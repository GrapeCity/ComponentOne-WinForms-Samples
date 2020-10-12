using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using C1.Win.C1Document;
using C1.Win.C1Ribbon;

namespace ControlExplorer.SSRS
{
    public partial class FlexSsrsViewer : C1DemoForm
    {
        const string ReportServer = "http://ssrs.componentone.com:8000/ReportServer";
        const string ReportFolder = "AdventureWorks/";

        C1SSRSDocumentSource ssrs;
        RibbonComboBox comboReports;

        public FlexSsrsViewer()
        {
            InitializeComponent();
            c1Zoom1.Target = null;

            var selReportLabel = new C1.Win.C1Ribbon.RibbonButton();
            c1FlexViewer1.Ribbon.QatItemsHolder.Add(selReportLabel);
            c1FlexViewer1.Ribbon.Qat.ItemLinks.Add(selReportLabel);
            selReportLabel.Text = "Select Report:";
            selReportLabel.Click += selReportLabel_Click;

            comboReports = new RibbonComboBox();
            comboReports.GripHandleVisible = true;
            comboReports.TextAreaWidth = 170;
            comboReports.MaxDropDownItems = 12;
            comboReports.DropDownStyle = RibbonComboBoxStyle.DropDownList;
            comboReports.SelectedIndexChanged += comboReports_SelectedIndexChanged;

            var coll = comboReports.Items;
            coll.Add(new RibbonButton("Company Sales"));
            coll.Add(new RibbonButton("Customers Near Stores"));
            coll.Add(new RibbonButton("Employee Sales Summary"));
            coll.Add(new RibbonButton("Employee Sales Summary Detail"));
            coll.Add(new RibbonButton("Product Catalog"));
            coll.Add(new RibbonButton("Product Line Sales"));
            coll.Add(new RibbonButton("Sales by Region"));
            coll.Add(new RibbonButton("Sales Order Detail"));
            coll.Add(new RibbonButton("Store Contacts"));
            coll.Add(new RibbonButton("Territory Sales Drilldown"));

            c1FlexViewer1.Ribbon.QatItemsHolder.Add(comboReports);
            c1FlexViewer1.Ribbon.Qat.ItemLinks.Add(comboReports);

            ssrs = new C1SSRSDocumentSource();
            ssrs.Credential = new System.Net.NetworkCredential("ssrs_demo", "bjqveS5gh89BH1Q", "");
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (ssrs != null)
                {
                    c1FlexViewer1.DocumentSource = null;
                    ssrs.Dispose();
                    ssrs = null;
                }
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        void LoadReport(string reportName)
        {
            // update document location
            ssrs.DocumentLocation = new SSRSReportLocation(ReportServer, ReportFolder + reportName);

            // assign SSRS document source to the viewer control
            c1FlexViewer1.DocumentSource = ssrs;
        }

        void selReportLabel_Click(object sender, EventArgs e)
        {
            foreach (RibbonItem item in c1FlexViewer1.Ribbon.Qat.Items)
            {
                RibbonComboBox rbc = item as RibbonComboBox;
                if (rbc == comboReports)
                {
                    rbc.DroppedDown = true;
                    break;
                }
            }
        }

        void FlexSsrsViewer_Load(object sender, EventArgs e)
        {
            comboReports.SelectedIndex = 0;
        }

        void comboReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            RibbonButton item = comboReports.SelectedItem;
            if (item != null)
            {
                LoadReport(item.Text);
            }
        }
    }
}
