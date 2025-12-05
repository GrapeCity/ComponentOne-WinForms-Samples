Imports System.Xml
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Text

Namespace LinqFlexPivot
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            ' designer
            InitializeComponent()

            ' load all interesting tables into a DataSet
            Dim ds = New DataSet()
            For Each table As String In "Products,Categories,Employees,Customers,Orders,Order Details".Split(","c)
                Dim sql As String = String.Format("select * from [{0}]", table)
                Dim da = New OleDbDataAdapter(sql, GetConnectionString())
                da.Fill(ds, table)
            Next table

            ' build LINQ query
            Dim q = From detail In ds.Tables("Order Details").AsEnumerable() _
                    Join product In ds.Tables("Products").AsEnumerable() On detail.Field(Of Integer)("ProductID") Equals product.Field(Of Integer)("ProductID") _
                    Join category In ds.Tables("Categories").AsEnumerable() On product.Field(Of Integer)("CategoryID") Equals category.Field(Of Integer)("CategoryID") _
                    Join order In ds.Tables("Orders").AsEnumerable() On detail.Field(Of Integer)("OrderID") Equals order.Field(Of Integer)("OrderID") _
                    Join customer In ds.Tables("Customers").AsEnumerable() On order.Field(Of String)("CustomerID") Equals customer.Field(Of String)("CustomerID") _
                    Join employee In ds.Tables("Employees").AsEnumerable() On order.Field(Of Integer)("EmployeeID") Equals employee.Field(Of Integer)("EmployeeID") _
                    Select New With {Key .Sales = (detail.Field(Of Short)("Quantity") * CDbl(detail.Field(Of Decimal)("UnitPrice"))) * (1 - CDbl(detail.Field(Of Single)("Discount"))), Key .OrderDate = order.Field(Of Date)("OrderDate"), Key .Product = product.Field(Of String)("ProductName"), Key .Customer = customer.Field(Of String)("CompanyName"), Key .Country = customer.Field(Of String)("Country"), Key .Employee = employee.Field(Of String)("FirstName") & " " & employee.Field(Of String)("LastName"), Key .Category = category.Field(Of String)("CategoryName")}

            ' use LINQ query as DataSource
            _c1FlexPivotPage.DataSource = q.ToList()

            ' show default view
            Dim fp = _c1FlexPivotPage.FlexPivotPanel.PivotEngine
            fp.BeginUpdate()
            fp.RowFields.Add("Country")
            fp.ColumnFields.Add("Category")
            fp.ValueFields.Add("Sales")
            fp.EndUpdate()

            ' load predefined FlexPivot views
            Dim doc = New XmlDocument()
            doc.LoadXml(My.Resources.FlexPivotViews)

            ' build menu with default FlexPivot views
            Dim menuView = New C1.Win.Command.C1CommandMenu()
            menuView.Text = "&View"
            menuView.Image = My.Resources.Views_small
            For Each nd As System.Xml.XmlNode In doc.SelectNodes("FlexPivotViews/C1FlexPivot")
                Dim cmd = New C1.Win.Command.C1Command()
                cmd.Text = nd.Attributes("id").Value
                cmd.UserData = nd
                AddHandler cmd.Click, AddressOf MenuView_DropDownItemClicked
                Dim link = New C1.Win.Command.C1CommandLink(cmd)
                menuView.CommandLinks.Add(link)
            Next nd

            ' add the new view menu to the toolstrip
            Dim menuLink = New C1.Win.Command.C1CommandLink(menuView)
            _c1FlexPivotPage.ToolBar.CommandLinks.Insert(3, menuLink)
        End Sub

        ' select a predefined FlexPivot view
        Private Sub MenuView_DropDownItemClicked(ByVal sender As Object, ByVal e As C1.Win.Command.ClickEventArgs)
            Dim nd = TryCast(e.CallerLink.Command.UserData, System.Xml.XmlNode)
            If nd IsNot Nothing Then
                _c1FlexPivotPage.FlexPivotPanel.ViewDefinition = nd.OuterXml
            End If
        End Sub

        ' get standard nwind mdb connection string
        Private Shared Function GetConnectionString() As String
            Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
            Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
            Return String.Format(conn, path)
        End Function
    End Class
End Namespace
