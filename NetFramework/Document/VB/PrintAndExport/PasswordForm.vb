Imports System.IO

Public Class PasswordForm

    Public Function EnterPassword(fileName As String) As String
        label2.Text = String.Format("'{0}' is protected. Please enter a Document Open Password.", Path.GetFileName(fileName))
        ActiveControl = tbPassword
        If (ShowDialog() = DialogResult.OK) Then
            Return tbPassword.Text
        End If
        Return Nothing
    End Function

    Public Shared Function DoEnterPassword(fileName As String) As String
        Using f As PasswordForm = New PasswordForm()
            Return f.EnterPassword(fileName)
        End Using
    End Function

End Class