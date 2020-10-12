using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SsrsQuickStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void c1SSRSDocumentSource1_SecurityError(object sender, C1.Win.C1Document.SecurityErrorEventArgs e)
        {
            // An alternative to specifying credentials for accessing SSRS via C1SSRSDocumentSource.ConnectionOptions.ConnectInfo
            // is to leave those blank in the designer, handle the C1SSRSDocumentSource.SecurityError event,
            // and provide user credentials here. This allows to e.g. ask the user for credentials.
#if skip_this
            var ds = sender as C1.Win.C1Document.C1SSRSDocumentSource;
            ds.Credential = new System.Net.NetworkCredential(login, password);
            e.Retry = true;
#endif
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = ((C1.Win.C1Document.SSRSReportLocation)c1SSRSDocumentSource1.DocumentLocation).ReportServer +
                ((C1.Win.C1Document.SSRSReportLocation)c1SSRSDocumentSource1.DocumentLocation).ReportPath;
        }
    }
}
