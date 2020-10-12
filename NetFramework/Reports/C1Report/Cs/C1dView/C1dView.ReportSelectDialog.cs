using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.C1Report;

namespace C1dView
{
    public partial class ReportSelectDialog : Form
    {
        private string _fileName = null;

        public ReportSelectDialog()
        {
            InitializeComponent();
            lstReports.SelectedIndexChanged += (s, e) =>
                {
                    if (lstReports.SelectedItems.Count > 0)
                        ReportName = lstReports.SelectedItems[0].Text;
                    else
                        ReportName = string.Empty;
                };
            lstReports.DoubleClick += (s, e) =>
                {
                    btnOk.PerformClick();
                };
            btnOk.Click += (s, e) =>
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                };
            btnCancel.Click += (s, e) =>
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            };
        }

        public string ReportName { get; set; }

        public bool HasReports { get { return lstReports.Items.Count > 0; } }

        public string FileName
        {
            get { return _fileName; }
            set
            {
                lstReports.Clear();
                try
                {
                    var reports = C1Report.GetReportList(value);
                    foreach (string repName in reports)
                        lstReports.Items.Add(repName);
                    if (lstReports.Items.Count > 0)
                        lstReports.SelectedIndices.Add(0);
                    _fileName = value;
                }
                catch
                {
                    _fileName = null;
                }
            }
        }
    }
}
