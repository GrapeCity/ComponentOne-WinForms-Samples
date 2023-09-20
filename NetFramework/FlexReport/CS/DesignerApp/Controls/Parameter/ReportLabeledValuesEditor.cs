//----------------------------------------------------------------------------
// ReportLabeledValuesEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Win.C1FlexGrid;
using C1.Win.C1Themes;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using Doc = C1.Win.C1Document;
using FlexReportDesignerApp.Util;

namespace FlexReportDesignerApp.Controls.Parameter
{
    internal partial class ReportLabeledValuesEditor : UserControl
    {
        private FlexDesignerHostServices _provider;
        // private bool _updating;
        private bool _editing;
        private string _parameterName = string.Empty;

        public ReportLabeledValuesEditor()
        {
            InitializeComponent();
            c1FlexGrid1.Cols[0].ComboList = "|...";
            c1FlexGrid1.Cols[1].ComboList = "|...";
            c1FlexGrid1.CellButtonClick += C1FlexGrid1_CellButtonClick;

            c1FlexGrid1.StartEdit += c1FlexGrid1_StartEdit;
            c1FlexGrid1.AfterSelChange += c1FlexGrid1_AfterSelChange;
            c1FlexGrid1.LeaveEdit += c1FlexGrid1_LeaveEdit;
        }

        private class ScriptObjectValueHolder
        {
            public ScriptObjectValue Value { get; set; }
        }

        private void C1FlexGrid1_CellButtonClick(object sender, RowColEventArgs e)
        {
            var grs = _provider.GetGetReportService();
            var ses = _provider.GetScriptEditorService();
            if (grs == null || ses == null)
            {
                e.Cancel = true;
                return;
            }

            bool isLabel = e.Col == c1FlexGrid1.Cols.Fixed;
            var valueHolder = new ScriptObjectValueHolder();
            var value = c1FlexGrid1.Rows[e.Row][e.Col];
            if (value is string)
                valueHolder.Value = (string)value;
            else
                valueHolder.Value = (value as ScriptObjectValue);
            object result;

            string displayNameFmt = isLabel ?
                "{0}.AllowedValuesDefinition.Values({1}).Label" :
                "{0}.AllowedValuesDefinition.Values({1}).Value";
            string displayName = string.Format(displayNameFmt, _parameterName, e.Row - c1FlexGrid1.Rows.Fixed);

            if (ses.EditScript(
                grs.Report,
                null,
                ScriptEditorContextKind.ReportScript,
                valueHolder,
                "Value",
                displayName,
                true,
                out result))
                c1FlexGrid1.Rows[e.Row][e.Col] = result;
            else
                e.Cancel = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            btnUp.Text = ((char)0xe9).ToString();
            btnDown.Text = ((char)0xea).ToString();

            base.OnLoad(e);
        }

        public void Init(FlexDesignerHostServices provider, ReportParameter parameter)
        {
            _provider = provider;
            _parameterName = parameter.Name;
            // _updating = true;

            var values = parameter.AllowedValuesDefinition.Values;
            var labelIndex = c1FlexGrid1.Cols.Fixed;
            var valueIndex = labelIndex + 1;
            foreach (var value in values)
            {
                var row = c1FlexGrid1.Rows.Add();
                row[labelIndex] = ScriptValueHelper.ToString(value.Label);
                row[valueIndex] = ScriptValueHelper.ToString(value.Value);
            }

            c1FlexGrid1.Col = labelIndex;
            if (values.Count > 0)
            {
                c1FlexGrid1.Row = c1FlexGrid1.Rows.Fixed;
            }

            UpdateButtonsSatus();

            // _updating = false;
        }

        public bool HasValues()
        {
            return c1FlexGrid1.Rows.Count > c1FlexGrid1.Rows.Fixed;
        }

        public void ApplyChanges(ReportParameter parameter)
        {
            var labelIndex = c1FlexGrid1.Cols.Fixed;
            var valueIndex = labelIndex + 1;

            var values = parameter.AllowedValuesDefinition.Values;
            values.Clear();
            for (var index = 1; index < c1FlexGrid1.Rows.Count; index++)
            {
                var row = c1FlexGrid1.Rows[index];
                if (row.IsNew) continue;

                var value = new ReportLabeledValue();
                if (row[labelIndex] != null) value.Label = (ScriptStringValue)(row[labelIndex].ToString());
                // AM 2015/10/22
                // it looks like one more column should be added - Null and if it checked
                // then value should be interpretted as null.
                // Currently it will be better if empty value interpretted as empty string see 135236 for details.
                if (Doc.Utils.IsNull(row[valueIndex]))
                    value.Value.Value = string.Empty;
                else
                    value.Value = row[valueIndex].ToString();
                values.Add(value);
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

        private void c1FlexGrid1_StartEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            _editing = true;
            UpdateButtonsSatus();
        }

        private void c1FlexGrid1_LeaveEdit(object sender, RowColEventArgs e)
        {
            _editing = false;
            UpdateButtonsSatus();
        }

        private void c1FlexGrid1_AfterSelChange(object sender, RangeEventArgs e)
        {
            UpdateButtonsSatus();
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
            if (c1FlexGrid1.RowSel >= c1FlexGrid1.Rows.Count-1) return;
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
