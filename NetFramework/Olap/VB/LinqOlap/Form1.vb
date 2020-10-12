Imports System.Xml
Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Text

Namespace LinqOlap
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
			_c1OlapPage.DataSource = q.ToList()

			' show default view
			Dim olap = _c1OlapPage.OlapPanel.OlapEngine
			olap.BeginUpdate()
			olap.RowFields.Add("Country")
			olap.ColumnFields.Add("Category")
			olap.ValueFields.Add("Sales")
			olap.EndUpdate()

			' load predefined olap views
			Dim doc = New XmlDocument()
			doc.LoadXml(My.Resources.OlapViews)

			' build menu with default olap views
			Dim menuView = New ToolStripDropDownButton("&View", My.Resources.Views_small)
			For Each nd As XmlNode In doc.SelectNodes("OlapViews/C1Olap")
				Dim tsi = menuView.DropDownItems.Add(nd.Attributes("id").Value)
				tsi.Tag = nd
			Next nd
			AddHandler menuView.DropDownItemClicked, AddressOf MenuView_DropDownItemClicked

			' add the new view menu to the toolstrip
			_c1OlapPage.ToolStrip.Items.Insert(3, menuView)
		End Sub

		' select a predefined Olap view
		Private Sub MenuView_DropDownItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs)
			Dim nd = TryCast(e.ClickedItem.Tag, XmlNode)
			If nd IsNot Nothing Then
				_c1OlapPage.OlapPanel.ViewDefinition = nd.OuterXml
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
