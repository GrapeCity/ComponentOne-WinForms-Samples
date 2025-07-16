namespace PdfViewer
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
            this.menuFile = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            this.c1PdfDocumentSource1 = new C1.Win.Document.C1PdfDocumentSource();
            this.menuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuFile
            // 
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuFile.Location = new System.Drawing.Point(0, 0);
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(1045, 24);
            this.menuFile.TabIndex = 1;
            this.menuFile.Text = "File";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // c1FlexViewer1
            // 
            this.c1FlexViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.DocumentSource = this.c1PdfDocumentSource1;
            this.c1FlexViewer1.Location = new System.Drawing.Point(2, 27);
            this.c1FlexViewer1.Name = "c1FlexViewer1";
            this.c1FlexViewer1.RibbonElements.Export.Visible = false;
            this.c1FlexViewer1.Size = new System.Drawing.Size(1045, 854);
            this.c1FlexViewer1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 883);
            this.Controls.Add(this.c1FlexViewer1);
            this.Controls.Add(this.menuFile);
            this.MainMenuStrip = this.menuFile;
            this.Name = "Form1";
            this.Text = "PDF Loader";
            this.menuFile.ResumeLayout(false);
            this.menuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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

