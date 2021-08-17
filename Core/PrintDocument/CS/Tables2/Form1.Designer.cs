namespace Tables2
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
            this.c1PrintPreviewControl1 = new C1.Win.C1Preview.C1PrintPreviewControl();
            this.c1PrintDocument1 = new C1.C1Preview.C1PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).BeginInit();
            this.c1PrintPreviewControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1PrintPreviewControl1
            // 
            this.c1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PrintPreviewControl1.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewControl1.Name = "c1PrintPreviewControl1";
            // 
            // c1PrintPreviewControl1.PreviewPane
            // 
            this.c1PrintPreviewControl1.PreviewPane.Document = this.c1PrintDocument1;
            this.c1PrintPreviewControl1.PreviewPane.ExportOptions.Content = new C1.Win.C1Preview.ExporterOptions[] {
        new C1.Win.C1Preview.ExporterOptions("C1dExportProvider", "", true, false, false)};
            this.c1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = true;
            this.c1PrintPreviewControl1.PreviewPane.TabIndex = 0;
            this.c1PrintPreviewControl1.Size = new System.Drawing.Size(760, 537);
            this.c1PrintPreviewControl1.TabIndex = 0;
            this.c1PrintPreviewControl1.Text = "c1PrintPreviewControl1";
            // 
            // c1PrintDocument1
            // 
            this.c1PrintDocument1.PageLayouts.Default.PageSettings = new C1.C1Preview.C1PageSettings(System.Drawing.Printing.PaperKind.Letter, false, "1in", "1in", "1in", "1in");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 537);
            this.Controls.Add(this.c1PrintPreviewControl1);
            this.Name = "Form1";
            this.Text = "Tables2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).EndInit();
            this.c1PrintPreviewControl1.ResumeLayout(false);
            this.c1PrintPreviewControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Preview.C1PrintPreviewControl c1PrintPreviewControl1;
        private C1.C1Preview.C1PrintDocument c1PrintDocument1;
    }
}