Imports C1.Win.Gauge

Public Class PageLituus

    Public Sub New()
        MyBase.New()

        InitializeComponent()
        FillDecorators()

    End Sub

    Private Sub FillDecorators()
        Dim x As Double = 0.0, y As Double = 0.0
        Dim x1 As Double = 0.0, y1 As Double = 0.0

        c1Gauge1.BeginUpdate()

        Dim cm As CommonColorMap = New CommonColorMap()
        cm.Name = "green"
        cm.ValueColorFalloff = C1GaugeValueColorFalloff.None
        cm.ValueColors.Add(New C1GaugeValueColor(0.0, Color.LimeGreen, 1.0))
        cm.ValueColors.Add(New C1GaugeValueColor(Double.NaN, 100, Color.DimGray, 1.0))
        c1LinearGauge1.ColorMaps.Add(cm)

        cm = New CommonColorMap()
        cm.Name = "yellow"
        cm.ValueColorFalloff = C1GaugeValueColorFalloff.None
        cm.ValueColors.Add(New C1GaugeValueColor(0.0, Color.Yellow, 1.0))
        cm.ValueColors.Add(New C1GaugeValueColor(Double.NaN, 100, Color.DimGray, 1.0))
        c1LinearGauge1.ColorMaps.Add(cm)

        cm = New CommonColorMap()
        cm.Name = "red"
        cm.ValueColorFalloff = C1GaugeValueColorFalloff.None
        cm.ValueColors.Add(New C1GaugeValueColor(0.0, Color.FromArgb(255, 64, 64), 1.0))
        cm.ValueColors.Add(New C1GaugeValueColor(Double.NaN, 100, Color.DimGray, 1.0))
        c1LinearGauge1.ColorMaps.Add(cm)

        For i As Int32 = 0 To 99
            Dim mark As C1GaugeSingleMark = New C1GaugeSingleMark()
            mark.Border.LineStyle = C1GaugeBorderStyle.None
            mark.Shape = C1GaugeMarkShape.Round
            mark.Width = 2
            Dim dl As Double = i * 0.035
            mark.Length = 6 + dl * dl * dl
            If (i < 60) Then
                mark.ColorMapName = "green"
            ElseIf (i < 85) Then
                mark.ColorMapName = "yellow"
            Else
                mark.ColorMapName = "red"
            End If
            mark.Value = i / 100.0

            GetXY(i, x, y)
            mark.Position = x * 0.01 + 0.27
            mark.Location = y + 35

            GetXY(i + 0.01, x1, y1)
            Dim dy As Double = (y1 - y) * 0.75
            Dim l As Double = Math.Sqrt((x1 - x) * (x1 - x) + dy * dy)
            Dim alpha As Double = Math.Asin(dy / l)
            If x1 < x Then
                alpha = Math.PI - alpha
            End If
            mark.ShapeAngle = alpha * 180.0 / Math.PI

            c1LinearGauge1.Decorators.Add(mark)
        Next i
        c1Gauge1.EndUpdate()
    End Sub

    Private Sub GetXY(ByVal a As Double, ByRef x As Double, ByRef y As Double)
        a = 120.0 - a
        Dim phi As Double = a * a * Math.PI / 5000.0
        Dim ro As Double = 36.0 / Math.Sqrt(phi)
        x = Math.Cos(phi) * ro
        y = Math.Sin(phi) * ro * 1.5
    End Sub

    Private Sub trackBar1_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles trackBar1.ValueChanged
        c1LinearGauge1.Value = trackBar1.Value / 100.0
    End Sub
End Class
