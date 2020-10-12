using C1.Framework;
using C1.C1Schedule;

namespace TableViews
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
            C1.C1Schedule.Printing.PrintStyle printStyle1 = new C1.C1Schedule.Printing.PrintStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            C1.C1Schedule.Printing.PrintStyle printStyle2 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle3 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle4 = new C1.C1Schedule.Printing.PrintStyle();
            C1.C1Schedule.Printing.PrintStyle printStyle5 = new C1.C1Schedule.Printing.PrintStyle();
            this.c1NWindDataSet1 = new TableViews.C1NwindDataSet();
            this.appointeesTableAdapter1 = new TableViews.C1NwindDataSetTableAdapters.AppointeesTableAdapter();
            this.appointmentsTableAdapter1 = new TableViews.C1NwindDataSetTableAdapters.AppointmentsTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.c1Calendar1 = new C1.Win.C1Schedule.C1Calendar();
            this.c1Schedule1 = new C1.Win.C1Schedule.C1Schedule();
            this.agendaView1 = new C1.Win.C1Schedule.C1AgendaView();
            this.c1Ribbon1 = new C1.Win.C1Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.C1Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.C1Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.C1Ribbon.RibbonConfigToolBar();
            this.contextualGroup = new C1.Win.C1Ribbon.RibbonContextualTabGroup();
            this.appointmentTab = new C1.Win.C1Ribbon.RibbonTab();
            this.appActions = new C1.Win.C1Ribbon.RibbonGroup();
            this.openAppButton = new C1.Win.C1Ribbon.RibbonButton();
            this.deleteAppButton = new C1.Win.C1Ribbon.RibbonButton();
            this.appOptionsGroup = new C1.Win.C1Ribbon.RibbonGroup();
            this.recButton = new C1.Win.C1Ribbon.RibbonButton();
            this.tagsGroup = new C1.Win.C1Ribbon.RibbonGroup();
            this.privateButton = new C1.Win.C1Ribbon.RibbonToggleButton();
            this.highImportanceButton = new C1.Win.C1Ribbon.RibbonToggleButton();
            this.lowImportanceButton = new C1.Win.C1Ribbon.RibbonToggleButton();
            this.ribbonQat1 = new C1.Win.C1Ribbon.RibbonQat();
            this.homeTab = new C1.Win.C1Ribbon.RibbonTab();
            this.newGroup = new C1.Win.C1Ribbon.RibbonGroup();
            this.newAppButton = new C1.Win.C1Ribbon.RibbonButton();
            this.gotoGroup = new C1.Win.C1Ribbon.RibbonGroup();
            this.todayButton = new C1.Win.C1Ribbon.RibbonButton();
            this.next7Button = new C1.Win.C1Ribbon.RibbonButton();
            this.arrangeGroup = new C1.Win.C1Ribbon.RibbonGroup();
            this.dayButton = new C1.Win.C1Ribbon.RibbonToggleButton();
            this.workweekButton = new C1.Win.C1Ribbon.RibbonToggleButton();
            this.weekButton = new C1.Win.C1Ribbon.RibbonToggleButton();
            this.monthButton = new C1.Win.C1Ribbon.RibbonToggleButton();
            this.timelineButton = new C1.Win.C1Ribbon.RibbonToggleButton();
            this.tableViewsGroup = new C1.Win.C1Ribbon.RibbonGroup();
            this.listButton = new C1.Win.C1Ribbon.RibbonToggleButton();
            this.activeButton = new C1.Win.C1Ribbon.RibbonToggleButton();
            this.settingsTab = new C1.Win.C1Ribbon.RibbonTab();
            this.optionsGroup = new C1.Win.C1Ribbon.RibbonGroup();
            this.themeCombo = new C1.Win.C1Ribbon.RibbonComboBox();
            this.White = new C1.Win.C1Ribbon.RibbonButton();
            this.Colorful = new C1.Win.C1Ribbon.RibbonButton();
            this.DarkGray = new C1.Win.C1Ribbon.RibbonButton();
            this.Black = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonSeparator1 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.agendaCheckBox = new C1.Win.C1Ribbon.RibbonCheckBox();
            this.agendaViewType = new C1.Win.C1Ribbon.RibbonComboBox();
            this.todayAgenda = new C1.Win.C1Ribbon.RibbonButton();
            this.weekAgenda = new C1.Win.C1Ribbon.RibbonButton();
            this.dateRangeAgenda = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.C1Ribbon.RibbonTopToolBar();
            this.tableView1 = new C1.Win.C1Schedule.C1TableView();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1NWindDataSet1
            // 
            this.c1NWindDataSet1.DataSetName = "C1NWindDataSet";
            this.c1NWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointeesTableAdapter1
            // 
            this.appointeesTableAdapter1.ClearBeforeFill = true;
            // 
            // appointmentsTableAdapter1
            // 
            this.appointmentsTableAdapter1.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitContainer1.Location = new System.Drawing.Point(0, 146);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1MinSize = 190;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1Schedule1);
            this.splitContainer1.Size = new System.Drawing.Size(850, 494);
            this.splitContainer1.SplitterDistance = 202;
            this.splitContainer1.TabIndex = 4;
            this.c1ThemeController1.SetTheme(this.splitContainer1, "(default)");
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.White;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.c1Calendar1);
            this.splitContainer2.Panel1MinSize = 186;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.agendaView1);
            this.splitContainer2.Size = new System.Drawing.Size(202, 494);
            this.splitContainer2.SplitterDistance = 202;
            this.splitContainer2.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.splitContainer2, "(default)");
            // 
            // c1Calendar1
            // 
            this.c1Calendar1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1Calendar1.BoldedDates = new System.DateTime[0];
            this.c1Calendar1.CalendarDimensions = 3;
            this.c1Calendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Calendar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.c1Calendar1.Location = new System.Drawing.Point(0, 0);
            this.c1Calendar1.Margin = new System.Windows.Forms.Padding(2);
            this.c1Calendar1.MaxSelectionCount = 70;
            this.c1Calendar1.Name = "c1Calendar1";
            this.c1Calendar1.Schedule = this.c1Schedule1;
            this.c1Calendar1.ShowWeekNumbers = false;
            this.c1Calendar1.Size = new System.Drawing.Size(202, 202);
            this.c1Calendar1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1Calendar1, "(default)");
            this.c1Calendar1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Custom;
            // 
            // c1Schedule1
            // 
            // 
            // 
            // 
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
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.DataMember = "Appointments";
            this.c1Schedule1.DataStorage.AppointmentStorage.DataSource = this.c1NWindDataSet1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.AppointmentProperties.MappingName = "Properties";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Body.MappingName = "Body";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.End.MappingName = "End";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.IdMapping.MappingName = "Id";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Location.MappingName = "Location";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Start.MappingName = "Start";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.AppointmentStorage.Mappings.Subject.MappingName = "Subject";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ContactStorage.DataMember = "Appointees";
            this.c1Schedule1.DataStorage.ContactStorage.DataSource = this.c1NWindDataSet1;
            // 
            // 
            // 
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ContactStorage.Mappings.IndexMapping.MappingName = "EmployeeID";
            // 
            // 
            // 
            this.c1Schedule1.DataStorage.ContactStorage.Mappings.TextMapping.MappingName = "FirstName";
            this.c1Schedule1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Schedule1.GroupPageSize = 2;
            this.c1Schedule1.Location = new System.Drawing.Point(0, 0);
            this.c1Schedule1.Margin = new System.Windows.Forms.Padding(2);
            this.c1Schedule1.Name = "c1Schedule1";
            this.c1Schedule1.PrintInfo.IsPrintingEnabled = false;
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
            this.c1Schedule1.Settings.AllowCategoriesEditing = false;
            this.c1Schedule1.Settings.AllowCategoriesMultiSelection = false;
            this.c1Schedule1.Settings.AllowContactsEditing = false;
            this.c1Schedule1.Settings.AllowContactsMultiSelection = false;
            this.c1Schedule1.Settings.SetReminder = false;
            this.c1Schedule1.ShowReminderForm = false;
            this.c1Schedule1.Size = new System.Drawing.Size(644, 494);
            this.c1Schedule1.TabIndex = 2;
            this.c1ThemeController1.SetTheme(this.c1Schedule1, "(default)");
            this.c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WorkWeekView;
            this.c1Schedule1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Custom;
            this.c1Schedule1.SelectedAppointmentsChanged += new System.EventHandler<C1.Win.C1Schedule.SelectedAppointmentsChangedEventArgs>(this.c1Schedule1_SelectedAppointmentsChanged);
            // 
            // agendaView1
            // 
            this.agendaView1.BackColor = System.Drawing.Color.White;
            this.agendaView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.agendaView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.agendaView1.Location = new System.Drawing.Point(0, 0);
            this.agendaView1.Margin = new System.Windows.Forms.Padding(5);
            this.agendaView1.Name = "agendaView1";
            this.agendaView1.Schedule = this.c1Schedule1;
            this.agendaView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.agendaView1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None;
            this.agendaView1.Size = new System.Drawing.Size(202, 288);
            this.agendaView1.StyleInfo = resources.GetString("agendaView1.StyleInfo");
            this.agendaView1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.agendaView1, "(default)");
            this.agendaView1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.agendaView1.SelectedAppointmentsChanged += new System.EventHandler(this.agendaView1_SelectedAppointmentsChanged);
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.ContextualTabGroups.Add(this.contextualGroup);
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(850, 146);
            this.c1Ribbon1.Tabs.Add(this.homeTab);
            this.c1Ribbon1.Tabs.Add(this.settingsTab);
            this.c1ThemeController1.SetTheme(this.c1Ribbon1, "(default)");
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // contextualGroup
            // 
            this.contextualGroup.Color = C1.Win.C1Ribbon.ContextualTabColor.Blue;
            this.contextualGroup.Name = "contextualGroup";
            this.contextualGroup.Tabs.Add(this.appointmentTab);
            this.contextualGroup.Text = "Calendar Tools";
            // 
            // appointmentTab
            // 
            this.appointmentTab.Groups.Add(this.appActions);
            this.appointmentTab.Groups.Add(this.appOptionsGroup);
            this.appointmentTab.Groups.Add(this.tagsGroup);
            this.appointmentTab.KeyTip = "A";
            this.appointmentTab.Name = "appointmentTab";
            this.appointmentTab.Text = "Appointment";
            // 
            // appActions
            // 
            this.appActions.Items.Add(this.openAppButton);
            this.appActions.Items.Add(this.deleteAppButton);
            this.appActions.Name = "appActions";
            this.appActions.Text = "Actions";
            // 
            // openAppButton
            // 
            this.openAppButton.KeyTip = "O";
            this.openAppButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("openAppButton.LargeImage")));
            this.openAppButton.Name = "openAppButton";
            this.openAppButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("openAppButton.SmallImage")));
            this.openAppButton.Text = "Open";
            this.openAppButton.ToolTip = "Open";
            this.openAppButton.Click += new System.EventHandler(this.openAppButton_Click);
            // 
            // deleteAppButton
            // 
            this.deleteAppButton.KeyTip = "D";
            this.deleteAppButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteAppButton.LargeImage")));
            this.deleteAppButton.Name = "deleteAppButton";
            this.deleteAppButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("deleteAppButton.SmallImage")));
            this.deleteAppButton.Text = "Delete";
            this.deleteAppButton.ToolTip = "Delete";
            this.deleteAppButton.Click += new System.EventHandler(this.deleteAppButton_Click);
            // 
            // appOptionsGroup
            // 
            this.appOptionsGroup.Items.Add(this.recButton);
            this.appOptionsGroup.Name = "appOptionsGroup";
            this.appOptionsGroup.Text = "Options";
            // 
            // recButton
            // 
            this.recButton.KeyTip = "R";
            this.recButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("recButton.LargeImage")));
            this.recButton.Name = "recButton";
            this.recButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("recButton.SmallImage")));
            this.recButton.Text = "Recurrence";
            this.recButton.Click += new System.EventHandler(this.recButton_Click);
            // 
            // tagsGroup
            // 
            this.tagsGroup.Items.Add(this.privateButton);
            this.tagsGroup.Items.Add(this.highImportanceButton);
            this.tagsGroup.Items.Add(this.lowImportanceButton);
            this.tagsGroup.Name = "tagsGroup";
            this.tagsGroup.Text = "Tags";
            // 
            // privateButton
            // 
            this.privateButton.KeyTip = "P";
            this.privateButton.Name = "privateButton";
            this.privateButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("privateButton.SmallImage")));
            this.privateButton.Text = "Private";
            this.privateButton.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageBeforeText;
            this.privateButton.Click += new System.EventHandler(this.privateButton_Click);
            // 
            // highImportanceButton
            // 
            this.highImportanceButton.KeyTip = "H";
            this.highImportanceButton.Name = "highImportanceButton";
            this.highImportanceButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("highImportanceButton.SmallImage")));
            this.highImportanceButton.Text = "High Importance";
            this.highImportanceButton.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageBeforeText;
            this.highImportanceButton.ToggleGroupName = "Importance";
            this.highImportanceButton.Click += new System.EventHandler(this.highImportanceButton_Click);
            // 
            // lowImportanceButton
            // 
            this.lowImportanceButton.KeyTip = "L";
            this.lowImportanceButton.Name = "lowImportanceButton";
            this.lowImportanceButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("lowImportanceButton.SmallImage")));
            this.lowImportanceButton.Text = "Low Importance";
            this.lowImportanceButton.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageBeforeText;
            this.lowImportanceButton.ToggleGroupName = "Importance";
            this.lowImportanceButton.Click += new System.EventHandler(this.lowImportanceButton_Click);
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // homeTab
            // 
            this.homeTab.Groups.Add(this.newGroup);
            this.homeTab.Groups.Add(this.gotoGroup);
            this.homeTab.Groups.Add(this.arrangeGroup);
            this.homeTab.Groups.Add(this.tableViewsGroup);
            this.homeTab.KeyTip = "H";
            this.homeTab.Name = "homeTab";
            this.homeTab.Text = "Home";
            // 
            // newGroup
            // 
            this.newGroup.Items.Add(this.newAppButton);
            this.newGroup.Name = "newGroup";
            this.newGroup.Text = "New";
            // 
            // newAppButton
            // 
            this.newAppButton.Description = "New Appointment";
            this.newAppButton.KeyTip = "N";
            this.newAppButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("newAppButton.LargeImage")));
            this.newAppButton.Name = "newAppButton";
            this.newAppButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("newAppButton.SmallImage")));
            this.newAppButton.Text = "New Appointment";
            this.newAppButton.ToolTip = "New Appointment";
            this.newAppButton.Click += new System.EventHandler(this.newAppButton_Click);
            // 
            // gotoGroup
            // 
            this.gotoGroup.Items.Add(this.todayButton);
            this.gotoGroup.Items.Add(this.next7Button);
            this.gotoGroup.Name = "gotoGroup";
            this.gotoGroup.Text = "Go To";
            // 
            // todayButton
            // 
            this.todayButton.Description = "Go to current date";
            this.todayButton.KeyTip = "T";
            this.todayButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("todayButton.LargeImage")));
            this.todayButton.Name = "todayButton";
            this.todayButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("todayButton.SmallImage")));
            this.todayButton.Text = "Today";
            this.todayButton.ToolTip = "Go to current date";
            this.todayButton.Click += new System.EventHandler(this.todayButton_Click);
            // 
            // next7Button
            // 
            this.next7Button.Description = "Show next 7 days";
            this.next7Button.LargeImage = ((System.Drawing.Image)(resources.GetObject("next7Button.LargeImage")));
            this.next7Button.Name = "next7Button";
            this.next7Button.SmallImage = ((System.Drawing.Image)(resources.GetObject("next7Button.SmallImage")));
            this.next7Button.Text = "Next 7 Days";
            this.next7Button.ToolTip = "Show next 7 days";
            this.next7Button.Click += new System.EventHandler(this.next7Button_Click);
            // 
            // arrangeGroup
            // 
            this.arrangeGroup.Items.Add(this.dayButton);
            this.arrangeGroup.Items.Add(this.workweekButton);
            this.arrangeGroup.Items.Add(this.weekButton);
            this.arrangeGroup.Items.Add(this.monthButton);
            this.arrangeGroup.Items.Add(this.timelineButton);
            this.arrangeGroup.Name = "arrangeGroup";
            this.arrangeGroup.Text = "Arrange";
            // 
            // dayButton
            // 
            this.dayButton.Description = "Show the daily view";
            this.dayButton.KeyTip = "1";
            this.dayButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("dayButton.LargeImage")));
            this.dayButton.Name = "dayButton";
            this.dayButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("dayButton.SmallImage")));
            this.dayButton.Text = "Day";
            this.dayButton.ToggleGroupName = "CalendarView";
            this.dayButton.ToolTip = "Day";
            this.dayButton.Click += new System.EventHandler(this.dayButton_Click);
            // 
            // workweekButton
            // 
            this.workweekButton.Description = "Only show days in the work week";
            this.workweekButton.KeyTip = "5";
            this.workweekButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("workweekButton.LargeImage")));
            this.workweekButton.Name = "workweekButton";
            this.workweekButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("workweekButton.SmallImage")));
            this.workweekButton.Text = "Work Week";
            this.workweekButton.ToggleGroupName = "CalendarView";
            this.workweekButton.ToolTip = "Work Week";
            this.workweekButton.Click += new System.EventHandler(this.workweekButton_Click);
            // 
            // weekButton
            // 
            this.weekButton.Description = "Show entire week";
            this.weekButton.KeyTip = "7";
            this.weekButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("weekButton.LargeImage")));
            this.weekButton.Name = "weekButton";
            this.weekButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("weekButton.SmallImage")));
            this.weekButton.Text = "Week";
            this.weekButton.ToggleGroupName = "CalendarView";
            this.weekButton.ToolTip = "Week";
            this.weekButton.Click += new System.EventHandler(this.weekButton_Click);
            // 
            // monthButton
            // 
            this.monthButton.Description = "Show the month";
            this.monthButton.KeyTip = "M";
            this.monthButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("monthButton.LargeImage")));
            this.monthButton.Name = "monthButton";
            this.monthButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("monthButton.SmallImage")));
            this.monthButton.Text = "Month";
            this.monthButton.ToggleGroupName = "CalendarView";
            this.monthButton.ToolTip = "Month";
            this.monthButton.Click += new System.EventHandler(this.monthButton_Click);
            // 
            // timelineButton
            // 
            this.timelineButton.Description = "Show calendar in the horizontal layout";
            this.timelineButton.KeyTip = "S";
            this.timelineButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("timelineButton.LargeImage")));
            this.timelineButton.Name = "timelineButton";
            this.timelineButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("timelineButton.SmallImage")));
            this.timelineButton.Text = "Schedule View";
            this.timelineButton.ToggleGroupName = "CalendarView";
            this.timelineButton.ToolTip = "Schedule View";
            this.timelineButton.Click += new System.EventHandler(this.timelineButton_Click);
            // 
            // tableViewsGroup
            // 
            this.tableViewsGroup.Items.Add(this.listButton);
            this.tableViewsGroup.Items.Add(this.activeButton);
            this.tableViewsGroup.Name = "tableViewsGroup";
            this.tableViewsGroup.Text = "Table Views";
            // 
            // listButton
            // 
            this.listButton.Description = "List";
            this.listButton.KeyTip = "L";
            this.listButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("listButton.LargeImage")));
            this.listButton.Name = "listButton";
            this.listButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("listButton.SmallImage")));
            this.listButton.Text = "List";
            this.listButton.ToggleGroupName = "TableView";
            this.listButton.ToolTip = "List";
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // activeButton
            // 
            this.activeButton.LargeImage = ((System.Drawing.Image)(resources.GetObject("activeButton.LargeImage")));
            this.activeButton.Name = "activeButton";
            this.activeButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("activeButton.SmallImage")));
            this.activeButton.Text = "Active";
            this.activeButton.ToggleGroupName = "TableView";
            this.activeButton.Click += new System.EventHandler(this.activeButton_Click);
            // 
            // settingsTab
            // 
            this.settingsTab.Groups.Add(this.optionsGroup);
            this.settingsTab.KeyTip = "S";
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Text = "Settings";
            // 
            // optionsGroup
            // 
            this.optionsGroup.Items.Add(this.themeCombo);
            this.optionsGroup.Items.Add(this.ribbonSeparator1);
            this.optionsGroup.Items.Add(this.agendaCheckBox);
            this.optionsGroup.Items.Add(this.agendaViewType);
            this.optionsGroup.Name = "optionsGroup";
            this.optionsGroup.Text = "Settings";
            // 
            // themeCombo
            // 
            this.themeCombo.DropDownStyle = C1.Win.C1Ribbon.RibbonComboBoxStyle.DropDownList;
            this.themeCombo.Items.Add(this.White);
            this.themeCombo.Items.Add(this.Colorful);
            this.themeCombo.Items.Add(this.DarkGray);
            this.themeCombo.Items.Add(this.Black);
            this.themeCombo.KeyTip = "T";
            this.themeCombo.Label = "Office Theme:";
            this.themeCombo.Name = "themeCombo";
            this.themeCombo.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.TextAlwaysVisible;
            this.themeCombo.SelectedIndexChanged += new System.EventHandler(this.themeCombo_SelectedIndexChanged);
            // 
            // White
            // 
            this.White.Name = "White";
            this.White.Text = "White";
            // 
            // Colorful
            // 
            this.Colorful.Name = "Colorful";
            this.Colorful.Text = "Colorful";
            // 
            // DarkGray
            // 
            this.DarkGray.Name = "DarkGray";
            this.DarkGray.Text = "Dark Gray";
            // 
            // Black
            // 
            this.Black.Name = "Black";
            this.Black.Text = "Black";
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // agendaCheckBox
            // 
            this.agendaCheckBox.Checked = true;
            this.agendaCheckBox.Name = "agendaCheckBox";
            this.agendaCheckBox.Text = "Show Agenda";
            this.agendaCheckBox.CheckedChanged += new System.EventHandler(this.agendaCheckBox_CheckedChanged);
            // 
            // agendaViewType
            // 
            this.agendaViewType.Items.Add(this.todayAgenda);
            this.agendaViewType.Items.Add(this.weekAgenda);
            this.agendaViewType.Items.Add(this.dateRangeAgenda);
            this.agendaViewType.KeyTip = "R";
            this.agendaViewType.Label = "Range:";
            this.agendaViewType.Name = "agendaViewType";
            this.agendaViewType.SupportedGroupSizing = C1.Win.C1Ribbon.SupportedGroupSizing.TextAlwaysVisible;
            this.agendaViewType.SelectedIndexChanged += new System.EventHandler(this.agendaViewType_SelectedIndexChanged);
            // 
            // todayAgenda
            // 
            this.todayAgenda.Name = "todayAgenda";
            this.todayAgenda.Text = "Today";
            // 
            // weekAgenda
            // 
            this.weekAgenda.Name = "weekAgenda";
            this.weekAgenda.Text = "Week";
            // 
            // dateRangeAgenda
            // 
            this.dateRangeAgenda.Name = "dateRangeAgenda";
            this.dateRangeAgenda.Text = "Full";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // tableView1
            // 
            this.tableView1.AllowDelete = true;
            this.tableView1.AllowFiltering = true;
            this.tableView1.BackColor = System.Drawing.Color.White;
            this.tableView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.tableView1.Location = new System.Drawing.Point(0, 146);
            this.tableView1.Name = "tableView1";
            this.tableView1.NullEmptyString = "(none)";
            this.tableView1.Schedule = this.c1Schedule1;
            this.tableView1.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.tableView1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None;
            this.tableView1.Size = new System.Drawing.Size(850, 494);
            this.tableView1.StyleInfo = resources.GetString("tableView1.StyleInfo");
            this.tableView1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.tableView1, "(default)");
            this.tableView1.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.tableView1.Visible = false;
            this.tableView1.SelectedAppointmentsChanged += new System.EventHandler(this.tableView1_SelectedAppointmentsChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 640);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tableView1);
            this.Controls.Add(this.c1Ribbon1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "C1Schedule Table Views";
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.VisualStyleHolder = C1.Win.C1Ribbon.VisualStyle.Custom;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1NWindDataSet1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Calendar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.AppointmentStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.CategoryStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ContactStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.LabelStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.OwnerStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.ResourceStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1.DataStorage.StatusStorage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Schedule1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Schedule.C1Calendar c1Calendar1;
        private C1.Win.C1Schedule.C1Schedule c1Schedule1;
        private C1NwindDataSet c1NWindDataSet1;
        private C1NwindDataSetTableAdapters.AppointeesTableAdapter appointeesTableAdapter1;
        private C1NwindDataSetTableAdapters.AppointmentsTableAdapter appointmentsTableAdapter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.C1Schedule.C1TableView tableView1;
        private C1.Win.C1Schedule.C1AgendaView agendaView1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
        private C1.Win.C1Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.C1Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.C1Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.C1Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.C1Ribbon.RibbonQat ribbonQat1;
        private C1.Win.C1Ribbon.RibbonTab homeTab;
        private C1.Win.C1Ribbon.RibbonGroup newGroup;
        private C1.Win.C1Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.C1Ribbon.RibbonGroup gotoGroup;
        private C1.Win.C1Ribbon.RibbonGroup arrangeGroup;
        private C1.Win.C1Ribbon.RibbonButton newAppButton;
        private C1.Win.C1Ribbon.RibbonButton todayButton;
        private C1.Win.C1Ribbon.RibbonButton next7Button;
        private C1.Win.C1Ribbon.RibbonToggleButton dayButton;
        private C1.Win.C1Ribbon.RibbonToggleButton workweekButton;
        private C1.Win.C1Ribbon.RibbonToggleButton weekButton;
        private C1.Win.C1Ribbon.RibbonToggleButton monthButton;
        private C1.Win.C1Ribbon.RibbonToggleButton timelineButton;
        private C1.Win.C1Ribbon.RibbonTab settingsTab;
        private C1.Win.C1Ribbon.RibbonGroup optionsGroup;
        private C1.Win.C1Ribbon.RibbonCheckBox agendaCheckBox;
        private C1.Win.C1Ribbon.RibbonToggleButton listButton;
        private C1.Win.C1Ribbon.RibbonComboBox themeCombo;
        private C1.Win.C1Ribbon.RibbonButton White;
        private C1.Win.C1Ribbon.RibbonButton Colorful;
        private C1.Win.C1Ribbon.RibbonButton DarkGray;
        private C1.Win.C1Ribbon.RibbonButton Black;
        private C1.Win.C1Ribbon.RibbonComboBox agendaViewType;
        private C1.Win.C1Ribbon.RibbonButton todayAgenda;
        private C1.Win.C1Ribbon.RibbonButton weekAgenda;
        private C1.Win.C1Ribbon.RibbonButton dateRangeAgenda;
        private C1.Win.C1Ribbon.RibbonContextualTabGroup contextualGroup;
        private C1.Win.C1Ribbon.RibbonTab appointmentTab;
        private C1.Win.C1Ribbon.RibbonGroup appActions;
        private C1.Win.C1Ribbon.RibbonButton openAppButton;
        private C1.Win.C1Ribbon.RibbonButton deleteAppButton;
        private C1.Win.C1Ribbon.RibbonGroup appOptionsGroup;
        private C1.Win.C1Ribbon.RibbonButton recButton;
        private C1.Win.C1Ribbon.RibbonGroup tagsGroup;
        private C1.Win.C1Ribbon.RibbonToggleButton privateButton;
        private C1.Win.C1Ribbon.RibbonToggleButton highImportanceButton;
        private C1.Win.C1Ribbon.RibbonToggleButton lowImportanceButton;
        private C1.Win.C1Ribbon.RibbonGroup tableViewsGroup;
        private C1.Win.C1Ribbon.RibbonToggleButton activeButton;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator1;
    }
}

