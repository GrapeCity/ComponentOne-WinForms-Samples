<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim PrintStyle1 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle
        Dim PrintStyle2 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle
        Dim PrintStyle3 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle
        Dim PrintStyle4 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle
        Dim PrintStyle5 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DayViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WorkWeekViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WeekViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MonthViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TodayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.C1Calendar1 = New C1.Win.C1Schedule.C1Calendar
        Me.C1Schedule1 = New C1.Win.C1Schedule.C1Schedule
        Me.C1NwindDataSet1 = New MultiUser.C1NWindDataSet
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.lstCalendarOwners = New System.Windows.Forms.CheckedListBox
        Me.AppointmentsTableAdapter1 = New MultiUser.C1NWindDataSetTableAdapters.Appointments_MultiTableAdapter
        Me.EmployeesTableAdapter1 = New MultiUser.C1NWindDataSetTableAdapters.EmployeesTableAdapter
        Me.CustomersTableAdapter1 = New MultiUser.C1NWindDataSetTableAdapters.Customers_MultiTableAdapter
        Me.TimeLineViewMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        CType(Me.C1Calendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.AppointmentStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.CategoryStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.ContactStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.LabelStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.OwnerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1Schedule1.DataStorage.StatusStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DayViewToolStripMenuItem, Me.WorkWeekViewToolStripMenuItem, Me.WeekViewToolStripMenuItem, Me.MonthViewToolStripMenuItem, Me.TimeLineViewMenuItem, Me.TodayToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(1008, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'DayViewToolStripMenuItem
        '
        Me.DayViewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DayViewToolStripMenuItem.Image = CType(resources.GetObject("DayViewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DayViewToolStripMenuItem.Name = "DayViewToolStripMenuItem"
        Me.DayViewToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        Me.DayViewToolStripMenuItem.Text = "Day View"
        '
        'WorkWeekViewToolStripMenuItem
        '
        Me.WorkWeekViewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WorkWeekViewToolStripMenuItem.Image = CType(resources.GetObject("WorkWeekViewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WorkWeekViewToolStripMenuItem.Name = "WorkWeekViewToolStripMenuItem"
        Me.WorkWeekViewToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        Me.WorkWeekViewToolStripMenuItem.Text = "Work Week View"
        '
        'WeekViewToolStripMenuItem
        '
        Me.WeekViewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WeekViewToolStripMenuItem.Image = CType(resources.GetObject("WeekViewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.WeekViewToolStripMenuItem.Name = "WeekViewToolStripMenuItem"
        Me.WeekViewToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        Me.WeekViewToolStripMenuItem.Text = "Week View"
        '
        'MonthViewToolStripMenuItem
        '
        Me.MonthViewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MonthViewToolStripMenuItem.Image = CType(resources.GetObject("MonthViewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MonthViewToolStripMenuItem.Name = "MonthViewToolStripMenuItem"
        Me.MonthViewToolStripMenuItem.Size = New System.Drawing.Size(28, 20)
        Me.MonthViewToolStripMenuItem.Text = "Month View"
        '
        'TodayToolStripMenuItem
        '
        Me.TodayToolStripMenuItem.Name = "TodayToolStripMenuItem"
        Me.TodayToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.TodayToolStripMenuItem.Text = "Today"
        '
        'C1Calendar1
        '
        Me.C1Calendar1.BoldedDates = New Date(-1) {}
        Me.C1Calendar1.CalendarDimensions = 3
        Me.C1Calendar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Calendar1.Location = New System.Drawing.Point(0, 0)
        Me.C1Calendar1.Margin = New System.Windows.Forms.Padding(2)
        Me.C1Calendar1.Name = "C1Calendar1"
        Me.C1Calendar1.Schedule = Me.C1Schedule1
        Me.C1Calendar1.Size = New System.Drawing.Size(180, 282)
        Me.C1Calendar1.TabIndex = 1
        Me.C1Calendar1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2010Silver
        '
        'C1Schedule1
        '
        '
        '
        '
        Me.C1Calendar1.CalendarInfo.CultureInfo = New System.Globalization.CultureInfo("en-US")
        Me.C1Calendar1.CalendarInfo.DateFormatString = "M/d/yyyy"
        Me.C1Calendar1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00")
        Me.C1Calendar1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00")
        Me.C1Calendar1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00")
        Me.C1Calendar1.CalendarInfo.WeekStart = System.DayOfWeek.Monday
        Me.C1Calendar1.CalendarInfo.WorkDays.AddRange(New System.DayOfWeek() {System.DayOfWeek.Monday, System.DayOfWeek.Tuesday, System.DayOfWeek.Wednesday, System.DayOfWeek.Thursday, System.DayOfWeek.Friday})
        '
        '
        '
        '
        '
        '
        Me.C1Schedule1.DataStorage.AppointmentStorage.DataMember = "Appointments_Multi"
        Me.C1Schedule1.DataStorage.AppointmentStorage.DataSource = Me.C1NwindDataSet1
        '
        '
        '
        '
        '
        '
        Me.C1Schedule1.DataStorage.AppointmentStorage.Mappings.AppointmentProperties.MappingName = "Properties"
        '
        '
        '
        Me.C1Schedule1.DataStorage.AppointmentStorage.Mappings.Body.MappingName = "Description"
        '
        '
        '
        Me.C1Schedule1.DataStorage.AppointmentStorage.Mappings.End.MappingName = "End"
        '
        '
        '
        Me.C1Schedule1.DataStorage.AppointmentStorage.Mappings.IdMapping.MappingName = "AppointmentId"
        '
        '
        '
        Me.C1Schedule1.DataStorage.AppointmentStorage.Mappings.Location.MappingName = "Location"
        '
        '
        '
        Me.C1Schedule1.DataStorage.AppointmentStorage.Mappings.OwnerIndexMapping.MappingName = "Owner"
        '
        '
        '
        Me.C1Schedule1.DataStorage.AppointmentStorage.Mappings.Start.MappingName = "Start"
        '
        '
        '
        Me.C1Schedule1.DataStorage.AppointmentStorage.Mappings.Subject.MappingName = "Subject"
        '
        '
        '
        Me.C1Schedule1.DataStorage.ContactStorage.DataMember = "Customers_Multi"
        Me.C1Schedule1.DataStorage.ContactStorage.DataSource = Me.C1NwindDataSet1
        '
        '
        '
        '
        '
        '
        Me.C1Schedule1.DataStorage.ContactStorage.Mappings.IdMapping.MappingName = "CustomerID"
        '
        '
        '
        Me.C1Schedule1.DataStorage.ContactStorage.Mappings.TextMapping.MappingName = "CompanyName"
        '
        '
        '
        Me.C1Schedule1.DataStorage.OwnerStorage.DataMember = "Employees"
        Me.C1Schedule1.DataStorage.OwnerStorage.DataSource = Me.C1NwindDataSet1
        '
        '
        '
        '
        '
        '
        Me.C1Schedule1.DataStorage.OwnerStorage.Mappings.IndexMapping.MappingName = "EmployeeID"
        '
        '
        '
        Me.C1Schedule1.DataStorage.OwnerStorage.Mappings.TextMapping.MappingName = "FirstName"
        Me.C1Schedule1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Schedule1.GroupBy = "Owner"
        Me.C1Schedule1.GroupPageSize = 3
        Me.C1Schedule1.Location = New System.Drawing.Point(0, 0)
        Me.C1Schedule1.Margin = New System.Windows.Forms.Padding(2)
        Me.C1Schedule1.Name = "C1Schedule1"
        PrintStyle1.Description = "Daily Style"
        PrintStyle1.PreviewImage = CType(resources.GetObject("PrintStyle1.PreviewImage"), System.Drawing.Image)
        PrintStyle1.StyleName = "Daily"
        PrintStyle1.StyleSource = "day.c1d"
        PrintStyle2.Description = "Weekly Style"
        PrintStyle2.PreviewImage = CType(resources.GetObject("PrintStyle2.PreviewImage"), System.Drawing.Image)
        PrintStyle2.StyleName = "Week"
        PrintStyle2.StyleSource = "week.c1d"
        PrintStyle3.Description = "Monthly Style"
        PrintStyle3.PreviewImage = CType(resources.GetObject("PrintStyle3.PreviewImage"), System.Drawing.Image)
        PrintStyle3.StyleName = "Month"
        PrintStyle3.StyleSource = "month.c1d"
        PrintStyle4.Description = "Details Style"
        PrintStyle4.PreviewImage = CType(resources.GetObject("PrintStyle4.PreviewImage"), System.Drawing.Image)
        PrintStyle4.StyleName = "Details"
        PrintStyle4.StyleSource = "details.c1d"
        PrintStyle5.Context = C1.C1Schedule.Printing.PrintContextType.Appointment
        PrintStyle5.Description = "Memo Style"
        PrintStyle5.PreviewImage = CType(resources.GetObject("PrintStyle5.PreviewImage"), System.Drawing.Image)
        PrintStyle5.StyleName = "Memo"
        PrintStyle5.StyleSource = "memo.c1d"
        Me.C1Schedule1.PrintInfo.PrintStyles.AddRange(New C1.C1Schedule.Printing.PrintStyle() {PrintStyle1, PrintStyle2, PrintStyle3, PrintStyle4, PrintStyle5})
        '
        '
        '
        Me.C1Schedule1.Settings.AllowContactsEditing = False
        Me.C1Schedule1.Settings.FirstVisibleTime = System.TimeSpan.Parse("07:00:00")
        Me.C1Schedule1.Size = New System.Drawing.Size(824, 580)
        Me.C1Schedule1.TabIndex = 3
        Me.C1Schedule1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2010Silver
        '
        'NwindDataSet1
        '
        Me.C1NwindDataSet1.DataSetName = "NwindDataSet"
        Me.C1NwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel1MinSize = 150
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.C1Schedule1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1008, 580)
        Me.SplitContainer1.SplitterDistance = 180
        Me.SplitContainer1.TabIndex = 4
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.C1Calendar1)
        Me.SplitContainer2.Panel1MinSize = 150
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lstCalendarOwners)
        Me.SplitContainer2.Size = New System.Drawing.Size(180, 580)
        Me.SplitContainer2.SplitterDistance = 282
        Me.SplitContainer2.TabIndex = 0
        '
        'lstCalendarOwners
        '
        Me.lstCalendarOwners.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstCalendarOwners.FormattingEnabled = True
        Me.lstCalendarOwners.Location = New System.Drawing.Point(0, 0)
        Me.lstCalendarOwners.Name = "lstCalendarOwners"
        Me.lstCalendarOwners.Size = New System.Drawing.Size(180, 289)
        Me.lstCalendarOwners.TabIndex = 0
        '
        'AppointmentsTableAdapter1
        '
        Me.AppointmentsTableAdapter1.ClearBeforeFill = True
        '
        'EmployeesTableAdapter1
        '
        Me.EmployeesTableAdapter1.ClearBeforeFill = True
        '
        'CustomersTableAdapter1
        '
        Me.CustomersTableAdapter1.ClearBeforeFill = True
        '
        'TimeLineViewMenuItem
        '
        Me.TimeLineViewMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TimeLineViewMenuItem.Image = CType(resources.GetObject("TimeLineViewMenuItem.Image"), System.Drawing.Image)
        Me.TimeLineViewMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TimeLineViewMenuItem.Name = "TimeLineViewMenuItem"
        Me.TimeLineViewMenuItem.Size = New System.Drawing.Size(28, 20)
        Me.TimeLineViewMenuItem.ToolTipText = "Time Line"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 604)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.C1Calendar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.AppointmentStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.CategoryStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.ContactStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.LabelStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.OwnerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1.DataStorage.StatusStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1Schedule1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DayViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkWeekViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WeekViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C1Calendar1 As C1.Win.C1Schedule.C1Calendar
    Friend WithEvents C1Schedule1 As C1.Win.C1Schedule.C1Schedule
    Friend WithEvents C1NwindDataSet1 As MultiUser.C1NWindDataSet
    Friend WithEvents AppointmentsTableAdapter1 As MultiUser.C1NWindDataSetTableAdapters.Appointments_MultiTableAdapter
    Friend WithEvents EmployeesTableAdapter1 As MultiUser.C1NWindDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lstCalendarOwners As System.Windows.Forms.CheckedListBox
    Friend WithEvents CustomersTableAdapter1 As MultiUser.C1NWindDataSetTableAdapters.Customers_MultiTableAdapter
    Friend WithEvents TimeLineViewMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
