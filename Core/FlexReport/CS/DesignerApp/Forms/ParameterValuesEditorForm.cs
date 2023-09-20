//----------------------------------------------------------------------------
// ParameterValuesEditorForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.FlexGrid;
using C1.Win.Input;
using C1.Win.Themes;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using FlexReportDesignerApp.Controls;
using FlexReportDesignerApp.Util;

namespace FlexReportDesignerApp.Forms
{
    public partial class ParameterValuesEditorForm : Form
    {
        private class NameEditor : C1ComboBox
        {
            private FlexDesignerHostServices _services;
            private C1FlexReport _subreport;
            private bool _emptyNames;
            private object _preValue;
            private readonly C1FlexGrid _grid;

            public NameEditor(C1FlexGrid grid)
            {
                _grid = grid;
            }

            //public override void C1EditorInitialize(object value, IDictionary attrs)
            //{
            //    base.C1EditorInitialize(value, attrs);
            //    AcceptsEscape = false;
            //    UpdateSelectedIndex();
            //}

            public void Init(FlexDesignerHostServices services, C1FlexReport subreport)
            {
                _services = services;
                _subreport = subreport;
                _emptyNames = false;

                PopulateItems();
                if (Items.Count == 0)
                {
                    Items.Add("(no parameters in supreport)");
                    _emptyNames = true;
                }
            }

            protected override void OnDropDownOpened(EventArgs e)
            {
                base.OnDropDownOpened(e);
                if(_emptyNames)
                    _preValue = Value;
            }

            protected override void OnDropDownClosed(EventArgs e)
            {
                base.OnDropDownClosed(e);
                if(_emptyNames)
                    Value = _preValue;
            }

            private void PopulateItems()
            {
                if (_subreport == null || _services == null) return;
                var grs = _services.GetGetReportService();
                if (grs == null) return;

                foreach (var rpt in grs.GetReportList())
                {
                    if (
                        string.Compare(rpt.ReportName, _subreport.ReportName, true,
                            System.Globalization.CultureInfo.CurrentCulture) == 0)
                    {
                        foreach (var parameter in rpt.Parameters)
                        {
                            Items.Add(parameter.Name);
                        }
                    }
                }
            }

            private void UpdateSelectedIndex()
            {
                if (SelectedIndex != -1) return;
                var value = Value as string;
                if (value == null) return;

                var index = -1;
                foreach (var item in Items)
                {
                    index++;
                    if (value.Equals(item.Value as string))
                    {
                        SelectedIndex = index;
                        break;
                    }
                }
            }

            protected override bool IsInputKey(Keys keyData)
            {
                return keyData == Keys.Escape || base.IsInputKey(keyData);
            }

            protected override void OnKeyDown(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    e.Handled = true;
                    _grid.FinishEditing(true);
                }
                else if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
                {
                    e.Handled = true;
                }
                else
                {
                    base.OnKeyDown(e);
                }
            }
        }

        private class ValueEditor : ScriptValueEditorControl
        {
            private readonly C1FlexGrid _grid;
            public ValueEditor(C1FlexGrid grid)
            {
                _grid = grid;
            }

            //public override void C1EditorInitialize(object value, IDictionary attrs)
            //{
            //    base.C1EditorInitialize(value, attrs);
            //    AcceptsEscape = false;
            //}

            protected override bool IsInputKey(Keys keyData)
            {
                return keyData == Keys.Escape || base.IsInputKey(keyData);
            }

            protected override void OnKeyDown(KeyEventArgs e)
            {
                if (e.KeyCode == Keys.Escape)
                {
                    e.Handled = true;
                    _grid.FinishEditing(true);
                }
                base.OnKeyDown(e);
            }
        }

        private IServiceProvider _provider;
        private C1FlexReport _report;
        private ValueEditor _valueEditor;
        private NameEditor _nameEditor;
        private string _scriptNamePrefix = "";
        private bool _updating;
        private bool _editing;

        public ParameterValuesEditorForm()
        {
            InitializeComponent();


            c1FlexGrid1.StartEdit += c1FlexGrid1_StartEdit;
            c1FlexGrid1.AfterEdit += c1FlexGrid1_AfterEdit;
            c1FlexGrid1.LeaveEdit += c1FlexGrid1_LeaveEdit;
            c1FlexGrid1.AfterSelChange += c1FlexGrid1_AfterSelChange;
            c1FlexGrid1.KeyPressEdit += c1FlexGrid1_KeyPressEdit;
            C1ThemeController.ApplyThemeToControlTree(this, MainForm.TheMainForm.CachedTheme);
        }

        private void GetReportParameterValuesEnviroment(ReportParameterValues rpvs, out string scriptNamePrefix, out C1FlexReport anotherReport)
        {
            if (rpvs.Owner is SubreportField)
            {
                scriptNamePrefix = ((SubreportField)rpvs.Owner).Name + "";
                anotherReport = ((SubreportField)rpvs.Owner).Subreport;
            }
            else if (rpvs.Owner is ReportLinkTargetBookmark)
            {
                scriptNamePrefix = "Hyperlink";
                anotherReport = ((ReportLinkTargetBookmark)rpvs.Owner).Report;
            }
            else
            {
                System.Diagnostics.Debug.Assert(false);
                scriptNamePrefix = "Script";
                anotherReport = null;
            }
            scriptNamePrefix += ".ParameterValues";
        }

        void c1FlexGrid1_KeyPressEdit(object sender, C1.Win.FlexGrid.KeyPressEditEventArgs e)
        {
            Debug.WriteLine(e.KeyChar);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            btnUp.Text = ((char)0xe9).ToString();
            btnDown.Text = ((char)0xea).ToString();
            AppSettings.LoadObject("ParameterValuesEditorForm", new FormState(this));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            AppSettings.SaveObject("ParameterValuesEditorForm", new FormState(this));
        }

        public void Init(FlexDesignerHostServices provider, ReportParameterValues parameterValues)
        {
            Debug.Assert(parameterValues != null);

            _provider = provider;
            C1FlexReport anotherReport;
            GetReportParameterValuesEnviroment(parameterValues, out _scriptNamePrefix, out anotherReport);
            _report = parameterValues.Report;

            _updating = true;

            _valueEditor = new ValueEditor(c1FlexGrid1);
            _valueEditor.Init(provider, _report.DataSourceName, "");
            C1ThemeController.ApplyThemeToControlTree(_valueEditor, MainForm.TheMainForm.CachedTheme);
            _nameEditor = new NameEditor(c1FlexGrid1);
            _nameEditor.Init(provider, anotherReport);
            C1ThemeController.ApplyThemeToControlTree(_nameEditor, MainForm.TheMainForm.CachedTheme);

            var labelIndex = c1FlexGrid1.Cols.Fixed;
            var valueIndex = labelIndex + 1;
            foreach (var item in parameterValues)
            {
                var row = c1FlexGrid1.Rows.Add();
                row[labelIndex] = ScriptValueHelper.ToString(item.Name);
                row[valueIndex] = ScriptValueHelper.ToString(item.Value);
            }

            c1FlexGrid1.Col = labelIndex;
            if (parameterValues.Count > 0)
            {
                c1FlexGrid1.Row = c1FlexGrid1.Rows.Fixed;
            }

            UpdateButtonsSatus();

            _updating = false;
        }

        public void ApplyChanges(ReportParameterValues parameterValues)
        {
            var labelIndex = c1FlexGrid1.Cols.Fixed;
            var valueIndex = labelIndex + 1;

            parameterValues.Clear();
            for (int i = 1; i < c1FlexGrid1.Rows.Count; i++)
            {
                var row = c1FlexGrid1.Rows[i];
                if (row.IsNew) continue;

                var item = new ReportParameterValue();
                if (row[labelIndex] != null) item.Name = row[labelIndex].ToString();
                if (row[valueIndex] != null) item.Value = (ScriptObjectValue) row[valueIndex].ToString();
                parameterValues.Add(item);
            }
        }

        private void UpdateButtonsSatus()
        {
            btnAdd.Enabled = false;
            btnRemove.Enabled = false;
            btnUp.Enabled = false;
            btnDown.Enabled = false;

            if (_editing) return;

            btnAdd.Enabled = true;

            bool hasRowSelected = c1FlexGrid1.RowSel >= c1FlexGrid1.Rows.Fixed;
            btnRemove.Enabled = hasRowSelected;

            bool isFirstRowSelected = hasRowSelected && c1FlexGrid1.RowSel == c1FlexGrid1.Rows.Fixed;
            bool isLastRowSelected = hasRowSelected && c1FlexGrid1.RowSel == c1FlexGrid1.Rows.Count - 1;
            btnUp.Enabled = hasRowSelected && !isFirstRowSelected;
            btnDown.Enabled = hasRowSelected && !isLastRowSelected;
        }

        void c1FlexGrid1_AfterSelChange(object sender, C1.Win.FlexGrid.RangeEventArgs e)
        {
            UpdateButtonsSatus();
        }

        void c1FlexGrid1_LeaveEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
        {
            _editing = false;
            UpdateButtonsSatus();
        }

        private void c1FlexGrid1_StartEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
        {
            _editing = true;
            UpdateButtonsSatus();

            if (_updating) return;

            var labelIndex = c1FlexGrid1.Cols.Fixed;
            var valueIndex = labelIndex + 1;
            var data = c1FlexGrid1.Rows[e.Row][e.Col];
            var value = data == null ? "" : data.ToString();

            if (e.Col == labelIndex)
            {
                _nameEditor.Value = value;
                c1FlexGrid1.Editor = _nameEditor;
            }
            else if (e.Col == valueIndex)
            {
                _valueEditor.ScriptName = string.Format("{0}[{1}].{2}", _scriptNamePrefix, e.Row - c1FlexGrid1.Rows.Fixed, "Value");
                _valueEditor.Expression = value;
                c1FlexGrid1.Editor = _valueEditor;
            }
            else
            {
                c1FlexGrid1.Editor = null;
            }
        }

        private void c1FlexGrid1_AfterEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
        {
            if (_updating) return;

            var labelIndex = c1FlexGrid1.Cols.Fixed;
            var valueIndex = labelIndex + 1;
            if (e.Col == labelIndex)
            {
                c1FlexGrid1.Rows[e.Row][e.Col] = _nameEditor.Text;
            }
            else if (e.Col == valueIndex)
            {
                c1FlexGrid1.Rows[e.Row][e.Col] = _valueEditor.Expression;
                _valueEditor.Expression = "";
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.Rows.Add();
            UpdateButtonsSatus();
            c1FlexGrid1.Row = c1FlexGrid1.Rows.Count - 1;
            c1FlexGrid1.Col = 0;
            c1FlexGrid1.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (c1FlexGrid1.RowSel < c1FlexGrid1.Rows.Fixed) return;
            c1FlexGrid1.Rows.Remove(c1FlexGrid1.RowSel);
            UpdateButtonsSatus();
            if (btnRemove.Enabled)
                btnRemove.Focus();
            else
                c1FlexGrid1.Focus();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (c1FlexGrid1.RowSel <= c1FlexGrid1.Rows.Fixed) return;
            c1FlexGrid1.Rows.Move(c1FlexGrid1.RowSel, c1FlexGrid1.RowSel - 1);
            UpdateButtonsSatus();
            if (btnUp.Enabled)
                btnUp.Focus();
            else if (btnDown.Enabled)
                btnDown.Focus();
            else
                c1FlexGrid1.Focus();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (c1FlexGrid1.RowSel >= c1FlexGrid1.Rows.Count - 1) return;
            c1FlexGrid1.Rows.Move(c1FlexGrid1.RowSel, c1FlexGrid1.RowSel + 1);
            UpdateButtonsSatus();
            if (btnDown.Enabled)
                btnDown.Focus();
            else if (btnUp.Enabled)
                btnUp.Focus();
            else
                c1FlexGrid1.Focus();
        }
    }
}
