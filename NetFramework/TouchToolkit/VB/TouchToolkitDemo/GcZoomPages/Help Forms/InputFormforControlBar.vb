Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace C1ZoomPages
	Public Partial Class InputFormforControlBar
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Protected Overrides Sub OnLoad(e As EventArgs)
			MyBase.OnLoad(e)
			Me.gcZoom1.ControlBars(0).Position = New Point(Me.Width, 0)
		End Sub
	End Class
End Namespace
