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
		Me.c1GanttView1.Project.StartDate = Me.c1GanttView1.Tasks(1).Start.Value
	End Sub

	Private Sub btnZoomSelectedTask_Click(sender As Object, e As EventArgs)
		c1GanttView1.ZoomTask(c1GanttView1.SelectedTask)
	End Sub

	Private Sub btnZoomOut_Click(sender As Object, e As EventArgs)
		c1GanttView1.ZoomOut()
	End Sub

	Private Sub btnZoomIn_Click(sender As Object, e As EventArgs)
		c1GanttView1.ZoomIn()
	End Sub

	Private Sub btnZoomEntireProject_Click(sender As Object, e As EventArgs)
		c1GanttView1.ZoomEntireProject()
	End Sub

	Private Sub c1GanttView1_SelectedIndexChanged(sender As Object, e As EventArgs)
		If c1GanttView1.SelectedTask Is Nothing OrElse Not c1GanttView1.SelectedTask.Initialized Then
			btnZoomSelectedTask.Enabled = False
		Else
			btnZoomSelectedTask.Enabled = True
		End If
	End Sub
End Class
