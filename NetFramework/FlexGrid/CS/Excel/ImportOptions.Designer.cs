using C1.Win.Input;

namespace Excel
{
    partial class ImportOptions
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
            this.chkLoadAsTransposed = new C1.Win.Input.C1CheckBox();
            this.chkVisibleOnly = new C1.Win.Input.C1CheckBox();
            this.chkLoadMergedRanges = new C1.Win.Input.C1CheckBox();
            this.chkNoFreezing = new C1.Win.Input.C1CheckBox();
            this.chkIncludeFixedCells = new C1.Win.Input.C1CheckBox();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new C1.Win.Input.C1Button();
            this.btnOK = new C1.Win.Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.chkLoadAsTransposed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVisibleOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLoadMergedRanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNoFreezing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncludeFixedCells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            this.SuspendLayout();
            // 
            // chkLoadAsTransposed
            // 
            this.chkLoadAsTransposed.AutoSize = true;
            this.chkLoadAsTransposed.Location = new System.Drawing.Point(222, 56);
            this.chkLoadAsTransposed.Name = "chkLoadAsTransposed";
            this.chkLoadAsTransposed.Size = new System.Drawing.Size(179, 26);
            this.chkLoadAsTransposed.Styles.Button.Default.BackColor = System.Drawing.Color.Transparent;
            this.chkLoadAsTransposed.TabIndex = 17;
            this.chkLoadAsTransposed.Text = "Load As Transposed";
            this.c1ThemeController1.SetTheme(this.chkLoadAsTransposed, "(default)");
            // 
            // chkVisibleOnly
            // 
            this.chkVisibleOnly.AutoSize = true;
            this.chkVisibleOnly.Location = new System.Drawing.Point(15, 97);
            this.chkVisibleOnly.Name = "chkVisibleOnly";
            this.chkVisibleOnly.Size = new System.Drawing.Size(124, 26);
            this.chkVisibleOnly.Styles.Button.Default.BackColor = System.Drawing.Color.Transparent;
            this.chkVisibleOnly.TabIndex = 14;
            this.chkVisibleOnly.Text = "Visible Only";
            this.c1ThemeController1.SetTheme(this.chkVisibleOnly, "(default)");
            // 
            // chkLoadMergedRanges
            // 
            this.chkLoadMergedRanges.AutoSize = true;
            this.chkLoadMergedRanges.Location = new System.Drawing.Point(222, 15);
            this.chkLoadMergedRanges.Name = "chkLoadMergedRanges";
            this.chkLoadMergedRanges.Size = new System.Drawing.Size(188, 26);
            this.chkLoadMergedRanges.Styles.Button.Default.BackColor = System.Drawing.Color.Transparent;
            this.chkLoadMergedRanges.TabIndex = 13;
            this.chkLoadMergedRanges.Text = "Load Merged Ranges";
            this.c1ThemeController1.SetTheme(this.chkLoadMergedRanges, "(default)");
            // 
            // chkNoFreezing
            // 
            this.chkNoFreezing.AutoSize = true;
            this.chkNoFreezing.Location = new System.Drawing.Point(15, 56);
            this.chkNoFreezing.Name = "chkNoFreezing";
            this.chkNoFreezing.Size = new System.Drawing.Size(125, 26);
            this.chkNoFreezing.Styles.Button.Default.BackColor = System.Drawing.Color.Transparent;
            this.chkNoFreezing.TabIndex = 12;
            this.chkNoFreezing.Text = "No Freezing";
            this.c1ThemeController1.SetTheme(this.chkNoFreezing, "(default)");
            // 
            // chkIncludeFixedCells
            // 
            this.chkIncludeFixedCells.AutoSize = true;
            this.chkIncludeFixedCells.Location = new System.Drawing.Point(15, 15);
            this.chkIncludeFixedCells.Name = "chkIncludeFixedCells";
            this.chkIncludeFixedCells.Size = new System.Drawing.Size(168, 26);
            this.chkIncludeFixedCells.Styles.Button.Default.BackColor = System.Drawing.Color.Transparent;
            this.chkIncludeFixedCells.TabIndex = 11;
            this.chkIncludeFixedCells.Text = "Include Fixed Cells";
            this.c1ThemeController1.SetTheme(this.chkIncludeFixedCells, "(default)");
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office365Colorful";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.chkLoadAsTransposed);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.chkVisibleOnly);
            this.panel1.Controls.Add(this.chkLoadMergedRanges);
            this.panel1.Controls.Add(this.chkNoFreezing);
            this.panel1.Controls.Add(this.chkIncludeFixedCells);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 188);
            this.panel1.TabIndex = 11;
            this.c1ThemeController1.SetTheme(this.panel1, "(default)");
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(309, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 16;
            this.button1.Text = "Cancel";
            this.c1ThemeController1.SetTheme(this.button1, "(default)");
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(197, 141);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 35);
            this.btnOK.TabIndex = 15;
            this.btnOK.Text = "OK";
            this.c1ThemeController1.SetTheme(this.btnOK, "(default)");
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ImportOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 188);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Import Options";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.chkLoadAsTransposed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVisibleOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkLoadMergedRanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNoFreezing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncludeFixedCells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal C1.Win.Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.Panel panel1;
        private C1CheckBox chkLoadAsTransposed;
        private C1Button button1;
        private C1Button btnOK;
        private C1CheckBox chkVisibleOnly;
        private C1CheckBox chkLoadMergedRanges;
        private C1CheckBox chkNoFreezing;
        private C1CheckBox chkIncludeFixedCells;
    }
}