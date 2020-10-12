namespace Toolstrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1Editor1 = new C1.Win.C1Editor.C1Editor();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.editorToolStripMain1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain();
            this.editorToolStripStyle1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripStyle();
            this.editorToolStripObjects1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects();
            this.editorToolStripTable1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripTable();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.c1EditorToolStripButton1 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripButton();
            this.c1EditorToolStripButton2 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripButton();
            this.c1EditorToolStripButton3 = new C1.Win.C1Editor.ToolStrips.C1EditorToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).BeginInit();
            this.panel2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.panel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(586, 415);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(586, 515);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.editorToolStripStyle1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.editorToolStripMain1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.editorToolStripObjects1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.editorToolStripTable1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c1Editor1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 415);
            this.panel1.TabIndex = 0;
            // 
            // c1Editor1
            // 
            this.c1Editor1.AllowDrop = false;
            this.c1Editor1.BackColor = System.Drawing.SystemColors.Window;
            this.c1Editor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Editor1.Location = new System.Drawing.Point(0, 0);
            this.c1Editor1.Name = "c1Editor1";
            this.c1Editor1.Size = new System.Drawing.Size(586, 333);
            this.c1Editor1.TabIndex = 3;
            this.c1Editor1.XmlExtensions = null;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 333);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(586, 82);
            this.panel2.TabIndex = 2;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(66, 52);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(104, 17);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Custom Toolstrip";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Show:";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(66, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(205, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "MS Toolstrip with C1Editor buttons";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(66, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "C1Editor ToolStrips";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // editorToolStripMain1
            // 
            this.editorToolStripMain1.Dock = System.Windows.Forms.DockStyle.None;
            this.editorToolStripMain1.Editor = this.c1Editor1;
            this.editorToolStripMain1.Location = new System.Drawing.Point(3, 25);
            this.editorToolStripMain1.Name = "editorToolStripMain1";
            this.editorToolStripMain1.Size = new System.Drawing.Size(379, 25);
            this.editorToolStripMain1.TabIndex = 5;
            this.editorToolStripMain1.Text = "editorToolStripMain1";
            // 
            // editorToolStripStyle1
            // 
            this.editorToolStripStyle1.Dock = System.Windows.Forms.DockStyle.None;
            this.editorToolStripStyle1.Editor = this.c1Editor1;
            this.editorToolStripStyle1.Location = new System.Drawing.Point(8, 0);
            this.editorToolStripStyle1.Name = "editorToolStripStyle1";
            this.editorToolStripStyle1.Size = new System.Drawing.Size(479, 25);
            this.editorToolStripStyle1.TabIndex = 7;
            this.editorToolStripStyle1.Text = "editorToolStripStyle1";
            // 
            // editorToolStripObjects1
            // 
            this.editorToolStripObjects1.Dock = System.Windows.Forms.DockStyle.None;
            this.editorToolStripObjects1.Editor = this.c1Editor1;
            this.editorToolStripObjects1.Location = new System.Drawing.Point(177, 50);
            this.editorToolStripObjects1.Name = "editorToolStripObjects1";
            this.editorToolStripObjects1.Size = new System.Drawing.Size(125, 25);
            this.editorToolStripObjects1.TabIndex = 8;
            this.editorToolStripObjects1.Text = "editorToolStripObjects1";
            // 
            // editorToolStripTable1
            // 
            this.editorToolStripTable1.Dock = System.Windows.Forms.DockStyle.None;
            this.editorToolStripTable1.Editor = this.c1Editor1;
            this.editorToolStripTable1.Location = new System.Drawing.Point(3, 75);
            this.editorToolStripTable1.Name = "editorToolStripTable1";
            this.editorToolStripTable1.Size = new System.Drawing.Size(286, 25);
            this.editorToolStripTable1.TabIndex = 6;
            this.editorToolStripTable1.Text = "editorToolStripTable1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.c1EditorToolStripButton1,
            this.c1EditorToolStripButton2,
            this.c1EditorToolStripButton3,
            this.toolStripSeparator2,
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 50);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(174, 25);
            this.toolStrip2.TabIndex = 9;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabel2.Text = "MS ToolStrip";
            // 
            // c1EditorToolStripButton1
            // 
            this.c1EditorToolStripButton1.Command = C1.Win.C1Editor.ToolStrips.CommandButton.Cut;
            this.c1EditorToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.c1EditorToolStripButton1.Editor = this.c1Editor1;
            this.c1EditorToolStripButton1.Enabled = false;
            this.c1EditorToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("c1EditorToolStripButton1.Image")));
            this.c1EditorToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.c1EditorToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1EditorToolStripButton1.Name = "c1EditorToolStripButton1";
            this.c1EditorToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.c1EditorToolStripButton1.Text = "Cut";
            this.c1EditorToolStripButton1.ToolTipText = "Cut (Ctrl+X)";
            // 
            // c1EditorToolStripButton2
            // 
            this.c1EditorToolStripButton2.Command = C1.Win.C1Editor.ToolStrips.CommandButton.Copy;
            this.c1EditorToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.c1EditorToolStripButton2.Editor = this.c1Editor1;
            this.c1EditorToolStripButton2.Enabled = false;
            this.c1EditorToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("c1EditorToolStripButton2.Image")));
            this.c1EditorToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.c1EditorToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1EditorToolStripButton2.Name = "c1EditorToolStripButton2";
            this.c1EditorToolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.c1EditorToolStripButton2.Text = "Copy";
            this.c1EditorToolStripButton2.ToolTipText = "Copy (Ctrl+C)";
            // 
            // c1EditorToolStripButton3
            // 
            this.c1EditorToolStripButton3.Command = C1.Win.C1Editor.ToolStrips.CommandButton.Paste;
            this.c1EditorToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.c1EditorToolStripButton3.Editor = this.c1Editor1;
            this.c1EditorToolStripButton3.Enabled = false;
            this.c1EditorToolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("c1EditorToolStripButton3.Image")));
            this.c1EditorToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.c1EditorToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1EditorToolStripButton3.Name = "c1EditorToolStripButton3";
            this.c1EditorToolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.c1EditorToolStripButton3.Text = "Paste";
            this.c1EditorToolStripButton3.ToolTipText = "Paste (Ctrl+V)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Word count";
            this.toolStripButton2.ToolTipText = "Word count";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 515);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripObjects editorToolStripObjects1;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripStyle editorToolStripStyle1;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripTable editorToolStripTable1;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripMain editorToolStripMain1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Editor.C1Editor c1Editor1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripButton c1EditorToolStripButton1;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripButton c1EditorToolStripButton2;
        private C1.Win.C1Editor.ToolStrips.C1EditorToolStripButton c1EditorToolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}

