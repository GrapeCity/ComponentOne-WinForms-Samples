using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using C1.Web.C1WebReport;

namespace CustomNavBar
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

        protected void Page_Load(object sender, EventArgs e)
        {
            CorrectConnectionString(_c1wr.Report);
            if (!IsPostBack)
                _c1wr_CurrentPageChanged(this, EventArgs.Empty);
        }

        // handle navigation buttons
        protected void _btnFirst_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            _c1wr.CurrentPage = 1;
        }
        protected void _btnPrev_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            _c1wr.CurrentPage--;
        }
        protected void _btnNext_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            _c1wr.CurrentPage++;
        }
        protected void _btnLast_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            _c1wr.CurrentPage = _c1wr.PageCount;
        }

        // update bar state after page changes
        protected void _c1wr_CurrentPageChanged(object sender, System.EventArgs e)
        {
            int curr = _c1wr.CurrentPage;
            int cnt = _c1wr.PageCount;

            // show/hide navigation buttons
            _btnFirst.Visible = _btnPrev.Visible = (curr > 1);
            _btnLast.Visible = _btnNext.Visible = (curr < cnt);
            _btnJump.Visible = _txtPage.Visible = (cnt > 1);

            // update label
            string str = string.Format("This is page {0} of {1}", curr, cnt);
            if (curr == 1) str = "This is the first page.";
            else if (curr == cnt) str = string.Format("This is the last page ({0}).", cnt);
            _lblCurrent.Text = str;
        }

        // handle goto page button
        protected void _btnJump_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            try
            {
                int curr = int.Parse(_txtPage.Text);
                if (curr < 1) curr = 1;
                if (curr > _c1wr.PageCount) curr = _c1wr.PageCount;
                _c1wr.CurrentPage = curr;
            }
            catch { }
            _txtPage.Text = "";
        }
        protected void _btnExport_Click(object sender, EventArgs e)
        {
            _c1wr.Export(_cbxFormats.SelectedValue);
        }
    }
}
