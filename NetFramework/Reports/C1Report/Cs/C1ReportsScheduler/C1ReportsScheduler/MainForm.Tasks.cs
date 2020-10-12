using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace C1ReportsScheduler
{
    public partial class MainForm
    {
        private void InitTaskGrid()
        {
            this._taskGrid.AutoGenerateColumns = false;
            this._taskGrid.AllowUserToAddRows = false;
            this._taskGrid.MultiSelect = false;
            this._taskGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this._taskGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._taskGrid.RowHeadersWidth = c_gridRowHeadersWidth;
            if (_tasksHolder != null)
                this._taskGrid.DataSource = Tasks;
            this._taskGrid.CellClick += new DataGridViewCellEventHandler(_taskGrid_CellClick);
            this._taskGrid.CurrentCellChanged += new EventHandler(_taskGrid_CurrentCellChanged);
            this._taskGrid.DataError += new DataGridViewDataErrorEventHandler(_taskGrid_DataError);
            this._taskGrid.CellFormatting += new DataGridViewCellFormattingEventHandler(_taskGrid_CellFormatting);
            this._taskGrid.CellParsing += new DataGridViewCellParsingEventHandler(_taskGrid_CellParsing);
            this._taskGrid.CellPainting += new DataGridViewCellPaintingEventHandler(_taskGrid_CellPainting);
            this._taskGrid.RowsAdded += new DataGridViewRowsAddedEventHandler(_taskGrid_RowsAdded);
            this._taskGrid.RowsRemoved += new DataGridViewRowsRemovedEventHandler(_taskGrid_RowsRemoved);
            this._taskGrid.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(_taskGrid_DataBindingComplete);
            this._taskGrid.CurrentCellDirtyStateChanged += new EventHandler(_taskGrid_CurrentCellDirtyStateChanged);

            // file name:
            DataGridViewTextBoxColumn colFileName = new DataGridViewTextBoxColumn();
            colFileName.Name = "File Name";
            colFileName.DataPropertyName = "FileName";
            colFileName.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            colFileName.Width = c_gridFileNameWidth;
            _taskGrid.Columns.Add(colFileName);
            _taskGridInfo.FileNameColIdx = colFileName.Index;

            // file selection ellipsis:
            DataGridViewButtonColumn colFileSelect = new DataGridViewButtonColumn();
            // using column template allows to set tooltip properly:
            DataGridViewButtonCell tpl = new DataGridViewButtonCell();
            tpl.ToolTipText = "Click to select file name";
            tpl.UseColumnTextForButtonValue = true;
            colFileSelect.CellTemplate = tpl;
            colFileSelect.Text = "\x2026"; // ellipsis
            colFileSelect.Width = c_btnWidth;
            colFileSelect.MinimumWidth = c_btnWidth;
            colFileSelect.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colFileSelect.Resizable = DataGridViewTriState.False;
            colFileSelect.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            _taskGrid.Columns.Add(colFileSelect);
            _taskGridInfo.FileSelectColIdx = colFileSelect.Index;

            // report name:
            DataGridViewComboBoxColumn colReportName = new DataGridViewComboBoxColumn();
            colReportName.DataPropertyName = "ReportName";
            colReportName.Name = "Report Name";
            colReportName.ValueType = typeof(string);
            colReportName.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            colReportName.Width = c_gridReportNameWidth;
            _taskGrid.Columns.Add(colReportName);
            _taskGridInfo.ReportNameColIdx = colReportName.Index;

            // task type:
            DataGridViewComboBoxColumn colTaskKind = new DataGridViewComboBoxColumn();
            colTaskKind.DataPropertyName = "ReportKind";
            colTaskKind.Name = "Report Type";
            colTaskKind.DataSource = c_taskKinds;
            colTaskKind.ValueType = typeof(ReportKind);
            colTaskKind.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            _taskGrid.Columns.Add(colTaskKind);
            _taskGridInfo.TaskKindColIdx = colTaskKind.Index;

            // task checked status:
            DataGridViewImageColumn colCheckedStatus = new DataGridViewImageColumn();
            colCheckedStatus.DataPropertyName = "CheckedStatus";
            colCheckedStatus.Width = c_btnWidth;
            colCheckedStatus.MinimumWidth = c_btnWidth;
            colCheckedStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colCheckedStatus.Resizable = DataGridViewTriState.False;
            colCheckedStatus.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            _taskGrid.Columns.Add(colCheckedStatus);
            _taskGridInfo.CheckedStatusColIdx = colCheckedStatus.Index;

            // task state:
            DataGridViewTextBoxColumn colReady = new DataGridViewTextBoxColumn();
            colReady.ReadOnly = true;
            colReady.Name = "Status";
            colReady.DataPropertyName = "State";
            colReady.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            colReady.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            _taskGrid.Columns.Add(colReady);
            _taskGridInfo.ReadyColIdx = colReady.Index;
        }

        void _taskGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // "immediate update" on task kind and report name:
            if (_taskGrid.IsCurrentCellDirty && _taskGrid.CurrentCell != null)
            {
                if (_taskGrid.CurrentCell.ColumnIndex == _taskGridInfo.TaskKindColIdx ||
                    _taskGrid.CurrentCell.ColumnIndex == _taskGridInfo.ReportNameColIdx)
                    _taskGrid.CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange);
            }
        }

        void _taskGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                case ListChangedType.ItemDeleted:
                    if (e.ListChangedType == ListChangedType.ItemAdded && _desiredTaskId == Util.NewestId)
                    {
                        // special treatment for newly added tasks:
                        CurrentTaskIndex = _taskGrid.Rows.Count - 1;
                        _desiredTaskId = Util.NullId;
                    }
                    else if (_desiredTaskId != Util.NullId)
                    {
                        CurrentTaskId = _desiredTaskId;
                        if (CurrentTaskId == _desiredTaskId)
                            _desiredTaskId = Util.NullId;
                    }
                    break;
                default:
                    break;
            }
        }

        void _taskGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                for (int i = 0; i < e.RowCount; ++i)
                {
                    TaskBase task = Tasks[e.RowIndex + i];
                    task.Actions.Invoker = this;
                    UpdateTaskGridReportList(e.RowIndex + i);
                    OnTaskStateChanged(task);
                    task.PropertyChanged += new PropertyChangedEventHandler(TaskPropertyChanged);
                }
            }
            catch (Exception ex)
            {
                WinUtil.ShowError(ex.Message);
            }
        }

        void _taskGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // this ensures that task move up/down buttons are updated for first/last tasks:
            UpdateCurrentTaskUi();
        }

        private delegate void OnTaskStateChangedInvoker(TaskBase task);

        private void TaskPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "State")
            {
                if (InvokeRequired)
                    Invoke(new OnTaskStateChangedInvoker(OnTaskStateChanged), new object[] { (TaskBase)sender });
                else
                    OnTaskStateChanged((TaskBase)sender);
            }
            else if (e.PropertyName == "FileName" || e.PropertyName == "ReportKind")
            {
                System.Diagnostics.Debug.Assert(!InvokeRequired); // expect this only from ui
                int index = ((TaskBase)sender).Index;
                if (index != -1)
                {
                    UpdateTaskGridReportList(index);
                    if (e.PropertyName == "ReportKind" && index == CurrentTaskIndex)
                        UpdateActionGridDropDowns();
                    if (index == CurrentTaskIndex)
                        UpdateCurrentTaskUi();
                }
            }
        }

        /// <summary>
        /// Set task grid row's properties according to task state.
        /// If the passed task is current, also updates actions and schedule panels.
        /// </summary>
        /// <param name="task"></param>
        private void OnTaskStateChanged(TaskBase task)
        {
            if (task == null)
                return;
            try
            {
                int taskIdx = Tasks.IndexOf(task);
                // ignore state change from task if it's not in grid - assume
                // that it was removed while executing:
                // System.Diagnostics.Debug.Assert(taskIdx >= 0);
                if (taskIdx < 0)
                    return;
                bool ro = task.State != TaskState.Ready;
                _taskGrid.Rows[taskIdx].ReadOnly = ro;
                if (task == CurrentTask)
                {
                    _actionGrid.ReadOnly = ro;
                    foreach (ActionBase a in task.Actions)
                        UpdateActionGridCellsReadonlyState(a);
                    SetReadOnlyRecursive(grpSchedule.Controls, ro);
                    // for "one time" schedules, repeat freq/unit must be adjusted:
                    numScheduleRepeatFreq.Enabled = chkScheduleRepeat.Checked;
                    cmbScheduleRepeatUnit.Enabled = chkScheduleRepeat.Checked;
                    SetReadOnlyRecursive(flwScheduleFrequency.Controls, ro);
                    dtpScheduleDate.Enabled = !ro;
                    dtpScheduleTime.Enabled = !ro;
                }
            }
            catch (Exception ex)
            {
                WinUtil.ShowError(ex.Message);
            }
        }

        private void SetReadOnlyRecursive(Control.ControlCollection controls, bool readOnly)
        {
            foreach (Control c in controls)
            {
                c.Enabled = !readOnly;
                SetReadOnlyRecursive(c.Controls, readOnly);
            }
        }

        private void _taskGrid_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.ColumnIndex == _taskGridInfo.TaskKindColIdx)
            {
                string str = (string)e.Value;
                TaskKindName name;
                foreach (ReportKind kind in c_taskKindNames.Keys)
                {
                    if (c_taskKindNames.TryGetValue(kind, out name))
                    {
                        if (name.Name == str)
                        {
                            e.Value = kind;
                            // _taskGrid[e.ColumnIndex, e.RowIndex].ToolTipText = name.ToolTip;
                            e.ParsingApplied = true;
                            break;
                        }
                    }
                }
            }
        }

        void _taskGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == _taskGridInfo.FileNameColIdx)
                WinUtil.PaintFileNameCell(e);
        }

        private void _taskGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            bool readOnly = _taskGrid.Rows[e.RowIndex].ReadOnly;
            e.CellStyle.ForeColor = readOnly ? SystemColors.GrayText : SystemColors.ControlText;

            if (e.ColumnIndex == _taskGridInfo.ReadyColIdx)
            {
                switch (Tasks[e.RowIndex].State)
                {
                    case TaskState.Ready:
                        e.Value = "Ready";
                        break;
                    case TaskState.Busy:
                        e.Value = "Busy";
                        break;
                    case TaskState.Scheduled:
                        e.Value = "Scheduled";
                        break;
                    case TaskState.Paused:
                        e.Value = "Paused";
                        break;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        break;
                }
            }
            else if (e.ColumnIndex == _taskGridInfo.TaskKindColIdx)
            {
                TaskBase task = Tasks[e.RowIndex];
                e.Value = c_taskKindNames[task.ReportKind].Name;
                _taskGrid[e.ColumnIndex, e.RowIndex].ToolTipText = c_taskKindNames[task.ReportKind].ToolTip;
            }
            else if (e.ColumnIndex == _taskGridInfo.CheckedStatusColIdx)
            {
                TaskBase task = Tasks[e.RowIndex];
                switch (task.CheckedStatus)
                {
                    case CheckedStatus.Unknown:
                        e.Value = global::C1ReportsScheduler.Properties.Resources.GrayBall;
                        _taskGrid[e.ColumnIndex, e.RowIndex].ToolTipText = string.Empty;
                        break;
                    case CheckedStatus.Invalid:
                        e.Value = global::C1ReportsScheduler.Properties.Resources.StateError;
                        _taskGrid[e.ColumnIndex, e.RowIndex].ToolTipText = GetTaskErrorMessage(task);
                        break;
                    case CheckedStatus.CheckedOk:
                        e.Value = global::C1ReportsScheduler.Properties.Resources.StateOk;
                        _taskGrid[e.ColumnIndex, e.RowIndex].ToolTipText = string.Empty;
                        break;
                    case CheckedStatus.Working:
                        e.Value = global::C1ReportsScheduler.Properties.Resources.Working;
                        _taskGrid[e.ColumnIndex, e.RowIndex].ToolTipText = string.Empty;
                        break;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        break;
                }
            }
            else if (e.ColumnIndex == _taskGridInfo.ReportNameColIdx)
            {
                TaskBase task = Tasks[e.RowIndex];
                switch (task.ReportKind)
                {
                    case ReportKind.XmlReport:
                    case ReportKind.ImportedReport:
                        _taskGrid[e.ColumnIndex, e.RowIndex].ReadOnly = false;
                        break;
                    case ReportKind.C1dDocument:
                    case ReportKind.Program:
                        _taskGrid[e.ColumnIndex, e.RowIndex].ReadOnly = true;
                        break;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        break;
                }
            }
        }

        void _taskGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void UpdateTaskGridReportList(int rowIdx)
        {
            if (rowIdx < 0)
                return;

            // update list of reports:
            TaskBase task = Tasks[rowIdx];
            DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)_taskGrid[_taskGridInfo.ReportNameColIdx, rowIdx];
            if (cell.DataSource != task.ReportNames)
            {
                cell.DataSource = task.ReportNames;
                if (task.ReportNames != null && task.ReportNames.Length > 0 && !task.ReportNames.Contains<string>(task.ReportName))
                    task.ReportName = task.ReportNames[0];
            }
        }

        private void _taskGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            OnCurrentTaskChanged(false);
        }

        private void OnCurrentTaskChanged(bool forceUpdate)
        {
            TaskBase newCurrentTask = GetCurrentTask();

            if (_currentTask == newCurrentTask && !forceUpdate)
                return;

            if (_currentTask != null)
                _currentTask.Schedule.PropertyChanged -= new PropertyChangedEventHandler(_currSchedule_PropertyChanged);

            _currentTask = newCurrentTask;

            if (_currentTask != null)
                _currentTask.Schedule.PropertyChanged += new PropertyChangedEventHandler(_currSchedule_PropertyChanged);

            this.SuspendLayout();
            try
            {
                if (_currentTask == null)
                {
                    _actionGrid.DataSource = null;
                }
                else
                {
                    System.Diagnostics.Debug.Assert(_currentTask.Actions.Invoker == this);
                    _actionGrid.DataSource = _currentTask.Actions;
                    UpdateActionGridDropDowns();
                    UpdateSchedule(_currentTask);
                }
                UpdateCurrentTaskUi();
                UpdateCurrentActionUi();
                UpdateScheduleUi();
                OnTaskStateChanged(_currentTask);
            }
            finally
            {
                this.ResumeLayout();
            }
        }

        private void UpdateActionGridDropDowns()
        {
            try
            {
                for (int actionIdx = 0; actionIdx < _currentTask.Actions.Count; ++actionIdx)
                {
                    ActionBase action = _currentTask.Actions[actionIdx];
                    UpdateActionGridFormatList(action);
                    UpdateActionGridActionKindList(action);
                }
            }
            catch
            {
            }
        }

        void _taskGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == _taskGridInfo.FileSelectColIdx && !_taskGrid.Rows[e.RowIndex].ReadOnly)
            {
                UiTaskSelectFileName(Tasks[e.RowIndex]);
            }
        }

        private void UpdateCurrentTaskUi()
        {
            try
            {
                TaskBase task = CurrentTask;
                int taskIdx = CurrentTaskIndex;
                int taskCount = _taskGrid.Rows.Count;

                this.tbtnTaskRemove.Enabled = task != null && task.IsReady;
                this.tbtnTaskMoveUp.Enabled = taskIdx > 0;
                this.tbtnTaskMoveDown.Enabled = taskIdx >= 0 && taskIdx < taskCount - 1;
                this.tbtnTaskPreview.Enabled = task != null && task.IsReady && task.ReportKind != ReportKind.Program;

                // update status bar:
                if (task == null)
                {
                    statusTextTask.Text = string.Empty;
                    statusTextTask.Image = null;
                }
                else
                {
                    statusTextTask.Text = GetTaskErrorMessage(task);
                    if (string.IsNullOrEmpty(statusTextTask.Text))
                        statusTextTask.Image = null;
                    else
                        statusTextTask.Image = global::C1ReportsScheduler.Properties.Resources.StateError;
                }
                ShowHidePleaseAddTask();
            }
            catch
            {
            }
        }

        private string GetTaskErrorMessage(TaskBase task)
        {
            if (task == null)
                return string.Empty;
            else if (!string.IsNullOrEmpty(task.Message))
                return task.Message;
            else
            {
                foreach (ActionBase action in task.Actions)
                    if (!string.IsNullOrEmpty(action.Message))
                        return string.Format("One or more actions have errors: {0}", action.Message);
            }
            return string.Empty;
        }

        private void ShowHidePleaseAddTask()
        {
            if (CurrentTask == null)
            {
                if (_lblPleaseAddTask == null)
                {
                    _lblPleaseAddTask = new Label();
                    _lblPleaseAddTask.Text =
                        "This panel will show actions and schedule associated with the current task\r\n" +
                        "if there is at least one task in the task list.";
                    _lblPleaseAddTask.AutoSize = false;
                    _lblPleaseAddTask.Dock = DockStyle.Fill;
                    _lblPleaseAddTask.TextAlign = ContentAlignment.MiddleCenter;
                    splitContainer1.Panel2.Controls.Add(_lblPleaseAddTask);
                    _lblPleaseAddTask.BringToFront();
                }
            }
            else
            {
                if (_lblPleaseAddTask != null)
                {
                    _lblPleaseAddTask.Dispose();
                    _lblPleaseAddTask = null;
                }
            }
        }

        private void UpdateCurrentActionUi()
        {
            try
            {
                ActionBase action = CurrentAction;
                int actionIdx = CurrentActionIndex;
                int actionCount = _actionGrid.Rows.Count;
                bool taskIsReady = CurrentTaskIsReady;
                this.tbtnActionAdd.Enabled = taskIsReady;
                this.tbtnActionRemove.Enabled = action != null && taskIsReady;
                this.tbtnActionMoveUp.Enabled = taskIsReady && actionIdx > 0;
                this.tbtnActionMoveDown.Enabled = taskIsReady && actionIdx >= 0 && actionIdx < actionCount - 1;
            }
            catch
            {
            }
        }

        private bool UiTaskSelectFileName(TaskBase task)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter =
                        "Report definition files (*.xml)|*.xml|C1DX documents(*.c1dx)|*.c1dx|C1D documents (*.c1d)|*.c1d|Executable files (*.exe)|*.exe|All files (*.*)|*.*";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        task.FileName = ofd.FileName;
                        switch (Path.GetExtension(ofd.FileName).ToLowerInvariant())
                        {
                            case ".xml":
                                if (task.ReportKind == ReportKind.C1dDocument)
                                    task.ReportKind = ReportKind.XmlReport;
                                break;
                            case ".c1d":
                            case ".c1dx":
                                if (task.ReportKind != ReportKind.C1dDocument)
                                    task.ReportKind = ReportKind.C1dDocument;
                                break;
                            case ".exe":
                                if (task.ReportKind != ReportKind.Program)
                                    task.ReportKind = ReportKind.Program;
                                break;
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
            catch (Exception ex)
            {
                WinUtil.ShowError(ex.Message);
                return false;
            }
        }
    }
}
