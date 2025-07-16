using C1.Framework;
using C1.Schedule;

namespace CustomData
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this._exit = new System.Windows.Forms.ToolStripMenuItem();
			this._today = new System.Windows.Forms.ToolStripMenuItem();
			this.clearWeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.c1Schedule1 = new C1.Win.Schedule.C1Schedule();
			this.timeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fitnessClubDataSet = new CustomData.FitnessClubDataSet();
			this.instructorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.c1Calendar1 = new C1.Win.Schedule.C1Calendar();
			this.instructorsTableAdapter = new CustomData.FitnessClubDataSetTableAdapters.InstructorsTableAdapter();
			this.timeTableTableAdapter = new CustomData.FitnessClubDataSetTableAdapters.TimeTableTableAdapter();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// splitter1
			// 
			this.splitter1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.splitter1.Location = new System.Drawing.Point(272, 26);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 537);
			this.splitter1.TabIndex = 1;
			this.splitter1.TabStop = false;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._exit,
            this._today,
            this.clearWeekToolStripMenuItem,
            this.copyDayToolStripMenuItem,
            this.copyToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.ShowItemToolTips = true;
			this.menuStrip1.Size = new System.Drawing.Size(876, 26);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// _exit
			// 
			this._exit.Name = "_exit";
			this._exit.Size = new System.Drawing.Size(43, 22);
			this._exit.Text = "Exit";
			this._exit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// _today
			// 
			this._today.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._today.Name = "_today";
			this._today.Size = new System.Drawing.Size(62, 22);
			this._today.Text = "Today";
			this._today.Click += new System.EventHandler(this._today_Click);
			// 
			// clearWeekToolStripMenuItem
			// 
			this.clearWeekToolStripMenuItem.Name = "clearWeekToolStripMenuItem";
			this.clearWeekToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
			this.clearWeekToolStripMenuItem.Text = "Clear Week";
			this.clearWeekToolStripMenuItem.ToolTipText = "Clear current week time table";
			this.clearWeekToolStripMenuItem.Click += new System.EventHandler(this.clearWeekToolStripMenuItem_Click);
			// 
			// copyDayToolStripMenuItem
			// 
			this.copyDayToolStripMenuItem.Name = "copyDayToolStripMenuItem";
			this.copyDayToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
			this.copyDayToolStripMenuItem.Text = "Copy Day...";
			this.copyDayToolStripMenuItem.ToolTipText = "Copy current day timetable";
			this.copyDayToolStripMenuItem.Click += new System.EventHandler(this.copyDayToolStripMenuItem_Click);
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
			this.copyToolStripMenuItem.Text = "Copy Week...";
			this.copyToolStripMenuItem.ToolTipText = "Copy current week time table";
			this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
			// 
			// c1Schedule1
			// 
			this.c1Schedule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			// 
			// 
			// 
			this.c1Schedule1.CalendarInfo.DateFormatString = "M/d/yyyy";
			this.c1Schedule1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("21:00:00");
			this.c1Schedule1.CalendarInfo.Holidays.Add(new System.DateTime(2006, 11, 7, 0, 0, 0, 0));
			this.c1Schedule1.CalendarInfo.Holidays.Add(new System.DateTime(2006, 10, 8, 0, 0, 0, 0));
			this.c1Schedule1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("09:00:00");
			this.c1Schedule1.CalendarInfo.TimeInterval = C1.Schedule.TimeScaleEnum.FifteenMinutes;
			this.c1Schedule1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:15:00");
			this.c1Schedule1.CalendarInfo.WeekStart = System.DayOfWeek.Monday;
			this.c1Schedule1.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
            System.DayOfWeek.Sunday,
            System.DayOfWeek.Monday,
            System.DayOfWeek.Tuesday,
            System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday,
            System.DayOfWeek.Friday,
            System.DayOfWeek.Saturday});
			// 
			// 
			// 
			// 
			// 
			// 
			this.c1Schedule1.DataStorage.AppointmentStorage.DataSource = this.timeTableBindingSource;
			// 
			// 
			// 
			// 
			// 
			// 
			this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.AppointmentProperties.MappingName = "Misc";
			// 
			// 
			// 
			this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Body.MappingName = "Description";
			// 
			// 
			// 
			this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.End.MappingName = "End";
			// 
			// 
			// 
			this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.IdMapping.MappingName = "Id";
			// 
			// 
			// 
			this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Location.MappingName = "Location";
			// 
			// 
			// 
			this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Start.MappingName = "Begin";
			// 
			// 
			// 
			this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Subject.MappingName = "Exercise";
			// 
			// 
			// 
			this.c1Schedule1.DataStorage.ContactStorage.DataSource = this.instructorsBindingSource;
			// 
			// 
			// 
			// 
			// 
			// 
			this.c1Schedule1.DataStorage.ContactStorage.Mappings.CaptionMapping.MappingName = "Info";
			// 
			// 
			// 
			this.c1Schedule1.DataStorage.ContactStorage.Mappings.IndexMapping.MappingName = "Id";
			// 
			// 
			// 
			this.c1Schedule1.DataStorage.ContactStorage.Mappings.TextMapping.MappingName = "Name";
			this.c1Schedule1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.c1Schedule1.Location = new System.Drawing.Point(275, 26);
			this.c1Schedule1.Name = "c1Schedule1";
			this.c1Schedule1.ShowContextMenu = false;
			this.c1Schedule1.ShowReminderForm = false;
			this.c1Schedule1.ShowWorkTimeOnly = true;
			this.c1Schedule1.Size = new System.Drawing.Size(601, 537);
			this.c1Schedule1.TabIndex = 2;
			this.c1Schedule1.ViewType = C1.Win.Schedule.ScheduleViewEnum.WeekView;
			this.c1Schedule1.VisualStyle = C1.Win.Schedule.UI.VisualStyle.Office2007Blue;
			this.c1Schedule1.BeforeAppointmentShow += new C1.Schedule.CancelAppointmentEventHandler(this.c1Schedule1_BeforeAppointmentShow);
			this.c1Schedule1.BeforeViewChange += new System.EventHandler<C1.Win.Schedule.BeforeViewChangeEventArgs>(this.c1Schedule1_BeforeViewChange);
            this.c1Schedule1.BeforeAppointmentCreate += new CancelAppointmentEventHandler(this.c1Schedule1_BeforeAppointmentCreate);
			// 
			// timeTableBindingSource
			// 
			this.timeTableBindingSource.DataMember = "TimeTable";
			this.timeTableBindingSource.DataSource = this.fitnessClubDataSet;
			// 
			// fitnessClubDataSet
			// 
			this.fitnessClubDataSet.DataSetName = "FitnessClubDataSet";
			this.fitnessClubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// instructorsBindingSource
			// 
			this.instructorsBindingSource.DataMember = "Instructors";
			this.instructorsBindingSource.DataSource = this.fitnessClubDataSet;
			// 
			// c1Calendar1
			// 
			this.c1Calendar1.BoldedDates = new System.DateTime[0];
			this.c1Calendar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.c1Calendar1.CalendarDimensions = 3;
			this.c1Calendar1.Dock = System.Windows.Forms.DockStyle.Left;
			this.c1Calendar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.c1Calendar1.Location = new System.Drawing.Point(0, 26);
			this.c1Calendar1.Name = "c1Calendar1";
			this.c1Calendar1.Schedule = this.c1Schedule1;
			this.c1Calendar1.ShowWeekNumbers = true;
			this.c1Calendar1.Size = new System.Drawing.Size(272, 537);
			this.c1Calendar1.TabIndex = 0;
			this.c1Calendar1.VisualStyle = C1.Win.Schedule.UI.VisualStyle.Office2007Blue;
			// 
			// instructorsTableAdapter
			// 
			this.instructorsTableAdapter.ClearBeforeFill = true;
			// 
			// timeTableTableAdapter
			// 
			this.timeTableTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(876, 563);
			this.Controls.Add(this.c1Schedule1);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.c1Calendar1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Fitness Center Time Table";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.timeTableBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fitnessClubDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.instructorsBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private C1.Win.Schedule.C1Calendar c1Calendar1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private C1.Win.Schedule.C1Schedule c1Schedule1;
		private System.Windows.Forms.ToolStripMenuItem _today;
		private FitnessClubDataSet fitnessClubDataSet;
		private System.Windows.Forms.BindingSource instructorsBindingSource;
		private CustomData.FitnessClubDataSetTableAdapters.InstructorsTableAdapter instructorsTableAdapter;
		private System.Windows.Forms.BindingSource timeTableBindingSource;
		private CustomData.FitnessClubDataSetTableAdapters.TimeTableTableAdapter timeTableTableAdapter;
		private System.Windows.Forms.ToolStripMenuItem _exit;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearWeekToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyDayToolStripMenuItem;
	}
}

