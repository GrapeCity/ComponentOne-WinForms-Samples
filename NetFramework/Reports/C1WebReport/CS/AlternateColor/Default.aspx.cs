﻿using System;
using System.Drawing;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using C1.C1Report;

namespace AlternateColor
{
    public partial class _Default : System.Web.UI.Page
    {
        bool _toggle = false;

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

        protected void C1WebReport1_PrintSection(object sender, ReportEventArgs e)
        {
            if (e.Section == SectionTypeEnum.Detail)
            {
                Section s = this.C1WebReport1.Report.Sections[e.Section];
                s.BackColor = (_toggle) ? Color.LightGoldenrodYellow : Color.Wheat;
                _toggle = !_toggle;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            C1WebReport1.ShowPDF();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CorrectConnectionString(C1WebReport1.Report);
        }
    }
}
