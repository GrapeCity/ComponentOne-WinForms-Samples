Imports C1.Framework
Imports C1.C1Schedule

Namespace TestSchedule
	Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.splitter1 = New System.Windows.Forms.Splitter
            Me.menuStrip1 = New System.Windows.Forms.MenuStrip
            Me._exit = New System.Windows.Forms.ToolStripMenuItem
            Me._today = New System.Windows.Forms.ToolStripMenuItem
            Me.clearWeekToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.copyDayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.copyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
            Me.c1Schedule1 = New C1.Win.C1Schedule.C1Schedule
            Me.c1Calendar1 = New C1.Win.C1Schedule.C1Calendar
            Me.menuStrip1.SuspendLayout()
            CType(Me.c1Schedule1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.c1Schedule1.DataStorage.AppointmentStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.c1Schedule1.DataStorage.CategoryStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.c1Schedule1.DataStorage.ContactStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.c1Schedule1.DataStorage.LabelStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.c1Schedule1.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.c1Schedule1.DataStorage.StatusStorage, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'splitter1
            '
            Me.splitter1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.splitter1.Location = New System.Drawing.Point(272, 26)
            Me.splitter1.Name = "splitter1"
            Me.splitter1.Size = New System.Drawing.Size(3, 537)
            Me.splitter1.TabIndex = 1
            Me.splitter1.TabStop = False
            '
            'menuStrip1
            '
            Me.menuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me._exit, Me._today, Me.clearWeekToolStripMenuItem, Me.copyDayToolStripMenuItem, Me.copyToolStripMenuItem})
            Me.menuStrip1.Location = New System.Drawing.Point(0, 0)
            Me.menuStrip1.Name = "menuStrip1"
            Me.menuStrip1.ShowItemToolTips = True
            Me.menuStrip1.Size = New System.Drawing.Size(876, 26)
            Me.menuStrip1.TabIndex = 3
            Me.menuStrip1.Text = "menuStrip1"
            '
            '_exit
            '
            Me._exit.Name = "_exit"
            Me._exit.Size = New System.Drawing.Size(43, 22)
            Me._exit.Text = "Exit"
            '
            '_today
            '
            Me._today.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
            Me._today.Name = "_today"
            Me._today.Size = New System.Drawing.Size(62, 22)
            Me._today.Text = "Today"
            '
            'clearWeekToolStripMenuItem
            '
            Me.clearWeekToolStripMenuItem.Name = "clearWeekToolStripMenuItem"
            Me.clearWeekToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
            Me.clearWeekToolStripMenuItem.Text = "Clear Week"
            Me.clearWeekToolStripMenuItem.ToolTipText = "Clear current week time table"
            '
            'copyDayToolStripMenuItem
            '
            Me.copyDayToolStripMenuItem.Name = "copyDayToolStripMenuItem"
            Me.copyDayToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
            Me.copyDayToolStripMenuItem.Text = "Copy Day..."
            Me.copyDayToolStripMenuItem.ToolTipText = "Copy current day timetable"
            '
            'copyToolStripMenuItem
            '
            Me.copyToolStripMenuItem.Name = "copyToolStripMenuItem"
            Me.copyToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
            Me.copyToolStripMenuItem.Text = "Copy Week..."
            Me.copyToolStripMenuItem.ToolTipText = "Copy current week time table"
            '
            'c1Schedule1
            '
            Me.c1Schedule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            '
            '
            '
            Me.c1Schedule1.CalendarInfo.DateFormatString = "M/d/yyyy"
            Me.c1Schedule1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("21:00:00")
            Me.c1Schedule1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("09:00:00")
            Me.c1Schedule1.CalendarInfo.TimeInterval = C1.C1Schedule.TimeScaleEnum.FifteenMinutes
            Me.c1Schedule1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:15:00")
            Me.c1Schedule1.CalendarInfo.WeekStart = System.DayOfWeek.Monday
            Me.c1Schedule1.CalendarInfo.WorkDays.AddRange(New System.DayOfWeek() {System.DayOfWeek.Sunday, System.DayOfWeek.Monday, System.DayOfWeek.Tuesday, System.DayOfWeek.Wednesday, System.DayOfWeek.Thursday, System.DayOfWeek.Friday, System.DayOfWeek.Saturday})
            '
            '
            '
            Me.c1Schedule1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.c1Schedule1.Settings.FirstVisibleTime = System.TimeSpan.Parse("00:00:00")
            Me.c1Schedule1.Location = New System.Drawing.Point(275, 26)
            Me.c1Schedule1.Name = "c1Schedule1"
            Me.c1Schedule1.ShowContextMenu = False
            Me.c1Schedule1.ShowReminderForm = False
            Me.c1Schedule1.ShowWorkTimeOnly = True
            Me.c1Schedule1.Size = New System.Drawing.Size(601, 537)
            Me.c1Schedule1.TabIndex = 2
            Me.c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WeekView
            Me.c1Schedule1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2007Blue
            '
            'c1Calendar1
            '
            Me.c1Calendar1.BoldedDates = New Date(-1) {}
            Me.c1Calendar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.c1Calendar1.CalendarDimensions = 3
            Me.c1Calendar1.Dock = System.Windows.Forms.DockStyle.Left
            Me.c1Calendar1.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.c1Calendar1.Location = New System.Drawing.Point(0, 26)
            Me.c1Calendar1.Name = "c1Calendar1"
            Me.c1Calendar1.Schedule = Me.c1Schedule1
            Me.c1Calendar1.ShowWeekNumbers = True
            Me.c1Calendar1.Size = New System.Drawing.Size(272, 537)
            Me.c1Calendar1.TabIndex = 0
            Me.c1Calendar1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2007Blue
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(876, 563)
            Me.Controls.Add(Me.c1Schedule1)
            Me.Controls.Add(Me.splitter1)
            Me.Controls.Add(Me.c1Calendar1)
            Me.Controls.Add(Me.menuStrip1)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MainMenuStrip = Me.menuStrip1
            Me.Name = "Form1"
            Me.Text = "Fitness Center Time Table"
            Me.menuStrip1.ResumeLayout(False)
            Me.menuStrip1.PerformLayout()
            CType(Me.c1Schedule1.DataStorage.AppointmentStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.c1Schedule1.DataStorage.CategoryStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.c1Schedule1.DataStorage.ContactStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.c1Schedule1.DataStorage.LabelStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.c1Schedule1.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.c1Schedule1.DataStorage.StatusStorage, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.c1Schedule1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

        Friend WithEvents c1Calendar1 As C1.Win.C1Schedule.C1Calendar
        Friend WithEvents splitter1 As System.Windows.Forms.Splitter
        Friend WithEvents menuStrip1 As System.Windows.Forms.MenuStrip
        Friend WithEvents c1Schedule1 As C1.Win.C1Schedule.C1Schedule
        Friend WithEvents _today As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents _exit As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents copyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents clearWeekToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents copyDayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	End Class
End Namespace

