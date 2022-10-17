namespace SsrsViewer
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.connPanel = new System.Windows.Forms.Panel();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.btnHideReport = new System.Windows.Forms.Button();
            this.tvReports = new System.Windows.Forms.TreeView();
            this.ilMain = new System.Windows.Forms.ImageList(this.components);
            this.btnOpen = new System.Windows.Forms.Button();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.tbDomain = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSSRSServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spMain = new System.Windows.Forms.Splitter();
            this.c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            this.c1SsrsDocumentSource1 = new C1.Win.Document.C1SSRSDocumentSource();
            this.bwListReports = new System.ComponentModel.BackgroundWorker();
            this.connPanel.SuspendLayout();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // connPanel
            // 
            this.connPanel.Controls.Add(this.btnShowReport);
            this.connPanel.Controls.Add(this.btnHideReport);
            this.connPanel.Controls.Add(this.tvReports);
            this.connPanel.Controls.Add(this.btnOpen);
            this.connPanel.Controls.Add(this.gbLogin);
            this.connPanel.Controls.Add(this.tbSSRSServer);
            this.connPanel.Controls.Add(this.label1);
            this.connPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.connPanel.Location = new System.Drawing.Point(0, 0);
            this.connPanel.Name = "connPanel";
            this.connPanel.Size = new System.Drawing.Size(290, 602);
            this.connPanel.TabIndex = 0;
            // 
            // btnShowReport
            // 
            this.btnShowReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowReport.Location = new System.Drawing.Point(194, 573);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(89, 23);
            this.btnShowReport.TabIndex = 7;
            this.btnShowReport.Text = "Show Report";
            this.btnShowReport.UseVisualStyleBackColor = true;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // btnHideReport
            // 
            this.btnHideReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHideReport.Enabled = false;
            this.btnHideReport.Location = new System.Drawing.Point(8, 573);
            this.btnHideReport.Name = "btnHideReport";
            this.btnHideReport.Size = new System.Drawing.Size(89, 23);
            this.btnHideReport.TabIndex = 6;
            this.btnHideReport.Text = "Hide Report";
            this.btnHideReport.UseVisualStyleBackColor = true;
            this.btnHideReport.Click += new System.EventHandler(this.btnHideReport_Click);
            // 
            // tvReports
            // 
            this.tvReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvReports.HideSelection = false;
            this.tvReports.ImageIndex = 0;
            this.tvReports.ImageList = this.ilMain;
            this.tvReports.Location = new System.Drawing.Point(8, 193);
            this.tvReports.Name = "tvReports";
            this.tvReports.SelectedImageIndex = 0;
            this.tvReports.Size = new System.Drawing.Size(275, 374);
            this.tvReports.TabIndex = 5;
            this.tvReports.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvReports_AfterSelect);
            this.tvReports.DoubleClick += new System.EventHandler(this.tvReports_DoubleClick);
            // 
            // ilMain
            // 
            this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
            this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMain.Images.SetKeyName(0, "Folder.png");
            this.ilMain.Images.SetKeyName(1, "CreateReportBlankReport.png");
            this.ilMain.Images.SetKeyName(2, "RecurrenceEdit.png");
            this.ilMain.Images.SetKeyName(3, "Connection.png");
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(208, 164);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.gbLogin.Text = " Login information: ";
            // 
            // tbDomain
            // 
            this.tbDomain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDomain.Location = new System.Drawing.Point(80, 73);
            this.tbDomain.Name = "tbDomain";
            this.tbDomain.Size = new System.Drawing.Size(184, 23);
            this.tbDomain.TabIndex = 5;
            // 
            // tbPassword
            // 
            this.tbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPassword.Location = new System.Drawing.Point(80, 47);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(184, 23);
            this.tbPassword.TabIndex = 3;
            // 
            // tbUserName
            // 
            this.tbUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tbSSRSServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // 
            // spMain
            // 
            this.spMain.BackColor = System.Drawing.Color.LightGray;
            this.spMain.Location = new System.Drawing.Point(290, 0);
            this.spMain.Name = "spMain";
            this.spMain.Size = new System.Drawing.Size(4, 602);
            this.spMain.TabIndex = 1;
            this.spMain.TabStop = false;
            // 
            // c1FlexViewer1
            // 
            this.c1FlexViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexViewer1.Location = new System.Drawing.Point(294, 0);
            this.c1FlexViewer1.Name = "c1FlexViewer1";
            this.c1FlexViewer1.Size = new System.Drawing.Size(760, 602);
            this.c1FlexViewer1.TabIndex = 0;
            this.c1FlexViewer1.PropertyChanged += new System.ComponentModel.PropertyChangedEventHandler(this.PreviewPane_PropertyChanged);
            // 
            // c1SsrsDocumentSource1
            // 
            this.c1SsrsDocumentSource1.Language = new System.Globalization.CultureInfo("en-US");
            this.c1SsrsDocumentSource1.BusyStateChanged += new System.EventHandler(this.SsrsDocumentSource_BusyStateChanged);
            this.c1SsrsDocumentSource1.PageCountChanged += new System.EventHandler(this.SsrsDocumentSource_PageCountChanged);
            this.c1SsrsDocumentSource1.SecurityError += new C1.Win.Document.SecurityErrorEventHandler(this.SsrsDocumentSource_SecurityError);
            // 
            // bwListReports
            // 
            this.bwListReports.WorkerSupportsCancellation = true;
            this.bwListReports.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwListReports_DoWork);
            this.bwListReports.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwListReports_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1054, 602);
            this.Controls.Add(this.c1FlexViewer1);
            this.Controls.Add(this.spMain);
            this.Controls.Add(this.connPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SSRS Report Viewer";
            this.connPanel.ResumeLayout(false);
            this.connPanel.PerformLayout();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel connPanel;
        private System.Windows.Forms.Splitter spMain;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.TextBox tbDomain;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSSRSServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TreeView tvReports;
        private System.Windows.Forms.ImageList ilMain;
        private System.ComponentModel.BackgroundWorker bwListReports;
        private System.Windows.Forms.Button btnHideReport;
        private System.Windows.Forms.Button btnShowReport;
        private C1.Win.Document.C1SSRSDocumentSource c1SsrsDocumentSource1;
        private C1.Win.FlexViewer.C1FlexViewer c1FlexViewer1;
    }
}

