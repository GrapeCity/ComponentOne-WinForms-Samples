namespace ControlExplorer.DynamicHelp
{
    partial class DynamicHelp
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
            C1.Win.C1DynamicHelp.MapItem mapItem1 = new C1.Win.C1DynamicHelp.MapItem();
            C1.Win.C1DynamicHelp.MapItem mapItem2 = new C1.Win.C1DynamicHelp.MapItem();
            C1.Win.C1DynamicHelp.MapItem mapItem3 = new C1.Win.C1DynamicHelp.MapItem();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Design time");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Runtime");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("How to use C1DynamicHelp", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.c1DynamicHelp1 = new C1.Win.C1DynamicHelp.C1DynamicHelp();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnBack = new System.Windows.Forms.ToolStripButton();
            this.btnForward = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAuthoringMode = new System.Windows.Forms.ToolStripButton();
            this.btnContents = new System.Windows.Forms.ToolStripButton();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPin = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            mapItem1.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.Enter;
            mapItem1.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem1.ShowDefaultTopicFirst = true;
            mapItem1.UIElement = this.textBox1;
            mapItem1.Url = "WordDocuments/designtimesupport.htm";
            mapItem1.UseDefaultTrigger = false;
            this.c1DynamicHelp1.SetHelpTopic(this.textBox1, mapItem1);
            this.textBox1.Location = new System.Drawing.Point(12, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Show topic on focus";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            mapItem2.HelpTopicTrigger = ((C1.Win.C1DynamicHelp.HelpTopicTrigger)((C1.Win.C1DynamicHelp.HelpTopicTrigger.Enter | C1.Win.C1DynamicHelp.HelpTopicTrigger.MouseEnter)));
            mapItem2.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem2.ShowDefaultTopicFirst = true;
            mapItem2.UIElement = this.linkLabel1;
            mapItem2.Url = "WordDocuments/glossaryofterms.htm";
            mapItem2.UseDefaultTrigger = false;
            this.c1DynamicHelp1.SetHelpTopic(this.linkLabel1, mapItem2);
            this.linkLabel1.Location = new System.Drawing.Point(12, 307);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(127, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "What is Authoring Mode?";
            // 
            // button1
            // 
            mapItem3.HelpTopicTrigger = C1.Win.C1DynamicHelp.HelpTopicTrigger.MouseEnter;
            mapItem3.ItemType = C1.Win.C1DynamicHelp.MapItemType.Static;
            mapItem3.ShowDefaultTopicFirst = true;
            mapItem3.UIElement = this.button1;
            mapItem3.Url = "WordDocuments/runtimesupport.htm";
            mapItem3.UseDefaultTrigger = true;
            this.c1DynamicHelp1.SetHelpTopic(this.button1, mapItem3);
            this.button1.Location = new System.Drawing.Point(12, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Show topic on mouse hover";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DynamicHelp1.SetHelpTopic(this.splitContainer1, null);
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.linkLabel1);
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.c1DynamicHelp1.SetHelpTopic(this.splitContainer1.Panel1, null);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1DynamicHelp1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.c1DynamicHelp1.SetHelpTopic(this.splitContainer1.Panel2, null);
            this.splitContainer1.Size = new System.Drawing.Size(592, 446);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.c1DynamicHelp1.SetHelpTopic(this.checkBox1, null);
            this.checkBox1.Location = new System.Drawing.Point(15, 144);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Show topic programmatically";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // treeView1
            // 
            this.c1DynamicHelp1.SetHelpTopic(this.treeView1, null);
            this.treeView1.Location = new System.Drawing.Point(12, 182);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Design time";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Runtime";
            treeNode3.Name = "Node0";
            treeNode3.Text = "How to use C1DynamicHelp";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(167, 104);
            this.treeView1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1DynamicHelp1.SetHelpTopic(this.label1, null);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(266, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Point the mouse to the sample controls below to see help topics associated with t" +
                "hem.";
            // 
            // c1DynamicHelp1
            // 
            this.c1DynamicHelp1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1DynamicHelp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1DynamicHelp1.Location = new System.Drawing.Point(0, 25);
            this.c1DynamicHelp1.Name = "c1DynamicHelp1";
            this.c1DynamicHelp1.Size = new System.Drawing.Size(318, 419);
            this.c1DynamicHelp1.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.c1DynamicHelp1.SetHelpTopic(this.toolStrip1, null);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnBack,
            this.btnForward,
            this.toolStripSeparator1,
            this.btnAuthoringMode,
            this.btnContents,
            this.btnSearch,
            this.toolStripSeparator2,
            this.btnPin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(318, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // btnBack
            // 
            this.btnBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBack.Enabled = false;
            this.c1DynamicHelp1.SetHelpTopic(this.btnBack, null);
            this.btnBack.Image = global::ControlExplorer.Properties.Resources.HistoryBack;
            this.btnBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(23, 22);
            this.btnBack.Text = "Go Back";
            // 
            // btnForward
            // 
            this.btnForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnForward.Enabled = false;
            this.c1DynamicHelp1.SetHelpTopic(this.btnForward, null);
            this.btnForward.Image = global::ControlExplorer.Properties.Resources.HistoryForward;
            this.btnForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(23, 22);
            this.btnForward.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            this.c1DynamicHelp1.SetHelpTopic(this.toolStripSeparator1, null);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAuthoringMode
            // 
            this.btnAuthoringMode.CheckOnClick = true;
            this.c1DynamicHelp1.SetHelpTopic(this.btnAuthoringMode, null);
            this.btnAuthoringMode.Image = global::ControlExplorer.Properties.Resources.Edit;
            this.btnAuthoringMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAuthoringMode.Name = "btnAuthoringMode";
            this.btnAuthoringMode.Size = new System.Drawing.Size(64, 22);
            this.btnAuthoringMode.Text = "Author";
            this.btnAuthoringMode.ToolTipText = "Authoring Mode";
            this.btnAuthoringMode.CheckedChanged += new System.EventHandler(this.btnAuthoringMode_CheckedChanged);
            // 
            // btnContents
            // 
            this.c1DynamicHelp1.SetHelpTopic(this.btnContents, null);
            this.btnContents.Image = global::ControlExplorer.Properties.Resources.Contents;
            this.btnContents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnContents.Name = "btnContents";
            this.btnContents.Size = new System.Drawing.Size(75, 22);
            this.btnContents.Text = "Contents";
            // 
            // btnSearch
            // 
            this.c1DynamicHelp1.SetHelpTopic(this.btnSearch, null);
            this.btnSearch.Image = global::ControlExplorer.Properties.Resources.Zoom;
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 22);
            this.btnSearch.Text = "Search";
            // 
            // toolStripSeparator2
            // 
            this.c1DynamicHelp1.SetHelpTopic(this.toolStripSeparator2, null);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnPin
            // 
            this.btnPin.CheckOnClick = true;
            this.btnPin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.c1DynamicHelp1.SetHelpTopic(this.btnPin, null);
            this.btnPin.Image = global::ControlExplorer.Properties.Resources.Unpinned;
            this.btnPin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPin.Name = "btnPin";
            this.btnPin.Size = new System.Drawing.Size(23, 22);
            this.btnPin.Text = "Fix Topic";
            this.btnPin.CheckedChanged += new System.EventHandler(this.btnPin_CheckedChanged);
            // 
            // DynamicHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.splitContainer1);
            this.c1DynamicHelp1.SetHelpTopic(this, null);
            this.Name = "DynamicHelp";
            this.Text = "Overview";
            this.Load += new System.EventHandler(this.DynamicHelp_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnBack;
        private System.Windows.Forms.ToolStripButton btnForward;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnContents;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnPin;
        private C1.Win.C1DynamicHelp.C1DynamicHelp c1DynamicHelp1;
        private System.Windows.Forms.ToolStripButton btnAuthoringMode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}