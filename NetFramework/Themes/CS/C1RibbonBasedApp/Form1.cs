using System;
using System.IO;
using C1.Win.Ribbon;
using C1.Win.C1Schedule;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using C1.Win.C1Command;
using C1.Win.C1TrueDBGrid;
using C1.C1Schedule;
using System.Drawing;
using GrapeCity.Documents.Drawing;
using System.Windows.Forms;
using C1.Win.C1Themes;
using System.Drawing.Drawing2D;

namespace C1RibbonBasedApp
{
    public partial class Form1 : C1RibbonForm
    {
        private int _updateCounter;
        private C1ScheduleOptions _scheduleOptions;
        private C1FlexGridOptions _flexGridOptions;
        private C1TrueDBGridOptions _trueGridOptions;
        private C1CommandLink currentBtn;
        // Panel to act as the strip with custom color
        private Panel blueStrip;

        public Form1()
        {
            InitializeComponent();

            _scheduleOptions = new C1ScheduleOptions(this.csMain);
            _flexGridOptions = new C1FlexGridOptions(this.c1FlexGrid1);
            _trueGridOptions = new C1TrueDBGridOptions(this.c1TrueDBGrid1);

            // 
            ccCFGViewNormal.CommandStateQuery += C1FlexGridViewCommandStateQuery;
            ccCFGViewNormal.Click += C1FlexGridViewCommandClick;
            ccCFGViewTree.CommandStateQuery += C1FlexGridViewCommandStateQuery;
            ccCFGViewTree.Click += C1FlexGridViewCommandClick;
            ccCFGViewSubtotals.CommandStateQuery += C1FlexGridViewCommandStateQuery;
            ccCFGViewSubtotals.Click += C1FlexGridViewCommandClick;

            //
            ccCTDBGViewNormal.CommandStateQuery += C1TrueDBGridViewCommandStateQuery;
            ccCTDBGViewNormal.Click += C1TrueDBGridViewCommandClick;
            ccCTDBGViewForm.CommandStateQuery += C1TrueDBGridViewCommandStateQuery;
            ccCTDBGViewForm.Click += C1TrueDBGridViewCommandClick;
            ccCTDBGViewGroupBy.CommandStateQuery += C1TrueDBGridViewCommandStateQuery;
            ccCTDBGViewGroupBy.Click += C1TrueDBGridViewCommandClick;
            ccCTDBGViewHierarchical.CommandStateQuery += C1TrueDBGridViewCommandStateQuery;
            ccCTDBGViewHierarchical.Click += C1TrueDBGridViewCommandClick;
            ccCTDBGViewInverted.CommandStateQuery += C1TrueDBGridViewCommandStateQuery;
            ccCTDBGViewInverted.Click += C1TrueDBGridViewCommandClick;
            ccCTDBGViewMultipleLines.CommandStateQuery += C1TrueDBGridViewCommandStateQuery;
            ccCTDBGViewMultipleLines.Click += C1TrueDBGridViewCommandClick;

            //
            ccCSViewDay.CommandStateQuery += C1ScheduleViewCommandStateQuery;
            ccCSViewDay.Click += C1ScheduleViewCommandClick;
            ccCSViewMonth.CommandStateQuery += C1ScheduleViewCommandStateQuery;
            ccCSViewMonth.Click += C1ScheduleViewCommandClick;
            ccCSViewTimeLine.CommandStateQuery += C1ScheduleViewCommandStateQuery;
            ccCSViewTimeLine.Click += C1ScheduleViewCommandClick;
            ccCSViewWeek.CommandStateQuery += C1ScheduleViewCommandStateQuery;
            ccCSViewWeek.Click += C1ScheduleViewCommandClick;
            ccCSViewWorkWeek.CommandStateQuery += C1ScheduleViewCommandStateQuery;
            ccCSViewWorkWeek.Click += C1ScheduleViewCommandClick;

            // Blue panel strip.
            blueStrip = new Panel
            {
                Size = new Size(5, 0), // 5px wide, height will adjust dynamically
                BackColor = Color.Transparent, // Set to transparent to enable custom painting
                Visible = true // Initially hidden
            };
            blueStrip.Paint += BlueStrip_Paint;
            this.Controls.Add(blueStrip);


            c1DockingTabPage2.TabClick += C1DockingTabPage2_TabClick;
            c1DockingTabPage1.TabClick += C1DockingTabPage1_TabClick;
            c1DockingTab1.SizeChanged += C1CommandDock1_SizeChanged;
            c1DockingTab1.HandleCreated += C1CommandDock1_SizeChanged;
            c1DockingTabPage2.Closed += C1DockingTabPage2_Closed;
            c1DockingTabPage1.Closed += C1DockingTabPage1_Closed;
        }

        private void C1DockingTabPage1_Closed(object sender, EventArgs e)
        {
            blueStrip.Visible = false;
        }

        private void C1DockingTabPage2_Closed(object sender, EventArgs e)
        {
            if (c1DockingTab1.SelectedIndex==0)
            {
                c1OutBar1_SelectedPageChanged(sender, e);
            }
            
        }

        private void C1CommandDock1_SizeChanged(object sender, EventArgs e)
        {
            if (sender is C1DockingTab dockingTab)
            {
                if (dockingTab.SelectedIndex == 0)
                {
                    c1OutBar1_SelectedPageChanged(sender, e);
                }
                else
                {
                    blueStrip.Visible = false;
                }
            }
            
        }

        private void C1DockingTabPage1_TabClick(object sender, EventArgs e)
        {
            c1OutBar1_SelectedPageChanged(sender, e);
        }

        private void C1DockingTabPage2_TabClick(object sender, EventArgs e)
        {
            blueStrip.Visible = false;
        }

        private void C1FlexGridViewCommandStateQuery(
            object sender,
            CommandStateQueryEventArgs e)
        {
            FlexViewModeEnum vm = (FlexViewModeEnum)Enum.Parse(typeof(FlexViewModeEnum), (string)((C1Command)sender).UserData);
            e.Pressed = _flexGridOptions.ViewMode == vm;
        }

        private void C1FlexGridViewCommandClick(
            object sender,
            ClickEventArgs e)
        {
            FlexViewModeEnum vm = (FlexViewModeEnum)Enum.Parse(typeof(FlexViewModeEnum), (string)((C1Command)sender).UserData);
            _flexGridOptions.ViewMode = vm;
            UpdateControls();
            ActivateCommandLink(sender,ctbC1FlexGrid, copC1FlexGrid);
        }

        private void C1TrueDBGridViewCommandStateQuery(
            object sender,
            CommandStateQueryEventArgs e)
        {
            DataViewEnum dv = (DataViewEnum)Enum.Parse(typeof(DataViewEnum), (string)((C1Command)sender).UserData);
            e.Pressed = _trueGridOptions.DataView == dv;
        }

        private void C1TrueDBGridViewCommandClick(
            object sender,
            ClickEventArgs e)
        {
            DataViewEnum dv = (DataViewEnum)Enum.Parse(typeof(DataViewEnum), (string)((C1Command)sender).UserData);
            _trueGridOptions.DataView = dv;
            UpdateControls();
            ActivateCommandLink(sender, ctbC1TrueDBGridView, copC1TrueDBGrid);
        }

        private void C1ScheduleViewCommandStateQuery(
            object sender,
            CommandStateQueryEventArgs e)
        {
            ScheduleViewEnum sv = (ScheduleViewEnum)Enum.Parse(typeof(ScheduleViewEnum), (string)((C1Command)sender).UserData);
            e.Pressed = _scheduleOptions.ViewType == sv;
        }

        private void C1ScheduleViewCommandClick(
            object sender,
            ClickEventArgs e)
        {
            ScheduleViewEnum sv = (ScheduleViewEnum)Enum.Parse(typeof(ScheduleViewEnum), (string)((C1Command)sender).UserData);
            _scheduleOptions.ViewType = sv;
            UpdateControls();
            ActivateCommandLink(sender, ctbC1ScheduleView, copC1Schedule);
        }

        private void UpdateMinimizeMaximize()
        {
            if (crMain.Minimized)
            {
                minimizeRibbonButton.SmallImage = ilSmall.Images["MaximizeRibbon.png"];
                minimizeRibbonButton.ToolTip = "Maximize the Ribbon";
            }
            else
            {
                minimizeRibbonButton.SmallImage = ilSmall.Images["MinimizeRibbon.png"];
                minimizeRibbonButton.ToolTip = "Minimize the Ribbon";
            }
        }

        /// <summary>
        /// Method called before updating controls like cneFixedColCount, cneFixedRowCount
        /// to suppress events called when value of such controls is changed.
        /// </summary>
        private void BeginUpdate()
        {
            _updateCounter++;
        }

        /// <summary>
        /// Called after BeginUpdate().
        /// </summary>
        private void EndUpdate()
        {
            _updateCounter--;
        }

        /// <summary>
        /// Returns true if execution between BeforeUpdate() and EndUpdate().
        /// </summary>
        private bool UpdateDisabled
        {
            get { return _updateCounter != 0; }
        }

        private void FillItems(
            RibbonComboBox rcb,
            Type type)
        {
            rcb.Items.Clear();
            Array values = Enum.GetValues(type);
            string[] names = Enum.GetNames(type);

            for (int i = 0; i < values.Length; i++)
            {
                RibbonButton rb = new RibbonButton(names[i]);
                rb.Tag = values.GetValue(i);
                rcb.Items.Add(rb);
            }
        }

        private void FillItems(
            C1SplitButton btn,
            Type enumType)
        {
            Array values = Enum.GetValues(enumType);
            string[] names = Enum.GetNames(enumType);

            btn.Items.Clear();
            for (int i = 0; i < values.Length; i++)
            {
                DropDownItem ddi = new DropDownItem();
                ddi.Text = names[i];
                ddi.Tag = values.GetValue(i);
                btn.Items.Add(ddi);
            }
        }

        // Select item in RibbonGallery by its tag
        private void SelectRibbonGalleryItem(
            RibbonGallery rg,
            object v)
        {
            for (int i = 0; i < rg.Items.Count; i++)
                if ((string)rg.Items[i].Tag == v.ToString())
                {
                    rg.SelectedIndex = i;
                    return;
                }
        }

        private void SelectComboBoxItem(
            RibbonComboBox rcb,
            object v)
        {
            for (int i = 0; i < rcb.Items.Count; i++)
                if (rcb.Items[i].Tag.Equals(v))
                {
                    rcb.SelectedIndex = i;
                    return;
                }
        }

        private void ShowRibbonTab(
            RibbonTab rt)
        {
            foreach (RibbonTab tg in crMain.Tabs)
            {
                if (tg != rtC1FlexGrid && tg != rtC1TrueDBGrid && tg != rtC1Schedule)
                    continue;
                if (tg != rt)
                    tg.Visible = false;
            }
            rt.Visible = true;
        }

        // Initializes controls on c1OutBar1
        private void UpdateControls()
        {
            BeginUpdate();
           
            // C1FlexGrid options
            // update C1Input controls
            csbSelectionMode.Text = _flexGridOptions.SelectionMode.ToString();
            csbFocusRect.Text = _flexGridOptions.FocusRect.ToString();
            cneFixedColCount.Value = _flexGridOptions.FrozenColCount;
            cneFixedColCount.PostValidation.Intervals.Clear();
            cneFixedColCount.PostValidation.Intervals.Add(new ValueInterval(0, c1FlexGrid1.Cols.Count, true, true));
            cneFixedRowCount.Value = _flexGridOptions.FrozenRowCount;
            cneFixedRowCount.PostValidation.Intervals.Clear();
            cneFixedRowCount.PostValidation.Intervals.Add(new ValueInterval(0, c1FlexGrid1.Rows.Count, true, true));
            ccbShowCursor.Checked = _flexGridOptions.ShowCursor;
            // update ribbon controls
            SelectRibbonGalleryItem(rglrCFGView, _flexGridOptions.ViewMode);
            SelectRibbonGalleryItem(rglrCSView, _scheduleOptions.ViewType);
            rnbCFGFixedColCount.Value = _flexGridOptions.FrozenColCount;
            rnbCFGFixedRowCount.Value = _flexGridOptions.FrozenRowCount;
            SelectComboBoxItem(rcbCFGSelectionMode, _flexGridOptions.SelectionMode);
            SelectComboBoxItem(rcbCFGFocusRect, _flexGridOptions.FocusRect);
            rcbCFGShowCursor.Checked = _flexGridOptions.ShowCursor;

            // C1TrueDBGrid options
            ccbCTDBGShowCaption.Checked = _trueGridOptions.ShowCaption;
            ccbCTDBGShowFilterBar.Checked = _trueGridOptions.ShowFilterBar;
            // update ribbon controls
            SelectRibbonGalleryItem(rglrCTDBGView, _trueGridOptions.DataView);
            rcbCTDBGShowCaption.Checked = _trueGridOptions.ShowCaption;
            rcbCTDBGShowFilterBar.Checked = _trueGridOptions.ShowFilterBar;

            // C1Schedule options
            // update C1Input controls
            ccbCSEnableGrouping.Checked = _scheduleOptions.EnableGrouping;
            ccbCSOffice2003WeekView.Checked = _scheduleOptions.Office2003WeekView;
            // update C1Ribbon controls
            rcbCSEnableGrouping.Checked = _scheduleOptions.EnableGrouping;
            rcbCSOffice2003WeekView.Checked = _scheduleOptions.Office2003WeekView;

            EndUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common\";
            if (File.Exists(path + "c1nwind.mdb"))
                AppDomain.CurrentDomain.SetData("DataDirectory", path);

            // TODO: This line of code loads data into the 'c1NWINDDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.c1NWINDDataSet.Employees);

            //
            // initialize C1Schedule
            //
            csMain.ShowReminderForm = false;

            DateTime now = DateTime.Now;
            Appointment app = csMain.DataStorage.AppointmentStorage.Appointments.Add(new DateTime(now.Year, now.Month, now.Day, now.Hour, 0, 0), TimeSpan.FromHours(1));
            app.Subject = "test appointment";
            app.Location = "test location";
            app.Categories.Add(csMain.DataStorage.CategoryStorage.Categories[0]);

            app = csMain.DataStorage.AppointmentStorage.Appointments.Add(new DateTime(now.Year, now.Month, now.Day).AddDays(1), TimeSpan.FromHours(24));
            app.Subject = "test event";
            app.AllDayEvent = true;
            app.Location = "test location";
            app.Categories.Add(csMain.DataStorage.CategoryStorage.Categories[0]);

            //
            // initialize C1TrueDBGrid
            //
            _trueGridOptions.ShowCaption = true;
            _trueGridOptions.ShowFilterBar = true;
            _trueGridOptions.ShowGroupByArea = true;
            _trueGridOptions.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.Normal;

            //
            // initialize C1FlexGrid
            //
            _flexGridOptions.ViewMode = FlexViewModeEnum.Normal;
            _flexGridOptions.FrozenColCount = 3;
            rnbCFGFixedColCount.Minimum = 0;
            rnbCFGFixedColCount.Maximum = c1FlexGrid1.Cols.Count;
            rnbCFGFixedRowCount.Minimum = 0;
            rnbCFGFixedRowCount.Maximum = c1FlexGrid1.Rows.Count;

            // fill items of C1SplitButton used to select C1FlexGrid view mode
            FillItems(csbSelectionMode, typeof(SelectionModeEnum));
            FillItems(csbFocusRect, typeof(FocusRectEnum));
            FillItems(rcbCFGSelectionMode, typeof(C1.Win.C1FlexGrid.SelectionModeEnum));
            FillItems(rcbCFGFocusRect, typeof(C1.Win.C1FlexGrid.FocusRectEnum));

            //
            UpdateControls();

            //
            UpdateMinimizeMaximize();

        


            //apply Office365White theme
            var theme = C1ThemeController.GetThemeByName("Office365White", false);
            C1ThemeController.ApplyThemeToControlTree(this,theme,null,true);

            //Show and Hide of the Tabs.
            c1DockingTab2_SelectedTabChanged(null, EventArgs.Empty);


            //change background colors.
            ctbMain.BackColor = Color.White;
            tableLayoutPanel1.BackColor = Color.White;
            panel2.BackColor = Color.White;
            panel3.BackColor = Color.White;
            c1OutBar1.BackColor = Color.White;

            
        }


        private void cneFixedColCount_ValueChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _flexGridOptions.FrozenColCount = (int)(decimal)cneFixedColCount.Value;
            UpdateControls();
        }

        private void cneFixedRowCount_ValueChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _flexGridOptions.FrozenRowCount = (int)(decimal)cneFixedRowCount.Value;
            UpdateControls();
        }

        private void csbSelectionMode_DropDownItemClicked(object sender, DropDownItemClickedEventArgs e)
        {
            if (UpdateDisabled)
                return;
            ((C1SplitButton)sender).Text = e.ClickedItem.Text;
            _flexGridOptions.SelectionMode = (SelectionModeEnum)e.ClickedItem.Tag;
            UpdateControls();
        }

        private void csbFocusRect_DropDownItemClicked(object sender, DropDownItemClickedEventArgs e)
        {
            if (UpdateDisabled)
                return;
            ((C1SplitButton)sender).Text = e.ClickedItem.Text;
            _flexGridOptions.FocusRect = (FocusRectEnum)e.ClickedItem.Tag;
            UpdateControls();
        }

        private void ccbShowCursor_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _flexGridOptions.ShowCursor = ccbShowCursor.Checked;
            UpdateControls();
        }

        private void ccbCTDBGShowCaption_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _trueGridOptions.ShowCaption = ccbCTDBGShowCaption.Checked;
            UpdateControls();
        }

        private void ccbCTDBGShowFilterBar_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _trueGridOptions.ShowFilterBar = ccbCTDBGShowFilterBar.Checked;
            UpdateControls();
        }

        private void ccbCSEnableGrouping_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _scheduleOptions.EnableGrouping = ccbCSEnableGrouping.Checked;
            UpdateControls();
        }

        private void ccbCSOffice2003WeekView_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _scheduleOptions.Office2003WeekView = ccbCSOffice2003WeekView.Checked;
            UpdateControls();
        }

        private void rglrCFGView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _flexGridOptions.ViewMode = (FlexViewModeEnum)Enum.Parse(typeof(FlexViewModeEnum), (string)rglrCFGView.SelectedItem.Tag);
            UpdateControls();
        }

        private void rnbCFGFixedColCount_ValueChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _flexGridOptions.FrozenColCount = (int)rnbCFGFixedColCount.Value;
            UpdateControls();
        }

        private void rnbCFGFixedRowCount_ValueChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _flexGridOptions.FrozenRowCount = (int)rnbCFGFixedRowCount.Value;
            UpdateControls();
        }

        private void rcbCFGSelectionMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _flexGridOptions.SelectionMode = (SelectionModeEnum)rcbCFGSelectionMode.SelectedItem.Tag;
            UpdateControls();
        }

        private void rcbCFGFocusRect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _flexGridOptions.FocusRect = (FocusRectEnum)rcbCFGFocusRect.SelectedItem.Tag;
            UpdateControls();
        }

        private void rcbCFGShowCursor_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _flexGridOptions.ShowCursor = rcbCFGShowCursor.Checked;
            UpdateControls();
        }

        private void rglrCTDBGView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _trueGridOptions.DataView = (DataViewEnum)Enum.Parse(typeof(DataViewEnum), (string)rglrCTDBGView.SelectedItem.Tag);
            UpdateControls();
        }

        private void rcbCTDBGShowCaption_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _trueGridOptions.ShowCaption = rcbCTDBGShowCaption.Checked;
            UpdateControls();
        }

        private void rcbCTDBGShowFilterBar_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _trueGridOptions.ShowFilterBar = rcbCTDBGShowFilterBar.Checked;
            UpdateControls();
        }

        private void rglrCSView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _scheduleOptions.ViewType = (ScheduleViewEnum)Enum.Parse(typeof(ScheduleViewEnum), (string)rglrCSView.SelectedItem.Tag);
            UpdateControls();
        }

        private void rcbCSEnableGrouping_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _scheduleOptions.EnableGrouping = rcbCSEnableGrouping.Checked;
            UpdateControls();
        }

        private void rcbCSOffice2003WeekView_CheckedChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _scheduleOptions.Office2003WeekView = rcbCSOffice2003WeekView.Checked;
            UpdateControls();
        }

        private void c1DockingTab2_SelectedTabChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            BeginUpdate();
            if (c1DockingTab2.SelectedTab == c1DockingTabPage3)
            {
                c1OutBar1.SelectedPage = copC1FlexGrid;
                ShowRibbonTab(rtC1FlexGrid);
                crMain.SelectedTab = rtC1FlexGrid;
                ActivateCommandLinkForFlex();
                


            }
            else if (c1DockingTab2.SelectedTab == c1DockingTabPage4)
            {
                c1OutBar1.SelectedPage = copC1TrueDBGrid;
                ShowRibbonTab(rtC1TrueDBGrid);
                crMain.SelectedTab = rtC1TrueDBGrid;

                ActivateCommandLinkForTrueDB();
              
            }
            else if (c1DockingTab2.SelectedTab == c1DockingSchedulerTabPage)
            {
                c1OutBar1.SelectedPage = copC1Schedule;
                ShowRibbonTab(rtC1Schedule);
                crMain.SelectedTab = rtC1Schedule;
                c1NavBar1.SelectedButtonIndex = 1;
                ActivateCommandLinkForSchedule();
               
            }
            EndUpdate();
        }

        private void ActivateCommandLinkForSchedule()
        {
            // Activate the appropriate command link based on the tab
            var command = new C1Command();

            switch (_scheduleOptions.ViewType)
            {
                case ScheduleViewEnum.DayView:
                    command = ccCSViewDay;
                    break;
                case ScheduleViewEnum.WorkWeekView:
                    command = ccCSViewWorkWeek;
                    break;
                case ScheduleViewEnum.WeekView:
                    command = ccCSViewWeek;
                    break;
                case ScheduleViewEnum.MonthView:
                    command = ccCSViewMonth;
                    break;
                case ScheduleViewEnum.TimeLineView:
                    command = ccCSViewTimeLine;
                    break;
                default:
                    command = ccCSViewWorkWeek;
                    break;
            }
            ActivateCommandLink(command, ctbC1ScheduleView, copC1Schedule);
        }

        private void ActivateCommandLinkForTrueDB()
        {
            // Activate the appropriate command link based on the tab
            var command = new C1Command();

            switch (_trueGridOptions.DataView)
            {
                case DataViewEnum.Normal:
                    command = ccCTDBGViewNormal;
                    break;
                case DataViewEnum.Inverted:
                    command = ccCTDBGViewInverted;
                    break;
                case DataViewEnum.Form:
                    command = ccCTDBGViewForm;
                    break;
                case DataViewEnum.GroupBy:
                    command = ccCTDBGViewGroupBy;
                    break;
                case DataViewEnum.MultipleLines:
                    command = ccCTDBGViewMultipleLines;
                    break;
                case DataViewEnum.Hierarchical:
                    command = ccCTDBGViewHierarchical;
                    break;
                default:
                    command = ccCTDBGViewNormal;
                    break;
            }
            ActivateCommandLink(command, ctbC1TrueDBGridView, copC1TrueDBGrid);
        }

        private void ActivateCommandLinkForFlex()
        {
            // Activate the appropriate command link based on the tab
            var command = new C1Command();

            switch (_flexGridOptions.ViewMode)
            {
                case FlexViewModeEnum.Normal:
                    command = ccCFGViewNormal;
                    break;
                case FlexViewModeEnum.Tree:
                    command = ccCFGViewTree;
                    break;
                case FlexViewModeEnum.Subtotals:
                    command = ccCFGViewSubtotals;
                    break;
                default:
                    command = ccCFGViewNormal;
                    break;
            }

            //ativate the command link.
            ActivateCommandLink(command, ctbC1FlexGrid, copC1FlexGrid);
        }

        private void c1OutBar1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            BeginUpdate();
            EndUpdate();
      
            if (c1OutBar1.SelectedIndex == 0)
            {
                ActivateCommandLinkForFlex();
            }
            else if (c1OutBar1.SelectedIndex==1)
            {
                ActivateCommandLinkForTrueDB();
            }
            else
            { 
                ActivateCommandLinkForSchedule();
            }
            
        }

        private void minimizeRibbonButton_Click(object sender, EventArgs e)
        {
            crMain.Minimized = !crMain.Minimized;
            UpdateMinimizeMaximize();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void C1NavBar1_ButtonClick(object sender, System.EventArgs e)
        {
            if (c1NavBar1.SelectedPanel == this.c1NavBarPanel2)
            {
                c1DockingTab2.SelectedTab = c1DockingSchedulerTabPage;
            }
        }


        // Method to find the C1CommandLink by its associated C1Command
        private C1CommandLink FindCommandLinkByCommand(C1ToolBar toolBar, C1Command command)
        {
            foreach (C1CommandLink commandLink in toolBar.CommandLinks)
            {
                if (commandLink.Command == command)
                {
                    return commandLink;
                }
            }
            return null; // Return null if no matching command link is found
        }

        private void BlueStrip_Paint(object sender, PaintEventArgs e)
        {
            if (sender is Panel panel)
            {
                // Ensure blue strip is drawn without covering buttons
                if (blueStrip.Visible)
                {
                    using (System.Drawing.Pen roundedPen = new System.Drawing.Pen(ColorTranslator.FromHtml("#005FB8"), 5))
                    {
                        roundedPen.StartCap = LineCap.Round;
                        roundedPen.EndCap = LineCap.Round;
                        roundedPen.LineJoin = LineJoin.Round;

                        // Center line within the panel width
                        float startX = 2;
                        float startY = 3;
                        float endX = startX;
                        float endY = panel.Height-3;

                        // Draw the rounded line
                        e.Graphics.DrawLine(roundedPen, startX, startY, endX, endY);
                    }
                }
            }
        }

        // Method to activate the blue strip for the selected button
        private void ActivateCommandLink(object senderBtn, C1ToolBar toolBar, C1OutPage c1OutPage)
        {
            blueStrip.Visible = false;
            if ((senderBtn is C1Command currentCommand)&&(!c1DockingTab1.AutoHiding))
            {
                // Find the associated C1CommandLink for the clicked command
                currentBtn = FindCommandLinkByCommand(toolBar, currentCommand);

                if (currentBtn != null)
                {
                    // Calculate the x and y position for the blue strip
                    int x = c1CommandDock1.Bounds.X + c1DockingTab1.Bounds.X + c1DockingTabPage1.Bounds.X +
                            c1OutBar1.Bounds.X + c1OutPage.Bounds.X + toolBar.Bounds.X + currentBtn.Bounds.X;


                    int y = c1CommandDock1.Bounds.Y + c1DockingTab1.Bounds.Y + c1DockingTabPage1.Bounds.Y +
                            c1OutBar1.Bounds.Y + c1OutPage.Bounds.Y + toolBar.Bounds.Y + currentBtn.Bounds.Y;

                    // Adjust the blue strip to match the selected C1CommandLink button
                    blueStrip.Height = currentBtn.Bounds.Height-8;
                    blueStrip.Location = new Point(x + 2, y+5);
                    blueStrip.Visible = true;
                    blueStrip.Invalidate();
                    blueStrip.BringToFront();

                }
                else
                {
                    // Handle case when no matching command link is found
                    blueStrip.Visible = false;
                }
            }
        }

        private void c1DockingTab1_AutoHidingChanged(object sender, EventArgs e)
        {
            if (sender is C1DockingTab dockingTab)
            {
                if (dockingTab.AutoHiding)
                {
                    blueStrip.Visible = false;

                }
                else if (dockingTab.SelectedIndex == 0)
                {
                    c1OutBar1_SelectedPageChanged(sender, e);
                }
                else
                {
                    blueStrip.Visible = false;
                }
            }

        }
    }
}
