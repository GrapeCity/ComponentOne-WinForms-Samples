Imports System.IO
Imports System.Reflection
Imports C1.LiveLinq
Imports C1.LiveLinq.AdoNet
Imports C1.LiveLinq.LiveViews
Imports System.Configuration
Imports System.Globalization


Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' get the data
        Dim ds As NORTHWNDDataSet = GetData()

        ' create a live views to update order details
        dataGridView1.DataSource = GetOrderDetails(ds)

        ' create live views that provide up-to-date order information
        dataGridView2.DataSource = GetSalesByCategory(ds)
        dataGridView3.DataSource = GetSalesByProduct(ds)

    End Sub

    Private Function GetData() As NORTHWNDDataSet
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
        Dim dbFile As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common", "Northwnd.mdf")
        If Not File.Exists(dbFile) Then
            Throw New Exception("Sample database Northwnd.mdf must be created in the Common folder. Run the CreateSampleDB utility to create the Northwind database")
        End If

        Dim key As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions")
        If key Is Nothing Then
            Throw New Exception("Microsoft SQL Server LocalDB is not installed.")
        End If
        Dim version As String = "v11.0"
        For Each subKeyName In key.GetSubKeyNames()
            Dim localDBVersion As Double = 0
            If Double.TryParse(subKeyName, NumberStyles.Number, CultureInfo.InvariantCulture, localDBVersion) And localDBVersion >= 12 Then
                version = "MSSQLLocalDB"
                Exit For
            End If
        Next
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim connStr = config.ConnectionStrings.ConnectionStrings("DeclarativeProgramming.My.MySettings.NORTHWNDConnectionString")
        connStr.ConnectionString = connStr.ConnectionString.Replace("v11.0", version)
        config.Save(ConfigurationSaveMode.Modified, True)
        ConfigurationManager.RefreshSection("connectionStrings")

        Dim ds As New NORTHWNDDataSet()
        Dim daProducts As New NORTHWNDDataSetTableAdapters.ProductsTableAdapter
        daProducts.Fill(ds.Products)
        Dim daOrder_Details As New NORTHWNDDataSetTableAdapters.Order_DetailsTableAdapter
        daOrder_Details.Fill(ds.Order_Details)
        Dim daCategories As New NORTHWNDDataSetTableAdapters.CategoriesTableAdapter
        daCategories.Fill(ds.Categories)
        Return ds
    End Function


    Public Class SalesByCategoryInfo
        Public CategoryName As String
        Public SaleAmount As Decimal
    End Class

    Private Function GetSalesByCategory(ByVal ds As NORTHWNDDataSet) As Object
        Dim products = ds.Products
        Dim details = ds.Order_Details
        Dim categories = ds.Categories

        Dim salesByCategory =
            From p In products.AsLive()
            Join c In categories.AsLive()
                On p.CategoryID Equals c.CategoryID
            Join d In details.AsLive()
                On p.ProductID Equals d.ProductID
            Let detail = New SalesByCategoryInfo() With {.CategoryName = c.CategoryName, .SaleAmount = d.UnitPrice * d.Quantity * Convert.ToDecimal(1.0F - d.Discount)}
            Group detail By Key = detail.CategoryName Into categorySales = Group
            Let total = categorySales.Sum(Function(x) x.SaleAmount)
            Order By total Descending
            Select New With
            {
                .CategoryName = Key,
                .TotalSales = total
            }

        Return salesByCategory.AsDynamic()

    End Function

    Public Class SalesByProductInfo
        Public ProductName As String
        Public CategoryName As String
        Public TotalSales As Decimal
    End Class

    Private Function GetSalesByProduct(ByVal ds As NORTHWNDDataSet) As Object
        Dim products = ds.Products
        Dim details = ds.Order_Details
        Dim categories = ds.Categories

        Dim salesByProduct =
          From p In products.AsLive()
          Join c In categories.AsLive()
            On p.CategoryID Equals c.CategoryID
          Group Join d In details.AsLive()
            On p.ProductID Equals d.ProductID
          Into sales = Group
          Let productSales = New SalesByProductInfo() With
          {
             .ProductName = p.ProductName,
             .CategoryName = c.CategoryName,
             .TotalSales = sales.Sum(
                 Function(d) d.UnitPrice * d.Quantity *
                        Convert.ToDecimal(1.0F - d.Discount))
          }
          Order By productSales.TotalSales Descending
          Select productSales

        Return salesByProduct
    End Function

    Private Function GetOrderDetails(ByVal ds As NORTHWNDDataSet) As Object
        Dim products = ds.Products
        Dim details = ds.Order_Details
        Dim categories = ds.Categories

        Dim orderDetails =
            From d In details.AsLive().AsUpdatable()
            Join p In products.AsLive()
            On d.ProductID Equals p.ProductID
            Join c In categories.AsLive()
            On p.CategoryID Equals c.CategoryID
            Select CType(New With {
                c.CategoryName,
                p.ProductName,
                d.UnitPrice,
                d.Quantity,
                d.Discount}, Object)

        Return orderDetails
    End Function

End Class
