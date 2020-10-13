
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports C1.Win.C1Chart

Public Class PieGrouper
	Private _root As List(Of PieGrouper) = Nothing
	Private _children As List(Of PieGrouper) = Nothing
	Private _parent As PieGrouper = Nothing

	Private _syncPoint As Integer = -1
	Private _syncValue As Single = 0.0F
	Private _syncColor As Color = Color.Empty

	Private _name As String = String.Empty
	Private _value As Single = 0.0F
	Private _color As Color = Color.Empty

	Private msgs() As String = { _
	   "All leaf nodes must be at the same depth.", _
	   "A leaf node cannot have children.", _
	   "An intermediate node cannot be added to a node with child leaf nodes", _
	   "A leaf node cannot be added to a node with child intermediate nodes", _
	   "A root node cannot be added to a child node.", _
	   "Only a populated root node can be synced and used for populating the ChartDataSeriesCollection." _
	}

	Private Function makeException(ByVal name As String, ByVal code As Integer) As Exception
		Dim e As New Exception(msgs(code))
		e.Data.Add("code", code)
		e.Data.Add("name", name)
		Return e
	End Function 'makeException

	Private Sub setDepth()
		Dim depth As Integer = 0
		Dim ps As PieGrouper = Me
		ps._syncPoint = 0
		While Not (ps._parent Is Nothing)
			ps = ps._parent
			depth += 1
			If ps._syncPoint < 0 Then
				ps._syncPoint = depth
			End If
		End While
		If ps._syncPoint <> depth Then
			Throw makeException(Nothing, 0)
		End If
	End Sub	'setDepth

	Private Sub reset()
		_syncValue = 0.0F
		_syncColor = Color.Empty

		If Not (_root Is Nothing) Then
			Dim pg As PieGrouper
			For Each pg In _root
				pg.reset()
			Next pg
		End If
		If Not (_children Is Nothing) Then
			Dim pg As PieGrouper
			For Each pg In _children
				pg.reset()
			Next pg
		End If
	End Sub	'reset

	Private Function addChild(ByRef sliceList As List(Of PieGrouper), ByVal pieSlice As PieGrouper) As PieGrouper
		If sliceList Is Nothing Then
			sliceList = New List(Of PieGrouper)()
		End If

		pieSlice._parent = Me
		sliceList.Add(pieSlice)

		Return pieSlice
	End Function

	Private Function initChild(ByVal name As String, ByVal value As Single, ByVal color As Color) As PieGrouper
		Dim ps As New PieGrouper()
		ps._name = name
		ps._value = value
		ps._color = color
		ps._parent = Me
		Return ps
	End Function

	Private Function AddChild(ByVal pieSlice As PieGrouper) As PieGrouper
		If Me._value <> 0.0F Then
			Throw makeException(pieSlice._name, 1)
		End If
		If Not (Me._children Is Nothing) AndAlso Me._children.Count > 0 Then
			Dim childValue As Single = Me._children(0)._value
			If childValue = 0 <> (pieSlice._value = 0) Then
				If childValue <> 0 Then
					Throw makeException(pieSlice._name, 2)
				Else
					Throw makeException(pieSlice._name, 3)
				End If
			End If
		End If
		Return AddChild(_children, pieSlice)
	End Function

	'/ <summary>
	'/ Adds a leaf node with an explicit value and explicit color.
	'/ A leaf node cannot have children.  Use Color.Transparent
	'/ to inherit the parent node color.
	'/ </summary>
	'/ <param name="name"></param>
	'/ <param name="value"></param>
	'/ <param name="color"></param>
	'/ <returns></returns>
	Public Sub AddLeaf(ByVal name As String, ByVal value As Single, ByVal color As Color)
		If value = 0.0F Then
			Return
		End If
		Dim ps As PieGrouper = addChild(initChild(name, value, color))
		ps.setDepth()
	End Sub

	'/ <summary>
	'/ Adds a leaf node with a value and uniquely generated color.
	'/ A leaf node cannot have children.
	'/ </summary>
	'/ <param name="name"></param>
	'/ <param name="value"></param>
	'/ <returns></returns>
	Public Sub AddLeaf(ByVal name As String, ByVal value As Single)
		AddLeaf(name, value, Color.Empty)
	End Sub

	'/ <summary>
	'/ Adds an intermediate node with an explicit color.  An intermediate node
	'/ is valued as the sum of its immediate children.  Use Color.Transparent
	'/ to inherit the parent node color.
	'/ </summary>
	'/ <param name="name"></param>
	'/ <param name="color"></param>
	'/ <returns></returns>
	Public Function AddIntermediate(ByVal name As String, ByVal color As Color) As PieGrouper
		Return addChild(initChild(name, 0.0F, color))
	End Function

	'/ <summary>
	'/ Adds an intermediate node with a uniquely generated color.  An intermediate
	'/ node is valued as the sum of its immediate children.
	'/ </summary>
	'/ <param name="name"></param>
	'/ <returns></returns>
	Public Function AddIntermediate(ByVal name As String) As PieGrouper
		Return AddIntermediate(name, Color.Empty)
	End Function

	'/ <summary>
	'/ Adds a root node with an explicit color.  A root node is valued as
	'/ the sum of its immediate children.
	'/ </summary>
	'/ <param name="name"></param>
	'/ <param name="color"></param>
	'/ <returns></returns>
	Public Function AddRoot(ByVal name As String, ByVal color As Color) As PieGrouper
		If Not (Me._parent Is Nothing) Then
			Throw makeException(name, 4)
		End If
		Return addChild(_root, initChild(name, 0.0F, color))
	End Function

	'/ <summary>
	'/ Add a root node with a uniquely generated color.  A root node is
	'/ valued as the sum of its immediate children.
	'/ </summary>
	'/ <param name="name"></param>
	'/ <returns></returns>
	Public Function AddRoot(ByVal name As String) As PieGrouper
		Return AddRoot(name, Color.Empty)
	End Function

	Private Sub syncSubnodes(ByVal node As PieGrouper, ByVal pointLists() As List(Of PieGrouper), ByRef seriesCount As Integer)
		If Not (node Is Nothing) Then
			If Not (node._children Is Nothing) AndAlso node._children.Count > 0 Then
				' an intermediate node
				Dim ps As PieGrouper
				For Each ps In node._children
					If ps._color = Color.Transparent AndAlso node._syncColor <> Color.Empty Then
						ps._syncColor = node._syncColor
					Else
						ps._syncColor = ps._color
					End If
					syncSubnodes(ps, pointLists, seriesCount)
					node._syncValue += ps._syncValue
				Next ps
			Else
				' an leaf node
				node._syncValue = node._value
			End If
			If node._syncValue <> 0.0F Then
				seriesCount += 1

				Dim point As Integer = node._syncPoint
				If pointLists(point) Is Nothing Then
					pointLists(point) = New List(Of PieGrouper)()
				End If
				pointLists(point).Add(node)
			End If
		End If
	End Sub

	Private Sub syncNodes(ByVal pointLists() As List(Of PieGrouper))
		If Me._root Is Nothing Then
			Throw makeException(Nothing, 5)
		End If
		reset()

		Dim seriesCount As Integer = 0

		Dim root As PieGrouper
		For Each root In _root
			root._syncColor = root._color
			syncSubnodes(root, pointLists, seriesCount)
		Next root
	End Sub

	Public Sub AddToChartDataSeriesCollection(ByVal ascending As Boolean, ByVal cdsc As ChartDataSeriesCollection)
		AddToChartDataSeriesCollection(ascending, cdsc, Nothing)
	End Sub

	'/ <summary>
	'/ Using the data structures created through the use of AddRoot, AddIntermediate and AddLeaf
	'/ methods, populates the specified ChartDataSeriesCollection for a stacked Pie chart with
	'/ segments.
	'/ </summary>
	'/ <param name="ascending"></param>
	'/ <param name="cdsc"></param>
	'/ <param name="dataLabelText"></param>
	Public Sub AddToChartDataSeriesCollection(ByVal ascending As Boolean, ByVal cdsc As ChartDataSeriesCollection, ByVal dataLabelText As String)
		Dim pointCount As Integer = _syncPoint
		Dim pointLists() As List(Of PieGrouper)
		pointLists = Array.CreateInstance(GetType(List(Of PieGrouper)), pointCount)
		syncNodes(pointLists)
		cdsc.Clear()

		Dim pointArray(pointCount - 1) As Single
		pointArray.Initialize()

		If dataLabelText Is Nothing Then
			dataLabelText = "{#TEXT}" + ControlChars.Cr + ControlChars.Lf + "{#YVAL} ({%YVAL:0.00%})"
		End If
		Dim i As Integer
		For i = 0 To pointCount - 1
			Dim j As Integer
			If ascending Then
				j = i
			Else
				j = pointCount - 1 - i
			End If
			Dim pointList As List(Of PieGrouper) = pointLists(j)
			Dim ps As PieGrouper
			For Each ps In pointList
				Dim cds As ChartDataSeries = cdsc.AddNewSeries()
				cds.Label = ps._name
				If ps._syncColor <> Color.Empty Then
					If ps._syncColor = Color.Transparent Then
						Dim ps1 As PieGrouper = ps
						While Not (ps1 Is Nothing) AndAlso ps1._syncColor = Color.Transparent
							ps1 = ps1._parent
						End While
						If Not (ps1 Is Nothing) AndAlso ps1._syncColor <> Color.Transparent Then
							If ps1._syncColor = Color.Empty Then
								ps1._syncColor = cds.FillStyle.Color1
							End If
							ps._syncColor = ps1._syncColor

							ps1 = ps
							While Not (ps1 Is Nothing) AndAlso ps1._syncColor = Color.Transparent
								ps1._syncColor = ps._syncColor
								ps1 = ps1._parent
							End While
						End If
					End If
					cds.FillStyle.Color1 = ps._syncColor
				Else
					ps._syncColor = cds.FillStyle.Color1
				End If

				pointArray(i) = ps._syncValue
				cds.Y.CopyDataIn(pointArray)

				cds.DataLabel.Compass = LabelCompassEnum.RadialText
				cds.DataLabel.Offset = -5
				cds.DataLabel.Text = dataLabelText
				cds.DataLabel.Visible = True

				cds.TooltipText = cds.DataLabel.Text
			Next ps
			pointArray(i) = 0.0F
		Next i
	End Sub
End Class
