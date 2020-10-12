using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.C1Report;

namespace ReportStyle
{
    public partial class Form1 : Form
    {
        private string _fileName = "";
        private C1Report _rep = null;
        private ReportStyle _style = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Report Definition Files (*.xml)|*.xml|All Files (*.*)|*.*";
            if (ofd.ShowDialog(this) != DialogResult.OK)
                return;
            _fileName = ofd.FileName;
            cmbReports.Items.Clear();
            string[] reports = C1Report.GetReportList(_fileName);
            foreach (string report in reports)
                cmbReports.Items.Add(report);
            cmbReports.SelectedIndex = 0;

        }

        private void cmbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            C1Report rep = new C1Report();
            rep.Load(_fileName, cmbReports.SelectedItem as string);
            c1PrintPreviewControl1.Document = rep;
            _rep = rep;
        }

        private void btnSelectStyle_Click(object sender, EventArgs e)
        {
            StyleSelector rw = new StyleSelector();
            if (_style != null)
                rw.SelectedStyle = _style;

            if (rw.ShowDialog() == DialogResult.OK)
            {
                _style = rw.SelectedStyle;
                if (_style != null && _rep != null)
                {
                    _style.Apply(_rep);
                    _rep.Render();
                }
            }
        }
    }
}