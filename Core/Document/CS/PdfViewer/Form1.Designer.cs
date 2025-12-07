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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            c1PdfDocumentSource1 = new C1.Win.Document.C1PdfDocumentSource(components);
            c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            ilLarge = new System.Windows.Forms.ImageList(components);
            ilSmall = new System.Windows.Forms.ImageList(components);
            ofdOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)c1FlexViewer1).BeginInit();
            SuspendLayout();
            // 
            // c1FlexViewer1
            // 
            c1FlexViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            c1FlexViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            c1FlexViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1FlexViewer1.DocumentSource = c1PdfDocumentSource1;
            c1FlexViewer1.Location = new System.Drawing.Point(0, 0);
            c1FlexViewer1.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            c1FlexViewer1.Name = "c1FlexViewer1";
            c1FlexViewer1.Size = new System.Drawing.Size(1044, 512);
            c1FlexViewer1.TabIndex = 0;
            // 
            // ilLarge
            // 
            ilLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            ilLarge.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ilLarge.ImageStream");
            ilLarge.TransparentColor = System.Drawing.Color.Transparent;
            ilLarge.Images.SetKeyName(0, "FolderLarge.png");
            // 
            // ilSmall
            // 
            ilSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            ilSmall.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ilSmall.ImageStream");
            ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            ilSmall.Images.SetKeyName(0, "FolderSmall.png");
            // 
            // ofdOpen
            // 
            ofdOpen.DefaultExt = "pdf";
            ofdOpen.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1044, 512);
            Controls.Add(c1FlexViewer1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "PDF Viewer";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)c1FlexViewer1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private C1.Win.Document.C1PdfDocumentSource c1PdfDocumentSource1;
        private C1.Win.FlexViewer.C1FlexViewer c1FlexViewer1;
        private System.Windows.Forms.ImageList ilLarge;
        private System.Windows.Forms.ImageList ilSmall;
        private System.Windows.Forms.OpenFileDialog ofdOpen;
    }
}

