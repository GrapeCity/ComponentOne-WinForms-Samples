Imports System.Windows.Forms

Imports C1.Win.C1TrueDBGrid

Public Class C1TrueDBGridOptions
	Private _trueGrid As C1TrueDBGrid

	Public Sub New(trueGrid As C1TrueDBGrid)
		_trueGrid = trueGrid
	End Sub

	Public ReadOnly Property TrueGrid() As C1TrueDBGrid
		Get
			Return _trueGrid
		End Get
	End Property

	Public Property DataView() As DataViewEnum
		Get
			Return _trueGrid.DataView
		End Get
		Set
			If DataView = value Then
				Return
			End If

			_trueGrid.DataView = value
			If value = DataViewEnum.GroupBy Then
				If _trueGrid.GroupedColumns.IndexOf(_trueGrid.Columns("Region")) = -1 Then
					_trueGrid.GroupedColumns.Add(_trueGrid.Columns("Region"))
				End If
				For i As Integer = 0 To _trueGrid.RowCount - 1
					_trueGrid.ExpandGroupRow(i)
				Next
			Else
				_trueGrid.GroupedColumns.Clear()
			End If
		End Set
	End Property

	Public Property ShowCaption() As Boolean
		Get
			Return Not String.IsNullOrEmpty(_trueGrid.Caption)
		End Get
		Set
			If ShowCaption = value Then
				Return
			End If

			If value Then
				_trueGrid.Caption = "C1TrueDBGrid caption"
			Else
				_trueGrid.Caption = String.Empty
			End If
		End Set
	End Property

	Public Property ShowFilterBar() As Boolean
		Get
			Return _trueGrid.FilterBar
		End Get
		Set
			_trueGrid.FilterBar = value
		End Set
	End Property

	Public Property ShowGroupByArea() As Boolean
		Get
			Return _trueGrid.GroupByAreaVisible
		End Get
		Set
			_trueGrid.GroupByAreaVisible = value
		End Set
	End Property
End Class
