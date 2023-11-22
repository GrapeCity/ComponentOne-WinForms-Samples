//----------------------------------------------------------------------------
// PictureHolderEditorForm.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1Themes;
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using FlexReportDesignerApp.Util;

namespace FlexReportDesignerApp.Forms
{
    internal partial class PictureHolderEditorForm : Form
    {
        public PictureHolderEditorForm()
        {
            InitializeComponent();
            MinimumSize = Size;

            C1ThemeController.ApplyThemeToControlTree(this, MainForm.TheMainForm.CachedTheme);
        }

        public void Init(FlexDesignerHostServices services, object propOwner, string propName, object value, bool supportExpression)
        {
            pictureHolderEditorControl1.Init(services, propOwner, propName, value, supportExpression);
        }

        public PictureHolder Value
        {
            get { return pictureHolderEditorControl1.Value; }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AppSettings.LoadObject("PictureHolderEditorForm", new FormState(this));
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            AppSettings.SaveObject("PictureHolderEditorForm", new FormState(this));
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            pictureHolderEditorControl1.UpdateTabStop();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            pictureHolderEditorControl1.ApplyChanges();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
