using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C1ReportsScheduler
{
    public partial class MainForm
    {
        private void InitActionGrid()
        {
            this._actionGrid.AutoGenerateColumns = false;
            this._actionGrid.AllowUserToAddRows = false;
            this._actionGrid.MultiSelect = false;
            this._actionGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this._actionGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this._actionGrid.RowHeadersWidth = c_gridRowHeadersWidth;

            this._actionGrid.DataError += new DataGridViewDataErrorEventHandler(_actionGrid_DataError);
            this._actionGrid.CellClick += new DataGridViewCellEventHandler(_actionGrid_CellClick);
            this._actionGrid.CurrentCellChanged += new EventHandler(_actionGrid_CurrentCellChanged);
            this._actionGrid.CellFormatting += new DataGridViewCellFormattingEventHandler(_actionGrid_CellFormatting);
            this._actionGrid.CellPainting += new DataGridViewCellPaintingEventHandler(_actionGrid_CellPainting);
            this._actionGrid.RowsAdded += new DataGridViewRowsAddedEventHandler(_actionGrid_RowsAdded);
            this._actionGrid.RowsRemoved += new DataGridViewRowsRemovedEventHandler(_actionGrid_RowsRemoved);
            this._actionGrid.DataBindingComplete += new DataGridViewBindingCompleteEventHandler(_actionGrid_DataBindingComplete);
            this._actionGrid.CurrentCellDirtyStateChanged += new EventHandler(_actionGrid_CurrentCellDirtyStateChanged);

            // action action:
            DataGridViewComboBoxColumn colKind = new DataGridViewComboBoxColumn();
            colKind.DataPropertyName = "Kind";
            colKind.Name = "Action";
            colKind.DataSource = Enum.GetValues(typeof(ActionKind));
            colKind.ValueType = typeof(ActionKind);
            colKind.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            _actionGrid.Columns.Add(colKind);
            _actionGridInfo.KindColIdx = colKind.Index;

            // format name:
            DataGridViewComboBoxColumn colFormatName = new DataGridViewComboBoxColumn();
            colFormatName.DataPropertyName = "ExportFormatName";
            colFormatName.Name = "Export Format";
            colFormatName.ValueType = typeof(string);
            colFormatName.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            _actionGrid.Columns.Add(colFormatName);
            _actionGridInfo.FormatColIdx = colFormatName.Index;

            // file/printer name:
            DataGridViewTextBoxColumn colFileName = new DataGridViewTextBoxColumn();
            colFileName.Name = "Output File/Printer Name";
            colFileName.DataPropertyName = "OutputFileName";
            colFileName.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            colFileName.Width = c_gridFileNameWidth;
            _actionGrid.Columns.Add(colFileName);
            _actionGridInfo.OutputNameColIdx = colFileName.Index;

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
            _actionGrid.Columns.Add(colFileSelect);
            _actionGridInfo.OutputNameSelectColIdx = colFileSelect.Index;

            // action checked status:
            DataGridViewImageColumn colCheckedStatus = new DataGridViewImageColumn();
            colCheckedStatus.DataPropertyName = "CheckedStatus";
            colCheckedStatus.Width = c_btnWidth;
            colCheckedStatus.MinimumWidth = c_btnWidth;
            colCheckedStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colCheckedStatus.Resizable = DataGridViewTriState.False;
            colCheckedStatus.HeaderCell.Style.WrapMode = DataGridViewTriState.False;
            _actionGrid.Columns.Add(colCheckedStatus);
            _actionGridInfo.CheckedStatusColIdx = colCheckedStatus.Index;
        }

        void _actionGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            // "immediate update" on action kind:
            if (_actionGrid.IsCurrentCellDirty && _actionGrid.CurrentCell != null)
            {
                if (_actionGrid.CurrentCell.ColumnIndex == _actionGridInfo.KindColIdx ||
                    _actionGrid.CurrentCell.ColumnIndex == _actionGridInfo.FormatColIdx)
                    _actionGrid.CommitEdit(DataGridViewDataErrorContexts.CurrentCellChange);
            }
        }

        void _actionGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                case ListChangedType.ItemDeleted:
                    if (e.ListChangedType == ListChangedType.ItemAdded && _desiredActionId == Util.NewestId)
                    {
                        // special treatment for newly added actions:
                        CurrentActionIndex = _actionGrid.Rows.Count - 1;
                        _desiredActionId = Util.NullId;
                    }
                    else if (_desiredActionId != Util.NullId)
                    {
                        CurrentActionId = _desiredActionId;
                        if (CurrentActionId == _desiredActionId)
                            _desiredActionId = Util.NullId;
                    }
                    break;
                default:
                    break;
            }
        }

        void _actionGrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            TaskBase task = CurrentTask;
            System.Diagnostics.Debug.Assert(task != null);
            if (task == null)
                return;
            for (int i = 0; i < e.RowCount; ++i)
            {
                ActionBase action = task.Actions[e.RowIndex + i];
                UpdateActionGridFormatList(action);
                UpdateActionGridActionKindList(action);
                action.PropertyChanged += new PropertyChangedEventHandler(ActionPropertyChanged);
            }
        }

        void _actionGrid_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            // this ensures that task move up/down buttons are updated for first/last actions:
            UpdateCurrentActionUi();
        }

        void ActionPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Kind" || e.PropertyName == "ExportFormatNames")
                UpdateActionGridFormatList(sender as ActionBase);
            else if (e.PropertyName == "ActionKinds")
                UpdateActionGridActionKindList(sender as ActionBase);
        }

        void _actionGrid_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == _actionGridInfo.OutputNameColIdx)
                WinUtil.PaintFileNameCell(e);
        }

        void _actionGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            try
            {
                TaskBase task = CurrentTask;
                if (task == null)
                    return;

                bool readOnly = task.State != TaskState.Ready;
                _actionGrid.ReadOnly = readOnly;
                e.CellStyle.ForeColor = readOnly ? SystemColors.GrayText : SystemColors.ControlText;

                if (e.ColumnIndex == _actionGridInfo.CheckedStatusColIdx)
                {
                    CheckedStatus cs;
                    string message;
                    if (e.RowIndex >= task.Actions.Count)
                        return;
                    cs = task.Actions[e.RowIndex].CheckedStatus;
                    message = task.Actions[e.RowIndex].Message;
                    switch (cs)
                    {
                        case CheckedStatus.Unknown:
                            e.Value = global::C1ReportsScheduler.Properties.Resources.GrayBall;
                            _actionGrid[e.ColumnIndex, e.RowIndex].ToolTipText = string.Empty;
                            break;
                        case CheckedStatus.Invalid:
                            e.Value = global::C1ReportsScheduler.Properties.Resources.StateError;
                            _actionGrid[e.ColumnIndex, e.RowIndex].ToolTipText = message;
                            break;
                        case CheckedStatus.CheckedOk:
                            e.Value = global::C1ReportsScheduler.Properties.Resources.StateOk;
                            _actionGrid[e.ColumnIndex, e.RowIndex].ToolTipText = string.Empty;
                            break;
                        case CheckedStatus.Working:
                            e.Value = global::C1ReportsScheduler.Properties.Resources.Working;
                            _actionGrid[e.ColumnIndex, e.RowIndex].ToolTipText = string.Empty;
                            break;
                        default:
                            System.Diagnostics.Debug.Assert(false);
                            break;
                    }
                }
                else if (e.ColumnIndex == _actionGridInfo.OutputNameColIdx)
                {
                    if (readOnly || task.ReportKind == ReportKind.Program)
                        e.CellStyle.ForeColor = SystemColors.GrayText;
                }
            }
            catch
            {
            }
        }

        void _actionGrid_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Ignore data errors
        }

        void _actionGrid_CurrentCellChanged(object sender, EventArgs e)
        {
            UpdateCurrentActionUi();
        }

        void _actionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return; // caption was clicked

            if (e.ColumnIndex == _actionGridInfo.OutputNameSelectColIdx)
            {
                TaskBase task = CurrentTask;
                if (task != null)
                {
                    ActionBase action = task.Actions[e.RowIndex];
                    if (UiActionSelectFileName(action))
                    {
                        UpdateActionGridFormatList(action);
                        UpdateActionGridActionKindList(action);
                    }
                }
            }
            // ...
        }

        private void UpdateActionGridFormatList(ActionBase action)
        {
            if (action == null)
                return;
            try
            {
                var actionRowIdx = action.Index;
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)_actionGrid[_actionGridInfo.FormatColIdx, actionRowIdx];
                cell.DataSource = action.ExportFormatNames;
                if (action.Kind == ActionKind.Export)
                    _actionGrid[_actionGridInfo.FormatColIdx, actionRowIdx].ReadOnly = false;
                else // print, external program
                    _actionGrid[_actionGridInfo.FormatColIdx, actionRowIdx].ReadOnly = true;
            }
            catch
            {
            }
        }

        private void UpdateActionGridActionKindList(ActionBase action)
        {
            if (action == null)
                return;
            try
            {
                var actionRowIdx = action.Index;
                DataGridViewComboBoxCell cell = (DataGridViewComboBoxCell)_actionGrid[_actionGridInfo.KindColIdx, actionRowIdx];
                cell.DataSource = action.ActionKinds;
                UpdateActionGridCellsReadonlyState(action);
            }
            catch
            {
            }
        }

        private void UpdateActionGridCellsReadonlyState(ActionBase action)
        {
            if (action == null)
                return;
            var actionRowIdx = action.Index;
            switch (action.Kind)
            {
                case ActionKind.Export:
                    _actionGrid[_actionGridInfo.FormatColIdx, actionRowIdx].ReadOnly = false;
                    _actionGrid[_actionGridInfo.OutputNameColIdx, actionRowIdx].ReadOnly = false;
                    _actionGrid[_actionGridInfo.OutputNameSelectColIdx, actionRowIdx].ReadOnly = false;
                    break;
                case ActionKind.Print:
                    _actionGrid[_actionGridInfo.FormatColIdx, actionRowIdx].ReadOnly = true;
                    _actionGrid[_actionGridInfo.OutputNameColIdx, actionRowIdx].ReadOnly = false;
                    _actionGrid[_actionGridInfo.OutputNameSelectColIdx, actionRowIdx].ReadOnly = false;
                    break;
                case ActionKind.Run:
                    _actionGrid[_actionGridInfo.FormatColIdx, actionRowIdx].ReadOnly = true;
                    _actionGrid[_actionGridInfo.OutputNameColIdx, actionRowIdx].ReadOnly = true;
                    _actionGrid[_actionGridInfo.OutputNameSelectColIdx, actionRowIdx].ReadOnly = true;
                    break;
                default:
                    System.Diagnostics.Debug.Assert(false);
                    break;
            }
        }

        private bool UiActionSelectFileName(ActionBase action)
        {
            try
            {
                switch (action.Kind)
                {
                    case ActionKind.Export:
                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.Filter = "All files (*.*)|*.*";
                        if (!string.IsNullOrEmpty(action.ExportFormatKey))
                        {
                            sfd.Filter = string.Format("{0} (*.{1})|*.{1}|", action.ExportFormatName, action.ExportDefaultExtension) + sfd.Filter;
                        }
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            action.OutputFileName = sfd.FileName;
                            return true;
                        }
                        break;
                    case ActionKind.Print:
                        PrintDialog pdlg = new PrintDialog();
                        if (pdlg.ShowDialog() == DialogResult.OK)
                        {
                            // todo: save all print settings
                            action.OutputFileName = pdlg.PrinterSettings.PrinterName;
                            return true;
                        }
                        break;
                    case ActionKind.Run:
                        break;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        break;
                }
                return false;
            }
            catch (Exception ex)
            {
                WinUtil.ShowError(ex.Message);
                return false;
            }
        }
    }
}
