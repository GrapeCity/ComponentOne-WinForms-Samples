namespace ControlExplorer.TrueDBGrid
{
    partial class ConditionalFiltering
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConditionalFiltering));
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1DemoDataSet = new ControlExplorer.C1DemoDataSet();
            this.productsTableAdapter = new ControlExplorer.C1DemoDataSetTableAdapters.ProductsTableAdapter();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.c1DemoDataSet;
            // 
            // c1DemoDataSet
            // 
            this.c1DemoDataSet.DataSetName = "C1DemoDataSet";
            this.c1DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1TrueDBGrid1.DataSource = this.productsBindingSource;
            this.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            this.c1TrueDBGrid1.RecordSelectorWidth = 20;
            this.c1TrueDBGrid1.RowDivider.Color = System.Drawing.Color.LightGray;
            this.c1TrueDBGrid1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.c1TrueDBGrid1.RowHeight = 20;
            this.c1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.LightGray;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(592, 446);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.Text = "c1TrueDBGrid1";
            // 
            // ConditionalFiltering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Name = "ConditionalFiltering";
            this.Text = "ConditionalFiltering";
            this.Load += new System.EventHandler(this.ConditionalFiltering_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1DemoDataSet c1DemoDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ControlExplorer.C1DemoDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
    }
}