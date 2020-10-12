Public Class PageSlidingScale

    Private Sub c1RadialGauge1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles c1RadialGauge1.ValueChanged
        Dim v As Double = c1RadialGauge1.Value
        c1RadialGauge1.Minimum = v - 15.0
        c1RadialGauge1.Maximum = v + 15.0
    End Sub

    Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar1.ValueChanged
        c1RadialGauge1.Value = trackBar1.Value * 0.25
    End Sub

End Class
