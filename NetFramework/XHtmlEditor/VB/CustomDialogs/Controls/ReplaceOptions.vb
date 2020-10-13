Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Friend Partial Class ReplaceOptions
	Inherits FindOptions
	Public Sub New()
		MyBase.New()
		InitializeComponent()

        AddHandler _btnReplace.Click, AddressOf _btnReplace_Click

        AddHandler _btnReplaceAll.Click, AddressOf _btnReplaceAll_Click

        _tbFindPattern_TextChanged(Me, EventArgs.Empty)
    End Sub

    Sub _btnReplace_Click(ByVal sender As Object, ByVal e As EventArgs)
        RaiseButtonReplaceClick()
    End Sub

    Sub _btnReplaceAll_Click(ByVal sender As Object, ByVal e As EventArgs)
        RaiseButtonReplaceAllClick()
    End Sub

    Private Sub _tbFindPattern_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        _btnReplace.Enabled = _btnFindNext.Enabled
        _btnReplaceAll.Enabled = _btnFindNext.Enabled
    End Sub

#Region "events"

    Public Event ButtonReplaceClick As EventHandler

    Protected Sub RaiseButtonReplaceClick()
        RaiseEvent ButtonReplaceClick(Me, EventArgs.Empty)
    End Sub

    Public Event ButtonReplaceAllClick As EventHandler

    Protected Sub RaiseButtonReplaceAllClick()
        RaiseEvent ButtonReplaceAllClick(Me, EventArgs.Empty)
    End Sub

#End Region

#Region "properties"

    Public ReadOnly Property ReplacePattern() As String
        Get
            Return _tbReplacePattern.Text.Trim()
        End Get
    End Property

#End Region
End Class

