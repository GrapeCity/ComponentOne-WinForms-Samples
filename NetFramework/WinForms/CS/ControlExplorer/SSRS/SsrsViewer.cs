using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Runtime.CompilerServices;

using C1.Win.C1Document;
using C1.Win.C1Preview;
using C1.Win.C1Ssrs;

using RS = C1.Win.ImportServices.ReportingService4;

namespace ControlExplorer.SSRS
{
    public partial class SsrsViewer : C1DemoForm
    {
        private string _reportServer;
        private NetworkCredential _credential;
        private RequestCredentialDelegate _requestCredentialDelegate;

        public SsrsViewer()
        {
            InitializeComponent();

            tbSSRSServer.Text = "http://ssrs.componentone.com:8000/ReportServer";
            tbUserName.Text = "ssrs_demo";
            tbPassword.Text = "bjqveS5gh89BH1Q";

            _requestCredentialDelegate = new RequestCredentialDelegate(RequestCredential);

            c1PrintPreviewControl1.TextSearchUIStyle = TextSearchUIStyle.ToolBar;

            UpdateControls();
        }

        private string ExceptionToString(Exception exception)
        {
            return exception == null ? "NULL" : exception.Message;
        }

        private NetworkCredential GetCredential()
        {
            return new NetworkCredential(tbUserName.Text, tbPassword.Text, tbDomain.Text);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //
            btnOpen.Enabled = false;
            tvReports.ShowRootLines = false;
            tvReports.Nodes.Clear();
            var node = tvReports.Nodes.Add("Loading...");
            node.ImageIndex = 2;
            node.SelectedImageIndex = 2;

            //
            bwListReports.RunWorkerAsync(new ListReportsArgs() { Form = this, Credential = GetCredential(), ReportServer = tbSSRSServer.Text });
        }

        private delegate NetworkCredential RequestCredentialDelegate(string path, NetworkCredential credential);

        private NetworkCredential RequestCredential(string path, NetworkCredential nc)
        {
            NetworkCredential result = CredentialDialog.DoLogin(this, path, nc);
            if (result == null)
                return null;

            tbUserName.Text = result.UserName;
            tbPassword.Text = result.Password;
            tbDomain.Text = result.Domain;
            return result;
        }

        private class ListReportsArgs
        {
            public string ReportServer;
            public NetworkCredential Credential;
            public SsrsViewer Form;
        }

        private void bwListReports_DoWork(object sender, DoWorkEventArgs e)
        {
            ListReportsArgs lra = (ListReportsArgs)e.Argument;

            //
            RS.CatalogItem[] items = null;
            NetworkCredential nc = lra.Credential;
            while (true)
            {
                try
                {
                    using (ServerConnection rs = new ServerConnection())
                    {
                        rs.SetConnectionOptions(lra.ReportServer, new ConnectionOptions(nc));
                        items = rs.ListChildren(@"/", true, CancellationToken.None);
                        var sortedItems = from itm in items where itm.Type == RS.ItemTypeEnum.Folder || itm.Type == RS.ItemTypeEnum.Report orderby itm.Type, itm.Path, itm.Name select itm;
                        e.Result = new ListReportsResult() { Items = sortedItems, Credential = nc, ReportServer = lra.ReportServer };
                        return;
                    }
                }
                catch (C1.Win.C1Ssrs.SecurityException ex)
                {
                    // request credential
                    nc = Invoke(_requestCredentialDelegate, ex.Path, nc) as NetworkCredential;
                    if (nc != null)
                        continue;
                    e.Cancel = true;
                    return;
                }
                catch (Exception ex)
                {
                    e.Result = new ListReportsResult() { ErrorMessage = string.Format("Could not connect to the server.\r\n\r\n{0}", ex.Message) };
                    return;
                }
            }
        }

        private class ListReportsResult
        {
            public string ReportServer;
            public NetworkCredential Credential;
            public IEnumerable<RS.CatalogItem> Items;
            public string ErrorMessage;
        }

        private void bwListReports_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (IsDisposed)
            {
                return;
            }
            tvReports.Nodes.Clear();
            tvReports.ShowRootLines = true;
            btnOpen.Enabled = true;

            //
            if (e.Cancelled)
                return;
            ListReportsResult lrr = e.Result as ListReportsResult;
            if (lrr == null)
                return;
            if (lrr.ErrorMessage != null)
            {
                MessageBox.Show(this, lrr.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _reportServer = lrr.ReportServer;
            _credential = lrr.Credential;
            AddItems(tvReports.Nodes, lrr.Items);
        }

        private void AddItems(TreeNodeCollection nodes, IEnumerable<RS.CatalogItem> allItems, int level = 1)
        {
            var items = allItems.Where((itm) => !itm.Hidden && (itm.Type == RS.ItemTypeEnum.Report || itm.Type == RS.ItemTypeEnum.Folder));

            foreach (RS.CatalogItem item in items.Where((itm) => itm.Path.Count((c) => c == '/') == level))
            {
                if (item.Type == RS.ItemTypeEnum.Folder)
                {
                    var itemPath = item.Path + '/'; // make sure two folders like "/A" and "/AAA" won't be mixed up
                    var subItems = items.Where((itm) => itm.Path.StartsWith(itemPath) && (itm.Path.Count((c) => c == '/') == level + 1));
                   
                    if (subItems.Any())
                    {
                        TreeNode tn = nodes.Add(item.Name);
                        tn.Tag = item;
                        tn.SelectedImageIndex = 0;
                        tn.ImageIndex = 0;
                        AddItems(tn.Nodes, subItems, level + 1);
                    }
                }
                else
                {
                    TreeNode tn = nodes.Add(item.Name);
                    tn.Tag = item;
                    tn.SelectedImageIndex = 1;
                    tn.ImageIndex = 1;
                }
            }
        }

        private void UpdateControls()
        {
            var rl = c1SsrsDocumentSource1.DocumentLocation as SSRSReportLocation;
            if (rl != null)
                tbReport.Text = ReportSession.Combine(rl.ReportServer, rl.ReportPath);
            else
                tbReport.Text = "None";
            var treeNode = tvReports.SelectedNode;
            bool showReportEnabled = false;
            if (treeNode != null && !c1SsrsDocumentSource1.IsBusy)
            {
                var ci = treeNode.Tag as RS.CatalogItem;
                if (ci != null && ci.Type == RS.ItemTypeEnum.Report)
                {
                    showReportEnabled = true;
                }
            }
            btnShowReport.Enabled = showReportEnabled;
            if (c1SsrsDocumentSource1.PageCount > 0)
                tbState.Text = string.Format("Pages: {0}", c1SsrsDocumentSource1.PageCount);
            else
                tbState.Text = "Empty";
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            if (c1SsrsDocumentSource1.IsBusy)
                return;
            TreeNode node = tvReports.SelectedNode;
            if (node == null)
                return;
            RS.CatalogItem ci = node.Tag as RS.CatalogItem;
            if (ci == null || ci.Type != RS.ItemTypeEnum.Report)
                return;

            c1SsrsDocumentSource1.Credential = _credential;
            c1SsrsDocumentSource1.DocumentLocation = new SSRSReportLocation(_reportServer, ci.Path);
            c1PrintPreviewControl1.Document = c1SsrsDocumentSource1;
            c1PrintPreviewControl1.PreviewPane.Focus();
            UpdateControls();
        }

        private void tvReports_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateControls();
        }

        private void tvReports_DoubleClick(object sender, EventArgs e)
        {
            btnShowReport_Click(btnShowReport, EventArgs.Empty);
        }

        private void SsrsDocumentSource_StateChanged(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(() => { UpdateControls(); }));
        }

        private void SsrsDocumentSource_PageCountChanged(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(() => { UpdateControls(); }));
        }

        private void SsrsDocumentSource_SecurityError(object sender, SecurityErrorEventArgs e)
        {
            this.Invoke(new SecurityErrorEventHandler((s, ea) => 
            {
                C1DocumentSource ds = (C1DocumentSource)s;
                NetworkCredential nc = RequestCredential(ea.Path, ds.Credential);
                if (nc == null)
                    return;
                ds.Credential = nc;
                ea.Retry = true;
            }), sender, e);
        }
    }
}
