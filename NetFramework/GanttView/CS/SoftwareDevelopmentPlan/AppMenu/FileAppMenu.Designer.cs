﻿namespace SoftwareDevelopmentPlan
{
    partial class FileAppMenu
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
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.menuButton1 = new AppMenuButton();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
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
            this.c1InputPanel1.Location = new System.Drawing.Point(19, 67);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(732, 493);
            this.c1InputPanel1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1InputPanel1, "(default)");
            this.c1InputPanel1.VisualStyle = C1.Win.C1InputPanel.VisualStyle.Custom;
            // 
            // menuButton1
            // 
            this.menuButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.menuButton1.ButtonImage = global::SoftwareDevelopmentPlan.Properties.Resources.open_32;
            this.menuButton1.ButtonText = "Browse";
            this.menuButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.menuButton1.Location = new System.Drawing.Point(19, 20);
            this.menuButton1.Margin = new System.Windows.Forms.Padding(5);
            this.menuButton1.Name = "menuButton1";
            this.menuButton1.Size = new System.Drawing.Size(400, 39);
            this.menuButton1.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.menuButton1, "(default)");
            this.menuButton1.Click += new System.EventHandler(this.menuButton1_Click);
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office2016DarkGray";
            // 
            // FileAppMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuButton1);
            this.Controls.Add(this.c1InputPanel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Name = "FileAppMenu";
            this.Size = new System.Drawing.Size(773, 571);
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private AppMenuButton menuButton1;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
    }
}
