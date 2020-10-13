Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Text
Imports System.Xml

Namespace SqlFilter
	Partial Public Class Form1
		Inherits Form
		Private _customerList As List(Of String)
		Private _activeCustomerList As List(Of String)
		Private Const MAX_CUSTOMERS As Integer = 12

		Public Sub New()
			InitializeComponent()

			' get complete list of customers
			_customerList = New List(Of String)()
			Dim sql = "SELECT DISTINCT Customers.CompanyName AS [Customer] FROM Customers"
			Dim da = New OleDbDataAdapter(sql, GetConnectionString())
			Dim dt = New DataTable()
			da.Fill(dt)
			For Each dr As DataRow In dt.Rows
				_customerList.Add(CStr(dr("Customer")))
			Next dr

			' get active customer list
			_activeCustomerList = New List(Of String)()
			For Each customer As String In My.Settings.Default.Customers
				_activeCustomerList.Add(customer)
			Next customer

			' get data into the CachedDataTable
            Dim dtSales = New CachedDataTable(My.Resources.SqlTemplate, My.Resources.WhereTemplate, GetConnectionString())
			dtSales.Fill(_activeCustomerList)

			' assign data to C1OlapPage control
			_c1OlapPage.DataSource = dtSales

			' show default view
			Dim olap = _c1OlapPage.OlapEngine
			olap.BeginUpdate()
			olap.RowFields.Add("Customer")
			olap.ColumnFields.Add("Category")
			olap.ValueFields.Add("Sales")
			olap.EndUpdate()

			' custom filter: customers in the list, customers currently active
			Dim field = olap.Fields("Customer")
			Dim filter = field.Filter
			filter.Values = _customerList
			filter.ShowValues = _activeCustomerList.ToArray()
			AddHandler filter.PropertyChanged, AddressOf filter_PropertyChanged

			' load predefined olap views
			Dim doc = New XmlDocument()
            doc.LoadXml(My.Resources.OlapViews)

			' build menu with default olap views
			Dim items = _c1OlapPage.MenuGrid.DropDownItems
			items.Add(New ToolStripSeparator())
			For Each nd As XmlNode In doc.SelectNodes("OlapViews/C1Olap")
				Dim tsi = items.Add(nd.Attributes("id").Value)
				tsi.Tag = nd
			Next nd
			AddHandler _c1OlapPage.MenuGrid.DropDownItemClicked, AddressOf MenuView_DropDownItemClicked

			' change "OrderDate" caption to "Date" (looks nicer on the UI)
			olap.Fields("OrderDate").Caption = "Date"

			' make sure Customer field is always in the view
			' (since it is always used at least as a filter)
			AddHandler _c1OlapPage.Updating, AddressOf _c1OlapPage_Updating
		End Sub

		' make sure Customer field is always in the view
		' (since it is always used at least as a filter)
		Private Sub _c1OlapPage_Updating(ByVal sender As Object, ByVal e As EventArgs)
			Dim olap = _c1OlapPage.OlapEngine
			Dim field = olap.Fields("Customer")
			If Not field.IsActive Then
				olap.FilterFields.Add(field)
			End If
		End Sub

		' re-query database when list of selected customers changes
		Private Sub filter_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			' get reference to parent filter
			Dim filter = TryCast(sender, C1.Olap.C1OlapFilter)

			' get list of values accepted by the filter
			_activeCustomerList.Clear()
			For Each customer As String In _customerList
				If filter.Apply(customer) Then
					_activeCustomerList.Add(customer)
				End If
			Next customer

			' skip if no values were selected
			If _activeCustomerList.Count = 0 Then
				MessageBox.Show("You have selected no customers, change will not be applied.", "No Customers")
				Return
			End If

			' trim list if necessary
			If _activeCustomerList.Count > MAX_CUSTOMERS Then
				MessageBox.Show("You have selected too many customers, list will be trimmed.", "Too Many Customers")
				_activeCustomerList.RemoveRange(MAX_CUSTOMERS, _activeCustomerList.Count - MAX_CUSTOMERS)
			End If

			' get new data
			Dim dt = TryCast(_c1OlapPage.DataSource, CachedDataTable)
			dt.Fill(_activeCustomerList)
		End Sub

		Protected Overrides Sub OnClosed(ByVal e As EventArgs)
			' save current customer list for next time
			Dim customerList = My.Settings.Default.Customers
			customerList.Clear()
			For Each customer As String In _activeCustomerList
				customerList.Add(customer)
			Next customer
			My.Settings.Default.Save()

			' fire event as usual
			MyBase.OnClosed(e)
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
