Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()
        Application.EnableVisualStyles()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents C1TrueDBDropdown1 As C1.Win.TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DataSet11 As UsingC1TDBDropdown.DataSet1
    Friend WithEvents c1TrueDBGrid1 As C1.Win.TrueDBGrid.C1TrueDBGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Style1 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style()
        Dim Style2 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style()
        Dim Style3 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style()
        Dim Style4 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style()
        Dim Style5 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style()
        Dim Style6 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style()
        Dim Style7 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style()
        Dim Style8 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style()
        Dim Style9 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style()
        Dim Style10 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style()
        Dim Style11 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style()
        Me.c1TrueDBGrid1 = New C1.Win.TrueDBGrid.C1TrueDBGrid()
        Me.DataSet11 = New UsingC1TDBDropdown.DataSet1()
        Me.C1TrueDBDropdown1 = New C1.Win.TrueDBGrid.C1TrueDBDropdown()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        CType(Me.c1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBDropdown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'c1TrueDBGrid1
        '
        Me.c1TrueDBGrid1.Caption = "Products Table"
        Me.c1TrueDBGrid1.DataSource = Me.DataSet11.Products
        Me.c1TrueDBGrid1.Images.Add(CType(resources.GetObject("c1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.c1TrueDBGrid1.Location = New System.Drawing.Point(19, 18)
        Me.c1TrueDBGrid1.Name = "c1TrueDBGrid1"
        Me.c1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = Nothing
        Me.c1TrueDBGrid1.Size = New System.Drawing.Size(480, 250)
        Me.c1TrueDBGrid1.TabIndex = 0
        Me.c1TrueDBGrid1.Text = "c1TrueDBGrid1"
        Me.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag")
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'C1TrueDBDropdown1
        '
        Me.C1TrueDBDropdown1.AllowColMove = True
        Me.C1TrueDBDropdown1.AllowColSelect = True
        Me.C1TrueDBDropdown1.AllowRowSizing = C1.Win.TrueDBGrid.RowSizingEnum.AllRows
        Me.C1TrueDBDropdown1.AlternatingRows = False
        Me.C1TrueDBDropdown1.CaptionStyle = Style1
        Me.C1TrueDBDropdown1.ColumnCaptionHeight = 17
        Me.C1TrueDBDropdown1.ColumnFooterHeight = 17
        Me.C1TrueDBDropdown1.ColumnSelectorStyle = Style2
        Me.C1TrueDBDropdown1.DataSource = Me.DataSet11.Categories
        Me.C1TrueDBDropdown1.EvenRowStyle = Style3
        Me.C1TrueDBDropdown1.FetchRowStyles = False
        Me.C1TrueDBDropdown1.FooterStyle = Style4
        Me.C1TrueDBDropdown1.HeadingHotStyle = Style5
        Me.C1TrueDBDropdown1.HeadingStyle = Style6
        Me.C1TrueDBDropdown1.HighLightRowStyle = Style7
        Me.C1TrueDBDropdown1.Images.Add(CType(resources.GetObject("C1TrueDBDropdown1.Images"), System.Drawing.Image))
        Me.C1TrueDBDropdown1.Location = New System.Drawing.Point(144, 120)
        Me.C1TrueDBDropdown1.Name = "C1TrueDBDropdown1"
        Me.C1TrueDBDropdown1.OddRowStyle = Style8
        Me.C1TrueDBDropdown1.RecordSelectorStyle = Style9
        Me.C1TrueDBDropdown1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1TrueDBDropdown1.RowDivider.Style = C1.Win.TrueDBGrid.LineStyleEnum.[Single]
        Me.C1TrueDBDropdown1.RowSelectorStyle = Style10
        Me.C1TrueDBDropdown1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1TrueDBDropdown1.ScrollTips = False
        Me.C1TrueDBDropdown1.Size = New System.Drawing.Size(230, 120)
        Me.C1TrueDBDropdown1.Style = Style11
        Me.C1TrueDBDropdown1.TabIndex = 1
        Me.C1TrueDBDropdown1.Text = "c1TrueDBDropdown1"
        Me.C1TrueDBDropdown1.Visible = False
        Me.C1TrueDBDropdown1.PropBag = resources.GetString("C1TrueDBDropdown1.PropBag")
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Picture", "Picture")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Categories(CategoryID, CategoryName, Description, Picture) VALUES (?," &
    " ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CategoryID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("CategoryName", System.Data.OleDb.OleDbType.VarWChar, 15, "CategoryName"), New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 0, "Description"), New System.Data.OleDb.OleDbParameter("Picture", System.Data.OleDb.OleDbType.VarBinary, 0, "Picture")})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\ComponentOne Studio" &
    ".NET 2.0\Common\C1Nwind.mdb;"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ProductID", "ProductID"), New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})})
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO Products(CategoryID, Discontinued, ProductID, ProductName, QuantityPe" &
    "rUnit, ReorderLevel, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder) VALUES (" &
    "?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CategoryID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "CategoryID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Discontinued", System.Data.OleDb.OleDbType.[Boolean], 2, "Discontinued"), New System.Data.OleDb.OleDbParameter("ProductID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ProductID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("ProductName", System.Data.OleDb.OleDbType.VarWChar, 40, "ProductName"), New System.Data.OleDb.OleDbParameter("QuantityPerUnit", System.Data.OleDb.OleDbType.VarWChar, 20, "QuantityPerUnit"), New System.Data.OleDb.OleDbParameter("ReorderLevel", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ReorderLevel", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("SupplierID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "SupplierID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("UnitPrice", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "UnitPrice", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("UnitsInStock", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "UnitsInStock", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("UnitsOnOrder", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "UnitsOnOrder", System.Data.DataRowVersion.Current, Nothing)})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT CategoryID, Discontinued, ProductID, ProductName, QuantityPerUnit, Reorder" &
    "Level, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(432, 270)
        Me.Controls.Add(Me.C1TrueDBDropdown1)
        Me.Controls.Add(Me.c1TrueDBGrid1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.c1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBDropdown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OleDbConnection1.ConnectionString = GetModifiedConnectionString(Me.OleDbConnection1.ConnectionString)
        Me.OleDbDataAdapter1.Fill(Me.DataSet11)
        Me.OleDbDataAdapter2.Fill(Me.DataSet11)

        ' attach the dropdown to the categories column
        Me.c1TrueDBGrid1.Columns("CategoryID").DropDown = Me.C1TrueDBDropdown1

        ' underlying datasource value is CategoryID
        Me.C1TrueDBDropdown1.ValueMember = "CategoryID"

        ' display value will be CategoryName
        Me.C1TrueDBDropdown1.DisplayMember = "CategoryName"

        ' tell the grid that we're translating values
        Me.c1TrueDBGrid1.Columns("CategoryID").ValueItems.Translate = True

        ' now use the dropdown to perform the translation for us
        ' using a more readable format (i.e.,"CategoryName")
        Me.C1TrueDBDropdown1.ValueTranslate = True

        ' show checkboxes for the Discontinued column
        Me.c1TrueDBGrid1.Columns("Discontinued").ValueItems.Presentation = C1.Win.TrueDBGrid.PresentationEnum.CheckBox
    End Sub

    Private Function GetModifiedConnectionString(ByVal connstring As String) As String
        Dim dataSource As Integer = connstring.IndexOf("Data Source=", 0, StringComparison.OrdinalIgnoreCase)
        Dim dataSourceEnd As Integer = connstring.LastIndexOf("\", connstring.IndexOf(";", dataSource))
        connstring = connstring.Substring(0, dataSource) + "Data Source=" + _
         Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
         "\ComponentOne Samples\Common" + connstring.Substring(dataSourceEnd)
        Return connstring
    End Function

End Class
