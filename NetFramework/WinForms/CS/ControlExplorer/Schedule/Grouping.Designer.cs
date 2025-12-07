namespace ControlExplorer.Schedule
{
    partial class Grouping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grouping));
            C1.Schedule.Printing.PrintStyle printStyle2 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle3 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle4 = new C1.Schedule.Printing.PrintStyle();
            C1.Schedule.Printing.PrintStyle printStyle5 = new C1.Schedule.Printing.PrintStyle();
            this.c1Schedule1 = new C1.Win.Schedule.C1Schedule();
            this.c1ToolBar1 = new C1.Win.Command.C1ToolBar();
            this.c1CommandHolder1 = new C1.Win.Command.C1CommandHolder();
            this.c1Command_Day = new C1.Win.Command.C1Command();
            this.c1Command_Week = new C1.Win.Command.C1Command();
            this.c1Command_Month = new C1.Win.Command.C1Command();
            this.c1Command_Grouping = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink5 = new C1.Win.Command.C1CommandLink();
            this.c1Command_GroupNone = new C1.Win.Command.C1Command();
            this.c1CommandLink6 = new C1.Win.Command.C1CommandLink();
            this.c1Command_GroupCategory = new C1.Win.Command.C1Command();
            this.c1CommandLink7 = new C1.Win.Command.C1CommandLink();
            this.c1Command_GroupContact = new C1.Win.Command.C1Command();
            this.c1CommandLink8 = new C1.Win.Command.C1CommandLink();
            this.c1Command_GroupResource = new C1.Win.Command.C1Command();
            this.c1Command_WorkWeek = new C1.Win.Command.C1CommandControl();
            this.c1Command_FullWeek = new C1.Win.Command.C1Command();
            this.c1Command_TimeLine = new C1.Win.Command.C1Command();
            this.c1CommandLink4 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink1 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink2 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink9 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink3 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink10 = new C1.Win.Command.C1CommandLink();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.SuspendLayout();
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
            this.c1Schedule1.Location = new System.Drawing.Point(0, 24);
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
            this.c1Schedule1.Size = new System.Drawing.Size(1173, 574);
            this.c1Schedule1.TabIndex = 1;
            this.c1Schedule1.ViewType = C1.Win.Schedule.ScheduleViewEnum.WorkWeekView;
            this.c1Schedule1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.AccessibleName = "Tool Bar";
            this.c1ToolBar1.AutoSize = false;
            this.c1ToolBar1.ButtonLookHorz = C1.Win.Command.ButtonLookFlags.Text;
            this.c1ToolBar1.CommandHolder = this.c1CommandHolder1;
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink4,
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink9,
            this.c1CommandLink3,
            this.c1CommandLink10});
            this.c1ToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1ToolBar1.Location = new System.Drawing.Point(0, 0);
            this.c1ToolBar1.Movable = false;
            this.c1ToolBar1.Name = "c1ToolBar1";
            this.c1ToolBar1.Size = new System.Drawing.Size(1173, 24);
            this.c1ToolBar1.Text = "c1ToolBar1";
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1Command_Day);
            this.c1CommandHolder1.Commands.Add(this.c1Command_Week);
            this.c1CommandHolder1.Commands.Add(this.c1Command_Month);
            this.c1CommandHolder1.Commands.Add(this.c1Command_Grouping);
            this.c1CommandHolder1.Commands.Add(this.c1Command_GroupNone);
            this.c1CommandHolder1.Commands.Add(this.c1Command_GroupCategory);
            this.c1CommandHolder1.Commands.Add(this.c1Command_GroupContact);
            this.c1CommandHolder1.Commands.Add(this.c1Command_GroupResource);
            this.c1CommandHolder1.Commands.Add(this.c1Command_WorkWeek);
            this.c1CommandHolder1.Commands.Add(this.c1Command_FullWeek);
            this.c1CommandHolder1.Commands.Add(this.c1Command_TimeLine);
            this.c1CommandHolder1.Owner = this;
            this.c1CommandHolder1.CommandClick += new C1.Win.Command.CommandClickEventHandler(this.c1CommandHolder1_CommandClick);
            // 
            // c1Command_Day
            // 
            this.c1Command_Day.CheckAutoToggle = true;
            this.c1Command_Day.Name = "c1Command_Day";
            this.c1Command_Day.ShortcutText = "";
            this.c1Command_Day.Text = "Day";
            // 
            // c1Command_Week
            // 
            this.c1Command_Week.CheckAutoToggle = true;
            this.c1Command_Week.Checked = true;
            this.c1Command_Week.Name = "c1Command_Week";
            this.c1Command_Week.ShortcutText = "";
            this.c1Command_Week.Text = "Work Week";
            // 
            // c1Command_Month
            // 
            this.c1Command_Month.CheckAutoToggle = true;
            this.c1Command_Month.Name = "c1Command_Month";
            this.c1Command_Month.ShortcutText = "";
            this.c1Command_Month.Text = "Month";
            // 
            // c1Command_Grouping
            // 
            this.c1Command_Grouping.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink7,
            this.c1CommandLink8});
            this.c1Command_Grouping.HideNonRecentLinks = false;
            this.c1Command_Grouping.Name = "c1Command_Grouping";
            this.c1Command_Grouping.ShortcutText = "";
            this.c1Command_Grouping.ShowToolTips = true;
            this.c1Command_Grouping.Text = "Group By";
            this.c1Command_Grouping.VisualStyle = C1.Win.Command.VisualStyle.Office2010Blue;
            this.c1Command_Grouping.VisualStyleBase = C1.Win.Command.VisualStyle.Office2010Blue;
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Command = this.c1Command_GroupNone;
            // 
            // c1Command_GroupNone
            // 
            this.c1Command_GroupNone.CheckAutoToggle = true;
            this.c1Command_GroupNone.Name = "c1Command_GroupNone";
            this.c1Command_GroupNone.ShortcutText = "";
            this.c1Command_GroupNone.Text = "None";
            // 
            // c1CommandLink6
            // 
            this.c1CommandLink6.Command = this.c1Command_GroupCategory;
            this.c1CommandLink6.SortOrder = 1;
            // 
            // c1Command_GroupCategory
            // 
            this.c1Command_GroupCategory.CheckAutoToggle = true;
            this.c1Command_GroupCategory.Name = "c1Command_GroupCategory";
            this.c1Command_GroupCategory.ShortcutText = "";
            this.c1Command_GroupCategory.Text = "Category";
            // 
            // c1CommandLink7
            // 
            this.c1CommandLink7.Command = this.c1Command_GroupContact;
            this.c1CommandLink7.SortOrder = 2;
            // 
            // c1Command_GroupContact
            // 
            this.c1Command_GroupContact.CheckAutoToggle = true;
            this.c1Command_GroupContact.Checked = true;
            this.c1Command_GroupContact.Name = "c1Command_GroupContact";
            this.c1Command_GroupContact.ShortcutText = "";
            this.c1Command_GroupContact.Text = "Contact";
            // 
            // c1CommandLink8
            // 
            this.c1CommandLink8.Command = this.c1Command_GroupResource;
            this.c1CommandLink8.SortOrder = 3;
            // 
            // c1Command_GroupResource
            // 
            this.c1Command_GroupResource.CheckAutoToggle = true;
            this.c1Command_GroupResource.Name = "c1Command_GroupResource";
            this.c1Command_GroupResource.ShortcutText = "";
            this.c1Command_GroupResource.Text = "Resource";
            // 
            // c1Command_WorkWeek
            // 
            this.c1Command_WorkWeek.Name = "c1Command_WorkWeek";
            this.c1Command_WorkWeek.ShortcutText = "";
            this.c1Command_WorkWeek.Text = "Show work week";
            // 
            // c1Command_FullWeek
            // 
            this.c1Command_FullWeek.CheckAutoToggle = true;
            this.c1Command_FullWeek.Name = "c1Command_FullWeek";
            this.c1Command_FullWeek.ShortcutText = "";
            this.c1Command_FullWeek.Text = "Full Week";
            // 
            // c1Command_TimeLine
            // 
            this.c1Command_TimeLine.CheckAutoToggle = true;
            this.c1Command_TimeLine.Name = "c1Command_TimeLine";
            this.c1Command_TimeLine.ShortcutText = "";
            this.c1Command_TimeLine.Text = "Time Line";
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.c1Command_Grouping;
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.ButtonLook = C1.Win.Command.ButtonLookFlags.Text;
            this.c1CommandLink1.Command = this.c1Command_Day;
            this.c1CommandLink1.Delimiter = true;
            this.c1CommandLink1.SortOrder = 1;
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.ButtonLook = C1.Win.Command.ButtonLookFlags.Text;
            this.c1CommandLink2.Command = this.c1Command_Week;
            this.c1CommandLink2.SortOrder = 2;
            // 
            // c1CommandLink9
            // 
            this.c1CommandLink9.Command = this.c1Command_FullWeek;
            this.c1CommandLink9.SortOrder = 3;
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.ButtonLook = C1.Win.Command.ButtonLookFlags.Text;
            this.c1CommandLink3.Command = this.c1Command_Month;
            this.c1CommandLink3.SortOrder = 4;
            // 
            // c1CommandLink10
            // 
            this.c1CommandLink10.Command = this.c1Command_TimeLine;
            this.c1CommandLink10.SortOrder = 5;
            // 
            // Grouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 598);
            this.Controls.Add(this.c1Schedule1);
            this.Controls.Add(this.c1ToolBar1);
            this.Name = "Grouping";
            this.Text = "Grouping";
            this.Load += new System.EventHandler(this.Grouping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Command.C1ToolBar c1ToolBar1;
        private C1.Win.Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.Command.C1CommandLink c1CommandLink1;
        private C1.Win.Command.C1Command c1Command_Day;
        private C1.Win.Command.C1Command c1Command_Week;
        private C1.Win.Command.C1Command c1Command_Month;
        private C1.Win.Command.C1CommandLink c1CommandLink2;
        private C1.Win.Command.C1CommandLink c1CommandLink3;
        private C1.Win.Command.C1CommandMenu c1Command_Grouping;
        private C1.Win.Command.C1CommandLink c1CommandLink5;
        private C1.Win.Schedule.C1Schedule c1Schedule1;
        private C1.Win.Command.C1CommandLink c1CommandLink4;
        private C1.Win.Command.C1Command c1Command_GroupNone;
        private C1.Win.Command.C1CommandLink c1CommandLink6;
        private C1.Win.Command.C1Command c1Command_GroupCategory;
        private C1.Win.Command.C1CommandLink c1CommandLink7;
        private C1.Win.Command.C1Command c1Command_GroupContact;
        private C1.Win.Command.C1CommandLink c1CommandLink8;
        private C1.Win.Command.C1Command c1Command_GroupResource;
        private C1.Win.Command.C1CommandControl c1Command_WorkWeek;
        private C1.Win.Command.C1Command c1Command_FullWeek;
        private C1.Win.Command.C1CommandLink c1CommandLink9;
        private C1.Win.Command.C1Command c1Command_TimeLine;
        private C1.Win.Command.C1CommandLink c1CommandLink10;
    }
}