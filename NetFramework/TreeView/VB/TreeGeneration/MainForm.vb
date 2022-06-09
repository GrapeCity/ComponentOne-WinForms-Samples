Imports C1.Win.C1Themes
Imports C1.Win.Ribbon

Partial Public Class MainForm
    Inherits C1RibbonForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitThemes()

        C1TreeView1.BindingInfo.DataMemberPath.Add(0, "Customers")
        C1TreeView1.BindingInfo.DataMemberPath.Add(1, "Orders")
        C1TreeView1.BindingInfo.DataMemberPath.Add(2, "OrderDetail")
        C1TreeView1.BindingInfo.DataSource = GetData()
    End Sub

    Public Function GetData() As DataSet
        Dim drc As DataRowCollection
        Dim dcc As DataColumnCollection
        Dim ds As DataSet = New DataSet("Hierarchical DataSet")
        ds.Tables.Add("Products")
        dcc = ds.Tables("Products").Columns
        dcc.Add("ID", GetType(String))
        dcc.Add("Name", GetType(String))
        dcc.Add("Value", GetType(Decimal))
        drc = ds.Tables("Products").Rows
        drc.Add(New Object() {"P1", "Widget", 19.95})
        drc.Add(New Object() {"P2", "Gadget", 22.75})
        drc.Add(New Object() {"P3", "Sprocket", 33.1})
        ds.Tables.Add("Customers")
        dcc = ds.Tables("Customers").Columns
        dcc.Add("ID", GetType(String))
        dcc.Add("Name", GetType(String))
        dcc.Add("Address", GetType(String))
        drc = ds.Tables("Customers").Rows
        drc.Add(New Object() {"C1", "John", "122 Penny Lane"})
        drc.Add(New Object() {"C2", "Paul", "666 Abbey Road"})
        drc.Add(New Object() {"C3", "George", "222 Chatham Road"})
        drc.Add(New Object() {"C4", "Ringo", "345 Oxford St."})
        ds.Tables.Add("Orders")
        dcc = ds.Tables("Orders").Columns
        dcc.Add("ID", GetType(String))
        dcc.Add("CustomerID", GetType(String))
        dcc.Add("Prty", GetType(Integer))
        dcc.Add("Date", GetType(DateTime))
        drc = ds.Tables("Orders").Rows
        drc.Add(New Object() {"O1", "C1", 1, New DateTime(2001, 12, 1)})
        drc.Add(New Object() {"O2", "C2", 2, New DateTime(2002, 1, 22)})
        drc.Add(New Object() {"O3", "C3", 3, New DateTime(2002, 1, 20)})
        drc.Add(New Object() {"O4", "C4", 1, New DateTime(2002, 1, 14)})
        drc.Add(New Object() {"O5", "C1", 3, New DateTime(2002, 1, 16)})
        ds.Tables.Add("OrderDetail")
        dcc = ds.Tables("OrderDetail").Columns
        dcc.Add("ID", GetType(String))
        dcc.Add("OrderID", GetType(String))
        dcc.Add("ProductID", GetType(String))
        dcc.Add("Qty", GetType(Integer))
        drc = ds.Tables("OrderDetail").Rows
        drc.Add(New Object() {"D1", "O1", "P1", 1})
        drc.Add(New Object() {"D2", "O1", "P2", 12})
        drc.Add(New Object() {"D3", "O1", "P3", 1})
        drc.Add(New Object() {"D4", "O2", "P1", 1})
        drc.Add(New Object() {"D5", "O2", "P2", 8})
        drc.Add(New Object() {"D6", "O2", "P3", 1})
        drc.Add(New Object() {"D7", "O3", "P1", 1})
        drc.Add(New Object() {"D8", "O4", "P1", 1})
        drc.Add(New Object() {"D9", "O4", "P2", 10})
        drc.Add(New Object() {"D10", "O5", "P1", 1})
        drc.Add(New Object() {"D11", "O5", "P2", 16})
        drc.Add(New Object() {"D12", "O5", "P3", 1})
        ds.Relations.Add("CustomerOrders", ds.Tables("Customers").Columns("ID"), ds.Tables("Orders").Columns("CustomerID"))
        ds.Relations.Add("Order Details", ds.Tables("Orders").Columns("ID"), ds.Tables("OrderDetail").Columns("OrderID"))
        ds.Relations.Add("Product Details", ds.Tables("Products").Columns("ID"), ds.Tables("OrderDetail").Columns("ProductID"))
        Return ds
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
