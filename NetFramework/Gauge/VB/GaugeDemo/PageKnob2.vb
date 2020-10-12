Imports C1.Win.C1Gauge

Public Class PageKnob2

    Private _lastV1 As Int32
    Private _lastV2 As Int32
    Private _v As Int32

    Private Sub DoStep(ByVal stepCount As Int32)
        _v += stepCount
        Dim vLabel As C1GaugeCaption = CType(c1Gauge1.CoverShapes(0), C1GaugeCaption)
        vLabel.Text = _v.ToString()
    End Sub

    Private Sub c1RadialGauge1_PointerDragMove(ByVal sender As System.Object, ByVal e As C1.Win.C1Gauge.PointerDragEventArgs) Handles c1RadialGauge1.PointerDragMove
        SetNewValue1(e.NewValue)
    End Sub

    Private Sub SetNewValue1(ByVal newValue As Double)
        Dim min As Double = c1RadialGauge1.Minimum
        Dim max As Double = c1RadialGauge1.Maximum
        Dim alpha As Double = (newValue - min) / (max - min)
        If alpha < 0.33 Then
            c1RadialGauge1.Minimum = min - 18
            c1RadialGauge1.Maximum = max - 18
        ElseIf alpha > 0.66 Then
            c1RadialGauge1.Maximum = max + 18
            c1RadialGauge1.Minimum = min + 18
        End If
        c1RadialGauge1.Pointer.UpdateValue(newValue, 1.0)
        Dim v As Int32 = Convert.ToInt32(c1RadialGauge1.Pointer.Value)
        If v <> _lastV1 Then
            DoStep(v - _lastV1)
            _lastV1 = v
        End If
    End Sub

    Private Sub c1RadialGauge2_PointerDragMove(ByVal sender As System.Object, ByVal e As C1.Win.C1Gauge.PointerDragEventArgs) Handles c1RadialGauge2.PointerDragMove
        SetNewValue2(e.NewValue)
    End Sub

    Private Sub SetNewValue2(ByVal newValue As Double)
        Dim min As Double = c1RadialGauge2.Minimum
        Dim max As Double = c1RadialGauge2.Maximum
        Dim alpha As Double = (newValue - min) / (max - min)
        If alpha < 0.33 Then
            c1RadialGauge2.Minimum = min - 36
            c1RadialGauge2.Maximum = max - 36
        ElseIf alpha > 0.66 Then
            c1RadialGauge2.Maximum = max + 36
            c1RadialGauge2.Minimum = min + 36
        End If
        c1RadialGauge2.Pointer.UpdateValue(newValue, 1.0)
        Dim v As Int32 = Convert.ToInt32(c1RadialGauge2.Pointer.Value)
        If v <> _lastV2 Then
            DoStep((v - _lastV2) * 10)
            _lastV2 = v
        End If
    End Sub

    Private Sub c1Gauge1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles c1Gauge1.KeyDown
        If e.KeyCode = Keys.Insert Then
            SetNewValue2(c1RadialGauge2.Pointer.Value + 1.0)
        ElseIf e.KeyCode = Keys.Delete Then
            SetNewValue2(c1RadialGauge2.Pointer.Value - 1.0)
        ElseIf e.KeyCode = Keys.PageUp Then
            SetNewValue1(c1RadialGauge1.Pointer.Value + 1.0)
        ElseIf e.KeyCode = Keys.PageDown Then
            SetNewValue1(c1RadialGauge1.Pointer.Value - 1.0)
        End If
    End Sub
End Class
