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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.C1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.orderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.C1NWindDataSet = New ComboBoxTranslateValue.C1NWindDataSet()
        Me.OrderTableAdapter = New ComboBoxTranslateValue.C1NWindDataSetTableAdapters.OrderTableAdapter()
        Me._addBtn = New C1.Win.C1Input.C1Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._descriptionEdit = New C1.Win.C1Input.C1TextBox()
        Me._quantityEdit = New C1.Win.C1Input.C1NumericEdit()
        Me.C1DateEdit1 = New C1.Win.C1Input.C1DateEdit()
        Me._purchaseDateEdit = New C1.Win.C1Input.C1DateEdit()
        Me._customerEdit = New C1.Win.C1Input.C1ComboBox()
        Me.CustomerdemoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._themes = New C1.Win.C1Input.C1ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.C1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.Customer_demoTableAdapter = New ComboBoxTranslateValue.C1NWindDataSetTableAdapters.Customer_demoTableAdapter()
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.orderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1NWindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._addBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me._descriptionEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._quantityEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1DateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._purchaseDateEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._customerEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerdemoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._themes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1TrueDBGrid1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.C1TrueDBGrid1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.C1TrueDBGrid1.DataSource = Me.orderBindingSource
        Me.C1TrueDBGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.C1TrueDBGrid1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(12, 12)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
        Me.C1TrueDBGrid1.RowDivider.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.C1TrueDBGrid1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.C1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(340, 339)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1ThemeController1.SetTheme(Me.C1TrueDBGrid1, "(default)")
        Me.C1TrueDBGrid1.UseCompatibleTextRendering = False
        '
        'orderBindingSource
        '
        Me.orderBindingSource.DataMember = "Order"
        Me.orderBindingSource.DataSource = Me.C1NWindDataSet
        '
        'C1NWindDataSet
        '
        Me.C1NWindDataSet.DataSetName = "C1NWindDataSet"
        Me.C1NWindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrderTableAdapter
        '
        Me.OrderTableAdapter.ClearBeforeFill = True
        '
        '_addBtn
        '
        Me._addBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me._addBtn.Location = New System.Drawing.Point(12, 360)
        Me._addBtn.Name = "_addBtn"
        Me._addBtn.Size = New System.Drawing.Size(75, 23)
        Me._addBtn.TabIndex = 1
        Me._addBtn.Text = "Add"
        Me.C1ThemeController1.SetTheme(Me._addBtn, "(default)")
        Me._addBtn.UseVisualStyleBackColor = True
        Me._addBtn.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me._descriptionEdit)
        Me.Panel1.Controls.Add(Me._quantityEdit)
        Me.Panel1.Controls.Add(Me.C1DateEdit1)
        Me.Panel1.Controls.Add(Me._purchaseDateEdit)
        Me.Panel1.Controls.Add(Me._customerEdit)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(368, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(229, 339)
        Me.Panel1.TabIndex = 2
        Me.C1ThemeController1.SetTheme(Me.Panel1, "(default)")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(3, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Description"
        Me.C1ThemeController1.SetTheme(Me.Label6, "(default)")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(17, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Quantity"
        Me.C1ThemeController1.SetTheme(Me.Label5, "(default)")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(30, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Timer"
        Me.C1ThemeController1.SetTheme(Me.Label4, "(default)")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(33, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Date"
        Me.C1ThemeController1.SetTheme(Me.Label3, "(default)")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Customer"
        Me.C1ThemeController1.SetTheme(Me.Label2, "(default)")
        '
        '_descriptionEdit
        '
        Me._descriptionEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._descriptionEdit.BackColor = System.Drawing.Color.White
        Me._descriptionEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._descriptionEdit.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.orderBindingSource, "Description", True))
        Me._descriptionEdit.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer))
        Me._descriptionEdit.Location = New System.Drawing.Point(69, 108)
        Me._descriptionEdit.Multiline = True
        Me._descriptionEdit.Name = "_descriptionEdit"
        Me._descriptionEdit.Size = New System.Drawing.Size(145, 85)
        Me._descriptionEdit.TabIndex = 4
        Me._descriptionEdit.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me._descriptionEdit, "(default)")
        Me._descriptionEdit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        '_quantityEdit
        '
        Me._quantityEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._quantityEdit.BackColor = System.Drawing.Color.White
        Me._quantityEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me._quantityEdit.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me._quantityEdit.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me._quantityEdit.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.orderBindingSource, "Quantity", True))
        Me._quantityEdit.DataType = GetType(Integer)
        Me._quantityEdit.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer))
        Me._quantityEdit.ImagePadding = New System.Windows.Forms.Padding(0)
        Me._quantityEdit.Location = New System.Drawing.Point(69, 84)
        Me._quantityEdit.Name = "_quantityEdit"
        Me._quantityEdit.Size = New System.Drawing.Size(145, 18)
        Me._quantityEdit.TabIndex = 3
        Me._quantityEdit.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me._quantityEdit, "(default)")
        Me._quantityEdit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'C1DateEdit1
        '
        Me.C1DateEdit1.AllowSpinLoop = False
        Me.C1DateEdit1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.C1DateEdit1.BackColor = System.Drawing.Color.White
        Me.C1DateEdit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.C1DateEdit1.Calendar.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit1.Calendar.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.C1DateEdit1.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit1.Calendar.DayNamesFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C1DateEdit1.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C1DateEdit1.Calendar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit1.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.C1DateEdit1.Calendar.SelectionForeColor = System.Drawing.Color.White
        Me.C1DateEdit1.Calendar.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.C1DateEdit1.Calendar.TitleFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.C1DateEdit1.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.C1DateEdit1.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.C1DateEdit1.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.C1DateEdit1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.C1DateEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.orderBindingSource, "Time", True))
        Me.C1DateEdit1.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.C1DateEdit1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.LongTime
        Me.C1DateEdit1.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.C1DateEdit1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.C1DateEdit1.Location = New System.Drawing.Point(69, 60)
        Me.C1DateEdit1.Name = "C1DateEdit1"
        Me.C1DateEdit1.Size = New System.Drawing.Size(145, 18)
        Me.C1DateEdit1.TabIndex = 2
        Me.C1DateEdit1.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me.C1DateEdit1, "(default)")
        Me.C1DateEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        Me.C1DateEdit1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        '_purchaseDateEdit
        '
        Me._purchaseDateEdit.AllowSpinLoop = False
        Me._purchaseDateEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._purchaseDateEdit.BackColor = System.Drawing.Color.White
        Me._purchaseDateEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me._purchaseDateEdit.Calendar.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me._purchaseDateEdit.Calendar.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me._purchaseDateEdit.Calendar.DayNamesColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me._purchaseDateEdit.Calendar.DayNamesFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me._purchaseDateEdit.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me._purchaseDateEdit.Calendar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me._purchaseDateEdit.Calendar.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(140, Byte), Integer))
        Me._purchaseDateEdit.Calendar.SelectionForeColor = System.Drawing.Color.White
        Me._purchaseDateEdit.Calendar.TitleBackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me._purchaseDateEdit.Calendar.TitleFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me._purchaseDateEdit.Calendar.TitleForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me._purchaseDateEdit.Calendar.TodayBorderColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(140, Byte), Integer))
        Me._purchaseDateEdit.Calendar.TrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer))
        Me._purchaseDateEdit.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me._purchaseDateEdit.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.orderBindingSource, "PurchaseDate", True))
        Me._purchaseDateEdit.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer))
        Me._purchaseDateEdit.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me._purchaseDateEdit.DisplayFormat.Inherit = CType((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.CalendarType), C1.Win.C1Input.FormatInfoInheritFlags)
        Me._purchaseDateEdit.ImagePadding = New System.Windows.Forms.Padding(0)
        Me._purchaseDateEdit.Location = New System.Drawing.Point(69, 36)
        Me._purchaseDateEdit.Name = "_purchaseDateEdit"
        Me._purchaseDateEdit.Size = New System.Drawing.Size(145, 18)
        Me._purchaseDateEdit.TabIndex = 1
        Me._purchaseDateEdit.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me._purchaseDateEdit, "(default)")
        Me._purchaseDateEdit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        '_customerEdit
        '
        Me._customerEdit.AllowSpinLoop = False
        Me._customerEdit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._customerEdit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me._customerEdit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me._customerEdit.BackColor = System.Drawing.Color.White
        Me._customerEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._customerEdit.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.orderBindingSource, "CustomerID", True))
        Me._customerEdit.DataType = GetType(Integer)
        Me._customerEdit.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer))
        Me._customerEdit.GapHeight = 0
        Me._customerEdit.ImagePadding = New System.Windows.Forms.Padding(0)
        Me._customerEdit.ItemsDataSource = Me.CustomerdemoBindingSource
        Me._customerEdit.ItemsDisplayMember = "LastName"
        Me._customerEdit.ItemsValueMember = "ID"
        Me._customerEdit.Location = New System.Drawing.Point(69, 12)
        Me._customerEdit.Name = "_customerEdit"
        Me._customerEdit.Size = New System.Drawing.Size(145, 18)
        Me._customerEdit.Style.DropDownBackColor = System.Drawing.Color.White
        Me._customerEdit.Style.DropDownBorderColor = System.Drawing.Color.Gainsboro
        Me._customerEdit.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me._customerEdit.TabIndex = 0
        Me._customerEdit.Tag = Nothing
        Me._customerEdit.TextDetached = True
        Me.C1ThemeController1.SetTheme(Me._customerEdit, "(default)")
        Me._customerEdit.TranslateValue = True
        Me._customerEdit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'CustomerdemoBindingSource
        '
        Me.CustomerdemoBindingSource.DataMember = "Customer_demo"
        Me.CustomerdemoBindingSource.DataSource = Me.C1NWindDataSet
        '
        '_themes
        '
        Me._themes.AllowSpinLoop = False
        Me._themes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._themes.BackColor = System.Drawing.Color.White
        Me._themes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me._themes.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(152, Byte), Integer))
        Me._themes.GapHeight = 0
        Me._themes.ImagePadding = New System.Windows.Forms.Padding(0)
        Me._themes.ItemsDisplayMember = "name"
        Me._themes.ItemsValueMember = ""
        Me._themes.Location = New System.Drawing.Point(461, 357)
        Me._themes.Name = "_themes"
        Me._themes.Size = New System.Drawing.Size(136, 18)
        Me._themes.Style.DropDownBackColor = System.Drawing.Color.White
        Me._themes.Style.DropDownBorderColor = System.Drawing.Color.Gainsboro
        Me._themes.Style.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me._themes.TabIndex = 3
        Me._themes.Tag = Nothing
        Me.C1ThemeController1.SetTheme(Me._themes, "(default)")
        Me._themes.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(410, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Themes"
        Me.C1ThemeController1.SetTheme(Me.Label1, "(default)")
        '
        'C1ThemeController1
        '
        Me.C1ThemeController1.Theme = "MacBlue"
        '
        'Customer_demoTableAdapter
        '
        Me.Customer_demoTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 391)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._themes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me._addBtn)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Name = "Form1"
        Me.Text = "ComboBoxTranslateValue"
        Me.C1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.orderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1NWindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._addBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._descriptionEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._quantityEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1DateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._purchaseDateEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._customerEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerdemoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._themes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents C1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1NWindDataSet As C1NWindDataSet
    Friend WithEvents orderBindingSource As BindingSource
    Friend WithEvents OrderTableAdapter As C1NWindDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents _addBtn As C1.Win.C1Input.C1Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents _descriptionEdit As C1.Win.C1Input.C1TextBox
    Friend WithEvents _quantityEdit As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents C1DateEdit1 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents _purchaseDateEdit As C1.Win.C1Input.C1DateEdit
    Friend WithEvents _customerEdit As C1.Win.C1Input.C1ComboBox
    Friend WithEvents _themes As C1.Win.C1Input.C1ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents C1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Friend WithEvents CustomerdemoBindingSource As BindingSource
    Friend WithEvents Customer_demoTableAdapter As C1NWindDataSetTableAdapters.Customer_demoTableAdapter
End Class
