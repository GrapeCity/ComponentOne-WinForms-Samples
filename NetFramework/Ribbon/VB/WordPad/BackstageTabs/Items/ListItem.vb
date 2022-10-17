Public Class ListItem

    Private _defaultBackColor As Color = Color.FromArgb(243, 243, 243)
    Private _hotBackColor As Color = Color.FromArgb(198, 198, 198)
    Private _hotPressedBackColor As Color = Color.FromArgb(195, 195, 195)

    Public Property Item As RecentDocumentItem
    Public Event PinnedChanged As EventHandler

    Public Sub OnPinnedChanged()
        RaiseEvent PinnedChanged(Me, EventArgs.Empty)
    End Sub

    Private Sub MenuItem_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, pbPin.MouseDown, lblSubText.MouseDown, lblText.MouseDown, pbImage.MouseDown
        BackColor = _hotPressedBackColor
    End Sub

    Private Sub MenuItem_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, pbPin.MouseUp, lblSubText.MouseUp, lblText.MouseUp, pbImage.MouseUp
        BackColor = _hotBackColor
    End Sub

    Private Sub MenuItem_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseLeave, pbPin.MouseLeave, lblSubText.MouseLeave, lblText.MouseLeave, pbImage.MouseLeave
        BackColor = _defaultBackColor
        UpdatePinnedState()
    End Sub

    Private Sub MenuItem_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseEnter, pbPin.MouseEnter, lblSubText.MouseEnter, lblText.MouseEnter, pbImage.MouseEnter
        BackColor = _hotBackColor
        UpdatePinnedState(True)
    End Sub

    Private Sub pbPin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbPin.Click
        Item.Pinned = Not Item.Pinned
        OnPinnedChanged()
    End Sub

    Private Sub MenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblSubText.Click, lblText.Click, pbImage.Click
        OnClick(e)
    End Sub

    Public Sub SetItem(ByVal item As RecentDocumentItem, ByVal image As Image)
        Me.Item = item

        lblText.Text = item.Text
        lblSubText.Text = item.SubText
        pbImage.Image = image
        UpdatePinnedState()
    End Sub

    Private Sub UpdatePinnedState(ByVal Optional hot As Boolean = False)
        If Item.Pinned Then
            pbPin.Image = My.Resources.Pinnned_small
        ElseIf hot Then
            pbPin.Image = My.Resources.Pin_small
        Else
            pbPin.Image = Nothing
        End If

        pbPin.Invalidate()
    End Sub

    Private Sub ListItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = _defaultBackColor
    End Sub
End Class
