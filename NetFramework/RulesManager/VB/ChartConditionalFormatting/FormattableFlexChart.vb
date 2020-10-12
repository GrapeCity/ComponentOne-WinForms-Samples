Imports System.Collections.Specialized
Imports System.ComponentModel
Imports C1.Chart
Imports C1.Win.Chart
Imports C1.Win.CoditionalFormatting

Public Class FormattableFlexChart
    Inherits FlexChart
    Implements IFormattableView

    Private style As IItemStyle
    Public Event DataChanged As ListChangedEventHandler Implements IFormattableView.DataChanged
    Public Event ItemFormatting As EventHandler(Of ItemFormattingEventArgs) Implements IFormattableView.ItemFormatting

    Private Function GetFieldNames() As IEnumerable(Of String) Implements IFormattableView.GetFieldNames
        Return Series.[Select](Function(s) s.Name)
    End Function

    Private Function GetItemCount() As Integer Implements IFormattableView.GetItemCount
        Dim count As Integer = 0

        For Each serie In Series
            Dim values = serie.GetValues(0)

            If values IsNot Nothing Then
                count = Math.Max(count, values.Count())
            End If
        Next

        Return count
    End Function

    Private Function GetValue(item As Integer, field As String) As Object Implements IFormattableView.GetValue
        Dim matchedSeries = Series.Where(Function(s) s.Name = field)

        If matchedSeries IsNot Nothing AndAlso matchedSeries.Count() > 0 Then
            Dim values = (CType(matchedSeries.First(), ISeries)).GetValues(0)

            If values IsNot Nothing AndAlso values.Length > item AndAlso item >= 0 Then
                Return values(item)
            End If
        End If

        Return Nothing
    End Function

    Public Sub UpdateView() Implements IFormattableView.UpdateView
        Invalidate()
    End Sub

    Protected Overrides Sub Series_CollectionChanged(ByVal sender As Object, ByVal e As NotifyCollectionChangedEventArgs)
        Select Case e.Action
            Case NotifyCollectionChangedAction.Add
                Attach(e.NewItems)
            Case NotifyCollectionChangedAction.Move
            Case NotifyCollectionChangedAction.Remove
                Detach(e.OldItems)
            Case NotifyCollectionChangedAction.Replace
                Detach(e.OldItems)
                Attach(e.NewItems)
            Case NotifyCollectionChangedAction.Reset
                Detach(e.OldItems)
        End Select

        MyBase.Series_CollectionChanged(sender, e)
    End Sub

    Public Sub DataSourceChanged(ByVal e As ListChangedEventArgs)
        RaiseEvent DataChanged(Me, e)
    End Sub

    Private Sub Attach(ByVal objs As IEnumerable)
        If objs IsNot Nothing Then

            For Each item In objs
                Attach(item)
            Next
        End If
    End Sub

    Private Sub Detach(ByVal objs As IEnumerable)
        If objs IsNot Nothing Then

            For Each item In objs
                Detach(item)
            Next
        End If
    End Sub

    Private Sub Attach(ByVal obj As Object)
        Dim series = TryCast(obj, Series)

        If series IsNot Nothing Then
            AddHandler series.SymbolRendering, AddressOf OnSeriesSymbolRendering
            AddHandler series.SymbolRendered, AddressOf OnSeriesSymbolRendered
        End If
    End Sub

    Private Sub Detach(ByVal obj As Object)
        Dim series = TryCast(obj, Series)

        If series IsNot Nothing Then
            RemoveHandler series.SymbolRendering, AddressOf OnSeriesSymbolRendering
            RemoveHandler series.SymbolRendered, AddressOf OnSeriesSymbolRendered
        End If
    End Sub

    Private Sub OnSeriesSymbolRendering(ByVal sender As Object, ByVal e As RenderSymbolEventArgs)
        If e.Series Is Nothing AndAlso e.Series.Name Is Nothing Then
            Return
        End If

        Dim args = New ItemFormattingEventArgs(e.Index, e.Series.Name)
        RaiseEvent ItemFormatting(Me, args)
        style = args.Style

        If style IsNot Nothing Then
            Dim backColor = style.BackColor

            If Not backColor.IsEmpty Then
                e.Engine.SetFill(backColor.ToArgb())
            End If

            Dim borderColor = args.Style.BorderColor

            If Not borderColor.IsEmpty Then
                e.Engine.SetStroke(borderColor.ToArgb())
            End If
        End If
    End Sub

    Private Sub OnSeriesSymbolRendered(ByVal sender As Object, ByVal e As RenderSymbolEventArgs)
        If style IsNot Nothing Then
            Dim icon = style.Icon

            If icon IsNot Nothing Then
                e.Engine.DrawImage(icon, e.Point.X - icon.Width * 0.5, e.Point.Y, icon.Width, icon.Height)
            End If
        End If
    End Sub

End Class

