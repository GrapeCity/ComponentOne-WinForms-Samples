using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using C1.C1Report;
using C1.Win.C1Ribbon;

namespace NewIn2015v2
{
    public partial class Form1 : C1.Win.C1Ribbon.C1RibbonForm
    {
        private RibbonComboBox _rcbFile;
        private RibbonComboBox _rcbReport;

        public Form1()
        {
            InitializeComponent();

            //
            // Build additional RibbonGroup in the Ribbon of C1RibbonPreview control
            RibbonGroup rgReports = new RibbonGroup("Reports");
            _rcbFile = new RibbonComboBox();
            _rcbFile.LabelWidth = 40;
            _rcbFile.Label = "File";
            _rcbFile.DropDownStyle = RibbonComboBoxStyle.DropDownList;
            _rcbFile.SelectedIndexChanged += _rcbFile_SelectedIndexChanged;
            _rcbFile.TextAreaWidth = 200;
            rgReports.Items.Add(_rcbFile);

            _rcbReport = new RibbonComboBox();
            _rcbReport.LabelWidth = 40;
            _rcbReport.Label = "Report";
            _rcbReport.DropDownStyle = RibbonComboBoxStyle.DropDownList;
            _rcbReport.SelectedIndexChanged += _rcbReport_SelectedIndexChanged;
            _rcbReport.TextAreaWidth = 200;
            rgReports.Items.Add(_rcbReport);

            // fill _rbFile with initial list of the files
            // added all files in the ..\..\Reports directory
            string[] files = Directory.GetFiles(@"..\..\Reports", "*.xml");
            if (files != null)
            {
                foreach (string file in files)
                {
                    try
                    {
                        string[] reports = C1Report.GetReportList(file);
                        if (reports != null && reports.Length > 0)
                        {
                            RibbonItem ri = _rcbFile.Items.Add(file);
                            ri.ToolTip = file;
                        }
                    }
                    catch
                    {
                        // eat all exceptions if folder contains "not C1Report xmls"
                    }
                }
                if (_rcbFile.Items.Count > 0)
                    _rcbFile.SelectedIndex = 0;
            }

            // add created RibbonGroup to the ribbon
            c1RibbonPreview1.Ribbon.Tabs[0].Groups.Insert(0, rgReports);
        }

        void _rcbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            RibbonItem ri = _rcbReport.SelectedItem;
            _rcbReport.ToolTip = ri == null ? "" : ri.ToolTip;

            string report = _rcbReport.ToolTip;
            // start timer do not update preview here to prevent too often updates
            timer1.Enabled = false;
            timer1.Enabled = !string.IsNullOrEmpty(report);
        }

        void _rcbFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            RibbonItem ri = _rcbFile.SelectedItem;
            _rcbFile.ToolTip = ri == null ? "" : ri.ToolTip;

            // load list of the reports from file
            string file = ri.ToolTip;
            _rcbReport.Items.Clear();
            try
            {
                string[] reports = C1Report.GetReportList(file);
                foreach (string report in reports)
                {
                    RibbonItem rir = _rcbReport.Items.Add(report);
                    rir.ToolTip = report;
                }
            }
            catch
            {
            }
            if (_rcbReport.Items.Count > 0)
                _rcbReport.SelectedIndex = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ignore tick if we currently rendering a report
            if (c1Report1.IsBusy)
                return;

            timer1.Enabled = false;
            // preview current report
            string file = _rcbFile.SelectedItem == null ? null : _rcbFile.SelectedItem.ToolTip;
            string report = _rcbReport.SelectedItem == null ? null : _rcbReport.SelectedItem.ToolTip;
            if (string.IsNullOrEmpty(report) || string.IsNullOrEmpty(file))
            {
                c1RibbonPreview1.Document = null;
                return;
            }

            try
            {
                c1Report1.Load(file, report);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Cannot load report [{1}] from file:\r\n{0}\r\n\r\nException:\r\n{2}", file, report, ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                c1RibbonPreview1.Document = c1Report1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Exception while rendering the report:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
