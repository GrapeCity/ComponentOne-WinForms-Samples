Public Class PageIntervalWidth

    Protected Overrides Sub OnTimer()
        UpdateValue(c1RadialGauge1, 20)
        UpdateValue(c1LinearGauge1, 20)
        UpdateValue(c1LinearGauge2, 20)
    End Sub

End Class
