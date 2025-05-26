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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
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
            c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1FlexGrid1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            c1FlexGrid1.KeyActionTab = C1.Win.FlexGrid.KeyActionEnum.MoveAcrossOut;
            c1FlexGrid1.Location = new System.Drawing.Point(5, 86);
            c1FlexGrid1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.NewRowWatermark = "Click to add new row";
            c1FlexGrid1.Size = new System.Drawing.Size(1322, 887);
            c1FlexGrid1.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(c1FlexGrid1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(1332, 979);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnExportPdf);
            panel1.Controls.Add(NumericEditCol);
            panel1.Controls.Add(NumericEditRow);
            panel1.Controls.Add(LabelCol);
            panel1.Controls.Add(LabelRow);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1332, 80);
            panel1.TabIndex = 7;
            // 
            // BtnExportPdf
            // 
            BtnExportPdf.Location = new System.Drawing.Point(495, 20);
            BtnExportPdf.Name = "BtnExportPdf";
            BtnExportPdf.Size = new System.Drawing.Size(137, 40);
            BtnExportPdf.Styles.Default.BackColor = System.Drawing.Color.White;
            BtnExportPdf.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(249, 249, 249);
            BtnExportPdf.Styles.Hot.BorderColor = System.Drawing.Color.FromArgb(213, 213, 213);
            BtnExportPdf.Styles.Hot.ForeColor = System.Drawing.Color.FromArgb(27, 27, 27);
            BtnExportPdf.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(254, 254, 254);
            BtnExportPdf.Styles.HotPressed.BorderColor = System.Drawing.SystemColors.ButtonFace;
            BtnExportPdf.Styles.HotPressed.ForeColor = System.Drawing.SystemColors.WindowFrame;
            BtnExportPdf.Styles.ShowFocusBorder = true;
            BtnExportPdf.TabIndex = 4;
            BtnExportPdf.Text = "Export to Pdf";
            BtnExportPdf.Click += BtnExportPdf_Click;
            // 
            // NumericEditCol
            // 
            NumericEditCol.AutoSize = false;
            NumericEditCol.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            NumericEditCol.Location = new System.Drawing.Point(387, 23);
            NumericEditCol.Name = "NumericEditCol";
            NumericEditCol.Size = new System.Drawing.Size(80, 35);
            NumericEditCol.Styles.Button.Hot.BackColor = System.Drawing.Color.White;
            NumericEditCol.Styles.Button.Hot.BorderColor = System.Drawing.Color.FromArgb(138, 138, 138);
            NumericEditCol.Styles.Button.HotPressed.BackColor = System.Drawing.Color.White;
            NumericEditCol.Styles.Button.HotPressed.BorderColor = System.Drawing.Color.FromArgb(138, 138, 138);
            NumericEditCol.Styles.Button.Pressed.BackColor = System.Drawing.Color.White;
            NumericEditCol.Styles.Button.Pressed.BorderColor = System.Drawing.Color.FromArgb(138, 138, 138);
            NumericEditCol.Styles.Default.BackColor = System.Drawing.Color.White;
            NumericEditCol.Styles.Focused.BorderColor = System.Drawing.Color.FromArgb(138, 138, 138);
            NumericEditCol.TabIndex = 3;
            NumericEditCol.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumericEditCol.ValueChanged += NumericEditCol_ValueChanged;
            // 
            // NumericEditRow
            // 
            NumericEditRow.AutoSize = false;
            NumericEditRow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            NumericEditRow.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            NumericEditRow.Location = new System.Drawing.Point(159, 24);
            NumericEditRow.Name = "NumericEditRow";
            NumericEditRow.Size = new System.Drawing.Size(80, 35);
            NumericEditRow.Styles.Button.Hot.BackColor = System.Drawing.Color.White;
            NumericEditRow.Styles.Button.Hot.BorderColor = System.Drawing.Color.FromArgb(138, 138, 138);
            NumericEditRow.Styles.Button.HotPressed.BackColor = System.Drawing.Color.White;
            NumericEditRow.Styles.Button.HotPressed.BorderColor = System.Drawing.Color.FromArgb(138, 138, 138);
            NumericEditRow.Styles.Button.Pressed.BackColor = System.Drawing.Color.White;
            NumericEditRow.Styles.Button.Pressed.BorderColor = System.Drawing.Color.FromArgb(138, 138, 138);
            NumericEditRow.Styles.Default.BackColor = System.Drawing.Color.White;
            NumericEditRow.Styles.Focused.BorderColor = System.Drawing.Color.FromArgb(138, 138, 138);
            NumericEditRow.TabIndex = 2;
            NumericEditRow.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumericEditRow.ValueChanged += NumericEditRow_ValueChanged;
            // 
            // LabelCol
            // 
            LabelCol.AutoSize = true;
            LabelCol.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            LabelCol.Location = new System.Drawing.Point(258, 22);
            LabelCol.Name = "LabelCol";
            LabelCol.Size = new System.Drawing.Size(113, 35);
            LabelCol.TabIndex = 1;
            LabelCol.Text = "Cols/page:";
            // 
            // LabelRow
            // 
            LabelRow.AutoSize = true;
            LabelRow.Font = new System.Drawing.Font("Segoe UI Variable Text", 10F);
            LabelRow.Location = new System.Drawing.Point(22, 23);
            LabelRow.Name = "LabelRow";
            LabelRow.Size = new System.Drawing.Size(121, 35);
            LabelRow.TabIndex = 0;
            LabelRow.Text = "Rows/page:";
            // 
            // PdfExport
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PdfExport";
            Size = new System.Drawing.Size(1332, 979);
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
