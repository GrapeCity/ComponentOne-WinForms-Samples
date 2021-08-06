//----------------------------------------------------------------------------
// SQLiteConnectionStringEditorForm.cs
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
    public partial class SQLiteConnectionStringEditorForm : Form
    {
        private ConnectionStringParser _parser;

        public SQLiteConnectionStringEditorForm()
        {
            InitializeComponent();

        }

        #region Public
        public bool Edit(
            ref string connectionString)
        {
            _parser = ConnectionStringParser.Parse(connectionString);
            if (_parser == null)
                _parser = new ConnectionStringParser();

            tbDataSource.Text = _parser["Data Source"];
            tbPassword.Text = _parser["Password"];
            bool result = ShowDialog() == System.Windows.Forms.DialogResult.OK;
            if (result)
            {
                _parser["Data Source"] = tbDataSource.Text;
                _parser["Password"] = tbPassword.Text;
                connectionString = _parser.ToString();
            }
            return result;
        }
        #endregion

        private void btnDataSourceBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.FileName = tbDataSource.Text;
                ofd.DefaultExt = "db";
                ofd.Filter = Strings.SQLiteConnectionStringEditorForm.DbFilter;
                ofd.CheckFileExists = true;
                if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                    tbDataSource.Text = ofd.FileName;
                ActiveControl = tbDataSource;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDataSource.Text))
            {
                DataSourceForm.ReportDataSourceError(Strings.SqlServerCeConnectionStringEditorForm.ErrSpecifyDbFileName);
                ActiveControl = tbDataSource;
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
