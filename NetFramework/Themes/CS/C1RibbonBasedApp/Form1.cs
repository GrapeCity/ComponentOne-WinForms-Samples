using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using C1.Win.C1Themes;
using C1.Win.C1Ribbon;
using C1.Win.C1Schedule;
using C1.Win.C1FlexGrid;
using C1.Win.C1Input;
using C1.Win.C1Command;
using C1.Win.C1TrueDBGrid;
using C1.C1Schedule;

namespace C1RibbonBasedApp
{
    public partial class Form1 : C1RibbonForm
    {
        private int _updateCounter;
        private C1ScheduleOptions _scheduleOptions;
        private C1FlexGridOptions _flexGridOptions;
        private C1TrueDBGridOptions _trueGridOptions;

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
        }

        private void UpdateMinimizeMaximize()
        {
            if (crMain.Minimized)
            {
                minimizeRibbonButton.SmallImageKey = "MaximizeRibbon.png";
                minimizeRibbonButton.ToolTip = "Maximize the Ribbon";
            }
            else
            {
                minimizeRibbonButton.SmallImageKey = "MinimizeRibbon.png";
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

        private void ShowRibbonContextualTabGroup(
            RibbonContextualTabGroup rctg)
        {
            foreach (RibbonContextualTabGroup tg in crMain.ContextualTabGroups)
            {
                if (tg != rctgC1FlexGrid && tg != rctgC1Schedule && tg != rctgC1TrueDBGrid)
                    continue;
                if (tg != rctg)
                    tg.Visible = false;
            }
            rctg.Visible = true;
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

            //
            c1DockingTab2_SelectedTabChanged(null, EventArgs.Empty);

            // fill list of themes
            string[] themes = C1ThemeController.GetThemes();
            foreach (string theme in themes)
            {
                RibbonToggleButton rtb = new RibbonToggleButton();
                rtb.Text = theme;
                rtb.Tag = theme;
                rtb.Click += OnThemeClick;
                rtb.Pressed = C1ThemeController.ApplicationTheme == theme;
                themeMenu.Items.Add(rtb);
            }
            themeMenu.Text = string.Format("Theme: {0}", C1ThemeController.ApplicationTheme);
        }

        void OnThemeClick(object sender, EventArgs e)
        {
            RibbonToggleButton rtb = (RibbonToggleButton)sender;
            string theme = (string)rtb.Tag;
            foreach (RibbonToggleButton rb in themeMenu.Items)
                rb.Pressed = false;
            rtb.Pressed = true;
            themeMenu.Text = string.Format("Theme: {0}", theme);
            C1ThemeController.ApplicationTheme = theme;
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
                ShowRibbonContextualTabGroup(rctgC1FlexGrid);
                crMain.SelectedTab = rtC1FlexGrid;
            }
            else if (c1DockingTab2.SelectedTab == c1DockingTabPage4)
            {
                c1OutBar1.SelectedPage = copC1TrueDBGrid;
                ShowRibbonContextualTabGroup(rctgC1TrueDBGrid);
                crMain.SelectedTab = rtC1TrueDBGrid;
            }
            else if (c1DockingTab2.SelectedTab == c1DockingSchedulerTabPage)
            {
                c1OutBar1.SelectedPage = copC1Schedule;
                ShowRibbonContextualTabGroup(rctgC1Schedule);
                crMain.SelectedTab = rtC1Schedule;
                c1NavBar1.SelectedButtonIndex = 1;
            }
            EndUpdate();
        }

        private void c1OutBar1_SelectedPageChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            BeginUpdate();
            EndUpdate();
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

    }
}
