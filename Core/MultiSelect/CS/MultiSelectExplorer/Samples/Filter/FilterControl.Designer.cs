// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace MultiSelectExplorer.Samples.Filter
{
    partial class FilterControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterControl));
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            _flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            pnlTop = new System.Windows.Forms.Panel();
            lblColumnFilterName = new C1.Win.Input.C1Label();
            btnClear = new C1.Win.Input.C1Button();
            _multiSelect = new C1.Win.Input.C1MultiSelect();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_flexGrid).BeginInit();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lblColumnFilterName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnClear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_multiSelect).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(_flexGrid, 0, 1);
            tableLayoutPanel1.Controls.Add(pnlTop, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1026, 784);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // _flexGrid
            // 
            _flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            _flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            _flexGrid.Location = new System.Drawing.Point(16, 78);
            _flexGrid.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            _flexGrid.Name = "_flexGrid";
            _flexGrid.Size = new System.Drawing.Size(994, 690);
            _flexGrid.StyleInfo = resources.GetString("_flexGrid.StyleInfo");
            _flexGrid.TabIndex = 0;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(lblColumnFilterName);
            pnlTop.Controls.Add(btnClear);
            pnlTop.Controls.Add(_multiSelect);
            pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlTop.Location = new System.Drawing.Point(8, 8);
            pnlTop.Margin = new System.Windows.Forms.Padding(0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new System.Drawing.Size(1010, 62);
            pnlTop.TabIndex = 1;
            // 
            // lblColumnFilterName
            // 
            lblColumnFilterName.AutoSize = true;
            lblColumnFilterName.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblColumnFilterName.Location = new System.Drawing.Point(3, 16);
            lblColumnFilterName.Name = "lblColumnFilterName";
            lblColumnFilterName.Size = new System.Drawing.Size(74, 26);
            lblColumnFilterName.TabIndex = 2;
            lblColumnFilterName.Text = "c1Label1";
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(530, 14);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(94, 33);
            btnClear.Styles.Corners = new C1.Framework.Corners(1, 1, 1, 1);
            btnClear.Styles.Default.BackColor = System.Drawing.SystemColors.Highlight;
            btnClear.Styles.Default.BorderColor = System.Drawing.SystemColors.Highlight;
            btnClear.Styles.Default.ForeColor = System.Drawing.Color.White;
            btnClear.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(30, 144, 235);
            btnClear.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(30, 144, 235);
            btnClear.Styles.HotPressed.BorderColor = System.Drawing.SystemColors.Highlight;
            btnClear.Styles.Pressed.BorderColor = System.Drawing.Color.White;
            btnClear.TabIndex = 1;
            btnClear.Text = "c1Button1";
            btnClear.Click += btnClear_Click;
            // 
            // _multiSelect
            // 
            _multiSelect.AutoSize = false;
            _multiSelect.Location = new System.Drawing.Point(108, 14);
            _multiSelect.Name = "_multiSelect";
            _multiSelect.ShowSelectAll = true;
            _multiSelect.Size = new System.Drawing.Size(409, 33);
            _multiSelect.TabIndex = 0;
            _multiSelect.SelectionChanged += multiSelectColumnFilter_SelectionChanged;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // FilterControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "FilterControl";
            Size = new System.Drawing.Size(1026, 784);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_flexGrid).EndInit();
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lblColumnFilterName).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnClear).EndInit();
            ((System.ComponentModel.ISupportInitialize)_multiSelect).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.FlexGrid.C1FlexGrid _flexGrid;
        private System.Windows.Forms.Panel pnlTop;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private C1.Win.Input.C1MultiSelect _multiSelect;
        private C1.Win.Input.C1Button btnClear;
        private C1.Win.Input.C1Label lblColumnFilterName;
    }
}
