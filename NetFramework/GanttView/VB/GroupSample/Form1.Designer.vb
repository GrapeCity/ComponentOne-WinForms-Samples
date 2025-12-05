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
		Dim calendarException1 As New C1.Win.GanttView.CalendarException()
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
		Dim task2 As New C1.Win.GanttView.Task()
		Dim task3 As New C1.Win.GanttView.Task()
		Dim task4 As New C1.Win.GanttView.Task()
		Dim predecessor1 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef1 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef2 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef3 As New C1.Win.GanttView.ResourceRef()
		Dim task5 As New C1.Win.GanttView.Task()
		Dim predecessor2 As New C1.Win.GanttView.Predecessor()
		Dim task6 As New C1.Win.GanttView.Task()
		Dim task7 As New C1.Win.GanttView.Task()
		Dim predecessor3 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef4 As New C1.Win.GanttView.ResourceRef()
		Dim task8 As New C1.Win.GanttView.Task()
		Dim predecessor4 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef5 As New C1.Win.GanttView.ResourceRef()
		Dim task9 As New C1.Win.GanttView.Task()
		Dim predecessor5 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef6 As New C1.Win.GanttView.ResourceRef()
		Dim task10 As New C1.Win.GanttView.Task()
		Dim predecessor6 As New C1.Win.GanttView.Predecessor()
		Dim task11 As New C1.Win.GanttView.Task()
		Dim task12 As New C1.Win.GanttView.Task()
		Dim predecessor7 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef7 As New C1.Win.GanttView.ResourceRef()
		Dim task13 As New C1.Win.GanttView.Task()
		Dim predecessor8 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef8 As New C1.Win.GanttView.ResourceRef()
		Dim task14 As New C1.Win.GanttView.Task()
		Dim predecessor9 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef9 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef10 As New C1.Win.GanttView.ResourceRef()
		Dim task15 As New C1.Win.GanttView.Task()
		Dim task16 As New C1.Win.GanttView.Task()
		Dim predecessor10 As New C1.Win.GanttView.Predecessor()
		Dim predecessor11 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef11 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef12 As New C1.Win.GanttView.ResourceRef()
		Dim task17 As New C1.Win.GanttView.Task()
		Dim predecessor12 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef13 As New C1.Win.GanttView.ResourceRef()
		Dim task18 As New C1.Win.GanttView.Task()
		Dim predecessor13 As New C1.Win.GanttView.Predecessor()
		Dim task19 As New C1.Win.GanttView.Task()
		Dim predecessor14 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef14 As New C1.Win.GanttView.ResourceRef()
		Dim task20 As New C1.Win.GanttView.Task()
		Dim task21 As New C1.Win.GanttView.Task()
		Dim predecessor15 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef15 As New C1.Win.GanttView.ResourceRef()
		Dim task22 As New C1.Win.GanttView.Task()
		Dim predecessor16 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef16 As New C1.Win.GanttView.ResourceRef()
		Dim task23 As New C1.Win.GanttView.Task()
		Dim predecessor17 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef17 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef18 As New C1.Win.GanttView.ResourceRef()
		Dim task24 As New C1.Win.GanttView.Task()
		Dim task25 As New C1.Win.GanttView.Task()
		Dim task26 As New C1.Win.GanttView.Task()
		Dim task27 As New C1.Win.GanttView.Task()
		Dim task28 As New C1.Win.GanttView.Task()
		Me.c1GanttView1 = New C1.Win.GanttView.C1GanttView()
		Me.btnOutdent = New System.Windows.Forms.Button()
		Me.btnIndent = New System.Windows.Forms.Button()
		Me.comboGroupBy = New System.Windows.Forms.ComboBox()
		Me.chkMaintainHierarchy = New System.Windows.Forms.CheckBox()
		Me.chkShowProjectSummary = New System.Windows.Forms.CheckBox()
		Me.summaryGroupBox = New System.Windows.Forms.GroupBox()
		Me.groupGroupBox = New System.Windows.Forms.GroupBox()
		DirectCast(Me.c1GanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.summaryGroupBox.SuspendLayout()
		Me.groupGroupBox.SuspendLayout()
		Me.SuspendLayout()
		' 
		' c1GanttView1
		' 
		Me.c1GanttView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.c1GanttView1.BackColor = System.Drawing.SystemColors.Window
		calendarException1.Name = "Vacation"
		calendarException1.RecurrencePattern.DayOfMonth = 10
		calendarException1.RecurrencePattern.MonthOfYear = 7
		calendarException1.StartDate = New System.DateTime(2013, 6, 10, 0, 0, 0, _
			0)
		Me.c1GanttView1.CalendarExceptions.Add(calendarException1)
		taskPropertyColumn1.Caption = "Task Mode"
		taskPropertyColumn1.ID = 619243840
		taskPropertyColumn1.[Property] = C1.Win.GanttView.TaskProperty.Mode
		taskPropertyColumn1.Width = 51
		taskPropertyColumn2.Caption = "Task Name"
		taskPropertyColumn2.ID = 2099866733
		taskPropertyColumn2.[Property] = C1.Win.GanttView.TaskProperty.Name
		taskPropertyColumn2.Width = 125
		taskPropertyColumn3.Caption = "Duration"
		taskPropertyColumn3.ID = 1358251825
		taskPropertyColumn3.[Property] = C1.Win.GanttView.TaskProperty.Duration
		taskPropertyColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		taskPropertyColumn3.Width = 50
		taskPropertyColumn4.Caption = "Duration Units"
		taskPropertyColumn4.ID = 1827635185
		taskPropertyColumn4.[Property] = C1.Win.GanttView.TaskProperty.DurationUnits
		taskPropertyColumn4.Width = 59
		taskPropertyColumn5.Caption = "Start"
		taskPropertyColumn5.ID = 1435981949
		taskPropertyColumn5.[Property] = C1.Win.GanttView.TaskProperty.Start
		taskPropertyColumn5.Width = 94
		taskPropertyColumn6.Caption = "Finish"
		taskPropertyColumn6.ID = 1177114106
		taskPropertyColumn6.[Property] = C1.Win.GanttView.TaskProperty.Finish
		taskPropertyColumn6.Width = 104
		taskPropertyColumn7.Caption = "% Complete"
		taskPropertyColumn7.ID = 705116663
		taskPropertyColumn7.[Property] = C1.Win.GanttView.TaskProperty.PercentComplete
		taskPropertyColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		taskPropertyColumn8.Caption = "Constraint Type"
		taskPropertyColumn8.ID = 1424686126
		taskPropertyColumn8.[Property] = C1.Win.GanttView.TaskProperty.ConstraintType
		taskPropertyColumn8.Visible = False
		taskPropertyColumn9.Caption = "Constraint Date"
		taskPropertyColumn9.ID = 1191399244
		taskPropertyColumn9.[Property] = C1.Win.GanttView.TaskProperty.ConstraintDate
		taskPropertyColumn9.Visible = False
		taskPropertyColumn10.Caption = "Predecessors"
		taskPropertyColumn10.ID = 502674747
		taskPropertyColumn10.[Property] = C1.Win.GanttView.TaskProperty.Predecessors
		taskPropertyColumn10.Visible = False
		taskPropertyColumn11.Caption = "Deadline"
		taskPropertyColumn11.ID = 166462627
		taskPropertyColumn11.[Property] = C1.Win.GanttView.TaskProperty.Deadline
		taskPropertyColumn11.Visible = False
		taskPropertyColumn12.Caption = "Calendar"
		taskPropertyColumn12.ID = 997563278
		taskPropertyColumn12.[Property] = C1.Win.GanttView.TaskProperty.Calendar
		taskPropertyColumn12.Visible = False
		taskPropertyColumn13.Caption = "Resource Names"
		taskPropertyColumn13.ID = 1673084976
		taskPropertyColumn13.[Property] = C1.Win.GanttView.TaskProperty.ResourceNames
		taskPropertyColumn13.Visible = False
		taskPropertyColumn14.Caption = "Notes"
		taskPropertyColumn14.ID = 1052675343
		taskPropertyColumn14.[Property] = C1.Win.GanttView.TaskProperty.Notes
		taskPropertyColumn14.Visible = False
		Me.c1GanttView1.Columns.Add(taskPropertyColumn1)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn2)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn3)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn4)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn5)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn6)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn7)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn8)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn9)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn10)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn11)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn12)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn13)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn14)
		Me.c1GanttView1.DefaultWorkingTimes.Interval_1.Empty = False
		Me.c1GanttView1.DefaultWorkingTimes.Interval_1.From = New System.DateTime(1, 1, 1, 8, 30, 0, _
			0)
		Me.c1GanttView1.DefaultWorkingTimes.Interval_1.[To] = New System.DateTime(1, 1, 1, 12, 0, 0, _
			0)
		Me.c1GanttView1.DefaultWorkingTimes.Interval_2.Empty = False
		Me.c1GanttView1.DefaultWorkingTimes.Interval_2.From = New System.DateTime(1, 1, 1, 13, 30, 0, _
			0)
		Me.c1GanttView1.DefaultWorkingTimes.Interval_2.[To] = New System.DateTime(1, 1, 1, 18, 0, 0, _
			0)
		Me.c1GanttView1.FirstMonthOfFY = C1.Win.GanttView.FirstMonthOfFY.March
		Me.c1GanttView1.GridWidth = 323
        Me.c1GanttView1.GroupDefinition.Items.Add(New C1.Win.GanttView.DurationGroup(True))
		Me.c1GanttView1.Location = New System.Drawing.Point(0, 1)
		Me.c1GanttView1.Name = "c1GanttView1"
		Me.c1GanttView1.NonworkingTimeColor = System.Drawing.Color.FromArgb(CInt(CByte(230)), CInt(CByte(185)), CInt(CByte(184)))
		Me.c1GanttView1.ProgressLine.StatusDate = New System.DateTime(2013, 7, 24, 0, 0, 0, _
			0)
		Me.c1GanttView1.ProgressLine.Visible = True
		task1.ID = 1331333418
		task1.Mode = C1.Win.GanttView.TaskMode.Automatic
		task1.Name = "Project Summary Task"
		task1.PercentComplete = 0.282442748091603
		Me.c1GanttView1.ProjectSummary = task1
		resource1.Cost = New Decimal(New Integer() {100, 0, 0, 0})
		resource1.ID = 1640417825
		resource1.Name = "Rita Been"
		resource1.Notes = "Tester"
		resource2.Cost = New Decimal(New Integer() {250, 0, 0, 0})
		resource2.ID = 239555279
		resource2.Name = "Eric Smith"
		resource2.Notes = "Project Manager"
		resource3.Cost = New Decimal(New Integer() {150, 0, 0, 0})
		resource3.ID = 766290656
		resource3.Name = "Daniel Hank"
		resource3.Notes = "Analyst"
		resource4.Cost = New Decimal(New Integer() {300, 0, 0, 0})
		resource4.ID = 2011144056
		resource4.Name = "Juan Carlos"
		resource4.Notes = "Developer"
		resource5.Cost = New Decimal(New Integer() {100, 0, 0, 0})
		resource5.ID = 448108000
		resource5.Name = "Mike Jones "
		resource5.Notes = "Developer"
		resource6.Cost = New Decimal(New Integer() {400, 0, 0, 0})
		resource6.ID = 1869891731
		resource6.Name = "Chris Lee"
		resource6.Notes = "Developer"
		resource7.Cost = New Decimal(New Integer() {250, 0, 0, 0})
		resource7.ID = 556319480
		resource7.Name = "Sarah Robert"
		resource7.Notes = "Tester"
		resource8.Cost = New Decimal(New Integer() {200, 0, 0, 0})
		resource8.ID = 1334638351
		resource8.Name = "Micheal Owen"
		resource8.Notes = "Documentation Maker"
		resource9.Cost = New Decimal(New Integer() {150, 0, 0, 0})
		resource9.ID = 2101511829
		resource9.Name = "Juliet Paul"
		resource9.Notes = "Documentation Maker"
		Me.c1GanttView1.Resources.Add(resource1)
		Me.c1GanttView1.Resources.Add(resource2)
		Me.c1GanttView1.Resources.Add(resource3)
		Me.c1GanttView1.Resources.Add(resource4)
		Me.c1GanttView1.Resources.Add(resource5)
		Me.c1GanttView1.Resources.Add(resource6)
		Me.c1GanttView1.Resources.Add(resource7)
		Me.c1GanttView1.Resources.Add(resource8)
		Me.c1GanttView1.Resources.Add(resource9)
		Me.c1GanttView1.ShowToolbar = False
		Me.c1GanttView1.Size = New System.Drawing.Size(1114, 555)
		Me.c1GanttView1.StartDate = New System.DateTime(2013, 6, 5, 0, 0, 0, _
			0)
		Me.c1GanttView1.TabIndex = 0
		task2.ID = 939539143
		task2.Mode = C1.Win.GanttView.TaskMode.Automatic
		task2.Name = "Acquisition"
		task2.OutlineParentID = 1331333418
		task2.PercentComplete = 1.0
		task3.ConstraintDate = New System.DateTime(2013, 6, 6, 0, 0, 0, _
			0)
		task3.ConstraintType = C1.Win.GanttView.ConstraintType.StartNoEarlierThan
		task3.Duration = 0.0
		task3.ID = 242148085
		task3.Mode = C1.Win.GanttView.TaskMode.Automatic
		task3.Name = "Manuscript received"
		task3.OutlineParentID = 939539143
		task4.ConstraintDate = New System.DateTime(2013, 6, 6, 0, 0, 0, _
			0)
		task4.ConstraintType = C1.Win.GanttView.ConstraintType.StartNoEarlierThan
		task4.Duration = 25.0
		task4.ID = 925207044
		task4.Mode = C1.Win.GanttView.TaskMode.Automatic
		task4.Name = "Content edit"
		task4.OutlineParentID = 939539143
		task4.PercentComplete = 1.0
		predecessor1.PredecessorTaskID = 242148085
		task4.Predecessors.Add(predecessor1)
		resourceRef1.Amount = 1.0
		resourceRef1.ResourceID = 766290656
		resourceRef2.Amount = 1.0
		resourceRef2.ResourceID = 239555279
		resourceRef3.Amount = 1.0
		resourceRef3.ResourceID = 2101511829
		task4.ResourceRefs.Add(resourceRef1)
		task4.ResourceRefs.Add(resourceRef2)
		task4.ResourceRefs.Add(resourceRef3)
		task5.Finish = New System.DateTime(2013, 7, 12, 8, 30, 0, _
			0)
		task5.ID = 362538391
		task5.Name = "Handoff to Editorial"
		task5.OutlineParentID = 939539143
		predecessor2.PredecessorTaskID = 925207044
		task5.Predecessors.Add(predecessor2)
		task5.Start = New System.DateTime(2013, 7, 12, 8, 30, 0, _
			0)
		task6.ID = 1807223556
		task6.Mode = C1.Win.GanttView.TaskMode.Automatic
		task6.Name = "Editorial"
		task6.OutlineParentID = 1331333418
		task6.PercentComplete = 0.0333333333333333
		task7.Finish = New System.DateTime(2013, 7, 19, 8, 30, 0, _
			0)
		task7.ID = 1552574403
		task7.Name = "Organize manuscript for copyedit"
		task7.OutlineParentID = 1807223556
		task7.PercentComplete = 0.2
		predecessor3.PredecessorTaskID = 362538391
		task7.Predecessors.Add(predecessor3)
		resourceRef4.Amount = 1.0
		resourceRef4.ResourceID = 2011144056
		task7.ResourceRefs.Add(resourceRef4)
		task7.Start = New System.DateTime(2013, 7, 12, 8, 30, 0, _
			0)
		task8.Finish = New System.DateTime(2013, 8, 16, 8, 30, 0, _
			0)
		task8.ID = 1179983348
		task8.Name = "Copyedit"
		task8.OutlineParentID = 1807223556
		predecessor4.PredecessorTaskID = 1552574403
		task8.Predecessors.Add(predecessor4)
		resourceRef5.Amount = 1.0
		resourceRef5.ResourceID = 448108000
		task8.ResourceRefs.Add(resourceRef5)
		task8.Start = New System.DateTime(2013, 7, 19, 8, 30, 0, _
			0)
		task9.Finish = New System.DateTime(2013, 8, 23, 8, 30, 0, _
			0)
		task9.ID = 2098269195
		task9.Name = "Copyedit incorp"
		task9.OutlineParentID = 1807223556
		predecessor5.PredecessorTaskID = 1179983348
		task9.Predecessors.Add(predecessor5)
		resourceRef6.Amount = 1.0
		resourceRef6.ResourceID = 2011144056
		task9.ResourceRefs.Add(resourceRef6)
		task9.Start = New System.DateTime(2013, 8, 16, 8, 30, 0, _
			0)
		task10.Finish = New System.DateTime(2013, 8, 23, 8, 30, 0, _
			0)
		task10.ID = 792666599
		task10.Name = "Handoff to Production"
		task10.OutlineParentID = 1807223556
		predecessor6.PredecessorTaskID = 2098269195
		task10.Predecessors.Add(predecessor6)
		task10.Start = New System.DateTime(2013, 8, 23, 8, 30, 0, _
			0)
		task11.Finish = New System.DateTime(2013, 8, 23, 8, 30, 0, _
			0)
		task11.ID = 2121238572
		task11.Name = "Design and Production"
		task11.OutlineParentID = 1331333418
		task11.PercentComplete = 0.366666666666667
		task11.Start = New System.DateTime(2013, 7, 12, 8, 30, 0, _
			0)
		task12.Finish = New System.DateTime(2013, 7, 19, 8, 30, 0, _
			0)
		task12.ID = 312019882
		task12.Name = "Cover design"
		task12.OutlineParentID = 2121238572
		task12.PercentComplete = 1.0
		predecessor7.PredecessorTaskID = 1552574403
		predecessor7.PredecessorType = C1.Win.GanttView.PredecessorType.StartToStart
		task12.Predecessors.Add(predecessor7)
		resourceRef7.Amount = 1.0
		resourceRef7.ResourceID = 1869891731
		task12.ResourceRefs.Add(resourceRef7)
		task12.Start = New System.DateTime(2013, 7, 12, 8, 30, 0, _
			0)
		task13.Finish = New System.DateTime(2013, 8, 2, 8, 30, 0, _
			0)
		task13.ID = 2131650479
		task13.Name = "Set pages"
		task13.OutlineParentID = 2121238572
		task13.PercentComplete = 0.6
		predecessor8.PredecessorTaskID = 312019882
		task13.Predecessors.Add(predecessor8)
		resourceRef8.Amount = 1.0
		resourceRef8.ResourceID = 556319480
		task13.ResourceRefs.Add(resourceRef8)
		task13.Start = New System.DateTime(2013, 7, 19, 8, 30, 0, _
			0)
		task14.Finish = New System.DateTime(2013, 8, 23, 8, 30, 0, _
			0)
		task14.ID = 1600264846
		task14.Name = "Interior illustration design"
		task14.OutlineParentID = 2121238572
		predecessor9.PredecessorTaskID = 2131650479
		task14.Predecessors.Add(predecessor9)
		resourceRef9.Amount = 1.0
		resourceRef9.ResourceID = 1869891731
		resourceRef10.Amount = 1.0
		resourceRef10.ResourceID = 766290656
		task14.ResourceRefs.Add(resourceRef9)
		task14.ResourceRefs.Add(resourceRef10)
		task14.Start = New System.DateTime(2013, 8, 2, 8, 30, 0, _
			0)
		task15.Finish = New System.DateTime(2013, 9, 20, 8, 30, 0, _
			0)
		task15.ID = 185936048
		task15.Name = "Pages review"
		task15.OutlineParentID = 1331333418
		task15.Start = New System.DateTime(2013, 8, 23, 8, 30, 0, _
			0)
		task16.Finish = New System.DateTime(2013, 9, 6, 8, 30, 0, _
			0)
		task16.ID = 1447717244
		task16.Name = "Proofread and index"
		task16.OutlineParentID = 185936048
		predecessor10.PredecessorTaskID = 1600264846
		predecessor11.PredecessorTaskID = 792666599
		task16.Predecessors.Add(predecessor10)
		task16.Predecessors.Add(predecessor11)
		resourceRef11.Amount = 1.0
		resourceRef11.ResourceID = 1334638351
		resourceRef12.Amount = 1.0
		resourceRef12.ResourceID = 2011144056
		task16.ResourceRefs.Add(resourceRef11)
		task16.ResourceRefs.Add(resourceRef12)
		task16.Start = New System.DateTime(2013, 8, 23, 8, 30, 0, _
			0)
		task17.Finish = New System.DateTime(2013, 9, 13, 8, 30, 0, _
			0)
		task17.ID = 1352797036
		task17.Name = "Incorporate 1st Pages review"
		task17.OutlineParentID = 185936048
		predecessor12.PredecessorTaskID = 1447717244
		task17.Predecessors.Add(predecessor12)
		resourceRef13.Amount = 1.0
		resourceRef13.ResourceID = 2101511829
		task17.ResourceRefs.Add(resourceRef13)
		task17.Start = New System.DateTime(2013, 9, 6, 8, 30, 0, _
			0)
		task18.Finish = New System.DateTime(2013, 9, 13, 8, 30, 0, _
			0)
		task18.ID = 1301076315
		task18.Name = "Send proofed pages to Production"
		task18.OutlineParentID = 185936048
		predecessor13.PredecessorTaskID = 1352797036
		task18.Predecessors.Add(predecessor13)
		task18.Start = New System.DateTime(2013, 9, 13, 8, 30, 0, _
			0)
		task19.Finish = New System.DateTime(2013, 9, 20, 8, 30, 0, _
			0)
		task19.ID = 562163695
		task19.Name = "Enter page corrections and index"
		task19.OutlineParentID = 185936048
		predecessor14.PredecessorTaskID = 1301076315
		task19.Predecessors.Add(predecessor14)
		resourceRef14.Amount = 1.0
		resourceRef14.ResourceID = 556319480
		task19.ResourceRefs.Add(resourceRef14)
		task19.Start = New System.DateTime(2013, 9, 13, 8, 30, 0, _
			0)
		task20.Finish = New System.DateTime(2013, 10, 28, 8, 30, 0, _
			0)
		task20.ID = 19552401
		task20.Name = "Color prep and printing"
		task20.OutlineParentID = 1331333418
		task20.Start = New System.DateTime(2013, 9, 20, 8, 30, 0, _
			0)
		task21.Finish = New System.DateTime(2013, 9, 23, 8, 30, 0, _
			0)
		task21.ID = 1597983629
		task21.Name = "Send to color house"
		task21.OutlineParentID = 19552401
		predecessor15.PredecessorTaskID = 562163695
		task21.Predecessors.Add(predecessor15)
		resourceRef15.Amount = 1.0
		resourceRef15.ResourceID = 1640417825
		task21.ResourceRefs.Add(resourceRef15)
		task21.Start = New System.DateTime(2013, 9, 20, 8, 30, 0, _
			0)
		task22.Finish = New System.DateTime(2013, 9, 30, 8, 30, 0, _
			0)
		task22.ID = 591786279
		task22.Name = "Generate proofs"
		task22.OutlineParentID = 19552401
		predecessor16.PredecessorTaskID = 1597983629
		task22.Predecessors.Add(predecessor16)
		resourceRef16.Amount = 1.0
		resourceRef16.ResourceID = 2011144056
		task22.ResourceRefs.Add(resourceRef16)
		task22.Start = New System.DateTime(2013, 9, 23, 8, 30, 0, _
			0)
		task23.Finish = New System.DateTime(2013, 10, 28, 8, 30, 0, _
			0)
		task23.ID = 816445275
		task23.Name = "Print and ship"
		task23.OutlineParentID = 19552401
		predecessor17.PredecessorTaskID = 591786279
		task23.Predecessors.Add(predecessor17)
		resourceRef17.Amount = 1.0
		resourceRef17.ResourceID = 1334638351
		resourceRef18.Amount = 1.0
		resourceRef18.ResourceID = 556319480
		task23.ResourceRefs.Add(resourceRef17)
		task23.ResourceRefs.Add(resourceRef18)
		task23.Start = New System.DateTime(2013, 9, 30, 8, 30, 0, _
			0)
		task24.ID = 514161404
		task25.ID = 992389273
		task26.ID = 246882487
		task27.ID = 1546671531
		task28.ID = 2076126586
		Me.c1GanttView1.Tasks.Add(task2)
		Me.c1GanttView1.Tasks.Add(task3)
		Me.c1GanttView1.Tasks.Add(task4)
		Me.c1GanttView1.Tasks.Add(task5)
		Me.c1GanttView1.Tasks.Add(task6)
		Me.c1GanttView1.Tasks.Add(task7)
		Me.c1GanttView1.Tasks.Add(task8)
		Me.c1GanttView1.Tasks.Add(task9)
		Me.c1GanttView1.Tasks.Add(task10)
		Me.c1GanttView1.Tasks.Add(task11)
		Me.c1GanttView1.Tasks.Add(task12)
		Me.c1GanttView1.Tasks.Add(task13)
		Me.c1GanttView1.Tasks.Add(task14)
		Me.c1GanttView1.Tasks.Add(task15)
		Me.c1GanttView1.Tasks.Add(task16)
		Me.c1GanttView1.Tasks.Add(task17)
		Me.c1GanttView1.Tasks.Add(task18)
		Me.c1GanttView1.Tasks.Add(task19)
		Me.c1GanttView1.Tasks.Add(task20)
		Me.c1GanttView1.Tasks.Add(task21)
		Me.c1GanttView1.Tasks.Add(task22)
		Me.c1GanttView1.Tasks.Add(task23)
		Me.c1GanttView1.Tasks.Add(task24)
		Me.c1GanttView1.Tasks.Add(task25)
		Me.c1GanttView1.Tasks.Add(task26)
		Me.c1GanttView1.Tasks.Add(task27)
		Me.c1GanttView1.Tasks.Add(task28)
		Me.c1GanttView1.Timescale.BottomTier.Align = C1.Win.GanttView.ScaleLabelAlignment.Center
		Me.c1GanttView1.Timescale.BottomTier.Format = "w"
		Me.c1GanttView1.Timescale.BottomTier.Visible = True
		Me.c1GanttView1.Timescale.MiddleTier.Format = "nnnn d"
		Me.c1GanttView1.Timescale.MiddleTier.Units = C1.Win.GanttView.TimescaleUnits.Weeks
		Me.c1GanttView1.Timescale.MiddleTier.Visible = True
		' 
		' btnOutdent
		' 
		Me.btnOutdent.Location = New System.Drawing.Point(13, 25)
		Me.btnOutdent.Name = "btnOutdent"
		Me.btnOutdent.Size = New System.Drawing.Size(87, 29)
		Me.btnOutdent.TabIndex = 1
		Me.btnOutdent.Text = "Outdent"
		Me.btnOutdent.UseVisualStyleBackColor = True
		AddHandler Me.btnOutdent.Click, New System.EventHandler(AddressOf Me.btnOutdent_Click)
		' 
		' btnIndent
		' 
		Me.btnIndent.Location = New System.Drawing.Point(107, 25)
		Me.btnIndent.Name = "btnIndent"
		Me.btnIndent.Size = New System.Drawing.Size(87, 29)
		Me.btnIndent.TabIndex = 2
		Me.btnIndent.Text = "Indent"
		Me.btnIndent.UseVisualStyleBackColor = True
		AddHandler Me.btnIndent.Click, New System.EventHandler(AddressOf Me.btnIndent_Click)
		' 
		' comboGroupBy
		' 
		Me.comboGroupBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.comboGroupBy.FormattingEnabled = True
		Me.comboGroupBy.Items.AddRange(New Object() {"No Group", "Task Mode", "Task Complete", "Constraint Type", "Duration", "Milestones", _
			"Resource", "Status", "Advance Group"})
		Me.comboGroupBy.Location = New System.Drawing.Point(13, 22)
		Me.comboGroupBy.Name = "comboGroupBy"
		Me.comboGroupBy.Size = New System.Drawing.Size(140, 23)
		Me.comboGroupBy.TabIndex = 4
		' 
		' chkMaintainHierarchy
		' 
		Me.chkMaintainHierarchy.AutoSize = True
		Me.chkMaintainHierarchy.Location = New System.Drawing.Point(13, 59)
		Me.chkMaintainHierarchy.Name = "chkMaintainHierarchy"
		Me.chkMaintainHierarchy.Size = New System.Drawing.Size(127, 19)
		Me.chkMaintainHierarchy.TabIndex = 5
		Me.chkMaintainHierarchy.Text = "Maintain Hierarchy"
		Me.chkMaintainHierarchy.UseVisualStyleBackColor = True
		AddHandler Me.chkMaintainHierarchy.CheckedChanged, New System.EventHandler(AddressOf Me.chkMaintainHierarchy_CheckedChanged)
		' 
		' chkShowProjectSummary
		' 
		Me.chkShowProjectSummary.AutoSize = True
		Me.chkShowProjectSummary.Location = New System.Drawing.Point(13, 61)
		Me.chkShowProjectSummary.Name = "chkShowProjectSummary"
		Me.chkShowProjectSummary.Size = New System.Drawing.Size(149, 19)
		Me.chkShowProjectSummary.TabIndex = 5
		Me.chkShowProjectSummary.Text = "Show Project Summary"
		Me.chkShowProjectSummary.UseVisualStyleBackColor = True
		AddHandler Me.chkShowProjectSummary.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowProjectSummary_CheckedChanged)
		' 
		' summaryGroupBox
		' 
		Me.summaryGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.summaryGroupBox.Controls.Add(Me.btnOutdent)
		Me.summaryGroupBox.Controls.Add(Me.chkShowProjectSummary)
		Me.summaryGroupBox.Controls.Add(Me.btnIndent)
		Me.summaryGroupBox.Location = New System.Drawing.Point(1139, 1)
		Me.summaryGroupBox.Name = "summaryGroupBox"
		Me.summaryGroupBox.Size = New System.Drawing.Size(209, 85)
		Me.summaryGroupBox.TabIndex = 6
		Me.summaryGroupBox.TabStop = False
		Me.summaryGroupBox.Text = "Summary"
		' 
		' groupGroupBox
		' 
		Me.groupGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.groupGroupBox.Controls.Add(Me.comboGroupBy)
		Me.groupGroupBox.Controls.Add(Me.chkMaintainHierarchy)
		Me.groupGroupBox.Location = New System.Drawing.Point(1139, 105)
		Me.groupGroupBox.Name = "groupGroupBox"
		Me.groupGroupBox.Size = New System.Drawing.Size(206, 89)
		Me.groupGroupBox.TabIndex = 7
		Me.groupGroupBox.TabStop = False
		Me.groupGroupBox.Text = "Group"
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 15F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1362, 558)
		Me.Controls.Add(Me.groupGroupBox)
		Me.Controls.Add(Me.summaryGroupBox)
		Me.Controls.Add(Me.c1GanttView1)
		Me.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.Name = "Form1"
		Me.Text = "Group Sample"
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
		DirectCast(Me.c1GanttView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.summaryGroupBox.ResumeLayout(False)
		Me.summaryGroupBox.PerformLayout()
		Me.groupGroupBox.ResumeLayout(False)
		Me.groupGroupBox.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private c1GanttView1 As C1.Win.GanttView.C1GanttView
	Private btnOutdent As System.Windows.Forms.Button
	Private btnIndent As System.Windows.Forms.Button
	Private comboGroupBy As System.Windows.Forms.ComboBox
	Private chkMaintainHierarchy As System.Windows.Forms.CheckBox
	Private chkShowProjectSummary As System.Windows.Forms.CheckBox
	Private summaryGroupBox As System.Windows.Forms.GroupBox
	Private groupGroupBox As System.Windows.Forms.GroupBox
End Class

