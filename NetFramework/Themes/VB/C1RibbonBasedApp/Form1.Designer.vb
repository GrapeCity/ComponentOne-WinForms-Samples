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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim C1TopicPage1 As C1.Win.C1Command.C1TopicPage = New C1.Win.C1Command.C1TopicPage()
        Dim C1TopicLink1 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink2 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink3 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink4 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink5 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink6 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicPage2 As C1.Win.C1Command.C1TopicPage = New C1.Win.C1Command.C1TopicPage()
        Dim C1TopicLink7 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink8 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim C1TopicLink9 As C1.Win.C1Command.C1TopicLink = New C1.Win.C1Command.C1TopicLink()
        Dim PrintStyle1 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle()
        Dim PrintStyle2 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle()
        Dim PrintStyle3 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle()
        Dim PrintStyle4 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle()
        Dim PrintStyle5 As C1.C1Schedule.Printing.PrintStyle = New C1.C1Schedule.Printing.PrintStyle()
        Dim BarStyle1 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle2 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle3 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle4 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle5 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle6 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle7 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle8 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle9 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle10 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle11 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle12 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle13 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle14 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle15 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle16 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim BarStyle17 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
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
        Dim ResourceRef1 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef2 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef3 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task3 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task4 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle18 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor1 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef4 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task5 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task6 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor2 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef5 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef6 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task7 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task8 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor3 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef7 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef8 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task9 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task10 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim BarStyle19 As C1.Win.C1GanttView.BarStyle = New C1.Win.C1GanttView.BarStyle()
        Dim Predecessor4 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef9 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim ResourceRef10 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
        Dim Task11 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Task12 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Dim Predecessor5 As C1.Win.C1GanttView.Predecessor = New C1.Win.C1GanttView.Predecessor()
        Dim ResourceRef11 As C1.Win.C1GanttView.ResourceRef = New C1.Win.C1GanttView.ResourceRef()
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
        Dim Task28 As C1.Win.C1GanttView.Task = New C1.Win.C1GanttView.Task()
        Me.ilMain2 = New System.Windows.Forms.ImageList(Me.components)
        Me.c1ThemeController1 = New C1.Win.C1Themes.C1ThemeController()
        Me.crMain = New C1.Win.Ribbon.C1Ribbon()
        Me.appMenu = New C1.Win.Ribbon.RibbonApplicationMenu()
        Me.optionsButton = New C1.Win.Ribbon.RibbonButton()
        Me.exitButton = New C1.Win.Ribbon.RibbonButton()
        Me.newButton = New C1.Win.Ribbon.RibbonButton()
        Me.openButton = New C1.Win.Ribbon.RibbonButton()
        Me.saveButton = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonSeparator9 = New C1.Win.Ribbon.RibbonSeparator()
        Me.printSplitButton = New C1.Win.Ribbon.RibbonSplitButton()
        Me.printMenuLabel = New C1.Win.Ribbon.RibbonLabel()
        Me.printButton = New C1.Win.Ribbon.RibbonButton()
        Me.quickPrintButton = New C1.Win.Ribbon.RibbonButton()
        Me.previewButton = New C1.Win.Ribbon.RibbonButton()
        Me.prepareMenu = New C1.Win.Ribbon.RibbonMenu()
        Me.prepareMenuLabel = New C1.Win.Ribbon.RibbonLabel()
        Me.propertiesButton = New C1.Win.Ribbon.RibbonButton()
        Me.inspectDocumentButton = New C1.Win.Ribbon.RibbonButton()
        Me.encryptDocumentButton = New C1.Win.Ribbon.RibbonButton()
        Me.restrictPermissionMenu = New C1.Win.Ribbon.RibbonMenu()
        Me.unrestrictedAccessToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.restrictedAccessToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonSeparator11 = New C1.Win.Ribbon.RibbonSeparator()
        Me.manageCredentialsButton = New C1.Win.Ribbon.RibbonButton()
        Me.addSignatureButton = New C1.Win.Ribbon.RibbonButton()
        Me.markAsFinalButton = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonSeparator10 = New C1.Win.Ribbon.RibbonSeparator()
        Me.closeButton = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonListItem1 = New C1.Win.Ribbon.RibbonListItem()
        Me.recentDocumentsLabel = New C1.Win.Ribbon.RibbonLabel()
        Me.ribbonListItem2 = New C1.Win.Ribbon.RibbonListItem()
        Me.ribbonSeparator12 = New C1.Win.Ribbon.RibbonSeparator()
        Me.ribbonListItem3 = New C1.Win.Ribbon.RibbonListItem()
        Me.rcListLabel1 = New C1.Win.Ribbon.RibbonLabel()
        Me.rcListPinButton1 = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonListItem4 = New C1.Win.Ribbon.RibbonListItem()
        Me.rcListLabel2 = New C1.Win.Ribbon.RibbonLabel()
        Me.rcListPinButton2 = New C1.Win.Ribbon.RibbonToggleButton()
        Me.RibbonBottomToolBar1 = New C1.Win.Ribbon.RibbonBottomToolBar()
        Me.configToolBar = New C1.Win.Ribbon.RibbonConfigToolBar()
        Me.themeMenu = New C1.Win.Ribbon.RibbonMenu()
        Me.minimizeRibbonButton = New C1.Win.Ribbon.RibbonButton()
        Me.expandRibbonButton = New C1.Win.Ribbon.RibbonButton()
        Me.helpConfigButton = New C1.Win.Ribbon.RibbonButton()
        Me.rctgC1FlexGrid = New C1.Win.Ribbon.RibbonContextualTabGroup()
        Me.rtC1FlexGrid = New C1.Win.Ribbon.RibbonTab()
        Me.rgCFGView = New C1.Win.Ribbon.RibbonGroup()
        Me.rglrCFGView = New C1.Win.Ribbon.RibbonGallery()
        Me.rgiCFGViewNormal = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgiCFGViewTree = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgiCFGViewSubtotals = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgCFGOptions = New C1.Win.Ribbon.RibbonGroup()
        Me.rnbCFGFixedColCount = New C1.Win.Ribbon.RibbonNumericBox()
        Me.rnbCFGFixedRowCount = New C1.Win.Ribbon.RibbonNumericBox()
        Me.ribbonSeparator13 = New C1.Win.Ribbon.RibbonSeparator()
        Me.rcbCFGSelectionMode = New C1.Win.Ribbon.RibbonComboBox()
        Me.rcbCFGFocusRect = New C1.Win.Ribbon.RibbonComboBox()
        Me.ribbonSeparator15 = New C1.Win.Ribbon.RibbonSeparator()
        Me.rcbCFGShowCursor = New C1.Win.Ribbon.RibbonCheckBox()
        Me.rctgC1TrueDBGrid = New C1.Win.Ribbon.RibbonContextualTabGroup()
        Me.rtC1TrueDBGrid = New C1.Win.Ribbon.RibbonTab()
        Me.rgCTDBGView = New C1.Win.Ribbon.RibbonGroup()
        Me.rglrCTDBGView = New C1.Win.Ribbon.RibbonGallery()
        Me.rgiCTDBGViewNormal = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgiCTDBGViewInverted = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgiCTDBGViewForm = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgiCTDBGViewGroupBy = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgiCTDBGViewMultipleLines = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgiCTDBGViewHierarchical = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgCTDBGOptions = New C1.Win.Ribbon.RibbonGroup()
        Me.rcbCTDBGShowCaption = New C1.Win.Ribbon.RibbonCheckBox()
        Me.rcbCTDBGShowFilterBar = New C1.Win.Ribbon.RibbonCheckBox()
        Me.rctgC1Schedule = New C1.Win.Ribbon.RibbonContextualTabGroup()
        Me.rtC1Schedule = New C1.Win.Ribbon.RibbonTab()
        Me.rgCSView = New C1.Win.Ribbon.RibbonGroup()
        Me.rglrCSView = New C1.Win.Ribbon.RibbonGallery()
        Me.rgiCSViewDay = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgiCSViewWorkWeek = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgiCSViewWeek = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgiCSViewMonth = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgiCSViewTimeLine = New C1.Win.Ribbon.RibbonGalleryItem()
        Me.rgCSOptions = New C1.Win.Ribbon.RibbonGroup()
        Me.rcbCSEnableGrouping = New C1.Win.Ribbon.RibbonCheckBox()
        Me.rcbCSOffice2003WeekView = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ilLarge = New System.Windows.Forms.ImageList(Me.components)
        Me.qat = New C1.Win.Ribbon.RibbonQat()
        Me.undoSplitButton = New C1.Win.Ribbon.RibbonSplitButton()
        Me.redoButton = New C1.Win.Ribbon.RibbonButton()
        Me.ilSmall = New System.Windows.Forms.ImageList(Me.components)
        Me.homeTab = New C1.Win.Ribbon.RibbonTab()
        Me.clipboardGroup = New C1.Win.Ribbon.RibbonGroup()
        Me.pasteSplitButton = New C1.Win.Ribbon.RibbonSplitButton()
        Me.pasteButton = New C1.Win.Ribbon.RibbonButton()
        Me.pasteSpecialButton = New C1.Win.Ribbon.RibbonButton()
        Me.cutButton = New C1.Win.Ribbon.RibbonButton()
        Me.copyButton = New C1.Win.Ribbon.RibbonButton()
        Me.formatPainterButton = New C1.Win.Ribbon.RibbonButton()
        Me.fontGroup = New C1.Win.Ribbon.RibbonGroup()
        Me.ribbonToolBar1 = New C1.Win.Ribbon.RibbonToolBar()
        Me.fontComboBox = New C1.Win.Ribbon.RibbonFontComboBox()
        Me.fontSizeComboBox = New C1.Win.Ribbon.RibbonComboBox()
        Me.size8Button = New C1.Win.Ribbon.RibbonButton()
        Me.size9Button = New C1.Win.Ribbon.RibbonButton()
        Me.size10Button = New C1.Win.Ribbon.RibbonButton()
        Me.size11Button = New C1.Win.Ribbon.RibbonButton()
        Me.size12Button = New C1.Win.Ribbon.RibbonButton()
        Me.size14Button = New C1.Win.Ribbon.RibbonButton()
        Me.size16Button = New C1.Win.Ribbon.RibbonButton()
        Me.size18Button = New C1.Win.Ribbon.RibbonButton()
        Me.size20Button = New C1.Win.Ribbon.RibbonButton()
        Me.size22Button = New C1.Win.Ribbon.RibbonButton()
        Me.size24Button = New C1.Win.Ribbon.RibbonButton()
        Me.size26Button = New C1.Win.Ribbon.RibbonButton()
        Me.size28Button = New C1.Win.Ribbon.RibbonButton()
        Me.size36Button = New C1.Win.Ribbon.RibbonButton()
        Me.size48Button = New C1.Win.Ribbon.RibbonButton()
        Me.size72Button = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonSeparator2 = New C1.Win.Ribbon.RibbonSeparator()
        Me.growFontButton = New C1.Win.Ribbon.RibbonButton()
        Me.shrinkFontButton = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonSeparator3 = New C1.Win.Ribbon.RibbonSeparator()
        Me.clearFormattingButton = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonToolBar2 = New C1.Win.Ribbon.RibbonToolBar()
        Me.boldToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.italicToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.underlineSplitButton = New C1.Win.Ribbon.RibbonSplitButton()
        Me.subscriptToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.superscriptToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.changeCaseMenu = New C1.Win.Ribbon.RibbonMenu()
        Me.caseMenuOption1 = New C1.Win.Ribbon.RibbonButton()
        Me.caseMenuOption2 = New C1.Win.Ribbon.RibbonButton()
        Me.caseMenuOption3 = New C1.Win.Ribbon.RibbonButton()
        Me.caseMenuOption4 = New C1.Win.Ribbon.RibbonButton()
        Me.caseMenuOption5 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonSeparator16 = New C1.Win.Ribbon.RibbonSeparator()
        Me.ribbonButton4 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonSeparator4 = New C1.Win.Ribbon.RibbonSeparator()
        Me.highlightColorSplitButton = New C1.Win.Ribbon.RibbonSplitButton()
        Me.highlightTextColorPickerItem = New C1.Win.Ribbon.RibbonColorPickerItem()
        Me.ribbonSeparator14 = New C1.Win.Ribbon.RibbonSeparator()
        Me.noColorToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.fontColorPicker = New C1.Win.Ribbon.RibbonColorPicker()
        Me.alignmentGroup = New C1.Win.Ribbon.RibbonGroup()
        Me.ribbonToolBar3 = New C1.Win.Ribbon.RibbonToolBar()
        Me.topAlignToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.middleAlignToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.bottomAlignToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonSeparator5 = New C1.Win.Ribbon.RibbonSeparator()
        Me.orientationMenu = New C1.Win.Ribbon.RibbonMenu()
        Me.ribbonToolBar4 = New C1.Win.Ribbon.RibbonToolBar()
        Me.alignLeftToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.centerToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.alignRightToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonSeparator6 = New C1.Win.Ribbon.RibbonSeparator()
        Me.decreaseIndentButton = New C1.Win.Ribbon.RibbonButton()
        Me.increaseIndentButton = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonSeparator7 = New C1.Win.Ribbon.RibbonSeparator()
        Me.wrapTextToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.mergeSplitButton = New C1.Win.Ribbon.RibbonSplitButton()
        Me.mergeAndCenterButton = New C1.Win.Ribbon.RibbonButton()
        Me.mergeCellsButton = New C1.Win.Ribbon.RibbonButton()
        Me.unmergeCellsButton = New C1.Win.Ribbon.RibbonButton()
        Me.viewTab = New C1.Win.Ribbon.RibbonTab()
        Me.viewsGroup = New C1.Win.Ribbon.RibbonGroup()
        Me.printLayoutToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.fullScreenToggleButton = New C1.Win.Ribbon.RibbonToggleButton()
        Me.hideShowGroup = New C1.Win.Ribbon.RibbonGroup()
        Me.rulerCheckBox = New C1.Win.Ribbon.RibbonCheckBox()
        Me.gridlinesCheckBox = New C1.Win.Ribbon.RibbonCheckBox()
        Me.messageBarCheckBox = New C1.Win.Ribbon.RibbonCheckBox()
        Me.zoomGroup = New C1.Win.Ribbon.RibbonGroup()
        Me.zoomButton = New C1.Win.Ribbon.RibbonButton()
        Me.onePageButton = New C1.Win.Ribbon.RibbonButton()
        Me.twoPagesButton = New C1.Win.Ribbon.RibbonButton()
        Me.pageWidthButton = New C1.Win.Ribbon.RibbonButton()
        Me.windowGroup = New C1.Win.Ribbon.RibbonGroup()
        Me.newWindowButton = New C1.Win.Ribbon.RibbonButton()
        Me.arrangeAllButton = New C1.Win.Ribbon.RibbonButton()
        Me.splitWindowButton = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonSeparator8 = New C1.Win.Ribbon.RibbonSeparator()
        Me.switchWindowsMenu = New C1.Win.Ribbon.RibbonMenu()
        Me.rtControls = New C1.Win.Ribbon.RibbonTab()
        Me.rgControlsNormal = New C1.Win.Ribbon.RibbonGroup()
        Me.ribbonButton2 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton3 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonToolBar5 = New C1.Win.Ribbon.RibbonToolBar()
        Me.ribbonToggleButton4 = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonToggleButton5 = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonToggleButton6 = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonColorPicker1 = New C1.Win.Ribbon.RibbonColorPicker()
        Me.ribbonSplitButton1 = New C1.Win.Ribbon.RibbonSplitButton()
        Me.ribbonButton5 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton6 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton7 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton8 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonSeparator17 = New C1.Win.Ribbon.RibbonSeparator()
        Me.ribbonCheckBox1 = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ribbonCheckBox2 = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ribbonSeparator18 = New C1.Win.Ribbon.RibbonSeparator()
        Me.ribbonComboBox1 = New C1.Win.Ribbon.RibbonComboBox()
        Me.ribbonButton9 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton10 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonDatePicker1 = New C1.Win.Ribbon.RibbonDatePicker()
        Me.ribbonNumericBox1 = New C1.Win.Ribbon.RibbonNumericBox()
        Me.ribbonTextBox1 = New C1.Win.Ribbon.RibbonTextBox()
        Me.ribbonTimePicker1 = New C1.Win.Ribbon.RibbonTimePicker()
        Me.ribbonSeparator19 = New C1.Win.Ribbon.RibbonSeparator()
        Me.ribbonProgressBar1 = New C1.Win.Ribbon.RibbonProgressBar()
        Me.ribbonTrackBar2 = New C1.Win.Ribbon.RibbonTrackBar()
        Me.rgControlsDisabled = New C1.Win.Ribbon.RibbonGroup()
        Me.ribbonButton21 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton31 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonToolBar51 = New C1.Win.Ribbon.RibbonToolBar()
        Me.ribbonToggleButton41 = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonToggleButton51 = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonToggleButton61 = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonColorPicker11 = New C1.Win.Ribbon.RibbonColorPicker()
        Me.ribbonSplitButton11 = New C1.Win.Ribbon.RibbonSplitButton()
        Me.ribbonButton51 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton61 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton71 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton81 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonSeparator171 = New C1.Win.Ribbon.RibbonSeparator()
        Me.ribbonCheckBox11 = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ribbonCheckBox21 = New C1.Win.Ribbon.RibbonCheckBox()
        Me.ribbonSeparator181 = New C1.Win.Ribbon.RibbonSeparator()
        Me.ribbonComboBox11 = New C1.Win.Ribbon.RibbonComboBox()
        Me.ribbonButton91 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonButton101 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonDatePicker11 = New C1.Win.Ribbon.RibbonDatePicker()
        Me.ribbonNumericBox11 = New C1.Win.Ribbon.RibbonNumericBox()
        Me.ribbonTextBox11 = New C1.Win.Ribbon.RibbonTextBox()
        Me.ribbonTimePicker11 = New C1.Win.Ribbon.RibbonTimePicker()
        Me.ribbonSeparator191 = New C1.Win.Ribbon.RibbonSeparator()
        Me.ribbonProgressBar11 = New C1.Win.Ribbon.RibbonProgressBar()
        Me.ribbonTrackBar21 = New C1.Win.Ribbon.RibbonTrackBar()
        Me.RibbonTopToolBar1 = New C1.Win.Ribbon.RibbonTopToolBar()
        Me.c1StatusBar1 = New C1.Win.Ribbon.C1StatusBar()
        Me.ribbonLabel1 = New C1.Win.Ribbon.RibbonLabel()
        Me.ribbonButton1 = New C1.Win.Ribbon.RibbonButton()
        Me.ribbonToggleButton1 = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonToggleButton2 = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonToggleButton3 = New C1.Win.Ribbon.RibbonToggleButton()
        Me.ribbonSeparator1 = New C1.Win.Ribbon.RibbonSeparator()
        Me.ribbonTrackBar1 = New C1.Win.Ribbon.RibbonTrackBar()
        Me.c1NavBar1 = New C1.Win.C1Command.C1NavBar()
        Me.c1NavBarPanel5 = New C1.Win.C1Command.C1NavBarPanel()
        Me.ctbMain = New C1.Win.C1Command.C1TopicBar()
        Me.c1NavBarPanel2 = New C1.Win.C1Command.C1NavBarPanel()
        Me.c1Calendar1 = New C1.Win.C1Schedule.C1Calendar()
        Me.c1NavBarPanel3 = New C1.Win.C1Command.C1NavBarPanel()
        Me.label1 = New System.Windows.Forms.Label()
        Me.c1NavBarPanel4 = New C1.Win.C1Command.C1NavBarPanel()
        Me.label2 = New System.Windows.Forms.Label()
        Me.c1CommandDock1 = New C1.Win.C1Command.C1CommandDock()
        Me.c1DockingTab1 = New C1.Win.C1Command.C1DockingTab()
        Me.c1DockingTabPage1 = New C1.Win.C1Command.C1DockingTabPage()
        Me.c1OutBar1 = New C1.Win.C1Command.C1OutBar()
        Me.copC1FlexGrid = New C1.Win.C1Command.C1OutPage()
        Me.ctbC1FlexGrid = New C1.Win.C1Command.C1ToolBar()
        Me.cchMain = New C1.Win.C1Command.C1CommandHolder()
        Me.ccCTDBGViewNormal = New C1.Win.C1Command.C1Command()
        Me.ccCTDBGViewInverted = New C1.Win.C1Command.C1Command()
        Me.ccCTDBGViewForm = New C1.Win.C1Command.C1Command()
        Me.ccCTDBGViewGroupBy = New C1.Win.C1Command.C1Command()
        Me.ccCTDBGViewMultipleLines = New C1.Win.C1Command.C1Command()
        Me.ccCTDBGViewHierarchical = New C1.Win.C1Command.C1Command()
        Me.ccCFGViewNormal = New C1.Win.C1Command.C1Command()
        Me.ccCFGViewTree = New C1.Win.C1Command.C1Command()
        Me.ccCFGViewSubtotals = New C1.Win.C1Command.C1Command()
        Me.ccCSViewDay = New C1.Win.C1Command.C1Command()
        Me.ccCSViewWorkWeek = New C1.Win.C1Command.C1Command()
        Me.ccCSViewWeek = New C1.Win.C1Command.C1Command()
        Me.ccCSViewMonth = New C1.Win.C1Command.C1Command()
        Me.ccCSViewTimeLine = New C1.Win.C1Command.C1Command()
        Me.ilMain = New System.Windows.Forms.ImageList(Me.components)
        Me.c1CommandLink1 = New C1.Win.C1Command.C1CommandLink()
        Me.c1CommandLink2 = New C1.Win.C1Command.C1CommandLink()
        Me.c1CommandLink3 = New C1.Win.C1Command.C1CommandLink()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.csbFocusRect = New C1.Win.C1Input.C1SplitButton()
        Me.c1Label4 = New C1.Win.C1Input.C1Label()
        Me.csbSelectionMode = New C1.Win.C1Input.C1SplitButton()
        Me.c1Label2 = New C1.Win.C1Input.C1Label()
        Me.cneFixedRowCount = New C1.Win.C1Input.C1NumericEdit()
        Me.ccbShowCursor = New C1.Win.C1Input.C1CheckBox()
        Me.cneFixedColCount = New C1.Win.C1Input.C1NumericEdit()
        Me.c1Label3 = New C1.Win.C1Input.C1Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.copC1TrueDBGrid = New C1.Win.C1Command.C1OutPage()
        Me.ctbC1TrueDBGridView = New C1.Win.C1Command.C1ToolBar()
        Me.c1CommandLink4 = New C1.Win.C1Command.C1CommandLink()
        Me.c1CommandLink5 = New C1.Win.C1Command.C1CommandLink()
        Me.c1CommandLink6 = New C1.Win.C1Command.C1CommandLink()
        Me.c1CommandLink7 = New C1.Win.C1Command.C1CommandLink()
        Me.c1CommandLink8 = New C1.Win.C1Command.C1CommandLink()
        Me.c1CommandLink9 = New C1.Win.C1Command.C1CommandLink()
        Me.panel2 = New System.Windows.Forms.Panel()
        Me.ccbCTDBGShowFilterBar = New C1.Win.C1Input.C1CheckBox()
        Me.ccbCTDBGShowCaption = New C1.Win.C1Input.C1CheckBox()
        Me.copC1Schedule = New C1.Win.C1Command.C1OutPage()
        Me.ctbC1ScheduleView = New C1.Win.C1Command.C1ToolBar()
        Me.c1CommandLink10 = New C1.Win.C1Command.C1CommandLink()
        Me.c1CommandLink11 = New C1.Win.C1Command.C1CommandLink()
        Me.c1CommandLink12 = New C1.Win.C1Command.C1CommandLink()
        Me.c1CommandLink13 = New C1.Win.C1Command.C1CommandLink()
        Me.c1CommandLink14 = New C1.Win.C1Command.C1CommandLink()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.ccbCSOffice2003WeekView = New C1.Win.C1Input.C1CheckBox()
        Me.ccbCSEnableGrouping = New C1.Win.C1Input.C1CheckBox()
        Me.c1DockingTabPage2 = New C1.Win.C1Command.C1DockingTabPage()
        Me.c1DockingTab2 = New C1.Win.C1Command.C1DockingTab()
        Me.c1DockingTabPage3 = New C1.Win.C1Command.C1DockingTabPage()
        Me.c1FlexGrid1 = New C1.Win.C1FlexGrid.C1FlexGrid()
        Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.c1NWINDDataSet = New C1RibbonBasedApp.C1NWINDDataSet()
        Me.c1DockingTabPage4 = New C1.Win.C1Command.C1DockingTabPage()
        Me.c1TrueDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.c1DockingTabPage5 = New C1.Win.C1Command.C1DockingTabPage()
        Me.csMain = New C1.Win.C1Schedule.C1Schedule()
        Me.c1DockingTabPage6 = New C1.Win.C1Command.C1DockingTabPage()
        Me.c1GanttView1 = New C1.Win.C1GanttView.C1GanttView()
        Me.employeesTableAdapter = New C1RibbonBasedApp.C1NWINDDataSetTableAdapters.EmployeesTableAdapter()
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.crMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1StatusBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1NavBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1NavBar1.SuspendLayout()
        Me.c1NavBarPanel5.SuspendLayout()
        CType(Me.ctbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1NavBarPanel2.SuspendLayout()
        CType(Me.c1Calendar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1NavBarPanel3.SuspendLayout()
        Me.c1NavBarPanel4.SuspendLayout()
        CType(Me.c1CommandDock1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1CommandDock1.SuspendLayout()
        CType(Me.c1DockingTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1DockingTab1.SuspendLayout()
        Me.c1DockingTabPage1.SuspendLayout()
        CType(Me.c1OutBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1OutBar1.SuspendLayout()
        Me.copC1FlexGrid.SuspendLayout()
        CType(Me.cchMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.csbFocusRect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.csbSelectionMode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cneFixedRowCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccbShowCursor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cneFixedColCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.copC1TrueDBGrid.SuspendLayout()
        Me.panel2.SuspendLayout()
        CType(Me.ccbCTDBGShowFilterBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccbCTDBGShowCaption, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.copC1Schedule.SuspendLayout()
        Me.panel3.SuspendLayout()
        CType(Me.ccbCSOffice2003WeekView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ccbCSEnableGrouping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1DockingTab2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1DockingTab2.SuspendLayout()
        Me.c1DockingTabPage3.SuspendLayout()
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1NWINDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1DockingTabPage4.SuspendLayout()
        CType(Me.c1TrueDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1DockingTabPage5.SuspendLayout()
        CType(Me.csMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.csMain.DataStorage.AppointmentStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.csMain.DataStorage.CategoryStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.csMain.DataStorage.ContactStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.csMain.DataStorage.LabelStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.csMain.DataStorage.OwnerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.csMain.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.csMain.DataStorage.StatusStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.c1DockingTabPage6.SuspendLayout()
        CType(Me.c1GanttView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1GanttView1.DataStorage.CalendarStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1GanttView1.DataStorage.PropertyStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1GanttView1.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.c1GanttView1.DataStorage.TasksStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ilMain2
        '
        Me.ilMain2.ImageStream = CType(resources.GetObject("ilMain2.ImageStream"), System.Windows.Forms.ImageListStreamer)
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
        'crMain
        '
        Me.crMain.ApplicationMenuHolder = Me.appMenu
        Me.crMain.AutoSizeElement = C1.Framework.AutoSizeElement.Width
        Me.crMain.BottomToolBarHolder = Me.RibbonBottomToolBar1
        Me.crMain.ConfigToolBarHolder = Me.configToolBar
        Me.crMain.ContextualTabGroups.Add(Me.rctgC1FlexGrid)
        Me.crMain.ContextualTabGroups.Add(Me.rctgC1TrueDBGrid)
        Me.crMain.ContextualTabGroups.Add(Me.rctgC1Schedule)
        Me.crMain.LargeImageList = Me.ilLarge
        Me.crMain.Location = New System.Drawing.Point(0, 0)
        Me.crMain.Margin = New System.Windows.Forms.Padding(5)
        Me.crMain.MinimumHeight = 200
        Me.crMain.MinimumWidth = 250
        Me.crMain.Name = "crMain"
        Me.crMain.QatHolder = Me.qat
        Me.crMain.QatItemsHolder.Add(Me.undoSplitButton)
        Me.crMain.QatItemsHolder.Add(Me.redoButton)
        Me.crMain.Size = New System.Drawing.Size(1236, 146)
        Me.crMain.SmallImageList = Me.ilSmall
        Me.crMain.Tabs.Add(Me.homeTab)
        Me.crMain.Tabs.Add(Me.viewTab)
        Me.crMain.Tabs.Add(Me.rtControls)
        Me.c1ThemeController1.SetTheme(Me.crMain, "(default)")
        Me.crMain.TopToolBarHolder = Me.RibbonTopToolBar1
        '
        'appMenu
        '
        Me.appMenu.BottomPaneItems.Add(Me.optionsButton)
        Me.appMenu.BottomPaneItems.Add(Me.exitButton)
        Me.appMenu.DropDownWidth = 394
        Me.appMenu.KeyTip = "F"
        Me.appMenu.LeftPaneItems.Add(Me.newButton)
        Me.appMenu.LeftPaneItems.Add(Me.openButton)
        Me.appMenu.LeftPaneItems.Add(Me.saveButton)
        Me.appMenu.LeftPaneItems.Add(Me.ribbonSeparator9)
        Me.appMenu.LeftPaneItems.Add(Me.printSplitButton)
        Me.appMenu.LeftPaneItems.Add(Me.prepareMenu)
        Me.appMenu.LeftPaneItems.Add(Me.ribbonSeparator10)
        Me.appMenu.LeftPaneItems.Add(Me.closeButton)
        Me.appMenu.Name = "appMenu"
        Me.appMenu.RightPaneItems.Add(Me.ribbonListItem1)
        Me.appMenu.RightPaneItems.Add(Me.ribbonListItem2)
        Me.appMenu.RightPaneItems.Add(Me.ribbonListItem3)
        Me.appMenu.RightPaneItems.Add(Me.ribbonListItem4)
        Me.appMenu.Text = "FILE"
        Me.appMenu.ToolTip = "Application Button"
        '
        'optionsButton
        '
        Me.optionsButton.Name = "optionsButton"
        Me.optionsButton.SmallImage = CType(resources.GetObject("optionsButton.SmallImage"), System.Drawing.Image)
        Me.optionsButton.Text = "Opt&ions"
        '
        'exitButton
        '
        Me.exitButton.Name = "exitButton"
        Me.exitButton.SmallImage = CType(resources.GetObject("exitButton.SmallImage"), System.Drawing.Image)
        Me.exitButton.Text = "E&xit"
        '
        'newButton
        '
        Me.newButton.LargeImage = CType(resources.GetObject("newButton.LargeImage"), System.Drawing.Image)
        Me.newButton.Name = "newButton"
        Me.newButton.SmallImage = CType(resources.GetObject("newButton.SmallImage"), System.Drawing.Image)
        Me.newButton.Text = "&New"
        Me.newButton.ToolTip = "New (Ctrl+P)"
        '
        'openButton
        '
        Me.openButton.LargeImage = CType(resources.GetObject("openButton.LargeImage"), System.Drawing.Image)
        Me.openButton.Name = "openButton"
        Me.openButton.SmallImage = CType(resources.GetObject("openButton.SmallImage"), System.Drawing.Image)
        Me.openButton.Text = "&Open"
        Me.openButton.ToolTip = "Open (Ctrl+O)"
        '
        'saveButton
        '
        Me.saveButton.LargeImage = CType(resources.GetObject("saveButton.LargeImage"), System.Drawing.Image)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.saveButton.SmallImage = CType(resources.GetObject("saveButton.SmallImage"), System.Drawing.Image)
        Me.saveButton.Text = "&Save"
        Me.saveButton.ToolTip = "Save (Ctrl+S)"
        '
        'ribbonSeparator9
        '
        Me.ribbonSeparator9.Name = "ribbonSeparator9"
        '
        'printSplitButton
        '
        Me.printSplitButton.Items.Add(Me.printMenuLabel)
        Me.printSplitButton.Items.Add(Me.printButton)
        Me.printSplitButton.Items.Add(Me.quickPrintButton)
        Me.printSplitButton.Items.Add(Me.previewButton)
        Me.printSplitButton.LargeImage = CType(resources.GetObject("printSplitButton.LargeImage"), System.Drawing.Image)
        Me.printSplitButton.Name = "printSplitButton"
        Me.printSplitButton.Text = "&Print"
        '
        'printMenuLabel
        '
        Me.printMenuLabel.Name = "printMenuLabel"
        Me.printMenuLabel.Text = "Preview and print the document"
        '
        'printButton
        '
        Me.printButton.Description = "Select a printer, number of copies, and other options before printing."
        Me.printButton.LargeImage = CType(resources.GetObject("printButton.LargeImage"), System.Drawing.Image)
        Me.printButton.Name = "printButton"
        Me.printButton.Text = "&Print"
        '
        'quickPrintButton
        '
        Me.quickPrintButton.Description = "Send the document directly to the default printer without making changes."
        Me.quickPrintButton.LargeImage = CType(resources.GetObject("quickPrintButton.LargeImage"), System.Drawing.Image)
        Me.quickPrintButton.Name = "quickPrintButton"
        Me.quickPrintButton.SmallImage = CType(resources.GetObject("quickPrintButton.SmallImage"), System.Drawing.Image)
        Me.quickPrintButton.Text = "&Quick Print"
        '
        'previewButton
        '
        Me.previewButton.Description = "Preview and make changes to pages before printing."
        Me.previewButton.LargeImage = CType(resources.GetObject("previewButton.LargeImage"), System.Drawing.Image)
        Me.previewButton.Name = "previewButton"
        Me.previewButton.SmallImage = CType(resources.GetObject("previewButton.SmallImage"), System.Drawing.Image)
        Me.previewButton.Text = "Print Pre&view"
        '
        'prepareMenu
        '
        Me.prepareMenu.Items.Add(Me.prepareMenuLabel)
        Me.prepareMenu.Items.Add(Me.propertiesButton)
        Me.prepareMenu.Items.Add(Me.inspectDocumentButton)
        Me.prepareMenu.Items.Add(Me.encryptDocumentButton)
        Me.prepareMenu.Items.Add(Me.restrictPermissionMenu)
        Me.prepareMenu.Items.Add(Me.addSignatureButton)
        Me.prepareMenu.Items.Add(Me.markAsFinalButton)
        Me.prepareMenu.LargeImage = CType(resources.GetObject("prepareMenu.LargeImage"), System.Drawing.Image)
        Me.prepareMenu.Name = "prepareMenu"
        Me.prepareMenu.Text = "Pr&epare"
        '
        'prepareMenuLabel
        '
        Me.prepareMenuLabel.Name = "prepareMenuLabel"
        Me.prepareMenuLabel.Text = "Prepare the document for distribution"
        '
        'propertiesButton
        '
        Me.propertiesButton.Description = "View and edit document properties, such as Title, Author, and Keywords."
        Me.propertiesButton.LargeImage = CType(resources.GetObject("propertiesButton.LargeImage"), System.Drawing.Image)
        Me.propertiesButton.Name = "propertiesButton"
        Me.propertiesButton.Text = "&Properties"
        '
        'inspectDocumentButton
        '
        Me.inspectDocumentButton.Description = "Check the document for hidden metadata or personal information."
        Me.inspectDocumentButton.LargeImage = CType(resources.GetObject("inspectDocumentButton.LargeImage"), System.Drawing.Image)
        Me.inspectDocumentButton.Name = "inspectDocumentButton"
        Me.inspectDocumentButton.Text = "&Inspect Document"
        '
        'encryptDocumentButton
        '
        Me.encryptDocumentButton.Description = "Increase the security of the document by adding encryption."
        Me.encryptDocumentButton.LargeImage = CType(resources.GetObject("encryptDocumentButton.LargeImage"), System.Drawing.Image)
        Me.encryptDocumentButton.Name = "encryptDocumentButton"
        Me.encryptDocumentButton.Text = "&Encrypt Document"
        '
        'restrictPermissionMenu
        '
        Me.restrictPermissionMenu.Description = "Grant people access with restricting their ability to edit, copy, and print."
        Me.restrictPermissionMenu.Items.Add(Me.unrestrictedAccessToggleButton)
        Me.restrictPermissionMenu.Items.Add(Me.restrictedAccessToggleButton)
        Me.restrictPermissionMenu.Items.Add(Me.ribbonSeparator11)
        Me.restrictPermissionMenu.Items.Add(Me.manageCredentialsButton)
        Me.restrictPermissionMenu.LargeImage = CType(resources.GetObject("restrictPermissionMenu.LargeImage"), System.Drawing.Image)
        Me.restrictPermissionMenu.Name = "restrictPermissionMenu"
        Me.restrictPermissionMenu.Text = "&Restrict Permission"
        '
        'unrestrictedAccessToggleButton
        '
        Me.unrestrictedAccessToggleButton.CanDepress = False
        Me.unrestrictedAccessToggleButton.Name = "unrestrictedAccessToggleButton"
        Me.unrestrictedAccessToggleButton.Pressed = True
        Me.unrestrictedAccessToggleButton.Text = "&Unrestricted Access"
        Me.unrestrictedAccessToggleButton.ToggleGroupName = "accessGroup"
        '
        'restrictedAccessToggleButton
        '
        Me.restrictedAccessToggleButton.CanDepress = False
        Me.restrictedAccessToggleButton.Name = "restrictedAccessToggleButton"
        Me.restrictedAccessToggleButton.Text = "&Restricted Access"
        Me.restrictedAccessToggleButton.ToggleGroupName = "accessGroup"
        '
        'ribbonSeparator11
        '
        Me.ribbonSeparator11.Name = "ribbonSeparator11"
        '
        'manageCredentialsButton
        '
        Me.manageCredentialsButton.Name = "manageCredentialsButton"
        Me.manageCredentialsButton.Text = "&Manage Credentials"
        '
        'addSignatureButton
        '
        Me.addSignatureButton.Description = "Insure the integrity of the document by adding an invisible digital signature."
        Me.addSignatureButton.LargeImage = CType(resources.GetObject("addSignatureButton.LargeImage"), System.Drawing.Image)
        Me.addSignatureButton.Name = "addSignatureButton"
        Me.addSignatureButton.Text = "Add a Digital &Signature"
        '
        'markAsFinalButton
        '
        Me.markAsFinalButton.Description = "Let readers know the document is final and make it read-only."
        Me.markAsFinalButton.LargeImage = CType(resources.GetObject("markAsFinalButton.LargeImage"), System.Drawing.Image)
        Me.markAsFinalButton.Name = "markAsFinalButton"
        Me.markAsFinalButton.Text = "Mark as &Final"
        '
        'ribbonSeparator10
        '
        Me.ribbonSeparator10.Name = "ribbonSeparator10"
        '
        'closeButton
        '
        Me.closeButton.LargeImage = CType(resources.GetObject("closeButton.LargeImage"), System.Drawing.Image)
        Me.closeButton.Name = "closeButton"
        Me.closeButton.Text = "&Close"
        '
        'ribbonListItem1
        '
        Me.ribbonListItem1.AllowSelection = False
        Me.ribbonListItem1.Items.Add(Me.recentDocumentsLabel)
        Me.ribbonListItem1.Name = "ribbonListItem1"
        '
        'recentDocumentsLabel
        '
        Me.recentDocumentsLabel.Name = "recentDocumentsLabel"
        Me.recentDocumentsLabel.Text = "Recent Documents"
        '
        'ribbonListItem2
        '
        Me.ribbonListItem2.Items.Add(Me.ribbonSeparator12)
        Me.ribbonListItem2.Name = "ribbonListItem2"
        '
        'ribbonSeparator12
        '
        Me.ribbonSeparator12.Name = "ribbonSeparator12"
        '
        'ribbonListItem3
        '
        Me.ribbonListItem3.Items.Add(Me.rcListLabel1)
        Me.ribbonListItem3.Items.Add(Me.rcListPinButton1)
        Me.ribbonListItem3.Name = "ribbonListItem3"
        '
        'rcListLabel1
        '
        Me.rcListLabel1.Name = "rcListLabel1"
        Me.rcListLabel1.Text = "&1  C# Language Specification.doc"
        '
        'rcListPinButton1
        '
        Me.rcListPinButton1.KeyTip = "Y1"
        Me.rcListPinButton1.Name = "rcListPinButton1"
        Me.rcListPinButton1.Pressed = True
        Me.rcListPinButton1.SelectableInListItem = True
        '
        'ribbonListItem4
        '
        Me.ribbonListItem4.Items.Add(Me.rcListLabel2)
        Me.ribbonListItem4.Items.Add(Me.rcListPinButton2)
        Me.ribbonListItem4.Name = "ribbonListItem4"
        '
        'rcListLabel2
        '
        Me.rcListLabel2.Name = "rcListLabel2"
        Me.rcListLabel2.Text = "&2  Readme.doc"
        '
        'rcListPinButton2
        '
        Me.rcListPinButton2.KeyTip = "Y2"
        Me.rcListPinButton2.Name = "rcListPinButton2"
        Me.rcListPinButton2.SelectableInListItem = True
        '
        'RibbonBottomToolBar1
        '
        Me.RibbonBottomToolBar1.Name = "RibbonBottomToolBar1"
        '
        'configToolBar
        '
        Me.configToolBar.Items.Add(Me.themeMenu)
        Me.configToolBar.Items.Add(Me.minimizeRibbonButton)
        Me.configToolBar.Items.Add(Me.expandRibbonButton)
        Me.configToolBar.Items.Add(Me.helpConfigButton)
        Me.configToolBar.Name = "configToolBar"
        '
        'themeMenu
        '
        Me.themeMenu.KeyTip = "T"
        Me.themeMenu.Name = "themeMenu"
        Me.themeMenu.SmallImage = CType(resources.GetObject("themeMenu.SmallImage"), System.Drawing.Image)
        Me.themeMenu.Text = "Theme"
        Me.themeMenu.ToolTip = resources.GetString("themeMenu.ToolTip")
        '
        'minimizeRibbonButton
        '
        Me.minimizeRibbonButton.KeyTip = "M"
        Me.minimizeRibbonButton.Name = "minimizeRibbonButton"
        Me.minimizeRibbonButton.SmallImage = ilSmall.Images("MinimizeRibbon.png")
        Me.minimizeRibbonButton.ToolTip = "Minimize the Ribbon"
        '
        'expandRibbonButton
        '
        Me.expandRibbonButton.KeyTip = "M"
        Me.expandRibbonButton.Name = "expandRibbonButton"
        Me.expandRibbonButton.SmallImage = CType(resources.GetObject("expandRibbonButton.SmallImage"), System.Drawing.Image)
        Me.expandRibbonButton.ToolTip = "Expand the Ribbon"
        Me.expandRibbonButton.Visible = False
        '
        'helpConfigButton
        '
        Me.helpConfigButton.Name = "helpConfigButton"
        Me.helpConfigButton.SmallImage = CType(resources.GetObject("helpConfigButton.SmallImage"), System.Drawing.Image)
        Me.helpConfigButton.ToolTip = "Help"
        '
        'rctgC1FlexGrid
        '
        Me.rctgC1FlexGrid.Color = C1.Win.Ribbon.ContextualTabColor.Blue
        Me.rctgC1FlexGrid.Name = "rctgC1FlexGrid"
        Me.rctgC1FlexGrid.Tabs.Add(Me.rtC1FlexGrid)
        Me.rctgC1FlexGrid.Text = "C1FlexGrid"
        '
        'rtC1FlexGrid
        '
        Me.rtC1FlexGrid.Groups.Add(Me.rgCFGView)
        Me.rtC1FlexGrid.Groups.Add(Me.rgCFGOptions)
        Me.rtC1FlexGrid.KeyTip = "F"
        Me.rtC1FlexGrid.Name = "rtC1FlexGrid"
        Me.rtC1FlexGrid.Text = "C1FlexGrid"
        '
        'rgCFGView
        '
        Me.rgCFGView.Items.Add(Me.rglrCFGView)
        Me.rgCFGView.Name = "rgCFGView"
        Me.rgCFGView.Text = "View"
        '
        'rglrCFGView
        '
        Me.rglrCFGView.Items.Add(Me.rgiCFGViewNormal)
        Me.rglrCFGView.Items.Add(Me.rgiCFGViewTree)
        Me.rglrCFGView.Items.Add(Me.rgiCFGViewSubtotals)
        Me.rglrCFGView.Name = "rglrCFGView"
        Me.rglrCFGView.Text = "C1FlexGrid View"
        '
        'rgiCFGViewNormal
        '
        Me.rgiCFGViewNormal.LargeImage = ilLarge.Images("TableInsertGallery.png")
        Me.rgiCFGViewNormal.Name = "rgiCFGViewNormal"
        Me.rgiCFGViewNormal.Tag = "Normal"
        Me.rgiCFGViewNormal.Text = "Normal"
        '
        'rgiCFGViewTree
        '
        Me.rgiCFGViewTree.LargeImage = ilLarge.Images("tree.png")
        Me.rgiCFGViewTree.Name = "rgiCFGViewTree"
        Me.rgiCFGViewTree.Tag = "Tree"
        Me.rgiCFGViewTree.Text = "Tree"
        '
        'rgiCFGViewSubtotals
        '
        Me.rgiCFGViewSubtotals.LargeImage = ilLarge.Images("OutlineSubtotals.png")
        Me.rgiCFGViewSubtotals.Name = "rgiCFGViewSubtotals"
        Me.rgiCFGViewSubtotals.Tag = "Subtotals"
        Me.rgiCFGViewSubtotals.Text = "Subtotatls"
        '
        'rgCFGOptions
        '
        Me.rgCFGOptions.Items.Add(Me.rnbCFGFixedColCount)
        Me.rgCFGOptions.Items.Add(Me.rnbCFGFixedRowCount)
        Me.rgCFGOptions.Items.Add(Me.ribbonSeparator13)
        Me.rgCFGOptions.Items.Add(Me.rcbCFGSelectionMode)
        Me.rgCFGOptions.Items.Add(Me.rcbCFGFocusRect)
        Me.rgCFGOptions.Items.Add(Me.ribbonSeparator15)
        Me.rgCFGOptions.Items.Add(Me.rcbCFGShowCursor)
        Me.rgCFGOptions.Name = "rgCFGOptions"
        Me.rgCFGOptions.Text = "Options"
        '
        'rnbCFGFixedColCount
        '
        Me.rnbCFGFixedColCount.Label = "Fixed column count:"
        Me.rnbCFGFixedColCount.LabelWidth = 122
        Me.rnbCFGFixedColCount.Name = "rnbCFGFixedColCount"
        '
        'rnbCFGFixedRowCount
        '
        Me.rnbCFGFixedRowCount.Label = "Fixed row count:"
        Me.rnbCFGFixedRowCount.LabelWidth = 122
        Me.rnbCFGFixedRowCount.Name = "rnbCFGFixedRowCount"
        '
        'ribbonSeparator13
        '
        Me.ribbonSeparator13.Name = "ribbonSeparator13"
        '
        'rcbCFGSelectionMode
        '
        Me.rcbCFGSelectionMode.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        Me.rcbCFGSelectionMode.Label = "Selection mode:"
        Me.rcbCFGSelectionMode.LabelWidth = 110
        Me.rcbCFGSelectionMode.Name = "rcbCFGSelectionMode"
        '
        'rcbCFGFocusRect
        '
        Me.rcbCFGFocusRect.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList
        Me.rcbCFGFocusRect.Label = "Focus Rect:"
        Me.rcbCFGFocusRect.LabelWidth = 110
        Me.rcbCFGFocusRect.Name = "rcbCFGFocusRect"
        '
        'ribbonSeparator15
        '
        Me.ribbonSeparator15.Name = "ribbonSeparator15"
        '
        'rcbCFGShowCursor
        '
        Me.rcbCFGShowCursor.Name = "rcbCFGShowCursor"
        Me.rcbCFGShowCursor.Text = "Show Cursor"
        '
        'rctgC1TrueDBGrid
        '
        Me.rctgC1TrueDBGrid.Color = C1.Win.Ribbon.ContextualTabColor.Cyan
        Me.rctgC1TrueDBGrid.Name = "rctgC1TrueDBGrid"
        Me.rctgC1TrueDBGrid.Tabs.Add(Me.rtC1TrueDBGrid)
        Me.rctgC1TrueDBGrid.Text = "C1TrueDBGrid"
        '
        'rtC1TrueDBGrid
        '
        Me.rtC1TrueDBGrid.Groups.Add(Me.rgCTDBGView)
        Me.rtC1TrueDBGrid.Groups.Add(Me.rgCTDBGOptions)
        Me.rtC1TrueDBGrid.Name = "rtC1TrueDBGrid"
        Me.rtC1TrueDBGrid.Text = "C1TrueDBGrid"
        '
        'rgCTDBGView
        '
        Me.rgCTDBGView.Items.Add(Me.rglrCTDBGView)
        Me.rgCTDBGView.Name = "rgCTDBGView"
        Me.rgCTDBGView.Text = "View"
        '
        'rglrCTDBGView
        '
        Me.rglrCTDBGView.Items.Add(Me.rgiCTDBGViewNormal)
        Me.rglrCTDBGView.Items.Add(Me.rgiCTDBGViewInverted)
        Me.rglrCTDBGView.Items.Add(Me.rgiCTDBGViewForm)
        Me.rglrCTDBGView.Items.Add(Me.rgiCTDBGViewGroupBy)
        Me.rglrCTDBGView.Items.Add(Me.rgiCTDBGViewMultipleLines)
        Me.rglrCTDBGView.Items.Add(Me.rgiCTDBGViewHierarchical)
        Me.rglrCTDBGView.Name = "rglrCTDBGView"
        Me.rglrCTDBGView.Text = "Gallery"
        Me.rglrCTDBGView.VisibleItems = 6
        '
        'rgiCTDBGViewNormal
        '
        Me.rgiCTDBGViewNormal.LargeImage = ilLarge.Images("NormalLarge.png")
        Me.rgiCTDBGViewNormal.Name = "rgiCTDBGViewNormal"
        Me.rgiCTDBGViewNormal.Tag = "Normal"
        Me.rgiCTDBGViewNormal.Text = "Normal"
        '
        'rgiCTDBGViewInverted
        '
        Me.rgiCTDBGViewInverted.LargeImage = ilLarge.Images("InvertedLarge.png")
        Me.rgiCTDBGViewInverted.Name = "rgiCTDBGViewInverted"
        Me.rgiCTDBGViewInverted.Tag = "Inverted"
        Me.rgiCTDBGViewInverted.Text = "Inverted"
        '
        'rgiCTDBGViewForm
        '
        Me.rgiCTDBGViewForm.LargeImage = ilLarge.Images("FormViewLarge.png")
        Me.rgiCTDBGViewForm.Name = "rgiCTDBGViewForm"
        Me.rgiCTDBGViewForm.Tag = "Form"
        Me.rgiCTDBGViewForm.Text = "Form"
        '
        'rgiCTDBGViewGroupBy
        '
        Me.rgiCTDBGViewGroupBy.LargeImage = ilLarge.Images("GroupByLarge.png")
        Me.rgiCTDBGViewGroupBy.Name = "rgiCTDBGViewGroupBy"
        Me.rgiCTDBGViewGroupBy.Tag = "GroupBy"
        Me.rgiCTDBGViewGroupBy.Text = "Grouped"
        '
        'rgiCTDBGViewMultipleLines
        '
        Me.rgiCTDBGViewMultipleLines.LargeImage = ilLarge.Images("MultilineLarge.png")
        Me.rgiCTDBGViewMultipleLines.Name = "rgiCTDBGViewMultipleLines"
        Me.rgiCTDBGViewMultipleLines.Tag = "MultipleLines"
        Me.rgiCTDBGViewMultipleLines.Text = "Multiple"
        '
        'rgiCTDBGViewHierarchical
        '
        Me.rgiCTDBGViewHierarchical.LargeImage = ilLarge.Images("HierarchicalLarge.png")
        Me.rgiCTDBGViewHierarchical.Name = "rgiCTDBGViewHierarchical"
        Me.rgiCTDBGViewHierarchical.Tag = "Hierarchical"
        Me.rgiCTDBGViewHierarchical.Text = "Hierarchical"
        '
        'rgCTDBGOptions
        '
        Me.rgCTDBGOptions.Items.Add(Me.rcbCTDBGShowCaption)
        Me.rgCTDBGOptions.Items.Add(Me.rcbCTDBGShowFilterBar)
        Me.rgCTDBGOptions.Name = "rgCTDBGOptions"
        Me.rgCTDBGOptions.Text = "Options"
        '
        'rcbCTDBGShowCaption
        '
        Me.rcbCTDBGShowCaption.Name = "rcbCTDBGShowCaption"
        Me.rcbCTDBGShowCaption.Text = "Show Caption"
        '
        'rcbCTDBGShowFilterBar
        '
        Me.rcbCTDBGShowFilterBar.Name = "rcbCTDBGShowFilterBar"
        Me.rcbCTDBGShowFilterBar.Text = "Show Filter Bar"
        '
        'rctgC1Schedule
        '
        Me.rctgC1Schedule.Color = C1.Win.Ribbon.ContextualTabColor.Green
        Me.rctgC1Schedule.Name = "rctgC1Schedule"
        Me.rctgC1Schedule.Tabs.Add(Me.rtC1Schedule)
        Me.rctgC1Schedule.Text = "C1Schedule"
        '
        'rtC1Schedule
        '
        Me.rtC1Schedule.Groups.Add(Me.rgCSView)
        Me.rtC1Schedule.Groups.Add(Me.rgCSOptions)
        Me.rtC1Schedule.Name = "rtC1Schedule"
        Me.rtC1Schedule.Text = "C1Schedule"
        '
        'rgCSView
        '
        Me.rgCSView.Items.Add(Me.rglrCSView)
        Me.rgCSView.Name = "rgCSView"
        Me.rgCSView.Text = "View"
        '
        'rglrCSView
        '
        Me.rglrCSView.Items.Add(Me.rgiCSViewDay)
        Me.rglrCSView.Items.Add(Me.rgiCSViewWorkWeek)
        Me.rglrCSView.Items.Add(Me.rgiCSViewWeek)
        Me.rglrCSView.Items.Add(Me.rgiCSViewMonth)
        Me.rglrCSView.Items.Add(Me.rgiCSViewTimeLine)
        Me.rglrCSView.Name = "rglrCSView"
        Me.rglrCSView.Text = "Gallery"
        Me.rglrCSView.VisibleItems = 5
        '
        'rgiCSViewDay
        '
        Me.rgiCSViewDay.LargeImage = ilLarge.Images("DailyView.png")
        Me.rgiCSViewDay.Name = "rgiCSViewDay"
        Me.rgiCSViewDay.Tag = "DayView"
        Me.rgiCSViewDay.Text = "Day"
        '
        'rgiCSViewWorkWeek
        '
        Me.rgiCSViewWorkWeek.LargeImage = ilLarge.Images("WorkWeek.png")
        Me.rgiCSViewWorkWeek.Name = "rgiCSViewWorkWeek"
        Me.rgiCSViewWorkWeek.Tag = "WorkWeekView"
        Me.rgiCSViewWorkWeek.Text = "Work Week"
        '
        'rgiCSViewWeek
        '
        Me.rgiCSViewWeek.LargeImage = ilLarge.Images("WeeklyView.png")
        Me.rgiCSViewWeek.Name = "rgiCSViewWeek"
        Me.rgiCSViewWeek.Tag = "WeekView"
        Me.rgiCSViewWeek.Text = "Week"
        '
        'rgiCSViewMonth
        '
        Me.rgiCSViewMonth.LargeImage = ilLarge.Images("MonthlyView.png")
        Me.rgiCSViewMonth.Name = "rgiCSViewMonth"
        Me.rgiCSViewMonth.Tag = "MonthView"
        Me.rgiCSViewMonth.Text = "Month"
        '
        'rgiCSViewTimeLine
        '
        Me.rgiCSViewTimeLine.LargeImage = ilLarge.Images("TimeScaleMenu.png")
        Me.rgiCSViewTimeLine.Name = "rgiCSViewTimeLine"
        Me.rgiCSViewTimeLine.Tag = "TimeLineView"
        Me.rgiCSViewTimeLine.Text = "Time Line"
        '
        'rgCSOptions
        '
        Me.rgCSOptions.Items.Add(Me.rcbCSEnableGrouping)
        Me.rgCSOptions.Items.Add(Me.rcbCSOffice2003WeekView)
        Me.rgCSOptions.Name = "rgCSOptions"
        Me.rgCSOptions.Text = "Options"
        '
        'rcbCSEnableGrouping
        '
        Me.rcbCSEnableGrouping.Name = "rcbCSEnableGrouping"
        Me.rcbCSEnableGrouping.Text = "Enable Grouping"
        '
        'rcbCSOffice2003WeekView
        '
        Me.rcbCSOffice2003WeekView.Name = "rcbCSOffice2003WeekView"
        Me.rcbCSOffice2003WeekView.Text = "Office 2003 Week View"
        '
        'ilLarge
        '
        Me.ilLarge.ImageStream = CType(resources.GetObject("ilLarge.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ilLarge.TransparentColor = System.Drawing.Color.Transparent
        Me.ilLarge.Images.SetKeyName(0, "TableInsertGallery.png")
        Me.ilLarge.Images.SetKeyName(1, "tree.png")
        Me.ilLarge.Images.SetKeyName(2, "OutlineSubtotals.png")
        Me.ilLarge.Images.SetKeyName(3, "NormalLarge.png")
        Me.ilLarge.Images.SetKeyName(4, "InvertedLarge.png")
        Me.ilLarge.Images.SetKeyName(5, "FormViewLarge.png")
        Me.ilLarge.Images.SetKeyName(6, "GroupByLarge.png")
        Me.ilLarge.Images.SetKeyName(7, "MultilineLarge.png")
        Me.ilLarge.Images.SetKeyName(8, "HierarchicalLarge.png")
        Me.ilLarge.Images.SetKeyName(9, "DailyView.png")
        Me.ilLarge.Images.SetKeyName(10, "WeeklyView.png")
        Me.ilLarge.Images.SetKeyName(11, "WorkWeek.png")
        Me.ilLarge.Images.SetKeyName(12, "MonthlyView.png")
        Me.ilLarge.Images.SetKeyName(13, "TimeScaleMenu.png")
        Me.ilLarge.Images.SetKeyName(14, "Refresh.png")
        '
        'qat
        '
        Me.qat.HotItemLinks.Add(Me.newButton)
        Me.qat.HotItemLinks.Add(Me.openButton)
        Me.qat.HotItemLinks.Add(Me.saveButton)
        Me.qat.HotItemLinks.Add(Me.quickPrintButton)
        Me.qat.HotItemLinks.Add(Me.previewButton)
        Me.qat.HotItemLinks.Add(Me.themeMenu)
        Me.qat.ItemLinks.Add(Me.themeMenu)
        Me.qat.Name = "qat"
        '
        'undoSplitButton
        '
        Me.undoSplitButton.Name = "undoSplitButton"
        Me.undoSplitButton.SmallImage = CType(resources.GetObject("undoSplitButton.SmallImage"), System.Drawing.Image)
        Me.undoSplitButton.Text = "Undo"
        Me.undoSplitButton.ToolTip = "Undo (Ctrl+Z)"
        '
        'redoButton
        '
        Me.redoButton.Name = "redoButton"
        Me.redoButton.SmallImage = CType(resources.GetObject("redoButton.SmallImage"), System.Drawing.Image)
        Me.redoButton.Text = "Redo"
        Me.redoButton.ToolTip = "Redo (Ctrl+Y)"
        '
        'ilSmall
        '
        Me.ilSmall.ImageStream = CType(resources.GetObject("ilSmall.ImageStream"), System.Windows.Forms.ImageListStreamer)
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
        Me.ilSmall.Images.SetKeyName(49, "MinimizeRibbon.png")
        Me.ilSmall.Images.SetKeyName(50, "MaximizeRibbon.png")
        '
        'homeTab
        '
        Me.homeTab.Groups.Add(Me.clipboardGroup)
        Me.homeTab.Groups.Add(Me.fontGroup)
        Me.homeTab.Groups.Add(Me.alignmentGroup)
        Me.homeTab.KeyTip = "H"
        Me.homeTab.Name = "homeTab"
        Me.homeTab.Text = "HOME"
        '
        'clipboardGroup
        '
        Me.clipboardGroup.GroupKeyTip = "ZO"
        Me.clipboardGroup.HasLauncherButton = True
        Me.clipboardGroup.Image = CType(resources.GetObject("clipboardGroup.Image"), System.Drawing.Image)
        Me.clipboardGroup.Items.Add(Me.pasteSplitButton)
        Me.clipboardGroup.Items.Add(Me.cutButton)
        Me.clipboardGroup.Items.Add(Me.copyButton)
        Me.clipboardGroup.Items.Add(Me.formatPainterButton)
        Me.clipboardGroup.LauncherKeyTip = "FO"
        Me.clipboardGroup.Name = "clipboardGroup"
        Me.clipboardGroup.Text = "Clipboard"
        '
        'pasteSplitButton
        '
        Me.pasteSplitButton.Items.Add(Me.pasteButton)
        Me.pasteSplitButton.Items.Add(Me.pasteSpecialButton)
        Me.pasteSplitButton.KeyTip = "V"
        Me.pasteSplitButton.LargeImage = CType(resources.GetObject("pasteSplitButton.LargeImage"), System.Drawing.Image)
        Me.pasteSplitButton.Name = "pasteSplitButton"
        Me.pasteSplitButton.SmallImage = CType(resources.GetObject("pasteSplitButton.SmallImage"), System.Drawing.Image)
        Me.pasteSplitButton.SupportedGroupSizing = C1.Win.Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.pasteSplitButton.Text = "Paste"
        Me.pasteSplitButton.ToggleOnClick = True
        '
        'pasteButton
        '
        Me.pasteButton.KeyTip = "T"
        Me.pasteButton.Name = "pasteButton"
        Me.pasteButton.ShortcutKeyDisplayString = "UU"
        Me.pasteButton.SmallImage = CType(resources.GetObject("pasteButton.SmallImage"), System.Drawing.Image)
        Me.pasteButton.Text = "Paste"
        '
        'pasteSpecialButton
        '
        Me.pasteSpecialButton.KeyTip = "S"
        Me.pasteSpecialButton.Name = "pasteSpecialButton"
        Me.pasteSpecialButton.SmallImage = CType(resources.GetObject("pasteSpecialButton.SmallImage"), System.Drawing.Image)
        Me.pasteSpecialButton.Text = "Paste Special..."
        '
        'cutButton
        '
        Me.cutButton.KeyTip = "X"
        Me.cutButton.Name = "cutButton"
        Me.cutButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.cutButton.SmallImage = CType(resources.GetObject("cutButton.SmallImage"), System.Drawing.Image)
        Me.cutButton.Text = "Cut"
        Me.cutButton.ToolTip = "Cut (Ctrl+X)"
        '
        'copyButton
        '
        Me.copyButton.KeyTip = "C"
        Me.copyButton.Name = "copyButton"
        Me.copyButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.copyButton.SmallImage = CType(resources.GetObject("copyButton.SmallImage"), System.Drawing.Image)
        Me.copyButton.Text = "Copy"
        Me.copyButton.ToolTip = "Copy (Ctrl+C)"
        '
        'formatPainterButton
        '
        Me.formatPainterButton.KeyTip = "FP"
        Me.formatPainterButton.Name = "formatPainterButton"
        Me.formatPainterButton.SmallImage = CType(resources.GetObject("formatPainterButton.SmallImage"), System.Drawing.Image)
        Me.formatPainterButton.Text = "Format Painter"
        Me.formatPainterButton.ToolTip = "Format Painter"
        '
        'fontGroup
        '
        Me.fontGroup.GroupKeyTip = "ZF"
        Me.fontGroup.HasLauncherButton = True
        Me.fontGroup.Image = CType(resources.GetObject("fontGroup.Image"), System.Drawing.Image)
        Me.fontGroup.Items.Add(Me.ribbonToolBar1)
        Me.fontGroup.Items.Add(Me.ribbonToolBar2)
        Me.fontGroup.LauncherKeyTip = "FN"
        Me.fontGroup.LauncherToolTip = "Launcher Tooltip"
        Me.fontGroup.Name = "fontGroup"
        Me.fontGroup.Text = "Font"
        '
        'ribbonToolBar1
        '
        Me.ribbonToolBar1.Items.Add(Me.fontComboBox)
        Me.ribbonToolBar1.Items.Add(Me.fontSizeComboBox)
        Me.ribbonToolBar1.Items.Add(Me.ribbonSeparator2)
        Me.ribbonToolBar1.Items.Add(Me.growFontButton)
        Me.ribbonToolBar1.Items.Add(Me.shrinkFontButton)
        Me.ribbonToolBar1.Items.Add(Me.ribbonSeparator3)
        Me.ribbonToolBar1.Items.Add(Me.clearFormattingButton)
        Me.ribbonToolBar1.Name = "ribbonToolBar1"
        '
        'fontComboBox
        '
        Me.fontComboBox.GripHandleVisible = True
        Me.fontComboBox.KeyTip = "FF"
        Me.fontComboBox.MaxDropDownItems = 16
        Me.fontComboBox.Name = "fontComboBox"
        Me.fontComboBox.Text = "Arial"
        Me.fontComboBox.TextAreaWidth = 90
        Me.fontComboBox.ToolTip = "Font"
        '
        'fontSizeComboBox
        '
        Me.fontSizeComboBox.GripHandleVisible = True
        Me.fontSizeComboBox.Items.Add(Me.size8Button)
        Me.fontSizeComboBox.Items.Add(Me.size9Button)
        Me.fontSizeComboBox.Items.Add(Me.size10Button)
        Me.fontSizeComboBox.Items.Add(Me.size11Button)
        Me.fontSizeComboBox.Items.Add(Me.size12Button)
        Me.fontSizeComboBox.Items.Add(Me.size14Button)
        Me.fontSizeComboBox.Items.Add(Me.size16Button)
        Me.fontSizeComboBox.Items.Add(Me.size18Button)
        Me.fontSizeComboBox.Items.Add(Me.size20Button)
        Me.fontSizeComboBox.Items.Add(Me.size22Button)
        Me.fontSizeComboBox.Items.Add(Me.size24Button)
        Me.fontSizeComboBox.Items.Add(Me.size26Button)
        Me.fontSizeComboBox.Items.Add(Me.size28Button)
        Me.fontSizeComboBox.Items.Add(Me.size36Button)
        Me.fontSizeComboBox.Items.Add(Me.size48Button)
        Me.fontSizeComboBox.Items.Add(Me.size72Button)
        Me.fontSizeComboBox.KeyTip = "FS"
        Me.fontSizeComboBox.MaxDropDownItems = 100
        Me.fontSizeComboBox.Name = "fontSizeComboBox"
        Me.fontSizeComboBox.Text = "12"
        Me.fontSizeComboBox.TextAreaWidth = 30
        Me.fontSizeComboBox.ToolTip = "Font Size"
        '
        'size8Button
        '
        Me.size8Button.Name = "size8Button"
        Me.size8Button.Text = "8"
        '
        'size9Button
        '
        Me.size9Button.Name = "size9Button"
        Me.size9Button.Text = "9"
        '
        'size10Button
        '
        Me.size10Button.Name = "size10Button"
        Me.size10Button.Text = "10"
        '
        'size11Button
        '
        Me.size11Button.Name = "size11Button"
        Me.size11Button.Text = "11"
        '
        'size12Button
        '
        Me.size12Button.Name = "size12Button"
        Me.size12Button.Text = "12"
        '
        'size14Button
        '
        Me.size14Button.Name = "size14Button"
        Me.size14Button.Text = "14"
        '
        'size16Button
        '
        Me.size16Button.Name = "size16Button"
        Me.size16Button.Text = "16"
        '
        'size18Button
        '
        Me.size18Button.Name = "size18Button"
        Me.size18Button.Text = "18"
        '
        'size20Button
        '
        Me.size20Button.Name = "size20Button"
        Me.size20Button.Text = "20"
        '
        'size22Button
        '
        Me.size22Button.Name = "size22Button"
        Me.size22Button.Text = "22"
        '
        'size24Button
        '
        Me.size24Button.Name = "size24Button"
        Me.size24Button.Text = "24"
        '
        'size26Button
        '
        Me.size26Button.Name = "size26Button"
        Me.size26Button.Text = "26"
        '
        'size28Button
        '
        Me.size28Button.Name = "size28Button"
        Me.size28Button.Text = "28"
        '
        'size36Button
        '
        Me.size36Button.Name = "size36Button"
        Me.size36Button.Text = "36"
        '
        'size48Button
        '
        Me.size48Button.Name = "size48Button"
        Me.size48Button.Text = "48"
        '
        'size72Button
        '
        Me.size72Button.Name = "size72Button"
        Me.size72Button.Text = "72"
        '
        'ribbonSeparator2
        '
        Me.ribbonSeparator2.Name = "ribbonSeparator2"
        '
        'growFontButton
        '
        Me.growFontButton.KeyTip = "FG"
        Me.growFontButton.Name = "growFontButton"
        Me.growFontButton.SmallImage = CType(resources.GetObject("growFontButton.SmallImage"), System.Drawing.Image)
        Me.growFontButton.ToolTip = "Grow Font"
        '
        'shrinkFontButton
        '
        Me.shrinkFontButton.KeyTip = "FK"
        Me.shrinkFontButton.Name = "shrinkFontButton"
        Me.shrinkFontButton.SmallImage = CType(resources.GetObject("shrinkFontButton.SmallImage"), System.Drawing.Image)
        Me.shrinkFontButton.ToolTip = "Shrink Font"
        '
        'ribbonSeparator3
        '
        Me.ribbonSeparator3.Name = "ribbonSeparator3"
        '
        'clearFormattingButton
        '
        Me.clearFormattingButton.KeyTip = "E"
        Me.clearFormattingButton.Name = "clearFormattingButton"
        Me.clearFormattingButton.SmallImage = CType(resources.GetObject("clearFormattingButton.SmallImage"), System.Drawing.Image)
        Me.clearFormattingButton.ToolTip = "Clear Formatting"
        '
        'ribbonToolBar2
        '
        Me.ribbonToolBar2.Items.Add(Me.boldToggleButton)
        Me.ribbonToolBar2.Items.Add(Me.italicToggleButton)
        Me.ribbonToolBar2.Items.Add(Me.underlineSplitButton)
        Me.ribbonToolBar2.Items.Add(Me.subscriptToggleButton)
        Me.ribbonToolBar2.Items.Add(Me.superscriptToggleButton)
        Me.ribbonToolBar2.Items.Add(Me.changeCaseMenu)
        Me.ribbonToolBar2.Items.Add(Me.ribbonSeparator4)
        Me.ribbonToolBar2.Items.Add(Me.highlightColorSplitButton)
        Me.ribbonToolBar2.Items.Add(Me.fontColorPicker)
        Me.ribbonToolBar2.Name = "ribbonToolBar2"
        '
        'boldToggleButton
        '
        Me.boldToggleButton.KeyTip = "1"
        Me.boldToggleButton.Name = "boldToggleButton"
        Me.boldToggleButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.boldToggleButton.SmallImage = CType(resources.GetObject("boldToggleButton.SmallImage"), System.Drawing.Image)
        Me.boldToggleButton.ToolTip = "Bold"
        '
        'italicToggleButton
        '
        Me.italicToggleButton.KeyTip = "2"
        Me.italicToggleButton.Name = "italicToggleButton"
        Me.italicToggleButton.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.italicToggleButton.SmallImage = CType(resources.GetObject("italicToggleButton.SmallImage"), System.Drawing.Image)
        Me.italicToggleButton.ToolTip = "Italic"
        '
        'underlineSplitButton
        '
        Me.underlineSplitButton.KeyTip = "3"
        Me.underlineSplitButton.Name = "underlineSplitButton"
        Me.underlineSplitButton.SmallImage = CType(resources.GetObject("underlineSplitButton.SmallImage"), System.Drawing.Image)
        Me.underlineSplitButton.ToolTip = "Underline"
        '
        'subscriptToggleButton
        '
        Me.subscriptToggleButton.KeyTip = "5"
        Me.subscriptToggleButton.Name = "subscriptToggleButton"
        Me.subscriptToggleButton.SmallImage = CType(resources.GetObject("subscriptToggleButton.SmallImage"), System.Drawing.Image)
        Me.subscriptToggleButton.ToggleGroupName = "scriptsGroup"
        Me.subscriptToggleButton.ToolTip = "Subscript"
        '
        'superscriptToggleButton
        '
        Me.superscriptToggleButton.KeyTip = "6"
        Me.superscriptToggleButton.Name = "superscriptToggleButton"
        Me.superscriptToggleButton.SmallImage = CType(resources.GetObject("superscriptToggleButton.SmallImage"), System.Drawing.Image)
        Me.superscriptToggleButton.ToggleGroupName = "scriptsGroup"
        Me.superscriptToggleButton.ToolTip = "Superscript"
        '
        'changeCaseMenu
        '
        Me.changeCaseMenu.Items.Add(Me.caseMenuOption1)
        Me.changeCaseMenu.Items.Add(Me.caseMenuOption2)
        Me.changeCaseMenu.Items.Add(Me.caseMenuOption3)
        Me.changeCaseMenu.Items.Add(Me.caseMenuOption4)
        Me.changeCaseMenu.Items.Add(Me.caseMenuOption5)
        Me.changeCaseMenu.Items.Add(Me.ribbonSeparator16)
        Me.changeCaseMenu.Items.Add(Me.ribbonButton4)
        Me.changeCaseMenu.KeyTip = "7"
        Me.changeCaseMenu.Name = "changeCaseMenu"
        Me.changeCaseMenu.SmallImage = CType(resources.GetObject("changeCaseMenu.SmallImage"), System.Drawing.Image)
        Me.changeCaseMenu.ToolTip = "Change Case"
        '
        'caseMenuOption1
        '
        Me.caseMenuOption1.Name = "caseMenuOption1"
        Me.caseMenuOption1.Text = "&Sentence case."
        '
        'caseMenuOption2
        '
        Me.caseMenuOption2.Name = "caseMenuOption2"
        Me.caseMenuOption2.Text = "&lowercase"
        '
        'caseMenuOption3
        '
        Me.caseMenuOption3.Name = "caseMenuOption3"
        Me.caseMenuOption3.Text = "&UPPERCASE"
        '
        'caseMenuOption4
        '
        Me.caseMenuOption4.Name = "caseMenuOption4"
        Me.caseMenuOption4.Text = "&Capitalize Each Word"
        '
        'caseMenuOption5
        '
        Me.caseMenuOption5.Name = "caseMenuOption5"
        Me.caseMenuOption5.Text = "&tOGGLE cASE"
        '
        'ribbonSeparator16
        '
        Me.ribbonSeparator16.Name = "ribbonSeparator16"
        '
        'ribbonButton4
        '
        Me.ribbonButton4.Name = "ribbonButton4"
        Me.ribbonButton4.SmallImage = CType(resources.GetObject("ribbonButton4.SmallImage"), System.Drawing.Image)
        Me.ribbonButton4.Text = "Button"
        '
        'ribbonSeparator4
        '
        Me.ribbonSeparator4.Name = "ribbonSeparator4"
        '
        'highlightColorSplitButton
        '
        Me.highlightColorSplitButton.Items.Add(Me.highlightTextColorPickerItem)
        Me.highlightColorSplitButton.Items.Add(Me.ribbonSeparator14)
        Me.highlightColorSplitButton.Items.Add(Me.noColorToggleButton)
        Me.highlightColorSplitButton.KeyTip = "I"
        Me.highlightColorSplitButton.Name = "highlightColorSplitButton"
        Me.highlightColorSplitButton.SmallImage = CType(resources.GetObject("highlightColorSplitButton.SmallImage"), System.Drawing.Image)
        Me.highlightColorSplitButton.ToolTip = "Text Highlight Color"
        '
        'highlightTextColorPickerItem
        '
        Me.highlightTextColorPickerItem.Name = "highlightTextColorPickerItem"
        '
        'ribbonSeparator14
        '
        Me.ribbonSeparator14.Name = "ribbonSeparator14"
        '
        'noColorToggleButton
        '
        Me.noColorToggleButton.Name = "noColorToggleButton"
        Me.noColorToggleButton.Text = "&No Color"
        '
        'fontColorPicker
        '
        Me.fontColorPicker.KeyTip = "FC"
        Me.fontColorPicker.Name = "fontColorPicker"
        Me.fontColorPicker.SmallImage = CType(resources.GetObject("fontColorPicker.SmallImage"), System.Drawing.Image)
        Me.fontColorPicker.ToolTip = "Font Color"
        '
        'alignmentGroup
        '
        Me.alignmentGroup.GroupKeyTip = "ZA"
        Me.alignmentGroup.HasLauncherButton = True
        Me.alignmentGroup.Image = CType(resources.GetObject("alignmentGroup.Image"), System.Drawing.Image)
        Me.alignmentGroup.Items.Add(Me.ribbonToolBar3)
        Me.alignmentGroup.Items.Add(Me.ribbonToolBar4)
        Me.alignmentGroup.Items.Add(Me.ribbonSeparator7)
        Me.alignmentGroup.Items.Add(Me.wrapTextToggleButton)
        Me.alignmentGroup.Items.Add(Me.mergeSplitButton)
        Me.alignmentGroup.LauncherKeyTip = "FA"
        Me.alignmentGroup.Name = "alignmentGroup"
        Me.alignmentGroup.Text = "Alignment"
        '
        'ribbonToolBar3
        '
        Me.ribbonToolBar3.Items.Add(Me.topAlignToggleButton)
        Me.ribbonToolBar3.Items.Add(Me.middleAlignToggleButton)
        Me.ribbonToolBar3.Items.Add(Me.bottomAlignToggleButton)
        Me.ribbonToolBar3.Items.Add(Me.ribbonSeparator5)
        Me.ribbonToolBar3.Items.Add(Me.orientationMenu)
        Me.ribbonToolBar3.Name = "ribbonToolBar3"
        '
        'topAlignToggleButton
        '
        Me.topAlignToggleButton.KeyTip = "AT"
        Me.topAlignToggleButton.Name = "topAlignToggleButton"
        Me.topAlignToggleButton.SmallImage = CType(resources.GetObject("topAlignToggleButton.SmallImage"), System.Drawing.Image)
        Me.topAlignToggleButton.ToggleGroupName = "verticalAlign"
        Me.topAlignToggleButton.ToolTip = "Top Align"
        '
        'middleAlignToggleButton
        '
        Me.middleAlignToggleButton.KeyTip = "AM"
        Me.middleAlignToggleButton.Name = "middleAlignToggleButton"
        Me.middleAlignToggleButton.SmallImage = CType(resources.GetObject("middleAlignToggleButton.SmallImage"), System.Drawing.Image)
        Me.middleAlignToggleButton.ToggleGroupName = "verticalAlign"
        Me.middleAlignToggleButton.ToolTip = "Middle Align"
        '
        'bottomAlignToggleButton
        '
        Me.bottomAlignToggleButton.KeyTip = "AB"
        Me.bottomAlignToggleButton.Name = "bottomAlignToggleButton"
        Me.bottomAlignToggleButton.SmallImage = CType(resources.GetObject("bottomAlignToggleButton.SmallImage"), System.Drawing.Image)
        Me.bottomAlignToggleButton.ToggleGroupName = "verticalAlign"
        Me.bottomAlignToggleButton.ToolTip = "Bottom Align"
        '
        'ribbonSeparator5
        '
        Me.ribbonSeparator5.Name = "ribbonSeparator5"
        '
        'orientationMenu
        '
        Me.orientationMenu.KeyTip = "FQ"
        Me.orientationMenu.Name = "orientationMenu"
        Me.orientationMenu.SmallImage = CType(resources.GetObject("orientationMenu.SmallImage"), System.Drawing.Image)
        Me.orientationMenu.ToolTip = "Orientation"
        '
        'ribbonToolBar4
        '
        Me.ribbonToolBar4.Items.Add(Me.alignLeftToggleButton)
        Me.ribbonToolBar4.Items.Add(Me.centerToggleButton)
        Me.ribbonToolBar4.Items.Add(Me.alignRightToggleButton)
        Me.ribbonToolBar4.Items.Add(Me.ribbonSeparator6)
        Me.ribbonToolBar4.Items.Add(Me.decreaseIndentButton)
        Me.ribbonToolBar4.Items.Add(Me.increaseIndentButton)
        Me.ribbonToolBar4.Name = "ribbonToolBar4"
        '
        'alignLeftToggleButton
        '
        Me.alignLeftToggleButton.KeyTip = "AL"
        Me.alignLeftToggleButton.Name = "alignLeftToggleButton"
        Me.alignLeftToggleButton.SmallImage = CType(resources.GetObject("alignLeftToggleButton.SmallImage"), System.Drawing.Image)
        Me.alignLeftToggleButton.ToggleGroupName = "horzAlign"
        Me.alignLeftToggleButton.ToolTip = "Align Text Left"
        '
        'centerToggleButton
        '
        Me.centerToggleButton.KeyTip = "AC"
        Me.centerToggleButton.Name = "centerToggleButton"
        Me.centerToggleButton.SmallImage = CType(resources.GetObject("centerToggleButton.SmallImage"), System.Drawing.Image)
        Me.centerToggleButton.ToggleGroupName = "horzAlign"
        Me.centerToggleButton.ToolTip = "Center"
        '
        'alignRightToggleButton
        '
        Me.alignRightToggleButton.KeyTip = "AR"
        Me.alignRightToggleButton.Name = "alignRightToggleButton"
        Me.alignRightToggleButton.SmallImage = CType(resources.GetObject("alignRightToggleButton.SmallImage"), System.Drawing.Image)
        Me.alignRightToggleButton.ToggleGroupName = "horzAlign"
        Me.alignRightToggleButton.ToolTip = "Align Text Right"
        '
        'ribbonSeparator6
        '
        Me.ribbonSeparator6.Name = "ribbonSeparator6"
        '
        'decreaseIndentButton
        '
        Me.decreaseIndentButton.KeyTip = "AO"
        Me.decreaseIndentButton.Name = "decreaseIndentButton"
        Me.decreaseIndentButton.SmallImage = CType(resources.GetObject("decreaseIndentButton.SmallImage"), System.Drawing.Image)
        Me.decreaseIndentButton.ToolTip = "Decrease Indent"
        '
        'increaseIndentButton
        '
        Me.increaseIndentButton.KeyTip = "AI"
        Me.increaseIndentButton.Name = "increaseIndentButton"
        Me.increaseIndentButton.SmallImage = CType(resources.GetObject("increaseIndentButton.SmallImage"), System.Drawing.Image)
        Me.increaseIndentButton.ToolTip = "Increase Indent"
        '
        'ribbonSeparator7
        '
        Me.ribbonSeparator7.Name = "ribbonSeparator7"
        '
        'wrapTextToggleButton
        '
        Me.wrapTextToggleButton.KeyTip = "W"
        Me.wrapTextToggleButton.Name = "wrapTextToggleButton"
        Me.wrapTextToggleButton.SmallImage = CType(resources.GetObject("wrapTextToggleButton.SmallImage"), System.Drawing.Image)
        Me.wrapTextToggleButton.Text = "Wrap Text"
        Me.wrapTextToggleButton.ToolTip = "Wrap Text"
        '
        'mergeSplitButton
        '
        Me.mergeSplitButton.Items.Add(Me.mergeAndCenterButton)
        Me.mergeSplitButton.Items.Add(Me.mergeCellsButton)
        Me.mergeSplitButton.Items.Add(Me.unmergeCellsButton)
        Me.mergeSplitButton.KeyTip = "M"
        Me.mergeSplitButton.Name = "mergeSplitButton"
        Me.mergeSplitButton.SmallImage = CType(resources.GetObject("mergeSplitButton.SmallImage"), System.Drawing.Image)
        Me.mergeSplitButton.Text = "Merge && Center"
        Me.mergeSplitButton.ToolTip = "Merge && Center"
        '
        'mergeAndCenterButton
        '
        Me.mergeAndCenterButton.Name = "mergeAndCenterButton"
        Me.mergeAndCenterButton.SmallImage = CType(resources.GetObject("mergeAndCenterButton.SmallImage"), System.Drawing.Image)
        Me.mergeAndCenterButton.Text = "Merge && &Center"
        '
        'mergeCellsButton
        '
        Me.mergeCellsButton.Name = "mergeCellsButton"
        Me.mergeCellsButton.SmallImage = CType(resources.GetObject("mergeCellsButton.SmallImage"), System.Drawing.Image)
        Me.mergeCellsButton.Text = "&Merge Cells"
        '
        'unmergeCellsButton
        '
        Me.unmergeCellsButton.Name = "unmergeCellsButton"
        Me.unmergeCellsButton.SmallImage = CType(resources.GetObject("unmergeCellsButton.SmallImage"), System.Drawing.Image)
        Me.unmergeCellsButton.Text = "&Unmerge Cells"
        '
        'viewTab
        '
        Me.viewTab.Groups.Add(Me.viewsGroup)
        Me.viewTab.Groups.Add(Me.hideShowGroup)
        Me.viewTab.Groups.Add(Me.zoomGroup)
        Me.viewTab.Groups.Add(Me.windowGroup)
        Me.viewTab.KeyTip = "W"
        Me.viewTab.Name = "viewTab"
        Me.viewTab.Text = "VIEW"
        '
        'viewsGroup
        '
        Me.viewsGroup.GroupKeyTip = "ZV"
        Me.viewsGroup.Image = CType(resources.GetObject("viewsGroup.Image"), System.Drawing.Image)
        Me.viewsGroup.Items.Add(Me.printLayoutToggleButton)
        Me.viewsGroup.Items.Add(Me.fullScreenToggleButton)
        Me.viewsGroup.Name = "viewsGroup"
        Me.viewsGroup.Text = "Document Views"
        '
        'printLayoutToggleButton
        '
        Me.printLayoutToggleButton.KeyTip = "P"
        Me.printLayoutToggleButton.LargeImage = CType(resources.GetObject("printLayoutToggleButton.LargeImage"), System.Drawing.Image)
        Me.printLayoutToggleButton.Name = "printLayoutToggleButton"
        Me.printLayoutToggleButton.SmallImage = CType(resources.GetObject("printLayoutToggleButton.SmallImage"), System.Drawing.Image)
        Me.printLayoutToggleButton.SupportedGroupSizing = C1.Win.Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.printLayoutToggleButton.Text = "Print Layout"
        Me.printLayoutToggleButton.ToggleGroupName = "viewsGroup"
        '
        'fullScreenToggleButton
        '
        Me.fullScreenToggleButton.KeyTip = "F"
        Me.fullScreenToggleButton.LargeImage = CType(resources.GetObject("fullScreenToggleButton.LargeImage"), System.Drawing.Image)
        Me.fullScreenToggleButton.Name = "fullScreenToggleButton"
        Me.fullScreenToggleButton.SmallImage = CType(resources.GetObject("fullScreenToggleButton.SmallImage"), System.Drawing.Image)
        Me.fullScreenToggleButton.SupportedGroupSizing = C1.Win.Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.fullScreenToggleButton.Text = "Full Screen Reading"
        Me.fullScreenToggleButton.ToggleGroupName = "viewsGroup"
        '
        'hideShowGroup
        '
        Me.hideShowGroup.GroupKeyTip = "ZS"
        Me.hideShowGroup.Image = CType(resources.GetObject("hideShowGroup.Image"), System.Drawing.Image)
        Me.hideShowGroup.Items.Add(Me.rulerCheckBox)
        Me.hideShowGroup.Items.Add(Me.gridlinesCheckBox)
        Me.hideShowGroup.Items.Add(Me.messageBarCheckBox)
        Me.hideShowGroup.Name = "hideShowGroup"
        Me.hideShowGroup.Text = "Hide/Show"
        '
        'rulerCheckBox
        '
        Me.rulerCheckBox.KeyTip = "R"
        Me.rulerCheckBox.Name = "rulerCheckBox"
        Me.rulerCheckBox.Text = "Ruler"
        '
        'gridlinesCheckBox
        '
        Me.gridlinesCheckBox.KeyTip = "G"
        Me.gridlinesCheckBox.Name = "gridlinesCheckBox"
        Me.gridlinesCheckBox.SmallImage = CType(resources.GetObject("gridlinesCheckBox.SmallImage"), System.Drawing.Image)
        Me.gridlinesCheckBox.Text = "Gridlines"
        '
        'messageBarCheckBox
        '
        Me.messageBarCheckBox.Enabled = False
        Me.messageBarCheckBox.KeyTip = "M"
        Me.messageBarCheckBox.Name = "messageBarCheckBox"
        Me.messageBarCheckBox.Text = "Message Bar"
        '
        'zoomGroup
        '
        Me.zoomGroup.GroupKeyTip = "ZZ"
        Me.zoomGroup.Image = CType(resources.GetObject("zoomGroup.Image"), System.Drawing.Image)
        Me.zoomGroup.Items.Add(Me.zoomButton)
        Me.zoomGroup.Items.Add(Me.onePageButton)
        Me.zoomGroup.Items.Add(Me.twoPagesButton)
        Me.zoomGroup.Items.Add(Me.pageWidthButton)
        Me.zoomGroup.Name = "zoomGroup"
        Me.zoomGroup.Text = "Zoom"
        '
        'zoomButton
        '
        Me.zoomButton.KeyTip = "Q"
        Me.zoomButton.LargeImage = CType(resources.GetObject("zoomButton.LargeImage"), System.Drawing.Image)
        Me.zoomButton.Name = "zoomButton"
        Me.zoomButton.SmallImage = CType(resources.GetObject("zoomButton.SmallImage"), System.Drawing.Image)
        Me.zoomButton.SupportedGroupSizing = C1.Win.Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.zoomButton.Text = "Zoom"
        Me.zoomButton.ToolTip = "Zoom"
        '
        'onePageButton
        '
        Me.onePageButton.KeyTip = "1"
        Me.onePageButton.Name = "onePageButton"
        Me.onePageButton.SmallImage = CType(resources.GetObject("onePageButton.SmallImage"), System.Drawing.Image)
        Me.onePageButton.Text = "One Page"
        '
        'twoPagesButton
        '
        Me.twoPagesButton.KeyTip = "2"
        Me.twoPagesButton.Name = "twoPagesButton"
        Me.twoPagesButton.SmallImage = CType(resources.GetObject("twoPagesButton.SmallImage"), System.Drawing.Image)
        Me.twoPagesButton.Text = "Two Pages"
        '
        'pageWidthButton
        '
        Me.pageWidthButton.KeyTip = "I"
        Me.pageWidthButton.Name = "pageWidthButton"
        Me.pageWidthButton.SmallImage = CType(resources.GetObject("pageWidthButton.SmallImage"), System.Drawing.Image)
        Me.pageWidthButton.Text = "Page Width"
        '
        'windowGroup
        '
        Me.windowGroup.GroupKeyTip = "ZW"
        Me.windowGroup.Image = CType(resources.GetObject("windowGroup.Image"), System.Drawing.Image)
        Me.windowGroup.Items.Add(Me.newWindowButton)
        Me.windowGroup.Items.Add(Me.arrangeAllButton)
        Me.windowGroup.Items.Add(Me.splitWindowButton)
        Me.windowGroup.Items.Add(Me.ribbonSeparator8)
        Me.windowGroup.Items.Add(Me.switchWindowsMenu)
        Me.windowGroup.Name = "windowGroup"
        Me.windowGroup.Text = "Window"
        '
        'newWindowButton
        '
        Me.newWindowButton.KeyTip = "N"
        Me.newWindowButton.Name = "newWindowButton"
        Me.newWindowButton.SmallImage = CType(resources.GetObject("newWindowButton.SmallImage"), System.Drawing.Image)
        Me.newWindowButton.Text = "New Window"
        '
        'arrangeAllButton
        '
        Me.arrangeAllButton.KeyTip = "A"
        Me.arrangeAllButton.Name = "arrangeAllButton"
        Me.arrangeAllButton.SmallImage = CType(resources.GetObject("arrangeAllButton.SmallImage"), System.Drawing.Image)
        Me.arrangeAllButton.Text = "Arrange All"
        '
        'splitWindowButton
        '
        Me.splitWindowButton.KeyTip = "S"
        Me.splitWindowButton.Name = "splitWindowButton"
        Me.splitWindowButton.SmallImage = CType(resources.GetObject("splitWindowButton.SmallImage"), System.Drawing.Image)
        Me.splitWindowButton.Text = "Split"
        Me.splitWindowButton.ToolTip = "Split Window"
        '
        'ribbonSeparator8
        '
        Me.ribbonSeparator8.Name = "ribbonSeparator8"
        '
        'switchWindowsMenu
        '
        Me.switchWindowsMenu.Enabled = False
        Me.switchWindowsMenu.KeyTip = "W"
        Me.switchWindowsMenu.LargeImage = CType(resources.GetObject("switchWindowsMenu.LargeImage"), System.Drawing.Image)
        Me.switchWindowsMenu.Name = "switchWindowsMenu"
        Me.switchWindowsMenu.SmallImage = CType(resources.GetObject("switchWindowsMenu.SmallImage"), System.Drawing.Image)
        Me.switchWindowsMenu.SupportedGroupSizing = C1.Win.Ribbon.SupportedGroupSizing.LargeImageOnly
        Me.switchWindowsMenu.Text = "Switch Windows"
        '
        'rtControls
        '
        Me.rtControls.Groups.Add(Me.rgControlsNormal)
        Me.rtControls.Groups.Add(Me.rgControlsDisabled)
        Me.rtControls.Name = "rtControls"
        Me.rtControls.Text = "CONTROLS"
        '
        'rgControlsNormal
        '
        Me.rgControlsNormal.Items.Add(Me.ribbonButton2)
        Me.rgControlsNormal.Items.Add(Me.ribbonButton3)
        Me.rgControlsNormal.Items.Add(Me.ribbonToolBar5)
        Me.rgControlsNormal.Items.Add(Me.ribbonColorPicker1)
        Me.rgControlsNormal.Items.Add(Me.ribbonSplitButton1)
        Me.rgControlsNormal.Items.Add(Me.ribbonSeparator17)
        Me.rgControlsNormal.Items.Add(Me.ribbonCheckBox1)
        Me.rgControlsNormal.Items.Add(Me.ribbonCheckBox2)
        Me.rgControlsNormal.Items.Add(Me.ribbonSeparator18)
        Me.rgControlsNormal.Items.Add(Me.ribbonComboBox1)
        Me.rgControlsNormal.Items.Add(Me.ribbonDatePicker1)
        Me.rgControlsNormal.Items.Add(Me.ribbonNumericBox1)
        Me.rgControlsNormal.Items.Add(Me.ribbonTextBox1)
        Me.rgControlsNormal.Items.Add(Me.ribbonTimePicker1)
        Me.rgControlsNormal.Items.Add(Me.ribbonSeparator19)
        Me.rgControlsNormal.Items.Add(Me.ribbonProgressBar1)
        Me.rgControlsNormal.Items.Add(Me.ribbonTrackBar2)
        Me.rgControlsNormal.Name = "rgControlsNormal"
        Me.rgControlsNormal.Text = "Normal State"
        '
        'ribbonButton2
        '
        Me.ribbonButton2.LargeImage = CType(resources.GetObject("ribbonButton2.LargeImage"), System.Drawing.Image)
        Me.ribbonButton2.Name = "ribbonButton2"
        Me.ribbonButton2.Text = "Large Button"
        '
        'ribbonButton3
        '
        Me.ribbonButton3.Name = "ribbonButton3"
        Me.ribbonButton3.SmallImage = CType(resources.GetObject("ribbonButton3.SmallImage"), System.Drawing.Image)
        Me.ribbonButton3.Text = "Small Button"
        '
        'ribbonToolBar5
        '
        Me.ribbonToolBar5.Items.Add(Me.ribbonToggleButton4)
        Me.ribbonToolBar5.Items.Add(Me.ribbonToggleButton5)
        Me.ribbonToolBar5.Items.Add(Me.ribbonToggleButton6)
        Me.ribbonToolBar5.Name = "ribbonToolBar5"
        '
        'ribbonToggleButton4
        '
        Me.ribbonToggleButton4.Name = "ribbonToggleButton4"
        Me.ribbonToggleButton4.Pressed = True
        Me.ribbonToggleButton4.SmallImage = CType(resources.GetObject("ribbonToggleButton4.SmallImage"), System.Drawing.Image)
        Me.ribbonToggleButton4.ToggleGroupName = "2"
        '
        'ribbonToggleButton5
        '
        Me.ribbonToggleButton5.Name = "ribbonToggleButton5"
        Me.ribbonToggleButton5.SmallImage = CType(resources.GetObject("ribbonToggleButton5.SmallImage"), System.Drawing.Image)
        Me.ribbonToggleButton5.ToggleGroupName = "2"
        '
        'ribbonToggleButton6
        '
        Me.ribbonToggleButton6.Name = "ribbonToggleButton6"
        Me.ribbonToggleButton6.SmallImage = CType(resources.GetObject("ribbonToggleButton6.SmallImage"), System.Drawing.Image)
        Me.ribbonToggleButton6.ToggleGroupName = "2"
        '
        'ribbonColorPicker1
        '
        Me.ribbonColorPicker1.Name = "ribbonColorPicker1"
        Me.ribbonColorPicker1.SmallImage = CType(resources.GetObject("ribbonColorPicker1.SmallImage"), System.Drawing.Image)
        '
        'ribbonSplitButton1
        '
        Me.ribbonSplitButton1.Items.Add(Me.ribbonButton5)
        Me.ribbonSplitButton1.Items.Add(Me.ribbonButton6)
        Me.ribbonSplitButton1.Items.Add(Me.ribbonButton7)
        Me.ribbonSplitButton1.Items.Add(Me.ribbonButton8)
        Me.ribbonSplitButton1.Name = "ribbonSplitButton1"
        Me.ribbonSplitButton1.SmallImage = CType(resources.GetObject("ribbonSplitButton1.SmallImage"), System.Drawing.Image)
        Me.ribbonSplitButton1.Text = "Split Button"
        '
        'ribbonButton5
        '
        Me.ribbonButton5.Name = "ribbonButton5"
        Me.ribbonButton5.SmallImage = CType(resources.GetObject("ribbonButton5.SmallImage"), System.Drawing.Image)
        Me.ribbonButton5.Text = "Item1"
        '
        'ribbonButton6
        '
        Me.ribbonButton6.Name = "ribbonButton6"
        Me.ribbonButton6.SmallImage = CType(resources.GetObject("ribbonButton6.SmallImage"), System.Drawing.Image)
        Me.ribbonButton6.Text = "Item2"
        '
        'ribbonButton7
        '
        Me.ribbonButton7.Name = "ribbonButton7"
        Me.ribbonButton7.SmallImage = CType(resources.GetObject("ribbonButton7.SmallImage"), System.Drawing.Image)
        Me.ribbonButton7.Text = "Item3"
        '
        'ribbonButton8
        '
        Me.ribbonButton8.Enabled = False
        Me.ribbonButton8.Name = "ribbonButton8"
        Me.ribbonButton8.SmallImage = CType(resources.GetObject("ribbonButton8.SmallImage"), System.Drawing.Image)
        Me.ribbonButton8.Text = "Disabled Item"
        '
        'ribbonSeparator17
        '
        Me.ribbonSeparator17.Name = "ribbonSeparator17"
        '
        'ribbonCheckBox1
        '
        Me.ribbonCheckBox1.Checked = True
        Me.ribbonCheckBox1.Name = "ribbonCheckBox1"
        Me.ribbonCheckBox1.Text = "Checked"
        '
        'ribbonCheckBox2
        '
        Me.ribbonCheckBox2.Name = "ribbonCheckBox2"
        Me.ribbonCheckBox2.Text = "Unchecked"
        '
        'ribbonSeparator18
        '
        Me.ribbonSeparator18.Name = "ribbonSeparator18"
        '
        'ribbonComboBox1
        '
        Me.ribbonComboBox1.Items.Add(Me.ribbonButton9)
        Me.ribbonComboBox1.Items.Add(Me.ribbonButton10)
        Me.ribbonComboBox1.Label = "Combo"
        Me.ribbonComboBox1.LabelWidth = 50
        Me.ribbonComboBox1.Name = "ribbonComboBox1"
        Me.ribbonComboBox1.Text = "ComboBox"
        '
        'ribbonButton9
        '
        Me.ribbonButton9.Name = "ribbonButton9"
        Me.ribbonButton9.SmallImage = CType(resources.GetObject("ribbonButton9.SmallImage"), System.Drawing.Image)
        Me.ribbonButton9.Text = "Item1"
        '
        'ribbonButton10
        '
        Me.ribbonButton10.Name = "ribbonButton10"
        Me.ribbonButton10.SmallImage = CType(resources.GetObject("ribbonButton10.SmallImage"), System.Drawing.Image)
        Me.ribbonButton10.Text = "Item2"
        '
        'ribbonDatePicker1
        '
        Me.ribbonDatePicker1.Label = "Date"
        Me.ribbonDatePicker1.LabelWidth = 50
        Me.ribbonDatePicker1.Name = "ribbonDatePicker1"
        Me.ribbonDatePicker1.TextAreaWidth = 80
        Me.ribbonDatePicker1.Value = New Date(2013, 11, 2, 0, 0, 0, 0)
        '
        'ribbonNumericBox1
        '
        Me.ribbonNumericBox1.Label = "Numeric"
        Me.ribbonNumericBox1.LabelWidth = 50
        Me.ribbonNumericBox1.Name = "ribbonNumericBox1"
        Me.ribbonNumericBox1.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'ribbonTextBox1
        '
        Me.ribbonTextBox1.Label = "Text"
        Me.ribbonTextBox1.LabelWidth = 40
        Me.ribbonTextBox1.Name = "ribbonTextBox1"
        Me.ribbonTextBox1.Text = "TextBox"
        '
        'ribbonTimePicker1
        '
        Me.ribbonTimePicker1.Label = "Time"
        Me.ribbonTimePicker1.LabelWidth = 40
        Me.ribbonTimePicker1.Name = "ribbonTimePicker1"
        Me.ribbonTimePicker1.Value = System.TimeSpan.Parse("10:53:08")
        '
        'ribbonSeparator19
        '
        Me.ribbonSeparator19.Name = "ribbonSeparator19"
        '
        'ribbonProgressBar1
        '
        Me.ribbonProgressBar1.Name = "ribbonProgressBar1"
        Me.ribbonProgressBar1.Value = 30
        '
        'ribbonTrackBar2
        '
        Me.ribbonTrackBar2.Name = "ribbonTrackBar2"
        Me.ribbonTrackBar2.Value = 50
        '
        'rgControlsDisabled
        '
        Me.rgControlsDisabled.Items.Add(Me.ribbonButton21)
        Me.rgControlsDisabled.Items.Add(Me.ribbonButton31)
        Me.rgControlsDisabled.Items.Add(Me.ribbonToolBar51)
        Me.rgControlsDisabled.Items.Add(Me.ribbonColorPicker11)
        Me.rgControlsDisabled.Items.Add(Me.ribbonSplitButton11)
        Me.rgControlsDisabled.Items.Add(Me.ribbonSeparator171)
        Me.rgControlsDisabled.Items.Add(Me.ribbonCheckBox11)
        Me.rgControlsDisabled.Items.Add(Me.ribbonCheckBox21)
        Me.rgControlsDisabled.Items.Add(Me.ribbonSeparator181)
        Me.rgControlsDisabled.Items.Add(Me.ribbonComboBox11)
        Me.rgControlsDisabled.Items.Add(Me.ribbonDatePicker11)
        Me.rgControlsDisabled.Items.Add(Me.ribbonNumericBox11)
        Me.rgControlsDisabled.Items.Add(Me.ribbonTextBox11)
        Me.rgControlsDisabled.Items.Add(Me.ribbonTimePicker11)
        Me.rgControlsDisabled.Items.Add(Me.ribbonSeparator191)
        Me.rgControlsDisabled.Items.Add(Me.ribbonProgressBar11)
        Me.rgControlsDisabled.Items.Add(Me.ribbonTrackBar21)
        Me.rgControlsDisabled.Name = "rgControlsDisabled"
        Me.rgControlsDisabled.Text = "Disabled State"
        '
        'ribbonButton21
        '
        Me.ribbonButton21.Enabled = False
        Me.ribbonButton21.LargeImage = CType(resources.GetObject("ribbonButton21.LargeImage"), System.Drawing.Image)
        Me.ribbonButton21.Name = "ribbonButton21"
        Me.ribbonButton21.Text = "Large Button"
        '
        'ribbonButton31
        '
        Me.ribbonButton31.Enabled = False
        Me.ribbonButton31.Name = "ribbonButton31"
        Me.ribbonButton31.SmallImage = CType(resources.GetObject("ribbonButton31.SmallImage"), System.Drawing.Image)
        Me.ribbonButton31.Text = "Small Button"
        '
        'ribbonToolBar51
        '
        Me.ribbonToolBar51.Enabled = False
        Me.ribbonToolBar51.Items.Add(Me.ribbonToggleButton41)
        Me.ribbonToolBar51.Items.Add(Me.ribbonToggleButton51)
        Me.ribbonToolBar51.Items.Add(Me.ribbonToggleButton61)
        Me.ribbonToolBar51.Name = "ribbonToolBar51"
        '
        'ribbonToggleButton41
        '
        Me.ribbonToggleButton41.Name = "ribbonToggleButton41"
        Me.ribbonToggleButton41.Pressed = True
        Me.ribbonToggleButton41.SmallImage = CType(resources.GetObject("ribbonToggleButton41.SmallImage"), System.Drawing.Image)
        Me.ribbonToggleButton41.ToggleGroupName = "2"
        '
        'ribbonToggleButton51
        '
        Me.ribbonToggleButton51.Name = "ribbonToggleButton51"
        Me.ribbonToggleButton51.SmallImage = CType(resources.GetObject("ribbonToggleButton51.SmallImage"), System.Drawing.Image)
        Me.ribbonToggleButton51.ToggleGroupName = "2"
        '
        'ribbonToggleButton61
        '
        Me.ribbonToggleButton61.Name = "ribbonToggleButton61"
        Me.ribbonToggleButton61.SmallImage = CType(resources.GetObject("ribbonToggleButton61.SmallImage"), System.Drawing.Image)
        Me.ribbonToggleButton61.ToggleGroupName = "2"
        '
        'ribbonColorPicker11
        '
        Me.ribbonColorPicker11.Enabled = False
        Me.ribbonColorPicker11.Name = "ribbonColorPicker11"
        Me.ribbonColorPicker11.SmallImage = CType(resources.GetObject("ribbonColorPicker11.SmallImage"), System.Drawing.Image)
        '
        'ribbonSplitButton11
        '
        Me.ribbonSplitButton11.Enabled = False
        Me.ribbonSplitButton11.Items.Add(Me.ribbonButton51)
        Me.ribbonSplitButton11.Items.Add(Me.ribbonButton61)
        Me.ribbonSplitButton11.Items.Add(Me.ribbonButton71)
        Me.ribbonSplitButton11.Items.Add(Me.ribbonButton81)
        Me.ribbonSplitButton11.Name = "ribbonSplitButton11"
        Me.ribbonSplitButton11.SmallImage = CType(resources.GetObject("ribbonSplitButton11.SmallImage"), System.Drawing.Image)
        Me.ribbonSplitButton11.Text = "Split Button"
        '
        'ribbonButton51
        '
        Me.ribbonButton51.Name = "ribbonButton51"
        Me.ribbonButton51.SmallImage = CType(resources.GetObject("ribbonButton51.SmallImage"), System.Drawing.Image)
        Me.ribbonButton51.Text = "Item1"
        '
        'ribbonButton61
        '
        Me.ribbonButton61.Name = "ribbonButton61"
        Me.ribbonButton61.SmallImage = CType(resources.GetObject("ribbonButton61.SmallImage"), System.Drawing.Image)
        Me.ribbonButton61.Text = "Item2"
        '
        'ribbonButton71
        '
        Me.ribbonButton71.Name = "ribbonButton71"
        Me.ribbonButton71.SmallImage = CType(resources.GetObject("ribbonButton71.SmallImage"), System.Drawing.Image)
        Me.ribbonButton71.Text = "Item3"
        '
        'ribbonButton81
        '
        Me.ribbonButton81.Name = "ribbonButton81"
        Me.ribbonButton81.SmallImage = CType(resources.GetObject("ribbonButton81.SmallImage"), System.Drawing.Image)
        Me.ribbonButton81.Text = "Disabled Item"
        '
        'ribbonSeparator171
        '
        Me.ribbonSeparator171.Name = "ribbonSeparator171"
        '
        'ribbonCheckBox11
        '
        Me.ribbonCheckBox11.Checked = True
        Me.ribbonCheckBox11.Enabled = False
        Me.ribbonCheckBox11.Name = "ribbonCheckBox11"
        Me.ribbonCheckBox11.Text = "Checked"
        '
        'ribbonCheckBox21
        '
        Me.ribbonCheckBox21.Enabled = False
        Me.ribbonCheckBox21.Name = "ribbonCheckBox21"
        Me.ribbonCheckBox21.Text = "Unchecked"
        '
        'ribbonSeparator181
        '
        Me.ribbonSeparator181.Name = "ribbonSeparator181"
        '
        'ribbonComboBox11
        '
        Me.ribbonComboBox11.Enabled = False
        Me.ribbonComboBox11.Items.Add(Me.ribbonButton91)
        Me.ribbonComboBox11.Items.Add(Me.ribbonButton101)
        Me.ribbonComboBox11.Label = "Combo"
        Me.ribbonComboBox11.LabelWidth = 50
        Me.ribbonComboBox11.Name = "ribbonComboBox11"
        Me.ribbonComboBox11.Text = "ComboBox"
        '
        'ribbonButton91
        '
        Me.ribbonButton91.Name = "ribbonButton91"
        Me.ribbonButton91.SmallImage = CType(resources.GetObject("ribbonButton91.SmallImage"), System.Drawing.Image)
        Me.ribbonButton91.Text = "Item1"
        '
        'ribbonButton101
        '
        Me.ribbonButton101.Name = "ribbonButton101"
        Me.ribbonButton101.SmallImage = CType(resources.GetObject("ribbonButton101.SmallImage"), System.Drawing.Image)
        Me.ribbonButton101.Text = "Item2"
        '
        'ribbonDatePicker11
        '
        Me.ribbonDatePicker11.Enabled = False
        Me.ribbonDatePicker11.Label = "Date"
        Me.ribbonDatePicker11.LabelWidth = 50
        Me.ribbonDatePicker11.Name = "ribbonDatePicker11"
        Me.ribbonDatePicker11.TextAreaWidth = 80
        Me.ribbonDatePicker11.Value = New Date(2013, 11, 2, 0, 0, 0, 0)
        '
        'ribbonNumericBox11
        '
        Me.ribbonNumericBox11.Enabled = False
        Me.ribbonNumericBox11.Label = "Numeric"
        Me.ribbonNumericBox11.LabelWidth = 50
        Me.ribbonNumericBox11.Name = "ribbonNumericBox11"
        Me.ribbonNumericBox11.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'ribbonTextBox11
        '
        Me.ribbonTextBox11.Enabled = False
        Me.ribbonTextBox11.Label = "Text"
        Me.ribbonTextBox11.LabelWidth = 40
        Me.ribbonTextBox11.Name = "ribbonTextBox11"
        Me.ribbonTextBox11.Text = "TextBox"
        '
        'ribbonTimePicker11
        '
        Me.ribbonTimePicker11.Enabled = False
        Me.ribbonTimePicker11.Label = "Time"
        Me.ribbonTimePicker11.LabelWidth = 40
        Me.ribbonTimePicker11.Name = "ribbonTimePicker11"
        Me.ribbonTimePicker11.Value = System.TimeSpan.Parse("10:53:37")
        '
        'ribbonSeparator191
        '
        Me.ribbonSeparator191.Name = "ribbonSeparator191"
        '
        'ribbonProgressBar11
        '
        Me.ribbonProgressBar11.Enabled = False
        Me.ribbonProgressBar11.Name = "ribbonProgressBar11"
        Me.ribbonProgressBar11.Value = 30
        '
        'ribbonTrackBar21
        '
        Me.ribbonTrackBar21.Enabled = False
        Me.ribbonTrackBar21.Name = "ribbonTrackBar21"
        Me.ribbonTrackBar21.Value = 50
        '
        'RibbonTopToolBar1
        '
        Me.RibbonTopToolBar1.Name = "RibbonTopToolBar1"
        '
        'c1StatusBar1
        '
        Me.c1StatusBar1.AutoSizeElement = C1.Framework.AutoSizeElement.Width
        Me.c1StatusBar1.LeftPaneItems.Add(Me.ribbonLabel1)
        Me.c1StatusBar1.LeftPaneItems.Add(Me.ribbonButton1)
        Me.c1StatusBar1.Location = New System.Drawing.Point(0, 663)
        Me.c1StatusBar1.Name = "c1StatusBar1"
        Me.c1StatusBar1.RightPaneItems.Add(Me.ribbonToggleButton1)
        Me.c1StatusBar1.RightPaneItems.Add(Me.ribbonToggleButton2)
        Me.c1StatusBar1.RightPaneItems.Add(Me.ribbonToggleButton3)
        Me.c1StatusBar1.RightPaneItems.Add(Me.ribbonSeparator1)
        Me.c1StatusBar1.RightPaneItems.Add(Me.ribbonTrackBar1)
        Me.c1StatusBar1.Size = New System.Drawing.Size(1236, 22)
        Me.c1StatusBar1.SmallImageList = Me.ilSmall
        Me.c1ThemeController1.SetTheme(Me.c1StatusBar1, "(default)")
        '
        'ribbonLabel1
        '
        Me.ribbonLabel1.Name = "ribbonLabel1"
        Me.ribbonLabel1.Text = "Page 1 of 10"
        '
        'ribbonButton1
        '
        Me.ribbonButton1.Name = "ribbonButton1"
        Me.ribbonButton1.SmallImage = ilSmall.Images("MacroRecord.png")
        '
        'ribbonToggleButton1
        '
        Me.ribbonToggleButton1.Name = "ribbonToggleButton1"
        Me.ribbonToggleButton1.Pressed = True
        Me.ribbonToggleButton1.SmallImage = ilSmall.Images("ViewNormalViewExcel.png")
        Me.ribbonToggleButton1.ToggleGroupName = "1"
        '
        'ribbonToggleButton2
        '
        Me.ribbonToggleButton2.Name = "ribbonToggleButton2"
        Me.ribbonToggleButton2.SmallImage = ilSmall.Images("ViewDraftView.png")
        Me.ribbonToggleButton2.ToggleGroupName = "1"
        '
        'ribbonToggleButton3
        '
        Me.ribbonToggleButton3.Name = "ribbonToggleButton3"
        Me.ribbonToggleButton3.SmallImage = ilSmall.Images("ViewOutlineView.png")
        Me.ribbonToggleButton3.ToggleGroupName = "1"
        '
        'ribbonSeparator1
        '
        Me.ribbonSeparator1.Name = "ribbonSeparator1"
        '
        'ribbonTrackBar1
        '
        Me.ribbonTrackBar1.Name = "ribbonTrackBar1"
        '
        'c1NavBar1
        '
        Me.c1NavBar1.AllowCollapse = True
        Me.c1NavBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.c1NavBar1.Collapsed = False
        Me.c1NavBar1.Controls.Add(Me.c1NavBarPanel5)
        Me.c1NavBar1.Controls.Add(Me.c1NavBarPanel2)
        Me.c1NavBar1.Controls.Add(Me.c1NavBarPanel3)
        Me.c1NavBar1.Controls.Add(Me.c1NavBarPanel4)
        Me.c1NavBar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.c1NavBar1.Location = New System.Drawing.Point(0, 146)
        Me.c1NavBar1.Name = "c1NavBar1"
        Me.c1NavBar1.Size = New System.Drawing.Size(275, 517)
        Me.c1NavBar1.StackButtonCount = 3
        Me.c1NavBar1.StripHeight = 31
        Me.c1NavBar1.Style.Button.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.c1NavBar1.Style.Button.Height = 37
        Me.c1NavBar1.Style.Button.MoreButtonImage = CType(resources.GetObject("c1NavBar1.Style.Button.MoreButtonImage"), System.Drawing.Image)
        Me.c1NavBar1.Style.Grip.Height = 5
        Me.c1NavBar1.Style.Panel.Header.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.c1NavBar1.Style.Panel.Header.Height = 20
        Me.c1NavBar1.Style.Section.Header.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.c1NavBar1.Style.Section.Header.Height = 18
        Me.c1NavBar1.Style.Section.Header.Indent = 8
        Me.c1ThemeController1.SetTheme(Me.c1NavBar1, "(default)")
        '
        'c1NavBarPanel5
        '
        Me.c1NavBarPanel5.Button.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.c1NavBarPanel5.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.c1NavBarPanel5.Button.SmallImage = CType(resources.GetObject("resource.SmallImage"), System.Drawing.Image)
        Me.c1NavBarPanel5.Button.Text = "Mail"
        Me.c1NavBarPanel5.Controls.Add(Me.ctbMain)
        Me.c1NavBarPanel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1NavBarPanel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1NavBarPanel5.ID = 5
        Me.c1NavBarPanel5.Name = "c1NavBarPanel5"
        Me.c1NavBarPanel5.Size = New System.Drawing.Size(263, 347)
        Me.c1ThemeController1.SetTheme(Me.c1NavBarPanel5, "(default)")
        '
        'ctbMain
        '
        Me.ctbMain.AutoScrollMinSize = New System.Drawing.Size(0, 282)
        Me.ctbMain.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.ctbMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctbMain.ImageList = Me.ilMain2
        Me.ctbMain.Location = New System.Drawing.Point(0, 0)
        Me.ctbMain.Name = "ctbMain"
        Me.ctbMain.Padding = New System.Windows.Forms.Padding(12)
        Me.ctbMain.PagePadding = New System.Windows.Forms.Padding(10)
        C1TopicPage1.ImageList = Me.ilMain2
        C1TopicLink1.ImageIndex = 1
        C1TopicLink1.Text = "Inbox"
        C1TopicLink2.ImageIndex = 2
        C1TopicLink2.Text = "Drafts"
        C1TopicLink3.ImageIndex = 3
        C1TopicLink3.Text = "Sent"
        C1TopicLink4.ImageIndex = 4
        C1TopicLink4.Text = "Trash"
        C1TopicLink5.ImageIndex = 6
        C1TopicLink5.Text = "Outbox"
        C1TopicLink6.Enabled = False
        C1TopicLink6.ImageIndex = 7
        C1TopicLink6.Text = "SPAM (disabled)"
        C1TopicPage1.Links.Add(C1TopicLink1)
        C1TopicPage1.Links.Add(C1TopicLink2)
        C1TopicPage1.Links.Add(C1TopicLink3)
        C1TopicPage1.Links.Add(C1TopicLink4)
        C1TopicPage1.Links.Add(C1TopicLink5)
        C1TopicPage1.Links.Add(C1TopicLink6)
        C1TopicPage1.Text = "All folders"
        C1TopicPage2.ImageIndex = 0
        C1TopicPage2.ImageList = Me.ilMain2
        C1TopicLink7.ImageIndex = 1
        C1TopicLink7.Text = "Inbox"
        C1TopicLink8.ImageIndex = 3
        C1TopicLink8.Text = "Sent"
        C1TopicLink9.ImageIndex = 4
        C1TopicLink9.Text = "Trash"
        C1TopicPage2.Links.Add(C1TopicLink7)
        C1TopicPage2.Links.Add(C1TopicLink8)
        C1TopicPage2.Links.Add(C1TopicLink9)
        C1TopicPage2.SpecialStyle = True
        C1TopicPage2.Text = "Favorites"
        Me.ctbMain.Pages.Add(C1TopicPage1)
        Me.ctbMain.Pages.Add(C1TopicPage2)
        Me.ctbMain.Size = New System.Drawing.Size(263, 347)
        Me.ctbMain.TabIndex = 0
        Me.c1ThemeController1.SetTheme(Me.ctbMain, "(default)")
        '
        'c1NavBarPanel2
        '
        Me.c1NavBarPanel2.Button.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.c1NavBarPanel2.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.c1NavBarPanel2.Button.SmallImage = CType(resources.GetObject("resource.SmallImage1"), System.Drawing.Image)
        Me.c1NavBarPanel2.Button.Text = "Calendar"
        Me.c1NavBarPanel2.Controls.Add(Me.c1Calendar1)
        Me.c1NavBarPanel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1NavBarPanel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1NavBarPanel2.ID = 2
        Me.c1NavBarPanel2.Name = "c1NavBarPanel2"
        Me.c1NavBarPanel2.Size = New System.Drawing.Size(263, 347)
        Me.c1ThemeController1.SetTheme(Me.c1NavBarPanel2, "(default)")
        '
        'c1Calendar1
        '
        Me.c1Calendar1.AutoSizeElement = C1.Framework.AutoSizeElement.Both
        Me.c1Calendar1.BoldedDates = New Date(-1) {}
        Me.c1Calendar1.CalendarDimensions = 2
        '
        '
        '
        Me.c1Calendar1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00")
        Me.c1Calendar1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00")
        Me.c1Calendar1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00")
        Me.c1Calendar1.CalendarInfo.WeekStart = System.DayOfWeek.Monday
        Me.c1Calendar1.CalendarInfo.WorkDays.AddRange(New System.DayOfWeek() {System.DayOfWeek.Monday, System.DayOfWeek.Tuesday, System.DayOfWeek.Wednesday, System.DayOfWeek.Thursday, System.DayOfWeek.Friday})
        Me.c1Calendar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Calendar1.Location = New System.Drawing.Point(0, 0)
        Me.c1Calendar1.MaxSelectionCount = 70
        Me.c1Calendar1.Name = "c1Calendar1"
        Me.c1Calendar1.Size = New System.Drawing.Size(263, 347)
        Me.c1Calendar1.TabIndex = 0
        Me.c1ThemeController1.SetTheme(Me.c1Calendar1, "(default)")
        Me.c1Calendar1.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Custom
        '
        'c1NavBarPanel3
        '
        Me.c1NavBarPanel3.Button.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.c1NavBarPanel3.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.c1NavBarPanel3.Button.SmallImage = CType(resources.GetObject("resource.SmallImage2"), System.Drawing.Image)
        Me.c1NavBarPanel3.Button.Text = "Contacts"
        Me.c1NavBarPanel3.Controls.Add(Me.label1)
        Me.c1NavBarPanel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1NavBarPanel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1NavBarPanel3.ID = 3
        Me.c1NavBarPanel3.Name = "c1NavBarPanel3"
        Me.c1NavBarPanel3.Size = New System.Drawing.Size(263, 347)
        Me.c1ThemeController1.SetTheme(Me.c1NavBarPanel3, "(default)")
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.White
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(59, 165)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(125, 30)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Empty C1NavBar panel in a C1NavBar container"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.c1ThemeController1.SetTheme(Me.label1, "(default)")
        Me.label1.UseCompatibleTextRendering = True
        '
        'c1NavBarPanel4
        '
        Me.c1NavBarPanel4.Button.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.c1NavBarPanel4.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.c1NavBarPanel4.Button.SmallImage = CType(resources.GetObject("resource.SmallImage3"), System.Drawing.Image)
        Me.c1NavBarPanel4.Button.Text = "Tasks"
        Me.c1NavBarPanel4.Controls.Add(Me.label2)
        Me.c1NavBarPanel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1NavBarPanel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1NavBarPanel4.ID = 4
        Me.c1NavBarPanel4.Name = "c1NavBarPanel4"
        Me.c1NavBarPanel4.Size = New System.Drawing.Size(263, 347)
        Me.c1ThemeController1.SetTheme(Me.c1NavBarPanel4, "(default)")
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.White
        Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.label2.Location = New System.Drawing.Point(64, 167)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(125, 30)
        Me.label2.TabIndex = 1
        Me.label2.Text = "Empty C1NavBar panel in a C1NavBar container"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.c1ThemeController1.SetTheme(Me.label2, "(default)")
        Me.label2.UseCompatibleTextRendering = True
        '
        'c1CommandDock1
        '
        Me.c1CommandDock1.BackColor = System.Drawing.Color.White
        Me.c1CommandDock1.Controls.Add(Me.c1DockingTab1)
        Me.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Right
        Me.c1CommandDock1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.c1CommandDock1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1CommandDock1.Id = 1
        Me.c1CommandDock1.Location = New System.Drawing.Point(931, 146)
        Me.c1CommandDock1.Name = "c1CommandDock1"
        Me.c1CommandDock1.Size = New System.Drawing.Size(305, 517)
        Me.c1ThemeController1.SetTheme(Me.c1CommandDock1, "(default)")
        '
        'c1DockingTab1
        '
        Me.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.c1DockingTab1.BackColor = System.Drawing.Color.White
        Me.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1DockingTab1.CanAutoHide = True
        Me.c1DockingTab1.CanCloseTabs = True
        Me.c1DockingTab1.CanMoveTabs = True
        Me.c1DockingTab1.Controls.Add(Me.c1DockingTabPage1)
        Me.c1DockingTab1.Controls.Add(Me.c1DockingTabPage2)
        Me.c1DockingTab1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.c1DockingTab1.HotTrack = True
        Me.c1DockingTab1.ImageList = Me.ilMain2
        Me.c1DockingTab1.Location = New System.Drawing.Point(0, 0)
        Me.c1DockingTab1.Name = "c1DockingTab1"
        Me.c1DockingTab1.ShowCaption = True
        Me.c1DockingTab1.Size = New System.Drawing.Size(305, 517)
        Me.c1DockingTab1.TabIndex = 0
        Me.c1DockingTab1.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        Me.c1DockingTab1.TabsShowFocusCues = False
        Me.c1DockingTab1.TabsSpacing = 2
        Me.c1DockingTab1.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007
        Me.c1ThemeController1.SetTheme(Me.c1DockingTab1, "(default)")
        '
        'c1DockingTabPage1
        '
        Me.c1DockingTabPage1.CaptionVisible = True
        Me.c1DockingTabPage1.Controls.Add(Me.c1OutBar1)
        Me.c1DockingTabPage1.ImageIndex = 12
        Me.c1DockingTabPage1.Location = New System.Drawing.Point(4, 1)
        Me.c1DockingTabPage1.Name = "c1DockingTabPage1"
        Me.c1DockingTabPage1.Size = New System.Drawing.Size(300, 490)
        Me.c1DockingTabPage1.TabIndex = 0
        Me.c1DockingTabPage1.Text = "Settings"
        '
        'c1OutBar1
        '
        Me.c1OutBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.c1OutBar1.Controls.Add(Me.copC1FlexGrid)
        Me.c1OutBar1.Controls.Add(Me.copC1TrueDBGrid)
        Me.c1OutBar1.Controls.Add(Me.copC1Schedule)
        Me.c1OutBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1OutBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.c1OutBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1OutBar1.ImageList = Me.ilMain
        Me.c1OutBar1.Location = New System.Drawing.Point(0, 24)
        Me.c1OutBar1.Name = "c1OutBar1"
        Me.c1OutBar1.PageTitleHeight = 28
        Me.c1OutBar1.Size = New System.Drawing.Size(300, 466)
        Me.c1ThemeController1.SetTheme(Me.c1OutBar1, "(default)")
        '
        'copC1FlexGrid
        '
        Me.copC1FlexGrid.Controls.Add(Me.ctbC1FlexGrid)
        Me.copC1FlexGrid.Controls.Add(Me.panel1)
        Me.copC1FlexGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.copC1FlexGrid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.copC1FlexGrid.ImageIndex = 0
        Me.copC1FlexGrid.Name = "copC1FlexGrid"
        Me.copC1FlexGrid.Size = New System.Drawing.Size(300, 382)
        Me.copC1FlexGrid.Text = "C1FlexGrid"
        Me.c1ThemeController1.SetTheme(Me.copC1FlexGrid, "(default)")
        '
        'ctbC1FlexGrid
        '
        Me.ctbC1FlexGrid.AccessibleName = "Tool Bar"
        Me.ctbC1FlexGrid.AutoSize = False
        Me.ctbC1FlexGrid.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.ctbC1FlexGrid.CommandHolder = Me.cchMain
        Me.ctbC1FlexGrid.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.c1CommandLink1, Me.c1CommandLink2, Me.c1CommandLink3})
        Me.ctbC1FlexGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctbC1FlexGrid.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ctbC1FlexGrid.Horizontal = False
        Me.ctbC1FlexGrid.Location = New System.Drawing.Point(0, 0)
        Me.ctbC1FlexGrid.Movable = False
        Me.ctbC1FlexGrid.Name = "ctbC1FlexGrid"
        Me.ctbC1FlexGrid.Size = New System.Drawing.Size(300, 172)
        Me.ctbC1FlexGrid.Text = "C1FlexGrid"
        Me.c1ThemeController1.SetTheme(Me.ctbC1FlexGrid, "(default)")
        '
        'cchMain
        '
        Me.cchMain.Commands.Add(Me.ccCTDBGViewNormal)
        Me.cchMain.Commands.Add(Me.ccCTDBGViewInverted)
        Me.cchMain.Commands.Add(Me.ccCTDBGViewForm)
        Me.cchMain.Commands.Add(Me.ccCTDBGViewGroupBy)
        Me.cchMain.Commands.Add(Me.ccCTDBGViewMultipleLines)
        Me.cchMain.Commands.Add(Me.ccCTDBGViewHierarchical)
        Me.cchMain.Commands.Add(Me.ccCFGViewNormal)
        Me.cchMain.Commands.Add(Me.ccCFGViewTree)
        Me.cchMain.Commands.Add(Me.ccCFGViewSubtotals)
        Me.cchMain.Commands.Add(Me.ccCSViewDay)
        Me.cchMain.Commands.Add(Me.ccCSViewWorkWeek)
        Me.cchMain.Commands.Add(Me.ccCSViewWeek)
        Me.cchMain.Commands.Add(Me.ccCSViewMonth)
        Me.cchMain.Commands.Add(Me.ccCSViewTimeLine)
        Me.cchMain.ImageList = Me.ilMain
        Me.cchMain.Owner = Me
        '
        'ccCTDBGViewNormal
        '
        Me.ccCTDBGViewNormal.ImageIndex = 5
        Me.ccCTDBGViewNormal.Name = "ccCTDBGViewNormal"
        Me.ccCTDBGViewNormal.ShortcutText = ""
        Me.ccCTDBGViewNormal.Text = "Normal View"
        Me.ccCTDBGViewNormal.UserData = "Normal"
        '
        'ccCTDBGViewInverted
        '
        Me.ccCTDBGViewInverted.ImageIndex = 6
        Me.ccCTDBGViewInverted.Name = "ccCTDBGViewInverted"
        Me.ccCTDBGViewInverted.ShortcutText = ""
        Me.ccCTDBGViewInverted.Text = "Inverted View"
        Me.ccCTDBGViewInverted.UserData = "Inverted"
        '
        'ccCTDBGViewForm
        '
        Me.ccCTDBGViewForm.ImageIndex = 7
        Me.ccCTDBGViewForm.Name = "ccCTDBGViewForm"
        Me.ccCTDBGViewForm.ShortcutText = ""
        Me.ccCTDBGViewForm.Text = "Form  View"
        Me.ccCTDBGViewForm.UserData = "Form"
        '
        'ccCTDBGViewGroupBy
        '
        Me.ccCTDBGViewGroupBy.ImageIndex = 8
        Me.ccCTDBGViewGroupBy.Name = "ccCTDBGViewGroupBy"
        Me.ccCTDBGViewGroupBy.ShortcutText = ""
        Me.ccCTDBGViewGroupBy.Text = "Grouped View"
        Me.ccCTDBGViewGroupBy.UserData = "GroupBy"
        '
        'ccCTDBGViewMultipleLines
        '
        Me.ccCTDBGViewMultipleLines.ImageIndex = 9
        Me.ccCTDBGViewMultipleLines.Name = "ccCTDBGViewMultipleLines"
        Me.ccCTDBGViewMultipleLines.ShortcutText = ""
        Me.ccCTDBGViewMultipleLines.Text = "Multiple Lines View"
        Me.ccCTDBGViewMultipleLines.UserData = "MultipleLines"
        '
        'ccCTDBGViewHierarchical
        '
        Me.ccCTDBGViewHierarchical.ImageIndex = 10
        Me.ccCTDBGViewHierarchical.Name = "ccCTDBGViewHierarchical"
        Me.ccCTDBGViewHierarchical.ShortcutText = ""
        Me.ccCTDBGViewHierarchical.Text = "Hierarchical View"
        Me.ccCTDBGViewHierarchical.UserData = "Hierarchical"
        '
        'ccCFGViewNormal
        '
        Me.ccCFGViewNormal.ImageIndex = 0
        Me.ccCFGViewNormal.Name = "ccCFGViewNormal"
        Me.ccCFGViewNormal.ShortcutText = ""
        Me.ccCFGViewNormal.Text = "Normal View"
        Me.ccCFGViewNormal.UserData = "Normal"
        '
        'ccCFGViewTree
        '
        Me.ccCFGViewTree.ImageIndex = 3
        Me.ccCFGViewTree.Name = "ccCFGViewTree"
        Me.ccCFGViewTree.ShortcutText = ""
        Me.ccCFGViewTree.Text = "Tree View"
        Me.ccCFGViewTree.UserData = "Tree"
        '
        'ccCFGViewSubtotals
        '
        Me.ccCFGViewSubtotals.ImageIndex = 4
        Me.ccCFGViewSubtotals.Name = "ccCFGViewSubtotals"
        Me.ccCFGViewSubtotals.ShortcutText = ""
        Me.ccCFGViewSubtotals.Text = "Subtotal Styles"
        Me.ccCFGViewSubtotals.UserData = "Subtotals"
        '
        'ccCSViewDay
        '
        Me.ccCSViewDay.ImageIndex = 11
        Me.ccCSViewDay.Name = "ccCSViewDay"
        Me.ccCSViewDay.ShortcutText = ""
        Me.ccCSViewDay.Text = "Day View"
        Me.ccCSViewDay.UserData = "DayView"
        '
        'ccCSViewWorkWeek
        '
        Me.ccCSViewWorkWeek.ImageIndex = 12
        Me.ccCSViewWorkWeek.Name = "ccCSViewWorkWeek"
        Me.ccCSViewWorkWeek.ShortcutText = ""
        Me.ccCSViewWorkWeek.Text = "Work Week View"
        Me.ccCSViewWorkWeek.UserData = "WorkWeekView"
        '
        'ccCSViewWeek
        '
        Me.ccCSViewWeek.ImageIndex = 13
        Me.ccCSViewWeek.Name = "ccCSViewWeek"
        Me.ccCSViewWeek.ShortcutText = ""
        Me.ccCSViewWeek.Text = "Week View"
        Me.ccCSViewWeek.UserData = "WeekView"
        '
        'ccCSViewMonth
        '
        Me.ccCSViewMonth.ImageIndex = 14
        Me.ccCSViewMonth.Name = "ccCSViewMonth"
        Me.ccCSViewMonth.ShortcutText = ""
        Me.ccCSViewMonth.Text = "Month View"
        Me.ccCSViewMonth.UserData = "MonthView"
        '
        'ccCSViewTimeLine
        '
        Me.ccCSViewTimeLine.ImageIndex = 15
        Me.ccCSViewTimeLine.Name = "ccCSViewTimeLine"
        Me.ccCSViewTimeLine.ShortcutText = ""
        Me.ccCSViewTimeLine.Text = "Time Line View"
        Me.ccCSViewTimeLine.UserData = "TimeLineView"
        '
        'ilMain
        '
        Me.ilMain.ImageStream = CType(resources.GetObject("ilMain.ImageStream"), System.Windows.Forms.ImageListStreamer)
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
        'c1CommandLink1
        '
        Me.c1CommandLink1.Command = Me.ccCFGViewNormal
        '
        'c1CommandLink2
        '
        Me.c1CommandLink2.Command = Me.ccCFGViewTree
        Me.c1CommandLink2.SortOrder = 1
        '
        'c1CommandLink3
        '
        Me.c1CommandLink3.Command = Me.ccCFGViewSubtotals
        Me.c1CommandLink3.SortOrder = 2
        '
        'panel1
        '
        Me.panel1.BackColor = System.Drawing.Color.White
        Me.panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panel1.Location = New System.Drawing.Point(0, 172)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(300, 210)
        Me.panel1.TabIndex = 2
        Me.c1ThemeController1.SetTheme(Me.panel1, "(default)")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.csbFocusRect, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.c1Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.csbSelectionMode, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.c1Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cneFixedRowCount, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ccbShowCursor, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.cneFixedColCount, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.c1Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(300, 210)
        Me.TableLayoutPanel1.TabIndex = 14
        Me.c1ThemeController1.SetTheme(Me.TableLayoutPanel1, "(default)")
        '
        'csbFocusRect
        '
        Me.csbFocusRect.Dock = System.Windows.Forms.DockStyle.Fill
        Me.csbFocusRect.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.csbFocusRect.Location = New System.Drawing.Point(98, 84)
        Me.csbFocusRect.Name = "csbFocusRect"
        Me.csbFocusRect.Size = New System.Drawing.Size(199, 23)
        Me.csbFocusRect.TabIndex = 11
        Me.csbFocusRect.Text = "c1SplitButton2"
        Me.c1ThemeController1.SetTheme(Me.csbFocusRect, "(default)")
        Me.csbFocusRect.UseVisualStyleBackColor = True
        Me.csbFocusRect.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1Label4
        '
        Me.c1Label4.AutoSize = True
        Me.c1Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Label4.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.c1Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1Label4.Location = New System.Drawing.Point(3, 81)
        Me.c1Label4.Name = "c1Label4"
        Me.c1Label4.Size = New System.Drawing.Size(89, 29)
        Me.c1Label4.TabIndex = 13
        Me.c1Label4.Tag = Nothing
        Me.c1Label4.Text = "Focus rect:"
        Me.c1Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.c1Label4.TextDetached = True
        Me.c1ThemeController1.SetTheme(Me.c1Label4, "(default)")
        Me.c1Label4.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom
        '
        'csbSelectionMode
        '
        Me.csbSelectionMode.Dock = System.Windows.Forms.DockStyle.Fill
        Me.csbSelectionMode.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.csbSelectionMode.Location = New System.Drawing.Point(98, 55)
        Me.csbSelectionMode.Name = "csbSelectionMode"
        Me.csbSelectionMode.Size = New System.Drawing.Size(199, 23)
        Me.csbSelectionMode.TabIndex = 10
        Me.csbSelectionMode.Text = "c1SplitButton1"
        Me.c1ThemeController1.SetTheme(Me.csbSelectionMode, "(default)")
        Me.csbSelectionMode.UseVisualStyleBackColor = True
        Me.csbSelectionMode.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1Label2
        '
        Me.c1Label2.AutoSize = True
        Me.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Label2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.c1Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1Label2.Location = New System.Drawing.Point(3, 26)
        Me.c1Label2.Name = "c1Label2"
        Me.c1Label2.Size = New System.Drawing.Size(89, 26)
        Me.c1Label2.TabIndex = 7
        Me.c1Label2.Tag = Nothing
        Me.c1Label2.Text = "Fixed rows:"
        Me.c1Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.c1Label2.TextDetached = True
        Me.c1ThemeController1.SetTheme(Me.c1Label2, "(default)")
        Me.c1Label2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom
        '
        'cneFixedRowCount
        '
        Me.cneFixedRowCount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.cneFixedRowCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.cneFixedRowCount.Calculator.BackColor = System.Drawing.Color.White
        Me.cneFixedRowCount.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.cneFixedRowCount.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.cneFixedRowCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cneFixedRowCount.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.cneFixedRowCount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.cneFixedRowCount.ImageTransparentColor = System.Drawing.Color.Empty
        Me.cneFixedRowCount.Location = New System.Drawing.Point(98, 29)
        Me.cneFixedRowCount.Name = "cneFixedRowCount"
        Me.cneFixedRowCount.Size = New System.Drawing.Size(199, 20)
        Me.cneFixedRowCount.TabIndex = 6
        Me.cneFixedRowCount.Tag = Nothing
        Me.c1ThemeController1.SetTheme(Me.cneFixedRowCount, "(default)")
        Me.cneFixedRowCount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        Me.cneFixedRowCount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ccbShowCursor
        '
        Me.ccbShowCursor.AutoSize = True
        Me.ccbShowCursor.BackColor = System.Drawing.Color.Transparent
        Me.ccbShowCursor.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ccbShowCursor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TableLayoutPanel1.SetColumnSpan(Me.ccbShowCursor, 2)
        Me.ccbShowCursor.Dock = System.Windows.Forms.DockStyle.Top
        Me.ccbShowCursor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccbShowCursor.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ccbShowCursor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ccbShowCursor.Location = New System.Drawing.Point(3, 113)
        Me.ccbShowCursor.Name = "ccbShowCursor"
        Me.ccbShowCursor.Padding = New System.Windows.Forms.Padding(4, 1, 1, 1)
        Me.ccbShowCursor.Size = New System.Drawing.Size(294, 19)
        Me.ccbShowCursor.TabIndex = 9
        Me.ccbShowCursor.Text = "Show cursor"
        Me.c1ThemeController1.SetTheme(Me.ccbShowCursor, "(default)")
        Me.ccbShowCursor.UseVisualStyleBackColor = True
        Me.ccbShowCursor.Value = Nothing
        Me.ccbShowCursor.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'cneFixedColCount
        '
        Me.cneFixedColCount.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.cneFixedColCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.cneFixedColCount.Calculator.BackColor = System.Drawing.Color.White
        Me.cneFixedColCount.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        Me.cneFixedColCount.DisabledForeColor = System.Drawing.Color.FromArgb(CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.cneFixedColCount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cneFixedColCount.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.cneFixedColCount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.cneFixedColCount.ImageTransparentColor = System.Drawing.Color.Empty
        Me.cneFixedColCount.Location = New System.Drawing.Point(98, 3)
        Me.cneFixedColCount.Name = "cneFixedColCount"
        Me.cneFixedColCount.Size = New System.Drawing.Size(199, 20)
        Me.cneFixedColCount.TabIndex = 5
        Me.cneFixedColCount.Tag = Nothing
        Me.c1ThemeController1.SetTheme(Me.cneFixedColCount, "(default)")
        Me.cneFixedColCount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown
        Me.cneFixedColCount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1Label3
        '
        Me.c1Label3.AutoSize = True
        Me.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.c1Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1Label3.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.c1Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1Label3.Location = New System.Drawing.Point(3, 52)
        Me.c1Label3.Name = "c1Label3"
        Me.c1Label3.Size = New System.Drawing.Size(89, 29)
        Me.c1Label3.TabIndex = 12
        Me.c1Label3.Tag = Nothing
        Me.c1Label3.Text = "Selection mode:"
        Me.c1Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.c1Label3.TextDetached = True
        Me.c1ThemeController1.SetTheme(Me.c1Label3, "(default)")
        Me.c1Label3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Custom
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 26)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Fixed columns:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.c1ThemeController1.SetTheme(Me.Label3, "(default)")
        '
        'copC1TrueDBGrid
        '
        Me.copC1TrueDBGrid.Controls.Add(Me.ctbC1TrueDBGridView)
        Me.copC1TrueDBGrid.Controls.Add(Me.panel2)
        Me.copC1TrueDBGrid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.copC1TrueDBGrid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.copC1TrueDBGrid.ImageIndex = 1
        Me.copC1TrueDBGrid.Name = "copC1TrueDBGrid"
        Me.copC1TrueDBGrid.Size = New System.Drawing.Size(300, 382)
        Me.copC1TrueDBGrid.Text = "C1TrueDBGrid"
        Me.c1ThemeController1.SetTheme(Me.copC1TrueDBGrid, "(default)")
        '
        'ctbC1TrueDBGridView
        '
        Me.ctbC1TrueDBGridView.AccessibleName = "Tool Bar"
        Me.ctbC1TrueDBGridView.AutoSize = False
        Me.ctbC1TrueDBGridView.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.ctbC1TrueDBGridView.CommandHolder = Me.cchMain
        Me.ctbC1TrueDBGridView.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.c1CommandLink4, Me.c1CommandLink5, Me.c1CommandLink6, Me.c1CommandLink7, Me.c1CommandLink8, Me.c1CommandLink9})
        Me.ctbC1TrueDBGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctbC1TrueDBGridView.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ctbC1TrueDBGridView.Horizontal = False
        Me.ctbC1TrueDBGridView.Location = New System.Drawing.Point(0, 0)
        Me.ctbC1TrueDBGridView.Movable = False
        Me.ctbC1TrueDBGridView.Name = "ctbC1TrueDBGridView"
        Me.ctbC1TrueDBGridView.Size = New System.Drawing.Size(300, 326)
        Me.ctbC1TrueDBGridView.Text = "Page1"
        Me.c1ThemeController1.SetTheme(Me.ctbC1TrueDBGridView, "(default)")
        '
        'c1CommandLink4
        '
        Me.c1CommandLink4.Command = Me.ccCTDBGViewNormal
        '
        'c1CommandLink5
        '
        Me.c1CommandLink5.Command = Me.ccCTDBGViewInverted
        Me.c1CommandLink5.SortOrder = 1
        '
        'c1CommandLink6
        '
        Me.c1CommandLink6.Command = Me.ccCTDBGViewForm
        Me.c1CommandLink6.SortOrder = 2
        '
        'c1CommandLink7
        '
        Me.c1CommandLink7.Command = Me.ccCTDBGViewGroupBy
        Me.c1CommandLink7.SortOrder = 3
        '
        'c1CommandLink8
        '
        Me.c1CommandLink8.Command = Me.ccCTDBGViewMultipleLines
        Me.c1CommandLink8.SortOrder = 4
        '
        'c1CommandLink9
        '
        Me.c1CommandLink9.Command = Me.ccCTDBGViewHierarchical
        Me.c1CommandLink9.SortOrder = 5
        '
        'panel2
        '
        Me.panel2.BackColor = System.Drawing.Color.White
        Me.panel2.Controls.Add(Me.ccbCTDBGShowFilterBar)
        Me.panel2.Controls.Add(Me.ccbCTDBGShowCaption)
        Me.panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panel2.Location = New System.Drawing.Point(0, 326)
        Me.panel2.Name = "panel2"
        Me.panel2.Size = New System.Drawing.Size(300, 56)
        Me.panel2.TabIndex = 3
        Me.c1ThemeController1.SetTheme(Me.panel2, "(default)")
        '
        'ccbCTDBGShowFilterBar
        '
        Me.ccbCTDBGShowFilterBar.AutoSize = True
        Me.ccbCTDBGShowFilterBar.BackColor = System.Drawing.Color.Transparent
        Me.ccbCTDBGShowFilterBar.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ccbCTDBGShowFilterBar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ccbCTDBGShowFilterBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccbCTDBGShowFilterBar.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ccbCTDBGShowFilterBar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ccbCTDBGShowFilterBar.Location = New System.Drawing.Point(3, 26)
        Me.ccbCTDBGShowFilterBar.Name = "ccbCTDBGShowFilterBar"
        Me.ccbCTDBGShowFilterBar.Padding = New System.Windows.Forms.Padding(4, 1, 1, 1)
        Me.ccbCTDBGShowFilterBar.Size = New System.Drawing.Size(104, 19)
        Me.ccbCTDBGShowFilterBar.TabIndex = 1
        Me.ccbCTDBGShowFilterBar.Text = "Show filter bar"
        Me.c1ThemeController1.SetTheme(Me.ccbCTDBGShowFilterBar, "(default)")
        Me.ccbCTDBGShowFilterBar.UseVisualStyleBackColor = True
        Me.ccbCTDBGShowFilterBar.Value = Nothing
        Me.ccbCTDBGShowFilterBar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ccbCTDBGShowCaption
        '
        Me.ccbCTDBGShowCaption.AutoSize = True
        Me.ccbCTDBGShowCaption.BackColor = System.Drawing.Color.Transparent
        Me.ccbCTDBGShowCaption.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ccbCTDBGShowCaption.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ccbCTDBGShowCaption.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccbCTDBGShowCaption.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ccbCTDBGShowCaption.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ccbCTDBGShowCaption.Location = New System.Drawing.Point(3, 3)
        Me.ccbCTDBGShowCaption.Name = "ccbCTDBGShowCaption"
        Me.ccbCTDBGShowCaption.Padding = New System.Windows.Forms.Padding(4, 1, 1, 1)
        Me.ccbCTDBGShowCaption.Size = New System.Drawing.Size(99, 19)
        Me.ccbCTDBGShowCaption.TabIndex = 0
        Me.ccbCTDBGShowCaption.Text = "Show caption"
        Me.c1ThemeController1.SetTheme(Me.ccbCTDBGShowCaption, "(default)")
        Me.ccbCTDBGShowCaption.UseVisualStyleBackColor = True
        Me.ccbCTDBGShowCaption.Value = Nothing
        Me.ccbCTDBGShowCaption.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'copC1Schedule
        '
        Me.copC1Schedule.Controls.Add(Me.ctbC1ScheduleView)
        Me.copC1Schedule.Controls.Add(Me.panel3)
        Me.copC1Schedule.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.copC1Schedule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.copC1Schedule.ImageIndex = 2
        Me.copC1Schedule.Name = "copC1Schedule"
        Me.copC1Schedule.Size = New System.Drawing.Size(300, 354)
        Me.copC1Schedule.Text = "C1Schedule"
        Me.c1ThemeController1.SetTheme(Me.copC1Schedule, "(default)")
        '
        'ctbC1ScheduleView
        '
        Me.ctbC1ScheduleView.AccessibleName = "Tool Bar"
        Me.ctbC1ScheduleView.AutoSize = False
        Me.ctbC1ScheduleView.ButtonLookVert = CType((C1.Win.C1Command.ButtonLookFlags.Text Or C1.Win.C1Command.ButtonLookFlags.Image), C1.Win.C1Command.ButtonLookFlags)
        Me.ctbC1ScheduleView.CommandHolder = Me.cchMain
        Me.ctbC1ScheduleView.CommandLinks.AddRange(New C1.Win.C1Command.C1CommandLink() {Me.c1CommandLink10, Me.c1CommandLink11, Me.c1CommandLink12, Me.c1CommandLink13, Me.c1CommandLink14})
        Me.ctbC1ScheduleView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctbC1ScheduleView.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.ctbC1ScheduleView.Horizontal = False
        Me.ctbC1ScheduleView.Location = New System.Drawing.Point(0, 0)
        Me.ctbC1ScheduleView.Movable = False
        Me.ctbC1ScheduleView.Name = "ctbC1ScheduleView"
        Me.ctbC1ScheduleView.Size = New System.Drawing.Size(300, 298)
        Me.ctbC1ScheduleView.Text = "Page1"
        Me.c1ThemeController1.SetTheme(Me.ctbC1ScheduleView, "(default)")
        '
        'c1CommandLink10
        '
        Me.c1CommandLink10.Command = Me.ccCSViewDay
        '
        'c1CommandLink11
        '
        Me.c1CommandLink11.Command = Me.ccCSViewWorkWeek
        Me.c1CommandLink11.SortOrder = 1
        '
        'c1CommandLink12
        '
        Me.c1CommandLink12.Command = Me.ccCSViewWeek
        Me.c1CommandLink12.SortOrder = 2
        '
        'c1CommandLink13
        '
        Me.c1CommandLink13.Command = Me.ccCSViewMonth
        Me.c1CommandLink13.SortOrder = 3
        '
        'c1CommandLink14
        '
        Me.c1CommandLink14.Command = Me.ccCSViewTimeLine
        Me.c1CommandLink14.SortOrder = 4
        '
        'panel3
        '
        Me.panel3.BackColor = System.Drawing.Color.White
        Me.panel3.Controls.Add(Me.ccbCSOffice2003WeekView)
        Me.panel3.Controls.Add(Me.ccbCSEnableGrouping)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panel3.Location = New System.Drawing.Point(0, 298)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(300, 56)
        Me.panel3.TabIndex = 3
        Me.c1ThemeController1.SetTheme(Me.panel3, "(default)")
        '
        'ccbCSOffice2003WeekView
        '
        Me.ccbCSOffice2003WeekView.AutoSize = True
        Me.ccbCSOffice2003WeekView.BackColor = System.Drawing.Color.Transparent
        Me.ccbCSOffice2003WeekView.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ccbCSOffice2003WeekView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ccbCSOffice2003WeekView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccbCSOffice2003WeekView.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ccbCSOffice2003WeekView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ccbCSOffice2003WeekView.Location = New System.Drawing.Point(3, 26)
        Me.ccbCSOffice2003WeekView.Name = "ccbCSOffice2003WeekView"
        Me.ccbCSOffice2003WeekView.Padding = New System.Windows.Forms.Padding(4, 1, 1, 1)
        Me.ccbCSOffice2003WeekView.Size = New System.Drawing.Size(146, 19)
        Me.ccbCSOffice2003WeekView.TabIndex = 1
        Me.ccbCSOffice2003WeekView.Text = "Office 2003 Week View"
        Me.c1ThemeController1.SetTheme(Me.ccbCSOffice2003WeekView, "(default)")
        Me.ccbCSOffice2003WeekView.UseVisualStyleBackColor = True
        Me.ccbCSOffice2003WeekView.Value = Nothing
        Me.ccbCSOffice2003WeekView.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'ccbCSEnableGrouping
        '
        Me.ccbCSEnableGrouping.AutoSize = True
        Me.ccbCSEnableGrouping.BackColor = System.Drawing.Color.Transparent
        Me.ccbCSEnableGrouping.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.ccbCSEnableGrouping.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ccbCSEnableGrouping.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ccbCSEnableGrouping.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ccbCSEnableGrouping.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ccbCSEnableGrouping.Location = New System.Drawing.Point(3, 3)
        Me.ccbCSEnableGrouping.Name = "ccbCSEnableGrouping"
        Me.ccbCSEnableGrouping.Padding = New System.Windows.Forms.Padding(4, 1, 1, 1)
        Me.ccbCSEnableGrouping.Size = New System.Drawing.Size(116, 19)
        Me.ccbCSEnableGrouping.TabIndex = 0
        Me.ccbCSEnableGrouping.Text = "Enable Grouping"
        Me.c1ThemeController1.SetTheme(Me.ccbCSEnableGrouping, "(default)")
        Me.ccbCSEnableGrouping.UseVisualStyleBackColor = True
        Me.ccbCSEnableGrouping.Value = Nothing
        Me.ccbCSEnableGrouping.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2010Blue
        '
        'c1DockingTabPage2
        '
        Me.c1DockingTabPage2.CaptionVisible = True
        Me.c1DockingTabPage2.ImageIndex = 11
        Me.c1DockingTabPage2.Location = New System.Drawing.Point(4, 1)
        Me.c1DockingTabPage2.Name = "c1DockingTabPage2"
        Me.c1DockingTabPage2.Size = New System.Drawing.Size(300, 490)
        Me.c1DockingTabPage2.TabIndex = 1
        Me.c1DockingTabPage2.Text = "Search"
        '
        'c1DockingTab2
        '
        Me.c1DockingTab2.BackColor = System.Drawing.Color.White
        Me.c1DockingTab2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.c1DockingTab2.Controls.Add(Me.c1DockingTabPage3)
        Me.c1DockingTab2.Controls.Add(Me.c1DockingTabPage4)
        Me.c1DockingTab2.Controls.Add(Me.c1DockingTabPage5)
        Me.c1DockingTab2.Controls.Add(Me.c1DockingTabPage6)
        Me.c1DockingTab2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1DockingTab2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.c1DockingTab2.HotTrack = True
        Me.c1DockingTab2.Location = New System.Drawing.Point(265, 146)
        Me.c1DockingTab2.Name = "c1DockingTab2"
        Me.c1DockingTab2.Size = New System.Drawing.Size(666, 517)
        Me.c1DockingTab2.TabIndex = 9
        Me.c1DockingTab2.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        Me.c1DockingTab2.TabsShowFocusCues = False
        Me.c1DockingTab2.TabsSpacing = 2
        Me.c1DockingTab2.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007
        Me.c1ThemeController1.SetTheme(Me.c1DockingTab2, "(default)")
        '
        'c1DockingTabPage3
        '
        Me.c1DockingTabPage3.Controls.Add(Me.c1FlexGrid1)
        Me.c1DockingTabPage3.Location = New System.Drawing.Point(1, 26)
        Me.c1DockingTabPage3.Name = "c1DockingTabPage3"
        Me.c1DockingTabPage3.Size = New System.Drawing.Size(664, 490)
        Me.c1DockingTabPage3.TabIndex = 0
        Me.c1DockingTabPage3.Text = "C1FlexGrid"
        '
        'c1FlexGrid1
        '
        Me.c1FlexGrid1.BackColor = System.Drawing.Color.White
        Me.c1FlexGrid1.ColumnInfo = resources.GetString("c1FlexGrid1.ColumnInfo")
        Me.c1FlexGrid1.DataSource = Me.employeesBindingSource
        Me.c1FlexGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1FlexGrid1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.c1FlexGrid1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1FlexGrid1.Location = New System.Drawing.Point(0, 0)
        Me.c1FlexGrid1.Name = "c1FlexGrid1"
        Me.c1FlexGrid1.Rows.Count = 1
        Me.c1FlexGrid1.Rows.DefaultSize = 21
        Me.c1FlexGrid1.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None
        Me.c1FlexGrid1.Size = New System.Drawing.Size(664, 490)
        Me.c1FlexGrid1.StyleInfo = resources.GetString("c1FlexGrid1.StyleInfo")
        Me.c1FlexGrid1.TabIndex = 0
        Me.c1ThemeController1.SetTheme(Me.c1FlexGrid1, "(default)")
        Me.c1FlexGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        '
        'employeesBindingSource
        '
        Me.employeesBindingSource.DataMember = "Employees"
        Me.employeesBindingSource.DataSource = Me.c1NWINDDataSet
        '
        'c1NWINDDataSet
        '
        Me.c1NWINDDataSet.DataSetName = "C1NWINDDataSet"
        Me.c1NWINDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'c1DockingTabPage4
        '
        Me.c1DockingTabPage4.Controls.Add(Me.c1TrueDBGrid1)
        Me.c1DockingTabPage4.Location = New System.Drawing.Point(1, 26)
        Me.c1DockingTabPage4.Name = "c1DockingTabPage4"
        Me.c1DockingTabPage4.Size = New System.Drawing.Size(664, 490)
        Me.c1DockingTabPage4.TabIndex = 1
        Me.c1DockingTabPage4.Text = "C1TrueDBGrid"
        '
        'c1TrueDBGrid1
        '
        Me.c1TrueDBGrid1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.c1TrueDBGrid1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.c1TrueDBGrid1.DataSource = Me.employeesBindingSource
        Me.c1TrueDBGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1TrueDBGrid1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.c1TrueDBGrid1.Images.Add(CType(resources.GetObject("c1TrueDBGrid1.Images"), System.Drawing.Image))
        Me.c1TrueDBGrid1.Location = New System.Drawing.Point(0, 0)
        Me.c1TrueDBGrid1.Name = "c1TrueDBGrid1"
        Me.c1TrueDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.c1TrueDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75.0R
        Me.c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = Nothing
        Me.c1TrueDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag")
        Me.c1TrueDBGrid1.RowDivider.Color = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.c1TrueDBGrid1.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.c1TrueDBGrid1.RowHeight = 17
        Me.c1TrueDBGrid1.RowSubDividerColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.c1TrueDBGrid1.Size = New System.Drawing.Size(664, 490)
        Me.c1TrueDBGrid1.TabIndex = 0
        Me.c1TrueDBGrid1.Text = "c1TrueDBGrid1"
        Me.c1ThemeController1.SetTheme(Me.c1TrueDBGrid1, "(default)")
        Me.c1TrueDBGrid1.UseCompatibleTextRendering = False
        Me.c1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Custom
        '
        'c1DockingTabPage5
        '
        Me.c1DockingTabPage5.Controls.Add(Me.csMain)
        Me.c1DockingTabPage5.Location = New System.Drawing.Point(1, 26)
        Me.c1DockingTabPage5.Name = "c1DockingTabPage5"
        Me.c1DockingTabPage5.Size = New System.Drawing.Size(664, 490)
        Me.c1DockingTabPage5.TabIndex = 2
        Me.c1DockingTabPage5.Text = "C1Schedule"
        '
        'csMain
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
        PrintStyle1.Description = "Daily Style"
        PrintStyle1.StyleName = "Daily"
        PrintStyle1.StyleSource = "day.c1d"
        PrintStyle2.Description = "Weekly Style"
        PrintStyle2.StyleName = "Week"
        PrintStyle2.StyleSource = "week.c1d"
        PrintStyle3.Description = "Monthly Style"
        PrintStyle3.StyleName = "Month"
        PrintStyle3.StyleSource = "month.c1d"
        PrintStyle4.Description = "Details Style"
        PrintStyle4.StyleName = "Details"
        PrintStyle4.StyleSource = "details.c1d"
        PrintStyle5.Context = C1.C1Schedule.Printing.PrintContextType.Appointment
        PrintStyle5.Description = "Memo Style"
        PrintStyle5.StyleName = "Memo"
        PrintStyle5.StyleSource = "memo.c1d"
        Me.csMain.PrintInfo.PrintStyles.AddRange(New C1.C1Schedule.Printing.PrintStyle() {PrintStyle1, PrintStyle2, PrintStyle3, PrintStyle4, PrintStyle5})
        '
        '
        '
        Me.csMain.Settings.AllowCategoriesEditing = False
        Me.csMain.Settings.AllowCategoriesMultiSelection = False
        Me.csMain.Settings.AllowContactsEditing = False
        Me.csMain.Settings.AllowContactsMultiSelection = False
        Me.csMain.Settings.FirstVisibleTime = System.TimeSpan.Parse("06:00:00")
        Me.csMain.ShowTitle = False
        Me.csMain.Size = New System.Drawing.Size(664, 490)
        Me.csMain.TabIndex = 5
        Me.c1ThemeController1.SetTheme(Me.csMain, "(default)")
        Me.csMain.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WorkWeekView
        Me.csMain.VisualStyle = C1.Win.C1Schedule.UI.VisualStyle.Custom
        '
        'c1DockingTabPage6
        '
        Me.c1DockingTabPage6.Controls.Add(Me.c1GanttView1)
        Me.c1DockingTabPage6.Location = New System.Drawing.Point(1, 26)
        Me.c1DockingTabPage6.Name = "c1DockingTabPage6"
        Me.c1DockingTabPage6.Size = New System.Drawing.Size(664, 490)
        Me.c1DockingTabPage6.TabIndex = 3
        Me.c1DockingTabPage6.Text = "C1GanttView"
        '
        'c1GanttView1
        '
        Me.c1GanttView1.BackColor = System.Drawing.Color.White
        BarStyle1.BarColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(209, Byte), Integer))
        BarStyle1.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle1.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle1.EndShape = 22
        BarStyle1.RightText1_ID = -13
        BarStyle1.StartShape = 21
        BarStyle2.BarColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer), CType(CType(63, Byte), Integer))
        BarStyle2.BarShape = C1.Win.C1GanttView.BarShape.MiddleBar
        BarStyle2.BarType = C1.Win.C1GanttView.BarType.Progress
        BarStyle4.BarType = C1.Win.C1GanttView.BarType.Deadline
        BarStyle4.StartColor = System.Drawing.Color.Green
        BarStyle4.StartShape = 12
        BarStyle5.BarColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(220, Byte), Integer))
        BarStyle5.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle5.BarType = C1.Win.C1GanttView.BarType.AutoTask
        BarStyle5.RightText1_ID = -13
        BarStyle6.BarShape = C1.Win.C1GanttView.BarShape.MiddleBar
        BarStyle6.BarType = C1.Win.C1GanttView.BarType.GroupTask
        BarStyle6.EndShape = 17
        BarStyle6.RightText1_ID = -1
        BarStyle6.StartShape = 17
        BarStyle7.BarShape = C1.Win.C1GanttView.BarShape.TopBar
        BarStyle7.BarType = C1.Win.C1GanttView.BarType.SummaryTask
        BarStyle7.EndShape = 2
        BarStyle7.StartShape = 2
        BarStyle8.BarColor = System.Drawing.Color.Gray
        BarStyle8.BarShape = C1.Win.C1GanttView.BarShape.TopBar
        BarStyle8.BarType = C1.Win.C1GanttView.BarType.ProjectSummary
        BarStyle8.EndColor = System.Drawing.Color.Gray
        BarStyle8.EndShape = 2
        BarStyle8.StartColor = System.Drawing.Color.Gray
        BarStyle8.StartShape = 2
        BarStyle9.BarType = C1.Win.C1GanttView.BarType.Milestone
        BarStyle9.EndShape = 3
        BarStyle9.RightText1_ID = -7
        BarStyle10.BarColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer))
        BarStyle10.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle10.BarType = C1.Win.C1GanttView.BarType.DurationOnly
        BarStyle10.EndColor = System.Drawing.Color.White
        BarStyle10.EndShape = 24
        BarStyle10.StartColor = System.Drawing.Color.White
        BarStyle10.StartShape = 23
        BarStyle11.BarType = C1.Win.C1GanttView.BarType.DurationOnlyMilestone
        BarStyle11.EndColor = System.Drawing.Color.LightGray
        BarStyle11.EndShape = 3
        BarStyle12.BarType = C1.Win.C1GanttView.BarType.StartOnly
        BarStyle12.StartShape = 21
        BarStyle13.BarType = C1.Win.C1GanttView.BarType.FinishOnly
        BarStyle13.EndShape = 22
        BarStyle14.BarColor = System.Drawing.Color.Pink
        BarStyle14.BarShape = C1.Win.C1GanttView.BarShape.MiddleBar
        BarStyle14.BarType = C1.Win.C1GanttView.BarType.SummaryProgress
        BarStyle15.BarColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(255, Byte), Integer))
        BarStyle15.BarShape = C1.Win.C1GanttView.BarShape.Frame
        BarStyle15.BarType = C1.Win.C1GanttView.BarType.InactiveTask
        BarStyle15.RightText1_ID = -13
        BarStyle16.BarShape = C1.Win.C1GanttView.BarShape.HalfFrame
        BarStyle16.BarType = C1.Win.C1GanttView.BarType.InactiveSummary
        BarStyle16.EndShape = 2
        BarStyle16.StartShape = 2
        BarStyle17.BarType = C1.Win.C1GanttView.BarType.InactiveMilestone
        BarStyle17.EndShape = 25
        BarStyle17.RightText1_ID = -7
        Me.c1GanttView1.BarStyles.Add(BarStyle1)
        Me.c1GanttView1.BarStyles.Add(BarStyle2)
        Me.c1GanttView1.BarStyles.Add(BarStyle3)
        Me.c1GanttView1.BarStyles.Add(BarStyle4)
        Me.c1GanttView1.BarStyles.Add(BarStyle5)
        Me.c1GanttView1.BarStyles.Add(BarStyle6)
        Me.c1GanttView1.BarStyles.Add(BarStyle7)
        Me.c1GanttView1.BarStyles.Add(BarStyle8)
        Me.c1GanttView1.BarStyles.Add(BarStyle9)
        Me.c1GanttView1.BarStyles.Add(BarStyle10)
        Me.c1GanttView1.BarStyles.Add(BarStyle11)
        Me.c1GanttView1.BarStyles.Add(BarStyle12)
        Me.c1GanttView1.BarStyles.Add(BarStyle13)
        Me.c1GanttView1.BarStyles.Add(BarStyle14)
        Me.c1GanttView1.BarStyles.Add(BarStyle15)
        Me.c1GanttView1.BarStyles.Add(BarStyle16)
        Me.c1GanttView1.BarStyles.Add(BarStyle17)
        CalendarException1.Name = "Vacation"
        CalendarException1.RecurrencePattern.DayOfMonth = 10
        CalendarException1.RecurrencePattern.MonthOfYear = 7
        CalendarException1.StartDate = New Date(2013, 6, 10, 0, 0, 0, 0)
        Me.c1GanttView1.CalendarExceptions.Add(CalendarException1)
        Me.c1GanttView1.CellBorderColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.c1GanttView1.ChartViewZoomFactor = 7.0!
        TaskPropertyColumn1.Caption = "Task Mode"
        TaskPropertyColumn1.ID = 619243840
        TaskPropertyColumn1.Property = C1.Win.C1GanttView.TaskProperty.Mode
        TaskPropertyColumn1.Width = 90
        TaskPropertyColumn2.Caption = "Task Name"
        TaskPropertyColumn2.ID = 2099866733
        TaskPropertyColumn2.Property = C1.Win.C1GanttView.TaskProperty.Name
        TaskPropertyColumn2.Width = 80
        TaskPropertyColumn3.Caption = "Duration"
        TaskPropertyColumn3.ID = 1358251825
        TaskPropertyColumn3.Property = C1.Win.C1GanttView.TaskProperty.Duration
        TaskPropertyColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        TaskPropertyColumn3.Visible = False
        TaskPropertyColumn3.Width = 45
        TaskPropertyColumn4.Caption = "Duration Units"
        TaskPropertyColumn4.ID = 1827635185
        TaskPropertyColumn4.Property = C1.Win.C1GanttView.TaskProperty.DurationUnits
        TaskPropertyColumn4.Visible = False
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
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn1)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn2)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn3)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn4)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn5)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn6)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn7)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn8)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn9)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn10)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn11)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn12)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn13)
        Me.c1GanttView1.Columns.Add(TaskPropertyColumn14)
        '
        '
        '
        Me.c1GanttView1.DefaultWorkingTimes.Interval_1.Empty = False
        Me.c1GanttView1.DefaultWorkingTimes.Interval_1.From = New Date(1, 1, 1, 8, 30, 0, 0)
        Me.c1GanttView1.DefaultWorkingTimes.Interval_1.To = New Date(1, 1, 1, 12, 0, 0, 0)
        Me.c1GanttView1.DefaultWorkingTimes.Interval_2.Empty = False
        Me.c1GanttView1.DefaultWorkingTimes.Interval_2.From = New Date(1, 1, 1, 13, 30, 0, 0)
        Me.c1GanttView1.DefaultWorkingTimes.Interval_2.To = New Date(1, 1, 1, 18, 0, 0, 0)
        Me.c1GanttView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.c1GanttView1.EmptyAreaBackColor = System.Drawing.Color.FromArgb(CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.c1GanttView1.FinishDate = New Date(2013, 6, 29, 0, 0, 0, 0)
        Me.c1GanttView1.FirstMonthOfFY = C1.Win.C1GanttView.FirstMonthOfFY.March
        Me.c1GanttView1.FixedBackColor = System.Drawing.Color.White
        Me.c1GanttView1.FixedCellBorderColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.c1GanttView1.FixedForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1GanttView1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.c1GanttView1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1GanttView1.GridWidth = 215
        Me.c1GanttView1.GroupBackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.c1GanttView1.HighlightBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(114, Byte), Integer), CType(CType(198, Byte), Integer))
        Me.c1GanttView1.HighlightForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.c1GanttView1.Location = New System.Drawing.Point(0, 0)
        Me.c1GanttView1.Name = "c1GanttView1"
        Me.c1GanttView1.ProgressLine.StatusDate = New Date(2013, 6, 19, 0, 0, 0, 0)
        Me.c1GanttView1.ProgressLine.Visible = True
        Task1.ID = 558389010
        Task1.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task1.Name = "Project Summary Task"
        Task1.NextID = 0
        Task1.PercentComplete = 0.47368421052631576R
        Me.c1GanttView1.ProjectSummary = Task1
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
        Me.c1GanttView1.Resources.AddRange(New C1.Win.C1GanttView.Resource() {Resource1, Resource2, Resource3, Resource4, Resource5, Resource6, Resource7, Resource8, Resource9})
        Me.c1GanttView1.ScheduleFrom = C1.Win.C1GanttView.ScheduleFrom.ProjectFinishDate
        Me.c1GanttView1.ShowToolbar = False
        Me.c1GanttView1.Size = New System.Drawing.Size(664, 490)
        Me.c1GanttView1.SplitterColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.c1GanttView1.TabIndex = 0
        Task2.Finish = New Date(2013, 6, 7, 0, 0, 0, 0)
        Task2.ID = 362538391
        Task2.Name = "Planning"
        Task2.NextID = 110002178
        Task2.OutlineParentID = 558389010
        Task2.PercentComplete = 1.0R
        ResourceRef1.Amount = 1.0R
        ResourceRef1.ResourceID = 766290656
        ResourceRef2.Amount = 1.0R
        ResourceRef2.ResourceID = 1334638351
        ResourceRef3.Amount = 1.0R
        ResourceRef3.ResourceID = 239555279
        Task2.ResourceRefs.Add(ResourceRef1)
        Task2.ResourceRefs.Add(ResourceRef2)
        Task2.ResourceRefs.Add(ResourceRef3)
        Task2.Start = New Date(2013, 6, 4, 0, 0, 0, 0)
        Task3.ID = 110002178
        Task3.NextID = 1179983348
        BarStyle18.BarColor = System.Drawing.Color.PaleVioletRed
        BarStyle18.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle18.BarType = C1.Win.C1GanttView.BarType.AutoTask
        BarStyle18.TopText1_ID = 1673084976
        Task4.BarStyles.Add(BarStyle18)
        Task4.ConstraintDate = New Date(2013, 6, 7, 0, 0, 0, 0)
        Task4.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
        Task4.Deadline = New Date(2013, 6, 15, 0, 0, 0, 0)
        Task4.Duration = 4.0R
        Task4.ID = 1179983348
        Task4.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task4.Name = "Analysis"
        Task4.NextID = 1427410353
        Task4.OutlineParentID = 558389010
        Task4.PercentComplete = 1.0R
        Predecessor1.PredecessorTaskID = 362538391
        Task4.Predecessors.Add(Predecessor1)
        ResourceRef4.Amount = 1.0R
        ResourceRef4.ResourceID = 2011144056
        Task4.ResourceRefs.Add(ResourceRef4)
        Task5.ID = 1427410353
        Task5.NextID = 2098269195
        Task6.Finish = New Date(2013, 6, 18, 18, 0, 0, 0)
        Task6.ID = 2098269195
        Task6.Name = "Design"
        Task6.NextID = 1753282054
        Task6.OutlineParentID = 558389010
        Task6.PercentComplete = 0.5R
        Predecessor2.PredecessorTaskID = 1179983348
        Task6.Predecessors.Add(Predecessor2)
        ResourceRef5.Amount = 1.0R
        ResourceRef5.ResourceID = 2101511829
        ResourceRef6.Amount = 1.0R
        ResourceRef6.ResourceID = 1869891731
        Task6.ResourceRefs.Add(ResourceRef5)
        Task6.ResourceRefs.Add(ResourceRef6)
        Task6.Start = New Date(2013, 6, 13, 8, 30, 0, 0)
        Task7.ID = 1753282054
        Task7.NextID = 792666599
        Task8.ConstraintDate = New Date(2013, 6, 19, 0, 0, 0, 0)
        Task8.ConstraintType = C1.Win.C1GanttView.ConstraintType.StartNoEarlierThan
        Task8.Duration = 4.0R
        Task8.ID = 792666599
        Task8.Mode = C1.Win.C1GanttView.TaskMode.Automatic
        Task8.Name = "Implementation"
        Task8.NextID = 1853855961
        Task8.OutlineParentID = 558389010
        Predecessor3.PredecessorTaskID = 2098269195
        Task8.Predecessors.Add(Predecessor3)
        ResourceRef7.Amount = 1.0R
        ResourceRef7.ResourceID = 1334638351
        ResourceRef8.Amount = 1.0R
        ResourceRef8.ResourceID = 766290656
        Task8.ResourceRefs.Add(ResourceRef7)
        Task8.ResourceRefs.Add(ResourceRef8)
        Task9.ID = 1853855961
        Task9.NextID = 2121238572
        BarStyle19.BarColor = System.Drawing.Color.Green
        BarStyle19.BarShape = C1.Win.C1GanttView.BarShape.ThickBar
        BarStyle19.BarType = C1.Win.C1GanttView.BarType.ManualTask
        BarStyle19.EndShape = 22
        BarStyle19.LeftText1_ID = 1673084976
        BarStyle19.StartShape = 21
        Task10.BarStyles.Add(BarStyle19)
        Task10.Deadline = New Date(2013, 6, 28, 0, 0, 0, 0)
        Task10.Finish = New Date(2013, 6, 27, 8, 30, 0, 0)
        Task10.ID = 2121238572
        Task10.Name = "Documentation"
        Task10.NextID = 1728214611
        Task10.OutlineParentID = 558389010
        Predecessor4.PredecessorTaskID = 792666599
        Task10.Predecessors.Add(Predecessor4)
        ResourceRef9.Amount = 1.0R
        ResourceRef9.ResourceID = 1640417825
        ResourceRef10.Amount = 1.0R
        ResourceRef10.ResourceID = 556319480
        Task10.ResourceRefs.Add(ResourceRef9)
        Task10.ResourceRefs.Add(ResourceRef10)
        Task10.Start = New Date(2013, 6, 25, 8, 30, 0, 0)
        Task11.ID = 1728214611
        Task11.NextID = 312019882
        Task12.Finish = New Date(2013, 6, 28, 18, 0, 0, 0)
        Task12.ID = 312019882
        Task12.Name = "Support"
        Task12.NextID = 2131650479
        Task12.OutlineParentID = 558389010
        Predecessor5.PredecessorTaskID = 2121238572
        Task12.Predecessors.Add(Predecessor5)
        ResourceRef11.Amount = 1.0R
        ResourceRef11.ResourceID = 2011144056
        Task12.ResourceRefs.Add(ResourceRef11)
        Task12.Start = New Date(2013, 6, 27, 8, 30, 0, 0)
        Task13.ID = 2131650479
        Task13.NextID = 1600264846
        Task14.ID = 1600264846
        Task14.NextID = 185936048
        Task15.ID = 185936048
        Task15.NextID = 1447717244
        Task16.ID = 1447717244
        Task16.NextID = 1352797036
        Task17.ID = 1352797036
        Task17.NextID = 1301076315
        Task18.ID = 1301076315
        Task18.NextID = 562163695
        Task19.ID = 562163695
        Task19.NextID = 19552401
        Task20.ID = 19552401
        Task20.NextID = 1597983629
        Task21.ID = 1597983629
        Task21.NextID = 591786279
        Task22.ID = 591786279
        Task22.NextID = 816445275
        Task23.ID = 816445275
        Task23.NextID = 514161404
        Task24.ID = 514161404
        Task24.NextID = 992389273
        Task25.ID = 992389273
        Task25.NextID = 246882487
        Task26.ID = 246882487
        Task26.NextID = 1546671531
        Task27.ID = 1546671531
        Task27.NextID = 2076126586
        Task28.ID = 2076126586
        Task28.NextID = -1
        Me.c1GanttView1.Tasks.AddRange(New C1.Win.C1GanttView.Task() {Task2, Task3, Task4, Task5, Task6, Task7, Task8, Task9, Task10, Task11, Task12, Task13, Task14, Task15, Task16, Task17, Task18, Task19, Task20, Task21, Task22, Task23, Task24, Task25, Task26, Task27, Task28})
        Me.c1ThemeController1.SetTheme(Me.c1GanttView1, "(default)")
        Me.c1GanttView1.Timescale.BottomTier.Align = C1.Win.C1GanttView.ScaleLabelAlignment.Center
        Me.c1GanttView1.Timescale.BottomTier.Format = "w"
        Me.c1GanttView1.Timescale.BottomTier.Visible = True
        Me.c1GanttView1.Timescale.MiddleTier.Format = "nnn d, \'yy"
        Me.c1GanttView1.Timescale.MiddleTier.MinWidth = 62
        Me.c1GanttView1.Timescale.MiddleTier.Units = C1.Win.C1GanttView.TimescaleUnits.Weeks
        Me.c1GanttView1.Timescale.MiddleTier.Visible = True
        Me.c1GanttView1.ToolbarBackColor = System.Drawing.Color.White
        Me.c1GanttView1.VisualStyle = C1.Win.C1GanttView.VisualStyle.Custom
        '
        'employeesTableAdapter
        '
        Me.employeesTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1236, 685)
        Me.Controls.Add(Me.c1DockingTab2)
        Me.Controls.Add(Me.c1CommandDock1)
        Me.Controls.Add(Me.c1NavBar1)
        Me.Controls.Add(Me.c1StatusBar1)
        Me.Controls.Add(Me.crMain)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.c1ThemeController1.SetTheme(Me, "(default)")
        CType(Me.c1ThemeController1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.crMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1StatusBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1NavBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1NavBar1.ResumeLayout(False)
        Me.c1NavBarPanel5.ResumeLayout(False)
        CType(Me.ctbMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1NavBarPanel2.ResumeLayout(False)
        CType(Me.c1Calendar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1NavBarPanel3.ResumeLayout(False)
        Me.c1NavBarPanel4.ResumeLayout(False)
        CType(Me.c1CommandDock1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1CommandDock1.ResumeLayout(False)
        CType(Me.c1DockingTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1DockingTab1.ResumeLayout(False)
        Me.c1DockingTabPage1.ResumeLayout(False)
        CType(Me.c1OutBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1OutBar1.ResumeLayout(False)
        Me.copC1FlexGrid.ResumeLayout(False)
        CType(Me.cchMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.csbFocusRect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.csbSelectionMode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cneFixedRowCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccbShowCursor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cneFixedColCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1Label3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.copC1TrueDBGrid.ResumeLayout(False)
        Me.panel2.ResumeLayout(False)
        Me.panel2.PerformLayout()
        CType(Me.ccbCTDBGShowFilterBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccbCTDBGShowCaption, System.ComponentModel.ISupportInitialize).EndInit()
        Me.copC1Schedule.ResumeLayout(False)
        Me.panel3.ResumeLayout(False)
        Me.panel3.PerformLayout()
        CType(Me.ccbCSOffice2003WeekView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ccbCSEnableGrouping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1DockingTab2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1DockingTab2.ResumeLayout(False)
        Me.c1DockingTabPage3.ResumeLayout(False)
        CType(Me.c1FlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1NWINDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1DockingTabPage4.ResumeLayout(False)
        CType(Me.c1TrueDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1DockingTabPage5.ResumeLayout(False)
        CType(Me.csMain.DataStorage.AppointmentStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.csMain.DataStorage.CategoryStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.csMain.DataStorage.ContactStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.csMain.DataStorage.LabelStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.csMain.DataStorage.OwnerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.csMain.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.csMain.DataStorage.StatusStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.csMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.c1DockingTabPage6.ResumeLayout(False)
        CType(Me.c1GanttView1.DataStorage.CalendarStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1GanttView1.DataStorage.PropertyStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1GanttView1.DataStorage.ResourceStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1GanttView1.DataStorage.TasksStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.c1GanttView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private c1ThemeController1 As C1.Win.C1Themes.C1ThemeController
    Private newButton As C1.Win.Ribbon.RibbonButton
    Private openButton As C1.Win.Ribbon.RibbonButton
    Private saveButton As C1.Win.Ribbon.RibbonButton
    Private crMain As C1.Win.Ribbon.C1Ribbon
    Private appMenu As C1.Win.Ribbon.RibbonApplicationMenu
    Private optionsButton As C1.Win.Ribbon.RibbonButton
    Private WithEvents exitButton As C1.Win.Ribbon.RibbonButton
    Private ribbonSeparator9 As C1.Win.Ribbon.RibbonSeparator
    Private printSplitButton As C1.Win.Ribbon.RibbonSplitButton
    Private printMenuLabel As C1.Win.Ribbon.RibbonLabel
    Private printButton As C1.Win.Ribbon.RibbonButton
    Private quickPrintButton As C1.Win.Ribbon.RibbonButton
    Private previewButton As C1.Win.Ribbon.RibbonButton
    Private prepareMenu As C1.Win.Ribbon.RibbonMenu
    Private prepareMenuLabel As C1.Win.Ribbon.RibbonLabel
    Private propertiesButton As C1.Win.Ribbon.RibbonButton
    Private inspectDocumentButton As C1.Win.Ribbon.RibbonButton
    Private encryptDocumentButton As C1.Win.Ribbon.RibbonButton
    Private restrictPermissionMenu As C1.Win.Ribbon.RibbonMenu
    Private unrestrictedAccessToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private restrictedAccessToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonSeparator11 As C1.Win.Ribbon.RibbonSeparator
    Private manageCredentialsButton As C1.Win.Ribbon.RibbonButton
    Private addSignatureButton As C1.Win.Ribbon.RibbonButton
    Private markAsFinalButton As C1.Win.Ribbon.RibbonButton
    Private ribbonSeparator10 As C1.Win.Ribbon.RibbonSeparator
    Private closeButton As C1.Win.Ribbon.RibbonButton
    Private ribbonListItem1 As C1.Win.Ribbon.RibbonListItem
    Private recentDocumentsLabel As C1.Win.Ribbon.RibbonLabel
    Private ribbonListItem2 As C1.Win.Ribbon.RibbonListItem
    Private ribbonSeparator12 As C1.Win.Ribbon.RibbonSeparator
    Private ribbonListItem3 As C1.Win.Ribbon.RibbonListItem
    Private rcListLabel1 As C1.Win.Ribbon.RibbonLabel
    Private rcListPinButton1 As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonListItem4 As C1.Win.Ribbon.RibbonListItem
    Private rcListLabel2 As C1.Win.Ribbon.RibbonLabel
    Private rcListPinButton2 As C1.Win.Ribbon.RibbonToggleButton
    Private configToolBar As C1.Win.Ribbon.RibbonConfigToolBar
    Private themeMenu As C1.Win.Ribbon.RibbonMenu
    Private WithEvents minimizeRibbonButton As C1.Win.Ribbon.RibbonButton
    Private expandRibbonButton As C1.Win.Ribbon.RibbonButton
    Private helpConfigButton As C1.Win.Ribbon.RibbonButton
    Private rctgC1FlexGrid As C1.Win.Ribbon.RibbonContextualTabGroup
    Private rtC1FlexGrid As C1.Win.Ribbon.RibbonTab
    Private rgCFGView As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rglrCFGView As C1.Win.Ribbon.RibbonGallery
    Private rgiCFGViewNormal As C1.Win.Ribbon.RibbonGalleryItem
    Private rgiCFGViewTree As C1.Win.Ribbon.RibbonGalleryItem
    Private rgiCFGViewSubtotals As C1.Win.Ribbon.RibbonGalleryItem
    Private rgCFGOptions As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rnbCFGFixedColCount As C1.Win.Ribbon.RibbonNumericBox
    Private WithEvents rnbCFGFixedRowCount As C1.Win.Ribbon.RibbonNumericBox
    Private ribbonSeparator13 As C1.Win.Ribbon.RibbonSeparator
    Private WithEvents rcbCFGSelectionMode As C1.Win.Ribbon.RibbonComboBox
    Private WithEvents rcbCFGFocusRect As C1.Win.Ribbon.RibbonComboBox
    Private ribbonSeparator15 As C1.Win.Ribbon.RibbonSeparator
    Private WithEvents rcbCFGShowCursor As C1.Win.Ribbon.RibbonCheckBox
    Private rctgC1TrueDBGrid As C1.Win.Ribbon.RibbonContextualTabGroup
    Private rtC1TrueDBGrid As C1.Win.Ribbon.RibbonTab
    Private rgCTDBGView As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rglrCTDBGView As C1.Win.Ribbon.RibbonGallery
    Private rgiCTDBGViewNormal As C1.Win.Ribbon.RibbonGalleryItem
    Private rgiCTDBGViewInverted As C1.Win.Ribbon.RibbonGalleryItem
    Private rgiCTDBGViewForm As C1.Win.Ribbon.RibbonGalleryItem
    Private rgiCTDBGViewGroupBy As C1.Win.Ribbon.RibbonGalleryItem
    Private rgiCTDBGViewMultipleLines As C1.Win.Ribbon.RibbonGalleryItem
    Private rgiCTDBGViewHierarchical As C1.Win.Ribbon.RibbonGalleryItem
    Private rgCTDBGOptions As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rcbCTDBGShowCaption As C1.Win.Ribbon.RibbonCheckBox
    Private WithEvents rcbCTDBGShowFilterBar As C1.Win.Ribbon.RibbonCheckBox
    Private rctgC1Schedule As C1.Win.Ribbon.RibbonContextualTabGroup
    Private rtC1Schedule As C1.Win.Ribbon.RibbonTab
    Private rgCSView As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rglrCSView As C1.Win.Ribbon.RibbonGallery
    Private rgiCSViewDay As C1.Win.Ribbon.RibbonGalleryItem
    Private rgiCSViewWorkWeek As C1.Win.Ribbon.RibbonGalleryItem
    Private rgiCSViewWeek As C1.Win.Ribbon.RibbonGalleryItem
    Private rgiCSViewMonth As C1.Win.Ribbon.RibbonGalleryItem
    Private rgiCSViewTimeLine As C1.Win.Ribbon.RibbonGalleryItem
    Private rgCSOptions As C1.Win.Ribbon.RibbonGroup
    Private WithEvents rcbCSEnableGrouping As C1.Win.Ribbon.RibbonCheckBox
    Private WithEvents rcbCSOffice2003WeekView As C1.Win.Ribbon.RibbonCheckBox
    Private ilLarge As System.Windows.Forms.ImageList
    Private qat As C1.Win.Ribbon.RibbonQat
    Private undoSplitButton As C1.Win.Ribbon.RibbonSplitButton
    Private redoButton As C1.Win.Ribbon.RibbonButton
    Private ilSmall As System.Windows.Forms.ImageList
    Private homeTab As C1.Win.Ribbon.RibbonTab
    Private clipboardGroup As C1.Win.Ribbon.RibbonGroup
    Private pasteSplitButton As C1.Win.Ribbon.RibbonSplitButton
    Private pasteButton As C1.Win.Ribbon.RibbonButton
    Private pasteSpecialButton As C1.Win.Ribbon.RibbonButton
    Private cutButton As C1.Win.Ribbon.RibbonButton
    Private copyButton As C1.Win.Ribbon.RibbonButton
    Private formatPainterButton As C1.Win.Ribbon.RibbonButton
    Private fontGroup As C1.Win.Ribbon.RibbonGroup
    Private ribbonToolBar1 As C1.Win.Ribbon.RibbonToolBar
    Private fontComboBox As C1.Win.Ribbon.RibbonFontComboBox
    Private fontSizeComboBox As C1.Win.Ribbon.RibbonComboBox
    Private size8Button As C1.Win.Ribbon.RibbonButton
    Private size9Button As C1.Win.Ribbon.RibbonButton
    Private size10Button As C1.Win.Ribbon.RibbonButton
    Private size11Button As C1.Win.Ribbon.RibbonButton
    Private size12Button As C1.Win.Ribbon.RibbonButton
    Private size14Button As C1.Win.Ribbon.RibbonButton
    Private size16Button As C1.Win.Ribbon.RibbonButton
    Private size18Button As C1.Win.Ribbon.RibbonButton
    Private size20Button As C1.Win.Ribbon.RibbonButton
    Private size22Button As C1.Win.Ribbon.RibbonButton
    Private size24Button As C1.Win.Ribbon.RibbonButton
    Private size26Button As C1.Win.Ribbon.RibbonButton
    Private size28Button As C1.Win.Ribbon.RibbonButton
    Private size36Button As C1.Win.Ribbon.RibbonButton
    Private size48Button As C1.Win.Ribbon.RibbonButton
    Private size72Button As C1.Win.Ribbon.RibbonButton
    Private ribbonSeparator2 As C1.Win.Ribbon.RibbonSeparator
    Private growFontButton As C1.Win.Ribbon.RibbonButton
    Private shrinkFontButton As C1.Win.Ribbon.RibbonButton
    Private ribbonSeparator3 As C1.Win.Ribbon.RibbonSeparator
    Private clearFormattingButton As C1.Win.Ribbon.RibbonButton
    Private ribbonToolBar2 As C1.Win.Ribbon.RibbonToolBar
    Private boldToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private italicToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private underlineSplitButton As C1.Win.Ribbon.RibbonSplitButton
    Private subscriptToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private superscriptToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private changeCaseMenu As C1.Win.Ribbon.RibbonMenu
    Private caseMenuOption1 As C1.Win.Ribbon.RibbonButton
    Private caseMenuOption2 As C1.Win.Ribbon.RibbonButton
    Private caseMenuOption3 As C1.Win.Ribbon.RibbonButton
    Private caseMenuOption4 As C1.Win.Ribbon.RibbonButton
    Private caseMenuOption5 As C1.Win.Ribbon.RibbonButton
    Private ribbonSeparator16 As C1.Win.Ribbon.RibbonSeparator
    Private ribbonButton4 As C1.Win.Ribbon.RibbonButton
    Private ribbonSeparator4 As C1.Win.Ribbon.RibbonSeparator
    Private highlightColorSplitButton As C1.Win.Ribbon.RibbonSplitButton
    Private highlightTextColorPickerItem As C1.Win.Ribbon.RibbonColorPickerItem
    Private ribbonSeparator14 As C1.Win.Ribbon.RibbonSeparator
    Private noColorToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private fontColorPicker As C1.Win.Ribbon.RibbonColorPicker
    Private alignmentGroup As C1.Win.Ribbon.RibbonGroup
    Private ribbonToolBar3 As C1.Win.Ribbon.RibbonToolBar
    Private topAlignToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private middleAlignToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private bottomAlignToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonSeparator5 As C1.Win.Ribbon.RibbonSeparator
    Private orientationMenu As C1.Win.Ribbon.RibbonMenu
    Private ribbonToolBar4 As C1.Win.Ribbon.RibbonToolBar
    Private alignLeftToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private centerToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private alignRightToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonSeparator6 As C1.Win.Ribbon.RibbonSeparator
    Private decreaseIndentButton As C1.Win.Ribbon.RibbonButton
    Private increaseIndentButton As C1.Win.Ribbon.RibbonButton
    Private ribbonSeparator7 As C1.Win.Ribbon.RibbonSeparator
    Private wrapTextToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private mergeSplitButton As C1.Win.Ribbon.RibbonSplitButton
    Private mergeAndCenterButton As C1.Win.Ribbon.RibbonButton
    Private mergeCellsButton As C1.Win.Ribbon.RibbonButton
    Private unmergeCellsButton As C1.Win.Ribbon.RibbonButton
    Private viewTab As C1.Win.Ribbon.RibbonTab
    Private viewsGroup As C1.Win.Ribbon.RibbonGroup
    Private printLayoutToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private fullScreenToggleButton As C1.Win.Ribbon.RibbonToggleButton
    Private hideShowGroup As C1.Win.Ribbon.RibbonGroup
    Private rulerCheckBox As C1.Win.Ribbon.RibbonCheckBox
    Private gridlinesCheckBox As C1.Win.Ribbon.RibbonCheckBox
    Private messageBarCheckBox As C1.Win.Ribbon.RibbonCheckBox
    Private zoomGroup As C1.Win.Ribbon.RibbonGroup
    Private zoomButton As C1.Win.Ribbon.RibbonButton
    Private onePageButton As C1.Win.Ribbon.RibbonButton
    Private twoPagesButton As C1.Win.Ribbon.RibbonButton
    Private pageWidthButton As C1.Win.Ribbon.RibbonButton
    Private windowGroup As C1.Win.Ribbon.RibbonGroup
    Private newWindowButton As C1.Win.Ribbon.RibbonButton
    Private arrangeAllButton As C1.Win.Ribbon.RibbonButton
    Private splitWindowButton As C1.Win.Ribbon.RibbonButton
    Private ribbonSeparator8 As C1.Win.Ribbon.RibbonSeparator
    Private switchWindowsMenu As C1.Win.Ribbon.RibbonMenu
    Private rtControls As C1.Win.Ribbon.RibbonTab
    Private rgControlsNormal As C1.Win.Ribbon.RibbonGroup
    Private ribbonButton2 As C1.Win.Ribbon.RibbonButton
    Private ribbonButton3 As C1.Win.Ribbon.RibbonButton
    Private ribbonToolBar5 As C1.Win.Ribbon.RibbonToolBar
    Private ribbonToggleButton4 As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonToggleButton5 As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonToggleButton6 As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonColorPicker1 As C1.Win.Ribbon.RibbonColorPicker
    Private ribbonSplitButton1 As C1.Win.Ribbon.RibbonSplitButton
    Private ribbonButton5 As C1.Win.Ribbon.RibbonButton
    Private ribbonButton6 As C1.Win.Ribbon.RibbonButton
    Private ribbonButton7 As C1.Win.Ribbon.RibbonButton
    Private ribbonButton8 As C1.Win.Ribbon.RibbonButton
    Private ribbonSeparator17 As C1.Win.Ribbon.RibbonSeparator
    Private ribbonCheckBox1 As C1.Win.Ribbon.RibbonCheckBox
    Private ribbonCheckBox2 As C1.Win.Ribbon.RibbonCheckBox
    Private ribbonSeparator18 As C1.Win.Ribbon.RibbonSeparator
    Private ribbonComboBox1 As C1.Win.Ribbon.RibbonComboBox
    Private ribbonButton9 As C1.Win.Ribbon.RibbonButton
    Private ribbonButton10 As C1.Win.Ribbon.RibbonButton
    Private ribbonDatePicker1 As C1.Win.Ribbon.RibbonDatePicker
    Private ribbonNumericBox1 As C1.Win.Ribbon.RibbonNumericBox
    Private ribbonTextBox1 As C1.Win.Ribbon.RibbonTextBox
    Private ribbonTimePicker1 As C1.Win.Ribbon.RibbonTimePicker
    Private ribbonSeparator19 As C1.Win.Ribbon.RibbonSeparator
    Private ribbonProgressBar1 As C1.Win.Ribbon.RibbonProgressBar
    Private ribbonTrackBar2 As C1.Win.Ribbon.RibbonTrackBar
    Private rgControlsDisabled As C1.Win.Ribbon.RibbonGroup
    Private ribbonButton21 As C1.Win.Ribbon.RibbonButton
    Private ribbonButton31 As C1.Win.Ribbon.RibbonButton
    Private ribbonToolBar51 As C1.Win.Ribbon.RibbonToolBar
    Private ribbonToggleButton41 As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonToggleButton51 As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonToggleButton61 As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonColorPicker11 As C1.Win.Ribbon.RibbonColorPicker
    Private ribbonSplitButton11 As C1.Win.Ribbon.RibbonSplitButton
    Private ribbonButton51 As C1.Win.Ribbon.RibbonButton
    Private ribbonButton61 As C1.Win.Ribbon.RibbonButton
    Private ribbonButton71 As C1.Win.Ribbon.RibbonButton
    Private ribbonButton81 As C1.Win.Ribbon.RibbonButton
    Private ribbonSeparator171 As C1.Win.Ribbon.RibbonSeparator
    Private ribbonCheckBox11 As C1.Win.Ribbon.RibbonCheckBox
    Private ribbonCheckBox21 As C1.Win.Ribbon.RibbonCheckBox
    Private ribbonSeparator181 As C1.Win.Ribbon.RibbonSeparator
    Private ribbonComboBox11 As C1.Win.Ribbon.RibbonComboBox
    Private ribbonButton91 As C1.Win.Ribbon.RibbonButton
    Private ribbonButton101 As C1.Win.Ribbon.RibbonButton
    Private ribbonDatePicker11 As C1.Win.Ribbon.RibbonDatePicker
    Private ribbonNumericBox11 As C1.Win.Ribbon.RibbonNumericBox
    Private ribbonTextBox11 As C1.Win.Ribbon.RibbonTextBox
    Private ribbonTimePicker11 As C1.Win.Ribbon.RibbonTimePicker
    Private ribbonSeparator191 As C1.Win.Ribbon.RibbonSeparator
    Private ribbonProgressBar11 As C1.Win.Ribbon.RibbonProgressBar
    Private ribbonTrackBar21 As C1.Win.Ribbon.RibbonTrackBar
    Private c1StatusBar1 As C1.Win.Ribbon.C1StatusBar
    Private ribbonLabel1 As C1.Win.Ribbon.RibbonLabel
    Private ribbonButton1 As C1.Win.Ribbon.RibbonButton
    Private ribbonToggleButton1 As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonToggleButton2 As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonToggleButton3 As C1.Win.Ribbon.RibbonToggleButton
    Private ribbonSeparator1 As C1.Win.Ribbon.RibbonSeparator
    Private ribbonTrackBar1 As C1.Win.Ribbon.RibbonTrackBar
    Private c1NavBar1 As C1.Win.C1Command.C1NavBar
    Private c1NavBarPanel2 As C1.Win.C1Command.C1NavBarPanel
    Private c1NavBarPanel3 As C1.Win.C1Command.C1NavBarPanel
    Private c1NavBarPanel4 As C1.Win.C1Command.C1NavBarPanel
    Private ilMain2 As System.Windows.Forms.ImageList
    Private c1Calendar1 As C1.Win.C1Schedule.C1Calendar
    Private label1 As System.Windows.Forms.Label
    Private label2 As System.Windows.Forms.Label
    Private c1CommandDock1 As C1.Win.C1Command.C1CommandDock
    Private c1DockingTab1 As C1.Win.C1Command.C1DockingTab
    Private c1DockingTabPage1 As C1.Win.C1Command.C1DockingTabPage
    Private c1DockingTabPage2 As C1.Win.C1Command.C1DockingTabPage
    Private cchMain As C1.Win.C1Command.C1CommandHolder
    Private ccCTDBGViewNormal As C1.Win.C1Command.C1Command
    Private ccCTDBGViewInverted As C1.Win.C1Command.C1Command
    Private ccCTDBGViewForm As C1.Win.C1Command.C1Command
    Private ccCTDBGViewGroupBy As C1.Win.C1Command.C1Command
    Private ccCTDBGViewMultipleLines As C1.Win.C1Command.C1Command
    Private ccCTDBGViewHierarchical As C1.Win.C1Command.C1Command
    Private ccCFGViewNormal As C1.Win.C1Command.C1Command
    Private ccCFGViewTree As C1.Win.C1Command.C1Command
    Private ccCFGViewSubtotals As C1.Win.C1Command.C1Command
    Private ccCSViewDay As C1.Win.C1Command.C1Command
    Private ccCSViewWorkWeek As C1.Win.C1Command.C1Command
    Private ccCSViewWeek As C1.Win.C1Command.C1Command
    Private ccCSViewMonth As C1.Win.C1Command.C1Command
    Private ccCSViewTimeLine As C1.Win.C1Command.C1Command
    Private ilMain As System.Windows.Forms.ImageList
    Private WithEvents c1OutBar1 As C1.Win.C1Command.C1OutBar
    Private copC1FlexGrid As C1.Win.C1Command.C1OutPage
    Private copC1TrueDBGrid As C1.Win.C1Command.C1OutPage
    Private copC1Schedule As C1.Win.C1Command.C1OutPage
    Private ctbC1FlexGrid As C1.Win.C1Command.C1ToolBar
    Private c1CommandLink1 As C1.Win.C1Command.C1CommandLink
    Private c1CommandLink2 As C1.Win.C1Command.C1CommandLink
    Private c1CommandLink3 As C1.Win.C1Command.C1CommandLink
    Private panel1 As System.Windows.Forms.Panel
    Private WithEvents ccbShowCursor As C1.Win.C1Input.C1CheckBox
    Private c1Label2 As C1.Win.C1Input.C1Label
    Private WithEvents cneFixedRowCount As C1.Win.C1Input.C1NumericEdit
    Private WithEvents cneFixedColCount As C1.Win.C1Input.C1NumericEdit
    Private c1Label1 As C1.Win.C1Input.C1Label
    Private WithEvents csbFocusRect As C1.Win.C1Input.C1SplitButton
    Private WithEvents csbSelectionMode As C1.Win.C1Input.C1SplitButton
    Private c1Label4 As C1.Win.C1Input.C1Label
    Private c1Label3 As C1.Win.C1Input.C1Label
    Private ctbC1TrueDBGridView As C1.Win.C1Command.C1ToolBar
    Private c1CommandLink4 As C1.Win.C1Command.C1CommandLink
    Private c1CommandLink5 As C1.Win.C1Command.C1CommandLink
    Private c1CommandLink6 As C1.Win.C1Command.C1CommandLink
    Private c1CommandLink7 As C1.Win.C1Command.C1CommandLink
    Private c1CommandLink8 As C1.Win.C1Command.C1CommandLink
    Private c1CommandLink9 As C1.Win.C1Command.C1CommandLink
    Private panel2 As System.Windows.Forms.Panel
    Private WithEvents ccbCTDBGShowFilterBar As C1.Win.C1Input.C1CheckBox
    Private WithEvents ccbCTDBGShowCaption As C1.Win.C1Input.C1CheckBox
    Private WithEvents ctbC1ScheduleView As C1.Win.C1Command.C1ToolBar
    Private c1CommandLink10 As C1.Win.C1Command.C1CommandLink
    Private c1CommandLink11 As C1.Win.C1Command.C1CommandLink
    Private c1CommandLink12 As C1.Win.C1Command.C1CommandLink
    Private c1CommandLink13 As C1.Win.C1Command.C1CommandLink
    Private c1CommandLink14 As C1.Win.C1Command.C1CommandLink
    Private panel3 As System.Windows.Forms.Panel
    Private WithEvents ccbCSOffice2003WeekView As C1.Win.C1Input.C1CheckBox
    Private WithEvents ccbCSEnableGrouping As C1.Win.C1Input.C1CheckBox
    Private WithEvents c1DockingTab2 As C1.Win.C1Command.C1DockingTab
    Private c1DockingTabPage3 As C1.Win.C1Command.C1DockingTabPage
    Private c1DockingTabPage4 As C1.Win.C1Command.C1DockingTabPage
    Private c1DockingTabPage5 As C1.Win.C1Command.C1DockingTabPage
    Private c1DockingTabPage6 As C1.Win.C1Command.C1DockingTabPage
    Private c1FlexGrid1 As C1.Win.C1FlexGrid.C1FlexGrid
    Private csMain As C1.Win.C1Schedule.C1Schedule
    Private c1GanttView1 As C1.Win.C1GanttView.C1GanttView
    Private c1NWINDDataSet As C1NWINDDataSet
    Private employeesBindingSource As System.Windows.Forms.BindingSource
    Private employeesTableAdapter As C1NWINDDataSetTableAdapters.EmployeesTableAdapter
    Private c1TrueDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Private c1NavBarPanel5 As C1.Win.C1Command.C1NavBarPanel
    Private ctbMain As C1.Win.C1Command.C1TopicBar
    Friend WithEvents RibbonBottomToolBar1 As C1.Win.Ribbon.RibbonBottomToolBar
    Friend WithEvents RibbonTopToolBar1 As C1.Win.Ribbon.RibbonTopToolBar
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
End Class

