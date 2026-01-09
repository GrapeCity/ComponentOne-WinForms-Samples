namespace FlexGridExplorer.Samples
{
    partial class PdfExport
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
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            BtnExportPdf = new C1.Win.Input.C1Button();
            NumericEditCol = new C1.Win.Input.C1NumericEdit();
            NumericEditRow = new C1.Win.Input.C1NumericEdit();
            LabelCol = new C1.Win.Input.C1Label();
            LabelRow = new C1.Win.Input.C1Label();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BtnExportPdf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericEditCol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericEditRow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LabelCol).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LabelRow).BeginInit();
            SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.Rows;
            c1FlexGrid1.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.Both;
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:28;}\t";
            c1FlexGrid1.Dock = DockStyle.Fill;
            c1FlexGrid1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            c1FlexGrid1.KeyActionTab = C1.Win.FlexGrid.KeyActionEnum.MoveAcrossOut;
            c1FlexGrid1.Location = new Point(4, 52);
            c1FlexGrid1.Margin = new Padding(4, 4, 4, 4);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.NewRowWatermark = "Click to add new row";
            c1FlexGrid1.Size = new Size(924, 531);
            c1FlexGrid1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(c1FlexGrid1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(932, 587);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnExportPdf);
            panel1.Controls.Add(NumericEditCol);
            panel1.Controls.Add(NumericEditRow);
            panel1.Controls.Add(LabelCol);
            panel1.Controls.Add(LabelRow);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(932, 48);
            panel1.TabIndex = 7;
            // 
            // BtnExportPdf
            // 
            BtnExportPdf.Location = new Point(346, 12);
            BtnExportPdf.Name = "BtnExportPdf";
            BtnExportPdf.Size = new Size(96, 27);
            BtnExportPdf.Styles.Default.BackColor = Color.White;
            BtnExportPdf.Styles.Hot.BackColor = Color.FromArgb(249, 249, 249);
            BtnExportPdf.Styles.Hot.BorderColor = Color.FromArgb(213, 213, 213);
            BtnExportPdf.Styles.Hot.ForeColor = Color.FromArgb(27, 27, 27);
            BtnExportPdf.Styles.HotPressed.BackColor = Color.FromArgb(254, 254, 254);
            BtnExportPdf.Styles.HotPressed.BorderColor = SystemColors.ButtonFace;
            BtnExportPdf.Styles.HotPressed.ForeColor = SystemColors.WindowFrame;
            BtnExportPdf.Styles.ShowFocusBorder = true;
            BtnExportPdf.TabIndex = 4;
            BtnExportPdf.Text = "Export to Pdf";
            BtnExportPdf.Click += BtnExportPdf_Click;
            // 
            // NumericEditCol
            // 
            NumericEditCol.AutoSize = false;
            NumericEditCol.Font = new Font("Segoe UI Variable Text", 10F);
            NumericEditCol.Location = new Point(271, 14);
            NumericEditCol.Name = "NumericEditCol";
            NumericEditCol.Size = new Size(56, 25);
            NumericEditCol.Styles.Button.Hot.BackColor = Color.White;
            NumericEditCol.Styles.Button.Hot.BorderColor = Color.FromArgb(138, 138, 138);
            NumericEditCol.Styles.Button.HotPressed.BackColor = Color.White;
            NumericEditCol.Styles.Button.HotPressed.BorderColor = Color.FromArgb(138, 138, 138);
            NumericEditCol.Styles.Button.Pressed.BackColor = Color.White;
            NumericEditCol.Styles.Button.Pressed.BorderColor = Color.FromArgb(138, 138, 138);
            NumericEditCol.Styles.Default.BackColor = Color.White;
            NumericEditCol.Styles.Focused.BorderColor = Color.FromArgb(138, 138, 138);
            NumericEditCol.TabIndex = 3;
            NumericEditCol.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumericEditCol.ValueChanged += NumericEditCol_ValueChanged;
            // 
            // NumericEditRow
            // 
            NumericEditRow.AutoSize = false;
            NumericEditRow.BorderStyle = BorderStyle.Fixed3D;
            NumericEditRow.Font = new Font("Segoe UI Variable Text", 10F);
            NumericEditRow.Location = new Point(111, 14);
            NumericEditRow.Name = "NumericEditRow";
            NumericEditRow.Size = new Size(56, 25);
            NumericEditRow.Styles.Button.Hot.BackColor = Color.White;
            NumericEditRow.Styles.Button.Hot.BorderColor = Color.FromArgb(138, 138, 138);
            NumericEditRow.Styles.Button.HotPressed.BackColor = Color.White;
            NumericEditRow.Styles.Button.HotPressed.BorderColor = Color.FromArgb(138, 138, 138);
            NumericEditRow.Styles.Button.Pressed.BackColor = Color.White;
            NumericEditRow.Styles.Button.Pressed.BorderColor = Color.FromArgb(138, 138, 138);
            NumericEditRow.Styles.Default.BackColor = Color.White;
            NumericEditRow.Styles.Focused.BorderColor = Color.FromArgb(138, 138, 138);
            NumericEditRow.TabIndex = 2;
            NumericEditRow.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumericEditRow.ValueChanged += NumericEditRow_ValueChanged;
            // 
            // LabelCol
            // 
            LabelCol.AutoSize = true;
            LabelCol.Font = new Font("Segoe UI Variable Text", 10F);
            LabelCol.Location = new Point(181, 13);
            LabelCol.Name = "LabelCol";
            LabelCol.Size = new Size(79, 25);
            LabelCol.TabIndex = 1;
            LabelCol.Text = "Cols/page:";
            // 
            // LabelRow
            // 
            LabelRow.AutoSize = true;
            LabelRow.Font = new Font("Segoe UI Variable Text", 10F);
            LabelRow.Location = new Point(15, 14);
            LabelRow.Name = "LabelRow";
            LabelRow.Size = new Size(85, 25);
            LabelRow.TabIndex = 0;
            LabelRow.Text = "Rows/page:";
            // 
            // PdfExport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "PdfExport";
            Size = new Size(932, 587);
            Load += PdfExport_Load;
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BtnExportPdf).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericEditCol).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericEditRow).EndInit();
            ((System.ComponentModel.ISupportInitialize)LabelCol).EndInit();
            ((System.ComponentModel.ISupportInitialize)LabelRow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripLabel addNewLb;
        private System.Windows.Forms.ToolStripButton addNewBtn;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.Input.C1Button BtnExportPdf;
        private C1.Win.Input.C1NumericEdit NumericEditCol;
        private C1.Win.Input.C1NumericEdit NumericEditRow;
        private C1.Win.Input.C1Label LabelCol;
        private C1.Win.Input.C1Label LabelRow;
    }
}
