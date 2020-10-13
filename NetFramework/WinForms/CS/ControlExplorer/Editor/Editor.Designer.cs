namespace ControlExplorer.Editor
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.C1Editor1 = new C1.Win.C1Editor.C1Editor();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.previewModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sourceModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.C1EditorToolStripMain1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain();
            this.c1EditorToolStripStyle1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripStyle();
            this.C1EditorToolStripTable1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripTable();
            this.C1EditorToolStripObjects1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects();
            this.c1SpellChecker1 = new C1.Win.C1SpellChecker.C1SpellChecker(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1Editor1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1SpellChecker1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.C1Editor1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(736, 346);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(736, 446);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.C1EditorToolStripMain1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.c1EditorToolStripStyle1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.C1EditorToolStripTable1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.C1EditorToolStripObjects1);
            // 
            // C1Editor1
            // 
            this.C1Editor1.BackColor = System.Drawing.SystemColors.Window;
            this.C1Editor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.C1Editor1.Location = new System.Drawing.Point(0, 0);
            this.C1Editor1.Name = "C1Editor1";
            this.C1Editor1.Size = new System.Drawing.Size(736, 324);
            this.C1Editor1.TabIndex = 1;
            this.C1Editor1.XmlExtensions = null;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 324);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(736, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previewModeToolStripMenuItem,
            this.sourceModeToolStripMenuItem,
            this.designModeToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(70, 20);
            this.toolStripSplitButton1.Text = "Mode";
            this.toolStripSplitButton1.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStripSplitButton1_DropDownItemClicked);
            // 
            // previewModeToolStripMenuItem
            // 
            this.previewModeToolStripMenuItem.CheckOnClick = true;
            this.previewModeToolStripMenuItem.Name = "previewModeToolStripMenuItem";
            this.previewModeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.previewModeToolStripMenuItem.Text = "Preview Mode";
            // 
            // sourceModeToolStripMenuItem
            // 
            this.sourceModeToolStripMenuItem.CheckOnClick = true;
            this.sourceModeToolStripMenuItem.Name = "sourceModeToolStripMenuItem";
            this.sourceModeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.sourceModeToolStripMenuItem.Text = "Source Mode";
            // 
            // designModeToolStripMenuItem
            // 
            this.designModeToolStripMenuItem.Checked = true;
            this.designModeToolStripMenuItem.CheckOnClick = true;
            this.designModeToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.designModeToolStripMenuItem.Name = "designModeToolStripMenuItem";
            this.designModeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.designModeToolStripMenuItem.Text = "Design Mode";
            // 
            // C1EditorToolStripMain1
            // 
            this.C1EditorToolStripMain1.Dock = System.Windows.Forms.DockStyle.None;
            this.C1EditorToolStripMain1.Editor = this.C1Editor1;
            this.C1EditorToolStripMain1.Location = new System.Drawing.Point(3, 0);
            this.C1EditorToolStripMain1.Name = "C1EditorToolStripMain1";
            this.C1EditorToolStripMain1.Size = new System.Drawing.Size(381, 25);
            this.C1EditorToolStripMain1.TabIndex = 0;
            this.C1EditorToolStripMain1.Text = "C1EditorToolStripMain1";
            // 
            // c1EditorToolStripStyle1
            // 
            this.c1EditorToolStripStyle1.Dock = System.Windows.Forms.DockStyle.None;
            this.c1EditorToolStripStyle1.Editor = this.C1Editor1;
            this.c1EditorToolStripStyle1.Location = new System.Drawing.Point(3, 25);
            this.c1EditorToolStripStyle1.Name = "c1EditorToolStripStyle1";
            this.c1EditorToolStripStyle1.Size = new System.Drawing.Size(725, 25);
            this.c1EditorToolStripStyle1.TabIndex = 4;
            this.c1EditorToolStripStyle1.Text = "c1EditorToolStripStyle1";
            // 
            // C1EditorToolStripTable1
            // 
            this.C1EditorToolStripTable1.Dock = System.Windows.Forms.DockStyle.None;
            this.C1EditorToolStripTable1.Editor = this.C1Editor1;
            this.C1EditorToolStripTable1.Location = new System.Drawing.Point(3, 50);
            this.C1EditorToolStripTable1.Name = "C1EditorToolStripTable1";
            this.C1EditorToolStripTable1.Size = new System.Drawing.Size(288, 25);
            this.C1EditorToolStripTable1.TabIndex = 3;
            this.C1EditorToolStripTable1.Text = "C1EditorToolStripTable1";
            // 
            // C1EditorToolStripObjects1
            // 
            this.C1EditorToolStripObjects1.Dock = System.Windows.Forms.DockStyle.None;
            this.C1EditorToolStripObjects1.Editor = this.C1Editor1;
            this.C1EditorToolStripObjects1.Location = new System.Drawing.Point(23, 75);
            this.C1EditorToolStripObjects1.Name = "C1EditorToolStripObjects1";
            this.C1EditorToolStripObjects1.Size = new System.Drawing.Size(127, 25);
            this.C1EditorToolStripObjects1.TabIndex = 1;
            this.C1EditorToolStripObjects1.Text = "C1EditorToolStripObjects1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ShowErrors_small.png");
            this.imageList1.Images.SetKeyName(1, "Spelling_small.png");
            this.imageList1.Images.SetKeyName(2, "WordCount_small.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Panel1Collapsed = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.toolStripContainer1);
            this.splitContainer1.Size = new System.Drawing.Size(736, 446);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.TabIndex = 1;
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 446);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Editor";
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.Editor_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C1Editor1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1SpellChecker1)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private C1.Win.C1Editor.C1Editor C1Editor1;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects C1EditorToolStripObjects1;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain C1EditorToolStripMain1;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripTable C1EditorToolStripTable1;
        private C1.Win.C1SpellChecker.C1SpellChecker c1SpellChecker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem previewModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designModeToolStripMenuItem;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripStyle c1EditorToolStripStyle1;
    }
}