namespace TouchToolkitDemo
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Basic (Zoom and Scroll)");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ControlBar");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Show Control");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Pan Window");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Zoom Policy");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Misc");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("C1Zoom", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Basic (Zoom and Scroll)");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("C1ZoomPanel", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Multiple window Business app example with the Component");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("C1ApplicationZoom", new System.Windows.Forms.TreeNode[] {
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("C1Magnify");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Compare PictureBox and C1MultiScaleImage");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("C1MultiScaleImage", new System.Windows.Forms.TreeNode[] {
            treeNode13});
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Touch Events Listener");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("ContextualUI");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("AutoRepeat");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("ImageViewer");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Drawing Board for Pen");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("C1TouchEventProvider", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.cube = new System.Windows.Forms.PictureBox();
            this.firstView = new System.Windows.Forms.LinkLabel();
            this.product_title = new System.Windows.Forms.Label();
            this.product_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myTabControl1 = new TouchToolkitDemo.MyTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treemenu = new TouchToolkitDemo.MyTreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.searchlist = new System.Windows.Forms.ListBox();
            this.searchtext = new System.Windows.Forms.TextBox();
            this.menuheader = new System.Windows.Forms.PictureBox();
            this.product_info = new System.Windows.Forms.LinkLabel();
            this.copyright = new System.Windows.Forms.Label();
            this.mescius_logo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.myTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuheader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mescius_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            this.splitContainer2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackgroundImage = global::TouchToolkitDemo.Properties.Resources.header_b;
            this.splitContainer2.Panel1.Controls.Add(this.cube);
            this.splitContainer2.Panel1.Controls.Add(this.firstView);
            this.splitContainer2.Panel1.Controls.Add(this.product_title);
            this.splitContainer2.Panel1.Controls.Add(this.product_logo);
            this.splitContainer2.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(1008, 690);
            this.splitContainer2.SplitterDistance = 80;
            this.splitContainer2.SplitterWidth = 6;
            this.splitContainer2.TabIndex = 0;
            // 
            // cube
            // 
            this.cube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cube.BackgroundImage = global::TouchToolkitDemo.Properties.Resources.cube;
            this.cube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cube.Location = new System.Drawing.Point(12, 4);
            this.cube.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cube.Name = "cube";
            this.cube.Size = new System.Drawing.Size(72, 74);
            this.cube.TabIndex = 8;
            this.cube.TabStop = false;
            // 
            // firstView
            // 
            this.firstView.ActiveLinkColor = System.Drawing.Color.White;
            this.firstView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.firstView.AutoSize = true;
            this.firstView.DisabledLinkColor = System.Drawing.Color.White;
            this.firstView.Font = new System.Drawing.Font("Meiryo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.firstView.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.firstView.LinkColor = System.Drawing.Color.White;
            this.firstView.Location = new System.Drawing.Point(659, 48);
            this.firstView.Name = "firstView";
            this.firstView.Size = new System.Drawing.Size(71, 20);
            this.firstView.TabIndex = 1;
            this.firstView.TabStop = true;
            this.firstView.Text = "Introduce";
            this.firstView.VisitedLinkColor = System.Drawing.Color.White;
            // 
            // product_title
            // 
            this.product_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.product_title.AutoSize = true;
            this.product_title.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.product_title.ForeColor = System.Drawing.Color.White;
            this.product_title.Location = new System.Drawing.Point(277, 45);
            this.product_title.Name = "product_title";
            this.product_title.Size = new System.Drawing.Size(174, 24);
            this.product_title.TabIndex = 0;
            this.product_title.Text = "for Windows Forms";
            // 
            // product_logo
            // 
            this.product_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.product_logo.BackgroundImage = global::TouchToolkitDemo.Properties.Resources.product_logo;
            this.product_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.product_logo.Location = new System.Drawing.Point(90, 20);
            this.product_logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.product_logo.Name = "product_logo";
            this.product_logo.Size = new System.Drawing.Size(181, 49);
            this.product_logo.TabIndex = 1;
            this.product_logo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TouchToolkitDemo.Properties.Resources.header_g;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 80);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitContainer1);
            this.splitContainer3.Panel1.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.BackgroundImage = global::TouchToolkitDemo.Properties.Resources.fotter;
            this.splitContainer3.Panel2.Controls.Add(this.product_info);
            this.splitContainer3.Panel2.Controls.Add(this.copyright);
            this.splitContainer3.Panel2.Controls.Add(this.mescius_logo);
            this.splitContainer3.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer3.Size = new System.Drawing.Size(1008, 604);
            this.splitContainer3.SplitterDistance = 519;
            this.splitContainer3.SplitterWidth = 6;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(7, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.menuheader);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1001, 519);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.myTabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 7, 7, 5);
            this.panel1.Size = new System.Drawing.Size(253, 481);
            this.panel1.TabIndex = 0;
            // 
            // myTabControl1
            // 
            this.myTabControl1.Controls.Add(this.tabPage1);
            this.myTabControl1.Controls.Add(this.tabPage2);
            this.myTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myTabControl1.Location = new System.Drawing.Point(7, 7);
            this.myTabControl1.Name = "myTabControl1";
            this.myTabControl1.SelectedIndex = 0;
            this.myTabControl1.Size = new System.Drawing.Size(239, 469);
            this.myTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treemenu);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(231, 438);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Features";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treemenu
            // 
            this.treemenu.BackColor = System.Drawing.Color.White;
            this.treemenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treemenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treemenu.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.treemenu.ForeColor = System.Drawing.Color.Black;
            this.treemenu.HideSelection = false;
            this.treemenu.Indent = 15;
            this.treemenu.ItemHeight = 25;
            this.treemenu.Location = new System.Drawing.Point(3, 3);
            this.treemenu.Name = "treemenu";
            treeNode1.Name = "Node4";
            treeNode1.Tag = "C1Zoom";
            treeNode1.Text = "Basic (Zoom and Scroll)";
            treeNode2.Name = "Node7";
            treeNode2.Text = "ControlBar";
            treeNode3.Name = "Node8";
            treeNode3.Text = "Show Control";
            treeNode4.Name = "Node0";
            treeNode4.Text = "Pan Window";
            treeNode5.Name = "Node2";
            treeNode5.Text = "Zoom Policy";
            treeNode6.Name = "Node0";
            treeNode6.Text = "Misc";
            treeNode7.Name = "Node0";
            treeNode7.Text = "C1Zoom";
            treeNode8.Name = "Node3";
            treeNode8.Tag = "C1ZoomPanel";
            treeNode8.Text = "Basic (Zoom and Scroll)";
            treeNode9.Name = "Node1";
            treeNode9.Text = "C1ZoomPanel";
            treeNode10.Name = "Node4";
            treeNode10.Text = "Multiple window Business app example with the Component";
            treeNode11.Name = "Node2";
            treeNode11.Text = "C1ApplicationZoom";
            treeNode12.Name = "Node1";
            treeNode12.Text = "C1Magnify";
            treeNode13.Name = "Node0";
            treeNode13.Text = "Compare PictureBox and C1MultiScaleImage";
            treeNode14.Name = "Node2";
            treeNode14.Text = "C1MultiScaleImage";
            treeNode15.Name = "Node9";
            treeNode15.Text = "Touch Events Listener";
            treeNode16.Name = "Node10";
            treeNode16.Text = "ContextualUI";
            treeNode17.Name = "Node12";
            treeNode17.Text = "AutoRepeat";
            treeNode18.Name = "Node11";
            treeNode18.Text = "ImageViewer";
            treeNode19.Name = "Node2";
            treeNode19.Text = "Drawing Board for Pen";
            treeNode20.Name = "Node3";
            treeNode20.Text = "C1TouchEventProvider";
            this.treemenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode9,
            treeNode11,
            treeNode12,
            treeNode14,
            treeNode20});
            this.treemenu.Size = new System.Drawing.Size(225, 432);
            this.treemenu.TabIndex = 1;
            this.treemenu.VisibleChanged += new System.EventHandler(this.treemenu_VisibleChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.searchlist);
            this.tabPage2.Controls.Add(this.searchtext);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(231, 443);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Indexes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search:";
            // 
            // searchlist
            // 
            this.searchlist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchlist.BackColor = System.Drawing.Color.White;
            this.searchlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchlist.ForeColor = System.Drawing.Color.Black;
            this.searchlist.FormattingEnabled = true;
            this.searchlist.ItemHeight = 18;
            this.searchlist.Location = new System.Drawing.Point(9, 38);
            this.searchlist.Name = "searchlist";
            this.searchlist.Size = new System.Drawing.Size(216, 252);
            this.searchlist.TabIndex = 5;
            // 
            // searchtext
            // 
            this.searchtext.Location = new System.Drawing.Point(79, 7);
            this.searchtext.Name = "searchtext";
            this.searchtext.Size = new System.Drawing.Size(146, 25);
            this.searchtext.TabIndex = 4;
            // 
            // menuheader
            // 
            this.menuheader.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuheader.Image = global::TouchToolkitDemo.Properties.Resources.menuheader;
            this.menuheader.Location = new System.Drawing.Point(0, 0);
            this.menuheader.Name = "menuheader";
            this.menuheader.Size = new System.Drawing.Size(253, 38);
            this.menuheader.TabIndex = 1;
            this.menuheader.TabStop = false;
            // 
            // product_info
            // 
            this.product_info.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.product_info.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.product_info.Dock = System.Windows.Forms.DockStyle.Right;
            this.product_info.Font = new System.Drawing.Font("Meiryo", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.product_info.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.product_info.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.product_info.Location = new System.Drawing.Point(903, 0);
            this.product_info.Name = "product_info";
            this.product_info.Size = new System.Drawing.Size(105, 79);
            this.product_info.TabIndex = 1;
            this.product_info.TabStop = true;
            this.product_info.Text = "Product Info.";
            this.product_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.product_info.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            // 
            // copyright
            // 
            this.copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.copyright.AutoSize = true;
            this.copyright.Font = new System.Drawing.Font("Meiryo", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copyright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.copyright.Location = new System.Drawing.Point(173, -90);
            this.copyright.Name = "copyright";
            this.copyright.Size = new System.Drawing.Size(213, 17);
            this.copyright.TabIndex = 0;
            this.copyright.Text = "© Mescius, Inc. All rights reserved.";
            // 
            // mescius_logo
            // 
            this.mescius_logo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mescius_logo.BackgroundImage = global::TouchToolkitDemo.Properties.Resources.mescius_logo;
            this.mescius_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mescius_logo.Location = new System.Drawing.Point(12, -98);
            this.mescius_logo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mescius_logo.Name = "mescius_logo";
            this.mescius_logo.Size = new System.Drawing.Size(155, 29);
            this.mescius_logo.TabIndex = 6;
            this.mescius_logo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1008, 79);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1008, 690);
            this.Controls.Add(this.splitContainer2);
            this.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1024, 729);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiTouch for Windows Forms 1.0J Demonstration";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.myTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuheader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mescius_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox product_logo;
        private System.Windows.Forms.Label product_title;
        private System.Windows.Forms.LinkLabel firstView;
        private System.Windows.Forms.PictureBox cube;
        private System.Windows.Forms.Label copyright;
        private System.Windows.Forms.PictureBox mescius_logo;
        private System.Windows.Forms.LinkLabel product_info;
        private System.Windows.Forms.PictureBox menuheader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MyTabControl myTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MyTreeView treemenu;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox searchlist;
        private System.Windows.Forms.TextBox searchtext;
    }
}

