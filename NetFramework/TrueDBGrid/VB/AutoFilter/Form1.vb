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
    Friend WithEvents C1TrueDBGrid1 As C1.Win.TrueDBGrid.C1TrueDBGrid
    Friend WithEvents C1TrueDBDropdown1 As C1.Win.TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents DataSet11 As AutoFilter.DataSet1
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Style1 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style
        Dim Style2 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style
        Dim Style3 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style
        Dim Style4 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style
        Dim Style5 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style
        Dim Style6 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style
        Dim Style7 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style
        Dim Style8 As C1.Win.TrueDBGrid.Style = New C1.Win.TrueDBGrid.Style
        Me.C1TrueDBGrid1 = New C1.Win.TrueDBGrid.C1TrueDBGrid
        Me.DataSet11 = New AutoFilter.DataSet1
        Me.C1TrueDBDropdown1 = New C1.Win.TrueDBGrid.C1TrueDBDropdown
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1TrueDBDropdown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C1TrueDBGrid1
        '
        Me.C1TrueDBGrid1.DataSource = Me.DataSet11.Orders
        Me.C1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.C1TrueDBGrid1.FilterBar = True
        Me.C1TrueDBGrid1.Images.Add(CType(resources.GetObject("C1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.C1TrueDBGrid1.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.Name = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.C1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.C1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("C1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.C1TrueDBGrid1.Size = New System.Drawing.Size(384, 222)
        Me.C1TrueDBGrid1.TabIndex = 0
        Me.C1TrueDBGrid1.Text = "C1TrueDBGrid1"
        Me.C1TrueDBGrid1.PropBag = resources.GetString("C1TrueDBGrid1.PropBag")
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
        Me.C1TrueDBDropdown1.DataSource = Me.DataSet11.Customers
        Me.C1TrueDBDropdown1.EvenRowStyle = Style2
        Me.C1TrueDBDropdown1.ExtendRightColumn = True
        Me.C1TrueDBDropdown1.FetchRowStyles = False
        Me.C1TrueDBDropdown1.FooterStyle = Style3
        Me.C1TrueDBDropdown1.HeadingStyle = Style4
        Me.C1TrueDBDropdown1.HighLightRowStyle = Style5
        Me.C1TrueDBDropdown1.Images.Add(CType(resources.GetObject("C1TrueDBDropdown1.Images"), System.Drawing.Image))
        Me.C1TrueDBDropdown1.Location = New System.Drawing.Point(208, 112)
        Me.C1TrueDBDropdown1.Name = "C1TrueDBDropdown1"
        Me.C1TrueDBDropdown1.OddRowStyle = Style6
        Me.C1TrueDBDropdown1.RecordSelectorStyle = Style7
        Me.C1TrueDBDropdown1.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.C1TrueDBDropdown1.RowDivider.Style = C1.Win.TrueDBGrid.LineStyleEnum.[Single]
        Me.C1TrueDBDropdown1.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.C1TrueDBDropdown1.ScrollTips = False
        Me.C1TrueDBDropdown1.Size = New System.Drawing.Size(100, 88)
        Me.C1TrueDBDropdown1.Style = Style8
        Me.C1TrueDBDropdown1.TabIndex = 1
        Me.C1TrueDBDropdown1.Text = "C1TrueDBDropdown1"
        Me.C1TrueDBDropdown1.Visible = False
        Me.C1TrueDBDropdown1.PropBag = resources.GetString("C1TrueDBDropdown1.PropBag")
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})})
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = resources.GetString("OleDbInsertCommand1.CommandText")
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"), New System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Freight", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Freight", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"), New System.Data.OleDb.OleDbParameter("OrderID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, "RequiredDate"), New System.Data.OleDb.OleDbParameter("ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, "ShipAddress"), New System.Data.OleDb.OleDbParameter("ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCity"), New System.Data.OleDb.OleDbParameter("ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCountry"), New System.Data.OleDb.OleDbParameter("ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, "ShipName"), New System.Data.OleDb.OleDbParameter("ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, "ShippedDate"), New System.Data.OleDb.OleDbParameter("ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "ShipPostalCode"), New System.Data.OleDb.OleDbParameter("ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipRegion"), New System.Data.OleDb.OleDbParameter("ShipVia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ShipVia", System.Data.DataRowVersion.Current, Nothing)})
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\ComponentOne Studi" +
            "o.NET 2.0\Common\C1Nwind.mdb;" '17716
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CustomerID, EmployeeID, Freight, OrderDate, OrderID, RequiredDate, ShipAdd" & _
            "ress, ShipCity, ShipCountry, ShipName, ShippedDate, ShipPostalCode, ShipRegion, " & _
            "ShipVia FROM Orders"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Customers", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID")})})
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO Customers(CustomerID) VALUES (?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID")})
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT CustomerID FROM Customers"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(384, 222)
        Me.Controls.Add(Me.C1TrueDBDropdown1)
        Me.Controls.Add(Me.C1TrueDBGrid1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.C1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1TrueDBDropdown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.OleDbConnection1.ConnectionString = GetConnectionString() '17716
        Me.OleDbDataAdapter1.Fill(Me.DataSet11)
        Me.OleDbDataAdapter2.Fill(Me.DataSet11)
        ' the dropdown control is bound to the Customers table
        Me.C1TrueDBGrid1.Columns("CustomerID").DropDown = Me.C1TrueDBDropdown1
        ' turn on the dropdown button in the filterbar
        Me.C1TrueDBGrid1.Splits(0).DisplayColumns("CustomerID").FilterButton = True
        ' turn it off for regulars cells in the grid
        Me.C1TrueDBGrid1.Splits(0).DisplayColumns("CustomerID").Button = False
        Me.C1TrueDBDropdown1.ColumnHeaders = False

    End Sub

    Private Function GetConnectionString() As String '17716
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function

End Class
