Imports System.Data.OleDb
Imports C1.Win.Themes

Public Enum LayoutOption
    Traditional
    Compact
    Detailed
End Enum

Partial Public Class ColumnBandsUserControl
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub Init()
        SetupC1FlexGrid()
    End Sub

    Public Sub ApplyTheme(ByVal themeName As String)
        Dim theme = C1ThemeController.GetThemeByName(themeName, False)
        C1ThemeController.ApplyThemeToControlTree(Me, theme)
    End Sub

    Public Sub ApplyLayout(ByVal [option] As LayoutOption)
        Select Case [option]
            Case LayoutOption.Traditional
                c1FlexGridBandedView1.FlexGrid = Nothing
                c1FlexGridBandedView2.FlexGrid = Nothing
            Case LayoutOption.Compact
                c1FlexGridBandedView2.FlexGrid = Nothing
                c1FlexGridBandedView1.FlexGrid = flexGrid1
            Case LayoutOption.Detailed
                c1FlexGridBandedView1.FlexGrid = Nothing
                c1FlexGridBandedView2.FlexGrid = flexGrid1
        End Select
    End Sub

    Private Sub SetupC1FlexGrid()
        flexGrid1.BeginUpdate()
        flexGrid1.DataSource = GetDataSource()
        flexGrid1.AutoSizeCols()
        flexGrid1.AutoSizeRows()
        flexGrid1.EndUpdate()
    End Sub

    Private Function GetDataSource() As DataTable
        Dim rs As String = "
                SELECT Distinct 
	                Orders.[OrderID], 
	                Orders.OrderDate, 
	                Shippers.CompanyName, 
	                Customers.Country AS Country, 
                    [FirstName] + ' ' + [LastName] As Saler, 
	                Products.ProductName AS Product, 
	                [Order Details].UnitPrice AS UnitPrice, 
	                [Order Details].Quantity, 
	                [Order Details].Discount, 
	                ([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100 as ExtendedPrice 
	                FROM Shippers 
		                INNER JOIN (Products 
		                INNER JOIN ((Employees 
		                INNER JOIN (Customers 
		                INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Employees.EmployeeID = Orders.EmployeeID) 
		                INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID)
			                ON Shippers.ShipperID = Orders.ShipVia; "
        Dim cn As String = GetConnectionString()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(rs, cn)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Private Shared Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
End Class

