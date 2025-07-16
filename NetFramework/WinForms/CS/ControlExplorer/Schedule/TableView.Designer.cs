namespace ControlExplorer.Schedule
{
    partial class TableView
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
            C1.Schedule.Printing.PrintStyle printStyle1 = new C1.Schedule.Printing.PrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableView));
            C1.Schedule.Printing.PrintStyle printStyle2 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle3 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle4 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle5 = new C1.Schedule.Printing.PrintStyle();
            this.c1Calendar1 = new C1.Win.Schedule.C1Calendar();
            this.c1Schedule1 = new C1.Win.Schedule.C1Schedule();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnActiveView = new System.Windows.Forms.ToolStripButton();
            this.btnTableView = new System.Windows.Forms.ToolStripButton();
            this.btnCalendarView = new System.Windows.Forms.ToolStripButton();
            this.c1TableView1 = new C1.Win.Schedule.C1TableView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TableView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1Calendar1
            // 
            this.c1Calendar1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1Calendar1.BoldedDates = new System.DateTime[0];
            this.c1Calendar1.CalendarDimensions = 3;
            this.c1Calendar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1Calendar1.Location = new System.Drawing.Point(0, 0);
            this.c1Calendar1.MaxSelectionCount = 70;
            this.c1Calendar1.MinimumSize = new System.Drawing.Size(190, 0);
            this.c1Calendar1.Name = "c1Calendar1";
            this.c1Calendar1.Schedule = this.c1Schedule1;
            this.c1Calendar1.Size = new System.Drawing.Size(190, 594);
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
            this.c1Schedule1.Location = new System.Drawing.Point(190, 0);
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
            printStyle5.Context = C1.Schedule.Printing.PrintContextType.Appointment;
            printStyle5.Description = "Memo Style";
            printStyle5.PreviewImage = ((System.Drawing.Image)(resources.GetObject("printStyle5.PreviewImage")));
            printStyle5.StyleName = "Memo";
            printStyle5.StyleSource = "memo.c1d";
            this.c1Schedule1.PrintInfo.PrintStyles.AddRange(new C1.Schedule.Printing.PrintStyle[] {
            printStyle1,
            printStyle2,
            printStyle3,
            printStyle4,
            printStyle5});
            this.c1Schedule1.Size = new System.Drawing.Size(891, 594);
            this.c1Schedule1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnActiveView,
            this.btnTableView,
            this.btnCalendarView});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1081, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnActiveView
            // 
            this.btnActiveView.Checked = true;
            this.btnActiveView.CheckOnClick = true;
            this.btnActiveView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnActiveView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnActiveView.Image = ((System.Drawing.Image)(resources.GetObject("btnActiveView.Image")));
            this.btnActiveView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActiveView.Name = "btnActiveView";
            this.btnActiveView.Size = new System.Drawing.Size(23, 22);
            this.btnActiveView.Text = "Active";
            this.btnActiveView.Click += new System.EventHandler(this.btnActiveView_Click);
            // 
            // btnTableView
            // 
            this.btnTableView.CheckOnClick = true;
            this.btnTableView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnTableView.Image = ((System.Drawing.Image)(resources.GetObject("btnTableView.Image")));
            this.btnTableView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTableView.Name = "btnTableView";
            this.btnTableView.Size = new System.Drawing.Size(23, 22);
            this.btnTableView.Text = "Table View";
            this.btnTableView.Click += new System.EventHandler(this.btnTableView_Click);
            // 
            // btnCalendarView
            // 
            this.btnCalendarView.CheckOnClick = true;
            this.btnCalendarView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCalendarView.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendarView.Image")));
            this.btnCalendarView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCalendarView.Name = "btnCalendarView";
            this.btnCalendarView.Size = new System.Drawing.Size(23, 22);
            this.btnCalendarView.Text = "Calendar View";
            this.btnCalendarView.Click += new System.EventHandler(this.btnCalendarView_Click);
            // 
            // c1TableView1
            // 
            this.c1TableView1.Active = true;
            this.c1TableView1.AllowDelete = true;
            this.c1TableView1.AllowFiltering = true;
            this.c1TableView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TableView1.FieldsXml = resources.GetString("c1TableView1.FieldsXml");
            this.c1TableView1.Location = new System.Drawing.Point(193, 0);
            this.c1TableView1.Name = "c1TableView1";
            this.c1TableView1.NullEmptyString = "(none)";
            this.c1TableView1.Schedule = this.c1Schedule1;
            this.c1TableView1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.Both;
            this.c1TableView1.Size = new System.Drawing.Size(888, 594);
            this.c1TableView1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.c1Schedule1);
            this.panel1.Controls.Add(this.c1Calendar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 594);
            this.panel1.TabIndex = 4;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(190, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 594);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 619);
            this.Controls.Add(this.c1TableView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "TableView";
            this.Text = "TableView";
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TableView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Schedule.C1Calendar c1Calendar1;
        private C1.Win.Schedule.C1Schedule c1Schedule1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnTableView;
        private System.Windows.Forms.ToolStripButton btnCalendarView;
        private C1.Win.Schedule.C1TableView c1TableView1;
        private System.Windows.Forms.ToolStripButton btnActiveView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
    }
}