namespace ControlExplorer.InputPanel
{
    partial class MasterDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterDetail));
            this.c1InputPanel1 = new C1.Win.C1InputPanel.C1InputPanel();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.c1DemoDataSet = new ControlExplorer.C1DemoDataSet();
            this.hdrCategories = new C1.Win.C1InputPanel.InputGroupHeader();
            this.navCategories = new C1.Win.C1InputPanel.InputDataNavigator();
            this.sepLine = new C1.Win.C1InputPanel.InputSeparator();
            this.lblCategoryID = new C1.Win.C1InputPanel.InputLabel();
            this.numCategoryID = new C1.Win.C1InputPanel.InputNumericBox();
            this.lblCategoryName = new C1.Win.C1InputPanel.InputLabel();
            this.txtCategoryName = new C1.Win.C1InputPanel.InputTextBox();
            this.lblDescription = new C1.Win.C1InputPanel.InputLabel();
            this.txtDescription = new C1.Win.C1InputPanel.InputTextBox();
            this.lblPicture = new C1.Win.C1InputPanel.InputLabel();
            this.imgPicture = new C1.Win.C1InputPanel.InputImage();
            this.c1InputPanel2 = new C1.Win.C1InputPanel.C1InputPanel();
            this.categoriesProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hdrIBindingList = new C1.Win.C1InputPanel.InputGroupHeader();
            this.navIBindingList = new C1.Win.C1InputPanel.InputDataNavigator();
            this.sepLine1 = new C1.Win.C1InputPanel.InputSeparator();
            this.lblProductID = new C1.Win.C1InputPanel.InputLabel();
            this.numProductID = new C1.Win.C1InputPanel.InputNumericBox();
            this.lblProductName = new C1.Win.C1InputPanel.InputLabel();
            this.txtProductName = new C1.Win.C1InputPanel.InputTextBox();
            this.lblSupplierID = new C1.Win.C1InputPanel.InputLabel();
            this.numSupplierID = new C1.Win.C1InputPanel.InputNumericBox();
            this.lblCategoryID1 = new C1.Win.C1InputPanel.InputLabel();
            this.numCategoryID1 = new C1.Win.C1InputPanel.InputNumericBox();
            this.lblQuantityPerUnit = new C1.Win.C1InputPanel.InputLabel();
            this.txtQuantityPerUnit = new C1.Win.C1InputPanel.InputTextBox();
            this.lblUnitPrice = new C1.Win.C1InputPanel.InputLabel();
            this.numUnitPrice = new C1.Win.C1InputPanel.InputNumericBox();
            this.lblUnitsInStock = new C1.Win.C1InputPanel.InputLabel();
            this.numUnitsInStock = new C1.Win.C1InputPanel.InputNumericBox();
            this.lblUnitsOnOrder = new C1.Win.C1InputPanel.InputLabel();
            this.numUnitsOnOrder = new C1.Win.C1InputPanel.InputNumericBox();
            this.lblReorderLevel = new C1.Win.C1InputPanel.InputLabel();
            this.numReorderLevel = new C1.Win.C1InputPanel.InputNumericBox();
            this.chkDiscontinued = new C1.Win.C1InputPanel.InputCheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.categoriesTableAdapter = new ControlExplorer.C1DemoDataSetTableAdapters.CategoriesTableAdapter();
            this.productsTableAdapter = new ControlExplorer.C1DemoDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesProductsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // c1InputPanel1
            // 
            this.c1InputPanel1.DataSource = this.categoriesBindingSource;
            this.c1InputPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1InputPanel1.Items.Add(this.hdrCategories);
            this.c1InputPanel1.Items.Add(this.navCategories);
            this.c1InputPanel1.Items.Add(this.sepLine);
            this.c1InputPanel1.Items.Add(this.lblCategoryID);
            this.c1InputPanel1.Items.Add(this.numCategoryID);
            this.c1InputPanel1.Items.Add(this.lblCategoryName);
            this.c1InputPanel1.Items.Add(this.txtCategoryName);
            this.c1InputPanel1.Items.Add(this.lblDescription);
            this.c1InputPanel1.Items.Add(this.txtDescription);
            this.c1InputPanel1.Items.Add(this.lblPicture);
            this.c1InputPanel1.Items.Add(this.imgPicture);
            this.c1InputPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1InputPanel1.Name = "c1InputPanel1";
            this.c1InputPanel1.Size = new System.Drawing.Size(592, 182);
            this.c1InputPanel1.TabIndex = 0;
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataMember = "Categories";
            this.categoriesBindingSource.DataSource = this.c1DemoDataSet;
            // 
            // c1DemoDataSet
            // 
            this.c1DemoDataSet.DataSetName = "C1DemoDataSet";
            this.c1DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hdrCategories
            // 
            this.hdrCategories.Name = "hdrCategories";
            this.hdrCategories.Text = "&Categories";
            // 
            // navCategories
            // 
            this.navCategories.AddNewImage = ((System.Drawing.Image)(resources.GetObject("navCategories.AddNewImage")));
            this.navCategories.AddNewToolTip = "Add New";
            this.navCategories.ApplyImage = ((System.Drawing.Image)(resources.GetObject("navCategories.ApplyImage")));
            this.navCategories.ApplyToolTip = "Apply Changes";
            this.navCategories.CancelImage = ((System.Drawing.Image)(resources.GetObject("navCategories.CancelImage")));
            this.navCategories.CancelToolTip = "Cancel Changes";
            this.navCategories.DataSource = this.categoriesBindingSource;
            this.navCategories.DeleteImage = ((System.Drawing.Image)(resources.GetObject("navCategories.DeleteImage")));
            this.navCategories.DeleteToolTip = "Delete";
            this.navCategories.MoveFirstImage = ((System.Drawing.Image)(resources.GetObject("navCategories.MoveFirstImage")));
            this.navCategories.MoveFirstToolTip = "Move First";
            this.navCategories.MoveLastImage = ((System.Drawing.Image)(resources.GetObject("navCategories.MoveLastImage")));
            this.navCategories.MoveLastToolTip = "Move Last";
            this.navCategories.MoveNextImage = ((System.Drawing.Image)(resources.GetObject("navCategories.MoveNextImage")));
            this.navCategories.MoveNextToolTip = "Move Next";
            this.navCategories.MovePreviousImage = ((System.Drawing.Image)(resources.GetObject("navCategories.MovePreviousImage")));
            this.navCategories.MovePreviousToolTip = "Move Previous";
            this.navCategories.Name = "navCategories";
            this.navCategories.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.navCategories.ReloadImage = ((System.Drawing.Image)(resources.GetObject("navCategories.ReloadImage")));
            this.navCategories.ReloadToolTip = "Reload Data";
            this.navCategories.SaveImage = ((System.Drawing.Image)(resources.GetObject("navCategories.SaveImage")));
            this.navCategories.SaveToolTip = "Save Data";
            // 
            // sepLine
            // 
            this.sepLine.Break = C1.Win.C1InputPanel.BreakType.Group;
            this.sepLine.Height = 11;
            this.sepLine.Name = "sepLine";
            this.sepLine.Width = 520;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Text = "Category &ID:";
            this.lblCategoryID.Width = 91;
            // 
            // numCategoryID
            // 
            this.numCategoryID.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesBindingSource, "CategoryID", true));
            this.numCategoryID.Format = "0";
            this.numCategoryID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCategoryID.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numCategoryID.Name = "numCategoryID";
            this.numCategoryID.ReadOnly = true;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Text = "Category &Name:";
            this.lblCategoryName.Width = 91;
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesBindingSource, "CategoryName", true));
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Width = 200;
            // 
            // lblDescription
            // 
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text = "&Description:";
            this.lblDescription.Width = 91;
            // 
            // txtDescription
            // 
            this.txtDescription.Break = C1.Win.C1InputPanel.BreakType.Column;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesBindingSource, "Description", true));
            this.txtDescription.Height = 48;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Spread;
            this.txtDescription.Width = 200;
            // 
            // lblPicture
            // 
            this.lblPicture.HorizontalAlign = C1.Win.C1InputPanel.InputContentAlignment.Center;
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Text = "Picture:";
            this.lblPicture.VerticalAlign = C1.Win.C1InputPanel.InputContentAlignment.Far;
            this.lblPicture.Width = 91;
            // 
            // imgPicture
            // 
            this.imgPicture.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesBindingSource, "Picture", true));
            this.imgPicture.Height = 90;
            this.imgPicture.Name = "imgPicture";
            this.imgPicture.Width = 90;
            // 
            // c1InputPanel2
            // 
            this.c1InputPanel2.DataSource = this.categoriesProductsBindingSource;
            this.c1InputPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1InputPanel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.c1InputPanel2.Items.Add(this.hdrIBindingList);
            this.c1InputPanel2.Items.Add(this.navIBindingList);
            this.c1InputPanel2.Items.Add(this.sepLine1);
            this.c1InputPanel2.Items.Add(this.lblProductID);
            this.c1InputPanel2.Items.Add(this.numProductID);
            this.c1InputPanel2.Items.Add(this.lblProductName);
            this.c1InputPanel2.Items.Add(this.txtProductName);
            this.c1InputPanel2.Items.Add(this.lblSupplierID);
            this.c1InputPanel2.Items.Add(this.numSupplierID);
            this.c1InputPanel2.Items.Add(this.lblCategoryID1);
            this.c1InputPanel2.Items.Add(this.numCategoryID1);
            this.c1InputPanel2.Items.Add(this.lblQuantityPerUnit);
            this.c1InputPanel2.Items.Add(this.txtQuantityPerUnit);
            this.c1InputPanel2.Items.Add(this.lblUnitPrice);
            this.c1InputPanel2.Items.Add(this.numUnitPrice);
            this.c1InputPanel2.Items.Add(this.lblUnitsInStock);
            this.c1InputPanel2.Items.Add(this.numUnitsInStock);
            this.c1InputPanel2.Items.Add(this.lblUnitsOnOrder);
            this.c1InputPanel2.Items.Add(this.numUnitsOnOrder);
            this.c1InputPanel2.Items.Add(this.lblReorderLevel);
            this.c1InputPanel2.Items.Add(this.numReorderLevel);
            this.c1InputPanel2.Items.Add(this.chkDiscontinued);
            this.c1InputPanel2.Location = new System.Drawing.Point(0, 182);
            this.c1InputPanel2.Name = "c1InputPanel2";
            this.c1InputPanel2.Size = new System.Drawing.Size(592, 264);
            this.c1InputPanel2.TabIndex = 1;
            // 
            // categoriesProductsBindingSource
            // 
            this.categoriesProductsBindingSource.DataMember = "CategoriesProducts";
            this.categoriesProductsBindingSource.DataSource = this.categoriesBindingSource;
            // 
            // hdrIBindingList
            // 
            this.hdrIBindingList.Name = "hdrIBindingList";
            this.hdrIBindingList.Text = "&Products";
            // 
            // navIBindingList
            // 
            this.navIBindingList.AddNewImage = ((System.Drawing.Image)(resources.GetObject("navIBindingList.AddNewImage")));
            this.navIBindingList.AddNewToolTip = "Add New";
            this.navIBindingList.ApplyImage = ((System.Drawing.Image)(resources.GetObject("navIBindingList.ApplyImage")));
            this.navIBindingList.ApplyToolTip = "Apply Changes";
            this.navIBindingList.CancelImage = ((System.Drawing.Image)(resources.GetObject("navIBindingList.CancelImage")));
            this.navIBindingList.CancelToolTip = "Cancel Changes";
            this.navIBindingList.DataSource = this.categoriesProductsBindingSource;
            this.navIBindingList.DeleteImage = ((System.Drawing.Image)(resources.GetObject("navIBindingList.DeleteImage")));
            this.navIBindingList.DeleteToolTip = "Delete";
            this.navIBindingList.MoveFirstImage = ((System.Drawing.Image)(resources.GetObject("navIBindingList.MoveFirstImage")));
            this.navIBindingList.MoveFirstToolTip = "Move First";
            this.navIBindingList.MoveLastImage = ((System.Drawing.Image)(resources.GetObject("navIBindingList.MoveLastImage")));
            this.navIBindingList.MoveLastToolTip = "Move Last";
            this.navIBindingList.MoveNextImage = ((System.Drawing.Image)(resources.GetObject("navIBindingList.MoveNextImage")));
            this.navIBindingList.MoveNextToolTip = "Move Next";
            this.navIBindingList.MovePreviousImage = ((System.Drawing.Image)(resources.GetObject("navIBindingList.MovePreviousImage")));
            this.navIBindingList.MovePreviousToolTip = "Move Previous";
            this.navIBindingList.Name = "navIBindingList";
            this.navIBindingList.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.navIBindingList.ReloadImage = ((System.Drawing.Image)(resources.GetObject("navIBindingList.ReloadImage")));
            this.navIBindingList.ReloadToolTip = "Reload Data";
            this.navIBindingList.SaveImage = ((System.Drawing.Image)(resources.GetObject("navIBindingList.SaveImage")));
            this.navIBindingList.SaveToolTip = "Save Data";
            this.navIBindingList.ShowReloadButton = true;
            this.navIBindingList.ShowSaveButton = true;
            // 
            // sepLine1
            // 
            this.sepLine1.Break = C1.Win.C1InputPanel.BreakType.Group;
            this.sepLine1.Height = 11;
            this.sepLine1.Name = "sepLine1";
            this.sepLine1.Width = 520;
            // 
            // lblProductID
            // 
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Text = "P&roduct ID:";
            this.lblProductID.Width = 99;
            // 
            // numProductID
            // 
            this.numProductID.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesProductsBindingSource, "ProductID", true));
            this.numProductID.Format = "0";
            this.numProductID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numProductID.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numProductID.Name = "numProductID";
            this.numProductID.ReadOnly = true;
            // 
            // lblProductName
            // 
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Text = "Pr&oduct Name:";
            this.lblProductName.Width = 99;
            // 
            // txtProductName
            // 
            this.txtProductName.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesProductsBindingSource, "ProductName", true));
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Width = 200;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Text = "&Supplier ID:";
            this.lblSupplierID.Width = 99;
            // 
            // numSupplierID
            // 
            this.numSupplierID.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesProductsBindingSource, "SupplierID", true));
            this.numSupplierID.Format = "0";
            this.numSupplierID.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numSupplierID.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numSupplierID.Name = "numSupplierID";
            // 
            // lblCategoryID1
            // 
            this.lblCategoryID1.Name = "lblCategoryID1";
            this.lblCategoryID1.Text = "C&ategory ID:";
            this.lblCategoryID1.Width = 99;
            // 
            // numCategoryID1
            // 
            this.numCategoryID1.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesProductsBindingSource, "CategoryID", true));
            this.numCategoryID1.Format = "0";
            this.numCategoryID1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numCategoryID1.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.numCategoryID1.Name = "numCategoryID1";
            // 
            // lblQuantityPerUnit
            // 
            this.lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            this.lblQuantityPerUnit.Text = "&Quantity Per Unit:";
            this.lblQuantityPerUnit.Width = 99;
            // 
            // txtQuantityPerUnit
            // 
            this.txtQuantityPerUnit.Break = C1.Win.C1InputPanel.BreakType.Column;
            this.txtQuantityPerUnit.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesProductsBindingSource, "QuantityPerUnit", true));
            this.txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            this.txtQuantityPerUnit.Width = 200;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Text = "&Unit Price:";
            this.lblUnitPrice.Width = 99;
            // 
            // numUnitPrice
            // 
            this.numUnitPrice.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesProductsBindingSource, "UnitPrice", true));
            this.numUnitPrice.Format = "C2";
            this.numUnitPrice.Name = "numUnitPrice";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Text = "Uni&ts In Stock:";
            this.lblUnitsInStock.Width = 99;
            // 
            // numUnitsInStock
            // 
            this.numUnitsInStock.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesProductsBindingSource, "UnitsInStock", true));
            this.numUnitsInStock.Format = "0";
            this.numUnitsInStock.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numUnitsInStock.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numUnitsInStock.Name = "numUnitsInStock";
            // 
            // lblUnitsOnOrder
            // 
            this.lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            this.lblUnitsOnOrder.Text = "Units On Ord&er:";
            this.lblUnitsOnOrder.Width = 99;
            // 
            // numUnitsOnOrder
            // 
            this.numUnitsOnOrder.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesProductsBindingSource, "UnitsOnOrder", true));
            this.numUnitsOnOrder.Format = "0";
            this.numUnitsOnOrder.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numUnitsOnOrder.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numUnitsOnOrder.Name = "numUnitsOnOrder";
            // 
            // lblReorderLevel
            // 
            this.lblReorderLevel.Name = "lblReorderLevel";
            this.lblReorderLevel.Text = "Reorder &Level:";
            this.lblReorderLevel.Width = 99;
            // 
            // numReorderLevel
            // 
            this.numReorderLevel.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesProductsBindingSource, "ReorderLevel", true));
            this.numReorderLevel.Format = "0";
            this.numReorderLevel.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.numReorderLevel.Minimum = new decimal(new int[] {
            32768,
            0,
            0,
            -2147483648});
            this.numReorderLevel.Name = "numReorderLevel";
            // 
            // chkDiscontinued
            // 
            this.chkDiscontinued.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", this.categoriesProductsBindingSource, "Discontinued", true));
            this.chkDiscontinued.Name = "chkDiscontinued";
            this.chkDiscontinued.Text = "Discontinued";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 182);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(592, 3);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // MasterDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(242)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.c1InputPanel2);
            this.Controls.Add(this.c1InputPanel1);
            this.Name = "MasterDetail";
            this.Text = "MasterDetail";
            this.Load += new System.EventHandler(this.MasterDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DemoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1InputPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesProductsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel1;
        private C1.Win.C1InputPanel.C1InputPanel c1InputPanel2;
        private System.Windows.Forms.Splitter splitter1;
        private C1DemoDataSet c1DemoDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private ControlExplorer.C1DemoDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private C1.Win.C1InputPanel.InputGroupHeader hdrCategories;
        private C1.Win.C1InputPanel.InputDataNavigator navCategories;
        private C1.Win.C1InputPanel.InputSeparator sepLine;
        private C1.Win.C1InputPanel.InputLabel lblCategoryID;
        private C1.Win.C1InputPanel.InputNumericBox numCategoryID;
        private C1.Win.C1InputPanel.InputLabel lblCategoryName;
        private C1.Win.C1InputPanel.InputTextBox txtCategoryName;
        private C1.Win.C1InputPanel.InputLabel lblDescription;
        private C1.Win.C1InputPanel.InputTextBox txtDescription;
        private C1.Win.C1InputPanel.InputLabel lblPicture;
        private C1.Win.C1InputPanel.InputImage imgPicture;
        private System.Windows.Forms.BindingSource categoriesProductsBindingSource;
        private ControlExplorer.C1DemoDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private C1.Win.C1InputPanel.InputGroupHeader hdrIBindingList;
        private C1.Win.C1InputPanel.InputDataNavigator navIBindingList;
        private C1.Win.C1InputPanel.InputSeparator sepLine1;
        private C1.Win.C1InputPanel.InputLabel lblProductID;
        private C1.Win.C1InputPanel.InputNumericBox numProductID;
        private C1.Win.C1InputPanel.InputLabel lblProductName;
        private C1.Win.C1InputPanel.InputTextBox txtProductName;
        private C1.Win.C1InputPanel.InputLabel lblSupplierID;
        private C1.Win.C1InputPanel.InputNumericBox numSupplierID;
        private C1.Win.C1InputPanel.InputLabel lblCategoryID1;
        private C1.Win.C1InputPanel.InputNumericBox numCategoryID1;
        private C1.Win.C1InputPanel.InputLabel lblQuantityPerUnit;
        private C1.Win.C1InputPanel.InputTextBox txtQuantityPerUnit;
        private C1.Win.C1InputPanel.InputLabel lblUnitPrice;
        private C1.Win.C1InputPanel.InputNumericBox numUnitPrice;
        private C1.Win.C1InputPanel.InputLabel lblUnitsInStock;
        private C1.Win.C1InputPanel.InputNumericBox numUnitsInStock;
        private C1.Win.C1InputPanel.InputLabel lblUnitsOnOrder;
        private C1.Win.C1InputPanel.InputNumericBox numUnitsOnOrder;
        private C1.Win.C1InputPanel.InputLabel lblReorderLevel;
        private C1.Win.C1InputPanel.InputNumericBox numReorderLevel;
        private C1.Win.C1InputPanel.InputCheckBox chkDiscontinued;
    }
}