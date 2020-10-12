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
        Me.components = New System.ComponentModel.Container()
        Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.nORTHWNDDataSet = New Traditional.NORTHWNDDataSet()
        Me.fKProductsCategoriesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.categoriesTableAdapter = New Traditional.NORTHWNDDataSetTableAdapters.CategoriesTableAdapter()
        Me.productsTableAdapter = New Traditional.NORTHWNDDataSetTableAdapters.ProductsTableAdapter()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.textBox4 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.productIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoryIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantityPerUnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitsInStockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitsOnOrderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.reorderLevelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discontinuedDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.label1 = New System.Windows.Forms.Label()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nORTHWNDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fKProductsCategoriesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bindingSource1
        '
        Me.bindingSource1.DataMember = "Categories"
        Me.bindingSource1.DataSource = Me.nORTHWNDDataSet
        '
        'nORTHWNDDataSet
        '
        Me.nORTHWNDDataSet.DataSetName = "NORTHWNDDataSet"
        Me.nORTHWNDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'fKProductsCategoriesBindingSource
        '
        Me.fKProductsCategoriesBindingSource.DataMember = "FK_Products_Categories"
        Me.fKProductsCategoriesBindingSource.DataSource = Me.bindingSource1
        '
        'categoriesTableAdapter
        '
        Me.categoriesTableAdapter.ClearBeforeFill = True
        '
        'productsTableAdapter
        '
        Me.productsTableAdapter.ClearBeforeFill = True
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(232, 368)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(76, 13)
        Me.label5.TabIndex = 21
        Me.label5.Text = "Units in Stock:"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(221, 346)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(89, 13)
        Me.label4.TabIndex = 20
        Me.label4.Text = "Quantity per Unit:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(254, 320)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(56, 13)
        Me.label3.TabIndex = 19
        Me.label3.Text = "Unit Price:"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(232, 290)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(78, 13)
        Me.label2.TabIndex = 18
        Me.label2.Text = "Product Name:"
        '
        'textBox4
        '
        Me.textBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.fKProductsCategoriesBindingSource, "UnitsInStock", True))
        Me.textBox4.Location = New System.Drawing.Point(316, 365)
        Me.textBox4.Name = "textBox4"
        Me.textBox4.Size = New System.Drawing.Size(362, 20)
        Me.textBox4.TabIndex = 17
        '
        'textBox3
        '
        Me.textBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.fKProductsCategoriesBindingSource, "QuantityPerUnit", True))
        Me.textBox3.Location = New System.Drawing.Point(316, 339)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(362, 20)
        Me.textBox3.TabIndex = 16
        '
        'textBox2
        '
        Me.textBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.fKProductsCategoriesBindingSource, "UnitPrice", True))
        Me.textBox2.Location = New System.Drawing.Point(316, 313)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(362, 20)
        Me.textBox2.TabIndex = 15
        '
        'textBox1
        '
        Me.textBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.fKProductsCategoriesBindingSource, "ProductName", True))
        Me.textBox1.Location = New System.Drawing.Point(316, 287)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(362, 20)
        Me.textBox1.TabIndex = 14
        '
        'dataGridView1
        '
        Me.dataGridView1.AutoGenerateColumns = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productIDDataGridViewTextBoxColumn, Me.productNameDataGridViewTextBoxColumn, Me.supplierIDDataGridViewTextBoxColumn, Me.categoryIDDataGridViewTextBoxColumn, Me.quantityPerUnitDataGridViewTextBoxColumn, Me.unitPriceDataGridViewTextBoxColumn, Me.unitsInStockDataGridViewTextBoxColumn, Me.unitsOnOrderDataGridViewTextBoxColumn, Me.reorderLevelDataGridViewTextBoxColumn, Me.discontinuedDataGridViewCheckBoxColumn})
        Me.dataGridView1.DataSource = Me.fKProductsCategoriesBindingSource
        Me.dataGridView1.Location = New System.Drawing.Point(26, 51)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(652, 217)
        Me.dataGridView1.TabIndex = 13
        '
        'productIDDataGridViewTextBoxColumn
        '
        Me.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn"
        Me.productIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'productNameDataGridViewTextBoxColumn
        '
        Me.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName"
        Me.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName"
        Me.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn"
        '
        'supplierIDDataGridViewTextBoxColumn
        '
        Me.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID"
        Me.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID"
        Me.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn"
        '
        'categoryIDDataGridViewTextBoxColumn
        '
        Me.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "CategoryID"
        Me.categoryIDDataGridViewTextBoxColumn.HeaderText = "CategoryID"
        Me.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn"
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
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(282, 27)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(52, 13)
        Me.label1.TabIndex = 12
        Me.label1.Text = "Category:"
        '
        'comboBox1
        '
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Location = New System.Drawing.Point(340, 24)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(338, 21)
        Me.comboBox1.TabIndex = 11
        Me.comboBox1.ValueMember = "CategoryID"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 408)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.textBox4)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.comboBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nORTHWNDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fKProductsCategoriesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents bindingSource1 As System.Windows.Forms.BindingSource
    Private WithEvents nORTHWNDDataSet As Traditional.NORTHWNDDataSet
    Private WithEvents fKProductsCategoriesBindingSource As System.Windows.Forms.BindingSource
    Private WithEvents categoriesTableAdapter As Traditional.NORTHWNDDataSetTableAdapters.CategoriesTableAdapter
    Private WithEvents productsTableAdapter As Traditional.NORTHWNDDataSetTableAdapters.ProductsTableAdapter
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents textBox4 As System.Windows.Forms.TextBox
    Private WithEvents textBox3 As System.Windows.Forms.TextBox
    Private WithEvents textBox2 As System.Windows.Forms.TextBox
    Private WithEvents textBox1 As System.Windows.Forms.TextBox
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents productIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents productNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents supplierIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents categoryIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents quantityPerUnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents unitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents unitsInStockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents unitsOnOrderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents reorderLevelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents discontinuedDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox

End Class
