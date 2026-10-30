using C1.Framework;
using C1.Win.Command.HamburgerMenu;
using System.Drawing;

namespace HamburgerMenuExplorer.Samples
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
            C1.Framework.C1BitmapIcon c1BitmapIcon1 = new C1.Framework.C1BitmapIcon();
            C1.Framework.C1BitmapIcon c1BitmapIcon2 = new C1.Framework.C1BitmapIcon();
            C1.Framework.C1BitmapIcon c1BitmapIcon3 = new C1.Framework.C1BitmapIcon();
            C1.Framework.C1PathIcon c1PathIcon1 = new C1.Framework.C1PathIcon();
            C1.Framework.C1PathIcon c1PathIcon2 = new C1.Framework.C1PathIcon();
            C1.Framework.C1PathIcon c1PathIcon3 = new C1.Framework.C1PathIcon();
            System.Drawing.FontFamily fontFamily1 = new System.Drawing.FontFamily("Arial");
            System.Drawing.Font font1 = new System.Drawing.Font(fontFamily1, 12, FontStyle.Bold, GraphicsUnit.Pixel);
            C1.Schedule.Printing.PrintStyle printStyle1 = new C1.Schedule.Printing.PrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            C1.Schedule.Printing.PrintStyle printStyle2 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle3 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle4 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle5 = new C1.Schedule.Printing.PrintStyle();
            this.c1HamburgerMenu1 = new C1.Win.Command.HamburgerMenu.C1HamburgerMenu();
            this.c1HamburgerMenuItem1 = new C1.Win.Command.HamburgerMenu.C1HamburgerMenuItem();
            this.c1HamburgerMenuItem2 = new C1.Win.Command.HamburgerMenu.C1HamburgerMenuItem();
            this.c1HamburgerMenuItem3 = new C1.Win.Command.HamburgerMenu.C1HamburgerMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.c1Schedule1 = new C1.Win.Schedule.C1Schedule();
            this.c1HamburgerMenu1.SuspendLayout();
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
            // c1HamburgerMenuItem1
            // 
            this.c1HamburgerMenuItem1.Text = "Schedule";
            c1PathIcon1.Data = "M0,0 L1.75,0 L3.5,2 L5.25,0 L7,0 L3.5,4 z";
            c1PathIcon1.Size = new System.Drawing.Size(20, 20);
            c1PathIcon1.Padding = new C1.Framework.Thickness(5);
            c1PathIcon2.Data = "M0,4 L1.75,4 L3.5,2 L5.25,4 L7,4 L3.5,0 z";
            c1PathIcon2.Size = new System.Drawing.Size(20, 20);
            c1PathIcon2.Padding = new C1.Framework.Thickness(5);
            c1BitmapIcon1.Size = new System.Drawing.Size(20, 20);
            c1BitmapIcon1.Padding = new C1.Framework.Thickness(3);
            c1BitmapIcon1.Source = global::HamburgerMenuExplorer.Properties.Resources.Calendar;
            c1BitmapIcon1.Stretch = C1.Framework.Stretch.Uniform;
            this.c1HamburgerMenuItem1.Icon = new C1HamburgerMenuIcon(c1BitmapIcon1);
            this.c1HamburgerMenuItem1.ToolTipText = "Shows calendar and schedule.";
            // 
            // c1HamburgerMenuItem2
            // 
            this.c1HamburgerMenuItem2.Text = "Mail";
            c1BitmapIcon2.Size = new System.Drawing.Size(20, 20);
            c1BitmapIcon2.Padding = new C1.Framework.Thickness(3);
            c1BitmapIcon2.Source = global::HamburgerMenuExplorer.Properties.Resources.Mail;
            c1BitmapIcon2.Stretch = C1.Framework.Stretch.Uniform;
            this.c1HamburgerMenuItem2.ExpandedIcon = c1PathIcon1;
            this.c1HamburgerMenuItem2.CollapsedIcon = c1PathIcon2;
            this.c1HamburgerMenuItem2.Icon = new C1HamburgerMenuIcon(c1BitmapIcon2);
            this.c1HamburgerMenuItem2.ToolTipText = "Shows email content.";
            // 
            // c1HamburgerMenuItem3
            // 
            this.c1HamburgerMenuItem3.Text = "Settings";
            this.c1HamburgerMenuItem3.Expanded = true;
            c1BitmapIcon3.Size = new System.Drawing.Size(20, 20);
            c1BitmapIcon3.Padding = new C1.Framework.Thickness(3);
            c1BitmapIcon3.Source = global::HamburgerMenuExplorer.Properties.Resources.Settings;
            c1BitmapIcon3.Stretch = C1.Framework.Stretch.Uniform;
            this.c1HamburgerMenuItem3.ExpandedIcon = c1PathIcon1;
            this.c1HamburgerMenuItem3.CollapsedIcon = c1PathIcon2;
            this.c1HamburgerMenuItem3.Icon = new C1HamburgerMenuIcon(c1BitmapIcon3);
            this.c1HamburgerMenuItem3.ToolTipText = "Use property grid to customize C1HamburgerMenu.";
            //
            // c1HamburgerMenu1
            //
            this.c1HamburgerMenu1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1HamburgerMenu1.Location = new System.Drawing.Point(0, 0);
            this.c1HamburgerMenu1.Name = "c1HamburgerMenu1";
            c1PathIcon3.Size = new System.Drawing.Size(20, 20);
            c1PathIcon3.Padding = new C1.Framework.Thickness(5);
            c1PathIcon3.Data = "M0, 3 a 1.6,1.6 0 1,0 3.2,0 a 1.6,1.6 0 1,0 -3.2,0zM5, 3 a 1.6,1.6 0 1,0 3.2,0 a 1.6,1.6 0 1,0 -3.2,0zM10, 3 a 1.6,1.6 0 1,0 3.2,0 a 1.6,1.6 0 1,0 -3.2,0z";
            this.c1HamburgerMenu1.ToggleButton.Icon = new C1HamburgerMenuIcon(c1PathIcon3);
            this.c1HamburgerMenu1.Items.Add(c1HamburgerMenuItem1);
            this.c1HamburgerMenu1.Items.Add(c1HamburgerMenuItem2);
            this.c1HamburgerMenu1.Items.Add(c1HamburgerMenuItem3);
            this.c1HamburgerMenu1.Size = new System.Drawing.Size(40, 514);
            this.c1HamburgerMenu1.ExpandedWidth = 215;
            this.c1HamburgerMenu1.AllowWrapToNextLine = true;
            this.c1HamburgerMenu1.TabIndex = 0;
            this.c1HamburgerMenu1.Styles.Common.ShowBorder = true;
            this.c1HamburgerMenu1.Styles.ToggleButton.Border = 1;
            this.c1HamburgerMenu1.Styles.ToggleButton.Font = font1;
            this.c1HamburgerMenu1.Styles.ToggleButton.Padding = new Thickness(8);
            this.c1HamburgerMenu1.Styles.ActiveItem.Border = 1;
            this.c1HamburgerMenu1.Styles.Items.Border = 1;
            this.c1HamburgerMenu1.Styles.ActiveItem.Font = font1;
            this.c1HamburgerMenu1.Styles.Items.Font = font1;
            this.c1HamburgerMenu1.Styles.ActiveItem.Padding = new Thickness(8);
            this.c1HamburgerMenu1.Styles.Items.Padding = new Thickness(8);
            this.c1HamburgerMenu1.Styles.Items.Default.Badge.Shape = BadgeShape.RoundedRectangle;
            this.c1HamburgerMenu1.Styles.Items.Hot.Badge.Shape = BadgeShape.Circle;
            this.c1HamburgerMenu1.Styles.Items.Disabled.Badge.Shape = BadgeShape.RoundedRectangle;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(215, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 514);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.contentPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(218, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 514);
            this.panel1.TabIndex = 4;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.c1Schedule1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 0);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(647, 514);
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
            this.c1Schedule1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.c1Schedule1.Size = new System.Drawing.Size(647, 514);
            this.c1Schedule1.TabIndex = 0;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.c1HamburgerMenu1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Overview";
            this.Size = new System.Drawing.Size(865, 514);
            this.c1HamburgerMenu1.ResumeLayout(false);
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

        private C1.Win.Command.HamburgerMenu.C1HamburgerMenu c1HamburgerMenu1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Schedule.C1Schedule c1Schedule1;
        private System.Windows.Forms.Panel contentPanel;
        private C1.Win.Command.HamburgerMenu.C1HamburgerMenuItem c1HamburgerMenuItem1;
        private C1.Win.Command.HamburgerMenu.C1HamburgerMenuItem c1HamburgerMenuItem2;
        private C1.Win.Command.HamburgerMenu.C1HamburgerMenuItem c1HamburgerMenuItem3;
    }
}
