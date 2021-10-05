//----------------------------------------------------------------------------
// ErrorList.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Doc = C1.Win.Document;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.Controls
{
    /// <summary>
    /// Represents the list of warnings and errors produced when a report was generated.
    /// </summary>
    public partial class ErrorList : UserControl
    {
        private ITooltipService _tooltipService = null;
        private ListViewItem.ListViewSubItem _tooltipSubItem = null;
        private static Dictionary<Doc.LogEntrySeverity, string> s_severityTooltips = new Dictionary<Doc.LogEntrySeverity, string>()
        {
            { Doc.LogEntrySeverity.Info, Strings.ErrorList.Tooltip_Info },
            { Doc.LogEntrySeverity.Warning, Strings.ErrorList.Tooltip_Warning },
            { Doc.LogEntrySeverity.Error, Strings.ErrorList.Tooltip_Error },
            { Doc.LogEntrySeverity.Critical, Strings.ErrorList.Tooltip_Critical },
            { Doc.LogEntrySeverity.Cancelled, Strings.ErrorList.Tooltip_Cancelled },
        };

        public ErrorList()
        {
            InitializeComponent();

            _list.MouseMove += _list_MouseMove;
            _list.SelectedIndexChanged += _list_SelectedIndexChanged;
        }

        public event EventHandler SelectionChanged;

        private void OnSelectionChanged()
        {
            if (SelectionChanged != null)
                SelectionChanged(this, EventArgs.Empty);
        }

        private void _list_MouseMove(object sender, MouseEventArgs e)
        {
            if (_tooltipService == null)
                return;

            var hti = _list.HitTest(e.X, e.Y);
            var subItem = hti.SubItem;
            if (subItem != _tooltipSubItem)
            {
                _tooltipSubItem = subItem;
                if (_tooltipSubItem == null)
                    _tooltipService.ClearToolTip(_list);
                else
                    _tooltipService.SetToolTip(_list, _tooltipSubItem.Tag as string);
            }
        }

        private void _list_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnSelectionChanged();
        }

        public void SetServices(FlexDesignerHostServices services)
        {
            _tooltipService = services.GetTooltipService();
        }

        public bool IsEmpty
        {
            get { return _list.Items.Count == 0; }
        }

        public void Clear()
        {
            _list.Items.Clear();
            if (_tooltipService != null)
                _tooltipService.ClearToolTip(_list);
            OnSelectionChanged();
        }

        public bool CanCopy
        {
            get { return _list.SelectedItems.Count > 0; }
        }

        public void Copy()
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < _list.SelectedItems.Count; ++i)
                {
                    ListViewItem item = _list.SelectedItems[i];
                    sb.Append(item.Tag as string);
                    sb.AppendLine();
                    sb.AppendFormat("({0})", item.SubItems[2].Text);
                    if (i < _list.SelectedItems.Count - 1)
                        sb.AppendLine();
                }
                var s = sb.ToString();
                if (!string.IsNullOrEmpty(s))
                    Clipboard.SetText(s);
            }
            catch (Exception ex)
            {
                MessageForm.Error(string.Format(Strings.MainForm.ClipboardErrorFmt, ex.Message));
            }
        }

        private string MessageTooltip(Doc.LogEntry entry)
        {
            string tooltip;
            if (entry.Exception == null)
                tooltip = entry.Message;
            else
                tooltip = string.Format(Strings.ErrorList.ExceptionTooltipFmt, entry.Exception);
            return tooltip;
        }

        private string CountTooltip(string severity, int count)
        {
            if (count < 2)
                return Strings.ErrorList.CountOneTooltip;
            return string.Format(Strings.ErrorList.CountManyTooltipFmt, severity.ToLowerInvariant(), count);
        }

        public void AddLogEntry(Doc.LogEntry entry)
        {
            var severity = entry.Severity.ToString();
            var lastItem = _list.Items.Count > 0 ? _list.Items[_list.Items.Count - 1] : null;
            if (lastItem != null && lastItem.SubItems.Count == 3)
            {
                if (lastItem.SubItems[0].Text == severity && lastItem.SubItems[1].Text == entry.Message)
                {
                    int count;
                    if (!int.TryParse(lastItem.SubItems[2].Text, out count))
                        count = 0;
                    ++count;
                    lastItem.SubItems[2].Text = count.ToString();
                    lastItem.SubItems[2].Tag = CountTooltip(severity, count);
                    return;
                }
            }
            var lvi = new ListViewItem(severity);
            lvi.ImageKey = severity;
            lvi.SubItems[0].Tag = s_severityTooltips[entry.Severity];
            lvi.SubItems.Add(entry.Message);
            lvi.SubItems[1].Tag = MessageTooltip(entry);
            lvi.SubItems.Add("1");
            lvi.SubItems[2].Tag = CountTooltip(severity, 1);
            // item's own tag contains the info to copy to clipboard if requested (same but not html formatted):
            StringBuilder sb = new StringBuilder();
            sb.Append(severity);
            sb.Append(':');
            sb.AppendLine();
            if (entry.Exception == null)
                sb.Append(entry.Message);
            else
                sb.Append(entry.Exception.ToString());
            lvi.Tag = sb.ToString();
            _list.Items.Add(lvi);
            OnSelectionChanged();
        }

        public string Settings
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < _list.Columns.Count - 1; ++i)
                    sb.AppendFormat("{0}, ", _list.Columns[i].Width);
                if (_list.Columns.Count > 0)
                    sb.AppendFormat("{0}", _list.Columns[_list.Columns.Count - 1].Width);
                return sb.ToString();
            }
            set
            {
                _list.SuspendLayout();
                try
                {
                    var ws = value.Split(',');
                    for (int i = 0; i < ws.Length; ++i)
                    {
                        int w = int.Parse(ws[i].Trim());
                        w = Math.Max(16, Math.Min(1024, w)); // sanity
                        _list.Columns[i].Width = w;
                    }
                }
                catch
                {
                    // eat errors
                }
                finally
                {
                    _list.ResumeLayout(true);
                }
            }
        }

        public void ResetSettings()
        {
            int[] widths = { 64, 256, 64 };
            _list.SuspendLayout();
            for (int i = 0; i < 3 && i < _list.Columns.Count; ++i)
                _list.Columns[i].Width = widths[i];
            _list.ResumeLayout(true);
        }
    }
}
