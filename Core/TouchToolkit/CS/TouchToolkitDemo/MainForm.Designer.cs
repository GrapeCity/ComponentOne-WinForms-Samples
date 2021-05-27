namespace TouchToolkitDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
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
            this.firstView = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkInfo = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treemenu = new TouchToolkitDemo.MyTreeView();
            this.pnlSample = new System.Windows.Forms.Panel();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // firstView
            // 
            this.firstView.AutoSize = true;
            this.firstView.Dock = System.Windows.Forms.DockStyle.Left;
            this.firstView.ForeColor = System.Drawing.Color.SkyBlue;
            this.firstView.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstView.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.firstView.Location = new System.Drawing.Point(0, 0);
            this.firstView.Name = "firstView";
            this.firstView.TabIndex = 1;
            this.firstView.TabStop = true;
            this.firstView.Text = "Home";
            this.firstView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.chkInfo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.firstView);                      
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 68);
            this.panel1.TabIndex = 1;
            // 
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(61, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "label2";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkInfo
            // 
            this.chkInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkInfo.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkInfo.AutoSize = true;
            this.chkInfo.BackColor = System.Drawing.SystemColors.Window;
            this.chkInfo.Checked = true;
            this.chkInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkInfo.FlatAppearance.BorderSize = 0;
            this.chkInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            this.chkInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.chkInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.chkInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkInfo.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F);
            this.chkInfo.Location = new System.Drawing.Point(593, 0);
            this.chkInfo.Name = "chkInfo";
            this.chkInfo.Size = new System.Drawing.Size(75, 65);
            this.chkInfo.TabIndex = 1;
            this.chkInfo.Text = "❔";
            this.chkInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkInfo.UseVisualStyleBackColor = false;
            this.chkInfo.CheckedChanged += new System.EventHandler(this.chkInfo_CheckedChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SkyBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 67);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(668, 1);
            this.panel4.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treemenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlSample);
            this.splitContainer1.Panel2.Controls.Add(this.pnlDescription);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 784);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 2;
            // 
            // treemenu
            // 
            this.treemenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treemenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treemenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.treemenu.ForeColor = System.Drawing.Color.DimGray;
            this.treemenu.HideSelection = false;
            this.treemenu.Location = new System.Drawing.Point(0, 0);
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
            this.treemenu.Size = new System.Drawing.Size(336, 784);
            this.treemenu.TabIndex = 1;
            this.treemenu.VisibleChanged += new System.EventHandler(this.treemenu_VisibleChanged);
            // 
            // pnlSample
            // 
            this.pnlSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSample.BackColor = System.Drawing.SystemColors.Window;
            this.pnlSample.Location = new System.Drawing.Point(0, 101);
            this.pnlSample.Name = "pnlSample";
            this.pnlSample.Size = new System.Drawing.Size(668, 683);
            this.pnlSample.TabIndex = 3;
            // 
            // pnlDescription
            // 
            this.pnlDescription.AutoSize = true;
            this.pnlDescription.BackColor = System.Drawing.SystemColors.Window;
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDescription.Location = new System.Drawing.Point(0, 68);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.pnlDescription.Size = new System.Drawing.Size(668, 33);
            this.pnlDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDescription.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.Location = new System.Drawing.Point(0, 4);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(668, 25);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;            
            this.ClientSize = new System.Drawing.Size(1008, 784);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(1008, 784);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiTouch for Windows Forms";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlDescription.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.LinkLabel firstView;
        private MyTreeView treemenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox chkInfo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnlSample;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
    }
}