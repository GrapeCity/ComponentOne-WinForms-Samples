//----------------------------------------------------------------------------
// DataSourceForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using Flex = C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.Util
{
	/// <summary>
    /// DataSource picker form for use with C1ReportDesigner app.
	/// </summary>
	public partial class DataSourceForm : System.Windows.Forms.Form
    {
        // private fields
        private Flex.C1FlexReport _report;
        private Flex.DataSource _dataSource;
        private bool _newDataSource = false;

		public DataSourceForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
        }

        /// <summary>
        /// This is incomplete attempt to (a) prevent duplicate data source error messages, and
        /// (b) indicate erroneous datasources in the data tree with an icon or something.
        /// TODO (or discard).
        /// </summary>
        /// <param name="msg"></param>
        public static void ReportDataSourceError(string msg)
        {
            MainForm.HideSpash();
            MessageForm.Error(msg);
        }

        public bool EditDataSource(
            Flex.C1FlexReport report,
            Hashtable dataSchema,
            Flex.DataSource dataSource,
            FlexDesignerHostServices services,
            bool newDataSource = false)
        {
            _report = report;
            _newDataSource = newDataSource;
            _cmbDataSourceName.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (Flex.DataSource ds in report.DataSources)
                _cmbDataSourceName.Items.Add(ds.Name);
            //
            System.Diagnostics.Debug.Assert(_report.DataSources.Contains(dataSource), "We can only handle datasources that are in the report's DataSources collection");
            //
            _dspMain.DataSchema = dataSchema;
            SetDataSource(dataSource);

            // initialize picker control
            _dspMain.DesignerHostServices = services;
            // _dspMain.DataSource = dataSource;

            // set up form events
            // _dspMain.DoubleClick += new EventHandler(_btnOK_Click);

            // ready to go
            return ShowDialog() == DialogResult.OK;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (_newDataSource)
                EditName();
        }

        private void SetDataSource(Flex.DataSource dataSource)
        {
            // this check avoids duplicate error messages when opening a bad data source:
            if (dataSource == _dataSource)
                return;

            _dataSource = dataSource;
            _cmbDataSourceName.Text = _dataSource.Name;
            _cmbDataSourceName.SelectedItem = _dataSource.Name;

            //
            _dspMain.DataSource = dataSource;

            // initialize members
            _dspMain.IsolationLevel = dataSource.IsolationLevel;
            _dspMain.SetDataSource(dataSource.DataProvider, dataSource.ConnectionString, dataSource.RecordSource);

            // set up form events
            // _dspMain.DoubleClick += new EventHandler(_btnOK_Click);
        }

        // save results and dismiss dialog
		private void _btnOK_Click(object sender, System.EventArgs e)
		{
            if (!_dspMain.RecordSourceSelected)
            {
                // AppUtils.ShowWarning(Strings.DataSourceForm.SelectDataSource);
                MessageForm.Warn(Strings.DataSourceForm.SelectDataSource);
                return;
            }

			// apply changes
            _dataSource.DataProvider = _dspMain.DataProvider;
            _dataSource.ConnectionString = _dspMain.ConnectionString;
            _dataSource.RecordSource = _dspMain.RecordSource;
            _dataSource.RecordSourceType = _dspMain.RecordSourceType;
            _dataSource.Recordset = _dspMain.Recordset;

            //
            IList<DataSourcePicker.ReportParameterDesc> prms = _dspMain.GetRecordSourceParameters();
            if (prms != null && prms.Count > 0)
            {
                Flex.C1FlexReport report = _dataSource.ParentReport;
                foreach (DataSourcePicker.ReportParameterDesc rpd in prms)
                {
                    Flex.ReportParameter rp = (Flex.ReportParameter)report.Parameters.FindByName(rpd.Name);
                    if (rp == null)
                    {
                        rp = new Flex.ReportParameter();
                        rp.Name = rpd.Name;
                        rp.DataType = rpd.Type;
                        report.Parameters.Add(rp);
                    }
                }
            }

			// done
			DialogResult = DialogResult.OK;
		}

        private class DataSourceFormState : FormState
        {
            #region Constructors
            public DataSourceFormState(DataSourceForm owner)
                : base(owner)
            {
            }
            #endregion

            #region Internal properties
            internal new DataSourceForm Owner
            {
                get { return (DataSourceForm)base.Owner; }
            }
            #endregion

            #region Public properties
            [DefaultValue(false)]
            public bool Wrap
            {
                get { return Owner._dspMain.WordWrap; }
                set { Owner._dspMain.WordWrap = value; }
            }
            #endregion
        }

        private void DataSourceForm_Load(object sender, EventArgs e)
        {
            AppSettings.LoadObject("DataSourceForm", new DataSourceFormState(this));
        }

        private void DataSourceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AppSettings.SaveObject("DataSourceForm", new DataSourceFormState(this));
        }

        private void EditName()
        {
            _cmbDataSourceName.DropDownStyle = ComboBoxStyle.DropDown;
            _cmbDataSourceName.Focus();
        }

        private void AcceptDataSourceNameChange()
        {
            string oldName = _dataSource.Name;
            string newName = _cmbDataSourceName.Text;
            try
            {
                _dataSource.Name = newName;
                int idx = _cmbDataSourceName.Items.IndexOf(oldName);
                _cmbDataSourceName.Items[idx] = newName;
                _cmbDataSourceName.DropDownStyle = ComboBoxStyle.DropDownList;
                _cmbDataSourceName.SelectedItem = newName;
                if (_report.DataSourceName == oldName)
                    _report.DataSourceName = newName;
            }
            catch
            {
                EditName();
            }
        }

        private void _cmbDataSourceName_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F2:
                    EditName();
                    e.Handled = true;
                    break;
                case Keys.Enter:
                    if (!_cmbDataSourceName.DroppedDown)
                    {
                        AcceptDataSourceNameChange();
                        e.Handled = true;
                    }
                    break;
                case Keys.Escape:
                    _cmbDataSourceName.DropDownStyle = ComboBoxStyle.DropDownList;
                    _cmbDataSourceName.Text = _dataSource.Name;
                    e.Handled = true;
                    break;
            }
        }

        private void _cmbDataSourceName_DropDown(object sender, EventArgs e)
        {
            _cmbDataSourceName.Text = _dataSource.Name;
            _cmbDataSourceName.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void _cmbDataSourceName_Leave(object sender, EventArgs e)
        {
            if (_cmbDataSourceName.DropDownStyle != ComboBoxStyle.DropDownList)
            {
                AcceptDataSourceNameChange();
            }
        }

        private void _cmbDataSourceName_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Escape)
                e.IsInputKey = true;
        }

        private void _cmbDataSourceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var ds = _report.DataSources.FindByName(_cmbDataSourceName.SelectedItem as string);
                SetDataSource(ds);
            }
            catch
            {
            }
        }
	}
}
