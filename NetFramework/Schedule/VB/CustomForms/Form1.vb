Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.Schedule
Imports C1.Schedule
Imports System.Globalization
Imports System.Threading
Imports System.Collections

Namespace TestSchedule
	Public Partial Class Form1
		Inherits Form
		' collection of levels
		Private _levels As LevelCollection
		' collection of categories
        Private _categories As ExerciseCategories
        ' array of locations
        Private _locations As ArrayList

        Public Sub New()
            ' create level and category collections
            _levels = New LevelCollection()
            _categories = New ExerciseCategories()

            ' fill array of locations
            _locations = New ArrayList()
            _locations.Add(New Location(0, "LA Spin"))
            _locations.Add(New Location(1, "Studio 1"))
            _locations.Add(New Location(2, "Studio 2"))
            _locations.Add(New Location(3, "Pool"))
            _locations.Add(New Location(4, "Sauna"))
            _locations.Add(New Location(5, "Studio 3"))

            InitializeComponent()
            ' Set mappings for LabelStorage (map Level to C1.Schedule.Label object properties)
            Me.c1Schedule1.DataStorage.LabelStorage.Mappings.TextMapping.MappingName = "LevelName"
            Me.c1Schedule1.DataStorage.LabelStorage.Mappings.CaptionMapping.MappingName = "Description"
            Me.c1Schedule1.DataStorage.LabelStorage.Mappings.ColorMapping.MappingName = "ColorString"
            Me.c1Schedule1.DataStorage.LabelStorage.Mappings.IdMapping.MappingName = "Id"
            ' Set LabelStorage DataSource
            Me.c1Schedule1.DataStorage.LabelStorage.DataSource = _levels.Values

            ' Set mappings for CategoryStorage (map ExerciseCategory to C1.Schedule.Category object properties)
            Me.c1Schedule1.DataStorage.CategoryStorage.Mappings.TextMapping.MappingName = "Name"
            Me.c1Schedule1.DataStorage.CategoryStorage.Mappings.IndexMapping.MappingName = "Id"
            ' Set CategoryStorage DataSource
            Me.c1Schedule1.DataStorage.CategoryStorage.DataSource = _categories

            ' Set mappings for ResourceStorage (map Location to C1.Schedule.Resource object properties)
            Me.c1Schedule1.DataStorage.ResourceStorage.Mappings.TextMapping.MappingName = "Name"
            Me.c1Schedule1.DataStorage.ResourceStorage.Mappings.IndexMapping.MappingName = "Id"
            ' Set ResourceStorage DataSource
            Me.c1Schedule1.DataStorage.ResourceStorage.DataSource = _locations

            ' add some contacts
            Dim cnt As New Contact()
            cnt.Text = "Alisa Liddel"
            cnt.MenuCaption = "Alisa Liddel"
            Me.c1Schedule1.DataStorage.ContactStorage.Contacts.Add(cnt)

            Dim cnt1 = New Contact()
            cnt1.Text = "Rabbit"
            cnt1.MenuCaption = "Rabbit"
            Me.c1Schedule1.DataStorage.ContactStorage.Contacts.Add(cnt1)
        End Sub

        Private Sub exitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _exit.Click
            Close()
        End Sub

        ' Go to the current date
        Private Sub _today_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _today.Click
            ' Go to today date.
            Me.c1Schedule1.GoToDate(DateTime.Today)

        End Sub

        Private Sub c1Schedule1_BeforeAppointmentCreate(ByVal sender As Object, ByVal e As CancelAppointmentEventArgs) Handles c1Schedule1.BeforeAppointmentCreate
            ' set default exercise duration (45 minutes)
            e.Appointment.Duration = TimeSpan.FromMinutes(45)
        End Sub

        Private Sub c1Schedule1_BeforeViewChange(ByVal sender As Object, ByVal e As BeforeViewChangeEventArgs) Handles c1Schedule1.BeforeViewChange
            ' never switch to other views
            e.ViewType = ScheduleViewEnum.WeekView
        End Sub

        ' Replace built-in AppointmentForm with the ExerciseForm
        Private Sub c1Schedule1_BeforeAppointmentShow(ByVal sender As Object, ByVal e As CancelAppointmentEventArgs) Handles c1Schedule1.BeforeAppointmentShow
            ' Don't show built-in form
            e.Cancel = True
            For Each f As Form In Application.OpenForms
                ' activate form if it is already opened
                If TypeOf f Is ExerciseForm Then
                    If DirectCast(f, ExerciseForm).Appointment.Equals(e.Appointment) Then
                        f.BringToFront()
                        Return
                    End If
                End If
            Next
            ' Create ExerciseForm for selected Appointment
            Dim form As New ExerciseForm(c1Schedule1, e.Appointment)
            ' Show form
            form.Show()
        End Sub

		' Copy timetable information from currently selected day to another one
        Private Sub copyDayToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyDayToolStripMenuItem.Click
            ' Create CopyForm
            Dim f As New CopyForm()
			f._message.Text = "Select a day for copy to (choose one)"
            f.Text = "Select Day"

            ' If user have selected a new day
            If f.ShowDialog() = DialogResult.OK Then
                Dim originalDate As DateTime = c1Schedule1.CurrentDate.[Date]

                Dim newDate As DateTime = f.[Date].[Date]

                If newDate = originalDate Then
                    ' don't copy if user selected the same day
                    Return
                End If

                ' A days number to add to the Appointment.Start value 
                Dim days As Integer = DirectCast((newDate - originalDate), TimeSpan).Days

                ' Get all current day Appointments
                Dim list As AppointmentList = c1Schedule1.DataStorage.AppointmentStorage.Appointments.GetOccurrences(originalDate, originalDate.AddDays(1))

                ' For each current day Appointment, create a new one for the selected day
                For Each app As Appointment In list
                    ' Create new Appointment
                    Dim newApp As New Appointment()
                    ' Copy properties from the existent one
                    newApp.CopyFrom(app, False)
                    ' Change start time
                    newApp.Start = newApp.Start.AddDays(days)
                    ' Add new Appointment to AppointmentStorage
                    c1Schedule1.DataStorage.AppointmentStorage.Appointments.Add(newApp)
                Next
            End If
        End Sub

		' Copy timetable information from currently selected week to another one
        Private Sub copyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles copyToolStripMenuItem.Click
            ' Create CopyForm.
            Dim f As New CopyForm()
            ' If user have selected a new week
            If f.ShowDialog() = DialogResult.OK Then
                Dim weekStart As DateTime = c1Schedule1.SelectedDates(0)

                Dim newWeekStart As DateTime = f.[Date].[Date]
                While newWeekStart.DayOfWeek <> c1Schedule1.CalendarInfo.WeekStart
                    newWeekStart = newWeekStart.AddDays(-1)
                End While

                If newWeekStart = weekStart Then
                    ' don't copy if user selected the same week
                    Return
                End If

                ' A days number to add to the Appointment.Start value 
                Dim days As Integer = DirectCast((newWeekStart - weekStart), TimeSpan).Days

                ' Get all current week Appointments
                Dim list As AppointmentList = c1Schedule1.DataStorage.AppointmentStorage.Appointments.GetOccurrences(weekStart, weekStart.AddDays(7))

                ' For each current week Appointment, create a new one for the selected week
                For Each app As Appointment In list
                    ' Create new Appointment
                    Dim newApp As New Appointment()
                    ' Copy properties from the existent one
                    newApp.CopyFrom(app, False)
                    ' Change start time
                    newApp.Start = newApp.Start.AddDays(days)
                    ' Add new Appointment to AppointmentStorage
                    c1Schedule1.DataStorage.AppointmentStorage.Appointments.Add(newApp)
                Next
            End If
        End Sub

		' Clear current week timetable
        Private Sub clearWeekToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles clearWeekToolStripMenuItem.Click
            ' Get week start
            Dim weekStart As DateTime = c1Schedule1.SelectedDates(0)

            ' Get all current week Appointments
            Dim list As AppointmentList = c1Schedule1.DataStorage.AppointmentStorage.Appointments.GetOccurrences(weekStart, weekStart.AddDays(7))

            ' Remove appointments
            For Each app As Appointment In list
                app.Delete()
            Next
        End Sub

        ' Show custom Reminder form when Reminder fires
        Private Sub c1Schedule1_ReminderFire(ByVal sender As System.Object, ByVal e As C1.Schedule.ReminderEventArgs) Handles c1Schedule1.ReminderFire
            Dim form As New ReminderForm(e.Reminder, Me)
            ' Show form
            form.Show()
        End Sub
    End Class
End Namespace
