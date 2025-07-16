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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim PrintStyle1 As C1.Schedule.Printing.PrintStyle = New C1.Schedule.Printing.PrintStyle()
        Dim PrintStyle2 As C1.Schedule.Printing.PrintStyle = New C1.Schedule.Printing.PrintStyle()
        Dim PrintStyle3 As C1.Schedule.Printing.PrintStyle = New C1.Schedule.Printing.PrintStyle()
        Dim PrintStyle4 As C1.Schedule.Printing.PrintStyle = New C1.Schedule.Printing.PrintStyle()
        Dim PrintStyle5 As C1.Schedule.Printing.PrintStyle = New C1.Schedule.Printing.PrintStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DayViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkWeekViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeekViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeLineViewMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualStyleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbVisualStyle = New System.Windows.Forms.ToolStripComboBox()
        Me.GroupingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NoneToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupPageSizeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmbGroupPageSize = New System.Windows.Forms.ToolStripComboBox()
        Me.ShowEmptyGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C1Calendar1 = New C1.Win.Schedule.C1Calendar()
        Me.C1Schedule1 = New C1.Win.Schedule.C1Schedule()
        Me.C1NWindDataSet1 = New C1ScheduleDemo.C1NWindDataSet()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.AppointmentsTableAdapter1 = New C1ScheduleDemo.C1NWindDataSetTableAdapters.AppointmentsTableAdapter()
        Me.EmployeesTableAdapter1 = New C1ScheduleDemo.C1NWindDataSetTableAdapters.AppointeesTableAdapter()
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
        CType(Me.C1NWindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DayViewToolStripMenuItem, Me.WorkWeekViewToolStripMenuItem, Me.WeekViewToolStripMenuItem, Me.MonthViewToolStripMenuItem, Me.TimeLineViewMenuItem, Me.TodayToolStripMenuItem, Me.VisualStyleToolStripMenuItem, Me.GroupingToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.ShowItemToolTips = True
        Me.MenuStrip1.Size = New System.Drawing.Size(631, 24)
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
        'TimeLineViewMenuItem
        '
        Me.TimeLineViewMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TimeLineViewMenuItem.Image = CType(resources.GetObject("TimeLineViewMenuItem.Image"), System.Drawing.Image)
        Me.TimeLineViewMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TimeLineViewMenuItem.Name = "TimeLineViewMenuItem"
        Me.TimeLineViewMenuItem.Size = New System.Drawing.Size(28, 20)
        Me.TimeLineViewMenuItem.ToolTipText = "Time Line"
        '
        'TodayToolStripMenuItem
        '
        Me.TodayToolStripMenuItem.Name = "TodayToolStripMenuItem"
        Me.TodayToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.TodayToolStripMenuItem.Text = "Today"
        '
        'VisualStyleToolStripMenuItem
        '
        Me.VisualStyleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbVisualStyle})
        Me.VisualStyleToolStripMenuItem.Name = "VisualStyleToolStripMenuItem"
        Me.VisualStyleToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.VisualStyleToolStripMenuItem.Text = "Visual Style"
        '
        'cmbVisualStyle
        '
        Me.cmbVisualStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVisualStyle.Name = "cmbVisualStyle"
        Me.cmbVisualStyle.Size = New System.Drawing.Size(121, 23)
        '
        'GroupingToolStripMenuItem
        '
        Me.GroupingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoneToolStripMenuItem, Me.GroupPageSizeToolStripMenuItem, Me.ShowEmptyGroupToolStripMenuItem})
        Me.GroupingToolStripMenuItem.Name = "GroupingToolStripMenuItem"
        Me.GroupingToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.GroupingToolStripMenuItem.Text = "Grouping"
        '
        'NoneToolStripMenuItem
        '
        Me.NoneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NoneToolStripMenuItem1, Me.ContactToolStripMenuItem, Me.CategoryToolStripMenuItem, Me.ResourceToolStripMenuItem})
        Me.NoneToolStripMenuItem.Name = "NoneToolStripMenuItem"
        Me.NoneToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.NoneToolStripMenuItem.Text = "Group By"
        '
        'NoneToolStripMenuItem1
        '
        Me.NoneToolStripMenuItem1.Checked = True
        Me.NoneToolStripMenuItem1.CheckOnClick = True
        Me.NoneToolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NoneToolStripMenuItem1.Name = "NoneToolStripMenuItem1"
        Me.NoneToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.NoneToolStripMenuItem1.Text = "None"
        '
        'ContactToolStripMenuItem
        '
        Me.ContactToolStripMenuItem.CheckOnClick = True
        Me.ContactToolStripMenuItem.Name = "ContactToolStripMenuItem"
        Me.ContactToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContactToolStripMenuItem.Text = "Contact"
        '
        'CategoryToolStripMenuItem
        '
        Me.CategoryToolStripMenuItem.CheckOnClick = True
        Me.CategoryToolStripMenuItem.Name = "CategoryToolStripMenuItem"
        Me.CategoryToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.CategoryToolStripMenuItem.Text = "Category"
        '
        'ResourceToolStripMenuItem
        '
        Me.ResourceToolStripMenuItem.CheckOnClick = True
        Me.ResourceToolStripMenuItem.Name = "ResourceToolStripMenuItem"
        Me.ResourceToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ResourceToolStripMenuItem.Text = "Resource"
        '
        'GroupPageSizeToolStripMenuItem
        '
        Me.GroupPageSizeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmbGroupPageSize})
        Me.GroupPageSizeToolStripMenuItem.Name = "GroupPageSizeToolStripMenuItem"
        Me.GroupPageSizeToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.GroupPageSizeToolStripMenuItem.Text = "Group Page Size"
        '
        'cmbGroupPageSize
        '
        Me.cmbGroupPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGroupPageSize.DropDownWidth = 30
        Me.cmbGroupPageSize.Margin = New System.Windows.Forms.Padding(0)
        Me.cmbGroupPageSize.MaxLength = 2
        Me.cmbGroupPageSize.Name = "cmbGroupPageSize"
        Me.cmbGroupPageSize.Size = New System.Drawing.Size(75, 23)
        '
        'ShowEmptyGroupToolStripMenuItem
        '
        Me.ShowEmptyGroupToolStripMenuItem.CheckOnClick = True
        Me.ShowEmptyGroupToolStripMenuItem.Name = "ShowEmptyGroupToolStripMenuItem"
        Me.ShowEmptyGroupToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ShowEmptyGroupToolStripMenuItem.Text = "Show Empty Group"
        '
        'C1Calendar1
        '
        Me.C1Calendar1.BoldedDates = New Date(-1) {}
        Me.C1Calendar1.CalendarDimensions = 3
        Me.C1Calendar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.C1Calendar1.Location = New System.Drawing.Point(0, 24)
        Me.C1Calendar1.Margin = New System.Windows.Forms.Padding(2)
        Me.C1Calendar1.Name = "C1Calendar1"
        Me.C1Calendar1.Schedule = Me.C1Schedule1
        Me.C1Calendar1.Size = New System.Drawing.Size(200, 436)
        Me.C1Calendar1.TabIndex = 1
        '
        'C1Schedule1
        '
        '
        '
        '
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
        Me.C1Schedule1.DataStorage.AppointmentStorage.DataMember = "Appointments"
        Me.C1Schedule1.DataStorage.AppointmentStorage.DataSource = Me.C1NWindDataSet1
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
        Me.C1Schedule1.DataStorage.AppointmentStorage.Mappings.Body.MappingName = "Body"
        '
        '
        '
        Me.C1Schedule1.DataStorage.AppointmentStorage.Mappings.End.MappingName = "End"
        '
        '
        '
        Me.C1Schedule1.DataStorage.AppointmentStorage.Mappings.IdMapping.MappingName = "Id"
        '
        '
        '
        Me.C1Schedule1.DataStorage.AppointmentStorage.Mappings.Location.MappingName = "Location"
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
        Me.C1Schedule1.DataStorage.ContactStorage.DataMember = "Appointees"
        Me.C1Schedule1.DataStorage.ContactStorage.DataSource = Me.C1NWindDataSet1
        '
        '
        '
        '
        '
        '
        Me.C1Schedule1.DataStorage.ContactStorage.Mappings.IndexMapping.MappingName = "EmployeeID"
        '
        '
        '
        Me.C1Schedule1.DataStorage.ContactStorage.Mappings.TextMapping.MappingName = "FirstName"
        Me.C1Schedule1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1Schedule1.GroupPageSize = 2
        Me.C1Schedule1.Location = New System.Drawing.Point(202, 24)
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
        PrintStyle5.Context = C1.Schedule.Printing.PrintContextType.Appointment
        PrintStyle5.Description = "Memo Style"
        PrintStyle5.PreviewImage = CType(resources.GetObject("PrintStyle5.PreviewImage"), System.Drawing.Image)
        PrintStyle5.StyleName = "Memo"
        PrintStyle5.StyleSource = "memo.c1d"
        Me.C1Schedule1.PrintInfo.PrintStyles.AddRange(New C1.Schedule.Printing.PrintStyle() {PrintStyle1, PrintStyle2, PrintStyle3, PrintStyle4, PrintStyle5})
        '
        '
        '
        Me.C1Schedule1.Settings.AllowCategoriesEditing = False
        Me.C1Schedule1.Settings.AllowCategoriesMultiSelection = False
        Me.C1Schedule1.Settings.AllowContactsEditing = False
        Me.C1Schedule1.Settings.AllowContactsMultiSelection = False
        Me.C1Schedule1.Settings.FirstVisibleTime = System.TimeSpan.Parse("07:00:00")
        Me.C1Schedule1.Size = New System.Drawing.Size(429, 436)
        Me.C1Schedule1.TabIndex = 3
        '
        'C1NWindDataSet1
        '
        Me.C1NWindDataSet1.DataSetName = "C1NWindDataSet"
        Me.C1NWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(200, 24)
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(2)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(2, 436)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'AppointmentsTableAdapter1
        '
        Me.AppointmentsTableAdapter1.ClearBeforeFill = True
        '
        'EmployeesTableAdapter1
        '
        Me.EmployeesTableAdapter1.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 460)
        Me.Controls.Add(Me.C1Schedule1)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.C1Calendar1)
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
        CType(Me.C1NWindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents C1Calendar1 As C1.Win.Schedule.C1Calendar
    Friend WithEvents C1Schedule1 As C1.Win.Schedule.C1Schedule
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents AppointmentsTableAdapter1 As C1ScheduleDemo.C1NWindDataSetTableAdapters.AppointmentsTableAdapter
    Friend WithEvents EmployeesTableAdapter1 As C1ScheduleDemo.C1NWindDataSetTableAdapters.AppointeesTableAdapter
    Friend WithEvents VisualStyleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbVisualStyle As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents GroupingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoneToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupPageSizeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbGroupPageSize As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ShowEmptyGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TimeLineViewMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C1NWindDataSet1 As C1ScheduleDemo.C1NWindDataSet

End Class
