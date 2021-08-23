namespace ReportStyle
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
            this.c1PrintPreviewControl1 = new C1.Win.C1Preview.C1PrintPreviewControl();
            this.c1Report1 = new C1.C1Report.C1Report();
            this.btnFileOpen = new System.Windows.Forms.Button();
            this.cmbReports = new System.Windows.Forms.ComboBox();
            this.btnSelectStyle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).BeginInit();
            this.c1PrintPreviewControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1PrintPreviewControl1
            // 
            this.c1PrintPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1PrintPreviewControl1.AvailablePreviewActions = ((C1.Win.C1Preview.C1PreviewActionFlags)((((((((((((((((((((((C1.Win.C1Preview.C1PreviewActionFlags.FileSave | C1.Win.C1Preview.C1PreviewActionFlags.PageSetup)
                        | C1.Win.C1Preview.C1PreviewActionFlags.Print)
                        | C1.Win.C1Preview.C1PreviewActionFlags.PageSingle)
                        | C1.Win.C1Preview.C1PreviewActionFlags.PageContinuous)
                        | C1.Win.C1Preview.C1PreviewActionFlags.PageFacing)
                        | C1.Win.C1Preview.C1PreviewActionFlags.PageFacingContinuous)
                        | C1.Win.C1Preview.C1PreviewActionFlags.GoFirst)
                        | C1.Win.C1Preview.C1PreviewActionFlags.GoPrev)
                        | C1.Win.C1Preview.C1PreviewActionFlags.GoNext)
                        | C1.Win.C1Preview.C1PreviewActionFlags.GoLast)
                        | C1.Win.C1Preview.C1PreviewActionFlags.GoPage)
                        | C1.Win.C1Preview.C1PreviewActionFlags.HistoryNext)
                        | C1.Win.C1Preview.C1PreviewActionFlags.HistoryPrev)
                        | C1.Win.C1Preview.C1PreviewActionFlags.ZoomIn)
                        | C1.Win.C1Preview.C1PreviewActionFlags.ZoomOut)
                        | C1.Win.C1Preview.C1PreviewActionFlags.ZoomFactor)
                        | C1.Win.C1Preview.C1PreviewActionFlags.ZoomInTool)
                        | C1.Win.C1Preview.C1PreviewActionFlags.ZoomOutTool)
                        | C1.Win.C1Preview.C1PreviewActionFlags.HandTool)
                        | C1.Win.C1Preview.C1PreviewActionFlags.SelectTextTool)
                        | C1.Win.C1Preview.C1PreviewActionFlags.Find)));
            this.c1PrintPreviewControl1.Location = new System.Drawing.Point(242, 0);
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
            this.c1PrintPreviewControl1.PreviewPane.Document = this.c1Report1;
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
            this.c1PrintPreviewControl1.PreviewThumbnailView.Size = new System.Drawing.Size(165, 546);
            this.c1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0;
            this.c1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = false;
            this.c1PrintPreviewControl1.Size = new System.Drawing.Size(666, 619);
            this.c1PrintPreviewControl1.TabIndex = 0;
            this.c1PrintPreviewControl1.Text = "c1PrintPreviewControl1";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.File.Open.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.File.Open.Image")));
            this.c1PrintPreviewControl1.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.File.Open.Name = "btnFileOpen";
            this.c1PrintPreviewControl1.ToolBars.File.Open.Size = new System.Drawing.Size(32, 22);
            this.c1PrintPreviewControl1.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen";
            this.c1PrintPreviewControl1.ToolBars.File.Open.ToolTipText = "Open File";
            this.c1PrintPreviewControl1.ToolBars.File.Open.Visible = false;
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.File.Reflow.Image")));
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.Name = "btnReflow";
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.Tag = "C1PreviewActionEnum.Reflow";
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.ToolTipText = "Reflow";
            this.c1PrintPreviewControl1.ToolBars.File.Reflow.Visible = false;
            // 
            // 
            // 
            this.c1PrintPreviewControl1.ToolBars.Text.Find.Image = ((System.Drawing.Image)(resources.GetObject("c1PrintPreviewControl1.ToolBars.Text.Find.Image")));
            this.c1PrintPreviewControl1.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.c1PrintPreviewControl1.ToolBars.Text.Find.Name = "btnFind";
            this.c1PrintPreviewControl1.ToolBars.Text.Find.Size = new System.Drawing.Size(23, 22);
            this.c1PrintPreviewControl1.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find";
            this.c1PrintPreviewControl1.ToolBars.Text.Find.ToolTipText = "Find Text";
            // 
            // c1Report1
            // 
            this.c1Report1.ReportDefinition = resources.GetString("c1Report1.ReportDefinition");
            this.c1Report1.ReportName = "c1Report1";
            // 
            // btnFileOpen
            // 
            this.btnFileOpen.Location = new System.Drawing.Point(12, 12);
            this.btnFileOpen.Name = "btnFileOpen";
            this.btnFileOpen.Size = new System.Drawing.Size(224, 23);
            this.btnFileOpen.TabIndex = 1;
            this.btnFileOpen.Text = "Open Report Definition File...";
            this.btnFileOpen.UseVisualStyleBackColor = true;
            this.btnFileOpen.Click += new System.EventHandler(this.btnFileOpen_Click);
            // 
            // cmbReports
            // 
            this.cmbReports.FormattingEnabled = true;
            this.cmbReports.Location = new System.Drawing.Point(12, 41);
            this.cmbReports.Name = "cmbReports";
            this.cmbReports.Size = new System.Drawing.Size(224, 21);
            this.cmbReports.TabIndex = 2;
            this.cmbReports.SelectedIndexChanged += new System.EventHandler(this.cmbReports_SelectedIndexChanged);
            // 
            // btnSelectStyle
            // 
            this.btnSelectStyle.Location = new System.Drawing.Point(12, 68);
            this.btnSelectStyle.Name = "btnSelectStyle";
            this.btnSelectStyle.Size = new System.Drawing.Size(224, 23);
            this.btnSelectStyle.TabIndex = 4;
            this.btnSelectStyle.Text = "Select Report Style";
            this.btnSelectStyle.UseVisualStyleBackColor = true;
            this.btnSelectStyle.Click += new System.EventHandler(this.btnSelectStyle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 617);
            this.Controls.Add(this.btnSelectStyle);
            this.Controls.Add(this.cmbReports);
            this.Controls.Add(this.btnFileOpen);
            this.Controls.Add(this.c1PrintPreviewControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).EndInit();
            this.c1PrintPreviewControl1.ResumeLayout(false);
            this.c1PrintPreviewControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Report1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Preview.C1PrintPreviewControl c1PrintPreviewControl1;
        private C1.C1Report.C1Report c1Report1;
        private System.Windows.Forms.Button btnFileOpen;
        private System.Windows.Forms.ComboBox cmbReports;
        private System.Windows.Forms.Button btnSelectStyle;

    }
}

