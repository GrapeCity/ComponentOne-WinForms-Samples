Imports C1.CalendarView
Imports C1.Framework
Imports C1.Win.Shared

Public Class Form1
    Private Sub cmbDayTitlePosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDayTitlePosition.SelectedIndexChanged
        c1CalendarView1.DayTitlePosition = CType([Enum].Parse(GetType(Position), cmbDayTitlePosition.Text), Position)
    End Sub

    Private Sub cmbMonthTitlePosition_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMonthTitlePosition.SelectedIndexChanged
        c1CalendarView1.MonthTitlePosition = CType([Enum].Parse(GetType(Position), cmbMonthTitlePosition.Text), Position)
    End Sub

    Private Sub cbVerticalOrientationLayout_CheckedChanged(sender As Object, e As EventArgs) Handles cbVerticalOrientationLayout.CheckedChanged
        c1CalendarView1.VerticalOrientationLayout = cbVerticalOrientationLayout.Checked
    End Sub

    Private Sub cmbAlignment_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAlignment.SelectedIndexChanged
        If (c1CalendarView1.VerticalOrientationLayout) Then
            c1CalendarView1.Theme.Common.VerticalAlignment = CType([Enum].Parse(GetType(Alignment), cmbAlignment.Text), Alignment)
        Else
            c1CalendarView1.Theme.Common.HorizontalAlignment = CType([Enum].Parse(GetType(Alignment), cmbAlignment.Text), Alignment)
        End If
    End Sub

    Private Sub cbShowWeekNumbers_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowWeekNumbers.CheckedChanged
        c1CalendarView1.ShowWeekNumbers = cbShowWeekNumbers.Checked
    End Sub

    Private Sub numCalendarDimensions_ValueChanged(sender As Object, e As EventArgs) Handles numCalendarDimensions.ValueChanged
        c1CalendarView1.CalendarDimensions = numCalendarDimensions.Value
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim themes As String() = C1.Win.C1Themes.C1ThemeController.GetThemes()
        cmbTheme.Items.AddRange(themes)
        cmbTheme.SelectedIndex = Array.IndexOf(themes, "Office365White")
    End Sub

    Private Sub numMaxSelectionCount_ValueChanged(sender As Object, e As EventArgs) Handles numMaxSelectionCount.ValueChanged
        c1CalendarView1.MaxSelectionCount = numMaxSelectionCount.Value
    End Sub

    Private Sub cmbTheme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTheme.SelectedIndexChanged
        C1ThemeController1.Theme = cmbTheme.Text
        If (clpDayForeColor.Color <> Color.Transparent) Then
            c1CalendarView1.Theme.Day.Ordinary.ForeColor = clpDayForeColor.Color
        End If
        If (clpWeekendForeColor.Color <> Color.Transparent) Then
            c1CalendarView1.Theme.Day.Weekend.ForeColor = clpWeekendForeColor.Color
        End If
        If (clpTodayForeColor.Color <> Color.Transparent) Then
            c1CalendarView1.Theme.Day.Today.ForeColor = clpTodayForeColor.Color
        End If
        If (clpTodayBorderColor.Color <> Color.Transparent) Then
            c1CalendarView1.Theme.Day.Today.BorderColor = clpTodayBorderColor.Color
        End If
    End Sub

    Private Sub clpDayForeColor_ColorChanged(sender As Object, e As EventArgs) Handles clpDayForeColor.ColorChanged
        c1CalendarView1.Theme.Day.Ordinary.ForeColor = clpDayForeColor.Color
    End Sub

    Private Sub clpWeekendForeColor_ColorChanged(sender As Object, e As EventArgs) Handles clpWeekendForeColor.ColorChanged
        c1CalendarView1.Theme.Day.Weekend.ForeColor = clpWeekendForeColor.Color
    End Sub

    Private Sub clpTodayForeColor_ColorChanged(sender As Object, e As EventArgs) Handles clpTodayForeColor.ColorChanged
        c1CalendarView1.Theme.Day.Today.ForeColor = clpTodayForeColor.Color
    End Sub

    Private Sub clpTodayBorderColor_ColorChanged(sender As Object, e As EventArgs) Handles clpTodayBorderColor.ColorChanged
        c1CalendarView1.Theme.Day.Today.BorderColor = clpTodayBorderColor.Color
    End Sub
End Class
