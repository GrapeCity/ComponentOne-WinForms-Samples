namespace ControlExplorer.Schedule
{
    partial class CustomDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomDialog));
            C1.C1Schedule.Printing.PrintStyle printStyle2 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle3 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle4 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle5 = new C1.C1Schedule.Printing.PrintStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.c1Calendar1 = new C1.Win.C1Schedule.C1Calendar();
            this.c1Schedule1 = new C1.Win.C1Schedule.C1Schedule();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.c1Calendar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1Schedule1);
            this.splitContainer1.Size = new System.Drawing.Size(592, 446);
            this.splitContainer1.SplitterDistance = 192;
            this.splitContainer1.TabIndex = 0;
            // 
            // c1Calendar1
            // 
            this.c1Calendar1.BoldedDates = new System.DateTime[0];
            this.c1Calendar1.CalendarDimensions = 5;
            this.c1Calendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Calendar1.Location = new System.Drawing.Point(0, 0);
            this.c1Calendar1.Name = "c1Calendar1";
            this.c1Calendar1.Schedule = this.c1Schedule1;
            this.c1Calendar1.Size = new System.Drawing.Size(592, 192);
            this.c1Calendar1.TabIndex = 0;
            this.c1Calendar1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2010Blue;
            // 
            // c1Schedule1
            // 
            // 
            // 
            // 
            this.c1Calendar1.CalendarInfo.CultureInfo = new System.Globalization.CultureInfo("en-US");
            this.c1Calendar1.CalendarInfo.DateFormatString = "M/d/yyyy";
            this.c1Calendar1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00");
            this.c1Calendar1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00");
            this.c1Calendar1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00");
            this.c1Calendar1.CalendarInfo.WeekStart = System.DayOfWeek.Sunday;
            this.c1Calendar1.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
            System.DayOfWeek.Monday,
            System.DayOfWeek.Tuesday,
            System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday,
            System.DayOfWeek.Friday});
            this.c1Schedule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Schedule1.GroupPageSize = 2;
            this.c1Schedule1.Location = new System.Drawing.Point(0, 0);
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
            this.c1Schedule1.Size = new System.Drawing.Size(592, 250);
            this.c1Schedule1.TabIndex = 0;
            this.c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WorkWeekView;
            this.c1Schedule1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Office2010Blue;
            this.c1Schedule1.BeforeViewChange += new System.EventHandler<C1.Win.C1Schedule.BeforeViewChangeEventArgs>(this.c1Schedule1_BeforeViewChange);
            this.c1Schedule1.BeforeAppointmentShow += new C1.C1Schedule.CancelAppointmentEventHandler(this.c1Schedule1_BeforeAppointmentShow);
            this.c1Schedule1.BeforeAppointmentCreate += new C1.C1Schedule.CancelAppointmentEventHandler(this.c1Schedule1_BeforeAppointmentCreate);
            // 
            // CustomDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CustomDialog";
            this.Text = "CustomDialog";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.C1Schedule.C1Schedule c1Schedule1;
        private C1.Win.C1Schedule.C1Calendar c1Calendar1;
    }
}