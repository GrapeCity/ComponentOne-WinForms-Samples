<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LargeDataset
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
        Dim ControlHandler1 As C1.Win.Data.ControlHandler = New C1.Win.Data.ControlHandler()
        Me.discountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.c1DataSource1 = New C1.Win.Data.Entities.C1DataSource()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.orderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.c1DataSource1,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'discountDataGridViewTextBoxColumn
        '
        Me.discountDataGridViewTextBoxColumn.DataPropertyName = "Discount"
        Me.discountDataGridViewTextBoxColumn.HeaderText = "Discount"
        Me.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn"
        '
        'c1DataSource1
        '
        Me.c1DataSource1.ContextType = GetType(TutorialsWinForms.NORTHWNDEntities)
        EntityViewSourceProperties1.EntitySetName = "Order_Details"
        EntityViewSourceProperties1.PageSize = 50
        EntityViewSourceProperties1.VirtualMode = C1.Data.DataSource.VirtualModeKind.Managed
        Me.c1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties1)
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.AutoGenerateColumns = false
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.orderIDDataGridViewTextBoxColumn, Me.productIDDataGridViewTextBoxColumn, Me.unitPriceDataGridViewTextBoxColumn, Me.quantityDataGridViewTextBoxColumn, Me.discountDataGridViewTextBoxColumn, Me.orderDataGridViewTextBoxColumn, Me.productDataGridViewTextBoxColumn})
        ControlHandler1.AutoLookup = false
        ControlHandler1.VirtualMode = True
        Me.c1DataSource1.SetControlHandler(Me.dataGridView1, ControlHandler1)
        Me.dataGridView1.DataMember = "Order_Details"
        Me.dataGridView1.DataSource = Me.c1DataSource1
        Me.dataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(514, 606)
        Me.dataGridView1.TabIndex = 1
        '
        'orderIDDataGridViewTextBoxColumn
        '
        Me.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID"
        Me.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID"
        Me.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn"
        '
        'productIDDataGridViewTextBoxColumn
        '
        Me.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID"
        Me.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID"
        Me.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn"
        '
        'unitPriceDataGridViewTextBoxColumn
        '
        Me.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice"
        Me.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice"
        Me.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn"
        '
        'quantityDataGridViewTextBoxColumn
        '
        Me.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn"
        '
        'orderDataGridViewTextBoxColumn
        '
        Me.orderDataGridViewTextBoxColumn.DataPropertyName = "Order"
        Me.orderDataGridViewTextBoxColumn.HeaderText = "Order"
        Me.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn"
        '
        'productDataGridViewTextBoxColumn
        '
        Me.productDataGridViewTextBoxColumn.DataPropertyName = "Product"
        Me.productDataGridViewTextBoxColumn.HeaderText = "Product"
        Me.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn"
        '
        'LargeDataset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(538, 630)
        Me.Controls.Add(Me.dataGridView1)
        Me.Name = "LargeDataset"
        Me.Text = "LargeDataset"
        CType(Me.c1DataSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Private WithEvents discountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents c1DataSource1 As C1.Win.Data.Entities.C1DataSource
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents orderIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents productIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents unitPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents quantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents orderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents productDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
