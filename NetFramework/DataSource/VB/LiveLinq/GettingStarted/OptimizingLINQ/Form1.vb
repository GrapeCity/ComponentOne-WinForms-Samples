Imports System.IO
Imports System.Reflection
Imports C1.LiveLinq
Imports C1.LiveLinq.AdoNet
Imports System.Configuration
Imports System.Globalization

Public Class Form1

    ' declare northwind DataSet
    Dim _ds As New NORTHWNDDataSet


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        AppDomain.CurrentDomain.SetData("DataDirectory", Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common")
        Dim dbFile As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common", "Northwnd.mdf")
        If Not File.Exists(dbFile) Then
            Throw New Exception("Sample database Northwnd.mdf must be created in the Common folder. Run the CreateSampleDB utility to create the Northwind database")
        End If

        ' make sure both version 11 and version 12 or higher of SQLServer LocalDb are supported
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
        Dim connStr = config.ConnectionStrings.ConnectionStrings("OptimizingLINQ.My.MySettings.NORTHWNDConnectionString")
        connStr.ConnectionString = connStr.ConnectionString.Replace("v11.0", version)
        config.Save(ConfigurationSaveMode.Modified, True)
        ConfigurationManager.RefreshSection("connectionStrings")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' load data into DataSet
        Dim daCustomers As New NORTHWNDDataSetTableAdapters.CustomersTableAdapter
        daCustomers.Fill(_ds.Customers)
        Dim daOrders As New NORTHWNDDataSetTableAdapters.OrdersTableAdapter
        daOrders.Fill(_ds.Orders)
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click

        lbxResult.Items.Clear()

        ' get reference to source data
        Dim customers = _ds.Customers
        Dim orders = _ds.Orders

        ' find all orders for the first customer
        Dim q =
              From o In orders
              Where o.CustomerID = customers(0).CustomerID
              Select o

        ' benchmark the query (execute 1000 times)
        Dim start = DateTime.Now
        Dim count As Integer = 0
        For i As Integer = 0 To 1000
            For Each d In q
                count = count + 1
            Next
        Next

        lbxResult.Items.Add(String.Format("LiveLinq query done in {0} ms", DateTime.Now.Subtract(start).TotalMilliseconds))

    End Sub

    Private Sub btnFindIndexing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFindIndexing.Click

        lbxResult.Items.Clear()

        ' get reference to source data
        Dim customers = _ds.Customers
        Dim orders = _ds.Orders

        ' find all orders for the first customer
        Dim q =
              From o In orders.AsIndexed()
              Where o.CustomerID.Indexed() = customers(0).CustomerID
              Select o

        ' benchmark the query (execute 1000 times)
        Dim start = DateTime.Now
        Dim count As Integer = 0
        For i As Integer = 0 To 1000
            For Each d In q
                count = count + 1
            Next
        Next

        lbxResult.Items.Add(String.Format("LiveLinq query done in {0} ms", DateTime.Now.Subtract(start).TotalMilliseconds))

    End Sub
End Class
