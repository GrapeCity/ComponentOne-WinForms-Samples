namespace MultiDocumentFilesPrint
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this._pview = new C1.Win.C1Preview.C1PrintPreviewControl();
            this.btnMultiDoc = new System.Windows.Forms.Button();
            this.btnSingleDoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMask = new System.Windows.Forms.TextBox();
            this.btnChooseDir = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._pview)).BeginInit();
            this._pview.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _pview
            // 
            this._pview.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pview.Location = new System.Drawing.Point(0, 29);
            this._pview.Name = "_pview";
            // 
            // _pview.OutlineView
            // 
            this._pview.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pview.PreviewOutlineView.Location = new System.Drawing.Point(0, 0);
            this._pview.PreviewOutlineView.Name = "OutlineView";
            this._pview.PreviewOutlineView.Size = new System.Drawing.Size(165, 427);
            this._pview.PreviewOutlineView.TabIndex = 0;
            // 
            // _pview.PreviewPane
            // 
            this._pview.PreviewPane.IntegrateExternalTools = true;
            this._pview.PreviewPane.TabIndex = 0;
            // 
            // _pview.PreviewTextSearchPanel
            // 
            this._pview.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this._pview.PreviewTextSearchPanel.Location = new System.Drawing.Point(530, 0);
            this._pview.PreviewTextSearchPanel.MinimumSize = new System.Drawing.Size(200, 240);
            this._pview.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel";
            this._pview.PreviewTextSearchPanel.Size = new System.Drawing.Size(200, 453);
            this._pview.PreviewTextSearchPanel.TabIndex = 0;
            this._pview.PreviewTextSearchPanel.Visible = false;
            // 
            // _pview.ThumbnailView
            // 
            this._pview.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._pview.PreviewThumbnailView.Location = new System.Drawing.Point(0, 0);
            this._pview.PreviewThumbnailView.Name = "ThumbnailView";
            this._pview.PreviewThumbnailView.Size = new System.Drawing.Size(165, 549);
            this._pview.PreviewThumbnailView.TabIndex = 0;
            this._pview.PreviewThumbnailView.UseImageAsThumbnail = false;
            this._pview.Size = new System.Drawing.Size(971, 622);
            this._pview.TabIndex = 1;
            this._pview.Text = "c1PrintPreviewControl1";
            // 
            // btnMultiDoc
            // 
            this.btnMultiDoc.AutoSize = true;
            this.btnMultiDoc.Location = new System.Drawing.Point(616, 3);
            this.btnMultiDoc.Name = "btnMultiDoc";
            this.btnMultiDoc.Size = new System.Drawing.Size(101, 23);
            this.btnMultiDoc.TabIndex = 5;
            this.btnMultiDoc.Text = "C1MultiDocument";
            this.btnMultiDoc.UseVisualStyleBackColor = true;
            this.btnMultiDoc.Click += new System.EventHandler(this.MultiDocument_Click);
            // 
            // btnSingleDoc
            // 
            this.btnSingleDoc.AutoSize = true;
            this.btnSingleDoc.Location = new System.Drawing.Point(723, 3);
            this.btnSingleDoc.Name = "btnSingleDoc";
            this.btnSingleDoc.Size = new System.Drawing.Size(100, 23);
            this.btnSingleDoc.TabIndex = 6;
            this.btnSingleDoc.Text = "C1PrintDocument";
            this.btnSingleDoc.UseVisualStyleBackColor = true;
            this.btnSingleDoc.Click += new System.EventHandler(this.SingleDocument_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Directory:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(61, 3);
            this.tbDir.Name = "tbDir";
            this.tbDir.Size = new System.Drawing.Size(358, 20);
            this.tbDir.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mask (e.g. \"*.cs\"):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbMask
            // 
            this.tbMask.Location = new System.Drawing.Point(557, 3);
            this.tbMask.Name = "tbMask";
            this.tbMask.Size = new System.Drawing.Size(53, 20);
            this.tbMask.TabIndex = 4;
            this.tbMask.Text = "*.cs";
            // 
            // btnChooseDir
            // 
            this.btnChooseDir.AutoSize = true;
            this.btnChooseDir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnChooseDir.Location = new System.Drawing.Point(425, 3);
            this.btnChooseDir.Name = "btnChooseDir";
            this.btnChooseDir.Size = new System.Drawing.Size(26, 23);
            this.btnChooseDir.TabIndex = 2;
            this.btnChooseDir.Text = "...";
            this.btnChooseDir.UseVisualStyleBackColor = true;
            this.btnChooseDir.Click += new System.EventHandler(this.btnChooseDir_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.tbDir);
            this.flowLayoutPanel1.Controls.Add(this.btnChooseDir);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.tbMask);
            this.flowLayoutPanel1.Controls.Add(this.btnMultiDoc);
            this.flowLayoutPanel1.Controls.Add(this.btnSingleDoc);
            this.flowLayoutPanel1.Controls.Add(this.btnHelp);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(971, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnHelp
            // 
            this.btnHelp.AutoSize = true;
            this.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelp.Location = new System.Drawing.Point(829, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(39, 23);
            this.btnHelp.TabIndex = 7;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 651);
            this.Controls.Add(this._pview);
            this.Controls.Add(this.flowLayoutPanel1);
            this.HelpButton = true;
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this._pview)).EndInit();
            this._pview.ResumeLayout(false);
            this._pview.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Preview.C1PrintPreviewControl _pview;
        private System.Windows.Forms.Button btnMultiDoc;
        private System.Windows.Forms.Button btnSingleDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMask;
        private System.Windows.Forms.Button btnChooseDir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnHelp;
    }
}

