Imports System.Data.OleDb
Imports System.IO
Imports C1.Win.C1Themes
Imports C1.Win.Ribbon
Partial Public Class MainForm
    Inherits C1RibbonForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitThemes()
    End Sub


    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs)
        FillFlexGrid(c1FlexGrid1)
        c1FlexGrid1.AllowPinning = C1.Win.C1FlexGrid.AllowPinning.SingleColumn
        c1FlexGrid1.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        c1FlexGrid1.Cols.Frozen = 3
        FillFlexGrid(c1FlexGrid2)
        c1FlexGrid2.AllowPinning = C1.Win.C1FlexGrid.AllowPinning.ColumnRange
        c1FlexGrid2.AllowFreezing = C1.Win.C1FlexGrid.AllowFreezingEnum.Columns
        c1FlexGrid2.Cols.Frozen = 4
        InitThemes()
    End Sub

    Private Sub FillFlexGrid(ByVal c1FlexGrid As C1.Win.C1FlexGrid.C1FlexGrid)
        c1FlexGrid.DataSource = DemoDataSource()

        If c1FlexGrid.Cols.Contains("Product") Then
            c1FlexGrid.Cols("Product").MinWidth = 120
            c1FlexGrid.Cols("Product").StarWidth = "*"
        End If

        If c1FlexGrid.Cols.Contains("UnitPrice") Then c1FlexGrid.Cols("UnitPrice").Format = "n2"
        If c1FlexGrid.Cols.Contains("ExtendedPrice") Then c1FlexGrid.Cols("ExtendedPrice").Format = "n2"
    End Sub

    Public Function DemoDataSource() As DataTable
        Dim dt As DataTable = New DataTable()
        Dim sql As String = "SELECT DISTINCTROW Orders.OrderID, Orders.OrderDate, Shippers.CompanyName, Customers.Country, [FirstName] & "" "" & [LastName] AS Salesperson, Products.ProductName AS Product, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount, CCur([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100 AS ExtendedPrice FROM Shippers INNER JOIN (Products INNER JOIN ((Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID) ON Shippers.ShipperID = Orders.ShipVia;"
        Dim dbPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common\C1NWind.mdb"

        If File.Exists(dbPath) Then
            Dim connString As String = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & dbPath & ";Persist Security Info=False"
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(sql, connString)
            da.Fill(dt)
        Else
            MessageBox.Show("An example database C1NWind.mdb is not found at" & dbPath)
        End If

        Return dt
    End Function

#Region "Themes"

    Private Sub CmbThemes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbThemes.SelectedIndexChanged
        C1ThemeController1.Theme = cmbThemes.SelectedItem.Text
    End Sub

    Private Sub InitThemes()
        Dim themes = C1ThemeController.GetThemes().Where(Function(x) x.Contains("Office2016"))

        For Each theme In themes
            cmbThemes.Items.Add(theme)
        Next
    End Sub

#End Region

End Class
