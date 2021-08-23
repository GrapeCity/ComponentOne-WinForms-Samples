using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace MultiReport
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
            // populate report list (only once, the items become ViewState after this)
            if (!IsPostBack)
            {
                string fileName = _c1wr.ReportSource.FileName;
                string[] names = _c1wr.Report.GetReportInfo(Page.MapPath(fileName));
                foreach (string name in names)
                    DropDownList1.Items.Add(name);

                // go load first time
                DropDownList1_SelectedIndexChanged(this, System.EventArgs.Empty);
            }
        }
        protected void DropDownList1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // load selected report into control
            if (DropDownList1.SelectedItem != null)
                _c1wr.ReportSource.ReportName = DropDownList1.SelectedItem.ToString();
            CorrectConnectionString(_c1wr.Report);
        }
        protected void CheckBoxList1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            // the user changed something, so update them all
            _c1wr.Paged = CheckBoxList1.Items[0].Selected;
            _c1wr.NavigationBar.Visible = CheckBoxList1.Items[1].Selected;
            _c1wr.Cache.Enabled = CheckBoxList1.Items[2].Selected;
            _c1wr.Scrollable = CheckBoxList1.Items[3].Selected;
            _c1wr.DrillDown = CheckBoxList1.Items[4].Selected;
        }
        protected void Button1_Click(object sender, System.EventArgs e)
        {
            // show PDF version
            _c1wr.ShowPDF();
        }

    }
}
