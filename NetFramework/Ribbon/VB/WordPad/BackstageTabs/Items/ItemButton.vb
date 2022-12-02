Public Class ItemButton

    Private _defaultBackColor As Color = Color.FromArgb(243, 243, 243)
    Private _hotBackColor As Color = Color.FromArgb(198, 198, 198)
    Private _hotPressedBackColor As Color = Color.FromArgb(195, 195, 195)

    Public Property ItemImage As Image
        Get
            Return pbImage.Image
        End Get
        Set(ByVal value As Image)
            pbImage.Image = value
        End Set
    End Property

    Public Property ItemText As String
        Get
            Return lblText.Text
        End Get
        Set(ByVal value As String)
            lblText.Text = value
        End Set
    End Property

    Private Sub MenuItem_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseDown, pbImage.MouseDown, lblText.MouseDown
        BackColor = _hotPressedBackColor
    End Sub

    Private Sub MenuItem_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp, pbImage.MouseUp, lblText.MouseUp
        BackColor = _hotBackColor
    End Sub

    Private Sub MenuItem_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseLeave, pbImage.MouseLeave, lblText.MouseLeave
        BackColor = _defaultBackColor
    End Sub

    Private Sub MenuItem_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.MouseEnter, pbImage.MouseEnter, lblText.MouseEnter
        BackColor = _hotBackColor
    End Sub

    Private Sub MenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbImage.Click, lblText.Click
        Me.OnClick(EventArgs.Empty)
    End Sub

    Private Sub ItemButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BackColor = _defaultBackColor
    End Sub
End Class
