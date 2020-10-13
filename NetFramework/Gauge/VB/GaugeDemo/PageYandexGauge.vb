Imports C1.Win.C1Gauge

Public Class PageYandexGauge

    Private Sub c1RadialGauge1_ItemMouseMove(ByVal sender As System.Object, ByVal e As ItemMouseEventArgs) Handles c1RadialGauge1.ItemMouseMove, c1RadialGauge1.ItemMouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            Dim p As C1GaugePointer = e.Gauge.Pointer
            p.Value = p.GetValueAt(e.X, e.Y)
        End If
    End Sub

End Class
