Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports TouchToolKitDemo.C1ZoomPages.Help_Forms

Namespace C1ZoomPages
	Public Partial Class ShowControlDemo
		Inherits DemoBase
		Public Sub New()
			InitializeComponent()
			InitializeDemo()
		End Sub

		Private Sub InitializeDemo()
			Me.Title = "Show Control"
			Me.Description = "When AutoShowControl property is true, C1Zoom will try to scroll the from to show the focused control."
		End Sub

		Private Sub formButton_Click(sender As Object, e As EventArgs)
			Using form As Form = New ShowControlForm()
					' The _gcZoom will auto detach when the Form dispose.
					'_gcZoom.SetEnabled(form, false);
				form.ShowDialog(Me)
			End Using
		End Sub
	End Class
End Namespace
