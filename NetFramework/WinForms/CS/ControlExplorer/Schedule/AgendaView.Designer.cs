namespace ControlExplorer.Schedule
{
    partial class AgendaView
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
            C1.C1Schedule.Printing.PrintStyle printStyle1 = new C1.C1Schedule.Printing.PrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgendaView));
            C1.C1Schedule.Printing.PrintStyle printStyle2 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle3 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle4 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle5 = new C1.C1Schedule.Printing.PrintStyle();
            this.c1Calendar1 = new C1.Win.C1Schedule.C1Calendar();
            this.c1Schedule1 = new C1.Win.C1Schedule.C1Schedule();
            this.c1AgendaView1 = new C1.Win.C1Schedule.C1AgendaView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1AgendaView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1Calendar1
            // 
            this.c1Calendar1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1Calendar1.BoldedDates = new System.DateTime[0];
            this.c1Calendar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1Calendar1.Location = new System.Drawing.Point(0, 0);
            this.c1Calendar1.Margin = new System.Windows.Forms.Padding(0);
            this.c1Calendar1.MaxSelectionCount = 70;
            this.c1Calendar1.Name = "c1Calendar1";
            this.c1Calendar1.Schedule = this.c1Schedule1;
            this.c1Calendar1.Size = new System.Drawing.Size(235, 220);
            this.c1Calendar1.TabIndex = 0;
            // 
            // c1Schedule1
            // 
            this.c1Calendar1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00");
            this.c1Calendar1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00");
            this.c1Calendar1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00");
            this.c1Calendar1.CalendarInfo.WeekStart = System.DayOfWeek.Monday;
            this.c1Calendar1.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
            System.DayOfWeek.Monday,
            System.DayOfWeek.Tuesday,
            System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday,
            System.DayOfWeek.Friday});
            // 
            // 
            // 
            this.c1Schedule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Schedule1.GroupPageSize = 2;
            this.c1Schedule1.Location = new System.Drawing.Point(238, 0);
            this.c1Schedule1.Margin = new System.Windows.Forms.Padding(0);
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
            this.c1Schedule1.Settings.SetReminder = false;
            this.c1Schedule1.Size = new System.Drawing.Size(843, 619);
            this.c1Schedule1.TabIndex = 1;
            // 
            // c1AgendaView1
            // 
            this.c1AgendaView1.AutoResize = true;
            this.c1AgendaView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1AgendaView1.Location = new System.Drawing.Point(0, 223);
            this.c1AgendaView1.Margin = new System.Windows.Forms.Padding(0);
            this.c1AgendaView1.Name = "c1AgendaView1";
            this.c1AgendaView1.Schedule = this.c1Schedule1;
            this.c1AgendaView1.ShowEmptyDays = true;
            this.c1AgendaView1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.Both;
            this.c1AgendaView1.Size = new System.Drawing.Size(235, 396);
            this.c1AgendaView1.TabIndex = 2;
            this.c1AgendaView1.Tree.Column = 0;
            this.c1AgendaView1.Tree.Indent = 9;
            this.c1AgendaView1.Tree.Style = C1.Win.C1FlexGrid.TreeStyleFlags.Leaf;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c1AgendaView1);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.c1Calendar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 619);
            this.panel1.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 220);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(235, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(235, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 619);
            this.splitter2.TabIndex = 5;
            this.splitter2.TabStop = false;
            // 
            // AgendaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1081, 619);
            this.Controls.Add(this.c1Schedule1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel1);
            this.Name = "AgendaView";
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1AgendaView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Schedule.C1Calendar c1Calendar1;
        private C1.Win.C1Schedule.C1Schedule c1Schedule1;
        private C1.Win.C1Schedule.C1AgendaView c1AgendaView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
    }
}
