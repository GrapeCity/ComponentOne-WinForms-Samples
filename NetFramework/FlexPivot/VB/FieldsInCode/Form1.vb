Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Text

Namespace FilterInCode
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			' get data
			Dim da = New OleDbDataAdapter("select * from invoices", GetConnectionString())
			Dim dt = New DataTable()
			da.Fill(dt)

            ' bind to FlexPivot page
            Me.c1FlexPivotPage1.DataSource = dt

			' build view
            Dim fp = Me.c1FlexPivotPage1.FlexPivotEngine
            fp.ValueFields.Add("ExtendedPrice")
            fp.RowFields.Add("OrderDate", "ProductName")

			' format order date and extended price
            Dim field = fp.Fields("OrderDate")
			field.Format = "yyyy"
            field = fp.Fields("ExtendedPrice")
			field.Format = "c"

			' show average price (instead of sum)
            field = fp.Fields("ExtendedPrice")
            field.Subtotal = C1.FlexPivot.Subtotal.Average

			' apply value filter to show only a few products
            Dim filter As C1.FlexPivot.C1FlexPivotFilter = fp.Fields("ProductName").Filter
			filter.Clear()
			filter.ShowValues = "Chai,Chang,Geitost,Ikura".Split(","c)

			' apply range filter to show only some dates
            filter = fp.Fields("OrderDate").Filter
			filter.Clear()
            filter.Condition1.Operator = C1.FlexPivot.ConditionOperator.GreaterThanOrEqualTo
            filter.Condition1.Parameter = New Date(2014, 1, 1)
            filter.Condition2.Operator = C1.FlexPivot.ConditionOperator.LessThanOrEqualTo
            filter.Condition2.Parameter = New Date(2014, 12, 31)
			filter.AndConditions = True
		End Sub
		Private Shared Function GetConnectionString() As String
			Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
			Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
			Return String.Format(conn, path)
		End Function
	End Class
End Namespace
