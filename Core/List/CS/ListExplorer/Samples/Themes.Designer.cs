namespace ListExplorer.Samples
{
    partial class Themes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themes));
            this.c1Combo1 = new C1.Win.List.C1Combo();
            this.c1List1 = new C1.Win.List.C1List();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbThemePicker = new C1.Win.List.C1Combo();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1List1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbThemePicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Combo1
            // 
            this.c1Combo1.Caption = "";
            this.c1Combo1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.c1Combo1.DeadAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1Combo1.Location = new System.Drawing.Point(3, 61);
            this.c1Combo1.MatchEntryTimeout = ((long)(2000));
            this.c1Combo1.MaxDropDownItems = ((short)(5));
            this.c1Combo1.MaxLength = 32767;
            this.c1Combo1.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.c1Combo1.Name = "c1Combo1";
            this.c1Combo1.PropBag = resources.GetString("c1Combo1.PropBag");
            this.c1Combo1.RowDivider.Style = C1.Win.List.LineStyleEnum.Single;
            this.c1Combo1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1Combo1.Size = new System.Drawing.Size(493, 24);
            this.c1Combo1.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.c1Combo1, "(default)");
            // 
            // c1List1
            // 
            this.c1List1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1List1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.c1List1.DeadAreaBackColor = System.Drawing.SystemColors.ControlDark;
            this.c1List1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.c1List1.Location = new System.Drawing.Point(3, 91);
            this.c1List1.MatchEntryTimeout = ((long)(2000));
            this.c1List1.Name = "c1List1";
            this.c1List1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1List1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1List1.PreviewInfo.ZoomFactor = 75D;
            this.c1List1.PropBag = resources.GetString("c1List1.PropBag");
            this.c1List1.RowDivider.Style = C1.Win.List.LineStyleEnum.Single;
            this.c1List1.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.c1List1.Size = new System.Drawing.Size(493, 237);
            this.c1List1.TabIndex = 1;
            this.c1List1.Text = "c1List1";
            this.c1ThemeController1.SetTheme(this.c1List1, "(default)");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Theme picker:";
            this.c1ThemeController1.SetTheme(this.label1, "(default)");
            // 
            // cmbThemePicker
            // 
            this.cmbThemePicker.Caption = "";
            this.cmbThemePicker.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbThemePicker.DeadAreaBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmbThemePicker.Location = new System.Drawing.Point(94, 14);
            this.cmbThemePicker.MatchEntryTimeout = ((long)(2000));
            this.cmbThemePicker.MaxDropDownItems = ((short)(5));
            this.cmbThemePicker.MaxLength = 32767;
            this.cmbThemePicker.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbThemePicker.Name = "cmbThemePicker";
            this.cmbThemePicker.PropBag = resources.GetString("cmbThemePicker.PropBag");
            this.cmbThemePicker.RowDivider.Style = C1.Win.List.LineStyleEnum.Single;
            this.cmbThemePicker.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbThemePicker.Size = new System.Drawing.Size(196, 24);
            this.cmbThemePicker.TabIndex = 3;
            this.c1ThemeController1.SetTheme(this.cmbThemePicker, "(default)");
            this.cmbThemePicker.SelectionChangeCommitted += new System.EventHandler(this.cmbThemePicker_SelectionChangeCommitted);
            // 
            // Themes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbThemePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c1List1);
            this.Controls.Add(this.c1Combo1);
            this.Name = "Themes";
            this.Size = new System.Drawing.Size(499, 331);
            this.c1ThemeController1.SetTheme(this, "(default)");
            this.Load += new System.EventHandler(this.Themes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Combo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1List1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbThemePicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.List.C1Combo c1Combo1;
        private C1.Win.List.C1List c1List1;
        private System.Windows.Forms.Label label1;
        private C1.Win.List.C1Combo cmbThemePicker;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
    }
}
