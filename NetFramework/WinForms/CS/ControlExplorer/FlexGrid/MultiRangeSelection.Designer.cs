﻿namespace ControlExplorer.FlexGrid
{
    partial class MultiRangeSelection
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
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.tsTopMenu = new System.Windows.Forms.ToolStrip();
            this.btnSelectRanges = new System.Windows.Forms.ToolStripButton();
            this.btnCopyToClipboard = new System.Windows.Forms.ToolStripButton();
            this.btnPasteFromClipboard = new System.Windows.Forms.ToolStripButton();
            this.btnExportToExcel = new System.Windows.Forms.ToolStripButton();
            this.tsBottomMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            this.tsTopMenu.SuspendLayout();
            this.tsBottomMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.c1FlexGrid1.ColumnPickerInfo.SearchMode = C1.Win.C1FlexGrid.ColumnPickerSearchMode.None;
            this.c1FlexGrid1.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.c1FlexGrid1.ColumnPickerInfo.ShowToolButton = false;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 40);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Size = new System.Drawing.Size(1449, 749);
            this.c1FlexGrid1.TabIndex = 0;
            this.c1FlexGrid1.UseCompatibleTextRendering = false;
            // 
            // tsTopMenu
            // 
            this.tsTopMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTopMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSelectRanges,
            this.toolStripSeparator1,
            this.btnCopyToClipboard,
            this.toolStripSeparator2,
            this.btnPasteFromClipboard,
            this.toolStripSeparator3,
            this.btnExportToExcel});
            this.tsTopMenu.Location = new System.Drawing.Point(0, 0);
            this.tsTopMenu.Name = "tsTopMenu";
            this.tsTopMenu.Size = new System.Drawing.Size(1449, 40);
            this.tsTopMenu.TabIndex = 2;
            this.tsTopMenu.Text = "toolStrip1";
            // 
            // btnSelectRanges
            // 
            this.btnSelectRanges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSelectRanges.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelectRanges.Name = "btnSelectRanges";
            this.btnSelectRanges.Size = new System.Drawing.Size(80, 37);
            this.btnSelectRanges.Text = "Select ranges";
            this.btnSelectRanges.Click += new System.EventHandler(this.btnSelectRanges_Click);
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCopyToClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(106, 37);
            this.btnCopyToClipboard.Text = "Copy to clipboard";
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnPasteFromClipboard
            // 
            this.btnPasteFromClipboard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPasteFromClipboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPasteFromClipboard.Name = "btnPasteFromClipboard";
            this.btnPasteFromClipboard.Size = new System.Drawing.Size(121, 37);
            this.btnPasteFromClipboard.Text = "Paste from clipboard";
            this.btnPasteFromClipboard.Click += new System.EventHandler(this.btnPasteFromClipboard_Click);
            // 
            // btnExportToExcel
            // 
            this.btnExportToExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnExportToExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExportToExcel.Name = "btnExportToExcel";
            this.btnExportToExcel.Size = new System.Drawing.Size(89, 37);
            this.btnExportToExcel.Text = "Export to Excel";
            this.btnExportToExcel.Click += new System.EventHandler(this.btnExportToExcel_Click);
            // 
            // tsBottomMenu
            // 
            this.tsBottomMenu.AutoSize = false;
            this.tsBottomMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsBottomMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBottomMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.tsBottomMenu.Location = new System.Drawing.Point(0, 789);
            this.tsBottomMenu.Name = "tsBottomMenu";
            this.tsBottomMenu.Size = new System.Drawing.Size(1449, 20);
            this.tsBottomMenu.TabIndex = 3;
            this.tsBottomMenu.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(98, 17);
            this.toolStripLabel1.Text = "Selection statistic";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // MultiRangeSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 809);
            this.Controls.Add(this.c1FlexGrid1);
            this.Controls.Add(this.tsBottomMenu);
            this.Controls.Add(this.tsTopMenu);
            this.Name = "MultiRangeSelection";
            this.Text = "ColumnPicker";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            this.tsTopMenu.ResumeLayout(false);
            this.tsTopMenu.PerformLayout();
            this.tsBottomMenu.ResumeLayout(false);
            this.tsBottomMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.ToolStrip tsTopMenu;
        private System.Windows.Forms.ToolStripButton btnSelectRanges;
        private System.Windows.Forms.ToolStripButton btnCopyToClipboard;
        private System.Windows.Forms.ToolStrip tsBottomMenu;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton btnPasteFromClipboard;
        private System.Windows.Forms.ToolStripButton btnExportToExcel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}