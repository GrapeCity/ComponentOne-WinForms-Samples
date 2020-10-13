namespace Hyperlinks
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
            this.c1PrintDocument1 = new C1.C1Preview.C1PrintDocument();
            this.c1PrintPreviewControl1 = new C1.Win.C1Preview.C1PrintPreviewControl();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).BeginInit();
            this.c1PrintPreviewControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1PrintDocument1
            // 
            this.c1PrintDocument1.PageLayouts.Default.PageSettings = new C1.C1Preview.C1PageSettings(false, System.Drawing.Printing.PaperKind.Letter, false, "1in", "1in", "1in", "1in");
            // 
            // c1PrintPreviewControl1
            // 
            this.c1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PrintPreviewControl1.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewControl1.Name = "c1PrintPreviewControl1";
            // 
            // c1PrintPreviewControl1.OutlineView
            // 
            this.c1PrintPreviewControl1.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PrintPreviewControl1.PreviewOutlineView.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewControl1.PreviewOutlineView.Name = "OutlineView";
            this.c1PrintPreviewControl1.PreviewOutlineView.Size = new System.Drawing.Size(165, 427);
            this.c1PrintPreviewControl1.PreviewOutlineView.TabIndex = 0;
            // 
            // c1PrintPreviewControl1.PreviewPane
            // 
            this.c1PrintPreviewControl1.PreviewPane.Document = this.c1PrintDocument1;
            this.c1PrintPreviewControl1.PreviewPane.ExportOptions.Content = new C1.Win.C1Preview.ExporterOptions[] {
        new C1.Win.C1Preview.ExporterOptions("C1dExportProvider", "C1.C1Preview.Export.C1dOptionsForm", true, false, false)};
            // 
            // 
            // 
            this.c1PrintPreviewControl1.PreviewPane.HistoryOptions.SavedActions = ((C1.Win.C1Preview.HistorySavedActionsEnum)(((((((((((((((((((C1.Win.C1Preview.HistorySavedActionsEnum.Continuous | C1.Win.C1Preview.HistorySavedActionsEnum.PageLayout)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.Rows)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.Cols)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.ZoomMode)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.ZoomFactor)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.StartPageChange)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.HyperlinkJump)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.Scroll)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.TextSearch)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.DocumentOpen)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.DocumentReflow)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.DocumentChangeMargins)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.DocumentChangePageSettings)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.HideMarginsState)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.ShowRulers)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.ShowPrintableArea)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.PrintingLayout)
                        | C1.Win.C1Preview.HistorySavedActionsEnum.PrinterSettings)));
            this.c1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = true;
            this.c1PrintPreviewControl1.PreviewPane.TabIndex = 0;
            // 
            // c1PrintPreviewControl1.PreviewTextSearchPanel
            // 
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Location = new System.Drawing.Point(530, 0);
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.MinimumSize = new System.Drawing.Size(200, 240);
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel";
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Size = new System.Drawing.Size(200, 453);
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.TabIndex = 0;
            this.c1PrintPreviewControl1.PreviewTextSearchPanel.Visible = false;
            // 
            // c1PrintPreviewControl1.ThumbnailView
            // 
            this.c1PrintPreviewControl1.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PrintPreviewControl1.PreviewThumbnailView.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewControl1.PreviewThumbnailView.Name = "ThumbnailView";
            this.c1PrintPreviewControl1.PreviewThumbnailView.Size = new System.Drawing.Size(165, 457);
            this.c1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0;
            this.c1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = false;
            this.c1PrintPreviewControl1.Size = new System.Drawing.Size(759, 530);
            this.c1PrintPreviewControl1.TabIndex = 0;
            this.c1PrintPreviewControl1.Text = "c1PrintPreviewControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 530);
            this.Controls.Add(this.c1PrintPreviewControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).EndInit();
            this.c1PrintPreviewControl1.ResumeLayout(false);
            this.c1PrintPreviewControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.C1Preview.C1PrintDocument c1PrintDocument1;
        private C1.Win.C1Preview.C1PrintPreviewControl c1PrintPreviewControl1;
    }
}
