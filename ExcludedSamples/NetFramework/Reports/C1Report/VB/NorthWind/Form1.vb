Imports C1.C1Report
Imports System.IO
Imports System.Xml

Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        '
        ' Prepare XML files in Sample dir
        '
        Dim i As Integer
        Dim j As Integer
        Dim files As String() = Directory.GetFiles(Application.StartupPath + "\..\Data", "*.xml")
        Dim xmlDoc As XmlDocument = New XmlDocument()
        Dim corrected As Boolean = False
        For i = 0 To files.Length - 1
            Dim file As String = files(i)
            Try
                xmlDoc.Load(file)
                ' select all ConnectionString nodes
                Dim nodes As XmlNodeList = xmlDoc.SelectNodes("Reports/Report/DataSource/ConnectionString")
                If (Not IsNothing(nodes)) Then
                    For j = 0 To nodes.Count - 1
                        Dim node As XmlNode = nodes(j)
                        Dim cs As String = CorrectConnectionString(node.InnerText)
                        If (String.Compare(cs, node.InnerText) <> 0) Then
                            node.InnerText = cs
                            corrected = True
                        End If
                    Next
                End If

                If (corrected) Then
                    xmlDoc.Save(file)
                End If
            Catch
            End Try
        Next
    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents ppv As C1.Win.C1Preview.C1PreviewPane
    Friend WithEvents tbbtnFirst As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnPrev As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnNext As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnLast As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnSep As System.Windows.Forms.ToolBarButton
    Friend WithEvents tbbtnZoom As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuZoom As System.Windows.Forms.ContextMenu
    Friend WithEvents mz100 As System.Windows.Forms.MenuItem
    Friend WithEvents mzPage As System.Windows.Forms.MenuItem
    Friend WithEvents mzTwoPages As System.Windows.Forms.MenuItem
    Friend WithEvents cmbReport As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents status As System.Windows.Forms.StatusBar
    Friend WithEvents mzThumnails As System.Windows.Forms.MenuItem

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents c1r As C1.C1Report.C1Report
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ppv = New C1.Win.C1Preview.C1PreviewPane()
        Me.ToolBar1 = New System.Windows.Forms.ToolBar()
        Me.tbbtnFirst = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnPrev = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnNext = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnLast = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnSep = New System.Windows.Forms.ToolBarButton()
        Me.tbbtnZoom = New System.Windows.Forms.ToolBarButton()
        Me.mnuZoom = New System.Windows.Forms.ContextMenu()
        Me.mz100 = New System.Windows.Forms.MenuItem()
        Me.mzPage = New System.Windows.Forms.MenuItem()
        Me.mzTwoPages = New System.Windows.Forms.MenuItem()
        Me.mzThumnails = New System.Windows.Forms.MenuItem()
        Me.cmbReport = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.status = New System.Windows.Forms.StatusBar()
        Me.c1r = New C1.C1Report.C1Report()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.ppv, Me.ToolBar1})
        Me.Panel1.Location = New System.Drawing.Point(10, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(543, 454)
        Me.Panel1.TabIndex = 4
        '
        'ppv
        '
        Me.ppv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ppv.Location = New System.Drawing.Point(0, 25)
        Me.ppv.Name = "ppv"
        Me.ppv.Size = New System.Drawing.Size(539, 425)
        Me.ppv.TabIndex = 6
        Me.ppv.ZoomFactor = 1
        '
        'ToolBar1
        '
        Me.ToolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.tbbtnFirst, Me.tbbtnPrev, Me.tbbtnNext, Me.tbbtnLast, Me.tbbtnSep, Me.tbbtnZoom})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(0, 22)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(539, 25)
        Me.ToolBar1.TabIndex = 5
        Me.ToolBar1.TextAlign = System.Windows.Forms.ToolBarTextAlign.Right
        Me.ToolBar1.Wrappable = False
        '
        'tbbtnFirst
        '
        Me.tbbtnFirst.Text = "<<"
        '
        'tbbtnPrev
        '
        Me.tbbtnPrev.Text = "<"
        '
        'tbbtnNext
        '
        Me.tbbtnNext.Text = ">"
        '
        'tbbtnLast
        '
        Me.tbbtnLast.Text = ">>"
        '
        'tbbtnSep
        '
        Me.tbbtnSep.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'tbbtnZoom
        '
        Me.tbbtnZoom.DropDownMenu = Me.mnuZoom
        Me.tbbtnZoom.Style = System.Windows.Forms.ToolBarButtonStyle.DropDownButton
        Me.tbbtnZoom.Text = "Zoom"
        '
        'mnuZoom
        '
        Me.mnuZoom.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mz100, Me.mzPage, Me.mzTwoPages, Me.mzThumnails})
        '
        'mz100
        '
        Me.mz100.Index = 0
        Me.mz100.Text = "100%"
        '
        'mzPage
        '
        Me.mzPage.Index = 1
        Me.mzPage.Text = "Full Page"
        '
        'mzTwoPages
        '
        Me.mzTwoPages.Index = 2
        Me.mzTwoPages.Text = "Two Pages"
        '
        'mzThumnails
        '
        Me.mzThumnails.Index = 3
        Me.mzThumnails.Text = "Thumbnails"
        '
        'cmbReport
        '
        Me.cmbReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReport.Location = New System.Drawing.Point(123, 10)
        Me.cmbReport.Name = "cmbReport"
        Me.cmbReport.Size = New System.Drawing.Size(276, 24)
        Me.cmbReport.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "&Select Report"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'status
        '
        Me.status.Location = New System.Drawing.Point(0, 512)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(563, 27)
        Me.status.TabIndex = 7
        Me.status.Text = "Ready"
        '
        'c1r
        '
        Me.c1r.ReportName = "C1Report1"
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(416, 10)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(120, 24)
        Me.btnSetup.TabIndex = 8
        Me.btnSetup.Text = "Page Setup"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(563, 539)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSetup, Me.Label1, Me.cmbReport, Me.Panel1, Me.status})
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1Report: NorthWind Reports"
        Me.Panel1.ResumeLayout(False)
        CType(Me.c1r, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function CorrectConnectionString(ByVal cs As String) As String
        If (IsNothing(cs)) Then
            Return cs
        End If

        '
        Dim i As Integer = cs.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase)
        If (i < 0) Then
            Return cs
        End If
        While (i < cs.Length And cs(i) <> "=")
            i = i + 1
        End While
        If (i >= cs.Length) Then
            Return cs
        End If

        Dim j As Integer = i
        While (i < cs.Length And cs(i) <> ";")
            i = i + 1
        End While

        '
        Dim mdbName As String = cs.Substring(j + 1, i - j - 1).Trim()
        If (mdbName.Length <= 0) Then
            Return cs
        End If
        mdbName = System.IO.Path.GetFileName(mdbName)
        If (String.Compare(mdbName, "nwind.mdb", True) = 0) Then
            mdbName = "c1nwind.mdb"
        End If

        '
        cs = cs.Substring(0, j + 1) + _
            Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
            "\ComponentOne Samples\Common\" + _
            mdbName + _
            cs.Substring(i)

        Return cs
    End Function

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick

        If e.Button Is tbbtnFirst Then
            ppv.StartPageIdx = 0
        ElseIf e.Button Is tbbtnLast Then
            ppv.StartPageIdx = 10000
        ElseIf e.Button Is tbbtnPrev Then
            ppv.StartPageIdx -= 1
        ElseIf e.Button Is tbbtnNext Then
            ppv.StartPageIdx += 1
        ElseIf e.Button Is Me.tbbtnZoom Then
            ppv.Rows = 1
            ppv.Cols = 1
            If ppv.ZoomFactor = 1 Then
                ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage
            Else
                ppv.ZoomFactor = 1
            End If
        End If

    End Sub

    Private Sub mz100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mz100.Click
        ppv.Rows = 1
        ppv.Cols = 1
        ppv.ZoomFactor = 1
    End Sub

    Private Sub mzPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mzPage.Click
        ppv.Rows = 1
        ppv.Cols = 1
        ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage
    End Sub

    Private Sub mzTwoPages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mzTwoPages.Click
        ppv.Rows = 1
        ppv.Cols = 2
        ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage
    End Sub

    Private Sub mzThumnails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mzThumnails.Click
        ppv.Rows = 3
        ppv.Cols = 5
        ppv.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage
    End Sub

    Private Sub c1r_EndPage(ByVal sender As System.Object, ByVal e As C1.C1Report.ReportEventArgs)
        status.Text = "Rendering page " & e.Page & " of " & cmbReport.Text
    End Sub

    Private Sub c1r_EndReport(ByVal sender As System.Object, ByVal e As System.EventArgs)
        status.Text = "Ready"
    End Sub

    '-----------------------------------------------------------------
    ' report definition file
    '
    Const DataFileName = "\Data\Nwind.xml"
    Dim m_ReportDefinitionFile As String

    '-----------------------------------------------------------------
    ' populate combo box with available reports
    '
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' get application path
        Dim appPath As String = Path.GetDirectoryName(Application.ExecutablePath).ToLower()
        Dim i As Integer = appPath.IndexOf("/bin")
        If (i < 0) Then i = appPath.IndexOf("\bin")
        If (i > 0) Then appPath = appPath.Remove(i, appPath.Length - i)


        ' get names of reports in the report definition file
        m_ReportDefinitionFile = appPath & DataFileName
        Dim reports As String() = c1r.GetReportInfo(m_ReportDefinitionFile)

        ' populate list box
        cmbReport.Items.Clear()
        Dim report As String
        For Each report In reports
            cmbReport.Items.Add(report)
        Next
    End Sub

    Private Sub cmbReport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReport.SelectedIndexChanged

        If cmbReport.SelectedIndex < 0 Then Exit Sub

        Try
            Cursor = Cursors.WaitCursor

            ' load report
            status.Text = "Loading " & cmbReport.Text
            c1r.Load(m_ReportDefinitionFile, cmbReport.Text)
            c1r.DataSource.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\ComponentOne Samples\Common\C1Nwind.mdb;Persist Security Info=False"
            ' render into print preview control
            status.Text = "Rendering " & cmbReport.Text
            Try
                c1r.Render()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            ppv.Document = c1r

            ' give focus to print preview control
            ppv.StartPageIdx = 0
            ppv.Focus()

        Finally
            Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click

        ' build page setup dialog
        Dim dlg As PageSetupDialog = New PageSetupDialog()
        dlg.PageSettings = c1r.Document.DefaultPageSettings

        ' show dialog
        If dlg.ShowDialog() = DialogResult.OK Then

            ' apply changes to report, render it again
            c1r.Layout.UpdateFromPrintDoc()
            ppv.Document = c1r
        End If

        ' done with the dialog
        dlg.Dispose()

    End Sub
End Class
