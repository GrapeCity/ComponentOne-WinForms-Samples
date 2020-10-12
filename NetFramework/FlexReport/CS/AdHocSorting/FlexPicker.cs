using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.FlexReport;

namespace AdHocSorting
{
    public partial class FlexPicker : Form
    {
        public FlexPicker()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }

        public string FileName
        {
            get { return _txtFileName.Text; }
            set
            {
                _txtFileName.Text = value;
                ValidateChildren();
            }
        }

        public string ReportName
        {
            get { return _cmbReport.SelectedItem as string; }
        }

        private void _btnSelectFile_Click(object sender, EventArgs e)
        {
            if (_ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                _txtFileName.Text = _ofd.FileName;
                ValidateChildren();
            }
        }

        private void _txtFileName_Validated(object sender, EventArgs e)
        {
            _cmbReport.Items.Clear();
            try
            {
                string fn = _txtFileName.Text;
                if (string.IsNullOrEmpty(fn) || !System.IO.File.Exists(fn))
                    return;
                //
                var reports = C1.Win.FlexReport.C1FlexReport.GetReportList(_txtFileName.Text);
                foreach (string reportName in reports)
                    _cmbReport.Items.Add(reportName);
                if (_cmbReport.Items.Count > 0)
                    _cmbReport.SelectedIndex = 0;
            }
            catch
            { }
        }
    }
}
