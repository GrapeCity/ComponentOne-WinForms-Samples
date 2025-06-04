Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.Net
Imports System.Threading
Imports System.Runtime.CompilerServices

Imports C1.Document
Imports C1.Win.Ribbon
Imports C1.Ssrs

Imports C1.Win.FlexViewer
Imports C1.ImportServices.ReportingService4

Public Class MainForm

    Private Delegate Function RequestCredentialDelegate(ByVal path As String, ByVal credential As NetworkCredential) As NetworkCredential

    Private _reportServer As String
    Private _credential As NetworkCredential
    Private _requestCredentialDelegate As RequestCredentialDelegate

    Private _rbConnection As RibbonToggleButton

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        UpdateLayout()
        c1FlexViewer1.ParamPanelAlignment = FlexViewerPanelAlignment.Far

        tbSSRSServer.Text = "http://ssrs.componentone.com:8000/ReportServer"
        tbUserName.Text = "ssrs_demo"
        tbPassword.Text = "bjqveS5gh89BH1Q"

        _requestCredentialDelegate = AddressOf RequestCredential
        UpdateControls()

    End Sub

    Private Sub UpdateLayout()
        Dim resources = New ComponentResourceManager(GetType(MainForm))

        _rbConnection = New RibbonToggleButton()
        _rbConnection.Pressed = True
        _rbConnection.SmallImage = ilMain.Images(3)
        _rbConnection.Text = "SSRS Server && Reports"
        AddHandler _rbConnection.PressedChanged, AddressOf ConnectionButton_PressedChanged

        Dim ribbon = c1FlexViewer1.Ribbon
        ribbon.QatItemsHolder.Insert(0, _rbConnection)
        ribbon.Qat.Items.Insert(0, _rbConnection)
        ribbon.Qat.MenuItems.Insert(0, _rbConnection)

        connPanel.Parent = Nothing
        spMain.Parent = Nothing

        Dim cc = c1FlexViewer1.Controls
        Dim c1 = cc(0)
        Dim c2 = cc(1)
        Dim c3 = cc(2)
        cc.Clear()

        cc.Add(c1)
        cc.Add(spMain)
        cc.Add(connPanel)
        cc.Add(c2)
        cc.Add(c3)
    End Sub

    Private Sub UpdateControls()

        Dim treeNode = tvReports.SelectedNode
        Dim showReportEnabled As Boolean = False
        If treeNode IsNot Nothing AndAlso Not c1SsrsDocumentSource1.IsBusy AndAlso Not c1SsrsDocumentSource1.IsDisposed Then
            Dim ci = TryCast(treeNode.Tag, CatalogItem)
            If ci IsNot Nothing AndAlso ci.Type = ItemTypeEnum.Report Then
                showReportEnabled = True
            End If
        End If
        btnShowReport.Enabled = showReportEnabled
        btnHideReport.Enabled = c1FlexViewer1.DocumentSource IsNot Nothing

    End Sub

    Private Function ExceptionToString(ByVal ex As Exception) As String

        Return If(ex Is Nothing, "NULL", ex.Message)

    End Function

    Private Function GetCredential() As NetworkCredential

        Return New NetworkCredential(tbUserName.Text, tbPassword.Text, tbDomain.Text)

    End Function

    Private Function RequestCredential(ByVal path As String, ByVal nc As NetworkCredential) As NetworkCredential

        Dim result As NetworkCredential = CredentialDialog.DoLogin(Me, path, nc)
        If result Is Nothing Then
            Return Nothing
        End If
        tbUserName.Text = result.UserName
        tbPassword.Text = result.Password
        tbDomain.Text = result.Domain
        Return result

    End Function

    Private Sub ConnectionButton_PressedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim panelVisible As Boolean = _rbConnection.Pressed
        connPanel.Visible = panelVisible
        spMain.Visible = panelVisible

    End Sub

    Private Sub PreviewPane_PropertyChanged(ByVal sender As System.Object, ByVal e As PropertyChangedEventArgs) Handles c1FlexViewer1.PropertyChanged

        If e.PropertyName = "Document" Then
            UpdateControls()
        End If

    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click

        btnOpen.Enabled = False
        tvReports.ShowRootLines = False
        tvReports.Nodes.Clear()
        Dim node = tvReports.Nodes.Add("Loading...")
        node.ImageIndex = 2
        node.SelectedImageIndex = 2

        bwListReports.RunWorkerAsync(New ListReportsArgs With {.Form = Me, .Credential = GetCredential(), .ReportServer = tbSSRSServer.Text})

    End Sub

    Structure ListReportsArgs

        Public ReportServer As String
        Public Credential As NetworkCredential
        Public Form As MainForm

    End Structure

    Private Sub bwListReports_DoWork(ByVal sender As System.Object, ByVal e As DoWorkEventArgs) Handles bwListReports.DoWork

        Dim lra = DirectCast(e.Argument, ListReportsArgs)

        Dim items As CatalogItem() = Nothing
        Dim nc As NetworkCredential = lra.Credential
        While (True)

            Try
                Using rs As New ServerConnection()

                    rs.SetConnectionOptions(lra.ReportServer, New ConnectionOptions(nc))
                    items = rs.ListChildren("/", True, CancellationToken.None)
                    Dim sortedItems = From itm In items
                                      Where itm.Type = ItemTypeEnum.Folder _
                                          OrElse itm.Type = ItemTypeEnum.Report
                                      Order By itm.Type, itm.Path, itm.Name
                                      Select itm

                    e.Result = New ListReportsResult With {.Items = sortedItems, .Credential = nc, .ReportServer = lra.ReportServer}
                    Return

                End Using

            Catch ex As C1.Ssrs.SecurityException

                ' request credential
                nc = TryCast(Invoke(_requestCredentialDelegate, ex.Path, nc), NetworkCredential)
                If nc IsNot Nothing Then
                    Continue While
                End If
                e.Cancel = True
                Return

            Catch ex As Exception

                e.Result = New ListReportsResult With {.ErrorMessage = String.Format("Could not connect to the server." +
                                                                                     Environment.NewLine + Environment.NewLine + "{0}", ex.Message)}
                Return

            End Try

        End While

    End Sub

    Private Class ListReportsResult

        Public ReportServer As String
        Public Credential As NetworkCredential
        Public Items As IEnumerable(Of CatalogItem)
        Public ErrorMessage As String

    End Class

    Private Sub bwListReports_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As RunWorkerCompletedEventArgs) Handles bwListReports.RunWorkerCompleted

        tvReports.Nodes.Clear()
        tvReports.ShowRootLines = True
        btnOpen.Enabled = True

        If e.Cancelled Then
            Return
        End If
        Dim lrr As ListReportsResult = TryCast(e.Result, ListReportsResult)
        If lrr Is Nothing Then
            Return
        End If
        If lrr.ErrorMessage IsNot Nothing Then
            MessageBox.Show(Me, lrr.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        _reportServer = lrr.ReportServer
        _credential = lrr.Credential
        AddItems(tvReports.Nodes, lrr.Items)

    End Sub

    Private Sub AddItems(ByVal nodes As TreeNodeCollection, ByVal allItems As IEnumerable(Of CatalogItem), Optional ByVal level As Int32 = 1)

        Dim items = allItems.Where(Function(itm) Not itm.Hidden AndAlso (itm.Type = ItemTypeEnum.Report OrElse itm.Type = ItemTypeEnum.Folder))

        For Each item As CatalogItem In items.Where(Function(itm) itm.Path.Count(Function(c) c = "/"c) = level)

            If item.Type = ItemTypeEnum.Folder Then
                Dim itemPath = item.Path + "/" 'make sure two folders like "/A" and "/AAA" won't be mixed up
                Dim subItems = items.Where(Function(itm) itm.Path.StartsWith(itemPath) AndAlso (itm.Path.Count(Function(c) c = "/"c) = level + 1))

                If subItems.Any() Then
                    Dim tn As TreeNode = nodes.Add(item.Name)
                    tn.Tag = item
                    tn.SelectedImageIndex = 0
                    tn.ImageIndex = 0
                    AddItems(tn.Nodes, subItems, level + 1)
                End If
            Else

                Dim tn As TreeNode = nodes.Add(item.Name)
                tn.Tag = item
                tn.SelectedImageIndex = 1
                tn.ImageIndex = 1

            End If

        Next

    End Sub

    Private Sub btnHideReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHideReport.Click

        If c1SsrsDocumentSource1.IsBusy OrElse c1SsrsDocumentSource1.IsDisposed Then
            Return
        End If
        btnHideReport.Enabled = False
        c1FlexViewer1.DocumentSource = Nothing
        tvReports.Focus()

    End Sub

    Private Sub btnShowReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowReport.Click

        If c1SsrsDocumentSource1.IsBusy OrElse c1SsrsDocumentSource1.IsDisposed Then
            Return
        End If
        Dim node As TreeNode = tvReports.SelectedNode
        If node Is Nothing Then
            Return
        End If
        Dim ci As CatalogItem = TryCast(node.Tag, CatalogItem)
        If ci Is Nothing OrElse ci.Type <> ItemTypeEnum.Report Then
            Return
        End If

        btnHideReport.Enabled = True
        c1SsrsDocumentSource1.Credential = _credential
        c1SsrsDocumentSource1.DocumentLocation = New SSRSReportLocation(_reportServer, ci.Path)
        c1FlexViewer1.DocumentSource = c1SsrsDocumentSource1
        c1FlexViewer1.Pane.Focus()

    End Sub

    Private Sub tvReports_AfterSelect(ByVal sender As System.Object, ByVal e As TreeViewEventArgs) Handles tvReports.AfterSelect

        UpdateControls()

    End Sub

    Private Sub tvReports_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tvReports.DoubleClick

        btnShowReport_Click(btnShowReport, EventArgs.Empty)

    End Sub

    Private Sub SsrsDocumentSource_BusyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1SsrsDocumentSource1.BusyStateChanged

        Me.Invoke(Sub() UpdateControls())

    End Sub

    Private Sub SsrsDocumentSource_PageCountChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1SsrsDocumentSource1.PageCountChanged

        Me.Invoke(Sub() UpdateControls())

    End Sub

    Private Sub SsrsDocumentSource_SecurityError(ByVal sender As System.Object, ByVal e As SecurityErrorEventArgs) Handles c1SsrsDocumentSource1.SecurityError

        Me.Invoke(New SecurityErrorEventHandler(Sub(s, ea)

                                                    Dim ds As C1DocumentSource = DirectCast(s, C1DocumentSource)
                                                    Dim nc As NetworkCredential = RequestCredential(ea.Path, ds.Credential)
                                                    If nc Is Nothing Then
                                                        Return
                                                    End If
                                                    ds.Credential = nc
                                                    ea.Retry = True
                                                End Sub
            ), sender, e)

    End Sub

End Class
