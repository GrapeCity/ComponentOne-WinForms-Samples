Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
imports System.Windows.Forms
imports System.Data
imports C1.Win.C1FlexGrid


Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

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
    Friend WithEvents oleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents oleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents oleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents oleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents oleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    Friend WithEvents DataSet11 As DataMap.DataSet1
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.oleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter
        Me.oleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand
        Me.oleDbConnection1 = New System.Data.OleDb.OleDbConnection
        Me.oleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand
        Me.oleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid
        Me.DataSet11 = New DataMap.DataSet1
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'oleDbDataAdapter1
        '
        Me.oleDbDataAdapter1.SelectCommand = Me.oleDbSelectCommand1
        Me.oleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Products", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ProductName", "ProductName"), New System.Data.Common.DataColumnMapping("SupplierID", "SupplierID"), New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("QuantityPerUnit", "QuantityPerUnit"), New System.Data.Common.DataColumnMapping("UnitPrice", "UnitPrice"), New System.Data.Common.DataColumnMapping("UnitsInStock", "UnitsInStock"), New System.Data.Common.DataColumnMapping("UnitsOnOrder", "UnitsOnOrder"), New System.Data.Common.DataColumnMapping("ReorderLevel", "ReorderLevel"), New System.Data.Common.DataColumnMapping("Discontinued", "Discontinued")})})
        '
        'oleDbSelectCommand1
        '
        Me.oleDbSelectCommand1.CommandText = "SELECT CategoryID, Discontinued, ProductID, ProductName, QuantityPerUnit, Reorder" & _
            "Level, SupplierID, UnitPrice, UnitsInStock, UnitsOnOrder FROM Products"
        Me.oleDbSelectCommand1.Connection = Me.oleDbConnection1
        '
        'oleDbSelectCommand2
        '
        Me.oleDbSelectCommand2.CommandText = "SELECT CategoryID, CategoryName, Description, Picture FROM Categories"
        Me.oleDbSelectCommand2.Connection = Me.oleDbConnection1
        '
        'oleDbDataAdapter2
        '
        Me.oleDbDataAdapter2.SelectCommand = Me.oleDbSelectCommand2
        Me.oleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Categories", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CategoryID", "CategoryID"), New System.Data.Common.DataColumnMapping("CategoryName", "CategoryName"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Picture", "Picture")})})
        '
        '_flex
        '
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:42;}" & Global.Microsoft.VisualBasic.ChrW(9)
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Location = New System.Drawing.Point(0, 0)
        Me._flex.Name = "_flex"
        Me._flex.Rows.DefaultSize = 19
        Me._flex.Size = New System.Drawing.Size(584, 372)
        Me._flex.StyleInfo = resources.GetString("_flex.StyleInfo")
        Me._flex.TabIndex = 0
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(584, 372)
        Me.Controls.Add(Me._flex)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "C1FlexGrid: Mapping Data Columns"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' get the data
        Me.oleDbConnection1.ConnectionString = GetConnectionString()
        Me.oleDbDataAdapter1.Fill(Me.DataSet11)
        Me.oleDbDataAdapter2.Fill(Me.DataSet11)

        ' build data mapping for CategoryID->CategoryName
        Dim ht As New Hashtable()
        Dim dt As DataTable = CType(DataSet11.Categories, DataTable)
        Dim dr As DataRow
        For Each dr In dt.Rows
            ht.Add(dr("CategoryID"), dr("CategoryName"))
        Next

        ' assign data source to grid
        _flex.DataSource = DataSet11.Products

        ' assign data map to CategoryID column
        ' ** after setting the data source **
        Dim c As Column = _flex.Cols("CategoryID")
        c.DataMap = ht
        c.TextAlign = TextAlignEnum.LeftTop
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
