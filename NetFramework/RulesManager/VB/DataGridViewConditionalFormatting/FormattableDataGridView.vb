Imports System.ComponentModel
Imports C1.Win.CoditionalFormatting

Public Class FormattableDataGridView
    Inherits DataGridView
    Implements IFormattableView

    Public Event DataChanged As ListChangedEventHandler Implements IFormattableView.DataChanged
    Public Event ItemFormatting As EventHandler(Of ItemFormattingEventArgs) Implements IFormattableView.ItemFormatting

    Private Function GetFieldNames() As IEnumerable(Of String) Implements IFormattableView.GetFieldNames
        Dim fields = New List(Of String)()

        For Each column In Columns
            Dim name = (TryCast(column, DataGridViewColumn))?.DataPropertyName

            If Not String.IsNullOrEmpty(name) Then
                fields.Add(name)
            End If
        Next

        Return fields
    End Function

    Private Function GetItemCount() As Integer Implements IFormattableView.GetItemCount
        Return Rows.Count
    End Function

    Private Function GetValue(row As Integer, col As String) As Object Implements IFormattableView.GetValue
        Return Me(col, row).Value
    End Function

    Protected Overrides Sub OnDataBindingComplete(ByVal e As DataGridViewBindingCompleteEventArgs)
        MyBase.OnDataBindingComplete(e)
        RaiseEvent DataChanged(Me, New ListChangedEventArgs(ListChangedType.Reset, 0))
    End Sub

    Protected Overrides Sub OnCellPainting(ByVal e As DataGridViewCellPaintingEventArgs)
        Dim columnIndex = e.ColumnIndex
        Dim rowIndex = e.RowIndex

        If columnIndex >= 0 AndAlso rowIndex >= 0 Then
            Dim ifea = New ItemFormattingEventArgs(rowIndex, Columns(columnIndex).DataPropertyName)
            RaiseEvent ItemFormatting(Me, ifea)
            Dim ruleStyle = ifea?.Style

            If ruleStyle IsNot Nothing Then
                Dim cellStyle = e.CellStyle
                Dim backColor = ruleStyle.BackColor

                If Not backColor.IsEmpty Then
                    cellStyle.BackColor = backColor
                End If

                Dim foreColor = ruleStyle.ForeColor

                If Not foreColor.IsEmpty Then
                    cellStyle.ForeColor = foreColor
                End If

                Dim fontStyle = ruleStyle.FontStyle

                If cellStyle.Font.Style <> fontStyle AndAlso fontStyle <> FontStyle.Regular Then
                    cellStyle.Font = New Font(cellStyle.Font, fontStyle)
                End If
            End If
        End If

        MyBase.OnCellPainting(e)
    End Sub

    Public Sub UpdateView() Implements IFormattableView.UpdateView
        Invalidate()
    End Sub

End Class
