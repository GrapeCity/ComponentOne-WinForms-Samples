<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServerSideFiltering
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
        Dim EntityViewSourceProperties2 As C1.Win.Data.Entities.EntityViewSourceProperties = New C1.Win.Data.Entities.EntityViewSourceProperties()
        Dim FilterDescriptorProperties1 As C1.Win.Data.FilterDescriptorProperties = New C1.Win.Data.FilterDescriptorProperties()
        Dim SortDescriptorProperties1 As C1.Win.Data.SortDescriptorProperties = New C1.Win.Data.SortDescriptorProperties()
        Dim ControlHandler1 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Me.C1DataSource1 = New C1.Win.Data.Entities.C1DataSource()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
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
        CType(Me.C1DataSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'C1DataSource1
        '
        Me.C1DataSource1.ContextType = GetType(TutorialsWinForms.NORTHWNDEntities)
        EntityViewSourceProperties1.EntitySetName = "Categories"
        EntityViewSourceProperties2.EntitySetName = "Products"
        FilterDescriptorProperties1.PropertyPath = "CategoryID"
        FilterDescriptorProperties1.Value = "1"
        EntityViewSourceProperties2.FilterDescriptors.Add(FilterDescriptorProperties1)
        SortDescriptorProperties1.PropertyPath = "ProductName"
        EntityViewSourceProperties2.SortDescriptors.Add(SortDescriptorProperties1)
        Me.C1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties1)
        Me.C1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties2)
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.Location = New System.Drawing.Point(704, 376)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(104, 23)
        Me.btnSaveChanges.TabIndex = 19
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = true
        '
        'comboBox1
        '
        Me.comboBox1.DataSource = Me.C1DataSource1
        Me.comboBox1.DisplayMember = "Categories.CategoryName"
        Me.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBox1.FormattingEnabled = true
        Me.comboBox1.Location = New System.Drawing.Point(34, 33)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(175, 21)
        Me.comboBox1.TabIndex = 18
        Me.comboBox1.ValueMember = "Categories.CategoryID"
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.AutoGenerateColumns = false
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productIDDataGridViewTextBoxColumn, Me.productNameDataGridViewTextBoxColumn, Me.supplierIDDataGridViewTextBoxColumn, Me.categoryIDDataGridViewTextBoxColumn, Me.quantityPerUnitDataGridViewTextBoxColumn, Me.unitPriceDataGridViewTextBoxColumn, Me.unitsInStockDataGridViewTextBoxColumn, Me.unitsOnOrderDataGridViewTextBoxColumn, Me.reorderLevelDataGridViewTextBoxColumn, Me.discontinuedDataGridViewCheckBoxColumn})
        ControlHandler1.AutoLookup = false
        ControlHandler1.VirtualMode = false
        Me.C1DataSource1.SetControlHandler(Me.dataGridView1, ControlHandler1)
        Me.dataGridView1.DataMember = "Products"
        Me.dataGridView1.DataSource = Me.C1DataSource1
        Me.dataGridView1.Location = New System.Drawing.Point(34, 75)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(774, 285)
        Me.dataGridView1.TabIndex = 20
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
        'ServerSideFiltering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 433)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.comboBox1)
        Me.Name = "ServerSideFiltering"
        Me.Text = "ServerSideFiltering"
        CType(Me.C1DataSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Private WithEvents btnSaveChanges As System.Windows.Forms.Button
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
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
    Private WithEvents C1DataSource1 As C1.Win.Data.Entities.C1DataSource
End Class
