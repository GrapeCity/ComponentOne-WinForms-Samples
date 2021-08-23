namespace MapReports
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
            this._rep = new C1.C1Report.C1Report();
            this._reportList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnGo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).BeginInit();
            this.c1PrintPreviewControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._rep)).BeginInit();
            this.SuspendLayout();
            // 
            // c1PrintPreviewControl1
            // 
            this.c1PrintPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1PrintPreviewControl1.Location = new System.Drawing.Point(225, 1);
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
            this.c1PrintPreviewControl1.PreviewPane.Document = this._rep;
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
            this.c1PrintPreviewControl1.PreviewThumbnailView.Size = new System.Drawing.Size(165, 552);
            this.c1PrintPreviewControl1.PreviewThumbnailView.TabIndex = 0;
            this.c1PrintPreviewControl1.PreviewThumbnailView.UseImageAsThumbnail = false;
            this.c1PrintPreviewControl1.Size = new System.Drawing.Size(825, 625);
            this.c1PrintPreviewControl1.TabIndex = 0;
            this.c1PrintPreviewControl1.Text = "c1PrintPreviewControl1";
            // 
            // _rep
            // 
            this._rep.ReportDefinition = resources.GetString("_rep.ReportDefinition");
            this._rep.ReportName = "c1Report1";
            // 
            // _reportList
            // 
            this._reportList.FormattingEnabled = true;
            this._reportList.Location = new System.Drawing.Point(5, 38);
            this._reportList.Name = "_reportList";
            this._reportList.Size = new System.Drawing.Size(214, 134);
            this._reportList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a report in the list below,\r\nclick \"Go\" to render:";
            // 
            // _btnGo
            // 
            this._btnGo.Location = new System.Drawing.Point(144, 178);
            this._btnGo.Name = "_btnGo";
            this._btnGo.Size = new System.Drawing.Size(75, 23);
            this._btnGo.TabIndex = 3;
            this._btnGo.Text = "Go";
            this._btnGo.UseVisualStyleBackColor = true;
            this._btnGo.Click += new System.EventHandler(this._btnGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 627);
            this.Controls.Add(this._btnGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._reportList);
            this.Controls.Add(this.c1PrintPreviewControl1);
            this.Name = "Form1";
            this.Text = "Map Reports";
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).EndInit();
            this.c1PrintPreviewControl1.ResumeLayout(false);
            this.c1PrintPreviewControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._rep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Preview.C1PrintPreviewControl c1PrintPreviewControl1;
        private C1.C1Report.C1Report _rep;
        private System.Windows.Forms.ListBox _reportList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _btnGo;
    }
}

