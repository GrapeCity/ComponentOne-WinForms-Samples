namespace ControlExplorer.FlexGrid
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.btnPrint = new C1.Win.C1Input.C1Button();
            this.lRowsPerPage = new C1.Win.C1Input.C1Label();
            this.lColsPerPage = new C1.Win.C1Input.C1Label();
            this.nRowsPerPage = new C1.Win.C1Input.C1NumericEdit();
            this.nColsPerPage = new C1.Win.C1Input.C1NumericEdit();
            this.pdfDocument = new C1.Win.Pdf.C1PdfDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lRowsPerPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lColsPerPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRowsPerPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nColsPerPage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flexGrid
            // 
            this.flexGrid.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.flexGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexGrid.Location = new System.Drawing.Point(0, 42);
            this.flexGrid.Name = "flexGrid";
            this.flexGrid.Rows.DefaultSize = 22;
            this.flexGrid.Size = new System.Drawing.Size(962, 603);
            this.flexGrid.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(348, 8);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(103, 23);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Export to Pdf";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this._btnPrint_Click);
            // 
            // lRowsPerPage
            // 
            this.lRowsPerPage.AutoSize = true;
            this.lRowsPerPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lRowsPerPage.Location = new System.Drawing.Point(12, 13);
            this.lRowsPerPage.Name = "lRowsPerPage";
            this.lRowsPerPage.Size = new System.Drawing.Size(77, 13);
            this.lRowsPerPage.TabIndex = 2;
            this.lRowsPerPage.Tag = null;
            this.lRowsPerPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lRowsPerPage.Value = "Rows/page:";
            // 
            // lColsPerPage
            // 
            this.lColsPerPage.AutoSize = true;
            this.lColsPerPage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lColsPerPage.Location = new System.Drawing.Point(164, 13);
            this.lColsPerPage.Name = "lColsPerPage";
            this.lColsPerPage.Size = new System.Drawing.Size(70, 13);
            this.lColsPerPage.TabIndex = 2;
            this.lColsPerPage.Tag = null;
            this.lColsPerPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lColsPerPage.Value = "Cols/page:";
            // 
            // nRowsPerPage
            // 
            this.nRowsPerPage.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nRowsPerPage.Location = new System.Drawing.Point(109, 10);
            this.nRowsPerPage.Name = "nRowsPerPage";
            this.nRowsPerPage.Size = new System.Drawing.Size(37, 18);
            this.nRowsPerPage.TabIndex = 3;
            this.nRowsPerPage.Tag = null;
            this.nRowsPerPage.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            // 
            // nColsPerPage
            // 
            this.nColsPerPage.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nColsPerPage.Location = new System.Drawing.Point(254, 10);
            this.nColsPerPage.Name = "nColsPerPage";
            this.nColsPerPage.Size = new System.Drawing.Size(36, 18);
            this.nColsPerPage.TabIndex = 3;
            this.nColsPerPage.Tag = null;
            this.nColsPerPage.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            // 
            // pdfDocument
            // 
            this.pdfDocument.DocumentInfo.Author = "";
            this.pdfDocument.DocumentInfo.CreationDate = new System.DateTime(((long)(0)));
            this.pdfDocument.DocumentInfo.Creator = "";
            this.pdfDocument.DocumentInfo.Keywords = "";
            this.pdfDocument.DocumentInfo.Producer = "ComponentOne C1Pdf";
            this.pdfDocument.DocumentInfo.Subject = "";
            this.pdfDocument.DocumentInfo.Title = "";
            this.pdfDocument.PdfVersion = "1.3";
            this.pdfDocument.RefDC = null;
            this.pdfDocument.RotateAngle = 0F;
            this.pdfDocument.UseFontShaping = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.nRowsPerPage);
            this.panel1.Controls.Add(this.nColsPerPage);
            this.panel1.Controls.Add(this.lRowsPerPage);
            this.panel1.Controls.Add(this.lColsPerPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(962, 42);
            this.panel1.TabIndex = 4;
            // 
            // PdfExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(962, 645);
            this.Controls.Add(this.flexGrid);
            this.Controls.Add(this.panel1);
            this.Name = "PdfExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Pdf Export";
            this.Load += new System.EventHandler(this.PdfExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lRowsPerPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lColsPerPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRowsPerPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nColsPerPage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid flexGrid;
        private C1.Win.C1Input.C1Button btnPrint;
        private C1.Win.C1Input.C1Label lRowsPerPage;
        private C1.Win.C1Input.C1Label lColsPerPage;
        private C1.Win.C1Input.C1NumericEdit nRowsPerPage;
        private C1.Win.C1Input.C1NumericEdit nColsPerPage;
        private C1.Win.Pdf.C1PdfDocument pdfDocument;
        private System.Windows.Forms.Panel panel1;
    }
}