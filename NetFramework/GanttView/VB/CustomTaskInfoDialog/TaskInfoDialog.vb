Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.GanttView

Public Partial Class TaskInfoDialog
	Inherits Form
	#Region "field"

	Private _ganttView As C1GanttView
	Private _selectedTask As Task

	#End Region

	#Region "ctors"

	Public Sub New()
		InitializeComponent()
	End Sub

	Public Sub New(ganttView As C1GanttView)
		Me.New()
		_ganttView = ganttView
	End Sub

	#End Region

	#Region "event handlers"

	Private Sub TaskInfoDialog_Load(sender As Object, e As EventArgs)
		Dim tasks As New List(Of Task)()
		Dim taskColl As TaskCollection = _ganttView.Tasks
		For Each task As Task In taskColl
			If Not String.IsNullOrEmpty(task.Name) Then
				tasks.Add(task)
			End If
		Next
		cbTask.DataSource = tasks
		cbTask.DisplayMember = "Name"
		cbTask.SelectedItem = _ganttView.SelectedTask
	End Sub

	Private Sub cbTask_SelectedIndexChanged(sender As Object, e As EventArgs)
		_selectedTask = DirectCast(cbTask.SelectedValue, Task)
		tbTaskName.Text = _selectedTask.Name
		tbResource.Text = _selectedTask.ResourceNames
		tbStart.Text = _selectedTask.Start.Value.ToShortDateString()
		tbDuration.Text = _selectedTask.GetDurationInDays() & " day(s)"
		tbPercentComplete.Text = (_selectedTask.PercentComplete * 100).ToString("0.00")
	End Sub

	#End Region

End Class
