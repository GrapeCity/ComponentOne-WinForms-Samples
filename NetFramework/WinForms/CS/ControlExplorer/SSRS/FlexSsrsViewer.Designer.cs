namespace ControlExplorer.SSRS
{
    partial class FlexSsrsViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexViewer1
            // 
            this.c1FlexViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexViewer1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexViewer1.Name = "c1FlexViewer1";
            this.c1FlexViewer1.Size = new System.Drawing.Size(656, 389);
            this.c1FlexViewer1.TabIndex = 0;
            this.c1FlexViewer1.UseIncrementalSearch = true;
            this.c1FlexViewer1.ZoomMode = C1.Win.FlexViewer.FlexViewerZoomMode.WholePage;
            // 
            // CommonReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 389);
            this.Controls.Add(this.c1FlexViewer1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FlexSsrsViewer";
            this.Text = "FlexSsrsViewer";
            this.Load += new System.EventHandler(this.FlexSsrsViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private C1.Win.FlexViewer.C1FlexViewer c1FlexViewer1;
    }
}