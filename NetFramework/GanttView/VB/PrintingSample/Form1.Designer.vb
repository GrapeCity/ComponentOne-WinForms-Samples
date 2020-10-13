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
        Dim Resource1 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource2 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource3 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource4 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource5 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource6 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource7 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource8 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Resource9 As C1.Win.C1GanttView.Resource = New C1.Win.C1GanttView.Resource()
        Dim Task1 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle1 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim ResourceRef1 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef2 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef3 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task2 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task3 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle2 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle3 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle4 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor1 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef4 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task4 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task5 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle5 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle6 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor2 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef5 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef6 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task6 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task7 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle7 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle8 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle9 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor3 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef7 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef8 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task8 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task9 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle10 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle11 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor4 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef9 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef10 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task10 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task11 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle12 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor5 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef11 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task12 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task13 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task14 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task15 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task16 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task17 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task18 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task19 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task20 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task21 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task22 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task23 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task24 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task25 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task26 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task27 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.ganttView = New C1.Win.C1GanttView.C1GanttView()
        CType(Me.ganttView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrint.Location = New System.Drawing.Point(316, 614)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(178, 29)
        Me.btnPrint.TabIndex = 1
        Me.btnPrint.Text = "Print From Custom Style"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnPreview
        '
        Me.btnPreview.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPreview.Location = New System.Drawing.Point(521, 614)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(170, 29)
        Me.btnPreview.TabIndex = 1
        Me.btnPreview.Text = "Preview From Custom Style"
        Me.btnPreview.UseVisualStyleBackColor = True
        '
        'ganttView
        '
        Me.ganttView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ganttView.BackColor = System.Drawing.SystemColors.Window
        CalendarException1.Name = "Vacation"
        CalendarException1.RecurrencePattern.DayOfMonth = 10
        CalendarException1.RecurrencePattern.MonthOfYear = 7
        CalendarException1.StartDate = New Date(2013, 6, 10, 0, 0, 0, 0)
        Me.ganttView.CalendarExceptions.Add(CalendarException1)
        TaskPropertyColumn1.Caption = "Task Mode"
        TaskPropertyColumn1.ID = 619243840
        TaskPropertyColumn1.Property = C1.Win.C1GanttView.TaskProperty.Mode
        TaskPropertyColumn1.Visible = False
        TaskPropertyColumn1.Width = 46
        TaskPropertyColumn2.Caption = "Task Name"
        TaskPropertyColumn2.ID = 2099866733
        TaskPropertyColumn2.Property = C1.Win.C1GanttView.TaskProperty.Name
        TaskPropertyColumn2.Width = 69
        TaskPropertyColumn3.Caption = "Duration"
        TaskPropertyColumn3.ID = 1358251825
        TaskPropertyColumn3.Property = C1.Win.C1GanttView.TaskProperty.Duration
        TaskPropertyColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        TaskPropertyColumn3.Width = 30
        TaskPropertyColumn4.Caption = "Duration Units"
        TaskPropertyColumn4.ID = 1827635185
        TaskPropertyColumn4.Property = C1.Win.C1GanttView.TaskProperty.DurationUnits
        TaskPropertyColumn4.Width = 51
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
        TaskPropertyColumn7.Visible = False
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
        Me.ganttView.DefaultWorkingTimes.Interval_1.Empty = False
        Me.ganttView.DefaultWorkingTimes.Interval_1.From = New Date(1, 1, 1, 8, 30, 0, 0)
        Me.ganttView.DefaultWorkingTimes.Interval_1.To = New Date(1, 1, 1, 12, 0, 0, 0)
        Me.ganttView.DefaultWorkingTimes.Interval_2.Empty = False
        Me.ganttView.DefaultWorkingTimes.Interval_2.From = New Date(1, 1, 1, 13, 30, 0, 0)
        Me.ganttView.DefaultWorkingTimes.Interval_2.To = New Date(1, 1, 1, 18, 0, 0, 0)
        Me.ganttView.EnablePrinting = True
        Me.ganttView.FirstMonthOfFY = C1.Win.C1GanttView.FirstMonthOfFY.March
        Me.ganttView.GridWidth = 188
        Me.ganttView.Location = New System.Drawing.Point(0, 0)
        Me.ganttView.Name = "ganttView"
        Me.ganttView.NonworkingTimeColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(184, Byte), Integer))
        Me.ganttView.PrintInfo.EndDate = New Date(CType(0, Long))
        Me.ganttView.PrintInfo.LegendTextAreaWidth = 2.0!
        Me.ganttView.PrintInfo.PrintType = C1.Win.C1GanttView.Printing.PrintType.General
        Me.ganttView.PrintInfo.StartDate = New Date(CType(0, Long))
        Me.ganttView.PrintInfo.StyleSource = "General.c1d"
        Me.ganttView.ProgressLine.StatusDate = New Date(2013, 6, 19, 0, 0, 0, 0)
        Me.ganttView.ProgressLine.Visible = True
        Resource1.Cost = New Decimal(New Integer() {100, 0, 0, 0})
        Resource1.ID = 1640417825
        Resource1.Name = "Rita Been"
        Resource1.Notes = "Tester"
        Resource2.Cost = New Decimal(New Integer() {250, 0, 0, 0})
        Resource2.ID = 239555279
        Resource2.Name = "Eric Smith"
        Resource2.Notes = "Project Manager"
        Resource3.Cost = New Decimal(New Integer() {150, 0, 0, 0})
        Resource3.ID = 766290656
        Resource3.Name = "Daniel Hank"
        Resource3.Notes = "Analyst"
        Resource4.Cost = New Decimal(New Integer() {300, 0, 0, 0})
        Resource4.ID = 2011144056
        Resource4.Name = "Juan Carlos"
        Resource4.Notes = "Developer"
        Resource5.Cost = New Decimal(New Integer() {100, 0, 0, 0})
        Resource5.ID = 448108000
        Resource5.Name = "Mike Jones "
        Resource5.Notes = "Developer"
        Resource6.Cost = New Decimal(New Integer() {400, 0, 0, 0})
        Resource6.ID = 1869891731
        Resource6.Name = "Chris Lee"
        Resource6.Notes = "Developer"
        Resource7.Cost = New Decimal(New Integer() {250, 0, 0, 0})
        Resource7.ID = 556319480
        Resource7.Name = "Sarah Robert"
        Resource7.Notes = "Tester"
        Resource8.Cost = New Decimal(New Integer() {200, 0, 0, 0})
        Resource8.ID = 1334638351
        Resource8.Name = "Micheal Owen"
        Resource8.Notes = "Documentation Maker"
        Resource9.Cost = New Decimal(New Integer() {150, 0, 0, 0})
        Resource9.ID = 2101511829
        Resource9.Name = "Juliet Paul"
        Resource9.Notes = "Documentation Maker"
        Me.ganttView.Resources.Add(Resource1)
        Me.ganttView.Resources.Add(Resource2)
        Me.ganttView.Resources.Add(Resource3)
        Me.ganttView.Resources.Add(Resource4)
        Me.ganttView.Resources.Add(Resource5)
        Me.ganttView.Resources.Add(Resource6)
        Me.ganttView.Resources.Add(Resource7)
        Me.ganttView.Resources.Add(Resource8)
        Me.ganttView.Resources.Add(Resource9)
        Me.ganttView.Size = New System.Drawing.Size(1064, 607)
        Me.ganttView.StartDate = New Date(2013, 6, 5, 0, 0, 0, 0)
        Me.ganttView.TabIndex = 0
        BarStyle1.BarColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(209, Byte), Integer))
        BarStyle1.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle1.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle1.EndShape = 22
        BarStyle1.RightText1_ID = -13
        BarStyle1.StartShape = 21
        BarStyle1.TopText1_ID = 2099866733
        Task1.BarStyles.Add(BarStyle1)
        Task1.Finish = New Date(2013, 6, 7, 0, 0, 0, 0)
        Task1.ID = 362538391
        Task1.Name = "Planning"
        Task1.PercentComplete = 1.0R
        ResourceRef1.Amount = 1.0R
        ResourceRef1.ResourceID = 766290656
        ResourceRef2.Amount = 1.0R
        ResourceRef2.ResourceID = 1334638351
        ResourceRef3.Amount = 1.0R
        ResourceRef3.ResourceID = 239555279
        Task1.ResourceRefs.Add(ResourceRef1)
        Task1.ResourceRefs.Add(ResourceRef2)
        Task1.ResourceRefs.Add(ResourceRef3)
        Task1.Start = New Date(2013, 6, 5, 0, 0, 0, 0)
        Task2.ID = 110002178
        BarStyle2.BarColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(209, Byte), Integer))
        BarStyle2.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle2.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle2.EndShape = 22
        BarStyle2.RightText1_ID = -13
        BarStyle2.StartShape = 21
        BarStyle2.TopText1_ID = 2099866733
        BarStyle3.BarColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(220, Byte), Integer))
        BarStyle3.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle3.BarType = C1.Win.C1GanttView.BarType.AutoTask
        BarStyle3.RightText1_ID = -13
        BarStyle3.TopText1_ID = 2099866733
        BarStyle4.BarType = C1.Win.C1GanttView.BarType.Deadline
        BarStyle4.StartColor = System.Drawing.Color.Green
        BarStyle4.StartShape = 12
        BarStyle4.TopText1_ID = 166462627
        Task3.BarStyles.Add(BarStyle2)
        Task3.BarStyles.Add(BarStyle3)
        Task3.BarStyles.Add(BarStyle4)
        Task3.ConstraintDate = New Date(2013, 6, 7, 0, 0, 0, 0)
        Task3.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
        Task3.Deadline = New Date(2013, 6, 15, 0, 0, 0, 0)
        Task3.Duration = 3.0R
        Task3.ID = 1179983348
        Task3.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task3.Name = "Analysis"
        Task3.PercentComplete = 1.0R
        Predecessor1.PredecessorTaskID = 362538391
        Task3.Predecessors.Add(Predecessor1)
        ResourceRef4.Amount = 1.0R
        ResourceRef4.ResourceID = 2011144056
        Task3.ResourceRefs.Add(ResourceRef4)
        Task4.ID = 1427410353
        BarStyle5.BarColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(209, Byte), Integer))
        BarStyle5.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle5.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle5.EndShape = 22
        BarStyle5.RightText1_ID = -13
        BarStyle5.StartShape = 21
        BarStyle5.TopText1_ID = 2099866733
        BarStyle6.BarColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        BarStyle6.BarShape = C1.Win.C1GanttView.BarShape.MiddleBar
        BarStyle6.BarType = C1.Win.C1GanttView.BarType.Progress
        BarStyle6.BottomText1_ID = 705116663
        Task5.BarStyles.Add(BarStyle5)
        Task5.BarStyles.Add(BarStyle6)
        Task5.Finish = New Date(2013, 6, 15, 0, 0, 0, 0)
        Task5.ID = 2098269195
        Task5.Name = "Design"
        Task5.PercentComplete = 0.5R
        Predecessor2.PredecessorTaskID = 1179983348
        Task5.Predecessors.Add(Predecessor2)
        ResourceRef5.Amount = 1.0R
        ResourceRef5.ResourceID = 2101511829
        ResourceRef6.Amount = 1.0R
        ResourceRef6.ResourceID = 1869891731
        Task5.ResourceRefs.Add(ResourceRef5)
        Task5.ResourceRefs.Add(ResourceRef6)
        Task5.Start = New Date(2013, 6, 13, 8, 30, 0, 0)
        Task6.ID = 1753282054
        BarStyle7.BarColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(209, Byte), Integer))
        BarStyle7.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle7.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle7.EndShape = 22
        BarStyle7.RightText1_ID = -13
        BarStyle7.StartShape = 21
        BarStyle7.TopText1_ID = 2099866733
        BarStyle8.BarColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(220, Byte), Integer))
        BarStyle8.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle8.BarType = C1.Win.C1GanttView.BarType.AutoTask
        BarStyle8.LeftText1_ID = 1673084976
        BarStyle8.TopText1_ID = 2099866733
        BarStyle9.BarColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        BarStyle9.BarShape = C1.Win.C1GanttView.BarShape.MiddleBar
        BarStyle9.BarType = C1.Win.C1GanttView.BarType.Progress
        BarStyle9.BottomText1_ID = 705116663
        Task7.BarStyles.Add(BarStyle7)
        Task7.BarStyles.Add(BarStyle8)
        Task7.BarStyles.Add(BarStyle9)
        Task7.ConstraintDate = New Date(2013, 6, 17, 0, 0, 0, 0)
        Task7.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
        Task7.Duration = 4.0R
        Task7.ID = 792666599
        Task7.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task7.Name = "Implementation"
        Task7.PercentComplete = 0.25R
        Predecessor3.PredecessorTaskID = 2098269195
        Task7.Predecessors.Add(Predecessor3)
        ResourceRef7.Amount = 1.0R
        ResourceRef7.ResourceID = 1334638351
        ResourceRef8.Amount = 1.0R
        ResourceRef8.ResourceID = 766290656
        Task7.ResourceRefs.Add(ResourceRef7)
        Task7.ResourceRefs.Add(ResourceRef8)
        Task8.ID = 1853855961
        BarStyle10.BarColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(209, Byte), Integer))
        BarStyle10.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle10.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle10.EndShape = 22
        BarStyle10.LeftText1_ID = 1673084976
        BarStyle10.StartShape = 21
        BarStyle10.TopText1_ID = 2099866733
        BarStyle11.BarType = C1.Win.C1GanttView.BarType.Deadline
        BarStyle11.BottomText1_ID = 166462627
        BarStyle11.StartColor = System.Drawing.Color.Green
        BarStyle11.StartShape = 12
        Task9.BarStyles.Add(BarStyle10)
        Task9.BarStyles.Add(BarStyle11)
        Task9.Deadline = New Date(2013, 6, 26, 0, 0, 0, 0)
        Task9.Finish = New Date(2013, 6, 24, 18, 0, 0, 0)
        Task9.ID = 2121238572
        Task9.Name = "Documentation"
        Predecessor4.PredecessorTaskID = 792666599
        Task9.Predecessors.Add(Predecessor4)
        ResourceRef9.Amount = 1.0R
        ResourceRef9.ResourceID = 1640417825
        ResourceRef10.Amount = 1.0R
        ResourceRef10.ResourceID = 556319480
        Task9.ResourceRefs.Add(ResourceRef9)
        Task9.ResourceRefs.Add(ResourceRef10)
        Task9.Start = New Date(2013, 6, 21, 8, 30, 0, 0)
        Task10.ID = 1728214611
        BarStyle12.BarColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(209, Byte), Integer))
        BarStyle12.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle12.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle12.EndShape = 22
        BarStyle12.LeftText1_ID = 1673084976
        BarStyle12.StartShape = 21
        BarStyle12.TopText1_ID = 2099866733
        Task11.BarStyles.Add(BarStyle12)
        Task11.Finish = New Date(2013, 6, 27, 0, 0, 0, 0)
        Task11.ID = 312019882
        Task11.Name = "Support"
        Predecessor5.PredecessorTaskID = 2121238572
        Task11.Predecessors.Add(Predecessor5)
        ResourceRef11.Amount = 1.0R
        ResourceRef11.ResourceID = 2011144056
        Task11.ResourceRefs.Add(ResourceRef11)
        Task11.Start = New Date(2013, 6, 25, 0, 0, 0, 0)
        Task12.ID = 2131650479
        Task13.ID = 1600264846
        Task14.ID = 185936048
        Task15.ID = 1447717244
        Task16.ID = 1352797036
        Task17.ID = 1301076315
        Task18.ID = 562163695
        Task19.ID = 19552401
        Task20.ID = 1597983629
        Task21.ID = 591786279
        Task22.ID = 816445275
        Task23.ID = 514161404
        Task24.ID = 992389273
        Task25.ID = 246882487
        Task26.ID = 1546671531
        Task27.ID = 2076126586
        Me.ganttView.Tasks.Add(Task1)
        Me.ganttView.Tasks.Add(Task2)
        Me.ganttView.Tasks.Add(Task3)
        Me.ganttView.Tasks.Add(Task4)
        Me.ganttView.Tasks.Add(Task5)
        Me.ganttView.Tasks.Add(Task6)
        Me.ganttView.Tasks.Add(Task7)
        Me.ganttView.Tasks.Add(Task8)
        Me.ganttView.Tasks.Add(Task9)
        Me.ganttView.Tasks.Add(Task10)
        Me.ganttView.Tasks.Add(Task11)
        Me.ganttView.Tasks.Add(Task12)
        Me.ganttView.Tasks.Add(Task13)
        Me.ganttView.Tasks.Add(Task14)
        Me.ganttView.Tasks.Add(Task15)
        Me.ganttView.Tasks.Add(Task16)
        Me.ganttView.Tasks.Add(Task17)
        Me.ganttView.Tasks.Add(Task18)
        Me.ganttView.Tasks.Add(Task19)
        Me.ganttView.Tasks.Add(Task20)
        Me.ganttView.Tasks.Add(Task21)
        Me.ganttView.Tasks.Add(Task22)
        Me.ganttView.Tasks.Add(Task23)
        Me.ganttView.Tasks.Add(Task24)
        Me.ganttView.Tasks.Add(Task25)
        Me.ganttView.Tasks.Add(Task26)
        Me.ganttView.Tasks.Add(Task27)
        Me.ganttView.Timescale.BottomTier.Align = C1.Win.C1GanttView.ScaleLabelAlignment.Center
        Me.ganttView.Timescale.BottomTier.Format = "w"
        Me.ganttView.Timescale.BottomTier.Visible = True
        Me.ganttView.Timescale.MiddleTier.Format = "nnn d, \'yy"
        Me.ganttView.Timescale.MiddleTier.MinWidth = 62
        Me.ganttView.Timescale.MiddleTier.Units = C1.Win.C1GanttView.TimescaleUnits.Weeks
        Me.ganttView.Timescale.MiddleTier.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 648)
        Me.Controls.Add(Me.btnPreview)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.ganttView)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ganttView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

	#End Region

	Private ganttView As C1.Win.C1GanttView.C1GanttView
    Private WithEvents btnPrint As System.Windows.Forms.Button
    Private WithEvents btnPreview As System.Windows.Forms.Button
End Class

