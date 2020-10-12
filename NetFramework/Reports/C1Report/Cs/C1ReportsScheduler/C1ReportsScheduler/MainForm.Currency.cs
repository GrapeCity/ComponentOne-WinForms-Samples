using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace C1ReportsScheduler
{
    public partial class MainForm
    {

        // this is the main current task property; others (CurrentTaskId, CurrentTask) should use this
        private int CurrentTaskIndex
        {
            get
            {
                try
                {
                    if (_taskGrid.CurrentRow == null)
                        return -1;
                    return _taskGrid.CurrentRow.Index;
                }
                catch
                {
                    return -1;
                }
            }
            set
            {
                try
                {
                    int colIdx = _taskGrid.CurrentCell == null ? 0 : _taskGrid.CurrentCell.ColumnIndex;
                    if (value >= 0 && value < _taskGrid.Rows.Count)
                        _taskGrid.CurrentCell = _taskGrid[colIdx, value];
                }
                catch
                {
                }
            }
        }

        private TaskBase CurrentTask
        {
            get
            {
                return _currentTask;
            }
        }

        /// <summary>
        /// Does NOT use the cached _currentTask. Should only be used in special cases.
        /// </summary>
        /// <returns></returns>
        private TaskBase GetCurrentTask()
        {
            try
            {
                int idx = CurrentTaskIndex;
                if (idx == -1)
                    return null;
                return Tasks[idx];
            }
            catch
            {
                return null;
            }
        }

        private long CurrentTaskId
        {
            get
            {
                TaskBase task = CurrentTask;
                if (task != null)
                    return task.Id;
                return Util.NullId;
            }
            set
            {
                if (value != Util.NullId)
                {
                    try
                    {
                        for (int i = 0; i < _taskGrid.Rows.Count; ++i)
                            if (_tasksHolder.Tasks[i].Id == value)
                            {
                                CurrentTaskIndex = i;
                                break;
                            }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private bool CurrentTaskIsReady
        {
            get
            {
                TaskBase task = CurrentTask;
                return task != null && task.State == TaskState.Ready;
            }
        }

        private int CurrentActionIndex
        {
            get
            {
                try
                {
                    if (_actionGrid.CurrentRow == null)
                        return -1;
                    return _actionGrid.CurrentRow.Index;
                }
                catch
                {
                    return -1;
                }
            }
            set
            {
                try
                {
                    int colIdx = _actionGrid.CurrentCell == null ? 0 : _actionGrid.CurrentCell.ColumnIndex;
                    if (value >= 0 && value < _actionGrid.Rows.Count)
                        _actionGrid.CurrentCell = _actionGrid[colIdx, value];
                }
                catch
                {
                }
            }
        }

        private ActionBase CurrentAction
        {
            get
            {
                try
                {
                    TaskBase task = CurrentTask;
                    if (task == null)
                        return null;
                    int actionIndex = CurrentActionIndex;
                    if (actionIndex == -1)
                        return null;
                    return task.Actions[actionIndex];
                }
                catch
                {
                    return null;
                }
            }
        }

        private long CurrentActionId
        {
            get
            {
                ActionBase action = CurrentAction;
                if (action == null)
                    return Util.NullId;
                return action.Id;
            }
            set
            {
                if (value != Util.NullId)
                {
                    try
                    {
                        TaskBase task = CurrentTask;
                        if (task == null)
                            return;
                        for (int i = 0; i < _actionGrid.Rows.Count; ++i)
                            if (task.Actions[i].Id == value)
                            {
                                CurrentActionIndex = i;
                                break;
                            }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private ActionList CurrentActions
        {
            get
            {
                TaskBase task = CurrentTask;
                if (task == null)
                    return null;
                return task.Actions;
            }
        }
    }
}
