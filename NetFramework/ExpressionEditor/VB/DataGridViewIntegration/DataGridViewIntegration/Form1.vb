Imports System
Imports System.Data
Imports System.Windows.Forms
Imports C1.Win.ExpressionEditor
Imports System.Data.OleDb

Public Class Form1
    Private _columnName As String
    Private WithEvents _dialog As ExpressionEditorForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewEE1.DataSource = GetDataSource()
        DataGridViewEE1.UpdateExpression("Expression", "[UnitPrice] * [UnitsInStock]")
        DataGridViewEE1.Columns.Add("EmptyExpression", "EmptyExpression")
    End Sub

    Private Sub OpenExpressionEditorDialog(columnName As String)
        _columnName = columnName
        If (_dialog Is Nothing) Then
            _dialog = New ExpressionEditorForm()
        End If
        'set data for ExpressionEditorForm dialog
        _dialog.Text = String.Format("Edit expression of '{0}' column", columnName)
        _dialog.DataSource = DataGridViewEE1.DataSource
        _dialog.Expression = DataGridViewEE1.GetExpression(columnName)
        _dialog.ShowDialog()
        If (_dialog.DialogResult = DialogResult.OK) Then
            'update expression and evaluate it
            DataGridViewEE1.UpdateExpression(columnName, _dialog.Expression)
            DataGridViewEE1.Evaluate(columnName)
        End If
    End Sub
    'The Apply button was clicked
    Private Sub _dialog_Apply(sender As Object, e As EventArgs) Handles _dialog.Apply
        'update expression and evaluate it
        DataGridViewEE1.UpdateExpression(_columnName, _dialog.Expression)
        DataGridViewEE1.Evaluate(_columnName)
    End Sub
    Private Sub DataGridViewEE1_ColumnHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewEE1.ColumnHeaderMouseClick
        If (e.Button = MouseButtons.Right) Then
            Dim column = DataGridViewEE1.Columns(e.ColumnIndex)
            If (False = column.IsDataBound) Then
                OpenExpressionEditorDialog(column.Name)
            End If
        End If
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
