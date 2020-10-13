namespace C1EditorQuickStart
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.c1Editor1 = new C1.Win.C1Editor.C1Editor();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._lblDesign = new System.Windows.Forms.ToolStripStatusLabel();
            this._lblPreview = new System.Windows.Forms.ToolStripStatusLabel();
            this._lblSource = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.mainToolStrip = new C1EditorQuickStart.ToolStrips.ToolStripMain();
            this.c1SpellChecker1 = new C1.Win.C1SpellChecker.C1SpellChecker(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.searchAndReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAndReplaceDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectXmlNodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.styleToolStrip = new C1EditorQuickStart.ToolStrips.ToolStripStyles();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.selectParagraphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1SpellChecker1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1Editor1
            // 
            this.c1Editor1.BackColor = System.Drawing.SystemColors.Window;
            this.c1Editor1.XmlExtensions = null;
            this.c1Editor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Editor1.Location = new System.Drawing.Point(0, 0);
            this.c1Editor1.Margin = new System.Windows.Forms.Padding(5);
            this.c1Editor1.Name = "c1Editor1";
            this.c1Editor1.WordWrap = true;
            this.c1Editor1.Size = new System.Drawing.Size(675, 384);
            this.c1Editor1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._lblDesign,
            this._lblPreview,
            this._lblSource});
            this.statusStrip1.Location = new System.Drawing.Point(0, 384);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(675, 23);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _lblDesign
            // 
            this._lblDesign.BackColor = System.Drawing.Color.Orange;
            this._lblDesign.Image = ((System.Drawing.Image)(resources.GetObject("_lblDesign.Image")));
            this._lblDesign.Name = "_lblDesign";
            this._lblDesign.Size = new System.Drawing.Size(67, 18);
            this._lblDesign.Text = "Design";
            this._lblDesign.Click += new System.EventHandler(this._lblDesign_Click);
            // 
            // _lblPreview
            // 
            this._lblPreview.Image = global::C1EditorQuickStart.Properties.Resources.SplitMode_small;
            this._lblPreview.Name = "_lblPreview";
            this._lblPreview.Size = new System.Drawing.Size(49, 18);
            this._lblPreview.Text = "Preview";
            this._lblPreview.Click += new System.EventHandler(this._lblDesign_Click);
            // 
            // _lblSource
            // 
            this._lblSource.Image = global::C1EditorQuickStart.Properties.Resources.SourceMode_small;
            this._lblSource.Name = "_lblSource";
            this._lblSource.Size = new System.Drawing.Size(68, 18);
            this._lblSource.Text = "Source";
            this._lblSource.Click += new System.EventHandler(this._lblDesign_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.c1Editor1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(675, 407);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(675, 457);
            this.toolStripContainer1.TabIndex = 3;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.mainToolStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.styleToolStrip);
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainToolStrip.Editor = this.c1Editor1;
            this.mainToolStrip.Location = new System.Drawing.Point(3, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(393, 25);
            this.mainToolStrip.SpellChecker = this.c1SpellChecker1;
            this.mainToolStrip.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(115, 25);
            this.toolStrip1.TabIndex = 4;
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectParagraphToolStripMenuItem,
            this.selectXmlNodeToolStripMenuItem,
            this.toolStripMenuItem1,
            this.searchAndReplaceToolStripMenuItem,
            this.searchAndReplaceDocToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(72, 22);
            this.toolStripDropDownButton1.Text = "How To";
            // 
            // searchAndReplaceToolStripMenuItem
            // 
            this.searchAndReplaceToolStripMenuItem.Name = "searchAndReplaceToolStripMenuItem";
            this.searchAndReplaceToolStripMenuItem.Size = new System.Drawing.Size(350, 22);
            this.searchAndReplaceToolStripMenuItem.Text = "Search and Replace (using selection)";
            this.searchAndReplaceToolStripMenuItem.Click += new System.EventHandler(this.replaceUsingSelection_Click);
            // 
            // searchAndReplaceDocToolStripMenuItem
            // 
            this.searchAndReplaceDocToolStripMenuItem.Name = "searchAndReplaceDocToolStripMenuItem";
            this.searchAndReplaceDocToolStripMenuItem.Size = new System.Drawing.Size(350, 22);
            this.searchAndReplaceDocToolStripMenuItem.Text = "Search and Replace (using XmlDocument)";
            this.searchAndReplaceDocToolStripMenuItem.Click += new System.EventHandler(this.replaceUsingXmlDocument);
            // 
            // selectXmlNodeToolStripMenuItem
            // 
            this.selectXmlNodeToolStripMenuItem.Name = "selectXmlNodeToolStripMenuItem";
            this.selectXmlNodeToolStripMenuItem.Size = new System.Drawing.Size(350, 22);
            this.selectXmlNodeToolStripMenuItem.Text = "Select Xml Node";
            this.selectXmlNodeToolStripMenuItem.Click += new System.EventHandler(this.selectXmlNode_Click);
            // 
            // styleToolStrip
            // 
            this.styleToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.styleToolStrip.Editor = this.c1Editor1;
            this.styleToolStrip.Location = new System.Drawing.Point(118, 25);
            this.styleToolStrip.Name = "styleToolStrip";
            this.styleToolStrip.Size = new System.Drawing.Size(262, 25);
            this.styleToolStrip.TabIndex = 3;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(347, 6);
            // 
            // selectParagraphToolStripMenuItem
            // 
            this.selectParagraphToolStripMenuItem.Name = "selectParagraphToolStripMenuItem";
            this.selectParagraphToolStripMenuItem.Size = new System.Drawing.Size(350, 22);
            this.selectParagraphToolStripMenuItem.Text = "Select Paragraph";
            this.selectParagraphToolStripMenuItem.Click += new System.EventHandler(this.selectParagraph_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 457);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1SpellChecker1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Editor.C1Editor c1Editor1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private C1EditorQuickStart.ToolStrips.ToolStripMain mainToolStrip;
        private C1.Win.C1SpellChecker.C1SpellChecker c1SpellChecker1;
        private C1EditorQuickStart.ToolStrips.ToolStripStyles styleToolStrip;
        private System.Windows.Forms.ToolStripStatusLabel _lblDesign;
        private System.Windows.Forms.ToolStripStatusLabel _lblPreview;
        private System.Windows.Forms.ToolStripStatusLabel _lblSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem searchAndReplaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectXmlNodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAndReplaceDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectParagraphToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    }
}

