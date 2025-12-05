Imports System.Text

Namespace CustomFilters
	Friend Class ColorFilter
		Implements C1.Win.FlexGrid.IC1ColumnFilter
		'-------------------------------------------------------------------------------
		#Region "** fields"

		Private _targetColor As Color = Color.Empty
		Private _tolerance As Integer = 100

		#End Region

		'-------------------------------------------------------------------------------
		#Region "** object model"

		''' <summary>
		''' Gets or sets the color the filter is looking for.
		''' </summary>
		Public Property TargetColor() As Color
			Get
				Return _targetColor
			End Get
			Set(ByVal value As Color)
				_targetColor = value
			End Set
		End Property
		''' <summary>
		''' Gets or sets the tolerance to use when matching the colors.
		''' </summary>
		Public Property Tolerance() As Integer
			Get
				Return _tolerance
			End Get
			Set(ByVal value As Integer)
				_tolerance = value
			End Set
		End Property

		#End Region

		'-------------------------------------------------------------------------------
		#Region "** IC1ColumnFilter Members"

		' filter is active if TargetColor is not empty.
		Public ReadOnly Property IsActive() As Boolean Implements C1.Win.FlexGrid.IC1ColumnFilter.IsActive
			Get
				Return TargetColor <> Color.Empty
			End Get
		End Property

		' reset filter by setting TargetColor to empty.
		Public Sub Reset() Implements C1.Win.FlexGrid.IC1ColumnFilter.Reset
			TargetColor = Color.Empty
		End Sub

		' apply filter to a given color
		Public Function Apply(ByVal value As Object) As Boolean Implements C1.Win.FlexGrid.IC1ColumnFilter.Apply
			Dim clr = CType(value, Color)
            Dim dr As Integer = Math.Abs(Convert.ToInt32(clr.R) - Convert.ToInt32(_targetColor.R))
            Dim dg As Integer = Math.Abs(Convert.ToInt32(clr.G) - Convert.ToInt32(_targetColor.G))
            Dim db As Integer = Math.Abs(Convert.ToInt32(clr.B) - Convert.ToInt32(_targetColor.B))
            Return dr + dg + db <= Tolerance
		End Function

		' return editor control for this filter
		Public Function GetEditor() As C1.Win.FlexGrid.IC1ColumnFilterEditor Implements C1.Win.FlexGrid.IC1ColumnFilter.GetEditor
			Return New ColorFilterEditor()
		End Function

		#End Region
	End Class
End Namespace
