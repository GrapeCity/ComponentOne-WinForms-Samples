using FlexGridExplorer.Properties;

namespace FlexGridExplorer.Samples
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiRangeSelection));
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            tsTopMenu = new ToolStrip();
            toolStripComboBoxSelMode = new ToolStripComboBox();
            toolStripSeparator4 = new ToolStripSeparator();
            btnSelectRanges = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnCopyToClipboard = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnPasteFromClipboard = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            btnExportToExcel = new ToolStripButton();
            tsBottomMenu = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            c1FlexGridRowsSelected = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            tsTopMenu.SuspendLayout();
            tsBottomMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexGridRowsSelected).BeginInit();
            SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid1.Dock = DockStyle.Fill;
            c1FlexGrid1.Location = new Point(0, 25);
            c1FlexGrid1.Margin = new Padding(4, 3, 4, 3);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.Size = new Size(1559, 885);
            c1FlexGrid1.TabIndex = 0;
            // 
            // tsTopMenu
            // 
            tsTopMenu.GripStyle = ToolStripGripStyle.Hidden;
            tsTopMenu.Items.AddRange(new ToolStripItem[] { toolStripComboBoxSelMode, toolStripSeparator4, btnSelectRanges, toolStripSeparator1, btnCopyToClipboard, toolStripSeparator2, btnPasteFromClipboard, toolStripSeparator3, btnExportToExcel });
            tsTopMenu.Location = new Point(0, 0);
            tsTopMenu.Name = "tsTopMenu";
            tsTopMenu.Size = new Size(1690, 25);
            tsTopMenu.TabIndex = 2;
            tsTopMenu.Text = "toolStrip1";
            // 
            // toolStripComboBoxSelMode
            // 
            toolStripComboBoxSelMode.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxSelMode.Name = "toolStripComboBoxSelMode";
            toolStripComboBoxSelMode.Size = new Size(121, 25);
            toolStripComboBoxSelMode.SelectedIndexChanged += toolStripComboBoxSelMode_SelectedIndexChanged;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // btnSelectRanges
            // 
            btnSelectRanges.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSelectRanges.ImageTransparentColor = Color.Magenta;
            btnSelectRanges.Name = "btnSelectRanges";
            btnSelectRanges.Size = new Size(80, 22);
            btnSelectRanges.Text = "Select ranges";
            btnSelectRanges.Click += btnSelectRanges_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnCopyToClipboard
            // 
            btnCopyToClipboard.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnCopyToClipboard.ImageTransparentColor = Color.Magenta;
            btnCopyToClipboard.Name = "btnCopyToClipboard";
            btnCopyToClipboard.Size = new Size(106, 22);
            btnCopyToClipboard.Text = "Copy to clipboard";
            btnCopyToClipboard.Click += btnCopyToClipboard_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnPasteFromClipboard
            // 
            btnPasteFromClipboard.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnPasteFromClipboard.ImageTransparentColor = Color.Magenta;
            btnPasteFromClipboard.Name = "btnPasteFromClipboard";
            btnPasteFromClipboard.Size = new Size(121, 22);
            btnPasteFromClipboard.Text = "Paste from clipboard";
            btnPasteFromClipboard.Click += btnPasteFromClipboard_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnExportToExcel.ImageTransparentColor = Color.Magenta;
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(89, 22);
            btnExportToExcel.Text = "Export to Excel";
            btnExportToExcel.Click += btnExportToExcel_Click;
            // 
            // tsBottomMenu
            // 
            tsBottomMenu.AutoSize = false;
            tsBottomMenu.Dock = DockStyle.Bottom;
            tsBottomMenu.GripStyle = ToolStripGripStyle.Hidden;
            tsBottomMenu.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            tsBottomMenu.Location = new Point(0, 910);
            tsBottomMenu.Name = "tsBottomMenu";
            tsBottomMenu.Size = new Size(1690, 23);
            tsBottomMenu.TabIndex = 3;
            tsBottomMenu.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(98, 20);
            toolStripLabel1.Text = "Selection statistic";
            // 
            // c1FlexGridRowsSelected
            // 
            c1FlexGridRowsSelected.BackColor = Color.White;
            c1FlexGridRowsSelected.ColumnInfo = "1,0,0,0,0,-1,Columns:0{Name:\"colRowsSelected\";Caption:\"Rows.Selected:\";AllowDragging:False;AllowResizing:False;AllowEditing:False;}\t";
            c1FlexGridRowsSelected.Dock = DockStyle.Right;
            c1FlexGridRowsSelected.ExtendLastCol = true;
            c1FlexGridRowsSelected.FocusRect = C1.Win.FlexGrid.FocusRectEnum.Background;
            c1FlexGridRowsSelected.ForeColor = Color.FromArgb(32, 32, 32);
            c1FlexGridRowsSelected.IconsStyle = C1.Win.FlexGrid.IconsStyle.Office365;
            c1FlexGridRowsSelected.Location = new Point(1559, 25);
            c1FlexGridRowsSelected.MarqueeStyle.BackgroundPadding = new Padding(1);
            c1FlexGridRowsSelected.MarqueeStyle.BackgroundPaddingColor = Color.White;
            c1FlexGridRowsSelected.MarqueeStyle.BorderAlign = C1.Win.FlexGrid.BorderAlign.Outside;
            c1FlexGridRowsSelected.MarqueeStyle.BorderMode = C1.Win.FlexGrid.MarqueeBorderMode.CellRange;
            c1FlexGridRowsSelected.MarqueeStyle.Color = Color.FromArgb(33, 132, 72);
            c1FlexGridRowsSelected.MarqueeStyle.Width = 2;
            c1FlexGridRowsSelected.Name = "c1FlexGridRowsSelected";
            c1FlexGridRowsSelected.Rows.Count = 1;
            c1FlexGridRowsSelected.Size = new Size(131, 885);
            c1FlexGridRowsSelected.StyleInfo = resources.GetString("c1FlexGridRowsSelected.StyleInfo");
            c1FlexGridRowsSelected.TabIndex = 0;
            c1FlexGridRowsSelected.Tree.Indent = 25;
            c1FlexGridRowsSelected.Tree.LineColor = Color.FromArgb(141, 141, 141);
            // 
            // MultiRangeSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(c1FlexGrid1);
            Controls.Add(c1FlexGridRowsSelected);
            Controls.Add(tsBottomMenu);
            Controls.Add(tsTopMenu);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MultiRangeSelection";
            Size = new Size(1690, 933);
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            tsTopMenu.ResumeLayout(false);
            tsTopMenu.PerformLayout();
            tsBottomMenu.ResumeLayout(false);
            tsBottomMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexGridRowsSelected).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
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
        private ToolStripComboBox toolStripComboBoxSelMode;
        private ToolStripSeparator toolStripSeparator4;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGridRowsSelected;
    }
}
