Imports C1.Win.C1Gauge

Public Class PageHypotrochoid

    Private Const _chainLength As Double = 25.0
    Private _value As Double = _chainLength

    Public Sub New()
        MyBase.New()

        InitializeComponent()
        c1LinearGauge1.MorePointers(0).Value = _value
        FillDecorators()

    End Sub

    Protected Overrides Sub OnTimer()
        _value += 2.0
        If _value > 100.0 Then
            _value = 0.0
        End If
        If _value <= _chainLength Then
            c1LinearGauge1.MorePointers(2).Value = _value
            c1LinearGauge1.MorePointers(1).Value = 100.0 + _value - _chainLength
            c1LinearGauge1.MorePointers(0).Value = Double.NaN
        Else
            c1LinearGauge1.MorePointers(2).Value = 0.0
            c1LinearGauge1.MorePointers(1).Value = _value - _chainLength
            c1LinearGauge1.MorePointers(0).Value = _value
        End If
    End Sub

    Private Sub FillDecorators()
        Dim x As Double = 0.0, y As Double = 0.0
        Dim x1 As Double = 0.0, y1 As Double = 0.0

        Dim cs As CommonShape = New CommonShape()
        cs.Name = "my arrow"
        cs.StartWidth = 2.5
        cs.EndAngle = 60.0
        cs.EndWidth = 2.5
        cs.EndSwellWidth = 1
        c1Gauge1.CommonShapes.Add(cs)

        Dim cm As CommonColorMap = New CommonColorMap()
        cm.Name = "my colors"
        cm.ValueColorFalloff = C1GaugeValueColorFalloff.None
        cm.ValueColors.Add(New C1GaugeValueColor(0.0, Color.SteelBlue, 1.0))
        cm.ValueColors.Add(New C1GaugeValueColor(Double.NaN, 2, Color.Transparent, 1.0))
        cm.ValueColors.Add(New C1GaugeValueColor(Double.NaN, 1, Color.SteelBlue, 1.0))
        cm.ValueColors.Add(New C1GaugeValueColor(Double.NaN, 0, Color.Transparent, 1.0))
        c1LinearGauge1.ColorMaps.Add(cm)

        c1Gauge1.BeginUpdate()
        For i As Int32 = 0 To 100 Step 2
            Dim mark As C1GaugeSingleMark = New C1GaugeSingleMark()
            mark.Border.Color = Color.LightSteelBlue
            mark.Filling.BrushType = C1GaugeBrushType.Gradient
            mark.Filling.Color2 = Color.LightSteelBlue
            mark.Gradient.Direction = C1GaugeGradientDirection.RadialOuter
            mark.CustomShape.CommonShapeName = "my arrow"
            mark.Length = 6
            mark.Width = 2.5
            mark.ColorMapName = "my colors"
            mark.Value = i

            GetXY(i, x, y)
            mark.Position = x * 0.01 + 0.5
            mark.Location = y + 50

            GetXY(i + 0.01, x1, y1)
            Dim l As Double = Math.Sqrt((x1 - x) * (x1 - x) + (y1 - y) * (y1 - y))
            Dim alpha As Double = Math.Asin((y1 - y) / l)
            If x1 < x Then
                alpha = Math.PI - alpha
            End If
            mark.ShapeAngle = -alpha * 180.0 / Math.PI + 90.0

            c1LinearGauge1.Decorators.Add(mark)
        Next i
        c1Gauge1.EndUpdate()
    End Sub

    Private Sub GetXY(ByVal a As Double, ByRef x As Double, ByRef y As Double)
        Const R As Double = 36.0
        Const rr As Double = 12.0
        Const h As Double = 30.0
        Dim phi As Double = a * Math.PI / 50.0
        Dim d As Double = R - rr
        Dim t As Double = d * phi / rr
        x = Math.Cos(phi) * d + Math.Cos(t) * h
        y = Math.Sin(phi) * d - Math.Sin(t) * h
    End Sub

End Class
