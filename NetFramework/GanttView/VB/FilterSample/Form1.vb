Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports C1.Win.GanttView

Public Partial Class Form1
	Inherits Form
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub btnMissNaming_Click(sender As Object, e As EventArgs)
		Dim filter As New AdvancedFilter()

		Dim condition As New ConditionTaskFilter()
		condition.FilterField = FilterField.Name
		condition.TestOperator = TestOperators.Equal
		filter.Conditions.Add(condition)

		ganttView.ApplyFilter(filter)
	End Sub

	Private Sub btnMissingResource_Click(sender As Object, e As EventArgs)
		' Filter the non-summary tasks and not milestone that're missing resource
		Dim advancedFilter As New AdvancedFilter()

		Dim summaryCondition As New ConditionTaskFilter()
		summaryCondition.FilterField = FilterField.Summary
		summaryCondition.TestOperator = TestOperators.Equal
		summaryCondition.FilterValue = False
		advancedFilter.Conditions.Add(summaryCondition)

		Dim milestoneCondition As New ConditionTaskFilter()
		milestoneCondition.FilterField = FilterField.Milestone
		milestoneCondition.TestOperator = TestOperators.Equal
		milestoneCondition.FilterValue = False
		advancedFilter.Conditions.Add(milestoneCondition)

		Dim resourceCondition As New ConditionTaskFilter()
		resourceCondition.FilterField = FilterField.ResourceNames
		resourceCondition.TestOperator = TestOperators.Equal
		resourceCondition.FilterValue = String.Empty
		advancedFilter.Conditions.Add(resourceCondition)

		ganttView.ApplyFilter(advancedFilter)
	End Sub

	Private Sub btnPerformWithin_Click(sender As Object, e As EventArgs)
		Dim filter As New AdvancedFilter()

		' Filter the tasks start from 2014/03/16...
		Dim startCondition As New ConditionTaskFilter()
		startCondition.FilterField = FilterField.Start
		startCondition.TestOperator = TestOperators.IsGreaterThanOrEqualTo
		startCondition.FilterValue = New DateTime(2014, 3, 16)
		filter.Conditions.Add(startCondition)

		' ...finish before or at 2014/04/01...
		Dim finishCondition As New ConditionTaskFilter()
		finishCondition.FilterField = FilterField.Finish
		finishCondition.TestOperator = TestOperators.IsLessThanOrEqualTo
		finishCondition.FilterValue = New DateTime(2014, 4, 1)
		filter.Conditions.Add(finishCondition)

		' ...and are not non-summary tasks.
		Dim summaryCondition As New ConditionTaskFilter()
		summaryCondition.FilterField = FilterField.Summary
		summaryCondition.TestOperator = TestOperators.Equal
		summaryCondition.FilterValue = False
		filter.Conditions.Add(summaryCondition)

		ganttView.ApplyFilter(filter)
	End Sub

	Private Sub btnHaveNotes_Click(sender As Object, e As EventArgs)
		Dim filter As New AdvancedFilter()

		Dim notesCondition As New ConditionTaskFilter()
		notesCondition.FilterField = FilterField.Notes
		notesCondition.TestOperator = TestOperators.DoesNotEqual
		filter.Conditions.Add(notesCondition)

		ganttView.ApplyFilter(filter)
	End Sub

	Private Sub btnLateOn_Click(sender As Object, e As EventArgs)
		Dim filter As New LateTasksFilter(New DateTime(2014, 3, 16))
		ganttView.ApplyFilter(filter)
	End Sub

	Private Sub btnCompletedByCarole_Click(sender As Object, e As EventArgs)
		Dim advancedFilter As New AdvancedFilter()

		' Filter the tasks that those ResourceNames contain "Carole Poland"...
		Dim resourceCondition As New ConditionTaskFilter()
		resourceCondition.FilterField = FilterField.ResourceNames
		resourceCondition.TestOperator = TestOperators.Contain
		resourceCondition.FilterValue = "Carole Poland"
		advancedFilter.Conditions.Add(resourceCondition)

		Dim percentCompleteCondition As New ConditionTaskFilter()
		percentCompleteCondition.FilterField = FilterField.PercentComplete
		percentCompleteCondition.TestOperator = TestOperators.Equal
        percentCompleteCondition.FilterValue = 100
        advancedFilter.Conditions.Add(percentCompleteCondition)

		ganttView.ApplyFilter(advancedFilter)
	End Sub

	Private Sub btnTobyOrToni_Click(sender As Object, e As EventArgs)
		Dim advancedFilter As New AdvancedFilter()

		' Filter the tasks that those ResourceNames contain "Toby Nixon"...
		Dim tobyCondition As New ConditionTaskFilter()
		tobyCondition.FilterField = FilterField.ResourceNames
		tobyCondition.TestOperator = TestOperators.Contain
		tobyCondition.FilterValue = "Toby Nixon"
		advancedFilter.Conditions.Add(tobyCondition)

		' ...and "Toni Poe".
		Dim sharonCondition As New ConditionTaskFilter()
		' Using Or combination operator.
		sharonCondition.CombinationOperator = CombinationOperator.[Or]
		sharonCondition.FilterField = FilterField.ResourceNames
		sharonCondition.TestOperator = TestOperators.Contain
		sharonCondition.FilterValue = "Toni Poe"
		advancedFilter.Conditions.Add(sharonCondition)

		ganttView.ApplyFilter(advancedFilter)
	End Sub

End Class
