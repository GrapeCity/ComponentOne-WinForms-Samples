Imports System.Globalization
Imports System

Namespace TestSchedule
    ' ReminderForm is a custom form to show instead of C1Schedule's embedded one
    Public Class ReminderForm

        Private _reminder As C1.Schedule.Reminder
        Private _owner As Form1

        Public Sub New(ByVal reminder As C1.Schedule.Reminder, ByVal owner As Form1)
            _reminder = reminder
            _owner = owner
            Me.InitializeComponent()
        End Sub

        Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
            ' Open Appointment Form for editing
            Dim form As New ExerciseForm(_owner.c1Schedule1, _reminder.ParentAppointment)
            ' Show form
            form.Show()
            ' Close Reminder form
            Me.Close()
        End Sub

        Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
            ' Snooze Reminder
            _reminder.Snooze(TimeSpan.FromMinutes(15))
            ' Close Reminder form
            Me.Close()
        End Sub

        Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
            ' Dismiss Reminder
            _reminder.Dismiss()
            ' Close Reminder form
            Me.Close()
        End Sub

        Private Sub ReminderForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' Initialize controls
            Me.Text = """" + _reminder.Caption + """ Reminder"
            TextBox1.Text = """" + _reminder.Caption + """ event should occur at " + _reminder.ParentAppointment.Start.ToString(CultureInfo.CurrentUICulture)
        End Sub
    End Class
End Namespace
