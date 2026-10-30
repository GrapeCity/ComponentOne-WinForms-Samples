using C1.Win.Input;

namespace Excel
{
    partial class ExportOptions
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
            this.chkExcludeFooters = new C1.Win.Input.C1CheckBox();
            this.chkVisibleOnly = new C1.Win.Input.C1CheckBox();
            this.chkSelectedRowsOnly = new C1.Win.Input.C1CheckBox();
            this.chkSaveMergedRanges = new C1.Win.Input.C1CheckBox();
            this.chkOpenXml = new C1.Win.Input.C1CheckBox();
            this.chkNoFreezing = new C1.Win.Input.C1CheckBox();
            this.chkIncludeFixedCells = new C1.Win.Input.C1CheckBox();
            this.chkAsDisplayed = new C1.Win.Input.C1CheckBox();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new C1.Win.Input.C1Button();
            this.btnOK = new C1.Win.Input.C1Button();
            ((System.ComponentModel.ISupportInitialize)(this.chkExcludeFooters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVisibleOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectedRowsOnly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSaveMergedRanges)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOpenXml)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNoFreezing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncludeFixedCells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAsDisplayed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOK)).BeginInit();
            this.SuspendLayout();
            // 
            // chkExcludeFooters
            // 
            this.chkExcludeFooters.AutoSize = true;
            this.chkExcludeFooters.Location = new System.Drawing.Point(204, 88);
            this.chkExcludeFooters.Name = "chkExcludeFooters";
            this.chkExcludeFooters.Size = new System.Drawing.Size(165, 27);
            this.chkExcludeFooters.TabIndex = 18;
            this.chkExcludeFooters.Text = "Exclude Footers";
            this.c1ThemeController1.SetTheme(this.chkExcludeFooters, "(default)");
            // 
            // chkVisibleOnly
            // 
            this.chkVisibleOnly.AutoSize = true;
            this.chkVisibleOnly.Location = new System.Drawing.Point(204, 126);
            this.chkVisibleOnly.Name = "chkVisibleOnly";
            this.chkVisibleOnly.Size = new System.Drawing.Size(133, 27);
            this.chkVisibleOnly.TabIndex = 17;
            this.chkVisibleOnly.Text = "Visible Only";
            this.c1ThemeController1.SetTheme(this.chkVisibleOnly, "(default)");
            // 
            // chkSelectedRowsOnly
            // 
            this.chkSelectedRowsOnly.AutoSize = true;
            this.chkSelectedRowsOnly.Location = new System.Drawing.Point(204, 50);
            this.chkSelectedRowsOnly.Name = "chkSelectedRowsOnly";
            this.chkSelectedRowsOnly.Size = new System.Drawing.Size(196, 27);
            this.chkSelectedRowsOnly.TabIndex = 16;
            this.chkSelectedRowsOnly.Text = "Selected Rows Only";
            this.c1ThemeController1.SetTheme(this.chkSelectedRowsOnly, "(default)");
            // 
            // chkSaveMergedRanges
            // 
            this.chkSaveMergedRanges.AutoSize = true;
            this.chkSaveMergedRanges.Location = new System.Drawing.Point(204, 12);
            this.chkSaveMergedRanges.Name = "chkSaveMergedRanges";
            this.chkSaveMergedRanges.Size = new System.Drawing.Size(209, 27);
            this.chkSaveMergedRanges.TabIndex = 15;
            this.chkSaveMergedRanges.Text = "Save Merged Ranges";
            this.c1ThemeController1.SetTheme(this.chkSaveMergedRanges, "(default)");
            // 
            // chkOpenXml
            // 
            this.chkOpenXml.AutoSize = true;
            this.chkOpenXml.Location = new System.Drawing.Point(12, 126);
            this.chkOpenXml.Name = "chkOpenXml";
            this.chkOpenXml.Size = new System.Drawing.Size(178, 27);
            this.chkOpenXml.TabIndex = 14;
            this.chkOpenXml.Text = "Save as OpenXml";
            this.c1ThemeController1.SetTheme(this.chkOpenXml, "(default)");
            // 
            // chkNoFreezing
            // 
            this.chkNoFreezing.AutoSize = true;
            this.chkNoFreezing.Location = new System.Drawing.Point(12, 88);
            this.chkNoFreezing.Name = "chkNoFreezing";
            this.chkNoFreezing.Size = new System.Drawing.Size(135, 27);
            this.chkNoFreezing.TabIndex = 13;
            this.chkNoFreezing.Text = "No Freezing";
            this.c1ThemeController1.SetTheme(this.chkNoFreezing, "(default)");
            // 
            // chkIncludeFixedCells
            // 
            this.chkIncludeFixedCells.AutoSize = true;
            this.chkIncludeFixedCells.Location = new System.Drawing.Point(12, 50);
            this.chkIncludeFixedCells.Name = "chkIncludeFixedCells";
            this.chkIncludeFixedCells.Size = new System.Drawing.Size(189, 27);
            this.chkIncludeFixedCells.TabIndex = 12;
            this.chkIncludeFixedCells.Text = "Include Fixed Cells";
            this.c1ThemeController1.SetTheme(this.chkIncludeFixedCells, "(default)");
            // 
            // chkAsDisplayed
            // 
            this.chkAsDisplayed.AutoSize = true;
            this.chkAsDisplayed.Location = new System.Drawing.Point(12, 12);
            this.chkAsDisplayed.Name = "chkAsDisplayed";
            this.chkAsDisplayed.Size = new System.Drawing.Size(140, 27);
            this.chkAsDisplayed.TabIndex = 11;
            this.chkAsDisplayed.Text = "As Displayed";
            this.c1ThemeController1.SetTheme(this.chkAsDisplayed, "(default)");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnOK);
            this.panel1.Controls.Add(this.chkExcludeFooters);
            this.panel1.Controls.Add(this.chkVisibleOnly);
            this.panel1.Controls.Add(this.chkSelectedRowsOnly);
            this.panel1.Controls.Add(this.chkSaveMergedRanges);
            this.panel1.Controls.Add(this.chkOpenXml);
            this.panel1.Controls.Add(this.chkNoFreezing);
            this.panel1.Controls.Add(this.chkIncludeFixedCells);
            this.panel1.Controls.Add(this.chkAsDisplayed);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 221);
            this.panel1.TabIndex = 11;
            this.c1ThemeController1.SetTheme(this.panel1, "(default)");
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(288, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cancel";
            this.c1ThemeController1.SetTheme(this.button1, "(default)");
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(173, 174);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(100, 35);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            this.c1ThemeController1.SetTheme(this.btnOK, "(default)");
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // ExportOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 221);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Options";
            this.c1ThemeController1.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.chkExcludeFooters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkVisibleOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSelectedRowsOnly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSaveMergedRanges)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkOpenXml)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNoFreezing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkIncludeFixedCells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkAsDisplayed)).EndInit();
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
        private C1Button button1;
        private C1Button btnOK;
        private C1CheckBox chkExcludeFooters;
        private C1CheckBox chkVisibleOnly;
        private C1CheckBox chkSelectedRowsOnly;
        private C1CheckBox chkSaveMergedRanges;
        private C1CheckBox chkOpenXml;
        private C1CheckBox chkNoFreezing;
        private C1CheckBox chkIncludeFixedCells;
        private C1CheckBox chkAsDisplayed;
    }
}