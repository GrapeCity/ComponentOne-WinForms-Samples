Imports C1.Win.Gauge

Public Class PageInteractive

    Private Sub c1RadialGauge1_ItemMouseMove(ByVal sender As System.Object, ByVal e As ItemMouseEventArgs) Handles C1RadialGauge1.ItemMouseMove, C1RadialGauge1.ItemMouseDown
        If TypeOf e.Item Is C1GaugeEllipse AndAlso (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            Dim el As C1GaugeEllipse = CType(e.Item, C1GaugeEllipse)
            If el.Name = "back" Then
                Dim p As C1GaugePointer = e.Gauge.Pointer
                p.UpdateValue(p.GetValueAt(e.X, e.Y), 2.5)
            End If
        End If
    End Sub

    Private Sub c1RadialGauge1_FormatLabel(ByVal sender As System.Object, ByVal e As FormatLabelEventArgs) Handles C1RadialGauge1.FormatLabel
        If Double.IsNaN(e.Value) Then
            e.Text = "Off"
        End If
    End Sub

End Class
