<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paging
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
        Me.C1DataSource1 = New C1.Win.Data.Entities.C1DataSource()
        Me.dataGridView1 = New System.Windows.Forms.DataGridView()
        Me.orderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.orderDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.requiredDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shippedDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shipViaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.freightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shipNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shipAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shipCityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shipRegionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shipPostalCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shipCountryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.shipperDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.labelPage = New System.Windows.Forms.Label()
        Me.btnPrevPage = New System.Windows.Forms.Button()
        CType(Me.C1DataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1DataSource1
        '
        Me.C1DataSource1.ContextType = GetType(TutorialsWinForms.NORTHWNDEntities)
        EntityViewSourceProperties1.EntitySetName = "Orders"
        EntityViewSourceProperties1.PageSize = 10
        Me.C1DataSource1.ViewSourceCollection.Add(EntityViewSourceProperties1)
        '
        'dataGridView1
        '
        Me.dataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dataGridView1.AutoGenerateColumns = False
        Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.orderIDDataGridViewTextBoxColumn, Me.customerIDDataGridViewTextBoxColumn, Me.employeeIDDataGridViewTextBoxColumn, Me.orderDateDataGridViewTextBoxColumn, Me.requiredDateDataGridViewTextBoxColumn, Me.shippedDateDataGridViewTextBoxColumn, Me.shipViaDataGridViewTextBoxColumn, Me.freightDataGridViewTextBoxColumn, Me.shipNameDataGridViewTextBoxColumn, Me.shipAddressDataGridViewTextBoxColumn, Me.shipCityDataGridViewTextBoxColumn, Me.shipRegionDataGridViewTextBoxColumn, Me.shipPostalCodeDataGridViewTextBoxColumn, Me.shipCountryDataGridViewTextBoxColumn, Me.customerDataGridViewTextBoxColumn, Me.employeeDataGridViewTextBoxColumn, Me.shipperDataGridViewTextBoxColumn})
        ControlHandler1.AutoLookup = True
        ControlHandler1.VirtualMode = False
        Me.C1DataSource1.SetControlHandler(Me.dataGridView1, ControlHandler1)
        Me.dataGridView1.DataMember = "Orders"
        Me.dataGridView1.DataSource = Me.C1DataSource1
        Me.dataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.dataGridView1.Name = "dataGridView1"
        Me.dataGridView1.Size = New System.Drawing.Size(887, 256)
        Me.dataGridView1.TabIndex = 20
        '
        'orderIDDataGridViewTextBoxColumn
        '
        Me.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID"
        Me.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID"
        Me.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn"
        '
        'customerIDDataGridViewTextBoxColumn
        '
        Me.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn"
        '
        'employeeIDDataGridViewTextBoxColumn
        '
        Me.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn"
        '
        'orderDateDataGridViewTextBoxColumn
        '
        Me.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate"
        Me.orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate"
        Me.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn"
        '
        'requiredDateDataGridViewTextBoxColumn
        '
        Me.requiredDateDataGridViewTextBoxColumn.DataPropertyName = "RequiredDate"
        Me.requiredDateDataGridViewTextBoxColumn.HeaderText = "RequiredDate"
        Me.requiredDateDataGridViewTextBoxColumn.Name = "requiredDateDataGridViewTextBoxColumn"
        '
        'shippedDateDataGridViewTextBoxColumn
        '
        Me.shippedDateDataGridViewTextBoxColumn.DataPropertyName = "ShippedDate"
        Me.shippedDateDataGridViewTextBoxColumn.HeaderText = "ShippedDate"
        Me.shippedDateDataGridViewTextBoxColumn.Name = "shippedDateDataGridViewTextBoxColumn"
        '
        'shipViaDataGridViewTextBoxColumn
        '
        Me.shipViaDataGridViewTextBoxColumn.DataPropertyName = "ShipVia"
        Me.shipViaDataGridViewTextBoxColumn.HeaderText = "ShipVia"
        Me.shipViaDataGridViewTextBoxColumn.Name = "shipViaDataGridViewTextBoxColumn"
        '
        'freightDataGridViewTextBoxColumn
        '
        Me.freightDataGridViewTextBoxColumn.DataPropertyName = "Freight"
        Me.freightDataGridViewTextBoxColumn.HeaderText = "Freight"
        Me.freightDataGridViewTextBoxColumn.Name = "freightDataGridViewTextBoxColumn"
        '
        'shipNameDataGridViewTextBoxColumn
        '
        Me.shipNameDataGridViewTextBoxColumn.DataPropertyName = "ShipName"
        Me.shipNameDataGridViewTextBoxColumn.HeaderText = "ShipName"
        Me.shipNameDataGridViewTextBoxColumn.Name = "shipNameDataGridViewTextBoxColumn"
        '
        'shipAddressDataGridViewTextBoxColumn
        '
        Me.shipAddressDataGridViewTextBoxColumn.DataPropertyName = "ShipAddress"
        Me.shipAddressDataGridViewTextBoxColumn.HeaderText = "ShipAddress"
        Me.shipAddressDataGridViewTextBoxColumn.Name = "shipAddressDataGridViewTextBoxColumn"
        '
        'shipCityDataGridViewTextBoxColumn
        '
        Me.shipCityDataGridViewTextBoxColumn.DataPropertyName = "ShipCity"
        Me.shipCityDataGridViewTextBoxColumn.HeaderText = "ShipCity"
        Me.shipCityDataGridViewTextBoxColumn.Name = "shipCityDataGridViewTextBoxColumn"
        '
        'shipRegionDataGridViewTextBoxColumn
        '
        Me.shipRegionDataGridViewTextBoxColumn.DataPropertyName = "ShipRegion"
        Me.shipRegionDataGridViewTextBoxColumn.HeaderText = "ShipRegion"
        Me.shipRegionDataGridViewTextBoxColumn.Name = "shipRegionDataGridViewTextBoxColumn"
        '
        'shipPostalCodeDataGridViewTextBoxColumn
        '
        Me.shipPostalCodeDataGridViewTextBoxColumn.DataPropertyName = "ShipPostalCode"
        Me.shipPostalCodeDataGridViewTextBoxColumn.HeaderText = "ShipPostalCode"
        Me.shipPostalCodeDataGridViewTextBoxColumn.Name = "shipPostalCodeDataGridViewTextBoxColumn"
        '
        'shipCountryDataGridViewTextBoxColumn
        '
        Me.shipCountryDataGridViewTextBoxColumn.DataPropertyName = "ShipCountry"
        Me.shipCountryDataGridViewTextBoxColumn.HeaderText = "ShipCountry"
        Me.shipCountryDataGridViewTextBoxColumn.Name = "shipCountryDataGridViewTextBoxColumn"
        '
        'customerDataGridViewTextBoxColumn
        '
        Me.customerDataGridViewTextBoxColumn.DataPropertyName = "Customer"
        Me.customerDataGridViewTextBoxColumn.HeaderText = "Customer"
        Me.customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn"
        '
        'employeeDataGridViewTextBoxColumn
        '
        Me.employeeDataGridViewTextBoxColumn.DataPropertyName = "Employee"
        Me.employeeDataGridViewTextBoxColumn.HeaderText = "Employee"
        Me.employeeDataGridViewTextBoxColumn.Name = "employeeDataGridViewTextBoxColumn"
        '
        'shipperDataGridViewTextBoxColumn
        '
        Me.shipperDataGridViewTextBoxColumn.DataPropertyName = "Shipper"
        Me.shipperDataGridViewTextBoxColumn.HeaderText = "Shipper"
        Me.shipperDataGridViewTextBoxColumn.Name = "shipperDataGridViewTextBoxColumn"
        '
        'btnNextPage
        '
        Me.btnNextPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnNextPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextPage.Location = New System.Drawing.Point(137, 284)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(28, 23)
        Me.btnNextPage.TabIndex = 19
        Me.btnNextPage.Text = ">"
        Me.btnNextPage.UseVisualStyleBackColor = True
        '
        'labelPage
        '
        Me.labelPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelPage.AutoSize = True
        Me.labelPage.Location = New System.Drawing.Point(62, 289)
        Me.labelPage.Name = "labelPage"
        Me.labelPage.Size = New System.Drawing.Size(55, 13)
        Me.labelPage.TabIndex = 18
        Me.labelPage.Text = "Page: 0/0"
        '
        'btnPrevPage
        '
        Me.btnPrevPage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnPrevPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevPage.Location = New System.Drawing.Point(30, 284)
        Me.btnPrevPage.Name = "btnPrevPage"
        Me.btnPrevPage.Size = New System.Drawing.Size(28, 23)
        Me.btnPrevPage.TabIndex = 17
        Me.btnPrevPage.Text = "<"
        Me.btnPrevPage.UseVisualStyleBackColor = True
        '
        'Paging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 324)
        Me.Controls.Add(Me.dataGridView1)
        Me.Controls.Add(Me.btnNextPage)
        Me.Controls.Add(Me.labelPage)
        Me.Controls.Add(Me.btnPrevPage)
        Me.Name = "Paging"
        Me.Text = "Paging"
        CType(Me.C1DataSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents btnNextPage As System.Windows.Forms.Button
    Private WithEvents labelPage As System.Windows.Forms.Label
    Private WithEvents btnPrevPage As System.Windows.Forms.Button
    Private WithEvents dataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents orderIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents customerIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents employeeIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents orderDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents requiredDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents shippedDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents shipViaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents freightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents shipNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents shipAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents shipCityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents shipRegionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents shipPostalCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents shipCountryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents customerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents employeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents shipperDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents C1DataSource1 As C1.Win.Data.Entities.C1DataSource
End Class
