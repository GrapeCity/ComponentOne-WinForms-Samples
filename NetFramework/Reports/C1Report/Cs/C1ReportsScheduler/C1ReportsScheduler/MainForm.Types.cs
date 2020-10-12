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
        private class TaskGridInfo
        {
            public int FileNameColIdx = -1;
            public int FileSelectColIdx = -1;
            public int ReportNameColIdx = -1;
            public int TaskKindColIdx = -1;
            public int BtnPreviewColIdx = -1;
            public int CheckedStatusColIdx = -1;
            public int ReadyColIdx = -1;
        }

        private class ActionGridInfo
        {
            public int KindColIdx = -1;
            public int FormatColIdx = -1;
            public int OutputNameColIdx = -1;
            public int OutputNameSelectColIdx = -1;
            public int StateColIdx = -1;
            public int CheckedStatusColIdx = -1;
        }

        private struct TaskKindName
        {
            public string Name;
            public string ToolTip;
            public TaskKindName(string name, string toolTip)
            {
                Name = name;
                ToolTip = toolTip;
            }
        }

        public UiSettings UiSettings
        {
            get
            {
                UiSettings value = new UiSettings();
                value.Location = Location;
                value.Size = Size;
                value.TaskPanelHeight = splitContainer1.SplitterDistance;
                foreach (DataGridViewColumn col in _taskGrid.Columns)
                    value.TaskColsWidths.Add(col.Width);
                foreach (DataGridViewColumn col in _actionGrid.Columns)
                    value.ActionColsWidths.Add(col.Width);
                if (_helpForm != null)
                    value.HelpFormBounds = _helpForm.Bounds;
                else if (Properties.Settings.Default.UiSettings != null)
                    value.HelpFormBounds = Properties.Settings.Default.UiSettings.HelpFormBounds;
                if (_logForm != null)
                    value.LogFormBounds = _logForm.Bounds;
                else if (Properties.Settings.Default.UiSettings != null)
                    value.LogFormBounds = Properties.Settings.Default.UiSettings.LogFormBounds;
                value.ShowLogForm = LogFormVisible;

                return value;
            }
            set
            {
                if (value.Location != Point.Empty)
                {
                    this.StartPosition = FormStartPosition.Manual;
                    this.Location = value.Location;
                }
                if (value.Size != Size.Empty)
                    this.Size = value.Size;
                if (value.TaskPanelHeight > 0)
                    this.splitContainer1.SplitterDistance = value.TaskPanelHeight;
                int i = 0;
                foreach (int w in value.TaskColsWidths)
                    if (_taskGrid.Columns.Count > i)
                        _taskGrid.Columns[i++].Width = w;
                i = 0;
                foreach (int w in value.ActionColsWidths)
                    if (_actionGrid.Columns.Count > i)
                        _actionGrid.Columns[i++].Width = w;

                if (value.ShowLogForm)
                    ShowLogForm();
            }
        }
    }
}
