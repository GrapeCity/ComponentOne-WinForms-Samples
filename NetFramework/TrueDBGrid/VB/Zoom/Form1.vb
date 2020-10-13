
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data


'/ <summary>
'/ Summary description for Form1.
   '/ </summary>
   
   Public Class Form1
      Inherits System.Windows.Forms.Form
      Private oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
      Private oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
      Private oleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
      Private oleDbConnection1 As System.Data.OleDb.OleDbConnection
        Private dataSet11 As DataSet1
      Private c1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
      Private mainMenu1 As System.Windows.Forms.MainMenu
      Private menuItem1 As System.Windows.Forms.MenuItem
      Private menuItem2 As System.Windows.Forms.MenuItem
      Private WithEvents menuItem3 As System.Windows.Forms.MenuItem
      Private WithEvents menuItem4 As System.Windows.Forms.MenuItem
      Private WithEvents menuItem5 As System.Windows.Forms.MenuItem
    Private WithEvents menuItem6 As System.Windows.Forms.MenuItem
    Private components As System.ComponentModel.IContainer
      '/ <summary>
      '/ Required designer variable.
      '/ </summary>

      
      Public Sub New()
        Application.EnableVisualStyles()
        '
         ' Required for Windows Form Designer support
         '
         InitializeComponent()
      End Sub 'New
       
      '
      ' TODO: Add any constructor code after InitializeComponent call
      '
      
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    '/ <summary>
    '/ Required method for Designer support - do not modify
    '/ the contents of this method with the code editor.
    '/ </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.dataSet11 = New Zoom.DataSet1
        Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.oleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand
        Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.c1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.mainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.menuItem1 = New System.Windows.Forms.MenuItem
        Me.menuItem2 = New System.Windows.Forms.MenuItem
        Me.menuItem3 = New System.Windows.Forms.MenuItem
        Me.menuItem4 = New System.Windows.Forms.MenuItem
        Me.menuItem5 = New System.Windows.Forms.MenuItem
        Me.menuItem6 = New System.Windows.Forms.MenuItem
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dataSet11
        '
        Me.dataSet11.DataSetName = "DataSet1"
        Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'oleDbDataAdapter1
        '
        Me.oleDbDataAdapter1.InsertCommand = Me.oleDbInsertCommand1
        Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
        Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("CustomerID", "CustomerID"), New System.Data.Common.DataColumnMapping("EmployeeID", "EmployeeID"), New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("RequiredDate", "RequiredDate"), New System.Data.Common.DataColumnMapping("ShippedDate", "ShippedDate"), New System.Data.Common.DataColumnMapping("ShipVia", "ShipVia"), New System.Data.Common.DataColumnMapping("Freight", "Freight"), New System.Data.Common.DataColumnMapping("ShipName", "ShipName"), New System.Data.Common.DataColumnMapping("ShipAddress", "ShipAddress"), New System.Data.Common.DataColumnMapping("ShipCity", "ShipCity"), New System.Data.Common.DataColumnMapping("ShipRegion", "ShipRegion"), New System.Data.Common.DataColumnMapping("ShipPostalCode", "ShipPostalCode"), New System.Data.Common.DataColumnMapping("ShipCountry", "ShipCountry")})})
        '
        'oleDbInsertCommand1
        '
        Me.oleDbInsertCommand1.CommandText = resources.GetString("oleDbInsertCommand1.CommandText")
        Me.oleDbInsertCommand1.Connection = Me.oleDbConnection1
        Me.oleDbInsertCommand1.Parameters.AddRange(New System.Data.OleDb.OleDbParameter() {New System.Data.OleDb.OleDbParameter("CustomerID", System.Data.OleDb.OleDbType.VarWChar, 5, "CustomerID"), New System.Data.OleDb.OleDbParameter("EmployeeID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "EmployeeID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("Freight", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "Freight", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"), New System.Data.OleDb.OleDbParameter("OrderID", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Current, Nothing), New System.Data.OleDb.OleDbParameter("RequiredDate", System.Data.OleDb.OleDbType.DBDate, 0, "RequiredDate"), New System.Data.OleDb.OleDbParameter("ShipAddress", System.Data.OleDb.OleDbType.VarWChar, 60, "ShipAddress"), New System.Data.OleDb.OleDbParameter("ShipCity", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCity"), New System.Data.OleDb.OleDbParameter("ShipCountry", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipCountry"), New System.Data.OleDb.OleDbParameter("ShipName", System.Data.OleDb.OleDbType.VarWChar, 40, "ShipName"), New System.Data.OleDb.OleDbParameter("ShippedDate", System.Data.OleDb.OleDbType.DBDate, 0, "ShippedDate"), New System.Data.OleDb.OleDbParameter("ShipPostalCode", System.Data.OleDb.OleDbType.VarWChar, 10, "ShipPostalCode"), New System.Data.OleDb.OleDbParameter("ShipRegion", System.Data.OleDb.OleDbType.VarWChar, 15, "ShipRegion"), New System.Data.OleDb.OleDbParameter("ShipVia", System.Data.OleDb.OleDbType.[Integer], 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "ShipVia", System.Data.DataRowVersion.Current, Nothing)})
        '
        'oleDbConnection1
        '
        Me.oleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Program Files\ComponentOne Studi" & _
            "o.NET 2.0\Common\C1Nwind.mdb;"
        '
        'oleDbSelectCommand1
        '
        Me.oleDbSelectCommand1.CommandText = "SELECT CustomerID, EmployeeID, Freight, OrderDate, OrderID, RequiredDate, ShipAdd" & _
            "ress, ShipCity, ShipCountry, ShipName, ShippedDate, ShipPostalCode, ShipRegion, " & _
            "ShipVia FROM Orders"
        Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
        '
        'c1TrueDBGrid1
        '
        Me.c1TrueDBGrid1.DataSource = Me.dataSet11.Orders
        Me.c1TrueDBGrid1.Images.Add(CType(resources.GetObject("c1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.c1TrueDBGrid1.Location = New System.Drawing.Point(8, 32)
        Me.c1TrueDBGrid1.Name = "c1TrueDBGrid1"
        Me.c1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.c1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1TrueDBGrid1.Size = New System.Drawing.Size(416, 208)
        Me.c1TrueDBGrid1.TabIndex = 0
        Me.c1TrueDBGrid1.Text = "c1TrueDBGrid1"
        Me.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag")
        '
        'mainMenu1
        '
        Me.mainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem1})
        '
        'menuItem1
        '
        Me.menuItem1.Index = 0
        Me.menuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem2})
        Me.menuItem1.Text = "View"
        '
        'menuItem2
        '
        Me.menuItem2.Index = 0
        Me.menuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.menuItem3, Me.menuItem4, Me.menuItem5, Me.menuItem6})
        Me.menuItem2.Text = "Zoom"
        '
        'menuItem3
        '
        Me.menuItem3.Index = 0
        Me.menuItem3.Text = "50%"
        '
        'menuItem4
        '
        Me.menuItem4.Index = 1
        Me.menuItem4.Text = "80%"
        '
        'menuItem5
        '
        Me.menuItem5.Index = 2
        Me.menuItem5.Text = "100%"
        '
        'menuItem6
        '
        Me.menuItem6.Index = 3
        Me.menuItem6.Text = "120%"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(432, 266)
        Me.Controls.Add(Me.c1TrueDBGrid1)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub 'InitializeComponent 
#End Region

    Shared Sub Main()
        Application.Run(New Form1())
    End Sub 'Main

    Private _rowHeight As Integer ' original row height
    Private _recSelWidth As Integer ' oringal record selector width
    Private _fontSize As Single ' original font size
    Private _colWidths As New ArrayList()
    ' original column widths
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.oleDbConnection1.ConnectionString = GetModifiedConnectionString(Me.oleDbConnection1.ConnectionString)
        Me.oleDbDataAdapter1.Fill(Me.dataSet11)
        ' save the column widths
        Dim dc As C1.Win.C1TrueDBGrid.C1DisplayColumn
        For Each dc In Me.c1TrueDBGrid1.Splits(0).DisplayColumns
            _colWidths.Add(CSng(dc.Width))
        Next dc
        ' save some state information
        _rowHeight = Me.c1TrueDBGrid1.RowHeight
        _recSelWidth = Me.c1TrueDBGrid1.RecordSelectorWidth
        _fontSize = Me.c1TrueDBGrid1.Styles("Normal").Font.Size
    End Sub 'Form1_Load


    ' sizes the grid to the given passed in percentage of original size
    Private Sub zoom(ByVal pcnt As Single)
        ' adjust row height
        Me.c1TrueDBGrid1.RowHeight = CInt(CSng(_rowHeight) * pcnt)
        ' and recordselector width
        Me.c1TrueDBGrid1.RecordSelectorWidth = CInt(CSng(_recSelWidth) * pcnt)

        ' adjust font sizes.  Normal is the root style so changing its sizes adjust all
        ' other styles
        Me.c1TrueDBGrid1.Styles("Normal").Font = New Font(Me.c1TrueDBGrid1.Styles("Normal").Font.FontFamily, _fontSize * pcnt)

        ' now adjust the column widths
        Dim i As Integer
        For i = 0 To (Me.c1TrueDBGrid1.Splits(0).DisplayColumns.Count) - 1
            Me.c1TrueDBGrid1.Splits(0).DisplayColumns(i).Width = CInt(CSng(_colWidths(i)) * pcnt)
        Next i
    End Sub 'zoom

    Private Sub menuItem3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem3.Click
        ' 50%
        zoom(CSng(0.5))
    End Sub 'menuItem3_Click


    Private Sub menuItem4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem4.Click
        ' 80%
        zoom(CSng(0.8))
    End Sub 'menuItem4_Click


    Private Sub menuItem5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem5.Click
        ' 100%
        zoom(CSng(1.0))
    End Sub 'menuItem5_Click


    Private Sub menuItem6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menuItem6.Click
        ' 120%
        zoom(CSng(1.2))
    End Sub 'menuItem6_Click

    Private Function GetModifiedConnectionString(ByVal connstring As String) As String
        Dim dataSource As Integer = connstring.IndexOf("Data Source=", 0, StringComparison.OrdinalIgnoreCase)
        Dim dataSourceEnd As Integer = connstring.LastIndexOf("\", connstring.IndexOf(";", dataSource))
        connstring = connstring.Substring(0, dataSource) + "Data Source=" + _
         Environment.GetFolderPath(Environment.SpecialFolder.Personal) + _
         "\ComponentOne Samples\Common" + connstring.Substring(dataSourceEnd)
        Return connstring
    End Function

End Class 'Form1
