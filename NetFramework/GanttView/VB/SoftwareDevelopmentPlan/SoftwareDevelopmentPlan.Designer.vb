Partial Class SoftwareDevelopmentPlan
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	''' <summary>
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Sub Dispose(disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Windows Form Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SoftwareDevelopmentPlan))
        Dim BarStyle1 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle2 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle3 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle4 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle5 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle6 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle7 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim CalendarException1 As C1.Win.C1GanttView.CalendarException = New C1.Win.C1GanttView.CalendarException()
        Dim TaskPropertyColumn1 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn2 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn3 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn4 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn5 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn6 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn7 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn8 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn9 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn10 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn11 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn12 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn13 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim TaskPropertyColumn14 As C1.Win.C1GanttView.TaskPropertyColumn = New C1.Win.C1GanttView.TaskPropertyColumn()
        Dim Task1 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Resource1 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource2 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource3 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource4 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource5 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource6 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource7 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource8 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource9 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Task2 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle8 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Task3 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle9 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim ResourceRef1 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef2 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task4 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle10 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor1 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef3 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task5 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor2 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef4 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef5 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task6 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle11 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor3 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim Task7 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task8 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor4 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef6 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task9 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor5 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef7 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task10 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor6 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef8 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef9 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task11 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle12 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor7 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim Task12 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task13 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor8 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef10 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task14 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor9 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef11 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef12 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef13 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task15 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim ResourceRef14 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef15 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task16 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle13 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor10 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim Predecessor11 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim Task17 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle14 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Task18 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor12 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef16 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task19 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor13 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim Predecessor14 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef17 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef18 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task20 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor15 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim Predecessor16 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef19 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task21 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle15 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor17 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim Predecessor18 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim Task22 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle16 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Task23 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim ResourceRef20 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task24 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim ResourceRef21 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task25 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor19 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim Predecessor20 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef22 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task26 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle17 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor21 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim Task27 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle18 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Task28 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor22 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim Predecessor23 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef23 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef24 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task29 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor24 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef25 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task30 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle19 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor25 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim Task31 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle20 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Task32 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task33 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task34 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task35 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task36 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task37 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task38 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task39 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task40 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task41 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task42 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task43 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task44 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task45 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task46 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task47 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task48 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task49 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task50 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task51 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task52 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task53 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task54 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Me.ribbon = New C1.Win.Ribbon.C1Ribbon()
        Me.ribbonApplicationMenu1 = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.rbOpen = New C1.Win.Ribbon.RibbonButton()
        Me.rbSave = New C1.Win.Ribbon.RibbonButton()
        Me.rbPrint = New C1.Win.Ribbon.RibbonButton()
        Me.rbPrintPreview = New C1.Win.Ribbon.RibbonButton()
        Me.rbQuit = New C1.Win.Ribbon.RibbonButton()
        Me.RibbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.ribbonConfigToolBar1 = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.ribbonQat1 = New C1.Win.Ribbon.RibbonQat()
        Me.ribbonTab1 = New C1.Win.Ribbon.RibbonTab()
        Me.ribbonGroup1 = New C1.Win.Ribbon.RibbonGroup()
        Me.ribbonToolBar1 = New C1.Win.Ribbon.RibbonToolBar()
        Me.rcpBackground = New C1.Win.Ribbon.RibbonColorPicker()
        Me.fontPicker = New C1.Win.Ribbon.RibbonFontComboBox()
        Me.rcbFontSize = New C1.Win.Ribbon.RibbonComboBox()
        Me.rcpForeground = New C1.Win.Ribbon.RibbonColorPicker()
        Me.ribbonToolBar2 = New C1.Win.Ribbon.RibbonToolBar()
        Me.ribbonGroup3 = New C1.Win.Ribbon.RibbonGroup()
        Me.rbManualSchedule = New C1.Win.Ribbon.RibbonToggleButton()
        Me.rbAutoSchedule = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonSeparator1 = New C1.Win.Ribbon.RibbonSeparator()
        Me.rbMoveTaskUp = New C1.Win.Ribbon.RibbonButton()
        Me.rbMoveTaskDown = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonSeparator2 = New C1.Win.Ribbon.RibbonSeparator()
        Me.rbOutdentTask = New C1.Win.Ribbon.RibbonButton()
        Me.rbIndentTask = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonGroup4 = New C1.Win.Ribbon.RibbonGroup()
        Me.rbAddTask = New C1.Win.Ribbon.RibbonButton()
        Me.rbAddSummary = New C1.Win.Ribbon.RibbonButton()
        Me.rbDeleteTask = New C1.Win.Ribbon.RibbonButton()
        Me.rbAddBlankRow = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonGroup5 = New C1.Win.Ribbon.RibbonGroup()
        Me.rbTaskInfo = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonGroup2 = New C1.Win.Ribbon.RibbonGroup()
        Me.rbScrollToTask = New C1.Win.Ribbon.RibbonButton()
        Me.rbColumns = New C1.Win.Ribbon.RibbonButton()
        Me.rbTimeScale = New C1.Win.Ribbon.RibbonButton()
        Me.rbProgressLine = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonTab2 = New C1.Win.Ribbon.RibbonTab()
        Me.ribbonGroup7 = New C1.Win.Ribbon.RibbonGroup()
        Me.rbResources = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonTab3 = New C1.Win.Ribbon.RibbonTab()
        Me.ribbonGroup8 = New C1.Win.Ribbon.RibbonGroup()
        Me.rbProjectInfo = New C1.Win.Ribbon.RibbonButton()
        Me.rbChangeWorkingTime = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonTab5 = New C1.Win.Ribbon.RibbonTab()
        Me.ribbonGroup11 = New C1.Win.Ribbon.RibbonGroup()
        Me.rcbTimeline = New C1.Win.Ribbon.RibbonComboBox()
        Me.rbTimescale2 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonMenu1 = New C1.Win.Ribbon.RibbonMenu()
        Me.rbZoomOut = New C1.Win.Ribbon.RibbonButton()
        Me.rbZoomIn = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonSeparator11 = New C1.Win.Ribbon.RibbonSeparator()
        Me.rbZoomDialog = New C1.Win.Ribbon.RibbonButton()
        Me.rbZoomEntireProject = New C1.Win.Ribbon.RibbonButton()
        Me.rbZoomSelectedTask = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonGroup6 = New C1.Win.Ribbon.RibbonGroup()
        Me.rcbGroupBy = New C1.Win.Ribbon.RibbonComboBox()
        Me.rbNoGroup = New C1.Win.Ribbon.RibbonButton()
        Me.rbTaskMode = New C1.Win.Ribbon.RibbonButton()
        Me.rbTaskComplete = New C1.Win.Ribbon.RibbonButton()
        Me.rbConstraintType = New C1.Win.Ribbon.RibbonButton()
        Me.rbDuration = New C1.Win.Ribbon.RibbonButton()
        Me.rbMilestones = New C1.Win.Ribbon.RibbonButton()
        Me.rbResource = New C1.Win.Ribbon.RibbonButton()
        Me.rbStatus = New C1.Win.Ribbon.RibbonButton()
        Me.rbAdvanceGroup = New C1.Win.Ribbon.RibbonButton()
        Me.rcbMaintainHierarchy = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ribbonGroup10 = New C1.Win.Ribbon.RibbonGroup()
        Me.rcbFilter = New C1.Win.Ribbon.RibbonComboBox()
        Me.rbNoFilter = New C1.Win.Ribbon.RibbonButton()
        Me.rbCompletedTasksFilter = New C1.Win.Ribbon.RibbonButton()
        Me.rbDateRangeFilter = New C1.Win.Ribbon.RibbonButton()
        Me.rbIncompleteTasksFilter = New C1.Win.Ribbon.RibbonButton()
        Me.rbLateTasksFilter = New C1.Win.Ribbon.RibbonButton()
        Me.rbMilestonesFilter = New C1.Win.Ribbon.RibbonButton()
        Me.rbSummaryTasksFilter = New C1.Win.Ribbon.RibbonButton()
        Me.rbDurationOnlyTasksFilter = New C1.Win.Ribbon.RibbonButton()
        Me.rbUsingResourceFilter = New C1.Win.Ribbon.RibbonButton()
        Me.rbAdvancedFilter = New C1.Win.Ribbon.RibbonButton()
        Me.rbMoreFilters = New C1.Win.Ribbon.RibbonButton()
        Me.rcbShowRelatedSummaryRows = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ribbonTab4 = New C1.Win.Ribbon.RibbonTab()
        Me.ribbonGroup9 = New C1.Win.Ribbon.RibbonGroup()
        Me.ribbonMenu3 = New C1.Win.Ribbon.RibbonMenu()
        Me.ribbonLabel4 = New C1.Win.Ribbon.RibbonLabel()
        Me.rcpCellBorder = New C1.Win.Ribbon.RibbonColorPicker()
        Me.rcpEmptyAreaBack = New C1.Win.Ribbon.RibbonColorPicker()
        Me.rcpFixedBackground = New C1.Win.Ribbon.RibbonColorPicker()
        Me.rcpFixedCellBorder = New C1.Win.Ribbon.RibbonColorPicker()
        Me.rcpFixedForeground = New C1.Win.Ribbon.RibbonColorPicker()
        Me.rcpHightlightBackground = New C1.Win.Ribbon.RibbonColorPicker()
        Me.rcpHightlightForeground = New C1.Win.Ribbon.RibbonColorPicker()
        Me.rcpNonworkingTime = New C1.Win.Ribbon.RibbonColorPicker()
        Me.rcpSplitter = New C1.Win.Ribbon.RibbonColorPicker()
        Me.rcpStartFinishLine = New C1.Win.Ribbon.RibbonColorPicker()
        Me.rcpTodayLine = New C1.Win.Ribbon.RibbonColorPicker()
        Me.rbBarStyles = New C1.Win.Ribbon.RibbonButton()
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.statusBar = New C1.Win.Ribbon.C1StatusBar()
        Me.rlLeftStatus = New C1.Win.Ribbon.RibbonLabel()
        Me.rtbZoom = New C1.Win.Ribbon.RibbonTrackBar()
        Me.ganttView = New C1.Win.C1GanttView.C1GanttView()
        CType(Me.ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.statusBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ganttView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ganttView.DataStorage.CalendarStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ganttView.DataStorage.PropertyStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ganttView.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ganttView.DataStorage.TasksStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ribbon
        '
        Me.ribbon.ApplicationMenuHolder = Me.ribbonApplicationMenu1
        Me.ribbon.BottomToolBarHolder = Me.RibbonBottomToolBar1
        Me.ribbon.ConfigToolBarHolder = Me.ribbonConfigToolBar1
        Me.ribbon.Location = New System.Drawing.Point(0, 0)
        Me.ribbon.Name = "ribbon"
        Me.ribbon.QatHolder = Me.ribbonQat1
        Me.ribbon.Size = New System.Drawing.Size(1117, 201)
        Me.ribbon.Tabs.Add(Me.ribbonTab1)
        Me.ribbon.Tabs.Add(Me.ribbonTab2)
        Me.ribbon.Tabs.Add(Me.ribbonTab3)
        Me.ribbon.Tabs.Add(Me.ribbonTab5)
        Me.ribbon.Tabs.Add(Me.ribbonTab4)
        Me.ribbon.TopToolBarHolder = Me.RibbonTopToolBar1
        '
        'ribbonApplicationMenu1
        '
        Me.ribbonApplicationMenu1.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("ribbonApplicationMenu1.IconSet"), System.Drawing.Image)))
        Me.ribbonApplicationMenu1.LeftPaneItems.Add(Me.rbOpen)
        Me.ribbonApplicationMenu1.LeftPaneItems.Add(Me.rbSave)
        Me.ribbonApplicationMenu1.LeftPaneItems.Add(Me.rbPrint)
        Me.ribbonApplicationMenu1.LeftPaneItems.Add(Me.rbPrintPreview)
        Me.ribbonApplicationMenu1.LeftPaneItems.Add(Me.rbQuit)
        Me.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1"
        '
        'rbOpen
        '
        Me.rbOpen.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbOpen.IconSet"), System.Drawing.Image)))
        Me.rbOpen.Name = "rbOpen"
        Me.rbOpen.Text = "Load From XML File"
        '
        'rbSave
        '
        Me.rbSave.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbSave.IconSet"), System.Drawing.Image)))
        Me.rbSave.Name = "rbSave"
        Me.rbSave.Text = "Save As XML File"
        '
        'rbPrint
        '
        Me.rbPrint.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbPrint.IconSet"), System.Drawing.Image)))
        Me.rbPrint.Name = "rbPrint"
        Me.rbPrint.Text = "Print"
        '
        'rbPrintPreview
        '
        Me.rbPrintPreview.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbPrintPreview.IconSet"), System.Drawing.Image)))
        Me.rbPrintPreview.Name = "rbPrintPreview"
        Me.rbPrintPreview.Text = "Print Preview"
        '
        'rbQuit
        '
        Me.rbQuit.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbQuit.IconSet"), System.Drawing.Image)))
        Me.rbQuit.Name = "rbQuit"
        Me.rbQuit.Text = "Quit"
        '
        'RibbonBottomToolBar1
        '
        Me.RibbonBottomToolBar1.Name = "RibbonBottomToolBar1"
        '
        'ribbonConfigToolBar1
        '
        Me.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1"
        '
        'ribbonQat1
        '
        Me.ribbonQat1.ItemLinks.Add(Me.rbOpen)
        Me.ribbonQat1.ItemLinks.Add(Me.rbSave)
        Me.ribbonQat1.Name = "ribbonQat1"
        '
        'ribbonTab1
        '
        Me.ribbonTab1.Groups.Add(Me.ribbonGroup1)
        Me.ribbonTab1.Groups.Add(Me.ribbonGroup3)
        Me.ribbonTab1.Groups.Add(Me.ribbonGroup4)
        Me.ribbonTab1.Groups.Add(Me.ribbonGroup5)
        Me.ribbonTab1.Groups.Add(Me.ribbonGroup2)
        Me.ribbonTab1.Name = "ribbonTab1"
        Me.ribbonTab1.Text = "TASK"
        '
        'ribbonGroup1
        '
        Me.ribbonGroup1.Items.Add(Me.ribbonToolBar1)
        Me.ribbonGroup1.Items.Add(Me.ribbonToolBar2)
        Me.ribbonGroup1.Name = "ribbonGroup1"
        Me.ribbonGroup1.Text = "Font"
        '
        'ribbonToolBar1
        '
        Me.ribbonToolBar1.Items.Add(Me.rcpBackground)
        Me.ribbonToolBar1.Items.Add(Me.fontPicker)
        Me.ribbonToolBar1.Items.Add(Me.rcbFontSize)
        Me.ribbonToolBar1.Items.Add(Me.rcpForeground)
        Me.ribbonToolBar1.Name = "ribbonToolBar1"
        '
        'rcpBackground
        '
        Me.rcpBackground.DefaultColor = System.Drawing.Color.Yellow
        Me.rcpBackground.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpBackground.IconSet"), System.Drawing.Image)))
        Me.rcpBackground.Name = "rcpBackground"
        Me.rcpBackground.ToolTip = "Color background of control"
        '
        'fontPicker
        '
        Me.fontPicker.Name = "fontPicker"
        Me.fontPicker.TextAreaWidth = 100
        Me.fontPicker.ToolTip = "Pick a new font for your text"
        '
        'rcbFontSize
        '
        Me.rcbFontSize.Name = "rcbFontSize"
        Me.rcbFontSize.TextAreaWidth = 30
        Me.rcbFontSize.ToolTip = "Chang the size of your text."
        '
        'rcpForeground
        '
        Me.rcpForeground.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpForeground.IconSet"), System.Drawing.Image)))
        Me.rcpForeground.Name = "rcpForeground"
        Me.rcpForeground.ToolTip = "Change the color of your text"
        '
        'ribbonToolBar2
        '
        Me.ribbonToolBar2.Name = "ribbonToolBar2"
        '
        'ribbonGroup3
        '
        Me.ribbonGroup3.Items.Add(Me.rbManualSchedule)
        Me.ribbonGroup3.Items.Add(Me.rbAutoSchedule)
        Me.ribbonGroup3.Items.Add(Me.ribbonSeparator1)
        Me.ribbonGroup3.Items.Add(Me.rbMoveTaskUp)
        Me.ribbonGroup3.Items.Add(Me.rbMoveTaskDown)
        Me.ribbonGroup3.Items.Add(Me.ribbonSeparator2)
        Me.ribbonGroup3.Items.Add(Me.rbOutdentTask)
        Me.ribbonGroup3.Items.Add(Me.rbIndentTask)
        Me.ribbonGroup3.Name = "ribbonGroup3"
        Me.ribbonGroup3.Text = "Tasks"
        '
        'rbManualSchedule
        '
        Me.rbManualSchedule.CanDepress = False
        Me.rbManualSchedule.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbManualSchedule.IconSet"), System.Drawing.Image)))
        Me.rbManualSchedule.Name = "rbManualSchedule"
        Me.rbManualSchedule.Text = "Manual Schedule"
        Me.rbManualSchedule.ToggleGroupName = "TaskModeGroup"
        Me.rbManualSchedule.ToolTip = resources.GetString("rbManualSchedule.ToolTip")
        '
        'rbAutoSchedule
        '
        Me.rbAutoSchedule.CanDepress = False
        Me.rbAutoSchedule.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbAutoSchedule.IconSet"), System.Drawing.Image)))
        Me.rbAutoSchedule.Name = "rbAutoSchedule"
        Me.rbAutoSchedule.Text = "Auto Schedule"
        Me.rbAutoSchedule.ToggleGroupName = "TaskModeGroup"
        Me.rbAutoSchedule.ToolTip = resources.GetString("rbAutoSchedule.ToolTip")
        '
        'ribbonSeparator1
        '
        Me.ribbonSeparator1.Name = "ribbonSeparator1"
        '
        'rbMoveTaskUp
        '
        Me.rbMoveTaskUp.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbMoveTaskUp.IconSet"), System.Drawing.Image)))
        Me.rbMoveTaskUp.Name = "rbMoveTaskUp"
        Me.rbMoveTaskUp.ToolTip = "Move Task Up"
        '
        'rbMoveTaskDown
        '
        Me.rbMoveTaskDown.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbMoveTaskDown.IconSet"), System.Drawing.Image)))
        Me.rbMoveTaskDown.Name = "rbMoveTaskDown"
        Me.rbMoveTaskDown.ToolTip = "Move Task Down"
        '
        'ribbonSeparator2
        '
        Me.ribbonSeparator2.Name = "ribbonSeparator2"
        '
        'rbOutdentTask
        '
        Me.rbOutdentTask.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbOutdentTask.IconSet"), System.Drawing.Image)))
        Me.rbOutdentTask.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbOutdentTask.IconSet1"), System.Drawing.Image)))
        Me.rbOutdentTask.Name = "rbOutdentTask"
        '
        'rbIndentTask
        '
        Me.rbIndentTask.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbIndentTask.IconSet"), System.Drawing.Image)))
        Me.rbIndentTask.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbIndentTask.IconSet1"), System.Drawing.Image)))
        Me.rbIndentTask.Name = "rbIndentTask"
        '
        'ribbonGroup4
        '
        Me.ribbonGroup4.Items.Add(Me.rbAddTask)
        Me.ribbonGroup4.Items.Add(Me.rbAddSummary)
        Me.ribbonGroup4.Items.Add(Me.rbDeleteTask)
        Me.ribbonGroup4.Items.Add(Me.rbAddBlankRow)
        Me.ribbonGroup4.Name = "ribbonGroup4"
        Me.ribbonGroup4.Text = "Edit"
        '
        'rbAddTask
        '
        Me.rbAddTask.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbAddTask.IconSet"), System.Drawing.Image)))
        Me.rbAddTask.Name = "rbAddTask"
        Me.rbAddTask.Text = "Task"
        Me.rbAddTask.ToolTip = resources.GetString("rbAddTask.ToolTip")
        '
        'rbAddSummary
        '
        Me.rbAddSummary.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbAddSummary.IconSet"), System.Drawing.Image)))
        Me.rbAddSummary.Name = "rbAddSummary"
        Me.rbAddSummary.Text = "Summary"
        '
        'rbDeleteTask
        '
        Me.rbDeleteTask.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbDeleteTask.IconSet"), System.Drawing.Image)))
        Me.rbDeleteTask.Name = "rbDeleteTask"
        Me.rbDeleteTask.Text = "Delete"
        Me.rbDeleteTask.ToolTip = "Delete Task"
        '
        'rbAddBlankRow
        '
        Me.rbAddBlankRow.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbAddBlankRow.IconSet"), System.Drawing.Image)))
        Me.rbAddBlankRow.Name = "rbAddBlankRow"
        Me.rbAddBlankRow.Text = "Blank Row"
        Me.rbAddBlankRow.ToolTip = "Add Blank Row"
        '
        'ribbonGroup5
        '
        Me.ribbonGroup5.Items.Add(Me.rbTaskInfo)
        Me.ribbonGroup5.Name = "ribbonGroup5"
        Me.ribbonGroup5.Text = "Properties"
        '
        'rbTaskInfo
        '
        Me.rbTaskInfo.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbTaskInfo.IconSet"), System.Drawing.Image)))
        Me.rbTaskInfo.Name = "rbTaskInfo"
        Me.rbTaskInfo.Text = "Information"
        Me.rbTaskInfo.ToolTip = "Task Information"
        '
        'ribbonGroup2
        '
        Me.ribbonGroup2.Items.Add(Me.rbScrollToTask)
        Me.ribbonGroup2.Items.Add(Me.rbColumns)
        Me.ribbonGroup2.Items.Add(Me.rbTimeScale)
        Me.ribbonGroup2.Items.Add(Me.rbProgressLine)
        Me.ribbonGroup2.Name = "ribbonGroup2"
        Me.ribbonGroup2.Text = "View"
        '
        'rbScrollToTask
        '
        Me.rbScrollToTask.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbScrollToTask.IconSet"), System.Drawing.Image)))
        Me.rbScrollToTask.Name = "rbScrollToTask"
        Me.rbScrollToTask.Text = "Scroll To Task"
        Me.rbScrollToTask.ToolTip = "Scroll To Task"
        '
        'rbColumns
        '
        Me.rbColumns.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbColumns.IconSet"), System.Drawing.Image)))
        Me.rbColumns.Name = "rbColumns"
        Me.rbColumns.Text = "Columns"
        Me.rbColumns.ToolTip = "Grid Columns"
        '
        'rbTimeScale
        '
        Me.rbTimeScale.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbTimeScale.IconSet"), System.Drawing.Image)))
        Me.rbTimeScale.Name = "rbTimeScale"
        Me.rbTimeScale.Text = "Time Scale"
        Me.rbTimeScale.ToolTip = "Time Scale"
        '
        'rbProgressLine
        '
        Me.rbProgressLine.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbProgressLine.IconSet"), System.Drawing.Image)))
        Me.rbProgressLine.Name = "rbProgressLine"
        Me.rbProgressLine.Text = "Progress Line"
        Me.rbProgressLine.ToolTip = "Progress Line"
        '
        'ribbonTab2
        '
        Me.ribbonTab2.Groups.Add(Me.ribbonGroup7)
        Me.ribbonTab2.Name = "ribbonTab2"
        Me.ribbonTab2.Text = "RESOURCE"
        '
        'ribbonGroup7
        '
        Me.ribbonGroup7.Items.Add(Me.rbResources)
        Me.ribbonGroup7.Name = "ribbonGroup7"
        Me.ribbonGroup7.Text = "Assignments"
        '
        'rbResources
        '
        Me.rbResources.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbResources.IconSet"), System.Drawing.Image)))
        Me.rbResources.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbResources.IconSet1"), System.Drawing.Image)))
        Me.rbResources.Name = "rbResources"
        Me.rbResources.Text = "Resources"
        Me.rbResources.ToolTip = "Project Resources"
        '
        'ribbonTab3
        '
        Me.ribbonTab3.Groups.Add(Me.ribbonGroup8)
        Me.ribbonTab3.Name = "ribbonTab3"
        Me.ribbonTab3.Text = "PROJECT"
        '
        'ribbonGroup8
        '
        Me.ribbonGroup8.Items.Add(Me.rbProjectInfo)
        Me.ribbonGroup8.Items.Add(Me.rbChangeWorkingTime)
        Me.ribbonGroup8.Name = "ribbonGroup8"
        Me.ribbonGroup8.Text = "Properties"
        '
        'rbProjectInfo
        '
        Me.rbProjectInfo.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbProjectInfo.IconSet"), System.Drawing.Image)))
        Me.rbProjectInfo.Name = "rbProjectInfo"
        Me.rbProjectInfo.Text = "Project Information"
        '
        'rbChangeWorkingTime
        '
        Me.rbChangeWorkingTime.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbChangeWorkingTime.IconSet"), System.Drawing.Image)))
        Me.rbChangeWorkingTime.Name = "rbChangeWorkingTime"
        Me.rbChangeWorkingTime.Text = "Change Working Time"
        Me.rbChangeWorkingTime.ToolTip = "Change Working Time"
        '
        'ribbonTab5
        '
        Me.ribbonTab5.Groups.Add(Me.ribbonGroup11)
        Me.ribbonTab5.Groups.Add(Me.ribbonGroup6)
        Me.ribbonTab5.Groups.Add(Me.ribbonGroup10)
        Me.ribbonTab5.Name = "ribbonTab5"
        Me.ribbonTab5.Text = "VIEW"
        '
        'ribbonGroup11
        '
        Me.ribbonGroup11.Items.Add(Me.rcbTimeline)
        Me.ribbonGroup11.Items.Add(Me.ribbonMenu1)
        Me.ribbonGroup11.Items.Add(Me.rbZoomEntireProject)
        Me.ribbonGroup11.Items.Add(Me.rbZoomSelectedTask)
        Me.ribbonGroup11.Name = "ribbonGroup11"
        Me.ribbonGroup11.Text = "Zoom"
        '
        'rcbTimeline
        '
        Me.rcbTimeline.Label = "Timescale:"
        Me.rcbTimeline.MenuItems.Add(Me.rbTimescale2)
        Me.rcbTimeline.Name = "rcbTimeline"
        '
        'rbTimescale2
        '
        Me.rbTimescale2.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbTimescale2.IconSet"), System.Drawing.Image)))
        Me.rbTimescale2.Name = "rbTimescale2"
        Me.rbTimescale2.Text = "&Timescale..."
        '
        'ribbonMenu1
        '
        Me.ribbonMenu1.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("ribbonMenu1.IconSet"), System.Drawing.Image)))
        Me.ribbonMenu1.Items.Add(Me.rbZoomOut)
        Me.ribbonMenu1.Items.Add(Me.rbZoomIn)
        Me.ribbonMenu1.Items.Add(Me.ribbonSeparator11)
        Me.ribbonMenu1.Items.Add(Me.rbZoomDialog)
        Me.ribbonMenu1.Name = "ribbonMenu1"
        Me.ribbonMenu1.Text = "Zoom"
        Me.ribbonMenu1.ToolTip = "Zoom"
        '
        'rbZoomOut
        '
        Me.rbZoomOut.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbZoomOut.IconSet"), System.Drawing.Image)))
        Me.rbZoomOut.Name = "rbZoomOut"
        Me.rbZoomOut.Text = "Zoom &Out"
        '
        'rbZoomIn
        '
        Me.rbZoomIn.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbZoomIn.IconSet"), System.Drawing.Image)))
        Me.rbZoomIn.Name = "rbZoomIn"
        Me.rbZoomIn.Text = "Zoom &In"
        '
        'ribbonSeparator11
        '
        Me.ribbonSeparator11.Name = "ribbonSeparator11"
        '
        'rbZoomDialog
        '
        Me.rbZoomDialog.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbZoomDialog.IconSet"), System.Drawing.Image)))
        Me.rbZoomDialog.Name = "rbZoomDialog"
        Me.rbZoomDialog.Text = "&Zoom..."
        '
        'rbZoomEntireProject
        '
        Me.rbZoomEntireProject.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbZoomEntireProject.IconSet"), System.Drawing.Image)))
        Me.rbZoomEntireProject.Name = "rbZoomEntireProject"
        Me.rbZoomEntireProject.Text = "Entire Project"
        Me.rbZoomEntireProject.ToolTip = "Zoom entire project."
        '
        'rbZoomSelectedTask
        '
        Me.rbZoomSelectedTask.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbZoomSelectedTask.IconSet"), System.Drawing.Image)))
        Me.rbZoomSelectedTask.Name = "rbZoomSelectedTask"
        Me.rbZoomSelectedTask.Text = "Selected Task"
        Me.rbZoomSelectedTask.ToolTip = "Zoom the selected task."
        '
        'ribbonGroup6
        '
        Me.ribbonGroup6.Items.Add(Me.rcbGroupBy)
        Me.ribbonGroup6.Items.Add(Me.rcbMaintainHierarchy)
        Me.ribbonGroup6.Name = "ribbonGroup6"
        Me.ribbonGroup6.Text = "Group"
        '
        'rcbGroupBy
        '
        Me.rcbGroupBy.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcbGroupBy.IconSet"), System.Drawing.Image)))
        Me.rcbGroupBy.Items.Add(Me.rbNoGroup)
        Me.rcbGroupBy.Items.Add(Me.rbTaskMode)
        Me.rcbGroupBy.Items.Add(Me.rbTaskComplete)
        Me.rcbGroupBy.Items.Add(Me.rbConstraintType)
        Me.rcbGroupBy.Items.Add(Me.rbDuration)
        Me.rcbGroupBy.Items.Add(Me.rbMilestones)
        Me.rcbGroupBy.Items.Add(Me.rbResource)
        Me.rcbGroupBy.Items.Add(Me.rbStatus)
        Me.rcbGroupBy.Items.Add(Me.rbAdvanceGroup)
        Me.rcbGroupBy.Label = "Group By"
        Me.rcbGroupBy.MaxDropDownItems = 10
        Me.rcbGroupBy.Name = "rcbGroupBy"
        '
        'rbNoGroup
        '
        Me.rbNoGroup.Name = "rbNoGroup"
        Me.rbNoGroup.Text = "[No Group]"
        '
        'rbTaskMode
        '
        Me.rbTaskMode.Name = "rbTaskMode"
        Me.rbTaskMode.Text = "Task Mode"
        '
        'rbTaskComplete
        '
        Me.rbTaskComplete.Name = "rbTaskComplete"
        Me.rbTaskComplete.Text = "Task Complete vs Task InComplete"
        '
        'rbConstraintType
        '
        Me.rbConstraintType.Name = "rbConstraintType"
        Me.rbConstraintType.Text = "Constraint Type"
        '
        'rbDuration
        '
        Me.rbDuration.Name = "rbDuration"
        Me.rbDuration.Text = "Duration"
        '
        'rbMilestones
        '
        Me.rbMilestones.Name = "rbMilestones"
        Me.rbMilestones.Text = "Milestones"
        '
        'rbResource
        '
        Me.rbResource.Name = "rbResource"
        Me.rbResource.Text = "Resource"
        '
        'rbStatus
        '
        Me.rbStatus.Name = "rbStatus"
        Me.rbStatus.Text = "Status"
        '
        'rbAdvanceGroup
        '
        Me.rbAdvanceGroup.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbAdvanceGroup.IconSet"), System.Drawing.Image)))
        Me.rbAdvanceGroup.Name = "rbAdvanceGroup"
        Me.rbAdvanceGroup.Text = "Advance Group"
        '
        'rcbMaintainHierarchy
        '
        Me.rcbMaintainHierarchy.Name = "rcbMaintainHierarchy"
        Me.rcbMaintainHierarchy.Text = "Maintain Hierarchy"
        '
        'ribbonGroup10
        '
        Me.ribbonGroup10.Items.Add(Me.rcbFilter)
        Me.ribbonGroup10.Items.Add(Me.rcbShowRelatedSummaryRows)
        Me.ribbonGroup10.Name = "ribbonGroup10"
        Me.ribbonGroup10.Text = "Filter"
        '
        'rcbFilter
        '
        Me.rcbFilter.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcbFilter.IconSet"), System.Drawing.Image)))
        Me.rcbFilter.Items.Add(Me.rbNoFilter)
        Me.rcbFilter.Items.Add(Me.rbCompletedTasksFilter)
        Me.rcbFilter.Items.Add(Me.rbDateRangeFilter)
        Me.rcbFilter.Items.Add(Me.rbIncompleteTasksFilter)
        Me.rcbFilter.Items.Add(Me.rbLateTasksFilter)
        Me.rcbFilter.Items.Add(Me.rbMilestonesFilter)
        Me.rcbFilter.Items.Add(Me.rbSummaryTasksFilter)
        Me.rcbFilter.Items.Add(Me.rbDurationOnlyTasksFilter)
        Me.rcbFilter.Items.Add(Me.rbUsingResourceFilter)
        Me.rcbFilter.Items.Add(Me.rbAdvancedFilter)
        Me.rcbFilter.Items.Add(Me.rbMoreFilters)
        Me.rcbFilter.Label = "Filter:"
        Me.rcbFilter.Name = "rcbFilter"
        '
        'rbNoFilter
        '
        Me.rbNoFilter.Name = "rbNoFilter"
        Me.rbNoFilter.Text = "No Filter"
        '
        'rbCompletedTasksFilter
        '
        Me.rbCompletedTasksFilter.Name = "rbCompletedTasksFilter"
        Me.rbCompletedTasksFilter.Text = "Completed Tasks"
        Me.rbCompletedTasksFilter.TextImageRelation = C1.Win.Ribbon.TextImageRelation.ImageAboveText
        '
        'rbDateRangeFilter
        '
        Me.rbDateRangeFilter.Name = "rbDateRangeFilter"
        Me.rbDateRangeFilter.Text = "Date Range..."
        '
        'rbIncompleteTasksFilter
        '
        Me.rbIncompleteTasksFilter.Name = "rbIncompleteTasksFilter"
        Me.rbIncompleteTasksFilter.Text = "Incomplete Tasks"
        '
        'rbLateTasksFilter
        '
        Me.rbLateTasksFilter.Name = "rbLateTasksFilter"
        Me.rbLateTasksFilter.Text = "Late Tasks"
        '
        'rbMilestonesFilter
        '
        Me.rbMilestonesFilter.Name = "rbMilestonesFilter"
        Me.rbMilestonesFilter.Text = "Milestones"
        '
        'rbSummaryTasksFilter
        '
        Me.rbSummaryTasksFilter.Name = "rbSummaryTasksFilter"
        Me.rbSummaryTasksFilter.Text = "Summary Tasks"
        '
        'rbDurationOnlyTasksFilter
        '
        Me.rbDurationOnlyTasksFilter.Name = "rbDurationOnlyTasksFilter"
        Me.rbDurationOnlyTasksFilter.Text = "Tasks With Duration Only"
        '
        'rbUsingResourceFilter
        '
        Me.rbUsingResourceFilter.Name = "rbUsingResourceFilter"
        Me.rbUsingResourceFilter.Text = "Using Resource..."
        '
        'rbAdvancedFilter
        '
        Me.rbAdvancedFilter.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbAdvancedFilter.IconSet"), System.Drawing.Image)))
        Me.rbAdvancedFilter.Name = "rbAdvancedFilter"
        Me.rbAdvancedFilter.Text = "Advanced Filter..."
        '
        'rbMoreFilters
        '
        Me.rbMoreFilters.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rbMoreFilters.IconSet"), System.Drawing.Image)))
        Me.rbMoreFilters.Name = "rbMoreFilters"
        Me.rbMoreFilters.Text = "More Filters..."
        '
        'rcbShowRelatedSummaryRows
        '
        Me.rcbShowRelatedSummaryRows.Name = "rcbShowRelatedSummaryRows"
        Me.rcbShowRelatedSummaryRows.Text = "Show Related Summary Rows"
        '
        'ribbonTab4
        '
        Me.ribbonTab4.Groups.Add(Me.ribbonGroup9)
        Me.ribbonTab4.Name = "ribbonTab4"
        Me.ribbonTab4.Text = "FORMATTING"
        '
        'ribbonGroup9
        '
        Me.ribbonGroup9.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("ribbonGroup9.IconSet"), System.Drawing.Image)))
        Me.ribbonGroup9.Items.Add(Me.ribbonMenu3)
        Me.ribbonGroup9.Items.Add(Me.rbBarStyles)
        Me.ribbonGroup9.Name = "ribbonGroup9"
        Me.ribbonGroup9.Text = "General"
        '
        'ribbonMenu3
        '
        Me.ribbonMenu3.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("ribbonMenu3.IconSet"), System.Drawing.Image)))
        Me.ribbonMenu3.Items.Add(Me.ribbonLabel4)
        Me.ribbonMenu3.Items.Add(Me.rcpCellBorder)
        Me.ribbonMenu3.Items.Add(Me.rcpEmptyAreaBack)
        Me.ribbonMenu3.Items.Add(Me.rcpFixedBackground)
        Me.ribbonMenu3.Items.Add(Me.rcpFixedCellBorder)
        Me.ribbonMenu3.Items.Add(Me.rcpFixedForeground)
        Me.ribbonMenu3.Items.Add(Me.rcpHightlightBackground)
        Me.ribbonMenu3.Items.Add(Me.rcpHightlightForeground)
        Me.ribbonMenu3.Items.Add(Me.rcpNonworkingTime)
        Me.ribbonMenu3.Items.Add(Me.rcpSplitter)
        Me.ribbonMenu3.Items.Add(Me.rcpStartFinishLine)
        Me.ribbonMenu3.Items.Add(Me.rcpTodayLine)
        Me.ribbonMenu3.Name = "ribbonMenu3"
        Me.ribbonMenu3.Text = "Colors"
        Me.ribbonMenu3.ToolTip = "Change colors appearance of control."
        '
        'ribbonLabel4
        '
        Me.ribbonLabel4.Name = "ribbonLabel4"
        Me.ribbonLabel4.Text = "Set Color"
        '
        'rcpCellBorder
        '
        Me.rcpCellBorder.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpCellBorder.IconSet"), System.Drawing.Image)))
        Me.rcpCellBorder.Name = "rcpCellBorder"
        Me.rcpCellBorder.Text = "Cell Border"
        '
        'rcpEmptyAreaBack
        '
        Me.rcpEmptyAreaBack.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpEmptyAreaBack.IconSet"), System.Drawing.Image)))
        Me.rcpEmptyAreaBack.Name = "rcpEmptyAreaBack"
        Me.rcpEmptyAreaBack.Text = "Empty Area Background"
        '
        'rcpFixedBackground
        '
        Me.rcpFixedBackground.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpFixedBackground.IconSet"), System.Drawing.Image)))
        Me.rcpFixedBackground.Name = "rcpFixedBackground"
        Me.rcpFixedBackground.Text = "Fixed Background"
        '
        'rcpFixedCellBorder
        '
        Me.rcpFixedCellBorder.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpFixedCellBorder.IconSet"), System.Drawing.Image)))
        Me.rcpFixedCellBorder.Name = "rcpFixedCellBorder"
        Me.rcpFixedCellBorder.Text = "Fixed Cell Border"
        '
        'rcpFixedForeground
        '
        Me.rcpFixedForeground.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpFixedForeground.IconSet"), System.Drawing.Image)))
        Me.rcpFixedForeground.Name = "rcpFixedForeground"
        Me.rcpFixedForeground.Text = "Fixed Foreground"
        '
        'rcpHightlightBackground
        '
        Me.rcpHightlightBackground.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpHightlightBackground.IconSet"), System.Drawing.Image)))
        Me.rcpHightlightBackground.Name = "rcpHightlightBackground"
        Me.rcpHightlightBackground.Text = "Highlight Background"
        '
        'rcpHightlightForeground
        '
        Me.rcpHightlightForeground.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpHightlightForeground.IconSet"), System.Drawing.Image)))
        Me.rcpHightlightForeground.Name = "rcpHightlightForeground"
        Me.rcpHightlightForeground.Text = "Highlight Foreground"
        '
        'rcpNonworkingTime
        '
        Me.rcpNonworkingTime.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpNonworkingTime.IconSet"), System.Drawing.Image)))
        Me.rcpNonworkingTime.Name = "rcpNonworkingTime"
        Me.rcpNonworkingTime.Text = "Nonworking Time"
        '
        'rcpSplitter
        '
        Me.rcpSplitter.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpSplitter.IconSet"), System.Drawing.Image)))
        Me.rcpSplitter.Name = "rcpSplitter"
        Me.rcpSplitter.Text = "Splitter"
        '
        'rcpStartFinishLine
        '
        Me.rcpStartFinishLine.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpStartFinishLine.IconSet"), System.Drawing.Image)))
        Me.rcpStartFinishLine.Name = "rcpStartFinishLine"
        Me.rcpStartFinishLine.Text = "Start Finish Line"
        '
        'rcpTodayLine
        '
        Me.rcpTodayLine.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, CType(resources.GetObject("rcpTodayLine.IconSet"), System.Drawing.Image)))
        Me.rcpTodayLine.Name = "rcpTodayLine"
        Me.rcpTodayLine.Text = "Today Line"
        '
        'rbBarStyles
        '
        Me.rbBarStyles.IconSet.Add(New C1.Framework.C1BitmapIcon(Nothing, New System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, CType(resources.GetObject("rbBarStyles.IconSet"), System.Drawing.Image)))
        Me.rbBarStyles.Name = "rbBarStyles"
        Me.rbBarStyles.Text = "Bar Styles"
        Me.rbBarStyles.ToolTip = "Bar Styles"
        '
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'statusBar
        '
        Me.statusBar.LeftPaneItems.Add(Me.rlLeftStatus)
        Me.statusBar.Location = New System.Drawing.Point(0, 598)
        Me.statusBar.Name = "statusBar"
        Me.statusBar.RightPaneItems.Add(Me.rtbZoom)
        Me.statusBar.Size = New System.Drawing.Size(1117, 28)
        '
        'rlLeftStatus
        '
        Me.rlLeftStatus.Name = "rlLeftStatus"
        Me.rlLeftStatus.Text = "READY"
        '
        'rtbZoom
        '
        Me.rtbZoom.Maximum = 11
        Me.rtbZoom.Minimum = 1
        Me.rtbZoom.Name = "rtbZoom"
        Me.rtbZoom.StepFrequency = 1
        Me.rtbZoom.TickFrequency = 6
        Me.rtbZoom.ToolTip = "Zoom"
        Me.rtbZoom.Value = 1
        Me.rtbZoom.Width = 200
        '
        'ganttView
        '
        Me.ganttView.BackColor = System.Drawing.SystemColors.Window
        BarStyle1.BarShape = C1.Win.C1GanttView.BarShape.TopBar
        BarStyle1.BarType = C1.Win.C1GanttView.BarType.SummaryTask
        BarStyle1.EndShape = 2
        BarStyle1.StartShape = 2
        BarStyle2.BarColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        BarStyle2.BarShape = C1.Win.C1GanttView.BarShape.MiddleBar
        BarStyle2.BarType = C1.Win.C1GanttView.BarType.Progress
        BarStyle3.BarColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(209, Byte), Integer))
        BarStyle3.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle3.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle3.EndShape = 22
        BarStyle3.RightText1_ID = -13
        BarStyle3.StartShape = 21
        BarStyle4.BarColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(220, Byte), Integer))
        BarStyle4.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle4.BarType = C1.Win.C1GanttView.BarType.AutoTask
        BarStyle4.RightText1_ID = -13
        BarStyle5.BarType = C1.Win.C1GanttView.BarType.Deadline
        BarStyle5.StartColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        BarStyle5.StartShape = 12
        BarStyle7.BarColor = System.Drawing.Color.Pink
        BarStyle7.BarShape = C1.Win.C1GanttView.BarShape.MiddleBar
        BarStyle7.BarType = C1.Win.C1GanttView.BarType.SummaryProgress
        Me.ganttView.BarStyles.Add(BarStyle1)
        Me.ganttView.BarStyles.Add(BarStyle2)
        Me.ganttView.BarStyles.Add(BarStyle3)
        Me.ganttView.BarStyles.Add(BarStyle4)
        Me.ganttView.BarStyles.Add(BarStyle5)
        Me.ganttView.BarStyles.Add(BarStyle6)
        Me.ganttView.BarStyles.Add(BarStyle7)
        CalendarException1.Name = "Vacation"
        CalendarException1.RecurrencePattern.DayOfMonth = 10
        CalendarException1.RecurrencePattern.MonthOfYear = 7
        CalendarException1.StartDate = New Date(2013, 6, 10, 0, 0, 0, 0)
        Me.ganttView.CalendarExceptions.Add(CalendarException1)
        Me.ganttView.CellBorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ganttView.ChartViewZoomFactor = 6.659091!
        TaskPropertyColumn1.Caption = "Task Mode"
        TaskPropertyColumn1.ID = 619243840
        TaskPropertyColumn1.Property = C1.Win.C1GanttView.TaskProperty.Mode
        TaskPropertyColumn1.Width = 70
        TaskPropertyColumn2.Caption = "Task Name"
        TaskPropertyColumn2.ID = 2099866733
        TaskPropertyColumn2.Property = C1.Win.C1GanttView.TaskProperty.Name
        TaskPropertyColumn3.Caption = "Duration"
        TaskPropertyColumn3.ID = 1358251825
        TaskPropertyColumn3.Property = C1.Win.C1GanttView.TaskProperty.Duration
        TaskPropertyColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        TaskPropertyColumn3.Width = 50
        TaskPropertyColumn4.Caption = "Duration Units"
        TaskPropertyColumn4.ID = 1827635185
        TaskPropertyColumn4.Property = C1.Win.C1GanttView.TaskProperty.DurationUnits
        TaskPropertyColumn4.Width = 85
        TaskPropertyColumn5.Caption = "Start"
        TaskPropertyColumn5.ID = 1435981949
        TaskPropertyColumn5.Property = C1.Win.C1GanttView.TaskProperty.Start
        TaskPropertyColumn5.Visible = False
        TaskPropertyColumn6.Caption = "Finish"
        TaskPropertyColumn6.ID = 1177114106
        TaskPropertyColumn6.Property = C1.Win.C1GanttView.TaskProperty.Finish
        TaskPropertyColumn6.Visible = False
        TaskPropertyColumn7.Caption = "% Complete"
        TaskPropertyColumn7.ID = 705116663
        TaskPropertyColumn7.Property = C1.Win.C1GanttView.TaskProperty.PercentComplete
        TaskPropertyColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        TaskPropertyColumn8.Caption = "Constraint Type"
        TaskPropertyColumn8.ID = 1424686126
        TaskPropertyColumn8.Property = C1.Win.C1GanttView.TaskProperty.ConstraintType
        TaskPropertyColumn8.Visible = False
        TaskPropertyColumn9.Caption = "Constraint Date"
        TaskPropertyColumn9.ID = 1191399244
        TaskPropertyColumn9.Property = C1.Win.C1GanttView.TaskProperty.ConstraintDate
        TaskPropertyColumn9.Visible = False
        TaskPropertyColumn10.Caption = "Predecessors"
        TaskPropertyColumn10.ID = 502674747
        TaskPropertyColumn10.Property = C1.Win.C1GanttView.TaskProperty.Predecessors
        TaskPropertyColumn10.Visible = False
        TaskPropertyColumn11.Caption = "Deadline"
        TaskPropertyColumn11.ID = 166462627
        TaskPropertyColumn11.Property = C1.Win.C1GanttView.TaskProperty.Deadline
        TaskPropertyColumn11.Visible = False
        TaskPropertyColumn12.Caption = "Calendar"
        TaskPropertyColumn12.ID = 997563278
        TaskPropertyColumn12.Property = C1.Win.C1GanttView.TaskProperty.Calendar
        TaskPropertyColumn12.Visible = False
        TaskPropertyColumn13.Caption = "Resource Names"
        TaskPropertyColumn13.ID = 1673084976
        TaskPropertyColumn13.Property = C1.Win.C1GanttView.TaskProperty.ResourceNames
        TaskPropertyColumn13.Visible = False
        TaskPropertyColumn14.Caption = "Notes"
        TaskPropertyColumn14.ID = 1052675343
        TaskPropertyColumn14.Property = C1.Win.C1GanttView.TaskProperty.Notes
        TaskPropertyColumn14.Visible = False
        Me.ganttView.Columns.Add(TaskPropertyColumn1)
        Me.ganttView.Columns.Add(TaskPropertyColumn2)
        Me.ganttView.Columns.Add(TaskPropertyColumn3)
        Me.ganttView.Columns.Add(TaskPropertyColumn4)
        Me.ganttView.Columns.Add(TaskPropertyColumn5)
        Me.ganttView.Columns.Add(TaskPropertyColumn6)
        Me.ganttView.Columns.Add(TaskPropertyColumn7)
        Me.ganttView.Columns.Add(TaskPropertyColumn8)
        Me.ganttView.Columns.Add(TaskPropertyColumn9)
        Me.ganttView.Columns.Add(TaskPropertyColumn10)
        Me.ganttView.Columns.Add(TaskPropertyColumn11)
        Me.ganttView.Columns.Add(TaskPropertyColumn12)
        Me.ganttView.Columns.Add(TaskPropertyColumn13)
        Me.ganttView.Columns.Add(TaskPropertyColumn14)
        '
        '
        '
        Me.ganttView.DefaultWorkingTimes.Interval_1.Empty = False
        Me.ganttView.DefaultWorkingTimes.Interval_1.From = New Date(1, 1, 1, 8, 30, 0, 0)
        Me.ganttView.DefaultWorkingTimes.Interval_1.To = New Date(1, 1, 1, 12, 0, 0, 0)
        Me.ganttView.DefaultWorkingTimes.Interval_2.Empty = False
        Me.ganttView.DefaultWorkingTimes.Interval_2.From = New Date(1, 1, 1, 13, 30, 0, 0)
        Me.ganttView.DefaultWorkingTimes.Interval_2.To = New Date(1, 1, 1, 18, 0, 0, 0)
        Me.ganttView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ganttView.EnablePrinting = True
        Me.ganttView.FirstMonthOfFY = C1.Win.C1GanttView.FirstMonthOfFY.March
        Me.ganttView.FixedBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ganttView.FixedCellBorderColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ganttView.FixedForeColor = System.Drawing.Color.Black
        Me.ganttView.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ganttView.GridWidth = 430
        Me.ganttView.GroupColumn = Nothing
        Me.ganttView.HighlightBackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.ganttView.HighlightForeColor = System.Drawing.Color.Black
        Me.ganttView.Location = New System.Drawing.Point(0, 201)
        Me.ganttView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ganttView.Name = "ganttView"
        Me.ganttView.NonworkingTimeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.ganttView.PrintInfo.LegendTextAreaWidth = 2.0!
        Me.ganttView.PrintInfo.PreviewHelper.C1PrintPreviewDialog = Nothing
        Me.ganttView.PrintInfo.PreviewHelper.Caption = "Print Preview"
        Me.ganttView.PrintInfo.PrintType = C1.Win.C1GanttView.Printing.PrintType.General
        Me.ganttView.PrintInfo.StyleSource = "General.c1d"
        Me.ganttView.ProgressLine.StatusDate = New Date(2013, 7, 18, 0, 0, 0, 0)
        Me.ganttView.ProgressLine.Visible = True
        Task1.ID = 1331333418
        Task1.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task1.Name = "Project Summary Task"
        Task1.NextID = 0
        Task1.PercentComplete = 0.376278560965452R
        Me.ganttView.ProjectSummary = Task1
        Resource1.Cost = New Decimal(New Integer() {100, 0, 0, 0})
        Resource1.ID = 1640417825
        Resource1.Name = "Rita Been"
        Resource1.NextID = 0
        Resource1.Notes = "Tester"
        Resource2.Cost = New Decimal(New Integer() {250, 0, 0, 0})
        Resource2.ID = 239555279
        Resource2.Name = "Eric Smith"
        Resource2.NextID = 0
        Resource2.Notes = "Project Manager"
        Resource3.Cost = New Decimal(New Integer() {150, 0, 0, 0})
        Resource3.ID = 766290656
        Resource3.Name = "Daniel Hank"
        Resource3.NextID = 0
        Resource3.Notes = "Analyst"
        Resource4.Cost = New Decimal(New Integer() {300, 0, 0, 0})
        Resource4.ID = 2011144056
        Resource4.Name = "Juan Carlos"
        Resource4.NextID = 0
        Resource4.Notes = "Developer"
        Resource5.Cost = New Decimal(New Integer() {100, 0, 0, 0})
        Resource5.ID = 448108000
        Resource5.Name = "Mike Jones "
        Resource5.NextID = 0
        Resource5.Notes = "Developer"
        Resource6.Cost = New Decimal(New Integer() {400, 0, 0, 0})
        Resource6.ID = 1869891731
        Resource6.Name = "Chris Lee"
        Resource6.NextID = 0
        Resource6.Notes = "Developer"
        Resource7.Cost = New Decimal(New Integer() {250, 0, 0, 0})
        Resource7.ID = 556319480
        Resource7.Name = "Sarah Robert"
        Resource7.NextID = 0
        Resource7.Notes = "Tester"
        Resource8.Cost = New Decimal(New Integer() {200, 0, 0, 0})
        Resource8.ID = 1334638351
        Resource8.Name = "Micheal Owen"
        Resource8.NextID = 0
        Resource8.Notes = "Documentation Maker"
        Resource9.Cost = New Decimal(New Integer() {150, 0, 0, 0})
        Resource9.ID = 2101511829
        Resource9.Name = "Juliet Paul"
        Resource9.NextID = 0
        Resource9.Notes = "Documentation Maker"
        Me.ganttView.Resources.AddRange(New C1.Win.C1GanttView.Resource() {Resource1, Resource2, Resource3, Resource4, Resource5, Resource6, Resource7, Resource8, Resource9})
        Me.ganttView.ShowToolbar = False
        Me.ganttView.Size = New System.Drawing.Size(1117, 397)
        Me.ganttView.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.ganttView.StartDate = New Date(2013, 6, 5, 0, 0, 0, 0)
        Me.ganttView.TabIndex = 4
        BarStyle8.BarColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(209, Byte), Integer))
        BarStyle8.BarShape = C1.Win.C1GanttView.BarShape.TopLine
        BarStyle8.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle8.EndShape = 15
        BarStyle8.RightText1_ID = -13
        BarStyle8.StartShape = 15
        BarStyle8.TopText1_ID = 2099866733
        Task2.BarStyles.Add(BarStyle8)
        Task2.Finish = New Date(2013, 6, 25, 8, 30, 0, 0)
        Task2.ID = 1647280566
        Task2.Name = "Analysis/Software Requirements"
        Task2.NextID = 894531595
        Task2.OutlineParentID = 1331333418
        Task2.PercentComplete = 0.99R
        Task2.Start = New Date(2013, 6, 5, 0, 0, 0, 0)
        BarStyle9.BarColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(220, Byte), Integer))
        BarStyle9.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle9.BarType = C1.Win.C1GanttView.BarType.AutoTask
        BarStyle9.RightText1_ID = -13
        Task3.BarStyles.Add(BarStyle9)
        Task3.Finish = New Date(2013, 6, 13, 8, 30, 0, 0)
        Task3.ID = 894531595
        Task3.Name = "Analysis requirements"
        Task3.NextID = 272795686
        Task3.OutlineParentID = 1647280566
        Task3.PercentComplete = 1.0R
        ResourceRef1.Amount = 1.0R
        ResourceRef1.ResourceID = 239555279
        ResourceRef2.Amount = 1.0R
        ResourceRef2.ResourceID = 766290656
        Task3.ResourceRefs.Add(ResourceRef1)
        Task3.ResourceRefs.Add(ResourceRef2)
        Task3.Start = New Date(2013, 6, 5, 0, 0, 0, 0)
        BarStyle10.BarColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(220, Byte), Integer))
        BarStyle10.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle10.BarType = C1.Win.C1GanttView.BarType.AutoTask
        BarStyle10.RightText1_ID = -13
        Task4.BarStyles.Add(BarStyle10)
        Task4.Duration = 6.0R
        Task4.ID = 272795686
        Task4.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task4.Name = "Wrting Specifications"
        Task4.NextID = 738728450
        Task4.OutlineParentID = 1647280566
        Task4.PercentComplete = 1.0R
        Predecessor1.PredecessorTaskID = 894531595
        Task4.Predecessors.Add(Predecessor1)
        ResourceRef3.Amount = 1.0R
        ResourceRef3.ResourceID = 766290656
        Task4.ResourceRefs.Add(ResourceRef3)
        Task5.ConstraintDate = New Date(2013, 6, 20, 8, 30, 0, 0)
        Task5.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
        Task5.Duration = 2.0R
        Task5.ID = 738728450
        Task5.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task5.Name = "Review Specificaions"
        Task5.NextID = 1192056988
        Task5.OutlineParentID = 1647280566
        Task5.PercentComplete = 1.0R
        Predecessor2.PredecessorTaskID = 272795686
        Task5.Predecessors.Add(Predecessor2)
        ResourceRef4.Amount = 1.0R
        ResourceRef4.ResourceID = 239555279
        ResourceRef5.Amount = 1.0R
        ResourceRef5.ResourceID = 766290656
        Task5.ResourceRefs.Add(ResourceRef4)
        Task5.ResourceRefs.Add(ResourceRef5)
        BarStyle11.BarType = C1.Win.C1GanttView.BarType.Milestone
        BarStyle11.EndShape = 3
        BarStyle11.RightText1_ID = -7
        BarStyle11.TopText1_ID = 2099866733
        Task6.BarStyles.Add(BarStyle11)
        Task6.Finish = New Date(2013, 6, 25, 8, 30, 0, 0)
        Task6.ID = 1192056988
        Task6.Name = "Analysis complete"
        Task6.NextID = 1713945315
        Task6.OutlineParentID = 1647280566
        Predecessor3.PredecessorTaskID = 738728450
        Task6.Predecessors.Add(Predecessor3)
        Task6.Start = New Date(2013, 6, 25, 8, 30, 0, 0)
        Task7.ID = 1713945315
        Task7.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task7.Name = "Design"
        Task7.NextID = 21199245
        Task7.OutlineParentID = 1331333418
        Task7.PercentComplete = 0.99R
        Task8.ConstraintDate = New Date(2013, 6, 25, 0, 0, 0, 0)
        Task8.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
        Task8.Duration = 5.0R
        Task8.ID = 21199245
        Task8.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task8.Name = "Develop functional specifications"
        Task8.NextID = 101520938
        Task8.OutlineParentID = 1713945315
        Task8.PercentComplete = 1.0R
        Predecessor4.PredecessorTaskID = 1192056988
        Task8.Predecessors.Add(Predecessor4)
        ResourceRef6.Amount = 1.0R
        ResourceRef6.ResourceID = 766290656
        Task8.ResourceRefs.Add(ResourceRef6)
        Task9.Duration = 4.0R
        Task9.ID = 101520938
        Task9.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task9.Name = "Develop prototype based on specifications"
        Task9.NextID = 50424750
        Task9.OutlineParentID = 1713945315
        Task9.PercentComplete = 1.0R
        Predecessor5.PredecessorTaskID = 21199245
        Task9.Predecessors.Add(Predecessor5)
        ResourceRef7.Amount = 1.0R
        ResourceRef7.ResourceID = 766290656
        Task9.ResourceRefs.Add(ResourceRef7)
        Task10.ConstraintDate = New Date(2013, 7, 4, 0, 0, 0, 0)
        Task10.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
        Task10.Duration = 2.0R
        Task10.ID = 50424750
        Task10.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task10.Name = "Obtain approval to proceed"
        Task10.NextID = 1965547925
        Task10.OutlineParentID = 1713945315
        Task10.PercentComplete = 1.0R
        Predecessor6.PredecessorTaskID = 101520938
        Task10.Predecessors.Add(Predecessor6)
        ResourceRef8.Amount = 1.0R
        ResourceRef8.ResourceID = 766290656
        ResourceRef9.Amount = 1.0R
        ResourceRef9.ResourceID = 239555279
        Task10.ResourceRefs.Add(ResourceRef8)
        Task10.ResourceRefs.Add(ResourceRef9)
        BarStyle12.BarType = C1.Win.C1GanttView.BarType.Milestone
        BarStyle12.EndShape = 3
        BarStyle12.RightText1_ID = -7
        BarStyle12.TopText1_ID = 2099866733
        Task11.BarStyles.Add(BarStyle12)
        Task11.Finish = New Date(2013, 7, 11, 8, 30, 0, 0)
        Task11.ID = 1965547925
        Task11.Name = "Design complete"
        Task11.NextID = 614140209
        Task11.OutlineParentID = 1713945315
        Predecessor7.PredecessorTaskID = 50424750
        Task11.Predecessors.Add(Predecessor7)
        Task11.Start = New Date(2013, 7, 11, 8, 30, 0, 0)
        Task12.ID = 614140209
        Task12.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task12.Name = "Development"
        Task12.NextID = 480459017
        Task12.OutlineParentID = 1331333418
        Task12.PercentComplete = 0.28125R
        Task13.Finish = New Date(2013, 7, 12, 8, 30, 0, 0)
        Task13.ID = 480459017
        Task13.Name = "Assign Development"
        Task13.NextID = 129624615
        Task13.OutlineParentID = 614140209
        Task13.PercentComplete = 1.0R
        Predecessor8.PredecessorTaskID = 1965547925
        Task13.Predecessors.Add(Predecessor8)
        ResourceRef10.Amount = 1.0R
        ResourceRef10.ResourceID = 239555279
        Task13.ResourceRefs.Add(ResourceRef10)
        Task13.Start = New Date(2013, 7, 11, 8, 30, 0, 0)
        Task14.Finish = New Date(2013, 8, 2, 8, 30, 0, 0)
        Task14.ID = 129624615
        Task14.Name = "Develope code"
        Task14.NextID = 469259466
        Task14.OutlineParentID = 614140209
        Task14.PercentComplete = 0.2R
        Predecessor9.PredecessorTaskID = 480459017
        Task14.Predecessors.Add(Predecessor9)
        ResourceRef11.Amount = 1.0R
        ResourceRef11.ResourceID = 2011144056
        ResourceRef12.Amount = 1.0R
        ResourceRef12.ResourceID = 448108000
        ResourceRef13.Amount = 1.0R
        ResourceRef13.ResourceID = 1869891731
        Task14.ResourceRefs.Add(ResourceRef11)
        Task14.ResourceRefs.Add(ResourceRef12)
        Task14.ResourceRefs.Add(ResourceRef13)
        Task14.Start = New Date(2013, 7, 12, 8, 30, 0, 0)
        Task15.Deadline = New Date(2013, 8, 9, 0, 0, 0, 0)
        Task15.Finish = New Date(2013, 8, 8, 8, 30, 0, 0)
        Task15.ID = 469259466
        Task15.Name = "Developer testing"
        Task15.NextID = 1009463521
        Task15.OutlineParentID = 614140209
        Task15.PercentComplete = 0.3125R
        ResourceRef14.Amount = 1.0R
        ResourceRef14.ResourceID = 448108000
        ResourceRef15.Amount = 1.0R
        ResourceRef15.ResourceID = 1869891731
        Task15.ResourceRefs.Add(ResourceRef14)
        Task15.ResourceRefs.Add(ResourceRef15)
        Task15.Start = New Date(2013, 7, 17, 0, 0, 0, 0)
        BarStyle13.BarType = C1.Win.C1GanttView.BarType.Milestone
        BarStyle13.EndShape = 3
        BarStyle13.RightText1_ID = -7
        BarStyle13.TopText1_ID = 2099866733
        Task16.BarStyles.Add(BarStyle13)
        Task16.Finish = New Date(2013, 8, 8, 8, 30, 0, 0)
        Task16.ID = 1009463521
        Task16.Name = "Develop complete"
        Task16.NextID = 652233069
        Task16.OutlineParentID = 614140209
        Predecessor10.PredecessorTaskID = 469259466
        Predecessor11.PredecessorTaskID = 129624615
        Task16.Predecessors.Add(Predecessor10)
        Task16.Predecessors.Add(Predecessor11)
        Task16.Start = New Date(2013, 8, 8, 8, 30, 0, 0)
        BarStyle14.BarColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(209, Byte), Integer))
        BarStyle14.BarShape = C1.Win.C1GanttView.BarShape.TopLine
        BarStyle14.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle14.EndShape = 15
        BarStyle14.RightText1_ID = -13
        BarStyle14.StartShape = 15
        BarStyle14.TopText1_ID = 2099866733
        Task17.BarStyles.Add(BarStyle14)
        Task17.Finish = New Date(2013, 8, 29, 8, 30, 0, 0)
        Task17.ID = 652233069
        Task17.Name = "Testing"
        Task17.NextID = 1461039266
        Task17.OutlineParentID = 1331333418
        Task17.PercentComplete = 0.050505045454545455R
        Task17.Start = New Date(2013, 7, 11, 8, 30, 0, 0)
        Task18.Finish = New Date(2013, 7, 18, 8, 30, 0, 0)
        Task18.ID = 1461039266
        Task18.Name = "Build test plans using product"
        Task18.NextID = 1922770321
        Task18.OutlineParentID = 652233069
        Task18.PercentComplete = 0.3333333R
        Predecessor12.PredecessorTaskID = 1965547925
        Task18.Predecessors.Add(Predecessor12)
        ResourceRef16.Amount = 1.0R
        ResourceRef16.ResourceID = 1640417825
        Task18.ResourceRefs.Add(ResourceRef16)
        Task18.Start = New Date(2013, 7, 11, 8, 30, 0, 0)
        Task19.Deadline = New Date(2013, 8, 30, 0, 0, 0, 0)
        Task19.Finish = New Date(2013, 8, 29, 8, 30, 0, 0)
        Task19.ID = 1922770321
        Task19.Name = "Unit testing"
        Task19.NextID = 2035623366
        Task19.OutlineParentID = 652233069
        Predecessor13.PredecessorTaskID = 1461039266
        Predecessor14.PredecessorTaskID = 1009463521
        Task19.Predecessors.Add(Predecessor13)
        Task19.Predecessors.Add(Predecessor14)
        ResourceRef17.Amount = 1.0R
        ResourceRef17.ResourceID = 556319480
        ResourceRef18.Amount = 1.0R
        ResourceRef18.ResourceID = 1640417825
        Task19.ResourceRefs.Add(ResourceRef17)
        Task19.ResourceRefs.Add(ResourceRef18)
        Task19.Start = New Date(2013, 8, 8, 8, 30, 0, 0)
        Task20.Finish = New Date(2013, 8, 27, 8, 30, 0, 0)
        Task20.ID = 2035623366
        Task20.Name = "Integration testing"
        Task20.NextID = 85175043
        Task20.OutlineParentID = 652233069
        Predecessor15.PredecessorTaskID = 1461039266
        Predecessor16.PredecessorTaskID = 1009463521
        Task20.Predecessors.Add(Predecessor15)
        Task20.Predecessors.Add(Predecessor16)
        ResourceRef19.Amount = 1.0R
        ResourceRef19.ResourceID = 556319480
        Task20.ResourceRefs.Add(ResourceRef19)
        Task20.Start = New Date(2013, 8, 8, 8, 30, 0, 0)
        BarStyle15.BarType = C1.Win.C1GanttView.BarType.Milestone
        BarStyle15.EndShape = 3
        BarStyle15.RightText1_ID = -7
        BarStyle15.TopText1_ID = 2099866733
        Task21.BarStyles.Add(BarStyle15)
        Task21.Finish = New Date(2013, 8, 29, 8, 30, 0, 0)
        Task21.ID = 85175043
        Task21.Name = "Testing complete"
        Task21.NextID = 1840770827
        Task21.OutlineParentID = 652233069
        Predecessor17.PredecessorTaskID = 1922770321
        Predecessor18.PredecessorTaskID = 2035623366
        Task21.Predecessors.Add(Predecessor17)
        Task21.Predecessors.Add(Predecessor18)
        Task21.Start = New Date(2013, 8, 29, 8, 30, 0, 0)
        BarStyle16.BarColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(209, Byte), Integer))
        BarStyle16.BarShape = C1.Win.C1GanttView.BarShape.TopLine
        BarStyle16.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle16.EndShape = 15
        BarStyle16.RightText1_ID = -13
        BarStyle16.StartShape = 15
        BarStyle16.TopText1_ID = 2099866733
        Task22.BarStyles.Add(BarStyle16)
        Task22.Finish = New Date(2013, 8, 7, 8, 30, 0, 0)
        Task22.ID = 1840770827
        Task22.Name = "Documentation"
        Task22.NextID = 830835292
        Task22.OutlineParentID = 1331333418
        Task22.PercentComplete = 0.34479165097656234R
        Task22.Start = New Date(2013, 7, 15, 0, 0, 0, 0)
        Task23.DurationUnits = C1.Win.C1GanttView.DurationUnits.Weeks
        Task23.Finish = New Date(2013, 8, 3, 0, 0, 0, 0)
        Task23.ID = 830835292
        Task23.Name = "Develop Help system"
        Task23.NextID = 380370192
        Task23.OutlineParentID = 1840770827
        Task23.PercentComplete = 0.535555522083333R
        ResourceRef20.Amount = 1.0R
        ResourceRef20.ResourceID = 1334638351
        Task23.ResourceRefs.Add(ResourceRef20)
        Task23.Start = New Date(2013, 7, 15, 0, 0, 0, 0)
        Task24.DurationUnits = C1.Win.C1GanttView.DurationUnits.Weeks
        Task24.Finish = New Date(2013, 8, 3, 0, 0, 0, 0)
        Task24.ID = 380370192
        Task24.Name = "Develop user manuals"
        Task24.NextID = 1427890061
        Task24.OutlineParentID = 1840770827
        Task24.PercentComplete = 0.2R
        ResourceRef21.Amount = 1.0R
        ResourceRef21.ResourceID = 2101511829
        Task24.ResourceRefs.Add(ResourceRef21)
        Task24.Start = New Date(2013, 7, 15, 0, 0, 0, 0)
        Task25.Finish = New Date(2013, 8, 7, 8, 30, 0, 0)
        Task25.ID = 1427890061
        Task25.Name = "Review documentation"
        Task25.NextID = 491845964
        Task25.OutlineParentID = 1840770827
        Predecessor19.PredecessorTaskID = 830835292
        Predecessor20.PredecessorTaskID = 380370192
        Task25.Predecessors.Add(Predecessor19)
        Task25.Predecessors.Add(Predecessor20)
        ResourceRef22.Amount = 1.0R
        ResourceRef22.ResourceID = 239555279
        Task25.ResourceRefs.Add(ResourceRef22)
        Task25.Start = New Date(2013, 8, 5, 0, 0, 0, 0)
        BarStyle17.BarType = C1.Win.C1GanttView.BarType.Milestone
        BarStyle17.EndShape = 3
        BarStyle17.RightText1_ID = -7
        BarStyle17.TopText1_ID = 2099866733
        Task26.BarStyles.Add(BarStyle17)
        Task26.Finish = New Date(2013, 8, 7, 8, 30, 0, 0)
        Task26.ID = 491845964
        Task26.Name = "Documentation complete"
        Task26.NextID = 1876211523
        Task26.OutlineParentID = 1840770827
        Predecessor21.PredecessorTaskID = 1427890061
        Task26.Predecessors.Add(Predecessor21)
        Task26.Start = New Date(2013, 8, 7, 8, 30, 0, 0)
        BarStyle18.BarColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(209, Byte), Integer))
        BarStyle18.BarShape = C1.Win.C1GanttView.BarShape.TopLine
        BarStyle18.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle18.EndShape = 15
        BarStyle18.RightText1_ID = -13
        BarStyle18.StartShape = 15
        BarStyle18.TopText1_ID = 2099866733
        Task27.BarStyles.Add(BarStyle18)
        Task27.Finish = New Date(2013, 9, 4, 8, 30, 0, 0)
        Task27.ID = 1876211523
        Task27.Name = "Deployment"
        Task27.NextID = 1549439053
        Task27.OutlineParentID = 1331333418
        Task27.Start = New Date(2013, 8, 29, 8, 30, 0, 0)
        Task28.Finish = New Date(2013, 8, 30, 8, 30, 0, 0)
        Task28.ID = 1549439053
        Task28.Name = "Develop deployment methodology"
        Task28.NextID = 149137853
        Task28.OutlineParentID = 1876211523
        Predecessor22.PredecessorTaskID = 85175043
        Predecessor23.PredecessorTaskID = 1840770827
        Task28.Predecessors.Add(Predecessor22)
        Task28.Predecessors.Add(Predecessor23)
        ResourceRef23.Amount = 1.0R
        ResourceRef23.ResourceID = 2011144056
        ResourceRef24.Amount = 1.0R
        ResourceRef24.ResourceID = 239555279
        Task28.ResourceRefs.Add(ResourceRef23)
        Task28.ResourceRefs.Add(ResourceRef24)
        Task28.Start = New Date(2013, 8, 29, 8, 30, 0, 0)
        Task29.Finish = New Date(2013, 9, 4, 8, 30, 0, 0)
        Task29.ID = 149137853
        Task29.Name = "Deploy software"
        Task29.NextID = 1615148365
        Task29.OutlineParentID = 1876211523
        Predecessor24.PredecessorTaskID = 1549439053
        Task29.Predecessors.Add(Predecessor24)
        ResourceRef25.Amount = 1.0R
        ResourceRef25.ResourceID = 2011144056
        Task29.ResourceRefs.Add(ResourceRef25)
        Task29.Start = New Date(2013, 8, 30, 8, 30, 0, 0)
        BarStyle19.BarType = C1.Win.C1GanttView.BarType.Milestone
        BarStyle19.EndShape = 3
        BarStyle19.RightText1_ID = -7
        BarStyle19.TopText1_ID = 2099866733
        Task30.BarStyles.Add(BarStyle19)
        Task30.Finish = New Date(2013, 9, 4, 8, 30, 0, 0)
        Task30.ID = 1615148365
        Task30.Name = "Deployment complete"
        Task30.NextID = 149558323
        Task30.OutlineParentID = 1876211523
        Predecessor25.PredecessorTaskID = 149137853
        Task30.Predecessors.Add(Predecessor25)
        Task30.Start = New Date(2013, 9, 4, 8, 30, 0, 0)
        BarStyle20.BarType = C1.Win.C1GanttView.BarType.Milestone
        BarStyle20.EndColor = System.Drawing.Color.Red
        BarStyle20.EndShape = 3
        BarStyle20.RightText1_ID = -7
        BarStyle20.TopText1_ID = 2099866733
        Task31.BarStyles.Add(BarStyle20)
        Task31.Finish = New Date(2013, 9, 4, 0, 0, 0, 0)
        Task31.ID = 149558323
        Task31.Name = "Software development complete"
        Task31.NextID = 925207044
        Task31.OutlineParentID = 1331333418
        Task31.Start = New Date(2013, 9, 4, 0, 0, 0, 0)
        Task32.ID = 925207044
        Task32.NextID = 362538391
        Task33.ID = 362538391
        Task33.NextID = 1179983348
        Task34.ID = 1179983348
        Task34.NextID = 2098269195
        Task35.ID = 2098269195
        Task35.NextID = 792666599
        Task36.ID = 792666599
        Task36.NextID = 2121238572
        Task37.ID = 2121238572
        Task37.NextID = 312019882
        Task38.ID = 312019882
        Task38.NextID = 2131650479
        Task39.ID = 2131650479
        Task39.NextID = 1600264846
        Task40.ID = 1600264846
        Task40.NextID = 185936048
        Task41.ID = 185936048
        Task41.NextID = 1447717244
        Task42.ID = 1447717244
        Task42.NextID = 1352797036
        Task43.ID = 1352797036
        Task43.NextID = 1301076315
        Task44.ID = 1301076315
        Task44.NextID = 562163695
        Task45.ID = 562163695
        Task45.NextID = 19552401
        Task46.ID = 19552401
        Task46.NextID = 1597983629
        Task47.ID = 1597983629
        Task47.NextID = 591786279
        Task48.ID = 591786279
        Task48.NextID = 816445275
        Task49.ID = 816445275
        Task49.NextID = 514161404
        Task50.ID = 514161404
        Task50.NextID = 992389273
        Task51.ID = 992389273
        Task51.NextID = 246882487
        Task52.ID = 246882487
        Task52.NextID = 1546671531
        Task53.ID = 1546671531
        Task53.NextID = 2076126586
        Task54.ID = 2076126586
        Task54.NextID = -1
        Me.ganttView.Tasks.AddRange(New C1.Win.C1GanttView.Task() {Task2, Task3, Task4, Task5, Task6, Task7, Task8, Task9, Task10, Task11, Task12, Task13, Task14, Task15, Task16, Task17, Task18, Task19, Task20, Task21, Task22, Task23, Task24, Task25, Task26, Task27, Task28, Task29, Task30, Task31, Task32, Task33, Task34, Task35, Task36, Task37, Task38, Task39, Task40, Task41, Task42, Task43, Task44, Task45, Task46, Task47, Task48, Task49, Task50, Task51, Task52, Task53, Task54})
        Me.ganttView.Timescale.BottomTier.Align = C1.Win.C1GanttView.ScaleLabelAlignment.Center
        Me.ganttView.Timescale.BottomTier.Format = "w"
        Me.ganttView.Timescale.BottomTier.Visible = True
        Me.ganttView.Timescale.MiddleTier.Format = "nnnn d"
        Me.ganttView.Timescale.MiddleTier.Units = C1.Win.C1GanttView.TimescaleUnits.Weeks
        Me.ganttView.Timescale.MiddleTier.Visible = True
        Me.ganttView.ToolbarBackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(247, Byte), Integer))
        '
        'SoftwareDevelopmentPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 626)
        Me.Controls.Add(Me.ganttView)
        Me.Controls.Add(Me.statusBar)
        Me.Controls.Add(Me.ribbon)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SoftwareDevelopmentPlan"
        Me.Text = "SoftwareDevelopmentPlan"
        CType(Me.ribbon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.statusBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ganttView.DataStorage.CalendarStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ganttView.DataStorage.PropertyStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ganttView.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ganttView.DataStorage.TasksStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ganttView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private ribbon As C1.Win.Ribbon.C1Ribbon
    Private ribbonApplicationMenu1 As C1.Win.Ribbon.RibbonApplicationMenu
    Private WithEvents rbOpen As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbSave As C1.Win.Ribbon.RibbonButton
    Private ribbonConfigToolBar1 As C1.Win.Ribbon.RibbonConfigToolBar
    Private ribbonQat1 As C1.Win.Ribbon.RibbonQat
    Private ribbonTab1 As C1.Win.Ribbon.RibbonTab
    Private ribbonGroup1 As C1.Win.Ribbon.RibbonGroup
    Private ribbonToolBar1 As C1.Win.Ribbon.RibbonToolBar
    Private WithEvents rcpBackground As C1.Win.Ribbon.RibbonColorPicker
    Private WithEvents fontPicker As C1.Win.Ribbon.RibbonFontComboBox
    Private WithEvents rcbFontSize As C1.Win.Ribbon.RibbonComboBox
    Private WithEvents rcpForeground As C1.Win.Ribbon.RibbonColorPicker
    Private ribbonToolBar2 As C1.Win.Ribbon.RibbonToolBar
    Private ribbonGroup3 As C1.Win.Ribbon.RibbonGroup
    Private ribbonSeparator1 As C1.Win.Ribbon.RibbonSeparator
    Private WithEvents rbMoveTaskUp As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbMoveTaskDown As C1.Win.Ribbon.RibbonButton
    Private ribbonGroup4 As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rbAddTask As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbDeleteTask As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbAddBlankRow As C1.Win.Ribbon.RibbonButton
    Private ribbonGroup5 As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rbTaskInfo As C1.Win.Ribbon.RibbonButton
    Private ribbonGroup2 As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rbScrollToTask As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbColumns As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbTimeScale As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbProgressLine As C1.Win.Ribbon.RibbonButton
    Private ribbonTab2 As C1.Win.Ribbon.RibbonTab
    Private ribbonGroup7 As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rbResources As C1.Win.Ribbon.RibbonButton
    Private ribbonTab3 As C1.Win.Ribbon.RibbonTab
    Private ribbonGroup8 As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rbProjectInfo As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbChangeWorkingTime As C1.Win.Ribbon.RibbonButton
    Private ribbonTab4 As C1.Win.Ribbon.RibbonTab
    Private ribbonGroup9 As C1.Win.Ribbon.RibbonGroup
    Private ribbonMenu3 As C1.Win.Ribbon.RibbonMenu
    Private ribbonLabel4 As C1.Win.Ribbon.RibbonLabel
    Private rcpCellBorder As C1.Win.Ribbon.RibbonColorPicker
    Private rcpFixedBackground As C1.Win.Ribbon.RibbonColorPicker
    Private rcpFixedCellBorder As C1.Win.Ribbon.RibbonColorPicker
    Private rcpFixedForeground As C1.Win.Ribbon.RibbonColorPicker
    Private rcpHightlightBackground As C1.Win.Ribbon.RibbonColorPicker
    Private rcpHightlightForeground As C1.Win.Ribbon.RibbonColorPicker
    Private rcpNonworkingTime As C1.Win.Ribbon.RibbonColorPicker
    Private rcpSplitter As C1.Win.Ribbon.RibbonColorPicker
    Private rcpStartFinishLine As C1.Win.Ribbon.RibbonColorPicker
    Private rcpTodayLine As C1.Win.Ribbon.RibbonColorPicker
    Private WithEvents rbBarStyles As C1.Win.Ribbon.RibbonButton
    Private rbQuit As C1.Win.Ribbon.RibbonButton
    Private rcpEmptyAreaBack As C1.Win.Ribbon.RibbonColorPicker
    Private statusBar As C1.Win.Ribbon.C1StatusBar
    Private WithEvents ganttView As C1.Win.C1GanttView.C1GanttView
    Private rlLeftStatus As C1.Win.Ribbon.RibbonLabel
    Private WithEvents rbManualSchedule As C1.Win.Ribbon.RibbonToggleButton
    Private WithEvents rbAutoSchedule As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonTab5 As C1.Win.Ribbon.RibbonTab
    Private ribbonGroup11 As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rcbTimeline As C1.Win.Ribbon.RibbonComboBox
    Private rbTimescale2 As C1.Win.Ribbon.RibbonButton
    Private WithEvents ribbonMenu1 As C1.Win.Ribbon.RibbonMenu
    Private WithEvents rbZoomOut As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbZoomIn As C1.Win.Ribbon.RibbonButton
    Private ribbonSeparator11 As C1.Win.Ribbon.RibbonSeparator
    Private WithEvents rbZoomDialog As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbZoomEntireProject As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbZoomSelectedTask As C1.Win.Ribbon.RibbonButton
    Private WithEvents rtbZoom As C1.Win.Ribbon.RibbonTrackBar
    Private WithEvents rbPrint As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbPrintPreview As C1.Win.Ribbon.RibbonButton
    Private ribbonSeparator2 As C1.Win.Ribbon.RibbonSeparator
    Private WithEvents rbOutdentTask As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbIndentTask As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbAddSummary As C1.Win.Ribbon.RibbonButton
    Private ribbonGroup6 As C1.Win.Ribbon.RibbonGroup
    Private rcbGroupBy As C1.Win.Ribbon.RibbonComboBox
    Private WithEvents rbNoGroup As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbTaskMode As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbTaskComplete As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbConstraintType As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbDuration As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbMilestones As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbResource As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbStatus As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbAdvanceGroup As C1.Win.Ribbon.RibbonButton
    Private WithEvents rcbMaintainHierarchy As C1.Win.Ribbon.RibbonCheckBox
    Private ribbonGroup10 As C1.Win.Ribbon.RibbonGroup
    Private rcbFilter As C1.Win.Ribbon.RibbonComboBox
    Private WithEvents rcbShowRelatedSummaryRows As C1.Win.Ribbon.RibbonCheckBox
    Private WithEvents rbNoFilter As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbSummaryTasksFilter As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbCompletedTasksFilter As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbDateRangeFilter As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbIncompleteTasksFilter As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbLateTasksFilter As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbMilestonesFilter As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbDurationOnlyTasksFilter As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbUsingResourceFilter As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbAdvancedFilter As C1.Win.Ribbon.RibbonButton
    Private WithEvents rbMoreFilters As C1.Win.Ribbon.RibbonButton
    Friend WithEvents RibbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
	Friend WithEvents RibbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
End Class
