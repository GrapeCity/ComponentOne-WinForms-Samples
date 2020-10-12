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
		Dim barStyle1 As New C1.Win.C1GanttView.BarStyle()
		Dim barStyle2 As New C1.Win.C1GanttView.BarStyle()
		Dim barStyle3 As New C1.Win.C1GanttView.BarStyle()
		Dim taskPropertyColumn1 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn2 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn3 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn4 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn5 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn6 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn7 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn8 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn9 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn10 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn11 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn12 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn13 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn14 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim task1 As New C1.Win.C1GanttView.Task()
		Dim resource1 As New C1.Win.C1GanttView.Resource()
		Dim resource2 As New C1.Win.C1GanttView.Resource()
		Dim resource3 As New C1.Win.C1GanttView.Resource()
		Dim resource4 As New C1.Win.C1GanttView.Resource()
		Dim task2 As New C1.Win.C1GanttView.Task()
		Dim task3 As New C1.Win.C1GanttView.Task()
		Dim resourceRef1 As New C1.Win.C1GanttView.ResourceRef()
		Dim task4 As New C1.Win.C1GanttView.Task()
		Dim barStyle4 As New C1.Win.C1GanttView.BarStyle()
		Dim barStyle5 As New C1.Win.C1GanttView.BarStyle()
		Dim predecessor1 As New C1.Win.C1GanttView.Predecessor()
		Dim resourceRef2 As New C1.Win.C1GanttView.ResourceRef()
		Dim task5 As New C1.Win.C1GanttView.Task()
		Dim predecessor2 As New C1.Win.C1GanttView.Predecessor()
		Dim resourceRef3 As New C1.Win.C1GanttView.ResourceRef()
		Dim task6 As New C1.Win.C1GanttView.Task()
		Dim predecessor3 As New C1.Win.C1GanttView.Predecessor()
		Dim task7 As New C1.Win.C1GanttView.Task()
		Dim task8 As New C1.Win.C1GanttView.Task()
		Dim predecessor4 As New C1.Win.C1GanttView.Predecessor()
		Dim resourceRef4 As New C1.Win.C1GanttView.ResourceRef()
		Dim task9 As New C1.Win.C1GanttView.Task()
		Dim predecessor5 As New C1.Win.C1GanttView.Predecessor()
		Dim resourceRef5 As New C1.Win.C1GanttView.ResourceRef()
		Dim task10 As New C1.Win.C1GanttView.Task()
		Dim predecessor6 As New C1.Win.C1GanttView.Predecessor()
		Dim task11 As New C1.Win.C1GanttView.Task()
		Dim task12 As New C1.Win.C1GanttView.Task()
		Dim task13 As New C1.Win.C1GanttView.Task()
		Dim task14 As New C1.Win.C1GanttView.Task()
		Dim task15 As New C1.Win.C1GanttView.Task()
		Dim task16 As New C1.Win.C1GanttView.Task()
		Dim task17 As New C1.Win.C1GanttView.Task()
		Dim task18 As New C1.Win.C1GanttView.Task()
		Dim task19 As New C1.Win.C1GanttView.Task()
		Dim task20 As New C1.Win.C1GanttView.Task()
		Dim task21 As New C1.Win.C1GanttView.Task()
		Dim task22 As New C1.Win.C1GanttView.Task()
		Dim task23 As New C1.Win.C1GanttView.Task()
		Dim task24 As New C1.Win.C1GanttView.Task()
		Dim task25 As New C1.Win.C1GanttView.Task()
		Dim task26 As New C1.Win.C1GanttView.Task()
		Dim task27 As New C1.Win.C1GanttView.Task()
		Dim task28 As New C1.Win.C1GanttView.Task()
		Dim task29 As New C1.Win.C1GanttView.Task()
		Dim task30 As New C1.Win.C1GanttView.Task()
		Dim task31 As New C1.Win.C1GanttView.Task()
		Dim task32 As New C1.Win.C1GanttView.Task()
		Dim task33 As New C1.Win.C1GanttView.Task()
		Dim task34 As New C1.Win.C1GanttView.Task()
		Dim task35 As New C1.Win.C1GanttView.Task()
		Dim task36 As New C1.Win.C1GanttView.Task()
		Dim task37 As New C1.Win.C1GanttView.Task()
		Dim task38 As New C1.Win.C1GanttView.Task()
		Dim task39 As New C1.Win.C1GanttView.Task()
		Dim task40 As New C1.Win.C1GanttView.Task()
		Dim task41 As New C1.Win.C1GanttView.Task()
		Dim task42 As New C1.Win.C1GanttView.Task()
		Dim task43 As New C1.Win.C1GanttView.Task()
		Dim task44 As New C1.Win.C1GanttView.Task()
		Dim task45 As New C1.Win.C1GanttView.Task()
		Dim task46 As New C1.Win.C1GanttView.Task()
		Dim task47 As New C1.Win.C1GanttView.Task()
		Dim task48 As New C1.Win.C1GanttView.Task()
		Dim task49 As New C1.Win.C1GanttView.Task()
		Dim task50 As New C1.Win.C1GanttView.Task()
		Dim task51 As New C1.Win.C1GanttView.Task()
		Dim task52 As New C1.Win.C1GanttView.Task()
		Dim task53 As New C1.Win.C1GanttView.Task()
		Dim task54 As New C1.Win.C1GanttView.Task()
		Dim task55 As New C1.Win.C1GanttView.Task()
		Dim task56 As New C1.Win.C1GanttView.Task()
		Dim task57 As New C1.Win.C1GanttView.Task()
		Dim task58 As New C1.Win.C1GanttView.Task()
		Dim task59 As New C1.Win.C1GanttView.Task()
		Dim task60 As New C1.Win.C1GanttView.Task()
		Dim task61 As New C1.Win.C1GanttView.Task()
		Me.c1GanttView1 = New C1.Win.C1GanttView.C1GanttView()
		DirectCast(Me.c1GanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' c1GanttView1
		' 
		Me.c1GanttView1.BackColor = System.Drawing.SystemColors.Window
		barStyle1.BarColor = System.Drawing.Color.FromArgb(CInt(CByte(64)), CInt(CByte(135)), CInt(CByte(220)))
		barStyle1.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
		barStyle1.BarType = C1.Win.C1GanttView.BarType.AutoTask
		barStyle1.RightText1_ID = -13
		barStyle1.TopText1_ID = 839049373
		barStyle2.BarColor = System.Drawing.Color.FromArgb(CInt(CByte(25)), CInt(CByte(200)), CInt(CByte(209)))
		barStyle2.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
		barStyle2.BarType = C1.Win.C1GanttView.BarType.ManualTask
		barStyle2.EndShape = 22
		barStyle2.RightText1_ID = -13
		barStyle2.StartShape = 21
		barStyle2.TopText1_ID = 839049373
		barStyle3.BarShape = C1.Win.C1GanttView.BarShape.TopBar
		barStyle3.BarType = C1.Win.C1GanttView.BarType.SummaryTask
		barStyle3.EndShape = 2
		barStyle3.StartShape = 2
		barStyle3.TopText1_ID = 839049373
		Me.c1GanttView1.BarStyles.Add(barStyle1)
		Me.c1GanttView1.BarStyles.Add(barStyle2)
		Me.c1GanttView1.BarStyles.Add(barStyle3)
		taskPropertyColumn1.ID = 115863021
		taskPropertyColumn1.[Property] = C1.Win.C1GanttView.TaskProperty.Mode
		taskPropertyColumn2.ID = 839049373
		taskPropertyColumn2.[Property] = C1.Win.C1GanttView.TaskProperty.Name
		taskPropertyColumn3.ID = 1824679307
		taskPropertyColumn3.[Property] = C1.Win.C1GanttView.TaskProperty.Duration
		taskPropertyColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		taskPropertyColumn4.ID = 492555211
		taskPropertyColumn4.[Property] = C1.Win.C1GanttView.TaskProperty.DurationUnits
		taskPropertyColumn5.ID = 715159541
		taskPropertyColumn5.[Property] = C1.Win.C1GanttView.TaskProperty.Start
		taskPropertyColumn6.ID = 142543729
		taskPropertyColumn6.[Property] = C1.Win.C1GanttView.TaskProperty.Finish
		taskPropertyColumn7.ID = 189872326
		taskPropertyColumn7.[Property] = C1.Win.C1GanttView.TaskProperty.PercentComplete
		taskPropertyColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		taskPropertyColumn7.Visible = False
		taskPropertyColumn8.ID = 950914077
		taskPropertyColumn8.[Property] = C1.Win.C1GanttView.TaskProperty.ConstraintType
		taskPropertyColumn8.Visible = False
		taskPropertyColumn9.ID = 1053593084
		taskPropertyColumn9.[Property] = C1.Win.C1GanttView.TaskProperty.ConstraintDate
		taskPropertyColumn9.Visible = False
		taskPropertyColumn10.ID = 350181539
		taskPropertyColumn10.[Property] = C1.Win.C1GanttView.TaskProperty.Predecessors
		taskPropertyColumn10.Visible = False
		taskPropertyColumn11.ID = 294597990
		taskPropertyColumn11.[Property] = C1.Win.C1GanttView.TaskProperty.Deadline
		taskPropertyColumn11.Visible = False
		taskPropertyColumn12.ID = 278348232
		taskPropertyColumn12.[Property] = C1.Win.C1GanttView.TaskProperty.Calendar
		taskPropertyColumn12.Visible = False
		taskPropertyColumn13.ID = 366124261
		taskPropertyColumn13.[Property] = C1.Win.C1GanttView.TaskProperty.ResourceNames
		taskPropertyColumn13.Visible = False
		taskPropertyColumn14.ID = 1783824597
		taskPropertyColumn14.[Property] = C1.Win.C1GanttView.TaskProperty.Notes
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
		Me.c1GanttView1.DefaultWorkingTimes.Interval_1.From = New System.DateTime(1, 1, 1, 9, 0, 0, _
			0)
		Me.c1GanttView1.DefaultWorkingTimes.Interval_1.[To] = New System.DateTime(1, 1, 1, 13, 0, 0, _
			0)
		Me.c1GanttView1.DefaultWorkingTimes.Interval_2.Empty = False
		Me.c1GanttView1.DefaultWorkingTimes.Interval_2.From = New System.DateTime(1, 1, 1, 14, 0, 0, _
			0)
		Me.c1GanttView1.DefaultWorkingTimes.Interval_2.[To] = New System.DateTime(1, 1, 1, 18, 0, 0, _
			0)
		Me.c1GanttView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.c1GanttView1.GridWidth = 218
		Me.c1GanttView1.Location = New System.Drawing.Point(0, 0)
		Me.c1GanttView1.Name = "c1GanttView1"
		task1.ID = 970674227
		task1.Mode = C1.Win.C1GanttView.TaskMode.Automatic
		task1.Name = "Project Summary Task"
		task1.PercentComplete = 0.7083333375
		Me.c1GanttView1.ProjectSummary = task1
		resource1.ID = 1622083619
		resource1.Name = "Scarlett"
		resource2.ID = 1374314959
		resource2.Name = "Thomas"
		resource3.ID = 1653216189
		resource3.Name = "Peter"
		resource4.ID = 1847509816
		resource4.Name = "Hassan"
		Me.c1GanttView1.Resources.Add(resource1)
		Me.c1GanttView1.Resources.Add(resource2)
		Me.c1GanttView1.Resources.Add(resource3)
		Me.c1GanttView1.Resources.Add(resource4)
		Me.c1GanttView1.Size = New System.Drawing.Size(656, 405)
		Me.c1GanttView1.StartDate = New System.DateTime(2014, 4, 15, 0, 0, 0, _
			0)
		Me.c1GanttView1.TabIndex = 0
		task2.Finish = New System.DateTime(2014, 4, 8, 9, 0, 0, _
			0)
		task2.ID = 1187951112
		task2.Name = "Sprint 1"
		task2.OutlineParentID = 970674227
		task2.PercentComplete = 0.60000001
		task2.Start = New System.DateTime(2014, 3, 25, 0, 0, 0, _
			0)
		task3.Finish = New System.DateTime(2014, 3, 29, 0, 0, 0, _
			0)
		task3.ID = 763953103
		task3.Name = "Task 1.1"
		task3.OutlineParentID = 1187951112
		task3.PercentComplete = 1.0
		resourceRef1.Amount = 1.0
		resourceRef1.ResourceID = 1622083619
		task3.ResourceRefs.Add(resourceRef1)
		task3.Start = New System.DateTime(2014, 3, 25, 0, 0, 0, _
			0)
		barStyle4.BarColor = System.Drawing.Color.FromArgb(CInt(CByte(64)), CInt(CByte(135)), CInt(CByte(220)))
		barStyle4.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
		barStyle4.BarType = C1.Win.C1GanttView.BarType.AutoTask
		barStyle4.RightText1_ID = -13
		barStyle4.TopText1_ID = 839049373
		barStyle5.BarColor = System.Drawing.Color.FromArgb(CInt(CByte(25)), CInt(CByte(200)), CInt(CByte(209)))
		barStyle5.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
		barStyle5.BarType = C1.Win.C1GanttView.BarType.ManualTask
		barStyle5.EndShape = 22
		barStyle5.RightText1_ID = -13
		barStyle5.StartShape = 21
		barStyle5.TopText1_ID = 839049373
		task4.BarStyles.Add(barStyle4)
		task4.BarStyles.Add(barStyle5)
		task4.Finish = New System.DateTime(2014, 4, 3, 9, 0, 0, _
			0)
		task4.ID = 1511903109
		task4.Name = "Task 1.2"
		task4.OutlineParentID = 1187951112
		predecessor1.PredecessorTaskID = 763953103
		task4.Predecessors.Add(predecessor1)
		resourceRef2.Amount = 1.0
		resourceRef2.ResourceID = 1653216189
		task4.ResourceRefs.Add(resourceRef2)
		task4.Start = New System.DateTime(2014, 3, 29, 0, 0, 0, _
			0)
		task5.ConstraintDate = New System.DateTime(2014, 4, 3, 0, 0, 0, _
			0)
		task5.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
		task5.Duration = 3.0
		task5.ID = 1825346952
		task5.Mode = C1.Win.C1GanttView.TaskMode.Automatic
		task5.Name = "Task 1.3"
		task5.OutlineParentID = 1187951112
		task5.PercentComplete = 0.6666667
		predecessor2.PredecessorTaskID = 1511903109
		task5.Predecessors.Add(predecessor2)
		resourceRef3.Amount = 1.0
		resourceRef3.ResourceID = 1847509816
		task5.ResourceRefs.Add(resourceRef3)
		task6.Finish = New System.DateTime(2014, 4, 8, 9, 0, 0, _
			0)
		task6.ID = 1077139004
		task6.Name = "Complete Sprint 1"
		task6.OutlineParentID = 1187951112
		predecessor3.PredecessorTaskID = 1825346952
		task6.Predecessors.Add(predecessor3)
		task6.Start = New System.DateTime(2014, 4, 8, 9, 0, 0, _
			0)
		task7.Finish = New System.DateTime(2014, 4, 28, 9, 0, 0, _
			0)
		task7.ID = 1961218391
		task7.Name = "Sprint 2"
		task7.OutlineParentID = 970674227
		task7.PercentComplete = 0.785714285714286
		task7.Start = New System.DateTime(2014, 4, 8, 9, 0, 0, _
			0)
		task8.ConstraintDate = New System.DateTime(2014, 4, 8, 0, 0, 0, _
			0)
		task8.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
		task8.Duration = 6.0
		task8.ID = 1129365440
		task8.Mode = C1.Win.C1GanttView.TaskMode.Automatic
		task8.Name = "Task 2.1"
		task8.OutlineParentID = 1961218391
		task8.PercentComplete = 0.5
		predecessor4.PredecessorTaskID = 1077139004
		task8.Predecessors.Add(predecessor4)
		resourceRef4.Amount = 1.0
		resourceRef4.ResourceID = 1374314959
		task8.ResourceRefs.Add(resourceRef4)
		task9.Finish = New System.DateTime(2014, 4, 28, 9, 0, 0, _
			0)
		task9.ID = 675416228
		task9.Name = "Task 2.2"
		task9.OutlineParentID = 1961218391
		task9.PercentComplete = 1.0
		predecessor5.PredecessorTaskID = 1129365440
		task9.Predecessors.Add(predecessor5)
		resourceRef5.Amount = 1.0
		resourceRef5.ResourceID = 1653216189
		task9.ResourceRefs.Add(resourceRef5)
		task9.Start = New System.DateTime(2014, 4, 16, 9, 0, 0, _
			0)
		task10.Finish = New System.DateTime(2014, 4, 28, 9, 0, 0, _
			0)
		task10.ID = 63380755
		task10.Name = "Complete Sprint 2"
		task10.OutlineParentID = 1961218391
		predecessor6.PredecessorTaskID = 675416228
		task10.Predecessors.Add(predecessor6)
		task10.Start = New System.DateTime(2014, 4, 28, 9, 0, 0, _
			0)
		task11.ID = 1041196519
		task12.ID = 1065666771
		task13.ID = 1869723603
		task14.ID = 1139603790
		task15.ID = 1560741278
		task16.ID = 1425805567
		task17.ID = 723544461
		task18.ID = 1625024465
		task19.ID = 1598943533
		task20.ID = 838099651
		task21.ID = 545824578
		task22.ID = 1828106548
		task23.ID = 1657702805
		task24.ID = 1042539893
		task25.ID = 984344103
		task26.ID = 1966528540
		task27.ID = 447284804
		task28.ID = 1845355371
		task29.ID = 290316068
		task30.ID = 998220569
		task31.ID = 1718309192
		task32.ID = 326036979
		task33.ID = 923123043
		task34.ID = 1679851278
		task35.ID = 188689714
		task36.ID = 507148195
		task37.ID = 1075624029
		task38.ID = 428946472
		task39.ID = 1346676234
		task40.ID = 1232819273
		task41.ID = 1201758702
		task42.ID = 2105687059
		task43.ID = 1026127421
		task44.ID = 775375388
		task45.ID = 487608693
		task46.ID = 683612193
		task47.ID = 795531031
		task48.ID = 860459586
		task49.ID = 1482982052
		task50.ID = 1784935651
		task51.ID = 706118151
		task52.ID = 1637670175
		task53.ID = 2111275435
		task54.ID = 490816137
		task55.ID = 165670924
		task56.ID = 1290051327
		task57.ID = 1677731955
		task58.ID = 1868896858
		task59.ID = 527559007
		task60.ID = 2006302060
		task61.ID = 629854201
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
		Me.c1GanttView1.Tasks.Add(task29)
		Me.c1GanttView1.Tasks.Add(task30)
		Me.c1GanttView1.Tasks.Add(task31)
		Me.c1GanttView1.Tasks.Add(task32)
		Me.c1GanttView1.Tasks.Add(task33)
		Me.c1GanttView1.Tasks.Add(task34)
		Me.c1GanttView1.Tasks.Add(task35)
		Me.c1GanttView1.Tasks.Add(task36)
		Me.c1GanttView1.Tasks.Add(task37)
		Me.c1GanttView1.Tasks.Add(task38)
		Me.c1GanttView1.Tasks.Add(task39)
		Me.c1GanttView1.Tasks.Add(task40)
		Me.c1GanttView1.Tasks.Add(task41)
		Me.c1GanttView1.Tasks.Add(task42)
		Me.c1GanttView1.Tasks.Add(task43)
		Me.c1GanttView1.Tasks.Add(task44)
		Me.c1GanttView1.Tasks.Add(task45)
		Me.c1GanttView1.Tasks.Add(task46)
		Me.c1GanttView1.Tasks.Add(task47)
		Me.c1GanttView1.Tasks.Add(task48)
		Me.c1GanttView1.Tasks.Add(task49)
		Me.c1GanttView1.Tasks.Add(task50)
		Me.c1GanttView1.Tasks.Add(task51)
		Me.c1GanttView1.Tasks.Add(task52)
		Me.c1GanttView1.Tasks.Add(task53)
		Me.c1GanttView1.Tasks.Add(task54)
		Me.c1GanttView1.Tasks.Add(task55)
		Me.c1GanttView1.Tasks.Add(task56)
		Me.c1GanttView1.Tasks.Add(task57)
		Me.c1GanttView1.Tasks.Add(task58)
		Me.c1GanttView1.Tasks.Add(task59)
		Me.c1GanttView1.Tasks.Add(task60)
		Me.c1GanttView1.Tasks.Add(task61)
		Me.c1GanttView1.Timescale.BottomTier.Align = C1.Win.C1GanttView.ScaleLabelAlignment.Center
		Me.c1GanttView1.Timescale.BottomTier.Format = "w"
		Me.c1GanttView1.Timescale.BottomTier.Visible = True
		Me.c1GanttView1.Timescale.MiddleTier.Format = "nnnn d"
		Me.c1GanttView1.Timescale.MiddleTier.Units = C1.Win.C1GanttView.TimescaleUnits.Weeks
		Me.c1GanttView1.Timescale.MiddleTier.Visible = True
		AddHandler Me.c1GanttView1.ShowDialog, New C1.Win.C1GanttView.ShowDialogEventHandler(AddressOf Me.c1GanttView1_ShowDialog)
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(656, 405)
		Me.Controls.Add(Me.c1GanttView1)
		Me.Name = "Form1"
		Me.Text = "Form1"
		DirectCast(Me.c1GanttView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private c1GanttView1 As C1.Win.C1GanttView.C1GanttView
End Class

