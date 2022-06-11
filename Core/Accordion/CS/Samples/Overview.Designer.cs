namespace AccordionExplorer.Samples
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            C1.Win.Accordion.C1AccordionPage c1AccordionPage1 = new C1.Win.Accordion.C1AccordionPage();
            C1.Framework.C1BitmapIcon c1BitmapIcon1 = new C1.Framework.C1BitmapIcon();
            C1.Win.Accordion.C1AccordionPage c1AccordionPage2 = new C1.Win.Accordion.C1AccordionPage();
            C1.Framework.C1BitmapIcon c1BitmapIcon2 = new C1.Framework.C1BitmapIcon();
            C1.Win.Accordion.C1AccordionPage c1AccordionPage3 = new C1.Win.Accordion.C1AccordionPage();
            C1.Schedule.Printing.PrintStyle printStyle1 = new C1.Schedule.Printing.PrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            C1.Schedule.Printing.PrintStyle printStyle2 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle3 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle4 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle5 = new C1.Schedule.Printing.PrintStyle();
            this.c1Accordion1 = new C1.Win.Accordion.C1Accordion();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.c1Schedule1 = new C1.Win.Schedule.C1Schedule();
            this.panel1.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Accordion1
            // 
            this.c1Accordion1.AllowCollapseAll = true;
            this.c1Accordion1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1Accordion1.Location = new System.Drawing.Point(0, 0);
            this.c1Accordion1.Name = "c1Accordion1";
            c1AccordionPage1.HeaderText = "Calendar";
            c1BitmapIcon1.Size = new System.Drawing.Size(16, 16);
            c1BitmapIcon1.Source = global::AccordionExplorer.Properties.Resources.Calendar;
            c1BitmapIcon1.Stretch = C1.Framework.Stretch.Uniform;
            c1AccordionPage1.Icon = c1BitmapIcon1;
            c1AccordionPage1.IsExpanded = true;
            c1AccordionPage1.Name = "CalendarPage";
            c1AccordionPage1.ToolTipText = "Shows calendar and schedule.";
            c1AccordionPage2.HeaderText = "Mail";
            c1BitmapIcon2.Size = new System.Drawing.Size(16, 16);
            c1BitmapIcon2.Source = global::AccordionExplorer.Properties.Resources.Mail;
            c1BitmapIcon2.Stretch = C1.Framework.Stretch.Uniform;
            c1AccordionPage2.Icon = c1BitmapIcon2;
            c1AccordionPage2.Name = "MailPage";
            c1AccordionPage2.ToolTipText = "Shows email content.";
            c1AccordionPage3.HeaderText = "Settings";
            c1AccordionPage3.Name = "SettingsPage";
            c1AccordionPage3.ToolTipText = "Use property grid to customize C1Accordion.";
            this.c1Accordion1.Pages.Add(c1AccordionPage1);
            this.c1Accordion1.Pages.Add(c1AccordionPage2);
            this.c1Accordion1.Pages.Add(c1AccordionPage3);
            this.c1Accordion1.Size = new System.Drawing.Size(269, 643);
            this.c1Accordion1.TabIndex = 0;
            this.c1Accordion1.PageExpandStateChanged += new System.EventHandler<C1.Win.Accordion.PageExpandStateChangedEventArgs>(this.c1Accordion1_PageExpandStateChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(269, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 643);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.contentPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(273, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 643);
            this.panel1.TabIndex = 4;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.c1Schedule1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(808, 643);
            this.contentPanel.TabIndex = 0;
            // 
            // c1Schedule1
            // 
            // 
            // 
            // 
            this.c1Schedule1.CalendarInfo.CultureInfo = new System.Globalization.CultureInfo("en-US");
            this.c1Schedule1.CalendarInfo.DateFormatString = "M/d/yyyy";
            this.c1Schedule1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00");
            this.c1Schedule1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00");
            this.c1Schedule1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00");
            this.c1Schedule1.CalendarInfo.WeekStart = System.DayOfWeek.Sunday;
            this.c1Schedule1.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
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
            this.c1Schedule1.Size = new System.Drawing.Size(808, 643);
            this.c1Schedule1.TabIndex = 0;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.c1Accordion1);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(1081, 643);
            this.panel1.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Accordion.C1Accordion c1Accordion1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Schedule.C1Schedule c1Schedule1;
        private System.Windows.Forms.Panel contentPanel;
    }
}
