Imports System.Drawing
Imports System.Windows.Forms

Partial Public Class AppMenuTabButton
    Inherits UserControl

    Private _defaultBackColor As Color = Color.FromArgb(212, 212, 212)
    Private _hotBackColor As Color = Color.DarkGray
    Private _hotPressedBackColor As Color = Color.Gray

    Public Sub New()
        InitializeComponent()
        BackColor = _defaultBackColor
    End Sub

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

    Private Sub MenuItem_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbImage.MouseDown, lblText.MouseDown, MyBase.MouseDown
        BackColor = _hotPressedBackColor
    End Sub

    Private Sub MenuItem_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles pbImage.MouseUp, lblText.MouseUp, MyBase.MouseUp
        BackColor = _hotBackColor
    End Sub

    Private Sub MenuItem_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles pbImage.MouseLeave, lblText.MouseLeave, MyBase.MouseLeave
        BackColor = _defaultBackColor
    End Sub

    Private Sub MenuItem_MouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles pbImage.MouseEnter, lblText.MouseEnter, MyBase.MouseEnter
        BackColor = _hotBackColor
    End Sub

    Private Sub MenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pbImage.Click, lblText.Click
        OnClick(e)
    End Sub

End Class
