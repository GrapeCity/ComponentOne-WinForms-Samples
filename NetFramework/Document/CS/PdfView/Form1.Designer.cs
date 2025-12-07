namespace PdfView
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
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.c1PdfDocumentSource1 = new C1.Win.Document.C1PdfDocumentSource(this.components);
            this.c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            this.ilLarge = new System.Windows.Forms.ImageList(this.components);
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.ofdOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexViewer1
            // 
            this.c1FlexViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexViewer1.DocumentSource = this.c1PdfDocumentSource1;
            this.c1FlexViewer1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexViewer1.Name = "c1FlexViewer1";
            this.c1FlexViewer1.Size = new System.Drawing.Size(991, 610);
            this.c1FlexViewer1.TabIndex = 0;
            // 
            // ilLarge
            // 
            this.ilLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLarge.ImageStream")));
            this.ilLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ilLarge.Images.SetKeyName(0, "FolderLarge.png");
            // 
            // ilSmall
            // 
            this.ilSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSmall.ImageStream")));
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSmall.Images.SetKeyName(0, "FolderSmall.png");
            // 
            // ofdOpen
            // 
            this.ofdOpen.DefaultExt = "pdf";
            this.ofdOpen.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 610);
            this.Controls.Add(this.c1FlexViewer1);
            this.Name = "Form1";
            this.Text = "PDF Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Document.C1PdfDocumentSource c1PdfDocumentSource1;
        private C1.Win.FlexViewer.C1FlexViewer c1FlexViewer1;
        private System.Windows.Forms.ImageList ilLarge;
        private System.Windows.Forms.ImageList ilSmall;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
    }
}

