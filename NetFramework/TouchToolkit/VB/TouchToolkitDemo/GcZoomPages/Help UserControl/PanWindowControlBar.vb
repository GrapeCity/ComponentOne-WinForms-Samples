Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace C1ZoomPages.Help_Forms
	Public Partial Class ControlBarUserControl01
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(sender As Object, e As EventArgs)
			Me.gcZoomCommandProvider1.OwnerForm.Close()
		End Sub
	End Class
End Namespace
