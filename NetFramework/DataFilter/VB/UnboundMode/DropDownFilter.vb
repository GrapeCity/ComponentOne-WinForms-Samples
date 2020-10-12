Imports C1.DataCollection
Imports C1.DataFilter
Imports C1.Win.DataFilter

Public Class DropDownFilter
    Inherits ToolStripDropDown

    Public Sub New()
        AutoClose = True
        AutoSize = True
        Margin = Padding.Empty
        Padding = Padding.Empty
        DataFilter = New C1DataFilter With {
            .AutoWidthMode = AutoWidthMode.Grow,
            .ShowClearFilterButtons = True,
            .ShowHeader = False
        }
        Dim host = New ToolStripControlHost(DataFilter) With {
            .Margin = Padding.Empty,
            .Padding = Padding.Empty,
            .AutoSize = True,
            .AutoToolTip = False
        }
        Items.Clear()
        Items.Add(host)
    End Sub

    Public Sub ShowFilter(ByVal propertyName As String, ByVal control As Control, ByVal location As Point)
        Dim isFound = False

        For Each Filter In DataFilter.Filters

            If Filter.PropertyName = propertyName Then
                Filter.Expanded = True
                isFound = True
            Else
                Filter.Expanded = False
            End If
        Next

        If isFound Then
            DataFilter.Height = GetPreferredSize(Size.Empty).Height
            Show(control, location)
        End If
    End Sub

    Public Sub AddFilter(ByVal filter As Filter)
        DataFilter.Filters.Add(filter)
    End Sub

    Public Sub ApplyFilter(ByVal dataSource As ISupportFiltering)
        dataSource.FilterAsync(DataFilter.GetFilterExpression())
    End Sub

    Public ReadOnly Property DataFilter As C1DataFilter

End Class
