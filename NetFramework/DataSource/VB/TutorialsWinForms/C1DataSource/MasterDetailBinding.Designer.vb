<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterDetailBinding
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
        Dim EntityViewSourceProperties1 As C1.Win.Data.Entities.EntityViewSourceProperties = New C1.Win.Data.Entities.EntityViewSourceProperties()
        Dim SortDescriptorProperties1 As C1.Win.Data.SortDescriptorProperties = New C1.Win.Data.SortDescriptorProperties()
        Dim ControlHandler1 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Dim ControlHandler2 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Me.c1DataSource1 = New C1.Win.Data.Entities.C1DataSource()
        Me.dataGridView2 = New System.Windows.Forms.DataGridView()
        Me.productIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryIDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantityPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitsInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitsOnOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reorderLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discontinuedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.categoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pictureDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.c1DataSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dataGridView2,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'c1DataSource1
        '
        Me.c1DataSource1.ContextType = GetType(TutorialsWinForms.NORTHWNDEntities)
        EntityViewSourceProperties1.EntitySetName = "Categories"
        SortDescriptorProperties1.PropertyPath = "CategoryID"
        EntityViewSourceProperties1.SortDescriptors.Add(SortDescriptorProperties1)
        Me.c1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties1)
        '
        'dataGridView2
        '
        Me.dataGridView2.AutoGenerateColumns = false
        Me.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productIDDataGridViewTextBoxColumn, Me.productNameDataGridViewTextBoxColumn, Me.categoryIDDataGridViewTextBoxColumn1, Me.supplierIDDataGridViewTextBoxColumn, Me.Category, Me.Supplier, Me.quantityPerUnitDataGridViewTextBoxColumn, Me.unitPriceDataGridViewTextBoxColumn, Me.unitsInStockDataGridViewTextBoxColumn, Me.unitsOnOrderDataGridViewTextBoxColumn, Me.reorderLevelDataGridViewTextBoxColumn, Me.discontinuedDataGridViewCheckBoxColumn})
        ControlHandler1.AutoLookup = True
        ControlHandler1.VirtualMode = false
        Me.c1DataSource1.SetControlHandler(Me.dataGridView2, ControlHandler1)
        Me.dataGridView2.DataMember = "Categories.Products"
        Me.dataGridView2.DataSource = Me.c1DataSource1
        Me.dataGridView2.Location = New System.Drawing.Point(12, 188)
        Me.dataGridView2.Name = "dataGridView2"
        Me.dataGridView2.Size = New System.Drawing.Size(811, 245)
        Me.dataGridView2.TabIndex = 4
        '
        'productIDDataGridViewTextBoxColumn
        '
        Me.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn"
        '
        'productNameDataGridViewTextBoxColumn
        '
        Me.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn"
        '
        'categoryIDDataGridViewTextBoxColumn1
        '
        Me.categoryIDDataGridViewTextBoxColumn1.DataPropertyName = "CategoryID"
        Me.categoryIDDataGridViewTextBoxColumn1.HeaderText = "CategoryID"
        Me.categoryIDDataGridViewTextBoxColumn1.Name = "categoryIDDataGridViewTextBoxColumn1"
        Me.categoryIDDataGridViewTextBoxColumn1.Visible = false
        '
        'supplierIDDataGridViewTextBoxColumn
        '
        Me.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID"
        Me.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID"
        Me.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn"
        Me.supplierIDDataGridViewTextBoxColumn.Visible = false
        '
        'Category
        '
        Me.Category.DataPropertyName = "Category"
        Me.Category.HeaderText = "Category"
        Me.Category.Name = "Category"
        '
        'Supplier
        '
        Me.Supplier.DataPropertyName = "Supplier"
        Me.Supplier.HeaderText = "Supplier"
        Me.Supplier.Name = "Supplier"
        '
        'quantityPerUnitDataGridViewTextBoxColumn
        '
        Me.quantityPerUnitDataGridViewTextBoxColumn.DataPropertyName = "QuantityPerUnit"
        Me.quantityPerUnitDataGridViewTextBoxColumn.HeaderText = "QuantityPerUnit"
        Me.quantityPerUnitDataGridViewTextBoxColumn.Name = "quantityPerUnitDataGridViewTextBoxColumn"
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
        'discontinuedDataGridViewCheckBoxColumn
        '
        Me.discontinuedDataGridViewCheckBoxColumn.DataPropertyName = "Discontinued"
        Me.discontinuedDataGridViewCheckBoxColumn.HeaderText = "Discontinued"
        Me.discontinuedDataGridViewCheckBoxColumn.Name = "discontinuedDataGridViewCheckBoxColumn"
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.AutoGenerateColumns = false
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.categoryIDDataGridViewTextBoxColumn, Me.categoryNameDataGridViewTextBoxColumn, Me.descriptionDataGridViewTextBoxColumn, Me.pictureDataGridViewImageColumn})
        ControlHandler2.AutoLookup = false
        ControlHandler2.VirtualMode = false
        Me.c1DataSource1.SetControlHandler(Me.dataGridView1, ControlHandler2)
        Me.dataGridView1.DataMember = "Categories"
        Me.dataGridView1.DataSource = Me.c1DataSource1
        Me.dataGridView1.Location = New System.Drawing.Point(12, 16)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(811, 161)
        Me.dataGridView1.TabIndex = 3
        '
        'categoryIDDataGridViewTextBoxColumn
        '
        Me.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID"
        Me.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID"
        Me.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn"
        '
        'categoryNameDataGridViewTextBoxColumn
        '
        Me.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName"
        Me.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName"
        Me.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn"
        '
        'descriptionDataGridViewTextBoxColumn
        '
        Me.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.descriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn"
        '
        'pictureDataGridViewImageColumn
        '
        Me.pictureDataGridViewImageColumn.DataPropertyName = "Picture"
        Me.pictureDataGridViewImageColumn.HeaderText = "Picture"
        Me.pictureDataGridViewImageColumn.Name = "pictureDataGridViewImageColumn"
        '
        'MasterDetailBinding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 445)
        Me.Controls.Add(Me.dataGridView2)
        Me.Controls.Add(Me.dataGridView1)
        Me.MaximizeBox = false
        Me.Name = "MasterDetailBinding"
        Me.Text = "MasterDetailBinding"
        CType(Me.c1DataSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dataGridView2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Private WithEvents c1DataSource1 As C1.Win.Data.Entities.C1DataSource
    Private WithEvents dataGridView2 As System.Windows.Forms.DataGridView
    Private WithEvents productIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents productNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents categoryIDDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents supplierIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Category As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Supplier As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents quantityPerUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents unitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents unitsInStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents unitsOnOrderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents reorderLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents discontinuedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents categoryIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents categoryNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents descriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents pictureDataGridViewImageColumn As System.Windows.Forms.DataGridViewImageColumn
End Class
