Partial Class Form1
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
		Dim taskPropertyColumn1 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn2 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn3 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn4 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn5 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn6 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn7 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn8 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn9 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn10 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn11 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn12 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn13 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn14 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim task1 As New C1.Win.GanttView.Task()
		Dim resource1 As New C1.Win.GanttView.Resource()
		Dim resource2 As New C1.Win.GanttView.Resource()
		Dim resource3 As New C1.Win.GanttView.Resource()
		Dim resource4 As New C1.Win.GanttView.Resource()
		Dim resource5 As New C1.Win.GanttView.Resource()
		Dim resource6 As New C1.Win.GanttView.Resource()
		Dim resource7 As New C1.Win.GanttView.Resource()
		Dim resource8 As New C1.Win.GanttView.Resource()
		Dim resource9 As New C1.Win.GanttView.Resource()
		Dim resource10 As New C1.Win.GanttView.Resource()
		Dim resource11 As New C1.Win.GanttView.Resource()
		Dim resource12 As New C1.Win.GanttView.Resource()
		Dim resource13 As New C1.Win.GanttView.Resource()
		Dim resource14 As New C1.Win.GanttView.Resource()
		Dim resource15 As New C1.Win.GanttView.Resource()
		Dim resource16 As New C1.Win.GanttView.Resource()
		Dim resource17 As New C1.Win.GanttView.Resource()
		Dim resource18 As New C1.Win.GanttView.Resource()
		Dim task2 As New C1.Win.GanttView.Task()
		Dim task3 As New C1.Win.GanttView.Task()
		Dim resourceRef1 As New C1.Win.GanttView.ResourceRef()
		Dim task4 As New C1.Win.GanttView.Task()
		Dim predecessor1 As New C1.Win.GanttView.Predecessor()
		Dim task5 As New C1.Win.GanttView.Task()
		Dim predecessor2 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef2 As New C1.Win.GanttView.ResourceRef()
		Dim task6 As New C1.Win.GanttView.Task()
		Dim predecessor3 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef3 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef4 As New C1.Win.GanttView.ResourceRef()
		Dim task7 As New C1.Win.GanttView.Task()
		Dim predecessor4 As New C1.Win.GanttView.Predecessor()
		Dim task8 As New C1.Win.GanttView.Task()
		Dim predecessor5 As New C1.Win.GanttView.Predecessor()
		Dim task9 As New C1.Win.GanttView.Task()
		Dim resourceRef5 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef6 As New C1.Win.GanttView.ResourceRef()
		Dim task10 As New C1.Win.GanttView.Task()
		Dim predecessor6 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef7 As New C1.Win.GanttView.ResourceRef()
		Dim task11 As New C1.Win.GanttView.Task()
		Dim predecessor7 As New C1.Win.GanttView.Predecessor()
		Dim task12 As New C1.Win.GanttView.Task()
		Dim predecessor8 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef8 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef9 As New C1.Win.GanttView.ResourceRef()
		Dim task13 As New C1.Win.GanttView.Task()
		Dim predecessor9 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef10 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef11 As New C1.Win.GanttView.ResourceRef()
		Dim task14 As New C1.Win.GanttView.Task()
		Dim predecessor10 As New C1.Win.GanttView.Predecessor()
		Dim predecessor11 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef12 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef13 As New C1.Win.GanttView.ResourceRef()
		Dim task15 As New C1.Win.GanttView.Task()
		Dim predecessor12 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef14 As New C1.Win.GanttView.ResourceRef()
		Dim task16 As New C1.Win.GanttView.Task()
		Dim predecessor13 As New C1.Win.GanttView.Predecessor()
		Dim task17 As New C1.Win.GanttView.Task()
		Dim task18 As New C1.Win.GanttView.Task()
		Dim resourceRef15 As New C1.Win.GanttView.ResourceRef()
		Dim task19 As New C1.Win.GanttView.Task()
		Dim predecessor14 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef16 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef17 As New C1.Win.GanttView.ResourceRef()
		Dim task20 As New C1.Win.GanttView.Task()
		Dim resourceRef18 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef19 As New C1.Win.GanttView.ResourceRef()
		Dim task21 As New C1.Win.GanttView.Task()
		Dim resourceRef20 As New C1.Win.GanttView.ResourceRef()
		Dim task22 As New C1.Win.GanttView.Task()
		Dim predecessor15 As New C1.Win.GanttView.Predecessor()
		Dim task23 As New C1.Win.GanttView.Task()
		Dim predecessor16 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef21 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef22 As New C1.Win.GanttView.ResourceRef()
		Dim task24 As New C1.Win.GanttView.Task()
		Dim predecessor17 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef23 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef24 As New C1.Win.GanttView.ResourceRef()
		Dim task25 As New C1.Win.GanttView.Task()
		Dim predecessor18 As New C1.Win.GanttView.Predecessor()
		Dim predecessor19 As New C1.Win.GanttView.Predecessor()
		Dim predecessor20 As New C1.Win.GanttView.Predecessor()
		Dim task26 As New C1.Win.GanttView.Task()
		Dim task27 As New C1.Win.GanttView.Task()
		Dim task28 As New C1.Win.GanttView.Task()
		Dim task29 As New C1.Win.GanttView.Task()
		Dim task30 As New C1.Win.GanttView.Task()
		Dim task31 As New C1.Win.GanttView.Task()
		Dim task32 As New C1.Win.GanttView.Task()
		Dim task33 As New C1.Win.GanttView.Task()
		Dim task34 As New C1.Win.GanttView.Task()
		Dim task35 As New C1.Win.GanttView.Task()
		Dim task36 As New C1.Win.GanttView.Task()
		Dim task37 As New C1.Win.GanttView.Task()
		Dim task38 As New C1.Win.GanttView.Task()
		Dim task39 As New C1.Win.GanttView.Task()
		Dim task40 As New C1.Win.GanttView.Task()
		Dim task41 As New C1.Win.GanttView.Task()
		Dim task42 As New C1.Win.GanttView.Task()
		Dim task43 As New C1.Win.GanttView.Task()
		Dim task44 As New C1.Win.GanttView.Task()
		Dim task45 As New C1.Win.GanttView.Task()
		Dim task46 As New C1.Win.GanttView.Task()
		Dim task47 As New C1.Win.GanttView.Task()
		Dim task48 As New C1.Win.GanttView.Task()
		Dim task49 As New C1.Win.GanttView.Task()
		Dim task50 As New C1.Win.GanttView.Task()
		Dim task51 As New C1.Win.GanttView.Task()
		Dim task52 As New C1.Win.GanttView.Task()
		Dim task53 As New C1.Win.GanttView.Task()
		Dim task54 As New C1.Win.GanttView.Task()
		Dim task55 As New C1.Win.GanttView.Task()
		Dim task56 As New C1.Win.GanttView.Task()
		Dim task57 As New C1.Win.GanttView.Task()
		Dim task58 As New C1.Win.GanttView.Task()
		Dim task59 As New C1.Win.GanttView.Task()
		Dim task60 As New C1.Win.GanttView.Task()
		Dim task61 As New C1.Win.GanttView.Task()
		Dim task62 As New C1.Win.GanttView.Task()
		Dim task63 As New C1.Win.GanttView.Task()
		Dim task64 As New C1.Win.GanttView.Task()
		Dim task65 As New C1.Win.GanttView.Task()
		Dim task66 As New C1.Win.GanttView.Task()
		Dim task67 As New C1.Win.GanttView.Task()
		Dim task68 As New C1.Win.GanttView.Task()
		Me.ganttView = New C1.Win.GanttView.C1GanttView()
		Me.btnMissNaming = New System.Windows.Forms.Button()
		Me.btnMissingResource = New System.Windows.Forms.Button()
		Me.btnPerformWithin = New System.Windows.Forms.Button()
		Me.btnHaveNotes = New System.Windows.Forms.Button()
		Me.groupBox1 = New System.Windows.Forms.GroupBox()
		Me.btnTobyOrToni = New System.Windows.Forms.Button()
		Me.btnCompletedByCarole = New System.Windows.Forms.Button()
		Me.btnLateOn = New System.Windows.Forms.Button()
		DirectCast(Me.ganttView, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.groupBox1.SuspendLayout()
		Me.SuspendLayout()
		' 
		' ganttView
		' 
		Me.ganttView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.ganttView.BackColor = System.Drawing.SystemColors.Window
		taskPropertyColumn1.Caption = "Task Mode"
		taskPropertyColumn1.ID = 281642421
		taskPropertyColumn1.[Property] = C1.Win.GanttView.TaskProperty.Mode
		taskPropertyColumn1.Width = 71
		taskPropertyColumn2.Caption = "Task Name"
		taskPropertyColumn2.ID = 389283492
		taskPropertyColumn2.[Property] = C1.Win.GanttView.TaskProperty.Name
		taskPropertyColumn2.Width = 167
		taskPropertyColumn3.Caption = "Duration"
		taskPropertyColumn3.ID = 1193980067
		taskPropertyColumn3.[Property] = C1.Win.GanttView.TaskProperty.Duration
		taskPropertyColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		taskPropertyColumn3.Width = 55
		taskPropertyColumn4.Caption = "Duration Units"
		taskPropertyColumn4.ID = 1834393658
		taskPropertyColumn4.[Property] = C1.Win.GanttView.TaskProperty.DurationUnits
		taskPropertyColumn5.Caption = "Start"
		taskPropertyColumn5.ID = 878770404
		taskPropertyColumn5.[Property] = C1.Win.GanttView.TaskProperty.Start
		taskPropertyColumn5.Visible = False
		taskPropertyColumn6.Caption = "Finish"
		taskPropertyColumn6.ID = 1347224272
		taskPropertyColumn6.[Property] = C1.Win.GanttView.TaskProperty.Finish
		taskPropertyColumn6.Visible = False
		taskPropertyColumn7.Caption = "% Complete"
		taskPropertyColumn7.ID = 1303371270
		taskPropertyColumn7.[Property] = C1.Win.GanttView.TaskProperty.PercentComplete
		taskPropertyColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		taskPropertyColumn7.Visible = False
		taskPropertyColumn8.Caption = "Constraint Type"
		taskPropertyColumn8.ID = 1686029953
		taskPropertyColumn8.[Property] = C1.Win.GanttView.TaskProperty.ConstraintType
		taskPropertyColumn8.Visible = False
		taskPropertyColumn9.Caption = "Constraint Date"
		taskPropertyColumn9.ID = 1178233289
		taskPropertyColumn9.[Property] = C1.Win.GanttView.TaskProperty.ConstraintDate
		taskPropertyColumn9.Visible = False
		taskPropertyColumn10.Caption = "Predecessors"
		taskPropertyColumn10.ID = 1777126625
		taskPropertyColumn10.[Property] = C1.Win.GanttView.TaskProperty.Predecessors
		taskPropertyColumn11.Caption = "Deadline"
		taskPropertyColumn11.ID = 1481072281
		taskPropertyColumn11.[Property] = C1.Win.GanttView.TaskProperty.Deadline
		taskPropertyColumn11.Visible = False
		taskPropertyColumn12.Caption = "Calendar"
		taskPropertyColumn12.ID = 1736156873
		taskPropertyColumn12.[Property] = C1.Win.GanttView.TaskProperty.Calendar
		taskPropertyColumn12.Visible = False
		taskPropertyColumn13.Caption = "Resource Names"
		taskPropertyColumn13.ID = 2017304018
		taskPropertyColumn13.[Property] = C1.Win.GanttView.TaskProperty.ResourceNames
		taskPropertyColumn13.Visible = False
		taskPropertyColumn14.Caption = "Notes"
		taskPropertyColumn14.ID = 1642844192
		taskPropertyColumn14.[Property] = C1.Win.GanttView.TaskProperty.Notes
		taskPropertyColumn14.Visible = False
		Me.ganttView.Columns.Add(taskPropertyColumn1)
		Me.ganttView.Columns.Add(taskPropertyColumn2)
		Me.ganttView.Columns.Add(taskPropertyColumn3)
		Me.ganttView.Columns.Add(taskPropertyColumn4)
		Me.ganttView.Columns.Add(taskPropertyColumn5)
		Me.ganttView.Columns.Add(taskPropertyColumn6)
		Me.ganttView.Columns.Add(taskPropertyColumn7)
		Me.ganttView.Columns.Add(taskPropertyColumn8)
		Me.ganttView.Columns.Add(taskPropertyColumn9)
		Me.ganttView.Columns.Add(taskPropertyColumn10)
		Me.ganttView.Columns.Add(taskPropertyColumn11)
		Me.ganttView.Columns.Add(taskPropertyColumn12)
		Me.ganttView.Columns.Add(taskPropertyColumn13)
		Me.ganttView.Columns.Add(taskPropertyColumn14)
		Me.ganttView.DefaultWorkingTimes.Interval_1.Empty = False
		Me.ganttView.DefaultWorkingTimes.Interval_1.From = New System.DateTime(1, 1, 1, 9, 0, 0, _
			0)
		Me.ganttView.DefaultWorkingTimes.Interval_1.[To] = New System.DateTime(1, 1, 1, 13, 0, 0, _
			0)
		Me.ganttView.DefaultWorkingTimes.Interval_2.Empty = False
		Me.ganttView.DefaultWorkingTimes.Interval_2.From = New System.DateTime(1, 1, 1, 14, 0, 0, _
			0)
		Me.ganttView.DefaultWorkingTimes.Interval_2.[To] = New System.DateTime(1, 1, 1, 18, 0, 0, _
			0)
		Me.ganttView.GridWidth = 338
		Me.ganttView.Location = New System.Drawing.Point(0, 0)
		Me.ganttView.Name = "ganttView"
		task1.ID = 1513498650
		task1.Mode = C1.Win.GanttView.TaskMode.Automatic
		task1.Name = "New Book Launch schedule"
		task1.PercentComplete = 0.215205889118933
		Me.ganttView.ProjectSummary = task1
		resource1.Cost = New Decimal(New Integer() {2700, 0, 0, 0})
		resource1.ID = 1310257871
		resource1.Name = "Toby Nixon"
		resource2.Cost = New Decimal(New Integer() {880, 0, 0, 0})
		resource2.ID = 403942649
		resource2.Name = "Vikas Jain"
		resource3.ID = 900059987
		resource3.Name = "Carole Poland"
		resource4.ID = 775286470
		resource4.Name = "Copyeditors"
		resource4.ResourceType = C1.Win.GanttView.ResourceType.Material
		resource5.ID = 967675533
		resource5.Name = "Dan Jump"
		resource6.ID = 38886245
		resource6.Name = "Hany Morcos"
		resource7.ID = 237469361
		resource7.Name = "Jane Dow"
		resource8.ID = 443042401
		resource8.Name = "John Evans"
		resource9.ID = 1698044936
		resource9.Name = "Jun Cao"
		resource10.ID = 1476859390
		resource10.Name = "Katie Jordan"
		resource11.ID = 603908635
		resource11.Name = "Luis Sousa"
		resource12.ID = 697558225
		resource12.Name = "Printing Service"
		resource12.ResourceType = C1.Win.GanttView.ResourceType.Material
		resource13.ID = 539828441
		resource13.Name = "Robin Wood"
		resource14.ID = 1310682358
		resource14.Name = "Sharon Salavaria"
		resource15.ID = 372390668
		resource15.Name = "Toni Poe"
		resource16.Cost = New Decimal(New Integer() {8000, 0, 0, 0})
		resource16.ID = 1423358882
		resource16.Name = "Travel"
		resource17.ID = 1164843623
		resource17.Name = "Wiliam Flash"
		resource18.ID = 260690927
		resource18.Name = "Zac Woodall"
		Me.ganttView.Resources.Add(resource1)
		Me.ganttView.Resources.Add(resource2)
		Me.ganttView.Resources.Add(resource3)
		Me.ganttView.Resources.Add(resource4)
		Me.ganttView.Resources.Add(resource5)
		Me.ganttView.Resources.Add(resource6)
		Me.ganttView.Resources.Add(resource7)
		Me.ganttView.Resources.Add(resource8)
		Me.ganttView.Resources.Add(resource9)
		Me.ganttView.Resources.Add(resource10)
		Me.ganttView.Resources.Add(resource11)
		Me.ganttView.Resources.Add(resource12)
		Me.ganttView.Resources.Add(resource13)
		Me.ganttView.Resources.Add(resource14)
		Me.ganttView.Resources.Add(resource15)
		Me.ganttView.Resources.Add(resource16)
		Me.ganttView.Resources.Add(resource17)
		Me.ganttView.Resources.Add(resource18)
		Me.ganttView.Size = New System.Drawing.Size(821, 477)
		Me.ganttView.StartDate = New System.DateTime(2014, 2, 25, 0, 0, 0, _
			0)
		Me.ganttView.TabIndex = 0
		task2.ID = 373743850
		task2.Mode = C1.Win.GanttView.TaskMode.Automatic
		task2.Name = "Planning Phase"
		task2.OutlineParentID = 1513498650
		task2.PercentComplete = 0.19047619047619
		task3.Duration = 1.0
		task3.ID = 1940039857
		task3.Mode = C1.Win.GanttView.TaskMode.Automatic
		task3.Name = "Assign launch team members"
		task3.OutlineParentID = 373743850
		task3.PercentComplete = 1.0
		resourceRef1.Amount = 1.0
		resourceRef1.ResourceID = 900059987
		task3.ResourceRefs.Add(resourceRef1)
		task4.Duration = 1.0
		task4.DurationUnits = C1.Win.GanttView.DurationUnits.Weeks
		task4.ID = 1902404950
		task4.Mode = C1.Win.GanttView.TaskMode.Automatic
		task4.OutlineParentID = 373743850
		task4.PercentComplete = 0.6
		predecessor1.PredecessorTaskID = 1940039857
		task4.Predecessors.Add(predecessor1)
		task5.Duration = 1.0
		task5.DurationUnits = C1.Win.GanttView.DurationUnits.Weeks
		task5.ID = 152489629
		task5.Mode = C1.Win.GanttView.TaskMode.Automatic
		task5.Name = "Schedule author interviews"
		task5.OutlineParentID = 373743850
		predecessor2.PredecessorTaskID = 1940039857
		task5.Predecessors.Add(predecessor2)
		resourceRef2.Amount = 1.0
		resourceRef2.ResourceID = 1698044936
		task5.ResourceRefs.Add(resourceRef2)
		task6.Duration = 2.0
		task6.DurationUnits = C1.Win.GanttView.DurationUnits.Weeks
		task6.ID = 2091011055
		task6.Mode = C1.Win.GanttView.TaskMode.Automatic
		task6.Name = "Design and order marketing material"
		task6.OutlineParentID = 373743850
		predecessor3.PredecessorTaskID = 1940039857
		task6.Predecessors.Add(predecessor3)
		resourceRef3.Amount = 1.0
		resourceRef3.ResourceID = 1310257871
		resourceRef4.Amount = 1.0
		resourceRef4.ResourceID = 260690927
		task6.ResourceRefs.Add(resourceRef3)
		task6.ResourceRefs.Add(resourceRef4)
		task7.Duration = 0.0
		task7.ID = 1524170823
		task7.Mode = C1.Win.GanttView.TaskMode.Automatic
		task7.Name = "Planning complete!"
		task7.OutlineParentID = 373743850
		predecessor4.PredecessorTaskID = 2091011055
		task7.Predecessors.Add(predecessor4)
		task8.ConstraintDate = New System.DateTime(2014, 3, 3, 0, 0, 0, _
			0)
		task8.ConstraintType = C1.Win.GanttView.ConstraintType.StartNoEarlierThan
		task8.ID = 2118603263
		task8.Mode = C1.Win.GanttView.TaskMode.Automatic
		task8.OutlineParentID = 1513498650
		task8.PercentComplete = 0.434782608695652
		predecessor5.PredecessorTaskID = 373743850
		task8.Predecessors.Add(predecessor5)
		task9.ConstraintDate = New System.DateTime(2014, 3, 12, 0, 0, 0, _
			0)
		task9.ConstraintType = C1.Win.GanttView.ConstraintType.StartNoEarlierThan
		task9.Duration = 1.0
		task9.ID = 1266698008
		task9.Mode = C1.Win.GanttView.TaskMode.Automatic
		task9.Name = "Kickoff book launch meeting"
		task9.OutlineParentID = 2118603263
		task9.PercentComplete = 1.0
		resourceRef5.Amount = 1.0
		resourceRef5.ResourceID = 1310682358
		resourceRef6.Amount = 1.0
		resourceRef6.ResourceID = 1310257871
		task9.ResourceRefs.Add(resourceRef5)
		task9.ResourceRefs.Add(resourceRef6)
		task10.Duration = 2.0
		task10.ID = 1743047809
		task10.Mode = C1.Win.GanttView.TaskMode.Automatic
		task10.OutlineParentID = 2118603263
		task10.PercentComplete = 0.5
		predecessor6.PredecessorTaskID = 1266698008
		task10.Predecessors.Add(predecessor6)
		resourceRef7.Amount = 1.0
		resourceRef7.ResourceID = 900059987
		task10.ResourceRefs.Add(resourceRef7)
		task11.Duration = 6.0
		task11.ID = 525875640
		task11.Mode = C1.Win.GanttView.TaskMode.Automatic
		task11.Name = "Plan author's travel itinerary"
		task11.OutlineParentID = 2118603263
		task11.PercentComplete = 1.0
		predecessor7.PredecessorTaskID = 1266698008
		task11.Predecessors.Add(predecessor7)
		task12.Duration = 1.0
		task12.DurationUnits = C1.Win.GanttView.DurationUnits.Weeks
		task12.ID = 132405539
		task12.Mode = C1.Win.GanttView.TaskMode.Automatic
		task12.Name = "Channel Sales prep"
		task12.OutlineParentID = 2118603263
		predecessor8.PredecessorTaskID = 1266698008
		task12.Predecessors.Add(predecessor8)
		resourceRef8.Amount = 1.0
		resourceRef8.ResourceID = 260690927
		resourceRef9.Amount = 1.0
		resourceRef9.ResourceID = 38886245
		task12.ResourceRefs.Add(resourceRef8)
		task12.ResourceRefs.Add(resourceRef9)
		task13.Finish = New System.DateTime(2014, 3, 24, 9, 0, 0, _
			0)
		task13.ID = 1353658744
		task13.Name = "Complete book launch form"
		task13.OutlineParentID = 2118603263
		task13.PercentComplete = 1.0
		predecessor9.PredecessorTaskID = 132405539
		task13.Predecessors.Add(predecessor9)
		resourceRef10.Amount = 1.0
		resourceRef10.ResourceID = 1310257871
		resourceRef11.Amount = 1.0
		resourceRef11.ResourceID = 403942649
		task13.ResourceRefs.Add(resourceRef10)
		task13.ResourceRefs.Add(resourceRef11)
		task13.Start = New System.DateTime(2014, 3, 20, 9, 0, 0, _
			0)
		task14.DurationUnits = C1.Win.GanttView.DurationUnits.Weeks
		task14.Finish = New System.DateTime(2014, 3, 27, 9, 0, 0, _
			0)
		task14.ID = 1396929467
		task14.Name = "Prepare book sales kit"
		task14.OutlineParentID = 2118603263
		predecessor10.PredecessorTaskID = 1266698008
		predecessor11.PredecessorTaskID = 132405539
		task14.Predecessors.Add(predecessor10)
		task14.Predecessors.Add(predecessor11)
		resourceRef12.Amount = 1.0
		resourceRef12.ResourceID = 38886245
		resourceRef13.Amount = 1.0
		resourceRef13.ResourceID = 260690927
		task14.ResourceRefs.Add(resourceRef12)
		task14.ResourceRefs.Add(resourceRef13)
		task14.Start = New System.DateTime(2014, 3, 20, 9, 0, 0, _
			0)
		task15.Duration = 2.0
		task15.ID = 518118730
		task15.Mode = C1.Win.GanttView.TaskMode.Automatic
		task15.Name = "Distribute internal marketing material"
		task15.OutlineParentID = 2118603263
		predecessor12.PredecessorTaskID = 1396929467
		task15.Predecessors.Add(predecessor12)
		resourceRef14.Amount = 1.0
		resourceRef14.ResourceID = 260690927
		task15.ResourceRefs.Add(resourceRef14)
		task16.ID = 1794896915
		task16.Mode = C1.Win.GanttView.TaskMode.Automatic
		task16.Name = "Public Launch Phase"
		task16.OutlineParentID = 1513498650
		predecessor13.PredecessorTaskID = 2118603263
		task16.Predecessors.Add(predecessor13)
		task17.ID = 1105961502
		task17.Mode = C1.Win.GanttView.TaskMode.Automatic
		task17.Name = "Author travel and appearances"
		task17.OutlineParentID = 1794896915
		task18.ConstraintDate = New System.DateTime(2014, 3, 31, 0, 0, 0, _
			0)
		task18.ConstraintType = C1.Win.GanttView.ConstraintType.StartNoEarlierThan
		task18.Duration = 1.0
		task18.ID = 119033255
		task18.Mode = C1.Win.GanttView.TaskMode.Automatic
		task18.Name = "Author radio interview"
		task18.OutlineParentID = 1105961502
		resourceRef15.Amount = 1.0
		resourceRef15.ResourceID = 372390668
		task18.ResourceRefs.Add(resourceRef15)
		task19.Duration = 1.0
		task19.ID = 1383214640
		task19.Mode = C1.Win.GanttView.TaskMode.Automatic
		task19.Name = "Author reading and signing at book fair"
		task19.OutlineParentID = 1105961502
		predecessor14.PredecessorTaskID = 119033255
		task19.Predecessors.Add(predecessor14)
		resourceRef16.Amount = 1.0
		resourceRef16.ResourceID = 372390668
		resourceRef17.Amount = 1.0
		resourceRef17.ResourceID = 1423358882
		task19.ResourceRefs.Add(resourceRef16)
		task19.ResourceRefs.Add(resourceRef17)
		task20.ConstraintDate = New System.DateTime(2014, 3, 31, 0, 0, 0, _
			0)
		task20.ConstraintType = C1.Win.GanttView.ConstraintType.StartNoEarlierThan
		task20.Duration = 2.0
		task20.ID = 2061905321
		task20.Mode = C1.Win.GanttView.TaskMode.Automatic
		task20.Name = "Distribute advance copies"
		task20.Notes = "Get recipient list from publicist"
		task20.OutlineParentID = 1794896915
		resourceRef18.Amount = 1.0
		resourceRef18.ResourceID = 1310257871
		resourceRef19.Amount = 1.0
		resourceRef19.ResourceID = 403942649
		task20.ResourceRefs.Add(resourceRef18)
		task20.ResourceRefs.Add(resourceRef19)
		task21.ConstraintDate = New System.DateTime(2014, 3, 31, 0, 0, 0, _
			0)
		task21.ConstraintType = C1.Win.GanttView.ConstraintType.StartNoEarlierThan
		task21.Duration = 2.0
		task21.ID = 225039161
		task21.Mode = C1.Win.GanttView.TaskMode.Automatic
		task21.Name = "Distribute book sales kit"
		task21.OutlineParentID = 1794896915
		resourceRef20.Amount = 1.0
		resourceRef20.ResourceID = 260690927
		task21.ResourceRefs.Add(resourceRef20)
		task22.Duration = 7.0
		task22.ID = 334780400
		task22.Mode = C1.Win.GanttView.TaskMode.Automatic
		task22.OutlineParentID = 1794896915
		predecessor15.PredecessorTaskID = 225039161
		task22.Predecessors.Add(predecessor15)
		task23.Duration = 1.0
		task23.DurationUnits = C1.Win.GanttView.DurationUnits.Weeks
		task23.ID = 950931069
		task23.Mode = C1.Win.GanttView.TaskMode.Automatic
		task23.Name = "Launch public Web portal for book"
		task23.OutlineParentID = 1794896915
		predecessor16.PredecessorTaskID = 225039161
		task23.Predecessors.Add(predecessor16)
		resourceRef21.Amount = 1.0
		resourceRef21.ResourceID = 1310257871
		resourceRef22.Amount = 1.0
		resourceRef22.ResourceID = 403942649
		task23.ResourceRefs.Add(resourceRef21)
		task23.ResourceRefs.Add(resourceRef22)
		task24.Duration = 1.0
		task24.DurationUnits = C1.Win.GanttView.DurationUnits.Weeks
		task24.ID = 349527667
		task24.Mode = C1.Win.GanttView.TaskMode.Automatic
		task24.Name = "Launch social media programs for book"
		task24.OutlineParentID = 1794896915
		predecessor17.PredecessorTaskID = 950931069
		task24.Predecessors.Add(predecessor17)
		resourceRef23.Amount = 1.0
		resourceRef23.ResourceID = 1310257871
		resourceRef24.Amount = 1.0
		resourceRef24.ResourceID = 403942649
		task24.ResourceRefs.Add(resourceRef23)
		task24.ResourceRefs.Add(resourceRef24)
		task25.Duration = 0.0
		task25.ID = 1952630353
		task25.Mode = C1.Win.GanttView.TaskMode.Automatic
		task25.Name = "Launch complete!"
		task25.OutlineParentID = 1794896915
		predecessor18.PredecessorTaskID = 334780400
		predecessor19.PredecessorTaskID = 950931069
		predecessor20.PredecessorTaskID = 349527667
		task25.Predecessors.Add(predecessor18)
		task25.Predecessors.Add(predecessor19)
		task25.Predecessors.Add(predecessor20)
		task26.ID = 1907411200
		task27.ID = 557040271
		task28.ID = 1772783385
		task29.ID = 2094903358
		task30.ID = 626127770
		task31.ID = 104461576
		task32.ID = 890975461
		task33.ID = 1476994843
		task34.ID = 1242069060
		task35.ID = 244233220
		task36.ID = 1890605695
		task37.ID = 159678678
		task38.ID = 1710019457
		task39.ID = 1786831974
		task40.ID = 35990369
		task41.ID = 758534052
		task42.ID = 686492856
		task43.ID = 1304030759
		task44.ID = 1321288092
		task45.ID = 1015939034
		task46.ID = 216473481
		task47.ID = 2037590830
		task48.ID = 1061679727
		task49.ID = 221841874
		task50.ID = 1530697032
		task51.ID = 1995786867
		task52.ID = 1414865794
		task53.ID = 647554806
		task54.ID = 971243530
		task55.ID = 1919783097
		task56.ID = 968785459
		task57.ID = 1515204094
		task58.ID = 892227204
		task59.ID = 1766942900
		task60.ID = 1343996224
		task61.ID = 516376503
		task62.ID = 1693906001
		task63.ID = 1566078940
		task64.ID = 1276277181
		task65.ID = 48028054
		task66.ID = 1200035595
		task67.ID = 47175981
		task68.ID = 500978750
		Me.ganttView.Tasks.Add(task2)
		Me.ganttView.Tasks.Add(task3)
		Me.ganttView.Tasks.Add(task4)
		Me.ganttView.Tasks.Add(task5)
		Me.ganttView.Tasks.Add(task6)
		Me.ganttView.Tasks.Add(task7)
		Me.ganttView.Tasks.Add(task8)
		Me.ganttView.Tasks.Add(task9)
		Me.ganttView.Tasks.Add(task10)
		Me.ganttView.Tasks.Add(task11)
		Me.ganttView.Tasks.Add(task12)
		Me.ganttView.Tasks.Add(task13)
		Me.ganttView.Tasks.Add(task14)
		Me.ganttView.Tasks.Add(task15)
		Me.ganttView.Tasks.Add(task16)
		Me.ganttView.Tasks.Add(task17)
		Me.ganttView.Tasks.Add(task18)
		Me.ganttView.Tasks.Add(task19)
		Me.ganttView.Tasks.Add(task20)
		Me.ganttView.Tasks.Add(task21)
		Me.ganttView.Tasks.Add(task22)
		Me.ganttView.Tasks.Add(task23)
		Me.ganttView.Tasks.Add(task24)
		Me.ganttView.Tasks.Add(task25)
		Me.ganttView.Tasks.Add(task26)
		Me.ganttView.Tasks.Add(task27)
		Me.ganttView.Tasks.Add(task28)
		Me.ganttView.Tasks.Add(task29)
		Me.ganttView.Tasks.Add(task30)
		Me.ganttView.Tasks.Add(task31)
		Me.ganttView.Tasks.Add(task32)
		Me.ganttView.Tasks.Add(task33)
		Me.ganttView.Tasks.Add(task34)
		Me.ganttView.Tasks.Add(task35)
		Me.ganttView.Tasks.Add(task36)
		Me.ganttView.Tasks.Add(task37)
		Me.ganttView.Tasks.Add(task38)
		Me.ganttView.Tasks.Add(task39)
		Me.ganttView.Tasks.Add(task40)
		Me.ganttView.Tasks.Add(task41)
		Me.ganttView.Tasks.Add(task42)
		Me.ganttView.Tasks.Add(task43)
		Me.ganttView.Tasks.Add(task44)
		Me.ganttView.Tasks.Add(task45)
		Me.ganttView.Tasks.Add(task46)
		Me.ganttView.Tasks.Add(task47)
		Me.ganttView.Tasks.Add(task48)
		Me.ganttView.Tasks.Add(task49)
		Me.ganttView.Tasks.Add(task50)
		Me.ganttView.Tasks.Add(task51)
		Me.ganttView.Tasks.Add(task52)
		Me.ganttView.Tasks.Add(task53)
		Me.ganttView.Tasks.Add(task54)
		Me.ganttView.Tasks.Add(task55)
		Me.ganttView.Tasks.Add(task56)
		Me.ganttView.Tasks.Add(task57)
		Me.ganttView.Tasks.Add(task58)
		Me.ganttView.Tasks.Add(task59)
		Me.ganttView.Tasks.Add(task60)
		Me.ganttView.Tasks.Add(task61)
		Me.ganttView.Tasks.Add(task62)
		Me.ganttView.Tasks.Add(task63)
		Me.ganttView.Tasks.Add(task64)
		Me.ganttView.Tasks.Add(task65)
		Me.ganttView.Tasks.Add(task66)
		Me.ganttView.Tasks.Add(task67)
		Me.ganttView.Tasks.Add(task68)
		Me.ganttView.Timescale.BottomTier.Align = C1.Win.GanttView.ScaleLabelAlignment.Center
		Me.ganttView.Timescale.BottomTier.Format = "w"
		Me.ganttView.Timescale.BottomTier.Visible = True
		Me.ganttView.Timescale.MiddleTier.Format = "nnnn d"
		Me.ganttView.Timescale.MiddleTier.Units = C1.Win.GanttView.TimescaleUnits.Weeks
		Me.ganttView.Timescale.MiddleTier.Visible = True
		' 
		' btnMissNaming
		' 
		Me.btnMissNaming.Location = New System.Drawing.Point(40, 22)
		Me.btnMissNaming.Name = "btnMissNaming"
		Me.btnMissNaming.Size = New System.Drawing.Size(178, 25)
		Me.btnMissNaming.TabIndex = 1
		Me.btnMissNaming.Text = "Missing Name Tasks"
		Me.btnMissNaming.UseVisualStyleBackColor = True
		AddHandler Me.btnMissNaming.Click, New System.EventHandler(AddressOf Me.btnMissNaming_Click)
		' 
		' btnMissingResource
		' 
		Me.btnMissingResource.Location = New System.Drawing.Point(40, 53)
		Me.btnMissingResource.Name = "btnMissingResource"
		Me.btnMissingResource.Size = New System.Drawing.Size(178, 25)
		Me.btnMissingResource.TabIndex = 1
		Me.btnMissingResource.Text = "Missing Resource Tasks"
		Me.btnMissingResource.UseVisualStyleBackColor = True
		AddHandler Me.btnMissingResource.Click, New System.EventHandler(AddressOf Me.btnMissingResource_Click)
		' 
		' btnPerformWithin
		' 
		Me.btnPerformWithin.Location = New System.Drawing.Point(40, 84)
		Me.btnPerformWithin.Name = "btnPerformWithin"
		Me.btnPerformWithin.Size = New System.Drawing.Size(178, 50)
		Me.btnPerformWithin.TabIndex = 1
		Me.btnPerformWithin.Text = "Tasks Are Performed Within" & vbLf & "Mar 16 - Apr 1"
		Me.btnPerformWithin.UseVisualStyleBackColor = True
		AddHandler Me.btnPerformWithin.Click, New System.EventHandler(AddressOf Me.btnPerformWithin_Click)
		' 
		' btnHaveNotes
		' 
		Me.btnHaveNotes.Location = New System.Drawing.Point(40, 140)
		Me.btnHaveNotes.Name = "btnHaveNotes"
		Me.btnHaveNotes.Size = New System.Drawing.Size(178, 25)
		Me.btnHaveNotes.TabIndex = 1
		Me.btnHaveNotes.Text = "Tasks Have Notes"
		Me.btnHaveNotes.UseVisualStyleBackColor = True
		AddHandler Me.btnHaveNotes.Click, New System.EventHandler(AddressOf Me.btnHaveNotes_Click)
		' 
		' groupBox1
		' 
		Me.groupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupBox1.Controls.Add(Me.btnTobyOrToni)
		Me.groupBox1.Controls.Add(Me.btnPerformWithin)
		Me.groupBox1.Controls.Add(Me.btnCompletedByCarole)
		Me.groupBox1.Controls.Add(Me.btnLateOn)
		Me.groupBox1.Controls.Add(Me.btnHaveNotes)
		Me.groupBox1.Controls.Add(Me.btnMissingResource)
		Me.groupBox1.Controls.Add(Me.btnMissNaming)
		Me.groupBox1.Location = New System.Drawing.Point(828, 14)
		Me.groupBox1.Name = "groupBox1"
		Me.groupBox1.Size = New System.Drawing.Size(233, 463)
		Me.groupBox1.TabIndex = 2
		Me.groupBox1.TabStop = False
		Me.groupBox1.Text = "Filter"
		' 
		' btnTobyOrToni
		' 
		Me.btnTobyOrToni.Location = New System.Drawing.Point(40, 233)
		Me.btnTobyOrToni.Name = "btnTobyOrToni"
		Me.btnTobyOrToni.Size = New System.Drawing.Size(178, 50)
		Me.btnTobyOrToni.TabIndex = 2
		Me.btnTobyOrToni.Text = "Tasks Perform By Toby Or Toni"
		Me.btnTobyOrToni.UseVisualStyleBackColor = True
		AddHandler Me.btnTobyOrToni.Click, New System.EventHandler(AddressOf Me.btnTobyOrToni_Click)
		' 
		' btnCompletedByCarole
		' 
		Me.btnCompletedByCarole.Location = New System.Drawing.Point(40, 202)
		Me.btnCompletedByCarole.Name = "btnCompletedByCarole"
		Me.btnCompletedByCarole.Size = New System.Drawing.Size(178, 25)
		Me.btnCompletedByCarole.TabIndex = 1
		Me.btnCompletedByCarole.Text = "Completed Tasks By Carole"
		Me.btnCompletedByCarole.UseVisualStyleBackColor = True
		AddHandler Me.btnCompletedByCarole.Click, New System.EventHandler(AddressOf Me.btnCompletedByCarole_Click)
		' 
		' btnLateOn
		' 
		Me.btnLateOn.Location = New System.Drawing.Point(40, 171)
		Me.btnLateOn.Name = "btnLateOn"
		Me.btnLateOn.Size = New System.Drawing.Size(178, 25)
		Me.btnLateOn.TabIndex = 1
		Me.btnLateOn.Text = "Late Tasks On Mar 16"
		Me.btnLateOn.UseVisualStyleBackColor = True
		AddHandler Me.btnLateOn.Click, New System.EventHandler(AddressOf Me.btnLateOn_Click)
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1060, 477)
		Me.Controls.Add(Me.groupBox1)
		Me.Controls.Add(Me.ganttView)
		Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.Name = "Form1"
		Me.Text = "Filter Sample"
		DirectCast(Me.ganttView, System.ComponentModel.ISupportInitialize).EndInit()
		Me.groupBox1.ResumeLayout(False)
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private ganttView As C1.Win.GanttView.C1GanttView
	Private btnMissNaming As System.Windows.Forms.Button
	Private btnMissingResource As System.Windows.Forms.Button
	Private btnPerformWithin As System.Windows.Forms.Button
	Private btnHaveNotes As System.Windows.Forms.Button
	Private groupBox1 As System.Windows.Forms.GroupBox
	Private btnLateOn As System.Windows.Forms.Button
	Private btnCompletedByCarole As System.Windows.Forms.Button
	Private btnTobyOrToni As System.Windows.Forms.Button
End Class

