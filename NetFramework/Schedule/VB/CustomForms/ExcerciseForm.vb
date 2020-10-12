
Imports C1.C1Schedule
Imports C1.Win.C1Schedule
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.IO
Imports System.Globalization
Namespace TestSchedule

	''' <summary>
    ''' The <see cref="ExerciseForm"/> represents the dialog form for editing
    ''' <see cref="Appointment"/> objects.
    ''' It differ from the built-in AppointmentForms and display an Appointment
    ''' in terms of Fitness Center domain.
    ''' </summary>
    Partial Public Class ExerciseForm
        Inherits Form
        '------------------------------------------------------------------------------------------
#Region "** fields"
        ' reference to the owning C1Schedule component.
        Private _schedule As C1Schedule
        ' Appointment object
        Private _appointment As Appointment
#End Region

        '------------------------------------------------------------------------------------------
#Region "** ctor"

        ''' <summary>
        ''' Initializes a new instance of the <see cref="ExerciseForm"/> form
        ''' for editing of the specified <see cref="Appointment"/> object.
        ''' </summary>
        ''' <param name="schedule">The owning <see cref="C1Schedule"/> component.</param>
        ''' <param name="appointment">The <see cref="Appointment"/> object.</param>
        Public Sub New(ByVal schedule As C1Schedule, ByVal appointment As Appointment)
            ' initialize private fields
            _schedule = schedule
            _appointment = appointment

            ' call BeginEdit in order to not refresh UI at changing properties of Appointment
            _appointment.BeginEdit()

            Font = SystemInformation.MenuFont
            InitializeComponent()

            ' initialize form controls
            Initialize()
        End Sub

        ' initialize form controls
        Private Sub Initialize()
            ' cmbLabel shows group(student) level
            cmbLabel.DataSource = _schedule.DataStorage.LabelStorage.Labels
            cmbLabel.DisplayMember = "Text"
            AddHandler cmbLabel.DrawItem, AddressOf cmbLabel_DrawItem
            ' draw colored levels
            cmbLabel.DrawMode = DrawMode.OwnerDrawFixed

            ' cmbLocation shows available locations
            cmbLocation.DataSource = _schedule.DataStorage.ResourceStorage.Resources
            cmbLocation.DisplayMember = "Text"

            ' cmbInstructor shows instructors
            cmbInstructor.DataSource = _schedule.DataStorage.ContactStorage.Contacts
            cmbInstructor.DisplayMember = "Text"

            ' cmbCategory shows Exercise categories
            cmbCategory.DataSource = _schedule.DataStorage.CategoryStorage.Categories
            cmbCategory.DisplayMember = "Text"

            ' initialize date and time controls
            dpStart.Value = _appointment.Start.[Date]
            dpEnd.Value = _appointment.[End].[Date]
            tpStart.MinDate = _appointment.Start.[Date]
            tpStart.Value = _appointment.Start
            tpEnd.MinDate = _appointment.Start
            tpEnd.Value = _appointment.[End]
            dpEnd.MinDate = _appointment.Start

            ' initialize selected control values
            If _appointment.Label IsNot Nothing Then
                cmbLabel.SelectedItem = _appointment.Label
            End If
            cmbLocation.SelectedIndex = cmbLocation.FindStringExact(_appointment.Location)
            If cmbLocation.SelectedIndex = -1 Then
                cmbLocation.SelectedIndex = 0
            End If

            cmbExercise.SelectedIndex = cmbExercise.FindStringExact(_appointment.Subject)
            If cmbExercise.SelectedIndex = -1 Then
                cmbExercise.SelectedIndex = 0
            End If

            If _appointment.Links.Count > 0 Then
                cmbInstructor.SelectedIndex = cmbInstructor.FindStringExact(_appointment.Links(0).Text)
            End If
            If _appointment.Categories.Count > 0 Then
                cmbCategory.SelectedIndex = cmbCategory.FindStringExact(_appointment.Categories(0).ToString())
            End If

            txtBody.Text = _appointment.Body
        End Sub

        ' set Appointment properties according to the selected control values
        Private Sub SetAppointment()
            Try
                ' set Exercise name
                _appointment.Subject = cmbExercise.SelectedItem.ToString()
                ' set Exercise description
                _appointment.Body = txtBody.Text

                ' set Exercise level
                If cmbLabel.SelectedIndex >= 0 Then
                    If Not DirectCast(cmbLabel.SelectedItem, C1.C1Schedule.Label).Equals(_appointment.Label) Then
                        _appointment.Label = DirectCast(cmbLabel.SelectedItem, C1.C1Schedule.Label)
                    End If
                End If

                ' set Exercise instructor
                _appointment.Links.Clear()
                _appointment.Links.Add(DirectCast(cmbInstructor.SelectedItem, Contact))

                ' set Exercise category
                _appointment.Categories.Clear()
                _appointment.Categories.Add(DirectCast(cmbCategory.SelectedItem, Category))

                ' set Exercise start time
                _appointment.Start = dpStart.Value.Date.Add(tpStart.Value.TimeOfDay)
                ' set Exercise end time
                Dim endTime As DateTime = dpEnd.Value.Date.Add(tpEnd.Value.TimeOfDay)
                If _appointment.Start >= endTime Then
                    _appointment.End = _appointment.Start.AddMinutes(1)
                Else
                    _appointment.End = endTime
                End If

                ' set Exercise location
                _appointment.Location = cmbLocation.SelectedItem.ToString()

                _appointment.ReminderSet = True
            Finally
                ' always call EndEdit to apply changes and refresh UI
                _appointment.EndEdit()
                If Not _schedule.DataStorage.AppointmentStorage.Appointments.Contains(_appointment) Then
                    _schedule.DataStorage.AppointmentStorage.Appointments.Add(_appointment)
                End If

           End Try
        End Sub
#End Region

        '------------------------------------------------------------------------------------------
#Region "** object model"

        ''' <summary>
        ''' Gets the <see cref="Appointment"/> object.
        ''' </summary>
        Public ReadOnly Property Appointment() As Appointment
            Get
                Return _appointment
            End Get
        End Property
#End Region

        '------------------------------------------------------------------------------------------
#Region "** event handlers"
        Private Sub cmbLabel_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
            e.DrawBackground()
            Dim brush As Brush
            If (e.State And DrawItemState.Focus) = 0 Then
                brush = Brushes.Black
            Else
                brush = Brushes.White
            End If
            ' Define the default color of the brush as black.
            Dim myBrush As Brush = New SolidBrush(_schedule.DataStorage.LabelStorage.Labels(e.Index).Color)

            e.Graphics.DrawRectangle(New Pen(Color.Black, 1), e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Height - 4, e.Bounds.Height - 4)
            e.Graphics.FillRectangle(myBrush, e.Bounds.X + 3, e.Bounds.Y + 3, e.Bounds.Height - 5, e.Bounds.Height - 5)
            ' Draw the current item text based on the current Font and the custom brush settings.
            e.Graphics.DrawString(cmbLabel.Items(e.Index).ToString(), e.Font, brush, e.Bounds.X + e.Bounds.Height, e.Bounds.Y)
            ' If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle()
        End Sub

        Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
            ' validate DateTime values selected in controls
            If Not CheckTimes() Then
                ' if validation fails, return
                Return
            End If
            ' apply changes
            SetAppointment()
            DialogResult = DialogResult.OK
            ' close form
            Close()
        End Sub

        Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
            ' remove Exercise (this will remove an Appointment object from control)
            _appointment.Delete()
            ' close form
            Close()
        End Sub

        ' change minimum allowd values of other controls according to the new value of start date.
        Private Sub dpStart_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            tpStart.MinDate = dpStart.Value.Date
            Dim start As DateTime = dpStart.Value.Date.Add(tpStart.Value.TimeOfDay)
            Dim endTime As DateTime = dpEnd.Value.Date.Add(tpEnd.Value.TimeOfDay)
            If endTime < start Then
                endTime = start.Add(_schedule.CalendarInfo.TimeScale)
                dpEnd.Value = endTime
                tpEnd.Value = endTime
            End If
            tpEnd.MinDate = start
            dpEnd.MinDate = start
        End Sub

        ' Validate times and show error message if necessary.
        Private Function CheckTimes() As Boolean
            Dim start As DateTime = dpStart.Value.[Date].Add(tpStart.Value.TimeOfDay)
            Dim [end] As DateTime = dpEnd.Value.[Date].Add(tpEnd.Value.TimeOfDay)
            If [end] < start Then
                MessageBox.Show("The end date you entered occurs before the start date.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            Return True
        End Function
#End Region

    End Class
End Namespace
