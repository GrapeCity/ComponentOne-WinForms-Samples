Imports System.Windows.Forms
Imports C1.Win.C1FlexGrid
Imports C1.DataFilter
Imports C1.Win.Ribbon

Public Class FilterEditor

    Private _defaultExpression As Expression

    Public Sub New(grid As C1FlexGrid)
        InitializeComponent()
        C1FilterEditor1.DataSource = grid.DataSource
    End Sub

    Public Async Sub SetExpression(expression As Expression)
        C1FilterEditor1.SetExpression(expression)
        Await C1FilterEditor1.ApplyFilterAsync()
    End Sub

    Public ReadOnly Property IsEmpty As Boolean
        Get
            Dim expression As CombinationExpression = C1FilterEditor1.GetExpression()
            Return expression Is Nothing Or expression.Expressions.Count = 0
        End Get
    End Property

    Private Sub FilterEditor_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        _defaultExpression = C1FilterEditor1.GetExpression()
    End Sub

    'Clear button clicked
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear filter
        C1FilterEditor1.ClearFilter()
    End Sub

    'Ok button clicked
    Private Async Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        'Apply filter and close form
        Await C1FilterEditor1.ApplyFilterAsync()
        DialogResult = DialogResult.OK
        Close()
    End Sub

    'Cancel button clicked
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Undo changes and close form
        SetExpression(_defaultExpression)
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class