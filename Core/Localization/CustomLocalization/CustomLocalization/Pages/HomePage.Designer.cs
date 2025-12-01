namespace Custom_Localization.Pages
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            C1.Schedule.Printing.PrintStyle printStyle6 = new C1.Schedule.Printing.PrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            C1.Schedule.Printing.PrintStyle printStyle7 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle8 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle9 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle10 = new C1.Schedule.Printing.PrintStyle();
            panel2 = new Panel();
            controlsDisplayPanel = new Panel();
            c1Schedule1 = new C1.Win.Schedule.C1Schedule();
            cultureDisplayControl2 = new Custom_Localization.CustomControls.CultureDisplayControl();
            panel9 = new Panel();
            ScheduleLabel = new C1.Win.Input.C1Label();
            navigationPanel = new Panel();
            panel4 = new Panel();
            cultureDisplayControl1 = new Custom_Localization.CustomControls.CultureDisplayControl();
            panel8 = new Panel();
            availiableCultures = new C1.Win.Input.C1Label();
            panel2.SuspendLayout();
            controlsDisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.AppointmentStorage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.CategoryStorage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.ContactStorage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.LabelStorage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.OwnerStorage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.ResourceStorage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.StatusStorage).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ScheduleLabel).BeginInit();
            navigationPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)availiableCultures).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonShadow;
            panel2.Controls.Add(controlsDisplayPanel);
            panel2.Controls.Add(navigationPanel);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1186, 705);
            panel2.TabIndex = 2;
            // 
            // controlsDisplayPanel
            // 
            controlsDisplayPanel.BackColor = Color.White;
            controlsDisplayPanel.Controls.Add(c1Schedule1);
            controlsDisplayPanel.Controls.Add(cultureDisplayControl2);
            controlsDisplayPanel.Controls.Add(panel9);
            controlsDisplayPanel.Dock = DockStyle.Fill;
            controlsDisplayPanel.Location = new Point(0, 0);
            controlsDisplayPanel.Margin = new Padding(2);
            controlsDisplayPanel.Name = "controlsDisplayPanel";
            controlsDisplayPanel.Padding = new Padding(20, 0, 20, 20);
            controlsDisplayPanel.Size = new Size(735, 705);
            controlsDisplayPanel.TabIndex = 2;
            // 
            // c1Schedule1
            // 
            // 
            // 
            // 
            c1Schedule1.CalendarInfo.DateFormatString = "M/d/yyyy";
            c1Schedule1.CalendarInfo.EndDayTime = TimeSpan.Parse("19:00:00");
            c1Schedule1.CalendarInfo.StartDayTime = TimeSpan.Parse("07:00:00");
            c1Schedule1.CalendarInfo.TimeScale = TimeSpan.Parse("00:30:00");
            c1Schedule1.CalendarInfo.WeekStart = DayOfWeek.Sunday;
            c1Schedule1.CalendarInfo.WorkDays.AddRange(new DayOfWeek[] { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday });
            // 
            // 
            // 
            c1Schedule1.Dock = DockStyle.Fill;
            c1Schedule1.GroupPageSize = 2;
            c1Schedule1.Location = new Point(20, 62);
            c1Schedule1.Margin = new Padding(2);
            c1Schedule1.Name = "c1Schedule1";
            printStyle6.Description = "Daily Style";
            printStyle6.PreviewImage = (Image)resources.GetObject("printStyle6.PreviewImage");
            printStyle6.StyleName = "Daily";
            printStyle6.StyleSource = "day.c1d";
            printStyle7.Description = "Weekly Style";
            printStyle7.PreviewImage = (Image)resources.GetObject("printStyle7.PreviewImage");
            printStyle7.StyleName = "Week";
            printStyle7.StyleSource = "week.c1d";
            printStyle8.Description = "Monthly Style";
            printStyle8.PreviewImage = (Image)resources.GetObject("printStyle8.PreviewImage");
            printStyle8.StyleName = "Month";
            printStyle8.StyleSource = "month.c1d";
            printStyle9.Description = "Details Style";
            printStyle9.PreviewImage = (Image)resources.GetObject("printStyle9.PreviewImage");
            printStyle9.StyleName = "Details";
            printStyle9.StyleSource = "details.c1d";
            printStyle10.Context = C1.Schedule.Printing.PrintContextType.Appointment;
            printStyle10.Description = "Memo Style";
            printStyle10.PreviewImage = (Image)resources.GetObject("printStyle10.PreviewImage");
            printStyle10.StyleName = "Memo";
            printStyle10.StyleSource = "memo.c1d";
            c1Schedule1.PrintInfo.PrintStyles.AddRange(new C1.Schedule.Printing.PrintStyle[] { printStyle6, printStyle7, printStyle8, printStyle9, printStyle10 });
            c1Schedule1.Size = new Size(695, 623);
            c1Schedule1.TabIndex = 0;
            // 
            // 
            // 
            c1Schedule1.Theme.XmlDefinition = resources.GetString("resource.XmlDefinition");
            // 
            // cultureDisplayControl2
            // 
            cultureDisplayControl2.CustomAddedCultureHeaderText = "Custom Cultures";
            cultureDisplayControl2.IsOverrideCultureVisible = false;
            cultureDisplayControl2.Location = new Point(382, 192);
            cultureDisplayControl2.Margin = new Padding(2);
            cultureDisplayControl2.Name = "cultureDisplayControl2";
            cultureDisplayControl2.OverrideCultureHeaderText = "Override Cultures";
            cultureDisplayControl2.PreDefinedCultureHeaderText = "Pre Supported Cultures";
            cultureDisplayControl2.Size = new Size(8, 8);
            cultureDisplayControl2.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Controls.Add(ScheduleLabel);
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(20, 0);
            panel9.Margin = new Padding(2);
            panel9.Name = "panel9";
            panel9.Size = new Size(695, 62);
            panel9.TabIndex = 1;
            // 
            // ScheduleLabel
            // 
            ScheduleLabel.AutoSize = true;
            ScheduleLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ScheduleLabel.Location = new Point(0, 16);
            ScheduleLabel.Name = "ScheduleLabel";
            ScheduleLabel.Size = new Size(123, 33);
            ScheduleLabel.TabIndex = 0;
            ScheduleLabel.Text = "C1 Schedule";
            // 
            // navigationPanel
            // 
            navigationPanel.BackColor = Color.White;
            navigationPanel.Controls.Add(panel4);
            navigationPanel.Dock = DockStyle.Right;
            navigationPanel.Location = new Point(735, 0);
            navigationPanel.Margin = new Padding(2);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.Padding = new Padding(0, 0, 20, 20);
            navigationPanel.Size = new Size(451, 705);
            navigationPanel.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(cultureDisplayControl1);
            panel4.Controls.Add(panel8);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(431, 685);
            panel4.TabIndex = 3;
            // 
            // cultureDisplayControl1
            // 
            cultureDisplayControl1.Dock = DockStyle.Fill;
            cultureDisplayControl1.IsOverrideCultureVisible = false;
            cultureDisplayControl1.Location = new Point(0, 62);
            cultureDisplayControl1.Margin = new Padding(2);
            cultureDisplayControl1.Name = "cultureDisplayControl1";
            cultureDisplayControl1.Size = new Size(431, 623);
            cultureDisplayControl1.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(availiableCultures);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Margin = new Padding(2);
            panel8.Name = "panel8";
            panel8.Size = new Size(431, 62);
            panel8.TabIndex = 3;
            // 
            // availiableCultures
            // 
            availiableCultures.AutoSize = true;
            availiableCultures.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            availiableCultures.Location = new Point(0, 16);
            availiableCultures.Name = "availiableCultures";
            availiableCultures.Size = new Size(209, 33);
            availiableCultures.TabIndex = 0;
            availiableCultures.Text = "Custom Resource Files";
            availiableCultures.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Margin = new Padding(2);
            Name = "HomePage";
            Size = new Size(1186, 705);
            panel2.ResumeLayout(false);
            controlsDisplayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.AppointmentStorage).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.CategoryStorage).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.ContactStorage).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.LabelStorage).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.OwnerStorage).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.ResourceStorage).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1.DataStorage.StatusStorage).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Schedule1).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ScheduleLabel).EndInit();
            navigationPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)availiableCultures).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel controlsDisplayPanel;
        private C1.Win.Schedule.C1Schedule c1Schedule1;
        private CustomControls.CultureDisplayControl cultureDisplayControl2;
        private Panel panel9;
        private C1.Win.Input.C1Label ScheduleLabel;
        private Panel navigationPanel;
        private Panel panel4;
        private CustomControls.CultureDisplayControl cultureDisplayControl1;
        private Panel panel8;
        private C1.Win.Input.C1Label availiableCultures;
    }
}
