namespace ControlExplorer.FlexGrid
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
            this.components = new System.ComponentModel.Container();
            this.chkAsDisplayed = new System.Windows.Forms.CheckBox();
            this.chkIncludeFixedCells = new System.Windows.Forms.CheckBox();
            this.chkNoFreezing = new System.Windows.Forms.CheckBox();
            this.chkOpenXml = new System.Windows.Forms.CheckBox();
            this.chkSaveMergedRanges = new System.Windows.Forms.CheckBox();
            this.chkSelectedRowsOnly = new System.Windows.Forms.CheckBox();
            this.chkVisibleOnly = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkAsDisplayed
            // 
            this.chkAsDisplayed.AutoSize = true;
            this.chkAsDisplayed.Location = new System.Drawing.Point(13, 13);
            this.chkAsDisplayed.Name = "chkAsDisplayed";
            this.chkAsDisplayed.Size = new System.Drawing.Size(87, 17);
            this.chkAsDisplayed.TabIndex = 0;
            this.chkAsDisplayed.Text = "As Displayed";
            this.toolTip1.SetToolTip(this.chkAsDisplayed, "Save values as displayed (including formatting and mapping where available). ");
            this.chkAsDisplayed.UseVisualStyleBackColor = true;
            // 
            // chkIncludeFixedCells
            // 
            this.chkIncludeFixedCells.AutoSize = true;
            this.chkIncludeFixedCells.Location = new System.Drawing.Point(13, 37);
            this.chkIncludeFixedCells.Name = "chkIncludeFixedCells";
            this.chkIncludeFixedCells.Size = new System.Drawing.Size(114, 17);
            this.chkIncludeFixedCells.TabIndex = 1;
            this.chkIncludeFixedCells.Text = "Include Fixed Cells";
            this.toolTip1.SetToolTip(this.chkIncludeFixedCells, "Include fixed cells when loading or saving the grid. ");
            this.chkIncludeFixedCells.UseVisualStyleBackColor = true;
            // 
            // chkNoFreezing
            // 
            this.chkNoFreezing.AutoSize = true;
            this.chkNoFreezing.Location = new System.Drawing.Point(12, 60);
            this.chkNoFreezing.Name = "chkNoFreezing";
            this.chkNoFreezing.Size = new System.Drawing.Size(83, 17);
            this.chkNoFreezing.TabIndex = 3;
            this.chkNoFreezing.Text = "No Freezing";
            this.toolTip1.SetToolTip(this.chkNoFreezing, "Do not freeze rows and columns when exporting to or importing from Excel.");
            this.chkNoFreezing.UseVisualStyleBackColor = true;
            // 
            // chkOpenXml
            // 
            this.chkOpenXml.AutoSize = true;
            this.chkOpenXml.Location = new System.Drawing.Point(12, 84);
            this.chkOpenXml.Name = "chkOpenXml";
            this.chkOpenXml.Size = new System.Drawing.Size(111, 17);
            this.chkOpenXml.TabIndex = 4;
            this.chkOpenXml.Text = "Save as OpenXml";
            this.toolTip1.SetToolTip(this.chkOpenXml, "Load or save file in OpenXml (Office 2007) format. ");
            this.chkOpenXml.UseVisualStyleBackColor = true;
            // 
            // chkSaveMergedRanges
            // 
            this.chkSaveMergedRanges.AutoSize = true;
            this.chkSaveMergedRanges.Location = new System.Drawing.Point(148, 13);
            this.chkSaveMergedRanges.Name = "chkSaveMergedRanges";
            this.chkSaveMergedRanges.Size = new System.Drawing.Size(130, 17);
            this.chkSaveMergedRanges.TabIndex = 5;
            this.chkSaveMergedRanges.Text = "Save Merged Ranges";
            this.toolTip1.SetToolTip(this.chkSaveMergedRanges, "Save merged ranges when exporting to Excel.");
            this.chkSaveMergedRanges.UseVisualStyleBackColor = true;
            // 
            // chkSelectedRowsOnly
            // 
            this.chkSelectedRowsOnly.AutoSize = true;
            this.chkSelectedRowsOnly.Location = new System.Drawing.Point(147, 36);
            this.chkSelectedRowsOnly.Name = "chkSelectedRowsOnly";
            this.chkSelectedRowsOnly.Size = new System.Drawing.Size(122, 17);
            this.chkSelectedRowsOnly.TabIndex = 6;
            this.chkSelectedRowsOnly.Text = "Selected Rows Only";
            this.toolTip1.SetToolTip(this.chkSelectedRowsOnly, "Save only selected rows.");
            this.chkSelectedRowsOnly.UseVisualStyleBackColor = true;
            // 
            // chkVisibleOnly
            // 
            this.chkVisibleOnly.AutoSize = true;
            this.chkVisibleOnly.Location = new System.Drawing.Point(147, 60);
            this.chkVisibleOnly.Name = "chkVisibleOnly";
            this.chkVisibleOnly.Size = new System.Drawing.Size(80, 17);
            this.chkVisibleOnly.TabIndex = 7;
            this.chkVisibleOnly.Text = "Visible Only";
            this.toolTip1.SetToolTip(this.chkVisibleOnly, "Save only visible rows and columns.");
            this.chkVisibleOnly.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(122, 118);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(203, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ExportOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 153);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkVisibleOnly);
            this.Controls.Add(this.chkSelectedRowsOnly);
            this.Controls.Add(this.chkSaveMergedRanges);
            this.Controls.Add(this.chkOpenXml);
            this.Controls.Add(this.chkNoFreezing);
            this.Controls.Add(this.chkIncludeFixedCells);
            this.Controls.Add(this.chkAsDisplayed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExportOptions";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Export Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAsDisplayed;
        private System.Windows.Forms.CheckBox chkIncludeFixedCells;
        private System.Windows.Forms.CheckBox chkNoFreezing;
        private System.Windows.Forms.CheckBox chkOpenXml;
        private System.Windows.Forms.CheckBox chkSaveMergedRanges;
        private System.Windows.Forms.CheckBox chkSelectedRowsOnly;
        private System.Windows.Forms.CheckBox chkVisibleOnly;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}