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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            connPanel = new System.Windows.Forms.Panel();
            btnShowReport = new System.Windows.Forms.Button();
            btnHideReport = new System.Windows.Forms.Button();
            tvReports = new System.Windows.Forms.TreeView();
            ilMain = new System.Windows.Forms.ImageList(components);
            btnOpen = new System.Windows.Forms.Button();
            gbLogin = new System.Windows.Forms.GroupBox();
            tbDomain = new System.Windows.Forms.TextBox();
            tbPassword = new System.Windows.Forms.TextBox();
            tbUserName = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            tbSSRSServer = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            spMain = new System.Windows.Forms.Splitter();
            c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            bwListReports = new System.ComponentModel.BackgroundWorker();
            connPanel.SuspendLayout();
            gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexViewer1).BeginInit();
            SuspendLayout();
            // 
            // connPanel
            // 
            connPanel.Controls.Add(btnShowReport);
            connPanel.Controls.Add(btnHideReport);
            connPanel.Controls.Add(tvReports);
            connPanel.Controls.Add(btnOpen);
            connPanel.Controls.Add(gbLogin);
            connPanel.Controls.Add(tbSSRSServer);
            connPanel.Controls.Add(label1);
            connPanel.Dock = System.Windows.Forms.DockStyle.Left;
            connPanel.Location = new System.Drawing.Point(0, 0);
            connPanel.Name = "connPanel";
            connPanel.Size = new System.Drawing.Size(290, 602);
            connPanel.TabIndex = 0;
            // 
            // btnShowReport
            // 
            btnShowReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btnShowReport.Location = new System.Drawing.Point(194, 573);
            btnShowReport.Name = "btnShowReport";
            btnShowReport.Size = new System.Drawing.Size(89, 23);
            btnShowReport.TabIndex = 7;
            btnShowReport.Text = "Show Report";
            btnShowReport.UseVisualStyleBackColor = true;
            btnShowReport.Click += btnShowReport_Click;
            // 
            // btnHideReport
            // 
            btnHideReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            btnHideReport.Enabled = false;
            btnHideReport.Location = new System.Drawing.Point(8, 573);
            btnHideReport.Name = "btnHideReport";
            btnHideReport.Size = new System.Drawing.Size(89, 23);
            btnHideReport.TabIndex = 6;
            btnHideReport.Text = "Hide Report";
            btnHideReport.UseVisualStyleBackColor = true;
            btnHideReport.Click += btnHideReport_Click;
            // 
            // tvReports
            // 
            tvReports.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tvReports.HideSelection = false;
            tvReports.ImageIndex = 0;
            tvReports.ImageList = ilMain;
            tvReports.Location = new System.Drawing.Point(8, 193);
            tvReports.Name = "tvReports";
            tvReports.SelectedImageIndex = 0;
            tvReports.Size = new System.Drawing.Size(275, 374);
            tvReports.TabIndex = 5;
            tvReports.AfterSelect += tvReports_AfterSelect;
            tvReports.DoubleClick += tvReports_DoubleClick;
            // 
            // ilMain
            // 
            ilMain.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            ilMain.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ilMain.ImageStream");
            ilMain.TransparentColor = System.Drawing.Color.Transparent;
            ilMain.Images.SetKeyName(0, "Folder.png");
            ilMain.Images.SetKeyName(1, "CreateReportBlankReport.png");
            ilMain.Images.SetKeyName(2, "RecurrenceEdit.png");
            ilMain.Images.SetKeyName(3, "Connection.png");
            // 
            // btnOpen
            // 
            btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btnOpen.Location = new System.Drawing.Point(208, 164);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new System.Drawing.Size(75, 23);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // gbLogin
            // 
            gbLogin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            gbLogin.Controls.Add(tbDomain);
            gbLogin.Controls.Add(tbPassword);
            gbLogin.Controls.Add(tbUserName);
            gbLogin.Controls.Add(label4);
            gbLogin.Controls.Add(label3);
            gbLogin.Controls.Add(label2);
            gbLogin.Location = new System.Drawing.Point(8, 53);
            gbLogin.Name = "gbLogin";
            gbLogin.Size = new System.Drawing.Size(274, 105);
            gbLogin.TabIndex = 2;
            gbLogin.TabStop = false;
            gbLogin.Text = " Login information: ";
            // 
            // tbDomain
            // 
            tbDomain.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbDomain.Location = new System.Drawing.Point(80, 73);
            tbDomain.Name = "tbDomain";
            tbDomain.Size = new System.Drawing.Size(184, 23);
            tbDomain.TabIndex = 5;
            // 
            // tbPassword
            // 
            tbPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbPassword.Location = new System.Drawing.Point(80, 47);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new System.Drawing.Size(184, 23);
            tbPassword.TabIndex = 3;
            // 
            // tbUserName
            // 
            tbUserName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbUserName.Location = new System.Drawing.Point(80, 21);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new System.Drawing.Size(184, 23);
            tbUserName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(6, 75);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(52, 15);
            label4.TabIndex = 4;
            label4.Text = "Domain:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(6, 49);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(60, 15);
            label3.TabIndex = 2;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(6, 23);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 15);
            label2.TabIndex = 0;
            label2.Text = "User Name:";
            // 
            // tbSSRSServer
            // 
            tbSSRSServer.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            tbSSRSServer.Location = new System.Drawing.Point(8, 25);
            tbSSRSServer.Name = "tbSSRSServer";
            tbSSRSServer.Size = new System.Drawing.Size(275, 23);
            tbSSRSServer.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "SSRS Server:";
            // 
            // spMain
            // 
            spMain.BackColor = System.Drawing.Color.LightGray;
            spMain.Location = new System.Drawing.Point(290, 0);
            spMain.Name = "spMain";
            spMain.Size = new System.Drawing.Size(4, 602);
            spMain.TabIndex = 1;
            spMain.TabStop = false;
            // 
            // c1FlexViewer1
            // 
            c1FlexViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            c1FlexViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            c1FlexViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1FlexViewer1.Location = new System.Drawing.Point(294, 0);
            c1FlexViewer1.Name = "c1FlexViewer1";
            c1FlexViewer1.Size = new System.Drawing.Size(760, 602);
            c1FlexViewer1.TabIndex = 0;
            c1FlexViewer1.PropertyChanged += PreviewPane_PropertyChanged;
            // 
            // bwListReports
            // 
            bwListReports.WorkerSupportsCancellation = true;
            bwListReports.DoWork += bwListReports_DoWork;
            bwListReports.RunWorkerCompleted += bwListReports_RunWorkerCompleted;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            ClientSize = new System.Drawing.Size(1054, 602);
            Controls.Add(c1FlexViewer1);
            Controls.Add(spMain);
            Controls.Add(connPanel);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "SSRS Report Viewer";
            connPanel.ResumeLayout(false);
            connPanel.PerformLayout();
            gbLogin.ResumeLayout(false);
            gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexViewer1).EndInit();
            ResumeLayout(false);

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
        private C1.Document.C1SSRSDocumentSource c1SsrsDocumentSource1;
        private C1.Win.FlexViewer.C1FlexViewer c1FlexViewer1;
    }
}

