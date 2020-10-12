Imports C1.Win.ExpressionEditor

Public Class DataGridViewEE
    Inherits DataGridView
    Implements IDisposable

    Private _editors As ExpressionEditorCollection
    Public Sub New()
        MyBase.New()
        _editors = New ExpressionEditorCollection()
    End Sub

#Region " Model "
    'updates the expression for the editor associated with the specified column
    Public Sub UpdateExpression(columnName As String, expression As String)
        'if the collection does not contain editor associated with the specified column
        If (False = _editors.Contains(columnName)) Then
            'add a new column if necessary
            If (False = Columns.Contains(columnName)) Then
                Columns.Add(columnName, columnName)
            End If
        End If
        'updates the expression editor, or adds a new editor
        _editors.Update(columnName, expression)
        Evaluate(columnName)
        Invalidate()
    End Sub
    'evaluates expression for all rows
    Public Sub Evaluate(columnName As String)
        Dim count As Integer = Rows.Count - 1
        For i As Integer = 0 To count Step 1
            Evaluate(i, columnName)
        Next i
    End Sub
    Public Function GetExpression(columnName As String) As String
        If _editors.Contains(columnName) Then
            Return _editors(columnName).Expression
        Else
            Return Nothing
        End If
    End Function
#End Region

#Region " Override "
    Protected Overrides Sub OnCellValueChanged(e As DataGridViewCellEventArgs)
        If (False = _editors.Contains(Columns(e.ColumnIndex).Name)) Then
            Evaluate(e.RowIndex)
            Invalidate()
        End If
        MyBase.OnCellValueChanged(e)
    End Sub
    Protected Overrides Sub OnSorted(e As EventArgs)
        Evaluate()
    End Sub
    Protected Overrides Sub OnDataSourceChanged(e As EventArgs)
        'update the data source for editors
        _editors.DataSource = DataSource
        'evaluate expressions with new data
        Evaluate()
        MyBase.OnDataSourceChanged(e)
    End Sub
#End Region

#Region " Private "
    'evaluates all expressions
    Private Sub Evaluate()
        Dim count As Integer = Rows.Count - 1
        For i As Integer = 0 To count Step 1
            Evaluate(i)
        Next i
    End Sub
    'evaluates all expressions for specified row
    Private Sub Evaluate(row As Integer)
        'item context - data for specified row
        Dim context As Object = Rows(row).DataBoundItem
        If (context IsNot Nothing) Then
            'set item context
            _editors.ItemContext = context
            'for all editors
            For Each editor In _editors
                Dim value As Object = Nothing
                If (editor.Value.TryEvaluate(value)) Then
                    Me(editor.Key, row).Value = value
                End If
            Next editor
        End If
    End Sub
    Private Sub Evaluate(row As Integer, columnName As String)
        'item context - data for specified row
        Dim context = Rows(row).DataBoundItem
        If (context IsNot Nothing) Then
            'set item context
            _editors.ItemContext = context
            Dim value As Object = Nothing
            If (_editors(columnName).TryEvaluate(value)) Then
                Me(columnName, row).Value = value
            End If
        End If
    End Sub
#End Region

#Region " IDisposable Support "
    Public Overloads Sub Dispose() Implements IDisposable.Dispose
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
    Protected Overrides Sub Finalize()
        Dispose(False)
        MyBase.Finalize()
    End Sub
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            _editors?.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub
#End Region

End Class
