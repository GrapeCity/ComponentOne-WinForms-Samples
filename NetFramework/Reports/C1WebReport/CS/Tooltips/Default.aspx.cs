using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Tooltips
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
            if (!IsPostBack)
            {
                C1WebReport1.ReportSource.FileName = GetReportSourceFileName(Page);
                C1WebReport1.ReportSource.ReportName = "05: Watermark";

                txtFirst.Text = C1WebReport1.NavigationBar.ToolTips.GotoFirst;
                txtPrev.Text = C1WebReport1.NavigationBar.ToolTips.GotoPrevious;
                txtNext.Text = C1WebReport1.NavigationBar.ToolTips.GotoNext;
                txtLast.Text = C1WebReport1.NavigationBar.ToolTips.GotoLast;
                txtGoto.Text = C1WebReport1.NavigationBar.ToolTips.GotoPage;
                txtExport.Text = C1WebReport1.NavigationBar.ToolTips.Export;
            }
            CorrectConnectionString(C1WebReport1.Report);
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            C1WebReport1.NavigationBar.ToolTips.GotoFirst = txtFirst.Text;
            C1WebReport1.NavigationBar.ToolTips.GotoPrevious = txtPrev.Text;
            C1WebReport1.NavigationBar.ToolTips.GotoNext = txtNext.Text;
            C1WebReport1.NavigationBar.ToolTips.GotoLast = txtLast.Text;
            C1WebReport1.NavigationBar.ToolTips.GotoPage = txtGoto.Text;
            C1WebReport1.NavigationBar.ToolTips.Export = txtExport.Text;
        }
    }
}
