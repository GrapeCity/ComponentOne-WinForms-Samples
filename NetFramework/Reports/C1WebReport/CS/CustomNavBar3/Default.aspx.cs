using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace CustomNavBar3
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
                C1WebReport1.ReportSource.ReportName = "03: Unbound Images";
            }
            CorrectConnectionString(C1WebReport1.Report);
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedIndex == 1)
            {
                C1WebReport1.NavigationBar.Images.GotoFirstImageUrl = "~/Images/first.gif";
                C1WebReport1.NavigationBar.MouseOverImages.GotoFirstImageUrl = "~/Images/first_over.gif";
                C1WebReport1.NavigationBar.DisabledImages.GotoFirstImageUrl = "~/Images/firstd.gif";

                C1WebReport1.NavigationBar.Images.GotoPreviousImageUrl = "~/Images/Prev.gif";
                C1WebReport1.NavigationBar.MouseOverImages.GotoPreviousImageUrl = "~/Images/Prev_over.gif";
                C1WebReport1.NavigationBar.DisabledImages.GotoPreviousImageUrl = "~/Images/Prevd.gif";

                C1WebReport1.NavigationBar.Images.GotoNextImageUrl = "~/Images/Next.gif";
                C1WebReport1.NavigationBar.MouseOverImages.GotoNextImageUrl = "~/Images/Next_over.gif";
                C1WebReport1.NavigationBar.DisabledImages.GotoNextImageUrl = "~/Images/Nextd.gif";

                C1WebReport1.NavigationBar.Images.GotoLastImageUrl = "~/Images/Last.gif";
                C1WebReport1.NavigationBar.MouseOverImages.GotoLastImageUrl = "~/Images/Last_over.gif";
                C1WebReport1.NavigationBar.DisabledImages.GotoLastImageUrl = "~/Images/Lastd.gif";

                C1WebReport1.NavigationBar.Images.GotoPageImageUrl = "~/Images/gotopage.gif";
                C1WebReport1.NavigationBar.MouseOverImages.GotoPageImageUrl = "~/Images/gotopage_over.gif";
                C1WebReport1.NavigationBar.DisabledImages.GotoPageImageUrl = "~/Images/gotopaged.gif";

                C1WebReport1.NavigationBar.Images.ExportImageUrl = "~/Images/export.gif";
                C1WebReport1.NavigationBar.MouseOverImages.ExportImageUrl = "~/Images/export_over.gif";
                C1WebReport1.NavigationBar.DisabledImages.ExportImageUrl = "~/Images/exportd.gif";
            }
            else
            {
                C1WebReport1.NavigationBar.Images.GotoFirstImageUrl = "";
                C1WebReport1.NavigationBar.MouseOverImages.GotoFirstImageUrl = "";
                C1WebReport1.NavigationBar.DisabledImages.GotoFirstImageUrl = "";

                C1WebReport1.NavigationBar.Images.GotoPreviousImageUrl = "";
                C1WebReport1.NavigationBar.MouseOverImages.GotoPreviousImageUrl = "";
                C1WebReport1.NavigationBar.DisabledImages.GotoPreviousImageUrl = "";

                C1WebReport1.NavigationBar.Images.GotoNextImageUrl = "";
                C1WebReport1.NavigationBar.MouseOverImages.GotoNextImageUrl = "";
                C1WebReport1.NavigationBar.DisabledImages.GotoNextImageUrl = "";

                C1WebReport1.NavigationBar.Images.GotoLastImageUrl = "";
                C1WebReport1.NavigationBar.MouseOverImages.GotoLastImageUrl = "";
                C1WebReport1.NavigationBar.DisabledImages.GotoLastImageUrl = "";

                C1WebReport1.NavigationBar.Images.GotoPageImageUrl = "";
                C1WebReport1.NavigationBar.MouseOverImages.GotoPageImageUrl = "";
                C1WebReport1.NavigationBar.DisabledImages.GotoPageImageUrl = "";

                C1WebReport1.NavigationBar.Images.ExportImageUrl = "";
                C1WebReport1.NavigationBar.MouseOverImages.ExportImageUrl = "";
                C1WebReport1.NavigationBar.DisabledImages.ExportImageUrl = "";
            }
        }
    }
}
