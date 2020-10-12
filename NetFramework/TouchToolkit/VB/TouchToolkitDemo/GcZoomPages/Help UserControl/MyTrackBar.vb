Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace C1ZoomPages.Help_Forms
	Public Partial Class MyTrackBar
		Inherits UserControl
		Public Sub New()
			InitializeComponent()

			MaxValue = 4
			MinValue = 1

			AddHandler button2.LocationChanged, AddressOf button2_LocationChanged
			AddHandler button2.MouseMove, AddressOf button2_MouseMove
			AddHandler button2.MouseDown, AddressOf button2_MouseDown
			AddHandler button2.MouseUp, AddressOf button2_MouseUp
			AddHandler button2.MouseCaptureChanged, AddressOf button2_MouseCaptureChanged
		End Sub

		Private downLocation As System.Nullable(Of Integer) = Nothing
		Private startY As Integer = 0

		Private Sub button2_MouseCaptureChanged(sender As Object, e As EventArgs)
			downLocation = Nothing
		End Sub

		Private Sub button2_MouseUp(sender As Object, e As MouseEventArgs)
			downLocation = Nothing
		End Sub

		Private Sub button2_MouseDown(sender As Object, e As MouseEventArgs)
			downLocation = button2.PointToScreen(e.Location).Y
			startY = button2.Location.Y
		End Sub

		Private Sub button2_MouseMove(sender As Object, e As MouseEventArgs)
			Dim moveLocation = button2.PointToScreen(e.Location).Y

			If downLocation IsNot Nothing Then
				Dim y As Integer = startY + (moveLocation - downLocation.Value)
				If y < 0 Then
					y = 0
				End If
				If y > button1.Height - button2.Height Then
					y = button1.Height - button2.Height
				End If
				button2.Location = New Point(button2.Location.X, y)
			End If
		End Sub

		Private Sub button2_LocationChanged(sender As Object, e As EventArgs)
			OnValueChanged(e)
		End Sub

		<Bindable(True)> _
		Public Property Value() As Single
			Get
				Return CSng(button2.Location.Y) / (button1.Height - button2.Height) * (MaxValue - MinValue) + MinValue
			End Get
			Set
				button2.Location = New Point(button2.Location.X, CInt((button1.Height - button2.Height) * (value - MinValue) / (MaxValue - MinValue)))
			End Set
		End Property

		Public Property MaxValue() As Single
			Get
				Return m_MaxValue
			End Get
			Set
				m_MaxValue = Value
			End Set
		End Property
		Private m_MaxValue As Single
		Public Property MinValue() As Single
			Get
				Return m_MinValue
			End Get
			Set
				m_MinValue = Value
			End Set
		End Property
		Private m_MinValue As Single

		Public Event ValueChanged As EventHandler(Of EventArgs)

		Protected Overridable Sub OnValueChanged(e As EventArgs)
			RaiseEvent ValueChanged(Me, e)
		End Sub
	End Class
End Namespace
