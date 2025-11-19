// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace MultiSelectExplorer.Samples
{
    partial class ThemeControl
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
            lblMultiSelectTitle = new C1.Win.Input.C1Label();
            _multiSelect = new C1.Win.Input.C1MultiSelect();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            lblThemeSelectionTitle = new C1.Win.Input.C1Label();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)lblMultiSelectTitle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_multiSelect).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblThemeSelectionTitle).BeginInit();
            SuspendLayout();
            // 
            // lblMultiSelectTitle
            // 
            lblMultiSelectTitle.AutoSize = true;
            lblMultiSelectTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblMultiSelectTitle.Location = new System.Drawing.Point(9, 9);
            lblMultiSelectTitle.Name = "lblMultiSelectTitle";
            lblMultiSelectTitle.Size = new System.Drawing.Size(94, 33);
            lblMultiSelectTitle.TabIndex = 7;
            lblMultiSelectTitle.Text = "c1Label1";
            // 
            // _multiSelect
            // 
            _multiSelect.AutoSize = false;
            _multiSelect.Location = new System.Drawing.Point(19, 54);
            _multiSelect.Name = "_multiSelect";
            _multiSelect.Size = new System.Drawing.Size(721, 50);
            _multiSelect.TabIndex = 6;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(_multiSelect);
            splitContainer1.Panel1.Controls.Add(lblMultiSelectTitle);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new System.Drawing.Size(1122, 782);
            splitContainer1.SplitterDistance = 852;
            splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(266, 782);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblThemeSelectionTitle);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(2, 2);
            panel1.Margin = new System.Windows.Forms.Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(262, 47);
            panel1.TabIndex = 8;
            // 
            // lblThemeSelectionTitle
            // 
            lblThemeSelectionTitle.AutoSize = true;
            lblThemeSelectionTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblThemeSelectionTitle.Location = new System.Drawing.Point(2, 6);
            lblThemeSelectionTitle.Name = "lblThemeSelectionTitle";
            lblThemeSelectionTitle.Size = new System.Drawing.Size(94, 33);
            lblThemeSelectionTitle.TabIndex = 1;
            lblThemeSelectionTitle.Text = "c1Label2";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowLayoutPanel1.Location = new System.Drawing.Point(2, 53);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            flowLayoutPanel1.Size = new System.Drawing.Size(262, 727);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // ThemeControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "ThemeControl";
            Size = new System.Drawing.Size(1122, 782);
            ((System.ComponentModel.ISupportInitialize)lblMultiSelectTitle).EndInit();
            ((System.ComponentModel.ISupportInitialize)_multiSelect).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblThemeSelectionTitle).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private C1.Win.Input.C1Label lblMultiSelectTitle;
        private C1.Win.Input.C1MultiSelect _multiSelect;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Input.C1Label lblThemeSelectionTitle;
    }
}
