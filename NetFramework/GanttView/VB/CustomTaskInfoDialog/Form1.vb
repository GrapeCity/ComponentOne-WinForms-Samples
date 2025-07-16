Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub c1GanttView1_ShowDialog(sender As Object, e As C1.Win.GanttView.ShowDialogEventArgs)
		Dim dlg As New TaskInfoDialog(c1GanttView1)
		e.Dialog = dlg
	End Sub
End Class
