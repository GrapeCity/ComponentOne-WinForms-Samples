Imports C1.Win.Gauge

Public Class PageSwissRailwayClock

    Public Sub New()
        MyBase.New()

        InitializeComponent()
        OnTimer()

    End Sub

    Protected Overrides Sub OnTimer()
        Dim pointers As PointerCollection = c1RadialGauge1.MorePointers
        Dim seconds As Double = DateTime.Now.TimeOfDay.TotalSeconds
        pointers("hours").Value = Math.Floor((seconds Mod 43200.0) / 3600.0)
        pointers("minutes").Value = Math.Floor((seconds - (Math.Floor(seconds / 3600.0) * 3600.0)) / 60.0)
        pointers("seconds").Value = seconds - (Math.Floor(seconds / 60.0) * 60.0)
    End Sub

End Class
