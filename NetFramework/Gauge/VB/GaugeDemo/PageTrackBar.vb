Imports C1.Win.C1Gauge

Public Class PageTrackBar

    Private _pressedTick As Int64
    Private _pressedButton As Int32

    Private Sub c1LinearGauge1_PointerDragMove(ByVal sender As System.Object, ByVal e As PointerDragEventArgs) Handles c1LinearGauge1.PointerDragMove
        e.Pointer.UpdateValue(e.NewValue, 1.0)
    End Sub

    Protected Overrides Sub OnTimer()
        If _pressedButton > 0 Then
            Dim newTick As Int64 = DateTime.UtcNow.Ticks
            If newTick - _pressedTick > 3000000 Then
                If _pressedButton = 1 Then
                    c1LinearGauge1.Pointer.IncValue(-1, 5.0)
                Else
                    c1LinearGauge1.Pointer.IncValue(1, 5.0)
                End If
                _pressedTick += 2000000
            End If
        End If
    End Sub

    Private Sub c1LinearGauge1_ItemMouseUp(ByVal sender As System.Object, ByVal e As ItemMouseEventArgs) Handles c1LinearGauge1.ItemMouseUp
        If e.Button = MouseButtons.Left Then
            _pressedButton = 0
        End If
    End Sub

    Private Sub c1LinearGauge1_ItemMouseDown(ByVal sender As System.Object, ByVal e As ItemMouseEventArgs) Handles c1LinearGauge1.ItemMouseDown
        If e.Button = MouseButtons.Left Then
            Dim pointer As C1GaugePointer = c1LinearGauge1.Pointer
            If TypeOf e.Item Is C1GaugeRange Then
                pointer.Value = pointer.GetValueAt(e.X, e.Y)
            ElseIf TypeOf e.Item Is C1GaugeSingleMark Then
                Dim s As String = CType(e.Item, C1GaugeSingleMark).Name
                _pressedTick = DateTime.UtcNow.Ticks + 3000000
                If s = "minusButton" Then
                    If pointer.Value > 0.0 Then
                        pointer.IncValue(-1, 5.0)
                    Else
                        pointer.Value = Double.NaN
                    End If
                    _pressedButton = 1
                ElseIf s = "plusButton" Then
                    If Not Double.IsNaN(pointer.Value) Then
                        pointer.IncValue(1, 5.0)
                    Else
                        pointer.Value = 0.0
                    End If
                    _pressedButton = 2
                ElseIf s = "offMark" Then
                    pointer.Value = Double.NaN
                End If
            End If
        End If
    End Sub

    Private Sub c1LinearGauge1_ItemStateChanged(ByVal sender As System.Object, ByVal e As ItemEventArgs) Handles c1LinearGauge1.ItemStateChanged

        If TypeOf e.Item Is C1GaugePointer Then

            Dim po As C1GaugePointer = CType(e.Item, C1GaugePointer)
            c1Gauge1.BeginUpdate()
            If e.ItemHot Or e.ItemPressed Then
                po.Filling.CommonFillingName = "hotPointer"
            Else
                po.Filling.CommonFillingName = "normalPointer"
            End If
            c1Gauge1.EndUpdate(200)

        ElseIf TypeOf e.Item Is C1GaugeSingleMark Then
            Dim sm As C1GaugeSingleMark = CType(e.Item, C1GaugeSingleMark)
            If sm.Name = "minusButton" Or sm.Name = "plusButton" Then

                c1Gauge1.BeginUpdate()
                If e.ItemPressed Then
                    sm.Filling.CommonFillingName = "pressedButton"
                ElseIf e.ItemHot Then
                    sm.Filling.CommonFillingName = "hotButton"
                Else
                    sm.Filling.CommonFillingName = "normalButton"
                End If
                If e.ItemPressed Then
                    sm.Gradient.CommonGradientName = "pressed"
                Else
                    sm.Gradient.CommonGradientName = "normal"
                End If
                c1Gauge1.EndUpdate(200)

            End If
        End If

    End Sub

End Class
