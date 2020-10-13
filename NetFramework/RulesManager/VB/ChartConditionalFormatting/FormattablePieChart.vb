Imports System.Collections.Specialized
Imports System.ComponentModel
Imports C1.Chart
Imports C1.Win.Chart
Imports C1.Win.CoditionalFormatting

Public Class FormattablePieChart
    Inherits FlexPie
    Implements IFormattableView

    Private style As IItemStyle
    Public Event DataChanged As ListChangedEventHandler Implements IFormattableView.DataChanged
    Public Event ItemFormatting As EventHandler(Of ItemFormattingEventArgs) Implements IFormattableView.ItemFormatting

    Public Sub New()
        AddHandler SliceRendering, AddressOf FormattablePieChart_SliceRendering
        AddHandler SliceRendered, AddressOf FormattablePieChart_SliceRendered
    End Sub

    Private Function GetFieldNames() As IEnumerable(Of String) Implements IFormattableView.GetFieldNames
        Return New String() {Binding}
    End Function

    Private Function GetItemCount() As Integer Implements IFormattableView.GetItemCount
        Dim names = (CType(Me, IPieChart)).GetNames()

        If names Is Nothing Then
            Return 0
        End If

        Return names.Length
    End Function

    Private Function GetValue(item As Integer, field As String) As Object Implements IFormattableView.GetValue
        Return (CType(Me, IPieChart)).GetValues()(item)
    End Function

    Public Sub UpdateView() Implements IFormattableView.UpdateView
        Invalidate()
    End Sub

    Private Sub FormattablePieChart_SliceRendering(ByVal sender As Object, ByVal e As RenderSliceEventArgs)
        Dim pie = CType(Me, IPieChart)
        Dim args = New ItemFormattingEventArgs(e.Index, Binding)
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

    Private Sub FormattablePieChart_SliceRendered(ByVal sender As Object, ByVal e As RenderSliceEventArgs)
        If style IsNot Nothing Then
            Dim icon = style.Icon

            If icon IsNot Nothing Then
                Dim a2 = e.Angle + e.Sweep / 2.0F
                Dim x = e.CenterX + (Math.Cos(a2) * (e.InnerRadius + e.Radius) - icon.Width) * 0.5
                Dim y = e.CenterY + (Math.Sin(a2) * (e.InnerRadius + e.Radius) - icon.Height) * 0.5
                e.Engine.DrawImage(icon, x, y, icon.Width, icon.Height)
            End If
        End If
    End Sub

    Public Sub DataSourceChanged(ByVal e As ListChangedEventArgs)
        RaiseEvent DataChanged(Me, e)
    End Sub
End Class