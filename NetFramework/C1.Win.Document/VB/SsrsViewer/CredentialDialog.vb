Imports System.Windows.Forms
Imports System.Net

Public Class CredentialDialog

    Public Function Login(ByVal owner As IWin32Window, ByVal path As String, ByVal nc As NetworkCredential) As NetworkCredential

        tbPath.Text = path
        If nc IsNot Nothing Then
            tbUser.Text = nc.UserName
            tbPassword.Text = nc.Password
            tbDomain.Text = nc.Domain
        End If
        ActiveControl = tbUser
        If ShowDialog(owner) <> System.Windows.Forms.DialogResult.OK Then
            Return Nothing
        End If
        Return New NetworkCredential(tbUser.Text, tbPassword.Text, tbDomain.Text)

    End Function

    Public Shared Function DoLogin(ByVal owner As IWin32Window, ByVal path As String, ByVal nc As NetworkCredential) As NetworkCredential

        Using f As New CredentialDialog()
            Return f.Login(owner, path, nc)
        End Using

    End Function

End Class