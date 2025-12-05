using C1.Win.GanttView;
using C1.Win.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using C1.Win.Themes;
using C1.Win.FlexGrid;
using System.Threading.Tasks;
using static C1.Win.GanttView.Localization.Strings;

namespace SoftwareDevelopmentPlan
{
    public partial class SoftwareDevelopmentPlan : C1RibbonForm
    {
        private bool _zoomfactorIsChanging = false;
        private OpenFileAppMenu _openFileAppMenu;
        private SaveFileAppMenu _saveFileAppMenu;

        public SoftwareDevelopmentPlan()
        {
            InitializeComponent();

            ganttView.LoadXml(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "ganttview.xml"));

            rcbTimeline.Items.Add("15 Minutes");
            rcbTimeline.Items.Add("2 Hours");
            rcbTimeline.Items.Add("Quarter Days");
            rcbTimeline.Items.Add("Days");
            rcbTimeline.Items.Add("3 Days");
            rcbTimeline.Items.Add("7 Days");
            rcbTimeline.Items.Add("Months");
            rcbTimeline.Items.Add("Months");
            rcbTimeline.Items.Add("Quarters");
            rcbTimeline.Items.Add("Half-Years");
            Timescale_ZoomFactorChanged(null, EventArgs.Empty);

            // Set current colors and add event handler 
            // for items in Colors menu at Ribbon's Formatting tab
            rcpCellBorder.SelectedColorChanged += new EventHandler(rcpCellBorder_SelectedColorChanged);
            rcpCellBorder.DefaultColor = ganttView.CellBorderColor;

            rcpEmptyAreaBack.SelectedColorChanged += new EventHandler(rcpEmptyAreaBackground_SelectedColorChanged);
            rcpEmptyAreaBack.DefaultColor = ganttView.EmptyAreaBackColor;

            rcpFixedBackground.SelectedColorChanged += new EventHandler(rcpFixedBackground_SelectedColorChanged);
            rcpFixedBackground.DefaultColor = ganttView.FixedBackColor;

            rcpFixedCellBorder.SelectedColorChanged += new EventHandler(rcpFixedCellBorder_SelectedColorChanged);
            rcpFixedCellBorder.DefaultColor = ganttView.FixedCellBorderColor;

            rcpFixedForeground.SelectedColorChanged += new EventHandler(rcpFixedForeground_SelectedColorChanged);
            rcpFixedForeground.DefaultColor = ganttView.FixedForeColor;

            rcpHightlightBackground.SelectedColorChanged += new EventHandler(rcpHighlightBackground_SelectedColorChanged);
            rcpHightlightBackground.DefaultColor = ganttView.HighlightBackColor;

            rcpHightlightForeground.SelectedColorChanged += new EventHandler(rcpHighlightForeground_SelectedColorChanged);
            rcpHightlightForeground.DefaultColor = ganttView.HighlightForeColor;

            rcpNonworkingTime.SelectedColorChanged += new EventHandler(rcpNonworkingTime_SelectedColorChanged);
            rcpNonworkingTime.DefaultColor = ganttView.NonworkingTimeColor;

            rcpSplitter.SelectedColorChanged += new EventHandler(rcpSplitter_SelectedColorChanged);
            rcpSplitter.DefaultColor = ganttView.SplitterColor;

            rcpStartFinishLine.SelectedColorChanged += new EventHandler(rcpStartFinishLine_SelectedColorChanged);
            rcpStartFinishLine.DefaultColor = ganttView.StartFinishLineColor;

            rcpTodayLine.SelectedColorChanged += new EventHandler(rcpTodayLine_SelectedColorChanged);
            rcpTodayLine.DefaultColor = ganttView.TodayLineColor;

            fontPicker.SelectedIndex = fontPicker.Items.IndexOf(ganttView.Font.FontFamily.Name);
            rcbFontSize.Text = ganttView.Font.Size.ToString();

            rcpBackground.DefaultColor = ganttView.BackColor;
            rcpForeground.DefaultColor = ganttView.ForeColor;

            // Add common font sizes to fontSize combo box.
            foreach (int size in new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 })
            {
                rcbFontSize.Items.Add(new RibbonButton(size.ToString()));
            }

            rbQuit.Click += new EventHandler(rbQuit_Click);

            rcbMaintainHierarchy.Checked = ganttView.GroupDefinition.MaintainHierarchy;
            rcbShowRelatedSummaryRows.Checked = ganttView.FilterDefinition.ShowRelatedSummaryRows;
            InitializeGroupComboBox();
            InitializeFilterComboBox();
            UpdateRibbonItemState();

            // ribbon app menu
            _openFileAppMenu = new OpenFileAppMenu();
            btabOpen.Control = _openFileAppMenu;
            _openFileAppMenu.GanttView = ganttView;
            _openFileAppMenu.RibbonApplicationMenu = ribbonApplicationMenu1;
            btabOpen.Selected = true;

            _saveFileAppMenu = new SaveFileAppMenu();
            btabSave.Control = _saveFileAppMenu;
            _saveFileAppMenu.GanttView = ganttView;
            _saveFileAppMenu.RibbonApplicationMenu = ribbonApplicationMenu1;

            //set column width.
            ganttView.Columns[1].Width = 200;
            C1FlexGrid flexGrid1= ganttView.Controls[2] as C1FlexGrid;
            flexGrid1.Cols[0].Width = 45;


        }

        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);

            // Sets left text at status bar as BUSY while some sub progress is processing.
            rlLeftStatus.Text = "BUSY";
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            // Sets left text at status bar as READY.
            rlLeftStatus.Text = "READY";
        }

        private void InitializeGroupComboBox()
        {
            int groupDefCount = ganttView.GroupDefinition.Items.Count;
            if (groupDefCount == 0)
            {
                rcbGroupBy.SelectedIndex = 0;
            }
            else if (groupDefCount == 1)
            {
                BaseGroup groupModel = ganttView.GroupDefinition.Items[0];
                if (groupModel is TaskModeGroup)
                    rcbGroupBy.SelectedIndex = 1;
                else if (groupModel is TaskCompleteGroup)
                    rcbGroupBy.SelectedIndex = 2;
                else if (groupModel is ConstraintTypeGroup)
                    rcbGroupBy.SelectedIndex = 3;
                else if (groupModel is DurationGroup)
                    rcbGroupBy.SelectedIndex = 4;
                else if (groupModel is MilestonesGroup)
                    rcbGroupBy.SelectedIndex = 5;
                else if (groupModel is ResourceGroup)
                    rcbGroupBy.SelectedIndex = 6;
                else if (groupModel is StatusGroup)
                    rcbGroupBy.SelectedIndex = 7;
                else
                    rcbGroupBy.SelectedIndex = 8;
            }
            else
            {
                rcbGroupBy.SelectedIndex = 8;
            }
        }

        private void InitializeFilterComboBox()
        {
            BaseTaskFilter currentFilter = ganttView.FilterDefinition.CurrentFilter;
            int selectedIndex = -1;
            if (currentFilter == null)
            {
                selectedIndex = 0;
            }
            else
            {
                if (currentFilter is CompletedTasksFilter)
                {
                    selectedIndex = 1;
                }
                else if (currentFilter is DateRangeFilter)
                {
                    selectedIndex = 2;
                }
                else if (currentFilter is IncompleteTasksFilter)
                {
                    selectedIndex = 3;
                }
                else if (currentFilter is LateTasksFilter)
                {
                    selectedIndex = 4;
                }
                else if (currentFilter is MilestoneTasksFilter)
                {
                    selectedIndex = 5;
                }
                else if (currentFilter is SummaryTasksFilter)
                {
                    selectedIndex = 6;
                }
                else if (currentFilter is DurationOnlyTasksFilter)
                {
                    selectedIndex = 7;
                }
                else if (currentFilter is UsingResourceFilter)
                {
                    selectedIndex = 8;
                }
                else
                {
                    selectedIndex = 9;
                }
            }
            rcbFilter.SelectedIndex = selectedIndex;
        }

        private void UpdateRibbonItemState()
        {
            bool enableRibbonItem = ganttView.GroupDefinition.Items.Count == 0;
            rbAddBlankRow.Enabled = enableRibbonItem;
            rbAddTask.Enabled = enableRibbonItem;
            rbAddSummary.Enabled = enableRibbonItem;
            rbMoveTaskDown.Enabled = enableRibbonItem;
            rbMoveTaskUp.Enabled = enableRibbonItem;
            rbIndentTask.Enabled = enableRibbonItem;
            rbOutdentTask.Enabled = enableRibbonItem;
            rbTaskInfo.Enabled = enableRibbonItem;
            InitializeGroupComboBox();
            InitializeFilterComboBox();
        }

        #region Event Handlers
        
        private void ganttView_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update TaskMode status on RibbonToggleButton when selected task changes
            if(ganttView.SelectedTaskIndex != -1)
            {
                // When Task is empty, two buttons are disabled.
                rbAutoSchedule.Enabled = ganttView.SelectedTask.Initialized;
                rbManualSchedule.Enabled = ganttView.SelectedTask.Initialized;

                if(ganttView.SelectedTask.Mode == TaskMode.Automatic)
                    rbAutoSchedule.Pressed = true;
                else
                    rbManualSchedule.Pressed = true;
            }
            else 
            {
                rbAutoSchedule.Enabled = false;
                rbManualSchedule.Enabled = false;
            }

            if (ganttView.SelectedTask == null || !ganttView.SelectedTask.Initialized)
                rbZoomSelectedTask.Enabled = false;
            else
                rbZoomSelectedTask.Enabled = true;
        }

        private void fontPicker_ChangeCommitted(object sender, EventArgs e)
        {
            // We change only font family and keep other exist settings.
            Font font = new Font(fontPicker.Text, ganttView.Font.Size, ganttView.Font.Style);
            ganttView.Font = font;

            // In case the input font that haven't been installed, 
            // we need to reset selected font in combo box to default font.
            fontPicker.SelectedIndex = fontPicker.Items.IndexOf(ganttView.Font.FontFamily.Name);
        }

        private void rcbFontSize_ChangeCommitted(object sender, EventArgs e)
        {
            float fontSize;
            if(float.TryParse(rcbFontSize.Text, out fontSize) && fontSize >= 4 && fontSize <= 127)
            {
                Font font = new Font(ganttView.Font.FontFamily, fontSize, ganttView.Font.Style);
                ganttView.Font = font;
            }
            else
            {
                MessageBox.Show("Font size must be between 4 and 127.");

                // Set font size in combo box to current valid font size.
                rcbFontSize.Text = ganttView.Font.Size.ToString();
            }
        }

        private void rcpBackground_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.BackColor = rcpBackground.Color;
        }

        private void rcpForeground_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.ForeColor = rcpForeground.Color;
        }

        private void rbManualSchedule_Click(object sender, EventArgs e)
        {
            if(ganttView.SelectedTaskIndex != -1)
            {
                ganttView.SelectedTask.Mode = TaskMode.Manual;
            }
        }

        private void rbAutoSchedule_Click(object sender, EventArgs e)
        {
            if(ganttView.SelectedTaskIndex != -1)
            {
                ganttView.SelectedTask.Mode = TaskMode.Automatic;
            }
        }

        private void rbScrollToTask_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.ScrollToTask);
        }

        private void rbMoveTaskUp_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.MoveTaskUp);
        }

        private void rbMoveTaskDown_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.MoveTaskDown);
        }

        private void rbAddTask_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.AddTask);
        }

        private void rbAddBlankRow_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.AddBlankRow);
        }

        private void rbTaskInfo_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.TaskInfo);
        }

        private void rbDeleteTask_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.DeleteTask);
        }

        private void rbResources_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.Resources);
        }

        private void rbProjectInfo_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.ProjectInfo);
        }

        private void rbColumns_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.GridColumns);
        }

        private void rbProgressLine_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.ProgressLines);
        }

        private void rbChangeWorkingTIme_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.WorkingTime);
        }

        private void rbBarStyles_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.BarStyles);
        }

        private void rbTimeScale_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.Timescale);
        }

        private void rcpTodayLine_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.TodayLineColor = rcpTodayLine.Color;
        }

        private void rcpStartFinishLine_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.StartFinishLineColor = rcpStartFinishLine.Color;
        }

        private void rcpSplitter_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.SplitterColor = rcpSplitter.Color;
        }

        private void rcpNonworkingTime_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.NonworkingTimeColor = rcpNonworkingTime.Color;
        }

        private void rcpHighlightForeground_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.HighlightForeColor = rcpHightlightForeground.Color;
        }

        private void rcpHighlightBackground_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.HighlightBackColor = rcpHightlightBackground.Color;
        }

        private void rcpFixedForeground_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.FixedForeColor = rcpFixedForeground.Color;
        }

        private void rcpFixedCellBorder_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.FixedCellBorderColor = rcpFixedCellBorder.Color;
        }

        private void rcpFixedBackground_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.FixedBackColor = rcpFixedBackground.Color;
        }

        private void rcpEmptyAreaBackground_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.EmptyAreaBackColor = rcpEmptyAreaBack.Color;
        }

        private void rcpCellBorder_SelectedColorChanged(object sender, EventArgs e)
        {
            ganttView.CellBorderColor = rcpCellBorder.Color;
        }

        private void rbOpen_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.LoadFromXml);
        }

        private void rbSave_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.SaveAsXml);
        }

        private void rbPrint_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.Print);
        }

        private void rbPrintPreview_Click(object sender, EventArgs e)
        {
            ganttView.Preview();
        }

        private void rbQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimescale_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.Timescale);
        }

        private void rbZoomSelectedTask_Click(object sender, EventArgs e)
        {
            ganttView.ZoomTask(ganttView.SelectedTask);
        }

        private void rbZoomEntireProject_Click(object sender, EventArgs e)
        {
            ganttView.ZoomEntireProject();
        }

        private void rbZoomDialog_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.Zoom);
        }

        private void rbZoomOut_Click(object sender, EventArgs e)
        {
            ganttView.ZoomOut();
        }

        private void rbZoomIn_Click(object sender, EventArgs e)
        {
            ganttView.ZoomIn();
        }

        private void rcbTimeline_SelectedIndexChanged(object sender, EventArgs e)
        {
            ganttView.ChartViewZoomFactor = 11 - (rcbTimeline.SelectedIndex + 1);
        }

        private void rtbZoom_ValueChanged(object sender, EventArgs e)
        {
            if (_zoomfactorIsChanging)
                return;
            ganttView.ChartViewZoomFactor = 12 - (float)rtbZoom.Value;
        }

        private void Timescale_ZoomFactorChanged(object sender, EventArgs e)
        {
            _zoomfactorIsChanging = true;
            rtbZoom.Value = 12 - (int)ganttView.ChartViewZoomFactor;
            _zoomfactorIsChanging = false;
            ScaleTier lowestTier = null;
            if (ganttView.Timescale.BottomTier.Visible)
                lowestTier = ganttView.Timescale.BottomTier;
            else if (ganttView.Timescale.MiddleTier.Visible)
                lowestTier = ganttView.Timescale.MiddleTier;
            else if (ganttView.Timescale.TopTier.Visible)
                lowestTier = ganttView.Timescale.TopTier;

            if (lowestTier == null)
                return;
            rcbTimeline.Text = ((lowestTier.Count > 1) ? lowestTier.Count + " " : "") + lowestTier.Units.ToString();
        }

        private void rbOutdentTask_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.Outdent);
        }

        private void rbIndentTask_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.Indent);
        }

        private void rbAddSummary_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.AddSummaryTask);
        }

        private void rbNoGroup_Click(object sender, EventArgs e)
        {
            ganttView.ClearGroup();
            UpdateRibbonItemState();
        }

        private void rbTaskMode_Click(object sender, EventArgs e)
        {
            ganttView.Group(new TaskModeGroup(true));
            UpdateRibbonItemState();
        }

        private void rbTaskComplete_Click(object sender, EventArgs e)
        {
            ganttView.Group(new TaskCompleteGroup(true));
            UpdateRibbonItemState();
        }

        private void rbStatus_Click(object sender, EventArgs e)
        {
            DateTime statusDate = DateTime.Today;
            if (ganttView.ProgressLine.StatusDate.HasValue)
                statusDate = ganttView.ProgressLine.StatusDate.Value;
            ganttView.Group(new StatusGroup(statusDate, true));
            UpdateRibbonItemState();
        }

        private void rbMilestones_Click(object sender, EventArgs e)
        {
            ganttView.Group(new MilestonesGroup(true));
            UpdateRibbonItemState();
        }

        private void rbDuration_Click(object sender, EventArgs e)
        {
            ganttView.Group(new DurationGroup(true));
            UpdateRibbonItemState();
        }

        private void rbConstraintType_Click(object sender, EventArgs e)
        {
            ganttView.Group(new ConstraintTypeGroup(true));
            UpdateRibbonItemState();
        }

        private void rbResource_Click(object sender, EventArgs e)
        {
            ganttView.Group(new ResourceGroup(true));
            UpdateRibbonItemState();
        }

        private void rbAdvanceGroup_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.Group);
            UpdateRibbonItemState();
        }

        private void rcbMaintainHierarchy_CheckedChanged(object sender, EventArgs e)
        {
            ganttView.GroupDefinition.MaintainHierarchy = rcbMaintainHierarchy.Checked;
            UpdateRibbonItemState();
        }

        private void rbNoFilter_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.NoFilter);
        }

        private void rbCompletedTasksFilter_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.CompletedTasksFilter);
        }

        private void rbDateRangeFilter_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.DateRangeFilter);
        }

        private void rbIncompleteTasksFilter_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.IncompleteTasksFilter);
        }

        private void rbLateTasksFilter_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.LateTasksFilter);
        }

        private void rbMilestonesFilter_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.MilestonesFilter);
        }

        private void rbSummaryTasksFilter_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.SummaryTasksFilter);
        }

        private void rbDurationOnlyTasksFilter_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.TasksWithDurationOnlyFilter);
        }

        private void rbUsingResourceFilter_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.UsingResourceFilter);
        }

        private void rbAdvancedFilter_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.AdvancedFilter);
        }

        private void rbMoreFilters_Click(object sender, EventArgs e)
        {
            ganttView.ClickButton(CommandButton.MoreFilters);
        }

        private void rcbShowRelatedSummaryRows_CheckedChanged(object sender, EventArgs e)
        {
            ganttView.FilterDefinition.ShowRelatedSummaryRows = rcbShowRelatedSummaryRows.Checked;
        }

        private void ribbonApplicationMenu1_DropDown(object sender, EventArgs e)
        {
            // load opened docs
            var openedFiles = Properties.Settings.Default.OpenedFiles;
            openedFiles.ForEach(x => x.SetImage(Properties.Resources.xml));
            _openFileAppMenu.LoadItems(openedFiles);
            // load saved docs
            var saveFiles = Properties.Settings.Default.SavedFiles;
            saveFiles.ForEach(x => x.SetImage(Properties.Resources.folder));
            _saveFileAppMenu.LoadItems(saveFiles);
        }

        private void SoftwareDevelopmentPlan_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }
        #endregion
    }
}
