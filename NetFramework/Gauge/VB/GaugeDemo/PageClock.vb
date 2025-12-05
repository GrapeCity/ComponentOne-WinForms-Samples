Imports C1.Win.Gauge

Public Class PageClock

    Private _roman As Boolean

    Public Sub New()
        MyBase.New()

        InitializeComponent()
        OnTimer()

    End Sub

    Protected Overrides Sub OnTimer()
        Dim pointers As PointerCollection = c1RadialGauge1.MorePointers
        Dim seconds As Double = Math.Floor(DateTime.Now.TimeOfDay.TotalSeconds)
        pointers("hours").Value = (seconds Mod 43200.0) / 3600.0
        pointers("minutes").Value = (seconds - (Math.Floor(seconds / 3600.0) * 3600.0)) / 60.0
        pointers("seconds").Value = seconds - (Math.Floor(seconds / 60.0) * 60.0)
    End Sub

    Private Sub c1RadialGauge1_FormatLabel(ByVal sender As System.Object, _
      ByVal e As C1.Win.Gauge.FormatLabelEventArgs) Handles c1RadialGauge1.FormatLabel
        If _roman AndAlso e.Decorator.Name = "nums" Then

            Select Case Convert.ToInt32(e.ScaledValue)

                Case 1
                    e.Text = "I"
                Case 2
                    e.Text = "II"
                Case 3
                    e.Text = "III"
                Case 4
                    e.Text = "IV"
                Case 5
                    e.Text = "V"
                Case 6
                    e.Text = "VI"
                Case 7
                    e.Text = "VII"
                Case 8
                    e.Text = "VIII"
                Case 9
                    e.Text = "IX"
                Case 10
                    e.Text = "X"
                Case 11
                    e.Text = "XI"
                Case 12
                    e.Text = "XII"

            End Select

        End If
    End Sub

    Private Sub romanCheckBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles romanCheckBox.Click
        _roman = romanCheckBox.Checked
        c1Gauge1.InvalidateCache()
    End Sub
End Class
