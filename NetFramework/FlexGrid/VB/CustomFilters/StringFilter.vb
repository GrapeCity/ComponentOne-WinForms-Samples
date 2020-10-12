Imports System.Text

Namespace CustomFilters
	Friend Class StringFilter
		Implements C1.Win.C1FlexGrid.IC1ColumnFilter
		'-------------------------------------------------------------------------------
		#Region "** fields"

		Private _ranges As New List(Of Point)()

		#End Region

		'-------------------------------------------------------------------------------
		#Region "** object model"

		''' <summary>
		''' Gets the list of points that define the strings accepted by this fiter.
		''' </summary>
		Public ReadOnly Property Ranges() As List(Of Point)
			Get
				Return _ranges
			End Get
		End Property

		#End Region

		'-------------------------------------------------------------------------------
		#Region "** IC1ColumnFilter Members"

		' filter is active if range list is not empty.
		Public ReadOnly Property IsActive() As Boolean Implements C1.Win.C1FlexGrid.IC1ColumnFilter.IsActive
			Get
				Return _ranges.Count > 0
			End Get
		End Property

		' reset filter.
		Public Sub Reset() Implements C1.Win.C1FlexGrid.IC1ColumnFilter.Reset
			_ranges.Clear()
		End Sub

		' apply filter to a given date
		Public Function Apply(ByVal value As Object) As Boolean Implements C1.Win.C1FlexGrid.IC1ColumnFilter.Apply
			If value IsNot Nothing Then
				Dim s = value.ToString()
				If s.Length > 0 Then
                    Dim c As Integer = AscW(Char.ToUpperInvariant(s.Chars(0)))
					For Each cr In _ranges
                        If c >= AscW(Char.ToUpperInvariant(CChar(ChrW(cr.X)))) AndAlso c <= AscW(Char.ToUpperInvariant(CChar(ChrW(cr.Y)))) Then
                            Return True
                        End If
					Next cr
				End If
			End If
			Return False
		End Function

		' return editor control for this filter
		Public Function GetEditor() As C1.Win.C1FlexGrid.IC1ColumnFilterEditor Implements C1.Win.C1FlexGrid.IC1ColumnFilter.GetEditor
			Return New StringFilterEditor()
		End Function

		#End Region
	End Class
End Namespace
