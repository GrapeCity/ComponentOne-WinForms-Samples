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

	#Region "Event handlers"

	Private Sub Form1_Load(sender As Object, e As EventArgs)
        Dim modelCount As Integer = c1GanttView1.GroupDefinition.Items.Count
		If modelCount = 0 Then
			comboGroupBy.SelectedIndex = 0
		ElseIf modelCount = 1 Then
            Dim groupModel As BaseGroup = c1GanttView1.GroupDefinition.Items(0)
			If TypeOf groupModel Is TaskModeGroup Then
				comboGroupBy.SelectedIndex = 1
			ElseIf TypeOf groupModel Is TaskCompleteGroup Then
				comboGroupBy.SelectedIndex = 2
			ElseIf TypeOf groupModel Is ConstraintTypeGroup Then
				comboGroupBy.SelectedIndex = 3
			ElseIf TypeOf groupModel Is DurationGroup Then
				comboGroupBy.SelectedIndex = 4
			ElseIf TypeOf groupModel Is MilestonesGroup Then
				comboGroupBy.SelectedIndex = 5
			ElseIf TypeOf groupModel Is ResourceGroup Then
				comboGroupBy.SelectedIndex = 6
			ElseIf TypeOf groupModel Is StatusGroup Then
				comboGroupBy.SelectedIndex = 7
			Else
				comboGroupBy.SelectedIndex = 8
			End If
		Else
			comboGroupBy.SelectedIndex = 8
		End If
        If c1GanttView1.GroupDefinition.Items.Count > 0 Then
            summaryGroupBox.Enabled = False
        End If
		chkShowProjectSummary.Checked = c1GanttView1.ShowProjectSummary
		chkMaintainHierarchy.Checked = c1GanttView1.GroupDefinition.MaintainHierarchy
		AddHandler comboGroupBy.SelectedIndexChanged, New EventHandler(AddressOf comboGroupBy_SelectedIndexChanged)
	End Sub

	Private Sub btnOutdent_Click(sender As Object, e As EventArgs)
		c1GanttView1.ClickButton(CommandButton.Outdent)
	End Sub

	Private Sub btnIndent_Click(sender As Object, e As EventArgs)
		c1GanttView1.ClickButton(CommandButton.Indent)
	End Sub

	Private Sub chkShowProjectSummary_CheckedChanged(sender As Object, e As EventArgs)
		c1GanttView1.ShowProjectSummary = chkShowProjectSummary.Checked
	End Sub

	Private Sub comboGroupBy_SelectedIndexChanged(sender As Object, e As EventArgs)
		Dim selectedText As String = DirectCast(comboGroupBy.SelectedItem, String)
		Select Case selectedText
			Case "No Group"
				c1GanttView1.ClearGroup()
				Exit Select
			Case "Task Mode"
				c1GanttView1.Group(New TaskModeGroup(True))
				Exit Select
			Case "Task Complete"
				c1GanttView1.Group(New TaskCompleteGroup(True))
				Exit Select
			Case "Constraint Type"
				c1GanttView1.Group(New ConstraintTypeGroup(True))
				Exit Select
			Case "Duration"
				c1GanttView1.Group(New DurationGroup(True))
				Exit Select
			Case "Milestones"
				c1GanttView1.Group(New MilestonesGroup(True))
				Exit Select
			Case "Resource"
				c1GanttView1.Group(New ResourceGroup(True))
				Exit Select
			Case "Status"
				If True Then
					Dim statusDate As DateTime = DateTime.Today
					If c1GanttView1.ProgressLine.StatusDate.HasValue Then
						statusDate = c1GanttView1.ProgressLine.StatusDate.Value
					End If
					c1GanttView1.Group(New StatusGroup(statusDate, True))
				End If
				Exit Select
			Case "Advance Group"
				c1GanttView1.ClickButton(CommandButton.Group)
				Exit Select
			Case Else
				Exit Select
		End Select
        If c1GanttView1.GroupDefinition.Items.Count = 0 Then
            comboGroupBy.SelectedIndex = 0
            summaryGroupBox.Enabled = True
            chkShowProjectSummary.Checked = c1GanttView1.ShowProjectSummary
        Else
            summaryGroupBox.Enabled = False
        End If
	End Sub

	Private Sub chkMaintainHierarchy_CheckedChanged(sender As Object, e As EventArgs)
		c1GanttView1.GroupDefinition.MaintainHierarchy = chkMaintainHierarchy.Checked
	End Sub

	Private Sub btnClearGroup_Click(sender As Object, e As EventArgs)
		c1GanttView1.ClearGroup()
	End Sub

	#End Region


End Class

