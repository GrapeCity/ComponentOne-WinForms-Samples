namespace GanttViewScheduler
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
            C1.Win.GanttView.BarStyle barStyle1 = new C1.Win.GanttView.BarStyle();
            C1.Win.GanttView.BarStyle barStyle2 = new C1.Win.GanttView.BarStyle();
            C1.Win.GanttView.BarStyle barStyle3 = new C1.Win.GanttView.BarStyle();
            C1.Win.GanttView.BarStyle barStyle4 = new C1.Win.GanttView.BarStyle();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn1 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn2 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn3 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn4 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn5 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn6 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn7 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn8 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn9 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn10 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn11 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn12 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn13 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.TaskPropertyColumn taskPropertyColumn14 = new C1.Win.GanttView.TaskPropertyColumn();
            C1.Win.GanttView.Task task1 = new C1.Win.GanttView.Task();
            C1.Win.GanttView.Resource resource1 = new C1.Win.GanttView.Resource();
            C1.Win.GanttView.Resource resource2 = new C1.Win.GanttView.Resource();
            C1.Win.GanttView.Resource resource3 = new C1.Win.GanttView.Resource();
            C1.Win.GanttView.Resource resource4 = new C1.Win.GanttView.Resource();
            C1.Schedule.Printing.PrintStyle printStyle1 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle2 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle3 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle4 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle5 = new C1.Schedule.Printing.PrintStyle();
            this.c1GanttView1 = new C1.Win.GanttView.C1GanttView();
            this.c1Schedule1 = new C1.Win.Schedule.C1Schedule();
            this.btnRight = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.CalendarStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.PropertyStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.TasksStorage)).BeginInit();
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
            // c1GanttView1
            // 
            this.c1GanttView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.c1GanttView1.BackColor = System.Drawing.SystemColors.Window;
            barStyle1.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(135)))), ((int)(((byte)(220)))));
            barStyle1.BarShape = C1.Win.GanttView.BarShape.ThickBar;
            barStyle1.BarType = C1.Win.GanttView.BarType.AutoTask;
            barStyle1.TopText1_ID = 287759160;
            barStyle3.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            barStyle3.BarShape = C1.Win.GanttView.BarShape.MiddleBar;
            barStyle3.BarType = C1.Win.GanttView.BarType.Progress;
            barStyle4.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(200)))), ((int)(((byte)(209)))));
            barStyle4.BarShape = C1.Win.GanttView.BarShape.ThickBar;
            barStyle4.BarType = C1.Win.GanttView.BarType.ManualTask;
            barStyle4.EndShape = 22;
            barStyle4.StartShape = 21;
            barStyle4.TopText1_ID = 287759160;
            this.c1GanttView1.BarStyles.Add(barStyle1);
            this.c1GanttView1.BarStyles.Add(barStyle2);
            this.c1GanttView1.BarStyles.Add(barStyle3);
            this.c1GanttView1.BarStyles.Add(barStyle4);
            this.c1GanttView1.CellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1GanttView1.ChartViewZoomFactor = 7F;
            taskPropertyColumn1.Caption = "Task Mode";
            taskPropertyColumn1.ID = 1680832599;
            taskPropertyColumn1.Property = C1.Win.GanttView.TaskProperty.Mode;
            taskPropertyColumn1.Visible = false;
            taskPropertyColumn1.Width = 61;
            taskPropertyColumn2.Caption = "Task Name";
            taskPropertyColumn2.ID = 375059526;
            taskPropertyColumn2.Property = C1.Win.GanttView.TaskProperty.Name;
            taskPropertyColumn2.Width = 93;
            taskPropertyColumn3.Caption = "Duration";
            taskPropertyColumn3.ID = 1572034233;
            taskPropertyColumn3.Property = C1.Win.GanttView.TaskProperty.Duration;
            taskPropertyColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            taskPropertyColumn3.Width = 34;
            taskPropertyColumn4.Caption = "Duration Units";
            taskPropertyColumn4.ID = 688893641;
            taskPropertyColumn4.Property = C1.Win.GanttView.TaskProperty.DurationUnits;
            taskPropertyColumn4.Width = 60;
            taskPropertyColumn5.Caption = "Start";
            taskPropertyColumn5.ID = 1056085932;
            taskPropertyColumn5.Property = C1.Win.GanttView.TaskProperty.Start;
            taskPropertyColumn5.Visible = false;
            taskPropertyColumn6.Caption = "Finish";
            taskPropertyColumn6.ID = 536482953;
            taskPropertyColumn6.Property = C1.Win.GanttView.TaskProperty.Finish;
            taskPropertyColumn6.Visible = false;
            taskPropertyColumn7.Caption = "% Complete";
            taskPropertyColumn7.ID = 241887850;
            taskPropertyColumn7.Property = C1.Win.GanttView.TaskProperty.PercentComplete;
            taskPropertyColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            taskPropertyColumn7.Visible = false;
            taskPropertyColumn8.Caption = "Constraint Type";
            taskPropertyColumn8.ID = 1492723839;
            taskPropertyColumn8.Property = C1.Win.GanttView.TaskProperty.ConstraintType;
            taskPropertyColumn8.Visible = false;
            taskPropertyColumn9.Caption = "Constraint Date";
            taskPropertyColumn9.ID = 497084593;
            taskPropertyColumn9.Property = C1.Win.GanttView.TaskProperty.ConstraintDate;
            taskPropertyColumn9.Visible = false;
            taskPropertyColumn10.Caption = "Predecessors";
            taskPropertyColumn10.ID = 1887751057;
            taskPropertyColumn10.Property = C1.Win.GanttView.TaskProperty.Predecessors;
            taskPropertyColumn10.Visible = false;
            taskPropertyColumn11.Caption = "Deadline";
            taskPropertyColumn11.ID = 1454974103;
            taskPropertyColumn11.Property = C1.Win.GanttView.TaskProperty.Deadline;
            taskPropertyColumn11.Visible = false;
            taskPropertyColumn12.Caption = "Calendar";
            taskPropertyColumn12.ID = 365231808;
            taskPropertyColumn12.Property = C1.Win.GanttView.TaskProperty.Calendar;
            taskPropertyColumn12.Visible = false;
            taskPropertyColumn13.Caption = "Resource Names";
            taskPropertyColumn13.ID = 287759160;
            taskPropertyColumn13.Property = C1.Win.GanttView.TaskProperty.ResourceNames;
            taskPropertyColumn13.Visible = false;
            taskPropertyColumn14.Caption = "Notes";
            taskPropertyColumn14.ID = 1372220778;
            taskPropertyColumn14.Property = C1.Win.GanttView.TaskProperty.Notes;
            taskPropertyColumn14.Visible = false;
            this.c1GanttView1.Columns.Add(taskPropertyColumn1);
            this.c1GanttView1.Columns.Add(taskPropertyColumn2);
            this.c1GanttView1.Columns.Add(taskPropertyColumn3);
            this.c1GanttView1.Columns.Add(taskPropertyColumn4);
            this.c1GanttView1.Columns.Add(taskPropertyColumn5);
            this.c1GanttView1.Columns.Add(taskPropertyColumn6);
            this.c1GanttView1.Columns.Add(taskPropertyColumn7);
            this.c1GanttView1.Columns.Add(taskPropertyColumn8);
            this.c1GanttView1.Columns.Add(taskPropertyColumn9);
            this.c1GanttView1.Columns.Add(taskPropertyColumn10);
            this.c1GanttView1.Columns.Add(taskPropertyColumn11);
            this.c1GanttView1.Columns.Add(taskPropertyColumn12);
            this.c1GanttView1.Columns.Add(taskPropertyColumn13);
            this.c1GanttView1.Columns.Add(taskPropertyColumn14);
            // 
            // 
            // 
            this.c1GanttView1.DefaultWorkingTimes.Interval_1.Empty = false;
            this.c1GanttView1.DefaultWorkingTimes.Interval_1.From = new System.DateTime(1, 1, 1, 9, 0, 0, 0);
            this.c1GanttView1.DefaultWorkingTimes.Interval_1.To = new System.DateTime(1, 1, 1, 13, 0, 0, 0);
            this.c1GanttView1.DefaultWorkingTimes.Interval_2.Empty = false;
            this.c1GanttView1.DefaultWorkingTimes.Interval_2.From = new System.DateTime(1, 1, 1, 14, 0, 0, 0);
            this.c1GanttView1.DefaultWorkingTimes.Interval_2.To = new System.DateTime(1, 1, 1, 18, 0, 0, 0);
            this.c1GanttView1.FixedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.c1GanttView1.FixedCellBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(181)))), ((int)(((byte)(186)))));
            this.c1GanttView1.FixedForeColor = System.Drawing.Color.Black;
            this.c1GanttView1.GridWidth = 197;
            this.c1GanttView1.HighlightBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.c1GanttView1.HighlightForeColor = System.Drawing.Color.Black;
            this.c1GanttView1.Location = new System.Drawing.Point(12, 12);
            this.c1GanttView1.Name = "c1GanttView1";
            task1.ID = 1184615291;
            task1.Mode = C1.Win.GanttView.TaskMode.Automatic;
            task1.Name = "Project Summary Task";
            task1.NextID = 0;
            this.c1GanttView1.ProjectSummary = task1;
            resource1.Cost = new decimal(new int[] {
            20000,
            0,
            0,
            131072});
            resource1.ID = 457479171;
            resource1.Name = "Adam Miller";
            resource1.NextID = 0;
            resource2.Cost = new decimal(new int[] {
            50000,
            0,
            0,
            131072});
            resource2.ID = 574928631;
            resource2.Name = "Ruth Radelet";
            resource2.NextID = 0;
            resource3.Cost = new decimal(new int[] {
            25000,
            0,
            0,
            131072});
            resource3.ID = 1258408175;
            resource3.Name = "Johnny Jewel";
            resource3.NextID = 0;
            resource4.Cost = new decimal(new int[] {
            40000,
            0,
            0,
            131072});
            resource4.ID = 187715318;
            resource4.Name = "Nat Walker";
            resource4.NextID = 0;
            this.c1GanttView1.Resources.AddRange(new C1.Win.GanttView.Resource[] {
            resource1,
            resource2,
            resource3,
            resource4});
            this.c1GanttView1.Size = new System.Drawing.Size(545, 442);
            this.c1GanttView1.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(181)))), ((int)(((byte)(186)))));
            this.c1GanttView1.StartDate = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.c1GanttView1.TabIndex = 0;
            this.c1GanttView1.Timescale.BottomTier.Align = C1.Win.GanttView.ScaleLabelAlignment.Center;
            this.c1GanttView1.Timescale.BottomTier.Format = "w";
            this.c1GanttView1.Timescale.BottomTier.Visible = true;
            this.c1GanttView1.Timescale.MiddleTier.Format = "nnn d, \\\'yy";
            this.c1GanttView1.Timescale.MiddleTier.MinWidth = 49;
            this.c1GanttView1.Timescale.MiddleTier.Units = C1.Win.GanttView.TimescaleUnits.Weeks;
            this.c1GanttView1.Timescale.MiddleTier.Visible = true;
            this.c1GanttView1.ToolbarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.c1GanttView1.VisualStyle = C1.Win.GanttView.VisualStyle.Office2010Silver;
            // 
            // c1Schedule1
            // 
            this.c1Schedule1.AllowDrop = true;
            this.c1Schedule1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Schedule1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            // 
            // 
            // 
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
            this.c1Schedule1.GroupPageSize = 2;
            this.c1Schedule1.Location = new System.Drawing.Point(563, 12);
            this.c1Schedule1.Name = "c1Schedule1";
            printStyle1.Description = "Daily Style";
            printStyle1.StyleName = "Daily";
            printStyle1.StyleSource = "day.c1d";
            printStyle2.Description = "Weekly Style";
            printStyle2.StyleName = "Week";
            printStyle2.StyleSource = "week.c1d";
            printStyle3.Description = "Monthly Style";
            printStyle3.StyleName = "Month";
            printStyle3.StyleSource = "month.c1d";
            printStyle4.Description = "Details Style";
            printStyle4.StyleName = "Details";
            printStyle4.StyleSource = "details.c1d";
            printStyle5.Context = C1.Schedule.Printing.PrintContextType.Appointment;
            printStyle5.Description = "Memo Style";
            printStyle5.StyleName = "Memo";
            printStyle5.StyleSource = "memo.c1d";
            this.c1Schedule1.PrintInfo.PrintStyles.AddRange(new C1.Schedule.Printing.PrintStyle[] {
            printStyle1,
            printStyle2,
            printStyle3,
            printStyle4,
            printStyle5});
            this.c1Schedule1.Size = new System.Drawing.Size(334, 486);
            this.c1Schedule1.TabIndex = 1;
            this.c1Schedule1.TimeLineStyle = C1.Win.Schedule.TimeLineStyleEnum.Days;
            this.c1Schedule1.ViewType = C1.Win.Schedule.ScheduleViewEnum.MonthView;
            this.c1Schedule1.VisualStyle = C1.Win.Schedule.UI.VisualStyle.Office2007Silver;
            // 
            // btnRight
            // 
            this.btnRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRight.Location = new System.Drawing.Point(263, 460);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(101, 38);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "Save";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(393, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 510);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.c1Schedule1);
            this.Controls.Add(this.c1GanttView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.CalendarStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.PropertyStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.ResourceStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1.DataStorage.TasksStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1GanttView1)).EndInit();
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

        private C1.Win.GanttView.C1GanttView c1GanttView1;
        private C1.Win.Schedule.C1Schedule c1Schedule1;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button button1;
    }
}

