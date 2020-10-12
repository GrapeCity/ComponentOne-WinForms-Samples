namespace UserCSS.Controls
{
    partial class CSSChooser
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnApplyCSS = new System.Windows.Forms.Button();
            this.tbCustomDesignCSS = new System.Windows.Forms.TextBox();
            this.rbFileDesignCSS = new System.Windows.Forms.RadioButton();
            this.rbCustomDesignCSS = new System.Windows.Forms.RadioButton();
            this.rbNoDesignCSS = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblFileName.Location = new System.Drawing.Point(24, 45);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(143, 43);
            this.lblFileName.TabIndex = 13;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowse.Enabled = false;
            this.btnBrowse.Location = new System.Drawing.Point(110, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(63, 20);
            this.btnBrowse.TabIndex = 12;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnApplyCSS
            // 
            this.btnApplyCSS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplyCSS.Location = new System.Drawing.Point(0, 179);
            this.btnApplyCSS.Name = "btnApplyCSS";
            this.btnApplyCSS.Size = new System.Drawing.Size(115, 26);
            this.btnApplyCSS.TabIndex = 11;
            this.btnApplyCSS.Text = "Apply Custom CSS";
            this.btnApplyCSS.UseVisualStyleBackColor = true;
            this.btnApplyCSS.Click += new System.EventHandler(this.btnApplyCSS_Click);
            // 
            // tbCustomDesignCSS
            // 
            this.tbCustomDesignCSS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCustomDesignCSS.Enabled = false;
            this.tbCustomDesignCSS.Location = new System.Drawing.Point(3, 114);
            this.tbCustomDesignCSS.Multiline = true;
            this.tbCustomDesignCSS.Name = "tbCustomDesignCSS";
            this.tbCustomDesignCSS.Size = new System.Drawing.Size(170, 62);
            this.tbCustomDesignCSS.TabIndex = 10;
            // 
            // rbFileDesignCSS
            // 
            this.rbFileDesignCSS.AutoSize = true;
            this.rbFileDesignCSS.Location = new System.Drawing.Point(4, 25);
            this.rbFileDesignCSS.Name = "rbFileDesignCSS";
            this.rbFileDesignCSS.Size = new System.Drawing.Size(85, 17);
            this.rbFileDesignCSS.TabIndex = 9;
            this.rbFileDesignCSS.Text = "CSS from file";
            this.rbFileDesignCSS.UseVisualStyleBackColor = true;
            this.rbFileDesignCSS.CheckedChanged += new System.EventHandler(this.rbFileDesignCSS_CheckedChanged);
            // 
            // rbCustomDesignCSS
            // 
            this.rbCustomDesignCSS.AutoSize = true;
            this.rbCustomDesignCSS.Location = new System.Drawing.Point(4, 91);
            this.rbCustomDesignCSS.Name = "rbCustomDesignCSS";
            this.rbCustomDesignCSS.Size = new System.Drawing.Size(120, 17);
            this.rbCustomDesignCSS.TabIndex = 8;
            this.rbCustomDesignCSS.Text = "CSS from text below";
            this.rbCustomDesignCSS.UseVisualStyleBackColor = true;
            this.rbCustomDesignCSS.CheckedChanged += new System.EventHandler(this.rbCustomDesignCSS_CheckedChanged);
            // 
            // rbNoDesignCSS
            // 
            this.rbNoDesignCSS.AutoSize = true;
            this.rbNoDesignCSS.Checked = true;
            this.rbNoDesignCSS.Location = new System.Drawing.Point(4, 2);
            this.rbNoDesignCSS.Name = "rbNoDesignCSS";
            this.rbNoDesignCSS.Size = new System.Drawing.Size(63, 17);
            this.rbNoDesignCSS.TabIndex = 7;
            this.rbNoDesignCSS.TabStop = true;
            this.rbNoDesignCSS.Text = "No CSS";
            this.rbNoDesignCSS.UseVisualStyleBackColor = true;
            this.rbNoDesignCSS.CheckedChanged += new System.EventHandler(this.rbNoDesignCSS_CheckedChanged);
            // 
            // CSSChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnApplyCSS);
            this.Controls.Add(this.tbCustomDesignCSS);
            this.Controls.Add(this.rbFileDesignCSS);
            this.Controls.Add(this.rbCustomDesignCSS);
            this.Controls.Add(this.rbNoDesignCSS);
            this.Name = "CSSChooser";
            this.Size = new System.Drawing.Size(176, 211);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnApplyCSS;
        private System.Windows.Forms.TextBox tbCustomDesignCSS;
        private System.Windows.Forms.RadioButton rbFileDesignCSS;
        private System.Windows.Forms.RadioButton rbCustomDesignCSS;
        private System.Windows.Forms.RadioButton rbNoDesignCSS;
    }
}
