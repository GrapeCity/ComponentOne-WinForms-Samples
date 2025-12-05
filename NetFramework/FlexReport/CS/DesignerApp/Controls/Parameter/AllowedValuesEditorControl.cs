//----------------------------------------------------------------------------
// AllowedValuesEditorControl.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
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
using C1.Win.Themes;
using C1.Report;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.Controls.Parameter
{
    internal partial class AllowedValuesEditorControl : UserControl
    {
        private ReportParameter _originalParameter;
        private ReportParameter _parameter;
        private bool _updating;

        public AllowedValuesEditorControl()
        {
            InitializeComponent();
            rbNone.CheckedChanged += rbBinding_CheckedChanged;
            rbBinding.CheckedChanged += rbBinding_CheckedChanged;
            rbValues.CheckedChanged += rbBinding_CheckedChanged;
        }

        void rbBinding_CheckedChanged(object sender, EventArgs e)
        {
            if (_updating) return;
            blveMain.Visible = rbBinding.Checked;
            rlveMain.Visible = rbValues.Checked;
        }

        public void Init(FlexDesignerHostServices provider, ReportParameter parameter)
        {
            _originalParameter = parameter;
            _parameter = new ReportParameter {Name = parameter.Name};
            _parameter.AssignFrom(parameter);

            _updating = true;
            blveMain.Init(provider, _parameter);
            rlveMain.Init(provider, _parameter);

            if (IsDefault())
            {
                rbNone.Checked = true;
                blveMain.Visible = false;
                rlveMain.Visible = false;
                rbNone.Focus();
            }
            else if (_parameter.AllowedValuesDefinition.Values.Count == 0)
            {
                rbBinding.Checked = true;
                blveMain.Visible = true;
                rlveMain.Visible = false;
                rbBinding.Focus();
            }
            else
            {
                rbValues.Checked = true;
                blveMain.Visible = false;
                rlveMain.Visible = true;
                rbValues.Focus();
            }
            _updating = false;
        }

        public bool MaybeDiscardValues()
        {
            return !rbValues.Checked && rlveMain.HasValues();
        }

        private bool IsDefault()
        {
            return _parameter.AllowedValuesDefinition.Values.Count == 0
                   && string.IsNullOrEmpty(_parameter.AllowedValuesDefinition.Binding.DataSourceName)
                   && string.IsNullOrEmpty(_parameter.AllowedValuesDefinition.Binding.LabelExpression)
                   && string.IsNullOrEmpty(_parameter.AllowedValuesDefinition.Binding.ValueExpression);
        }

        public void ApplyChanges(bool discardValues)
        {
            ApplyChanges(_originalParameter, discardValues);
        }

        private void ApplyChanges(ReportParameter parameter, bool discardValues)
        {
            var binding = parameter.AllowedValuesDefinition.Binding;
            binding.DataSourceName = "";
            binding.LabelExpression = "";
            binding.ValueExpression = "";
            parameter.AllowedValuesDefinition.Values.Clear();

            if (rbBinding.Checked)
            {
                blveMain.ApplyChanges(parameter);
            }
            
            if (rbValues.Checked || !discardValues)
            {
                rlveMain.ApplyChanges(parameter);
            }
        }
    }
}
