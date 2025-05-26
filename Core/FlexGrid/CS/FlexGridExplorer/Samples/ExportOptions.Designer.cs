namespace FlexGridExplorer.Samples
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
            components = new System.ComponentModel.Container();
            btnOK = new C1.Win.Input.C1Button();
            button1 = new C1.Win.Input.C1Button();
            chkAsDisplayed = new C1.Win.Input.C1CheckBox();
            chkSaveMergedRanges = new C1.Win.Input.C1CheckBox();
            chkSelectedRowsOnly = new C1.Win.Input.C1CheckBox();
            chkIncludeFixedCells = new C1.Win.Input.C1CheckBox();
            chkVisibleOnly = new C1.Win.Input.C1CheckBox();
            chkNoFreezing = new C1.Win.Input.C1CheckBox();
            chkOpenXml = new C1.Win.Input.C1CheckBox();
            toolTip1 = new System.Windows.Forms.ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)btnOK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)button1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkAsDisplayed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkSaveMergedRanges).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkSelectedRowsOnly).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkIncludeFixedCells).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkVisibleOnly).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkNoFreezing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkOpenXml).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Location = new System.Drawing.Point(163, 145);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(94, 29);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // button1
            // 
            button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            button1.Location = new System.Drawing.Point(271, 145);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Cancel";
            // 
            // chkAsDisplayed
            // 
            chkAsDisplayed.AutoSize = true;
            chkAsDisplayed.Location = new System.Drawing.Point(17, 16);
            chkAsDisplayed.Name = "chkAsDisplayed";
            chkAsDisplayed.Size = new System.Drawing.Size(119, 22);
            chkAsDisplayed.TabIndex = 2;
            chkAsDisplayed.Text = "As Displayed";
            toolTip1.SetToolTip(chkAsDisplayed, "Save values as displayed (including formatting and mapping where available). ");
            // 
            // chkSaveMergedRanges
            // 
            chkSaveMergedRanges.AutoSize = true;
            chkSaveMergedRanges.Location = new System.Drawing.Point(196, 16);
            chkSaveMergedRanges.Name = "chkSaveMergedRanges";
            chkSaveMergedRanges.Size = new System.Drawing.Size(172, 22);
            chkSaveMergedRanges.TabIndex = 3;
            chkSaveMergedRanges.Text = "Save Merged Ranges";
            toolTip1.SetToolTip(chkSaveMergedRanges, "Save merged ranges when exporting to Excel.");
            // 
            // chkSelectedRowsOnly
            // 
            chkSelectedRowsOnly.AutoSize = true;
            chkSelectedRowsOnly.Location = new System.Drawing.Point(196, 44);
            chkSelectedRowsOnly.Name = "chkSelectedRowsOnly";
            chkSelectedRowsOnly.Size = new System.Drawing.Size(163, 22);
            chkSelectedRowsOnly.TabIndex = 5;
            chkSelectedRowsOnly.Text = "Selected Rows Only";
            toolTip1.SetToolTip(chkSelectedRowsOnly, "Save only selected rows.");
            // 
            // chkIncludeFixedCells
            // 
            chkIncludeFixedCells.AutoSize = true;
            chkIncludeFixedCells.Location = new System.Drawing.Point(17, 46);
            chkIncludeFixedCells.Name = "chkIncludeFixedCells";
            chkIncludeFixedCells.Size = new System.Drawing.Size(155, 22);
            chkIncludeFixedCells.TabIndex = 4;
            chkIncludeFixedCells.Text = "Include Fixed Cells";
            toolTip1.SetToolTip(chkIncludeFixedCells, "Include fixed cells when loading or saving the grid. ");
            // 
            // chkVisibleOnly
            // 
            chkVisibleOnly.AutoSize = true;
            chkVisibleOnly.Location = new System.Drawing.Point(196, 74);
            chkVisibleOnly.Name = "chkVisibleOnly";
            chkVisibleOnly.Size = new System.Drawing.Size(111, 22);
            chkVisibleOnly.TabIndex = 7;
            chkVisibleOnly.Text = "Visible Only";
            toolTip1.SetToolTip(chkVisibleOnly, "Save only visible rows and columns.");
            // 
            // chkNoFreezing
            // 
            chkNoFreezing.AutoSize = true;
            chkNoFreezing.Location = new System.Drawing.Point(16, 74);
            chkNoFreezing.Name = "chkNoFreezing";
            chkNoFreezing.Size = new System.Drawing.Size(113, 22);
            chkNoFreezing.TabIndex = 6;
            chkNoFreezing.Text = "No Freezing";
            toolTip1.SetToolTip(chkNoFreezing, "Do not freeze rows and columns when exporting to or importing from Excel.");
            // 
            // chkOpenXml
            // 
            chkOpenXml.AutoSize = true;
            chkOpenXml.Location = new System.Drawing.Point(16, 103);
            chkOpenXml.Name = "chkOpenXml";
            chkOpenXml.Size = new System.Drawing.Size(148, 22);
            chkOpenXml.TabIndex = 8;
            chkOpenXml.Text = "Save as OpenXml";
            toolTip1.SetToolTip(chkOpenXml, "Load or save file in OpenXml (Office 2007) format. ");
            // 
            // ExportOptions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(387, 188);
            Controls.Add(chkOpenXml);
            Controls.Add(chkVisibleOnly);
            Controls.Add(chkNoFreezing);
            Controls.Add(chkSelectedRowsOnly);
            Controls.Add(chkIncludeFixedCells);
            Controls.Add(chkSaveMergedRanges);
            Controls.Add(chkAsDisplayed);
            Controls.Add(button1);
            Controls.Add(btnOK);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExportOptions";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Export Option";
            ((System.ComponentModel.ISupportInitialize)btnOK).EndInit();
            ((System.ComponentModel.ISupportInitialize)button1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkAsDisplayed).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkSaveMergedRanges).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkSelectedRowsOnly).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkIncludeFixedCells).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkVisibleOnly).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkNoFreezing).EndInit();
            ((System.ComponentModel.ISupportInitialize)chkOpenXml).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private C1.Win.Input.C1Button btnOK;
        private C1.Win.Input.C1Button button1;
        private C1.Win.Input.C1CheckBox chkAsDisplayed;
        private C1.Win.Input.C1CheckBox chkSaveMergedRanges;
        private C1.Win.Input.C1CheckBox chkSelectedRowsOnly;
        private C1.Win.Input.C1CheckBox chkIncludeFixedCells;
        private C1.Win.Input.C1CheckBox chkVisibleOnly;
        private C1.Win.Input.C1CheckBox chkNoFreezing;
        private C1.Win.Input.C1CheckBox chkOpenXml;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}