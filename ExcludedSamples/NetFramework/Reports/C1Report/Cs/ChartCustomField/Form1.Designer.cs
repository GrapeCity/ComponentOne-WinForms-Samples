namespace ChartCustomField_2010
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
            this._ppv = new C1.Win.C1Preview.C1PrintPreviewControl();
            this.labelSelectReport = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._ppv.PreviewPane)).BeginInit();
            this.SuspendLayout();
            // 
            // _ppv
            // 
            this._ppv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._ppv.Location = new System.Drawing.Point(200, 0);
            this._ppv.Name = "_ppv";
            // 
            // 
            // 
            this._ppv.PreviewPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ppv.PreviewPane.IntegrateExternalTools = true;
            this._ppv.PreviewPane.Location = new System.Drawing.Point(177, 0);
            this._ppv.PreviewPane.Name = "previewPane";
            this._ppv.PreviewPane.Size = new System.Drawing.Size(403, 513);
            this._ppv.PreviewPane.TabIndex = 0;
            this._ppv.Size = new System.Drawing.Size(580, 560);
            this._ppv.TabIndex = 0;
            // 
            // labelSelectReport
            // 
            this.labelSelectReport.AutoSize = true;
            this.labelSelectReport.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSelectReport.Location = new System.Drawing.Point(10, 10);
            this.labelSelectReport.Name = "labelSelectReport";
            this.labelSelectReport.Size = new System.Drawing.Size(185, 19);
            this.labelSelectReport.TabIndex = 0;
            this.labelSelectReport.Text = "Select a Report:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 559);
            this.Controls.Add(this.labelSelectReport);
            this.Controls.Add(this._ppv);
            this.Name = "Form1";
            this.Text = "Chart Custom Field";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._ppv.PreviewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._ppv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Preview.C1PrintPreviewControl _ppv;
        private System.Windows.Forms.Label labelSelectReport;



    }
}

