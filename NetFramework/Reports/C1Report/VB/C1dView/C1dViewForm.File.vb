Imports System
Imports System.ComponentModel
Imports C1.C1Preview
Imports C1.C1Report
Imports C1.Win.C1Preview
Imports C1.Win.C1Ribbon
Imports C1.Win.C1Command

Partial Public Class C1dViewForm

    ''' <summary>
    ''' The number of fixed ribbon list items at the top of ribbon application menu's right panel
    ''' (the actual caption plus the delimiter).
    ''' </summary>
    Protected Const NFIXED As Integer = 2
    ''' <summary>
    ''' The number of recent documents to keep in the recent list.
    ''' </summary>
    Protected Const MAXRECENT As Integer = 10
    ''' <summary>
    ''' Offset of a newly opened window relative to the current one.
    ''' </summary>
    Protected ReadOnly NEW_WINDOW_OFFSET As Point = New Point(30, 10)
    ''' <summary>
    ''' Static list of recently opened file/report name pairs.
    ''' </summary>
    Protected Shared s_recentDocuments As List(Of Pair(Of String, String)) = New List(Of Pair(Of String, String))()
    ''' <summary>
    ''' Gets the list of recent reports/documents.
    ''' In each pair, First is the file name, and Second, if not null, is the report name.
    ''' </summary>
    Public Shared ReadOnly Property RecentDocuments As List(Of Pair(Of String, String))
        Get
            Return s_recentDocuments
        End Get
    End Property

    ''' <summary>
    ''' Subscribes to the ribbon application menu's DropDown event,
    ''' so that the recent documents list can be shown.
    ''' </summary>
    Protected Sub InitRecentDocuments()
        AddHandler Me.ramMain.DropDown, Sub(s, e) AddRecentDocumentsMenuItems()
    End Sub

    ''' <summary>
    ''' Creates and shows a new instance of <see cref="C1dViewForm"/>, and loads the specifed file into it.
    ''' If the file is the name of a report definition file, the report selection dialog is shown.
    ''' If the user cancels the dialog, or the file fails to open, the new window is closed.
    ''' </summary>
    ''' <param name="fileName">File to open, or null.</param>
    ''' <returns>The newly created window, or null if no file was loaded.</returns>
    Public Function FileNew(fileName As String) As C1dViewForm
        Dim p = Me.Location
        p.Offset(NEW_WINDOW_OFFSET)
        Dim window = New C1dViewForm()
        window.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        window.Location = p
        window.Size = Me.Size
        window.Show()
        If (Not String.IsNullOrEmpty(fileName)) Then
            window.cmdFileOpen.UserData = New Pair(Of String, String)(fileName, Nothing)
        End If
        window.cmdFileOpen.PerformClick()
        If (window.Document Is Nothing) Then
            window.cmdFileClose.PerformClick()
            Return Nothing
        Else
            Return window
        End If
    End Function

    ''' <summary>
    ''' Loads the specified file into the current window.
    ''' If <paramref name="fileName"/> is null or empty, file selection dialog is shown.
    ''' If <paramref name="reportName"/> is null or empty, report selection dialog is shown
    ''' if the file contains any report definitions.
    ''' Updates the recent file list.
    ''' </summary>
    ''' <param name="fileName">The file name (can be a report definition file, or a C1 document file).</param>
    ''' <param name="reportName">The report name (if <paramref name="fileName"/> is a report definition file).</param>
    Public Sub FileOpen(Optional ByVal fileName As String = Nothing, Optional ByVal reportName As String = Nothing)
        '' get a file name:
        If (String.IsNullOrEmpty(fileName)) Then
            '' Prepare file open dialog:
            Dim ofd = New OpenFileDialog()
            ofd.CheckFileExists = True
            '' Get the standard filter that handles .c1dx, .c1d, .c1db, .c1mdx extensions,
            '' add (at the top) .xml for opening reports:
            ofd.Filter = _
                "C1 Reports and Documents (*.xml;*.c1dx;*.c1d;*.c1db;*.c1mdx)|*.xml;*.c1dx;*.c1d;*.c1db;*.c1mdx" +
                "|C1 Reports (*.xml)|*.xml" +
                "|C1 Documents (*.c1dx;*.c1d;*.c1db;*.c1mdx)|*.c1dx;*.c1d;*.c1db;*.c1mdx" +
                "|C1 Open XML Documents (*.c1dx)|*.c1dx" +
                "|C1 Documents (*.c1d)|*.c1d" +
                "|C1 Binary Documents (*.c1db)|*.c1db" +
                "|C1 Open XML Multi Documents (*.c1mdx)|*.c1mdx" +
                "|All Files (*.*)|*.*"
            If (ofd.ShowDialog() <> DialogResult.OK) Then
                Return
            End If

            fileName = ofd.FileName
        End If

        '' get a report name if any (if the specified/selected file contains no reports,
        '' just pass it to the standard preview pane's FileOpen method to handle:
        If (String.IsNullOrEmpty(reportName)) Then
            Using rsd As ReportSelectDialog = New ReportSelectDialog()
                rsd.FileName = fileName
                If (rsd.HasReports) Then
                    If (rsd.ShowDialog(Me) <> DialogResult.OK) Then
                        Return
                    End If
                    fileName = rsd.FileName
                    reportName = rsd.ReportName
                End If
            End Using
        End If

        '' Open the report or document:
        Dim ok As Boolean

#If C1DVIEW_APP Then
        Dim openWindow = s_openWindows.Find(Function(f_) f_.FileName = fileName AndAlso f_.ReportName = reportName)
        If (openWindow IsNot Nothing) Then
            Dim focus As Action = Sub() openWindow.Activate()
            openWindow.BeginInvoke(focus)
            Return
        End If
#End If

        If (Not String.IsNullOrEmpty(reportName)) Then
            Try
                Dim rep = New C1Report()
                rep.Load(fileName, reportName)
                Me.Document = rep
                Me.Text = String.Format(WindowTitleFormat, reportName)
                ok = True

            Catch ex As Exception
                '' the next line should not be needed starting with C1Report 54625:
                Me.Document = Nothing
                '' show error (todo: make a dedicated method for error reporting):
                Dim err = If(ex.InnerException IsNot Nothing, ex.InnerException.Message, ex.Message)
                Dim msg = String.Format("Cannot open '{1}' (file '{0}')" & Environment.NewLine & "Error:" & Environment.NewLine & "{2}", fileName, reportName, err)
                MessageBox.Show(Me, msg, WindowTitle, MessageBoxButtons.OK, MessageBoxIcon.Error)
                ok = False
            End Try

        Else
            '' C1PreviewPane.FileOpen shows error messages itself:
            ok = Me.PreviewPane.FileOpen(fileName)
            If (ok) Then
                Me.Text = String.Format(WindowTitleFormat, fileName)
            End If
        End If
        If (ok) Then
            Me.FileName = fileName
            Me.ReportName = reportName
            '' add the report/document to the recent list:
            AddRecentDocument(fileName, reportName)
        Else
            '' remove junk:
            RemoveRecentDocument(fileName, reportName)
        End If
    End Sub

    ''' <summary>
    ''' Handles the close command.
    ''' If there are currently more than one C1dView windows open, closes the current window.
    ''' Otherwise (if the current window is the last one), just closes the loaded report or document, if any.
    ''' (This behavior is similar to MS Word and some other products.)
    ''' </summary> 
    Protected Sub FileClose()
        If (s_openWindows.Count > 1) Then
            Me.Close()
        Else
            Me.FileName = Nothing
            Me.ReportName = Nothing
            Me.Document = Nothing
            Me.Text = WindowTitle
            RefreshUI()
            Me.Invalidate(True)
        End If
    End Sub

    ''' <summary>
    ''' Closes all open windows.
    ''' </summary>
    Protected Sub FileExit()
        While (s_openWindows.Count > 0)
            s_openWindows.Last().Close()
        End While
    End Sub

    ''' <summary>
    ''' Handles the file open command.
    ''' <para>
    ''' The passed C1Command can be used to pass parameters:
    ''' If command.UserData is a pair of strings, the pair.First
    ''' is considered to be the file name, and pair.Second,
    ''' if not null, is considered to be the name of a report in that file.
    ''' If report name is specified, that report is loaded from the file.
    ''' Otherwise (if no report name given), the file is opened as a
    ''' previously saved C1 document or multi-document.
    ''' </para>
    ''' <para>
    ''' If command.UserData is null or not a pair, the method
    ''' shows a file open dialog and allows the user to choose a file to open.
    ''' </para>
    ''' <para>
    ''' The opened report or document is added to the recent documents' list.
    ''' The window title is updated.
    ''' </para>
    ''' </summary>
    ''' <param name="command">The command that can be used to pass parameters.</param>
    Protected Sub FileOpen(ByVal command As C1Command)
        '' check whether we were called with parameters (from the recent docs list):
        Dim pair = CType(command.UserData, Pair(Of String, String))
        '' reset user data for future calls:
        command.UserData = Nothing
        If (pair IsNot Nothing) Then
            FileOpen(pair.First, pair.Second)
        Else
            FileOpen()
        End If
    End Sub

    ''' <summary>
    ''' Builds the recent documents menu items (buttons) on the ribbon application menu.
    ''' Should be called from the ribbon application menu's DropDown event.
    ''' </summary>
    Protected Sub AddRecentDocumentsMenuItems()
        '' Clear any old items:
        While (ramMain.RightPaneItems.Count > NFIXED)
            ramMain.RightPaneItems.RemoveAt(NFIXED)
        End While

        '' add all recent docs to the menu:
        For Each pair As Pair(Of String, String) In RecentDocuments
            '' button for the new item:
            Dim rbtn = New RibbonButton()
            If (Not String.IsNullOrEmpty(pair.Second)) Then
                rbtn.Text = pair.Second
                rbtn.ToolTip = String.Format( _
                    "<table><tr><td>Report:</td><td><b>{1}</b></td></tr><tr><td>File:</td><td><b>{0}</b></td></tr></table>", _
                    pair.First, pair.Second)
            Else
                rbtn.Text = System.IO.Path.GetFileName(pair.First)
                rbtn.ToolTip = String.Format( _
                    "<table><tr><td>File:</td><td><b>{0}</b></td></tr></table>", _
                    pair.First)
            End If
            '' the list item:
            Dim rli = New RibbonListItem(rbtn)
            rli.Tag = pair
            AddHandler rli.Click, Sub(s, e)
                                      cmdFileOpen.UserData = CType(s, RibbonListItem).Tag
                                      cmdFileOpen.PerformClick()
                                      cmdFileOpen.UserData = Nothing '' cleanup
                                  End Sub
            '' done, add the new item:
            ramMain.RightPaneItems.Add(rli)
        Next
    End Sub

    ''' <summary>
    ''' Removes the specified report or document from <see cref="RecentDocuments"/>.
    ''' </summary>
    ''' <param name="fileName">The document or report file name.</param>
    ''' <param name="reportName">The report name.</param>
    Protected Shared Sub RemoveRecentDocument(ByVal fileName As String, ByVal reportName As String)
        '' avoid adding duplicates to the recent file list:
        RecentDocuments.RemoveAll(Function(p_) p_.First = fileName AndAlso p_.Second = reportName)
    End Sub

    ''' <summary>
    ''' Adds the specified report or document to <see cref="RecentDocuments"/>.
    ''' </summary>
    ''' <param name="fileName">The document or report file name.</param>
    ''' <param name="reportName">The report name.</param>
    Protected Shared Sub AddRecentDocument(ByVal fileName As String, ByVal reportName As String)
        '' avoid adding duplicates to the recent file list:
        RecentDocuments.RemoveAll(Function(p_) p_.First = fileName AndAlso p_.Second = reportName)

        '' Make room for the new item:
        If (RecentDocuments.Count >= MAXRECENT) Then
            RecentDocuments.RemoveRange(MAXRECENT - 1, RecentDocuments.Count - MAXRECENT + 1)
        End If

        '' Insert the new item at the top:
        RecentDocuments.Insert(0, New Pair(Of String, String)(fileName, reportName))
    End Sub

End Class
