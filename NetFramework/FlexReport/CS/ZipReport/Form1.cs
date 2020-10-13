using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

using C1.Win.FlexReport;
using C1.C1Zip;

namespace ZipReport
{
    public partial class Form1 : Form
    {
        private const string zipName = "FlexCommonTasks.zip";
        private const string zipPwd = "flex";
        private XmlDocument _xmlDoc = null;

        public Form1()
        {
            InitializeComponent();
            //
            AppDomain.CurrentDomain.SetData("DataDirectory",
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), @"ComponentOne Samples\Common"));
            //
            _flxr.ReportError += _flxr_ReportError;
            //
            LoadZip();
        }

        void _flxr_ReportError(object sender, ReportErrorEventArgs e)
        {
            var msg = string.Format("Error occurred while rendering the report on page {0}:\r\n\r\n{1}\r\n\r\nContinue?", e.Page, e.Exception.Message);
            e.Handled = MessageBox.Show(msg, "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Yes;
        }

        private void LoadZip()
        {
            // locate zip file
            string strFile = Application.ExecutablePath;
            int i = strFile.IndexOf("\\bin");
            if (i > -1)
                strFile = strFile.Substring(0, i);
            strFile += "\\" + zipName;

            // open password-protected zip file
            C1ZipFile zip = new C1ZipFile();
            zip.Open(strFile);
            zip.Password = zipPwd;

            // load report definition XML document from compressed stream
            Stream stream = zip.Entries[0].OpenReader();
            _xmlDoc = new XmlDocument();
            _xmlDoc.PreserveWhitespace = true;
            _xmlDoc.Load(stream);
            stream.Close();
            //
            zip.Close();
            //
            _lbReports.Items.AddRange(C1FlexReport.GetReportList(_xmlDoc));
        }

        private void Render()
        {
            string reportName = _lbReports.SelectedItem as string;
            if (!string.IsNullOrEmpty(reportName))
            {
                _flxr.Load(_xmlDoc, reportName);
                _flexView.DocumentSource = _flxr;
            }
        }

        private void _btnRender_Click(object sender, EventArgs e)
        {
            Render();
        }

        private void _lbReports_DoubleClick(object sender, EventArgs e)
        {
            Render();
        }
    }
}
