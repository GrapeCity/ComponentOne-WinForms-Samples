Imports System.Collections.Generic
Imports System.Windows.Forms

Imports C1.Win.C1FlexGrid

Public Enum FlexViewModeEnum
	None
	Normal
	Tree
	Subtotals
End Enum

''' <summary>
''' Allows change view options of C1FlexGrid.
''' </summary>
Public Class C1FlexGridOptions
	Private _flexGrid As C1FlexGrid
	Private _viewMode As FlexViewModeEnum
	Private _subtotalsData As List(Of Subtot) = Nothing
	Private _bindingSource As BindingSource

	Public Sub New(flexGrid As C1FlexGrid)
		_flexGrid = flexGrid
		_bindingSource = DirectCast(flexGrid.DataSource, BindingSource)
	End Sub

	Private Function MakeSubtots() As List(Of Subtot)
		Dim subtots As New List(Of Subtot)()

		Dim rand As New Random()
		Const  numRows As Integer = 4
		Const  maxValue As Integer = 99
		For i As Integer = 0 To numRows - 1
			subtots.Add(New Subtot(String.Format("A{0}", rand.[Next](5)), String.Format("B{0}", rand.[Next](5)), String.Format("C{0}", rand.[Next](5)), String.Format("D{0}", rand.[Next](5)), String.Format("E{0}", rand.[Next](5)), String.Format("F{0}", rand.[Next](5)), _
				String.Format("G{0}", rand.[Next](5)), rand.[Next](maxValue)))
		Next

		subtots.Sort(Function(x, y) 
		Dim res As Integer = x.Level0.CompareTo(y.Level0)
		If res <> 0 Then
			Return res
		End If
		res = x.Level1.CompareTo(y.Level1)
		If res <> 0 Then
			Return res
		End If
		res = x.Level2.CompareTo(y.Level2)
		If res <> 0 Then
			Return res
		End If
		res = x.Level3.CompareTo(y.Level3)
		If res <> 0 Then
			Return res
		End If
		res = x.Level4.CompareTo(y.Level4)
		If res <> 0 Then
			Return res
		End If
		res = x.Level5.CompareTo(y.Level5)
		If res <> 0 Then
			Return res
		End If
		res = x.Level6.CompareTo(y.Level6)
		Return res

End Function)

		Return subtots
	End Function

	Private Sub BuildEmployeesTree()
		_bindingSource.Sort = "Country,City"
		_flexGrid.DataSource = _bindingSource
		Dim idxCountry As Integer = _flexGrid.Cols("Country").Index
		_flexGrid.Cols.Move(idxCountry, 1)
		Dim idxCity As Integer = _flexGrid.Cols("City").Index
		_flexGrid.Cols.Move(idxCity, 2)
		_flexGrid.Cols("EmployeeID").Visible = False

		Dim lastCountry As String = ""
		Dim lastCity As String = ""
		For row As Integer = _flexGrid.Rows.Fixed To _flexGrid.Rows.Count - 1
			Dim country As String = TryCast(_flexGrid.GetData(row, "Country"), String)
			If country <> lastCountry Then
				lastCountry = country
				lastCity = ""
				Dim node = _flexGrid.Rows.InsertNode(System.Math.Max(System.Threading.Interlocked.Increment(row),row - 1), 0)
				node.Row(2) = String.Format("Country: {0}", country)
			End If
			Dim city As String = TryCast(_flexGrid.GetData(row, "City"), String)
			If city <> lastCity Then
				lastCity = city
				Dim node = _flexGrid.Rows.InsertNode(System.Math.Max(System.Threading.Interlocked.Increment(row),row - 1), 1)
				node.Row(2) = String.Format("Country: {0}, city: {1}", country, city)
			End If
		Next
		_flexGrid.Tree.Column = 1
	End Sub

	Private Sub BindSubtots(subtots As List(Of Subtot))
		If subtots IsNot Nothing Then
			Me._flexGrid.DataSource = subtots
		End If

		Me._flexGrid.Tree.Column = 1
		Me._flexGrid.Subtotal(AggregateEnum.Sum, 0, 1, 1, 8, "Subtotal0")
		Me._flexGrid.Subtotal(AggregateEnum.Sum, 1, 1, 2, 8, "Subtotal1")
		Me._flexGrid.Subtotal(AggregateEnum.Sum, 2, 1, 3, 8, "Subtotal2")
		Me._flexGrid.Subtotal(AggregateEnum.Sum, 3, 1, 4, 8, "Subtotal3")
		Me._flexGrid.Subtotal(AggregateEnum.Sum, 4, 1, 5, 8, "Subtotal4")
		Me._flexGrid.Subtotal(AggregateEnum.Sum, 5, 1, 6, 8, "Subtotal5")
		Me._flexGrid.Subtotal(AggregateEnum.Sum, 6, 1, 7, 8, "Subtotal6")

		Me._flexGrid.Subtotal(AggregateEnum.Sum, -1, -1, -1, 8, "GrandTotal")
	End Sub

	Private Sub UpdateGrid()
		Select Case _viewMode
			Case FlexViewModeEnum.None
				Exit Select
			Case FlexViewModeEnum.Normal
				Exit Select
			Case FlexViewModeEnum.Tree
				Exit Select
			Case FlexViewModeEnum.Subtotals
				If _subtotalsData Is Nothing Then
					_subtotalsData = MakeSubtots()
					BindSubtots(_subtotalsData)
				Else
					BindSubtots(Nothing)
				End If
				Exit Select
			Case Else
				System.Diagnostics.Debug.Assert(False)
				Exit Select
		End Select
	End Sub

	Public ReadOnly Property FlexGrid() As C1FlexGrid
		Get
			Return _flexGrid
		End Get
	End Property

	Public Property ViewMode() As FlexViewModeEnum
		Get
			Return _viewMode
		End Get
		Set
			If value = _viewMode Then
				Return
			End If

			_viewMode = value
			_flexGrid.BeginUpdate()
			_flexGrid.DataSource = Nothing
			_flexGrid.Clear(ClearFlags.Content)
			Select Case _viewMode
				Case FlexViewModeEnum.Normal
					_flexGrid.DataSource = _bindingSource
					Exit Select
				Case FlexViewModeEnum.Tree
					BuildEmployeesTree()
					Exit Select
				Case FlexViewModeEnum.Subtotals
					If _subtotalsData Is Nothing Then
						_subtotalsData = MakeSubtots()
					End If
					BindSubtots(_subtotalsData)
					Exit Select
				Case Else
					System.Diagnostics.Debug.Assert(False)
					Exit Select
			End Select
			_flexGrid.AutoSizeCols()
			_flexGrid.AutoSizeRows()
			_flexGrid.EndUpdate()
		End Set
	End Property

	Public Property FrozenColCount() As Integer
		Get
			Return _flexGrid.Cols.Frozen
		End Get
		Set
			_flexGrid.Cols.Frozen = value
		End Set
	End Property

	Public Property FrozenRowCount() As Integer
		Get
			Return _flexGrid.Rows.Frozen
		End Get
		Set
			_flexGrid.Rows.Frozen = value
		End Set
	End Property

	Public Property SelectionMode() As SelectionModeEnum
		Get
			Return _flexGrid.SelectionMode
		End Get
		Set
			_flexGrid.SelectionMode = value
		End Set
	End Property

	Public Property FocusRect() As FocusRectEnum
		Get
			Return _flexGrid.FocusRect
		End Get
		Set
			_flexGrid.FocusRect = value
		End Set
	End Property

	Public Property ShowCursor() As Boolean
		Get
			Return _flexGrid.ShowCursor
		End Get
		Set
			_flexGrid.ShowCursor = value
		End Set
	End Property

	#Region "Nested types"
	Private Class Subtot
		Public Sub New(level0__1 As String, level1__2 As String, level2__3 As String, level3__4 As String, level4__5 As String, level5__6 As String, _
			level6__7 As String, value__8 As Integer)
			Level0 = level0__1
			Level1 = level1__2
			Level2 = level2__3
			Level3 = level3__4
			Level4 = level4__5
			Level5 = level5__6
			Level6 = level6__7
			Value = value__8
		End Sub

		Public Property Level0() As String
			Get
				Return m_Level0
			End Get
			Set
				m_Level0 = Value
			End Set
		End Property
		Private m_Level0 As String
		Public Property Level1() As String
			Get
				Return m_Level1
			End Get
			Set
				m_Level1 = Value
			End Set
		End Property
		Private m_Level1 As String
		Public Property Level2() As String
			Get
				Return m_Level2
			End Get
			Set
				m_Level2 = Value
			End Set
		End Property
		Private m_Level2 As String
		Public Property Level3() As String
			Get
				Return m_Level3
			End Get
			Set
				m_Level3 = Value
			End Set
		End Property
		Private m_Level3 As String
		Public Property Level4() As String
			Get
				Return m_Level4
			End Get
			Set
				m_Level4 = Value
			End Set
		End Property
		Private m_Level4 As String
		Public Property Level5() As String
			Get
				Return m_Level5
			End Get
			Set
				m_Level5 = Value
			End Set
		End Property
		Private m_Level5 As String
		Public Property Level6() As String
			Get
				Return m_Level6
			End Get
			Set
				m_Level6 = Value
			End Set
		End Property
		Private m_Level6 As String
		Public Property Value() As Integer
			Get
				Return m_Value
			End Get
			Set
				m_Value = Value
			End Set
		End Property
		Private m_Value As Integer
	End Class
	#End Region
End Class
