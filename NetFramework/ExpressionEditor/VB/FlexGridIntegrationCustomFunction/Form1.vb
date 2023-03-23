Imports System.Data.OleDb
Imports C1.ExpressionEditor.Engine

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C1FlexGrid1.DataSource = GetDataSource()

        'add New custom function "Discount10"
        Dim items As New List(Of ExpressionItem)()
        items.Add(New ExpressionItem("Discount10", "Discount10()", ItemType.MathFuncs))
        ExpressionEditorCollection1.AddFunction(items, Function(args As List(Of Object)) Convert.ToDouble(args(0)) * 0.9, 1, 1)

        'add a calculated column
        Dim column = C1FlexGrid1.Cols.Add()
        column.Name = "DiscountPrice"
        column.DataType = GetType(Object)
        column.Caption = "DiscountPrice"
        column.AllowEditing = False
        column.AllowExpressionEditing = True
        column.Expression = "Discount10([UnitPrice])"
        column.Format = "F2"
    End Sub
#Region "DataSource"
    Private Function GetDataSource() As DataTable
        Dim rs As String = "select ProductName, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel from Products;"
        Dim cn As String = GetConnectionString()
        Dim da As OleDbDataAdapter = New OleDbDataAdapter(rs, cn)
        Dim dt As DataTable = New DataTable()
        da.Fill(dt)
        Return dt
    End Function
    Private Function GetConnectionString() As String
        Dim path As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\ComponentOne Samples\\Common"
        Dim conn As String = "provider=microsoft.jet.oledb.4.0;data source={0}\\c1nwind.mdb;"
        Return String.Format(conn, path)
    End Function
#End Region
End Class
