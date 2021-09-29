namespace AutoSizeTable
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
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).BeginInit();
            this.SuspendLayout();
            // 
            // c1PrintPreviewControl1
            // 
            this.c1PrintPreviewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PrintPreviewControl1.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c1PrintPreviewControl1.Name = "c1PrintPreviewControl1";
            // 
            // 
            // 
            this.c1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = true;
            this.c1PrintPreviewControl1.PreviewPane.Location = new System.Drawing.Point(0, 0);
            this.c1PrintPreviewControl1.PreviewPane.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c1PrintPreviewControl1.PreviewPane.Name = "previewPane";
            this.c1PrintPreviewControl1.PreviewPane.Size = new System.Drawing.Size(233, 300);
            this.c1PrintPreviewControl1.PreviewPane.TabIndex = 0;
            this.c1PrintPreviewControl1.Size = new System.Drawing.Size(930, 750);
            this.c1PrintPreviewControl1.TabIndex = 0;
            this.c1PrintPreviewControl1.Text = "c1PrintPreviewControl1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 750);
            this.Controls.Add(this.c1PrintPreviewControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "AutoSize Table";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Preview.C1PrintPreviewControl c1PrintPreviewControl1;
    }
}

