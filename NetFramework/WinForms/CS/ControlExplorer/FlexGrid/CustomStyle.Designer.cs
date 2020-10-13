namespace ControlExplorer.FlexGrid
{
    partial class CustomStyle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomStyle));
            this.c1FlexGrid1 = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1DemoDataSet = new ControlExplorer.C1DemoDataSet();
            this.notebook = new System.Windows.Forms.ImageList(this.components);
            this.checkBoxes = new System.Windows.Forms.ImageList(this.components);
            this.productsTableAdapter = new ControlExplorer.C1DemoDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexGrid1
            // 
            this.c1FlexGrid1.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            this.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo");
            this.c1FlexGrid1.DataSource = this.productsBindingSource;
            this.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1FlexGrid1.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.None;
            this.c1FlexGrid1.Location = new System.Drawing.Point(0, 0);
            this.c1FlexGrid1.Name = "c1FlexGrid1";
            this.c1FlexGrid1.Rows.Count = 1;
            this.c1FlexGrid1.Rows.DefaultSize = 22;
            this.c1FlexGrid1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None;
            this.c1FlexGrid1.Size = new System.Drawing.Size(991, 616);
            this.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo");
            this.c1FlexGrid1.TabIndex = 2;
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
            // notebook
            // 
            this.notebook.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("notebook.ImageStream")));
            this.notebook.TransparentColor = System.Drawing.Color.Transparent;
            this.notebook.Images.SetKeyName(0, "notebook_side.png");
            // 
            // checkBoxes
            // 
            this.checkBoxes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("checkBoxes.ImageStream")));
            this.checkBoxes.TransparentColor = System.Drawing.Color.Transparent;
            this.checkBoxes.Images.SetKeyName(0, "customUncheck1.png");
            this.checkBoxes.Images.SetKeyName(1, "customCheck1.png");
            this.checkBoxes.Images.SetKeyName(2, "customCheck2.png");
            this.checkBoxes.Images.SetKeyName(3, "customUncheck2.png");
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // CustomStyle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 616);
            this.Controls.Add(this.c1FlexGrid1);
            this.Name = "CustomStyle";
            this.Text = "CustomStyle";
            this.Load += new System.EventHandler(this.CustomStyle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid1;
        private System.Windows.Forms.ImageList notebook;
        private System.Windows.Forms.ImageList checkBoxes;
        private C1DemoDataSet c1DemoDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private ControlExplorer.C1DemoDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    }
}