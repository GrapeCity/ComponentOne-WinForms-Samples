//----------------------------------------------------------------------------
// AddSortDefForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Themes;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using FlexReportDesignerApp.Util;

namespace FlexReportDesignerApp.Forms
{
    public partial class AddSortDefForm : Form
    {
        public AddSortDefForm()
        {
            InitializeComponent();
            //
            _chkAscending.Checked = true;
            _chkDescending.Checked = false;
            _chkAscending.CheckedChanged += _chkAscending_CheckedChanged;
            _chkDescending.CheckedChanged += _chkDescending_CheckedChanged;
        }

        public AddSortDefForm(DataSource ds)
            : this()
        {
            C1ThemeController.ApplyThemeToControlTree(this, MainForm.TheMainForm.CachedTheme);

            if (ds.IsDataSourceInfoFetched)
            {
                _cmbSort.Items.Clear();
                ds.DataSourceInfo.TextFields.ForEach(tf_ => _cmbSort.Items.Add(tf_.Name));
            }
        }

        public string SortExpression
        {
            get
            {
                return _cmbSort.Text;
            }
            set
            {
                _cmbSort.Value = value;
            }
        }

        public bool Ascending
        {
            get
            {
                return _chkAscending.Checked;
            }
            set
            {
                if (value)
                    _chkAscending.Checked = true;
                else
                    _chkDescending.Checked = true;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AppSettings.LoadObject("AddSortDefForm", new FormState(this));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            AppSettings.SaveObject("AddSortDefForm", new FormState(this));
        }

        void _chkAscending_CheckedChanged(object sender, EventArgs e)
        {
            _chkDescending.Checked = !_chkAscending.Checked;
        }
        void _chkDescending_CheckedChanged(object sender, EventArgs e)
        {
            _chkAscending.Checked = !_chkDescending.Checked;
        }
    }
}
