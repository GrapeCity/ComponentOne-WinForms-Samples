//----------------------------------------------------------------------------
// SqlServerCeConnectionStringEditorForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using FlexReportDesignerApp.Util;

namespace FlexReportDesignerApp
{
    public partial class SqlServerCeConnectionStringEditorForm : Form
    {
        private ConnectionStringParser _parser;

        public SqlServerCeConnectionStringEditorForm()
        {
            InitializeComponent();


            this.cbFileMode.Items.Clear();
            this.cbFileMode.Items.Add(Strings.SqlServerCeConnectionStringEditorForm.FileModeRO);
            this.cbFileMode.Items.Add(Strings.SqlServerCeConnectionStringEditorForm.FileModeRW);
            this.cbFileMode.Items.Add(Strings.SqlServerCeConnectionStringEditorForm.FileModeEX);
            this.cbFileMode.Items.Add(Strings.SqlServerCeConnectionStringEditorForm.FileModeSR);
        }

        public bool Edit(ref string connectionString)
        {
            _parser = ConnectionStringParser.Parse(connectionString);
            if (_parser == null)
                _parser = new ConnectionStringParser();

            tbDataSource.Text = _parser["Data Source"];
            tbPassword.Text = _parser["Password"];
            tbTempFilePath.Text = _parser["Temp File Directory"];
            tbMaxDatabaseSize.Text = _parser["Max Database Size"];
            tbMaxBufferSize.Text = _parser["Max Buffer Size"];
            cbFileMode.Text = _parser["File Mode"];
            bool result = ShowDialog() == System.Windows.Forms.DialogResult.OK;
            if (result)
            {
                _parser["Data Source"] = tbDataSource.Text;
                _parser["Password"] = tbPassword.Text;
                _parser["Temp File Directory"] = tbTempFilePath.Text;
                _parser["Max Database Size"] = tbMaxDatabaseSize.Text;
                _parser["Max Buffer Size"] = tbMaxBufferSize.Text;
                _parser["File Mode"] = cbFileMode.Text;
                connectionString = _parser.ToString();
            }
            return result;
        }

        private void btnDataSourceBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.FileName = tbDataSource.Text;
                ofd.DefaultExt = "sdf";
                ofd.Filter = Strings.SqlServerCeConnectionStringEditorForm.SdfFilter;
                ofd.CheckFileExists = true;
                if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    tbDataSource.Text = ofd.FileName;
                ActiveControl = tbDataSource;
            }
        }

        private void btnTempFilePathBrows_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.SelectedPath = tbTempFilePath.Text;
                if (fbd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    tbTempFilePath.Text = fbd.SelectedPath;
                ActiveControl = tbTempFilePath;
            }
        }

        private void tbMaxDatabaseSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDataSource.Text))
            {
                DataSourceForm.ReportDataSourceError(Strings.SqlServerCeConnectionStringEditorForm.ErrSpecifyDbFileName);
                ActiveControl = tbDataSource;
                return;
            }
            if (string.Compare(cbFileMode.Text, Strings.SqlServerCeConnectionStringEditorForm.FileModeRO, true) == 0 && string.IsNullOrEmpty(tbTempFilePath.Text))
            {
                DataSourceForm.ReportDataSourceError(Strings.SqlServerCeConnectionStringEditorForm.ErrSpecifyTempDir);
                ActiveControl = tbTempFilePath;
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
