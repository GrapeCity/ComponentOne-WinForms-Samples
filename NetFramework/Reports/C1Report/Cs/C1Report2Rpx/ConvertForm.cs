using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.AppUtils.Options;
using C1R = C1.C1Report;
using AR = GrapeCity.ActiveReports;

namespace C1Report2Rpx
{
    public partial class ConvertForm : Form
    {
        private string _c1ReportDefinitionFile;
        private Reports _reports;
        private string _error;
        private bool _shown;

        public ConvertForm()
        {
            InitializeComponent();
        }

        #region Public
        public string Convert(
            IWin32Window owner,
            string c1ReportDefinitionFile,
            Reports reports)
        {
            _c1ReportDefinitionFile = c1ReportDefinitionFile;
            _reports = reports;
            tbC1ReportDefinition.Text = _c1ReportDefinitionFile;
            ShowDialog(owner);
            return _error;
        }
        #endregion

        #region Public static
        public static string DoConvert(
            IWin32Window owner,
            string c1ReportDefinitionFile,
            Reports reports)
        {
            using (ConvertForm f = new ConvertForm())
                return f.Convert(owner, c1ReportDefinitionFile, reports);
        }
        #endregion

        private void ConvertForm_Shown(object sender, EventArgs e)
        {
            if (_shown)
                return;
            _shown = true;

            try
            {
                //
                string[] reportNames = C1R.C1Report.GetReportList(_c1ReportDefinitionFile);
                if (reportNames.Length <= 0)
                {
                    _error = string.Format(Strings.ConvertForm.NoReportsInXMLFile, _c1ReportDefinitionFile);
                    return;
                }

                //
                foreach (string reportName in reportNames)
                {
                    tbReport.Text = reportName;
                    Application.DoEvents();

                    ReportItem ri = new ReportItem();
                    try
                    {
                        ri.Report.Load(_c1ReportDefinitionFile, reportName);
                        C1ReportConverter rc = new C1ReportConverter(ri.Report, ri.Log);
                        rc.Convert();
                        rc.AReport.SaveLayout(ri.RpxData);
                    }
                    catch (Exception ex)
                    {
                        ri.Log.Add(LogEntryLevel.Error, string.Empty, ex.Message);
                    }
                    _reports.Add(ri);
                }

                _error = null;
            }
            catch (Exception ex)
            {
                _error = string.Format(Strings.ConvertForm.ErrorParsingC1ReportXmlFile, _c1ReportDefinitionFile, ex.Message);
            }

            //
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
