Partial Public Class Loader
    Inherits UserControl

    Public Sub New()
        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        SetStyle(ControlStyles.Opaque, True)
        InitializeComponent()
    End Sub


    Protected Overrides ReadOnly Property CreateParams As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.ExStyle = cp.ExStyle Or &H20
            Return cp
        End Get
    End Property

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim alpha = (50 * 255) / 100
        Dim frmColor As Drawing.Color = Parent.BackColor
        Dim Rb As Integer = BackColor.R * alpha / 255 + frmColor.R * (255 - alpha) / 255
        Dim Gb As Integer = BackColor.G * alpha / 255 + frmColor.G * (255 - alpha) / 255
        Dim Bb As Integer = BackColor.B * alpha / 255 + frmColor.B * (255 - alpha) / 255
        Dim color = Drawing.Color.FromArgb(Rb, Gb, Bb)
        Dim bounds As Rectangle = New Rectangle(0, 0, Width - 1, Height - 1)

        Using g = e.Graphics

            Using bckColor = New SolidBrush(Drawing.Color.FromArgb(alpha, color))
                g.FillRectangle(bckColor, bounds)
            End Using
        End Using

        MyBase.OnPaint(e)
    End Sub

    Protected Overrides Sub OnBackColorChanged(ByVal e As EventArgs)
        If Parent IsNot Nothing Then
            Parent.Invalidate(Bounds, True)
        End If

        MyBase.OnBackColorChanged(e)
    End Sub

    Protected Overrides Sub OnParentBackColorChanged(ByVal e As EventArgs)
        Invalidate()
        MyBase.OnParentBackColorChanged(e)
    End Sub

    Public Sub ShowLoader()
        Visible = True
        BringToFront()
    End Sub

    Public Sub HideLoader()
        Visible = False
        SendToBack()
    End Sub

    Private Sub Loader_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Timer1.Enabled = Visible
        C1RadialGauge1.Value = 0
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        C1RadialGauge1.Value = (C1RadialGauge1.Value + 4) Mod 104
    End Sub
End Class
