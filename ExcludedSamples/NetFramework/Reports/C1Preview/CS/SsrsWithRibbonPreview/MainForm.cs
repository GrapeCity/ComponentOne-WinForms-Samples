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
using C1.Win.C1Ssrs;

using RS = C1.Win.ImportServices.ReportingService4;

namespace SsrsWithRibbonPreview
{
    public partial class MainForm : Form
    {
        string _reportServer;
        NetworkCredential _credential;
        RequestCredentialDelegate _requestCredentialDelegate;

        public MainForm()
        {
            InitializeComponent();

            c1RibbonPreview1.PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.PageWidth;
            c1RibbonPreview1.PreviewPane.PropertyChanged += PreviewPane_PropertyChanged;
            c1RibbonPreview1.Ribbon.AllowContextMenu = false;
            c1RibbonPreview1.Ribbon.TopToolBar.Visible = false;
            c1RibbonPreview1.Ribbon.Qat.Visible = false;

            tbSSRSServer.Text = "http://ssrs.componentone.com:8000/ReportServer";
            tbUserName.Text = "ssrs_demo";
            tbPassword.Text = "bjqveS5gh89BH1Q";

            _requestCredentialDelegate = new RequestCredentialDelegate(RequestCredential);
            UpdateControls();
        }

        void PreviewPane_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Document")
            {
                UpdateControls();
            }
        }

        string ExceptionToString(Exception exception)
        {
            return exception == null ? "NULL" : exception.Message;
        }

        NetworkCredential GetCredential()
        {
            return new NetworkCredential(tbUserName.Text, tbPassword.Text, tbDomain.Text);
        }

        void chkSearchToolBar_Click(object sender, EventArgs e)
        {
            if (chkSearchToolBar.Checked)
                c1RibbonPreview1.TextSearchStyle = C1.Win.C1Preview.TextSearchUIStyle.ToolBar;
            else
                c1RibbonPreview1.TextSearchStyle = C1.Win.C1Preview.TextSearchUIStyle.Panel;
        }

        void btnOpen_Click(object sender, EventArgs e)
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

        delegate NetworkCredential RequestCredentialDelegate(string path, NetworkCredential credential);

        NetworkCredential RequestCredential(string path, NetworkCredential nc)
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
            public MainForm Form;
        }

        void bwListReports_DoWork(object sender, DoWorkEventArgs e)
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

        void bwListReports_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
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

        void AddItems(TreeNodeCollection nodes, IEnumerable<RS.CatalogItem> allItems, int level = 1)
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

        void UpdateControls()
        {
            var treeNode = tvReports.SelectedNode;
            bool showReportEnabled = false;
            if (treeNode != null && !c1SsrsDocumentSource1.IsBusy && !c1SsrsDocumentSource1.IsDisposed)
            {
                var ci = treeNode.Tag as RS.CatalogItem;
                if (ci != null && ci.Type == RS.ItemTypeEnum.Report)
                {
                    showReportEnabled = true;
                }
            }
            btnShowReport.Enabled = showReportEnabled;
            btnHideReport.Enabled = c1SsrsDocumentSource1.DocumentLocation != null;
        }

        void btnHideReport_Click(object sender, EventArgs e)
        {
            if (c1SsrsDocumentSource1.IsBusy ||
                c1SsrsDocumentSource1.IsDisposed)
                return;
            btnHideReport.Enabled = false;
            c1SsrsDocumentSource1.DocumentLocation = null;
            c1RibbonPreview1.Document = c1SsrsDocumentSource1;
            tvReports.Focus();
        }

        void btnShowReport_Click(object sender, EventArgs e)
        {
            if (c1SsrsDocumentSource1.IsBusy ||
                c1SsrsDocumentSource1.IsDisposed)
                return;
            TreeNode node = tvReports.SelectedNode;
            if (node == null)
                return;
            RS.CatalogItem ci = node.Tag as RS.CatalogItem;
            if (ci == null || ci.Type != RS.ItemTypeEnum.Report)
                return;

            btnHideReport.Enabled = true;
            c1SsrsDocumentSource1.Credential = _credential;
            c1SsrsDocumentSource1.DocumentLocation = new SSRSReportLocation(_reportServer, ci.Path);
            c1RibbonPreview1.Document = c1SsrsDocumentSource1;
            c1RibbonPreview1.PreviewPane.Focus();
        }

        void tvReports_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateControls();
        }

        void tvReports_DoubleClick(object sender, EventArgs e)
        {
            btnShowReport_Click(btnShowReport, EventArgs.Empty);
        }

        void SsrsDocumentSource_BusyStateChanged(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(() => { UpdateControls(); }));
        }

        void SsrsDocumentSource_PageCountChanged(object sender, EventArgs e)
        {
            this.Invoke(new MethodInvoker(() => { UpdateControls(); }));
        }

        void SsrsDocumentSource_SecurityError(object sender, SecurityErrorEventArgs e)
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
