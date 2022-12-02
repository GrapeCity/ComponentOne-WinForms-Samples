﻿namespace TileExplorer.Samples
{
    partial class DataBound
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
            C1.Win.Tile.PanelElement panelElement1 = new C1.Win.Tile.PanelElement();
            C1.Win.Tile.TextElement textElement1 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.TextElement textElement2 = new C1.Win.Tile.TextElement();
            C1.Win.Tile.ImageElement imageElement1 = new C1.Win.Tile.ImageElement();
            C1.Win.Tile.PropertyMapping propertyMapping1 = new C1.Win.Tile.PropertyMapping();
            C1.Win.Tile.PropertyMapping propertyMapping2 = new C1.Win.Tile.PropertyMapping();
            C1.Win.Tile.PropertyMapping propertyMapping3 = new C1.Win.Tile.PropertyMapping();
            C1.Win.Tile.PropertyMapping propertyMapping4 = new C1.Win.Tile.PropertyMapping();
            C1.Win.Tile.PropertyMapping propertyMapping5 = new C1.Win.Tile.PropertyMapping();
            C1.Win.Tile.PropertyMapping propertyMapping6 = new C1.Win.Tile.PropertyMapping();
            this.c1TileControl1 = new C1.Win.Tile.C1TileControl();
            this.group1 = new C1.Win.Tile.Group();
            this.tile1 = new C1.Win.Tile.Tile();
            this.tile2 = new C1.Win.Tile.Tile();
            this.tile3 = new C1.Win.Tile.Tile();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.discontinuedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.quantityPerUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsInStockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitsOnOrderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1TileControl1
            // 
            this.c1TileControl1.AllowChecking = true;
            this.c1TileControl1.AllowRearranging = true;
            this.c1TileControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1TileControl1.BackColor = System.Drawing.Color.White;
            this.c1TileControl1.CellHeight = 68;
            this.c1TileControl1.CellWidth = 180;
            // 
            // 
            // 
            panelElement1.Alignment = System.Drawing.ContentAlignment.TopLeft;
            textElement1.FontBold = C1.Win.Tile.ThreeStateBoolean.True;
            panelElement1.Children.Add(textElement1);
            panelElement1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            textElement2.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            textElement2.FontItalic = C1.Win.Tile.ThreeStateBoolean.True;
            textElement2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            textElement2.ForeColorSelector = C1.Win.Tile.ForeColorSelector.Unbound;
            textElement2.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            textElement2.TextSelector = C1.Win.Tile.TextSelector.Text1;
            imageElement1.Alignment = System.Drawing.ContentAlignment.BottomRight;
            imageElement1.Image = global::TileExplorer.Properties.Resources.flags;
            imageElement1.ImageRows = 17;
            imageElement1.ImageSelector = C1.Win.Tile.ImageSelector.Unbound;
            this.c1TileControl1.DefaultTemplate.Elements.Add(panelElement1);
            this.c1TileControl1.DefaultTemplate.Elements.Add(textElement2);
            this.c1TileControl1.DefaultTemplate.Elements.Add(imageElement1);
            this.c1TileControl1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(104)))), ((int)(((byte)(197)))));
            this.c1TileControl1.Groups.Add(this.group1);
            this.c1TileControl1.GroupTextSize = 14F;
            this.c1TileControl1.Location = new System.Drawing.Point(12, 12);
            this.c1TileControl1.Name = "c1TileControl1";
            this.c1TileControl1.Padding = new System.Windows.Forms.Padding(0, 48, 0, 0);
            propertyMapping1.DataField = "ProductID";
            propertyMapping1.TileProperty = C1.Win.Tile.TileProperty.Tag;
            propertyMapping2.DataField = "CategoryID";            
            propertyMapping2.Lookup.DisplayMember = "Categories.CategoryName";
            propertyMapping2.Lookup.ValueMember = "Categories.CategoryID";
            propertyMapping2.TileProperty = C1.Win.Tile.TileProperty.Group;
            propertyMapping3.DataField = "ProductName";
            propertyMapping3.TileProperty = C1.Win.Tile.TileProperty.Text;
            propertyMapping4.DataField = "SupplierID";            
            propertyMapping4.Lookup.DisplayMember = "Suppliers.Country";
            propertyMapping4.Lookup.ValueMember = "Suppliers.SupplierID";
            propertyMapping4.TileProperty = C1.Win.Tile.TileProperty.Text1;
            propertyMapping5.DataField = "SupplierID";            
            propertyMapping5.Lookup.DisplayMember = "Suppliers.Country";
            propertyMapping5.Lookup.ValueMember = "Suppliers.SupplierID";
            propertyMapping5.TileProperty = C1.Win.Tile.TileProperty.IntValue;
            propertyMapping6.DataField = "Discontinued";
            propertyMapping6.TileProperty = C1.Win.Tile.TileProperty.BackColor;
            this.c1TileControl1.PropertyMappings.Add(propertyMapping1);
            this.c1TileControl1.PropertyMappings.Add(propertyMapping2);
            this.c1TileControl1.PropertyMappings.Add(propertyMapping3);
            this.c1TileControl1.PropertyMappings.Add(propertyMapping4);
            this.c1TileControl1.PropertyMappings.Add(propertyMapping5);
            this.c1TileControl1.PropertyMappings.Add(propertyMapping6);
            this.c1TileControl1.ScrollBarStyle = C1.Win.Tile.ScrollBarStyle.System;
            this.c1TileControl1.Size = new System.Drawing.Size(782, 348);
            this.c1TileControl1.TabIndex = 0;
            this.c1TileControl1.Text = "Products (by Categories)";
            this.c1TileControl1.TextBold = C1.Win.Tile.ThreeStateBoolean.True;
            this.c1TileControl1.TextSize = 18F;
            this.c1TileControl1.TextY = 14;
            this.c1TileControl1.TileClicked += new System.EventHandler<C1.Win.Tile.TileEventArgs>(this.c1TileControl1_TileClicked);
            this.c1TileControl1.FormatValue += new System.EventHandler<C1.Win.Tile.FormatValueEventArgs>(this.c1TileControl1_FormatValue);
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Text = "Group 1";
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile3);
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.LightCoral;
            this.tile1.Name = "tile1";
            this.tile1.Text = "Tile 1";
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.Teal;
            this.tile2.Name = "tile2";
            this.tile2.Text = "Tile 2";
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.SteelBlue;
            this.tile3.Name = "tile3";
            this.tile3.Text = "Tile 3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.supplierIDDataGridViewTextBoxColumn,
            this.categoryIDDataGridViewTextBoxColumn,
            this.discontinuedDataGridViewCheckBoxColumn,
            this.quantityPerUnitDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.unitsInStockDataGridViewTextBoxColumn,
            this.unitsOnOrderDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn});            
            this.dataGridView1.Location = new System.Drawing.Point(12, 372);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(782, 176);
            this.dataGridView1.TabIndex = 1;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 70;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";            
            this.supplierIDDataGridViewTextBoxColumn.DisplayMember = "Suppliers.CompanyName";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.supplierIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.supplierIDDataGridViewTextBoxColumn.ValueMember = "Suppliers.SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID";            
            this.categoryIDDataGridViewTextBoxColumn.DisplayMember = "Categories.CategoryName";
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categoryIDDataGridViewTextBoxColumn.ValueMember = "Categories.CategoryID";
            this.categoryIDDataGridViewTextBoxColumn.Width = 140;
            // 
            // discontinuedDataGridViewCheckBoxColumn
            // 
            this.discontinuedDataGridViewCheckBoxColumn.DataPropertyName = "Discontinued";
            this.discontinuedDataGridViewCheckBoxColumn.HeaderText = "Discontinued";
            this.discontinuedDataGridViewCheckBoxColumn.Name = "discontinuedDataGridViewCheckBoxColumn";
            // 
            // quantityPerUnitDataGridViewTextBoxColumn
            // 
            this.quantityPerUnitDataGridViewTextBoxColumn.DataPropertyName = "QuantityPerUnit";
            this.quantityPerUnitDataGridViewTextBoxColumn.HeaderText = "QuantityPerUnit";
            this.quantityPerUnitDataGridViewTextBoxColumn.Name = "quantityPerUnitDataGridViewTextBoxColumn";
            this.quantityPerUnitDataGridViewTextBoxColumn.Width = 200;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // unitsInStockDataGridViewTextBoxColumn
            // 
            this.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock";
            this.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn";
            // 
            // unitsOnOrderDataGridViewTextBoxColumn
            // 
            this.unitsOnOrderDataGridViewTextBoxColumn.DataPropertyName = "UnitsOnOrder";
            this.unitsOnOrderDataGridViewTextBoxColumn.HeaderText = "UnitsOnOrder";
            this.unitsOnOrderDataGridViewTextBoxColumn.Name = "unitsOnOrderDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // DataBound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(806, 560);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.c1TileControl1);
            this.Load += new System.EventHandler(this.DataBound_Load);            
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Tile.C1TileControl c1TileControl1;
        private C1.Win.Tile.Group group1;
        private C1.Win.Tile.Tile tile1;
        private C1.Win.Tile.Tile tile2;
        private C1.Win.Tile.Tile tile3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn discontinuedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityPerUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsInStockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitsOnOrderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
    }
}
