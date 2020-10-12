using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using C1.Win.C1Command;
using C1.Win.FlexReport;
using C1.Win.C1Ribbon;

namespace ControlExplorer.FlexReport
{
    public partial class CommonReports : C1DemoForm
    {
        C1FlexReport report;
        RibbonComboBox comboReports;
        RibbonToggleButton tbMoreReports;
        XmlDocument doc;
        Dictionary<string, List<string>> categories = new Dictionary<string, List<string>>();

        public CommonReports()
        {
            InitializeComponent();
            c1Zoom1.Target = null;

            // put C1TopicBur in the C1FlexViewer control
            tbReports.Parent = null;
            splitter1.Parent = null;

            var viewerControls = c1FlexViewer1.Controls;
            var c1 = viewerControls[0];
            var c2 = viewerControls[1];
            var c3 = viewerControls[2];
            viewerControls.Clear();

            viewerControls.Add(c1);
            viewerControls.Add(splitter1);
            viewerControls.Add(tbReports);
            viewerControls.Add(c2);
            viewerControls.Add(c3);

            // prepare the list of reports
            doc = new XmlDocument();
            doc.PreserveWhitespace = true;
            doc.LoadXml(ControlExplorer.Properties.Resources.FlexCommonTasks);

            // get the list of reports in the file
            string[] reports = C1FlexReport.GetReportList(doc);

            //
            // go over reports and get category from C1FlexReport.ReportInfo.Keywords
            using (C1FlexReport fr = new C1FlexReport())
            {
                foreach (string reportName in reports)
                {
                    fr.Load(doc, reportName);

                    string keywords = fr.ReportInfo.Keywords;
                    string[] ss = keywords.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    for (int i = 0; i < ss.Length; i++)
                    {
                        List<string> reps;
                        if (!categories.TryGetValue(ss[i], out reps))
                        {
                            reps = new List<string>();
                            categories.Add(ss[i], reps);
                        }
                        reps.Add(reportName);
                    }
                }

                // now categories dictionary contains list of categories and list of the reports in the each category
                // build content of the C1TopicBar
                foreach (KeyValuePair<string, List<string>> kvp in categories)
                {
                    C1TopicPage tp = new C1TopicPage(kvp.Key);
                    tp.ImageIndex = 0;
                    tp.ImageList = imageList1;
                    foreach (string s in kvp.Value)
                    {
                        C1TopicLink tl = new C1TopicLink(s);
                        tp.Links.Add(tl);
                    }
                    tbReports.Pages.Add(tp);
                }
            }

            // add list of the reports to the ribbon

            var ribbon = c1FlexViewer1.Ribbon;

            tbMoreReports = new RibbonToggleButton();
            tbMoreReports.Pressed = true;
            tbMoreReports.SmallImage = ControlExplorer.Properties.Resources.MoreReports;
            tbMoreReports.Text = "Reports panel";
            tbMoreReports.PressedChanged += MoreReports_PressedChanged;

            ribbon.QatItemsHolder.Insert(0, tbMoreReports);
            ribbon.Qat.Items.Insert(0, tbMoreReports);
            ribbon.Qat.MenuItems.Insert(0, tbMoreReports);

            comboReports = new RibbonComboBox();
            comboReports.GripHandleVisible = true;
            comboReports.TextAreaWidth = 170;
            comboReports.MaxDropDownItems = 12;
            comboReports.DropDownStyle = RibbonComboBoxStyle.DropDownList;
            comboReports.SelectedIndexChanged += comboReports_SelectedIndexChanged;

            var coll = comboReports.Items;
            foreach (string rn in reports)
                coll.Add(new RibbonButton(rn));

            ribbon.QatItemsHolder.Insert(0, comboReports);
            ribbon.Qat.ItemLinks.Insert(0, comboReports);

            var selReportLabel = new C1.Win.C1Ribbon.RibbonButton();
            ribbon.QatItemsHolder.Insert(0, selReportLabel);
            ribbon.Qat.ItemLinks.Insert(0, selReportLabel);
            selReportLabel.Text = "Select Report:";
            selReportLabel.Click += selReportLabel_Click;

            report = new C1FlexReport();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (report != null)
                {
                    c1FlexViewer1.DocumentSource = null;
                    report.Dispose();
                    report = null;
                }
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void CommonReports_Load(object sender, EventArgs e)
        {
            comboReports.SelectedIndex = 0;
        }

        private void LoadReport(string reportName)
        {
            if (report.IsBusy)
                return;

            // load C1FlexReport with selected report
            report.Load(doc, reportName);

            // assign report to the flex viewer control
            c1FlexViewer1.DocumentSource = report;
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

        void comboReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            RibbonButton item = comboReports.SelectedItem;
            if (item != null)
            {
                LoadReport(item.Text);
            }
        }

        void MoreReports_PressedChanged(object sender, EventArgs e)
        {
            bool panelVisible = tbMoreReports.Pressed;
            tbReports.Visible = panelVisible;
            splitter1.Visible = panelVisible;
        }

        void tbReports_LinkClick(object sender, C1TopicBarClickEventArgs e)
        {
            var coll = comboReports.Items;
            for (int i = 0; i < coll.Count; i++)
            {
                if (((RibbonButton)coll[i]).Text == e.Link.Text)
                {
                    comboReports.SelectedIndex = i;
                    break;
                }
            }
        }
    }
}
