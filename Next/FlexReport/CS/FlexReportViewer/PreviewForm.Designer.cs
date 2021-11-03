namespace FlexReportViewer
{
    partial class PreviewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewForm));
            this.fv = new C1.Win.FlexViewer.C1FlexViewer();
            ((System.ComponentModel.ISupportInitialize)(this.fv)).BeginInit();
            this.SuspendLayout();
            // 
            // fv
            // 
            this.fv.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.fv.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.fv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fv.Location = new System.Drawing.Point(0, 0);
            this.fv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.fv.Name = "fv";
            this.fv.Size = new System.Drawing.Size(1381, 914);
            this.fv.TabIndex = 0;
            // 
            // PreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1381, 914);
            this.Controls.Add(this.fv);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PreviewForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PreviewForm_FormClosing);
            this.Shown += new System.EventHandler(this.PreviewForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.fv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexViewer.C1FlexViewer fv;
    }
}

