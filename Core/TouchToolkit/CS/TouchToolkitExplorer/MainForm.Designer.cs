namespace TouchToolkitExplorer
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
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("C1Zoom", new System.Windows.Forms.TreeNode[] { treeNode1, treeNode2, treeNode3, treeNode4, treeNode5, treeNode6 });
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Basic (Zoom and Scroll)");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("C1ZoomPanel", new System.Windows.Forms.TreeNode[] { treeNode8 });
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Multiple window Business app example with the Component");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("C1ApplicationZoom", new System.Windows.Forms.TreeNode[] { treeNode10 });
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("C1Magnify");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Compare PictureBox and C1MultiScaleImage");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("C1MultiScaleImage", new System.Windows.Forms.TreeNode[] { treeNode13 });
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Touch Events Listener");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("ContextualUI");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("AutoRepeat");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("ImageViewer");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Drawing Board for Pen");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("C1TouchEventProvider", new System.Windows.Forms.TreeNode[] { treeNode15, treeNode16, treeNode17, treeNode18, treeNode19 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            firstView = new System.Windows.Forms.LinkLabel();
            panel1 = new System.Windows.Forms.Panel();
            chkInfo = new System.Windows.Forms.CheckBox();
            lblTitle = new System.Windows.Forms.Label();
            panel4 = new System.Windows.Forms.Panel();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            treemenu = new MyTreeView();
            pnlSample = new System.Windows.Forms.Panel();
            pnlDescription = new System.Windows.Forms.Panel();
            lblDescription = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            pnlDescription.SuspendLayout();
            SuspendLayout();
            // 
            // firstView
            // 
            firstView.AutoSize = true;
            firstView.Dock = System.Windows.Forms.DockStyle.Left;
            firstView.Font = new System.Drawing.Font("Calibri", 27.75F);
            firstView.ForeColor = System.Drawing.Color.SkyBlue;
            firstView.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            firstView.Location = new System.Drawing.Point(0, 0);
            firstView.Name = "firstView";
            firstView.Size = new System.Drawing.Size(111, 45);
            firstView.TabIndex = 1;
            firstView.TabStop = true;
            firstView.Text = "Home";
            firstView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = System.Drawing.SystemColors.Window;
            panel1.Controls.Add(chkInfo);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(firstView);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(668, 50);
            panel1.TabIndex = 1;
            // 
            // chkInfo
            // 
            chkInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            chkInfo.Appearance = System.Windows.Forms.Appearance.Button;
            chkInfo.AutoSize = true;
            chkInfo.BackColor = System.Drawing.SystemColors.Window;
            chkInfo.Checked = true;
            chkInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            chkInfo.FlatAppearance.BorderSize = 0;
            chkInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSkyBlue;
            chkInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            chkInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            chkInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            chkInfo.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F);
            chkInfo.Location = new System.Drawing.Point(614, 0);
            chkInfo.Name = "chkInfo";
            chkInfo.Size = new System.Drawing.Size(54, 47);
            chkInfo.TabIndex = 1;
            chkInfo.Text = "❔";
            chkInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            chkInfo.UseVisualStyleBackColor = false;
            chkInfo.CheckedChanged += chkInfo_CheckedChanged;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F);
            lblTitle.ForeColor = System.Drawing.Color.SkyBlue;
            lblTitle.Location = new System.Drawing.Point(111, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            lblTitle.Size = new System.Drawing.Size(150, 45);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "label2";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = System.Drawing.Color.SkyBlue;
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(0, 50);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(668, 1);
            panel4.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(treemenu);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlSample);
            splitContainer1.Panel2.Controls.Add(pnlDescription);
            splitContainer1.Panel2.Controls.Add(panel4);
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new System.Drawing.Size(1008, 784);
            splitContainer1.SplitterDistance = 336;
            splitContainer1.TabIndex = 2;
            // 
            // treemenu
            // 
            treemenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            treemenu.Dock = System.Windows.Forms.DockStyle.Fill;
            treemenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            treemenu.ForeColor = System.Drawing.Color.DimGray;
            treemenu.HideSelection = false;
            treemenu.Location = new System.Drawing.Point(0, 0);
            treemenu.Name = "treemenu";
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
            treemenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] { treeNode7, treeNode9, treeNode11, treeNode12, treeNode14, treeNode20 });
            treemenu.Size = new System.Drawing.Size(336, 784);
            treemenu.TabIndex = 1;
            treemenu.VisibleChanged += treemenu_VisibleChanged;
            // 
            // pnlSample
            // 
            pnlSample.BackColor = System.Drawing.SystemColors.Window;
            pnlSample.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlSample.Location = new System.Drawing.Point(0, 84);
            pnlSample.Name = "pnlSample";
            pnlSample.Size = new System.Drawing.Size(668, 700);
            pnlSample.TabIndex = 3;
            // 
            // pnlDescription
            // 
            pnlDescription.AutoSize = true;
            pnlDescription.BackColor = System.Drawing.SystemColors.Window;
            pnlDescription.Controls.Add(lblDescription);
            pnlDescription.Dock = System.Windows.Forms.DockStyle.Top;
            pnlDescription.Location = new System.Drawing.Point(0, 51);
            pnlDescription.Name = "pnlDescription";
            pnlDescription.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            pnlDescription.Size = new System.Drawing.Size(668, 33);
            pnlDescription.TabIndex = 2;
            // 
            // lblDescription
            // 
            lblDescription.Dock = System.Windows.Forms.DockStyle.Top;
            lblDescription.Font = new System.Drawing.Font("Calibri", 14.25F);
            lblDescription.Location = new System.Drawing.Point(0, 4);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(668, 25);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1008, 784);
            Controls.Add(splitContainer1);
            Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            MinimumSize = new System.Drawing.Size(1008, 784);
            Name = "MainForm";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "MultiTouch for Windows Forms";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            pnlDescription.ResumeLayout(false);
            ResumeLayout(false);
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