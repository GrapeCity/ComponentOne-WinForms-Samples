using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace CustomNavBar2
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
            if (!this.IsPostBack)
            {
                C1WebReport1.ReportSource.FileName = GetReportSourceFileName(Page);
                C1WebReport1.ReportSource.ReportName = "10: Gutter";
            }
            CorrectConnectionString(C1WebReport1.Report);
            lblPage.Text = C1WebReport1.CurrentPage.ToString();
            lblCount.Text = C1WebReport1.PageCount.ToString();

            bool useCallbacks = cbxUseCallback.Checked;
            C1WebReport1.EnableCallback = useCallbacks;

            // Set the actions of the buttons

            // First
            btnFirst.Attributes.Add("onclick", C1WebReport1.NavigationBar.GetNavigationBarEventReference(btnFirst, "<<") + ";return false;");
            // Prev
            btnPrev.Attributes.Add("onclick", C1WebReport1.NavigationBar.GetNavigationBarEventReference(btnFirst, " < ") + ";return false;");
            // Next
            btnNext.Attributes.Add("onclick", C1WebReport1.NavigationBar.GetNavigationBarEventReference(btnFirst, " > ") + ";return false;");
            // Last
            btnLast.Attributes.Add("onclick", C1WebReport1.NavigationBar.GetNavigationBarEventReference(btnFirst, ">>") + ";return false;");

            // GoTo. 
            // The argument should be "GOTO<N>" (N is the page number to go)
            // Example: GOTO5 
            string gotoRef = C1WebReport1.NavigationBar.GetNavigationBarEventReference(btnFirst, "GOTO___");
            gotoRef = gotoRef.Replace("'GOTO___'", "'GOTO'+document.getElementById('txtGoTo').value");
            btnGoTo.Attributes.Add("onclick", gotoRef + ";return false;");

            // Export
            // The argument should be "EXPORT<FRM>" (FRM is the format to export)
            // Example: EXPORTpdf
            string exportRef = C1WebReport1.NavigationBar.GetNavigationBarEventReference(btnFirst, "EXPORT___");
            exportRef = exportRef.Replace("'EXPORT___'", "'EXPORT'+document.getElementById('cbxFormats').value");
            btnExport.Attributes.Add("onclick", exportRef + ";return false;");
        }
        protected void C1WebReport1_CurrentPageChanged(object sender, EventArgs e)
        {
            lblPage.Text = C1WebReport1.CurrentPage.ToString();
        }
    }
}
