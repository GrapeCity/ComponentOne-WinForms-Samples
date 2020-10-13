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
		Dim taskPropertyColumn1 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn2 As New C1.Win.C1GanttView.TaskPropertyColumn()
		Dim customFieldColumn1 As New C1.Win.C1GanttView.CustomFieldColumn()
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
		Dim resource1 As New C1.Win.C1GanttView.Resource()
		Dim resource2 As New C1.Win.C1GanttView.Resource()
		Dim resource3 As New C1.Win.C1GanttView.Resource()
		Dim resource4 As New C1.Win.C1GanttView.Resource()
		Dim task1 As New C1.Win.C1GanttView.Task()
		Dim task2 As New C1.Win.C1GanttView.Task()
		Dim resourceRef1 As New C1.Win.C1GanttView.ResourceRef()
		Dim resourceRef2 As New C1.Win.C1GanttView.ResourceRef()
		Dim task3 As New C1.Win.C1GanttView.Task()
		Dim resourceRef3 As New C1.Win.C1GanttView.ResourceRef()
		Dim task4 As New C1.Win.C1GanttView.Task()
		Dim task5 As New C1.Win.C1GanttView.Task()
		Dim resourceRef4 As New C1.Win.C1GanttView.ResourceRef()
		Dim resourceRef5 As New C1.Win.C1GanttView.ResourceRef()
		Dim task6 As New C1.Win.C1GanttView.Task()
		Dim predecessor1 As New C1.Win.C1GanttView.Predecessor()
		Dim resourceRef6 As New C1.Win.C1GanttView.ResourceRef()
		Dim task7 As New C1.Win.C1GanttView.Task()
		Dim predecessor2 As New C1.Win.C1GanttView.Predecessor()
		Dim resourceRef7 As New C1.Win.C1GanttView.ResourceRef()
		Dim task8 As New C1.Win.C1GanttView.Task()
		Dim resourceRef8 As New C1.Win.C1GanttView.ResourceRef()
		Dim task9 As New C1.Win.C1GanttView.Task()
		Dim task10 As New C1.Win.C1GanttView.Task()
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
		Me.c1GanttView1 = New C1.Win.C1GanttView.C1GanttView()
		Me.btnZoomSelectedTask = New System.Windows.Forms.Button()
		Me.btnZoomEntireProject = New System.Windows.Forms.Button()
		Me.btnZoomIn = New System.Windows.Forms.Button()
		Me.btnZoomOut = New System.Windows.Forms.Button()
		DirectCast(Me.c1GanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' btnZoomSelectedTask
		' 
		Me.btnZoomSelectedTask.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnZoomSelectedTask.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.btnZoomSelectedTask.Location = New System.Drawing.Point(313, 521)
		Me.btnZoomSelectedTask.Name = "btnZoomSelectedTask"
		Me.btnZoomSelectedTask.Size = New System.Drawing.Size(122, 29)
		Me.btnZoomSelectedTask.TabIndex = 1
		Me.btnZoomSelectedTask.Text = "Zoom Selected Task"
		Me.btnZoomSelectedTask.UseVisualStyleBackColor = True
		AddHandler Me.btnZoomSelectedTask.Click, New System.EventHandler(AddressOf Me.btnZoomSelectedTask_Click)
		' 
		' btnZoomEntireProject
		' 
		Me.btnZoomEntireProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnZoomEntireProject.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.btnZoomEntireProject.Location = New System.Drawing.Point(483, 521)
		Me.btnZoomEntireProject.Name = "btnZoomEntireProject"
		Me.btnZoomEntireProject.Size = New System.Drawing.Size(138, 29)
		Me.btnZoomEntireProject.TabIndex = 1
		Me.btnZoomEntireProject.Text = "Zoom To Entire Project"
		Me.btnZoomEntireProject.UseVisualStyleBackColor = True
		AddHandler Me.btnZoomEntireProject.Click, New System.EventHandler(AddressOf Me.btnZoomEntireProject_Click)
		' 
		' btnZoomIn
		' 
		Me.btnZoomIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnZoomIn.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.btnZoomIn.Location = New System.Drawing.Point(683, 521)
		Me.btnZoomIn.Name = "btnZoomIn"
		Me.btnZoomIn.Size = New System.Drawing.Size(75, 29)
		Me.btnZoomIn.TabIndex = 1
		Me.btnZoomIn.Text = "Zoom In"
		Me.btnZoomIn.UseVisualStyleBackColor = True
		AddHandler Me.btnZoomIn.Click, New System.EventHandler(AddressOf Me.btnZoomIn_Click)
		' 
		' btnZoomOut
		' 
		Me.btnZoomOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnZoomOut.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CByte(0))
		Me.btnZoomOut.Location = New System.Drawing.Point(822, 521)
		Me.btnZoomOut.Name = "btnZoomOut"
		Me.btnZoomOut.Size = New System.Drawing.Size(78, 29)
		Me.btnZoomOut.TabIndex = 1
		Me.btnZoomOut.Text = "Zoom Out"
		Me.btnZoomOut.UseVisualStyleBackColor = True
		AddHandler Me.btnZoomOut.Click, New System.EventHandler(AddressOf Me.btnZoomOut_Click)
		' 
		' c1GanttView1
		' 
		Me.c1GanttView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.c1GanttView1.BackColor = System.Drawing.SystemColors.Window
		barStyle1.BarColor = System.Drawing.Color.FromArgb(CInt(CByte(64)), CInt(CByte(135)), CInt(CByte(220)))
		barStyle1.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
		barStyle1.BarType = C1.Win.C1GanttView.BarType.AutoTask
		barStyle1.TopText1_ID = 287759160
		Me.c1GanttView1.BarStyles.Add(barStyle1)
		taskPropertyColumn1.Caption = "Task Mode"
		taskPropertyColumn1.ID = 1680832599
		taskPropertyColumn1.[Property] = C1.Win.C1GanttView.TaskProperty.Mode
		taskPropertyColumn1.Visible = False
		taskPropertyColumn1.Width = 61
		taskPropertyColumn2.Caption = "Task Name"
		taskPropertyColumn2.ID = 375059526
		taskPropertyColumn2.[Property] = C1.Win.C1GanttView.TaskProperty.Name
		taskPropertyColumn2.Width = 93
		customFieldColumn1.Caption = "Actual Cost"
		customFieldColumn1.DataType = GetType(Decimal)
		customFieldColumn1.Format = "$#0"
		customFieldColumn1.ID = 79583976
		customFieldColumn1.Name = "ActualCost"
		customFieldColumn1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		customFieldColumn1.Width = 65
		taskPropertyColumn3.Caption = "Duration"
		taskPropertyColumn3.ID = 1572034233
		taskPropertyColumn3.[Property] = C1.Win.C1GanttView.TaskProperty.Duration
		taskPropertyColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		taskPropertyColumn3.Width = 34
		taskPropertyColumn4.Caption = "Duration Units"
		taskPropertyColumn4.ID = 688893641
		taskPropertyColumn4.[Property] = C1.Win.C1GanttView.TaskProperty.DurationUnits
		taskPropertyColumn4.Width = 60
		taskPropertyColumn5.Caption = "Start"
		taskPropertyColumn5.ID = 1056085932
		taskPropertyColumn5.[Property] = C1.Win.C1GanttView.TaskProperty.Start
		taskPropertyColumn5.Visible = False
		taskPropertyColumn6.Caption = "Finish"
		taskPropertyColumn6.ID = 536482953
		taskPropertyColumn6.[Property] = C1.Win.C1GanttView.TaskProperty.Finish
		taskPropertyColumn6.Visible = False
		taskPropertyColumn7.Caption = "% Complete"
		taskPropertyColumn7.ID = 241887850
		taskPropertyColumn7.[Property] = C1.Win.C1GanttView.TaskProperty.PercentComplete
		taskPropertyColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		taskPropertyColumn7.Visible = False
		taskPropertyColumn8.Caption = "Constraint Type"
		taskPropertyColumn8.ID = 1492723839
		taskPropertyColumn8.[Property] = C1.Win.C1GanttView.TaskProperty.ConstraintType
		taskPropertyColumn8.Visible = False
		taskPropertyColumn9.Caption = "Constraint Date"
		taskPropertyColumn9.ID = 497084593
		taskPropertyColumn9.[Property] = C1.Win.C1GanttView.TaskProperty.ConstraintDate
		taskPropertyColumn9.Visible = False
		taskPropertyColumn10.Caption = "Predecessors"
		taskPropertyColumn10.ID = 1887751057
		taskPropertyColumn10.[Property] = C1.Win.C1GanttView.TaskProperty.Predecessors
		taskPropertyColumn10.Visible = False
		taskPropertyColumn11.Caption = "Deadline"
		taskPropertyColumn11.ID = 1454974103
		taskPropertyColumn11.[Property] = C1.Win.C1GanttView.TaskProperty.Deadline
		taskPropertyColumn11.Visible = False
		taskPropertyColumn12.Caption = "Calendar"
		taskPropertyColumn12.ID = 365231808
		taskPropertyColumn12.[Property] = C1.Win.C1GanttView.TaskProperty.Calendar
		taskPropertyColumn12.Visible = False
		taskPropertyColumn13.Caption = "Resource Names"
		taskPropertyColumn13.ID = 287759160
		taskPropertyColumn13.[Property] = C1.Win.C1GanttView.TaskProperty.ResourceNames
		taskPropertyColumn13.Visible = False
		taskPropertyColumn14.Caption = "Notes"
		taskPropertyColumn14.ID = 1372220778
		taskPropertyColumn14.[Property] = C1.Win.C1GanttView.TaskProperty.Notes
		taskPropertyColumn14.Visible = False
		Me.c1GanttView1.Columns.Add(taskPropertyColumn1)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn2)
		Me.c1GanttView1.Columns.Add(customFieldColumn1)
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
		Me.c1GanttView1.GridWidth = 286
		Me.c1GanttView1.Location = New System.Drawing.Point(0, 0)
		Me.c1GanttView1.Name = "c1GanttView1"
		resource1.Cost = New Decimal(New Integer() {20000, 0, 0, 131072})
		resource1.ID = 457479171
		resource1.Name = "Adam Miller"
		resource2.Cost = New Decimal(New Integer() {50000, 0, 0, 131072})
		resource2.ID = 574928631
		resource2.Name = "Ruth Radelet"
		resource3.Cost = New Decimal(New Integer() {25000, 0, 0, 131072})
		resource3.ID = 1258408175
		resource3.Name = "Johnny Jewel"
		resource4.Cost = New Decimal(New Integer() {40000, 0, 0, 131072})
		resource4.ID = 187715318
		resource4.Name = "Nat Walker"
		Me.c1GanttView1.Resources.Add(resource1)
		Me.c1GanttView1.Resources.Add(resource2)
		Me.c1GanttView1.Resources.Add(resource3)
		Me.c1GanttView1.Resources.Add(resource4)
		Me.c1GanttView1.Size = New System.Drawing.Size(912, 498)
		Me.c1GanttView1.StartDate = New System.DateTime(2012, 6, 22, 0, 0, 0, _
			0)
		Me.c1GanttView1.TabIndex = 0
		task1.ID = 1428331781
		task2.ConstraintDate = New System.DateTime(2012, 6, 22, 0, 0, 0, _
			0)
		task2.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
		task2.Duration = 1.0
		task2.DurationUnits = C1.Win.C1GanttView.DurationUnits.Months
		task2.ID = 656460240
		task2.Mode = C1.Win.C1GanttView.TaskMode.Automatic
		task2.Name = "Development"
		resourceRef1.Amount = 1.0
		resourceRef1.ResourceID = 457479171
		resourceRef2.ResourceID = 1258408175
		task2.ResourceRefs.Add(resourceRef1)
		task2.ResourceRefs.Add(resourceRef2)
		task3.ConstraintDate = New System.DateTime(2012, 6, 26, 0, 0, 0, _
			0)
		task3.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
		task3.Duration = 2.0
		task3.DurationUnits = C1.Win.C1GanttView.DurationUnits.Weeks
		task3.ID = 132267904
		task3.Mode = C1.Win.C1GanttView.TaskMode.Automatic
		task3.Name = "Pre-production"
		resourceRef3.Amount = 1.0
		resourceRef3.ResourceID = 187715318
		task3.ResourceRefs.Add(resourceRef3)
		task4.ID = 704109188
		task5.ConstraintDate = New System.DateTime(2012, 6, 28, 0, 0, 0, _
			0)
		task5.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
		task5.Duration = 1.0
		task5.DurationUnits = C1.Win.C1GanttView.DurationUnits.Weeks
		task5.ID = 1639616200
		task5.Mode = C1.Win.C1GanttView.TaskMode.Automatic
		task5.Name = "Production"
		resourceRef4.Amount = 1.0
		resourceRef4.ResourceID = 187715318
		resourceRef5.Amount = 1.0
		resourceRef5.ResourceID = 1258408175
		task5.ResourceRefs.Add(resourceRef4)
		task5.ResourceRefs.Add(resourceRef5)
		task6.ConstraintDate = New System.DateTime(2012, 6, 29, 0, 0, 0, _
			0)
		task6.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
		task6.Duration = 3.0
		task6.ID = 1784420689
		task6.Mode = C1.Win.C1GanttView.TaskMode.Automatic
		task6.Name = "Post-production"
		predecessor1.PredecessorTaskID = 1639616200
		task6.Predecessors.Add(predecessor1)
		resourceRef6.Amount = 1.0
		resourceRef6.ResourceID = 574928631
		task6.ResourceRefs.Add(resourceRef6)
		task7.ConstraintDate = New System.DateTime(2012, 6, 30, 0, 0, 0, _
			0)
		task7.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
		task7.Duration = 1.0
		task7.ID = 1296539678
		task7.Mode = C1.Win.C1GanttView.TaskMode.Automatic
		task7.Name = "Distribution"
		predecessor2.PredecessorTaskID = 1784420689
		task7.Predecessors.Add(predecessor2)
		resourceRef7.Amount = 1.0
		resourceRef7.ResourceID = 457479171
		task7.ResourceRefs.Add(resourceRef7)
		task8.DurationUnits = C1.Win.C1GanttView.DurationUnits.Hours
		task8.Finish = New System.DateTime(2012, 7, 11, 14, 0, 0, _
			0)
		task8.ID = 1444841716
		task8.Name = "Feedback"
		resourceRef8.Amount = 1.0
		resourceRef8.ResourceID = 574928631
		task8.ResourceRefs.Add(resourceRef8)
		task8.Start = New System.DateTime(2012, 7, 11, 0, 0, 0, _
			0)
		task9.ID = 1292198183
		task10.ID = 194872062
		task11.ID = 1084382609
		task12.ID = 185961251
		task13.ID = 393559994
		task14.ID = 92150478
		task15.ID = 20990948
		task16.ID = 1623847046
		task17.ID = 1884750761
		task18.ID = 1112867871
		task19.ID = 43920728
		task20.ID = 149186310
		task21.ID = 1021263795
		task22.ID = 242707790
		task23.ID = 1748838715
		task24.ID = 506851181
		task25.ID = 791484787
		task26.ID = 572119585
		task27.ID = 2026106759
		task28.ID = 39792468
		task29.ID = 86367301
		task30.ID = 1099725135
		task31.ID = 454310966
		task32.ID = 604586163
		task33.ID = 1249515592
		task34.ID = 1587165775
		task35.ID = 82220786
		task36.ID = 1611700704
		task37.ID = 833779805
		task38.ID = 77200479
		task39.ID = 1549556208
		task40.ID = 1589311134
		task41.ID = 825958818
		task42.ID = 235990884
		task43.ID = 1230344991
		task44.ID = 1377162172
		task45.ID = 1751994680
		task46.ID = 870124682
		task47.ID = 142922960
		task48.ID = 149737373
		task49.ID = 1471732892
		task50.ID = 1020721195
		task51.ID = 3000297
		task52.ID = 342106233
		task53.ID = 321311081
		task54.ID = 138572851
		task55.ID = 350956984
		task56.ID = 413752451
		task57.ID = 530912837
		task58.ID = 921480601
		task59.ID = 848131414
		task60.ID = 1212301105
		Me.c1GanttView1.Tasks.Add(task1)
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
		Me.c1GanttView1.Timescale.BottomTier.Align = C1.Win.C1GanttView.ScaleLabelAlignment.Center
		Me.c1GanttView1.Timescale.BottomTier.Format = "w"
		Me.c1GanttView1.Timescale.BottomTier.Visible = True
		Me.c1GanttView1.Timescale.MiddleTier.Format = "nnn d, \'yy"
		Me.c1GanttView1.Timescale.MiddleTier.MinWidth = 49
		Me.c1GanttView1.Timescale.MiddleTier.Units = C1.Win.C1GanttView.TimescaleUnits.Weeks
		Me.c1GanttView1.Timescale.MiddleTier.Visible = True
		AddHandler Me.c1GanttView1.SelectedIndexChanged, New System.EventHandler(AddressOf Me.c1GanttView1_SelectedIndexChanged)
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(912, 562)
		Me.Controls.Add(Me.btnZoomOut)
		Me.Controls.Add(Me.btnZoomIn)
		Me.Controls.Add(Me.btnZoomEntireProject)
		Me.Controls.Add(Me.btnZoomSelectedTask)
		Me.Controls.Add(Me.c1GanttView1)
		Me.Name = "Form1"
		Me.Text = "Zoom Sample"
		DirectCast(Me.c1GanttView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private c1GanttView1 As C1.Win.C1GanttView.C1GanttView
	Private btnZoomSelectedTask As System.Windows.Forms.Button
	Private btnZoomEntireProject As System.Windows.Forms.Button
	Private btnZoomIn As System.Windows.Forms.Button
	Private btnZoomOut As System.Windows.Forms.Button
End Class

