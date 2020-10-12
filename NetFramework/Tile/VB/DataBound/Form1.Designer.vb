<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim PanelElement1 As C1.Win.C1Tile.PanelElement = New C1.Win.C1Tile.PanelElement
        Dim TextElement1 As C1.Win.C1Tile.TextElement = New C1.Win.C1Tile.TextElement
        Dim TextElement2 As C1.Win.C1Tile.TextElement = New C1.Win.C1Tile.TextElement
        Dim ImageElement1 As C1.Win.C1Tile.ImageElement = New C1.Win.C1Tile.ImageElement
        Dim PropertyMapping1 As C1.Win.C1Tile.PropertyMapping = New C1.Win.C1Tile.PropertyMapping
        Dim PropertyMapping2 As C1.Win.C1Tile.PropertyMapping = New C1.Win.C1Tile.PropertyMapping
        Dim PropertyMapping3 As C1.Win.C1Tile.PropertyMapping = New C1.Win.C1Tile.PropertyMapping
        Dim PropertyMapping4 As C1.Win.C1Tile.PropertyMapping = New C1.Win.C1Tile.PropertyMapping
        Dim PropertyMapping5 As C1.Win.C1Tile.PropertyMapping = New C1.Win.C1Tile.PropertyMapping
        Dim PropertyMapping6 As C1.Win.C1Tile.PropertyMapping = New C1.Win.C1Tile.PropertyMapping
        Me.DataSet11 = New DataBound.DataSet1
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.productsConnection = New System.Data.OleDb.OleDbConnection
        Me.productsDataAdapter = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.categoriesDataAdapter = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbSelectCommand3 = New System.Data.OleDb.OleDbCommand
        Me.suppliersDataAdapter = New System.Data.OleDb.OleDbDataAdapter
        Me.c1TileControl1 = New C1.Win.C1Tile.C1TileControl
        Me.group1 = New C1.Win.C1Tile.Group
        Me.tile1 = New C1.Win.C1Tile.Tile
        Me.tile2 = New C1.Win.C1Tile.Tile
        Me.tile3 = New C1.Win.C1Tile.Tile
        Me.dataGridView1 = New System.Windows.Forms.DataGridView
        Me.productIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.productNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.supplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.categoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.discontinuedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.quantityPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.unitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.unitsInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.unitsOnOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.reorderLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT        Products.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Products"
        Me.OleDbSelectCommand1.Connection = Me.productsConnection
        '
        'productsConnection
        '
        Me.productsConnection.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=""C:\Users\Andrey\Documents\Component" & _
            "One Samples\Common\C1NWind.mdb"""
        '
        'productsDataAdapter
        '
        Me.productsDataAdapter.SelectCommand = Me.OleDbSelectCommand1
        Me.productsDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT        Categories.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Categories"
        Me.OleDbSelectCommand2.Connection = Me.productsConnection
        '
        'categoriesDataAdapter
        '
        Me.categoriesDataAdapter.SelectCommand = Me.OleDbSelectCommand2
        Me.categoriesDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Picture", "Picture")})})
        '
        'OleDbSelectCommand3
        '
        Me.OleDbSelectCommand3.CommandText = "SELECT        Suppliers.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Suppliers"
        Me.OleDbSelectCommand3.Connection = Me.productsConnection
        '
        'suppliersDataAdapter
        '
        Me.suppliersDataAdapter.SelectCommand = Me.OleDbSelectCommand3
        Me.suppliersDataAdapter.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Suppliers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CompanyName", "CompanyName"), New System.Data.Common.DataColumnMapping("ContactName", "ContactName"), New System.Data.Common.DataColumnMapping("ContactTitle", "ContactTitle"), New System.Data.Common.DataColumnMapping("Address", "Address"), New System.Data.Common.DataColumnMapping("City", "City"), New System.Data.Common.DataColumnMapping("Region", "Region"), New System.Data.Common.DataColumnMapping("PostalCode", "PostalCode"), New System.Data.Common.DataColumnMapping("Country", "Country"), New System.Data.Common.DataColumnMapping("Phone", "Phone"), New System.Data.Common.DataColumnMapping("Fax", "Fax"), New System.Data.Common.DataColumnMapping("HomePage", "HomePage")})})
        '
        'c1TileControl1
        '
        Me.c1TileControl1.AllowChecking = True
        Me.c1TileControl1.AllowRearranging = True
        Me.c1TileControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.c1TileControl1.BackColor = System.Drawing.Color.White
        Me.c1TileControl1.CellHeight = 68
        Me.c1TileControl1.CellWidth = 180
        Me.c1TileControl1.DataMember = "Products"
        Me.c1TileControl1.DataSource = Me.DataSet11
        '
        '
        '
        PanelElement1.Alignment = System.Drawing.ContentAlignment.TopLeft
        TextElement1.FontBold = C1.Win.C1Tile.ThreeStateBoolean.[True]
        PanelElement1.Children.Add(TextElement1)
        PanelElement1.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        TextElement2.Alignment = System.Drawing.ContentAlignment.BottomLeft
        TextElement2.FontItalic = C1.Win.C1Tile.ThreeStateBoolean.[True]
        TextElement2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        TextElement2.ForeColorSelector = C1.Win.C1Tile.ForeColorSelector.Unbound
        TextElement2.Margin = New System.Windows.Forms.Padding(10, 6, 10, 6)
        TextElement2.TextSelector = C1.Win.C1Tile.TextSelector.Text1
        ImageElement1.Alignment = System.Drawing.ContentAlignment.BottomRight
        ImageElement1.Image = Global.DataBound.My.Resources.Resources.flags
        ImageElement1.ImageRows = 17
        ImageElement1.ImageSelector = C1.Win.C1Tile.ImageSelector.Unbound
        Me.c1TileControl1.DefaultTemplate.Elements.Add(PanelElement1)
        Me.c1TileControl1.DefaultTemplate.Elements.Add(TextElement2)
        Me.c1TileControl1.DefaultTemplate.Elements.Add(ImageElement1)
        Me.c1TileControl1.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(104, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.c1TileControl1.Groups.Add(Me.group1)
        Me.c1TileControl1.GroupTextSize = 14.0!
        Me.c1TileControl1.Location = New System.Drawing.Point(12, 12)
        Me.c1TileControl1.Name = "c1TileControl1"
        Me.c1TileControl1.Padding = New System.Windows.Forms.Padding(0, 48, 0, 0)
        PropertyMapping1.DataField = "ProductID"
        PropertyMapping1.TileProperty = C1.Win.C1Tile.TileProperty.Tag
        PropertyMapping2.DataField = "CategoryID"
        PropertyMapping2.Lookup.DataSource = Me.DataSet11
        PropertyMapping2.Lookup.DisplayMember = "Categories.CategoryName"
        PropertyMapping2.Lookup.ValueMember = "Categories.CategoryID"
        PropertyMapping2.TileProperty = C1.Win.C1Tile.TileProperty.Group
        PropertyMapping3.DataField = "ProductName"
        PropertyMapping3.TileProperty = C1.Win.C1Tile.TileProperty.Text
        PropertyMapping4.DataField = "SupplierID"
        PropertyMapping4.Lookup.DataSource = Me.DataSet11
        PropertyMapping4.Lookup.DisplayMember = "Suppliers.Country"
        PropertyMapping4.Lookup.ValueMember = "Suppliers.SupplierID"
        PropertyMapping4.TileProperty = C1.Win.C1Tile.TileProperty.Text1
        PropertyMapping5.DataField = "SupplierID"
        PropertyMapping5.Lookup.DataSource = Me.DataSet11
        PropertyMapping5.Lookup.DisplayMember = "Suppliers.Country"
        PropertyMapping5.Lookup.ValueMember = "Suppliers.SupplierID"
        PropertyMapping5.TileProperty = C1.Win.C1Tile.TileProperty.IntValue
        PropertyMapping6.DataField = "Discontinued"
        PropertyMapping6.TileProperty = C1.Win.C1Tile.TileProperty.BackColor
        Me.c1TileControl1.PropertyMappings.Add(PropertyMapping1)
        Me.c1TileControl1.PropertyMappings.Add(PropertyMapping2)
        Me.c1TileControl1.PropertyMappings.Add(PropertyMapping3)
        Me.c1TileControl1.PropertyMappings.Add(PropertyMapping4)
        Me.c1TileControl1.PropertyMappings.Add(PropertyMapping5)
        Me.c1TileControl1.PropertyMappings.Add(PropertyMapping6)
        Me.c1TileControl1.ScrollBarStyle = C1.Win.C1Tile.ScrollBarStyle.System
        Me.c1TileControl1.Size = New System.Drawing.Size(782, 348)
        Me.c1TileControl1.TabIndex = 1
        Me.c1TileControl1.Text = "Products (by Categories)"
        Me.c1TileControl1.TextBold = C1.Win.C1Tile.ThreeStateBoolean.[True]
        Me.c1TileControl1.TextSize = 18.0!
        Me.c1TileControl1.TextY = 14
        '
        'group1
        '
        Me.group1.Name = "group1"
        Me.group1.Text = "Group 1"
        Me.group1.Tiles.Add(Me.tile1)
        Me.group1.Tiles.Add(Me.tile2)
        Me.group1.Tiles.Add(Me.tile3)
        '
        'tile1
        '
        Me.tile1.BackColor = System.Drawing.Color.LightCoral
        Me.tile1.Name = "tile1"
        Me.tile1.Text = "Tile 1"
        '
        'tile2
        '
        Me.tile2.BackColor = System.Drawing.Color.Teal
        Me.tile2.Name = "tile2"
        Me.tile2.Text = "Tile 2"
        '
        'tile3
        '
        Me.tile3.BackColor = System.Drawing.Color.SteelBlue
        Me.tile3.Name = "tile3"
        Me.tile3.Text = "Tile 3"
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.AutoGenerateColumns = False
        Me.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productIDDataGridViewTextBoxColumn, Me.productNameDataGridViewTextBoxColumn, Me.supplierIDDataGridViewTextBoxColumn, Me.categoryIDDataGridViewTextBoxColumn, Me.discontinuedDataGridViewCheckBoxColumn, Me.quantityPerUnitDataGridViewTextBoxColumn, Me.unitPriceDataGridViewTextBoxColumn, Me.unitsInStockDataGridViewTextBoxColumn, Me.unitsOnOrderDataGridViewTextBoxColumn, Me.reorderLevelDataGridViewTextBoxColumn})
        Me.dataGridView1.DataMember = "Products"
        Me.dataGridView1.DataSource = Me.DataSet11
        Me.dataGridView1.Location = New System.Drawing.Point(12, 372)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(782, 176)
        Me.dataGridView1.TabIndex = 2
        '
        'productIDDataGridViewTextBoxColumn
        '
        Me.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn"
        Me.productIDDataGridViewTextBoxColumn.Width = 70
        '
        'productNameDataGridViewTextBoxColumn
        '
        Me.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn"
        Me.productNameDataGridViewTextBoxColumn.Width = 200
        '
        'supplierIDDataGridViewTextBoxColumn
        '
        Me.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID"
        Me.supplierIDDataGridViewTextBoxColumn.DataSource = Me.DataSet11
        Me.supplierIDDataGridViewTextBoxColumn.DisplayMember = "Suppliers.CompanyName"
        Me.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID"
        Me.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn"
        Me.supplierIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.supplierIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.supplierIDDataGridViewTextBoxColumn.ValueMember = "Suppliers.SupplierID"
        Me.supplierIDDataGridViewTextBoxColumn.Width = 200
        '
        'categoryIDDataGridViewTextBoxColumn
        '
        Me.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID"
        Me.categoryIDDataGridViewTextBoxColumn.DataSource = Me.DataSet11
        Me.categoryIDDataGridViewTextBoxColumn.DisplayMember = "Categories.CategoryName"
        Me.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID"
        Me.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn"
        Me.categoryIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.categoryIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.categoryIDDataGridViewTextBoxColumn.ValueMember = "Categories.CategoryID"
        Me.categoryIDDataGridViewTextBoxColumn.Width = 140
        '
        'discontinuedDataGridViewCheckBoxColumn
        '
        Me.discontinuedDataGridViewCheckBoxColumn.DataPropertyName = "Discontinued"
        Me.discontinuedDataGridViewCheckBoxColumn.HeaderText = "Discontinued"
        Me.discontinuedDataGridViewCheckBoxColumn.Name = "discontinuedDataGridViewCheckBoxColumn"
        '
        'quantityPerUnitDataGridViewTextBoxColumn
        '
        Me.quantityPerUnitDataGridViewTextBoxColumn.DataPropertyName = "QuantityPerUnit"
        Me.quantityPerUnitDataGridViewTextBoxColumn.HeaderText = "QuantityPerUnit"
        Me.quantityPerUnitDataGridViewTextBoxColumn.Name = "quantityPerUnitDataGridViewTextBoxColumn"
        Me.quantityPerUnitDataGridViewTextBoxColumn.Width = 200
        '
        'unitPriceDataGridViewTextBoxColumn
        '
        Me.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice"
        Me.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn"
        '
        'unitsInStockDataGridViewTextBoxColumn
        '
        Me.unitsInStockDataGridViewTextBoxColumn.DataPropertyName = "UnitsInStock"
        Me.unitsInStockDataGridViewTextBoxColumn.HeaderText = "UnitsInStock"
        Me.unitsInStockDataGridViewTextBoxColumn.Name = "unitsInStockDataGridViewTextBoxColumn"
        '
        'unitsOnOrderDataGridViewTextBoxColumn
        '
        Me.unitsOnOrderDataGridViewTextBoxColumn.DataPropertyName = "UnitsOnOrder"
        Me.unitsOnOrderDataGridViewTextBoxColumn.HeaderText = "UnitsOnOrder"
        Me.unitsOnOrderDataGridViewTextBoxColumn.Name = "unitsOnOrderDataGridViewTextBoxColumn"
        '
        'reorderLevelDataGridViewTextBoxColumn
        '
        Me.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel"
        Me.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel"
        Me.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(806, 560)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.c1TileControl1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Name = "Form1"
        Me.Text = "Filling Tiles from DataSource"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents productsConnection As System.Data.OleDb.OleDbConnection
    Friend WithEvents productsDataAdapter As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents categoriesDataAdapter As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand3 As System.Data.OleDb.OleDbCommand
    Friend WithEvents suppliersDataAdapter As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet11 As DataBound.DataSet1
    Private WithEvents c1TileControl1 As C1.Win.C1Tile.C1TileControl
    Private WithEvents group1 As C1.Win.C1Tile.Group
    Private WithEvents tile1 As C1.Win.C1Tile.Tile
    Private WithEvents tile2 As C1.Win.C1Tile.Tile
    Private WithEvents tile3 As C1.Win.C1Tile.Tile
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents productIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents productNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents supplierIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Private WithEvents categoryIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewComboBoxColumn
    Private WithEvents discontinuedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents quantityPerUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents unitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents unitsInStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents unitsOnOrderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents reorderLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
