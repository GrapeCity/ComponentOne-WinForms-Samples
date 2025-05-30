Imports C1.Win.C1Schedule
Imports C1.C1Schedule
Imports System.Data
Imports System.ComponentModel
Imports System.IO

Public Class Form1
#Region "Initialization"

    Dim _initialized As Boolean = False

    ' On form loading fill data adapters in order to load data from the database.
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
        ' suspend C1Schedule updates while loading data
        C1Schedule1.BeginUpdate()
        Me.CustomersTableAdapter1.Fill(C1NwindDataSet1.Customers_Multi)
        Me.EmployeesTableAdapter1.Fill(C1NwindDataSet1.Employees)
        Me.AppointmentsTableAdapter1.Fill(C1NwindDataSet1.Appointments_Multi)

        ' set correct MenuCaption for contacts (Customers)
        For Each cnt As Contact In C1Schedule1.DataStorage.ContactStorage.Contacts
            Dim row As MultiUser.C1NWindDataSet.Customers_MultiRow = Me.C1NwindDataSet1.Customers_Multi.FindByCustomerId(cnt.Key(0))
            If row IsNot Nothing Then
                cnt.MenuCaption = row("CompanyName").ToString() + " (" + row("ContactName").ToString() + ")"
            End If
        Next cnt

        ' set correct MenuCaption for owners (Employees)
        For Each cnt As Contact In C1Schedule1.DataStorage.OwnerStorage.Contacts
            Dim row As MultiUser.C1NWindDataSet.EmployeesRow = Me.C1NwindDataSet1.Employees.FindByEmployeeID(cnt.Key(0))
            If row IsNot Nothing Then
                cnt.MenuCaption = row("FirstName").ToString() + " " + row("LastName").ToString()
            End If
            lstCalendarOwners.Items.Add(cnt)
        Next cnt
        For i As Integer = 0 To lstCalendarOwners.Items.Count - 1
            ' check all items
            lstCalendarOwners.SetItemChecked(i, True)
        Next
        ' resume C1Schedule updates
        C1Schedule1.EndUpdate()

        ' preview C1Schedule context menu actions
        AddHandler C1Schedule1.ContextMenuStrip.MouseClick, AddressOf ContextMenuStrip_MouseClick

        _initialized = True
    End Sub
#End Region

#Region "Exit"
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    ' On form closing update data adapters in order to save data to the database.
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Me.EmployeesTableAdapter1.Update(NwindDataSet1.Employees)
        Me.AppointmentsTableAdapter1.Update(C1NwindDataSet1.Appointments_Multi)
    End Sub
#End Region

#Region "Navigation"
    Private Sub TodayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodayToolStripMenuItem.Click
        ' Go to today date.
        Me.C1Schedule1.GoToDate(DateTime.Today)
    End Sub

    Private Sub MonthViewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthViewToolStripMenuItem.Click
        ' Switch to the MonthView.
        Me.C1Schedule1.ViewType = ScheduleViewEnum.MonthView
    End Sub

    Private Sub TimeLineViewMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeLineViewMenuItem.Click
        ' Switch to the TimeLineView.
        Me.C1Schedule1.ViewType = ScheduleViewEnum.TimeLineView
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
#End Region

#Region "Show/Hide calendars"
    Private Sub lstCalendarOwners_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lstCalendarOwners.ItemCheck
        If Not _initialized Then
            Return
        End If

        ' update ScheduleGroupItem.IsChecked property
        Dim cnt As Contact = lstCalendarOwners.Items(e.Index)
        C1Schedule1.GroupItems(cnt).IsChecked = (e.NewValue = CheckState.Checked)
    End Sub
#End Region

#Region "Format group headers"
    Private Sub C1Schedule1_BeforeGroupHeaderFormat(ByVal sender As System.Object, ByVal e As C1.Win.C1Schedule.BeforeGroupHeaderFormatEventArgs) Handles C1Schedule1.BeforeGroupHeaderFormat
        Dim contact As Contact = e.Group.Owner
        If contact IsNot Nothing Then
            Dim row As MultiUser.C1NWindDataSet.EmployeesRow = Me.C1NwindDataSet1.Employees.FindByEmployeeID(contact.Key(0))
            If row IsNot Nothing Then
                Dim imageName As String = "photo" + row.EmployeeID.ToString() + ".bmp"
                If Not File.Exists(imageName) Then
                    ' resize and cache image into the working directory
                    Using ms As MemoryStream = New MemoryStream(row.Photo, 78, row.Photo.Length - 78)
                        Dim bmp As Bitmap = Image.FromStream(ms, True)
                        Dim bmp1 As Bitmap = ResizeImage(bmp, 82, 94)
                        bmp1.Save(imageName, System.Drawing.Imaging.ImageFormat.Bmp)
                    End Using
                End If
                ' use image from file
                ' note, C1Schedule only accepts images from internet (http://..), 
                ' application resources (res://..) and local file system (file:///..).
				e.Html = row.FirstName + " " + row.LastName + "&nbsp;<br><img STYLE='padding-top:1mm' src=file:///" + imageName + "/>"
            End If
            If e.Style.Hot IsNot Nothing Then
                ' Hot style is applied to the group header when ScheduleGroupItem is selected.
                e.Style.Hot.BackColor2 = Color.DarkSlateGray
                e.Style.Hot.BorderColor = Color.DarkSlateGray
                e.Style.Hot.ForeColor = Color.WhiteSmoke
            End If
        End If
        ' uncomment the next line to use rectangular group headers
        ' e.TriangleTab = False
    End Sub

    ''' <summary>
    ''' Resize the image to the specified width and height. 
    ''' </summary>
    ''' <param name="image">The image to resize.</param>        
    ''' <param name="width">The width to resize to.</param>        
    ''' <param name="height">The height to resize to.</param>        
    ''' <returns>The resized image.</returns>  
    Public Shared Function ResizeImage(ByVal image As System.Drawing.Image, ByVal width As Integer, ByVal height As Integer) As System.Drawing.Bitmap
        ' a holder for the result    
        Dim result As Bitmap = New Bitmap(width, height)
        ' use a graphics object to draw the resized image into the bitmap            
        Using graphics As Graphics = graphics.FromImage(result)
            ' set the resize quality modes to high quality                
            graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality
            graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality
            ' draw the image into the target bitmap                
            graphics.DrawImage(image, 0, 0, result.Width, result.Height)
        End Using
        ' return the resulting bitmap            
        Return result
    End Function
#End Region

#Region "Show custom forms"
    Dim _createRecurrenceFlag As Boolean = False

    Private Sub ContextMenuStrip_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        _createRecurrenceFlag = False
        Dim item As ToolStripItem = C1Schedule1.ContextMenuStrip.GetItemAt(e.Location)
        If (item IsNot Nothing) Then
            ' use this flag to open recurrence form automatically for the new recurring apps
            If (item.Owner.Tag Is Nothing) Then

                Select Case item.Name
                    Case "NewRecurringAppointment"
                    Case "NewRecurringEvent"
                        ' create recurrence
                        _createRecurrenceFlag = True
                End Select
            End If
        End If
    End Sub

    Private Sub c1Schedule1_BeforeAppointmentCreate(ByVal sender As Object, ByVal e As CancelAppointmentEventArgs) Handles C1Schedule1.BeforeAppointmentCreate
        ' set default status and label
        e.Appointment.BusyStatus = C1Schedule1.DataStorage.StatusStorage.Statuses(New Guid("{E6569EEF-845E-41FE-8772-C7A252D467F9}")) ' unknown status
        e.Appointment.Label = C1Schedule1.DataStorage.LabelStorage.Labels(New Guid("{D3F876F9-881B-478C-8594-4941B92D6424}")) ' none
    End Sub

    Private Sub c1Schedule1_BeforeAppointmentShow(ByVal sender As Object, ByVal e As CancelAppointmentEventArgs) Handles C1Schedule1.BeforeAppointmentShow
        ' Don't show built-in form
        e.Cancel = True
        Dim appointment As Appointment = e.Appointment
        For Each f As Form In Application.OpenForms
            ' activate form if it is already opened
            If TypeOf f Is AppointmentForm Then
                If DirectCast(f, AppointmentForm).Appointment.Equals(e.Appointment) Then
                    f.BringToFront()
                    Return
                End If
            End If
        Next
        If (appointment.RecurrenceState = RecurrenceStateEnum.Exception Or appointment.RecurrenceState = RecurrenceStateEnum.Occurrence) Then
            ' show Series dialog
            Dim dial As SeriesDialog = New SeriesDialog(appointment.Subject)
            If (dial.ShowDialog() = DialogResult.OK) Then
                If (dial.Series) Then
                    ' if customer selected Series, switch to the master appointment
                    appointment = appointment.ParentRecurrence
                    For Each f As Form In Application.OpenForms
                        ' activate form if it is already opened
                        If TypeOf f Is AppointmentForm Then
                            If DirectCast(f, AppointmentForm).Appointment.Equals(e.Appointment) Then
                                f.BringToFront()
                                Return
                            End If
                        End If
                    Next
                End If
            Else
                ' do nothing
                Return
            End If
        End If
        ' Create AppointmentForm for selected Appointment
        If _createRecurrenceFlag Then
            _createRecurrenceFlag = False
            appointment.Tag = "Create recurrence"
        End If
        Dim form As AppointmentForm = New AppointmentForm(C1Schedule1, appointment)
        form.Show(Me)
    End Sub

    ' update list of available locations
    ' you can remove the next methods if you use C1Schedule build 184 or later
    Private Sub c1Schedule1_AppointmentAdded(ByVal sender As Object, ByVal e As AppointmentEventArgs) Handles C1Schedule1.AppointmentAdded
        UpdateAvailableLocation(e.Appointment.Location)
    End Sub

    Private Sub c1Schedule1_AppointmentChanged(ByVal sender As Object, ByVal e As AppointmentEventArgs) Handles C1Schedule1.AppointmentChanged
        UpdateAvailableLocation(e.Appointment.Location)
    End Sub

    Private Sub UpdateAvailableLocation(ByVal location As String)
        If ((Not String.IsNullOrEmpty(location)) And Not AppointmentForm.Locations.Contains(location)) Then
            SyncLock AppointmentForm.Locations
                AppointmentForm.Locations.Add(location)
            End SyncLock
        End If
    End Sub

#End Region

End Class
