
namespace ScheduleExplorer.Samples
{
    partial class UnBound
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
            C1.C1Schedule.Printing.PrintStyle printStyle1 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle2 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle3 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle4 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle5 = new C1.C1Schedule.Printing.PrintStyle();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._DayView = new System.Windows.Forms.ToolStripMenuItem();
            this._workWeek = new System.Windows.Forms.ToolStripMenuItem();
            this._week = new System.Windows.Forms.ToolStripMenuItem();
            this._month = new System.Windows.Forms.ToolStripMenuItem();
            this._timeLine = new System.Windows.Forms.ToolStripMenuItem();
            this._today = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c1Schedule1 = new C1.Win.Schedule.C1Schedule();
            this.c1Calendar1 = new C1.Win.Schedule.C1Calendar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.splitter1.Location = new System.Drawing.Point(442, 732);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(753, 4);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
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
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1195, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.importToolStripMenuItem.Text = "Import...";
            this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.exportToolStripMenuItem.Text = "Export...";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // _DayView
            // 
            this._DayView.AutoToolTip = true;
            this._DayView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._DayView.Image = global::ScheduleExplorer.Properties.Resources._DayView_Image;
            this._DayView.Name = "_DayView";
            this._DayView.Size = new System.Drawing.Size(52, 36);
            this._DayView.Text = "Day View";
            this._DayView.ToolTipText = "Day View";
            this._DayView.Click += new System.EventHandler(this._DayView_Click);
            // 
            // _workWeek
            // 
            this._workWeek.AutoToolTip = true;
            this._workWeek.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._workWeek.Image = global::ScheduleExplorer.Properties.Resources._workWeek_Image;
            this._workWeek.Name = "_workWeek";
            this._workWeek.Size = new System.Drawing.Size(52, 36);
            this._workWeek.ToolTipText = "Work Week View";
            this._workWeek.Click += new System.EventHandler(this._workWeek_Click);
            // 
            // _week
            // 
            this._week.AutoToolTip = true;
            this._week.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._week.Image = global::ScheduleExplorer.Properties.Resources._week_Image;
            this._week.Name = "_week";
            this._week.Size = new System.Drawing.Size(52, 36);
            this._week.Text = "toolStripMenuItem1";
            this._week.ToolTipText = "Week View";
            this._week.Click += new System.EventHandler(this._week_Click);
            // 
            // _month
            // 
            this._month.AutoToolTip = true;
            this._month.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._month.Image = global::ScheduleExplorer.Properties.Resources._month_Image;
            this._month.Name = "_month";
            this._month.Size = new System.Drawing.Size(52, 36);
            this._month.Text = "toolStripMenuItem1";
            this._month.ToolTipText = "Month View";
            this._month.Click += new System.EventHandler(this._month_Click);
            // 
            // _timeLine
            // 
            this._timeLine.AutoToolTip = true;
            this._timeLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._timeLine.Image = global::ScheduleExplorer.Properties.Resources._timeLine_Image;
            this._timeLine.Name = "_timeLine";
            this._timeLine.Size = new System.Drawing.Size(52, 36);
            this._timeLine.Text = "toolStripMenuItem1";
            this._timeLine.ToolTipText = "Time Line";
            this._timeLine.Click += new System.EventHandler(this._timeLine_Click);
            // 
            // _today
            // 
            this._today.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._today.Image = global::ScheduleExplorer.Properties.Resources._DayView_Image;
            this._today.Name = "_today";
            this._today.Size = new System.Drawing.Size(97, 36);
            this._today.Text = "Today";
            this._today.Click += new System.EventHandler(this._today_Click);
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.CheckOnClick = true;
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.contactToolStripMenuItem.Text = "Contact";
            this.contactToolStripMenuItem.Click += new System.EventHandler(this.contactToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.CheckOnClick = true;
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // resourceToolStripMenuItem
            // 
            this.resourceToolStripMenuItem.CheckOnClick = true;
            this.resourceToolStripMenuItem.Name = "resourceToolStripMenuItem";
            this.resourceToolStripMenuItem.Size = new System.Drawing.Size(243, 44);
            this.resourceToolStripMenuItem.Text = "Resource";
            this.resourceToolStripMenuItem.Click += new System.EventHandler(this.resourceToolStripMenuItem_Click);
            // 
            // c1Schedule1
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

            this.c1Schedule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Schedule1.GroupPageSize = 2;
            this.c1Schedule1.Location = new System.Drawing.Point(442, 40);
            this.c1Schedule1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1Schedule1.Name = "c1Schedule1";
            printStyle1.Description = "Daily Style";
            printStyle1.StyleName = "Daily";
            printStyle1.PreviewImage = global::ScheduleExplorer.Properties.Resources.printStyle1_PreviewImage;
            printStyle1.StyleSource = "day.c1d";
            printStyle2.Description = "Weekly Style";
            printStyle2.StyleName = "Week";
            printStyle2.StyleSource = "week.c1d";
            printStyle2.PreviewImage = global::ScheduleExplorer.Properties.Resources.printStyle2_PreviewImage;
            printStyle3.Description = "Monthly Style";
            printStyle3.StyleName = "Month";
            printStyle3.StyleSource = "month.c1d";
            printStyle3.PreviewImage = global::ScheduleExplorer.Properties.Resources.printStyle3_PreviewImage;
            printStyle4.Description = "Details Style";
            printStyle4.StyleName = "Details";
            printStyle4.StyleSource = "details.c1d";
            printStyle4.PreviewImage = global::ScheduleExplorer.Properties.Resources.printStyle4_PreviewImage;
            printStyle5.Context = C1.C1Schedule.Printing.PrintContextType.Appointment;
            printStyle5.Description = "Memo Style";
            printStyle5.StyleName = "Memo";
            printStyle5.StyleSource = "memo.c1d";
            printStyle5.PreviewImage = global::ScheduleExplorer.Properties.Resources.printStyle5_PreviewImage;
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
            this.c1Schedule1.Size = new System.Drawing.Size(753, 692);
            this.c1Schedule1.TabIndex = 2;
            this.c1Schedule1.ViewType = C1.Win.Schedule.ScheduleViewEnum.WorkWeekView;
            // 
            // c1Calendar1
            // 
            this.c1Calendar1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1Calendar1.BoldedDates = new System.DateTime[0];
            this.c1Calendar1.CalendarDimensions = 3;
            this.c1Calendar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1Calendar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Calendar1.Location = new System.Drawing.Point(0, 40);
            this.c1Calendar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1Calendar1.MaxSelectionCount = 70;
            this.c1Calendar1.Name = "c1Calendar1";
            this.c1Calendar1.Schedule = this.c1Schedule1;
            this.c1Calendar1.Size = new System.Drawing.Size(442, 696);
            this.c1Calendar1.TabIndex = 0;
            // 
            // C1ScheduleDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Schedule1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.c1Calendar1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "C1ScheduleDemo";
            this.Size = new System.Drawing.Size(1195, 736);
            this.Load += new System.EventHandler(this.C1ScheduleDemo_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Schedule.C1Calendar c1Calendar1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private C1.Win.Schedule.C1Schedule c1Schedule1;
        private System.Windows.Forms.ToolStripMenuItem _DayView;
        private System.Windows.Forms.ToolStripMenuItem _workWeek;
        private System.Windows.Forms.ToolStripMenuItem _week;
        private System.Windows.Forms.ToolStripMenuItem _month;
        private System.Windows.Forms.ToolStripMenuItem _today;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _timeLine;
    }
}
