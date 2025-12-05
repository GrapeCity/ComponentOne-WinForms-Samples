namespace MultiGridDocument
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this._flexCategories = new C1.Win.FlexGrid.C1FlexGrid();
            this._flexProducts = new C1.Win.FlexGrid.C1FlexGrid();
            this._printDoc = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printOneGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printGridMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printDocumentObjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coolPrintPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printTwoGridsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traditionalPrintPreviewDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coolPrintPreviewDialogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._flexProducts)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this._flexCategories);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this._flexProducts);
            this.splitContainer1.Size = new System.Drawing.Size(675, 276);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 1;
            // 
            // _flexCategories
            // 
            this._flexCategories.ColumnInfo = "10,1,0,0,0,110,Columns:0{Width:31;}\t";
            this._flexCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexCategories.Location = new System.Drawing.Point(0, 0);
            this._flexCategories.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._flexCategories.Name = "_flexCategories";
            this._flexCategories.Rows.DefaultSize = 22;
            this._flexCategories.Size = new System.Drawing.Size(329, 276);
            this._flexCategories.StyleInfo = resources.GetString("_flexCategories.StyleInfo");
            this._flexCategories.TabIndex = 0;
            this._flexCategories.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // _flexProducts
            // 
            this._flexProducts.ColumnInfo = "10,1,0,0,0,110,Columns:0{Width:32;}\t";
            this._flexProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexProducts.Location = new System.Drawing.Point(0, 0);
            this._flexProducts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this._flexProducts.Name = "_flexProducts";
            this._flexProducts.Rows.DefaultSize = 22;
            this._flexProducts.Size = new System.Drawing.Size(342, 276);
            this._flexProducts.StyleInfo = resources.GetString("_flexProducts.StyleInfo");
            this._flexProducts.TabIndex = 0;
            this._flexProducts.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // _printDoc
            // 
            this._printDoc.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this._printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printOneGridToolStripMenuItem,
            this.printTwoGridsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printOneGridToolStripMenuItem
            // 
            this.printOneGridToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printGridMethodToolStripMenuItem,
            this.printDocumentObjectToolStripMenuItem,
            this.coolPrintPreviewToolStripMenuItem});
            this.printOneGridToolStripMenuItem.Name = "printOneGridToolStripMenuItem";
            this.printOneGridToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.printOneGridToolStripMenuItem.Text = "Print One Grid";
            // 
            // printGridMethodToolStripMenuItem
            // 
            this.printGridMethodToolStripMenuItem.Name = "printGridMethodToolStripMenuItem";
            this.printGridMethodToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.printGridMethodToolStripMenuItem.Text = "PrintGrid method";
            this.printGridMethodToolStripMenuItem.Click += new System.EventHandler(this.printGridMethodToolStripMenuItem_Click);
            // 
            // printDocumentObjectToolStripMenuItem
            // 
            this.printDocumentObjectToolStripMenuItem.Name = "printDocumentObjectToolStripMenuItem";
            this.printDocumentObjectToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.printDocumentObjectToolStripMenuItem.Text = "PrintDocument object";
            this.printDocumentObjectToolStripMenuItem.Click += new System.EventHandler(this.printDocumentObjectToolStripMenuItem_Click);
            // 
            // coolPrintPreviewToolStripMenuItem
            // 
            this.coolPrintPreviewToolStripMenuItem.Name = "coolPrintPreviewToolStripMenuItem";
            this.coolPrintPreviewToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.coolPrintPreviewToolStripMenuItem.Text = "CoolPrintPreview";
            this.coolPrintPreviewToolStripMenuItem.Click += new System.EventHandler(this.coolPrintPreviewToolStripMenuItem_Click);
            // 
            // printTwoGridsToolStripMenuItem
            // 
            this.printTwoGridsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traditionalPrintPreviewDialogToolStripMenuItem,
            this.coolPrintPreviewDialogToolStripMenuItem});
            this.printTwoGridsToolStripMenuItem.Name = "printTwoGridsToolStripMenuItem";
            this.printTwoGridsToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.printTwoGridsToolStripMenuItem.Text = "Print Two Grids";
            // 
            // traditionalPrintPreviewDialogToolStripMenuItem
            // 
            this.traditionalPrintPreviewDialogToolStripMenuItem.Name = "traditionalPrintPreviewDialogToolStripMenuItem";
            this.traditionalPrintPreviewDialogToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.traditionalPrintPreviewDialogToolStripMenuItem.Text = "Traditional PrintPreviewDialog";
            this.traditionalPrintPreviewDialogToolStripMenuItem.Click += new System.EventHandler(this.traditionalPrintPreviewDialogToolStripMenuItem_Click);
            // 
            // coolPrintPreviewDialogToolStripMenuItem
            // 
            this.coolPrintPreviewDialogToolStripMenuItem.Name = "coolPrintPreviewDialogToolStripMenuItem";
            this.coolPrintPreviewDialogToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.coolPrintPreviewDialogToolStripMenuItem.Text = "CoolPrintPreviewDialog";
            this.coolPrintPreviewDialogToolStripMenuItem.Click += new System.EventHandler(this.coolPrintPreviewDialogToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 300);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MultiGridDocument";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._flexProducts)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private C1.Win.FlexGrid.C1FlexGrid _flexCategories;
        private C1.Win.FlexGrid.C1FlexGrid _flexProducts;
        private System.Drawing.Printing.PrintDocument _printDoc;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printOneGridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printGridMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printDocumentObjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printTwoGridsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traditionalPrintPreviewDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coolPrintPreviewDialogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coolPrintPreviewToolStripMenuItem;
    }
}

