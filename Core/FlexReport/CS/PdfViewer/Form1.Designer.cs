namespace PdfReader
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuFile = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            c1PdfDocumentSource1 = new C1.Win.Document.C1PdfDocumentSource(components);
            menuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexViewer1).BeginInit();
            SuspendLayout();
            // 
            // menuFile
            // 
            menuFile.ImageScalingSize = new System.Drawing.Size(32, 32);
            menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem });
            menuFile.Location = new System.Drawing.Point(0, 0);
            menuFile.Name = "menuFile";
            menuFile.Padding = new System.Windows.Forms.Padding(13, 5, 0, 5);
            menuFile.Size = new System.Drawing.Size(2264, 46);
            menuFile.TabIndex = 1;
            menuFile.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { openToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(71, 36);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new System.Drawing.Size(221, 44);
            openToolStripMenuItem.Text = "Open...";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(221, 44);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // c1FlexViewer1
            // 
            c1FlexViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            c1FlexViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            c1FlexViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            c1FlexViewer1.DocumentSource = c1PdfDocumentSource1;
            c1FlexViewer1.Location = new System.Drawing.Point(4, 66);
            c1FlexViewer1.Margin = new System.Windows.Forms.Padding(13, 15, 13, 15);
            c1FlexViewer1.Name = "c1FlexViewer1";
            c1FlexViewer1.RibbonElements.Export.Visible = false;
            c1FlexViewer1.Size = new System.Drawing.Size(2264, 2048);
            c1FlexViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(2264, 2119);
            Controls.Add(c1FlexViewer1);
            Controls.Add(menuFile);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuFile;
            Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            Name = "Form1";
            Text = "PDF Loader";
            menuFile.ResumeLayout(false);
            menuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexViewer1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private C1.Win.FlexViewer.C1FlexViewer c1FlexViewer1;
        private System.Windows.Forms.MenuStrip menuFile;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private C1.Win.Document.C1PdfDocumentSource c1PdfDocumentSource1;
    }
}

