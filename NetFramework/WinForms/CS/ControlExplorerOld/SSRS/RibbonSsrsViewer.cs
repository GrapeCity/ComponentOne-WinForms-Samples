using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;

using C1.Win.C1Ribbon;
using C1.Win.C1SplitContainer;
using C1.Win.C1Preview;
using C1.Win.C1Document;
using C1.Win.C1Ssrs;

using RS = C1.Win.ImportServices.ReportingService4;

namespace ControlExplorer.SSRS
{
    public partial class RibbonSsrsViewer : C1DemoForm
    {
        string _reportServer;
        NetworkCredential _credential;
        RequestCredentialDelegate _requestCredentialDelegate;

        C1SplitterPanel _ssrsPanel;
        RibbonToggleButton _ssrsButton;
        C1SplitterPanel _reportPanel;

        GroupBox gbLogin;
        TextBox tbDomain;
        TextBox tbPassword;
        TextBox tbUserName;
        Label label4;
        Label label3;
        Label label2;
        TextBox tbSSRSServer;
        Label label1;
        CheckBox chkSearchToolBar;
        Button btnOpen;
        System.Windows.Forms.TreeView tvReports;
        Button btnHideReport;
        Button btnShowReport;
        Panel _host;

        public RibbonSsrsViewer()
        {
            InitializeComponent();

            PrepareRibbon();
            PreparePreviewPanel();
            CreateSsrsPanel();

            tbSSRSServer.Text = "http://ssrs.componentone.com:8000/ReportServer";
            tbUserName.Text = "ssrs_demo";
            tbPassword.Text = "bjqveS5gh89BH1Q";

            _requestCredentialDelegate = new RequestCredentialDelegate(RequestCredential);
        }

        void SsrsPanel_CloseButtonClick(object sender, EventArgs e)
        {
            _ssrsPanel.Visible = false;
            c1RibbonPreview1.PreviewPane.Focus();
        }

        void SsrsPanel_VisibleChanged(object sender, System.EventArgs e)
        {
            _ssrsButton.Pressed = _ssrsPanel.Visible;
        }

        void SsrsPanel_SizeChanged(object sender, EventArgs e)
        {
            _host.Size = _ssrsPanel.Size;
        }

        void SsrsButton_Click(object sender, EventArgs e)
        {
            _ssrsPanel.Visible = !_ssrsPanel.Visible;
        }

        void RibbonStyle_StyleChanged(object sender, EventArgs e)
        {
            var rs = c1RibbonPreview1.Ribbon.RibbonStyle;
            Color lineColor = rs.ColorSet[StyleColor.GroupSeparator];
            _ssrsPanel.BorderColor = lineColor;
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
                c1RibbonPreview1.TextSearchStyle = TextSearchUIStyle.ToolBar;
            else
                c1RibbonPreview1.TextSearchStyle = TextSearchUIStyle.Panel;
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
            public RibbonSsrsViewer Form;
        }

        void bwListReports_DoWork(object sender, DoWorkEventArgs e)
        {
            ListReportsArgs lra = (ListReportsArgs)e.Argument;

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
            var rl = c1SsrsDocumentSource1.DocumentLocation as SSRSReportLocation;
            if (rl != null)
                _reportPanel.Text = ReportSession.Combine(rl.ReportServer, rl.ReportPath);
            else
                _reportPanel.Text = string.Empty;

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
            btnHideReport.Enabled = c1SsrsDocumentSource1.DocumentLocation != null;
        }

        void btnHideReport_Click(object sender, EventArgs e)
        {
            if (c1SsrsDocumentSource1.IsBusy)
                return;
            btnHideReport.Enabled = false;
            c1SsrsDocumentSource1.DocumentLocation = null;
            c1RibbonPreview1.Document = c1SsrsDocumentSource1;
            tvReports.Focus();
            UpdateControls();
        }

        void btnShowReport_Click(object sender, EventArgs e)
        {
            if (c1SsrsDocumentSource1.IsBusy)
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
            UpdateControls();
        }

        void PreviewPane_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Document")
            {
                UpdateControls();
            }
        }

        void tvReports_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateControls();
        }

        void tvReports_DoubleClick(object sender, EventArgs e)
        {
            btnShowReport_Click(btnShowReport, EventArgs.Empty);
        }

        void SsrsDocumentSource_StateChanged(object sender, EventArgs e)
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

        void PrepareRibbon()
        {
            var ribbon = c1RibbonPreview1.Ribbon;
            ribbon.AllowContextMenu = false;
            ribbon.TopToolBar.Visible = false;
            ribbon.Qat.Visible = false;
            ribbon.RibbonStyle.StyleChanged += RibbonStyle_StyleChanged;

            _ssrsButton = new RibbonToggleButton();
            _ssrsButton.Text = "SSRS Config";
            _ssrsButton.SmallImage = ControlExplorer.Properties.Resources.SsrsConfig;
            _ssrsButton.KeyTip = "S";
            _ssrsButton.ToolTip = "SSRS source configuration panel";
            _ssrsButton.Click += SsrsButton_Click;

            ribbon.Tabs[0].Groups[4].Items.Insert(0, _ssrsButton);
        }

        void PreparePreviewPanel()
        {
            var pp = c1RibbonPreview1.PreviewPane;
            _reportPanel = (C1SplitterPanel)pp.Parent;
            pp.ZoomMode = ZoomModeEnum.PageWidth;
            pp.PropertyChanged += PreviewPane_PropertyChanged;
        }

        void CreateSsrsPanel()
        {
            this.btnShowReport = new System.Windows.Forms.Button();
            this.btnHideReport = new System.Windows.Forms.Button();
            this.tvReports = new System.Windows.Forms.TreeView();
            this.btnOpen = new System.Windows.Forms.Button();
            this.chkSearchToolBar = new System.Windows.Forms.CheckBox();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSSRSServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();

            _ssrsPanel = new C1SplitterPanel();
            _ssrsPanel.BorderColor = c1RibbonPreview1.OutlineViewSplitterPanel.BorderColor;
            _ssrsPanel.BorderWidth = 1;

            _host = new Panel();
            _ssrsPanel.Controls.Add(_host);
            _host.Size = new System.Drawing.Size(290, 576);

            _host.Controls.Add(this.btnShowReport);
            _host.Controls.Add(this.btnHideReport);
            _host.Controls.Add(this.tvReports);
            _host.Controls.Add(this.btnOpen);
            _host.Controls.Add(this.chkSearchToolBar);
            _host.Controls.Add(this.gbLogin);
            _host.Controls.Add(this.tbSSRSServer);
            _host.Controls.Add(this.label1);

            _ssrsPanel.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left;
            _ssrsPanel.KeepRelativeSize = false;
            _ssrsPanel.MinWidth = 210;
            _ssrsPanel.ShowCloseButton = true;
            _ssrsPanel.Text = "SSRS Source Configuration";
            _ssrsPanel.Width = 236;
            _ssrsPanel.CloseButtonClick += SsrsPanel_CloseButtonClick;
            _ssrsPanel.VisibleChanged += SsrsPanel_VisibleChanged;
            _ssrsPanel.SizeChanged += SsrsPanel_SizeChanged;

            // 
            // btnShowReport
            // 
            btnShowReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnShowReport.Location = new System.Drawing.Point(194, 547);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(89, 23);
            this.btnShowReport.TabIndex = 7;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // btnHideReport
            // 
            btnHideReport.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnHideReport.Enabled = false;
            this.btnHideReport.Location = new System.Drawing.Point(8, 547);
            this.btnHideReport.Name = "btnHideReport";
            this.btnHideReport.Size = new System.Drawing.Size(89, 23);
            this.btnHideReport.TabIndex = 6;
            this.btnHideReport.Text = "Hide Report";
            this.btnHideReport.UseVisualStyleBackColor = true;
            this.btnHideReport.Click += new System.EventHandler(this.btnHideReport_Click);
            // 
            // tvReports
            // 
            tvReports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.tvReports.HideSelection = false;
            this.tvReports.ImageIndex = 0;
            this.tvReports.ImageList = this.ilMain;
            this.tvReports.Location = new System.Drawing.Point(8, 193);
            this.tvReports.Name = "tvReports";
            this.tvReports.SelectedImageIndex = 0;
            this.tvReports.Size = new System.Drawing.Size(275, 348);
            this.tvReports.TabIndex = 5;
            this.tvReports.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(tvReports_AfterSelect);
            this.tvReports.DoubleClick += new System.EventHandler(this.tvReports_DoubleClick);
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnOpen.Location = new System.Drawing.Point(208, 164);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // chkSearchToolBar
            // 
            this.chkSearchToolBar.AutoSize = true;
            this.chkSearchToolBar.Checked = true;
            this.chkSearchToolBar.Location = new System.Drawing.Point(8, 167);
            this.chkSearchToolBar.Name = "chkSearchToolBar";
            this.chkSearchToolBar.Size = new System.Drawing.Size(127, 19);
            this.chkSearchToolBar.TabIndex = 3;
            this.chkSearchToolBar.Text = "Use Search ToolBar";
            this.chkSearchToolBar.UseVisualStyleBackColor = true;
            this.chkSearchToolBar.Click += new System.EventHandler(this.chkSearchToolBar_Click);
            // 
            // gbLogin
            // 
            gbLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.gbLogin.Controls.Add(this.tbDomain);
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Controls.Add(this.tbUserName);
            this.gbLogin.Controls.Add(this.label4);
            this.gbLogin.Controls.Add(this.label3);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Location = new System.Drawing.Point(8, 53);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(274, 105);
            this.gbLogin.TabIndex = 2;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = " Login information ";
            // 
            // tbDomain
            // 
            tbDomain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.tbDomain.Location = new System.Drawing.Point(80, 73);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.Size = new System.Drawing.Size(184, 23);
            this.tbDomain.TabIndex = 5;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.tbPassword.Location = new System.Drawing.Point(80, 47);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(184, 23);
            this.tbPassword.TabIndex = 3;
            // 
            // tbUserName
            // 
            tbUserName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.tbUserName.Location = new System.Drawing.Point(80, 21);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(184, 23);
            this.tbUserName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Domain:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name:";
            // 
            // tbSSRSServer
            // 
            tbSSRSServer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.tbSSRSServer.Location = new System.Drawing.Point(8, 25);
            this.tbSSRSServer.Name = "tbSSRSServer";
            this.tbSSRSServer.Size = new System.Drawing.Size(275, 23);
            this.tbSSRSServer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "SSRS Server:";

            c1RibbonPreview1.SplitContainer.Panels.Insert(0, _ssrsPanel);
        }
    }
}
