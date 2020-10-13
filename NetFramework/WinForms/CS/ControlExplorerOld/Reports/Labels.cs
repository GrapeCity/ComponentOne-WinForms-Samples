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
    public partial class Labels : C1DemoForm
    {
        XmlDocument doc;
        
        public Labels()
        {
            InitializeComponent();
        }

        private void Labels_Load(object sender, EventArgs e)
        {
            // load XmlDocument with all report definitions
            doc = new XmlDocument();
            doc.LoadXml(ControlExplorer.Properties.Resources.Reports);
            reportsCombo.SelectedIndex = 0;
        }

        private void LoadReport(string reportName)
        {
            // load C1Report with selected report
            c1Report1.Load(doc, reportName);
            c1PrintPreviewControl1.Document = c1Report1.Document;
        }

        private void reportsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadReport(reportsCombo.SelectedItem.ToString());
        }
    }
}
