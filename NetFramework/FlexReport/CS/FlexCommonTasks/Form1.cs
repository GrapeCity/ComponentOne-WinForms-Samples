using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Ribbon;
using C1.Win.FlexReport;
using C1.Win.C1Command;

namespace FlexCommonTasks
{
    public partial class Form1 : C1RibbonForm
    {
        const string c_FlexCommonTasks = "FlexCommonTasks.flxr";

        public Form1()
        {
            InitializeComponent();

            UpdateLayout();

            BuildTopicBar();
        }

        private void UpdateLayout()
        {
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
        }

        private static int CompareCategories(Category x, Category y)
        {
            bool xNew = x.Name.StartsWith("New in");
            bool yNew = y.Name.StartsWith("New in");
            if ((xNew && yNew) || (!xNew && !yNew))
                return string.Compare(x.Name, y.Name, true);
            if (xNew)
                return -1;
            if (yNew)
                return 1;
            return string.Compare(x.Name, y.Name, true);
        }

        private void BuildTopicBar()
        {
            // get list of the reports
            string fileName = @"..\..\" + c_FlexCommonTasks;
            string[] reports = C1FlexReport.GetReportList(fileName);
            
            // go over reports and get category from C1FlexReport.ReportInfo.Keywords
            using (C1FlexReport fr = new C1FlexReport())
            {
                List<Category> categories = new List<Category>();
                foreach (string reportName in reports)
                {
                    fr.Load(fileName, reportName);

                    string keywords = fr.ReportInfo.Keywords;
                    string[] ss = keywords.Split(new string[] { "\r\n" }, StringSplitOptions.None); 
                    for (int i = 0; i < ss.Length; i++)
                    {
                        Category c = categories.Find((item) => string.Compare(item.Name, ss[i], true) == 0);
                        if (c == null)
                        {
                            c = new Category() { Name = ss[i] };
                            categories.Add(c);
                        }
                        c.Reports.Add(reportName);
                    }
                }
                categories.Sort(CompareCategories);

                foreach (Category c in categories)
                {
                    // build items in the C1TopicBar
                    C1TopicPage tp = new C1TopicPage(c.Name);
                    foreach (string s in c.Reports)
                    {
                        C1TopicLink tl = new C1TopicLink(s);
                        tp.Links.Add(tl);
                    }
                    tbReports.Pages.Add(tp);
                }
            }
        }

        private void tbReports_LinkClick(object sender, C1TopicBarClickEventArgs e)
        {
            if (c1FlexReport1.IsBusy)
                return;
            c1FlexReport1.Load(@"..\..\" + c_FlexCommonTasks, e.Link.Text);
            c1FlexViewer1.DocumentSource = c1FlexReport1;
        }

        private class Category
        {
            public string Name;
            public List<string> Reports = new List<string>();
        }
    }
}
