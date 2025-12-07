Imports C1.Win.Schedule
Imports C1.Schedule
Imports C1.Win.Ribbon
Imports C1.Win.Schedule.Forms

Public Class AppointmentForm

#Region "Fields"
    Private _scheduler As C1Schedule
    ' temporary appointment used for editing
    Private _appEdited As Appointment

    Private _defaultStart As TimeSpan
    Private _defaultDuration As TimeSpan

    ' save all Location values which have been used in application
    ' you can remove this field if you use C1Schedule build 184 or later
    Public Shared Locations As List(Of String) = New List(Of String)()

    ' keep ZoomFactor for the appointment body rich text box
    Public Shared ZoomFactor As Single = 1.0F
#End Region

#Region "Initialization"
    ''' <summary>
    ''' Initializes a new instance of the <see cref="AppointmentForm"/> form.
    ''' </summary>
    ''' <param name="scheduler">Reference to the owning <see cref="C1Schedule"/> control.</param>
    ''' <param name="appointment">The <see cref="Appointment"/> object for editing.</param>
    Public Sub New(ByVal scheduler As C1Schedule, ByVal appointment As Appointment)
        _scheduler = scheduler
        _appointment = appointment
        ' work with appointment copy, so that don't change initial appointment
        ' until end-user saves the changes
        _appEdited = appointment.Copy()
        _appEdited.BeginEdit()
        _defaultStart = IIf(appointment.AllDayEvent, _scheduler.CalendarInfo.StartDayTime, appointment.Start.TimeOfDay)
        _defaultDuration = IIf(appointment.AllDayEvent, _scheduler.CalendarInfo.TimeScale, appointment.Duration)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Initialize()
    End Sub
    Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
		MyBase.OnLoad(e)
		SetCurrentZoom()
	End Sub
    Private Sub AppointmentForm_Shown(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Shown
        If (_scheduler IsNot Nothing And (Not DesignMode) And "Create recurrence".Equals(CType(_appEdited.Tag, String))) Then
            _appEdited.Tag = Nothing
            ' if form is opened with C1Schedule context menu "Create Recurring Appointment" or "Create Recurring Event",
            ' then open Recurrence dialog immediately
            _btnRecurrence_Click(Me, Nothing)
        End If
    End Sub
    Private Sub Initialize()
        ' initialize controls in the ribbon
        c1Ribbon1.BeginUpdate()
        _cmbStatus.DataBindings.Clear()
        _cmbLabel.DataBindings.Clear()
        _cmbOwner.DataBindings.Clear()
        _txtSubject.DataBindings.Clear()
        _txtBody.DataBindings.Clear()
        _cmbLocation.DataBindings.Clear()
        _chkAllDay.DataBindings.Clear()
        _dpStartDate.DataBindings.Clear()
        _dpStartTime.DataBindings.Clear()
        _dpEndTime.DataBindings.Clear()
        _dpEndDate.DataBindings.Clear()
        _dpEndTime.DataBindings.Clear()
        _dpEndDate.MinDate = DateTimePicker.MinimumDateTime
        _dpEndTime.MinDate = DateTimePicker.MinimumDateTime

        _togglePrivate.Pressed = _appEdited.Private
        Select Case (_appEdited.Importance)
            Case ImportanceEnum.High
                _toggleHighImportance.Pressed = True
            Case ImportanceEnum.Low
                _toggleLowImportance.Pressed = True
        End Select

        _cmbStatus.DataSource = _scheduler.DataStorage.StatusStorage.Statuses
        _cmbStatus.DisplayMember = "Text"
        Dim status As Binding = New Binding("SelectedItem", _appEdited, "BusyStatus", True, DataSourceUpdateMode.OnPropertyChanged)
        _cmbStatus.DataBindings.Add(status)
        AddHandler status.BindingComplete, AddressOf status_BindingComplete

        _cmbLabel.DataSource = _scheduler.DataStorage.LabelStorage.Labels
        _cmbLabel.DisplayMember = "Text"
        Dim label As Binding = New Binding("SelectedItem", _appEdited, "Label", True, DataSourceUpdateMode.OnPropertyChanged)
        _cmbLabel.DataBindings.Add(label)
        AddHandler label.BindingComplete, AddressOf label_BindingComplete

        FillReminders()
        InitZoom()
        c1Ribbon1.EndUpdate()

        ' initialize other controls
        ' bind controls to appointment properties
		RemoveHandler _cmbOwner.SelectedIndexChanged, AddressOf _cmbOwner_SelectedIndexChanged
		_cmbOwner.DataSource = _scheduler.DataStorage.OwnerStorage.Contacts
        _cmbOwner.DataBindings.Add(New Binding("SelectedItem", _appEdited, "Owner", True, DataSourceUpdateMode.OnPropertyChanged))
        AddHandler _cmbOwner.SelectedIndexChanged, AddressOf _cmbOwner_SelectedIndexChanged

        _txtSubject.DataBindings.Add(New Binding("Text", _appEdited, "Subject", False, DataSourceUpdateMode.OnPropertyChanged))
        _txtBody.DataBindings.Add(New Binding("Text", _appEdited, "Body", True, DataSourceUpdateMode.OnPropertyChanged))

        ' bind _cmbLocations to the available locations
        _cmbLocation.DataSource = Locations
        ' you can remove the previous line of code and uncomment the next line
        ' if you use C1Schedule build 184 or later
        ' _cmbLocation.DataSource = _scheduler.Locations 

        _cmbLocation.DataBindings.Add(New Binding("Text", _appEdited, "Location"))

        If (_appEdited.RecurrenceState <> RecurrenceStateEnum.Master) Then
            ' Note: don't set DateTime related bindings for master appointments

            Dim allDay As Binding = New Binding("Checked", _appEdited, "AllDayEvent", True, DataSourceUpdateMode.OnPropertyChanged)
            _chkAllDay.DataBindings.Add(allDay)
            AddHandler allDay.BindingComplete, AddressOf allDay_BindingComplete

            Dim start As Binding = New Binding("Value", _appEdited, "Start", True, DataSourceUpdateMode.OnPropertyChanged)
            _dpStartDate.DataBindings.Add(start)
            start = New Binding("Value", _appEdited, "Start", True, DataSourceUpdateMode.OnPropertyChanged)
            _dpStartTime.DataBindings.Add(start)
            AddHandler start.BindingComplete, AddressOf start_BindingComplete


            _dpEndTime.DataBindings.Add(New Binding("Value", _dpEndDate, "Value", False, DataSourceUpdateMode.OnPropertyChanged))
        End If

        For Each cat As Category In _scheduler.DataStorage.CategoryStorage.Categories
            Dim index As Integer = _lstCategories.Items.Add(cat)
            _lstCategories.SetItemChecked(index, _appEdited.Categories.Contains(cat))
        Next
        For Each cnt As Contact In _scheduler.DataStorage.ContactStorage.Contacts
            Dim index As Integer = _lstClients.Items.Add(cnt)
            _lstClients.SetItemChecked(index, _appEdited.Links.Contains(cnt))
        Next

        _btnPreview.Enabled = _scheduler.PrintInfo.IsPreviewEnabled
        _btnPrint.Enabled = _scheduler.PrintInfo.IsPrintingEnabled

		SetCurrentZoom()
		MakeTitle()
        UpdateRecurrenceControls()
        UpdateAppointmentEndControls()
    End Sub

    Private Sub status_BindingComplete(ByVal sender As Object, ByVal e As BindingCompleteEventArgs)
        RemoveHandler _cmbStatus.SelectedValueChanged, AddressOf _cmbStatus_SelectedValueChanged
        _appEdited.BusyStatus = CType(_cmbStatus.SelectedItem, Status)
        AddHandler _cmbStatus.SelectedValueChanged, AddressOf _cmbStatus_SelectedValueChanged
    End Sub
    Private Sub label_BindingComplete(ByVal sender As Object, ByVal e As BindingCompleteEventArgs)
        RemoveHandler _cmbLabel.SelectedValueChanged, AddressOf _cmbLabel_SelectedValueChanged
        _appEdited.Label = CType(_cmbLabel.SelectedItem, C1.Schedule.Label)
        AddHandler _cmbLabel.SelectedValueChanged, AddressOf _cmbLabel_SelectedValueChanged
    End Sub
    Private Sub start_BindingComplete(ByVal sender As Object, ByVal e As BindingCompleteEventArgs)
        UpdateAppointmentEndControls()
    End Sub
    Private Sub allDay_BindingComplete(ByVal sender As Object, ByVal e As BindingCompleteEventArgs)
        ' update window title and DateTime controls
        MakeTitle()
        Dim needUpdate As Boolean = False
        If (_appEdited.AllDayEvent) Then
            needUpdate = _dpStartTime.Visible
            _dpStartTime.Visible = False
            _dpEndTime.Visible = False
        Else
            needUpdate = Not _dpStartTime.Visible
            _dpStartTime.Visible = True
            _dpEndTime.Visible = True
            If (_appEdited.Start.TimeOfDay = TimeSpan.Zero And _appEdited.Duration.TotalDays >= 1) Then
                ' initialize times to some default values
                needUpdate = True
                _appEdited.Start = _appEdited.Start.Add(_defaultStart)
                _appEdited.Duration = _defaultDuration
            End If
        End If
        If (needUpdate) Then
            UpdateAppointmentEndControls()
        End If
    End Sub

#End Region

#Region "Public interface"
    Private _appointment As Appointment
    ''' <summary>
    ''' The <see cref="C1.Schedule.Appointment"/> object which is currently edited with the form.
    ''' </summary>
    Public Property Appointment() As Appointment
        Get
            Return _appointment
        End Get
        Private Set(ByVal value As Appointment)
            _appointment = value
        End Set
    End Property
#End Region

#Region "Actions"
    Private Sub _rbSaveClose_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _rbSaveClose.Click
        ' copy all changes to the initial appointment and close the form
        SaveAppointment()
        Close()
    End Sub
    Private Sub _rbDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _rbDelete.Click
        Appointment.Delete()
        Close()
    End Sub
    Protected Overrides Sub OnClosing(ByVal e As System.ComponentModel.CancelEventArgs)
        RemoveHandler _cmbStatus.SelectedValueChanged, AddressOf _cmbStatus_SelectedValueChanged
        RemoveHandler _cmbLabel.SelectedValueChanged, AddressOf _cmbLabel_SelectedValueChanged
        RemoveHandler _cmbReminder.SelectedIndexChanged, AddressOf _cmbReminder_SelectedIndexChanged
        If (_saved) Then
            DialogResult = DialogResult.OK
        End If
        MyBase.OnClosing(e)
    End Sub
    Private _saving As Boolean = False
    Private Sub _btnSaveAs_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnSaveAs.Click
        Try
            If (_saving) Then
                Exit Sub
            End If
            _saving = True
            SaveAppointment()
            _scheduler.Export(Appointment, _
     C1.Win.Schedule.Localization.Strings.AppointmentFormStrings.Item("SaveAppointment", _scheduler.CalendarInfo.CultureInfo))
        Finally
            _saving = False
        End Try
    End Sub
    Private Sub _btnPrint_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnPrint.Click
        SaveAppointment()
        _scheduler.PrintInfo.Print(Appointment)
    End Sub
    Private Sub _btnPreview_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnPreview.Click
        SaveAppointment()
        _scheduler.PrintInfo.Preview(Appointment)
    End Sub
    Private _saved As Boolean = False
    Private Sub SaveAppointment()
        ' save all changes into initial appointment
        Appointment.BeginEdit()
        Appointment.CopyFrom(_appEdited, False)
        Appointment.EndEdit()
        If Not _scheduler.DataStorage.AppointmentStorage.Appointments.Contains(Appointment) Then
            _scheduler.DataStorage.AppointmentStorage.Appointments.Add(Appointment)
        End If
        _saved = True
    End Sub
#End Region

#Region "Misc event handlers"
    Private Sub AppointmentForm_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
        If (e.Handled) Then
            Exit Sub
        End If
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) And Not _txtBody.Focused) Then
            SendKeys.Send("{TAB}")
        ElseIf (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Escape)) Then
            Close()
        End If
    End Sub
    Private Sub _txtBody_LinkClicked(ByVal sender As Object, ByVal e As LinkClickedEventArgs) Handles _txtBody.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub
#End Region

#Region "Recurrence handling"
    Private Sub UpdateRecurrenceControls()
        Select Case (_appEdited.RecurrenceState)
            Case RecurrenceStateEnum.Master
                _pnPattern.Visible = True
                _lblPattern.Text = _appEdited.GetRecurrencePattern().GetDescription(_scheduler.CalendarInfo)
                _pnTime.Visible = False
                _btnRecurrence.Pressed = True
            Case Else
                _pnPattern.Visible = False
                _pnTime.Visible = True
                _btnRecurrence.Pressed = False
        End Select
    End Sub
#End Region

#Region "Form title handling"
    Private Sub MakeTitle()
        Text = _scheduler.GroupItems(_appEdited.Owner).DisplayName + ": "
        ' update dialog title according to the appointment properties
        If (Not String.IsNullOrEmpty(_txtSubject.Text)) Then
            Text += _txtSubject.Text
        Else
            Text += "Untitled"
        End If
        If (_appEdited.AllDayEvent) Then
            Text += " - " + "Event"
        Else
            Text += " - " + "Appointment"
        End If
    End Sub
    Private Sub _txtSubject_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _txtSubject.TextChanged
        MakeTitle()
    End Sub
#End Region

#Region "Assignments"
    Private Sub _cmbOwner_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _cmbOwner.SelectedIndexChanged
        _appEdited.Owner = CType(_cmbOwner.SelectedItem, Contact)
        MakeTitle()
    End Sub
    Private Sub _lstCategories_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs) Handles _lstCategories.ItemCheck
        Dim cat As Category = CType(_lstCategories.Items(e.Index), Category)
        If (e.NewValue = CheckState.Checked) Then
            Dim index As Integer = e.Index
            If (Not _scheduler.Settings.AllowCategoriesMultiSelection) Then
                For i As Integer = 0 To _lstCategories.Items.Count - 1 Step 1
                    If (i <> index) Then
                        _lstCategories.SetItemChecked(i, False)
                    End If
                Next
            End If
            If (Not _appEdited.Categories.Contains(cat)) Then
                _appEdited.Categories.Add(cat)
            End If
        Else
            _appEdited.Categories.Remove(cat)
        End If
    End Sub
    Private Sub _lstClients_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs) Handles _lstClients.ItemCheck
        Dim cnt As Contact = CType(_lstClients.Items(e.Index), Contact)
        If (e.NewValue = CheckState.Checked) Then
            Dim index As Integer = e.Index
            If (Not _scheduler.Settings.AllowContactsMultiSelection) Then
                For i As Integer = 0 To _lstClients.Items.Count - 1 Step 1
                    If (i <> index) Then
                        _lstClients.SetItemChecked(i, False)
                    End If
                Next
            End If
            If (Not _appEdited.Links.Contains(cnt)) Then
                _appEdited.Links.Add(cnt)
            End If
        Else
            _appEdited.Links.Remove(cnt)
        End If
    End Sub
#End Region

#Region "DateTime properties handling"
    Private Sub UpdateAppointmentEndControls()
        Dim endTime As DateTime = _appEdited.End
        _dpEndDate.MinDate = _appEdited.Start
        _dpEndTime.MinDate = _appEdited.Start
        If (_appEdited.AllDayEvent) Then
            endTime = endTime.AddDays(-1)
        End If
        _dpEndDate.Value = endTime
        _dpEndTime.Value = endTime
    End Sub
    Private Sub _dpEndDate_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _dpEndDate.ValueChanged
        Dim endTime As DateTime = _dpEndDate.Value
        If (_appEdited.AllDayEvent) Then
            endTime = endTime.AddDays(1)
        End If
        _appEdited.End = endTime
        UpdateAppointmentEndControls()
    End Sub
#End Region

#Region "Tags"
    Private Sub _cmbLabel_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _cmbLabel.SelectedValueChanged
        _appEdited.Label = CType(_cmbLabel.SelectedItem, C1.Schedule.Label)
    End Sub
    Private Sub _togglePrivate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _togglePrivate.Click
        _appEdited.Private = _togglePrivate.Pressed
    End Sub
    Private Sub _toggleHighImportance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _toggleHighImportance.Click
        If (_toggleHighImportance.Pressed) Then
            _toggleLowImportance.Pressed = False
            _appEdited.Importance = ImportanceEnum.High
        ElseIf (_toggleLowImportance.Pressed = False) Then
            _appEdited.Importance = ImportanceEnum.Normal
        End If
    End Sub
    Private Sub _toggleLowImportance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _toggleLowImportance.Click
        If (_toggleLowImportance.Pressed) Then
            _toggleHighImportance.Pressed = False
            _appEdited.Importance = ImportanceEnum.Low
        ElseIf (_toggleHighImportance.Pressed = False) Then
            _appEdited.Importance = ImportanceEnum.Normal
        End If
    End Sub
#End Region

#Region "Options"
    Private Sub _btnRecurrence_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnRecurrence.Click
        Dim isNew As Boolean = _appEdited.RecurrenceState = RecurrenceStateEnum.NotRecurring
        Dim pattern As RecurrencePattern = _appEdited.GetRecurrencePattern()
        If (Not pattern.ParentAppointment.Equals(_appEdited)) Then
            ' if current appointment is occurrence,
            ' then switch to the master appointment
            Appointment.CancelEdit()
            Appointment = pattern.ParentAppointment
            _appEdited = pattern.ParentAppointment.Copy()
            _appEdited.BeginEdit()
            pattern = _appEdited.GetRecurrencePattern()
            Me.Initialize()
        End If
        Dim form As RecurrenceForm = New RecurrenceForm(_scheduler, pattern, isNew)
        form.ShowDialog(Me)
        If (form.DialogResult = DialogResult.OK) Then
            ' update master appointment properties from pattern
            _appEdited.Duration = pattern.Duration
            _appEdited.Start = pattern.StartTime
        ElseIf (isNew) Then
            ' clear pattern back
            _appEdited.ClearRecurrencePattern()
        End If
        ' initialize again
        Initialize()
    End Sub
    Private Sub _cmb_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles _cmbStatus.DrawItem, _cmbLabel.DrawItem
        Dim cmb As ComboBox = CType(sender, ComboBox)
        If (cmb IsNot Nothing) Then
            Dim bo As BaseObject = CType(cmb.Items(e.Index), BaseObject)
            e.DrawBackground()

            Using pen As Pen = New Pen(Color.Black, 1)
                e.Graphics.DrawRectangle(pen, e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Height - 4, e.Bounds.Height - 4)
            End Using
            e.Graphics.FillRectangle(CType(bo.Brush, C1.Win.Schedule.C1Brush).Brush, e.Bounds.X + 3, e.Bounds.Y + 3, e.Bounds.Height - 5, e.Bounds.Height - 5)

            ' draw the current item text based on the current Font
            Using brush As Brush = New SolidBrush(e.ForeColor)
                e.Graphics.DrawString(bo.ToString(), e.Font, brush, e.Bounds.X + e.Bounds.Height, e.Bounds.Y)
            End Using
            ' if the ListBox has focus, draw a focus rectangle around the selected item
            e.DrawFocusRectangle()
        End If
    End Sub
    Private Sub _cmbStatus_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _cmbStatus.SelectedValueChanged
        _appEdited.BusyStatus = CType(_cmbStatus.SelectedItem, Status)
    End Sub

    Private Sub FillReminders()
		RemoveHandler _cmbReminder.SelectedIndexChanged, AddressOf _cmbReminder_SelectedIndexChanged
		_cmbReminder.Items.Clear()
		AddReminderItem("None", Nothing)
        AddReminderItem("0 minutes", TimeSpan.Zero)
        AddReminderItem("5 minutes", TimeSpan.FromMinutes(5))
        AddReminderItem("10 minutes", TimeSpan.FromMinutes(10))
        AddReminderItem("15 minutes", TimeSpan.FromMinutes(15))
        AddReminderItem("30 minutes", TimeSpan.FromMinutes(30))
        AddReminderItem("1 hour", TimeSpan.FromHours(1))
        AddReminderItem("2 hours", TimeSpan.FromHours(2))
        AddReminderItem("3 hours", TimeSpan.FromHours(3))
        AddReminderItem("4 hours", TimeSpan.FromHours(4))
        AddReminderItem("5 hours", TimeSpan.FromHours(5))
        AddReminderItem("6 hours", TimeSpan.FromHours(6))
        AddReminderItem("7 hours", TimeSpan.FromHours(7))
        AddReminderItem("8 hours", TimeSpan.FromHours(8))
        AddReminderItem("9 hours", TimeSpan.FromHours(9))
        AddReminderItem("10 hours", TimeSpan.FromHours(10))
        AddReminderItem("11 hours", TimeSpan.FromHours(11))
        AddReminderItem("12 hours", TimeSpan.FromHours(12))
        AddReminderItem("18 hours", TimeSpan.FromHours(18))
        AddReminderItem("1 day", TimeSpan.FromDays(1))
        AddReminderItem("2 days", TimeSpan.FromDays(2))
        AddReminderItem("3 days", TimeSpan.FromDays(3))
        AddReminderItem("4 days", TimeSpan.FromDays(4))
        AddReminderItem("1 week", TimeSpan.FromDays(7))
        AddReminderItem("2 weeks", TimeSpan.FromDays(14))
        _cmbReminder.SelectedIndex = 0
        If (_appEdited.ReminderSet) Then
            For i As Integer = 1 To _cmbReminder.Items.Count - 1 Step 1
                If (CType(_cmbReminder.Items(i).Tag, TimeSpan) = _appEdited.ReminderTimeBeforeStart) Then
                    _cmbReminder.SelectedIndex = i
                    Exit For
                End If
            Next i
        End If
        AddHandler _cmbReminder.SelectedIndexChanged, AddressOf _cmbReminder_SelectedIndexChanged
    End Sub
    Private Sub AddReminderItem(ByVal text As String, ByVal tag As Object)
        Dim btn As RibbonButton = New RibbonButton(text)
        btn.Tag = tag
        _cmbReminder.Items.Add(btn)
    End Sub
    Private Sub _cmbReminder_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _cmbReminder.SelectedIndexChanged
        If (_cmbReminder.SelectedIndex = 0) Then
            _appEdited.ReminderSet = False
        Else
            _appEdited.ReminderSet = True
            _appEdited.ReminderTimeBeforeStart = CType(_cmbReminder.SelectedItem.Tag, TimeSpan)
        End If
    End Sub
#End Region

#Region "Zoom"
	Private Sub InitZoom()
		_galleryZoom.Items.Clear()
		For i As Integer = 75 To 150 Step 25
			_galleryZoom.Items.Add(i.ToString() + " %")
		Next i
		_galleryZoom.Items.Add("200 %")
		_galleryZoom.Items.Add("400 %")
	End Sub
    Private Sub _txtBody_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles _txtBody.Enter
        _galleryZoom.Enabled = True
	End Sub
	Private Sub SetCurrentZoom()
		If Me.Created Then
			' initialize zoom here, at earlier initialization it might be lost for empty RichTextBox
			Dim currentZoom As String = CType((ZoomFactor * 100), Integer).ToString()
			For Each item As RibbonGalleryItem In _galleryZoom.Items
				If (item.Text.StartsWith(currentZoom)) Then
					_galleryZoom.SelectedIndex = _galleryZoom.Items.IndexOf(item)
					Exit For
				End If
			Next
		End If
	End Sub
	Private Sub _galleryZoom_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles _galleryZoom.SelectedIndexChanged
		Dim factor As Integer = Integer.Parse(_galleryZoom.SelectedItem.Text.Substring(0, _galleryZoom.SelectedItem.Text.Length - 2))
		_txtBody.ZoomFactor = CType(factor, Single) / 100
		ZoomFactor = _txtBody.ZoomFactor
	End Sub
#End Region
End Class