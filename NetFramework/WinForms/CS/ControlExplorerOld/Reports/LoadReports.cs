using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using C1.C1Report;

namespace ControlExplorer.Reports
{
    public partial class LoadReports : C1DemoForm
    {
        XmlDocument doc;
        Label desc;
        bool loading;

        public LoadReports()
        {
            InitializeComponent();  
        }

        private void LoadReports_Load(object sender, EventArgs e)
        {
            // add Description tab
            desc = new Label();
            desc.Dock = DockStyle.Fill;
            desc.BackColor = Color.White;
            TabPage tabDesc = new TabPage("Description");
            tabDesc.Controls.Add(desc);
            c1PrintPreviewControl1.PreviewNavigationPanel.Controls.Add(tabDesc);

            doc = new XmlDocument();
            doc.LoadXml(ControlExplorer.Properties.Resources.Reports);
            comboReports.SelectedIndex = 0;

            // add demo properties
            AddProperty("NavigationPanelVisible", c1PrintPreviewControl1);
            AddProperty("ShowRulers", c1PrintPreviewControl1.PreviewPane);
        }

        private void LoadReport(string reportName)
        {
            loading = true;
            // load C1Report with selected report
            c1Report1.Load(doc, reportName);
            c1Report1.Sections.Header.Visible = false;

            // assign report to print preview control
            c1PrintPreviewControl1.Document = c1Report1.Document;

            // update demo description
            desc.Text = c1Report1.Fields["Description"].Text;
            loading = false;
        }

        private void comboReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!loading)
                LoadReport(comboReports.SelectedItem.ToString());
            else
                MessageBox.Show("C1Report is busy rendering previous report");
        }
    }
}
