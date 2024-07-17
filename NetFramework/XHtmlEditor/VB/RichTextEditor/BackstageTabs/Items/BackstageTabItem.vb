
Imports System.Drawing
Imports System.Windows.Forms
Imports RichTextEditor.RichTextEditor

Partial Public Class BackstageTabItem
    Inherits UserControl

    Private _defaultBackColor As Color = Color.FromArgb(212, 212, 212)

    Private _hotBackColor As Color = Color.DarkGray

    Private _hotPressedBackColor As Color = Color.Gray

    Private _item As RecentDocumentItem

    Public Sub New()
        InitializeComponent()
        BackColor = _defaultBackColor
    End Sub

    Public ReadOnly Property Item As RecentDocumentItem
        Get
            Return _item
        End Get
    End Property

    Public Event PinnedChanged As EventHandler

    Public Sub OnPinnedChanged()
        RaiseEvent PinnedChanged(Me, New EventArgs())
    End Sub

    Private Sub MenuItem_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbImage.MouseDown, pbPin.MouseDown, lblText.MouseDown, lblSubText.MouseDown, MyBase.MouseDown
        BackColor = _hotPressedBackColor
    End Sub

    Private Sub MenuItem_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbImage.MouseUp, pbPin.MouseUp, lblText.MouseUp, lblSubText.MouseUp, MyBase.MouseUp
        BackColor = _hotBackColor
    End Sub

    Private Sub MenuItem_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbImage.MouseLeave, pbPin.MouseLeave, lblText.MouseLeave, lblSubText.MouseLeave, MyBase.MouseLeave
        BackColor = _defaultBackColor
        UpdatePinnedState()
    End Sub

    Private Sub MenuItem_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pbImage.MouseEnter, pbPin.MouseEnter, lblText.MouseEnter, lblSubText.MouseEnter, MyBase.MouseEnter
        BackColor = _hotBackColor
        UpdatePinnedState(True)
    End Sub

    Private Sub pbPin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbPin.Click
        Item.Pinned = Not Item.Pinned
        OnPinnedChanged()
    End Sub

    Private Sub MenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbImage.Click, lblText.Click, lblSubText.Click
        OnClick(e)
    End Sub

    Public Sub SetItem(ByVal item As RecentDocumentItem, ByVal image As Image)
        _item = item
        lblText.Text = item.Text
        lblSubText.Text = item.SubText
        pbImage.Image = image
        UpdatePinnedState()
    End Sub

    Private Sub UpdatePinnedState(ByVal Optional hot As Boolean = False)
        If Item.Pinned Then
            pbPin.Image = Resources.Pinnned_small
        ElseIf hot Then
            pbPin.Image = Resources.Pin_small
        Else
            pbPin.Image = Nothing
        End If

        pbPin.Invalidate()
    End Sub
End Class