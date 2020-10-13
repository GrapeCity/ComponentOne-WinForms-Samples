namespace ControlExplorer.Schedule
{
    partial class Overview
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
            C1.C1Schedule.Printing.PrintStyle printStyle1 = new C1.C1Schedule.Printing.PrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            C1.C1Schedule.Printing.PrintStyle printStyle2 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle3 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle4 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle5 = new C1.C1Schedule.Printing.PrintStyle();
            this.c1Schedule1 = new C1.Win.C1Schedule.C1Schedule();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.c1Calendar1 = new C1.Win.C1Schedule.C1Calendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this._DayView = new System.Windows.Forms.ToolStripMenuItem();
            this._workWeek = new System.Windows.Forms.ToolStripMenuItem();
            this._week = new System.Windows.Forms.ToolStripMenuItem();
            this._month = new System.Windows.Forms.ToolStripMenuItem();
            this._timeline = new System.Windows.Forms.ToolStripMenuItem();
            this._today = new System.Windows.Forms.ToolStripMenuItem();
            this._print = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1Schedule1
            // 
            this.c1Schedule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.c1Schedule1.CalendarInfo.CultureInfo = new System.Globalization.CultureInfo("en-US");
            this.c1Schedule1.CalendarInfo.DateFormatString = "M/d/yyyy";
            this.c1Schedule1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("18:00:00");
            this.c1Schedule1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("06:00:00");
            this.c1Schedule1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00");
            this.c1Schedule1.CalendarInfo.WeekStart = System.DayOfWeek.Sunday;
            this.c1Schedule1.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
            System.DayOfWeek.Monday,
            System.DayOfWeek.Tuesday,
            System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday,
            System.DayOfWeek.Friday});
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
            // 
            // 
            // 
            this.c1Schedule1.Settings.FirstVisibleTime = System.TimeSpan.Parse("09:00:00");
            this.c1Schedule1.Size = new System.Drawing.Size(385, 422);
            this.c1Schedule1.TabIndex = 7;
            this.c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WorkWeekView;
            // 
            // splitter1
            // 
            this.splitter1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitter1.Location = new System.Drawing.Point(205, 24);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 422);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
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
            this.c1Calendar1.ShowWeekNumbers = false;
            this.c1Calendar1.Size = new System.Drawing.Size(205, 422);
            this.c1Calendar1.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._DayView,
            this._workWeek,
            this._week,
            this._month,
            this._timeline,
            this._today,
            this._print});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(592, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
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
            // _timeline
            // 
            this._timeline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._timeline.Image = global::ControlExplorer.Properties.Resources.Schedule;
            this._timeline.Name = "_timeline";
            this._timeline.Size = new System.Drawing.Size(28, 20);
            this._timeline.Text = "Time Line View";
            this._timeline.Click += new System.EventHandler(this._timeline_Click);
            // 
            // _today
            // 
            this._today.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._today.Name = "_today";
            this._today.Size = new System.Drawing.Size(52, 20);
            this._today.Text = "Today";
            this._today.Click += new System.EventHandler(this._today_Click);
            // 
            // _print
            // 
            this._print.Image = ((System.Drawing.Image)(resources.GetObject("_print.Image")));
            this._print.Name = "_print";
            this._print.Size = new System.Drawing.Size(60, 20);
            this._print.Text = "Print";
            this._print.Click += new System.EventHandler(this._print_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1Schedule1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.c1Calendar1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Overview";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.Overview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem _DayView;
        private System.Windows.Forms.ToolStripMenuItem _workWeek;
        private System.Windows.Forms.ToolStripMenuItem _week;
        private System.Windows.Forms.ToolStripMenuItem _month;
        private System.Windows.Forms.ToolStripMenuItem _today;
        private C1.Win.C1Schedule.C1Calendar c1Calendar1;
        private System.Windows.Forms.Splitter splitter1;
        private C1.Win.C1Schedule.C1Schedule c1Schedule1;
        private System.Windows.Forms.ToolStripMenuItem _print;
        private System.Windows.Forms.ToolStripMenuItem _timeline;
    }
}