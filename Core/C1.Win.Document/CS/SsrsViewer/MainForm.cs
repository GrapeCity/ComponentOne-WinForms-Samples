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

using C1.Win.Document;
using C1.Win.Ribbon;
using C1.Win.Ssrs;

using C1.Win.FlexViewer;
using C1.Win.ImportServices.ReportingService4;

namespace SsrsViewer
{
    public partial class MainForm : C1RibbonForm
    {
        delegate NetworkCredential RequestCredentialDelegate(string path, NetworkCredential credential);

        string _reportServer;
        NetworkCredential _credential;
        RequestCredentialDelegate _requestCredentialDelegate;

        RibbonToggleButton _rbConnection;

        public MainForm()
        {
            // design initialize
            InitializeComponent();

            // set window coordinates
            object xo = Properties.Settings.Default["WindowX"];
            object yo = Properties.Settings.Default["WindowY"];
            object wo = Properties.Settings.Default["WindowWidth"];
            object ho = Properties.Settings.Default["WindowHeight"];
            if (xo != null && yo != null && wo != null && ho != null && (int)wo > 0 && (int)ho > 0)
            {
                Location = new Point((int)xo, (int)yo);
                Size = new Size((int)wo, (int)ho);
            }

            // set window state
            object wso = Properties.Settings.Default["WindowState"];
            if (wso != null && (int)wso >= 0 && (int)wso < 3)
            {
                WindowState = (FormWindowState)wso;
            }

            // layout
            UpdateLayout();
            c1FlexViewer1.ParamPanelAlignment = FlexViewerPanelAlignment.Far;

            tbSSRSServer.Text = "http://ssrs.componentone.com:8000/ReportServer";
            tbUserName.Text = "ssrs_demo";
            tbPassword.Text = "bjqveS5gh89BH1Q";

            _requestCredentialDelegate = new RequestCredentialDelegate(RequestCredential);
            UpdateControls();
        }

        void UpdateLayout()
        {
            var resources = new ComponentResourceManager(typeof(MainForm));

            _rbConnection = new RibbonToggleButton();
            _rbConnection.Pressed = true;
            _rbConnection.SmallImage = ilMain.Images[3];
            _rbConnection.Text = "SSRS Server && Reports";
            _rbConnection.PressedChanged += ConnectionButton_PressedChanged;

            var ribbon = c1FlexViewer1.Ribbon;
            ribbon.QatItemsHolder.Insert(0, _rbConnection);
            ribbon.Qat.Items.Insert(0, _rbConnection);
            ribbon.Qat.MenuItems.Insert(0, _rbConnection);

            connPanel.Parent = null;
            spMain.Parent = null;

            var cc = c1FlexViewer1.Controls;
            var c1 = cc[0];
            var c2 = cc[1];
            var c3 = cc[2];
            cc.Clear();

            cc.Add(c1);
            cc.Add(spMain);
            cc.Add(connPanel);
            cc.Add(c2);
            cc.Add(c3);
        }

        void UpdateControls()
        {
            var treeNode = tvReports.SelectedNode;
            bool showReportEnabled = false;
            if (treeNode != null && !c1SsrsDocumentSource1.IsBusy && !c1SsrsDocumentSource1.IsDisposed)
            {
                var ci = treeNode.Tag as CatalogItem;
                if (ci != null && ci.Type == ItemTypeEnum.Report)
                {
                    showReportEnabled = true;
                }
            }
            btnShowReport.Enabled = showReportEnabled;
            btnHideReport.Enabled = c1FlexViewer1.DocumentSource != null;
        }

        string ExceptionToString(Exception exception)
        {
            return exception == null ? "NULL" : exception.Message;
        }

        NetworkCredential GetCredential()
        {
            return new NetworkCredential(tbUserName.Text, tbPassword.Text, tbDomain.Text);
        }

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

        void ConnectionButton_PressedChanged(object sender, EventArgs e)
        {
            bool panelVisible = _rbConnection.Pressed;
            connPanel.Visible = panelVisible;
            spMain.Visible = panelVisible;
        }

        void PreviewPane_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Document")
            {
                UpdateControls();
            }
        }

        void btnOpen_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
            tvReports.ShowRootLines = false;
            tvReports.Nodes.Clear();
            var node = tvReports.Nodes.Add("Loading...");
            node.ImageIndex = 2;
            node.SelectedImageIndex = 2;

            bwListReports.RunWorkerAsync(new ListReportsArgs() { Form = this, Credential = GetCredential(), ReportServer = tbSSRSServer.Text });
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

            CatalogItem[] items = null;
            NetworkCredential nc = lra.Credential;
            while (true)
            {
                try
                {
                    using (ServerConnection rs = new ServerConnection())
                    {
                        rs.SetConnectionOptions(lra.ReportServer, new ConnectionOptions(nc));
                        items = rs.ListChildren(@"/", true, CancellationToken.None);
                        var sortedItems = from itm in items where itm.Type == ItemTypeEnum.Folder || itm.Type == ItemTypeEnum.Report orderby itm.Type, itm.Path, itm.Name select itm;
                        e.Result = new ListReportsResult() { Items = sortedItems, Credential = nc, ReportServer = lra.ReportServer };
                        return;
                    }
                }
                catch (C1.Win.Ssrs.SecurityException ex)
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
            public IEnumerable<CatalogItem> Items;
            public string ErrorMessage;
        }

        void bwListReports_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tvReports.Nodes.Clear();
            tvReports.ShowRootLines = true;
            btnOpen.Enabled = true;

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

        void AddItems(TreeNodeCollection nodes, IEnumerable<CatalogItem> allItems, int level = 1)
        {
            var items = allItems.Where((itm) => !itm.Hidden && (itm.Type == ItemTypeEnum.Report || itm.Type == ItemTypeEnum.Folder));

            foreach (CatalogItem item in items.Where((itm) => itm.Path.Count((c) => c == '/') == level))
            {
                if (item.Type == ItemTypeEnum.Folder)
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

        void btnHideReport_Click(object sender, EventArgs e)
        {
            if (c1SsrsDocumentSource1.IsBusy ||
                c1SsrsDocumentSource1.IsDisposed)
                return;
            btnHideReport.Enabled = false;
            c1FlexViewer1.DocumentSource = null;
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
            CatalogItem ci = node.Tag as CatalogItem;
            if (ci == null || ci.Type != ItemTypeEnum.Report)
                return;

            btnHideReport.Enabled = true;
            c1SsrsDocumentSource1.Credential = _credential;
            c1SsrsDocumentSource1.DocumentLocation = new SSRSReportLocation(_reportServer, ci.Path);
            c1FlexViewer1.DocumentSource = c1SsrsDocumentSource1;
            c1FlexViewer1.Pane.Focus();
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

        /// <summary>
        /// Update propery at closing.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["WindowX"] = Location.X;
            Properties.Settings.Default["WindowY"] = Location.Y;
            Properties.Settings.Default["WindowWidth"] = Size.Width;
            Properties.Settings.Default["WindowHeight"] = Size.Height;
            Properties.Settings.Default["WindowState"] = (int)WindowState;
            Properties.Settings.Default.Save();
        }
    }
}
