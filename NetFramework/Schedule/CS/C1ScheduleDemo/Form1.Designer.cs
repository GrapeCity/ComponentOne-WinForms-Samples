using C1.Framework;
using C1.C1Schedule;

namespace TestSchedule
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
            this.toolStripVisualStyle = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbVisualStyle = new System.Windows.Forms.ToolStripComboBox();
            this.groupingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupPageSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbGroupPageSize = new System.Windows.Forms.ToolStripComboBox();
            this.showEmptyGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c1Schedule1 = new C1.Win.C1Schedule.C1Schedule();
            this.c1NWindDataSet1 = new TestSchedule.C1NwindDataSet();
            this.c1Calendar1 = new C1.Win.C1Schedule.C1Calendar();
            this.appointeesTableAdapter1 = new TestSchedule.C1NwindDataSetTableAdapters.AppointeesTableAdapter();
            this.appointmentsTableAdapter1 = new TestSchedule.C1NwindDataSetTableAdapters.AppointmentsTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitter1.Location = new System.Drawing.Point(204, 24);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 462);
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
            this._today,
            this.toolStripVisualStyle,
            this.groupingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(789, 24);
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
            this._DayView.AutoToolTip = true;
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
            this._workWeek.AutoToolTip = true;
            this._workWeek.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._workWeek.Image = ((System.Drawing.Image)(resources.GetObject("_workWeek.Image")));
            this._workWeek.Name = "_workWeek";
            this._workWeek.Size = new System.Drawing.Size(28, 20);
            this._workWeek.ToolTipText = "Work Week View";
            this._workWeek.Click += new System.EventHandler(this._workWeek_Click);
            // 
            // _week
            // 
            this._week.AutoToolTip = true;
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
            this._month.AutoToolTip = true;
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
            // toolStripVisualStyle
            // 
            this.toolStripVisualStyle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbVisualStyle});
            this.toolStripVisualStyle.Name = "toolStripVisualStyle";
            this.toolStripVisualStyle.Size = new System.Drawing.Size(78, 20);
            this.toolStripVisualStyle.Text = "Visual Style";
            // 
            // cmbVisualStyle
            // 
            this.cmbVisualStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVisualStyle.Name = "cmbVisualStyle";
            this.cmbVisualStyle.Size = new System.Drawing.Size(121, 23);
            this.cmbVisualStyle.SelectedIndexChanged += new System.EventHandler(this.cmbVisualStyle_SelectedIndexChanged);
            // 
            // groupingToolStripMenuItem
            // 
            this.groupingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupByToolStripMenuItem,
            this.groupPageSizeToolStripMenuItem,
            this.showEmptyGroupToolStripMenuItem});
            this.groupingToolStripMenuItem.Name = "groupingToolStripMenuItem";
            this.groupingToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.groupingToolStripMenuItem.Text = "Grouping";
            // 
            // groupByToolStripMenuItem
            // 
            this.groupByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem,
            this.contactToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.resourceToolStripMenuItem});
            this.groupByToolStripMenuItem.Name = "groupByToolStripMenuItem";
            this.groupByToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.groupByToolStripMenuItem.Text = "Group By";
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Checked = true;
            this.noneToolStripMenuItem.CheckOnClick = true;
            this.noneToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.noneToolStripMenuItem.Text = "None";
            this.noneToolStripMenuItem.Click += new System.EventHandler(this.noneToolStripMenuItem_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.CheckOnClick = true;
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.CheckOnClick = true;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // resourceToolStripMenuItem
            // 
            this.resourceToolStripMenuItem.CheckOnClick = true;
            this.resourceToolStripMenuItem.Name = "resourceToolStripMenuItem";
            this.resourceToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.resourceToolStripMenuItem.Text = "Resource";
            this.resourceToolStripMenuItem.Click += new System.EventHandler(this.resourceToolStripMenuItem_Click);
            // 
            // groupPageSizeToolStripMenuItem
            // 
            this.groupPageSizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbGroupPageSize});
            this.groupPageSizeToolStripMenuItem.Name = "groupPageSizeToolStripMenuItem";
            this.groupPageSizeToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.groupPageSizeToolStripMenuItem.Text = "Group Page Size";
            // 
            // cmbGroupPageSize
            // 
            this.cmbGroupPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupPageSize.DropDownWidth = 30;
            this.cmbGroupPageSize.Margin = new System.Windows.Forms.Padding(0);
            this.cmbGroupPageSize.MaxLength = 2;
            this.cmbGroupPageSize.Name = "cmbGroupPageSize";
            this.cmbGroupPageSize.Size = new System.Drawing.Size(75, 23);
            this.cmbGroupPageSize.SelectedIndexChanged += new System.EventHandler(this.cmbGroupPageSize_SelectedIndexChanged);
            // 
            // showEmptyGroupToolStripMenuItem
            // 
            this.showEmptyGroupToolStripMenuItem.CheckOnClick = true;
            this.showEmptyGroupToolStripMenuItem.Name = "showEmptyGroupToolStripMenuItem";
            this.showEmptyGroupToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.showEmptyGroupToolStripMenuItem.Text = "Show Empty Group";
            this.showEmptyGroupToolStripMenuItem.Click += new System.EventHandler(this.showEmptyGroupToolStripMenuItem_Click);
            // 
            // c1Schedule1
            // 
            // 
            // 
            // 
            this.c1Schedule1.CalendarInfo.DateFormatString = "M/d/yyyy";
            this.c1Schedule1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("18:00:00");
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
            this.c1Schedule1.DataStorage.AppointmentStorage.DataMember = "Appointments";
            this.c1Schedule1.DataStorage.AppointmentStorage.DataSource = this.c1NWindDataSet1;
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
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Body.MappingName = "Body";
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
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Start.MappingName = "Start";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Subject.MappingName = "Subject";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ContactStorage.DataMember = "Appointees";
            this.c1Schedule1.DataStorage.ContactStorage.DataSource = this.c1NWindDataSet1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ContactStorage.Mappings.IndexMapping.MappingName = "EmployeeID";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ContactStorage.Mappings.TextMapping.MappingName = "FirstName";
            this.c1Schedule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Schedule1.GroupPageSize = 2;
            this.c1Schedule1.Location = new System.Drawing.Point(206, 24);
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
            // 
            // 
            // 
            this.c1Schedule1.Settings.AllowCategoriesEditing = false;
            this.c1Schedule1.Settings.AllowCategoriesMultiSelection = false;
            this.c1Schedule1.Settings.AllowContactsEditing = false;
            this.c1Schedule1.Settings.AllowContactsMultiSelection = false;
            this.c1Schedule1.Settings.FirstVisibleTime = System.TimeSpan.Parse("06:00:00");
            this.c1Schedule1.Size = new System.Drawing.Size(583, 462);
            this.c1Schedule1.TabIndex = 2;
            this.c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WorkWeekView;
            // 
            // c1NWindDataSet1
            // 
            this.c1NWindDataSet1.DataSetName = "C1NWindDataSet";
            this.c1NWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.c1Calendar1.Size = new System.Drawing.Size(204, 462);
            this.c1Calendar1.TabIndex = 0;
            this.c1Calendar1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2007Black;
            // 
            // appointeesTableAdapter1
            // 
            this.appointeesTableAdapter1.ClearBeforeFill = true;
            // 
            // appointmentsTableAdapter1
            // 
            this.appointmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 486);
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
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem toolStripVisualStyle;
        private System.Windows.Forms.ToolStripMenuItem groupingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupPageSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEmptyGroupToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cmbGroupPageSize;
        private System.Windows.Forms.ToolStripComboBox cmbVisualStyle;
        private System.Windows.Forms.ToolStripMenuItem _timeLine;
        private C1NwindDataSet c1NWindDataSet1;
        private C1NwindDataSetTableAdapters.AppointeesTableAdapter appointeesTableAdapter1;
        private C1NwindDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter1;
    }
}

