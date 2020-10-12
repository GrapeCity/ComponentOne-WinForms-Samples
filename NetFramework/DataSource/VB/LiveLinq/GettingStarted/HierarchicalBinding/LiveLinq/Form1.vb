Imports System.IO
Imports System.Reflection
Imports C1.LiveLinq
Imports C1.LiveLinq.AdoNet
Imports C1.LiveLinq.LiveViews
Imports System.Configuration
Imports System.Globalization

Public Class Form1
    Private Function GetData() As NORTHWNDDataSet

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
        Dim connStr = config.ConnectionStrings.ConnectionStrings("LiveLinq.My.MySettings.NORTHWNDConnectionString")
        connStr.ConnectionString = connStr.ConnectionString.Replace("v11.0", version)
        config.Save(ConfigurationSaveMode.Modified, True)
        ConfigurationManager.RefreshSection("connectionStrings")

        Dim ds As New NORTHWNDDataSet
        Dim daProducts As New NORTHWNDDataSetTableAdapters.ProductsTableAdapter
        daProducts.Fill(ds.Products)
        Dim daCategories As New NORTHWNDDataSetTableAdapters.CategoriesTableAdapter
        daCategories.Fill(ds.Categories)
        Return ds
    End Function

    Private Sub DataBind(ByVal dataSource As Object)
        ' bind ComboBox
        comboBox1.DataSource = dataSource
        comboBox1.DisplayMember = "CategoryName"
        comboBox1.ValueMember = "CategoryID"

        ' bind DataGridView
        dataGridView1.DataMember = "Products"
        dataGridView1.DataSource = dataSource

        ' bind TextBox controls
        BindTextBox(textBox1, dataSource, "ProductName")
        BindTextBox(textBox2, dataSource, "UnitPrice")
        BindTextBox(textBox3, dataSource, "QuantityPerUnit")
        BindTextBox(textBox4, dataSource, "UnitsInStock")
    End Sub


    Private Sub BindTextBox(ByVal txt As TextBox, ByVal dataSource As Object, ByVal dataMember As String)
        Dim b As New Binding("Text", dataSource, "Products." + dataMember)
        txt.DataBindings.Add(b)
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' get the data
        Dim ds = GetData()

        ' create a live view with Categories and Products:
        Dim liveView =
              From c In ds.Categories.AsLive()
              Group Join p In ds.Products.AsLive()
                On c.CategoryID Equals p.CategoryID Into g = Group
              Select New With
              {
                  c.CategoryID,
                  c.CategoryName,
                  .Products = g
              }

        ' bind view to controls
        DataBind(liveView.AsDynamic())

    End Sub
End Class
