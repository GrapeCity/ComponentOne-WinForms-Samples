using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using C1.Win.C1FlexGrid;
using C1.Win.C1TrueDBGrid;
using C1.Win.C1Command;
using C1.Win.C1Themes;
using C1.Win.C1Schedule;
using C1.Win.C1Input;
using C1.C1Schedule;

namespace C1CommandBasedApp
{
    public partial class Form1 : Form
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

            //
            ccCTDBGShowCaption.CommandStateQuery += (s, e) => e.Pressed = _trueGridOptions.ShowCaption;
            ccCTDBGShowCaption.Click += (s, e) => { _trueGridOptions.ShowCaption = !_trueGridOptions.ShowCaption; UpdateControls(); };

            ccCFGShowCursor.CommandStateQuery += (s, e) => e.Pressed = _flexGridOptions.ShowCursor;
            ccCFGShowCursor.Click += (s, e) => { _flexGridOptions.ShowCursor = !_flexGridOptions.ShowCursor; UpdateControls(); };

            ccCSEnableGrouping.CommandStateQuery += (s, e) => e.Pressed = _scheduleOptions.EnableGrouping;
            ccCSEnableGrouping.Click += (s, e) => { _scheduleOptions.EnableGrouping = !_scheduleOptions.EnableGrouping; UpdateControls(); };
            ccCSOffice2003WeekView.CommandStateQuery += (s, e) => e.Pressed = _scheduleOptions.Office2003WeekView;
            ccCSOffice2003WeekView.Click += (s, e) => { _scheduleOptions.Office2003WeekView = !_scheduleOptions.Office2003WeekView; UpdateControls(); };
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

            //
            FillItems(ccmCFGSelectionMode, typeof(C1.Win.C1FlexGrid.SelectionModeEnum), SelectionModeCommandClick, SelectionModeCommandStateQuery);
            FillItems(ccmCFGFocusRect, typeof(C1.Win.C1FlexGrid.FocusRectEnum), FocusRectCommandClick, FocusRectCommandStateQuery);
            FillItems(csbSelectionMode, typeof(SelectionModeEnum));
            FillItems(csbFocusRect, typeof(FocusRectEnum));

            //
            UpdateControls();

            //
            c1DockingTab2_SelectedTabChanged(null, EventArgs.Empty);

            // fill list of themes
            string[] themes = C1ThemeController.GetThemes();
            ccmTheme.CommandLinks.Clear();
            for (int i = 0; i < themes.Length; i++)
            {
                C1Command cmd = new C1Command();
                cmd.Text = themes[i];
                cmd.UserData = themes[i];
                cmd.CommandStateQuery += OnThemeCommandStateQuery;
                cmd.Click += OnThemeClick;
                C1CommandLink cl = new C1CommandLink(cmd);
                ccmTheme.CommandLinks.Add(cl);
            }
            ccmTheme.Text = string.Format("Theme: {0}", C1ThemeController.ApplicationTheme);
        }

        /// <summary>
        /// Sets the application theme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnThemeClick(object sender, EventArgs e)
        {
            C1Command c = (C1Command)sender;
            string theme = (string)c.UserData;

            // reset Form.Font to default first
            this.Font = new Font("Segoe UI", 8F);

            C1ThemeController.ApplicationTheme = theme;
            ccmTheme.Text = string.Format("Theme: {0}", theme);
        }

        /// <summary>
        /// Sets the 'pressed' state on the menu item corresponding to the current application theme.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnThemeCommandStateQuery(
            object sender,
            CommandStateQueryEventArgs e)
        {
            C1Command c = (C1Command)sender;
            e.Pressed = C1ThemeController.ApplicationTheme == (string)c.UserData;
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

        private void FillItems(
            C1CommandMenu cm,
            Type type,
            ClickEventHandler commandClick,
            CommandStateQueryEventHandler commandStateQuery)
        {
            Array values = Enum.GetValues(type);
            string[] names = Enum.GetNames(type);

            cm.CommandLinks.Clear();
            for (int i = 0; i < values.Length; i++)
            {
                C1Command cmd = new C1Command();
                cmd.Text = names[i];
                cmd.UserData = values.GetValue(i);
                cmd.CommandStateQuery += commandStateQuery;
                cmd.Click += commandClick;
                C1CommandLink cl = new C1CommandLink(cmd);
                cm.CommandLinks.Add(cl);
            }
        }

        private void SelectionModeCommandStateQuery(
            object sender,
            CommandStateQueryEventArgs e)
        {
            SelectionModeEnum sm = (SelectionModeEnum)((C1Command)sender).UserData;
            e.Pressed = _flexGridOptions.SelectionMode == sm;
        }

        private void SelectionModeCommandClick(
            object sender,
            ClickEventArgs e)
        {
            SelectionModeEnum sm = (SelectionModeEnum)((C1Command)sender).UserData;
            _flexGridOptions.SelectionMode = sm;
            UpdateControls();
        }

        private void FocusRectCommandStateQuery(
            object sender,
            CommandStateQueryEventArgs e)
        {
            FocusRectEnum fr = (FocusRectEnum)((C1Command)sender).UserData;
            e.Pressed = _flexGridOptions.FocusRect == fr;
        }

        private void FocusRectCommandClick(
            object sender,
            ClickEventArgs e)
        {
            FocusRectEnum fr = (FocusRectEnum)((C1Command)sender).UserData;
            _flexGridOptions.FocusRect = fr;
            UpdateControls();
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
            cneCFGFrozenColCount.Value = _flexGridOptions.FrozenColCount;
            cneCFGFrozenColCount.PostValidation.Intervals.Clear();
            cneCFGFrozenColCount.PostValidation.Intervals.Add(new ValueInterval(0, c1FlexGrid1.Cols.Count, true, true));
            cneCFGFrozenRowCount.Value = _flexGridOptions.FrozenRowCount;
            cneCFGFrozenRowCount.PostValidation.Intervals.Clear();
            cneCFGFrozenRowCount.PostValidation.Intervals.Add(new ValueInterval(0, c1FlexGrid1.Rows.Count, true, true));
            ccbShowCursor.Checked = _flexGridOptions.ShowCursor;

            // C1TrueDBGrid options
            ccbCTDBGShowCaption.Checked = _trueGridOptions.ShowCaption;
            ccbCTDBGShowFilterBar.Checked = _trueGridOptions.ShowFilterBar;

            // C1Schedule options
            // update C1Input controls
            ccbCSEnableGrouping.Checked = _scheduleOptions.EnableGrouping;
            ccbCSOffice2003WeekView.Checked = _scheduleOptions.Office2003WeekView;

            EndUpdate();
        }

        private void c1DockingTab2_SelectedTabChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            BeginUpdate();
            if (c1DockingTab2.SelectedTab == c1DockingTabPage3)
            {
                c1OutBar1.SelectedPage = copC1FlexGrid;
            }
            else if (c1DockingTab2.SelectedTab == c1DockingTabPage4)
            {
                c1OutBar1.SelectedPage = copC1TrueDBGrid;
            }
            else if (c1DockingTab2.SelectedTab == c1DockingTabPage5)
            {
                c1OutBar1.SelectedPage = copC1Schedule;
                c1NavBar1.SelectedButtonIndex = 1;
            }
            EndUpdate();
        }

        private void ccFileExit_Click(object sender, ClickEventArgs e)
        {
            Close();
        }

        private void cneFixedColCount_ValueChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _flexGridOptions.FrozenColCount = (int)(decimal)((C1NumericEdit)sender).Value;
            UpdateControls();
        }

        private void cneFixedRowCount_ValueChanged(object sender, EventArgs e)
        {
            if (UpdateDisabled)
                return;
            _flexGridOptions.FrozenRowCount = (int)(decimal)((C1NumericEdit)sender).Value;
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
    }
}
