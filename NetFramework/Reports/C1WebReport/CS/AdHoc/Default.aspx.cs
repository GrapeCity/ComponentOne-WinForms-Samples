using System;
using System.Drawing;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace AdHoc
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
            // apply parameters in controls to the report
            //
            // NOTE: 
            //
            // This is necessary because the report definition
            // is not persisted as part of the ViewState (only the 
            // location of the file and the report name are, along
            // with the other control properties).
            //
            // Therefore, every time the page loads, the report
            // definition is read back into the control, and any
            // customizations to the report definition need to be
            // reapplied.
            // 
            ConfigureReport();
        }
        protected void _btnRender_Click(object sender, EventArgs e)
        {
            // make sure report is visible, show first page
            _c1wr.Visible = true;
            _c1wr.CurrentPage = 1;

            // also show other buttons
            _btnSend.Visible = true;
            Button1.Visible = true;
        }
        protected void _btnSend_Click(object sender, EventArgs e)
        {
            // show what happened
            _lblErr.Visible = true;

            try
            {
                // create report file
                string fileName = Page.MapPath("report.rtf");
                _c1wr.Report.RenderToFile(fileName, C1.C1Report.FileFormatEnum.RTF);

                // create message
                System.Web.Mail.MailMessage mm = new System.Web.Mail.MailMessage();
                mm.Subject = "Sales Goal Report";
                mm.From = "ceo@nwind.com"; // << must be a valid email
                mm.To = "joeManager@nwind.com";
                mm.Body = "Hi Joe. I got the sales goal down. Here's the final report.";

                // attach
                System.Web.Mail.MailAttachment att = new System.Web.Mail.MailAttachment(fileName);
                mm.Attachments.Add(att);

                // and send...
                System.Web.Mail.SmtpMail.Send(mm);
                _lblErr.Text = "** Your report is in the mail!";
            }
            catch (Exception x)
            {
                _lblErr.Text = "Sorry, failed to send because<br>" + x.Message;
                _lblErr.BackColor = Color.Pink;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            // show PDF version
            _c1wr.ShowPDF();
        }
        // configure report by applying current selection.
        //
        // The current user selection is saved in the ViewState,
        // but the report definition is too big for that, so it
        // is automatically reloaded with every post-back.
        // 
        private void ConfigureReport()
        {
            C1.C1Report.C1Report rpt = _c1wr.Report;

            CorrectConnectionString(rpt);

            // customize report with info submitted by the user by setting
            // the RecordSource property on the contained C1Report control
            string sql =
                "SELECT DISTINCTROW Employees.Country, Employees.LastName, " +
                "  Employees.FirstName, Orders.ShippedDate, Orders.OrderID, " +
                "  [Order Subtotals].Subtotal AS SaleAmount " +
                "FROM Employees INNER JOIN " +
                "  (Orders INNER JOIN [Order Subtotals] ON Orders.OrderID = [Order Subtotals].OrderID) " +
                "  ON Employees.EmployeeID = Orders.EmployeeID";

            // select specific year
            string year = _lstYear.SelectedItem.Text;
            if (year != "All")
                sql += " WHERE Year(Orders.ShippedDate) = " + year;
            sql += ";";

            // assign new RecordSource to control
            rpt.DataSource.RecordSource = sql;

            // also replace the built-in script (which has a hard-wired sales quota) 
            // with the custom value entered by the user
            try
            {
                // build the custom script
                string script = string.Format(
                    "goalExceeded = SalespersonTotal > {0:0.00}\n" +
                    "ExceededGoalLabel.Visible = goalExceeded\n" +
                    "SalespersonLine.Visible = goalExceeded",
                    double.Parse(this._txtGoal.Text, System.Globalization.NumberStyles.Any));

                // assign script to group header 2 OnPrint event
                rpt.Sections[C1.C1Report.SectionTypeEnum.GroupHeader2].OnPrint = script;

            }
            catch { } // invalid quota, ignore it
        }
    }
}
