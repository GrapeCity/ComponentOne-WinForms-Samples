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
            toolTip1 = new ToolTip(components);
            c1CheckBoxExcludeFooters = new C1.Win.Input.C1CheckBox();
            ((System.ComponentModel.ISupportInitialize)btnOK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)button1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkAsDisplayed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkSaveMergedRanges).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkSelectedRowsOnly).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkIncludeFixedCells).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkVisibleOnly).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkNoFreezing).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chkOpenXml).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1CheckBoxExcludeFooters).BeginInit();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(143, 109);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 22);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.Click += btnOK_Click;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(237, 109);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 1;
            button1.Text = "Cancel";
            // 
            // chkAsDisplayed
            // 
            chkAsDisplayed.AutoSize = true;
            chkAsDisplayed.Location = new Point(15, 12);
            chkAsDisplayed.Name = "chkAsDisplayed";
            chkAsDisplayed.Size = new Size(95, 19);
            chkAsDisplayed.TabIndex = 2;
            chkAsDisplayed.Text = "As Displayed";
            toolTip1.SetToolTip(chkAsDisplayed, "Save values as displayed (including formatting and mapping where available). ");
            // 
            // chkSaveMergedRanges
            // 
            chkSaveMergedRanges.AutoSize = true;
            chkSaveMergedRanges.Location = new Point(172, 12);
            chkSaveMergedRanges.Name = "chkSaveMergedRanges";
            chkSaveMergedRanges.Size = new Size(137, 19);
            chkSaveMergedRanges.TabIndex = 3;
            chkSaveMergedRanges.Text = "Save Merged Ranges";
            toolTip1.SetToolTip(chkSaveMergedRanges, "Save merged ranges when exporting to Excel.");
            // 
            // chkSelectedRowsOnly
            // 
            chkSelectedRowsOnly.AutoSize = true;
            chkSelectedRowsOnly.Location = new Point(172, 33);
            chkSelectedRowsOnly.Name = "chkSelectedRowsOnly";
            chkSelectedRowsOnly.Size = new Size(131, 19);
            chkSelectedRowsOnly.TabIndex = 5;
            chkSelectedRowsOnly.Text = "Selected Rows Only";
            toolTip1.SetToolTip(chkSelectedRowsOnly, "Save only selected rows.");
            // 
            // chkIncludeFixedCells
            // 
            chkIncludeFixedCells.AutoSize = true;
            chkIncludeFixedCells.Location = new Point(15, 34);
            chkIncludeFixedCells.Name = "chkIncludeFixedCells";
            chkIncludeFixedCells.Size = new Size(126, 19);
            chkIncludeFixedCells.TabIndex = 4;
            chkIncludeFixedCells.Text = "Include Fixed Cells";
            toolTip1.SetToolTip(chkIncludeFixedCells, "Include fixed cells when loading or saving the grid. ");
            // 
            // chkVisibleOnly
            // 
            chkVisibleOnly.AutoSize = true;
            chkVisibleOnly.Location = new Point(172, 56);
            chkVisibleOnly.Name = "chkVisibleOnly";
            chkVisibleOnly.Size = new Size(90, 19);
            chkVisibleOnly.TabIndex = 7;
            chkVisibleOnly.Text = "Visible Only";
            toolTip1.SetToolTip(chkVisibleOnly, "Save only visible rows and columns.");
            // 
            // chkNoFreezing
            // 
            chkNoFreezing.AutoSize = true;
            chkNoFreezing.Location = new Point(14, 56);
            chkNoFreezing.Name = "chkNoFreezing";
            chkNoFreezing.Size = new Size(91, 19);
            chkNoFreezing.TabIndex = 6;
            chkNoFreezing.Text = "No Freezing";
            toolTip1.SetToolTip(chkNoFreezing, "Do not freeze rows and columns when exporting to or importing from Excel.");
            // 
            // chkOpenXml
            // 
            chkOpenXml.AutoSize = true;
            chkOpenXml.Location = new Point(14, 77);
            chkOpenXml.Name = "chkOpenXml";
            chkOpenXml.Size = new Size(119, 19);
            chkOpenXml.TabIndex = 8;
            chkOpenXml.Text = "Save as OpenXml";
            toolTip1.SetToolTip(chkOpenXml, "Load or save file in OpenXml (Office 2007) format. ");
            // 
            // c1CheckBoxExcludeFooters
            // 
            c1CheckBoxExcludeFooters.AutoSize = true;
            c1CheckBoxExcludeFooters.Location = new Point(172, 77);
            c1CheckBoxExcludeFooters.Name = "c1CheckBoxExcludeFooters";
            c1CheckBoxExcludeFooters.Size = new Size(111, 19);
            c1CheckBoxExcludeFooters.TabIndex = 9;
            c1CheckBoxExcludeFooters.Text = "Exclude Footers";
            toolTip1.SetToolTip(c1CheckBoxExcludeFooters, "Exclude footer rows when exporting to Excel.");
            // 
            // ExportOptions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 141);
            Controls.Add(chkOpenXml);
            Controls.Add(c1CheckBoxExcludeFooters);
            Controls.Add(chkVisibleOnly);
            Controls.Add(chkNoFreezing);
            Controls.Add(chkSelectedRowsOnly);
            Controls.Add(chkIncludeFixedCells);
            Controls.Add(chkSaveMergedRanges);
            Controls.Add(chkAsDisplayed);
            Controls.Add(button1);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ExportOptions";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
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
            ((System.ComponentModel.ISupportInitialize)c1CheckBoxExcludeFooters).EndInit();
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
        private C1.Win.Input.C1CheckBox c1CheckBoxExcludeFooters;
    }
}