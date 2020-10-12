namespace C1HTMLSample
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
            this.c1PreviewPane1 = new C1.Win.C1Preview.C1PreviewPane();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintDocument1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PreviewPane1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1PreviewPane1
            // 
            this.c1PreviewPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PreviewPane1.Document = this.c1PrintDocument1;
            this.c1PreviewPane1.Location = new System.Drawing.Point(0, 0);
            this.c1PreviewPane1.Name = "c1PreviewPane1";
            this.c1PreviewPane1.Size = new System.Drawing.Size(534, 361);
            this.c1PreviewPane1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 361);
            this.Controls.Add(this.c1PreviewPane1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintDocument1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PreviewPane1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.C1Preview.C1PrintDocument c1PrintDocument1;
        private C1.Win.C1Preview.C1PreviewPane c1PreviewPane1;
    }
}