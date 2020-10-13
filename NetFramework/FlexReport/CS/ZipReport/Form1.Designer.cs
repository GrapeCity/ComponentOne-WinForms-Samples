namespace ZipReport
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
            this._flexView = new C1.Win.FlexViewer.C1FlexViewerPane();
            this._flxr = new C1.Win.FlexReport.C1FlexReport();
            this._btnRender = new System.Windows.Forms.Button();
            this._lbReports = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._flexView)).BeginInit();
            this.SuspendLayout();
            // 
            // _flexView
            // 
            this._flexView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._flexView.Location = new System.Drawing.Point(240, 2);
            this._flexView.Name = "_flexView";
            this._flexView.Size = new System.Drawing.Size(685, 672);
            this._flexView.TabIndex = 0;
            this._flexView.ZoomMode = C1.Win.FlexViewer.FlexViewerZoomMode.WholePage;
            // 
            // _flxr
            // 
            this._flxr.ReportDefinition = resources.GetString("_flxr.ReportDefinition");
            this._flxr.ReportName = "c1FlexReport1";
            // 
            // _btnRender
            // 
            this._btnRender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnRender.Location = new System.Drawing.Point(12, 571);
            this._btnRender.Name = "_btnRender";
            this._btnRender.Size = new System.Drawing.Size(222, 34);
            this._btnRender.TabIndex = 1;
            this._btnRender.Text = "Render";
            this._btnRender.UseVisualStyleBackColor = true;
            this._btnRender.Click += new System.EventHandler(this._btnRender_Click);
            // 
            // _lbReports
            // 
            this._lbReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this._lbReports.FormattingEnabled = true;
            this._lbReports.Location = new System.Drawing.Point(12, 37);
            this._lbReports.Name = "_lbReports";
            this._lbReports.Size = new System.Drawing.Size(222, 511);
            this._lbReports.TabIndex = 2;
            this._lbReports.DoubleClick += new System.EventHandler(this._lbReports_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select a report to render:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 674);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._lbReports);
            this.Controls.Add(this._btnRender);
            this.Controls.Add(this._flexView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ZipReport";
            ((System.ComponentModel.ISupportInitialize)(this._flexView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.FlexViewer.C1FlexViewerPane _flexView;
        private C1.Win.FlexReport.C1FlexReport _flxr;
        private System.Windows.Forms.Button _btnRender;
        private System.Windows.Forms.ListBox _lbReports;
        private System.Windows.Forms.Label label1;
    }
}

