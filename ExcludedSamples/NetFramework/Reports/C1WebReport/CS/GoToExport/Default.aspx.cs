using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace GoToExport
{
    public partial class _Default : System.Web.UI.Page
    {
        private void CorrectConnectionString(C1.C1Report.C1Report rep)
        {
            string cs = rep.DataSource.ConnectionString;
            if (cs == null || cs.Length <= 0)
                return;

            //
            int i = cs.IndexOf("Data Source", 0, StringComparison.OrdinalIgnoreCase);
            if (i < 0)
                return;
            while (i < cs.Length && cs[i] != '=') i++;
            if (i >= cs.Length)
                return;
            int j = i;
            while (i < cs.Length && cs[i] != ';') i++;

            //
            string mdbName = cs.Substring(j + 1, i - j - 1).Trim();
            if (mdbName.Length <= 0)
                return;
            mdbName = System.IO.Path.GetFileName(mdbName);
            if (string.Compare(mdbName, "nwind.mdb", true) == 0)
                mdbName = "c1nwind.mdb";

            //
            cs = cs.Substring(0, j + 1) +
                Environment.GetFolderPath(Environment.SpecialFolder.Personal) +
                @"\ComponentOne Samples\Common\" +
                mdbName +
                cs.Substring(i);

            rep.DataSource.ConnectionString = cs;

            //
            foreach (C1.C1Report.Field field in rep.Fields)
                if (field.Subreport != null)
                    CorrectConnectionString(field.Subreport);
        }

        static public String GetReportSourceFileName(System.Web.UI.Page page)
        {
            return page.MapPath("~/Reports/CommonTasks.xml");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (cbxFill.Checked)
            {
                C1WebReport1.ReportSource.FileName = GetReportSourceFileName(Page);
                C1WebReport1.ReportSource.ReportName = "18: Continued Headers";
            }
            else if (!cbxFill.Checked)
            {
                C1WebReport1.ReportSource.FileName = "";
                C1WebReport1.ReportSource.ReportName = "";
            }
            CorrectConnectionString(C1WebReport1.Report);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            C1WebReport1.NavigationBar.HasGotoPageButton = cbxGoToPageButton.Checked;
            C1WebReport1.EnableCallback = cbxUseCallback.Checked;
            C1WebReport1.NavigationBar.HasExportButton = cbxExportButton.Checked;
            C1.Web.C1WebReport.ExportFormatsEnum formats = 0;
            if (cbxPDF.Checked)
                formats = formats | C1.Web.C1WebReport.ExportFormatsEnum.PDF;
            if (cbxHTML.Checked)
                formats = formats | C1.Web.C1WebReport.ExportFormatsEnum.HTML;
            if (cbxRTF.Checked)
                formats = formats | C1.Web.C1WebReport.ExportFormatsEnum.RTF;
            if (cbxXLS.Checked)
                formats = formats | C1.Web.C1WebReport.ExportFormatsEnum.XLS;
            C1WebReport1.NavigationBar.ExportFormats = formats;
            C1WebReport1.ExportRenderMethod = (drpExportMethod.SelectedValue == "File") ? C1.Web.C1WebReport.ExportRenderMethodEnum.File : C1.Web.C1WebReport.ExportRenderMethodEnum.HttpHandler;
        }
    }
}
