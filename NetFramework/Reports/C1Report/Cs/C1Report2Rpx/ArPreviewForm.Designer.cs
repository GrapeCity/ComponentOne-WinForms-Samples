namespace C1Report2Rpx
{
    partial class ArPreviewForm
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
            this.avwMain = new GrapeCity.ActiveReports.Viewer.Win.Viewer();
            this.SuspendLayout();
            // 
            // avwMain
            // 
            this.avwMain.AnnotationToolbarVisible = false;
            this.avwMain.CurrentPage = 0;
            this.avwMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.avwMain.HyperlinkBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.avwMain.HyperlinkForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.avwMain.Location = new System.Drawing.Point(0, 0);
            this.avwMain.Name = "avwMain";
            this.avwMain.PagesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.avwMain.PreviewPages = 0;
            this.avwMain.SearchResultsBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.avwMain.SearchResultsForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(139)))));
            // 
            // 
            // 
            // 
            // 
            // 
            this.avwMain.Sidebar.ParametersPanel.ContextMenu = null;
            this.avwMain.Sidebar.ParametersPanel.Width = 180;
            // 
            // 
            // 
            this.avwMain.Sidebar.SearchPanel.ContextMenu = null;
            this.avwMain.Sidebar.SearchPanel.Width = 180;
            this.avwMain.Sidebar.SelectedIndex = 0;
            // 
            // 
            // 
            this.avwMain.Sidebar.ThumbnailsPanel.ContextMenu = null;
            this.avwMain.Sidebar.ThumbnailsPanel.Width = 180;
            // 
            // 
            // 
            this.avwMain.Sidebar.TocPanel.ContextMenu = null;
            this.avwMain.Sidebar.TocPanel.Width = 180;
            this.avwMain.Sidebar.Width = 180;
            this.avwMain.Size = new System.Drawing.Size(817, 471);
            this.avwMain.SplitView = false;
            this.avwMain.TabIndex = 0;
            this.avwMain.ViewType = GrapeCity.Viewer.Common.Model.ViewType.SinglePage;
            this.avwMain.Zoom = 1F;
            // 
            // ArPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 471);
            this.Controls.Add(this.avwMain);
            this.Name = "ArPreviewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ActiveReports Preview";
            this.ResumeLayout(false);

        }

        #endregion

        private GrapeCity.ActiveReports.Viewer.Win.Viewer avwMain;
    }
}