Public Class PageCarDashboard

    Protected Overrides Sub OnTimer()
        UpdateValue(c1RadialGauge1, "mph", 100, 0, 180)
        UpdateValue(c1RadialGauge1, "rpm", 3000, 0, 8300)
        UpdateValue(c1RadialGauge1, "fuel", 50, 0, 100)
    End Sub

End Class
