Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.OleDb
Imports C1.Win.C1FlexGrid

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
    Friend WithEvents _flex As C1.Win.C1FlexGrid.C1FlexGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me._flex = New C1.Win.C1FlexGrid.C1FlexGrid()
        CType(Me._flex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_flex
        '
        Me._flex.BackColor = System.Drawing.SystemColors.Window
        Me._flex.ColumnInfo = "10,1,0,0,0,85,Columns:"
        Me._flex.Dock = System.Windows.Forms.DockStyle.Fill
        Me._flex.Name = "_flex"
        Me._flex.Size = New System.Drawing.Size(292, 273)
        Me._flex.Styles = New C1.Win.C1FlexGrid.CellStyleCollection("Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "Hi" & _
        "ghlight{BackColor:Highlight;ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Search{BackColor:Highlight" & _
        ";ForeColor:HighlightText;}" & Microsoft.VisualBasic.ChrW(9) & "Frozen{BackColor:Beige;}" & Microsoft.VisualBasic.ChrW(9) & "EmptyArea{BackColor:AppWorks" & _
        "pace;Border:Flat,1,ControlDarkDark,Both;}" & Microsoft.VisualBasic.ChrW(9) & "GrandTotal{BackColor:Black;ForeColor:W" & _
        "hite;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal1{BackColor" & _
        ":ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal2{BackColor:ControlDarkDark;ForeColor" & _
        ":White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal4{BackCol" & _
        "or:ControlDarkDark;ForeColor:White;}" & Microsoft.VisualBasic.ChrW(9) & "Subtotal5{BackColor:ControlDarkDark;ForeCol" & _
        "or:White;}" & Microsoft.VisualBasic.ChrW(9))
        Me._flex.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me._flex})
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me._flex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim conn As String = GetConnectionString()
        Dim rs As String = "SELECT Employees.LastName, Orders.ShipCountry, Categories.CategoryName, Products.ProductName, Orders.OrderDate, [Quantity]*[Products].[UnitPrice] AS [Sale Amount] " + _
        "FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) INNER JOIN ((Employees INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID) " + _
        "INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID " + _
    "ORDER BY Employees.LastName, Orders.ShipCountry, Categories.CategoryName;"
        Cursor = Cursors.WaitCursor
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(rs, conn)
        Dim ds As New DataSet()
        da.Fill(ds)
        Cursor = Cursors.Default

        _flex.Cols(0).Width = 2 * _flex.Rows(0).HeightDisplay
        _flex.DataSource = ds.Tables(0)

        _flex.AllowSorting = AllowSortingEnum.None
        _flex.Cols(4).AllowDragging = False
        _flex.Cols(5).AllowDragging = False
        _flex.Cols(6).AllowDragging = False

        updatedatatree()

    End Sub

    Private Sub _flex_AfterDragColumn(ByVal sender As Object, ByVal e As C1.Win.C1FlexGrid.DragRowColEventArgs) Handles _flex.AfterDragColumn
        updatedatatree()
    End Sub

    Private Sub updateDataTree()

        ' sort the data when the user drags columns
        ' this will cause a date refresh, removing all subtotals and
        ' firing the AfterDataRefresh event, which rebuilds the subtotals
        Dim strSort As String = _flex.Cols(1).Name + ", " + _flex.Cols(2).Name + ", " + _flex.Cols(3).Name
        Dim dt As DataTable = CType(_flex.DataSource, DataTable)
        If Not dt Is Nothing Then
            dt.DefaultView.Sort = strSort
        End If
    End Sub

    Private Sub _flex_AfterDataRefresh(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles _flex.AfterDataRefresh

        ' build (rebuild) tree after any changes
        _flex.Tree.Style = TreeStyleFlags.Simple
        _flex.Tree.Column = 1
        _flex.AllowMerging = AllowMergingEnum.Nodes

        Dim totalOn As Integer = _flex.Cols("Sale Amount").SafeIndex
        _flex.Subtotal(AggregateEnum.Sum, 0, 1, totalOn)
        _flex.Subtotal(AggregateEnum.Sum, 1, 2, totalOn)
        _flex.Subtotal(AggregateEnum.Sum, 2, 3, totalOn)
        _flex.AutoSizeCols(1, 1, 1000, 3, 30, AutoSizeFlags.IgnoreHidden)
    End Sub

    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class
