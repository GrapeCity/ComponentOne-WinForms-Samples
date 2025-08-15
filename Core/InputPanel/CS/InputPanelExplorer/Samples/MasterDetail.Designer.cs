using InputPanelExplorer.Data;
using System.Resources;

namespace InputPanelExplorer.Samples
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
            components = new System.ComponentModel.Container();
            InputPanel1 = new C1.Win.InputPanel.C1InputPanel();
            categoriesBindingSource = new System.Windows.Forms.BindingSource(components);
            c1DemoDataSet = new C1DemoDataSet();
            hdrCategories = new C1.Win.InputPanel.InputGroupHeader();
            navCategories = new C1.Win.InputPanel.InputDataNavigator();
            sepLine = new C1.Win.InputPanel.InputSeparator();
            lblCategoryID = new C1.Win.InputPanel.InputLabel();
            numCategoryID = new C1.Win.InputPanel.InputNumericBox();
            lblCategoryName = new C1.Win.InputPanel.InputLabel();
            txtCategoryName = new C1.Win.InputPanel.InputTextBox();
            lblDescription = new C1.Win.InputPanel.InputLabel();
            txtDescription = new C1.Win.InputPanel.InputTextBox();
            lblPicture = new C1.Win.InputPanel.InputLabel();
            imgPicture = new C1.Win.InputPanel.InputImage();
            InputPanel2 = new C1.Win.InputPanel.C1InputPanel();
            categoriesProductsBindingSource = new System.Windows.Forms.BindingSource(components);
            hdrIBindingList = new C1.Win.InputPanel.InputGroupHeader();
            navIBindingList = new C1.Win.InputPanel.InputDataNavigator();
            sepLine1 = new C1.Win.InputPanel.InputSeparator();
            lblProductID = new C1.Win.InputPanel.InputLabel();
            numProductID = new C1.Win.InputPanel.InputNumericBox();
            lblProductName = new C1.Win.InputPanel.InputLabel();
            txtProductName = new C1.Win.InputPanel.InputTextBox();
            lblSupplierID = new C1.Win.InputPanel.InputLabel();
            numSupplierID = new C1.Win.InputPanel.InputNumericBox();
            lblCategoryID1 = new C1.Win.InputPanel.InputLabel();
            numCategoryID1 = new C1.Win.InputPanel.InputNumericBox();
            lblQuantityPerUnit = new C1.Win.InputPanel.InputLabel();
            txtQuantityPerUnit = new C1.Win.InputPanel.InputTextBox();
            lblUnitPrice = new C1.Win.InputPanel.InputLabel();
            numUnitPrice = new C1.Win.InputPanel.InputNumericBox();
            lblUnitsInStock = new C1.Win.InputPanel.InputLabel();
            numUnitsInStock = new C1.Win.InputPanel.InputNumericBox();
            lblUnitsOnOrder = new C1.Win.InputPanel.InputLabel();
            numUnitsOnOrder = new C1.Win.InputPanel.InputNumericBox();
            lblReorderLevel = new C1.Win.InputPanel.InputLabel();
            numReorderLevel = new C1.Win.InputPanel.InputNumericBox();
            chkDiscontinued = new C1.Win.InputPanel.InputCheckBox();
            splitter1 = new System.Windows.Forms.Splitter();
            categoriesTableAdapter = new InputPanelExplorer.Data.C1DemoDataSetTableAdapters.CategoriesTableAdapter();
            productsTableAdapter = new InputPanelExplorer.Data.C1DemoDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)InputPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1DemoDataSet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputPanel2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoriesProductsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // InputPanel1
            // 
            InputPanel1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            InputPanel1.DataSource = categoriesBindingSource;
            InputPanel1.DesignScaleFactor = 1.79353654F;
            InputPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            InputPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            InputPanel1.Items.Add(hdrCategories);
            InputPanel1.Items.Add(navCategories);
            InputPanel1.Items.Add(sepLine);
            InputPanel1.Items.Add(lblCategoryID);
            InputPanel1.Items.Add(numCategoryID);
            InputPanel1.Items.Add(lblCategoryName);
            InputPanel1.Items.Add(txtCategoryName);
            InputPanel1.Items.Add(lblDescription);
            InputPanel1.Items.Add(txtDescription);
            InputPanel1.Items.Add(lblPicture);
            InputPanel1.Items.Add(imgPicture);
            InputPanel1.Location = new System.Drawing.Point(0, 0);
            InputPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            InputPanel1.Name = "InputPanel1";
            InputPanel1.Size = new System.Drawing.Size(1641, 297);
            InputPanel1.TabIndex = 0;
            // 
            // categoriesBindingSource
            // 
            categoriesBindingSource.DataMember = "Categories";
            categoriesBindingSource.DataSource = c1DemoDataSet;
            // 
            // c1DemoDataSet
            // 
            c1DemoDataSet.DataSetName = "C1DemoDataSet";
            c1DemoDataSet.Namespace = "http://tempuri.org/C1DemoDataSet.xsd";
            c1DemoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hdrCategories
            // 
            hdrCategories.Name = "hdrCategories";
            hdrCategories.Text = "&Categories";
            // 
            // navCategories
            // 
            navCategories.AddNewImage = Resource1.navIBindingList_AddNewImage;
            navCategories.AddNewToolTip = "Add New";
            navCategories.ApplyImage = Resource1.navEmployees_ApplyImage;
            navCategories.ApplyToolTip = "Apply Changes";
            navCategories.CancelImage = Resource1.navEmployees_CancelImage;
            navCategories.CancelToolTip = "Cancel Changes";
            navCategories.DataSource = categoriesBindingSource;
            navCategories.DeleteImage = Resource1.navEmployees_DeleteImage;
            navCategories.DeleteToolTip = "Delete";
            navCategories.EditImage = Resource1.navEmployees_EditImage;
            navCategories.EditToolTip = "Edit";
            navCategories.MoveFirstImage = Resource1.navEmployees_MoveFirstImage;
            navCategories.MoveFirstToolTip = "Move First";
            navCategories.MoveLastImage = Resource1.navEmployees_MoveLastImage;
            navCategories.MoveLastToolTip = "Move Last";
            navCategories.MoveNextImage = Resource1.navEmployees_MoveNextImage;
            navCategories.MoveNextToolTip = "Move Next";
            navCategories.MovePreviousImage = Resource1.navEmployees_MovePreviousImage;
            navCategories.MovePreviousToolTip = "Move Previous";
            navCategories.Name = "navCategories";
            navCategories.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            navCategories.ReloadToolTip = "Reload Data";
            navCategories.SaveToolTip = "Save Data";
            navCategories.Width = 306;
            // 
            // sepLine
            // 
            sepLine.Break = C1.Win.InputPanel.BreakType.Group;
            sepLine.Height = 11;
            sepLine.Name = "sepLine";
            sepLine.Width = 520;
            // 
            // lblCategoryID
            // 
            lblCategoryID.Name = "lblCategoryID";
            lblCategoryID.Text = "Category &ID:";
            lblCategoryID.Width = 91;
            // 
            // numCategoryID
            // 
            numCategoryID.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesBindingSource, "CategoryID", true));
            numCategoryID.Format = "0";
            numCategoryID.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numCategoryID.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            numCategoryID.Name = "numCategoryID";
            numCategoryID.ReadOnly = true;
            // 
            // lblCategoryName
            // 
            lblCategoryName.Name = "lblCategoryName";
            lblCategoryName.Text = "Category &Name:";
            lblCategoryName.Width = 91;
            // 
            // txtCategoryName
            // 
            txtCategoryName.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesBindingSource, "CategoryName", true));
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Width = 200;
            // 
            // lblDescription
            // 
            lblDescription.Name = "lblDescription";
            lblDescription.Text = "&Description:";
            lblDescription.Width = 91;
            // 
            // txtDescription
            // 
            txtDescription.Break = C1.Win.InputPanel.BreakType.Column;
            txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesBindingSource, "Description", true));
            txtDescription.Height = 48;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.VerticalAlign = C1.Win.InputPanel.InputContentAlignment.Spread;
            txtDescription.Width = 200;
            // 
            // lblPicture
            // 
            lblPicture.HorizontalAlign = C1.Win.InputPanel.InputContentAlignment.Center;
            lblPicture.Name = "lblPicture";
            lblPicture.Text = "Picture:";
            lblPicture.VerticalAlign = C1.Win.InputPanel.InputContentAlignment.Far;
            lblPicture.Width = 91;
            // 
            // imgPicture
            // 
            imgPicture.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesBindingSource, "Picture", true));
            imgPicture.Height = 90;
            imgPicture.Name = "imgPicture";
            imgPicture.Width = 90;
            // 
            // InputPanel2
            // 
            InputPanel2.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            InputPanel2.DataSource = categoriesProductsBindingSource;
            InputPanel2.DesignScaleFactor = 1.79353654F;
            InputPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            InputPanel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            InputPanel2.Items.Add(hdrIBindingList);
            InputPanel2.Items.Add(navIBindingList);
            InputPanel2.Items.Add(sepLine1);
            InputPanel2.Items.Add(lblProductID);
            InputPanel2.Items.Add(numProductID);
            InputPanel2.Items.Add(lblProductName);
            InputPanel2.Items.Add(txtProductName);
            InputPanel2.Items.Add(lblSupplierID);
            InputPanel2.Items.Add(numSupplierID);
            InputPanel2.Items.Add(lblCategoryID1);
            InputPanel2.Items.Add(numCategoryID1);
            InputPanel2.Items.Add(lblQuantityPerUnit);
            InputPanel2.Items.Add(txtQuantityPerUnit);
            InputPanel2.Items.Add(lblUnitPrice);
            InputPanel2.Items.Add(numUnitPrice);
            InputPanel2.Items.Add(lblUnitsInStock);
            InputPanel2.Items.Add(numUnitsInStock);
            InputPanel2.Items.Add(lblUnitsOnOrder);
            InputPanel2.Items.Add(numUnitsOnOrder);
            InputPanel2.Items.Add(lblReorderLevel);
            InputPanel2.Items.Add(numReorderLevel);
            InputPanel2.Items.Add(chkDiscontinued);
            InputPanel2.Location = new System.Drawing.Point(0, 297);
            InputPanel2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            InputPanel2.Name = "InputPanel2";
            InputPanel2.Size = new System.Drawing.Size(1641, 644);
            InputPanel2.TabIndex = 1;
            // 
            // categoriesProductsBindingSource
            // 
            categoriesProductsBindingSource.DataMember = "CategoriesProducts";
            categoriesProductsBindingSource.DataSource = categoriesBindingSource;
            // 
            // hdrIBindingList
            // 
            hdrIBindingList.Name = "hdrIBindingList";
            hdrIBindingList.Text = "&Products";
            // 
            // navIBindingList
            // 
            navIBindingList.AddNewImage = Resource1.navIBindingList_AddNewImage;
            navIBindingList.AddNewToolTip = "Add New";
            navIBindingList.ApplyImage = Resource1.navEmployees_ApplyImage;
            navIBindingList.ApplyToolTip = "Apply Changes";
            navIBindingList.CancelImage = Resource1.navEmployees_CancelImage;
            navIBindingList.CancelToolTip = "Cancel Changes";
            navIBindingList.DataSource = categoriesProductsBindingSource;
            navIBindingList.DeleteImage = Resource1.navEmployees_DeleteImage;
            navIBindingList.DeleteToolTip = "Delete";
            navIBindingList.EditImage = Resource1.navEmployees_EditImage;
            navIBindingList.MoveFirstImage = Resource1.navEmployees_MoveFirstImage;
            navIBindingList.MoveFirstToolTip = "Move First";
            navIBindingList.MoveLastImage = Resource1.navEmployees_MoveLastImage;
            navIBindingList.MoveLastToolTip = "Move Last";
            navIBindingList.MoveNextImage = Resource1.navEmployees_MoveNextImage;
            navIBindingList.MoveNextToolTip = "Move Next";
            navIBindingList.MovePreviousImage = Resource1.navEmployees_MovePreviousImage;
            navIBindingList.MovePreviousToolTip = "Move Previous";
            navIBindingList.Name = "navIBindingList";
            navIBindingList.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            navIBindingList.ReloadToolTip = "Reload Data";
            navIBindingList.SaveToolTip = "Save Data";
            navIBindingList.ShowReloadButton = true;
            navIBindingList.ShowSaveButton = true;
            navIBindingList.Width = 352;
            // 
            // sepLine1
            // 
            sepLine1.Break = C1.Win.InputPanel.BreakType.Group;
            sepLine1.Height = 11;
            sepLine1.Name = "sepLine1";
            sepLine1.Width = 520;
            // 
            // lblProductID
            // 
            lblProductID.Name = "lblProductID";
            lblProductID.Text = "P&roduct ID:";
            lblProductID.Width = 99;
            // 
            // numProductID
            // 
            numProductID.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesProductsBindingSource, "ProductID", true));
            numProductID.Format = "0";
            numProductID.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numProductID.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            numProductID.Name = "numProductID";
            numProductID.ReadOnly = true;
            // 
            // lblProductName
            // 
            lblProductName.Name = "lblProductName";
            lblProductName.Text = "Pr&oduct Name:";
            lblProductName.Width = 99;
            // 
            // txtProductName
            // 
            txtProductName.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesProductsBindingSource, "ProductName", true));
            txtProductName.Name = "txtProductName";
            txtProductName.Width = 200;
            // 
            // lblSupplierID
            // 
            lblSupplierID.Name = "lblSupplierID";
            lblSupplierID.Text = "&Supplier ID:";
            lblSupplierID.Width = 99;
            // 
            // numSupplierID
            // 
            numSupplierID.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesProductsBindingSource, "SupplierID", true));
            numSupplierID.Format = "0";
            numSupplierID.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numSupplierID.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            numSupplierID.Name = "numSupplierID";
            // 
            // lblCategoryID1
            // 
            lblCategoryID1.Name = "lblCategoryID1";
            lblCategoryID1.Text = "C&ategory ID:";
            lblCategoryID1.Width = 99;
            // 
            // numCategoryID1
            // 
            numCategoryID1.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesProductsBindingSource, "CategoryID", true));
            numCategoryID1.Format = "0";
            numCategoryID1.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numCategoryID1.Minimum = new decimal(new int[] { int.MinValue, 0, 0, int.MinValue });
            numCategoryID1.Name = "numCategoryID1";
            // 
            // lblQuantityPerUnit
            // 
            lblQuantityPerUnit.Name = "lblQuantityPerUnit";
            lblQuantityPerUnit.Text = "&Quantity Per Unit:";
            lblQuantityPerUnit.Width = 99;
            // 
            // txtQuantityPerUnit
            // 
            txtQuantityPerUnit.Break = C1.Win.InputPanel.BreakType.Column;
            txtQuantityPerUnit.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesProductsBindingSource, "QuantityPerUnit", true));
            txtQuantityPerUnit.Name = "txtQuantityPerUnit";
            txtQuantityPerUnit.Width = 200;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Text = "&Unit Price:";
            lblUnitPrice.Width = 99;
            // 
            // numUnitPrice
            // 
            numUnitPrice.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesProductsBindingSource, "UnitPrice", true));
            numUnitPrice.Format = "C2";
            numUnitPrice.Name = "numUnitPrice";
            // 
            // lblUnitsInStock
            // 
            lblUnitsInStock.Name = "lblUnitsInStock";
            lblUnitsInStock.Text = "Uni&ts In Stock:";
            lblUnitsInStock.Width = 99;
            // 
            // numUnitsInStock
            // 
            numUnitsInStock.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesProductsBindingSource, "UnitsInStock", true));
            numUnitsInStock.Format = "0";
            numUnitsInStock.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            numUnitsInStock.Minimum = new decimal(new int[] { 32768, 0, 0, int.MinValue });
            numUnitsInStock.Name = "numUnitsInStock";
            // 
            // lblUnitsOnOrder
            // 
            lblUnitsOnOrder.Name = "lblUnitsOnOrder";
            lblUnitsOnOrder.Text = "Units On Ord&er:";
            lblUnitsOnOrder.Width = 99;
            // 
            // numUnitsOnOrder
            // 
            numUnitsOnOrder.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesProductsBindingSource, "UnitsOnOrder", true));
            numUnitsOnOrder.Format = "0";
            numUnitsOnOrder.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            numUnitsOnOrder.Minimum = new decimal(new int[] { 32768, 0, 0, int.MinValue });
            numUnitsOnOrder.Name = "numUnitsOnOrder";
            // 
            // lblReorderLevel
            // 
            lblReorderLevel.Name = "lblReorderLevel";
            lblReorderLevel.Text = "Reorder &Level:";
            lblReorderLevel.Width = 99;
            // 
            // numReorderLevel
            // 
            numReorderLevel.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesProductsBindingSource, "ReorderLevel", true));
            numReorderLevel.Format = "0";
            numReorderLevel.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            numReorderLevel.Minimum = new decimal(new int[] { 32768, 0, 0, int.MinValue });
            numReorderLevel.Name = "numReorderLevel";
            // 
            // chkDiscontinued
            // 
            chkDiscontinued.DataBindings.Add(new System.Windows.Forms.Binding("BoundValue", categoriesProductsBindingSource, "Discontinued", true));
            chkDiscontinued.Name = "chkDiscontinued";
            chkDiscontinued.Text = "Discontinued";
            // 
            // splitter1
            // 
            splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            splitter1.Location = new System.Drawing.Point(0, 297);
            splitter1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            splitter1.Name = "splitter1";
            splitter1.Size = new System.Drawing.Size(1641, 10);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // categoriesTableAdapter
            // 
            categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // productsTableAdapter
            // 
            productsTableAdapter.ClearBeforeFill = true;
            // 
            // MasterDetail
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(231, 242, 255);
            Controls.Add(splitter1);
            Controls.Add(InputPanel2);
            Controls.Add(InputPanel1);
            Margin = new System.Windows.Forms.Padding(7, 10, 7, 10);
            Name = "MasterDetail";
            Size = new System.Drawing.Size(1641, 941);
            Load += MasterDetail_Load;
            ((System.ComponentModel.ISupportInitialize)InputPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1DemoDataSet).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputPanel2).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoriesProductsBindingSource).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private C1.Win.InputPanel.C1InputPanel InputPanel1;
        private C1.Win.InputPanel.C1InputPanel InputPanel2;
        private System.Windows.Forms.Splitter splitter1;
        private C1DemoDataSet c1DemoDataSet;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private InputPanelExplorer.Data.C1DemoDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private C1.Win.InputPanel.InputGroupHeader hdrCategories;
        private C1.Win.InputPanel.InputDataNavigator navCategories;
        private C1.Win.InputPanel.InputSeparator sepLine;
        private C1.Win.InputPanel.InputLabel lblCategoryID;
        private C1.Win.InputPanel.InputNumericBox numCategoryID;
        private C1.Win.InputPanel.InputLabel lblCategoryName;
        private C1.Win.InputPanel.InputTextBox txtCategoryName;
        private C1.Win.InputPanel.InputLabel lblDescription;
        private C1.Win.InputPanel.InputTextBox txtDescription;
        private C1.Win.InputPanel.InputLabel lblPicture;
        private C1.Win.InputPanel.InputImage imgPicture;
        private System.Windows.Forms.BindingSource categoriesProductsBindingSource;
        private InputPanelExplorer.Data.C1DemoDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
        private C1.Win.InputPanel.InputGroupHeader hdrIBindingList;
        private C1.Win.InputPanel.InputDataNavigator navIBindingList;
        private C1.Win.InputPanel.InputSeparator sepLine1;
        private C1.Win.InputPanel.InputLabel lblProductID;
        private C1.Win.InputPanel.InputNumericBox numProductID;
        private C1.Win.InputPanel.InputLabel lblProductName;
        private C1.Win.InputPanel.InputTextBox txtProductName;
        private C1.Win.InputPanel.InputLabel lblSupplierID;
        private C1.Win.InputPanel.InputNumericBox numSupplierID;
        private C1.Win.InputPanel.InputLabel lblCategoryID1;
        private C1.Win.InputPanel.InputNumericBox numCategoryID1;
        private C1.Win.InputPanel.InputLabel lblQuantityPerUnit;
        private C1.Win.InputPanel.InputTextBox txtQuantityPerUnit;
        private C1.Win.InputPanel.InputLabel lblUnitPrice;
        private C1.Win.InputPanel.InputNumericBox numUnitPrice;
        private C1.Win.InputPanel.InputLabel lblUnitsInStock;
        private C1.Win.InputPanel.InputNumericBox numUnitsInStock;
        private C1.Win.InputPanel.InputLabel lblUnitsOnOrder;
        private C1.Win.InputPanel.InputNumericBox numUnitsOnOrder;
        private C1.Win.InputPanel.InputLabel lblReorderLevel;
        private C1.Win.InputPanel.InputNumericBox numReorderLevel;
        private C1.Win.InputPanel.InputCheckBox chkDiscontinued;
    }
}