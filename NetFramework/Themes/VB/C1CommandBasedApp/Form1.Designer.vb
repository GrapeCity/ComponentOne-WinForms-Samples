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
		Me.components = New System.ComponentModel.Container()
		Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Dim c1TopicPage3 As New C1.Win.Command.C1TopicPage()
		Dim c1TopicLink10 As New C1.Win.Command.C1TopicLink()
		Dim c1TopicLink11 As New C1.Win.Command.C1TopicLink()
		Dim c1TopicLink12 As New C1.Win.Command.C1TopicLink()
		Dim c1TopicLink13 As New C1.Win.Command.C1TopicLink()
		Dim c1TopicLink14 As New C1.Win.Command.C1TopicLink()
		Dim c1TopicLink15 As New C1.Win.Command.C1TopicLink()
		Dim c1TopicPage4 As New C1.Win.Command.C1TopicPage()
		Dim c1TopicLink16 As New C1.Win.Command.C1TopicLink()
		Dim c1TopicLink17 As New C1.Win.Command.C1TopicLink()
		Dim c1TopicLink18 As New C1.Win.Command.C1TopicLink()
		Dim printStyle6 As New C1.Schedule.Printing.PrintStyle()
		Dim printStyle7 As New C1.Schedule.Printing.PrintStyle()
		Dim printStyle8 As New C1.Schedule.Printing.PrintStyle()
		Dim printStyle9 As New C1.Schedule.Printing.PrintStyle()
		Dim printStyle10 As New C1.Schedule.Printing.PrintStyle()
		Dim calendarException16 As New C1.Win.GanttView.CalendarException()
		Dim taskPropertyColumn211 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn212 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn213 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn214 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn215 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn216 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn217 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn218 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn219 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn220 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn221 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn222 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn223 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim taskPropertyColumn224 As New C1.Win.GanttView.TaskPropertyColumn()
		Dim resource136 As New C1.Win.GanttView.Resource()
		Dim resource137 As New C1.Win.GanttView.Resource()
		Dim resource138 As New C1.Win.GanttView.Resource()
		Dim resource139 As New C1.Win.GanttView.Resource()
		Dim resource140 As New C1.Win.GanttView.Resource()
		Dim resource141 As New C1.Win.GanttView.Resource()
		Dim resource142 As New C1.Win.GanttView.Resource()
		Dim resource143 As New C1.Win.GanttView.Resource()
		Dim resource144 As New C1.Win.GanttView.Resource()
		Dim task406 As New C1.Win.GanttView.Task()
		Dim resourceRef166 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef167 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef168 As New C1.Win.GanttView.ResourceRef()
		Dim task407 As New C1.Win.GanttView.Task()
		Dim task408 As New C1.Win.GanttView.Task()
		Dim barStyle31 As New C1.Win.GanttView.BarStyle()
		Dim predecessor76 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef169 As New C1.Win.GanttView.ResourceRef()
		Dim task409 As New C1.Win.GanttView.Task()
		Dim task410 As New C1.Win.GanttView.Task()
		Dim predecessor77 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef170 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef171 As New C1.Win.GanttView.ResourceRef()
		Dim task411 As New C1.Win.GanttView.Task()
		Dim task412 As New C1.Win.GanttView.Task()
		Dim predecessor78 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef172 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef173 As New C1.Win.GanttView.ResourceRef()
		Dim task413 As New C1.Win.GanttView.Task()
		Dim task414 As New C1.Win.GanttView.Task()
		Dim barStyle32 As New C1.Win.GanttView.BarStyle()
		Dim predecessor79 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef174 As New C1.Win.GanttView.ResourceRef()
		Dim resourceRef175 As New C1.Win.GanttView.ResourceRef()
		Dim task415 As New C1.Win.GanttView.Task()
		Dim task416 As New C1.Win.GanttView.Task()
		Dim predecessor80 As New C1.Win.GanttView.Predecessor()
		Dim resourceRef176 As New C1.Win.GanttView.ResourceRef()
		Dim task417 As New C1.Win.GanttView.Task()
		Dim task418 As New C1.Win.GanttView.Task()
		Dim task419 As New C1.Win.GanttView.Task()
		Dim task420 As New C1.Win.GanttView.Task()
		Dim task421 As New C1.Win.GanttView.Task()
		Dim task422 As New C1.Win.GanttView.Task()
		Dim task423 As New C1.Win.GanttView.Task()
		Dim task424 As New C1.Win.GanttView.Task()
		Dim task425 As New C1.Win.GanttView.Task()
		Dim task426 As New C1.Win.GanttView.Task()
		Dim task427 As New C1.Win.GanttView.Task()
		Dim task428 As New C1.Win.GanttView.Task()
		Dim task429 As New C1.Win.GanttView.Task()
		Dim task430 As New C1.Win.GanttView.Task()
		Dim task431 As New C1.Win.GanttView.Task()
		Dim task432 As New C1.Win.GanttView.Task()
		Me.ilMain2 = New System.Windows.Forms.ImageList(Me.components)
		Me.ilSmall = New System.Windows.Forms.ImageList(Me.components)
		Me.cchMain = New C1.Win.Command.C1CommandHolder()
		Me.ccmFile = New C1.Win.Command.C1CommandMenu()
		Me.c1CommandLink2 = New C1.Win.Command.C1CommandLink()
		Me.ccmFileNew = New C1.Win.Command.C1CommandMenu()
		Me.c1CommandLink5 = New C1.Win.Command.C1CommandLink()
		Me.ccFileNewWizard = New C1.Win.Command.C1Command()
		Me.c1CommandLink3 = New C1.Win.Command.C1CommandLink()
		Me.ccFileNewEmpty = New C1.Win.Command.C1Command()
		Me.c1CommandLink4 = New C1.Win.Command.C1CommandLink()
		Me.ccFileOpen = New C1.Win.Command.C1Command()
		Me.c1CommandLink6 = New C1.Win.Command.C1CommandLink()
		Me.ccFileSave = New C1.Win.Command.C1Command()
		Me.c1CommandLink7 = New C1.Win.Command.C1CommandLink()
		Me.ccFileSaveAs = New C1.Win.Command.C1Command()
		Me.c1CommandLink9 = New C1.Win.Command.C1CommandLink()
		Me.ccFilePrint = New C1.Win.Command.C1Command()
		Me.c1CommandLink8 = New C1.Win.Command.C1CommandLink()
		Me.ccFileClose = New C1.Win.Command.C1Command()
		Me.c1CommandLink10 = New C1.Win.Command.C1CommandLink()
		Me.ccFileExit = New C1.Win.Command.C1Command()
		Me.ccmEdit = New C1.Win.Command.C1CommandMenu()
		Me.c1CommandLink11 = New C1.Win.Command.C1CommandLink()
		Me.ccUndo = New C1.Win.Command.C1Command()
		Me.c1CommandLink13 = New C1.Win.Command.C1CommandLink()
		Me.ccRedo = New C1.Win.Command.C1Command()
		Me.c1CommandLink14 = New C1.Win.Command.C1CommandLink()
		Me.ccCut = New C1.Win.Command.C1Command()
		Me.c1CommandLink15 = New C1.Win.Command.C1CommandLink()
		Me.ccCopy = New C1.Win.Command.C1Command()
		Me.c1CommandLink16 = New C1.Win.Command.C1CommandLink()
		Me.ccPaste = New C1.Win.Command.C1Command()
		Me.c1CommandLink17 = New C1.Win.Command.C1CommandLink()
		Me.ccDelete = New C1.Win.Command.C1Command()
		Me.c1CommandLink18 = New C1.Win.Command.C1CommandLink()
		Me.ccFind = New C1.Win.Command.C1Command()
		Me.c1CommandLink19 = New C1.Win.Command.C1CommandLink()
		Me.ccGoTo = New C1.Win.Command.C1Command()
		Me.ccmFormat = New C1.Win.Command.C1CommandMenu()
		Me.c1CommandLink20 = New C1.Win.Command.C1CommandLink()
		Me.ccFormatFont = New C1.Win.Command.C1Command()
		Me.c1CommandLink23 = New C1.Win.Command.C1CommandLink()
		Me.ccmFormatFontColor = New C1.Win.Command.C1CommandMenu()
		Me.c1CommandLink21 = New C1.Win.Command.C1CommandLink()
		Me.ccFormatFontBold = New C1.Win.Command.C1Command()
		Me.ccFormatFontItalic = New C1.Win.Command.C1Command()
		Me.ccFormatFontUnderline = New C1.Win.Command.C1Command()
		Me.ccFormatFontStrikeout = New C1.Win.Command.C1Command()
		Me.ccFormatAlignLeft = New C1.Win.Command.C1Command()
		Me.ccFormatAlignCenter = New C1.Win.Command.C1Command()
		Me.ccFormatAlignRight = New C1.Win.Command.C1Command()
		Me.ccFormatAlignJustify = New C1.Win.Command.C1Command()
		Me.ccmC1TrueDBGrid = New C1.Win.Command.C1CommandMenu()
		Me.c1CommandLink24 = New C1.Win.Command.C1CommandLink()
		Me.ccCTDBGViewNormal = New C1.Win.Command.C1Command()
		Me.c1CommandLink26 = New C1.Win.Command.C1CommandLink()
		Me.ccCTDBGViewInverted = New C1.Win.Command.C1Command()
		Me.c1CommandLink27 = New C1.Win.Command.C1CommandLink()
		Me.ccCTDBGViewForm = New C1.Win.Command.C1Command()
		Me.c1CommandLink28 = New C1.Win.Command.C1CommandLink()
		Me.ccCTDBGViewGroupBy = New C1.Win.Command.C1Command()
		Me.c1CommandLink29 = New C1.Win.Command.C1CommandLink()
		Me.ccCTDBGViewMultipleLines = New C1.Win.Command.C1Command()
		Me.c1CommandLink30 = New C1.Win.Command.C1CommandLink()
		Me.ccCTDBGViewHierarchical = New C1.Win.Command.C1Command()
		Me.c1CommandLink31 = New C1.Win.Command.C1CommandLink()
		Me.ccCTDBGShowCaption = New C1.Win.Command.C1Command()
		Me.ccmC1FlexGrid = New C1.Win.Command.C1CommandMenu()
		Me.c1CommandLink32 = New C1.Win.Command.C1CommandLink()
		Me.ccCFGViewNormal = New C1.Win.Command.C1Command()
		Me.c1CommandLink36 = New C1.Win.Command.C1CommandLink()
		Me.ccCFGViewTree = New C1.Win.Command.C1Command()
		Me.c1CommandLink37 = New C1.Win.Command.C1CommandLink()
		Me.ccCFGViewSubtotals = New C1.Win.Command.C1Command()
		Me.c1CommandLink38 = New C1.Win.Command.C1CommandLink()
		Me.ccCFGFixedColCount = New C1.Win.Command.C1CommandControl()
		Me.cneCFGFrozenColCount = New C1.Win.C1Input.C1NumericEdit()
		Me.c1CommandLink39 = New C1.Win.Command.C1CommandLink()
		Me.ccCFGFixedRowCount = New C1.Win.Command.C1CommandControl()
		Me.cneCFGFrozenRowCount = New C1.Win.C1Input.C1NumericEdit()
		Me.c1CommandLink40 = New C1.Win.Command.C1CommandLink()
		Me.ccmCFGSelectionMode = New C1.Win.Command.C1CommandMenu()
		Me.c1CommandLink33 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink41 = New C1.Win.Command.C1CommandLink()
		Me.ccmCFGFocusRect = New C1.Win.Command.C1CommandMenu()
		Me.c1CommandLink34 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink42 = New C1.Win.Command.C1CommandLink()
		Me.ccCFGShowCursor = New C1.Win.Command.C1Command()
		Me.ccmC1Schedule = New C1.Win.Command.C1CommandMenu()
		Me.c1CommandLink43 = New C1.Win.Command.C1CommandLink()
		Me.ccCSViewDay = New C1.Win.Command.C1Command()
		Me.c1CommandLink45 = New C1.Win.Command.C1CommandLink()
		Me.ccCSViewWorkWeek = New C1.Win.Command.C1Command()
		Me.c1CommandLink46 = New C1.Win.Command.C1CommandLink()
		Me.ccCSViewWeek = New C1.Win.Command.C1Command()
		Me.c1CommandLink47 = New C1.Win.Command.C1CommandLink()
		Me.ccCSViewMonth = New C1.Win.Command.C1Command()
		Me.c1CommandLink48 = New C1.Win.Command.C1CommandLink()
		Me.ccCSViewTimeLine = New C1.Win.Command.C1Command()
		Me.c1CommandLink49 = New C1.Win.Command.C1CommandLink()
		Me.ccCSEnableGrouping = New C1.Win.Command.C1Command()
		Me.c1CommandLink50 = New C1.Win.Command.C1CommandLink()
		Me.ccCSOffice2003WeekView = New C1.Win.Command.C1Command()
		Me.cccFormatFontName = New C1.Win.Command.C1CommandControl()
		Me.cddcFontName = New C1.Win.C1Input.C1DropDownControl()
		Me.cccFormatFontSize = New C1.Win.Command.C1CommandControl()
		Me.cddcFontSize = New C1.Win.C1Input.C1DropDownControl()
		Me.ccmFormatBorders = New C1.Win.Command.C1CommandMenu()
		Me.c1CommandLink73 = New C1.Win.Command.C1CommandLink()
		Me.ccFormatBorderBottom = New C1.Win.Command.C1Command()
		Me.c1CommandLink71 = New C1.Win.Command.C1CommandLink()
		Me.ccFormatBorderTop = New C1.Win.Command.C1Command()
		Me.c1CommandLink74 = New C1.Win.Command.C1CommandLink()
		Me.ccFormatBorderLeft = New C1.Win.Command.C1Command()
		Me.c1CommandLink75 = New C1.Win.Command.C1CommandLink()
		Me.ccFormatBorderRight = New C1.Win.Command.C1Command()
		Me.ccStatesNormal = New C1.Win.Command.C1Command()
		Me.ccStatesDisabled = New C1.Win.Command.C1Command()
		Me.ccStatesPressed = New C1.Win.Command.C1Command()
		Me.ccStatesChecked = New C1.Win.Command.C1Command()
		Me.ccmTheme = New C1.Win.Command.C1CommandMenu()
		Me.cmmMain = New C1.Win.Command.C1MainMenu()
		Me.c1CommandLink1 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink12 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink22 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink25 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink35 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink44 = New C1.Win.Command.C1CommandLink()
		Me.ccdTop = New C1.Win.Command.C1CommandDock()
		Me.ctbStates = New C1.Win.Command.C1ToolBar()
		Me.c1CommandLink76 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink77 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink78 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink79 = New C1.Win.Command.C1CommandLink()
		Me.ctbFormat = New C1.Win.Command.C1ToolBar()
		Me.c1CommandLink69 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink70 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink61 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink62 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink63 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink64 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink65 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink66 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink67 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink68 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink72 = New C1.Win.Command.C1CommandLink()
		Me.ctbEdit = New C1.Win.Command.C1ToolBar()
		Me.c1CommandLink55 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink56 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink57 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink58 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink59 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink60 = New C1.Win.Command.C1CommandLink()
		Me.ctbFile = New C1.Win.Command.C1ToolBar()
		Me.c1CommandLink80 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink51 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink52 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink53 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink54 = New C1.Win.Command.C1CommandLink()
		Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
		Me.c1NavBar1 = New C1.Win.Command.C1NavBar()
		Me.c1NavBarPanel5 = New C1.Win.Command.C1NavBarPanel()
		Me.ctbMain = New C1.Win.Command.C1TopicBar()
		Me.c1NavBarPanel2 = New C1.Win.Command.C1NavBarPanel()
		Me.c1Calendar1 = New C1.Win.Schedule.C1Calendar()
		Me.c1NavBarPanel3 = New C1.Win.Command.C1NavBarPanel()
		Me.label1 = New System.Windows.Forms.Label()
		Me.c1NavBarPanel4 = New C1.Win.Command.C1NavBarPanel()
		Me.label2 = New System.Windows.Forms.Label()
		Me.c1CommandDock1 = New C1.Win.Command.C1CommandDock()
		Me.c1DockingTab1 = New C1.Win.Command.C1DockingTab()
		Me.c1DockingTabPage1 = New C1.Win.Command.C1DockingTabPage()
		Me.c1OutBar1 = New C1.Win.Command.C1OutBar()
		Me.copC1FlexGrid = New C1.Win.Command.C1OutPage()
		Me.ctbC1FlexGrid = New C1.Win.Command.C1ToolBar()
		Me.c1CommandLink81 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink82 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink83 = New C1.Win.Command.C1CommandLink()
        Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.c1Label4 = New C1.Win.C1Input.C1Label()
		Me.c1Label3 = New C1.Win.C1Input.C1Label()
		Me.csbFocusRect = New C1.Win.C1Input.C1SplitButton()
		Me.csbSelectionMode = New C1.Win.C1Input.C1SplitButton()
		Me.ccbShowCursor = New C1.Win.C1Input.C1CheckBox()
		Me.c1Label2 = New C1.Win.C1Input.C1Label()
		Me.cneFixedRowCount = New C1.Win.C1Input.C1NumericEdit()
		Me.cneFixedColCount = New C1.Win.C1Input.C1NumericEdit()
		Me.c1Label1 = New C1.Win.C1Input.C1Label()
		Me.copC1TrueDBGrid = New C1.Win.Command.C1OutPage()
		Me.ctbC1TrueDBGridView = New C1.Win.Command.C1ToolBar()
		Me.c1CommandLink84 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink85 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink86 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink87 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink88 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink89 = New C1.Win.Command.C1CommandLink()
		Me.panel2 = New System.Windows.Forms.Panel()
		Me.ccbCTDBGShowFilterBar = New C1.Win.C1Input.C1CheckBox()
		Me.ccbCTDBGShowCaption = New C1.Win.C1Input.C1CheckBox()
		Me.copC1Schedule = New C1.Win.Command.C1OutPage()
		Me.ctbC1ScheduleView = New C1.Win.Command.C1ToolBar()
		Me.c1CommandLink90 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink91 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink92 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink93 = New C1.Win.Command.C1CommandLink()
		Me.c1CommandLink94 = New C1.Win.Command.C1CommandLink()
		Me.panel3 = New System.Windows.Forms.Panel()
		Me.ccbCSOffice2003WeekView = New C1.Win.C1Input.C1CheckBox()
		Me.ccbCSEnableGrouping = New C1.Win.C1Input.C1CheckBox()
		Me.c1DockingTabPage2 = New C1.Win.Command.C1DockingTabPage()
		Me.c1DockingTab2 = New C1.Win.Command.C1DockingTab()
		Me.c1DockingTabPage3 = New C1.Win.Command.C1DockingTabPage()
		Me.c1FlexGrid1 = New C1.Win.FlexGrid.C1FlexGrid()
		Me.c1DockingTabPage4 = New C1.Win.Command.C1DockingTabPage()
		Me.c1TrueDBGrid1 = New C1.Win.TrueDBGrid.C1TrueDBGrid()
		Me.c1DockingTabPage5 = New C1.Win.Command.C1DockingTabPage()
		Me.csMain = New C1.Win.Schedule.C1Schedule()
		Me.c1DockingTabPage6 = New C1.Win.Command.C1DockingTabPage()
		Me.c1GanttView1 = New C1.Win.GanttView.C1GanttView()
		Me.c1NWINDDataSet = New C1CommandBasedApp.C1NWINDDataSet()
		Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.employeesTableAdapter = New C1CommandBasedApp.C1NWINDDataSetTableAdapters.EmployeesTableAdapter()
		Me.c1ThemeController1 = New C1.Win.Themes.C1ThemeController()
		DirectCast(Me.cchMain, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.cneCFGFrozenColCount, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.cneCFGFrozenRowCount, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.cddcFontName, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.cddcFontSize, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.ccdTop, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ccdTop.SuspendLayout()
		Me.ctbFormat.SuspendLayout()
		DirectCast(Me.c1NavBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.c1NavBar1.SuspendLayout()
		Me.c1NavBarPanel5.SuspendLayout()
		DirectCast(Me.ctbMain, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.c1NavBarPanel2.SuspendLayout()
		DirectCast(Me.c1Calendar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.c1NavBarPanel3.SuspendLayout()
		Me.c1NavBarPanel4.SuspendLayout()
		DirectCast(Me.c1CommandDock1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.c1CommandDock1.SuspendLayout()
		DirectCast(Me.c1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.c1DockingTab1.SuspendLayout()
		Me.c1DockingTabPage1.SuspendLayout()
		DirectCast(Me.c1OutBar1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.c1OutBar1.SuspendLayout()
		Me.copC1FlexGrid.SuspendLayout()
        Me.tableLayoutPanel1.SuspendLayout()
        DirectCast(Me.c1Label4, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.c1Label3, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.c1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.cneFixedRowCount, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.cneFixedColCount, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.c1Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.copC1TrueDBGrid.SuspendLayout()
		Me.panel2.SuspendLayout()
		Me.copC1Schedule.SuspendLayout()
		Me.panel3.SuspendLayout()
		DirectCast(Me.c1DockingTab2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.c1DockingTab2.SuspendLayout()
		Me.c1DockingTabPage3.SuspendLayout()
		DirectCast(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.c1DockingTabPage4.SuspendLayout()
		DirectCast(Me.c1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.c1DockingTabPage5.SuspendLayout()
		DirectCast(Me.csMain, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.csMain.DataStorage.AppointmentStorage, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.csMain.DataStorage.CategoryStorage, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.csMain.DataStorage.ContactStorage, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.csMain.DataStorage.LabelStorage, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.csMain.DataStorage.OwnerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.csMain.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.csMain.DataStorage.StatusStorage, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.c1DockingTabPage6.SuspendLayout()
		DirectCast(Me.c1GanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.c1NWINDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		DirectCast(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		' 
		' ilMain2
		' 
		Me.ilMain2.ImageStream = DirectCast(resources.GetObject("ilMain2.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ilMain2.TransparentColor = System.Drawing.Color.Transparent
		Me.ilMain2.Images.SetKeyName(0, "GroupFavorites.png")
		Me.ilMain2.Images.SetKeyName(1, "MailFolderInbox.png")
		Me.ilMain2.Images.SetKeyName(2, "MailFolderDraft.png")
		Me.ilMain2.Images.SetKeyName(3, "MailFolderSent.png")
		Me.ilMain2.Images.SetKeyName(4, "EmptyTrash.png")
		Me.ilMain2.Images.SetKeyName(5, "MailFolderRSS.png")
		Me.ilMain2.Images.SetKeyName(6, "MailFolderOutbox.png")
		Me.ilMain2.Images.SetKeyName(7, "MailFolderSPAM.png")
		Me.ilMain2.Images.SetKeyName(8, "MailFolderSearch.png")
		Me.ilMain2.Images.SetKeyName(9, "Folder.png")
		Me.ilMain2.Images.SetKeyName(10, "OrangePoint.png")
		Me.ilMain2.Images.SetKeyName(11, "FindDialogExcel.png")
		Me.ilMain2.Images.SetKeyName(12, "AdvancedFileProperties.png")
		' 
		' ilSmall
		' 
		Me.ilSmall.ImageStream = DirectCast(resources.GetObject("ilSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ilSmall.TransparentColor = System.Drawing.Color.Transparent
		Me.ilSmall.Images.SetKeyName(0, "FileNew.png")
		Me.ilSmall.Images.SetKeyName(1, "DatabaseQueryNew.png")
		Me.ilSmall.Images.SetKeyName(2, "FileOpen.png")
		Me.ilSmall.Images.SetKeyName(3, "FileClose.png")
		Me.ilSmall.Images.SetKeyName(4, "FileSave.png")
		Me.ilSmall.Images.SetKeyName(5, "FileSaveAs.png")
		Me.ilSmall.Images.SetKeyName(6, "FilePrint.png")
		Me.ilSmall.Images.SetKeyName(7, "Undo.png")
		Me.ilSmall.Images.SetKeyName(8, "Redo.png")
		Me.ilSmall.Images.SetKeyName(9, "Cut.png")
		Me.ilSmall.Images.SetKeyName(10, "Copy.png")
		Me.ilSmall.Images.SetKeyName(11, "Paste.png")
		Me.ilSmall.Images.SetKeyName(12, "SlicerDelete.png")
		Me.ilSmall.Images.SetKeyName(13, "FindDialogExcel.png")
		Me.ilSmall.Images.SetKeyName(14, "FontBold.PNG")
		Me.ilSmall.Images.SetKeyName(15, "FontItalic_SmallImage.PNG")
		Me.ilSmall.Images.SetKeyName(16, "FontUnderline_SmallImage.PNG")
		Me.ilSmall.Images.SetKeyName(17, "FontStrikeout_SmallImage.PNG")
		Me.ilSmall.Images.SetKeyName(18, "AlignLeft.png")
		Me.ilSmall.Images.SetKeyName(19, "AlignCenter.png")
		Me.ilSmall.Images.SetKeyName(20, "AlignRight.png")
		Me.ilSmall.Images.SetKeyName(21, "AlignJustify.png")
		Me.ilSmall.Images.SetKeyName(22, "FontDialog.png")
		Me.ilSmall.Images.SetKeyName(23, "FontColorCycle.png")
		Me.ilSmall.Images.SetKeyName(24, "MacroRecord.png")
		Me.ilSmall.Images.SetKeyName(25, "ViewNormalViewExcel.png")
		Me.ilSmall.Images.SetKeyName(26, "ViewDraftView.png")
		Me.ilSmall.Images.SetKeyName(27, "ViewOutlineView.png")
		Me.ilSmall.Images.SetKeyName(28, "Normal.png")
		Me.ilSmall.Images.SetKeyName(29, "Inverted.png")
		Me.ilSmall.Images.SetKeyName(30, "FormView.png")
		Me.ilSmall.Images.SetKeyName(31, "GroupBy.png")
		Me.ilSmall.Images.SetKeyName(32, "Multiline.png")
		Me.ilSmall.Images.SetKeyName(33, "Hierarchical.png")
		Me.ilSmall.Images.SetKeyName(34, "TableInsertGallery.png")
		Me.ilSmall.Images.SetKeyName(35, "tree.png")
		Me.ilSmall.Images.SetKeyName(36, "OutlineSubtotals.png")
		Me.ilSmall.Images.SetKeyName(37, "DailyView.png")
		Me.ilSmall.Images.SetKeyName(38, "WeeklyView.png")
		Me.ilSmall.Images.SetKeyName(39, "WorkWeek.png")
		Me.ilSmall.Images.SetKeyName(40, "MonthlyView.png")
		Me.ilSmall.Images.SetKeyName(41, "BorderBottom.png")
		Me.ilSmall.Images.SetKeyName(42, "BorderTop.png")
		Me.ilSmall.Images.SetKeyName(43, "BorderLeft.png")
		Me.ilSmall.Images.SetKeyName(44, "BorderRight.png")
		Me.ilSmall.Images.SetKeyName(45, "C1TopicBarSmall.png")
		Me.ilSmall.Images.SetKeyName(46, "SlicerSettings.png")
		Me.ilSmall.Images.SetKeyName(47, "TimeScaleMenu.png")
		Me.ilSmall.Images.SetKeyName(48, "Refresh.png")
		' 
		' cchMain
		' 
		Me.cchMain.Commands.Add(Me.ccmFile)
		Me.cchMain.Commands.Add(Me.ccmFileNew)
		Me.cchMain.Commands.Add(Me.ccFileNewWizard)
		Me.cchMain.Commands.Add(Me.ccFileNewEmpty)
		Me.cchMain.Commands.Add(Me.ccFileOpen)
		Me.cchMain.Commands.Add(Me.ccFileSave)
		Me.cchMain.Commands.Add(Me.ccFileSaveAs)
		Me.cchMain.Commands.Add(Me.ccFilePrint)
		Me.cchMain.Commands.Add(Me.ccFileClose)
		Me.cchMain.Commands.Add(Me.ccFileExit)
		Me.cchMain.Commands.Add(Me.ccmEdit)
		Me.cchMain.Commands.Add(Me.ccUndo)
		Me.cchMain.Commands.Add(Me.ccRedo)
		Me.cchMain.Commands.Add(Me.ccCut)
		Me.cchMain.Commands.Add(Me.ccCopy)
		Me.cchMain.Commands.Add(Me.ccPaste)
		Me.cchMain.Commands.Add(Me.ccDelete)
		Me.cchMain.Commands.Add(Me.ccFind)
		Me.cchMain.Commands.Add(Me.ccGoTo)
		Me.cchMain.Commands.Add(Me.ccmFormat)
		Me.cchMain.Commands.Add(Me.ccFormatFont)
		Me.cchMain.Commands.Add(Me.ccmFormatFontColor)
		Me.cchMain.Commands.Add(Me.ccFormatFontBold)
		Me.cchMain.Commands.Add(Me.ccFormatFontItalic)
		Me.cchMain.Commands.Add(Me.ccFormatFontUnderline)
		Me.cchMain.Commands.Add(Me.ccFormatFontStrikeout)
		Me.cchMain.Commands.Add(Me.ccFormatAlignLeft)
		Me.cchMain.Commands.Add(Me.ccFormatAlignCenter)
		Me.cchMain.Commands.Add(Me.ccFormatAlignRight)
		Me.cchMain.Commands.Add(Me.ccFormatAlignJustify)
		Me.cchMain.Commands.Add(Me.ccmC1TrueDBGrid)
		Me.cchMain.Commands.Add(Me.ccCTDBGViewNormal)
		Me.cchMain.Commands.Add(Me.ccCTDBGViewInverted)
		Me.cchMain.Commands.Add(Me.ccCTDBGViewForm)
		Me.cchMain.Commands.Add(Me.ccCTDBGViewGroupBy)
		Me.cchMain.Commands.Add(Me.ccCTDBGViewMultipleLines)
		Me.cchMain.Commands.Add(Me.ccCTDBGViewHierarchical)
		Me.cchMain.Commands.Add(Me.ccCTDBGShowCaption)
		Me.cchMain.Commands.Add(Me.ccmC1FlexGrid)
		Me.cchMain.Commands.Add(Me.ccCFGViewNormal)
		Me.cchMain.Commands.Add(Me.ccCFGViewTree)
		Me.cchMain.Commands.Add(Me.ccCFGViewSubtotals)
		Me.cchMain.Commands.Add(Me.ccCFGFixedColCount)
		Me.cchMain.Commands.Add(Me.ccCFGFixedRowCount)
		Me.cchMain.Commands.Add(Me.ccmCFGSelectionMode)
		Me.cchMain.Commands.Add(Me.ccmCFGFocusRect)
		Me.cchMain.Commands.Add(Me.ccCFGShowCursor)
		Me.cchMain.Commands.Add(Me.ccmC1Schedule)
		Me.cchMain.Commands.Add(Me.ccCSViewDay)
		Me.cchMain.Commands.Add(Me.ccCSViewWorkWeek)
		Me.cchMain.Commands.Add(Me.ccCSViewWeek)
		Me.cchMain.Commands.Add(Me.ccCSViewMonth)
		Me.cchMain.Commands.Add(Me.ccCSViewTimeLine)
		Me.cchMain.Commands.Add(Me.ccCSEnableGrouping)
		Me.cchMain.Commands.Add(Me.ccCSOffice2003WeekView)
		Me.cchMain.Commands.Add(Me.cccFormatFontName)
		Me.cchMain.Commands.Add(Me.cccFormatFontSize)
		Me.cchMain.Commands.Add(Me.ccmFormatBorders)
		Me.cchMain.Commands.Add(Me.ccFormatBorderBottom)
		Me.cchMain.Commands.Add(Me.ccFormatBorderTop)
		Me.cchMain.Commands.Add(Me.ccFormatBorderLeft)
		Me.cchMain.Commands.Add(Me.ccFormatBorderRight)
		Me.cchMain.Commands.Add(Me.ccStatesNormal)
		Me.cchMain.Commands.Add(Me.ccStatesDisabled)
		Me.cchMain.Commands.Add(Me.ccStatesPressed)
		Me.cchMain.Commands.Add(Me.ccStatesChecked)
		Me.cchMain.Commands.Add(Me.ccmTheme)
		Me.cchMain.ImageList = Me.ilSmall
		Me.cchMain.Owner = Me
		' 
		' ccmFile
		' 
		Me.ccmFile.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink2, Me.c1CommandLink4, Me.c1CommandLink6, Me.c1CommandLink7, Me.c1CommandLink9, Me.c1CommandLink8, _
			Me.c1CommandLink10})
		Me.ccmFile.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccmFile.HideNonRecentLinks = False
		Me.ccmFile.Name = "ccmFile"
		Me.ccmFile.ShortcutText = ""
		Me.ccmFile.SideCaption.Text = "File actions"
		Me.ccmFile.Text = "&File"
		Me.c1ThemeController1.SetTheme(Me.ccmFile, "(default)")
		Me.ccmFile.VisualStyle = C1.Win.Command.VisualStyle.[Custom]
		Me.ccmFile.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue
		' 
		' c1CommandLink2
		' 
		Me.c1CommandLink2.Command = Me.ccmFileNew
		' 
		' ccmFileNew
		' 
		Me.ccmFileNew.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink5, Me.c1CommandLink3})
		Me.ccmFileNew.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccmFileNew.HideNonRecentLinks = False
		Me.ccmFileNew.Name = "ccmFileNew"
		Me.ccmFileNew.ShortcutText = ""
		Me.ccmFileNew.Text = "New"
		Me.c1ThemeController1.SetTheme(Me.ccmFileNew, "(default)")
		Me.ccmFileNew.VisualStyle = C1.Win.Command.VisualStyle.[Custom]
		Me.ccmFileNew.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue
		' 
		' c1CommandLink5
		' 
		Me.c1CommandLink5.Command = Me.ccFileNewWizard
		' 
		' ccFileNewWizard
		' 
		Me.ccFileNewWizard.ImageIndex = 1
		Me.ccFileNewWizard.Name = "ccFileNewWizard"
		Me.ccFileNewWizard.ShortcutText = ""
		Me.ccFileNewWizard.Text = "Wizard..."
		' 
		' c1CommandLink3
		' 
		Me.c1CommandLink3.Command = Me.ccFileNewEmpty
		Me.c1CommandLink3.SortOrder = 1
		' 
		' ccFileNewEmpty
		' 
		Me.ccFileNewEmpty.ImageIndex = 0
		Me.ccFileNewEmpty.Name = "ccFileNewEmpty"
		Me.ccFileNewEmpty.ShortcutText = ""
		Me.ccFileNewEmpty.Text = "Empty"
		' 
		' c1CommandLink4
		' 
		Me.c1CommandLink4.Command = Me.ccFileOpen
		Me.c1CommandLink4.SortOrder = 1
		' 
		' ccFileOpen
		' 
		Me.ccFileOpen.ImageIndex = 2
		Me.ccFileOpen.Name = "ccFileOpen"
		Me.ccFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
		Me.ccFileOpen.ShortcutText = ""
		Me.ccFileOpen.Text = "Open..."
		' 
		' c1CommandLink6
		' 
		Me.c1CommandLink6.Command = Me.ccFileSave
		Me.c1CommandLink6.Delimiter = True
		Me.c1CommandLink6.SortOrder = 2
		' 
		' ccFileSave
		' 
		Me.ccFileSave.ImageIndex = 4
		Me.ccFileSave.Name = "ccFileSave"
		Me.ccFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
		Me.ccFileSave.ShortcutText = ""
		Me.ccFileSave.Text = "Save"
		' 
		' c1CommandLink7
		' 
		Me.c1CommandLink7.Command = Me.ccFileSaveAs
		Me.c1CommandLink7.SortOrder = 3
		' 
		' ccFileSaveAs
		' 
		Me.ccFileSaveAs.ImageIndex = 5
		Me.ccFileSaveAs.Name = "ccFileSaveAs"
		Me.ccFileSaveAs.ShortcutText = ""
		Me.ccFileSaveAs.Text = "Save As..."
		' 
		' c1CommandLink9
		' 
		Me.c1CommandLink9.Command = Me.ccFilePrint
		Me.c1CommandLink9.Delimiter = True
		Me.c1CommandLink9.SortOrder = 4
		' 
		' ccFilePrint
		' 
		Me.ccFilePrint.ImageIndex = 6
		Me.ccFilePrint.Name = "ccFilePrint"
		Me.ccFilePrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP
		Me.ccFilePrint.ShortcutText = ""
		Me.ccFilePrint.Text = "Print..."
		' 
		' c1CommandLink8
		' 
		Me.c1CommandLink8.Command = Me.ccFileClose
		Me.c1CommandLink8.Delimiter = True
		Me.c1CommandLink8.SortOrder = 5
		' 
		' ccFileClose
		' 
		Me.ccFileClose.ImageIndex = 3
		Me.ccFileClose.Name = "ccFileClose"
		Me.ccFileClose.ShortcutText = ""
		Me.ccFileClose.Text = "Close"
		' 
		' c1CommandLink10
		' 
		Me.c1CommandLink10.Command = Me.ccFileExit
		Me.c1CommandLink10.Delimiter = True
		Me.c1CommandLink10.SortOrder = 6
		' 
		' ccFileExit
		' 
		Me.ccFileExit.Name = "ccFileExit"
		Me.ccFileExit.Shortcut = System.Windows.Forms.Shortcut.AltF4
		Me.ccFileExit.ShortcutText = ""
		Me.ccFileExit.Text = "E&xit"
		AddHandler Me.ccFileExit.Click, New C1.Win.Command.ClickEventHandler(AddressOf Me.ccFileExit_Click)
		' 
		' ccmEdit
		' 
		Me.ccmEdit.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink11, Me.c1CommandLink13, Me.c1CommandLink14, Me.c1CommandLink15, Me.c1CommandLink16, Me.c1CommandLink17, _
			Me.c1CommandLink18, Me.c1CommandLink19})
		Me.ccmEdit.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccmEdit.HideNonRecentLinks = False
		Me.ccmEdit.Name = "ccmEdit"
		Me.ccmEdit.ShortcutText = ""
		Me.ccmEdit.Text = "&Edit"
		Me.c1ThemeController1.SetTheme(Me.ccmEdit, "(default)")
		Me.ccmEdit.VisualStyle = C1.Win.Command.VisualStyle.[Custom]
		Me.ccmEdit.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue
		' 
		' c1CommandLink11
		' 
		Me.c1CommandLink11.Command = Me.ccUndo
		' 
		' ccUndo
		' 
		Me.ccUndo.ImageIndex = 7
		Me.ccUndo.Name = "ccUndo"
		Me.ccUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ
		Me.ccUndo.ShortcutText = ""
		Me.ccUndo.Text = "Undo"
		' 
		' c1CommandLink13
		' 
		Me.c1CommandLink13.Command = Me.ccRedo
		Me.c1CommandLink13.SortOrder = 1
		' 
		' ccRedo
		' 
		Me.ccRedo.Enabled = False
		Me.ccRedo.ImageIndex = 8
		Me.ccRedo.Name = "ccRedo"
		Me.ccRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY
		Me.ccRedo.ShortcutText = ""
		Me.ccRedo.Text = "Redo"
		' 
		' c1CommandLink14
		' 
		Me.c1CommandLink14.Command = Me.ccCut
		Me.c1CommandLink14.Delimiter = True
		Me.c1CommandLink14.SortOrder = 2
		' 
		' ccCut
		' 
		Me.ccCut.ImageIndex = 9
		Me.ccCut.Name = "ccCut"
		Me.ccCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX
		Me.ccCut.ShortcutText = ""
		Me.ccCut.Text = "Cut"
		' 
		' c1CommandLink15
		' 
		Me.c1CommandLink15.Command = Me.ccCopy
		Me.c1CommandLink15.SortOrder = 3
		' 
		' ccCopy
		' 
		Me.ccCopy.ImageIndex = 10
		Me.ccCopy.Name = "ccCopy"
		Me.ccCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC
		Me.ccCopy.ShortcutText = ""
		Me.ccCopy.Text = "Copy"
		' 
		' c1CommandLink16
		' 
		Me.c1CommandLink16.Command = Me.ccPaste
		Me.c1CommandLink16.SortOrder = 4
		' 
		' ccPaste
		' 
		Me.ccPaste.ImageIndex = 11
		Me.ccPaste.Name = "ccPaste"
		Me.ccPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV
		Me.ccPaste.ShortcutText = ""
		Me.ccPaste.Text = "Paste"
		' 
		' c1CommandLink17
		' 
		Me.c1CommandLink17.Command = Me.ccDelete
		Me.c1CommandLink17.SortOrder = 5
		' 
		' ccDelete
		' 
		Me.ccDelete.ImageIndex = 12
		Me.ccDelete.Name = "ccDelete"
		Me.ccDelete.Shortcut = System.Windows.Forms.Shortcut.Del
		Me.ccDelete.ShortcutText = ""
		Me.ccDelete.Text = "Delete"
		' 
		' c1CommandLink18
		' 
		Me.c1CommandLink18.Command = Me.ccFind
		Me.c1CommandLink18.Delimiter = True
		Me.c1CommandLink18.SortOrder = 6
		' 
		' ccFind
		' 
		Me.ccFind.ImageIndex = 13
		Me.ccFind.Name = "ccFind"
		Me.ccFind.ShortcutText = ""
		Me.ccFind.Text = "Find"
		' 
		' c1CommandLink19
		' 
		Me.c1CommandLink19.Command = Me.ccGoTo
		Me.c1CommandLink19.SortOrder = 7
		' 
		' ccGoTo
		' 
		Me.ccGoTo.Enabled = False
		Me.ccGoTo.Name = "ccGoTo"
		Me.ccGoTo.ShortcutText = ""
		Me.ccGoTo.Text = "Go To..."
		' 
		' ccmFormat
		' 
		Me.ccmFormat.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink20, Me.c1CommandLink23})
		Me.ccmFormat.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccmFormat.HideNonRecentLinks = False
		Me.ccmFormat.Name = "ccmFormat"
		Me.ccmFormat.ShortcutText = ""
		Me.ccmFormat.Text = "&Format"
		Me.c1ThemeController1.SetTheme(Me.ccmFormat, "(default)")
		Me.ccmFormat.VisualStyle = C1.Win.Command.VisualStyle.[Custom]
		Me.ccmFormat.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue
		' 
		' c1CommandLink20
		' 
		Me.c1CommandLink20.Command = Me.ccFormatFont
		' 
		' ccFormatFont
		' 
		Me.ccFormatFont.ImageIndex = 22
		Me.ccFormatFont.Name = "ccFormatFont"
		Me.ccFormatFont.ShortcutText = ""
		Me.ccFormatFont.Text = "Font..."
		' 
		' c1CommandLink23
		' 
		Me.c1CommandLink23.Command = Me.ccmFormatFontColor
		Me.c1CommandLink23.SortOrder = 1
		' 
		' ccmFormatFontColor
		' 
		Me.ccmFormatFontColor.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink21})
		Me.ccmFormatFontColor.Enabled = False
		Me.ccmFormatFontColor.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccmFormatFontColor.ImageIndex = 23
		Me.ccmFormatFontColor.Name = "ccmFormatFontColor"
		Me.ccmFormatFontColor.ShortcutText = ""
		Me.ccmFormatFontColor.Text = "Font Color"
		Me.c1ThemeController1.SetTheme(Me.ccmFormatFontColor, "(default)")
		Me.ccmFormatFontColor.VisualStyle = C1.Win.Command.VisualStyle.[Custom]
		Me.ccmFormatFontColor.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue
		' 
		' c1CommandLink21
		' 
		Me.c1CommandLink21.Text = "New Command"
		' 
		' ccFormatFontBold
		' 
		Me.ccFormatFontBold.CheckAutoToggle = True
		Me.ccFormatFontBold.Checked = True
		Me.ccFormatFontBold.ImageIndex = 14
		Me.ccFormatFontBold.Name = "ccFormatFontBold"
		Me.ccFormatFontBold.ShortcutText = ""
		Me.ccFormatFontBold.Text = "Bold"
		' 
		' ccFormatFontItalic
		' 
		Me.ccFormatFontItalic.CheckAutoToggle = True
		Me.ccFormatFontItalic.ImageIndex = 15
		Me.ccFormatFontItalic.Name = "ccFormatFontItalic"
		Me.ccFormatFontItalic.ShortcutText = ""
		Me.ccFormatFontItalic.Text = "Italic"
		' 
		' ccFormatFontUnderline
		' 
		Me.ccFormatFontUnderline.CheckAutoToggle = True
		Me.ccFormatFontUnderline.ImageIndex = 16
		Me.ccFormatFontUnderline.Name = "ccFormatFontUnderline"
		Me.ccFormatFontUnderline.ShortcutText = ""
		Me.ccFormatFontUnderline.Text = "Underline"
		' 
		' ccFormatFontStrikeout
		' 
		Me.ccFormatFontStrikeout.CheckAutoToggle = True
		Me.ccFormatFontStrikeout.ImageIndex = 17
		Me.ccFormatFontStrikeout.Name = "ccFormatFontStrikeout"
		Me.ccFormatFontStrikeout.ShortcutText = ""
		Me.ccFormatFontStrikeout.Text = "Strikeout"
		' 
		' ccFormatAlignLeft
		' 
		Me.ccFormatAlignLeft.CheckAutoToggle = True
		Me.ccFormatAlignLeft.ImageIndex = 18
		Me.ccFormatAlignLeft.Name = "ccFormatAlignLeft"
		Me.ccFormatAlignLeft.ShortcutText = ""
		' 
		' ccFormatAlignCenter
		' 
		Me.ccFormatAlignCenter.CheckAutoToggle = True
		Me.ccFormatAlignCenter.ImageIndex = 19
		Me.ccFormatAlignCenter.Name = "ccFormatAlignCenter"
		Me.ccFormatAlignCenter.ShortcutText = ""
		' 
		' ccFormatAlignRight
		' 
		Me.ccFormatAlignRight.CheckAutoToggle = True
		Me.ccFormatAlignRight.ImageIndex = 20
		Me.ccFormatAlignRight.Name = "ccFormatAlignRight"
		Me.ccFormatAlignRight.ShortcutText = ""
		' 
		' ccFormatAlignJustify
		' 
		Me.ccFormatAlignJustify.CheckAutoToggle = True
		Me.ccFormatAlignJustify.ImageIndex = 21
		Me.ccFormatAlignJustify.Name = "ccFormatAlignJustify"
		Me.ccFormatAlignJustify.ShortcutText = ""
		' 
		' ccmC1TrueDBGrid
		' 
		Me.ccmC1TrueDBGrid.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink24, Me.c1CommandLink26, Me.c1CommandLink27, Me.c1CommandLink28, Me.c1CommandLink29, Me.c1CommandLink30, _
			Me.c1CommandLink31})
		Me.ccmC1TrueDBGrid.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccmC1TrueDBGrid.HideNonRecentLinks = False
		Me.ccmC1TrueDBGrid.Name = "ccmC1TrueDBGrid"
		Me.ccmC1TrueDBGrid.ShortcutText = ""
		Me.ccmC1TrueDBGrid.Text = "C1TrueDBGrid"
		Me.c1ThemeController1.SetTheme(Me.ccmC1TrueDBGrid, "(default)")
		Me.ccmC1TrueDBGrid.VisualStyle = C1.Win.Command.VisualStyle.[Custom]
		Me.ccmC1TrueDBGrid.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue
		' 
		' c1CommandLink24
		' 
		Me.c1CommandLink24.Command = Me.ccCTDBGViewNormal
		' 
		' ccCTDBGViewNormal
		' 
		Me.ccCTDBGViewNormal.ImageIndex = 28
		Me.ccCTDBGViewNormal.Name = "ccCTDBGViewNormal"
		Me.ccCTDBGViewNormal.ShortcutText = ""
		Me.ccCTDBGViewNormal.Text = "Normal View"
		Me.ccCTDBGViewNormal.UserData = "Normal"
		' 
		' c1CommandLink26
		' 
		Me.c1CommandLink26.Command = Me.ccCTDBGViewInverted
		Me.c1CommandLink26.SortOrder = 1
		' 
		' ccCTDBGViewInverted
		' 
		Me.ccCTDBGViewInverted.ImageIndex = 29
		Me.ccCTDBGViewInverted.Name = "ccCTDBGViewInverted"
		Me.ccCTDBGViewInverted.ShortcutText = ""
		Me.ccCTDBGViewInverted.Text = "Inverted View"
		Me.ccCTDBGViewInverted.UserData = "Inverted"
		' 
		' c1CommandLink27
		' 
		Me.c1CommandLink27.Command = Me.ccCTDBGViewForm
		Me.c1CommandLink27.SortOrder = 2
		' 
		' ccCTDBGViewForm
		' 
		Me.ccCTDBGViewForm.ImageIndex = 30
		Me.ccCTDBGViewForm.Name = "ccCTDBGViewForm"
		Me.ccCTDBGViewForm.ShortcutText = ""
		Me.ccCTDBGViewForm.Text = "Form View"
		Me.ccCTDBGViewForm.UserData = "Form"
		' 
		' c1CommandLink28
		' 
		Me.c1CommandLink28.Command = Me.ccCTDBGViewGroupBy
		Me.c1CommandLink28.SortOrder = 3
		' 
		' ccCTDBGViewGroupBy
		' 
		Me.ccCTDBGViewGroupBy.ImageIndex = 31
		Me.ccCTDBGViewGroupBy.Name = "ccCTDBGViewGroupBy"
		Me.ccCTDBGViewGroupBy.ShortcutText = ""
		Me.ccCTDBGViewGroupBy.Text = "Grouped View"
		Me.ccCTDBGViewGroupBy.UserData = "GroupBy"
		' 
		' c1CommandLink29
		' 
		Me.c1CommandLink29.Command = Me.ccCTDBGViewMultipleLines
		Me.c1CommandLink29.SortOrder = 4
		' 
		' ccCTDBGViewMultipleLines
		' 
		Me.ccCTDBGViewMultipleLines.ImageIndex = 32
		Me.ccCTDBGViewMultipleLines.Name = "ccCTDBGViewMultipleLines"
		Me.ccCTDBGViewMultipleLines.ShortcutText = ""
		Me.ccCTDBGViewMultipleLines.Text = "Multiple Lines View"
		Me.ccCTDBGViewMultipleLines.UserData = "MultipleLines"
		' 
		' c1CommandLink30
		' 
		Me.c1CommandLink30.Command = Me.ccCTDBGViewHierarchical
		Me.c1CommandLink30.SortOrder = 5
		' 
		' ccCTDBGViewHierarchical
		' 
		Me.ccCTDBGViewHierarchical.ImageIndex = 33
		Me.ccCTDBGViewHierarchical.Name = "ccCTDBGViewHierarchical"
		Me.ccCTDBGViewHierarchical.ShortcutText = ""
		Me.ccCTDBGViewHierarchical.Text = "Hierarchical View"
		Me.ccCTDBGViewHierarchical.UserData = "Hierarchical"
		' 
		' c1CommandLink31
		' 
		Me.c1CommandLink31.Command = Me.ccCTDBGShowCaption
		Me.c1CommandLink31.Delimiter = True
		Me.c1CommandLink31.SortOrder = 6
		' 
		' ccCTDBGShowCaption
		' 
		Me.ccCTDBGShowCaption.Name = "ccCTDBGShowCaption"
		Me.ccCTDBGShowCaption.ShortcutText = ""
		Me.ccCTDBGShowCaption.Text = "Show Caption"
		' 
		' ccmC1FlexGrid
		' 
		Me.ccmC1FlexGrid.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink32, Me.c1CommandLink36, Me.c1CommandLink37, Me.c1CommandLink38, Me.c1CommandLink39, Me.c1CommandLink40, _
			Me.c1CommandLink41, Me.c1CommandLink42})
		Me.ccmC1FlexGrid.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccmC1FlexGrid.HideNonRecentLinks = False
		Me.ccmC1FlexGrid.Name = "ccmC1FlexGrid"
		Me.ccmC1FlexGrid.ShortcutText = ""
		Me.ccmC1FlexGrid.Text = "C1FlexGrid"
		Me.c1ThemeController1.SetTheme(Me.ccmC1FlexGrid, "(default)")
		Me.ccmC1FlexGrid.VisualStyle = C1.Win.Command.VisualStyle.[Custom]
		Me.ccmC1FlexGrid.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue
		' 
		' c1CommandLink32
		' 
		Me.c1CommandLink32.Command = Me.ccCFGViewNormal
		' 
		' ccCFGViewNormal
		' 
		Me.ccCFGViewNormal.ImageIndex = 34
		Me.ccCFGViewNormal.Name = "ccCFGViewNormal"
		Me.ccCFGViewNormal.ShortcutText = ""
		Me.ccCFGViewNormal.Text = "Normal View"
		Me.ccCFGViewNormal.UserData = "Normal"
		' 
		' c1CommandLink36
		' 
		Me.c1CommandLink36.Command = Me.ccCFGViewTree
		Me.c1CommandLink36.SortOrder = 1
		' 
		' ccCFGViewTree
		' 
		Me.ccCFGViewTree.ImageIndex = 35
		Me.ccCFGViewTree.Name = "ccCFGViewTree"
		Me.ccCFGViewTree.ShortcutText = ""
		Me.ccCFGViewTree.Text = "Tree View"
		Me.ccCFGViewTree.UserData = "Tree"
		' 
		' c1CommandLink37
		' 
		Me.c1CommandLink37.Command = Me.ccCFGViewSubtotals
		Me.c1CommandLink37.SortOrder = 2
		' 
		' ccCFGViewSubtotals
		' 
		Me.ccCFGViewSubtotals.ImageIndex = 36
		Me.ccCFGViewSubtotals.Name = "ccCFGViewSubtotals"
		Me.ccCFGViewSubtotals.ShortcutText = ""
		Me.ccCFGViewSubtotals.Text = "Subtotal Styles"
		Me.ccCFGViewSubtotals.UserData = "Subtotals"
		' 
		' c1CommandLink38
		' 
		Me.c1CommandLink38.Command = Me.ccCFGFixedColCount
		Me.c1CommandLink38.Delimiter = True
		Me.c1CommandLink38.SortOrder = 3
		Me.c1CommandLink38.Text = "Fixed column count"
		' 
		' ccCFGFixedColCount
		' 
		Me.ccCFGFixedColCount.Control = Me.cneCFGFrozenColCount
		Me.ccCFGFixedColCount.Name = "ccCFGFixedColCount"
		Me.ccCFGFixedColCount.ShortcutText = ""
		Me.ccCFGFixedColCount.Text = "Fixed column count"
		' 
		' cneCFGFrozenColCount
		' 
		Me.cneCFGFrozenColCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		' 
		' 
		' 
		Me.cneCFGFrozenColCount.Calculator.BackColor = System.Drawing.SystemColors.Control
		Me.cneCFGFrozenColCount.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
		Me.cneCFGFrozenColCount.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.cneCFGFrozenColCount.ImagePadding = New System.Windows.Forms.Padding(0)
		Me.cneCFGFrozenColCount.Location = New System.Drawing.Point(139, 82)
		Me.cneCFGFrozenColCount.Name = "cneCFGFrozenColCount"
		Me.cneCFGFrozenColCount.Size = New System.Drawing.Size(121, 20)
		Me.cneCFGFrozenColCount.TabIndex = 4
		Me.cneCFGFrozenColCount.Tag = Nothing
		Me.c1ThemeController1.SetTheme(Me.cneCFGFrozenColCount, "(default)")
		Me.cneCFGFrozenColCount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
		Me.cneCFGFrozenColCount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
		AddHandler Me.cneCFGFrozenColCount.ValueChanged, New System.EventHandler(AddressOf Me.cneFixedColCount_ValueChanged)
		' 
		' c1CommandLink39
		' 
		Me.c1CommandLink39.Command = Me.ccCFGFixedRowCount
		Me.c1CommandLink39.SortOrder = 4
		Me.c1CommandLink39.Text = "Fixed rows count"
		' 
		' ccCFGFixedRowCount
		' 
		Me.ccCFGFixedRowCount.Control = Me.cneCFGFrozenRowCount
		Me.ccCFGFixedRowCount.Name = "ccCFGFixedRowCount"
		Me.ccCFGFixedRowCount.ShortcutText = ""
		Me.ccCFGFixedRowCount.Text = "Fixed rows count"
		' 
		' cneCFGFrozenRowCount
		' 
		Me.cneCFGFrozenRowCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		' 
		' 
		' 
		Me.cneCFGFrozenRowCount.Calculator.BackColor = System.Drawing.SystemColors.Control
		Me.cneCFGFrozenRowCount.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
		Me.cneCFGFrozenRowCount.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.cneCFGFrozenRowCount.ImagePadding = New System.Windows.Forms.Padding(0)
		Me.cneCFGFrozenRowCount.Location = New System.Drawing.Point(139, 107)
		Me.cneCFGFrozenRowCount.Name = "cneCFGFrozenRowCount"
		Me.cneCFGFrozenRowCount.Size = New System.Drawing.Size(121, 20)
		Me.cneCFGFrozenRowCount.TabIndex = 5
		Me.cneCFGFrozenRowCount.Tag = Nothing
		Me.c1ThemeController1.SetTheme(Me.cneCFGFrozenRowCount, "(default)")
		Me.cneCFGFrozenRowCount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
		Me.cneCFGFrozenRowCount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
		AddHandler Me.cneCFGFrozenRowCount.ValueChanged, New System.EventHandler(AddressOf Me.cneFixedRowCount_ValueChanged)
		' 
		' c1CommandLink40
		' 
		Me.c1CommandLink40.Command = Me.ccmCFGSelectionMode
		Me.c1CommandLink40.Delimiter = True
		Me.c1CommandLink40.SortOrder = 5
		' 
		' ccmCFGSelectionMode
		' 
		Me.ccmCFGSelectionMode.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink33})
		Me.ccmCFGSelectionMode.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccmCFGSelectionMode.HideNonRecentLinks = False
		Me.ccmCFGSelectionMode.Name = "ccmCFGSelectionMode"
		Me.ccmCFGSelectionMode.ShortcutText = ""
		Me.ccmCFGSelectionMode.Text = "Selection Mode"
		Me.c1ThemeController1.SetTheme(Me.ccmCFGSelectionMode, "(default)")
		Me.ccmCFGSelectionMode.VisualStyle = C1.Win.Command.VisualStyle.[Custom]
		Me.ccmCFGSelectionMode.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue
		' 
		' c1CommandLink33
		' 
		Me.c1CommandLink33.Text = "New Command"
		' 
		' c1CommandLink41
		' 
		Me.c1CommandLink41.Command = Me.ccmCFGFocusRect
		Me.c1CommandLink41.SortOrder = 6
		' 
		' ccmCFGFocusRect
		' 
		Me.ccmCFGFocusRect.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink34})
		Me.ccmCFGFocusRect.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccmCFGFocusRect.HideNonRecentLinks = False
		Me.ccmCFGFocusRect.Name = "ccmCFGFocusRect"
		Me.ccmCFGFocusRect.ShortcutText = ""
		Me.ccmCFGFocusRect.Text = "Focus Rect"
		Me.c1ThemeController1.SetTheme(Me.ccmCFGFocusRect, "(default)")
		Me.ccmCFGFocusRect.VisualStyle = C1.Win.Command.VisualStyle.[Custom]
		Me.ccmCFGFocusRect.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue
		' 
		' c1CommandLink34
		' 
		Me.c1CommandLink34.Text = "New Command"
		' 
		' c1CommandLink42
		' 
		Me.c1CommandLink42.Command = Me.ccCFGShowCursor
		Me.c1CommandLink42.Delimiter = True
		Me.c1CommandLink42.SortOrder = 7
		' 
		' ccCFGShowCursor
		' 
		Me.ccCFGShowCursor.Name = "ccCFGShowCursor"
		Me.ccCFGShowCursor.ShortcutText = ""
		Me.ccCFGShowCursor.Text = "Show Cursor"
		' 
		' ccmC1Schedule
		' 
		Me.ccmC1Schedule.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink43, Me.c1CommandLink45, Me.c1CommandLink46, Me.c1CommandLink47, Me.c1CommandLink48, Me.c1CommandLink49, _
			Me.c1CommandLink50})
		Me.ccmC1Schedule.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccmC1Schedule.HideNonRecentLinks = False
		Me.ccmC1Schedule.Name = "ccmC1Schedule"
		Me.ccmC1Schedule.ShortcutText = ""
		Me.ccmC1Schedule.Text = "C1Schedule"
		Me.c1ThemeController1.SetTheme(Me.ccmC1Schedule, "(default)")
		Me.ccmC1Schedule.VisualStyle = C1.Win.Command.VisualStyle.[Custom]
		Me.ccmC1Schedule.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue
		' 
		' c1CommandLink43
		' 
		Me.c1CommandLink43.Command = Me.ccCSViewDay
		' 
		' ccCSViewDay
		' 
		Me.ccCSViewDay.ImageIndex = 37
		Me.ccCSViewDay.Name = "ccCSViewDay"
		Me.ccCSViewDay.ShortcutText = ""
		Me.ccCSViewDay.Text = "Day View"
		Me.ccCSViewDay.UserData = "DayView"
		' 
		' c1CommandLink45
		' 
		Me.c1CommandLink45.Command = Me.ccCSViewWorkWeek
		Me.c1CommandLink45.SortOrder = 1
		' 
		' ccCSViewWorkWeek
		' 
		Me.ccCSViewWorkWeek.ImageIndex = 39
		Me.ccCSViewWorkWeek.Name = "ccCSViewWorkWeek"
		Me.ccCSViewWorkWeek.ShortcutText = ""
		Me.ccCSViewWorkWeek.Text = "Work Week View"
		Me.ccCSViewWorkWeek.UserData = "WorkWeekView"
		' 
		' c1CommandLink46
		' 
		Me.c1CommandLink46.Command = Me.ccCSViewWeek
		Me.c1CommandLink46.SortOrder = 2
		' 
		' ccCSViewWeek
		' 
		Me.ccCSViewWeek.ImageIndex = 38
		Me.ccCSViewWeek.Name = "ccCSViewWeek"
		Me.ccCSViewWeek.ShortcutText = ""
		Me.ccCSViewWeek.Text = "Week View"
		Me.ccCSViewWeek.UserData = "WeekView"
		' 
		' c1CommandLink47
		' 
		Me.c1CommandLink47.Command = Me.ccCSViewMonth
		Me.c1CommandLink47.SortOrder = 3
		' 
		' ccCSViewMonth
		' 
		Me.ccCSViewMonth.ImageIndex = 40
		Me.ccCSViewMonth.Name = "ccCSViewMonth"
		Me.ccCSViewMonth.ShortcutText = ""
		Me.ccCSViewMonth.Text = "Month View"
		Me.ccCSViewMonth.UserData = "MonthView"
		' 
		' c1CommandLink48
		' 
		Me.c1CommandLink48.Command = Me.ccCSViewTimeLine
		Me.c1CommandLink48.SortOrder = 4
		' 
		' ccCSViewTimeLine
		' 
		Me.ccCSViewTimeLine.ImageIndex = 47
		Me.ccCSViewTimeLine.Name = "ccCSViewTimeLine"
		Me.ccCSViewTimeLine.ShortcutText = ""
		Me.ccCSViewTimeLine.Text = "Time Line View"
		Me.ccCSViewTimeLine.UserData = "TimeLineView"
		' 
		' c1CommandLink49
		' 
		Me.c1CommandLink49.Command = Me.ccCSEnableGrouping
		Me.c1CommandLink49.Delimiter = True
		Me.c1CommandLink49.SortOrder = 5
		' 
		' ccCSEnableGrouping
		' 
		Me.ccCSEnableGrouping.Name = "ccCSEnableGrouping"
		Me.ccCSEnableGrouping.ShortcutText = ""
		Me.ccCSEnableGrouping.Text = "Enable Grouping"
		' 
		' c1CommandLink50
		' 
		Me.c1CommandLink50.Command = Me.ccCSOffice2003WeekView
		Me.c1CommandLink50.SortOrder = 6
		' 
		' ccCSOffice2003WeekView
		' 
		Me.ccCSOffice2003WeekView.Name = "ccCSOffice2003WeekView"
		Me.ccCSOffice2003WeekView.ShortcutText = ""
		Me.ccCSOffice2003WeekView.Text = "Office 2003 Week View"
		' 
		' cccFormatFontName
		' 
		Me.cccFormatFontName.Control = Me.cddcFontName
		Me.cccFormatFontName.Name = "cccFormatFontName"
		Me.cccFormatFontName.ShortcutText = ""
		' 
		' cddcFontName
		' 
		Me.cddcFontName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.cddcFontName.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.cddcFontName.ImagePadding = New System.Windows.Forms.Padding(0)
		Me.cddcFontName.Location = New System.Drawing.Point(10, 4)
		Me.cddcFontName.Name = "cddcFontName"
		Me.cddcFontName.Size = New System.Drawing.Size(200, 20)
		Me.cddcFontName.TabIndex = 5
		Me.cddcFontName.Tag = Nothing
		Me.cddcFontName.TextDetached = True
		Me.c1ThemeController1.SetTheme(Me.cddcFontName, "(default)")
		Me.cddcFontName.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
		Me.cddcFontName.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
		' 
		' cccFormatFontSize
		' 
		Me.cccFormatFontSize.Control = Me.cddcFontSize
		Me.cccFormatFontSize.Name = "cccFormatFontSize"
		Me.cccFormatFontSize.ShortcutText = ""
		' 
		' cddcFontSize
		' 
		Me.cddcFontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.cddcFontSize.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.cddcFontSize.ImagePadding = New System.Windows.Forms.Padding(0)
		Me.cddcFontSize.Location = New System.Drawing.Point(212, 4)
		Me.cddcFontSize.Name = "cddcFontSize"
		Me.cddcFontSize.Size = New System.Drawing.Size(70, 20)
		Me.cddcFontSize.TabIndex = 6
		Me.cddcFontSize.Tag = Nothing
		Me.cddcFontSize.TextDetached = True
		Me.c1ThemeController1.SetTheme(Me.cddcFontSize, "(default)")
		Me.cddcFontSize.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown
		Me.cddcFontSize.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
		' 
		' ccmFormatBorders
		' 
		Me.ccmFormatBorders.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink73, Me.c1CommandLink71, Me.c1CommandLink74, Me.c1CommandLink75})
		Me.ccmFormatBorders.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccmFormatBorders.HideNonRecentLinks = False
		Me.ccmFormatBorders.ImageIndex = 41
		Me.ccmFormatBorders.Name = "ccmFormatBorders"
		Me.ccmFormatBorders.ShortcutText = ""
		Me.ccmFormatBorders.ShowToolTips = True
		Me.c1ThemeController1.SetTheme(Me.ccmFormatBorders, "(default)")
		Me.ccmFormatBorders.VisualStyle = C1.Win.Command.VisualStyle.[Custom]
		Me.ccmFormatBorders.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue
		' 
		' c1CommandLink73
		' 
		Me.c1CommandLink73.Command = Me.ccFormatBorderBottom
		' 
		' ccFormatBorderBottom
		' 
		Me.ccFormatBorderBottom.ImageIndex = 41
		Me.ccFormatBorderBottom.Name = "ccFormatBorderBottom"
		Me.ccFormatBorderBottom.ShortcutText = ""
		Me.ccFormatBorderBottom.Text = "Bottom border"
		' 
		' c1CommandLink71
		' 
		Me.c1CommandLink71.Command = Me.ccFormatBorderTop
		Me.c1CommandLink71.SortOrder = 1
		' 
		' ccFormatBorderTop
		' 
		Me.ccFormatBorderTop.ImageIndex = 42
		Me.ccFormatBorderTop.Name = "ccFormatBorderTop"
		Me.ccFormatBorderTop.ShortcutText = ""
		Me.ccFormatBorderTop.Text = "Border top"
		' 
		' c1CommandLink74
		' 
		Me.c1CommandLink74.Command = Me.ccFormatBorderLeft
		Me.c1CommandLink74.SortOrder = 2
		' 
		' ccFormatBorderLeft
		' 
		Me.ccFormatBorderLeft.ImageIndex = 43
		Me.ccFormatBorderLeft.Name = "ccFormatBorderLeft"
		Me.ccFormatBorderLeft.ShortcutText = ""
		Me.ccFormatBorderLeft.Text = "Border left"
		' 
		' c1CommandLink75
		' 
		Me.c1CommandLink75.Command = Me.ccFormatBorderRight
		Me.c1CommandLink75.SortOrder = 3
		' 
		' ccFormatBorderRight
		' 
		Me.ccFormatBorderRight.ImageIndex = 44
		Me.ccFormatBorderRight.Name = "ccFormatBorderRight"
		Me.ccFormatBorderRight.ShortcutText = ""
		Me.ccFormatBorderRight.Text = "Border right"
		' 
		' ccStatesNormal
		' 
		Me.ccStatesNormal.ImageIndex = 13
		Me.ccStatesNormal.Name = "ccStatesNormal"
		Me.ccStatesNormal.ShortcutText = ""
		Me.ccStatesNormal.Text = "Normal"
		Me.ccStatesNormal.ToolTipText = "Normal state"
		' 
		' ccStatesDisabled
		' 
		Me.ccStatesDisabled.Enabled = False
		Me.ccStatesDisabled.Name = "ccStatesDisabled"
		Me.ccStatesDisabled.ShortcutText = ""
		Me.ccStatesDisabled.Text = "Disabled"
		Me.ccStatesDisabled.ToolTipText = "Disabled command"
		' 
		' ccStatesPressed
		' 
		Me.ccStatesPressed.Name = "ccStatesPressed"
		Me.ccStatesPressed.Pressed = True
		Me.ccStatesPressed.ShortcutText = ""
		Me.ccStatesPressed.Text = "Pressed"
		Me.ccStatesPressed.ToolTipText = "Pressed command"
		' 
		' ccStatesChecked
		' 
		Me.ccStatesChecked.Checked = True
		Me.ccStatesChecked.ImageIndex = 13
		Me.ccStatesChecked.Name = "ccStatesChecked"
		Me.ccStatesChecked.ShortcutText = ""
		Me.ccStatesChecked.Text = "Checked"
		Me.ccStatesChecked.ToolTipText = "Checked command"
		' 
		' ccmTheme
		' 
		Me.ccmTheme.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccmTheme.Name = "ccmTheme"
		Me.ccmTheme.ShortcutText = ""
		Me.ccmTheme.Text = "Theme: Office365White"
		Me.c1ThemeController1.SetTheme(Me.ccmTheme, "(default)")
		Me.ccmTheme.VisualStyle = C1.Win.Command.VisualStyle.[Custom]
		Me.ccmTheme.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue
		' 
		' cmmMain
		' 
		Me.cmmMain.AccessibleName = "Menu Bar"
		Me.cmmMain.CommandHolder = Me.cchMain
		Me.cmmMain.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink1, Me.c1CommandLink12, Me.c1CommandLink22, Me.c1CommandLink25, Me.c1CommandLink35, Me.c1CommandLink44})
		Me.cmmMain.Dock = System.Windows.Forms.DockStyle.Top
		Me.cmmMain.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.cmmMain.Location = New System.Drawing.Point(0, 0)
		Me.cmmMain.Name = "cmmMain"
		Me.cmmMain.Size = New System.Drawing.Size(1256, 25)
		Me.c1ThemeController1.SetTheme(Me.cmmMain, "(default)")
		' 
		' c1CommandLink1
		' 
		Me.c1CommandLink1.Command = Me.ccmFile
		' 
		' c1CommandLink12
		' 
		Me.c1CommandLink12.Command = Me.ccmEdit
		Me.c1CommandLink12.SortOrder = 1
		' 
		' c1CommandLink22
		' 
		Me.c1CommandLink22.Command = Me.ccmFormat
		Me.c1CommandLink22.SortOrder = 2
		' 
		' c1CommandLink25
		' 
		Me.c1CommandLink25.Command = Me.ccmC1TrueDBGrid
		Me.c1CommandLink25.SortOrder = 3
		' 
		' c1CommandLink35
		' 
		Me.c1CommandLink35.Command = Me.ccmC1FlexGrid
		Me.c1CommandLink35.SortOrder = 4
		' 
		' c1CommandLink44
		' 
		Me.c1CommandLink44.Command = Me.ccmC1Schedule
		Me.c1CommandLink44.SortOrder = 5
		' 
		' ccdTop
		' 
		Me.ccdTop.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(204)), CInt(CByte(0)))
		Me.ccdTop.Controls.Add(Me.ctbStates)
		Me.ccdTop.Controls.Add(Me.ctbFormat)
		Me.ccdTop.Controls.Add(Me.ctbEdit)
		Me.ccdTop.Controls.Add(Me.ctbFile)
		Me.ccdTop.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccdTop.ForeColor = System.Drawing.Color.Black
		Me.ccdTop.Id = 1
		Me.ccdTop.Location = New System.Drawing.Point(0, 25)
		Me.ccdTop.Name = "ccdTop"
		Me.ccdTop.Size = New System.Drawing.Size(1256, 72)
		Me.c1ThemeController1.SetTheme(Me.ccdTop, "(default)")
		' 
		' ctbStates
		' 
		Me.ctbStates.AccessibleName = "Tool Bar"
		Me.ctbStates.CommandHolder = Me.cchMain
		Me.ctbStates.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink76, Me.c1CommandLink77, Me.c1CommandLink78, Me.c1CommandLink79})
		Me.ctbStates.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ctbStates.Location = New System.Drawing.Point(923, 0)
		Me.ctbStates.Name = "ctbStates"
		Me.ctbStates.Size = New System.Drawing.Size(278, 26)
		Me.ctbStates.Text = "States"
		Me.c1ThemeController1.SetTheme(Me.ctbStates, "(default)")
		' 
		' c1CommandLink76
		' 
		Me.c1CommandLink76.ButtonLook = CType((C1.Win.Command.ButtonLookFlags.Text Or C1.Win.Command.ButtonLookFlags.Image), C1.Win.Command.ButtonLookFlags)
		Me.c1CommandLink76.Command = Me.ccStatesNormal
		' 
		' c1CommandLink77
		' 
		Me.c1CommandLink77.ButtonLook = C1.Win.Command.ButtonLookFlags.Text
		Me.c1CommandLink77.Command = Me.ccStatesDisabled
		Me.c1CommandLink77.SortOrder = 1
		' 
		' c1CommandLink78
		' 
		Me.c1CommandLink78.ButtonLook = CType((C1.Win.Command.ButtonLookFlags.Text Or C1.Win.Command.ButtonLookFlags.Image), C1.Win.Command.ButtonLookFlags)
		Me.c1CommandLink78.Command = Me.ccStatesPressed
		Me.c1CommandLink78.SortOrder = 2
		' 
		' c1CommandLink79
		' 
		Me.c1CommandLink79.ButtonLook = CType((C1.Win.Command.ButtonLookFlags.Text Or C1.Win.Command.ButtonLookFlags.Image), C1.Win.Command.ButtonLookFlags)
		Me.c1CommandLink79.Command = Me.ccStatesChecked
		Me.c1CommandLink79.SortOrder = 3
		' 
		' ctbFormat
		' 
		Me.ctbFormat.AccessibleName = "Tool Bar"
		Me.ctbFormat.CommandHolder = Me.cchMain
		Me.ctbFormat.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink69, Me.c1CommandLink70, Me.c1CommandLink61, Me.c1CommandLink62, Me.c1CommandLink63, Me.c1CommandLink64, _
			Me.c1CommandLink65, Me.c1CommandLink66, Me.c1CommandLink67, Me.c1CommandLink68, Me.c1CommandLink72})
		Me.ctbFormat.Controls.Add(Me.cddcFontName)
		Me.ctbFormat.Controls.Add(Me.cddcFontSize)
		Me.ctbFormat.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ctbFormat.Location = New System.Drawing.Point(391, 0)
		Me.ctbFormat.Name = "ctbFormat"
		Me.ctbFormat.Size = New System.Drawing.Size(531, 28)
		Me.ctbFormat.Text = "Format"
		Me.c1ThemeController1.SetTheme(Me.ctbFormat, "(default)")
		' 
		' c1CommandLink69
		' 
		Me.c1CommandLink69.Command = Me.cccFormatFontName
		' 
		' c1CommandLink70
		' 
		Me.c1CommandLink70.Command = Me.cccFormatFontSize
		Me.c1CommandLink70.SortOrder = 1
		' 
		' c1CommandLink61
		' 
		Me.c1CommandLink61.Command = Me.ccFormatFontBold
		Me.c1CommandLink61.Delimiter = True
		Me.c1CommandLink61.SortOrder = 2
		' 
		' c1CommandLink62
		' 
		Me.c1CommandLink62.Command = Me.ccFormatFontItalic
		Me.c1CommandLink62.SortOrder = 3
		' 
		' c1CommandLink63
		' 
		Me.c1CommandLink63.Command = Me.ccFormatFontUnderline
		Me.c1CommandLink63.SortOrder = 4
		' 
		' c1CommandLink64
		' 
		Me.c1CommandLink64.Command = Me.ccFormatFontStrikeout
		Me.c1CommandLink64.SortOrder = 5
		' 
		' c1CommandLink65
		' 
		Me.c1CommandLink65.Command = Me.ccFormatAlignLeft
		Me.c1CommandLink65.Delimiter = True
		Me.c1CommandLink65.SortOrder = 6
		Me.c1CommandLink65.Text = "New Command"
		' 
		' c1CommandLink66
		' 
		Me.c1CommandLink66.Command = Me.ccFormatAlignCenter
		Me.c1CommandLink66.SortOrder = 7
		Me.c1CommandLink66.Text = "New Command"
		' 
		' c1CommandLink67
		' 
		Me.c1CommandLink67.Command = Me.ccFormatAlignRight
		Me.c1CommandLink67.SortOrder = 8
		Me.c1CommandLink67.Text = "New Command"
		' 
		' c1CommandLink68
		' 
		Me.c1CommandLink68.Command = Me.ccFormatAlignJustify
		Me.c1CommandLink68.SortOrder = 9
		Me.c1CommandLink68.Text = "New Command"
		' 
		' c1CommandLink72
		' 
		Me.c1CommandLink72.Command = Me.ccmFormatBorders
		Me.c1CommandLink72.Delimiter = True
		Me.c1CommandLink72.SortOrder = 10
		Me.c1CommandLink72.Text = "New Command"
		' 
		' ctbEdit
		' 
		Me.ctbEdit.AccessibleName = "Tool Bar"
		Me.ctbEdit.CommandHolder = Me.cchMain
		Me.ctbEdit.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink55, Me.c1CommandLink56, Me.c1CommandLink57, Me.c1CommandLink58, Me.c1CommandLink59, Me.c1CommandLink60})
		Me.ctbEdit.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ctbEdit.Location = New System.Drawing.Point(233, 0)
		Me.ctbEdit.Name = "ctbEdit"
		Me.ctbEdit.Size = New System.Drawing.Size(160, 26)
		Me.ctbEdit.Text = "Edit"
		Me.c1ThemeController1.SetTheme(Me.ctbEdit, "(default)")
		' 
		' c1CommandLink55
		' 
		Me.c1CommandLink55.Command = Me.ccUndo
		' 
		' c1CommandLink56
		' 
		Me.c1CommandLink56.Command = Me.ccRedo
		Me.c1CommandLink56.SortOrder = 1
		' 
		' c1CommandLink57
		' 
		Me.c1CommandLink57.Command = Me.ccCut
		Me.c1CommandLink57.Delimiter = True
		Me.c1CommandLink57.SortOrder = 2
		' 
		' c1CommandLink58
		' 
		Me.c1CommandLink58.Command = Me.ccCopy
		Me.c1CommandLink58.SortOrder = 3
		' 
		' c1CommandLink59
		' 
		Me.c1CommandLink59.Command = Me.ccPaste
		Me.c1CommandLink59.SortOrder = 4
		' 
		' c1CommandLink60
		' 
		Me.c1CommandLink60.Command = Me.ccDelete
		Me.c1CommandLink60.SortOrder = 5
		' 
		' ctbFile
		' 
		Me.ctbFile.AccessibleName = "Tool Bar"
		Me.ctbFile.CommandHolder = Me.cchMain
		Me.ctbFile.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink80, Me.c1CommandLink51, Me.c1CommandLink52, Me.c1CommandLink53, Me.c1CommandLink54})
		Me.ctbFile.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ctbFile.Location = New System.Drawing.Point(2, 0)
		Me.ctbFile.Movable = False
		Me.ctbFile.Name = "ctbFile"
		Me.ctbFile.Size = New System.Drawing.Size(232, 26)
		Me.ctbFile.Text = "File"
		Me.c1ThemeController1.SetTheme(Me.ctbFile, "(default)")
		' 
		' c1CommandLink80
		' 
		Me.c1CommandLink80.ButtonLook = C1.Win.Command.ButtonLookFlags.Text
		Me.c1CommandLink80.Command = Me.ccmTheme
		' 
		' c1CommandLink51
		' 
		Me.c1CommandLink51.Command = Me.ccFileNewEmpty
		Me.c1CommandLink51.Delimiter = True
		Me.c1CommandLink51.SortOrder = 1
		' 
		' c1CommandLink52
		' 
		Me.c1CommandLink52.Command = Me.ccFileOpen
		Me.c1CommandLink52.SortOrder = 2
		' 
		' c1CommandLink53
		' 
		Me.c1CommandLink53.Command = Me.ccFileSave
		Me.c1CommandLink53.SortOrder = 3
		' 
		' c1CommandLink54
		' 
		Me.c1CommandLink54.Command = Me.ccFilePrint
		Me.c1CommandLink54.SortOrder = 4
		' 
		' ilMain
		' 
		Me.ilMain.ImageStream = DirectCast(resources.GetObject("ilMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ilMain.TransparentColor = System.Drawing.Color.Transparent
		Me.ilMain.Images.SetKeyName(0, "Small.png")
		Me.ilMain.Images.SetKeyName(1, "C1TrueDBGridSmall.png")
		Me.ilMain.Images.SetKeyName(2, "C1ScheduleSmall.png")
		Me.ilMain.Images.SetKeyName(3, "tree.png")
		Me.ilMain.Images.SetKeyName(4, "OutlineSubtotals.png")
		Me.ilMain.Images.SetKeyName(5, "Normal.png")
		Me.ilMain.Images.SetKeyName(6, "Inverted.png")
		Me.ilMain.Images.SetKeyName(7, "FormView.png")
		Me.ilMain.Images.SetKeyName(8, "GroupBy.png")
		Me.ilMain.Images.SetKeyName(9, "Multiline.png")
		Me.ilMain.Images.SetKeyName(10, "Hierarchical.png")
		Me.ilMain.Images.SetKeyName(11, "DailyView.png")
		Me.ilMain.Images.SetKeyName(12, "WorkWeek.png")
		Me.ilMain.Images.SetKeyName(13, "WeeklyView.png")
		Me.ilMain.Images.SetKeyName(14, "MonthlyView.png")
		Me.ilMain.Images.SetKeyName(15, "TimeScaleMenu.png")
		' 
		' c1NavBar1
		' 
		Me.c1NavBar1.AllowCollapse = True
		Me.c1NavBar1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(248)), CInt(CByte(200)))
		Me.c1NavBar1.ButtonFont = New System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold)
		Me.c1NavBar1.ButtonHeight = 28
		Me.c1NavBar1.ButtonMargins = New System.Windows.Forms.Padding(2)
		Me.c1NavBar1.Collapsed = False
		Me.c1NavBar1.Controls.Add(Me.c1NavBarPanel5)
		Me.c1NavBar1.Controls.Add(Me.c1NavBarPanel2)
		Me.c1NavBar1.Controls.Add(Me.c1NavBarPanel3)
		Me.c1NavBar1.Controls.Add(Me.c1NavBarPanel4)
		Me.c1NavBar1.Dock = System.Windows.Forms.DockStyle.Left
		Me.c1NavBar1.GripHeight = 5
		Me.c1NavBar1.GripMargins = New System.Windows.Forms.Padding(2)
		Me.c1NavBar1.Location = New System.Drawing.Point(0, 97)
		Me.c1NavBar1.Name = "c1NavBar1"
		Me.c1NavBar1.PanelHeaderFont = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1NavBar1.PanelHeaderHeight = 18
		Me.c1NavBar1.SectionHeaderFont = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1NavBar1.SectionHeaderHeight = 18
		Me.c1NavBar1.SectionHeaderIndent = 8
		Me.c1NavBar1.Size = New System.Drawing.Size(265, 637)
		Me.c1NavBar1.StackButtonCount = 3
		Me.c1NavBar1.StripHeight = 24
		Me.c1ThemeController1.SetTheme(Me.c1NavBar1, "(default)")
		Me.c1NavBar1.Theme.BorderColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(248)), CInt(CByte(200)))
		Me.c1NavBar1.Theme.ButtonCheckedForeColor = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(25)), CInt(CByte(56)))
		Me.c1NavBar1.Theme.ButtonHighlightedForeColor = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(25)), CInt(CByte(56)))
		Me.c1NavBar1.Theme.ButtonNormalForeColor = System.Drawing.Color.FromArgb(CInt(CByte(30)), CInt(CByte(57)), CInt(CByte(91)))
		Me.c1NavBar1.Theme.ButtonPressedForeColor = System.Drawing.Color.FromArgb(CInt(CByte(0)), CInt(CByte(25)), CInt(CByte(56)))
		Me.c1NavBar1.Theme.PanelHeaderForeColor = System.Drawing.Color.FromArgb(CInt(CByte(30)), CInt(CByte(57)), CInt(CByte(91)))
		Me.c1NavBar1.Theme.SectionHeaderForeColor = System.Drawing.Color.FromArgb(CInt(CByte(30)), CInt(CByte(57)), CInt(CByte(91)))
		Me.c1NavBar1.Theme.SeparatorLightColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(248)), CInt(CByte(200)))
		Me.c1NavBar1.Theme.SeparatorNormalColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(248)), CInt(CByte(200)))
		' 
		' c1NavBarPanel5
		' 
		Me.c1NavBarPanel5.Button.Image = DirectCast(resources.GetObject("resource.Image"), System.Drawing.Image)
		Me.c1NavBarPanel5.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CInt(CByte(238)), CInt(CByte(238)), CInt(CByte(238)))
		Me.c1NavBarPanel5.Button.SmallImage = DirectCast(resources.GetObject("resource.SmallImage"), System.Drawing.Image)
		Me.c1NavBarPanel5.Button.Text = "Mail"
		Me.c1NavBarPanel5.Controls.Add(Me.ctbMain)
		Me.c1NavBarPanel5.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1NavBarPanel5.ForeColor = System.Drawing.Color.Black
		Me.c1NavBarPanel5.ID = 5
		Me.c1NavBarPanel5.Name = "c1NavBarPanel5"
		Me.c1NavBarPanel5.Size = New System.Drawing.Size(263, 487)
		Me.c1ThemeController1.SetTheme(Me.c1NavBarPanel5, "(default)")
		' 
		' ctbMain
		' 
		Me.ctbMain.AutoScrollMinSize = New System.Drawing.Size(0, 282)
		Me.ctbMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ctbMain.ImageList = Me.ilMain2
		Me.ctbMain.Location = New System.Drawing.Point(0, 0)
		Me.ctbMain.Name = "ctbMain"
		Me.ctbMain.Padding = New System.Windows.Forms.Padding(10)
		Me.ctbMain.PagePadding = New System.Windows.Forms.Padding(10)
		c1TopicPage3.ImageList = Me.ilMain2
		c1TopicLink10.ImageIndex = 1
		c1TopicLink10.Text = "Inbox"
		c1TopicLink11.ImageIndex = 2
		c1TopicLink11.Text = "Drafts"
		c1TopicLink12.ImageIndex = 3
		c1TopicLink12.Text = "Sent"
		c1TopicLink13.ImageIndex = 4
		c1TopicLink13.Text = "Trash"
		c1TopicLink14.ImageIndex = 6
		c1TopicLink14.Text = "Outbox"
		c1TopicLink15.Enabled = False
		c1TopicLink15.ImageIndex = 7
		c1TopicLink15.Text = "SPAM (disabled)"
		c1TopicPage3.Links.Add(c1TopicLink10)
		c1TopicPage3.Links.Add(c1TopicLink11)
		c1TopicPage3.Links.Add(c1TopicLink12)
		c1TopicPage3.Links.Add(c1TopicLink13)
		c1TopicPage3.Links.Add(c1TopicLink14)
		c1TopicPage3.Links.Add(c1TopicLink15)
		c1TopicPage3.Text = "All folders"
		c1TopicPage4.ImageIndex = 0
		c1TopicPage4.ImageList = Me.ilMain2
		c1TopicLink16.ImageIndex = 1
		c1TopicLink16.Text = "Inbox"
		c1TopicLink17.ImageIndex = 3
		c1TopicLink17.Text = "Sent"
		c1TopicLink18.ImageIndex = 4
		c1TopicLink18.Text = "Trash"
		c1TopicPage4.Links.Add(c1TopicLink16)
		c1TopicPage4.Links.Add(c1TopicLink17)
		c1TopicPage4.Links.Add(c1TopicLink18)
		c1TopicPage4.SpecialStyle = True
		c1TopicPage4.Text = "Favorites"
		Me.ctbMain.Pages.Add(c1TopicPage3)
		Me.ctbMain.Pages.Add(c1TopicPage4)
		Me.ctbMain.Size = New System.Drawing.Size(263, 487)
		Me.c1ThemeController1.SetTheme(Me.ctbMain, "(default)")
		' 
		' c1NavBarPanel2
		' 
		Me.c1NavBarPanel2.Button.Image = DirectCast(resources.GetObject("resource.Image1"), System.Drawing.Image)
		Me.c1NavBarPanel2.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CInt(CByte(238)), CInt(CByte(238)), CInt(CByte(238)))
		Me.c1NavBarPanel2.Button.SmallImage = DirectCast(resources.GetObject("resource.SmallImage1"), System.Drawing.Image)
		Me.c1NavBarPanel2.Button.Text = "Calendar"
		Me.c1NavBarPanel2.Controls.Add(Me.c1Calendar1)
		Me.c1NavBarPanel2.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1NavBarPanel2.ForeColor = System.Drawing.Color.Black
		Me.c1NavBarPanel2.ID = 2
		Me.c1NavBarPanel2.Name = "c1NavBarPanel2"
		Me.c1NavBarPanel2.Size = New System.Drawing.Size(263, 487)
		Me.c1ThemeController1.SetTheme(Me.c1NavBarPanel2, "(default)")
		' 
		' c1Calendar1
		' 
		Me.c1Calendar1.BoldedDates = New System.DateTime(-1) {}
		Me.c1Calendar1.CalendarDimensions = 2
        ' 
        ' 
        ' 
        Me.c1Calendar1.CalendarInfo.DateFormatString = "dd.MM.yyyy"
        Me.c1Calendar1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00")
		Me.c1Calendar1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00")
		Me.c1Calendar1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00")
		Me.c1Calendar1.CalendarInfo.WeekStart = System.DayOfWeek.Monday
		Me.c1Calendar1.CalendarInfo.WorkDays.AddRange(New System.DayOfWeek() {System.DayOfWeek.Monday, System.DayOfWeek.Tuesday, System.DayOfWeek.Wednesday, System.DayOfWeek.Thursday, System.DayOfWeek.Friday})
		Me.c1Calendar1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.c1Calendar1.Location = New System.Drawing.Point(0, 0)
		Me.c1Calendar1.Name = "c1Calendar1"
		Me.c1Calendar1.Size = New System.Drawing.Size(263, 487)
		Me.c1Calendar1.TabIndex = 0
		Me.c1ThemeController1.SetTheme(Me.c1Calendar1, "(default)")
		Me.c1Calendar1.VisualStyle = C1.Win.Schedule.UI.VisualStyle.[Custom]
		' 
		' c1NavBarPanel3
		' 
		Me.c1NavBarPanel3.Button.Image = DirectCast(resources.GetObject("resource.Image2"), System.Drawing.Image)
		Me.c1NavBarPanel3.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CInt(CByte(238)), CInt(CByte(238)), CInt(CByte(238)))
		Me.c1NavBarPanel3.Button.SmallImage = DirectCast(resources.GetObject("resource.SmallImage2"), System.Drawing.Image)
		Me.c1NavBarPanel3.Button.Text = "Contacts"
		Me.c1NavBarPanel3.Controls.Add(Me.label1)
		Me.c1NavBarPanel3.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1NavBarPanel3.ForeColor = System.Drawing.Color.Black
		Me.c1NavBarPanel3.ID = 3
		Me.c1NavBarPanel3.Name = "c1NavBarPanel3"
		Me.c1NavBarPanel3.Size = New System.Drawing.Size(263, 487)
		Me.c1ThemeController1.SetTheme(Me.c1NavBarPanel3, "(default)")
		' 
		' label1
		' 
		Me.label1.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.label1.ForeColor = System.Drawing.Color.Black
		Me.label1.Location = New System.Drawing.Point(59, 165)
		Me.label1.Name = "label1"
		Me.label1.Size = New System.Drawing.Size(125, 30)
		Me.label1.TabIndex = 0
		Me.label1.Text = "Empty C1NavBar panel in a C1NavBar container"
		Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.c1ThemeController1.SetTheme(Me.label1, "(default)")
		Me.label1.UseCompatibleTextRendering = True
		' 
		' c1NavBarPanel4
		' 
		Me.c1NavBarPanel4.Button.Image = DirectCast(resources.GetObject("resource.Image3"), System.Drawing.Image)
		Me.c1NavBarPanel4.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CInt(CByte(238)), CInt(CByte(238)), CInt(CByte(238)))
		Me.c1NavBarPanel4.Button.SmallImage = DirectCast(resources.GetObject("resource.SmallImage3"), System.Drawing.Image)
		Me.c1NavBarPanel4.Button.Text = "Tasks"
		Me.c1NavBarPanel4.Controls.Add(Me.label2)
		Me.c1NavBarPanel4.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1NavBarPanel4.ForeColor = System.Drawing.Color.Black
		Me.c1NavBarPanel4.ID = 4
		Me.c1NavBarPanel4.Name = "c1NavBarPanel4"
		Me.c1NavBarPanel4.Size = New System.Drawing.Size(263, 487)
		Me.c1ThemeController1.SetTheme(Me.c1NavBarPanel4, "(default)")
		' 
		' label2
		' 
		Me.label2.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.label2.ForeColor = System.Drawing.Color.Black
		Me.label2.Location = New System.Drawing.Point(64, 167)
		Me.label2.Name = "label2"
		Me.label2.Size = New System.Drawing.Size(125, 30)
		Me.label2.TabIndex = 1
		Me.label2.Text = "Empty C1NavBar panel in a C1NavBar container"
		Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.c1ThemeController1.SetTheme(Me.label2, "(default)")
		Me.label2.UseCompatibleTextRendering = True
		' 
		' c1CommandDock1
		' 
		Me.c1CommandDock1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(204)), CInt(CByte(0)))
		Me.c1CommandDock1.Controls.Add(Me.c1DockingTab1)
		Me.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Right
		Me.c1CommandDock1.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1CommandDock1.ForeColor = System.Drawing.Color.Black
		Me.c1CommandDock1.Id = 1
		Me.c1CommandDock1.Location = New System.Drawing.Point(980, 97)
		Me.c1CommandDock1.Name = "c1CommandDock1"
		Me.c1CommandDock1.Size = New System.Drawing.Size(276, 637)
		Me.c1ThemeController1.SetTheme(Me.c1CommandDock1, "(default)")
		' 
		' c1DockingTab1
		' 
		Me.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom
		Me.c1DockingTab1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(252)), CInt(CByte(238)), CInt(CByte(194)))
		Me.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.c1DockingTab1.CanAutoHide = True
		Me.c1DockingTab1.CanCloseTabs = True
		Me.c1DockingTab1.CanMoveTabs = True
		Me.c1DockingTab1.Controls.Add(Me.c1DockingTabPage1)
		Me.c1DockingTab1.Controls.Add(Me.c1DockingTabPage2)
		Me.c1DockingTab1.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1DockingTab1.ImageList = Me.ilMain2
		Me.c1DockingTab1.Location = New System.Drawing.Point(0, 0)
		Me.c1DockingTab1.Name = "c1DockingTab1"
		Me.c1DockingTab1.ShowCaption = True
		Me.c1DockingTab1.Size = New System.Drawing.Size(276, 637)
		Me.c1DockingTab1.TabIndex = 0
		Me.c1DockingTab1.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit
		Me.c1DockingTab1.TabsSpacing = 7
		Me.c1DockingTab1.TabStyle = C1.Win.Command.TabStyleEnum.Office2007
		Me.c1ThemeController1.SetTheme(Me.c1DockingTab1, "(default)")
		' 
		' c1DockingTabPage1
		' 
		Me.c1DockingTabPage1.CaptionVisible = True
		Me.c1DockingTabPage1.Controls.Add(Me.c1OutBar1)
		Me.c1DockingTabPage1.ImageIndex = 12
		Me.c1DockingTabPage1.Location = New System.Drawing.Point(3, 0)
		Me.c1DockingTabPage1.Name = "c1DockingTabPage1"
		Me.c1DockingTabPage1.Size = New System.Drawing.Size(273, 611)
		Me.c1DockingTabPage1.TabIndex = 0
		Me.c1DockingTabPage1.Text = "Settings"
		' 
		' c1OutBar1
		' 
		Me.c1OutBar1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(102)), CInt(CByte(100)), CInt(CByte(100)))
		Me.c1OutBar1.Controls.Add(Me.copC1FlexGrid)
		Me.c1OutBar1.Controls.Add(Me.copC1TrueDBGrid)
		Me.c1OutBar1.Controls.Add(Me.copC1Schedule)
		Me.c1OutBar1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.c1OutBar1.Font = New System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold)
		Me.c1OutBar1.ForeColor = System.Drawing.Color.FromArgb(CInt(CByte(64)), CInt(CByte(64)), CInt(CByte(64)))
		Me.c1OutBar1.ImageList = Me.ilMain
		Me.c1OutBar1.Location = New System.Drawing.Point(0, 22)
		Me.c1OutBar1.Name = "c1OutBar1"
		Me.c1OutBar1.PageTitleHeight = 28
		Me.c1OutBar1.Size = New System.Drawing.Size(273, 589)
		Me.c1ThemeController1.SetTheme(Me.c1OutBar1, "(default)")
		' 
		' copC1FlexGrid
		' 
		Me.copC1FlexGrid.Controls.Add(Me.ctbC1FlexGrid)
        Me.copC1FlexGrid.Controls.Add(Me.tableLayoutPanel1)
        Me.copC1FlexGrid.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.copC1FlexGrid.ForeColor = System.Drawing.Color.Black
		Me.copC1FlexGrid.ImageIndex = 0
		Me.copC1FlexGrid.Name = "copC1FlexGrid"
		Me.copC1FlexGrid.Size = New System.Drawing.Size(273, 505)
		Me.copC1FlexGrid.Text = "C1FlexGrid"
		Me.c1ThemeController1.SetTheme(Me.copC1FlexGrid, "(default)")
		' 
		' ctbC1FlexGrid
		' 
		Me.ctbC1FlexGrid.AccessibleName = "Tool Bar"
		Me.ctbC1FlexGrid.AutoSize = False
		Me.ctbC1FlexGrid.ButtonLookVert = CType((C1.Win.Command.ButtonLookFlags.Text Or C1.Win.Command.ButtonLookFlags.Image), C1.Win.Command.ButtonLookFlags)
		Me.ctbC1FlexGrid.CommandHolder = Me.cchMain
		Me.ctbC1FlexGrid.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink81, Me.c1CommandLink82, Me.c1CommandLink83})
		Me.ctbC1FlexGrid.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ctbC1FlexGrid.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ctbC1FlexGrid.Horizontal = False
		Me.ctbC1FlexGrid.Location = New System.Drawing.Point(0, 0)
		Me.ctbC1FlexGrid.Movable = False
		Me.ctbC1FlexGrid.Name = "ctbC1FlexGrid"
		Me.ctbC1FlexGrid.Size = New System.Drawing.Size(273, 345)
		Me.ctbC1FlexGrid.Text = "C1FlexGrid"
		Me.c1ThemeController1.SetTheme(Me.ctbC1FlexGrid, "(default)")
		' 
		' c1CommandLink81
		' 
		Me.c1CommandLink81.Command = Me.ccCFGViewNormal
		' 
		' c1CommandLink82
		' 
		Me.c1CommandLink82.Command = Me.ccCFGViewTree
		Me.c1CommandLink82.SortOrder = 1
		' 
		' c1CommandLink83
		' 
		Me.c1CommandLink83.Command = Me.ccCFGViewSubtotals
		Me.c1CommandLink83.SortOrder = 2
        ' 
        ' tableLayoutPanel1
        ' 
        Me.tableLayoutPanel1.ColumnCount = 2
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
        Me.tableLayoutPanel1.Controls.Add(Me.csbFocusRect, 1, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.ccbShowCursor, 0, 4)
        Me.tableLayoutPanel1.Controls.Add(Me.csbSelectionMode, 1, 2)
        Me.tableLayoutPanel1.Controls.Add(Me.c1Label1, 0, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.cneFixedRowCount, 1, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.c1Label4, 0, 3)
        Me.tableLayoutPanel1.Controls.Add(Me.cneFixedColCount, 1, 0)
        Me.tableLayoutPanel1.Controls.Add(Me.c1Label2, 0, 1)
        Me.tableLayoutPanel1.Controls.Add(Me.c1Label3, 0, 2)
        Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 296)
        Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
        Me.tableLayoutPanel1.RowCount = 5
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tableLayoutPanel1.Size = New System.Drawing.Size(240, 184)
        Me.tableLayoutPanel1.TabIndex = 2
        Me.c1ThemeController1.SetTheme(Me.tableLayoutPanel1, "(default)")

        ' 
        ' c1Label4
        ' 
        Me.c1Label4.AutoSize = True
		Me.c1Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.c1Label4.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1Label4.ForeColor = System.Drawing.Color.Black
		Me.c1Label4.Location = New System.Drawing.Point(3, 102)
		Me.c1Label4.Name = "c1Label4"
		Me.c1Label4.Size = New System.Drawing.Size(68, 13)
		Me.c1Label4.TabIndex = 13
		Me.c1Label4.Tag = Nothing
		Me.c1Label4.Text = "Focus rect:"
		Me.c1Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.c1Label4.TextDetached = True
		Me.c1ThemeController1.SetTheme(Me.c1Label4, "(default)")
		' 
		' c1Label3
		' 
		Me.c1Label3.AutoSize = True
		Me.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.c1Label3.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1Label3.ForeColor = System.Drawing.Color.Black
		Me.c1Label3.Location = New System.Drawing.Point(3, 73)
		Me.c1Label3.Name = "c1Label3"
		Me.c1Label3.Size = New System.Drawing.Size(95, 13)
		Me.c1Label3.TabIndex = 12
		Me.c1Label3.Tag = Nothing
		Me.c1Label3.Text = "Selection mode:"
		Me.c1Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.c1Label3.TextDetached = True
		Me.c1ThemeController1.SetTheme(Me.c1Label3, "(default)")
        ' 
        ' csbFocusRect
        ' 
        Me.csbFocusRect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.csbFocusRect.Location = New System.Drawing.Point(94, 94)
        Me.csbFocusRect.Margin = New System.Windows.Forms.Padding(5)
        Me.csbFocusRect.Name = "csbFocusRect"
        Me.csbFocusRect.Size = New System.Drawing.Size(141, 23)
        Me.csbFocusRect.TabIndex = 6
        Me.csbFocusRect.Text = "c1SplitButton1"
        Me.c1ThemeController1.SetTheme(Me.csbFocusRect, "(default)")
        Me.csbFocusRect.UseVisualStyleBackColor = True
        AddHandler Me.csbFocusRect.DropDownItemClicked, New C1.Win.C1Input.DropDownItemClickedEventHandler(AddressOf Me.csbFocusRect_DropDownItemClicked)
        ' 
        ' csbSelectionMode
        ' 
        Me.csbSelectionMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.csbSelectionMode.Location = New System.Drawing.Point(94, 61)
        Me.csbSelectionMode.Margin = New System.Windows.Forms.Padding(5)
        Me.csbSelectionMode.Name = "csbSelectionMode"
        Me.csbSelectionMode.Size = New System.Drawing.Size(141, 23)
        Me.csbSelectionMode.TabIndex = 4
        Me.csbSelectionMode.Text = "c1SplitButton1"
        Me.csbSelectionMode.UseVisualStyleBackColor = True
        Me.c1ThemeController1.SetTheme(Me.csbSelectionMode, "(default)")
        AddHandler Me.csbSelectionMode.DropDownItemClicked, New C1.Win.C1Input.DropDownItemClickedEventHandler(AddressOf Me.csbSelectionMode_DropDownItemClicked)
		' 
		' ccbShowCursor
		' 
		Me.ccbShowCursor.AutoSize = True
		Me.ccbShowCursor.BackColor = System.Drawing.Color.Transparent
		Me.ccbShowCursor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ccbShowCursor.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccbShowCursor.ForeColor = System.Drawing.Color.Black
		Me.ccbShowCursor.Location = New System.Drawing.Point(4, 140)
		Me.ccbShowCursor.Name = "ccbShowCursor"
		Me.ccbShowCursor.Padding = New System.Windows.Forms.Padding(4, 1, 1, 1)
		Me.ccbShowCursor.Size = New System.Drawing.Size(95, 19)
		Me.ccbShowCursor.TabIndex = 9
		Me.ccbShowCursor.Text = "Show cursor"
		Me.c1ThemeController1.SetTheme(Me.ccbShowCursor, "(default)")
		Me.ccbShowCursor.UseVisualStyleBackColor = False
		Me.ccbShowCursor.Value = Nothing
		Me.ccbShowCursor.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
		AddHandler Me.ccbShowCursor.CheckedChanged, New System.EventHandler(AddressOf Me.ccbShowCursor_CheckedChanged)
		' 
		' c1Label2
		' 
		Me.c1Label2.AutoSize = True
		Me.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.c1Label2.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1Label2.ForeColor = System.Drawing.Color.Black
		Me.c1Label2.Location = New System.Drawing.Point(3, 37)
		Me.c1Label2.Name = "c1Label2"
		Me.c1Label2.Size = New System.Drawing.Size(99, 13)
		Me.c1Label2.TabIndex = 7
		Me.c1Label2.Tag = Nothing
		Me.c1Label2.Text = "Fixed row count:"
		Me.c1Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.c1Label2.TextDetached = True
		Me.c1ThemeController1.SetTheme(Me.c1Label2, "(default)")
        ' 
        ' cneFixedRowCount
        ' 
        Me.cneFixedRowCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cneFixedRowCount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.cneFixedRowCount.ImageTransparentColor = System.Drawing.Color.Empty
        Me.cneFixedRowCount.Location = New System.Drawing.Point(94, 33)
        Me.cneFixedRowCount.Margin = New System.Windows.Forms.Padding(5)
        Me.cneFixedRowCount.Name = "cneFixedRowCount"
        Me.cneFixedRowCount.Size = New System.Drawing.Size(159, 18)
        Me.cneFixedRowCount.TabIndex = 2
        Me.cneFixedRowCount.Tag = Nothing
        Me.c1ThemeController1.SetTheme(Me.cneFixedRowCount, "(default)")
        Me.cneFixedRowCount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        AddHandler Me.cneFixedRowCount.ValueChanged, New System.EventHandler(AddressOf Me.cneFixedRowCount_ValueChanged)
        ' 
        ' cneFixedColCount
        ' 
        Me.cneFixedColCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cneFixedColCount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.cneFixedColCount.ImageTransparentColor = System.Drawing.Color.Empty
        Me.cneFixedColCount.Location = New System.Drawing.Point(94, 5)
        Me.cneFixedColCount.Margin = New System.Windows.Forms.Padding(5)
        Me.cneFixedColCount.Name = "cneFixedColCount"
        Me.cneFixedColCount.Size = New System.Drawing.Size(159, 18)
        Me.cneFixedColCount.TabIndex = 1
        Me.cneFixedColCount.Tag = Nothing
        Me.c1ThemeController1.SetTheme(Me.cneFixedColCount, "(default)")
        Me.cneFixedColCount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        AddHandler Me.cneFixedColCount.ValueChanged, New System.EventHandler(AddressOf Me.cneFixedColCount_ValueChanged)
		' 
		' c1Label1
		' 
		Me.c1Label1.AutoSize = True
		Me.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.c1Label1.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1Label1.ForeColor = System.Drawing.Color.Black
		Me.c1Label1.Location = New System.Drawing.Point(3, 9)
		Me.c1Label1.Name = "c1Label1"
		Me.c1Label1.Size = New System.Drawing.Size(117, 13)
		Me.c1Label1.TabIndex = 4
		Me.c1Label1.Tag = Nothing
		Me.c1Label1.Text = "Fixed column count:"
		Me.c1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.c1Label1.TextDetached = True
		Me.c1ThemeController1.SetTheme(Me.c1Label1, "(default)")
		' 
		' copC1TrueDBGrid
		' 
		Me.copC1TrueDBGrid.Controls.Add(Me.ctbC1TrueDBGridView)
		Me.copC1TrueDBGrid.Controls.Add(Me.panel2)
		Me.copC1TrueDBGrid.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.copC1TrueDBGrid.ForeColor = System.Drawing.Color.Black
		Me.copC1TrueDBGrid.ImageIndex = 1
		Me.copC1TrueDBGrid.Name = "copC1TrueDBGrid"
		Me.copC1TrueDBGrid.Size = New System.Drawing.Size(273, 505)
		Me.copC1TrueDBGrid.Text = "C1TrueDBGrid"
		Me.c1ThemeController1.SetTheme(Me.copC1TrueDBGrid, "(default)")
		' 
		' ctbC1TrueDBGridView
		' 
		Me.ctbC1TrueDBGridView.AccessibleName = "Tool Bar"
		Me.ctbC1TrueDBGridView.AutoSize = False
		Me.ctbC1TrueDBGridView.ButtonLookVert = CType((C1.Win.Command.ButtonLookFlags.Text Or C1.Win.Command.ButtonLookFlags.Image), C1.Win.Command.ButtonLookFlags)
		Me.ctbC1TrueDBGridView.CommandHolder = Me.cchMain
		Me.ctbC1TrueDBGridView.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink84, Me.c1CommandLink85, Me.c1CommandLink86, Me.c1CommandLink87, Me.c1CommandLink88, Me.c1CommandLink89})
		Me.ctbC1TrueDBGridView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ctbC1TrueDBGridView.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ctbC1TrueDBGridView.Horizontal = False
		Me.ctbC1TrueDBGridView.Location = New System.Drawing.Point(0, 0)
		Me.ctbC1TrueDBGridView.Movable = False
		Me.ctbC1TrueDBGridView.Name = "ctbC1TrueDBGridView"
		Me.ctbC1TrueDBGridView.Size = New System.Drawing.Size(273, 449)
		Me.ctbC1TrueDBGridView.Text = "Page1"
		Me.c1ThemeController1.SetTheme(Me.ctbC1TrueDBGridView, "(default)")
		' 
		' c1CommandLink84
		' 
		Me.c1CommandLink84.Command = Me.ccCTDBGViewNormal
		' 
		' c1CommandLink85
		' 
		Me.c1CommandLink85.Command = Me.ccCTDBGViewInverted
		Me.c1CommandLink85.SortOrder = 1
		' 
		' c1CommandLink86
		' 
		Me.c1CommandLink86.Command = Me.ccCTDBGViewForm
		Me.c1CommandLink86.SortOrder = 2
		' 
		' c1CommandLink87
		' 
		Me.c1CommandLink87.Command = Me.ccCTDBGViewGroupBy
		Me.c1CommandLink87.SortOrder = 3
		' 
		' c1CommandLink88
		' 
		Me.c1CommandLink88.Command = Me.ccCTDBGViewMultipleLines
		Me.c1CommandLink88.SortOrder = 4
		' 
		' c1CommandLink89
		' 
		Me.c1CommandLink89.Command = Me.ccCTDBGViewHierarchical
		Me.c1CommandLink89.SortOrder = 5
		' 
		' panel2
		' 
		Me.panel2.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(204)), CInt(CByte(0)))
		Me.panel2.Controls.Add(Me.ccbCTDBGShowFilterBar)
		Me.panel2.Controls.Add(Me.ccbCTDBGShowCaption)
		Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.panel2.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.panel2.ForeColor = System.Drawing.Color.Black
		Me.panel2.Location = New System.Drawing.Point(0, 449)
		Me.panel2.Name = "panel2"
		Me.panel2.Size = New System.Drawing.Size(273, 56)
		Me.panel2.TabIndex = 3
		Me.c1ThemeController1.SetTheme(Me.panel2, "(default)")
		' 
		' ccbCTDBGShowFilterBar
		' 
		Me.ccbCTDBGShowFilterBar.AutoSize = True
		Me.ccbCTDBGShowFilterBar.BackColor = System.Drawing.Color.Transparent
		Me.ccbCTDBGShowFilterBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ccbCTDBGShowFilterBar.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccbCTDBGShowFilterBar.ForeColor = System.Drawing.Color.Black
		Me.ccbCTDBGShowFilterBar.Location = New System.Drawing.Point(3, 26)
		Me.ccbCTDBGShowFilterBar.Name = "ccbCTDBGShowFilterBar"
		Me.ccbCTDBGShowFilterBar.Padding = New System.Windows.Forms.Padding(4, 1, 1, 1)
		Me.ccbCTDBGShowFilterBar.Size = New System.Drawing.Size(107, 19)
		Me.ccbCTDBGShowFilterBar.TabIndex = 1
		Me.ccbCTDBGShowFilterBar.Text = "Show filter bar"
		Me.c1ThemeController1.SetTheme(Me.ccbCTDBGShowFilterBar, "(default)")
		Me.ccbCTDBGShowFilterBar.UseVisualStyleBackColor = False
		Me.ccbCTDBGShowFilterBar.Value = Nothing
		Me.ccbCTDBGShowFilterBar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
		AddHandler Me.ccbCTDBGShowFilterBar.CheckedChanged, New System.EventHandler(AddressOf Me.ccbCTDBGShowFilterBar_CheckedChanged)
		' 
		' ccbCTDBGShowCaption
		' 
		Me.ccbCTDBGShowCaption.AutoSize = True
		Me.ccbCTDBGShowCaption.BackColor = System.Drawing.Color.Transparent
		Me.ccbCTDBGShowCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ccbCTDBGShowCaption.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccbCTDBGShowCaption.ForeColor = System.Drawing.Color.Black
		Me.ccbCTDBGShowCaption.Location = New System.Drawing.Point(3, 3)
		Me.ccbCTDBGShowCaption.Name = "ccbCTDBGShowCaption"
		Me.ccbCTDBGShowCaption.Padding = New System.Windows.Forms.Padding(4, 1, 1, 1)
		Me.ccbCTDBGShowCaption.Size = New System.Drawing.Size(102, 19)
		Me.ccbCTDBGShowCaption.TabIndex = 0
		Me.ccbCTDBGShowCaption.Text = "Show caption"
		Me.c1ThemeController1.SetTheme(Me.ccbCTDBGShowCaption, "(default)")
		Me.ccbCTDBGShowCaption.UseVisualStyleBackColor = False
		Me.ccbCTDBGShowCaption.Value = Nothing
		Me.ccbCTDBGShowCaption.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
		AddHandler Me.ccbCTDBGShowCaption.CheckedChanged, New System.EventHandler(AddressOf Me.ccbCTDBGShowCaption_CheckedChanged)
		' 
		' copC1Schedule
		' 
		Me.copC1Schedule.Controls.Add(Me.ctbC1ScheduleView)
		Me.copC1Schedule.Controls.Add(Me.panel3)
		Me.copC1Schedule.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.copC1Schedule.ForeColor = System.Drawing.Color.Black
		Me.copC1Schedule.ImageIndex = 2
		Me.copC1Schedule.Name = "copC1Schedule"
		Me.copC1Schedule.Size = New System.Drawing.Size(273, 477)
		Me.copC1Schedule.Text = "C1Schedule"
		Me.c1ThemeController1.SetTheme(Me.copC1Schedule, "(default)")
		' 
		' ctbC1ScheduleView
		' 
		Me.ctbC1ScheduleView.AccessibleName = "Tool Bar"
		Me.ctbC1ScheduleView.AutoSize = False
		Me.ctbC1ScheduleView.ButtonLookVert = CType((C1.Win.Command.ButtonLookFlags.Text Or C1.Win.Command.ButtonLookFlags.Image), C1.Win.Command.ButtonLookFlags)
		Me.ctbC1ScheduleView.CommandHolder = Me.cchMain
		Me.ctbC1ScheduleView.CommandLinks.AddRange(New C1.Win.Command.C1CommandLink() {Me.c1CommandLink90, Me.c1CommandLink91, Me.c1CommandLink92, Me.c1CommandLink93, Me.c1CommandLink94})
		Me.ctbC1ScheduleView.Dock = System.Windows.Forms.DockStyle.Fill
		Me.ctbC1ScheduleView.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ctbC1ScheduleView.Horizontal = False
		Me.ctbC1ScheduleView.Location = New System.Drawing.Point(0, 0)
		Me.ctbC1ScheduleView.Movable = False
		Me.ctbC1ScheduleView.Name = "ctbC1ScheduleView"
		Me.ctbC1ScheduleView.Size = New System.Drawing.Size(273, 421)
		Me.ctbC1ScheduleView.Text = "Page1"
		Me.c1ThemeController1.SetTheme(Me.ctbC1ScheduleView, "(default)")
		' 
		' c1CommandLink90
		' 
		Me.c1CommandLink90.Command = Me.ccCSViewDay
		' 
		' c1CommandLink91
		' 
		Me.c1CommandLink91.Command = Me.ccCSViewWorkWeek
		Me.c1CommandLink91.SortOrder = 1
		' 
		' c1CommandLink92
		' 
		Me.c1CommandLink92.Command = Me.ccCSViewWeek
		Me.c1CommandLink92.SortOrder = 2
		' 
		' c1CommandLink93
		' 
		Me.c1CommandLink93.Command = Me.ccCSViewMonth
		Me.c1CommandLink93.SortOrder = 3
		' 
		' c1CommandLink94
		' 
		Me.c1CommandLink94.Command = Me.ccCSViewTimeLine
		Me.c1CommandLink94.SortOrder = 4
		' 
		' panel3
		' 
		Me.panel3.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(204)), CInt(CByte(0)))
		Me.panel3.Controls.Add(Me.ccbCSOffice2003WeekView)
		Me.panel3.Controls.Add(Me.ccbCSEnableGrouping)
		Me.panel3.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.panel3.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.panel3.ForeColor = System.Drawing.Color.Black
		Me.panel3.Location = New System.Drawing.Point(0, 421)
		Me.panel3.Name = "panel3"
		Me.panel3.Size = New System.Drawing.Size(273, 56)
		Me.panel3.TabIndex = 3
		Me.c1ThemeController1.SetTheme(Me.panel3, "(default)")
		' 
		' ccbCSOffice2003WeekView
		' 
		Me.ccbCSOffice2003WeekView.AutoSize = True
		Me.ccbCSOffice2003WeekView.BackColor = System.Drawing.Color.Transparent
		Me.ccbCSOffice2003WeekView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ccbCSOffice2003WeekView.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccbCSOffice2003WeekView.ForeColor = System.Drawing.Color.Black
		Me.ccbCSOffice2003WeekView.Location = New System.Drawing.Point(3, 26)
		Me.ccbCSOffice2003WeekView.Name = "ccbCSOffice2003WeekView"
		Me.ccbCSOffice2003WeekView.Padding = New System.Windows.Forms.Padding(4, 1, 1, 1)
		Me.ccbCSOffice2003WeekView.Size = New System.Drawing.Size(149, 19)
		Me.ccbCSOffice2003WeekView.TabIndex = 1
		Me.ccbCSOffice2003WeekView.Text = "Office 2003 Week View"
		Me.c1ThemeController1.SetTheme(Me.ccbCSOffice2003WeekView, "(default)")
		Me.ccbCSOffice2003WeekView.UseVisualStyleBackColor = False
		Me.ccbCSOffice2003WeekView.Value = Nothing
		Me.ccbCSOffice2003WeekView.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
		AddHandler Me.ccbCSOffice2003WeekView.CheckedChanged, New System.EventHandler(AddressOf Me.ccbCSOffice2003WeekView_CheckedChanged)
		' 
		' ccbCSEnableGrouping
		' 
		Me.ccbCSEnableGrouping.AutoSize = True
		Me.ccbCSEnableGrouping.BackColor = System.Drawing.Color.Transparent
		Me.ccbCSEnableGrouping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.ccbCSEnableGrouping.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ccbCSEnableGrouping.ForeColor = System.Drawing.Color.Black
		Me.ccbCSEnableGrouping.Location = New System.Drawing.Point(3, 3)
		Me.ccbCSEnableGrouping.Name = "ccbCSEnableGrouping"
		Me.ccbCSEnableGrouping.Padding = New System.Windows.Forms.Padding(4, 1, 1, 1)
		Me.ccbCSEnableGrouping.Size = New System.Drawing.Size(119, 19)
		Me.ccbCSEnableGrouping.TabIndex = 0
		Me.ccbCSEnableGrouping.Text = "Enable Grouping"
		Me.c1ThemeController1.SetTheme(Me.ccbCSEnableGrouping, "(default)")
		Me.ccbCSEnableGrouping.UseVisualStyleBackColor = False
		Me.ccbCSEnableGrouping.Value = Nothing
		Me.ccbCSEnableGrouping.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
		AddHandler Me.ccbCSEnableGrouping.CheckedChanged, New System.EventHandler(AddressOf Me.ccbCSEnableGrouping_CheckedChanged)
		' 
		' c1DockingTabPage2
		' 
		Me.c1DockingTabPage2.CaptionVisible = True
		Me.c1DockingTabPage2.ImageIndex = 11
		Me.c1DockingTabPage2.Location = New System.Drawing.Point(3, 0)
		Me.c1DockingTabPage2.Name = "c1DockingTabPage2"
		Me.c1DockingTabPage2.Size = New System.Drawing.Size(273, 611)
		Me.c1DockingTabPage2.TabIndex = 1
		Me.c1DockingTabPage2.Text = "Search"
		' 
		' c1DockingTab2
		' 
		Me.c1DockingTab2.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(252)), CInt(CByte(238)), CInt(CByte(194)))
		Me.c1DockingTab2.Controls.Add(Me.c1DockingTabPage3)
		Me.c1DockingTab2.Controls.Add(Me.c1DockingTabPage4)
		Me.c1DockingTab2.Controls.Add(Me.c1DockingTabPage5)
		Me.c1DockingTab2.Controls.Add(Me.c1DockingTabPage6)
		Me.c1DockingTab2.Dock = System.Windows.Forms.DockStyle.Fill
		Me.c1DockingTab2.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1DockingTab2.Location = New System.Drawing.Point(265, 97)
		Me.c1DockingTab2.Name = "c1DockingTab2"
		Me.c1DockingTab2.Size = New System.Drawing.Size(715, 637)
		Me.c1DockingTab2.TabIndex = 10
		Me.c1DockingTab2.TabsSpacing = 7
		Me.c1DockingTab2.TabStyle = C1.Win.Command.TabStyleEnum.Office2007
		Me.c1ThemeController1.SetTheme(Me.c1DockingTab2, "(default)")
		AddHandler Me.c1DockingTab2.SelectedTabChanged, New System.EventHandler(AddressOf Me.c1DockingTab2_SelectedTabChanged)
		' 
		' c1DockingTabPage3
		' 
		Me.c1DockingTabPage3.Controls.Add(Me.c1FlexGrid1)
		Me.c1DockingTabPage3.Location = New System.Drawing.Point(1, 26)
		Me.c1DockingTabPage3.Name = "c1DockingTabPage3"
		Me.c1DockingTabPage3.Size = New System.Drawing.Size(713, 610)
		Me.c1DockingTabPage3.TabIndex = 0
		Me.c1DockingTabPage3.Text = "C1FlexGrid"
		' 
		' c1FlexGrid1
		' 
		Me.c1FlexGrid1.BackColor = System.Drawing.Color.White
		Me.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo")
		Me.c1FlexGrid1.DataSource = Me.employeesBindingSource
		Me.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.c1FlexGrid1.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1FlexGrid1.ForeColor = System.Drawing.Color.Black
		Me.c1FlexGrid1.Location = New System.Drawing.Point(0, 0)
		Me.c1FlexGrid1.Name = "c1FlexGrid1"
		Me.c1FlexGrid1.Rows.Count = 1
		Me.c1FlexGrid1.Rows.DefaultSize = 21
		Me.c1FlexGrid1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None
		Me.c1FlexGrid1.Size = New System.Drawing.Size(713, 610)
		Me.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo")
		Me.c1FlexGrid1.TabIndex = 0
		Me.c1ThemeController1.SetTheme(Me.c1FlexGrid1, "(default)")
		Me.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(CInt(CByte(124)), CInt(CByte(67)), CInt(CByte(0)))
		' 
		' c1DockingTabPage4
		' 
		Me.c1DockingTabPage4.Controls.Add(Me.c1TrueDBGrid1)
		Me.c1DockingTabPage4.Location = New System.Drawing.Point(1, 26)
		Me.c1DockingTabPage4.Name = "c1DockingTabPage4"
		Me.c1DockingTabPage4.Size = New System.Drawing.Size(713, 610)
		Me.c1DockingTabPage4.TabIndex = 1
		Me.c1DockingTabPage4.Text = "C1TrueDBGrid"
		' 
		' c1TrueDBGrid1
		' 
		Me.c1TrueDBGrid1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(204)), CInt(CByte(0)))
		Me.c1TrueDBGrid1.CaptionHeight = 17
		Me.c1TrueDBGrid1.DataSource = Me.employeesBindingSource
		Me.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.c1TrueDBGrid1.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1TrueDBGrid1.ForeColor = System.Drawing.Color.Black
		Me.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
		Me.c1TrueDBGrid1.Images.Add(DirectCast(resources.GetObject("c1TrueDBGrid1.Images"), System.Drawing.Image))
		Me.c1TrueDBGrid1.Location = New System.Drawing.Point(0, 0)
		Me.c1TrueDBGrid1.Name = "c1TrueDBGrid1"
		Me.c1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
		Me.c1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
		Me.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0
		Me.c1TrueDBGrid1.PrintInfo.PageSettings = DirectCast(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
		Me.c1TrueDBGrid1.RowDivider.Color = System.Drawing.Color.FromArgb(CInt(CByte(104)), CInt(CByte(87)), CInt(CByte(70)))
		Me.c1TrueDBGrid1.RowDivider.Style = C1.Win.TrueDBGrid.LineStyleEnum.[Single]
		Me.c1TrueDBGrid1.RowHeight = 15
		Me.c1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.FromArgb(CInt(CByte(104)), CInt(CByte(87)), CInt(CByte(70)))
		Me.c1TrueDBGrid1.Size = New System.Drawing.Size(713, 610)
		Me.c1TrueDBGrid1.TabIndex = 0
		Me.c1TrueDBGrid1.Text = "c1TrueDBGrid1"
		Me.c1ThemeController1.SetTheme(Me.c1TrueDBGrid1, "(default)")
		Me.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag")
		' 
		' c1DockingTabPage5
		' 
		Me.c1DockingTabPage5.Controls.Add(Me.csMain)
		Me.c1DockingTabPage5.Location = New System.Drawing.Point(1, 26)
		Me.c1DockingTabPage5.Name = "c1DockingTabPage5"
		Me.c1DockingTabPage5.Size = New System.Drawing.Size(713, 610)
		Me.c1DockingTabPage5.TabIndex = 2
		Me.c1DockingTabPage5.Text = "C1Schedule"
		' 
		' csMain
		' 
		' 
		' 
		' 
		Me.csMain.CalendarInfo.DateFormatString = "M/d/yyyy"
		Me.csMain.CalendarInfo.EndDayTime = System.TimeSpan.Parse("18:00:00")
		Me.csMain.CalendarInfo.StartDayTime = System.TimeSpan.Parse("06:00:00")
		Me.csMain.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00")
		Me.csMain.CalendarInfo.WeekStart = System.DayOfWeek.Monday
		Me.csMain.CalendarInfo.WorkDays.AddRange(New System.DayOfWeek() {System.DayOfWeek.Monday, System.DayOfWeek.Tuesday, System.DayOfWeek.Wednesday, System.DayOfWeek.Thursday, System.DayOfWeek.Friday})
		' 
		' 
		' 
		Me.csMain.Dock = System.Windows.Forms.DockStyle.Fill
		Me.csMain.GroupPageSize = 2
		Me.csMain.Location = New System.Drawing.Point(0, 0)
		Me.csMain.Margin = New System.Windows.Forms.Padding(2)
		Me.csMain.Name = "csMain"
		Me.csMain.PrintInfo.IsPrintingEnabled = False
		printStyle6.Description = "Daily Style"
		printStyle6.PreviewImage = DirectCast(resources.GetObject("printStyle6.PreviewImage"), System.Drawing.Image)
		printStyle6.StyleName = "Daily"
		printStyle6.StyleSource = "day.c1d"
		printStyle7.Description = "Weekly Style"
		printStyle7.PreviewImage = DirectCast(resources.GetObject("printStyle7.PreviewImage"), System.Drawing.Image)
		printStyle7.StyleName = "Week"
		printStyle7.StyleSource = "week.c1d"
		printStyle8.Description = "Monthly Style"
		printStyle8.PreviewImage = DirectCast(resources.GetObject("printStyle8.PreviewImage"), System.Drawing.Image)
		printStyle8.StyleName = "Month"
		printStyle8.StyleSource = "month.c1d"
		printStyle9.Description = "Details Style"
		printStyle9.PreviewImage = DirectCast(resources.GetObject("printStyle9.PreviewImage"), System.Drawing.Image)
		printStyle9.StyleName = "Details"
		printStyle9.StyleSource = "details.c1d"
		printStyle10.Context = C1.Schedule.Printing.PrintContextType.Appointment
		printStyle10.Description = "Memo Style"
		printStyle10.PreviewImage = DirectCast(resources.GetObject("printStyle10.PreviewImage"), System.Drawing.Image)
		printStyle10.StyleName = "Memo"
		printStyle10.StyleSource = "memo.c1d"
		Me.csMain.PrintInfo.PrintStyles.AddRange(New C1.Schedule.Printing.PrintStyle() {printStyle6, printStyle7, printStyle8, printStyle9, printStyle10})
		' 
		' 
		' 
		Me.csMain.Settings.AllowCategoriesEditing = False
		Me.csMain.Settings.AllowCategoriesMultiSelection = False
		Me.csMain.Settings.AllowContactsEditing = False
		Me.csMain.Settings.AllowContactsMultiSelection = False
		Me.csMain.Settings.FirstVisibleTime = System.TimeSpan.Parse("06:00:00")
		Me.csMain.ShowTitle = False
		Me.csMain.Size = New System.Drawing.Size(713, 610)
		Me.csMain.TabIndex = 5
		Me.c1ThemeController1.SetTheme(Me.csMain, "(default)")
		Me.csMain.ViewType = C1.Win.Schedule.ScheduleViewEnum.WorkWeekView
		Me.csMain.VisualStyle = C1.Win.Schedule.UI.VisualStyle.[Custom]
		' 
		' c1DockingTabPage6
		' 
		Me.c1DockingTabPage6.Controls.Add(Me.c1GanttView1)
		Me.c1DockingTabPage6.Location = New System.Drawing.Point(1, 26)
		Me.c1DockingTabPage6.Name = "c1DockingTabPage6"
		Me.c1DockingTabPage6.Size = New System.Drawing.Size(713, 610)
		Me.c1DockingTabPage6.TabIndex = 3
		Me.c1DockingTabPage6.Text = "C1GanttView"
		' 
		' c1GanttView1
		' 
		Me.c1GanttView1.BackColor = System.Drawing.Color.FromArgb(CInt(CByte(251)), CInt(CByte(251)), CInt(CByte(245)))
		calendarException16.Name = "Vacation"
		calendarException16.RecurrencePattern.DayOfMonth = 10
		calendarException16.RecurrencePattern.MonthOfYear = 7
		calendarException16.StartDate = New System.DateTime(2013, 6, 10, 0, 0, 0, _
			0)
		Me.c1GanttView1.CalendarExceptions.Add(calendarException16)
		Me.c1GanttView1.CellBorderColor = System.Drawing.SystemColors.WindowFrame
		taskPropertyColumn211.Caption = "Task Mode"
		taskPropertyColumn211.ID = 619243840
		taskPropertyColumn211.[Property] = C1.Win.GanttView.TaskProperty.Mode
		taskPropertyColumn211.Width = 90
		taskPropertyColumn212.Caption = "Task Name"
		taskPropertyColumn212.ID = 2099866733
		taskPropertyColumn212.[Property] = C1.Win.GanttView.TaskProperty.Name
		taskPropertyColumn212.Width = 80
		taskPropertyColumn213.Caption = "Duration"
		taskPropertyColumn213.ID = 1358251825
		taskPropertyColumn213.[Property] = C1.Win.GanttView.TaskProperty.Duration
		taskPropertyColumn213.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		taskPropertyColumn213.Visible = False
		taskPropertyColumn213.Width = 45
		taskPropertyColumn214.Caption = "Duration Units"
		taskPropertyColumn214.ID = 1827635185
		taskPropertyColumn214.[Property] = C1.Win.GanttView.TaskProperty.DurationUnits
		taskPropertyColumn214.Visible = False
		taskPropertyColumn214.Width = 51
		taskPropertyColumn215.Caption = "Start"
		taskPropertyColumn215.ID = 1435981949
		taskPropertyColumn215.[Property] = C1.Win.GanttView.TaskProperty.Start
		taskPropertyColumn215.Visible = False
		taskPropertyColumn216.Caption = "Finish"
		taskPropertyColumn216.ID = 1177114106
		taskPropertyColumn216.[Property] = C1.Win.GanttView.TaskProperty.Finish
		taskPropertyColumn216.Visible = False
		taskPropertyColumn217.Caption = "% Complete"
		taskPropertyColumn217.ID = 705116663
		taskPropertyColumn217.[Property] = C1.Win.GanttView.TaskProperty.PercentComplete
		taskPropertyColumn217.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		taskPropertyColumn217.Visible = False
		taskPropertyColumn218.Caption = "Constraint Type"
		taskPropertyColumn218.ID = 1424686126
		taskPropertyColumn218.[Property] = C1.Win.GanttView.TaskProperty.ConstraintType
		taskPropertyColumn218.Visible = False
		taskPropertyColumn219.Caption = "Constraint Date"
		taskPropertyColumn219.ID = 1191399244
		taskPropertyColumn219.[Property] = C1.Win.GanttView.TaskProperty.ConstraintDate
		taskPropertyColumn219.Visible = False
		taskPropertyColumn220.Caption = "Predecessors"
		taskPropertyColumn220.ID = 502674747
		taskPropertyColumn220.[Property] = C1.Win.GanttView.TaskProperty.Predecessors
		taskPropertyColumn220.Visible = False
		taskPropertyColumn221.Caption = "Deadline"
		taskPropertyColumn221.ID = 166462627
		taskPropertyColumn221.[Property] = C1.Win.GanttView.TaskProperty.Deadline
		taskPropertyColumn221.Visible = False
		taskPropertyColumn222.Caption = "Calendar"
		taskPropertyColumn222.ID = 997563278
		taskPropertyColumn222.[Property] = C1.Win.GanttView.TaskProperty.Calendar
		taskPropertyColumn222.Visible = False
		taskPropertyColumn223.Caption = "Resource Names"
		taskPropertyColumn223.ID = 1673084976
		taskPropertyColumn223.[Property] = C1.Win.GanttView.TaskProperty.ResourceNames
		taskPropertyColumn223.Visible = False
		taskPropertyColumn224.Caption = "Notes"
		taskPropertyColumn224.ID = 1052675343
		taskPropertyColumn224.[Property] = C1.Win.GanttView.TaskProperty.Notes
		taskPropertyColumn224.Visible = False
		Me.c1GanttView1.Columns.Add(taskPropertyColumn211)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn212)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn213)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn214)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn215)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn216)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn217)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn218)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn219)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn220)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn221)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn222)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn223)
		Me.c1GanttView1.Columns.Add(taskPropertyColumn224)
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
		Me.c1GanttView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.c1GanttView1.EmptyAreaBackColor = System.Drawing.Color.FromArgb(CInt(CByte(140)), CInt(CByte(140)), CInt(CByte(128)))
		Me.c1GanttView1.FinishDate = New System.DateTime(2013, 6, 29, 0, 0, 0, _
			0)
		Me.c1GanttView1.FirstMonthOfFY = C1.Win.GanttView.FirstMonthOfFY.March
		Me.c1GanttView1.FixedCellBorderColor = System.Drawing.SystemColors.WindowFrame
		Me.c1GanttView1.FixedForeColor = System.Drawing.Color.Black
		Me.c1GanttView1.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.c1GanttView1.ForeColor = System.Drawing.Color.Black
		Me.c1GanttView1.GridWidth = 215
		Me.c1GanttView1.Location = New System.Drawing.Point(0, 0)
		Me.c1GanttView1.Name = "c1GanttView1"
		Me.c1GanttView1.ProgressLine.StatusDate = New System.DateTime(2013, 6, 19, 0, 0, 0, _
			0)
		Me.c1GanttView1.ProgressLine.Visible = True
		resource136.Cost = New Decimal(New Integer() {100, 0, 0, 0})
		resource136.ID = 1640417825
		resource136.Name = "Rita Been"
		resource136.Notes = "Tester"
		resource137.Cost = New Decimal(New Integer() {250, 0, 0, 0})
		resource137.ID = 239555279
		resource137.Name = "Eric Smith"
		resource137.Notes = "Project Manager"
		resource138.Cost = New Decimal(New Integer() {150, 0, 0, 0})
		resource138.ID = 766290656
		resource138.Name = "Daniel Hank"
		resource138.Notes = "Analyst"
		resource139.Cost = New Decimal(New Integer() {300, 0, 0, 0})
		resource139.ID = 2011144056
		resource139.Name = "Juan Carlos"
		resource139.Notes = "Developer"
		resource140.Cost = New Decimal(New Integer() {100, 0, 0, 0})
		resource140.ID = 448108000
		resource140.Name = "Mike Jones "
		resource140.Notes = "Developer"
		resource141.Cost = New Decimal(New Integer() {400, 0, 0, 0})
		resource141.ID = 1869891731
		resource141.Name = "Chris Lee"
		resource141.Notes = "Developer"
		resource142.Cost = New Decimal(New Integer() {250, 0, 0, 0})
		resource142.ID = 556319480
		resource142.Name = "Sarah Robert"
		resource142.Notes = "Tester"
		resource143.Cost = New Decimal(New Integer() {200, 0, 0, 0})
		resource143.ID = 1334638351
		resource143.Name = "Micheal Owen"
		resource143.Notes = "Documentation Maker"
		resource144.Cost = New Decimal(New Integer() {150, 0, 0, 0})
		resource144.ID = 2101511829
		resource144.Name = "Juliet Paul"
		resource144.Notes = "Documentation Maker"
		Me.c1GanttView1.Resources.Add(resource136)
		Me.c1GanttView1.Resources.Add(resource137)
		Me.c1GanttView1.Resources.Add(resource138)
		Me.c1GanttView1.Resources.Add(resource139)
		Me.c1GanttView1.Resources.Add(resource140)
		Me.c1GanttView1.Resources.Add(resource141)
		Me.c1GanttView1.Resources.Add(resource142)
		Me.c1GanttView1.Resources.Add(resource143)
		Me.c1GanttView1.Resources.Add(resource144)
		Me.c1GanttView1.ScheduleFrom = C1.Win.GanttView.ScheduleFrom.ProjectFinishDate
		Me.c1GanttView1.ShowToolbar = False
		Me.c1GanttView1.Size = New System.Drawing.Size(713, 610)
		Me.c1GanttView1.SplitterColor = System.Drawing.Color.FromArgb(CInt(CByte(124)), CInt(CByte(67)), CInt(CByte(0)))
		Me.c1GanttView1.TabIndex = 0
		task406.Finish = New System.DateTime(2013, 6, 7, 0, 0, 0, _
			0)
		task406.ID = 362538391
		task406.Name = "Planning"
		task406.PercentComplete = 1.0
		resourceRef166.Amount = 1.0
		resourceRef166.ResourceID = 766290656
		resourceRef167.Amount = 1.0
		resourceRef167.ResourceID = 1334638351
		resourceRef168.Amount = 1.0
		resourceRef168.ResourceID = 239555279
		task406.ResourceRefs.Add(resourceRef166)
		task406.ResourceRefs.Add(resourceRef167)
		task406.ResourceRefs.Add(resourceRef168)
		task406.Start = New System.DateTime(2013, 6, 4, 0, 0, 0, _
			0)
		task407.ID = 110002178
		barStyle31.BarColor = System.Drawing.Color.PaleVioletRed
		barStyle31.BarShape = C1.Win.GanttView.BarShape.ThickBar
		barStyle31.BarType = C1.Win.GanttView.BarType.AutoTask
		barStyle31.TopText1_ID = 1673084976
		task408.BarStyles.Add(barStyle31)
		task408.ConstraintDate = New System.DateTime(2013, 6, 7, 0, 0, 0, _
			0)
		task408.ConstraintType = C1.Win.GanttView.ConstraintType.StartNoEarlierThan
		task408.Deadline = New System.DateTime(2013, 6, 15, 0, 0, 0, _
			0)
		task408.Duration = 4.0
		task408.ID = 1179983348
		task408.Mode = C1.Win.GanttView.TaskMode.Automatic
		task408.Name = "Analysis"
		task408.PercentComplete = 1.0
		predecessor76.PredecessorTaskID = 362538391
		task408.Predecessors.Add(predecessor76)
		resourceRef169.Amount = 1.0
		resourceRef169.ResourceID = 2011144056
		task408.ResourceRefs.Add(resourceRef169)
		task409.ID = 1427410353
		task410.Finish = New System.DateTime(2013, 6, 18, 18, 0, 0, _
			0)
		task410.ID = 2098269195
		task410.Name = "Design"
		task410.PercentComplete = 0.5
		predecessor77.PredecessorTaskID = 1179983348
		task410.Predecessors.Add(predecessor77)
		resourceRef170.Amount = 1.0
		resourceRef170.ResourceID = 2101511829
		resourceRef171.Amount = 1.0
		resourceRef171.ResourceID = 1869891731
		task410.ResourceRefs.Add(resourceRef170)
		task410.ResourceRefs.Add(resourceRef171)
		task410.Start = New System.DateTime(2013, 6, 13, 8, 30, 0, _
			0)
		task411.ID = 1753282054
		task412.ConstraintDate = New System.DateTime(2013, 6, 19, 0, 0, 0, _
			0)
		task412.ConstraintType = C1.Win.GanttView.ConstraintType.StartNoEarlierThan
		task412.Duration = 4.0
		task412.ID = 792666599
		task412.Mode = C1.Win.GanttView.TaskMode.Automatic
		task412.Name = "Implementation"
		predecessor78.PredecessorTaskID = 2098269195
		task412.Predecessors.Add(predecessor78)
		resourceRef172.Amount = 1.0
		resourceRef172.ResourceID = 1334638351
		resourceRef173.Amount = 1.0
		resourceRef173.ResourceID = 766290656
		task412.ResourceRefs.Add(resourceRef172)
		task412.ResourceRefs.Add(resourceRef173)
		task413.ID = 1853855961
		barStyle32.BarColor = System.Drawing.Color.Green
		barStyle32.BarShape = C1.Win.GanttView.BarShape.ThickBar
		barStyle32.BarType = C1.Win.GanttView.BarType.ManualTask
		barStyle32.EndShape = 22
		barStyle32.LeftText1_ID = 1673084976
		barStyle32.StartShape = 21
		task414.BarStyles.Add(barStyle32)
		task414.Deadline = New System.DateTime(2013, 6, 28, 0, 0, 0, _
			0)
		task414.Finish = New System.DateTime(2013, 6, 27, 8, 30, 0, _
			0)
		task414.ID = 2121238572
		task414.Name = "Documentation"
		predecessor79.PredecessorTaskID = 792666599
		task414.Predecessors.Add(predecessor79)
		resourceRef174.Amount = 1.0
		resourceRef174.ResourceID = 1640417825
		resourceRef175.Amount = 1.0
		resourceRef175.ResourceID = 556319480
		task414.ResourceRefs.Add(resourceRef174)
		task414.ResourceRefs.Add(resourceRef175)
		task414.Start = New System.DateTime(2013, 6, 25, 8, 30, 0, _
			0)
		task415.ID = 1728214611
		task416.Finish = New System.DateTime(2013, 6, 28, 18, 0, 0, _
			0)
		task416.ID = 312019882
		task416.Name = "Support"
		predecessor80.PredecessorTaskID = 2121238572
		task416.Predecessors.Add(predecessor80)
		resourceRef176.Amount = 1.0
		resourceRef176.ResourceID = 2011144056
		task416.ResourceRefs.Add(resourceRef176)
		task416.Start = New System.DateTime(2013, 6, 27, 8, 30, 0, _
			0)
		task417.ID = 2131650479
		task418.ID = 1600264846
		task419.ID = 185936048
		task420.ID = 1447717244
		task421.ID = 1352797036
		task422.ID = 1301076315
		task423.ID = 562163695
		task424.ID = 19552401
		task425.ID = 1597983629
		task426.ID = 591786279
		task427.ID = 816445275
		task428.ID = 514161404
		task429.ID = 992389273
		task430.ID = 246882487
		task431.ID = 1546671531
		task432.ID = 2076126586
		Me.c1GanttView1.Tasks.Add(task406)
		Me.c1GanttView1.Tasks.Add(task407)
		Me.c1GanttView1.Tasks.Add(task408)
		Me.c1GanttView1.Tasks.Add(task409)
		Me.c1GanttView1.Tasks.Add(task410)
		Me.c1GanttView1.Tasks.Add(task411)
		Me.c1GanttView1.Tasks.Add(task412)
		Me.c1GanttView1.Tasks.Add(task413)
		Me.c1GanttView1.Tasks.Add(task414)
		Me.c1GanttView1.Tasks.Add(task415)
		Me.c1GanttView1.Tasks.Add(task416)
		Me.c1GanttView1.Tasks.Add(task417)
		Me.c1GanttView1.Tasks.Add(task418)
		Me.c1GanttView1.Tasks.Add(task419)
		Me.c1GanttView1.Tasks.Add(task420)
		Me.c1GanttView1.Tasks.Add(task421)
		Me.c1GanttView1.Tasks.Add(task422)
		Me.c1GanttView1.Tasks.Add(task423)
		Me.c1GanttView1.Tasks.Add(task424)
		Me.c1GanttView1.Tasks.Add(task425)
		Me.c1GanttView1.Tasks.Add(task426)
		Me.c1GanttView1.Tasks.Add(task427)
		Me.c1GanttView1.Tasks.Add(task428)
		Me.c1GanttView1.Tasks.Add(task429)
		Me.c1GanttView1.Tasks.Add(task430)
		Me.c1GanttView1.Tasks.Add(task431)
		Me.c1GanttView1.Tasks.Add(task432)
		Me.c1ThemeController1.SetTheme(Me.c1GanttView1, "(default)")
		Me.c1GanttView1.Timescale.BottomTier.Align = C1.Win.GanttView.ScaleLabelAlignment.Center
		Me.c1GanttView1.Timescale.BottomTier.Format = "w"
		Me.c1GanttView1.Timescale.BottomTier.Visible = True
		Me.c1GanttView1.Timescale.MiddleTier.Format = "nnn d, \'yy"
		Me.c1GanttView1.Timescale.MiddleTier.MinWidth = 62
		Me.c1GanttView1.Timescale.MiddleTier.Units = C1.Win.GanttView.TimescaleUnits.Weeks
		Me.c1GanttView1.Timescale.MiddleTier.Visible = True
		Me.c1GanttView1.ToolbarBackColor = System.Drawing.Color.FromArgb(CInt(CByte(255)), CInt(CByte(204)), CInt(CByte(0)))
		Me.c1GanttView1.VisualStyle = C1.Win.GanttView.VisualStyle.[Custom]
		' 
		' c1NWINDDataSet
		' 
		Me.c1NWINDDataSet.DataSetName = "C1NWINDDataSet"
		Me.c1NWINDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		' 
		' employeesBindingSource
		' 
		Me.employeesBindingSource.DataMember = "Employees"
		Me.employeesBindingSource.DataSource = Me.c1NWINDDataSet
		' 
		' employeesTableAdapter
		' 
		Me.employeesTableAdapter.ClearBeforeFill = True
		' 
		' Form1
		' 
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1256, 734)
		Me.Controls.Add(Me.c1DockingTab2)
		Me.Controls.Add(Me.c1CommandDock1)
		Me.Controls.Add(Me.c1NavBar1)
		Me.Controls.Add(Me.ccdTop)
		Me.Controls.Add(Me.cmmMain)
		Me.Font = New System.Drawing.Font("Segoe UI", 8F)
		Me.ForeColor = System.Drawing.Color.Black
		Me.Name = "Form1"
		Me.Text = "Form1"
		Me.c1ThemeController1.SetTheme(Me, "(default)")
		AddHandler Me.Load, New System.EventHandler(AddressOf Me.Form1_Load)
		DirectCast(Me.cchMain, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.cneCFGFrozenColCount, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.cneCFGFrozenRowCount, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.cddcFontName, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.cddcFontSize, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.ccdTop, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ccdTop.ResumeLayout(False)
		Me.ctbFormat.ResumeLayout(False)
		DirectCast(Me.c1NavBar1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.c1NavBar1.ResumeLayout(False)
		Me.c1NavBarPanel5.ResumeLayout(False)
		DirectCast(Me.ctbMain, System.ComponentModel.ISupportInitialize).EndInit()
		Me.c1NavBarPanel2.ResumeLayout(False)
		DirectCast(Me.c1Calendar1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.c1NavBarPanel3.ResumeLayout(False)
		Me.c1NavBarPanel4.ResumeLayout(False)
		DirectCast(Me.c1CommandDock1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.c1CommandDock1.ResumeLayout(False)
		DirectCast(Me.c1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.c1DockingTab1.ResumeLayout(False)
		Me.c1DockingTabPage1.ResumeLayout(False)
		DirectCast(Me.c1OutBar1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.c1OutBar1.ResumeLayout(False)
		Me.copC1FlexGrid.ResumeLayout(False)
        Me.tableLayoutPanel1.ResumeLayout(False)
        Me.tableLayoutPanel1.PerformLayout()
        DirectCast(Me.c1Label4, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.c1Label3, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.c1Label2, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.cneFixedRowCount, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.cneFixedColCount, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.c1Label1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.copC1TrueDBGrid.ResumeLayout(False)
		Me.panel2.ResumeLayout(False)
		Me.panel2.PerformLayout()
		Me.copC1Schedule.ResumeLayout(False)
		Me.panel3.ResumeLayout(False)
		Me.panel3.PerformLayout()
		DirectCast(Me.c1DockingTab2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.c1DockingTab2.ResumeLayout(False)
		Me.c1DockingTabPage3.ResumeLayout(False)
		DirectCast(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.c1DockingTabPage4.ResumeLayout(False)
		DirectCast(Me.c1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.c1DockingTabPage5.ResumeLayout(False)
		DirectCast(Me.csMain.DataStorage.AppointmentStorage, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.csMain.DataStorage.CategoryStorage, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.csMain.DataStorage.ContactStorage, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.csMain.DataStorage.LabelStorage, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.csMain.DataStorage.OwnerStorage, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.csMain.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.csMain.DataStorage.StatusStorage, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.csMain, System.ComponentModel.ISupportInitialize).EndInit()
		Me.c1DockingTabPage6.ResumeLayout(False)
		DirectCast(Me.c1GanttView1, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.c1NWINDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		DirectCast(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	#End Region

	Private ilSmall As System.Windows.Forms.ImageList
	Private cchMain As C1.Win.Command.C1CommandHolder
	Private ccmFile As C1.Win.Command.C1CommandMenu
	Private c1CommandLink2 As C1.Win.Command.C1CommandLink
	Private ccmFileNew As C1.Win.Command.C1CommandMenu
	Private c1CommandLink5 As C1.Win.Command.C1CommandLink
	Private ccFileNewWizard As C1.Win.Command.C1Command
	Private c1CommandLink3 As C1.Win.Command.C1CommandLink
	Private ccFileNewEmpty As C1.Win.Command.C1Command
	Private c1CommandLink4 As C1.Win.Command.C1CommandLink
	Private ccFileOpen As C1.Win.Command.C1Command
	Private c1CommandLink6 As C1.Win.Command.C1CommandLink
	Private ccFileSave As C1.Win.Command.C1Command
	Private c1CommandLink7 As C1.Win.Command.C1CommandLink
	Private ccFileSaveAs As C1.Win.Command.C1Command
	Private c1CommandLink9 As C1.Win.Command.C1CommandLink
	Private ccFilePrint As C1.Win.Command.C1Command
	Private c1CommandLink8 As C1.Win.Command.C1CommandLink
	Private ccFileClose As C1.Win.Command.C1Command
	Private c1CommandLink10 As C1.Win.Command.C1CommandLink
	Private ccFileExit As C1.Win.Command.C1Command
	Private ccmEdit As C1.Win.Command.C1CommandMenu
	Private c1CommandLink11 As C1.Win.Command.C1CommandLink
	Private ccUndo As C1.Win.Command.C1Command
	Private c1CommandLink13 As C1.Win.Command.C1CommandLink
	Private ccRedo As C1.Win.Command.C1Command
	Private c1CommandLink14 As C1.Win.Command.C1CommandLink
	Private ccCut As C1.Win.Command.C1Command
	Private c1CommandLink15 As C1.Win.Command.C1CommandLink
	Private ccCopy As C1.Win.Command.C1Command
	Private c1CommandLink16 As C1.Win.Command.C1CommandLink
	Private ccPaste As C1.Win.Command.C1Command
	Private c1CommandLink17 As C1.Win.Command.C1CommandLink
	Private ccDelete As C1.Win.Command.C1Command
	Private c1CommandLink18 As C1.Win.Command.C1CommandLink
	Private ccFind As C1.Win.Command.C1Command
	Private c1CommandLink19 As C1.Win.Command.C1CommandLink
	Private ccGoTo As C1.Win.Command.C1Command
	Private ccmFormat As C1.Win.Command.C1CommandMenu
	Private c1CommandLink20 As C1.Win.Command.C1CommandLink
	Private ccFormatFont As C1.Win.Command.C1Command
	Private c1CommandLink23 As C1.Win.Command.C1CommandLink
	Private ccmFormatFontColor As C1.Win.Command.C1CommandMenu
	Private c1CommandLink21 As C1.Win.Command.C1CommandLink
	Private ccFormatFontBold As C1.Win.Command.C1Command
	Private ccFormatFontItalic As C1.Win.Command.C1Command
	Private ccFormatFontUnderline As C1.Win.Command.C1Command
	Private ccFormatFontStrikeout As C1.Win.Command.C1Command
	Private ccFormatAlignLeft As C1.Win.Command.C1Command
	Private ccFormatAlignCenter As C1.Win.Command.C1Command
	Private ccFormatAlignRight As C1.Win.Command.C1Command
	Private ccFormatAlignJustify As C1.Win.Command.C1Command
	Private ccmC1TrueDBGrid As C1.Win.Command.C1CommandMenu
	Private c1CommandLink24 As C1.Win.Command.C1CommandLink
	Private ccCTDBGViewNormal As C1.Win.Command.C1Command
	Private c1CommandLink26 As C1.Win.Command.C1CommandLink
	Private ccCTDBGViewInverted As C1.Win.Command.C1Command
	Private c1CommandLink27 As C1.Win.Command.C1CommandLink
	Private ccCTDBGViewForm As C1.Win.Command.C1Command
	Private c1CommandLink28 As C1.Win.Command.C1CommandLink
	Private ccCTDBGViewGroupBy As C1.Win.Command.C1Command
	Private c1CommandLink29 As C1.Win.Command.C1CommandLink
	Private ccCTDBGViewMultipleLines As C1.Win.Command.C1Command
	Private c1CommandLink30 As C1.Win.Command.C1CommandLink
	Private ccCTDBGViewHierarchical As C1.Win.Command.C1Command
	Private c1CommandLink31 As C1.Win.Command.C1CommandLink
	Private ccCTDBGShowCaption As C1.Win.Command.C1Command
	Private ccmC1FlexGrid As C1.Win.Command.C1CommandMenu
	Private c1CommandLink32 As C1.Win.Command.C1CommandLink
	Private ccCFGViewNormal As C1.Win.Command.C1Command
	Private c1CommandLink36 As C1.Win.Command.C1CommandLink
	Private ccCFGViewTree As C1.Win.Command.C1Command
	Private c1CommandLink37 As C1.Win.Command.C1CommandLink
	Private ccCFGViewSubtotals As C1.Win.Command.C1Command
	Private c1CommandLink38 As C1.Win.Command.C1CommandLink
	Private ccCFGFixedColCount As C1.Win.Command.C1CommandControl
	Private c1CommandLink39 As C1.Win.Command.C1CommandLink
	Private ccCFGFixedRowCount As C1.Win.Command.C1CommandControl
	Private c1CommandLink40 As C1.Win.Command.C1CommandLink
	Private ccmCFGSelectionMode As C1.Win.Command.C1CommandMenu
	Private c1CommandLink33 As C1.Win.Command.C1CommandLink
	Private c1CommandLink41 As C1.Win.Command.C1CommandLink
	Private ccmCFGFocusRect As C1.Win.Command.C1CommandMenu
	Private c1CommandLink34 As C1.Win.Command.C1CommandLink
	Private c1CommandLink42 As C1.Win.Command.C1CommandLink
	Private ccCFGShowCursor As C1.Win.Command.C1Command
	Private ccmC1Schedule As C1.Win.Command.C1CommandMenu
	Private c1CommandLink43 As C1.Win.Command.C1CommandLink
	Private ccCSViewDay As C1.Win.Command.C1Command
	Private c1CommandLink45 As C1.Win.Command.C1CommandLink
	Private ccCSViewWorkWeek As C1.Win.Command.C1Command
	Private c1CommandLink46 As C1.Win.Command.C1CommandLink
	Private ccCSViewWeek As C1.Win.Command.C1Command
	Private c1CommandLink47 As C1.Win.Command.C1CommandLink
	Private ccCSViewMonth As C1.Win.Command.C1Command
	Private c1CommandLink48 As C1.Win.Command.C1CommandLink
	Private ccCSViewTimeLine As C1.Win.Command.C1Command
	Private c1CommandLink49 As C1.Win.Command.C1CommandLink
	Private ccCSEnableGrouping As C1.Win.Command.C1Command
	Private c1CommandLink50 As C1.Win.Command.C1CommandLink
	Private ccCSOffice2003WeekView As C1.Win.Command.C1Command
	Private cccFormatFontName As C1.Win.Command.C1CommandControl
	Private cccFormatFontSize As C1.Win.Command.C1CommandControl
	Private ccmFormatBorders As C1.Win.Command.C1CommandMenu
	Private c1CommandLink73 As C1.Win.Command.C1CommandLink
	Private ccFormatBorderBottom As C1.Win.Command.C1Command
	Private c1CommandLink71 As C1.Win.Command.C1CommandLink
	Private ccFormatBorderTop As C1.Win.Command.C1Command
	Private c1CommandLink74 As C1.Win.Command.C1CommandLink
	Private ccFormatBorderLeft As C1.Win.Command.C1Command
	Private c1CommandLink75 As C1.Win.Command.C1CommandLink
	Private ccFormatBorderRight As C1.Win.Command.C1Command
	Private ccStatesNormal As C1.Win.Command.C1Command
	Private ccStatesDisabled As C1.Win.Command.C1Command
	Private ccStatesPressed As C1.Win.Command.C1Command
	Private ccStatesChecked As C1.Win.Command.C1Command
	Private ccdTop As C1.Win.Command.C1CommandDock
	Private ctbStates As C1.Win.Command.C1ToolBar
	Private c1CommandLink76 As C1.Win.Command.C1CommandLink
	Private c1CommandLink77 As C1.Win.Command.C1CommandLink
	Private c1CommandLink78 As C1.Win.Command.C1CommandLink
	Private c1CommandLink79 As C1.Win.Command.C1CommandLink
	Private ctbFormat As C1.Win.Command.C1ToolBar
	Private c1CommandLink69 As C1.Win.Command.C1CommandLink
	Private c1CommandLink70 As C1.Win.Command.C1CommandLink
	Private c1CommandLink61 As C1.Win.Command.C1CommandLink
	Private c1CommandLink62 As C1.Win.Command.C1CommandLink
	Private c1CommandLink63 As C1.Win.Command.C1CommandLink
	Private c1CommandLink64 As C1.Win.Command.C1CommandLink
	Private c1CommandLink65 As C1.Win.Command.C1CommandLink
	Private c1CommandLink66 As C1.Win.Command.C1CommandLink
	Private c1CommandLink67 As C1.Win.Command.C1CommandLink
	Private c1CommandLink68 As C1.Win.Command.C1CommandLink
	Private c1CommandLink72 As C1.Win.Command.C1CommandLink
	Private ctbEdit As C1.Win.Command.C1ToolBar
	Private c1CommandLink55 As C1.Win.Command.C1CommandLink
	Private c1CommandLink56 As C1.Win.Command.C1CommandLink
	Private c1CommandLink57 As C1.Win.Command.C1CommandLink
	Private c1CommandLink58 As C1.Win.Command.C1CommandLink
	Private c1CommandLink59 As C1.Win.Command.C1CommandLink
	Private c1CommandLink60 As C1.Win.Command.C1CommandLink
	Private ctbFile As C1.Win.Command.C1ToolBar
	Private c1CommandLink51 As C1.Win.Command.C1CommandLink
	Private c1CommandLink52 As C1.Win.Command.C1CommandLink
	Private c1CommandLink53 As C1.Win.Command.C1CommandLink
	Private c1CommandLink54 As C1.Win.Command.C1CommandLink
	Private cmmMain As C1.Win.Command.C1MainMenu
	Private c1CommandLink1 As C1.Win.Command.C1CommandLink
	Private c1CommandLink12 As C1.Win.Command.C1CommandLink
	Private c1CommandLink22 As C1.Win.Command.C1CommandLink
	Private c1CommandLink25 As C1.Win.Command.C1CommandLink
	Private c1CommandLink35 As C1.Win.Command.C1CommandLink
	Private c1CommandLink44 As C1.Win.Command.C1CommandLink
	Private cneCFGFrozenColCount As C1.Win.C1Input.C1NumericEdit
	Private cneCFGFrozenRowCount As C1.Win.C1Input.C1NumericEdit
	Private cddcFontName As C1.Win.C1Input.C1DropDownControl
	Private cddcFontSize As C1.Win.C1Input.C1DropDownControl
	Private ccmTheme As C1.Win.Command.C1CommandMenu
	Private c1CommandLink80 As C1.Win.Command.C1CommandLink
	Private ilMain2 As System.Windows.Forms.ImageList
	Private ilMain As System.Windows.Forms.ImageList
	Private c1CommandDock1 As C1.Win.Command.C1CommandDock
	Private c1DockingTab1 As C1.Win.Command.C1DockingTab
	Private c1DockingTabPage1 As C1.Win.Command.C1DockingTabPage
	Private c1OutBar1 As C1.Win.Command.C1OutBar
	Private copC1FlexGrid As C1.Win.Command.C1OutPage
	Private ctbC1FlexGrid As C1.Win.Command.C1ToolBar
	Private c1CommandLink81 As C1.Win.Command.C1CommandLink
	Private c1CommandLink82 As C1.Win.Command.C1CommandLink
    Private c1CommandLink83 As C1.Win.Command.C1CommandLink
    Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private c1Label4 As C1.Win.C1Input.C1Label
	Private c1Label3 As C1.Win.C1Input.C1Label
	Private csbFocusRect As C1.Win.C1Input.C1SplitButton
	Private csbSelectionMode As C1.Win.C1Input.C1SplitButton
	Private ccbShowCursor As C1.Win.C1Input.C1CheckBox
	Private c1Label2 As C1.Win.C1Input.C1Label
	Private cneFixedRowCount As C1.Win.C1Input.C1NumericEdit
	Private cneFixedColCount As C1.Win.C1Input.C1NumericEdit
	Private c1Label1 As C1.Win.C1Input.C1Label
	Private copC1TrueDBGrid As C1.Win.Command.C1OutPage
	Private ctbC1TrueDBGridView As C1.Win.Command.C1ToolBar
	Private c1CommandLink84 As C1.Win.Command.C1CommandLink
	Private c1CommandLink85 As C1.Win.Command.C1CommandLink
	Private c1CommandLink86 As C1.Win.Command.C1CommandLink
	Private c1CommandLink87 As C1.Win.Command.C1CommandLink
	Private c1CommandLink88 As C1.Win.Command.C1CommandLink
	Private c1CommandLink89 As C1.Win.Command.C1CommandLink
	Private panel2 As System.Windows.Forms.Panel
	Private ccbCTDBGShowFilterBar As C1.Win.C1Input.C1CheckBox
	Private ccbCTDBGShowCaption As C1.Win.C1Input.C1CheckBox
	Private copC1Schedule As C1.Win.Command.C1OutPage
	Private ctbC1ScheduleView As C1.Win.Command.C1ToolBar
	Private c1CommandLink90 As C1.Win.Command.C1CommandLink
	Private c1CommandLink91 As C1.Win.Command.C1CommandLink
	Private c1CommandLink92 As C1.Win.Command.C1CommandLink
	Private c1CommandLink93 As C1.Win.Command.C1CommandLink
	Private c1CommandLink94 As C1.Win.Command.C1CommandLink
	Private panel3 As System.Windows.Forms.Panel
	Private ccbCSOffice2003WeekView As C1.Win.C1Input.C1CheckBox
	Private ccbCSEnableGrouping As C1.Win.C1Input.C1CheckBox
	Private c1DockingTabPage2 As C1.Win.Command.C1DockingTabPage
	Private c1NavBar1 As C1.Win.Command.C1NavBar
	Private c1NavBarPanel5 As C1.Win.Command.C1NavBarPanel
	Private ctbMain As C1.Win.Command.C1TopicBar
	Private c1NavBarPanel2 As C1.Win.Command.C1NavBarPanel
	Private c1Calendar1 As C1.Win.Schedule.C1Calendar
	Private c1NavBarPanel3 As C1.Win.Command.C1NavBarPanel
	Private label1 As System.Windows.Forms.Label
	Private c1NavBarPanel4 As C1.Win.Command.C1NavBarPanel
	Private label2 As System.Windows.Forms.Label
	Private c1DockingTab2 As C1.Win.Command.C1DockingTab
	Private c1DockingTabPage3 As C1.Win.Command.C1DockingTabPage
	Private c1FlexGrid1 As C1.Win.FlexGrid.C1FlexGrid
	Private c1DockingTabPage4 As C1.Win.Command.C1DockingTabPage
	Private c1TrueDBGrid1 As C1.Win.TrueDBGrid.C1TrueDBGrid
	Private c1DockingTabPage5 As C1.Win.Command.C1DockingTabPage
	Private csMain As C1.Win.Schedule.C1Schedule
	Private c1DockingTabPage6 As C1.Win.Command.C1DockingTabPage
	Private c1GanttView1 As C1.Win.GanttView.C1GanttView
	Private c1NWINDDataSet As C1NWINDDataSet
	Private employeesBindingSource As System.Windows.Forms.BindingSource
	Private employeesTableAdapter As C1NWINDDataSetTableAdapters.EmployeesTableAdapter
	Private c1ThemeController1 As C1.Win.Themes.C1ThemeController
End Class

