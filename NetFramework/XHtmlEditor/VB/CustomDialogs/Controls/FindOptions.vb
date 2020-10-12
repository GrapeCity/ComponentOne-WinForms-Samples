Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms

Friend Partial Class FindOptions
	Inherits UserControl
    Public Sub New()
        Me.components = Nothing
        Me.InitializeComponent()
        AddHandler Me._btnClose.Click, AddressOf CloseClick
        AddHandler Me._btnFindNext.Click, AddressOf FindNextClick

        Me._tbFindPattern_TextChanged(Me, EventArgs.Empty)
    End Sub


    Sub FindNextClick(ByVal sender As Object, ByVal e As EventArgs)
        Me.RaiseFindNextButonClick()
    End Sub

    Sub CloseClick(ByVal sender As Object, ByVal e As EventArgs)
        Me.RaiseCloseButtonClick()
    End Sub




    Private Sub _tbFindPattern_TextChanged(ByVal sender As Object, ByVal e As EventArgs)
        _btnFindNext.Enabled = SearchPattern.Length > 0
    End Sub

#Region "events"

    Public Event ButtonFindNextClick As EventHandler

    Protected Sub RaiseFindNextButonClick()
        RaiseEvent ButtonFindNextClick(Me, EventArgs.Empty)
    End Sub

    Public Event ButtonCloseClick As EventHandler

    Protected Sub RaiseCloseButtonClick()
        RaiseEvent ButtonCloseClick(Me, EventArgs.Empty)
    End Sub

#End Region

#Region "properties"

    Public Property MatchCase() As Boolean
        Get
            Return _chbMatchCase.Checked
        End Get
        Set(ByVal value As Boolean)
            _chbMatchCase.Checked = value
        End Set
    End Property

    Public Property MatchWholeWord() As Boolean
        Get
            Return _chbMatchWholeWord.Checked
        End Get
        Set(ByVal value As Boolean)
            _chbMatchWholeWord.Checked = value
        End Set
    End Property

    Public Property SearchUp() As Boolean
        Get
            Return _chbSearchUp.Checked
        End Get
        Set(ByVal value As Boolean)
            _chbSearchUp.Checked = value
        End Set
    End Property

    Public Property SearchPattern() As String
        Get
            Return _tbFindPattern.Text.Trim()
        End Get
        Set(ByVal value As String)
            _tbFindPattern.Text = value
        End Set
    End Property

    Public ReadOnly Property AcceptButton() As Button
        Get
            Return _btnFindNext
        End Get
    End Property

    Public ReadOnly Property CancelButton() As Button
        Get
            Return _btnClose
        End Get
    End Property

#End Region

#Region "public"

    Public Sub SetActiveControl()
        _tbFindPattern.[Select]()
    End Sub

#End Region
End Class
