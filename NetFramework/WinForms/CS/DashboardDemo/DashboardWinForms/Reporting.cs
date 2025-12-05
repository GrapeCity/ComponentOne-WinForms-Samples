using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexReport;
using System.IO;
using System.Reflection;
using C1.Win.FlexViewer;
using C1.Win.Command;

namespace DashboardWinForms
{
    public partial class Reporting : UserControl
    {

        string[] _reps = new string[] { "RegionWiseSalesData.flxr", "CurrentOpportunitiesData.flxr", "ProfitAndSales.flxr" };

        public Reporting()
        {
            InitializeComponent();
            Text = Strings.Resource.ReportsPage_Title;
            c1DockingTabPage1.Text = Strings.Resource.RegionSales_Header;
            c1DockingTabPage2.Text = Strings.Resource.Opportunities_Header;
            c1DockingTabPage3.Text = Strings.Resource.ProfitAndSales_Header;
        }

        private void Reporting_Load(object sender, EventArgs e)
        {
            c1DockingTab1_TabClick(null, EventArgs.Empty);
        }

        private void c1DockingTab1_TabClick(object sender, EventArgs e)
        {
            var flexViewer = c1DockingTab1.SelectedTab.Tag as C1FlexViewer ?? new C1FlexViewer()
            {
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top,
                Dock = DockStyle.Fill,
                ZoomMode = FlexViewerZoomMode.PageWidth,
                Parent = c1DockingTab1.SelectedTab
            };
            if (flexViewer.DocumentSource == null)
            {
                flexViewer.Ribbon.Minimized = true;
                var flexReport = new C1FlexReport();
                var reportStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("DashboardWinForms.Reports." + _reps[c1DockingTab1.SelectedIndex]);
                string[] reports = C1FlexReport.GetReportList(reportStream);
                if (reports.Count() == 0)
                {
                    return;
                }
                var reportName = reports[0];
                if (!string.IsNullOrEmpty(reportName))
                {
                    reportStream.Seek(0, SeekOrigin.Begin);
                    flexReport.Load(reportStream, reportName);
                    flexViewer.DocumentSource = flexReport;
                    c1DockingTab1.SelectedTab.Tag = flexViewer;
                }
            }
        }

        private void c1DockingTab1_MeasureTab(object sender, C1.Win.Command.MeasureTabEventArgs e)
        {
            var tabs = (C1DockingTab)sender;
            tabs.ItemSize = new Size(250, 50);

        }
    }
}

