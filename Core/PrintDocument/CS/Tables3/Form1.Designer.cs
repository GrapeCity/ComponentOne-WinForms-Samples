namespace Tables3
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
            c1PrintPreviewControl1 = new C1.Win.C1Preview.C1PrintPreviewControl();
            c1PrintDocument1 = new C1.C1Preview.C1PrintDocument();
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1.PreviewPane).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1PrintDocument1).BeginInit();
            SuspendLayout();
            // 
            // c1PrintPreviewControl1
            // 
            c1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1PrintPreviewControl1.Location = new System.Drawing.Point(0, 0);
            c1PrintPreviewControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            c1PrintPreviewControl1.Name = "c1PrintPreviewControl1";
            // 
            // 
            // 
            c1PrintPreviewControl1.PreviewPane.Document = c1PrintDocument1;
            c1PrintPreviewControl1.PreviewPane.ExportOptions.Content = new C1.Win.C1Preview.ExporterOptions[]
    {
    new C1.Win.C1Preview.ExporterOptions("C1dExportProvider", "C1.C1Preview.Export.C1dOptionsForm", true, false, false)
    };
            c1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = true;
            c1PrintPreviewControl1.PreviewPane.Location = new System.Drawing.Point(0, 0);
            c1PrintPreviewControl1.PreviewPane.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            c1PrintPreviewControl1.PreviewPane.Name = "previewPane";
            c1PrintPreviewControl1.PreviewPane.Size = new System.Drawing.Size(233, 300);
            c1PrintPreviewControl1.PreviewPane.TabIndex = 0;
            c1PrintPreviewControl1.Size = new System.Drawing.Size(874, 627);
            c1PrintPreviewControl1.TabIndex = 0;
            c1PrintPreviewControl1.Text = "c1PrintPreviewControl1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(874, 627);
            Controls.Add(c1PrintPreviewControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Tables3";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1.PreviewPane).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PrintPreviewControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1PrintDocument1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Preview.C1PrintPreviewControl c1PrintPreviewControl1;
        private C1.C1Preview.C1PrintDocument c1PrintDocument1;
    }
}