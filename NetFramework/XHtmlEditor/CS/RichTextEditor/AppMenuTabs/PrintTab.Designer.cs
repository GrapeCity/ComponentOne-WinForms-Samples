namespace RichTextEditor.AppMenuTabs
{
    partial class PrintTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCaption = new System.Windows.Forms.Label();
            this.btnQPrint = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.c1PrintPreviewControl1 = new C1.Win.C1Preview.C1PrintPreviewControl();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.lblCaption.Location = new System.Drawing.Point(21, 7);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(155, 40);
            this.lblCaption.TabIndex = 3;
            this.lblCaption.Text = "label1";
            // 
            // btnQPrint
            // 
            this.btnQPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnQPrint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnQPrint.Location = new System.Drawing.Point(44, 80);
            this.btnQPrint.Name = "btnQPrint";
            this.btnQPrint.Size = new System.Drawing.Size(81, 86);
            this.btnQPrint.TabIndex = 4;
            this.btnQPrint.Text = "button1";
            this.btnQPrint.UseVisualStyleBackColor = false;
            this.btnQPrint.Click += new System.EventHandler(this.btnQPrint_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnPrint.Location = new System.Drawing.Point(44, 200);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 86);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "button2";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // c1PrintPreviewControl1
            // 
            this.c1PrintPreviewControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1PrintPreviewControl1.Location = new System.Drawing.Point(160, 60);
            this.c1PrintPreviewControl1.Name = "c1PrintPreviewControl1";
            this.c1PrintPreviewControl1.NavigationPanelVisible = false;
            this.c1PrintPreviewControl1.PreviewPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1PrintPreviewControl1.PreviewPane.ZoomMode = C1.Win.C1Preview.ZoomModeEnum.WholePage;
            this.c1PrintPreviewControl1.PreviewPane.IntegrateExternalTools = true;
            this.c1PrintPreviewControl1.PreviewPane.Name = "previewPane";
            this.c1PrintPreviewControl1.PreviewPane.Size = new System.Drawing.Size(553, 448);
            this.c1PrintPreviewControl1.PreviewPane.TabIndex = 0;
            this.c1PrintPreviewControl1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1PrintPreviewControl1, "(default)");
            // 
            // PrintTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnQPrint);
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.c1PrintPreviewControl1);
            this.Name = "PrintTab";
            this.Size = new System.Drawing.Size(933, 604);
            this.c1ThemeController1.SetTheme(this, "Office2016DarkGray");
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1.PreviewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1PrintPreviewControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Button btnQPrint;
        private System.Windows.Forms.Button btnPrint;
        private C1.Win.C1Preview.C1PrintPreviewControl c1PrintPreviewControl1;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
    }
}
