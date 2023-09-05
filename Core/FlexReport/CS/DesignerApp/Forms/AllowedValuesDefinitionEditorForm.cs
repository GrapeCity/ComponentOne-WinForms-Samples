//----------------------------------------------------------------------------
// AllowedValuesDefinitionEditorForm.cs
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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Themes;
using C1.Win.FlexReport;
using FlexReportDesignerApp.Util;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp.Forms
{
    internal partial class AllowedValuesDefinitionEditorForm : Form
    {
        public AllowedValuesDefinitionEditorForm()
        {
            InitializeComponent();
            btnOK.Click += btnOK_Click;
            btnCancel.Click += btnCancel_Click;

            C1ThemeController.ApplyThemeToControlTree(this, MainForm.TheMainForm.CachedTheme);
        }

        public void Init(FlexDesignerHostServices provider, ReportParameter parameter)
        {
            avecMain.Init(provider, parameter);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AppSettings.LoadObject("AllowedValuesDefinitionEditorForm", new FormState(this));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            AppSettings.SaveObject("AllowedValuesDefinitionEditorForm", new FormState(this));
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult= DialogResult.Cancel;
            Close();
        }

        void btnOK_Click(object sender, EventArgs e)
        {
            var discardValues = true;
            if (avecMain.MaybeDiscardValues())
            {
                var result = MessageForm.Ask("Discard the specified values?", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Cancel) return;
                if (result == DialogResult.No) discardValues = false;
            }
            avecMain.ApplyChanges(discardValues);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
