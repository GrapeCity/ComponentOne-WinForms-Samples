using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace ChartInReport
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CorrectConnectionString(C1WebReport1.Report);
        }

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

        protected void C1WebReport1_StartSection(object sender, C1.C1Report.ReportEventArgs e)
        {
            if (e.Section == C1.C1Report.SectionTypeEnum.Header)
            {
                // get picture field
                C1.C1Report.Field f = this.C1WebReport1.Report.Fields["PictureField"];

                // calculate image size in pixels (convert from twips)
                System.Drawing.Size size = new System.Drawing.Size(
                    (int)(f.Width * 96f / 1440f),
                    (int)(f.Height * 96f / 1440f));

                // get image from webchart and assign it to field
                f.Picture = this.C1WebChart1.GetImage(System.Drawing.Imaging.ImageFormat.Png, size);
            }
        }
    }
}
