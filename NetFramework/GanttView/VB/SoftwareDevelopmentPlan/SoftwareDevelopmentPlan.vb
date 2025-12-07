Imports C1.Win.GanttView
Imports C1.Win.Ribbon
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Public Partial Class SoftwareDevelopmentPlan
	Inherits C1RibbonForm
	Private _zoomfactorIsChanging As Boolean = False

	Public Sub New()
		InitializeComponent()

		rcbTimeline.Items.Add("15 Minutes")
		rcbTimeline.Items.Add("2 Hours")
		rcbTimeline.Items.Add("Quarter Days")
		rcbTimeline.Items.Add("Days")
		rcbTimeline.Items.Add("3 Days")
		rcbTimeline.Items.Add("7 Days")
		rcbTimeline.Items.Add("Months")
		rcbTimeline.Items.Add("Months")
		rcbTimeline.Items.Add("Quarters")
		rcbTimeline.Items.Add("Half-Years")
		Timescale_ZoomFactorChanged(Nothing, EventArgs.Empty)

		' Set current colors and add event handler 
		' for items in Colors menu at Ribbon's Formatting tab
		AddHandler rcpCellBorder.SelectedColorChanged, New EventHandler(AddressOf rcpCellBorder_SelectedColorChanged)
		rcpCellBorder.DefaultColor = ganttView.CellBorderColor

		AddHandler rcpEmptyAreaBack.SelectedColorChanged, New EventHandler(AddressOf rcpEmptyAreaBackground_SelectedColorChanged)
		rcpEmptyAreaBack.DefaultColor = ganttView.EmptyAreaBackColor

		AddHandler rcpFixedBackground.SelectedColorChanged, New EventHandler(AddressOf rcpFixedBackground_SelectedColorChanged)
		rcpFixedBackground.DefaultColor = ganttView.FixedBackColor

		AddHandler rcpFixedCellBorder.SelectedColorChanged, New EventHandler(AddressOf rcpFixedCellBorder_SelectedColorChanged)
		rcpFixedCellBorder.DefaultColor = ganttView.FixedCellBorderColor

		AddHandler rcpFixedForeground.SelectedColorChanged, New EventHandler(AddressOf rcpFixedForeground_SelectedColorChanged)
		rcpFixedForeground.DefaultColor = ganttView.FixedForeColor

		AddHandler rcpHightlightBackground.SelectedColorChanged, New EventHandler(AddressOf rcpHighlightBackground_SelectedColorChanged)
		rcpHightlightBackground.DefaultColor = ganttView.HighlightBackColor

		AddHandler rcpHightlightForeground.SelectedColorChanged, New EventHandler(AddressOf rcpHighlightForeground_SelectedColorChanged)
		rcpHightlightForeground.DefaultColor = ganttView.HighlightForeColor

		AddHandler rcpNonworkingTime.SelectedColorChanged, New EventHandler(AddressOf rcpNonworkingTime_SelectedColorChanged)
		rcpNonworkingTime.DefaultColor = ganttView.NonworkingTimeColor

		AddHandler rcpSplitter.SelectedColorChanged, New EventHandler(AddressOf rcpSplitter_SelectedColorChanged)
		rcpSplitter.DefaultColor = ganttView.SplitterColor

		AddHandler rcpStartFinishLine.SelectedColorChanged, New EventHandler(AddressOf rcpStartFinishLine_SelectedColorChanged)
		rcpStartFinishLine.DefaultColor = ganttView.StartFinishLineColor

		AddHandler rcpTodayLine.SelectedColorChanged, New EventHandler(AddressOf rcpTodayLine_SelectedColorChanged)
		rcpTodayLine.DefaultColor = ganttView.TodayLineColor

		fontPicker.SelectedIndex = fontPicker.Items.IndexOf(ganttView.Font.FontFamily.Name)
		rcbFontSize.Text = ganttView.Font.Size.ToString()

		rcpBackground.DefaultColor = ganttView.BackColor
		rcpForeground.DefaultColor = ganttView.ForeColor

		' Add common font sizes to fontSize combo box.
		For Each size As Integer In New Integer() {8, 9, 10, 11, 12, 14, _
			16, 18, 20, 22, 24, 26, _
			28, 36, 48, 72}
			rcbFontSize.Items.Add(New RibbonButton(size.ToString()))
		Next

		AddHandler rbQuit.Click, New EventHandler(AddressOf rbQuit_Click)

		rcbMaintainHierarchy.Checked = ganttView.GroupDefinition.MaintainHierarchy
		rcbShowRelatedSummaryRows.Checked = ganttView.FilterDefinition.ShowRelatedSummaryRows
		InitializeGroupComboBox()
		InitializeFilterComboBox()
		UpdateRibbonItemState()
	End Sub

	Protected Overrides Sub OnDeactivate(e As EventArgs)
		MyBase.OnDeactivate(e)

		' Sets left text at status bar as BUSY while some sub progress is processing.
		rlLeftStatus.Text = "BUSY"
	End Sub

	Protected Overrides Sub OnActivated(e As EventArgs)
		MyBase.OnActivated(e)

		' Sets left text at status bar as READY.
		rlLeftStatus.Text = "READY"
	End Sub

	Private Sub InitializeGroupComboBox()
		Dim groupDefCount As Integer = ganttView.GroupDefinition.Items.Count
		If groupDefCount = 0 Then
			rcbGroupBy.SelectedIndex = 0
		ElseIf groupDefCount = 1 Then
			Dim groupModel As BaseGroup = ganttView.GroupDefinition.Items(0)
			If TypeOf groupModel Is TaskModeGroup Then
				rcbGroupBy.SelectedIndex = 1
			ElseIf TypeOf groupModel Is TaskCompleteGroup Then
				rcbGroupBy.SelectedIndex = 2
			ElseIf TypeOf groupModel Is ConstraintTypeGroup Then
				rcbGroupBy.SelectedIndex = 3
			ElseIf TypeOf groupModel Is DurationGroup Then
				rcbGroupBy.SelectedIndex = 4
			ElseIf TypeOf groupModel Is MilestonesGroup Then
				rcbGroupBy.SelectedIndex = 5
			ElseIf TypeOf groupModel Is ResourceGroup Then
				rcbGroupBy.SelectedIndex = 6
			ElseIf TypeOf groupModel Is StatusGroup Then
				rcbGroupBy.SelectedIndex = 7
			Else
				rcbGroupBy.SelectedIndex = 8
			End If
		Else
			rcbGroupBy.SelectedIndex = 8
		End If
	End Sub

	Private Sub InitializeFilterComboBox()
		Dim currentFilter As BaseTaskFilter = ganttView.FilterDefinition.CurrentFilter
		Dim selectedIndex As Integer = -1
		If currentFilter Is Nothing Then
			selectedIndex = 0
		Else
			If TypeOf currentFilter Is CompletedTasksFilter Then
				selectedIndex = 1
			ElseIf TypeOf currentFilter Is DateRangeFilter Then
				selectedIndex = 2
			ElseIf TypeOf currentFilter Is IncompleteTasksFilter Then
				selectedIndex = 3
			ElseIf TypeOf currentFilter Is LateTasksFilter Then
				selectedIndex = 4
			ElseIf TypeOf currentFilter Is MilestoneTasksFilter Then
				selectedIndex = 5
			ElseIf TypeOf currentFilter Is SummaryTasksFilter Then
				selectedIndex = 6
			ElseIf TypeOf currentFilter Is DurationOnlyTasksFilter Then
				selectedIndex = 7
			ElseIf TypeOf currentFilter Is UsingResourceFilter Then
				selectedIndex = 8
			Else
				selectedIndex = 9
			End If
		End If
		rcbFilter.SelectedIndex = selectedIndex
	End Sub

	Private Sub UpdateRibbonItemState()
		Dim enableRibbonItem As Boolean = ganttView.GroupDefinition.Items.Count = 0
		rbAddBlankRow.Enabled = enableRibbonItem
		rbAddTask.Enabled = enableRibbonItem
		rbAddSummary.Enabled = enableRibbonItem
		rbMoveTaskDown.Enabled = enableRibbonItem
		rbMoveTaskUp.Enabled = enableRibbonItem
		rbIndentTask.Enabled = enableRibbonItem
		rbOutdentTask.Enabled = enableRibbonItem
		rbTaskInfo.Enabled = enableRibbonItem
		InitializeGroupComboBox()
		InitializeFilterComboBox()
	End Sub

#Region "Event Handlers"

	Private Sub ganttView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ganttView.SelectedIndexChanged
		' Update TaskMode status on RibbonToggleButton when selected task changes
		If ganttView.SelectedTaskIndex <> -1 Then
			' When Task is empty, two buttons are disabled.
			rbAutoSchedule.Enabled = ganttView.SelectedTask.Initialized
			rbManualSchedule.Enabled = ganttView.SelectedTask.Initialized

			If ganttView.SelectedTask.Mode = TaskMode.Automatic Then
				rbAutoSchedule.Pressed = True
			Else
				rbManualSchedule.Pressed = True
			End If
		Else
			rbAutoSchedule.Enabled = False
			rbManualSchedule.Enabled = False
		End If

		If ganttView.SelectedTask Is Nothing OrElse Not ganttView.SelectedTask.Initialized Then
			rbZoomSelectedTask.Enabled = False
		Else
			rbZoomSelectedTask.Enabled = True
		End If
	End Sub

	Private Sub fontPicker_ChangeCommitted(sender As Object, e As EventArgs) Handles fontPicker.ChangeCommitted
		' We change only font family and keep other exist settings.
		Dim font As New Font(fontPicker.Text, ganttView.Font.Size, ganttView.Font.Style)
		ganttView.Font = font

		' In case the input font that haven't been installed, 
		' we need to reset selected font in combo box to default font.
		fontPicker.SelectedIndex = fontPicker.Items.IndexOf(ganttView.Font.FontFamily.Name)
	End Sub

	Private Sub rcbFontSize_ChangeCommitted(sender As Object, e As EventArgs) Handles rcbFontSize.ChangeCommitted
		Dim fontSize As Single
		If Single.TryParse(rcbFontSize.Text, fontSize) AndAlso fontSize >= 4 AndAlso fontSize <= 127 Then
			Dim font As New Font(ganttView.Font.FontFamily, fontSize, ganttView.Font.Style)
			ganttView.Font = font
		Else
			MessageBox.Show("Font size must be between 4 and 127.")

			' Set font size in combo box to current valid font size.
			rcbFontSize.Text = ganttView.Font.Size.ToString()
		End If
	End Sub

	Private Sub rcpBackground_SelectedColorChanged(sender As Object, e As EventArgs) Handles rcpBackground.SelectedColorChanged
		ganttView.BackColor = rcpBackground.Color
	End Sub

	Private Sub rcpForeground_SelectedColorChanged(sender As Object, e As EventArgs) Handles rcpForeground.SelectedColorChanged
		ganttView.ForeColor = rcpForeground.Color
	End Sub

	Private Sub rbManualSchedule_Click(sender As Object, e As EventArgs) Handles rbManualSchedule.Click
		If ganttView.SelectedTaskIndex <> -1 Then
			ganttView.SelectedTask.Mode = TaskMode.Manual
		End If
	End Sub

	Private Sub rbAutoSchedule_Click(sender As Object, e As EventArgs) Handles rbAutoSchedule.Click
		If ganttView.SelectedTaskIndex <> -1 Then
			ganttView.SelectedTask.Mode = TaskMode.Automatic
		End If
	End Sub

	Private Sub rbScrollToTask_Click(sender As Object, e As EventArgs) Handles rbScrollToTask.Click
		ganttView.ClickButton(CommandButton.ScrollToTask)
	End Sub

	Private Sub rbMoveTaskUp_Click(sender As Object, e As EventArgs) Handles rbMoveTaskUp.Click
		ganttView.ClickButton(CommandButton.MoveTaskUp)
	End Sub

	Private Sub rbMoveTaskDown_Click(sender As Object, e As EventArgs) Handles rbMoveTaskDown.Click
		ganttView.ClickButton(CommandButton.MoveTaskDown)
	End Sub

	Private Sub rbAddTask_Click(sender As Object, e As EventArgs) Handles rbAddTask.Click
		ganttView.ClickButton(CommandButton.AddTask)
	End Sub

	Private Sub rbAddBlankRow_Click(sender As Object, e As EventArgs) Handles rbAddBlankRow.Click
		ganttView.ClickButton(CommandButton.AddBlankRow)
	End Sub

	Private Sub rbTaskInfo_Click(sender As Object, e As EventArgs) Handles rbTaskInfo.Click
		ganttView.ClickButton(CommandButton.TaskInfo)
	End Sub

	Private Sub rbDeleteTask_Click(sender As Object, e As EventArgs) Handles rbDeleteTask.Click
		ganttView.ClickButton(CommandButton.DeleteTask)
	End Sub

	Private Sub rbResources_Click(sender As Object, e As EventArgs) Handles rbResources.Click
		ganttView.ClickButton(CommandButton.Resources)
	End Sub

	Private Sub rbProjectInfo_Click(sender As Object, e As EventArgs) Handles rbProjectInfo.Click
		ganttView.ClickButton(CommandButton.ProjectInfo)
	End Sub

	Private Sub rbColumns_Click(sender As Object, e As EventArgs) Handles rbColumns.Click
		ganttView.ClickButton(CommandButton.GridColumns)
	End Sub

	Private Sub rbProgressLine_Click(sender As Object, e As EventArgs) Handles rbProgressLine.Click
		ganttView.ClickButton(CommandButton.ProgressLines)
	End Sub

	Private Sub rbChangeWorkingTIme_Click(sender As Object, e As EventArgs) Handles rbChangeWorkingTime.Click
		ganttView.ClickButton(CommandButton.WorkingTime)
	End Sub

	Private Sub rbBarStyles_Click(sender As Object, e As EventArgs) Handles rbBarStyles.Click
		ganttView.ClickButton(CommandButton.BarStyles)
	End Sub

	Private Sub rbTimeScale_Click(sender As Object, e As EventArgs) Handles rbTimeScale.Click
		ganttView.ClickButton(CommandButton.Timescale)
	End Sub

	Private Sub rcpTodayLine_SelectedColorChanged(sender As Object, e As EventArgs)
		ganttView.TodayLineColor = rcpTodayLine.Color
	End Sub

	Private Sub rcpStartFinishLine_SelectedColorChanged(sender As Object, e As EventArgs)
		ganttView.StartFinishLineColor = rcpStartFinishLine.Color
	End Sub

	Private Sub rcpSplitter_SelectedColorChanged(sender As Object, e As EventArgs)
		ganttView.SplitterColor = rcpSplitter.Color
	End Sub

	Private Sub rcpNonworkingTime_SelectedColorChanged(sender As Object, e As EventArgs)
		ganttView.NonworkingTimeColor = rcpNonworkingTime.Color
	End Sub

	Private Sub rcpHighlightForeground_SelectedColorChanged(sender As Object, e As EventArgs)
		ganttView.HighlightForeColor = rcpHightlightForeground.Color
	End Sub

	Private Sub rcpHighlightBackground_SelectedColorChanged(sender As Object, e As EventArgs)
		ganttView.HighlightBackColor = rcpHightlightBackground.Color
	End Sub

	Private Sub rcpFixedForeground_SelectedColorChanged(sender As Object, e As EventArgs)
		ganttView.FixedForeColor = rcpFixedForeground.Color
	End Sub

	Private Sub rcpFixedCellBorder_SelectedColorChanged(sender As Object, e As EventArgs)
		ganttView.FixedCellBorderColor = rcpFixedCellBorder.Color
	End Sub

	Private Sub rcpFixedBackground_SelectedColorChanged(sender As Object, e As EventArgs)
		ganttView.FixedBackColor = rcpFixedBackground.Color
	End Sub

	Private Sub rcpEmptyAreaBackground_SelectedColorChanged(sender As Object, e As EventArgs)
		ganttView.EmptyAreaBackColor = rcpEmptyAreaBack.Color
	End Sub

	Private Sub rcpCellBorder_SelectedColorChanged(sender As Object, e As EventArgs)
		ganttView.CellBorderColor = rcpCellBorder.Color
	End Sub

	Private Sub rbOpen_Click(sender As Object, e As EventArgs) Handles rbOpen.Click
		ganttView.ClickButton(CommandButton.LoadFromXml)
	End Sub

	Private Sub rbSave_Click(sender As Object, e As EventArgs) Handles rbSave.Click
		ganttView.ClickButton(CommandButton.SaveAsXml)
	End Sub

	Private Sub rbPrint_Click(sender As Object, e As EventArgs) Handles rbPrint.Click
		ganttView.ClickButton(CommandButton.Print)
	End Sub

	Private Sub rbPrintPreview_Click(sender As Object, e As EventArgs) Handles rbPrintPreview.Click
		ganttView.Preview()
	End Sub

	Private Sub rbQuit_Click(sender As Object, e As EventArgs)
		Me.Close()
	End Sub

	Private Sub btnTimescale_Click(sender As Object, e As EventArgs)
		ganttView.ClickButton(CommandButton.Timescale)
	End Sub

	Private Sub rbZoomSelectedTask_Click(sender As Object, e As EventArgs) Handles rbZoomSelectedTask.Click
		ganttView.ZoomTask(ganttView.SelectedTask)
	End Sub

	Private Sub rbZoomEntireProject_Click(sender As Object, e As EventArgs) Handles rbZoomEntireProject.Click
		ganttView.ZoomEntireProject()
	End Sub

	Private Sub rbZoomDialog_Click(sender As Object, e As EventArgs) Handles rbZoomDialog.Click
		ganttView.ClickButton(CommandButton.Zoom)
	End Sub

	Private Sub rbZoomOut_Click(sender As Object, e As EventArgs) Handles rbZoomOut.Click
		ganttView.ZoomOut()
	End Sub

	Private Sub rbZoomIn_Click(sender As Object, e As EventArgs) Handles rbZoomIn.Click
		ganttView.ZoomIn()
	End Sub

	Private Sub rcbTimeline_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rcbTimeline.SelectedIndexChanged
		ganttView.ChartViewZoomFactor = 11 - (rcbTimeline.SelectedIndex + 1)
	End Sub

	Private Sub rtbZoom_ValueChanged(sender As Object, e As EventArgs) Handles rtbZoom.ValueChanged
		If _zoomfactorIsChanging Then
			Return
		End If
		ganttView.ChartViewZoomFactor = 12 - CSng(rtbZoom.Value)
	End Sub

	Private Sub Timescale_ZoomFactorChanged(sender As Object, e As EventArgs)
		_zoomfactorIsChanging = True
		rtbZoom.Value = 12 - CInt(Math.Truncate(ganttView.ChartViewZoomFactor))
		_zoomfactorIsChanging = False
		Dim lowestTier As ScaleTier = Nothing
		If ganttView.Timescale.BottomTier.Visible Then
			lowestTier = ganttView.Timescale.BottomTier
		ElseIf ganttView.Timescale.MiddleTier.Visible Then
			lowestTier = ganttView.Timescale.MiddleTier
		ElseIf ganttView.Timescale.TopTier.Visible Then
			lowestTier = ganttView.Timescale.TopTier
		End If

		If lowestTier Is Nothing Then
			Return
		End If
		rcbTimeline.Text = (If((lowestTier.Count > 1), lowestTier.Count & " ", "")) & lowestTier.Units.ToString()
	End Sub

	Private Sub rbOutdentTask_Click(sender As Object, e As EventArgs) Handles rbOutdentTask.Click
		ganttView.ClickButton(CommandButton.Outdent)
	End Sub

	Private Sub rbIndentTask_Click(sender As Object, e As EventArgs) Handles rbIndentTask.Click
		ganttView.ClickButton(CommandButton.Indent)
	End Sub

	Private Sub rbAddSummary_Click(sender As Object, e As EventArgs) Handles rbAddSummary.Click
		ganttView.ClickButton(CommandButton.AddSummaryTask)
	End Sub

	Private Sub rbNoGroup_Click(sender As Object, e As EventArgs) Handles rbNoGroup.Click
		ganttView.ClearGroup()
		UpdateRibbonItemState()
	End Sub

	Private Sub rbTaskMode_Click(sender As Object, e As EventArgs) Handles rbTaskMode.Click
		ganttView.Group(New TaskModeGroup(True))
		UpdateRibbonItemState()
	End Sub

	Private Sub rbTaskComplete_Click(sender As Object, e As EventArgs) Handles rbTaskComplete.Click
		ganttView.Group(New TaskCompleteGroup(True))
		UpdateRibbonItemState()
	End Sub

	Private Sub rbStatus_Click(sender As Object, e As EventArgs) Handles rbStatus.Click
		Dim statusDate As DateTime = DateTime.Today
		If ganttView.ProgressLine.StatusDate.HasValue Then
			statusDate = ganttView.ProgressLine.StatusDate.Value
		End If
		ganttView.Group(New StatusGroup(statusDate, True))
		UpdateRibbonItemState()
	End Sub

	Private Sub rbMilestones_Click(sender As Object, e As EventArgs) Handles rbMilestones.Click
		ganttView.Group(New MilestonesGroup(True))
		UpdateRibbonItemState()
	End Sub

	Private Sub rbDuration_Click(sender As Object, e As EventArgs) Handles rbDuration.Click
		ganttView.Group(New DurationGroup(True))
		UpdateRibbonItemState()
	End Sub

	Private Sub rbConstraintType_Click(sender As Object, e As EventArgs) Handles rbConstraintType.Click
		ganttView.Group(New ConstraintTypeGroup(True))
		UpdateRibbonItemState()
	End Sub

	Private Sub rbResource_Click(sender As Object, e As EventArgs) Handles rbResource.Click
		ganttView.Group(New ResourceGroup(True))
		UpdateRibbonItemState()
	End Sub

	Private Sub rbAdvanceGroup_Click(sender As Object, e As EventArgs) Handles rbAdvanceGroup.Click
		ganttView.ClickButton(CommandButton.Group)
		UpdateRibbonItemState()
	End Sub

	Private Sub rcbMaintainHierarchy_CheckedChanged(sender As Object, e As EventArgs) Handles rcbMaintainHierarchy.CheckedChanged
		ganttView.GroupDefinition.MaintainHierarchy = rcbMaintainHierarchy.Checked
		UpdateRibbonItemState()
	End Sub

	Private Sub rbNoFilter_Click(sender As Object, e As EventArgs) Handles rbNoFilter.Click
		ganttView.ClickButton(CommandButton.NoFilter)
	End Sub

	Private Sub rbCompletedTasksFilter_Click(sender As Object, e As EventArgs) Handles rbCompletedTasksFilter.Click
		ganttView.ClickButton(CommandButton.CompletedTasksFilter)
	End Sub

	Private Sub rbDateRangeFilter_Click(sender As Object, e As EventArgs) Handles rbDateRangeFilter.Click
		ganttView.ClickButton(CommandButton.DateRangeFilter)
	End Sub

	Private Sub rbIncompleteTasksFilter_Click(sender As Object, e As EventArgs) Handles rbIncompleteTasksFilter.Click
		ganttView.ClickButton(CommandButton.IncompleteTasksFilter)
	End Sub

	Private Sub rbLateTasksFilter_Click(sender As Object, e As EventArgs) Handles rbLateTasksFilter.Click
		ganttView.ClickButton(CommandButton.LateTasksFilter)
	End Sub

	Private Sub rbMilestonesFilter_Click(sender As Object, e As EventArgs) Handles rbMilestonesFilter.Click
		ganttView.ClickButton(CommandButton.MilestonesFilter)
	End Sub

	Private Sub rbSummaryTasksFilter_Click(sender As Object, e As EventArgs) Handles rbSummaryTasksFilter.Click
		ganttView.ClickButton(CommandButton.SummaryTasksFilter)
	End Sub

	Private Sub rbDurationOnlyTasksFilter_Click(sender As Object, e As EventArgs) Handles rbDurationOnlyTasksFilter.Click
		ganttView.ClickButton(CommandButton.TasksWithDurationOnlyFilter)
	End Sub

	Private Sub rbUsingResourceFilter_Click(sender As Object, e As EventArgs) Handles rbUsingResourceFilter.Click
		ganttView.ClickButton(CommandButton.UsingResourceFilter)
	End Sub

	Private Sub rbAdvancedFilter_Click(sender As Object, e As EventArgs) Handles rbAdvancedFilter.Click
		ganttView.ClickButton(CommandButton.AdvancedFilter)
	End Sub

	Private Sub rbMoreFilters_Click(sender As Object, e As EventArgs) Handles rbMoreFilters.Click
		ganttView.ClickButton(CommandButton.MoreFilters)
	End Sub

	Private Sub rcbShowRelatedSummaryRows_CheckedChanged(sender As Object, e As EventArgs) Handles rcbShowRelatedSummaryRows.CheckedChanged
		ganttView.FilterDefinition.ShowRelatedSummaryRows = rcbShowRelatedSummaryRows.Checked
	End Sub

#End Region

End Class
