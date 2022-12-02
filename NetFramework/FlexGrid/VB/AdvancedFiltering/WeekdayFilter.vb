Imports C1.Win.C1FlexGrid
Imports System

Namespace AdvancedFiltering
    Friend Class WeekdayFilter
        Implements IC1ColumnFilter
        Public Monday As Boolean = True
        Public Tuesday As Boolean = True
        Public Wednesday As Boolean = True
        Public Thursday As Boolean = True
        Public Friday As Boolean = True
        Public Saturday As Boolean = True
        Public Sunday As Boolean = True

        Public Function GetEditor() As IC1ColumnFilterEditor Implements IC1ColumnFilter.GetEditor
            Return New WeekdayFilterEditor()
        End Function

        ''' <summary>
        ''' Reset filter to default "no filter"
        ''' </summary>
        Public Sub Reset() Implements IC1ColumnFilter.Reset
            Monday = True
            Tuesday = True
            Wednesday = True
            Thursday = True
            Friday = True
            Saturday = True
            Sunday = True
        End Sub

        Public Function Apply(ByVal value As Object) As Boolean Implements IC1ColumnFilter.Apply
            Dim [date] = CDate(value)
            If [date].DayOfWeek = DayOfWeek.Monday AndAlso Monday Then
                Return True
            ElseIf [date].DayOfWeek = DayOfWeek.Tuesday AndAlso Tuesday Then
                Return True
            ElseIf [date].DayOfWeek = DayOfWeek.Wednesday AndAlso Wednesday Then
                Return True
            ElseIf [date].DayOfWeek = DayOfWeek.Thursday AndAlso Thursday Then
                Return True
            ElseIf [date].DayOfWeek = DayOfWeek.Friday AndAlso Friday Then
                Return True
            ElseIf [date].DayOfWeek = DayOfWeek.Saturday AndAlso Saturday Then
                Return True
            ElseIf [date].DayOfWeek = DayOfWeek.Sunday AndAlso Sunday Then
                Return True
            End If
            Return False
        End Function

        Public ReadOnly Property IsActive As Boolean Implements IC1ColumnFilter.IsActive
            Get
                Return Not Monday OrElse Not Tuesday OrElse Not Wednesday OrElse Not Thursday OrElse Not Friday OrElse Not Saturday OrElse Not Sunday
            End Get
        End Property
    End Class
End Namespace
