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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.gbDatabase = New System.Windows.Forms.GroupBox()
        Me.cbItemsCount = New System.Windows.Forms.ComboBox()
        Me.label7 = New System.Windows.Forms.Label()
        Me.lblItemsCount = New System.Windows.Forms.Label()
        Me.label6 = New System.Windows.Forms.Label()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.lblResultTotalRows = New System.Windows.Forms.Label()
        Me.label8 = New System.Windows.Forms.Label()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPageOD = New System.Windows.Forms.TabPage()
        Me.lblODRowsTotal = New System.Windows.Forms.Label()
        Me.label10 = New System.Windows.Forms.Label()
        Me.dgvOrderDetails = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tabPageProducts = New System.Windows.Forms.TabPage()
        Me.lblProductsRowsTotal = New System.Windows.Forms.Label()
        Me.label11 = New System.Windows.Forms.Label()
        Me.dgvProducts = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tabPageOrders = New System.Windows.Forms.TabPage()
        Me.lblOrdersTotalRows = New System.Windows.Forms.Label()
        Me.label12 = New System.Windows.Forms.Label()
        Me.dgvOrders = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.tabPageResults = New System.Windows.Forms.TabPage()
        Me.dgvResult = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.btnFlexPivot = New System.Windows.Forms.Button()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnExec = New System.Windows.Forms.Button()
        Me.panelGroupRange = New System.Windows.Forms.Panel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.nudGroupFilter = New System.Windows.Forms.NumericUpDown()
        Me.label2 = New System.Windows.Forms.Label()
        Me.cbQuery = New System.Windows.Forms.ComboBox()
        Me.panelJoin = New System.Windows.Forms.Panel()
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.nudUnitPriceTo = New System.Windows.Forms.NumericUpDown()
        Me.panelJoinFlexPivot = New System.Windows.Forms.Panel()
        Me.cbProduct = New System.Windows.Forms.ComboBox()
        Me.panelUnitPriceRange = New System.Windows.Forms.Panel()
        Me.nudUnitPriceFrom = New System.Windows.Forms.NumericUpDown()
        Me.label5 = New System.Windows.Forms.Label()
        Me.gbQuery = New System.Windows.Forms.GroupBox()
        Me.panelProduct = New System.Windows.Forms.Panel()
        Me.gbDatabase.SuspendLayout()
        Me.tabControl1.SuspendLayout()
        Me.tabPageOD.SuspendLayout()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageProducts.SuspendLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageOrders.SuspendLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPageResults.SuspendLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelGroupRange.SuspendLayout()
        CType(Me.nudGroupFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudUnitPriceTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelJoinFlexPivot.SuspendLayout()
        Me.panelUnitPriceRange.SuspendLayout()
        CType(Me.nudUnitPriceFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbQuery.SuspendLayout()
        Me.panelProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDatabase
        '
        Me.gbDatabase.Controls.Add(Me.cbItemsCount)
        Me.gbDatabase.Controls.Add(Me.label7)
        Me.gbDatabase.Controls.Add(Me.lblItemsCount)
        Me.gbDatabase.Controls.Add(Me.label6)
        Me.gbDatabase.Controls.Add(Me.lblWarning)
        Me.gbDatabase.Controls.Add(Me.btnGenerate)
        Me.gbDatabase.Location = New System.Drawing.Point(14, 6)
        Me.gbDatabase.Name = "gbDatabase"
        Me.gbDatabase.Size = New System.Drawing.Size(289, 123)
        Me.gbDatabase.TabIndex = 13
        Me.gbDatabase.TabStop = False
        Me.gbDatabase.Text = "Database"
        '
        'cbItemsCount
        '
        Me.cbItemsCount.FormattingEnabled = True
        Me.cbItemsCount.Items.AddRange(New Object() {"100,000", "1,000,000", "10,000,000"})
        Me.cbItemsCount.Location = New System.Drawing.Point(14, 50)
        Me.cbItemsCount.Name = "cbItemsCount"
        Me.cbItemsCount.Size = New System.Drawing.Size(170, 21)
        Me.cbItemsCount.TabIndex = 8
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.Location = New System.Drawing.Point(10, 34)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(181, 13)
        Me.label7.TabIndex = 4
        Me.label7.Text = "Select how many rows to add:"
        '
        'lblItemsCount
        '
        Me.lblItemsCount.AutoSize = True
        Me.lblItemsCount.Location = New System.Drawing.Point(93, 17)
        Me.lblItemsCount.Name = "lblItemsCount"
        Me.lblItemsCount.Size = New System.Drawing.Size(14, 13)
        Me.lblItemsCount.TabIndex = 3
        Me.lblItemsCount.Text = "0"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Location = New System.Drawing.Point(10, 17)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(80, 13)
        Me.label6.TabIndex = 2
        Me.label6.Text = "Items count:"
        '
        'lblWarning
        '
        Me.lblWarning.ForeColor = System.Drawing.Color.Red
        Me.lblWarning.Location = New System.Drawing.Point(10, 84)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(272, 38)
        Me.lblWarning.TabIndex = 0
        Me.lblWarning.Text = "No data is available. Click ""Generate"" button to start working with the sample."
        Me.lblWarning.Visible = False
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(195, 48)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(87, 23)
        Me.btnGenerate.TabIndex = 1
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'lblDesc
        '
        Me.lblDesc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(3, 2)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(636, 46)
        Me.lblDesc.TabIndex = 9
        Me.lblDesc.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblResultTotalRows
        '
        Me.lblResultTotalRows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblResultTotalRows.AutoSize = True
        Me.lblResultTotalRows.Location = New System.Drawing.Point(76, 343)
        Me.lblResultTotalRows.Name = "lblResultTotalRows"
        Me.lblResultTotalRows.Size = New System.Drawing.Size(14, 13)
        Me.lblResultTotalRows.TabIndex = 10
        Me.lblResultTotalRows.Text = "0"
        '
        'label8
        '
        Me.label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label8.AutoSize = True
        Me.label8.Location = New System.Drawing.Point(5, 342)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(70, 13)
        Me.label8.TabIndex = 9
        Me.label8.Text = "Total rows:"
        '
        'tabControl1
        '
        Me.tabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabControl1.Controls.Add(Me.tabPageOD)
        Me.tabControl1.Controls.Add(Me.tabPageProducts)
        Me.tabControl1.Controls.Add(Me.tabPageOrders)
        Me.tabControl1.Controls.Add(Me.tabPageResults)
        Me.tabControl1.Location = New System.Drawing.Point(14, 135)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(652, 387)
        Me.tabControl1.TabIndex = 14
        '
        'tabPageOD
        '
        Me.tabPageOD.Controls.Add(Me.lblODRowsTotal)
        Me.tabPageOD.Controls.Add(Me.label10)
        Me.tabPageOD.Controls.Add(Me.dgvOrderDetails)
        Me.tabPageOD.Location = New System.Drawing.Point(4, 22)
        Me.tabPageOD.Name = "tabPageOD"
        Me.tabPageOD.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageOD.Size = New System.Drawing.Size(644, 361)
        Me.tabPageOD.TabIndex = 0
        Me.tabPageOD.Text = "Order Details"
        Me.tabPageOD.UseVisualStyleBackColor = True
        '
        'lblODRowsTotal
        '
        Me.lblODRowsTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblODRowsTotal.AutoSize = True
        Me.lblODRowsTotal.Location = New System.Drawing.Point(75, 343)
        Me.lblODRowsTotal.Name = "lblODRowsTotal"
        Me.lblODRowsTotal.Size = New System.Drawing.Size(14, 13)
        Me.lblODRowsTotal.TabIndex = 12
        Me.lblODRowsTotal.Text = "0"
        '
        'label10
        '
        Me.label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label10.AutoSize = True
        Me.label10.Location = New System.Drawing.Point(3, 342)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(70, 13)
        Me.label10.TabIndex = 11
        Me.label10.Text = "Total rows:"
        '
        'dgvOrderDetails
        '
        Me.dgvOrderDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrderDetails.ColumnInfo = "10,1,0,0,0,100,Columns:"
        Me.dgvOrderDetails.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.dgvOrderDetails.Location = New System.Drawing.Point(3, 3)
        Me.dgvOrderDetails.Name = "dgvOrderDetails"
        Me.dgvOrderDetails.Rows.DefaultSize = 20
        Me.dgvOrderDetails.Size = New System.Drawing.Size(635, 332)
        Me.dgvOrderDetails.StyleInfo = resources.GetString("dgvOrderDetails.StyleInfo")
        Me.dgvOrderDetails.TabIndex = 3
        '
        'tabPageProducts
        '
        Me.tabPageProducts.Controls.Add(Me.lblProductsRowsTotal)
        Me.tabPageProducts.Controls.Add(Me.label11)
        Me.tabPageProducts.Controls.Add(Me.dgvProducts)
        Me.tabPageProducts.Location = New System.Drawing.Point(4, 22)
        Me.tabPageProducts.Name = "tabPageProducts"
        Me.tabPageProducts.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPageProducts.Size = New System.Drawing.Size(644, 361)
        Me.tabPageProducts.TabIndex = 1
        Me.tabPageProducts.Text = "Products"
        Me.tabPageProducts.UseVisualStyleBackColor = True
        '
        'lblProductsRowsTotal
        '
        Me.lblProductsRowsTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblProductsRowsTotal.AutoSize = True
        Me.lblProductsRowsTotal.Location = New System.Drawing.Point(78, 346)
        Me.lblProductsRowsTotal.Name = "lblProductsRowsTotal"
        Me.lblProductsRowsTotal.Size = New System.Drawing.Size(14, 13)
        Me.lblProductsRowsTotal.TabIndex = 14
        Me.lblProductsRowsTotal.Text = "0"
        '
        'label11
        '
        Me.label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label11.AutoSize = True
        Me.label11.Location = New System.Drawing.Point(7, 345)
        Me.label11.Name = "label11"
        Me.label11.Size = New System.Drawing.Size(70, 13)
        Me.label11.TabIndex = 13
        Me.label11.Text = "Total rows:"
        '
        'dgvProducts
        '
        Me.dgvProducts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducts.ColumnInfo = "10,1,0,0,0,100,Columns:"
        Me.dgvProducts.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.dgvProducts.Location = New System.Drawing.Point(3, 3)
        Me.dgvProducts.Name = "dgvProducts"
        Me.dgvProducts.Rows.DefaultSize = 20
        Me.dgvProducts.Size = New System.Drawing.Size(635, 332)
        Me.dgvProducts.StyleInfo = resources.GetString("dgvProducts.StyleInfo")
        Me.dgvProducts.TabIndex = 4
        '
        'tabPageOrders
        '
        Me.tabPageOrders.Controls.Add(Me.lblOrdersTotalRows)
        Me.tabPageOrders.Controls.Add(Me.label12)
        Me.tabPageOrders.Controls.Add(Me.dgvOrders)
        Me.tabPageOrders.Location = New System.Drawing.Point(4, 22)
        Me.tabPageOrders.Name = "tabPageOrders"
        Me.tabPageOrders.Size = New System.Drawing.Size(644, 361)
        Me.tabPageOrders.TabIndex = 3
        Me.tabPageOrders.Text = "Orders"
        Me.tabPageOrders.UseVisualStyleBackColor = True
        '
        'lblOrdersTotalRows
        '
        Me.lblOrdersTotalRows.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOrdersTotalRows.AutoSize = True
        Me.lblOrdersTotalRows.Location = New System.Drawing.Point(77, 344)
        Me.lblOrdersTotalRows.Name = "lblOrdersTotalRows"
        Me.lblOrdersTotalRows.Size = New System.Drawing.Size(14, 13)
        Me.lblOrdersTotalRows.TabIndex = 14
        Me.lblOrdersTotalRows.Text = "0"
        '
        'label12
        '
        Me.label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label12.AutoSize = True
        Me.label12.Location = New System.Drawing.Point(6, 343)
        Me.label12.Name = "label12"
        Me.label12.Size = New System.Drawing.Size(70, 13)
        Me.label12.TabIndex = 13
        Me.label12.Text = "Total rows:"
        '
        'dgvOrders
        '
        Me.dgvOrders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvOrders.ColumnInfo = "10,1,0,0,0,100,Columns:"
        Me.dgvOrders.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.dgvOrders.Location = New System.Drawing.Point(3, 3)
        Me.dgvOrders.Name = "dgvOrders"
        Me.dgvOrders.Rows.DefaultSize = 20
        Me.dgvOrders.Size = New System.Drawing.Size(635, 337)
        Me.dgvOrders.StyleInfo = resources.GetString("dgvOrders.StyleInfo")
        Me.dgvOrders.TabIndex = 4
        '
        'tabPageResults
        '
        Me.tabPageResults.Controls.Add(Me.lblDesc)
        Me.tabPageResults.Controls.Add(Me.lblResultTotalRows)
        Me.tabPageResults.Controls.Add(Me.dgvResult)
        Me.tabPageResults.Controls.Add(Me.label8)
        Me.tabPageResults.Location = New System.Drawing.Point(4, 22)
        Me.tabPageResults.Name = "tabPageResults"
        Me.tabPageResults.Size = New System.Drawing.Size(644, 361)
        Me.tabPageResults.TabIndex = 2
        Me.tabPageResults.Text = "Results"
        Me.tabPageResults.UseVisualStyleBackColor = True
        '
        'dgvResult
        '
        Me.dgvResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvResult.ColumnInfo = "10,1,0,0,0,100,Columns:"
        Me.dgvResult.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.dgvResult.Location = New System.Drawing.Point(8, 50)
        Me.dgvResult.Name = "dgvResult"
        Me.dgvResult.Rows.DefaultSize = 20
        Me.dgvResult.Size = New System.Drawing.Size(630, 289)
        Me.dgvResult.StyleInfo = resources.GetString("dgvResult.StyleInfo")
        Me.dgvResult.TabIndex = 2
        '
        'btnFlexPivot
        '
        Me.btnFlexPivot.Location = New System.Drawing.Point(7, 27)
        Me.btnFlexPivot.Name = "btnFlexPivot"
        Me.btnFlexPivot.Size = New System.Drawing.Size(201, 23)
        Me.btnFlexPivot.TabIndex = 10
        Me.btnFlexPivot.Text = "Analyze in FlexPivot"
        Me.btnFlexPivot.UseVisualStyleBackColor = True
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(233, 45)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(40, 13)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "Time:"
        '
        'btnExec
        '
        Me.btnExec.Location = New System.Drawing.Point(233, 11)
        Me.btnExec.Name = "btnExec"
        Me.btnExec.Size = New System.Drawing.Size(87, 23)
        Me.btnExec.TabIndex = 2
        Me.btnExec.Text = "Execute"
        Me.btnExec.UseVisualStyleBackColor = True
        '
        'panelGroupRange
        '
        Me.panelGroupRange.Controls.Add(Me.label1)
        Me.panelGroupRange.Controls.Add(Me.nudGroupFilter)
        Me.panelGroupRange.Location = New System.Drawing.Point(10, 252)
        Me.panelGroupRange.Name = "panelGroupRange"
        Me.panelGroupRange.Size = New System.Drawing.Size(216, 75)
        Me.panelGroupRange.TabIndex = 8
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(3, 5)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(41, 13)
        Me.label1.TabIndex = 9
        Me.label1.Text = "From:"
        '
        'nudGroupFilter
        '
        Me.nudGroupFilter.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudGroupFilter.Location = New System.Drawing.Point(55, 3)
        Me.nudGroupFilter.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.nudGroupFilter.Name = "nudGroupFilter"
        Me.nudGroupFilter.Size = New System.Drawing.Size(75, 21)
        Me.nudGroupFilter.TabIndex = 8
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(7, 16)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(76, 13)
        Me.label2.TabIndex = 4
        Me.label2.Text = "Query type:"
        '
        'cbQuery
        '
        Me.cbQuery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbQuery.FormattingEnabled = True
        Me.cbQuery.Items.AddRange(New Object() {"Join", "Join with FlexPivot", "Product", "UnitPrice Range", "Group Filter", "Month"})
        Me.cbQuery.Location = New System.Drawing.Point(85, 13)
        Me.cbQuery.Name = "cbQuery"
        Me.cbQuery.Size = New System.Drawing.Size(140, 21)
        Me.cbQuery.TabIndex = 3
        '
        'panelJoin
        '
        Me.panelJoin.Location = New System.Drawing.Point(10, 171)
        Me.panelJoin.Name = "panelJoin"
        Me.panelJoin.Size = New System.Drawing.Size(216, 75)
        Me.panelJoin.TabIndex = 7
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(3, 31)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(25, 13)
        Me.label4.TabIndex = 7
        Me.label4.Text = "To:"
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(3, 5)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(41, 13)
        Me.label3.TabIndex = 6
        Me.label3.Text = "From:"
        '
        'nudUnitPriceTo
        '
        Me.nudUnitPriceTo.DecimalPlaces = 2
        Me.nudUnitPriceTo.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nudUnitPriceTo.Location = New System.Drawing.Point(55, 29)
        Me.nudUnitPriceTo.Name = "nudUnitPriceTo"
        Me.nudUnitPriceTo.Size = New System.Drawing.Size(75, 21)
        Me.nudUnitPriceTo.TabIndex = 1
        '
        'panelJoinFlexPivot
        '
        Me.panelJoinFlexPivot.Controls.Add(Me.btnFlexPivot)
        Me.panelJoinFlexPivot.Location = New System.Drawing.Point(10, 171)
        Me.panelJoinFlexPivot.Name = "panelJoinFlexPivot"
        Me.panelJoinFlexPivot.Size = New System.Drawing.Size(216, 75)
        Me.panelJoinFlexPivot.TabIndex = 9
        '
        'cbProduct
        '
        Me.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProduct.FormattingEnabled = True
        Me.cbProduct.Location = New System.Drawing.Point(7, 26)
        Me.cbProduct.Name = "cbProduct"
        Me.cbProduct.Size = New System.Drawing.Size(205, 21)
        Me.cbProduct.TabIndex = 7
        '
        'panelUnitPriceRange
        '
        Me.panelUnitPriceRange.Controls.Add(Me.label4)
        Me.panelUnitPriceRange.Controls.Add(Me.label3)
        Me.panelUnitPriceRange.Controls.Add(Me.nudUnitPriceTo)
        Me.panelUnitPriceRange.Controls.Add(Me.nudUnitPriceFrom)
        Me.panelUnitPriceRange.Location = New System.Drawing.Point(10, 40)
        Me.panelUnitPriceRange.Name = "panelUnitPriceRange"
        Me.panelUnitPriceRange.Size = New System.Drawing.Size(216, 59)
        Me.panelUnitPriceRange.TabIndex = 5
        '
        'nudUnitPriceFrom
        '
        Me.nudUnitPriceFrom.DecimalPlaces = 2
        Me.nudUnitPriceFrom.Increment = New Decimal(New Integer() {5, 0, 0, 131072})
        Me.nudUnitPriceFrom.Location = New System.Drawing.Point(55, 3)
        Me.nudUnitPriceFrom.Name = "nudUnitPriceFrom"
        Me.nudUnitPriceFrom.Size = New System.Drawing.Size(75, 21)
        Me.nudUnitPriceFrom.TabIndex = 0
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(3, 10)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(100, 13)
        Me.label5.TabIndex = 8
        Me.label5.Text = "Seclect product:"
        '
        'gbQuery
        '
        Me.gbQuery.Controls.Add(Me.panelGroupRange)
        Me.gbQuery.Controls.Add(Me.lblTime)
        Me.gbQuery.Controls.Add(Me.btnExec)
        Me.gbQuery.Controls.Add(Me.label2)
        Me.gbQuery.Controls.Add(Me.cbQuery)
        Me.gbQuery.Controls.Add(Me.panelJoin)
        Me.gbQuery.Controls.Add(Me.panelJoinFlexPivot)
        Me.gbQuery.Controls.Add(Me.panelUnitPriceRange)
        Me.gbQuery.Controls.Add(Me.panelProduct)
        Me.gbQuery.Location = New System.Drawing.Point(310, 6)
        Me.gbQuery.Name = "gbQuery"
        Me.gbQuery.Size = New System.Drawing.Size(356, 123)
        Me.gbQuery.TabIndex = 12
        Me.gbQuery.TabStop = False
        Me.gbQuery.Text = "Query"
        '
        'panelProduct
        '
        Me.panelProduct.Controls.Add(Me.cbProduct)
        Me.panelProduct.Controls.Add(Me.label5)
        Me.panelProduct.Location = New System.Drawing.Point(10, 105)
        Me.panelProduct.Name = "panelProduct"
        Me.panelProduct.Size = New System.Drawing.Size(216, 60)
        Me.panelProduct.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 529)
        Me.Controls.Add(Me.gbDatabase)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.gbQuery)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.MinimumSize = New System.Drawing.Size(696, 400)
        Me.Name = "Form1"
        Me.Text = "Queries Sample"
        Me.gbDatabase.ResumeLayout(False)
        Me.gbDatabase.PerformLayout()
        Me.tabControl1.ResumeLayout(False)
        Me.tabPageOD.ResumeLayout(False)
        Me.tabPageOD.PerformLayout()
        CType(Me.dgvOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageProducts.ResumeLayout(False)
        Me.tabPageProducts.PerformLayout()
        CType(Me.dgvProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageOrders.ResumeLayout(False)
        Me.tabPageOrders.PerformLayout()
        CType(Me.dgvOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPageResults.ResumeLayout(False)
        Me.tabPageResults.PerformLayout()
        CType(Me.dgvResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelGroupRange.ResumeLayout(False)
        Me.panelGroupRange.PerformLayout()
        CType(Me.nudGroupFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudUnitPriceTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelJoinFlexPivot.ResumeLayout(False)
        Me.panelUnitPriceRange.ResumeLayout(False)
        Me.panelUnitPriceRange.PerformLayout()
        CType(Me.nudUnitPriceFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbQuery.ResumeLayout(False)
        Me.gbQuery.PerformLayout()
        Me.panelProduct.ResumeLayout(False)
        Me.panelProduct.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gbDatabase As System.Windows.Forms.GroupBox
    Private WithEvents cbItemsCount As System.Windows.Forms.ComboBox
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents lblItemsCount As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents lblWarning As System.Windows.Forms.Label
    Private WithEvents btnGenerate As System.Windows.Forms.Button
    Private WithEvents lblDesc As System.Windows.Forms.Label
    Private WithEvents lblResultTotalRows As System.Windows.Forms.Label
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabPageOD As System.Windows.Forms.TabPage
    Private WithEvents lblODRowsTotal As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Private WithEvents dgvOrderDetails As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents tabPageProducts As System.Windows.Forms.TabPage
    Private WithEvents lblProductsRowsTotal As System.Windows.Forms.Label
    Private WithEvents label11 As System.Windows.Forms.Label
    Private WithEvents dgvProducts As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents tabPageOrders As System.Windows.Forms.TabPage
    Private WithEvents lblOrdersTotalRows As System.Windows.Forms.Label
    Private WithEvents label12 As System.Windows.Forms.Label
    Private WithEvents dgvOrders As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents tabPageResults As System.Windows.Forms.TabPage
    Private WithEvents dgvResult As C1.Win.C1FlexGrid.C1FlexGrid
    Private WithEvents btnFlexPivot As System.Windows.Forms.Button
    Private WithEvents lblTime As System.Windows.Forms.Label
    Private WithEvents btnExec As System.Windows.Forms.Button
    Private WithEvents panelGroupRange As System.Windows.Forms.Panel
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents nudGroupFilter As System.Windows.Forms.NumericUpDown
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents cbQuery As System.Windows.Forms.ComboBox
    Private WithEvents panelJoin As System.Windows.Forms.Panel
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents nudUnitPriceTo As System.Windows.Forms.NumericUpDown
    Private WithEvents panelJoinFlexPivot As System.Windows.Forms.Panel
    Private WithEvents cbProduct As System.Windows.Forms.ComboBox
    Private WithEvents panelUnitPriceRange As System.Windows.Forms.Panel
    Private WithEvents nudUnitPriceFrom As System.Windows.Forms.NumericUpDown
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents gbQuery As System.Windows.Forms.GroupBox
    Private WithEvents panelProduct As System.Windows.Forms.Panel

End Class
