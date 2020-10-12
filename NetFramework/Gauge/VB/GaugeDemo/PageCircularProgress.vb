Public Class PageCircularProgress

    Public Sub New()
        MyBase.New()

        InitializeComponent()

        trackBar1.Value = CType(c1RadialGauge1.MorePointers(0).Value + 0.5, Int32)
        trackBar2.Value = CType(c1RadialGauge1.MorePointers(1).Value + 0.5, Int32)
        trackBar3.Value = CType(c1RadialGauge1.MorePointers(2).Value + 0.5, Int32)
    End Sub

    Private Sub trackBar1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackBar1.ValueChanged
        c1RadialGauge1.MorePointers(0).Value = trackBar1.Value
    End Sub

    Private Sub trackBar2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackBar2.ValueChanged
        c1RadialGauge1.MorePointers(1).Value = trackBar2.Value
    End Sub

    Private Sub trackBar3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trackBar3.ValueChanged
        c1RadialGauge1.MorePointers(2).Value = trackBar3.Value
    End Sub
End Class
