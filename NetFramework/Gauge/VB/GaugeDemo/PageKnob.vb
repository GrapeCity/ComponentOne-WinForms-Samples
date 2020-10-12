Imports C1.Win.C1Gauge

Public Class PageKnob

    Private Sub c1RadialGauge1_PointerDragMove(ByVal sender As System.Object, ByVal e As PointerDragEventArgs) Handles c1RadialGauge1.PointerDragMove
        e.Pointer.Value = e.NewValue
    End Sub

End Class
