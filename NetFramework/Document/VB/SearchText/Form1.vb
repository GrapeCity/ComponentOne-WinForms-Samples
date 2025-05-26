Imports System
Imports System.IO
Imports C1.Document

Imports C1.Win.C1Document

Public Class Form1
    ''' <summary>
    ''' File name of the currently loaded document.
    ''' </summary>
    Dim _loadedFile As String = Nothing
    ''' <summary>
    ''' C1TextSearchManager instance used by the search.
    ''' </summary>
    Dim _textSearchManager As C1TextSearchManager

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Use sample file:
        tbFile.Text = Path.GetFullPath("DefaultDocument.pdf")

        ' Create and initialize the C1TextSearchManager:
        _textSearchManager = New C1TextSearchManager(c1PdfDocumentSource1)
        AddHandler _textSearchManager.FindActionCompleted, AddressOf _textSearchManager_FindActionCompleted
        AddHandler _textSearchManager.FoundPositionsChanged, AddressOf _textSearchManager_FoundPositionsChanged
        AddHandler _textSearchManager.LongOperation, AddressOf _textSearchManager_LongOperation

        '
        UpdateControls()
    End Sub

    ''' <summary>
    ''' 
    ''' Long operation handler is periodically called by C1TextSearchManager.
    '''Use it to update progress bar with an approximate progress value.
    '''Note that because we use async methods on C1TextSearchManager,
    ''' its event handlers run in a non-UI worker thread,
    ''' so we need to use the Invoke mechanism to update the UI.
    ''' </summary>
    ''' <param name="sender">The event sender (C1TextSearchManager).</param>
    ''' <param name="e">Event arguments.</param>
    Private Sub _textSearchManager_LongOperation(ByVal sender As Object, ByVal e As C1.Document.LongOperationEventArgs)
        Invoke(Sub() pbFind.Value = Math.Round(e.Complete * pbFind.Maximum))
    End Sub

    Private Sub _textSearchManager_FoundPositionsChanged(sender As Object, e As EventArgs)
        Invoke(Sub()
                   Dim n As Integer = _textSearchManager.FoundPositions.Count
                   For i = lvFoundPositions.Items.Count To n - 1
                       Dim fp As C1FoundPosition = _textSearchManager.FoundPositions(i)
                       Dim Bounds = fp.GetBounds()
                       Dim lvi = New ListViewItem(
                        New String() {
                        (i + 1).ToString(),
                        fp.GetPage().PageNo.ToString(),
                        String.Format("{0}, {1}, {2}, {3}", CInt(Math.Round(Bounds.Left)), CInt(Math.Round(Bounds.Top)), CInt(Math.Round(Bounds.Width)), CInt(Math.Round(Bounds.Height))),
                        fp.PositionInNearText.ToString(),
                        fp.NearText
                        })
                       lvFoundPositions.Items.Add(lvi)
                   Next
               End Sub
            )
    End Sub

    ''' <summary>
    ''' Called when the FoundPositions collection on the C1TextSearchManager has changed
    ''' (i.e. some New instances of the search text were found).
    ''' Use this to update the list of the found positions in our UI (via invoke).
    ''' </summary>
    ''' <param name="sender">The event sender (C1TextSearchManager).</param>
    ''' <param name="e">Event arguments.</param>
    Private Sub _textSearchManager_FindActionCompleted(sender As Object, e As FindActionCompletedEventArgs)
        Invoke(Sub()
                   UpdateControls()
                   pbFind.Visible = False
               End Sub
            )
    End Sub

    ''' <summary>
    ''' Called when the search is finished.
    ''' Update controls (via invoke), hide the progress bar.
    ''' </summary>
    Private Sub UpdateControls()
        Dim enabled = Not String.IsNullOrEmpty(tbFindText.Text) And Not _textSearchManager.IsSearching()
        btnFind.Enabled = enabled
    End Sub

    ''' <summary>
    ''' Allow the user to choose a PDF file to search.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        If (openFileDialog1.ShowDialog(Me) = DialogResult.OK) Then
            tbFile.Text = openFileDialog1.FileName
        End If
    End Sub

    ''' <summary>
    ''' Start the text search asynchronously.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        If (String.IsNullOrEmpty(tbFile.Text)) Then
            MessageBox.Show(Me, "Please select a PDF file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (Not File.Exists(tbFile.Text)) Then
            MessageBox.Show(Me, String.Format("File ""{0}"" does not exist.", tbFile.Text), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If (String.Compare(_loadedFile, tbFile.Text, True) <> 0) Then
            ' Load the specified PDF file into c1PdfDocumentSource1.
            ' The loop allows the user to specify a password for an encrypted file.
            While (True)
                Try
                    c1PdfDocumentSource1.LoadFromFile(tbFile.Text)
                    _loadedFile = tbFile.Text
                    Exit While
                Catch pex As C1.Document.PdfPasswordException
                    Dim password As String = PasswordForm.DoEnterPassword(tbFile.Text)
                    If (password Is Nothing) Then
                        Return
                    End If
                    c1PdfDocumentSource1.Credential.Password = password
                Catch ex As Exception
                    MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            End While
        End If

        ' Clear the previously found positions, if any, And start the search.
        ' Note the use of the FindStartAsync version of the FindStart method (a synchronous version Is also available)
        lvFoundPositions.Items.Clear()
        Dim ftp = New C1FindTextParams(tbFindText.Text, cbxWholeWord.Checked, cbxCaseSensitive.Checked)
        If (rbWholeDocument.Checked) Then
            _textSearchManager.FindStartAsync(0, SearchScope.WholeDocument, ftp, False)
        Else
            Dim pageNum = CInt(nudPageIndex.Value)
            If (pageNum < 1 Or pageNum > c1PdfDocumentSource1.PageCount) Then
                MessageBox.Show(String.Format("Page should be from 0 to {0}.", c1PdfDocumentSource1.PageCount), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                _textSearchManager.FindStartAsync(pageNum - 1, SearchScope.SinglePage, ftp, False)
            End If
        End If

        ' Update controls and show the progress bar:
        UpdateControls()
        pbFind.Value = 0
        pbFind.Visible = True
    End Sub

    ''' <summary>
    ''' Update controls when the search text changes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbFindText_TextChanged(sender As Object, e As EventArgs) Handles tbFindText.TextChanged
        UpdateControls()
    End Sub
End Class
