Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Text

Namespace CustomUI
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			
			' Disable the cross thread check for we use multi thread for data update.
			Control.CheckForIllegalCrossThreadCalls = False
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' load data
			Dim da = New OleDbDataAdapter("select * from Invoices", GetConnectionString())
			Dim dt = New DataTable()
			da.Fill(dt)

            ' assign it to C1FlexPivotPanel that is driving the app
            Me.c1FlexPivotPanel1.DataSource = dt

			' start with the SalesPerson view, all products
			_btnSalesperson.PerformClick()
			_btnAllPrices.PerformClick()
		End Sub

		'------------------------------------------------------------------------
		#Region "** handle clicks on view buttons"

		Private Sub _btnSalesperson_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnSalesperson.Click
			CheckButton(sender)
			BuildView("Salesperson")
		End Sub
		Private Sub _btnProduct_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnProduct.Click
			CheckButton(sender)
			BuildView("ProductName")
		End Sub
		Private Sub _btnCountry_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnCountry.Click
			CheckButton(sender)
			BuildView("Country")
		End Sub

		#End Region

		'------------------------------------------------------------------------
		#Region "** handle clicks on price filter buttons"

		Private Sub _btnExpensive_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnExpensive.Click
			CheckButton(sender)
			SetPriceFilter("Expensive Products (price > $50)", 50, Double.MaxValue)
		End Sub
		Private Sub _btnModerate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnModerate.Click
			CheckButton(sender)
			SetPriceFilter("Moderately Priced Products ($20 < price < $50)", 20, 50)
		End Sub
		Private Sub _btnInexpensive_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnInexpensive.Click
			CheckButton(sender)
			SetPriceFilter("Inexpensive Products (price < $20)", 0, 20)
		End Sub
		Private Sub _btnAllProducts_Click(ByVal sender As Object, ByVal e As EventArgs) Handles _btnAllPrices.Click
			CheckButton(sender)
			SetPriceFilter("All Products", 0, Double.MaxValue)
		End Sub

		#End Region

		'------------------------------------------------------------------------
		#Region "** generate report"

		Private Sub _btnReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles toolStripButton5.Click
            Using dlg = New C1.Win.FlexPivot.C1FlexPivotPrintPreviewDialog()
                dlg.Document = c1FlexPivotPrintDocument1
                dlg.StartPosition = FormStartPosition.Manual
                dlg.Bounds = Me.Bounds
                dlg.ShowDialog(Me)
            End Using
		End Sub

		#End Region

		'------------------------------------------------------------------------
		#Region "** implementation"

		' rebuild the view after a button was clicked
		Private Sub BuildView(ByVal fieldName As String)
			' get FlexPivot engine
			Dim fp = c1FlexPivotPanel1.PivotEngine

			' stop updating until done
			fp.BeginUpdate()

			' clear all fields
			fp.RowFields.Clear()
			fp.ColumnFields.Clear()
			fp.ValueFields.Clear()

			' format order dates to group by year
			Dim f = fp.Fields("OrderDate")
			f.Format = "yyyy"

			' build up view
			fp.ColumnFields.Add("OrderDate")
			fp.RowFields.Add(fieldName)
			fp.ValueFields.Add("ExtendedPrice")

			' restore updates
			fp.EndUpdate()
		End Sub

		' apply a filter to the product price
		Private Sub SetPriceFilter(ByVal footerText As String, ByVal min As Double, ByVal max As Double)
			' get FlexPivot engine
			Dim fp = c1FlexPivotPanel1.PivotEngine

			' stop updating until done
			fp.BeginUpdate()

			' make sure unit price field is active in the view
            Dim field = fp.Fields("UnitPrice")
            fp.FilterFields.Add(field)

			' customize the filter
			Dim filter = field.Filter
			filter.Clear()
			filter.Condition1.Operator = C1.PivotEngine.ConditionOperator.GreaterThanOrEqualTo
			filter.Condition1.Parameter = min
			filter.Condition2.Operator = C1.PivotEngine.ConditionOperator.LessThanOrEqualTo
			filter.Condition2.Parameter = max

			' restore updates
            fp.EndUpdate()

			' set report footer
            c1FlexPivotPrintDocument1.FooterText = footerText
		End Sub

		' show which button was pressed
		Private Sub CheckButton(ByVal pressedButton As Object)
			Dim btn = TryCast(pressedButton, ToolStripButton)
			btn.Checked = True

			Dim items = btn.Owner.Items
			Dim index = items.IndexOf(btn)
			For i As Integer = index + 1 To items.Count - 1
				If TypeOf items(i) Is ToolStripButton Then
					CType(items(i), ToolStripButton).Checked = False
				Else
					Exit For
				End If
			Next i
            Dim j As Integer = index - 1
            Do While j > 0 AndAlso Not (TypeOf items(j) Is ToolStripSeparator)
                If TypeOf items(j) Is ToolStripButton Then
                    CType(items(j), ToolStripButton).Checked = False
                Else
                    Exit Do
                End If
                j -= 1
            Loop
		End Sub

		' get standard nwind mdb connection string
		Private Shared Function GetConnectionString() As String
			Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
			Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
			Return String.Format(conn, path)
		End Function
		#End Region
	End Class
End Namespace
