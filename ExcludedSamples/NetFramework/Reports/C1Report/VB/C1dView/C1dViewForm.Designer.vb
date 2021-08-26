<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class C1dViewForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(C1dViewForm))
        Me.rbMain = New C1.Win.C1Ribbon.C1Ribbon()
        Me.ramMain = New C1.Win.C1Ribbon.RibbonApplicationMenu()
        Me.rbtnExit = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbtnOpen2 = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbtnSave2 = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbtnPrint2 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonSeparator5 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.rbtnPageSetup2 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonSeparator6 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.rbtnNew2 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonSeparator7 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.rbtnClose2 = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonListItem1 = New C1.Win.C1Ribbon.RibbonListItem()
        Me.RibbonLabel1 = New C1.Win.C1Ribbon.RibbonLabel()
        Me.RibbonListItem2 = New C1.Win.C1Ribbon.RibbonListItem()
        Me.RibbonSeparator8 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.RibbonConfigToolBar1 = New C1.Win.C1Ribbon.RibbonConfigToolBar()
        Me.rmenuHelp = New C1.Win.C1Ribbon.RibbonMenu()
        Me.rbtnAbout = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonQat1 = New C1.Win.C1Ribbon.RibbonQat()
        Me.rtPreview = New C1.Win.C1Ribbon.RibbonTab()
        Me.rgFile = New C1.Win.C1Ribbon.RibbonGroup()
        Me.rbtnOpen = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbtnSave = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbtnPrint = New C1.Win.C1Ribbon.RibbonButton()
        Me.rgPage = New C1.Win.C1Ribbon.RibbonGroup()
        Me.rbtnPageSetup = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbtnPagePortrait = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.rbtnPageLandscape = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.rbtnRefresh = New C1.Win.C1Ribbon.RibbonButton()
        Me.rgZoom = New C1.Win.C1Ribbon.RibbonGroup()
        Me.rbtnZoom100 = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.RibbonSeparator1 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.rbtnZoomFitPage = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.rbtnZoomFitWidth = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.rgNavigation = New C1.Win.C1Ribbon.RibbonGroup()
        Me.RibbonToolBar1 = New C1.Win.C1Ribbon.RibbonToolBar()
        Me.rbtnFirstPage = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbtnPreviousPage = New C1.Win.C1Ribbon.RibbonButton()
        Me.rebPageNo = New C1.Win.C1Ribbon.RibbonTextBox()
        Me.rlblPageCount = New C1.Win.C1Ribbon.RibbonLabel()
        Me.rbtnNextPage = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbtnLastPage = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonToolBar2 = New C1.Win.C1Ribbon.RibbonToolBar()
        Me.rbtnHistoryBack = New C1.Win.C1Ribbon.RibbonSplitButton()
        Me.RibbonSeparator2 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.rbtnHistoryNext = New C1.Win.C1Ribbon.RibbonSplitButton()
        Me.rgTools = New C1.Win.C1Ribbon.RibbonGroup()
        Me.rbtnHandTool = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.rbtnFind = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbtnFindAgain = New C1.Win.C1Ribbon.RibbonButton()
        Me.RibbonSeparator3 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.rbtnTextSelectTool = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.rbtnZoomInTool = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.rbtnZoomOutTool = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.cdLeft = New C1.Win.C1Command.C1CommandDock()
        Me.dtMain = New C1.Win.C1Command.C1DockingTab()
        Me.dtpPages = New C1.Win.C1Command.C1DockingTabPage()
        Me.ptvMain = New C1.Win.C1Preview.C1PreviewThumbnailView()
        Me._pview = New C1.Win.C1Preview.C1PreviewPane()
        Me.dtpOutline = New C1.Win.C1Command.C1DockingTabPage()
        Me.povMain = New C1.Win.C1Preview.C1PreviewOutlineView()
        Me.dtpSearch = New C1.Win.C1Command.C1DockingTabPage()
        Me.ptspMain = New C1.Win.C1Preview.C1PreviewTextSearchPanel()
        Me.sbMain = New C1.Win.C1Ribbon.C1StatusBar()
        Me.rbtnFindClose = New C1.Win.C1Ribbon.RibbonButton()
        Me.rtbFindText = New C1.Win.C1Ribbon.RibbonTextBox()
        Me.rbtnFindNext = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbtnFindPrev = New C1.Win.C1Ribbon.RibbonButton()
        Me.rbtnFindMatchCase = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.rlblStatusText = New C1.Win.C1Ribbon.RibbonLabel()
        Me.rbnProgress = New C1.Win.C1Ribbon.RibbonProgressBar()
        Me.rtgViewMode = New C1.Win.C1Ribbon.RibbonToggleGroup()
        Me.rbtnViewSinglePage = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.rbtnViewContinuous = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.rbtnViewPagesFacing = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.rbtnViewPagesFacingContinuous = New C1.Win.C1Ribbon.RibbonToggleButton()
        Me.RibbonSeparator4 = New C1.Win.C1Ribbon.RibbonSeparator()
        Me.rbtnZoom = New C1.Win.C1Ribbon.RibbonButton()
        Me.rtbZoom = New C1.Win.C1Ribbon.RibbonTrackBar()
        Me._cmdHolder = New C1.Win.C1Command.C1CommandHolder()
        Me.cmdFileOpen = New C1.Win.C1Command.C1Command()
        Me.cmdFileSave = New C1.Win.C1Command.C1Command()
        Me.cmdFileClose = New C1.Win.C1Command.C1Command()
        Me.cmdFileNew = New C1.Win.C1Command.C1Command()
        Me.cmdExit = New C1.Win.C1Command.C1Command()
        Me.cmdPrint = New C1.Win.C1Command.C1Command()
        Me.cmdRefresh = New C1.Win.C1Command.C1Command()
        Me.cmdPageSetup = New C1.Win.C1Command.C1Command()
        Me.cmdPageLandscape = New C1.Win.C1Command.C1Command()
        Me.cmdPagePortrait = New C1.Win.C1Command.C1Command()
        Me.cmdZoomFitPage = New C1.Win.C1Command.C1Command()
        Me.cmdZoomFitWidth = New C1.Win.C1Command.C1Command()
        Me.cmdZoom100 = New C1.Win.C1Command.C1Command()
        Me.cmdView = New C1.Win.C1Command.C1Command()
        Me.cmdGoPageNo = New C1.Win.C1Command.C1Command()
        Me.cmdGoFirst = New C1.Win.C1Command.C1Command()
        Me.cmdGoLast = New C1.Win.C1Command.C1Command()
        Me.cmdGoPrev = New C1.Win.C1Command.C1Command()
        Me.cmdGoNext = New C1.Win.C1Command.C1Command()
        Me.cmdHistoryPrev = New C1.Win.C1Command.C1Command()
        Me.cmdHistoryNext = New C1.Win.C1Command.C1Command()
        Me.cmdMouseModeHand = New C1.Win.C1Command.C1Command()
        Me.cmdMouseModeSelect = New C1.Win.C1Command.C1Command()
        Me.cmdMouseModeZoomIn = New C1.Win.C1Command.C1Command()
        Me.cmdMouseModeZoomOut = New C1.Win.C1Command.C1Command()
        Me.cmdPageViewSingle = New C1.Win.C1Command.C1Command()
        Me.cmdPageViewContinuous = New C1.Win.C1Command.C1Command()
        Me.cmdPageViewTwoUp = New C1.Win.C1Command.C1Command()
        Me.cmdPageViewTwoUpContinuous = New C1.Win.C1Command.C1Command()
        Me.cmdFind = New C1.Win.C1Command.C1Command()
        Me.cmdFindNext = New C1.Win.C1Command.C1Command()
        Me.cmdZoomIn = New C1.Win.C1Command.C1Command()
        Me.cmdZoomOut = New C1.Win.C1Command.C1Command()
        Me.cmdZoomDialog = New C1.Win.C1Command.C1Command()
        Me.cmdHelp = New C1.Win.C1Command.C1Command()
        Me.cmdAbout = New C1.Win.C1Command.C1Command()
        CType(Me.rbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cdLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cdLeft.SuspendLayout()
        CType(Me.dtMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dtMain.SuspendLayout()
        Me.dtpPages.SuspendLayout()
        CType(Me._pview, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.dtpOutline.SuspendLayout()
        Me.dtpSearch.SuspendLayout()
        CType(Me.sbMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._cmdHolder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbMain
        '
        Me.rbMain.ApplicationMenuHolder = Me.ramMain
        Me.rbMain.ConfigToolBarHolder = Me.RibbonConfigToolBar1
        Me.rbMain.Location = New System.Drawing.Point(0, 0)
        Me.rbMain.Name = "rbMain"
        Me.rbMain.QatHolder = Me.RibbonQat1
        Me.rbMain.Size = New System.Drawing.Size(904, 153)
        Me.rbMain.Tabs.Add(Me.rtPreview)
        Me.rbMain.VisualStyle = C1.Win.C1Ribbon.VisualStyle.Office2010Blue
        '
        'ramMain
        '
        Me.ramMain.BottomPaneItems.Add(Me.rbtnExit)
        Me.ramMain.LeftPaneItems.Add(Me.rbtnOpen2)
        Me.ramMain.LeftPaneItems.Add(Me.rbtnSave2)
        Me.ramMain.LeftPaneItems.Add(Me.rbtnPrint2)
        Me.ramMain.LeftPaneItems.Add(Me.RibbonSeparator5)
        Me.ramMain.LeftPaneItems.Add(Me.rbtnPageSetup2)
        Me.ramMain.LeftPaneItems.Add(Me.RibbonSeparator6)
        Me.ramMain.LeftPaneItems.Add(Me.rbtnNew2)
        Me.ramMain.LeftPaneItems.Add(Me.RibbonSeparator7)
        Me.ramMain.LeftPaneItems.Add(Me.rbtnClose2)
        Me.ramMain.Name = "ramMain"
        Me.ramMain.RightPaneItems.Add(Me.RibbonListItem1)
        Me.ramMain.RightPaneItems.Add(Me.RibbonListItem2)
        '
        'rbtnExit
        '
        Me.rbtnExit.Name = "rbtnExit"
        Me.rbtnExit.Text = "E&xit"
        Me.rbtnExit.ToolTip = "Exit"
        '
        'rbtnOpen2
        '
        Me.rbtnOpen2.LargeImage = CType(resources.GetObject("rbtnOpen2.LargeImage"), System.Drawing.Image)
        Me.rbtnOpen2.Name = "rbtnOpen2"
        Me.rbtnOpen2.SmallImage = CType(resources.GetObject("rbtnOpen2.SmallImage"), System.Drawing.Image)
        Me.rbtnOpen2.Text = "&Open"
        Me.rbtnOpen2.ToolTip = resources.GetString("rbtnOpen2.ToolTip")
        '
        'rbtnSave2
        '
        Me.rbtnSave2.LargeImage = CType(resources.GetObject("rbtnSave2.LargeImage"), System.Drawing.Image)
        Me.rbtnSave2.Name = "rbtnSave2"
        Me.rbtnSave2.SmallImage = CType(resources.GetObject("rbtnSave2.SmallImage"), System.Drawing.Image)
        Me.rbtnSave2.Text = "&Save"
        Me.rbtnSave2.ToolTip = resources.GetString("rbtnSave2.ToolTip")
        '
        'rbtnPrint2
        '
        Me.rbtnPrint2.LargeImage = CType(resources.GetObject("rbtnPrint2.LargeImage"), System.Drawing.Image)
        Me.rbtnPrint2.Name = "rbtnPrint2"
        Me.rbtnPrint2.SmallImage = CType(resources.GetObject("rbtnPrint2.SmallImage"), System.Drawing.Image)
        Me.rbtnPrint2.Text = "Print"
        Me.rbtnPrint2.ToolTip = resources.GetString("rbtnPrint2.ToolTip")
        '
        'RibbonSeparator5
        '
        Me.RibbonSeparator5.Name = "RibbonSeparator5"
        '
        'rbtnPageSetup2
        '
        Me.rbtnPageSetup2.LargeImage = CType(resources.GetObject("rbtnPageSetup2.LargeImage"), System.Drawing.Image)
        Me.rbtnPageSetup2.Name = "rbtnPageSetup2"
        Me.rbtnPageSetup2.SmallImage = CType(resources.GetObject("rbtnPageSetup2.SmallImage"), System.Drawing.Image)
        Me.rbtnPageSetup2.Text = "Page &Setup"
        Me.rbtnPageSetup2.ToolTip = resources.GetString("rbtnPageSetup2.ToolTip")
        '
        'RibbonSeparator6
        '
        Me.RibbonSeparator6.Name = "RibbonSeparator6"
        '
        'rbtnNew2
        '
        Me.rbtnNew2.LargeImage = CType(resources.GetObject("rbtnNew2.LargeImage"), System.Drawing.Image)
        Me.rbtnNew2.Name = "rbtnNew2"
        Me.rbtnNew2.Text = "&New Window"
        Me.rbtnNew2.ToolTip = resources.GetString("rbtnNew2.ToolTip")
        '
        'RibbonSeparator7
        '
        Me.RibbonSeparator7.Name = "RibbonSeparator7"
        '
        'rbtnClose2
        '
        Me.rbtnClose2.LargeImage = CType(resources.GetObject("rbtnClose2.LargeImage"), System.Drawing.Image)
        Me.rbtnClose2.Name = "rbtnClose2"
        Me.rbtnClose2.Text = "&Close"
        Me.rbtnClose2.ToolTip = resources.GetString("rbtnClose2.ToolTip")
        '
        'RibbonListItem1
        '
        Me.RibbonListItem1.AllowSelection = False
        Me.RibbonListItem1.Items.Add(Me.RibbonLabel1)
        Me.RibbonListItem1.Name = "RibbonListItem1"
        '
        'RibbonLabel1
        '
        Me.RibbonLabel1.Name = "RibbonLabel1"
        Me.RibbonLabel1.SmallImage = CType(resources.GetObject("RibbonLabel1.SmallImage"), System.Drawing.Image)
        Me.RibbonLabel1.Text = "Recent Documents"
        '
        'RibbonListItem2
        '
        Me.RibbonListItem2.AllowSelection = False
        Me.RibbonListItem2.Items.Add(Me.RibbonSeparator8)
        Me.RibbonListItem2.Name = "RibbonListItem2"
        '
        'RibbonSeparator8
        '
        Me.RibbonSeparator8.Name = "RibbonSeparator8"
        '
        'RibbonConfigToolBar1
        '
        Me.RibbonConfigToolBar1.Items.Add(Me.rmenuHelp)
        Me.RibbonConfigToolBar1.Name = "RibbonConfigToolBar1"
        '
        'rmenuHelp
        '
        Me.rmenuHelp.Items.Add(Me.rbtnAbout)
        Me.rmenuHelp.Name = "rmenuHelp"
        Me.rmenuHelp.SmallImage = CType(resources.GetObject("rmenuHelp.SmallImage"), System.Drawing.Image)
        '
        'rbtnAbout
        '
        Me.rbtnAbout.Name = "rbtnAbout"
        Me.rbtnAbout.Text = "About..."
        '
        'RibbonQat1
        '
        Me.RibbonQat1.Name = "RibbonQat1"
        '
        'rtPreview
        '
        Me.rtPreview.Groups.Add(Me.rgFile)
        Me.rtPreview.Groups.Add(Me.rgPage)
        Me.rtPreview.Groups.Add(Me.rgZoom)
        Me.rtPreview.Groups.Add(Me.rgNavigation)
        Me.rtPreview.Groups.Add(Me.rgTools)
        Me.rtPreview.Name = "rtPreview"
        Me.rtPreview.Text = "View"
        '
        'rgFile
        '
        Me.rgFile.Items.Add(Me.rbtnOpen)
        Me.rgFile.Items.Add(Me.rbtnSave)
        Me.rgFile.Items.Add(Me.rbtnPrint)
        Me.rgFile.Name = "rgFile"
        Me.rgFile.Text = "File"
        '
        'rbtnOpen
        '
        Me.rbtnOpen.LargeImage = CType(resources.GetObject("rbtnOpen.LargeImage"), System.Drawing.Image)
        Me.rbtnOpen.Name = "rbtnOpen"
        Me.rbtnOpen.SmallImage = CType(resources.GetObject("rbtnOpen.SmallImage"), System.Drawing.Image)
        Me.rbtnOpen.Text = "Open"
        Me.rbtnOpen.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText
        Me.rbtnOpen.ToolTip = resources.GetString("rbtnOpen.ToolTip")
        '
        'rbtnSave
        '
        Me.rbtnSave.LargeImage = CType(resources.GetObject("rbtnSave.LargeImage"), System.Drawing.Image)
        Me.rbtnSave.Name = "rbtnSave"
        Me.rbtnSave.SmallImage = CType(resources.GetObject("rbtnSave.SmallImage"), System.Drawing.Image)
        Me.rbtnSave.Text = "Save"
        Me.rbtnSave.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText
        Me.rbtnSave.ToolTip = resources.GetString("rbtnSave.ToolTip")
        '
        'rbtnPrint
        '
        Me.rbtnPrint.LargeImage = CType(resources.GetObject("rbtnPrint.LargeImage"), System.Drawing.Image)
        Me.rbtnPrint.Name = "rbtnPrint"
        Me.rbtnPrint.SmallImage = CType(resources.GetObject("rbtnPrint.SmallImage"), System.Drawing.Image)
        Me.rbtnPrint.Text = "Print"
        Me.rbtnPrint.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText
        Me.rbtnPrint.ToolTip = resources.GetString("rbtnPrint.ToolTip")
        '
        'rgPage
        '
        Me.rgPage.Items.Add(Me.rbtnPageSetup)
        Me.rgPage.Items.Add(Me.rbtnPagePortrait)
        Me.rgPage.Items.Add(Me.rbtnPageLandscape)
        Me.rgPage.Items.Add(Me.rbtnRefresh)
        Me.rgPage.Name = "rgPage"
        Me.rgPage.Text = "Page"
        '
        'rbtnPageSetup
        '
        Me.rbtnPageSetup.LargeImage = CType(resources.GetObject("rbtnPageSetup.LargeImage"), System.Drawing.Image)
        Me.rbtnPageSetup.Name = "rbtnPageSetup"
        Me.rbtnPageSetup.SmallImage = CType(resources.GetObject("rbtnPageSetup.SmallImage"), System.Drawing.Image)
        Me.rbtnPageSetup.Text = "Page Setup"
        Me.rbtnPageSetup.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText
        Me.rbtnPageSetup.ToolTip = resources.GetString("rbtnPageSetup.ToolTip")
        '
        'rbtnPagePortrait
        '
        Me.rbtnPagePortrait.Name = "rbtnPagePortrait"
        Me.rbtnPagePortrait.SmallImage = CType(resources.GetObject("rbtnPagePortrait.SmallImage"), System.Drawing.Image)
        Me.rbtnPagePortrait.Text = "Portrait"
        '
        'rbtnPageLandscape
        '
        Me.rbtnPageLandscape.Name = "rbtnPageLandscape"
        Me.rbtnPageLandscape.SmallImage = CType(resources.GetObject("rbtnPageLandscape.SmallImage"), System.Drawing.Image)
        Me.rbtnPageLandscape.Text = "Landscape"
        '
        'rbtnRefresh
        '
        Me.rbtnRefresh.Name = "rbtnRefresh"
        Me.rbtnRefresh.SmallImage = CType(resources.GetObject("rbtnRefresh.SmallImage"), System.Drawing.Image)
        Me.rbtnRefresh.Text = "Refresh"
        '
        'rgZoom
        '
        Me.rgZoom.HasLauncherButton = True
        Me.rgZoom.Items.Add(Me.rbtnZoom100)
        Me.rgZoom.Items.Add(Me.RibbonSeparator1)
        Me.rgZoom.Items.Add(Me.rbtnZoomFitPage)
        Me.rgZoom.Items.Add(Me.rbtnZoomFitWidth)
        Me.rgZoom.LauncherToolTip = resources.GetString("rgZoom.LauncherToolTip")
        Me.rgZoom.Name = "rgZoom"
        Me.rgZoom.Text = "Zoom"
        '
        'rbtnZoom100
        '
        Me.rbtnZoom100.CanDepress = False
        Me.rbtnZoom100.LargeImage = CType(resources.GetObject("rbtnZoom100.LargeImage"), System.Drawing.Image)
        Me.rbtnZoom100.Name = "rbtnZoom100"
        Me.rbtnZoom100.SmallImage = CType(resources.GetObject("rbtnZoom100.SmallImage"), System.Drawing.Image)
        Me.rbtnZoom100.Text = "100%"
        Me.rbtnZoom100.TextImageRelation = C1.Win.C1Ribbon.TextImageRelation.ImageAboveText
        Me.rbtnZoom100.ToolTip = resources.GetString("rbtnZoom100.ToolTip")
        '
        'RibbonSeparator1
        '
        Me.RibbonSeparator1.Name = "RibbonSeparator1"
        '
        'rbtnZoomFitPage
        '
        Me.rbtnZoomFitPage.CanDepress = False
        Me.rbtnZoomFitPage.Name = "rbtnZoomFitPage"
        Me.rbtnZoomFitPage.SmallImage = CType(resources.GetObject("rbtnZoomFitPage.SmallImage"), System.Drawing.Image)
        Me.rbtnZoomFitPage.Text = "Fit Window"
        Me.rbtnZoomFitPage.ToolTip = resources.GetString("rbtnZoomFitPage.ToolTip")
        '
        'rbtnZoomFitWidth
        '
        Me.rbtnZoomFitWidth.CanDepress = False
        Me.rbtnZoomFitWidth.Name = "rbtnZoomFitWidth"
        Me.rbtnZoomFitWidth.SmallImage = CType(resources.GetObject("rbtnZoomFitWidth.SmallImage"), System.Drawing.Image)
        Me.rbtnZoomFitWidth.Text = "Fit Width"
        Me.rbtnZoomFitWidth.ToolTip = resources.GetString("rbtnZoomFitWidth.ToolTip")
        '
        'rgNavigation
        '
        Me.rgNavigation.Items.Add(Me.RibbonToolBar1)
        Me.rgNavigation.Items.Add(Me.RibbonToolBar2)
        Me.rgNavigation.Name = "rgNavigation"
        Me.rgNavigation.Text = "Navigation"
        '
        'RibbonToolBar1
        '
        Me.RibbonToolBar1.Items.Add(Me.rbtnFirstPage)
        Me.RibbonToolBar1.Items.Add(Me.rbtnPreviousPage)
        Me.RibbonToolBar1.Items.Add(Me.rebPageNo)
        Me.RibbonToolBar1.Items.Add(Me.rlblPageCount)
        Me.RibbonToolBar1.Items.Add(Me.rbtnNextPage)
        Me.RibbonToolBar1.Items.Add(Me.rbtnLastPage)
        Me.RibbonToolBar1.Name = "RibbonToolBar1"
        '
        'rbtnFirstPage
        '
        Me.rbtnFirstPage.Name = "rbtnFirstPage"
        Me.rbtnFirstPage.SmallImage = CType(resources.GetObject("rbtnFirstPage.SmallImage"), System.Drawing.Image)
        Me.rbtnFirstPage.ToolTip = "Go to the first page of the document."
        '
        'rbtnPreviousPage
        '
        Me.rbtnPreviousPage.Name = "rbtnPreviousPage"
        Me.rbtnPreviousPage.SmallImage = CType(resources.GetObject("rbtnPreviousPage.SmallImage"), System.Drawing.Image)
        Me.rbtnPreviousPage.ToolTip = "Go to the previous page of the document."
        '
        'rebPageNo
        '
        Me.rebPageNo.Label = "Page"
        Me.rebPageNo.Name = "rebPageNo"
        Me.rebPageNo.TextAreaWidth = 40
        Me.rebPageNo.ToolTip = "The current page number."
        '
        'rlblPageCount
        '
        Me.rlblPageCount.Name = "rlblPageCount"
        Me.rlblPageCount.Text = "of 100000"
        Me.rlblPageCount.ToolTip = "Number of pages in the current document."
        '
        'rbtnNextPage
        '
        Me.rbtnNextPage.Name = "rbtnNextPage"
        Me.rbtnNextPage.SmallImage = CType(resources.GetObject("rbtnNextPage.SmallImage"), System.Drawing.Image)
        Me.rbtnNextPage.ToolTip = "Go to the next page of the document."
        '
        'rbtnLastPage
        '
        Me.rbtnLastPage.Name = "rbtnLastPage"
        Me.rbtnLastPage.SmallImage = CType(resources.GetObject("rbtnLastPage.SmallImage"), System.Drawing.Image)
        Me.rbtnLastPage.ToolTip = "Go to the last page of the document."
        '
        'RibbonToolBar2
        '
        Me.RibbonToolBar2.Items.Add(Me.rbtnHistoryBack)
        Me.RibbonToolBar2.Items.Add(Me.RibbonSeparator2)
        Me.RibbonToolBar2.Items.Add(Me.rbtnHistoryNext)
        Me.RibbonToolBar2.Name = "RibbonToolBar2"
        '
        'rbtnHistoryBack
        '
        Me.rbtnHistoryBack.Name = "rbtnHistoryBack"
        Me.rbtnHistoryBack.SmallImage = CType(resources.GetObject("rbtnHistoryBack.SmallImage"), System.Drawing.Image)
        Me.rbtnHistoryBack.Text = "Previous View"
        Me.rbtnHistoryBack.ToolTip = "Previous view in history."
        '
        'RibbonSeparator2
        '
        Me.RibbonSeparator2.Name = "RibbonSeparator2"
        '
        'rbtnHistoryNext
        '
        Me.rbtnHistoryNext.Name = "rbtnHistoryNext"
        Me.rbtnHistoryNext.SmallImage = CType(resources.GetObject("rbtnHistoryNext.SmallImage"), System.Drawing.Image)
        Me.rbtnHistoryNext.Text = "Next View"
        Me.rbtnHistoryNext.ToolTip = "Next view in history."
        '
        'rgTools
        '
        Me.rgTools.Items.Add(Me.rbtnHandTool)
        Me.rgTools.Items.Add(Me.rbtnFind)
        Me.rgTools.Items.Add(Me.rbtnFindAgain)
        Me.rgTools.Items.Add(Me.RibbonSeparator3)
        Me.rgTools.Items.Add(Me.rbtnTextSelectTool)
        Me.rgTools.Items.Add(Me.rbtnZoomInTool)
        Me.rgTools.Items.Add(Me.rbtnZoomOutTool)
        Me.rgTools.Name = "rgTools"
        Me.rgTools.Text = "Tools"
        '
        'rbtnHandTool
        '
        Me.rbtnHandTool.CanDepress = False
        Me.rbtnHandTool.Name = "rbtnHandTool"
        Me.rbtnHandTool.SmallImage = CType(resources.GetObject("rbtnHandTool.SmallImage"), System.Drawing.Image)
        Me.rbtnHandTool.Text = "Hand Tool"
        Me.rbtnHandTool.ToolTip = resources.GetString("rbtnHandTool.ToolTip")
        '
        'rbtnFind
        '
        Me.rbtnFind.Name = "rbtnFind"
        Me.rbtnFind.SmallImage = CType(resources.GetObject("rbtnFind.SmallImage"), System.Drawing.Image)
        Me.rbtnFind.Text = "Find"
        Me.rbtnFind.ToolTip = resources.GetString("rbtnFind.ToolTip")
        '
        'rbtnFindAgain
        '
        Me.rbtnFindAgain.Name = "rbtnFindAgain"
        Me.rbtnFindAgain.SmallImage = CType(resources.GetObject("rbtnFindAgain.SmallImage"), System.Drawing.Image)
        Me.rbtnFindAgain.Text = "Find Next"
        Me.rbtnFindAgain.ToolTip = resources.GetString("rbtnFindAgain.ToolTip")
        '
        'RibbonSeparator3
        '
        Me.RibbonSeparator3.Name = "RibbonSeparator3"
        '
        'rbtnTextSelectTool
        '
        Me.rbtnTextSelectTool.CanDepress = False
        Me.rbtnTextSelectTool.Name = "rbtnTextSelectTool"
        Me.rbtnTextSelectTool.SmallImage = CType(resources.GetObject("rbtnTextSelectTool.SmallImage"), System.Drawing.Image)
        Me.rbtnTextSelectTool.Text = "Text Select Tool"
        Me.rbtnTextSelectTool.ToolTip = resources.GetString("rbtnTextSelectTool.ToolTip")
        '
        'rbtnZoomInTool
        '
        Me.rbtnZoomInTool.CanDepress = False
        Me.rbtnZoomInTool.Name = "rbtnZoomInTool"
        Me.rbtnZoomInTool.SmallImage = CType(resources.GetObject("rbtnZoomInTool.SmallImage"), System.Drawing.Image)
        Me.rbtnZoomInTool.Text = "Zoom In Tool"
        Me.rbtnZoomInTool.ToolTip = resources.GetString("rbtnZoomInTool.ToolTip")
        '
        'rbtnZoomOutTool
        '
        Me.rbtnZoomOutTool.CanDepress = False
        Me.rbtnZoomOutTool.Name = "rbtnZoomOutTool"
        Me.rbtnZoomOutTool.SmallImage = CType(resources.GetObject("rbtnZoomOutTool.SmallImage"), System.Drawing.Image)
        Me.rbtnZoomOutTool.Text = "Zoom Out Tool"
        Me.rbtnZoomOutTool.ToolTip = resources.GetString("rbtnZoomOutTool.ToolTip")
        '
        'cdLeft
        '
        Me.cdLeft.Controls.Add(Me.dtMain)
        Me.cdLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.cdLeft.Id = 1
        Me.cdLeft.Location = New System.Drawing.Point(0, 153)
        Me.cdLeft.Name = "cdLeft"
        Me.cdLeft.Size = New System.Drawing.Size(186, 505)
        '
        'dtMain
        '
        Me.dtMain.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.dtMain.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtMain.CanAutoHide = True
        Me.dtMain.Controls.Add(Me.dtpPages)
        Me.dtMain.Controls.Add(Me.dtpOutline)
        Me.dtMain.Controls.Add(Me.dtpSearch)
        Me.dtMain.Location = New System.Drawing.Point(0, 0)
        Me.dtMain.Name = "dtMain"
        Me.dtMain.ShowCaption = True
        Me.dtMain.Size = New System.Drawing.Size(186, 505)
        Me.dtMain.TabIndex = 0
        Me.dtMain.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit
        Me.dtMain.TabsSpacing = 5
        Me.dtMain.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2010
        Me.dtMain.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue
        Me.dtMain.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue
        '
        'dtpPages
        '
        Me.dtpPages.CaptionVisible = True
        Me.dtpPages.Controls.Add(Me.ptvMain)
        Me.dtpPages.Location = New System.Drawing.Point(0, 0)
        Me.dtpPages.Name = "dtpPages"
        Me.dtpPages.Size = New System.Drawing.Size(183, 481)
        Me.dtpPages.TabIndex = 1
        Me.dtpPages.Text = "Pages"
        '
        'ptvMain
        '
        Me.ptvMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ptvMain.Location = New System.Drawing.Point(0, 20)
        Me.ptvMain.Name = "ptvMain"
        Me.ptvMain.PreviewPane = Me._pview
        Me.ptvMain.Size = New System.Drawing.Size(183, 461)
        Me.ptvMain.TabIndex = 0
        Me.ptvMain.UseImageAsThumbnail = False
        '
        '_pview
        '
        Me._pview.Dock = System.Windows.Forms.DockStyle.Fill
        Me._pview.Location = New System.Drawing.Point(186, 153)
        Me._pview.Name = "_pview"
        Me._pview.Size = New System.Drawing.Size(718, 505)
        Me._pview.TabIndex = 3
        '
        'dtpOutline
        '
        Me.dtpOutline.CaptionVisible = True
        Me.dtpOutline.Controls.Add(Me.povMain)
        Me.dtpOutline.Location = New System.Drawing.Point(0, 0)
        Me.dtpOutline.Name = "dtpOutline"
        Me.dtpOutline.Size = New System.Drawing.Size(183, 481)
        Me.dtpOutline.TabIndex = 1
        Me.dtpOutline.Text = "Outline"
        '
        'povMain
        '
        Me.povMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.povMain.Location = New System.Drawing.Point(0, 20)
        Me.povMain.Name = "povMain"
        Me.povMain.PreviewPane = Me._pview
        Me.povMain.Size = New System.Drawing.Size(183, 461)
        Me.povMain.TabIndex = 0
        '
        'dtpSearch
        '
        Me.dtpSearch.CaptionVisible = True
        Me.dtpSearch.Controls.Add(Me.ptspMain)
        Me.dtpSearch.Location = New System.Drawing.Point(0, 0)
        Me.dtpSearch.Name = "dtpSearch"
        Me.dtpSearch.Size = New System.Drawing.Size(183, 481)
        Me.dtpSearch.TabIndex = 2
        Me.dtpSearch.Text = "Search"
        '
        'ptspMain
        '
        Me.ptspMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ptspMain.Location = New System.Drawing.Point(0, 20)
        Me.ptspMain.MinimumSize = New System.Drawing.Size(200, 240)
        Me.ptspMain.Name = "ptspMain"
        Me.ptspMain.PreviewPane = Me._pview
        Me.ptspMain.Size = New System.Drawing.Size(200, 461)
        Me.ptspMain.TabIndex = 0
        '
        'sbMain
        '
        Me.sbMain.LeftPaneItems.Add(Me.rbtnFindClose)
        Me.sbMain.LeftPaneItems.Add(Me.rtbFindText)
        Me.sbMain.LeftPaneItems.Add(Me.rbtnFindNext)
        Me.sbMain.LeftPaneItems.Add(Me.rbtnFindPrev)
        Me.sbMain.LeftPaneItems.Add(Me.rbtnFindMatchCase)
        Me.sbMain.LeftPaneItems.Add(Me.rlblStatusText)
        Me.sbMain.Location = New System.Drawing.Point(0, 658)
        Me.sbMain.Name = "sbMain"
        Me.sbMain.RightPaneItems.Add(Me.rbnProgress)
        Me.sbMain.RightPaneItems.Add(Me.rtgViewMode)
        Me.sbMain.RightPaneItems.Add(Me.RibbonSeparator4)
        Me.sbMain.RightPaneItems.Add(Me.rbtnZoom)
        Me.sbMain.RightPaneItems.Add(Me.rtbZoom)
        Me.sbMain.Size = New System.Drawing.Size(904, 22)
        '
        'rbtnFindClose
        '
        Me.rbtnFindClose.Name = "rbtnFindClose"
        Me.rbtnFindClose.SmallImage = CType(resources.GetObject("rbtnFindClose.SmallImage"), System.Drawing.Image)
        Me.rbtnFindClose.ToolTip = "Close the text search bar."
        '
        'rtbFindText
        '
        Me.rtbFindText.Label = "Find:"
        Me.rtbFindText.Name = "rtbFindText"
        Me.rtbFindText.TextAreaWidth = 96
        '
        'rbtnFindNext
        '
        Me.rbtnFindNext.Name = "rbtnFindNext"
        Me.rbtnFindNext.SmallImage = CType(resources.GetObject("rbtnFindNext.SmallImage"), System.Drawing.Image)
        Me.rbtnFindNext.Text = "Next"
        '
        'rbtnFindPrev
        '
        Me.rbtnFindPrev.Name = "rbtnFindPrev"
        Me.rbtnFindPrev.SmallImage = CType(resources.GetObject("rbtnFindPrev.SmallImage"), System.Drawing.Image)
        Me.rbtnFindPrev.Text = "Previous"
        '
        'rbtnFindMatchCase
        '
        Me.rbtnFindMatchCase.Name = "rbtnFindMatchCase"
        Me.rbtnFindMatchCase.SmallImage = CType(resources.GetObject("rbtnFindMatchCase.SmallImage"), System.Drawing.Image)
        Me.rbtnFindMatchCase.Text = "Match case"
        '
        'rlblStatusText
        '
        Me.rlblStatusText.Name = "rlblStatusText"
        Me.rlblStatusText.Text = "Ready"
        '
        'rbnProgress
        '
        Me.rbnProgress.Name = "rbnProgress"
        '
        'rtgViewMode
        '
        Me.rtgViewMode.Items.Add(Me.rbtnViewSinglePage)
        Me.rtgViewMode.Items.Add(Me.rbtnViewContinuous)
        Me.rtgViewMode.Items.Add(Me.rbtnViewPagesFacing)
        Me.rtgViewMode.Items.Add(Me.rbtnViewPagesFacingContinuous)
        Me.rtgViewMode.Name = "rtgViewMode"
        '
        'rbtnViewSinglePage
        '
        Me.rbtnViewSinglePage.Name = "rbtnViewSinglePage"
        Me.rbtnViewSinglePage.SmallImage = CType(resources.GetObject("rbtnViewSinglePage.SmallImage"), System.Drawing.Image)
        Me.rbtnViewSinglePage.ToolTip = "Single Page View"
        '
        'rbtnViewContinuous
        '
        Me.rbtnViewContinuous.Name = "rbtnViewContinuous"
        Me.rbtnViewContinuous.SmallImage = CType(resources.GetObject("rbtnViewContinuous.SmallImage"), System.Drawing.Image)
        Me.rbtnViewContinuous.ToolTip = "Continuous View"
        '
        'rbtnViewPagesFacing
        '
        Me.rbtnViewPagesFacing.Name = "rbtnViewPagesFacing"
        Me.rbtnViewPagesFacing.SmallImage = CType(resources.GetObject("rbtnViewPagesFacing.SmallImage"), System.Drawing.Image)
        Me.rbtnViewPagesFacing.ToolTip = "Pages Facing View"
        '
        'rbtnViewPagesFacingContinuous
        '
        Me.rbtnViewPagesFacingContinuous.Name = "rbtnViewPagesFacingContinuous"
        Me.rbtnViewPagesFacingContinuous.SmallImage = CType(resources.GetObject("rbtnViewPagesFacingContinuous.SmallImage"), System.Drawing.Image)
        Me.rbtnViewPagesFacingContinuous.ToolTip = "Pages Facing Continuous View"
        '
        'RibbonSeparator4
        '
        Me.RibbonSeparator4.Name = "RibbonSeparator4"
        '
        'rbtnZoom
        '
        Me.rbtnZoom.Name = "rbtnZoom"
        Me.rbtnZoom.Text = "100%"
        Me.rbtnZoom.ToolTip = resources.GetString("rbtnZoom.ToolTip")
        '
        'rtbZoom
        '
        Me.rtbZoom.Maximum = 1000
        Me.rtbZoom.Minimum = 10
        Me.rtbZoom.Name = "rtbZoom"
        Me.rtbZoom.StepFrequency = 25
        Me.rtbZoom.ToolTip = resources.GetString("rtbZoom.ToolTip")
        Me.rtbZoom.Value = 10
        '
        '_cmdHolder
        '
        Me._cmdHolder.Commands.Add(Me.cmdFileOpen)
        Me._cmdHolder.Commands.Add(Me.cmdFileSave)
        Me._cmdHolder.Commands.Add(Me.cmdFileClose)
        Me._cmdHolder.Commands.Add(Me.cmdFileNew)
        Me._cmdHolder.Commands.Add(Me.cmdExit)
        Me._cmdHolder.Commands.Add(Me.cmdPrint)
        Me._cmdHolder.Commands.Add(Me.cmdRefresh)
        Me._cmdHolder.Commands.Add(Me.cmdPageSetup)
        Me._cmdHolder.Commands.Add(Me.cmdPageLandscape)
        Me._cmdHolder.Commands.Add(Me.cmdPagePortrait)
        Me._cmdHolder.Commands.Add(Me.cmdZoomFitPage)
        Me._cmdHolder.Commands.Add(Me.cmdZoomFitWidth)
        Me._cmdHolder.Commands.Add(Me.cmdZoom100)
        Me._cmdHolder.Commands.Add(Me.cmdView)
        Me._cmdHolder.Commands.Add(Me.cmdGoPageNo)
        Me._cmdHolder.Commands.Add(Me.cmdGoFirst)
        Me._cmdHolder.Commands.Add(Me.cmdGoLast)
        Me._cmdHolder.Commands.Add(Me.cmdGoPrev)
        Me._cmdHolder.Commands.Add(Me.cmdGoNext)
        Me._cmdHolder.Commands.Add(Me.cmdHistoryPrev)
        Me._cmdHolder.Commands.Add(Me.cmdHistoryNext)
        Me._cmdHolder.Commands.Add(Me.cmdMouseModeHand)
        Me._cmdHolder.Commands.Add(Me.cmdMouseModeSelect)
        Me._cmdHolder.Commands.Add(Me.cmdMouseModeZoomIn)
        Me._cmdHolder.Commands.Add(Me.cmdMouseModeZoomOut)
        Me._cmdHolder.Commands.Add(Me.cmdPageViewSingle)
        Me._cmdHolder.Commands.Add(Me.cmdPageViewContinuous)
        Me._cmdHolder.Commands.Add(Me.cmdPageViewTwoUp)
        Me._cmdHolder.Commands.Add(Me.cmdPageViewTwoUpContinuous)
        Me._cmdHolder.Commands.Add(Me.cmdFind)
        Me._cmdHolder.Commands.Add(Me.cmdFindNext)
        Me._cmdHolder.Commands.Add(Me.cmdZoomIn)
        Me._cmdHolder.Commands.Add(Me.cmdZoomOut)
        Me._cmdHolder.Commands.Add(Me.cmdZoomDialog)
        Me._cmdHolder.Commands.Add(Me.cmdHelp)
        Me._cmdHolder.Commands.Add(Me.cmdAbout)
        Me._cmdHolder.Owner = Me
        '
        'cmdFileOpen
        '
        Me.cmdFileOpen.Name = "cmdFileOpen"
        Me.cmdFileOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO
        Me.cmdFileOpen.ShortcutText = ""
        '
        'cmdFileSave
        '
        Me.cmdFileSave.Name = "cmdFileSave"
        Me.cmdFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.cmdFileSave.ShortcutText = ""
        '
        'cmdFileClose
        '
        Me.cmdFileClose.Name = "cmdFileClose"
        Me.cmdFileClose.Shortcut = System.Windows.Forms.Shortcut.CtrlF4
        Me.cmdFileClose.ShortcutText = ""
        '
        'cmdFileNew
        '
        Me.cmdFileNew.Name = "cmdFileNew"
        Me.cmdFileNew.Shortcut = System.Windows.Forms.Shortcut.CtrlN
        Me.cmdFileNew.ShortcutText = ""
        '
        'cmdExit
        '
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.ShortcutText = ""
        '
        'cmdPrint
        '
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.cmdPrint.ShortcutText = ""
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.cmdRefresh.ShortcutText = ""
        '
        'cmdPageSetup
        '
        Me.cmdPageSetup.Name = "cmdPageSetup"
        Me.cmdPageSetup.ShortcutText = ""
        '
        'cmdPageLandscape
        '
        Me.cmdPageLandscape.Name = "cmdPageLandscape"
        Me.cmdPageLandscape.ShortcutText = ""
        '
        'cmdPagePortrait
        '
        Me.cmdPagePortrait.Name = "cmdPagePortrait"
        Me.cmdPagePortrait.ShortcutText = ""
        '
        'cmdZoomFitPage
        '
        Me.cmdZoomFitPage.Name = "cmdZoomFitPage"
        Me.cmdZoomFitPage.ShortcutText = ""
        '
        'cmdZoomFitWidth
        '
        Me.cmdZoomFitWidth.Name = "cmdZoomFitWidth"
        Me.cmdZoomFitWidth.ShortcutText = ""
        '
        'cmdZoom100
        '
        Me.cmdZoom100.Name = "cmdZoom100"
        Me.cmdZoom100.ShortcutText = ""
        '
        'cmdView
        '
        Me.cmdView.Name = "cmdView"
        Me.cmdView.ShortcutText = ""
        '
        'cmdGoPageNo
        '
        Me.cmdGoPageNo.Name = "cmdGoPageNo"
        Me.cmdGoPageNo.ShortcutText = ""
        '
        'cmdGoFirst
        '
        Me.cmdGoFirst.Name = "cmdGoFirst"
        Me.cmdGoFirst.ShortcutText = ""
        '
        'cmdGoLast
        '
        Me.cmdGoLast.Name = "cmdGoLast"
        Me.cmdGoLast.ShortcutText = ""
        '
        'cmdGoPrev
        '
        Me.cmdGoPrev.Name = "cmdGoPrev"
        Me.cmdGoPrev.ShortcutText = ""
        '
        'cmdGoNext
        '
        Me.cmdGoNext.Name = "cmdGoNext"
        Me.cmdGoNext.ShortcutText = ""
        '
        'cmdHistoryPrev
        '
        Me.cmdHistoryPrev.Name = "cmdHistoryPrev"
        Me.cmdHistoryPrev.ShortcutText = ""
        '
        'cmdHistoryNext
        '
        Me.cmdHistoryNext.Name = "cmdHistoryNext"
        Me.cmdHistoryNext.ShortcutText = ""
        '
        'cmdMouseModeHand
        '
        Me.cmdMouseModeHand.Name = "cmdMouseModeHand"
        Me.cmdMouseModeHand.ShortcutText = ""
        '
        'cmdMouseModeSelect
        '
        Me.cmdMouseModeSelect.Name = "cmdMouseModeSelect"
        Me.cmdMouseModeSelect.ShortcutText = ""
        '
        'cmdMouseModeZoomIn
        '
        Me.cmdMouseModeZoomIn.Name = "cmdMouseModeZoomIn"
        Me.cmdMouseModeZoomIn.ShortcutText = ""
        '
        'cmdMouseModeZoomOut
        '
        Me.cmdMouseModeZoomOut.Name = "cmdMouseModeZoomOut"
        Me.cmdMouseModeZoomOut.ShortcutText = ""
        '
        'cmdPageViewSingle
        '
        Me.cmdPageViewSingle.Name = "cmdPageViewSingle"
        Me.cmdPageViewSingle.ShortcutText = ""
        '
        'cmdPageViewContinuous
        '
        Me.cmdPageViewContinuous.Name = "cmdPageViewContinuous"
        Me.cmdPageViewContinuous.ShortcutText = ""
        '
        'cmdPageViewTwoUp
        '
        Me.cmdPageViewTwoUp.Name = "cmdPageViewTwoUp"
        Me.cmdPageViewTwoUp.ShortcutText = ""
        '
        'cmdPageViewTwoUpContinuous
        '
        Me.cmdPageViewTwoUpContinuous.Name = "cmdPageViewTwoUpContinuous"
        Me.cmdPageViewTwoUpContinuous.ShortcutText = ""
        '
        'cmdFind
        '
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Shortcut = System.Windows.Forms.Shortcut.CtrlF
        Me.cmdFind.ShortcutText = ""
        '
        'cmdFindNext
        '
        Me.cmdFindNext.Name = "cmdFindNext"
        Me.cmdFindNext.Shortcut = System.Windows.Forms.Shortcut.F3
        Me.cmdFindNext.ShortcutText = ""
        '
        'cmdZoomIn
        '
        Me.cmdZoomIn.Name = "cmdZoomIn"
        Me.cmdZoomIn.ShortcutText = ""
        '
        'cmdZoomOut
        '
        Me.cmdZoomOut.Name = "cmdZoomOut"
        Me.cmdZoomOut.ShortcutText = ""
        '
        'cmdZoomDialog
        '
        Me.cmdZoomDialog.Name = "cmdZoomDialog"
        Me.cmdZoomDialog.ShortcutText = ""
        '
        'cmdHelp
        '
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.cmdHelp.ShortcutText = ""
        '
        'cmdAbout
        '
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.ShortcutText = ""
        '
        'C1dViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 680)
        Me.Controls.Add(Me._pview)
        Me.Controls.Add(Me.cdLeft)
        Me.Controls.Add(Me.rbMain)
        Me.Controls.Add(Me.sbMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "C1dViewForm"
        Me.Text = "C1dViewForm"
        CType(Me.rbMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cdLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cdLeft.ResumeLayout(False)
        CType(Me.dtMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dtMain.ResumeLayout(False)
        Me.dtpPages.ResumeLayout(False)
        CType(Me._pview, System.ComponentModel.ISupportInitialize).EndInit()
        Me.dtpOutline.ResumeLayout(False)
        Me.dtpSearch.ResumeLayout(False)
        CType(Me.sbMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._cmdHolder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbMain As C1.Win.C1Ribbon.C1Ribbon
    Friend WithEvents RibbonConfigToolBar1 As C1.Win.C1Ribbon.RibbonConfigToolBar
    Friend WithEvents rgFile As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents rbtnOpen As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents rbtnSave As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents rbtnPrint As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents rgPage As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents rgZoom As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents rgNavigation As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents rgTools As C1.Win.C1Ribbon.RibbonGroup
    Friend WithEvents rbtnPageSetup As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents rbtnPagePortrait As C1.Win.C1Ribbon.RibbonToggleButton
    Friend WithEvents rbtnPageLandscape As C1.Win.C1Ribbon.RibbonToggleButton
    Friend WithEvents rbtnRefresh As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents rbtnZoom100 As C1.Win.C1Ribbon.RibbonToggleButton
    Friend WithEvents RibbonSeparator1 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents rbtnZoomFitPage As C1.Win.C1Ribbon.RibbonToggleButton
    Friend WithEvents rbtnZoomFitWidth As C1.Win.C1Ribbon.RibbonToggleButton
    Friend WithEvents RibbonToolBar1 As C1.Win.C1Ribbon.RibbonToolBar
    Friend WithEvents rbtnFirstPage As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents rbtnPreviousPage As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonToolBar2 As C1.Win.C1Ribbon.RibbonToolBar
    Friend WithEvents rbtnNextPage As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents rbtnLastPage As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents rbtnHistoryBack As C1.Win.C1Ribbon.RibbonSplitButton
    Friend WithEvents RibbonSeparator2 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents rbtnHistoryNext As C1.Win.C1Ribbon.RibbonSplitButton
    Friend WithEvents rbtnHandTool As C1.Win.C1Ribbon.RibbonToggleButton
    Friend WithEvents rbtnFind As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents rbtnFindAgain As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonSeparator3 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents rbtnTextSelectTool As C1.Win.C1Ribbon.RibbonToggleButton
    Friend WithEvents rbtnZoomInTool As C1.Win.C1Ribbon.RibbonToggleButton
    Friend WithEvents rbtnZoomOutTool As C1.Win.C1Ribbon.RibbonToggleButton
    Friend WithEvents cdLeft As C1.Win.C1Command.C1CommandDock
    Friend WithEvents dtMain As C1.Win.C1Command.C1DockingTab
    Friend WithEvents dtpPages As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents sbMain As C1.Win.C1Ribbon.C1StatusBar
    Friend WithEvents _pview As C1.Win.C1Preview.C1PreviewPane
    Friend WithEvents _cmdHolder As C1.Win.C1Command.C1CommandHolder
    Friend WithEvents dtpOutline As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents dtpSearch As C1.Win.C1Command.C1DockingTabPage
    Friend WithEvents ptvMain As C1.Win.C1Preview.C1PreviewThumbnailView
    Friend WithEvents povMain As C1.Win.C1Preview.C1PreviewOutlineView
    Friend WithEvents ptspMain As C1.Win.C1Preview.C1PreviewTextSearchPanel
    Friend WithEvents rtgViewMode As C1.Win.C1Ribbon.RibbonToggleGroup
    Private WithEvents RibbonQat1 As C1.Win.C1Ribbon.RibbonQat
    Private WithEvents rtPreview As C1.Win.C1Ribbon.RibbonTab
    Private WithEvents rebPageNo As C1.Win.C1Ribbon.RibbonTextBox
    Private WithEvents rlblPageCount As C1.Win.C1Ribbon.RibbonLabel
    Private WithEvents rbtnFindClose As C1.Win.C1Ribbon.RibbonButton
    Private WithEvents rtbFindText As C1.Win.C1Ribbon.RibbonTextBox
    Private WithEvents rbtnFindNext As C1.Win.C1Ribbon.RibbonButton
    Private WithEvents rbtnFindPrev As C1.Win.C1Ribbon.RibbonButton
    Private WithEvents rbtnFindMatchCase As C1.Win.C1Ribbon.RibbonToggleButton
    Private WithEvents rlblStatusText As C1.Win.C1Ribbon.RibbonLabel
    Private WithEvents RibbonSeparator4 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents rbtnOpen2 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents rbtnSave2 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents rbtnPrint2 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonSeparator5 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents rbtnPageSetup2 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonSeparator6 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents rbtnNew2 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonSeparator7 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents rbtnClose2 As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents RibbonSeparator8 As C1.Win.C1Ribbon.RibbonSeparator
    Friend WithEvents cmdFileOpen As C1.Win.C1Command.C1Command
    Friend WithEvents cmdFileSave As C1.Win.C1Command.C1Command
    Friend WithEvents cmdFileClose As C1.Win.C1Command.C1Command
    Friend WithEvents cmdFileNew As C1.Win.C1Command.C1Command
    Friend WithEvents cmdExit As C1.Win.C1Command.C1Command
    Friend WithEvents cmdPrint As C1.Win.C1Command.C1Command
    Friend WithEvents cmdRefresh As C1.Win.C1Command.C1Command
    Friend WithEvents cmdPageSetup As C1.Win.C1Command.C1Command
    Friend WithEvents cmdPageLandscape As C1.Win.C1Command.C1Command
    Friend WithEvents cmdPagePortrait As C1.Win.C1Command.C1Command
    Friend WithEvents cmdZoomFitPage As C1.Win.C1Command.C1Command
    Friend WithEvents cmdZoomFitWidth As C1.Win.C1Command.C1Command
    Friend WithEvents cmdZoom100 As C1.Win.C1Command.C1Command
    Friend WithEvents cmdView As C1.Win.C1Command.C1Command
    Friend WithEvents cmdGoPageNo As C1.Win.C1Command.C1Command
    Friend WithEvents cmdGoFirst As C1.Win.C1Command.C1Command
    Friend WithEvents cmdGoLast As C1.Win.C1Command.C1Command
    Friend WithEvents cmdGoPrev As C1.Win.C1Command.C1Command
    Friend WithEvents cmdGoNext As C1.Win.C1Command.C1Command
    Friend WithEvents cmdHistoryPrev As C1.Win.C1Command.C1Command
    Friend WithEvents cmdHistoryNext As C1.Win.C1Command.C1Command
    Friend WithEvents cmdMouseModeHand As C1.Win.C1Command.C1Command
    Friend WithEvents cmdMouseModeSelect As C1.Win.C1Command.C1Command
    Friend WithEvents cmdMouseModeZoomIn As C1.Win.C1Command.C1Command
    Friend WithEvents cmdMouseModeZoomOut As C1.Win.C1Command.C1Command
    Friend WithEvents cmdPageViewSingle As C1.Win.C1Command.C1Command
    Friend WithEvents cmdPageViewContinuous As C1.Win.C1Command.C1Command
    Friend WithEvents cmdPageViewTwoUp As C1.Win.C1Command.C1Command
    Friend WithEvents cmdPageViewTwoUpContinuous As C1.Win.C1Command.C1Command
    Friend WithEvents cmdFind As C1.Win.C1Command.C1Command
    Friend WithEvents cmdFindNext As C1.Win.C1Command.C1Command
    Friend WithEvents cmdZoomIn As C1.Win.C1Command.C1Command
    Friend WithEvents cmdZoomOut As C1.Win.C1Command.C1Command
    Friend WithEvents cmdZoomDialog As C1.Win.C1Command.C1Command
    Friend WithEvents cmdHelp As C1.Win.C1Command.C1Command
    Friend WithEvents cmdAbout As C1.Win.C1Command.C1Command
    Friend WithEvents rmenuHelp As C1.Win.C1Ribbon.RibbonMenu
    Friend WithEvents rbtnAbout As C1.Win.C1Ribbon.RibbonButton
    Friend WithEvents rbtnExit As C1.Win.C1Ribbon.RibbonButton
    Private WithEvents rbnProgress As C1.Win.C1Ribbon.RibbonProgressBar
    Private WithEvents rbtnViewSinglePage As C1.Win.C1Ribbon.RibbonToggleButton
    Private WithEvents rbtnViewContinuous As C1.Win.C1Ribbon.RibbonToggleButton
    Private WithEvents rbtnViewPagesFacing As C1.Win.C1Ribbon.RibbonToggleButton
    Private WithEvents rbtnViewPagesFacingContinuous As C1.Win.C1Ribbon.RibbonToggleButton
    Private WithEvents rbtnZoom As C1.Win.C1Ribbon.RibbonButton
    Private WithEvents rtbZoom As C1.Win.C1Ribbon.RibbonTrackBar
    Private WithEvents RibbonListItem1 As C1.Win.C1Ribbon.RibbonListItem
    Private WithEvents RibbonLabel1 As C1.Win.C1Ribbon.RibbonLabel
    Private WithEvents RibbonListItem2 As C1.Win.C1Ribbon.RibbonListItem
    Private WithEvents ramMain As C1.Win.C1Ribbon.RibbonApplicationMenu
End Class
