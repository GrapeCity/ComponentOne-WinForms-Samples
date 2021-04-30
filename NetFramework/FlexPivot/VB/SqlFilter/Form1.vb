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
            For Each customer As String In Settings.Default.Customers
                _activeCustomerList.Add(customer)
            Next customer

			' get data into the CachedDataTable
            Dim dtSales = New CachedDataTable(My.Resources.SqlTemplate, My.Resources.WhereTemplate, GetConnectionString())
			dtSales.Fill(_activeCustomerList)

            ' assign data to C1FlexPivotPage control
            _c1FlexPivotPage.DataSource = dtSales

			' show default view
			Dim fp = _c1FlexPivotPage.PivotEngine
			fp.BeginUpdate()
			fp.RowFields.Add("Customer")
			fp.ColumnFields.Add("Category")
			fp.ValueFields.Add("Sales")
			fp.EndUpdate()

			' custom filter: customers in the list, customers currently active
			Dim field = fp.Fields("Customer")
			Dim filter = field.Filter
			filter.Values = _customerList
			filter.ShowValues = _activeCustomerList.ToArray()
			AddHandler filter.PropertyChanged, AddressOf filter_PropertyChanged

			' load predefined FlexPivot views
			Dim doc = New XmlDocument()
			doc.LoadXml(My.Resources.FlexPivotViews)

			' build menu with default FlexPivot views
			Dim items = _c1FlexPivotPage.MenuGrid.CommandLinks
			Dim i As Integer
			For Each nd As System.Xml.XmlNode In doc.SelectNodes("FlexPivotViews/C1FlexPivot")
				Dim cmd = New C1.Win.C1Command.C1Command()
				cmd.Text = nd.Attributes("id").Value
				cmd.UserData = nd
				AddHandler cmd.Click, AddressOf MenuView_DropDownItemClicked
				Dim link = New C1.Win.C1Command.C1CommandLink(cmd)
				If (i = 0) Then link.Delimiter = True
				items.Add(link)
				i += 1
			Next nd

			' change "OrderDate" caption to "Date" (looks nicer on the UI)
			fp.Fields("OrderDate").Caption = "Date"

			' make sure Customer field is always in the view
			' (since it is always used at least as a filter)
			AddHandler _c1FlexPivotPage.Updating, AddressOf _c1FlexPivotPage_Updating
		End Sub

		' make sure Customer field is always in the view
		' (since it is always used at least as a filter)
		Private Sub _c1FlexPivotPage_Updating(ByVal sender As Object, ByVal e As EventArgs)
			Dim fp = _c1FlexPivotPage.PivotEngine
			Dim field = fp.Fields("Customer")
            If Not field.IsActive Then
                fp.FilterFields.Add(field)
            End If
        End Sub

		' re-query database when list of selected customers changes
		Private Sub filter_PropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
			' get reference to parent filter
			Dim filter = TryCast(sender, C1.PivotEngine.PivotFilter)

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
            Dim dt = TryCast(_c1FlexPivotPage.DataSource, CachedDataTable)
			dt.Fill(_activeCustomerList)
		End Sub

		Protected Overrides Sub OnClosed(ByVal e As EventArgs)
			' save current customer list for next time
            Dim customerList = Settings.Default.Customers
			customerList.Clear()
			For Each customer As String In _activeCustomerList
				customerList.Add(customer)
			Next customer
            Settings.Default.Save()

			' fire event as usual
			MyBase.OnClosed(e)
		End Sub

        ' select a predefined FlexPivot view
        Private Sub MenuView_DropDownItemClicked(ByVal sender As Object, ByVal e As C1.Win.C1Command.ClickEventArgs)
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
