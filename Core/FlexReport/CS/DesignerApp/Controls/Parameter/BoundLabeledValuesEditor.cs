//----------------------------------------------------------------------------
// BoundLabeledValuesEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
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
using C1.Report;
using C1.Win.FlexReport.FlexDesigner;
using Office;

namespace FlexReportDesignerApp.Controls.Parameter
{
    internal partial class BoundLabeledValuesEditor : UserControl
    {
        private FlexDesignerHostServices _provider;
        private FlexReport _report;
        private bool _updating;
        
        public BoundLabeledValuesEditor()
        {
            InitializeComponent();
            cmbDataSourceName.SelectedIndexChanged += cmbDataSourceName_SelectedIndexChanged;
        }

        public void Init(FlexDesignerHostServices provider, ReportParameter parameter)
        {
            _provider = provider;

            var grs = _provider.GetService(typeof(IGetReportsService)) as IGetReportsService;
            Debug.Assert(grs != null);
            _report = grs.Report;

            _updating = true;
            PopulateDataSourceNames();
            var binding = parameter.AllowedValuesDefinition.Binding;
            svecLabel.Init(provider, binding.DataSourceName, parameter.Name + ".AllowedValuesDefinition.Binding.LabelExpression");
            svecValue.Init(provider, binding.DataSourceName, parameter.Name + ".AllowedValuesDefinition.Binding.ValueExpression");
            svecLabel.Enabled = svecValue.Enabled = !string.IsNullOrEmpty(binding.DataSourceName);

            cmbDataSourceName.Value = binding.DataSourceName;
            svecLabel.Expression = binding.LabelExpression;
            svecValue.Expression = binding.ValueExpression;
            _updating = false;
        }

        public void ApplyChanges(ReportParameter parameter)
        {
            var binding = parameter.AllowedValuesDefinition.Binding;
            binding.DataSourceName = cmbDataSourceName.Text;
            binding.LabelExpression = svecLabel.Expression;
            binding.ValueExpression = svecValue.Expression;
        }

        private void PopulateDataSourceNames()
        {
            cmbDataSourceName.Items.Clear();
            foreach (var ds in _report.DataSources)
            {
                cmbDataSourceName.Items.Add(ds.Name);
            }
        }

        private void cmbDataSourceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_updating) return;

            var scriptSource = cmbDataSourceName.Text;
            svecLabel.Enabled = svecValue.Enabled = !string.IsNullOrEmpty(scriptSource);
            svecLabel.ScriptSource = scriptSource;
            svecValue.ScriptSource = scriptSource;
        }
    }
}
