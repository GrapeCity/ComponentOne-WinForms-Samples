Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Text
Imports C1.Win.FlexGrid

Namespace ConditionalFormatting
	Partial Public Class Form1
		Inherits Form
		Private _bigValue As CellStyle
		Private Const BIGVALUE As Integer = 100

		Public Sub New()
			InitializeComponent()

			' configure grid
            Dim grid = Me.c1FlexPivotPage1.FlexPivotGrid

			' style used to show 'big values'
			_bigValue = grid.Styles.Add("bigValue")
			_bigValue.BackColor = Color.LightGreen

			' owner draw to apply the style
			grid.DrawMode = DrawModeEnum.OwnerDraw
			AddHandler grid.OwnerDrawCell, AddressOf grid_OwnerDrawCell

			' load data
			Dim da = New OleDbDataAdapter("select * from invoices", GetConnectionString())
			Dim dt = New DataTable()
			da.Fill(dt)

			' bind data
            Me.c1FlexPivotPage1.DataSource = dt

			' apply default view
            Me.c1FlexPivotPage1.ViewDefinition = My.Resources.DefaultView
		End Sub

		Private Sub grid_OwnerDrawCell(ByVal sender As Object, ByVal e As OwnerDrawCellEventArgs)
			Dim grid = TryCast(sender, C1.Win.FlexGrid.C1FlexGrid)
			If e.Row >= grid.Rows.Fixed AndAlso e.Col >= grid.Cols.Fixed AndAlso TypeOf grid(e.Row, e.Col) Is Double Then
				Dim value = CDbl(grid(e.Row, e.Col))
				If value > BIGVALUE Then
					e.Style = _bigValue
				End If
			End If
		End Sub

		Private Shared Function GetConnectionString() As String
			Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) & "\ComponentOne Samples\Common"
			Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;"
			Return String.Format(conn, path)
		End Function
	End Class
End Namespace
