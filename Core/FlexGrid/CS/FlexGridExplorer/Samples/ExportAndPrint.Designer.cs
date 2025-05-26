namespace FlexGridExplorer.Samples
{
    partial class ExportAndPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportAndPrint));
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            btnExcel = new System.Windows.Forms.ToolStripButton();
            btnImport = new System.Windows.Forms.ToolStripButton();
            btnPrint = new System.Windows.Forms.ToolStripButton();
            c1FlexGrid1 = new C1.Win.FlexGrid.C1FlexGrid();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btnExcel, btnImport, btnPrint });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(837, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnExcel
            // 
            btnExcel.Image = (System.Drawing.Image)resources.GetObject("btnExcel.Image");
            btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new System.Drawing.Size(132, 24);
            btnExcel.Text = "Export to Excel";
            btnExcel.ToolTipText = "Save this grid to Excel.";
            btnExcel.Click += btnExcel_Click;
            // 
            // btnImport
            // 
            btnImport.Image = (System.Drawing.Image)resources.GetObject("btnImport.Image");
            btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnImport.Name = "btnImport";
            btnImport.Size = new System.Drawing.Size(152, 24);
            btnImport.Text = "Import from Excel";
            btnImport.ToolTipText = "Load an Excel file from your machine.";
            btnImport.Click += btnImport_Click;
            // 
            // btnPrint
            // 
            btnPrint.Image = (System.Drawing.Image)resources.GetObject("btnPrint.Image");
            btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new System.Drawing.Size(118, 24);
            btnPrint.Text = "Print Preview";
            btnPrint.ToolTipText = "Open a print preview.";
            btnPrint.Click += btnPrint_Click;
            // 
            // c1FlexGrid1
            // 
            c1FlexGrid1.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1FlexGrid1.Location = new System.Drawing.Point(0, 27);
            c1FlexGrid1.Name = "c1FlexGrid1";
            c1FlexGrid1.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.RowRange;
            c1FlexGrid1.Size = new System.Drawing.Size(837, 677);
            c1FlexGrid1.TabIndex = 1;
            // 
            // ExportAndPrint
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(c1FlexGrid1);
            Controls.Add(toolStrip1);
            Name = "ExportAndPrint";
            Size = new System.Drawing.Size(837, 704);
            Load += ExportAndPrint_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexGrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private System.Windows.Forms.ToolStripButton btnImport;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGrid1;
    }
}
