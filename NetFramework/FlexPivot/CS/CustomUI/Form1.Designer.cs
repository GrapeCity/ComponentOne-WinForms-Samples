namespace CustomUI
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this._btnSalesperson = new System.Windows.Forms.ToolStripButton();
            this._btnProduct = new System.Windows.Forms.ToolStripButton();
            this._btnCountry = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this._btnExpensive = new System.Windows.Forms.ToolStripButton();
            this._btnModerate = new System.Windows.Forms.ToolStripButton();
            this._btnInexpensive = new System.Windows.Forms.ToolStripButton();
            this._btnAllPrices = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.c1FlexPivotGrid1 = new C1.Win.FlexPivot.C1FlexPivotGrid();
            this.c1FlexPivotPanel1 = new C1.Win.FlexPivot.C1FlexPivotPanel();
            this.c1FlexPivotChart1 = new C1.Win.FlexPivot.FlexPivotChart();
            this.c1FlexPivotPrintDocument1 = new C1.Win.FlexPivot.C1FlexPivotPrintDocument();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(119, 57);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.c1FlexPivotGrid1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.c1FlexPivotChart1);
            this.splitContainer1.Size = new System.Drawing.Size(790, 449);
            this.splitContainer1.SplitterDistance = 380;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this._btnSalesperson,
            this._btnProduct,
            this._btnCountry,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this._btnExpensive,
            this._btnModerate,
            this._btnInexpensive,
            this._btnAllPrices,
            this.toolStripSeparator3,
            this.toolStripButton5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 57);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(119, 449);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(116, 20);
            this.toolStripLabel2.Text = "View Sales by:";
            // 
            // _btnSalesperson
            // 
            this._btnSalesperson.Image = ((System.Drawing.Image)(resources.GetObject("_btnSalesperson.Image")));
            this._btnSalesperson.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._btnSalesperson.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnSalesperson.Name = "_btnSalesperson";
            this._btnSalesperson.Size = new System.Drawing.Size(116, 54);
            this._btnSalesperson.Text = "Salesperson";
            this._btnSalesperson.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._btnSalesperson.Click += new System.EventHandler(this._btnSalesperson_Click);
            // 
            // _btnProduct
            // 
            this._btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("_btnProduct.Image")));
            this._btnProduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._btnProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnProduct.Name = "_btnProduct";
            this._btnProduct.Size = new System.Drawing.Size(116, 54);
            this._btnProduct.Text = "Product";
            this._btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._btnProduct.Click += new System.EventHandler(this._btnProduct_Click);
            // 
            // _btnCountry
            // 
            this._btnCountry.Image = ((System.Drawing.Image)(resources.GetObject("_btnCountry.Image")));
            this._btnCountry.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this._btnCountry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnCountry.Name = "_btnCountry";
            this._btnCountry.Size = new System.Drawing.Size(116, 54);
            this._btnCountry.Text = "Country";
            this._btnCountry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this._btnCountry.Click += new System.EventHandler(this._btnCountry_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(116, 6);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(116, 20);
            this.toolStripLabel3.Text = "Price Filter:";
            // 
            // _btnExpensive
            // 
            this._btnExpensive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnExpensive.Image = ((System.Drawing.Image)(resources.GetObject("_btnExpensive.Image")));
            this._btnExpensive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnExpensive.Name = "_btnExpensive";
            this._btnExpensive.Size = new System.Drawing.Size(116, 22);
            this._btnExpensive.Text = "$$$ E&xpensive";
            this._btnExpensive.Click += new System.EventHandler(this._btnExpensive_Click);
            // 
            // _btnModerate
            // 
            this._btnModerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnModerate.Image = ((System.Drawing.Image)(resources.GetObject("_btnModerate.Image")));
            this._btnModerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnModerate.Name = "_btnModerate";
            this._btnModerate.Size = new System.Drawing.Size(116, 22);
            this._btnModerate.Text = "$$ &Moderate";
            this._btnModerate.Click += new System.EventHandler(this._btnModerate_Click);
            // 
            // _btnInexpensive
            // 
            this._btnInexpensive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnInexpensive.Image = ((System.Drawing.Image)(resources.GetObject("_btnInexpensive.Image")));
            this._btnInexpensive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnInexpensive.Name = "_btnInexpensive";
            this._btnInexpensive.Size = new System.Drawing.Size(116, 22);
            this._btnInexpensive.Text = "$ &Inexpensive";
            this._btnInexpensive.Click += new System.EventHandler(this._btnInexpensive_Click);
            // 
            // _btnAllPrices
            // 
            this._btnAllPrices.Checked = true;
            this._btnAllPrices.CheckState = System.Windows.Forms.CheckState.Checked;
            this._btnAllPrices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this._btnAllPrices.Image = ((System.Drawing.Image)(resources.GetObject("_btnAllPrices.Image")));
            this._btnAllPrices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._btnAllPrices.Name = "_btnAllPrices";
            this._btnAllPrices.Size = new System.Drawing.Size(116, 22);
            this._btnAllPrices.Text = "* &All Prices";
            this._btnAllPrices.Click += new System.EventHandler(this._btnAllProducts_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(116, 6);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(116, 54);
            this.toolStripButton5.Text = "Create &Report...";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Click += new System.EventHandler(this._btnReport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c1FlexPivotPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 57);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Custom FlexPivot Application";
            // 
            // c1FlexPivotGrid1
            // 
            this.c1FlexPivotGrid1.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.None;
            this.c1FlexPivotGrid1.AllowMergingFixed = C1.Win.FlexGrid.AllowMergingEnum.RestrictAll;
            this.c1FlexPivotGrid1.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.Light3D;
            this.c1FlexPivotGrid1.ColumnInfo = "1,1,0,0,0,120,Columns:0{Width:101;}\t";
            this.c1FlexPivotGrid1.DataSource = this.c1FlexPivotPanel1;
            this.c1FlexPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexPivotGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexPivotGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.c1FlexPivotGrid1.Name = "c1FlexPivotGrid1";
            this.c1FlexPivotGrid1.Rows.Count = 1;
            this.c1FlexPivotGrid1.Rows.DefaultSize = 24;
            this.c1FlexPivotGrid1.Size = new System.Drawing.Size(380, 449);
            this.c1FlexPivotGrid1.StyleInfo = resources.GetString("c1FlexPivotGrid1.StyleInfo");
            this.c1FlexPivotGrid1.TabIndex = 1;
            this.c1FlexPivotGrid1.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Blue;
            // 
            // c1FlexPivotPanel1
            // 
            this.c1FlexPivotPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexPivotPanel1.Location = new System.Drawing.Point(576, 15);
            this.c1FlexPivotPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.c1FlexPivotPanel1.Name = "c1FlexPivotPanel1";
            this.c1FlexPivotPanel1.ShowZeros = false;
            this.c1FlexPivotPanel1.Size = new System.Drawing.Size(319, 355);
            this.c1FlexPivotPanel1.TabIndex = 2;
            this.c1FlexPivotPanel1.Visible = false;
            // 
            // c1FlexPivotChart1
            // 
            this.c1FlexPivotChart1.BackColor = System.Drawing.Color.Transparent;
            this.c1FlexPivotChart1.DataSource = this.c1FlexPivotPanel1;
            this.c1FlexPivotChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexPivotChart1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexPivotChart1.Margin = new System.Windows.Forms.Padding(4);
            this.c1FlexPivotChart1.Name = "c1FlexPivotChart1";
            this.c1FlexPivotChart1.ShowTitle = false;
            this.c1FlexPivotChart1.Size = new System.Drawing.Size(405, 449);
            this.c1FlexPivotChart1.TabIndex = 1;
            // 
            // c1FlexPivotPrintDocument1
            // 
            this.c1FlexPivotPrintDocument1.FooterText = null;
            this.c1FlexPivotPrintDocument1.FlexPivotChart = this.c1FlexPivotChart1;
            this.c1FlexPivotPrintDocument1.FlexPivotGrid = this.c1FlexPivotGrid1;
            this.c1FlexPivotPrintDocument1.RawDataGrid = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 506);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexPivot: Custom User Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexPivotChart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton _btnSalesperson;
        private System.Windows.Forms.ToolStripButton _btnProduct;
        private System.Windows.Forms.ToolStripButton _btnCountry;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton _btnExpensive;
        private System.Windows.Forms.ToolStripButton _btnModerate;
        private System.Windows.Forms.ToolStripButton _btnInexpensive;
        private System.Windows.Forms.ToolStripButton _btnAllPrices;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private C1.Win.FlexPivot.C1FlexPivotPanel c1FlexPivotPanel1;
        private C1.Win.FlexPivot.C1FlexPivotGrid c1FlexPivotGrid1;
        private C1.Win.FlexPivot.FlexPivotChart c1FlexPivotChart1;
        private C1.Win.FlexPivot.C1FlexPivotPrintDocument c1FlexPivotPrintDocument1;
    }
}

