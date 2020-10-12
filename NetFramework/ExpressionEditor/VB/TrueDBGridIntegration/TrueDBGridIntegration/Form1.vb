Imports C1.Win.C1TrueDBGrid
Imports System.Data.OleDb

Public Class Form1
    Private _expressionColumnName As String = "Expression"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        C1TrueDBGrid1.DataSource = GetDataSource()

        'add a calculated column
        C1TrueDBGrid1.Columns.Add(New C1DataColumn(_expressionColumnName, GetType(Object)))
        C1TrueDBGrid1.Splits(0).DisplayColumns(_expressionColumnName).Visible = True
        C1TrueDBGrid1.Splits(0).DisplayColumns(_expressionColumnName).Locked = True
        'allow editing expression in run-time (expression icon in column header)
        C1TrueDBGrid1.Splits(0).DisplayColumns(_expressionColumnName).AllowExpressionEditing = True
        'set expression
        C1TrueDBGrid1.Columns(_expressionColumnName).Expression = "[UnitPrice] * [UnitsInStock]"
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