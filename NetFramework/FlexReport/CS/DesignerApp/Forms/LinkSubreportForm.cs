//----------------------------------------------------------------------------
// LinkSubreportForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;

using C1.Win.FlexReport;
using C1.Win.Localization;

namespace FlexReportDesignerApp.Util
{
	/// <summary>
	/// Summary description for LinkSubreportForm.
	/// </summary>
	public partial class LinkSubreportForm : System.Windows.Forms.Form
	{
        public LinkSubreportForm()
        {
            // Required for Windows Form Designer support
            InitializeComponent();
        }

		public LinkSubreportForm(
            C1FlexReportDesigner designer)
            : this()
		{
			//
            AutoScaleMode = AutoScaleMode.None;
            Font = MainForm.DefaultAppFont;
            _designer = designer;
        }

        private C1FlexReportDesigner _designer;
        private FieldBase _subrepField;

        internal bool Init(FieldBase masterField)
        {
            _subrepField = null;

            C1FlexReport subReport;
            if (masterField is SubreportField)
                subReport = ((SubreportField)masterField).Subreport;
            else if (masterField is Field)
                subReport = ((Field)masterField).Subreport;
            else
                subReport = null;
            if (subReport == null)
            {
                MessageForm.Warn(Strings.LinkSubreportForm.CannotFindField);
                return false;
            }
            //
            _subrepField = masterField;
            // populate master text fields' list:
            try
            {
                DataSource ds = _subrepField.ParentReport.DataSource;
                if (ds != null)
                    _cmbMaster.Items.AddRange(ds.DataSourceInfo.TextFields.Select(fi_ => fi_.Name).ToArray());
            }
            catch
            {
                MessageForm.Warn(Strings.LinkSubreportForm.CannotGetMasterFields);
                return false;
            }
            // populate sub-report text fields' list:
            try
            {
                DataSource ds = subReport.DataSource;
                if (ds != null)
                    _cmbChild.Items.AddRange(subReport.DataSource.DataSourceInfo.TextFields.Select(fi_ => fi_.Name).ToArray());
            }
            catch
            {
                MessageForm.Warn(Strings.LinkSubreportForm.CannotGetSubreportFields);
                return false;
            }
			// try to find a match automatically
            // TODO: this code runs always, even if there is an existing and different from auto-found, link.
            // this is not good, needs to be redone to preserve the current setup when showing the dialog if one exists.
			foreach (string sm in _cmbMaster.Items)
			{
				foreach (string sc in _cmbChild.Items)
				{
					if (sm == sc)
					{
						_cmbMaster.Text = sm;
						_cmbChild.Text = sc;
						break;
					}
				}
			}

            // all's ok
            return true;
        }

        // enable OK button after both fields are selected
        private void _cmb_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _btnOK.Enabled = (_cmbMaster.SelectedIndex > -1 && _cmbChild.SelectedIndex > -1);
        }

        // done, build expression and return
        private void _btnOK_Click(object sender, System.EventArgs e)
        {
			if (_cmbMaster.Text.Length > 0 && _cmbChild.Text.Length > 0)
			{
				string master = Bracket(_cmbMaster.Text);
				string child  = Bracket(_cmbChild.Text);
                string expr = string.Format("\"{0} = '\" & {1} & \"'\"", child, master);

                if (_subrepField is SubreportField)
                {
                    ((SubreportField)_subrepField).SubreportFilter = new ScriptStringValue() { Expression = expr };
                }
                else if (_subrepField is Field)
                {
                    ((Field)_subrepField).Text = expr;
                    ((Field)_subrepField).Calculated = true;
                }
			}
        }

        // bracket field names if necessary
        private string Bracket(string name)
        {
            return (name.StartsWith("[") && name.EndsWith("]"))
                ? name
                : string.Format("[{0}]", name);
        }
    }
}
