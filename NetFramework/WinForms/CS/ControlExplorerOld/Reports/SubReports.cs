using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ControlExplorer.Reports
{
    public partial class SubReports : C1DemoForm
    {
        XmlDocument doc;

        public SubReports()
        {
            InitializeComponent();
        }

        private void SubReports_Load(object sender, EventArgs e)
        {
            // load XmlDocument with all report definitions
            doc = new XmlDocument();
            doc.LoadXml(ControlExplorer.Properties.Resources.Reports);
            comboReports.SelectedIndex = 0;
        }

        private void LoadReport(string reportName)
        {
            // load C1Report with selected report
            c1Report1.Load(doc, reportName);
            c1Report1.Sections.Header.Visible = false;
            c1PrintPreviewControl1.Document = c1Report1.Document;
        }

        private void comboReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReport(comboReports.SelectedItem.ToString());

        }
    }
}
