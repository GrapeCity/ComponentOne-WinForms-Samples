Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace TouchEvent
	Public Partial Class TouchEventListener
		Inherits DemoBase
		#Region "Fileds"


		Private eventNames As String() = New String() {"ManipulationStarting", "ManipulationStarted", "ManipulationDelta", "ManipulationInertiaStarting", "ManipulationCompleted", "Tapped", _
			"DoubleTapped", "Holding", "RightTapped", "PointerCanceled", "PointerCaptureLost", "PointerEntered", _
			"PointerExited", "PointerMoved", "PointerPressed", "PointerReleased"}



		Private parameters As String() = New String() {"ManipulationStartingEventArgs", "ManipulationStartedEventArgs", "ManipulationDeltaEventArgs", "ManipulationInertiaStartingEventArgs", "ManipulationCompletedEventArgs", "TappedEventArgs", _
			"DoubleTappedEventArgs", "HoldingEventArgs", "RightTappedEventArgs", "PointerEventArgs", "PointerEventArgs", "PointerEventArgs", _
			"PointerEventArgs", "PointerEventArgs", "PointerEventArgs", "PointerEventArgs"}

		#End Region

		#Region "Init"

		Public Sub New()
			InitializeComponent()

			Me.Title = "Touch Event Listener"
			Me.Description = "In this page you can listen all(or individual) events of C1TouchEventProvider." & vbCr & vbLf & "  - Touch in the specified rectangle, selected event logs will be listed."

			dataGridView1.RowCount = 16
			For i As Integer = 0 To dataGridView1.RowCount - 1
				dataGridView1.Rows(i).Height = 30
				dataGridView1(0, i).Value = i < 5
				dataGridView1(1, i).Value = eventNames(i)
				dataGridView1(2, i).Value = parameters(i)
			Next
			dataGridView1.Columns(1).[ReadOnly] = True
			dataGridView1.Columns(2).[ReadOnly] = True

			AddHandler gcTouchEventProvider1.DoubleTapped, AddressOf gcTouchEventProvider1_DoubleTapped
			AddHandler gcTouchEventProvider1.Holding, AddressOf gcTouchEventProvider1_Holding
			AddHandler gcTouchEventProvider1.PointerCanceled, AddressOf gcTouchEventProvider1_PointerCanceled
			AddHandler gcTouchEventProvider1.PointerCaptureLost, AddressOf gcTouchEventProvider1_PointerCaptureLost
			AddHandler gcTouchEventProvider1.PointerEntered, AddressOf gcTouchEventProvider1_PointerEntered
			AddHandler gcTouchEventProvider1.PointerExited, AddressOf gcTouchEventProvider1_PointerExited
			AddHandler gcTouchEventProvider1.PointerMoved, AddressOf gcTouchEventProvider1_PointerMoved
			AddHandler gcTouchEventProvider1.PointerPressed, AddressOf gcTouchEventProvider1_PointerPressed
			AddHandler gcTouchEventProvider1.PointerReleased, AddressOf gcTouchEventProvider1_PointerReleased
			AddHandler gcTouchEventProvider1.RightTapped, AddressOf gcTouchEventProvider1_RightTapped
			AddHandler gcTouchEventProvider1.Tapped, AddressOf gcTouchEventProvider1_Tapped
			AddHandler gcTouchEventProvider1.ManipulationStarting, AddressOf gcTouchEventProvider1_ManipulationStarting
			AddHandler gcTouchEventProvider1.ManipulationStarted, AddressOf gcTouchEventProvider1_ManipulationStarted
			AddHandler gcTouchEventProvider1.ManipulationDelta, AddressOf gcTouchEventProvider1_ManipulationDelta
			AddHandler gcTouchEventProvider1.ManipulationInertiaStarting, AddressOf gcTouchEventProvider1_ManipulationInertiaStarting
			AddHandler gcTouchEventProvider1.ManipulationCompleted, AddressOf gcTouchEventProvider1_ManipulationCompleted

			AddHandler selectAllButton.Click, AddressOf selectAllButton_Click
			AddHandler manipulationButton.Click, AddressOf manipulationButton_Click
			AddHandler pointerButton.Click, AddressOf pointerButton_Click
			AddHandler tapButton.Click, AddressOf tapButton_Click

			AddHandler clearButton.Click, AddressOf clearButton_Click
		End Sub

		#End Region

		#Region "Print and clear event information"

		Private id As Integer = 1

		Private Sub clearButton_Click(sender As Object, e As EventArgs)
			listBox1.Items.Clear()
			id = 1
		End Sub

		Private Sub gcTouchEventProvider1_ManipulationCompleted(sender As Object, e As C1.Win.TouchToolKit.ManipulationCompletedEventArgs)
			If CBool(dataGridView1(0, 4).Value) Then
				listBox1.Items.Add(id.ToString() + ":ManipulationCompleted")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_ManipulationInertiaStarting(sender As Object, e As C1.Win.TouchToolKit.ManipulationInertiaStartingEventArgs)
			If CBool(dataGridView1(0, 3).Value) Then
				listBox1.Items.Add(id.ToString() + ":ManipulationInertiaStarting")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_ManipulationDelta(sender As Object, e As C1.Win.TouchToolKit.ManipulationDeltaEventArgs)
			If CBool(dataGridView1(0, 2).Value) Then
				listBox1.Items.Add(id.ToString() + ":ManipulationDelta")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_ManipulationStarted(sender As Object, e As C1.Win.TouchToolKit.ManipulationStartedEventArgs)
			If CBool(dataGridView1(0, 1).Value) Then
				listBox1.Items.Add(id.ToString() + ":ManipulationStarted")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_ManipulationStarting(sender As Object, e As C1.Win.TouchToolKit.ManipulationStartingEventArgs)
			If CBool(dataGridView1(0, 0).Value) Then
				listBox1.Items.Add(id.ToString() + ":ManipulationStarting")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_PointerReleased(sender As Object, e As C1.Win.TouchToolKit.PointerEventArgs)
			If CBool(dataGridView1(0, 15).Value) Then
				listBox1.Items.Add(id.ToString() + ":PointerReleased")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_PointerPressed(sender As Object, e As C1.Win.TouchToolKit.PointerEventArgs)
			If CBool(dataGridView1(0, 14).Value) Then
				listBox1.Items.Add(id.ToString() + ":PointerPressed")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_PointerMoved(sender As Object, e As C1.Win.TouchToolKit.PointerEventArgs)
			If CBool(dataGridView1(0, 13).Value) Then
				listBox1.Items.Add(id.ToString() + ":PointerMoved")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_PointerExited(sender As Object, e As C1.Win.TouchToolKit.PointerEventArgs)
			If CBool(dataGridView1(0, 12).Value) Then
				listBox1.Items.Add(id.ToString() + ":PointerExited")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_PointerEntered(sender As Object, e As C1.Win.TouchToolKit.PointerEventArgs)
			If CBool(dataGridView1(0, 11).Value) Then
				listBox1.Items.Add(id.ToString() + ":PointerEntered")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_PointerCaptureLost(sender As Object, e As C1.Win.TouchToolKit.PointerEventArgs)
			If CBool(dataGridView1(0, 10).Value) Then
				listBox1.Items.Add(id.ToString() + ":PointerCaptureLost")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_PointerCanceled(sender As Object, e As C1.Win.TouchToolKit.PointerEventArgs)
			If CBool(dataGridView1(0, 9).Value) Then
				listBox1.Items.Add(id.ToString() + ":PointerCanceled")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_RightTapped(sender As Object, e As C1.Win.TouchToolKit.RightTappedEventArgs)
			If CBool(dataGridView1(0, 8).Value) Then
				listBox1.Items.Add(id.ToString() + ":RightTapped")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_Holding(sender As Object, e As C1.Win.TouchToolKit.HoldingEventArgs)
			If CBool(dataGridView1(0, 7).Value) Then
				listBox1.Items.Add(id.ToString() + ":Holding")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_DoubleTapped(sender As Object, e As C1.Win.TouchToolKit.DoubleTappedEventArgs)
			If CBool(dataGridView1(0, 6).Value) Then
				listBox1.Items.Add(id.ToString() + ":DoubleTapped")
				id += 1
			End If
		End Sub

		Private Sub gcTouchEventProvider1_Tapped(sender As Object, e As C1.Win.TouchToolKit.TappedEventArgs)
			If CBool(dataGridView1(0, 5).Value) Then
				listBox1.Items.Add(id.ToString() + ":Tapped")
				id += 1
			End If
		End Sub

		#End Region

		#Region "select events"

		Private Sub selectAllButton_Click(sender As Object, e As EventArgs)
			Dim allIsChecked As Boolean = True
			For i As Integer = 0 To 15
				If CBool(dataGridView1(0, i).Value) = False Then
					allIsChecked = False
					Exit For
				End If
			Next
			If allIsChecked Then
				For i As Integer = 0 To 15
					dataGridView1(0, i).Value = False
				Next
			Else
				For i As Integer = 0 To 15
					dataGridView1(0, i).Value = True
				Next
			End If
		End Sub

		Private Sub manipulationButton_Click(sender As Object, e As EventArgs)
			Dim manipulationIsChecked As Boolean = True
			For i As Integer = 0 To 4
				If CBool(dataGridView1(0, i).Value) = False Then
					manipulationIsChecked = False
					Exit For
				End If
			Next
			If manipulationIsChecked Then
				For i As Integer = 0 To 4
					dataGridView1(0, i).Value = False
				Next
			Else
				For i As Integer = 0 To 4
					dataGridView1(0, i).Value = True
				Next
			End If
		End Sub

		Private Sub pointerButton_Click(sender As Object, e As EventArgs)
			Dim pointerIsChecked As Boolean = True
			For i As Integer = 9 To 15
				If CBool(dataGridView1(0, i).Value) = False Then
					pointerIsChecked = False
					Exit For
				End If
			Next
			If pointerIsChecked Then
				For i As Integer = 9 To 15
					dataGridView1(0, i).Value = False
				Next
			Else
				For i As Integer = 9 To 15
					dataGridView1(0, i).Value = True
				Next
			End If
		End Sub

		Private Sub tapButton_Click(sender As Object, e As EventArgs)
			Dim tapIsChecked As Boolean = True
			For i As Integer = 5 To 8
				If CBool(dataGridView1(0, i).Value) = False Then
					tapIsChecked = False
					Exit For
				End If
			Next
			If tapIsChecked Then
				For i As Integer = 5 To 8
					dataGridView1(0, i).Value = False
				Next
			Else
				For i As Integer = 5 To 8
					dataGridView1(0, i).Value = True
				Next
			End If
		End Sub

		#End Region
	End Class
End Namespace
