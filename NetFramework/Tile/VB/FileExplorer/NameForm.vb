Public Class NameForm

    Private Sub okButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles okButton.Click

        Dim s As String = nameBox.Text.Trim()
        If s.Length = 0 Then
            MessageBox.Show("Name can't be empty.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Me.DialogResult = System.Windows.Forms.DialogResult.OK

    End Sub

    Public Shared Function GetFolderName() As String

        Dim res As String = Nothing
        Dim nf As NameForm = New NameForm()
        If nf.ShowDialog() = DialogResult.OK Then
            res = nf.nameBox.Text
        End If
        nf.Dispose()
        Return res

    End Function

    Public Shared Function RenameItem(ByVal oldName As String, ByVal title As String, ByVal prompt As String) As String

        Dim res As String = Nothing
        Dim nf As NameForm = New NameForm()
        nf.Text = title
        nf.nameLabel.Text = prompt
        nf.nameBox.Text = oldName
        If nf.ShowDialog() = DialogResult.OK Then
            res = nf.nameBox.Text
        End If
        nf.Dispose()
        Return res

    End Function

End Class