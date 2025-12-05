Imports System.Text

Namespace CustomFilters
	Friend Class DateFilter
		Implements C1.Win.FlexGrid.IC1ColumnFilter
		'-------------------------------------------------------------------------------
		#Region "** fields"

		Private _min As Date = Date.MinValue
		Private _max As Date = Date.MaxValue

		#End Region

		'-------------------------------------------------------------------------------
		#Region "** object model"

		''' <summary>
		''' Gets or sets the minimum date required by the filter.
		''' </summary>
		Public Property Minimum() As Date
			Get
				Return _min
			End Get
			Set(ByVal value As Date)
				_min = value
			End Set
		End Property
		''' <summary>
		''' Gets or sets the maximum date required by the filter.
		''' </summary>
		Public Property Maximum() As Date
			Get
				Return _max
			End Get
			Set(ByVal value As Date)
				_max = value
			End Set
		End Property

		#End Region

		'-------------------------------------------------------------------------------
		#Region "** IC1ColumnFilter Members"

		' filter is active if range doesn't cover all represetabla dates.
		Public ReadOnly Property IsActive() As Boolean Implements C1.Win.FlexGrid.IC1ColumnFilter.IsActive
			Get
                Return _min <> Date.MinValue OrElse _max <> Date.MaxValue
			End Get
		End Property

		' reset filter.
		Public Sub Reset() Implements C1.Win.FlexGrid.IC1ColumnFilter.Reset
			_min = Date.MinValue
			_max = Date.MaxValue
		End Sub

		' apply filter to a given date
		Public Function Apply(ByVal value As Object) As Boolean Implements C1.Win.FlexGrid.IC1ColumnFilter.Apply
			Dim dt = CDate(value)
			Return dt >= _min AndAlso dt <= _max
		End Function

		' return editor control for this filter
		Public Function GetEditor() As C1.Win.FlexGrid.IC1ColumnFilterEditor Implements C1.Win.FlexGrid.IC1ColumnFilter.GetEditor
			Return New DateFilterEditor()
		End Function

		#End Region
	End Class
End Namespace
