Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace C1ZoomPages.Help_Forms
	Public Partial Class KeyboadControlBar
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button_Click(sender As Object, e As EventArgs)
			SendKeys.Send(TryCast(sender, Button).Tag.ToString())
		End Sub

		Private oldSize As System.Nullable(Of Size) = Nothing
		Private Sub button13_Click(sender As Object, e As EventArgs)
			If oldSize Is Nothing Then
				oldSize = Me.Size
				Me.Size = TryCast(sender, Control).Size
			Else
				Me.Size = oldSize.Value
				oldSize = Nothing
			End If
		End Sub
	End Class
End Namespace
