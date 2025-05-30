﻿using C1.Framework;
using C1.C1Schedule;

namespace FullBound
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
            C1.C1Schedule.Printing.PrintStyle printStyle1 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle2 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle3 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle4 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle5 = new C1.C1Schedule.Printing.PrintStyle();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._DayView = new System.Windows.Forms.ToolStripMenuItem();
            this._workWeek = new System.Windows.Forms.ToolStripMenuItem();
            this._week = new System.Windows.Forms.ToolStripMenuItem();
            this._month = new System.Windows.Forms.ToolStripMenuItem();
            this._timeLine = new System.Windows.Forms.ToolStripMenuItem();
            this._today = new System.Windows.Forms.ToolStripMenuItem();
            this.c1Schedule1 = new C1.Win.C1Schedule.C1Schedule();
            this.appointmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1Calendar1 = new C1.Win.C1Schedule.C1Calendar();
            this.c1NWindDataSet1 = new FullBound.C1NWindDataSet();
            this.appointments_FullTableAdapter = new FullBound.C1NWindDataSetTableAdapters.Appointments_FullTableAdapter();
            this.categoriesTableAdapter1 = new FullBound.C1NWindDataSetTableAdapters.CategoriesTableAdapter();
            this.appointeesTableAdapter = new FullBound.C1NWindDataSetTableAdapters.AppointeesTableAdapter();
            this.labelsTableAdapter1 = new FullBound.C1NWindDataSetTableAdapters.LabelsTableAdapter();
            this.products_ScheduleTableAdapter = new FullBound.C1NWindDataSetTableAdapters.Products_ScheduleTableAdapter();
            this.statusesTableAdapter1 = new FullBound.C1NWindDataSetTableAdapters.StatusesTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitter1.Location = new System.Drawing.Point(205, 24);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 433);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this._DayView,
            this._workWeek,
            this._week,
            this._month,
            this._timeLine,
            this._today});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // _DayView
            // 
            this._DayView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._DayView.Image = ((System.Drawing.Image)(resources.GetObject("_DayView.Image")));
            this._DayView.Name = "_DayView";
            this._DayView.Size = new System.Drawing.Size(28, 20);
            this._DayView.Text = "Day View";
            this._DayView.ToolTipText = "Day View";
            this._DayView.Click += new System.EventHandler(this._DayView_Click);
            // 
            // _workWeek
            // 
            this._workWeek.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._workWeek.Image = ((System.Drawing.Image)(resources.GetObject("_workWeek.Image")));
            this._workWeek.Name = "_workWeek";
            this._workWeek.Size = new System.Drawing.Size(28, 20);
            this._workWeek.ToolTipText = "Work Week View";
            this._workWeek.Click += new System.EventHandler(this._workWeek_Click);
            // 
            // _week
            // 
            this._week.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._week.Image = ((System.Drawing.Image)(resources.GetObject("_week.Image")));
            this._week.Name = "_week";
            this._week.Size = new System.Drawing.Size(28, 20);
            this._week.Text = "toolStripMenuItem1";
            this._week.ToolTipText = "Week View";
            this._week.Click += new System.EventHandler(this._week_Click);
            // 
            // _month
            // 
            this._month.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._month.Image = ((System.Drawing.Image)(resources.GetObject("_month.Image")));
            this._month.Name = "_month";
            this._month.Size = new System.Drawing.Size(28, 20);
            this._month.Text = "toolStripMenuItem1";
            this._month.ToolTipText = "Month View";
            this._month.Click += new System.EventHandler(this._month_Click);
            // 
            // _timeLine
            // 
            this._timeLine.AutoToolTip = true;
            this._timeLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._timeLine.Image = ((System.Drawing.Image)(resources.GetObject("_timeLine.Image")));
            this._timeLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._timeLine.Name = "_timeLine";
            this._timeLine.Size = new System.Drawing.Size(28, 20);
            this._timeLine.Text = "toolStripMenuItem1";
            this._timeLine.ToolTipText = "Time Line";
            this._timeLine.Click += new System.EventHandler(this._timeLine_Click);
            // 
            // _today
            // 
            this._today.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._today.Name = "_today";
            this._today.Size = new System.Drawing.Size(52, 20);
            this._today.Text = "Today";
            this._today.Click += new System.EventHandler(this._today_Click);
            // 
            // c1Schedule1
            // 
            // 
            // 
            // 
            this.c1Schedule1.CalendarInfo.DateFormatString = "M/d/yyyy";
            this.c1Schedule1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("18:00:00");
            this.c1Schedule1.CalendarInfo.Holidays.Add(new System.DateTime(2006, 11, 7, 0, 0, 0, 0));
            this.c1Schedule1.CalendarInfo.Holidays.Add(new System.DateTime(2006, 10, 8, 0, 0, 0, 0));
            this.c1Schedule1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("06:00:00");
            this.c1Schedule1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00");
            this.c1Schedule1.CalendarInfo.WeekStart = System.DayOfWeek.Monday;
            this.c1Schedule1.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
            System.DayOfWeek.Monday,
            System.DayOfWeek.Tuesday,
            System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday,
            System.DayOfWeek.Friday});
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.DataSource = this.appointmentsBindingSource;
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.AppointmentProperties.MappingName = "Properties";
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
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.IdMapping.MappingName = "AppointmentId";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Location.MappingName = "Location";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Start.MappingName = "Start";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Subject.MappingName = "Subject";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.CategoryStorage.DataSource = this.categoriesBindingSource;
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.CategoryStorage.Mappings.CaptionMapping.MappingName = "Description";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.CategoryStorage.Mappings.IndexMapping.MappingName = "CategoryID";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.CategoryStorage.Mappings.TextMapping.MappingName = "CategoryName";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ContactStorage.DataSource = this.employeesBindingSource;
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ContactStorage.Mappings.CaptionMapping.MappingName = "LastName";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ContactStorage.Mappings.IndexMapping.MappingName = "EmployeeID";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ContactStorage.Mappings.TextMapping.MappingName = "FirstName";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.LabelStorage.DataSource = this.labelsBindingSource;
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.LabelStorage.Mappings.CaptionMapping.MappingName = "Description";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.LabelStorage.Mappings.ColorMapping.MappingName = "Color";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.LabelStorage.Mappings.IdMapping.MappingName = "LabelId";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.LabelStorage.Mappings.TextMapping.MappingName = "Text";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ResourceStorage.DataSource = this.productsBindingSource;
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ResourceStorage.Mappings.CaptionMapping.MappingName = "ProductName";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ResourceStorage.Mappings.IndexMapping.MappingName = "ProductID";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ResourceStorage.Mappings.TextMapping.MappingName = "ProductName";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.StatusStorage.DataSource = this.statusesBindingSource;
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.StatusStorage.Mappings.CaptionMapping.MappingName = "Description";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.StatusStorage.Mappings.ColorMapping.MappingName = "Color";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.StatusStorage.Mappings.IdMapping.MappingName = "StatusId";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.StatusStorage.Mappings.TextMapping.MappingName = "Text";
            this.c1Schedule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Schedule1.GroupPageSize = 2;
            this.c1Schedule1.Location = new System.Drawing.Point(207, 24);
            this.c1Schedule1.Margin = new System.Windows.Forms.Padding(2);
            this.c1Schedule1.Name = "c1Schedule1";
            printStyle1.Description = "Daily Style";
            printStyle1.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle1.PreviewImage")));
            printStyle1.StyleName = "Daily";
            printStyle1.StyleSource = "day.c1d";
            printStyle2.Description = "Weekly Style";
            printStyle2.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle2.PreviewImage")));
            printStyle2.StyleName = "Week";
            printStyle2.StyleSource = "week.c1d";
            printStyle3.Description = "Monthly Style";
            printStyle3.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle3.PreviewImage")));
            printStyle3.StyleName = "Month";
            printStyle3.StyleSource = "month.c1d";
            printStyle4.Description = "Details Style";
            printStyle4.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle4.PreviewImage")));
            printStyle4.StyleName = "Details";
            printStyle4.StyleSource = "details.c1d";
            printStyle5.Context = C1.C1Schedule.Printing.PrintContextType.Appointment;
            printStyle5.Description = "Memo Style";
            printStyle5.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle5.PreviewImage")));
            printStyle5.StyleName = "Memo";
            printStyle5.StyleSource = "memo.c1d";
            this.c1Schedule1.PrintInfo.PrintStyles.AddRange(new C1.C1Schedule.Printing.PrintStyle[] {
            printStyle1,
            printStyle2,
            printStyle3,
            printStyle4,
            printStyle5});
            this.c1Schedule1.Size = new System.Drawing.Size(450, 433);
            this.c1Schedule1.TabIndex = 2;
            this.c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WorkWeekView;
            this.c1Schedule1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2007Silver;
            this.c1Schedule1.BeforeAppointmentShow += new C1.C1Schedule.CancelAppointmentEventHandler(this.c1Schedule1_BeforeAppointmentShow);
            this.c1Schedule1.AppointmentAdded += new System.EventHandler<C1.C1Schedule.AppointmentEventArgs>(this.c1Schedule1_AppointmentAdded);
            // 
            // appointmentsBindingSource
            // 
            this.appointmentsBindingSource.DataMember = "Appointments_Full";
            this.appointmentsBindingSource.DataSource = this.c1NWindDataSet1;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.c1NWindDataSet1;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Appointees";
            this.employeesBindingSource.DataSource = this.c1NWindDataSet1;
            // 
            // labelsBindingSource
            // 
            this.labelsBindingSource.DataMember = "Labels";
            this.labelsBindingSource.DataSource = this.c1NWindDataSet1;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products_Schedule";
            this.productsBindingSource.DataSource = this.c1NWindDataSet1;
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataMember = "Statuses";
            this.statusesBindingSource.DataSource = this.c1NWindDataSet1;
            // 
            // c1Calendar1
            // 
            this.c1Calendar1.BoldedDates = new System.DateTime[0];
            this.c1Calendar1.CalendarDimensions = 3;
            this.c1Calendar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1Calendar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Calendar1.Location = new System.Drawing.Point(0, 24);
            this.c1Calendar1.Margin = new System.Windows.Forms.Padding(2);
            this.c1Calendar1.Name = "c1Calendar1";
            this.c1Calendar1.Schedule = this.c1Schedule1;
            this.c1Calendar1.Size = new System.Drawing.Size(205, 433);
            this.c1Calendar1.TabIndex = 0;
            this.c1Calendar1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2007Silver;
            // 
            // c1NWindDataSet1
            // 
            this.c1NWindDataSet1.DataSetName = "C1NWindDataSet";
            this.c1NWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointments_FullTableAdapter
            // 
            this.appointments_FullTableAdapter.ClearBeforeFill = true;
            // 
            // categoriesTableAdapter1
            // 
            this.categoriesTableAdapter1.ClearBeforeFill = true;
            // 
            // appointeesTableAdapter
            // 
            this.appointeesTableAdapter.ClearBeforeFill = true;
            // 
            // labelsTableAdapter1
            // 
            this.labelsTableAdapter1.ClearBeforeFill = true;
            // 
            // products_ScheduleTableAdapter
            // 
            this.products_ScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // statusesTableAdapter1
            // 
            this.statusesTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 457);
            this.Controls.Add(this.c1Schedule1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.c1Calendar1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "C1Schedule Test Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labelsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private C1.Win.C1Schedule.C1Calendar c1Calendar1;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private C1.Win.C1Schedule.C1Schedule c1Schedule1;
		private System.Windows.Forms.ToolStripMenuItem _DayView;
		private System.Windows.Forms.ToolStripMenuItem _workWeek;
		private System.Windows.Forms.ToolStripMenuItem _week;
		private System.Windows.Forms.ToolStripMenuItem _month;
        private System.Windows.Forms.ToolStripMenuItem _today;
        private System.Windows.Forms.BindingSource appointmentsBindingSource;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private System.Windows.Forms.BindingSource labelsBindingSource;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private System.Windows.Forms.BindingSource statusesBindingSource;
		private System.Windows.Forms.ToolStripMenuItem _timeLine;
        private C1NWindDataSet c1NWindDataSet1;
        private C1NWindDataSetTableAdapters.Appointments_FullTableAdapter appointments_FullTableAdapter;
        private C1NWindDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter1;
        private C1NWindDataSetTableAdapters.AppointeesTableAdapter appointeesTableAdapter;
        private C1NWindDataSetTableAdapters.LabelsTableAdapter labelsTableAdapter1;
        private C1NWindDataSetTableAdapters.Products_ScheduleTableAdapter products_ScheduleTableAdapter;
        private C1NWindDataSetTableAdapters.StatusesTableAdapter statusesTableAdapter1;
	}
}

