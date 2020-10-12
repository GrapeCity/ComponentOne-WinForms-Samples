namespace ControlExplorer.Reports
{
    partial class RibbonPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonPreview));
            this.c1RibbonPreview1 = new C1.Win.C1RibbonPreview.C1RibbonPreview();
            this.c1PrintDocument1 = new C1.C1Preview.C1PrintDocument();
            this.c1Report1 = new C1.C1Report.C1Report();
            ((System.ComponentModel.ISupportInitialize)(this.c1RibbonPreview1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1RibbonPreview1
            // 
            this.c1RibbonPreview1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1RibbonPreview1.Location = new System.Drawing.Point(0, 0);
            this.c1RibbonPreview1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1RibbonPreview1.Name = "c1RibbonPreview1";
            this.c1RibbonPreview1.Size = new System.Drawing.Size(880, 542);
            this.c1RibbonPreview1.TabIndex = 0;
            // 
            // c1PrintDocument1
            // 
            this.c1PrintDocument1.DocumentInfo.Creator = "C1Reports Engine version 2.6.20101.54005";
            this.c1PrintDocument1.PageLayouts.Default.PageSettings = new C1.C1Preview.C1PageSettings(false, System.Drawing.Printing.PaperKind.Letter, false, "1in", "1in", "1in", "1in", System.Drawing.Printing.PaperSourceKind.Upper, 0, null, System.Drawing.Printing.PrinterResolutionKind.Custom, 0, 0);
            this.c1PrintDocument1.TagsInputDialogClass = null;
            // 
            // c1Report1
            // 
            this.c1Report1.ReportDefinition = resources.GetString("c1Report1.ReportDefinition");
            this.c1Report1.ReportName = "c1Report1";
            // 
            // RibbonPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 542);
            this.Controls.Add(this.c1RibbonPreview1);
            this.Name = "RibbonPreview";
            this.Text = "RibbonPreview";
            this.Load += new System.EventHandler(this.RibbonPreview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1RibbonPreview1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private C1.Win.C1RibbonPreview.C1RibbonPreview c1RibbonPreview1;
        private C1.C1Preview.C1PrintDocument c1PrintDocument1;
        private C1.C1Report.C1Report c1Report1;
    }
}