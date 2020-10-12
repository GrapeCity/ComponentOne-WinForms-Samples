using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using C1.C1Report;
using C1.Win.C1Ribbon;

namespace ControlExplorer.Reports
{
    public partial class RibbonPreview : C1DemoForm
    {
        XmlDocument doc;
        RibbonComboBox comboReports;
        bool loading;

        public RibbonPreview()
        {
            InitializeComponent();

            var selReportLabel = new C1.Win.C1Ribbon.RibbonButton();
            c1RibbonPreview1.Ribbon.QatItemsHolder.Add(selReportLabel);
            c1RibbonPreview1.Ribbon.Qat.ItemLinks.Add(selReportLabel);
            selReportLabel.Text = "Select Report:";
            selReportLabel.Click += selReportLabel_Click;

            comboReports = new RibbonComboBox();
            c1RibbonPreview1.Ribbon.QatItemsHolder.Add(comboReports);
            c1RibbonPreview1.Ribbon.Qat.ItemLinks.Add(comboReports);
            comboReports.DropDownStyle = RibbonComboBoxStyle.DropDownList;
            comboReports.TextAreaWidth = 130;
            comboReports.Items.Add(new RibbonButton("Alternating Background"));
            comboReports.Items.Add(new RibbonButton("Conditional Formatting"));
            comboReports.Items.Add(new RibbonButton("Subtotals and Aggregates"));
            comboReports.Items.Add(new RibbonButton("Running Sums"));
            comboReports.Items.Add(new RibbonButton("Cross-tab Reports"));
            comboReports.Items.Add(new RibbonButton("Sorting"));
            comboReports.Items.Add(new RibbonButton("Unbound Images"));
            comboReports.Items.Add(new RibbonButton("Bound Images"));
            comboReports.Items.Add(new RibbonButton("Watermark"));
            comboReports.Items.Add(new RibbonButton("Force Page Breaks"));
            comboReports.Items.Add(new RibbonButton("Suppress or Force Zeros"));
            comboReports.Items.Add(new RibbonButton("Global Constant"));
            comboReports.Items.Add(new RibbonButton("Custom Paper Size"));
            comboReports.Items.Add(new RibbonButton("Gutters"));
            comboReports.Items.Add(new RibbonButton("CanGrow CanShrink"));
            comboReports.ChangeCommitted += new System.EventHandler(this.ComboReports_ChangeCommitted);
        }

        private void RibbonPreview_Load(object sender, EventArgs e)
        {
            doc = new XmlDocument();
            doc.LoadXml(ControlExplorer.Properties.Resources.Reports);
            comboReports.SelectedIndex = 0;

            // add demo properties
            AddProperty("ShowRulers", c1RibbonPreview1.PreviewPane);
        }

        void selReportLabel_Click(object sender, EventArgs e)
        {
            foreach (RibbonItem item in c1RibbonPreview1.Ribbon.Qat.Items)
            {
                RibbonComboBox rbc = item as RibbonComboBox;
                if (rbc == comboReports)
                {
                    rbc.DroppedDown = true;
                    break;
                }
            }
        }

        void ComboReports_ChangeCommitted(object sender, EventArgs e)
        {
            string reportName = comboReports.Text;
            if (loading)
                MessageBox.Show("C1Report is busy rendering previous report");
            else if (!string.IsNullOrEmpty(reportName))
            {
                LoadReport(reportName);
            }
        }

        void LoadReport(string reportName)
        {
            loading = true;

            // load C1Report with selected report
            c1Report1.Load(doc, reportName);
            c1Report1.Sections.Header.Visible = false;

            // assign report to print preview control
            c1RibbonPreview1.Document = c1Report1.C1Document;

            loading = false;
        }
    }
}
