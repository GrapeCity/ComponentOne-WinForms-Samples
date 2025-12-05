namespace RichTextEditor.BackstageTabs.Items
{
    partial class BackstageTabFileList
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
            this.c1InputPanel1 = new C1.Win.InputPanel.C1InputPanel();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.appMenuTabButton1 = new RichTextEditor.BackstageTabs.Items.BackstageTabButton();
            this.lblCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1InputPanel1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1InputPanel1.DesignScaleFactor = 1.23718F;
            this.c1InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1InputPanel1.Location = new System.Drawing.Point(26, 158);
            this.c1InputPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(630, 218);
            this.c1InputPanel1.TabIndex = 2;
            this.c1ThemeController1.SetTheme(this.c1InputPanel1, "(default)");
            this.c1InputPanel1.VisualStyle = C1.Win.InputPanel.VisualStyle.Custom;
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office2016DarkGray";
            // 
            // appMenuTabButton1
            // 
            this.appMenuTabButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.appMenuTabButton1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.appMenuTabButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.appMenuTabButton1.ItemImage = null;
            this.appMenuTabButton1.ItemText = "label1";
            this.appMenuTabButton1.Location = new System.Drawing.Point(37, 98);
            this.appMenuTabButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.appMenuTabButton1.Name = "appMenuTabButton1";
            this.appMenuTabButton1.Size = new System.Drawing.Size(443, 52);
            this.appMenuTabButton1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.appMenuTabButton1, "(default)");
            this.appMenuTabButton1.Click += new System.EventHandler(this.menuButton1_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.lblCaption.Location = new System.Drawing.Point(24, 9);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(155, 65);
            this.lblCaption.TabIndex = 2;
            this.lblCaption.Text = "label1";
            // 
            // AppMenuTabFileList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.c1InputPanel1);
            this.Controls.Add(this.appMenuTabButton1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AppMenuTabFileList";
            this.Size = new System.Drawing.Size(675, 381);
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BackstageTabButton appMenuTabButton1;
        private C1.Win.InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.Label lblCaption;
    }
}
