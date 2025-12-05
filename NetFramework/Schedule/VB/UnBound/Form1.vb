Imports C1.Win.Schedule
Imports C1.Schedule
Imports System.IO

Public Class Form1

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub TodayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodayToolStripMenuItem.Click
        ' Go to today date.
        Me.C1Schedule1.GoToDate(DateTime.Today)
    End Sub

    Private Sub MonthViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthViewToolStripMenuItem.Click
        ' Switch to the MonthView.
        Me.C1Schedule1.ViewType = ScheduleViewEnum.MonthView
    End Sub

    Private Sub WeekViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WeekViewToolStripMenuItem.Click
        ' Switch to the WeekView.
        Me.C1Schedule1.ViewType = ScheduleViewEnum.WeekView
    End Sub

    Private Sub WorkWeekViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkWeekViewToolStripMenuItem.Click
        ' Switch to the WorkWeekView.
        Me.C1Schedule1.ViewType = ScheduleViewEnum.WorkWeekView
    End Sub

    Private Sub DayViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayViewToolStripMenuItem.Click
        ' Switch to the DayView.
        Me.C1Schedule1.ViewType = ScheduleViewEnum.DayView
    End Sub

    Private Sub TimeLineViewMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeLineViewMenuItem.Click
        ' Switch to the TimeLineView.
        Me.C1Schedule1.ViewType = ScheduleViewEnum.TimeLineView
    End Sub

    ' On closing the form, save all data to the file.
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Save all data to the file.
        Me.C1Schedule1.DataStorage.Export("C1Schedule.xml", FileFormatEnum.XML)
    End Sub

    ' On loading the form, load previously saved data.
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' If file with data exists,
        If File.Exists("C1Schedule.xml") Then
            ' load data from the file.
            Me.C1Schedule1.DataStorage.Import("C1Schedule.xml", FileFormatEnum.XML)
        End If
    End Sub

    ' Export data to the file.
    Private Sub ExportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportToolStripMenuItem.Click
        Me.C1Schedule1.Export(DBNull.Value, "Export Data")
    End Sub

    ' Import data from the file.
    Private Sub ImportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportToolStripMenuItem.Click
        Me.C1Schedule1.Import("Import Data")
    End Sub
End Class
