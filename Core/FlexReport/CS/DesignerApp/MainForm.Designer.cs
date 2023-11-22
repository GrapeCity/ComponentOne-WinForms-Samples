//----------------------------------------------------------------------------
// MainForm.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sbMain = new C1.Win.Ribbon.C1StatusBar();
            this.rbtnCloseSearch = new C1.Win.Ribbon.RibbonButton();
            this.rebSearchText = new C1.Win.Ribbon.RibbonTextBox();
            this.rbtnSearchNext = new C1.Win.Ribbon.RibbonButton();
            this.rbtnSearchPrev = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator26 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnMatchCase = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator27 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnMatchWholeWord = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator28 = new C1.Win.Ribbon.RibbonSeparator();
            this.rlblStatusBarText = new C1.Win.Ribbon.RibbonLabel();
            this.rlblSelectedReport = new C1.Win.Ribbon.RibbonLabel();
            this.ribbonSeparator17 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnRenderError = new C1.Win.Ribbon.RibbonButton();
            this.rsepRenderError = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnRotateViewCCW = new C1.Win.Ribbon.RibbonButton();
            this.rbtnRotateViewCW = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator30 = new C1.Win.Ribbon.RibbonSeparator();
            this.ribbonToggleGroup1 = new C1.Win.Ribbon.RibbonToggleGroup();
            this.rbtnViewSinglePage = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnViewContinuous = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnViewPagesFacing = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnViewPagesFacingContinuous = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator9 = new C1.Win.Ribbon.RibbonSeparator();
            this.rtbZoom = new C1.Win.Ribbon.RibbonTrackBar();
            this.rlblZoom = new C1.Win.Ribbon.RibbonLabel();
            this.rbtnStatusZoom = new C1.Win.Ribbon.RibbonButton();
            this.rbnMain = new C1.Win.Ribbon.C1Ribbon();
            this.ramMain = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.rbtnOptions = new C1.Win.Ribbon.RibbonButton();
            this.rbtnSaveAndExit = new C1.Win.Ribbon.RibbonButton();
            this.rbtnCancelAndExit = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExit = new C1.Win.Ribbon.RibbonButton();
            this.rbtnNew = new C1.Win.Ribbon.RibbonButton();
            this.rbtnOpen = new C1.Win.Ribbon.RibbonButton();
            this.rbtnClose = new C1.Win.Ribbon.RibbonButton();
            this.rbtnSave = new C1.Win.Ribbon.RibbonButton();
            this.rbtnSaveAs = new C1.Win.Ribbon.RibbonButton();
            this.rbtnPreviewPrint = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator1 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnImport = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExport = new C1.Win.Ribbon.RibbonButton();
            this.ribbonListItem1 = new C1.Win.Ribbon.RibbonListItem();
            this.ribbonLabel1 = new C1.Win.Ribbon.RibbonLabel();
            this.ribbonListItem2 = new C1.Win.Ribbon.RibbonListItem();
            this.ribbonSeparator2 = new C1.Win.Ribbon.RibbonSeparator();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.rbtnAbout = new C1.Win.Ribbon.RibbonSplitButton();
            this.rbtnHelpContents = new C1.Win.Ribbon.RibbonButton();
            this.rbtnCheckForUpdates = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator15 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnAbout2 = new C1.Win.Ribbon.RibbonButton();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.rbtnUndo = new C1.Win.Ribbon.RibbonButton();
            this.rbtnRedo = new C1.Win.Ribbon.RibbonButton();
            this.rbtnPaste = new C1.Win.Ribbon.RibbonButton();
            this.rbtnCut = new C1.Win.Ribbon.RibbonButton();
            this.rbtnCopy = new C1.Win.Ribbon.RibbonButton();
            this.rtDesign = new C1.Win.Ribbon.RibbonTab();
            this.rgMode = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnModeDesign = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnModePreview = new C1.Win.Ribbon.RibbonToggleButton();
            this.rgEdit = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnDelete = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator3 = new C1.Win.Ribbon.RibbonSeparator();
            this.rgFont = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonToolBar1 = new C1.Win.Ribbon.RibbonToolBar();
            this.rcbFontName = new C1.Win.Ribbon.RibbonFontComboBox();
            this.rcbFontSize = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonSeparator5 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnFontSizeUp = new C1.Win.Ribbon.RibbonButton();
            this.rbtnFontSizeDown = new C1.Win.Ribbon.RibbonButton();
            this.ribbonToolBar2 = new C1.Win.Ribbon.RibbonToolBar();
            this.rbtnFontBold = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnFontItalic = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnFontUnderline = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator8 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnTextAlignGeneral = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnTextAlignLeft = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnTextAlignCenter = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnTextAlignRight = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnTextAlignJustify = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator4 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnTextColor = new C1.Win.Ribbon.RibbonColorPicker();
            this.rbtnFillColor = new C1.Win.Ribbon.RibbonColorPicker();
            this.rgBorder = new C1.Win.Ribbon.RibbonGroup();
            this.rgalBorderStyle = new C1.Win.Ribbon.RibbonGallery();
            this.rgiBorderStyleSolid = new C1.Win.Ribbon.RibbonGalleryItem();
            this.rgiBorderStyleDash = new C1.Win.Ribbon.RibbonGalleryItem();
            this.rgiBorderStyleDot = new C1.Win.Ribbon.RibbonGalleryItem();
            this.rgiBorderStyleDashDot = new C1.Win.Ribbon.RibbonGalleryItem();
            this.rgiBorderStyleDashDotDot = new C1.Win.Ribbon.RibbonGalleryItem();
            this.rgiBorderStyleNone = new C1.Win.Ribbon.RibbonGalleryItem();
            this.ribbonSeparator18 = new C1.Win.Ribbon.RibbonSeparator();
            this.ribbonToolBar5 = new C1.Win.Ribbon.RibbonToolBar();
            this.rclrBorderColor = new C1.Win.Ribbon.RibbonColorPicker();
            this.ribbonToolBar6 = new C1.Win.Ribbon.RibbonToolBar();
            this.rcmbBorderWidth = new C1.Win.Ribbon.RibbonComboBox();
            this.rgAutoFormat = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnStyles = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator6 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnApplyStyleToSelection = new C1.Win.Ribbon.RibbonButton();
            this.rbtnFormatAsTableRow = new C1.Win.Ribbon.RibbonButton();
            this.rgData = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnDataSources = new C1.Win.Ribbon.RibbonSplitButton();
            this.ribbonSeparator22 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnDataSourcesAdd = new C1.Win.Ribbon.RibbonButton();
            this.rbtnGroupSort = new C1.Win.Ribbon.RibbonButton();
            this.rbtnReportInfo = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator21 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnScriptEditor = new C1.Win.Ribbon.RibbonToggleButton();
            this.rgTools = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnShowPropertyGrid = new C1.Win.Ribbon.RibbonButton();
            this.rbtnShowDataTree = new C1.Win.Ribbon.RibbonButton();
            this.rbtnShowErrorList = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator29 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbmCaptionsVisibility = new C1.Win.Ribbon.RibbonMenu();
            this.rbtnCaptionsVisibilityAll = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnCaptionsVisibilitySection = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnCaptionsVisibilityHairline = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnCaptionsVisibilityHidden = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator23 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnCaptionsExpandAll = new C1.Win.Ribbon.RibbonButton();
            this.rbtnCaptionsCollapseAll = new C1.Win.Ribbon.RibbonButton();
            this.rtInsert = new C1.Win.Ribbon.RibbonTab();
            this.rgFields = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnFieldArrow = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator12 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnFieldDataField = new C1.Win.Ribbon.RibbonSplitButton();
            this.rbtnFieldRtf = new C1.Win.Ribbon.RibbonSplitButton();
            this.rbtnFieldParagraph = new C1.Win.Ribbon.RibbonButton();
            this.rbtnFieldCheckBox = new C1.Win.Ribbon.RibbonSplitButton();
            this.rbtnFieldBarCode = new C1.Win.Ribbon.RibbonSplitButton();
            this.rbtnFieldCalculated = new C1.Win.Ribbon.RibbonSplitButton();
            this.rbtnFieldPicture = new C1.Win.Ribbon.RibbonSplitButton();
            this.rbtnFieldShape = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnFieldSubReport = new C1.Win.Ribbon.RibbonMenu();
            this.rbtnFieldChart = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnFieldLegacy = new C1.Win.Ribbon.RibbonToggleButton();
            this.rgSubSection = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnSubSectionAdd = new C1.Win.Ribbon.RibbonButton();
            this.rbtnSubSectionRemove = new C1.Win.Ribbon.RibbonButton();
            this.rbtnSubSectionMoveUp = new C1.Win.Ribbon.RibbonButton();
            this.rbtnSubSectionMoveDown = new C1.Win.Ribbon.RibbonButton();
            this.rgCustomFields = new C1.Win.Ribbon.RibbonGroup();
            this.rtArrange = new C1.Win.Ribbon.RibbonTab();
            this.rgGrid = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnSnapToGrid = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnShowGrid = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnLockFields = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator16 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnGridProperties = new C1.Win.Ribbon.RibbonButton();
            this.rgControlAlignment = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnAlignLeft = new C1.Win.Ribbon.RibbonButton();
            this.rbtnAlignRight = new C1.Win.Ribbon.RibbonButton();
            this.rbtnAlignCenter = new C1.Win.Ribbon.RibbonButton();
            this.rbtnAlignTop = new C1.Win.Ribbon.RibbonButton();
            this.rbtnAlignBottom = new C1.Win.Ribbon.RibbonButton();
            this.rbtnAlignMiddle = new C1.Win.Ribbon.RibbonButton();
            this.rgPosition = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnEqualHorizontalSpacing = new C1.Win.Ribbon.RibbonButton();
            this.rbtnIncreaseHorizontalSpacing = new C1.Win.Ribbon.RibbonButton();
            this.rbtnDecreaseHorizontalSpacing = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator13 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnEqualVerticalSpacing = new C1.Win.Ribbon.RibbonButton();
            this.rbtnIncreaseVerticalSpacing = new C1.Win.Ribbon.RibbonButton();
            this.rbtnDecreaseVerticalSpacing = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator11 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnAlignToGrid = new C1.Win.Ribbon.RibbonButton();
            this.rbtnBringToFront = new C1.Win.Ribbon.RibbonButton();
            this.rbtnSendToBack = new C1.Win.Ribbon.RibbonButton();
            this.rgSize = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnHeightToTallest = new C1.Win.Ribbon.RibbonButton();
            this.rbtnHeightToShortest = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator19 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnWidthToWidest = new C1.Win.Ribbon.RibbonButton();
            this.rbtnWidthToNarrowest = new C1.Win.Ribbon.RibbonButton();
            this.rbtnSizeToGrid = new C1.Win.Ribbon.RibbonButton();
            this.rtPageSetup = new C1.Win.Ribbon.RibbonTab();
            this.rgPageLayout1 = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnPageSize1 = new C1.Win.Ribbon.RibbonSplitButton();
            this.rbtnPagePortrait1 = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnPageLandscape1 = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator14 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnPageSetup1 = new C1.Win.Ribbon.RibbonButton();
            this.rtPreview = new C1.Win.Ribbon.RibbonTab();
            this.rgPageLayout2 = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnPageSize2 = new C1.Win.Ribbon.RibbonSplitButton();
            this.rbtnPagePortrait2 = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnPageLandscape2 = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator141 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnPageSetup2 = new C1.Win.Ribbon.RibbonButton();
            this.rgZoom = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnPreviewPaginated = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator24 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnPreviewParams = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnPreviewOutlines = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnPreviewThumbnails = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator25 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnZoomOnePage = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnZoomTwoPages = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnZoom = new C1.Win.Ribbon.RibbonMenu();
            this.rbtnZoomFitToWindow = new C1.Win.Ribbon.RibbonToggleButton();
            this.ribbonSeparator10 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnZoom10 = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnZoom25 = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnZoom50 = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnZoom75 = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnZoom100 = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnZoom125 = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnZoom150 = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnZoom200 = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnZoom500 = new C1.Win.Ribbon.RibbonToggleButton();
            this.rgNavigation = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonToolBar3 = new C1.Win.Ribbon.RibbonToolBar();
            this.rbtnFirstPage = new C1.Win.Ribbon.RibbonButton();
            this.rbtnPreviousPage = new C1.Win.Ribbon.RibbonButton();
            this.rebPageNo = new C1.Win.Ribbon.RibbonTextBox();
            this.rlblPageCount = new C1.Win.Ribbon.RibbonLabel();
            this.rbtnNextPage = new C1.Win.Ribbon.RibbonButton();
            this.rbtnLastPage = new C1.Win.Ribbon.RibbonButton();
            this.ribbonToolBar4 = new C1.Win.Ribbon.RibbonToolBar();
            this.rbtnPreviousView = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator7 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnNextView = new C1.Win.Ribbon.RibbonButton();
            this.rgPreviewTools = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnHandTool = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnTextSelectTool = new C1.Win.Ribbon.RibbonToggleButton();
            this.rbtnPreviewFind = new C1.Win.Ribbon.RibbonToggleButton();
            this.rgExport = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnExportPdf = new C1.Win.Ribbon.RibbonSplitButton();
            this.rbtnExportPdf_A = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExportPdf_linkedFonts = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExportHtml = new C1.Win.Ribbon.RibbonSplitButton();
            this.rbtnExportHtml2 = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExportHtmlPaged = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExportXls = new C1.Win.Ribbon.RibbonSplitButton();
            this.rbtnExportXls2 = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExportXlsx = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator20 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnExportRtf = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExportDocx = new C1.Win.Ribbon.RibbonButton();
            this.rmExportMore = new C1.Win.Ribbon.RibbonMenu();
            this.rbtnExportMetafiles = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExportTIFF = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExportBMP = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExportPNG = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExportJPEG = new C1.Win.Ribbon.RibbonButton();
            this.rbtnExportGIF = new C1.Win.Ribbon.RibbonButton();
            this.rgStopRefresh = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnPreviewStop = new C1.Win.Ribbon.RibbonButton();
            this.rbtnPreviewRefresh = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.c1CommandDock1 = new C1.Win.Command.C1CommandDock();
            this.c1DockingTab2 = new C1.Win.Command.C1DockingTab();
            this.dtpProperties = new C1.Win.Command.C1DockingTabPage();
            this._propGrid = new System.Windows.Forms.PropertyGrid();
            this.c1ToolBar2 = new C1.Win.Command.C1ToolBar();
            this.chMain = new C1.Win.Command.C1CommandHolder();
            this.cAddDataSource = new C1.Win.Command.C1Command();
            this.cPreviewStop = new C1.Win.Command.C1Command();
            this.cmNewReport = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink11 = new C1.Win.Command.C1CommandLink();
            this.cNewReportWizard = new C1.Win.Command.C1Command();
            this.c1CommandLink12 = new C1.Win.Command.C1CommandLink();
            this.cNewReportEmpty = new C1.Win.Command.C1Command();
            this.cPasteReport = new C1.Win.Command.C1Command();
            this.cCutReport = new C1.Win.Command.C1Command();
            this.cCopyReport = new C1.Win.Command.C1Command();
            this.cDeleteReport = new C1.Win.Command.C1Command();
            this.cMoveReportUp = new C1.Win.Command.C1Command();
            this.cMoveReportDown = new C1.Win.Command.C1Command();
            this.cPropertiesCategorized = new C1.Win.Command.C1Command();
            this.cPropertiesAlphabetical = new C1.Win.Command.C1Command();
            this.cmSelectAll = new C1.Win.Command.C1Command();
            this.cmCutField = new C1.Win.Command.C1Command();
            this.cmCopyField = new C1.Win.Command.C1Command();
            this.cmPasteField = new C1.Win.Command.C1Command();
            this.cmDeleteField = new C1.Win.Command.C1Command();
            this.cmBringToFront = new C1.Win.Command.C1Command();
            this.cmSendToBack = new C1.Win.Command.C1Command();
            this.cmReport = new C1.Win.Command.C1ContextMenu();
            this.c1CommandLink6 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink25 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink26 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink27 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink7 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink8 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink9 = new C1.Win.Command.C1CommandLink();
            this._cmDesigner = new C1.Win.Command.C1ContextMenu();
            this.c1CommandLink14 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink15 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink16 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink17 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink13 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink18 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink19 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink28 = new C1.Win.Command.C1CommandLink();
            this.cLockFields = new C1.Win.Command.C1Command();
            this._clContextPlaceholderTop = new C1.Win.Command.C1CommandLink();
            this._cContextPlaceholderTop = new C1.Win.Command.C1Command();
            this._clContextPlaceholderBot = new C1.Win.Command.C1CommandLink();
            this._cContextPlaceholderBot = new C1.Win.Command.C1Command();
            this.c1CommandLink10 = new C1.Win.Command.C1CommandLink();
            this.cmProperties = new C1.Win.Command.C1Command();
            this.cPreviewRefresh = new C1.Win.Command.C1Command();
            this.cScriptEditor = new C1.Win.Command.C1Command();
            this.cmDataTree = new C1.Win.Command.C1ContextMenu();
            this.clAddParameter = new C1.Win.Command.C1CommandLink();
            this.cAddParameter = new C1.Win.Command.C1Command();
            this.clAddDataSource = new C1.Win.Command.C1CommandLink();
            this.clAddCalculatedField = new C1.Win.Command.C1CommandLink();
            this.cAddCalculatedField = new C1.Win.Command.C1Command();
            this.clAddSort = new C1.Win.Command.C1CommandLink();
            this.cAddSort = new C1.Win.Command.C1Command();
            this.clDataTreeEdit = new C1.Win.Command.C1CommandLink();
            this.cDataTreeEdit = new C1.Win.Command.C1Command();
            this.clDataTreeChangeSortOrder = new C1.Win.Command.C1CommandLink();
            this.cDataTreeChangeSortOrder = new C1.Win.Command.C1Command();
            this.clDataTreeInplaceEdit = new C1.Win.Command.C1CommandLink();
            this.cDataTreeInplaceEdit = new C1.Win.Command.C1Command();
            this.clDataTreeMoveUp = new C1.Win.Command.C1CommandLink();
            this.cDataTreeMoveUp = new C1.Win.Command.C1Command();
            this.clDataTreeMoveDown = new C1.Win.Command.C1CommandLink();
            this.cDataTreeMoveDown = new C1.Win.Command.C1Command();
            this.clDataTreeDelete = new C1.Win.Command.C1CommandLink();
            this.cDataTreeDelete = new C1.Win.Command.C1Command();
            this.cDataTreeInsert = new C1.Win.Command.C1Command();
            this.cmDataTreeAdd = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink37 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink38 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink39 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink40 = new C1.Win.Command.C1CommandLink();
            this.cmPreview = new C1.Win.Command.C1ContextMenu();
            this.c1CommandLink5 = new C1.Win.Command.C1CommandLink();
            this.cPreviewCopy = new C1.Win.Command.C1Command();
            this.cDataSourceRefresh = new C1.Win.Command.C1Command();
            this.cmErrorList = new C1.Win.Command.C1ContextMenu();
            this.c1CommandLink30 = new C1.Win.Command.C1CommandLink();
            this.cErrorListHide = new C1.Win.Command.C1Command();
            this.c1CommandLink31 = new C1.Win.Command.C1CommandLink();
            this.cErrorListClear = new C1.Win.Command.C1Command();
            this.c1CommandLink32 = new C1.Win.Command.C1CommandLink();
            this.cErrorListCopy = new C1.Win.Command.C1Command();
            this.cErrorListShow = new C1.Win.Command.C1Command();
            this.ilReportList = new System.Windows.Forms.ImageList(this.components);
            this._flexDesigner = new C1.Win.FlexReport.C1FlexReportDesigner();
            this._reportList = new FlexReportDesignerApp.Util.ReportList();
            this._dataTree = new FlexReportDesignerApp.Controls.DataTree();
            this._errorList = new FlexReportDesignerApp.Controls.ErrorList();
            this.c1CommandLink3 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink4 = new C1.Win.Command.C1CommandLink();
            this._fieldPicker = new FlexReportDesignerApp.Util.FieldPicker();
            this.c1DockingTab1 = new C1.Win.Command.C1DockingTab();
            this.dtpReports = new C1.Win.Command.C1DockingTabPage();
            this.c1ToolBar1 = new C1.Win.Command.C1ToolBar();
            this.c1CommandLink1 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink23 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink24 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink22 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink2 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink20 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink21 = new C1.Win.Command.C1CommandLink();
            this.dtpData = new C1.Win.Command.C1DockingTabPage();
            this.toolbarData = new C1.Win.Command.C1ToolBar();
            this.c1CommandLink36 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink41 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink35 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink34 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink42 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink43 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink29 = new C1.Win.Command.C1CommandLink();
            this.dtpErrors = new C1.Win.Command.C1DockingTabPage();
            this._flexViewer = new C1.Win.FlexViewer.C1FlexViewerPane();
            this._reportRender = new C1.Win.FlexReport.C1FlexReport();
            this.rbtnFieldFlexChart = new C1.Win.Ribbon.RibbonButton();
            ((System.ComponentModel.ISupportInitialize)(this.sbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbnMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).BeginInit();
            this.c1CommandDock1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).BeginInit();
            this.c1DockingTab2.SuspendLayout();
            this.dtpProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).BeginInit();
            this.c1DockingTab1.SuspendLayout();
            this.dtpReports.SuspendLayout();
            this.dtpData.SuspendLayout();
            this.dtpErrors.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._flexViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // sbMain
            // 
            this.sbMain.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.sbMain.LeftPaneItems.Add(this.rbtnCloseSearch);
            this.sbMain.LeftPaneItems.Add(this.rebSearchText);
            this.sbMain.LeftPaneItems.Add(this.rbtnSearchNext);
            this.sbMain.LeftPaneItems.Add(this.rbtnSearchPrev);
            this.sbMain.LeftPaneItems.Add(this.ribbonSeparator26);
            this.sbMain.LeftPaneItems.Add(this.rbtnMatchCase);
            this.sbMain.LeftPaneItems.Add(this.ribbonSeparator27);
            this.sbMain.LeftPaneItems.Add(this.rbtnMatchWholeWord);
            this.sbMain.LeftPaneItems.Add(this.ribbonSeparator28);
            this.sbMain.LeftPaneItems.Add(this.rlblStatusBarText);
            this.sbMain.Location = new System.Drawing.Point(0, 801);
            this.sbMain.Name = "sbMain";
            this.sbMain.RightPaneItems.Add(this.rlblSelectedReport);
            this.sbMain.RightPaneItems.Add(this.ribbonSeparator17);
            this.sbMain.RightPaneItems.Add(this.rbtnRenderError);
            this.sbMain.RightPaneItems.Add(this.rsepRenderError);
            this.sbMain.RightPaneItems.Add(this.rbtnRotateViewCCW);
            this.sbMain.RightPaneItems.Add(this.rbtnRotateViewCW);
            this.sbMain.RightPaneItems.Add(this.ribbonSeparator30);
            this.sbMain.RightPaneItems.Add(this.ribbonToggleGroup1);
            this.sbMain.RightPaneItems.Add(this.ribbonSeparator9);
            this.sbMain.RightPaneItems.Add(this.rtbZoom);
            this.sbMain.RightPaneItems.Add(this.rlblZoom);
            this.sbMain.RightPaneItems.Add(this.rbtnStatusZoom);
            this.sbMain.Size = new System.Drawing.Size(1310, 22);
            // 
            // rbtnCloseSearch
            // 
            this.rbtnCloseSearch.Name = "rbtnCloseSearch";
            this.rbtnCloseSearch.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnCloseSearch.SmallImage")));
            this.rbtnCloseSearch.Tag = "CloseSearch";
            this.rbtnCloseSearch.ToolTip = "Close the text search bar";
            this.rbtnCloseSearch.Visible = false;
            this.rbtnCloseSearch.Click += new System.EventHandler(this.rbtnCloseSearch_Click);
            // 
            // rebSearchText
            // 
            this.rebSearchText.Label = "Find:";
            this.rebSearchText.Name = "rebSearchText";
            this.rebSearchText.Tag = "SearchTextBox";
            this.rebSearchText.TextAreaWidth = 132;
            this.rebSearchText.ToolTip = "Text to search";
            this.rebSearchText.Visible = false;
            this.rebSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            this.rebSearchText.TextChanged += new System.EventHandler(this.rebSearchText_TextChanged);
            // 
            // rbtnSearchNext
            // 
            this.rbtnSearchNext.Name = "rbtnSearchNext";
            this.rbtnSearchNext.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnSearchNext.SmallImage")));
            this.rbtnSearchNext.Tag = "SearchNext";
            this.rbtnSearchNext.Text = "Next";
            this.rbtnSearchNext.ToolTip = "Search for the next occurrence";
            this.rbtnSearchNext.Visible = false;
            this.rbtnSearchNext.Click += new System.EventHandler(this.rbtnSearchNext_Click);
            // 
            // rbtnSearchPrev
            // 
            this.rbtnSearchPrev.Name = "rbtnSearchPrev";
            this.rbtnSearchPrev.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnSearchPrev.SmallImage")));
            this.rbtnSearchPrev.Tag = "SearchPrev";
            this.rbtnSearchPrev.Text = "Previous";
            this.rbtnSearchPrev.ToolTip = "Search for the previous occurrence";
            this.rbtnSearchPrev.Visible = false;
            this.rbtnSearchPrev.Click += new System.EventHandler(this.rbtnSearchPrev_Click);
            // 
            // ribbonSeparator26
            // 
            this.ribbonSeparator26.Name = "ribbonSeparator26";
            this.ribbonSeparator26.Visible = false;
            // 
            // rbtnMatchCase
            // 
            this.rbtnMatchCase.Name = "rbtnMatchCase";
            this.rbtnMatchCase.Tag = "MatchCase";
            this.rbtnMatchCase.Text = "Match Case";
            this.rbtnMatchCase.ToolTip = "Match case while searching";
            this.rbtnMatchCase.Visible = false;
            this.rbtnMatchCase.Click += new System.EventHandler(this.rbtnMatchCase_Click);
            // 
            // ribbonSeparator27
            // 
            this.ribbonSeparator27.Name = "ribbonSeparator27";
            this.ribbonSeparator27.Visible = false;
            // 
            // rbtnMatchWholeWord
            // 
            this.rbtnMatchWholeWord.Name = "rbtnMatchWholeWord";
            this.rbtnMatchWholeWord.Tag = "MatchWholeWord";
            this.rbtnMatchWholeWord.Text = "Whole Word";
            this.rbtnMatchWholeWord.ToolTip = "Match whole word";
            this.rbtnMatchWholeWord.Visible = false;
            this.rbtnMatchWholeWord.Click += new System.EventHandler(this.rbtnMatchWholeWord_Click);
            // 
            // ribbonSeparator28
            // 
            this.ribbonSeparator28.Name = "ribbonSeparator28";
            this.ribbonSeparator28.Visible = false;
            // 
            // rlblStatusBarText
            // 
            this.rlblStatusBarText.Name = "rlblStatusBarText";
            // 
            // rlblSelectedReport
            // 
            this.rlblSelectedReport.Name = "rlblSelectedReport";
            this.rlblSelectedReport.Tag = "SelectedReport";
            this.rlblSelectedReport.Text = "Selected report";
            // 
            // ribbonSeparator17
            // 
            this.ribbonSeparator17.Name = "ribbonSeparator17";
            // 
            // rbtnRenderError
            // 
            this.rbtnRenderError.Name = "rbtnRenderError";
            this.rbtnRenderError.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnRenderError.SmallImage")));
            this.rbtnRenderError.Click += new System.EventHandler(this.rbtnRenderError_Click);
            // 
            // rsepRenderError
            // 
            this.rsepRenderError.Name = "rsepRenderError";
            // 
            // rbtnRotateViewCCW
            // 
            this.rbtnRotateViewCCW.Name = "rbtnRotateViewCCW";
            this.rbtnRotateViewCCW.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnRotateViewCCW.SmallImage")));
            this.rbtnRotateViewCCW.Tag = "RotateViewCCW";
            this.rbtnRotateViewCCW.ToolTip = "Rotate view counterclockwise";
            this.rbtnRotateViewCCW.Click += rbtnRotateViewCCW_Click;
            // 
            // rbtnRotateViewCW
            // 
            this.rbtnRotateViewCW.Name = "rbtnRotateViewCW";
            this.rbtnRotateViewCW.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnRotateViewCW.SmallImage")));
            this.rbtnRotateViewCW.Tag = "RotateViewCW";
            this.rbtnRotateViewCW.ToolTip = "Rotate view clockwise";
            this.rbtnRotateViewCW.Click += rbtnRotateViewCW_Click;
            // 
            // ribbonSeparator30
            // 
            this.ribbonSeparator30.Name = "ribbonSeparator30";
            // 
            // ribbonToggleGroup1
            // 
            this.ribbonToggleGroup1.Items.Add(this.rbtnViewSinglePage);
            this.ribbonToggleGroup1.Items.Add(this.rbtnViewContinuous);
            this.ribbonToggleGroup1.Items.Add(this.rbtnViewPagesFacing);
            this.ribbonToggleGroup1.Items.Add(this.rbtnViewPagesFacingContinuous);
            this.ribbonToggleGroup1.Name = "ribbonToggleGroup1";
            // 
            // rbtnViewSinglePage
            // 
            this.rbtnViewSinglePage.Name = "rbtnViewSinglePage";
            this.rbtnViewSinglePage.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnViewSinglePage.SmallImage")));
            this.rbtnViewSinglePage.Tag = "ViewSinglePage";
            this.rbtnViewSinglePage.ToolTip = "Single page view";
            this.rbtnViewSinglePage.Click += new System.EventHandler(this.rbtnViewSinglePage_Click);
            // 
            // rbtnViewContinuous
            // 
            this.rbtnViewContinuous.Name = "rbtnViewContinuous";
            this.rbtnViewContinuous.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnViewContinuous.SmallImage")));
            this.rbtnViewContinuous.Tag = "ViewContinuous";
            this.rbtnViewContinuous.ToolTip = "Continuous view";
            this.rbtnViewContinuous.Click += new System.EventHandler(this.rbtnViewSinglePage_Click);
            // 
            // rbtnViewPagesFacing
            // 
            this.rbtnViewPagesFacing.Name = "rbtnViewPagesFacing";
            this.rbtnViewPagesFacing.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnViewPagesFacing.SmallImage")));
            this.rbtnViewPagesFacing.Tag = "ViewPagesFacing";
            this.rbtnViewPagesFacing.ToolTip = "Pages facing view";
            this.rbtnViewPagesFacing.Click += new System.EventHandler(this.rbtnViewSinglePage_Click);
            // 
            // rbtnViewPagesFacingContinuous
            // 
            this.rbtnViewPagesFacingContinuous.Name = "rbtnViewPagesFacingContinuous";
            this.rbtnViewPagesFacingContinuous.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnViewPagesFacingContinuous.SmallImage")));
            this.rbtnViewPagesFacingContinuous.Tag = "ViewPagesFacingContinuous";
            this.rbtnViewPagesFacingContinuous.ToolTip = "Pages facing continuous view";
            this.rbtnViewPagesFacingContinuous.Click += new System.EventHandler(this.rbtnViewSinglePage_Click);
            // 
            // ribbonSeparator9
            // 
            this.ribbonSeparator9.Name = "ribbonSeparator9";
            // 
            // rtbZoom
            // 
            this.rtbZoom.Maximum = 190;
            this.rtbZoom.Minimum = 10;
            this.rtbZoom.Name = "rtbZoom";
            this.rtbZoom.Tag = "ZoomValue";
            this.rtbZoom.TickFrequency = 90;
            this.rtbZoom.ToolTip = "Zoom";
            this.rtbZoom.Value = 100;
            this.rtbZoom.Width = 140;
            this.rtbZoom.Scroll += new System.EventHandler(this.rtbZoom_Scroll);
            // 
            // rlblZoom
            // 
            this.rlblZoom.Name = "rlblZoom";
            this.rlblZoom.Tag = "LblZoom";
            this.rlblZoom.Text = "100%";
            // 
            // rbtnStatusZoom
            // 
            this.rbtnStatusZoom.Name = "rbtnStatusZoom";
            this.rbtnStatusZoom.OwnerDraw = true;
            this.rbtnStatusZoom.Tag = "LblZoom";
            this.rbtnStatusZoom.Text = "   {0}%";
            this.rbtnStatusZoom.Click += new System.EventHandler(this.rbtnStatusZoom_Click);
            this.rbtnStatusZoom.DrawItem += ZoomLevelButton_DrawItem;
            // 
            // rbnMain
            // 
            this.rbnMain.ApplicationMenuHolder = this.ramMain;
            this.rbnMain.AutoSizeElement = C1.Framework.AutoSizeElement.Width;
            this.rbnMain.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.rbnMain.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.rbnMain.Location = new System.Drawing.Point(0, 0);
            this.rbnMain.Name = "rbnMain";
            this.rbnMain.QatHolder = this.ribbonQat1;
            this.rbnMain.Size = new System.Drawing.Size(1310, 143);
            this.rbnMain.Tabs.Add(this.rtDesign);
            this.rbnMain.Tabs.Add(this.rtInsert);
            this.rbnMain.Tabs.Add(this.rtArrange);
            this.rbnMain.Tabs.Add(this.rtPageSetup);
            this.rbnMain.Tabs.Add(this.rtPreview);
            this.rbnMain.ToolTipSettings.MaximumWidth = 800;
            this.rbnMain.TopToolBarHolder = this.ribbonTopToolBar1;
            this.rbnMain.RibbonEvent += rbnMain_RibbonEvent;
            // 
            // ramMain
            // 
            this.ramMain.BottomPaneItems.Add(this.rbtnOptions);
            this.ramMain.BottomPaneItems.Add(this.rbtnSaveAndExit);
            this.ramMain.BottomPaneItems.Add(this.rbtnCancelAndExit);
            this.ramMain.BottomPaneItems.Add(this.rbtnExit);
            this.ramMain.DropDownWidth = 450;
            this.ramMain.KeyTip = "F";
            this.ramMain.LargeImage = ((System.Drawing.Image)(resources.GetObject("ramMain.LargeImage")));
            this.ramMain.LeftPaneItems.Add(this.rbtnNew);
            this.ramMain.LeftPaneItems.Add(this.rbtnOpen);
            this.ramMain.LeftPaneItems.Add(this.rbtnClose);
            this.ramMain.LeftPaneItems.Add(this.rbtnSave);
            this.ramMain.LeftPaneItems.Add(this.rbtnSaveAs);
            this.ramMain.LeftPaneItems.Add(this.rbtnPreviewPrint);
            this.ramMain.LeftPaneItems.Add(this.ribbonSeparator1);
            this.ramMain.LeftPaneItems.Add(this.rbtnImport);
            this.ramMain.LeftPaneItems.Add(this.rbtnExport);
            this.ramMain.Name = "ramMain";
            this.ramMain.RightPaneItems.Add(this.ribbonListItem1);
            this.ramMain.RightPaneItems.Add(this.ribbonListItem2);
            this.ramMain.Text = "File";
            // 
            // rbtnOptions
            // 
            this.rbtnOptions.Name = "rbtnOptions";
            this.rbtnOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnOptions.SmallImage")));
            this.rbtnOptions.Text = "Op&tions...";
            this.rbtnOptions.ToolTip = "Options";
            // 
            // rbtnSaveAndExit
            // 
            this.rbtnSaveAndExit.Name = "rbtnSaveAndExit";
            this.rbtnSaveAndExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnSaveAndExit.SmallImage")));
            this.rbtnSaveAndExit.Text = "Save && Exit";
            this.rbtnSaveAndExit.ToolTip = "Save changes and exit";
            this.rbtnSaveAndExit.Visible = false;
            // 
            // rbtnCancelAndExit
            // 
            this.rbtnCancelAndExit.Name = "rbtnCancelAndExit";
            this.rbtnCancelAndExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnCancelAndExit.SmallImage")));
            this.rbtnCancelAndExit.Text = "Cancel && Exit";
            this.rbtnCancelAndExit.ToolTip = "Cancel changes and exit";
            this.rbtnCancelAndExit.Visible = false;
            // 
            // rbtnExit
            // 
            this.rbtnExit.Name = "rbtnExit";
            this.rbtnExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnExit.SmallImage")));
            this.rbtnExit.Text = "E&xit";
            this.rbtnExit.ToolTip = "Exit";
            // 
            // rbtnNew
            // 
            this.rbtnNew.LargeImage = global::FlexReportDesignerApp.Img_File.FileNew_32;
            this.rbtnNew.Name = "rbtnNew";
            this.rbtnNew.SmallImage = global::FlexReportDesignerApp.Img_File.FileNew_16;
            this.rbtnNew.Tag = "New";
            this.rbtnNew.Text = "&New";
            this.rbtnNew.ToolTip = resources.GetString("rbtnNew.ToolTip");
            // 
            // rbtnOpen
            // 
            this.rbtnOpen.LargeImage = global::FlexReportDesignerApp.Img_File.FileOpen_32;
            this.rbtnOpen.Name = "rbtnOpen";
            this.rbtnOpen.SmallImage = global::FlexReportDesignerApp.Img_File.FileOpen_16;
            this.rbtnOpen.Tag = "Open";
            this.rbtnOpen.Text = "&Open...";
            this.rbtnOpen.ToolTip = resources.GetString("rbtnOpen.ToolTip");
            // 
            // rbtnClose
            // 
            this.rbtnClose.LargeImage = global::FlexReportDesignerApp.Img_File.FileClose_32;
            this.rbtnClose.Name = "rbtnClose";
            this.rbtnClose.SmallImage = global::FlexReportDesignerApp.Img_File.FileClose_16;
            this.rbtnClose.Tag = "Close";
            this.rbtnClose.Text = "&Close";
            this.rbtnClose.ToolTip = resources.GetString("rbtnClose.ToolTip");
            // 
            // rbtnSave
            // 
            this.rbtnSave.LargeImage = global::FlexReportDesignerApp.Img_File.FileSave_32;
            this.rbtnSave.Name = "rbtnSave";
            this.rbtnSave.SmallImage = global::FlexReportDesignerApp.Img_File.FileSave_16;
            this.rbtnSave.Tag = "Save";
            this.rbtnSave.Text = "&Save";
            this.rbtnSave.ToolTip = resources.GetString("rbtnSave.ToolTip");
            // 
            // rbtnSaveAs
            // 
            this.rbtnSaveAs.LargeImage = global::FlexReportDesignerApp.Img_File.FileSaveAs_32;
            this.rbtnSaveAs.Name = "rbtnSaveAs";
            this.rbtnSaveAs.SmallImage = global::FlexReportDesignerApp.Img_File.FileSaveAs_16;
            this.rbtnSaveAs.Tag = "SaveAs";
            this.rbtnSaveAs.Text = "Save &As...";
            this.rbtnSaveAs.ToolTip = resources.GetString("rbtnSaveAs.ToolTip");
            // 
            // rbtnPreviewPrint
            // 
            this.rbtnPreviewPrint.LargeImage = global::FlexReportDesignerApp.Img_File.FilePrint_32;
            this.rbtnPreviewPrint.Name = "rbtnPreviewPrint";
            this.rbtnPreviewPrint.SmallImage = global::FlexReportDesignerApp.Img_File.FilePrint_16;
            this.rbtnPreviewPrint.Tag = "PreviewPrint";
            this.rbtnPreviewPrint.Text = "&Print";
            this.rbtnPreviewPrint.ToolTip = resources.GetString("rbtnPreviewPrint.ToolTip");
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // rbtnImport
            // 
            this.rbtnImport.LargeImage = global::FlexReportDesignerApp.Img_File.FileImport_32;
            this.rbtnImport.Name = "rbtnImport";
            this.rbtnImport.SmallImage = global::FlexReportDesignerApp.Img_File.FileImport_16;
            this.rbtnImport.Tag = "Import";
            this.rbtnImport.Text = "&Import...";
            this.rbtnImport.ToolTip = resources.GetString("rbtnImport.ToolTip");
            // 
            // rbtnExport
            // 
            this.rbtnExport.LargeImage = global::FlexReportDesignerApp.Img_File.FileExport_32;
            this.rbtnExport.Name = "rbtnExport";
            this.rbtnExport.SmallImage = global::FlexReportDesignerApp.Img_File.FileExport_16;
            this.rbtnExport.Tag = "Export";
            this.rbtnExport.Text = "&Export...";
            this.rbtnExport.ToolTip = resources.GetString("rbtnExport.ToolTip");
            // 
            // ribbonListItem1
            // 
            this.ribbonListItem1.AllowSelection = false;
            this.ribbonListItem1.Items.Add(this.ribbonLabel1);
            this.ribbonListItem1.Name = "ribbonListItem1";
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            this.ribbonLabel1.Text = "Recent files";
            // 
            // ribbonListItem2
            // 
            this.ribbonListItem2.Items.Add(this.ribbonSeparator2);
            this.ribbonListItem2.Name = "ribbonListItem2";
            // 
            // ribbonSeparator2
            // 
            this.ribbonSeparator2.Name = "ribbonSeparator2";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Items.Add(this.rbtnAbout);
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // rbtnAbout
            // 
            this.rbtnAbout.Items.Add(this.rbtnHelpContents);
            this.rbtnAbout.Items.Add(this.rbtnCheckForUpdates);
            this.rbtnAbout.Items.Add(this.ribbonSeparator15);
            this.rbtnAbout.Items.Add(this.rbtnAbout2);
            this.rbtnAbout.KeyTip = "I";
            this.rbtnAbout.Name = "rbtnAbout";
            this.rbtnAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnAbout.SmallImage")));
            this.rbtnAbout.ToolTip = "Help";
            // 
            // rbtnHelpContents
            // 
            this.rbtnHelpContents.Name = "rbtnHelpContents";
            this.rbtnHelpContents.Text = "Online &help...";
            // 
            // rbtnCheckForUpdates
            // 
            this.rbtnCheckForUpdates.Name = "rbtnCheckForUpdates";
            this.rbtnCheckForUpdates.Text = "Check for &updates";
            // 
            // ribbonSeparator15
            // 
            this.ribbonSeparator15.Name = "ribbonSeparator15";
            // 
            // rbtnAbout2
            // 
            this.rbtnAbout2.Name = "rbtnAbout2";
            this.rbtnAbout2.Text = "&About FlexReportDesigner...";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.HotItemLinks.Add(this.rbtnUndo);
            this.ribbonQat1.HotItemLinks.Add(this.rbtnRedo);
            this.ribbonQat1.HotItemLinks.Add(this.rbtnPaste);
            this.ribbonQat1.HotItemLinks.Add(this.rbtnCut);
            this.ribbonQat1.HotItemLinks.Add(this.rbtnCopy);
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // rbtnUndo
            // 
            this.rbtnUndo.KeyTip = "Z";
            this.rbtnUndo.Name = "rbtnUndo";
            this.rbtnUndo.SmallImage = global::FlexReportDesignerApp.Img_Home.Undo_16;
            this.rbtnUndo.Tag = "Undo";
            this.rbtnUndo.Text = "Undo";
            this.rbtnUndo.ToolTip = resources.GetString("rbtnUndo.ToolTip");
            // 
            // rbtnRedo
            // 
            this.rbtnRedo.KeyTip = "Y";
            this.rbtnRedo.Name = "rbtnRedo";
            this.rbtnRedo.SmallImage = global::FlexReportDesignerApp.Img_Home.Redo_16;
            this.rbtnRedo.Tag = "Redo";
            this.rbtnRedo.Text = "Redo";
            this.rbtnRedo.ToolTip = resources.GetString("rbtnRedo.ToolTip");
            // 
            // rbtnPaste
            // 
            this.rbtnPaste.KeyTip = "V";
            this.rbtnPaste.LargeImage = global::FlexReportDesignerApp.Img_Home.Paste_32;
            this.rbtnPaste.Name = "rbtnPaste";
            this.rbtnPaste.SmallImage = global::FlexReportDesignerApp.Img_Home.Paste_16;
            this.rbtnPaste.Tag = "Paste";
            this.rbtnPaste.Text = "Paste";
            this.rbtnPaste.ToolTip = resources.GetString("rbtnPaste.ToolTip");
            // 
            // rbtnCut
            // 
            this.rbtnCut.KeyTip = "X";
            this.rbtnCut.Name = "rbtnCut";
            this.rbtnCut.SmallImage = global::FlexReportDesignerApp.Img_Home.Cut_16;
            this.rbtnCut.Tag = "Cut";
            this.rbtnCut.Text = "Cut";
            this.rbtnCut.ToolTip = resources.GetString("rbtnCut.ToolTip");
            // 
            // rbtnCopy
            // 
            this.rbtnCopy.KeyTip = "C";
            this.rbtnCopy.Name = "rbtnCopy";
            this.rbtnCopy.SmallImage = global::FlexReportDesignerApp.Img_Home.Copy_16;
            this.rbtnCopy.Tag = "Copy";
            this.rbtnCopy.Text = "Copy";
            this.rbtnCopy.ToolTip = resources.GetString("rbtnCopy.ToolTip");
            // 
            // rtDesign
            // 
            this.rtDesign.Groups.Add(this.rgMode);
            this.rtDesign.Groups.Add(this.rgEdit);
            this.rtDesign.Groups.Add(this.rgFont);
            this.rtDesign.Groups.Add(this.rgBorder);
            this.rtDesign.Groups.Add(this.rgAutoFormat);
            this.rtDesign.Groups.Add(this.rgData);
            this.rtDesign.Groups.Add(this.rgTools);
            this.rtDesign.KeyTip = "H";
            this.rtDesign.Name = "rtDesign";
            this.rtDesign.Text = "HOME";
            // 
            // rgMode
            // 
            this.rgMode.GroupKeyTip = "M";
            this.rgMode.Items.Add(this.rbtnModeDesign);
            this.rgMode.Items.Add(this.rbtnModePreview);
            this.rgMode.Name = "rgMode";
            this.rgMode.Text = "Mode";
            // 
            // rbtnModeDesign
            // 
            this.rbtnModeDesign.CanDepress = false;
            this.rbtnModeDesign.KeyTip = "MD";
            this.rbtnModeDesign.LargeImage = global::FlexReportDesignerApp.Img_Home.Mode_Design_32;
            this.rbtnModeDesign.Name = "rbtnModeDesign";
            this.rbtnModeDesign.SmallImage = global::FlexReportDesignerApp.Img_Home.Mode_Design_16;
            this.rbtnModeDesign.Tag = "ModeDesign";
            this.rbtnModeDesign.Text = "Design";
            this.rbtnModeDesign.ToolTip = resources.GetString("rbtnModeDesign.ToolTip");
            // 
            // rbtnModePreview
            // 
            this.rbtnModePreview.CanDepress = false;
            this.rbtnModePreview.KeyTip = "MP";
            this.rbtnModePreview.LargeImage = global::FlexReportDesignerApp.Img_Home.Mode_Preview_32;
            this.rbtnModePreview.Name = "rbtnModePreview";
            this.rbtnModePreview.SmallImage = global::FlexReportDesignerApp.Img_Home.Mode_Preview_16;
            this.rbtnModePreview.Tag = "ModePreview";
            this.rbtnModePreview.Text = "Preview";
            this.rbtnModePreview.ToolTip = resources.GetString("rbtnModePreview.ToolTip");
            // 
            // rgEdit
            // 
            this.rgEdit.GroupKeyTip = "E";
            this.rgEdit.Image = ((System.Drawing.Image)(resources.GetObject("rgEdit.Image")));
            this.rgEdit.Items.Add(this.rbtnPaste);
            this.rgEdit.Items.Add(this.rbtnCut);
            this.rgEdit.Items.Add(this.rbtnCopy);
            this.rgEdit.Items.Add(this.rbtnDelete);
            this.rgEdit.Items.Add(this.ribbonSeparator3);
            this.rgEdit.Items.Add(this.rbtnUndo);
            this.rgEdit.Items.Add(this.rbtnRedo);
            this.rgEdit.Name = "rgEdit";
            this.rgEdit.Text = "Edit";
            // 
            // rbtnDelete
            // 
            this.rbtnDelete.KeyTip = "DD";
            this.rbtnDelete.Name = "rbtnDelete";
            this.rbtnDelete.SmallImage = global::FlexReportDesignerApp.Img_Home.Delete_16;
            this.rbtnDelete.Tag = "Delete";
            this.rbtnDelete.Text = "Delete";
            this.rbtnDelete.ToolTip = resources.GetString("rbtnDelete.ToolTip");
            // 
            // ribbonSeparator3
            // 
            this.ribbonSeparator3.Name = "ribbonSeparator3";
            // 
            // rgFont
            // 
            this.rgFont.GroupKeyTip = "T";
            this.rgFont.Image = ((System.Drawing.Image)(resources.GetObject("rgFont.Image")));
            this.rgFont.Items.Add(this.ribbonToolBar1);
            this.rgFont.Items.Add(this.ribbonToolBar2);
            this.rgFont.Name = "rgFont";
            this.rgFont.Text = "Text";
            // 
            // ribbonToolBar1
            // 
            this.ribbonToolBar1.Items.Add(this.rcbFontName);
            this.ribbonToolBar1.Items.Add(this.rcbFontSize);
            this.ribbonToolBar1.Items.Add(this.ribbonSeparator5);
            this.ribbonToolBar1.Items.Add(this.rbtnFontSizeUp);
            this.ribbonToolBar1.Items.Add(this.rbtnFontSizeDown);
            this.ribbonToolBar1.Name = "ribbonToolBar1";
            // 
            // rcbFontName
            // 
            this.rcbFontName.KeyTip = "FF";
            this.rcbFontName.MaxDropDownItems = 15;
            this.rcbFontName.Name = "rcbFontName";
            this.rcbFontName.Tag = "FontName";
            this.rcbFontName.TextAreaWidth = 108;
            this.rcbFontName.ToolTip = resources.GetString("rcbFontName.ToolTip");
            // 
            // rcbFontSize
            // 
            this.rcbFontSize.KeyTip = "FS";
            this.rcbFontSize.Name = "rcbFontSize";
            this.rcbFontSize.Tag = "FontSize";
            this.rcbFontSize.TextAreaWidth = 40;
            this.rcbFontSize.ToolTip = resources.GetString("rcbFontSize.ToolTip");
            // 
            // ribbonSeparator5
            // 
            this.ribbonSeparator5.HiddenMode = true;
            this.ribbonSeparator5.Name = "ribbonSeparator5";
            // 
            // rbtnFontSizeUp
            // 
            this.rbtnFontSizeUp.KeyTip = "FG";
            this.rbtnFontSizeUp.Name = "rbtnFontSizeUp";
            this.rbtnFontSizeUp.SmallImage = global::FlexReportDesignerApp.Img_Home.FontSizeUp_16;
            this.rbtnFontSizeUp.Tag = "FontSizeUp";
            this.rbtnFontSizeUp.ToolTip = resources.GetString("rbtnFontSizeUp.ToolTip");
            // 
            // rbtnFontSizeDown
            // 
            this.rbtnFontSizeDown.KeyTip = "FK";
            this.rbtnFontSizeDown.Name = "rbtnFontSizeDown";
            this.rbtnFontSizeDown.SmallImage = global::FlexReportDesignerApp.Img_Home.FontSizeDown_16;
            this.rbtnFontSizeDown.Tag = "FontSizeDown";
            this.rbtnFontSizeDown.ToolTip = resources.GetString("rbtnFontSizeDown.ToolTip");
            // 
            // ribbonToolBar2
            // 
            this.ribbonToolBar2.Items.Add(this.rbtnFontBold);
            this.ribbonToolBar2.Items.Add(this.rbtnFontItalic);
            this.ribbonToolBar2.Items.Add(this.rbtnFontUnderline);
            this.ribbonToolBar2.Items.Add(this.ribbonSeparator8);
            this.ribbonToolBar2.Items.Add(this.rbtnTextAlignGeneral);
            this.ribbonToolBar2.Items.Add(this.rbtnTextAlignLeft);
            this.ribbonToolBar2.Items.Add(this.rbtnTextAlignCenter);
            this.ribbonToolBar2.Items.Add(this.rbtnTextAlignRight);
            this.ribbonToolBar2.Items.Add(this.rbtnTextAlignJustify);
            this.ribbonToolBar2.Items.Add(this.ribbonSeparator4);
            this.ribbonToolBar2.Items.Add(this.rbtnTextColor);
            this.ribbonToolBar2.Items.Add(this.rbtnFillColor);
            this.ribbonToolBar2.Name = "ribbonToolBar2";
            // 
            // rbtnFontBold
            // 
            this.rbtnFontBold.KeyTip = "1";
            this.rbtnFontBold.Name = "rbtnFontBold";
            this.rbtnFontBold.SmallImage = global::FlexReportDesignerApp.Img_Home.TextBold_16;
            this.rbtnFontBold.Tag = "FontBold";
            this.rbtnFontBold.ToolTip = resources.GetString("rbtnFontBold.ToolTip");
            // 
            // rbtnFontItalic
            // 
            this.rbtnFontItalic.KeyTip = "2";
            this.rbtnFontItalic.Name = "rbtnFontItalic";
            this.rbtnFontItalic.SmallImage = global::FlexReportDesignerApp.Img_Home.TextItalic_16;
            this.rbtnFontItalic.Tag = "FontItalic";
            this.rbtnFontItalic.ToolTip = resources.GetString("rbtnFontItalic.ToolTip");
            // 
            // rbtnFontUnderline
            // 
            this.rbtnFontUnderline.KeyTip = "3";
            this.rbtnFontUnderline.Name = "rbtnFontUnderline";
            this.rbtnFontUnderline.SmallImage = global::FlexReportDesignerApp.Img_Home.TextUnderline_16;
            this.rbtnFontUnderline.Tag = "FontUnderline";
            this.rbtnFontUnderline.ToolTip = resources.GetString("rbtnFontUnderline.ToolTip");
            // 
            // ribbonSeparator8
            // 
            this.ribbonSeparator8.Name = "ribbonSeparator8";
            // 
            // rbtnTextAlignGeneral
            // 
            this.rbtnTextAlignGeneral.KeyTip = "AG";
            this.rbtnTextAlignGeneral.Name = "rbtnTextAlignGeneral";
            this.rbtnTextAlignGeneral.SmallImage = global::FlexReportDesignerApp.Img_Home.TextAlignGeneral_16;
            this.rbtnTextAlignGeneral.Tag = "TextAlignGeneral";
            this.rbtnTextAlignGeneral.ToolTip = resources.GetString("rbtnTextAlignGeneral.ToolTip");
            // 
            // rbtnTextAlignLeft
            // 
            this.rbtnTextAlignLeft.KeyTip = "AL";
            this.rbtnTextAlignLeft.Name = "rbtnTextAlignLeft";
            this.rbtnTextAlignLeft.SmallImage = global::FlexReportDesignerApp.Img_Home.TextAlignLeft_16;
            this.rbtnTextAlignLeft.Tag = "TextAlignLeft";
            this.rbtnTextAlignLeft.ToolTip = resources.GetString("rbtnTextAlignLeft.ToolTip");
            // 
            // rbtnTextAlignCenter
            // 
            this.rbtnTextAlignCenter.KeyTip = "AC";
            this.rbtnTextAlignCenter.Name = "rbtnTextAlignCenter";
            this.rbtnTextAlignCenter.SmallImage = global::FlexReportDesignerApp.Img_Home.TextAlignCenter_16;
            this.rbtnTextAlignCenter.Tag = "TextAlignCenter";
            this.rbtnTextAlignCenter.ToolTip = resources.GetString("rbtnTextAlignCenter.ToolTip");
            // 
            // rbtnTextAlignRight
            // 
            this.rbtnTextAlignRight.KeyTip = "AR";
            this.rbtnTextAlignRight.Name = "rbtnTextAlignRight";
            this.rbtnTextAlignRight.SmallImage = global::FlexReportDesignerApp.Img_Home.TextAlignRight_16;
            this.rbtnTextAlignRight.Tag = "TextAlignRight";
            this.rbtnTextAlignRight.ToolTip = resources.GetString("rbtnTextAlignRight.ToolTip");
            // 
            // rbtnTextAlignJustify
            // 
            this.rbtnTextAlignJustify.KeyTip = "AJ";
            this.rbtnTextAlignJustify.Name = "rbtnTextAlignJustify";
            this.rbtnTextAlignJustify.SmallImage = global::FlexReportDesignerApp.Img_Home.TextJustify_16;
            this.rbtnTextAlignJustify.Tag = "TextAlignJustify";
            this.rbtnTextAlignJustify.ToolTip = resources.GetString("rbtnTextAlignJustify.ToolTip");
            // 
            // ribbonSeparator4
            // 
            this.ribbonSeparator4.Name = "ribbonSeparator4";
            // 
            // rbtnTextColor
            // 
            this.rbtnTextColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rbtnTextColor.KeyTip = "FC";
            this.rbtnTextColor.Name = "rbtnTextColor";
            this.rbtnTextColor.SmallImage = global::FlexReportDesignerApp.Img_Home.FontColor_16;
            this.rbtnTextColor.Tag = "TextColor";
            this.rbtnTextColor.ToolTip = resources.GetString("rbtnTextColor.ToolTip");
            // 
            // rbtnFillColor
            // 
            this.rbtnFillColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rbtnFillColor.KeyTip = "FL";
            this.rbtnFillColor.Name = "rbtnFillColor";
            this.rbtnFillColor.SmallImage = global::FlexReportDesignerApp.Img_Home.BackgroundColor_16;
            this.rbtnFillColor.Tag = "FillColor";
            this.rbtnFillColor.ToolTip = resources.GetString("rbtnFillColor.ToolTip");
            // 
            // rgBorder
            // 
            this.rgBorder.GroupKeyTip = "B";
            this.rgBorder.HasLauncherButton = true;
            this.rgBorder.Items.Add(this.rgalBorderStyle);
            this.rgBorder.Items.Add(this.ribbonSeparator18);
            this.rgBorder.Items.Add(this.ribbonToolBar5);
            this.rgBorder.Items.Add(this.ribbonToolBar6);
            this.rgBorder.LauncherKeyTip = "BB";
            this.rgBorder.Name = "rgBorder";
            this.rgBorder.Text = "Border";
            this.rgBorder.DialogLauncherClick += new System.EventHandler(this.rgBorder_DialogLauncherClick);
            // 
            // rgalBorderStyle
            // 
            this.rgalBorderStyle.Items.Add(this.rgiBorderStyleSolid);
            this.rgalBorderStyle.Items.Add(this.rgiBorderStyleDash);
            this.rgalBorderStyle.Items.Add(this.rgiBorderStyleDot);
            this.rgalBorderStyle.Items.Add(this.rgiBorderStyleDashDot);
            this.rgalBorderStyle.Items.Add(this.rgiBorderStyleDashDotDot);
            this.rgalBorderStyle.Items.Add(this.rgiBorderStyleNone);
            this.rgalBorderStyle.ItemSize = new System.Drawing.Size(40, 30);
            this.rgalBorderStyle.KeyTip = "BL";
            this.rgalBorderStyle.Name = "rgalBorderStyle";
            this.rgalBorderStyle.SmallImage = ((System.Drawing.Image)(resources.GetObject("rgalBorderStyle.SmallImage")));
            this.rgalBorderStyle.SupportedGroupSizing = C1.Win.Ribbon.SupportedGroupSizing.LargeImageOnly;
            this.rgalBorderStyle.Tag = "BorderStyle";
            this.rgalBorderStyle.Text = "Border style";
            this.rgalBorderStyle.ToolTip = resources.GetString("rgalBorderStyle.ToolTip");
            // 
            // rgiBorderStyleSolid
            // 
            this.rgiBorderStyleSolid.LargeImage = ((System.Drawing.Image)(resources.GetObject("rgiBorderStyleSolid.LargeImage")));
            this.rgiBorderStyleSolid.Name = "rgiBorderStyleSolid";
            this.rgiBorderStyleSolid.Tag = "BorderStyleSolid";
            this.rgiBorderStyleSolid.ToolTip = "Border Style: <b>Solid</b>";
            // 
            // rgiBorderStyleDash
            // 
            this.rgiBorderStyleDash.LargeImage = ((System.Drawing.Image)(resources.GetObject("rgiBorderStyleDash.LargeImage")));
            this.rgiBorderStyleDash.Name = "rgiBorderStyleDash";
            this.rgiBorderStyleDash.Tag = "BorderStyleDash";
            this.rgiBorderStyleDash.ToolTip = "Border Style: <b>Dash</b>";
            // 
            // rgiBorderStyleDot
            // 
            this.rgiBorderStyleDot.LargeImage = ((System.Drawing.Image)(resources.GetObject("rgiBorderStyleDot.LargeImage")));
            this.rgiBorderStyleDot.Name = "rgiBorderStyleDot";
            this.rgiBorderStyleDot.Tag = "BorderStyleDot";
            this.rgiBorderStyleDot.ToolTip = "Border Style: <b>Dot</b>";
            // 
            // rgiBorderStyleDashDot
            // 
            this.rgiBorderStyleDashDot.LargeImage = ((System.Drawing.Image)(resources.GetObject("rgiBorderStyleDashDot.LargeImage")));
            this.rgiBorderStyleDashDot.Name = "rgiBorderStyleDashDot";
            this.rgiBorderStyleDashDot.Tag = "BorderStyleDashDot";
            this.rgiBorderStyleDashDot.ToolTip = "Border Style: <b>Dash-Dot</b>";
            // 
            // rgiBorderStyleDashDotDot
            // 
            this.rgiBorderStyleDashDotDot.LargeImage = ((System.Drawing.Image)(resources.GetObject("rgiBorderStyleDashDotDot.LargeImage")));
            this.rgiBorderStyleDashDotDot.Name = "rgiBorderStyleDashDotDot";
            this.rgiBorderStyleDashDotDot.Tag = "BorderStyleDashDotDot";
            this.rgiBorderStyleDashDotDot.ToolTip = "Border Style: <b>Dash-Dot-Dot</b>";
            // 
            // rgiBorderStyleNone
            // 
            this.rgiBorderStyleNone.Name = "rgiBorderStyleNone";
            this.rgiBorderStyleNone.Tag = "BorderStyleNone";
            this.rgiBorderStyleNone.Text = "None";
            this.rgiBorderStyleNone.ToolTip = "Border Style: <b>Transparent</b>";
            // 
            // ribbonSeparator18
            // 
            this.ribbonSeparator18.HiddenMode = true;
            this.ribbonSeparator18.Name = "ribbonSeparator18";
            // 
            // ribbonToolBar5
            // 
            this.ribbonToolBar5.Items.Add(this.rclrBorderColor);
            this.ribbonToolBar5.Name = "ribbonToolBar5";
            // 
            // rclrBorderColor
            // 
            this.rclrBorderColor.DefaultColor = System.Drawing.Color.Black;
            this.rclrBorderColor.KeyTip = "BC";
            this.rclrBorderColor.Name = "rclrBorderColor";
            this.rclrBorderColor.SmallImage = global::FlexReportDesignerApp.Img_Home.LineColor_16;
            this.rclrBorderColor.Tag = "BorderColor";
            this.rclrBorderColor.ToolTip = resources.GetString("rclrBorderColor.ToolTip");
            // 
            // ribbonToolBar6
            // 
            this.ribbonToolBar6.Items.Add(this.rcmbBorderWidth);
            this.ribbonToolBar6.Name = "ribbonToolBar6";
            // 
            // rcmbBorderWidth
            // 
            this.rcmbBorderWidth.KeyTip = "BW";
            this.rcmbBorderWidth.MaxDropDownItems = 12;
            this.rcmbBorderWidth.MaxLength = 40;
            this.rcmbBorderWidth.Name = "rcmbBorderWidth";
            this.rcmbBorderWidth.Tag = "BorderWidth";
            this.rcmbBorderWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rcmbBorderWidth.TextAreaWidth = 30;
            this.rcmbBorderWidth.ToolTip = resources.GetString("rcmbBorderWidth.ToolTip");
            this.rcmbBorderWidth.ChangeCommitted += new System.EventHandler(this.rcmbBorderWidth_ChangeCommitted);
            // 
            // rgAutoFormat
            // 
            this.rgAutoFormat.GroupKeyTip = "F";
            this.rgAutoFormat.Image = ((System.Drawing.Image)(resources.GetObject("rgAutoFormat.Image")));
            this.rgAutoFormat.Items.Add(this.rbtnStyles);
            this.rgAutoFormat.Items.Add(this.ribbonSeparator6);
            this.rgAutoFormat.Items.Add(this.rbtnApplyStyleToSelection);
            this.rgAutoFormat.Items.Add(this.rbtnFormatAsTableRow);
            this.rgAutoFormat.Name = "rgAutoFormat";
            this.rgAutoFormat.Text = "Format";
            // 
            // rbtnStyles
            // 
            this.rbtnStyles.KeyTip = "S";
            this.rbtnStyles.LargeImage = global::FlexReportDesignerApp.Img_Home.ReportStyle_32;
            this.rbtnStyles.Name = "rbtnStyles";
            this.rbtnStyles.SmallImage = global::FlexReportDesignerApp.Img_Home.ReportStyle_16;
            this.rbtnStyles.Tag = "Styles";
            this.rbtnStyles.Text = "Report Styles";
            this.rbtnStyles.ToolTip = resources.GetString("rbtnStyles.ToolTip");
            // 
            // ribbonSeparator6
            // 
            this.ribbonSeparator6.Name = "ribbonSeparator6";
            // 
            // rbtnApplyStyleToSelection
            // 
            this.rbtnApplyStyleToSelection.KeyTip = "FP";
            this.rbtnApplyStyleToSelection.Name = "rbtnApplyStyleToSelection";
            this.rbtnApplyStyleToSelection.SmallImage = global::FlexReportDesignerApp.Img_Home.FormatPainter_16;
            this.rbtnApplyStyleToSelection.Tag = "ApplyStyleToSelection";
            this.rbtnApplyStyleToSelection.Text = "Format Painter";
            this.rbtnApplyStyleToSelection.ToolTip = resources.GetString("rbtnApplyStyleToSelection.ToolTip");
            // 
            // rbtnFormatAsTableRow
            // 
            this.rbtnFormatAsTableRow.KeyTip = "FT";
            this.rbtnFormatAsTableRow.Name = "rbtnFormatAsTableRow";
            this.rbtnFormatAsTableRow.SmallImage = global::FlexReportDesignerApp.Img_Home.FormatAsTableRow_16;
            this.rbtnFormatAsTableRow.Tag = "FormatAsTableRow";
            this.rbtnFormatAsTableRow.Text = "As Table Row";
            this.rbtnFormatAsTableRow.ToolTip = resources.GetString("rbtnFormatAsTableRow.ToolTip");
            // 
            // rgData
            // 
            this.rgData.GroupKeyTip = "D";
            this.rgData.Image = ((System.Drawing.Image)(resources.GetObject("rgData.Image")));
            this.rgData.Items.Add(this.rbtnDataSources);
            this.rgData.Items.Add(this.rbtnGroupSort);
            this.rgData.Items.Add(this.rbtnReportInfo);
            this.rgData.Items.Add(this.ribbonSeparator21);
            this.rgData.Items.Add(this.rbtnScriptEditor);
            this.rgData.Name = "rgData";
            this.rgData.Text = "Data";
            // 
            // rbtnDataSources
            // 
            this.rbtnDataSources.Items.Add(this.ribbonSeparator22);
            this.rbtnDataSources.Items.Add(this.rbtnDataSourcesAdd);
            this.rbtnDataSources.KeyTip = "DS";
            this.rbtnDataSources.LargeImage = global::FlexReportDesignerApp.Img_Home.DataSource_32;
            this.rbtnDataSources.Name = "rbtnDataSources";
            this.rbtnDataSources.SmallImage = global::FlexReportDesignerApp.Img_Home.DataSource_16;
            this.rbtnDataSources.Tag = "DataSources";
            this.rbtnDataSources.Text = "Data Sources";
            this.rbtnDataSources.ToolTip = resources.GetString("rbtnDataSources.ToolTip");
            // 
            // ribbonSeparator22
            // 
            this.ribbonSeparator22.Name = "ribbonSeparator22";
            // 
            // rbtnDataSourcesAdd
            // 
            this.chMain.SetC1Command(this.rbtnDataSourcesAdd, this.cAddDataSource);
            this.rbtnDataSourcesAdd.Name = "rbtnDataSourcesAdd";
            this.rbtnDataSourcesAdd.Text = "Add Data Source...";
            // 
            // rbtnGroupSort
            // 
            this.rbtnGroupSort.KeyTip = "DG";
            this.rbtnGroupSort.LargeImage = global::FlexReportDesignerApp.Img_Home.Groups_32;
            this.rbtnGroupSort.Name = "rbtnGroupSort";
            this.rbtnGroupSort.SmallImage = global::FlexReportDesignerApp.Img_Home.Groups_16;
            this.rbtnGroupSort.Tag = "GroupSort";
            this.rbtnGroupSort.Text = "Groups";
            this.rbtnGroupSort.ToolTip = resources.GetString("rbtnGroupSort.ToolTip");
            // 
            // rbtnReportInfo
            // 
            this.rbtnReportInfo.KeyTip = "DI";
            this.rbtnReportInfo.LargeImage = global::FlexReportDesignerApp.Img_Home.ReportInfo_32;
            this.rbtnReportInfo.Name = "rbtnReportInfo";
            this.rbtnReportInfo.SmallImage = global::FlexReportDesignerApp.Img_Home.ReportInfo_16;
            this.rbtnReportInfo.Tag = "ReportInfo";
            this.rbtnReportInfo.Text = "Report Info";
            this.rbtnReportInfo.ToolTip = resources.GetString("rbtnReportInfo.ToolTip");
            // 
            // ribbonSeparator21
            // 
            this.ribbonSeparator21.Name = "ribbonSeparator21";
            // 
            // rbtnScriptEditor
            // 
            this.rbtnScriptEditor.CanDepress = false;
            this.rbtnScriptEditor.KeyTip = "DE";
            this.rbtnScriptEditor.LargeImage = global::FlexReportDesignerApp.Img_Home.ScriptEditor_32;
            this.rbtnScriptEditor.Name = "rbtnScriptEditor";
            this.rbtnScriptEditor.SmallImage = global::FlexReportDesignerApp.Img_Home.ScriptEditor_16;
            this.rbtnScriptEditor.Tag = "ScriptEditor";
            this.rbtnScriptEditor.Text = "VBScript Editor";
            this.rbtnScriptEditor.ToolTip = resources.GetString("rbtnScriptEditor.ToolTip");
            // 
            // rgTools
            // 
            this.rgTools.GroupKeyTip = "V";
            this.rgTools.Image = ((System.Drawing.Image)(resources.GetObject("rgTools.Image")));
            this.rgTools.Items.Add(this.rbtnShowPropertyGrid);
            this.rgTools.Items.Add(this.rbtnShowDataTree);
            this.rgTools.Items.Add(this.rbtnShowErrorList);
            this.rgTools.Items.Add(this.ribbonSeparator29);
            this.rgTools.Items.Add(this.rbmCaptionsVisibility);
            this.rgTools.Name = "rgTools";
            this.rgTools.Text = "View";
            // 
            // rbtnShowPropertyGrid
            // 
            this.rbtnShowPropertyGrid.KeyTip = "PG";
            this.rbtnShowPropertyGrid.LargeImage = global::FlexReportDesignerApp.Img_Home.ViewProperties_32;
            this.rbtnShowPropertyGrid.Name = "rbtnShowPropertyGrid";
            this.rbtnShowPropertyGrid.SmallImage = global::FlexReportDesignerApp.Img_Home.ViewProperties_16;
            this.rbtnShowPropertyGrid.Tag = "ShowPropertyGrid";
            this.rbtnShowPropertyGrid.Text = "Properties";
            this.rbtnShowPropertyGrid.ToolTip = resources.GetString("rbtnShowPropertyGrid.ToolTip");
            // 
            // rbtnShowDataTree
            // 
            this.rbtnShowDataTree.KeyTip = "PF";
            this.rbtnShowDataTree.LargeImage = global::FlexReportDesignerApp.Img_Home.ViewData_32;
            this.rbtnShowDataTree.Name = "rbtnShowDataTree";
            this.rbtnShowDataTree.SmallImage = global::FlexReportDesignerApp.Img_Home.ViewData_16;
            this.rbtnShowDataTree.Tag = "ShowDataTree";
            this.rbtnShowDataTree.Text = "Data";
            this.rbtnShowDataTree.ToolTip = resources.GetString("rbtnShowDataTree.ToolTip");
            // 
            // rbtnShowErrorList
            // 
            this.rbtnShowErrorList.KeyTip = "PE";
            this.rbtnShowErrorList.LargeImage = global::FlexReportDesignerApp.Img_Home.ViewErrorList_32;
            this.rbtnShowErrorList.Name = "rbtnShowErrorList";
            this.rbtnShowErrorList.SmallImage = global::FlexReportDesignerApp.Img_Home.ViewErrorList_16;
            this.rbtnShowErrorList.Tag = "ShowErrorList";
            this.rbtnShowErrorList.Text = "Error List";
            this.rbtnShowErrorList.ToolTip = resources.GetString("rbtnShowErrorList.ToolTip");
            // 
            // ribbonSeparator29
            // 
            this.ribbonSeparator29.Name = "ribbonSeparator29";
            // 
            // rbmCaptionsVisibility
            // 
            this.rbmCaptionsVisibility.Items.Add(this.rbtnCaptionsVisibilityAll);
            this.rbmCaptionsVisibility.Items.Add(this.rbtnCaptionsVisibilitySection);
            this.rbmCaptionsVisibility.Items.Add(this.rbtnCaptionsVisibilityHairline);
            this.rbmCaptionsVisibility.Items.Add(this.rbtnCaptionsVisibilityHidden);
            this.rbmCaptionsVisibility.Items.Add(this.ribbonSeparator23);
            this.rbmCaptionsVisibility.Items.Add(this.rbtnCaptionsExpandAll);
            this.rbmCaptionsVisibility.Items.Add(this.rbtnCaptionsCollapseAll);
            this.rbmCaptionsVisibility.KeyTip = "PC";
            this.rbmCaptionsVisibility.LargeImage = global::FlexReportDesignerApp.Img_Home.ViewCaptions_32;
            this.rbmCaptionsVisibility.Name = "rbmCaptionsVisibility";
            this.rbmCaptionsVisibility.SmallImage = global::FlexReportDesignerApp.Img_Home.ViewCaptions_16;
            this.rbmCaptionsVisibility.Tag = "CaptionsVisibility";
            this.rbmCaptionsVisibility.Text = "Captions";
            this.rbmCaptionsVisibility.ToolTip = resources.GetString("rbmCaptionsVisibility.ToolTip");
            // 
            // rbtnCaptionsVisibilityAll
            // 
            this.rbtnCaptionsVisibilityAll.Name = "rbtnCaptionsVisibilityAll";
            this.rbtnCaptionsVisibilityAll.Tag = "CaptionsVisibilityAll";
            this.rbtnCaptionsVisibilityAll.Text = "All";
            // 
            // rbtnCaptionsVisibilitySection
            // 
            this.rbtnCaptionsVisibilitySection.Name = "rbtnCaptionsVisibilitySection";
            this.rbtnCaptionsVisibilitySection.Tag = "CaptionsVisibilitySection";
            this.rbtnCaptionsVisibilitySection.Text = "Section";
            // 
            // rbtnCaptionsVisibilityHairline
            // 
            this.rbtnCaptionsVisibilityHairline.Name = "rbtnCaptionsVisibilityHairline";
            this.rbtnCaptionsVisibilityHairline.Tag = "CaptionsVisibilityHairline";
            this.rbtnCaptionsVisibilityHairline.Text = "Hairline";
            // 
            // rbtnCaptionsVisibilityHidden
            // 
            this.rbtnCaptionsVisibilityHidden.Name = "rbtnCaptionsVisibilityHidden";
            this.rbtnCaptionsVisibilityHidden.Tag = "CaptionsVisibilityHidden";
            this.rbtnCaptionsVisibilityHidden.Text = "Hidden";
            // 
            // ribbonSeparator23
            // 
            this.ribbonSeparator23.Name = "ribbonSeparator23";
            // 
            // rbtnCaptionsExpandAll
            // 
            this.rbtnCaptionsExpandAll.Name = "rbtnCaptionsExpandAll";
            this.rbtnCaptionsExpandAll.Tag = "CaptionsExpandAll";
            this.rbtnCaptionsExpandAll.Text = "&Expand All";
            // 
            // rbtnCaptionsCollapseAll
            // 
            this.rbtnCaptionsCollapseAll.Name = "rbtnCaptionsCollapseAll";
            this.rbtnCaptionsCollapseAll.Tag = "CaptionsCollapseAll";
            this.rbtnCaptionsCollapseAll.Text = "&Collapse All";
            // 
            // rtInsert
            // 
            this.rtInsert.Groups.Add(this.rgFields);
            this.rtInsert.Groups.Add(this.rgSubSection);
            this.rtInsert.Groups.Add(this.rgCustomFields);
            this.rtInsert.KeyTip = "N";
            this.rtInsert.Name = "rtInsert";
            this.rtInsert.Text = "INSERT";
            // 
            // rgFields
            // 
            this.rgFields.GroupKeyTip = "F";
            this.rgFields.Image = ((System.Drawing.Image)(resources.GetObject("rgFields.Image")));
            this.rgFields.Items.Add(this.rbtnFieldArrow);
            this.rgFields.Items.Add(this.ribbonSeparator12);
            this.rgFields.Items.Add(this.rbtnFieldDataField);
            this.rgFields.Items.Add(this.rbtnFieldRtf);
            this.rgFields.Items.Add(this.rbtnFieldParagraph);
            this.rgFields.Items.Add(this.rbtnFieldCheckBox);
            this.rgFields.Items.Add(this.rbtnFieldBarCode);
            this.rgFields.Items.Add(this.rbtnFieldCalculated);
            this.rgFields.Items.Add(this.rbtnFieldPicture);
            this.rgFields.Items.Add(this.rbtnFieldShape);
            this.rgFields.Items.Add(this.rbtnFieldSubReport);
            this.rgFields.Items.Add(this.rbtnFieldFlexChart);
            this.rgFields.Items.Add(this.rbtnFieldLegacy);
            this.rgFields.Items.Add(this.rbtnFieldChart);
            this.rgFields.Name = "rgFields";
            this.rgFields.Text = "Fields";
            // 
            // rbtnFieldArrow
            // 
            this.rbtnFieldArrow.KeyTip = "A";
            this.rbtnFieldArrow.LargeImage = global::FlexReportDesignerApp.Img_Insert.Arrow_32;
            this.rbtnFieldArrow.Name = "rbtnFieldArrow";
            this.rbtnFieldArrow.SmallImage = global::FlexReportDesignerApp.Img_Insert.Arrow_16;
            this.rbtnFieldArrow.Text = "Arrow";
            this.rbtnFieldArrow.ToolTip = resources.GetString("rbtnFieldArrow.ToolTip");
            // 
            // ribbonSeparator12
            // 
            this.ribbonSeparator12.Name = "ribbonSeparator12";
            // 
            // rbtnFieldDataField
            // 
            this.rbtnFieldDataField.KeyTip = "T";
            this.rbtnFieldDataField.LargeImage = global::FlexReportDesignerApp.Img_Insert.FldText_32;
            this.rbtnFieldDataField.Name = "rbtnFieldDataField";
            this.rbtnFieldDataField.SmallImage = global::FlexReportDesignerApp.Img_Insert.FldText_16;
            this.rbtnFieldDataField.Text = "Text";
            this.rbtnFieldDataField.ToolTip = resources.GetString("rbtnFieldDataField.ToolTip");
            // 
            // rbtnFieldRtf
            // 
            this.rbtnFieldRtf.KeyTip = "ET";
            this.rbtnFieldRtf.LargeImage = global::FlexReportDesignerApp.Img_Insert.FldRTF_32;
            this.rbtnFieldRtf.Name = "rbtnFieldRtf";
            this.rbtnFieldRtf.SmallImage = global::FlexReportDesignerApp.Img_Insert.FldRTF_16;
            this.rbtnFieldRtf.Text = "RTF";
            this.rbtnFieldRtf.ToolTip = resources.GetString("rbtnFieldRtf.ToolTip");
            // 
            // rbtnFieldParagraph
            // 
            this.rbtnFieldParagraph.KeyTip = "P";
            this.rbtnFieldParagraph.LargeImage = global::FlexReportDesignerApp.Img_Insert.FldParagraph_32;
            this.rbtnFieldParagraph.Name = "rbtnFieldParagraph";
            this.rbtnFieldParagraph.SmallImage = global::FlexReportDesignerApp.Img_Insert.FldParagraph_16;
            this.rbtnFieldParagraph.Text = "Paragraph";
            this.rbtnFieldParagraph.ToolTip = resources.GetString("rbtnFieldParagraph.ToolTip");
            // 
            // rbtnFieldCheckBox
            // 
            this.rbtnFieldCheckBox.KeyTip = "C";
            this.rbtnFieldCheckBox.LargeImage = global::FlexReportDesignerApp.Img_Insert.FldCheckbox_32;
            this.rbtnFieldCheckBox.Name = "rbtnFieldCheckBox";
            this.rbtnFieldCheckBox.SmallImage = global::FlexReportDesignerApp.Img_Insert.FldCheckbox_16;
            this.rbtnFieldCheckBox.Text = "Checkbox";
            this.rbtnFieldCheckBox.ToolTip = resources.GetString("rbtnFieldCheckBox.ToolTip");
            // 
            // rbtnFieldBarCode
            // 
            this.rbtnFieldBarCode.KeyTip = "B";
            this.rbtnFieldBarCode.LargeImage = global::FlexReportDesignerApp.Img_Insert.FldBarcode_32;
            this.rbtnFieldBarCode.Name = "rbtnFieldBarCode";
            this.rbtnFieldBarCode.SmallImage = global::FlexReportDesignerApp.Img_Insert.FldBarcode_16;
            this.rbtnFieldBarCode.Text = "Barcode";
            this.rbtnFieldBarCode.ToolTip = resources.GetString("rbtnFieldBarCode.ToolTip");
            // 
            // rbtnFieldCalculated
            // 
            this.rbtnFieldCalculated.KeyTip = "F";
            this.rbtnFieldCalculated.LargeImage = global::FlexReportDesignerApp.Img_Insert.FldCalculated_32;
            this.rbtnFieldCalculated.Name = "rbtnFieldCalculated";
            this.rbtnFieldCalculated.SmallImage = global::FlexReportDesignerApp.Img_Insert.FldCalculated_16;
            this.rbtnFieldCalculated.Text = "Calculated";
            this.rbtnFieldCalculated.ToolTip = resources.GetString("rbtnFieldCalculated.ToolTip");
            // 
            // rbtnFieldPicture
            // 
            this.rbtnFieldPicture.KeyTip = "I";
            this.rbtnFieldPicture.LargeImage = global::FlexReportDesignerApp.Img_Insert.FldImage_32;
            this.rbtnFieldPicture.Name = "rbtnFieldPicture";
            this.rbtnFieldPicture.SmallImage = global::FlexReportDesignerApp.Img_Insert.FldImage_16;
            this.rbtnFieldPicture.Text = "Image";
            this.rbtnFieldPicture.ToolTip = resources.GetString("rbtnFieldPicture.ToolTip");
            // 
            // rbtnFieldShape
            // 
            this.rbtnFieldShape.KeyTip = "H";
            this.rbtnFieldShape.LargeImage = global::FlexReportDesignerApp.Img_Insert.FldShape_32;
            this.rbtnFieldShape.Name = "rbtnFieldShape";
            this.rbtnFieldShape.SmallImage = global::FlexReportDesignerApp.Img_Insert.FldShape_16;
            this.rbtnFieldShape.Text = "Shape";
            this.rbtnFieldShape.ToolTip = resources.GetString("rbtnFieldShape.ToolTip");
            // 
            // rbtnFieldSubReport
            // 
            this.rbtnFieldSubReport.KeyTip = "R";
            this.rbtnFieldSubReport.LargeImage = global::FlexReportDesignerApp.Img_Insert.FldSubReport_32;
            this.rbtnFieldSubReport.Name = "rbtnFieldSubReport";
            this.rbtnFieldSubReport.SmallImage = global::FlexReportDesignerApp.Img_Insert.FldSubReport_16;
            this.rbtnFieldSubReport.Text = "Subreport";
            this.rbtnFieldSubReport.ToolTip = resources.GetString("rbtnFieldSubReport.ToolTip");
            // 
            // rbtnFieldChart
            // 
            this.rbtnFieldChart.KeyTip = "LC";
            this.rbtnFieldChart.LargeImage = global::FlexReportDesignerApp.Img_Insert.FldChart_32;
            this.rbtnFieldChart.Name = "rbtnFieldChart";
            this.rbtnFieldChart.SmallImage = global::FlexReportDesignerApp.Img_Insert.FldChart_16;
            this.rbtnFieldChart.Text = "Legacy Chart";
            this.rbtnFieldChart.ToolTip = resources.GetString("rbtnFieldChart.ToolTip");
            // 
            // rbtnFieldLegacy
            // 
            this.rbtnFieldLegacy.CanBeAddedToQat = false;
            this.rbtnFieldLegacy.KeyTip = "LF";
            this.rbtnFieldLegacy.LargeImage = global::FlexReportDesignerApp.Img_Insert.FldLegacy_32;
            this.rbtnFieldLegacy.Name = "rbtnFieldLegacy";
            this.rbtnFieldLegacy.SmallImage = global::FlexReportDesignerApp.Img_Insert.FldLegacy_16;
            this.rbtnFieldLegacy.Text = "Legacy Field";
            this.rbtnFieldLegacy.ToolTip = resources.GetString("rbtnFieldLegacy.ToolTip");
            // 
            // rgSubSection
            // 
            this.rgSubSection.GroupKeyTip = "S";
            this.rgSubSection.Items.Add(this.rbtnSubSectionAdd);
            this.rgSubSection.Items.Add(this.rbtnSubSectionRemove);
            this.rgSubSection.Items.Add(this.rbtnSubSectionMoveUp);
            this.rgSubSection.Items.Add(this.rbtnSubSectionMoveDown);
            this.rgSubSection.Name = "rgSubSection";
            this.rgSubSection.Text = "SubSection";
            // 
            // rbtnSubSectionAdd
            // 
            this.rbtnSubSectionAdd.KeyTip = "SA";
            this.rbtnSubSectionAdd.LargeImage = global::FlexReportDesignerApp.Img_Insert.BandAdd_32;
            this.rbtnSubSectionAdd.Name = "rbtnSubSectionAdd";
            this.rbtnSubSectionAdd.SmallImage = global::FlexReportDesignerApp.Img_Insert.BandAdd_16;
            this.rbtnSubSectionAdd.Tag = "SubSectionAdd";
            this.rbtnSubSectionAdd.Text = "Add";
            this.rbtnSubSectionAdd.ToolTip = resources.GetString("rbtnSubSectionAdd.ToolTip");
            // 
            // rbtnSubSectionRemove
            // 
            this.rbtnSubSectionRemove.KeyTip = "SR";
            this.rbtnSubSectionRemove.LargeImage = global::FlexReportDesignerApp.Img_Insert.BandRemove_32;
            this.rbtnSubSectionRemove.Name = "rbtnSubSectionRemove";
            this.rbtnSubSectionRemove.SmallImage = global::FlexReportDesignerApp.Img_Insert.BandRemove_16;
            this.rbtnSubSectionRemove.Tag = "SubSectionRemove";
            this.rbtnSubSectionRemove.Text = "Remove";
            this.rbtnSubSectionRemove.ToolTip = resources.GetString("rbtnSubSectionRemove.ToolTip");
            // 
            // rbtnSubSectionMoveUp
            // 
            this.rbtnSubSectionMoveUp.KeyTip = "SU";
            this.rbtnSubSectionMoveUp.Name = "rbtnSubSectionMoveUp";
            this.rbtnSubSectionMoveUp.SmallImage = global::FlexReportDesignerApp.Img_Insert.BandMoveUp_16;
            this.rbtnSubSectionMoveUp.Tag = "SubSectionMoveUp";
            this.rbtnSubSectionMoveUp.Text = "Move Up";
            this.rbtnSubSectionMoveUp.ToolTip = resources.GetString("rbtnSubSectionMoveUp.ToolTip");
            // 
            // rbtnSubSectionMoveDown
            // 
            this.rbtnSubSectionMoveDown.KeyTip = "SD";
            this.rbtnSubSectionMoveDown.Name = "rbtnSubSectionMoveDown";
            this.rbtnSubSectionMoveDown.SmallImage = global::FlexReportDesignerApp.Img_Insert.BandMoveDown_16;
            this.rbtnSubSectionMoveDown.Tag = "SubSectionMoveDown";
            this.rbtnSubSectionMoveDown.Text = "Move Down";
            this.rbtnSubSectionMoveDown.ToolTip = resources.GetString("rbtnSubSectionMoveDown.ToolTip");
            // 
            // rgCustomFields
            // 
            this.rgCustomFields.GroupKeyTip = "C";
            this.rgCustomFields.Name = "rgCustomFields";
            this.rgCustomFields.Text = "Custom Fields";
            // 
            // rtArrange
            // 
            this.rtArrange.Groups.Add(this.rgGrid);
            this.rtArrange.Groups.Add(this.rgControlAlignment);
            this.rtArrange.Groups.Add(this.rgPosition);
            this.rtArrange.Groups.Add(this.rgSize);
            this.rtArrange.KeyTip = "A";
            this.rtArrange.Name = "rtArrange";
            this.rtArrange.Text = "ARRANGE";
            // 
            // rgGrid
            // 
            this.rgGrid.GroupKeyTip = "G";
            this.rgGrid.Image = ((System.Drawing.Image)(resources.GetObject("rgGrid.Image")));
            this.rgGrid.Items.Add(this.rbtnSnapToGrid);
            this.rgGrid.Items.Add(this.rbtnShowGrid);
            this.rgGrid.Items.Add(this.rbtnLockFields);
            this.rgGrid.Items.Add(this.ribbonSeparator16);
            this.rgGrid.Items.Add(this.rbtnGridProperties);
            this.rgGrid.Name = "rgGrid";
            this.rgGrid.Text = "Grid";
            // 
            // rbtnSnapToGrid
            // 
            this.rbtnSnapToGrid.KeyTip = "GS";
            this.rbtnSnapToGrid.Name = "rbtnSnapToGrid";
            this.rbtnSnapToGrid.SmallImage = global::FlexReportDesignerApp.Img_Arrange.SnapToGrid_16;
            this.rbtnSnapToGrid.Tag = "SnapToGrid";
            this.rbtnSnapToGrid.Text = "Snap to Grid";
            this.rbtnSnapToGrid.ToolTip = resources.GetString("rbtnSnapToGrid.ToolTip");
            // 
            // rbtnShowGrid
            // 
            this.rbtnShowGrid.KeyTip = "GG";
            this.rbtnShowGrid.Name = "rbtnShowGrid";
            this.rbtnShowGrid.SmallImage = global::FlexReportDesignerApp.Img_Arrange.ShowGrid_16;
            this.rbtnShowGrid.Tag = "ShowGrid";
            this.rbtnShowGrid.Text = "Show Grid";
            this.rbtnShowGrid.ToolTip = resources.GetString("rbtnShowGrid.ToolTip");
            // 
            // rbtnLockFields
            // 
            this.rbtnLockFields.KeyTip = "GF";
            this.rbtnLockFields.Name = "rbtnLockFields";
            this.rbtnLockFields.SmallImage = global::FlexReportDesignerApp.Img_Arrange.LockFields_16;
            this.rbtnLockFields.Tag = "LockFields";
            this.rbtnLockFields.Text = "Lock Fields";
            this.rbtnLockFields.ToolTip = resources.GetString("rbtnLockFields.ToolTip");
            // 
            // ribbonSeparator16
            // 
            this.ribbonSeparator16.HiddenMode = true;
            this.ribbonSeparator16.Name = "ribbonSeparator16";
            // 
            // rbtnGridProperties
            // 
            this.rbtnGridProperties.KeyTip = "GP";
            this.rbtnGridProperties.LargeImage = global::FlexReportDesignerApp.Img_Arrange.GridProperties_32;
            this.rbtnGridProperties.Name = "rbtnGridProperties";
            this.rbtnGridProperties.SmallImage = global::FlexReportDesignerApp.Img_Arrange.GridProperties_16;
            this.rbtnGridProperties.Tag = "GridProperties";
            this.rbtnGridProperties.Text = "Grid Properties";
            this.rbtnGridProperties.ToolTip = resources.GetString("rbtnGridProperties.ToolTip");
            // 
            // rgControlAlignment
            // 
            this.rgControlAlignment.GroupKeyTip = "A";
            this.rgControlAlignment.Image = ((System.Drawing.Image)(resources.GetObject("rgControlAlignment.Image")));
            this.rgControlAlignment.Items.Add(this.rbtnAlignLeft);
            this.rgControlAlignment.Items.Add(this.rbtnAlignRight);
            this.rgControlAlignment.Items.Add(this.rbtnAlignCenter);
            this.rgControlAlignment.Items.Add(this.rbtnAlignTop);
            this.rgControlAlignment.Items.Add(this.rbtnAlignBottom);
            this.rgControlAlignment.Items.Add(this.rbtnAlignMiddle);
            this.rgControlAlignment.Name = "rgControlAlignment";
            this.rgControlAlignment.Text = "Alignment";
            // 
            // rbtnAlignLeft
            // 
            this.rbtnAlignLeft.KeyTip = "AL";
            this.rbtnAlignLeft.Name = "rbtnAlignLeft";
            this.rbtnAlignLeft.SmallImage = global::FlexReportDesignerApp.Img_Arrange.AlignLeft_16;
            this.rbtnAlignLeft.Tag = "AlignLeft";
            this.rbtnAlignLeft.Text = "Left";
            this.rbtnAlignLeft.ToolTip = resources.GetString("rbtnAlignLeft.ToolTip");
            // 
            // rbtnAlignRight
            // 
            this.rbtnAlignRight.KeyTip = "AR";
            this.rbtnAlignRight.Name = "rbtnAlignRight";
            this.rbtnAlignRight.SmallImage = global::FlexReportDesignerApp.Img_Arrange.AlignRight_16;
            this.rbtnAlignRight.Tag = "AlignRight";
            this.rbtnAlignRight.Text = "Right";
            this.rbtnAlignRight.ToolTip = resources.GetString("rbtnAlignRight.ToolTip");
            // 
            // rbtnAlignCenter
            // 
            this.rbtnAlignCenter.KeyTip = "AC";
            this.rbtnAlignCenter.Name = "rbtnAlignCenter";
            this.rbtnAlignCenter.SmallImage = global::FlexReportDesignerApp.Img_Arrange.AlignCenter_16;
            this.rbtnAlignCenter.Tag = "AlignCenter";
            this.rbtnAlignCenter.Text = "Center";
            this.rbtnAlignCenter.ToolTip = resources.GetString("rbtnAlignCenter.ToolTip");
            // 
            // rbtnAlignTop
            // 
            this.rbtnAlignTop.KeyTip = "AT";
            this.rbtnAlignTop.Name = "rbtnAlignTop";
            this.rbtnAlignTop.SmallImage = global::FlexReportDesignerApp.Img_Arrange.AlignTop_16;
            this.rbtnAlignTop.Tag = "AlignTop";
            this.rbtnAlignTop.Text = "Top";
            this.rbtnAlignTop.ToolTip = resources.GetString("rbtnAlignTop.ToolTip");
            // 
            // rbtnAlignBottom
            // 
            this.rbtnAlignBottom.KeyTip = "AB";
            this.rbtnAlignBottom.Name = "rbtnAlignBottom";
            this.rbtnAlignBottom.SmallImage = global::FlexReportDesignerApp.Img_Arrange.AlignBottom_16;
            this.rbtnAlignBottom.Tag = "AlignBottom";
            this.rbtnAlignBottom.Text = "Bottom";
            this.rbtnAlignBottom.ToolTip = resources.GetString("rbtnAlignBottom.ToolTip");
            // 
            // rbtnAlignMiddle
            // 
            this.rbtnAlignMiddle.KeyTip = "AM";
            this.rbtnAlignMiddle.Name = "rbtnAlignMiddle";
            this.rbtnAlignMiddle.SmallImage = global::FlexReportDesignerApp.Img_Arrange.AlignMiddle_16;
            this.rbtnAlignMiddle.Tag = "AlignMiddle";
            this.rbtnAlignMiddle.Text = "Middle";
            this.rbtnAlignMiddle.ToolTip = resources.GetString("rbtnAlignMiddle.ToolTip");
            // 
            // rgPosition
            // 
            this.rgPosition.GroupKeyTip = "P";
            this.rgPosition.Image = ((System.Drawing.Image)(resources.GetObject("rgPosition.Image")));
            this.rgPosition.Items.Add(this.rbtnEqualHorizontalSpacing);
            this.rgPosition.Items.Add(this.rbtnIncreaseHorizontalSpacing);
            this.rgPosition.Items.Add(this.rbtnDecreaseHorizontalSpacing);
            this.rgPosition.Items.Add(this.ribbonSeparator13);
            this.rgPosition.Items.Add(this.rbtnEqualVerticalSpacing);
            this.rgPosition.Items.Add(this.rbtnIncreaseVerticalSpacing);
            this.rgPosition.Items.Add(this.rbtnDecreaseVerticalSpacing);
            this.rgPosition.Items.Add(this.ribbonSeparator11);
            this.rgPosition.Items.Add(this.rbtnAlignToGrid);
            this.rgPosition.Items.Add(this.rbtnBringToFront);
            this.rgPosition.Items.Add(this.rbtnSendToBack);
            this.rgPosition.Name = "rgPosition";
            this.rgPosition.Text = "Position";
            // 
            // rbtnEqualHorizontalSpacing
            // 
            this.rbtnEqualHorizontalSpacing.KeyTip = "PE";
            this.rbtnEqualHorizontalSpacing.Name = "rbtnEqualHorizontalSpacing";
            this.rbtnEqualHorizontalSpacing.SmallImage = global::FlexReportDesignerApp.Img_Arrange.EqualizeHorizontal_16;
            this.rbtnEqualHorizontalSpacing.Tag = "EqualHorizontalSpacing";
            this.rbtnEqualHorizontalSpacing.Text = "Equalize Horizontal";
            this.rbtnEqualHorizontalSpacing.ToolTip = resources.GetString("rbtnEqualHorizontalSpacing.ToolTip");
            // 
            // rbtnIncreaseHorizontalSpacing
            // 
            this.rbtnIncreaseHorizontalSpacing.KeyTip = "PI";
            this.rbtnIncreaseHorizontalSpacing.Name = "rbtnIncreaseHorizontalSpacing";
            this.rbtnIncreaseHorizontalSpacing.SmallImage = global::FlexReportDesignerApp.Img_Arrange.IncreaseHorizontal_16;
            this.rbtnIncreaseHorizontalSpacing.Tag = "IncreaseHorizontalSpacing";
            this.rbtnIncreaseHorizontalSpacing.Text = "Increase Horizontal";
            this.rbtnIncreaseHorizontalSpacing.ToolTip = resources.GetString("rbtnIncreaseHorizontalSpacing.ToolTip");
            // 
            // rbtnDecreaseHorizontalSpacing
            // 
            this.rbtnDecreaseHorizontalSpacing.KeyTip = "PD";
            this.rbtnDecreaseHorizontalSpacing.Name = "rbtnDecreaseHorizontalSpacing";
            this.rbtnDecreaseHorizontalSpacing.SmallImage = global::FlexReportDesignerApp.Img_Arrange.DecreaseHorizontal_16;
            this.rbtnDecreaseHorizontalSpacing.Tag = "DecreaseHorizontalSpacing";
            this.rbtnDecreaseHorizontalSpacing.Text = "Decrease Horizontal";
            this.rbtnDecreaseHorizontalSpacing.ToolTip = resources.GetString("rbtnDecreaseHorizontalSpacing.ToolTip");
            // 
            // ribbonSeparator13
            // 
            this.ribbonSeparator13.HiddenMode = true;
            this.ribbonSeparator13.Name = "ribbonSeparator13";
            // 
            // rbtnEqualVerticalSpacing
            // 
            this.rbtnEqualVerticalSpacing.KeyTip = "PQ";
            this.rbtnEqualVerticalSpacing.Name = "rbtnEqualVerticalSpacing";
            this.rbtnEqualVerticalSpacing.SmallImage = global::FlexReportDesignerApp.Img_Arrange.EqualizeVertical_16;
            this.rbtnEqualVerticalSpacing.Tag = "EqualVerticalSpacing";
            this.rbtnEqualVerticalSpacing.Text = "Equalize Vertical";
            this.rbtnEqualVerticalSpacing.ToolTip = resources.GetString("rbtnEqualVerticalSpacing.ToolTip");
            // 
            // rbtnIncreaseVerticalSpacing
            // 
            this.rbtnIncreaseVerticalSpacing.KeyTip = "PN";
            this.rbtnIncreaseVerticalSpacing.Name = "rbtnIncreaseVerticalSpacing";
            this.rbtnIncreaseVerticalSpacing.SmallImage = global::FlexReportDesignerApp.Img_Arrange.IncreaseVertical_16;
            this.rbtnIncreaseVerticalSpacing.Tag = "IncreaseVerticalSpacing";
            this.rbtnIncreaseVerticalSpacing.Text = "Increase Vertical";
            this.rbtnIncreaseVerticalSpacing.ToolTip = resources.GetString("rbtnIncreaseVerticalSpacing.ToolTip");
            // 
            // rbtnDecreaseVerticalSpacing
            // 
            this.rbtnDecreaseVerticalSpacing.KeyTip = "PC";
            this.rbtnDecreaseVerticalSpacing.Name = "rbtnDecreaseVerticalSpacing";
            this.rbtnDecreaseVerticalSpacing.SmallImage = global::FlexReportDesignerApp.Img_Arrange.DecreaseVertical_16;
            this.rbtnDecreaseVerticalSpacing.Tag = "DecreaseVerticalSpacing";
            this.rbtnDecreaseVerticalSpacing.Text = "Decrease Vertical";
            this.rbtnDecreaseVerticalSpacing.ToolTip = resources.GetString("rbtnDecreaseVerticalSpacing.ToolTip");
            // 
            // ribbonSeparator11
            // 
            this.ribbonSeparator11.HiddenMode = true;
            this.ribbonSeparator11.Name = "ribbonSeparator11";
            // 
            // rbtnAlignToGrid
            // 
            this.rbtnAlignToGrid.KeyTip = "PS";
            this.rbtnAlignToGrid.Name = "rbtnAlignToGrid";
            this.rbtnAlignToGrid.SmallImage = global::FlexReportDesignerApp.Img_Arrange.DoSnapToGrid_16;
            this.rbtnAlignToGrid.Tag = "AlignToGrid";
            this.rbtnAlignToGrid.Text = "Snap to Grid";
            this.rbtnAlignToGrid.ToolTip = resources.GetString("rbtnAlignToGrid.ToolTip");
            // 
            // rbtnBringToFront
            // 
            this.rbtnBringToFront.KeyTip = "PF";
            this.rbtnBringToFront.Name = "rbtnBringToFront";
            this.rbtnBringToFront.SmallImage = global::FlexReportDesignerApp.Img_Arrange.BringToFront_16;
            this.rbtnBringToFront.Tag = "BringToFront";
            this.rbtnBringToFront.Text = "Bring to Front";
            this.rbtnBringToFront.ToolTip = resources.GetString("rbtnBringToFront.ToolTip");
            // 
            // rbtnSendToBack
            // 
            this.rbtnSendToBack.KeyTip = "PB";
            this.rbtnSendToBack.Name = "rbtnSendToBack";
            this.rbtnSendToBack.SmallImage = global::FlexReportDesignerApp.Img_Arrange.SendToBack_16;
            this.rbtnSendToBack.Tag = "SendToBack";
            this.rbtnSendToBack.Text = "Send to Back";
            this.rbtnSendToBack.ToolTip = resources.GetString("rbtnSendToBack.ToolTip");
            // 
            // rgSize
            // 
            this.rgSize.GroupKeyTip = "S";
            this.rgSize.Image = ((System.Drawing.Image)(resources.GetObject("rgSize.Image")));
            this.rgSize.Items.Add(this.rbtnHeightToTallest);
            this.rgSize.Items.Add(this.rbtnHeightToShortest);
            this.rgSize.Items.Add(this.ribbonSeparator19);
            this.rgSize.Items.Add(this.rbtnWidthToWidest);
            this.rgSize.Items.Add(this.rbtnWidthToNarrowest);
            this.rgSize.Items.Add(this.rbtnSizeToGrid);
            this.rgSize.Name = "rgSize";
            this.rgSize.Text = "Size";
            // 
            // rbtnHeightToTallest
            // 
            this.rbtnHeightToTallest.KeyTip = "ST";
            this.rbtnHeightToTallest.Name = "rbtnHeightToTallest";
            this.rbtnHeightToTallest.SmallImage = global::FlexReportDesignerApp.Img_Arrange.ToTallest_16;
            this.rbtnHeightToTallest.Tag = "HeightToTallest";
            this.rbtnHeightToTallest.Text = "To Tallest";
            this.rbtnHeightToTallest.ToolTip = resources.GetString("rbtnHeightToTallest.ToolTip");
            // 
            // rbtnHeightToShortest
            // 
            this.rbtnHeightToShortest.KeyTip = "SS";
            this.rbtnHeightToShortest.Name = "rbtnHeightToShortest";
            this.rbtnHeightToShortest.SmallImage = global::FlexReportDesignerApp.Img_Arrange.ToShortest_16;
            this.rbtnHeightToShortest.Tag = "HeightToShortest";
            this.rbtnHeightToShortest.Text = "To Shortest";
            this.rbtnHeightToShortest.ToolTip = resources.GetString("rbtnHeightToShortest.ToolTip");
            // 
            // ribbonSeparator19
            // 
            this.ribbonSeparator19.HiddenMode = true;
            this.ribbonSeparator19.Name = "ribbonSeparator19";
            // 
            // rbtnWidthToWidest
            // 
            this.rbtnWidthToWidest.KeyTip = "SW";
            this.rbtnWidthToWidest.Name = "rbtnWidthToWidest";
            this.rbtnWidthToWidest.SmallImage = global::FlexReportDesignerApp.Img_Arrange.ToWidest_16;
            this.rbtnWidthToWidest.Tag = "WidthToWidest";
            this.rbtnWidthToWidest.Text = "To Widest";
            this.rbtnWidthToWidest.ToolTip = resources.GetString("rbtnWidthToWidest.ToolTip");
            // 
            // rbtnWidthToNarrowest
            // 
            this.rbtnWidthToNarrowest.KeyTip = "SN";
            this.rbtnWidthToNarrowest.Name = "rbtnWidthToNarrowest";
            this.rbtnWidthToNarrowest.SmallImage = global::FlexReportDesignerApp.Img_Arrange.ToNarrowest_16;
            this.rbtnWidthToNarrowest.Tag = "WidthToNarrowest";
            this.rbtnWidthToNarrowest.Text = "To Narrowest";
            this.rbtnWidthToNarrowest.ToolTip = resources.GetString("rbtnWidthToNarrowest.ToolTip");
            // 
            // rbtnSizeToGrid
            // 
            this.rbtnSizeToGrid.KeyTip = "SG";
            this.rbtnSizeToGrid.Name = "rbtnSizeToGrid";
            this.rbtnSizeToGrid.SmallImage = global::FlexReportDesignerApp.Img_Arrange.SizeToGrid_16;
            this.rbtnSizeToGrid.Tag = "SizeToGrid";
            this.rbtnSizeToGrid.Text = "Size to Grid";
            this.rbtnSizeToGrid.ToolTip = resources.GetString("rbtnSizeToGrid.ToolTip");
            // 
            // rtPageSetup
            // 
            this.rtPageSetup.Groups.Add(this.rgPageLayout1);
            this.rtPageSetup.KeyTip = "P";
            this.rtPageSetup.Name = "rtPageSetup";
            this.rtPageSetup.Text = "PAGE SETUP";
            // 
            // rgPageLayout1
            // 
            this.rgPageLayout1.GroupKeyTip = "P";
            this.rgPageLayout1.Image = ((System.Drawing.Image)(resources.GetObject("rgPageLayout1.Image")));
            this.rgPageLayout1.Items.Add(this.rbtnPageSize1);
            this.rgPageLayout1.Items.Add(this.rbtnPagePortrait1);
            this.rgPageLayout1.Items.Add(this.rbtnPageLandscape1);
            this.rgPageLayout1.Items.Add(this.ribbonSeparator14);
            this.rgPageLayout1.Items.Add(this.rbtnPageSetup1);
            this.rgPageLayout1.Name = "rgPageLayout1";
            this.rgPageLayout1.Text = "Page Layout";
            // 
            // rbtnPageSize1
            // 
            this.rbtnPageSize1.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnPageSize1.LargeImage")));
            this.rbtnPageSize1.Name = "rbtnPageSize1";
            this.rbtnPageSize1.Text = "Size";
            this.rbtnPageSize1.ToolTip = "Page size";
            this.rbtnPageSize1.Visible = false;
            // 
            // rbtnPagePortrait1
            // 
            this.rbtnPagePortrait1.KeyTip = "PP";
            this.rbtnPagePortrait1.LargeImage = global::FlexReportDesignerApp.Img_PageSetup.Potrait_32;
            this.rbtnPagePortrait1.Name = "rbtnPagePortrait1";
            this.rbtnPagePortrait1.SmallImage = global::FlexReportDesignerApp.Img_PageSetup.Potrait_16;
            this.rbtnPagePortrait1.Tag = "PagePortrait";
            this.rbtnPagePortrait1.Text = "Portrait";
            this.rbtnPagePortrait1.ToolTip = resources.GetString("rbtnPagePortrait1.ToolTip");
            // 
            // rbtnPageLandscape1
            // 
            this.rbtnPageLandscape1.KeyTip = "PL";
            this.rbtnPageLandscape1.LargeImage = global::FlexReportDesignerApp.Img_PageSetup.Landscape_32;
            this.rbtnPageLandscape1.Name = "rbtnPageLandscape1";
            this.rbtnPageLandscape1.SmallImage = global::FlexReportDesignerApp.Img_PageSetup.LandScape_16;
            this.rbtnPageLandscape1.Tag = "PageLandscape";
            this.rbtnPageLandscape1.Text = "Landscape";
            this.rbtnPageLandscape1.ToolTip = resources.GetString("rbtnPageLandscape1.ToolTip");
            // 
            // ribbonSeparator14
            // 
            this.ribbonSeparator14.Name = "ribbonSeparator14";
            // 
            // rbtnPageSetup1
            // 
            this.rbtnPageSetup1.KeyTip = "PS";
            this.rbtnPageSetup1.LargeImage = global::FlexReportDesignerApp.Img_PageSetup.PageSetup_32;
            this.rbtnPageSetup1.Name = "rbtnPageSetup1";
            this.rbtnPageSetup1.SmallImage = global::FlexReportDesignerApp.Img_PageSetup.PageSetup_16;
            this.rbtnPageSetup1.Tag = "PageSetup";
            this.rbtnPageSetup1.Text = "Page Setup";
            this.rbtnPageSetup1.ToolTip = resources.GetString("rbtnPageSetup1.ToolTip");
            // 
            // rtPreview
            // 
            this.rtPreview.Groups.Add(this.rgPageLayout2);
            this.rtPreview.Groups.Add(this.rgZoom);
            this.rtPreview.Groups.Add(this.rgNavigation);
            this.rtPreview.Groups.Add(this.rgPreviewTools);
            this.rtPreview.Groups.Add(this.rgExport);
            this.rtPreview.Groups.Add(this.rgStopRefresh);
            this.rtPreview.KeyTip = "V";
            this.rtPreview.Name = "rtPreview";
            this.rtPreview.Text = "PREVIEW";
            // 
            // rgPageLayout2
            // 
            this.rgPageLayout2.GroupKeyTip = "P";
            this.rgPageLayout2.Image = ((System.Drawing.Image)(resources.GetObject("rgPageLayout2.Image")));
            this.rgPageLayout2.Items.Add(this.rbtnPageSize2);
            this.rgPageLayout2.Items.Add(this.rbtnPagePortrait2);
            this.rgPageLayout2.Items.Add(this.rbtnPageLandscape2);
            this.rgPageLayout2.Items.Add(this.ribbonSeparator141);
            this.rgPageLayout2.Items.Add(this.rbtnPageSetup2);
            this.rgPageLayout2.Name = "rgPageLayout2";
            this.rgPageLayout2.Text = "Page Layout";
            // 
            // rbtnPageSize2
            // 
            this.rbtnPageSize2.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnPageSize2.LargeImage")));
            this.rbtnPageSize2.Name = "rbtnPageSize2";
            this.rbtnPageSize2.Text = "Size";
            this.rbtnPageSize2.ToolTip = "Page size";
            this.rbtnPageSize2.Visible = false;
            // 
            // rbtnPagePortrait2
            // 
            this.rbtnPagePortrait2.KeyTip = "PP";
            this.rbtnPagePortrait2.LargeImage = global::FlexReportDesignerApp.Img_PageSetup.Potrait_32;
            this.rbtnPagePortrait2.Name = "rbtnPagePortrait2";
            this.rbtnPagePortrait2.SmallImage = global::FlexReportDesignerApp.Img_PageSetup.Potrait_16;
            this.rbtnPagePortrait2.Tag = "PagePortrait";
            this.rbtnPagePortrait2.Text = "Portrait";
            this.rbtnPagePortrait2.ToolTip = resources.GetString("rbtnPagePortrait2.ToolTip");
            // 
            // rbtnPageLandscape2
            // 
            this.rbtnPageLandscape2.KeyTip = "PL";
            this.rbtnPageLandscape2.LargeImage = global::FlexReportDesignerApp.Img_PageSetup.Landscape_32;
            this.rbtnPageLandscape2.Name = "rbtnPageLandscape2";
            this.rbtnPageLandscape2.SmallImage = global::FlexReportDesignerApp.Img_PageSetup.LandScape_16;
            this.rbtnPageLandscape2.Tag = "PageLandscape";
            this.rbtnPageLandscape2.Text = "Landscape";
            this.rbtnPageLandscape2.ToolTip = resources.GetString("rbtnPageLandscape2.ToolTip");
            // 
            // ribbonSeparator141
            // 
            this.ribbonSeparator141.Name = "ribbonSeparator141";
            // 
            // rbtnPageSetup2
            // 
            this.rbtnPageSetup2.KeyTip = "PS";
            this.rbtnPageSetup2.LargeImage = global::FlexReportDesignerApp.Img_PageSetup.PageSetup_32;
            this.rbtnPageSetup2.Name = "rbtnPageSetup2";
            this.rbtnPageSetup2.SmallImage = global::FlexReportDesignerApp.Img_PageSetup.PageSetup_16;
            this.rbtnPageSetup2.Tag = "PageSetup";
            this.rbtnPageSetup2.Text = "Page Setup";
            this.rbtnPageSetup2.ToolTip = resources.GetString("rbtnPageSetup2.ToolTip");
            // 
            // rgZoom
            // 
            this.rgZoom.GroupKeyTip = "V";
            this.rgZoom.Image = ((System.Drawing.Image)(resources.GetObject("rgZoom.Image")));
            this.rgZoom.Items.Add(this.rbtnPreviewPaginated);
            this.rgZoom.Items.Add(this.ribbonSeparator24);
            this.rgZoom.Items.Add(this.rbtnPreviewParams);
            this.rgZoom.Items.Add(this.rbtnPreviewOutlines);
            this.rgZoom.Items.Add(this.rbtnPreviewThumbnails);
            this.rgZoom.Items.Add(this.ribbonSeparator25);
            this.rgZoom.Items.Add(this.rbtnZoomOnePage);
            this.rgZoom.Items.Add(this.rbtnZoomTwoPages);
            this.rgZoom.Items.Add(this.rbtnZoom);
            this.rgZoom.Name = "rgZoom";
            this.rgZoom.Text = "View";
            // 
            // rbtnPreviewPaginated
            // 
            this.rbtnPreviewPaginated.KeyTip = "PG";
            this.rbtnPreviewPaginated.LargeImage = global::FlexReportDesignerApp.Img_Preview.Paginated_32;
            this.rbtnPreviewPaginated.Name = "rbtnPreviewPaginated";
            this.rbtnPreviewPaginated.SmallImage = global::FlexReportDesignerApp.Img_Preview.Paginated_16;
            this.rbtnPreviewPaginated.Tag = "PreviewPaginated";
            this.rbtnPreviewPaginated.Text = "Paginated";
            this.rbtnPreviewPaginated.ToolTip = resources.GetString("rbtnPreviewPaginated.ToolTip");
            // 
            // ribbonSeparator24
            // 
            this.ribbonSeparator24.Name = "ribbonSeparator24";
            // 
            // rbtnPreviewParams
            // 
            this.rbtnPreviewParams.KeyTip = "A";
            this.rbtnPreviewParams.LargeImage = global::FlexReportDesignerApp.Img_Preview.Parameters_32;
            this.rbtnPreviewParams.Name = "rbtnPreviewParams";
            this.rbtnPreviewParams.SmallImage = global::FlexReportDesignerApp.Img_Preview.Parameters_16;
            this.rbtnPreviewParams.Tag = "PreviewParams";
            this.rbtnPreviewParams.Text = "Parameters";
            this.rbtnPreviewParams.ToolTip = resources.GetString("rbtnPreviewParams.ToolTip");
            // 
            // rbtnPreviewOutlines
            // 
            this.rbtnPreviewOutlines.KeyTip = "O";
            this.rbtnPreviewOutlines.LargeImage = global::FlexReportDesignerApp.Img_Preview.OutLine_32;
            this.rbtnPreviewOutlines.Name = "rbtnPreviewOutlines";
            this.rbtnPreviewOutlines.SmallImage = global::FlexReportDesignerApp.Img_Preview.OutLine_16;
            this.rbtnPreviewOutlines.Tag = "PreviewOutlines";
            this.rbtnPreviewOutlines.Text = "Outlines";
            this.rbtnPreviewOutlines.ToolTip = resources.GetString("rbtnPreviewOutlines.ToolTip");
            // 
            // rbtnPreviewThumbnails
            // 
            this.rbtnPreviewThumbnails.KeyTip = "T";
            this.rbtnPreviewThumbnails.LargeImage = global::FlexReportDesignerApp.Img_Preview.Thumbnails_32;
            this.rbtnPreviewThumbnails.Name = "rbtnPreviewThumbnails";
            this.rbtnPreviewThumbnails.SmallImage = global::FlexReportDesignerApp.Img_Preview.Thumbnails_16;
            this.rbtnPreviewThumbnails.Tag = "PreviewThumbnails";
            this.rbtnPreviewThumbnails.Text = "Thumbnails";
            this.rbtnPreviewThumbnails.ToolTip = resources.GetString("rbtnPreviewThumbnails.ToolTip");
            // 
            // ribbonSeparator25
            // 
            this.ribbonSeparator25.Name = "ribbonSeparator25";
            // 
            // rbtnZoomOnePage
            // 
            this.rbtnZoomOnePage.KeyTip = "V1";
            this.rbtnZoomOnePage.LargeImage = global::FlexReportDesignerApp.Img_Preview.SinglePage_32;
            this.rbtnZoomOnePage.Name = "rbtnZoomOnePage";
            this.rbtnZoomOnePage.SmallImage = global::FlexReportDesignerApp.Img_Preview.SinglePage_16;
            this.rbtnZoomOnePage.Tag = "ZoomOnePage";
            this.rbtnZoomOnePage.Text = "One Page";
            this.rbtnZoomOnePage.ToolTip = resources.GetString("rbtnZoomOnePage.ToolTip");
            // 
            // rbtnZoomTwoPages
            // 
            this.rbtnZoomTwoPages.KeyTip = "V2";
            this.rbtnZoomTwoPages.LargeImage = global::FlexReportDesignerApp.Img_Preview.TwoPage_32;
            this.rbtnZoomTwoPages.Name = "rbtnZoomTwoPages";
            this.rbtnZoomTwoPages.SmallImage = global::FlexReportDesignerApp.Img_Preview.TwoPage_16;
            this.rbtnZoomTwoPages.Tag = "ZoomTwoPages";
            this.rbtnZoomTwoPages.Text = "Two Pages";
            this.rbtnZoomTwoPages.ToolTip = resources.GetString("rbtnZoomTwoPages.ToolTip");
            // 
            // rbtnZoom
            // 
            this.rbtnZoom.Items.Add(this.rbtnZoomFitToWindow);
            this.rbtnZoom.Items.Add(this.ribbonSeparator10);
            this.rbtnZoom.Items.Add(this.rbtnZoom10);
            this.rbtnZoom.Items.Add(this.rbtnZoom25);
            this.rbtnZoom.Items.Add(this.rbtnZoom50);
            this.rbtnZoom.Items.Add(this.rbtnZoom75);
            this.rbtnZoom.Items.Add(this.rbtnZoom100);
            this.rbtnZoom.Items.Add(this.rbtnZoom125);
            this.rbtnZoom.Items.Add(this.rbtnZoom150);
            this.rbtnZoom.Items.Add(this.rbtnZoom200);
            this.rbtnZoom.Items.Add(this.rbtnZoom500);
            this.rbtnZoom.KeyTip = "VZ";
            this.rbtnZoom.LargeImage = global::FlexReportDesignerApp.Img_Home.Zoom_32;
            this.rbtnZoom.Name = "rbtnZoom";
            this.rbtnZoom.SmallImage = global::FlexReportDesignerApp.Img_Home.Zoom_16;
            this.rbtnZoom.Tag = "Zoom";
            this.rbtnZoom.Text = "Zoom";
            this.rbtnZoom.ToolTip = resources.GetString("rbtnZoom.ToolTip");
            // 
            // rbtnZoomFitToWindow
            // 
            this.rbtnZoomFitToWindow.Name = "rbtnZoomFitToWindow";
            this.rbtnZoomFitToWindow.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnZoomFitToWindow.SmallImage")));
            this.rbtnZoomFitToWindow.Tag = "ZoomFitToWindow";
            this.rbtnZoomFitToWindow.Text = "Fit to Window";
            this.rbtnZoomFitToWindow.ToolTip = "Fit to window";
            // 
            // ribbonSeparator10
            // 
            this.ribbonSeparator10.Name = "ribbonSeparator10";
            // 
            // rbtnZoom10
            // 
            this.rbtnZoom10.Name = "rbtnZoom10";
            this.rbtnZoom10.Tag = "Zoom10";
            this.rbtnZoom10.Text = "10%";
            // 
            // rbtnZoom25
            // 
            this.rbtnZoom25.Name = "rbtnZoom25";
            this.rbtnZoom25.Tag = "Zoom25";
            this.rbtnZoom25.Text = "25%";
            // 
            // rbtnZoom50
            // 
            this.rbtnZoom50.Name = "rbtnZoom50";
            this.rbtnZoom50.Tag = "Zoom50";
            this.rbtnZoom50.Text = "50%";
            // 
            // rbtnZoom75
            // 
            this.rbtnZoom75.Name = "rbtnZoom75";
            this.rbtnZoom75.Tag = "Zoom75";
            this.rbtnZoom75.Text = "75%";
            // 
            // rbtnZoom100
            // 
            this.rbtnZoom100.Name = "rbtnZoom100";
            this.rbtnZoom100.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnZoom100.SmallImage")));
            this.rbtnZoom100.Tag = "Zoom100";
            this.rbtnZoom100.Text = "100%";
            // 
            // rbtnZoom125
            // 
            this.rbtnZoom125.Name = "rbtnZoom125";
            this.rbtnZoom125.Tag = "Zoom125";
            this.rbtnZoom125.Text = "125%";
            // 
            // rbtnZoom150
            // 
            this.rbtnZoom150.Name = "rbtnZoom150";
            this.rbtnZoom150.Tag = "Zoom150";
            this.rbtnZoom150.Text = "150%";
            // 
            // rbtnZoom200
            // 
            this.rbtnZoom200.Name = "rbtnZoom200";
            this.rbtnZoom200.Tag = "Zoom200";
            this.rbtnZoom200.Text = "200%";
            // 
            // rbtnZoom500
            // 
            this.rbtnZoom500.Name = "rbtnZoom500";
            this.rbtnZoom500.Tag = "Zoom500";
            this.rbtnZoom500.Text = "500%";
            // 
            // rgNavigation
            // 
            this.rgNavigation.GroupKeyTip = "N";
            this.rgNavigation.Image = ((System.Drawing.Image)(resources.GetObject("rgNavigation.Image")));
            this.rgNavigation.Items.Add(this.ribbonToolBar3);
            this.rgNavigation.Items.Add(this.ribbonToolBar4);
            this.rgNavigation.Name = "rgNavigation";
            this.rgNavigation.Text = "Navigation";
            // 
            // ribbonToolBar3
            // 
            this.ribbonToolBar3.Items.Add(this.rbtnFirstPage);
            this.ribbonToolBar3.Items.Add(this.rbtnPreviousPage);
            this.ribbonToolBar3.Items.Add(this.rebPageNo);
            this.ribbonToolBar3.Items.Add(this.rlblPageCount);
            this.ribbonToolBar3.Items.Add(this.rbtnNextPage);
            this.ribbonToolBar3.Items.Add(this.rbtnLastPage);
            this.ribbonToolBar3.Name = "ribbonToolBar3";
            // 
            // rbtnFirstPage
            // 
            this.rbtnFirstPage.KeyTip = "1";
            this.rbtnFirstPage.Name = "rbtnFirstPage";
            this.rbtnFirstPage.SmallImage = global::FlexReportDesignerApp.Img_Preview.First_16;
            this.rbtnFirstPage.Tag = "FirstPage";
            this.rbtnFirstPage.ToolTip = resources.GetString("rbtnFirstPage.ToolTip");
            // 
            // rbtnPreviousPage
            // 
            this.rbtnPreviousPage.KeyTip = "2";
            this.rbtnPreviousPage.Name = "rbtnPreviousPage";
            this.rbtnPreviousPage.SmallImage = global::FlexReportDesignerApp.Img_Preview.Previous_16;
            this.rbtnPreviousPage.Tag = "PreviousPage";
            this.rbtnPreviousPage.ToolTip = resources.GetString("rbtnPreviousPage.ToolTip");
            // 
            // rebPageNo
            // 
            this.rebPageNo.KeyTip = "3";
            this.rebPageNo.Label = "Page";
            this.rebPageNo.Name = "rebPageNo";
            this.rebPageNo.Tag = "EditPageNo";
            this.rebPageNo.TextAreaWidth = 40;
            // 
            // rlblPageCount
            // 
            this.rlblPageCount.Name = "rlblPageCount";
            this.rlblPageCount.Tag = "LblPageCount";
            this.rlblPageCount.Text = "of 1";
            // 
            // rbtnNextPage
            // 
            this.rbtnNextPage.KeyTip = "4";
            this.rbtnNextPage.Name = "rbtnNextPage";
            this.rbtnNextPage.SmallImage = global::FlexReportDesignerApp.Img_Preview.Next_16;
            this.rbtnNextPage.Tag = "NextPage";
            this.rbtnNextPage.ToolTip = resources.GetString("rbtnNextPage.ToolTip");
            // 
            // rbtnLastPage
            // 
            this.rbtnLastPage.KeyTip = "5";
            this.rbtnLastPage.Name = "rbtnLastPage";
            this.rbtnLastPage.SmallImage = global::FlexReportDesignerApp.Img_Preview.Last_16;
            this.rbtnLastPage.Tag = "LastPage";
            this.rbtnLastPage.ToolTip = resources.GetString("rbtnLastPage.ToolTip");
            // 
            // ribbonToolBar4
            // 
            this.ribbonToolBar4.Items.Add(this.rbtnPreviousView);
            this.ribbonToolBar4.Items.Add(this.ribbonSeparator7);
            this.ribbonToolBar4.Items.Add(this.rbtnNextView);
            this.ribbonToolBar4.Name = "ribbonToolBar4";
            // 
            // rbtnPreviousView
            // 
            this.rbtnPreviousView.KeyTip = "VP";
            this.rbtnPreviousView.Name = "rbtnPreviousView";
            this.rbtnPreviousView.SmallImage = global::FlexReportDesignerApp.Img_Preview.PreviousView_16;
            this.rbtnPreviousView.Tag = "PreviousView";
            this.rbtnPreviousView.Text = "Previous View";
            this.rbtnPreviousView.ToolTip = resources.GetString("rbtnPreviousView.ToolTip");
            // 
            // ribbonSeparator7
            // 
            this.ribbonSeparator7.HiddenMode = true;
            this.ribbonSeparator7.Name = "ribbonSeparator7";
            // 
            // rbtnNextView
            // 
            this.rbtnNextView.KeyTip = "VN";
            this.rbtnNextView.Name = "rbtnNextView";
            this.rbtnNextView.SmallImage = global::FlexReportDesignerApp.Img_Preview.NextView_16;
            this.rbtnNextView.Tag = "NextView";
            this.rbtnNextView.Text = "Next View";
            this.rbtnNextView.ToolTip = resources.GetString("rbtnNextView.ToolTip");
            // 
            // rgPreviewTools
            // 
            this.rgPreviewTools.GroupKeyTip = "T";
            this.rgPreviewTools.Image = ((System.Drawing.Image)(resources.GetObject("rgPreviewTools.Image")));
            this.rgPreviewTools.Items.Add(this.rbtnHandTool);
            this.rgPreviewTools.Items.Add(this.rbtnTextSelectTool);
            this.rgPreviewTools.Items.Add(this.rbtnPreviewFind);
            this.rgPreviewTools.Name = "rgPreviewTools";
            this.rgPreviewTools.Text = "Tools";
            // 
            // rbtnHandTool
            // 
            this.rbtnHandTool.KeyTip = "H";
            this.rbtnHandTool.Name = "rbtnHandTool";
            this.rbtnHandTool.SmallImage = global::FlexReportDesignerApp.Img_Preview.Hand_16;
            this.rbtnHandTool.Tag = "HandTool";
            this.rbtnHandTool.Text = "Hand Tool";
            this.rbtnHandTool.ToolTip = resources.GetString("rbtnHandTool.ToolTip");
            // 
            // rbtnTextSelectTool
            // 
            this.rbtnTextSelectTool.KeyTip = "S";
            this.rbtnTextSelectTool.Name = "rbtnTextSelectTool";
            this.rbtnTextSelectTool.SmallImage = global::FlexReportDesignerApp.Img_Preview.SelectText_16;
            this.rbtnTextSelectTool.Tag = "TextSelectTool";
            this.rbtnTextSelectTool.Text = "Text Select Tool";
            this.rbtnTextSelectTool.ToolTip = resources.GetString("rbtnTextSelectTool.ToolTip");
            // 
            // rbtnPreviewFind
            // 
            this.rbtnPreviewFind.KeyTip = "F";
            this.rbtnPreviewFind.Name = "rbtnPreviewFind";
            this.rbtnPreviewFind.SmallImage = global::FlexReportDesignerApp.Img_Preview.Find_16;
            this.rbtnPreviewFind.Tag = "PreviewFind";
            this.rbtnPreviewFind.Text = "Find";
            this.rbtnPreviewFind.ToolTip = resources.GetString("rbtnPreviewFind.ToolTip");
            // 
            // rgExport
            // 
            this.rgExport.GroupKeyTip = "E";
            this.rgExport.Image = ((System.Drawing.Image)(resources.GetObject("rgExport.Image")));
            this.rgExport.Items.Add(this.rbtnExportPdf);
            this.rgExport.Items.Add(this.rbtnExportHtml);
            this.rgExport.Items.Add(this.rbtnExportXls);
            this.rgExport.Items.Add(this.ribbonSeparator20);
            this.rgExport.Items.Add(this.rbtnExportRtf);
            this.rgExport.Items.Add(this.rbtnExportDocx);
            this.rgExport.Items.Add(this.rmExportMore);
            this.rgExport.Name = "rgExport";
            this.rgExport.Text = "Export";
            // 
            // rbtnExportPdf
            // 
            this.rbtnExportPdf.Items.Add(this.rbtnExportPdf_A);
            this.rbtnExportPdf.Items.Add(this.rbtnExportPdf_linkedFonts);
            this.rbtnExportPdf.KeyTip = "EP";
            this.rbtnExportPdf.LargeImage = global::FlexReportDesignerApp.Img_Preview.ExportPDF_32;
            this.rbtnExportPdf.Name = "rbtnExportPdf";
            this.rbtnExportPdf.SmallImage = global::FlexReportDesignerApp.Img_Preview.ExportPDF_16;
            this.rbtnExportPdf.Tag = "_PDF_A";
            this.rbtnExportPdf.Text = "PDF";
            this.rbtnExportPdf.ToolTip = resources.GetString("rbtnExportPdf.ToolTip");
            // 
            // rbtnExportPdf_A
            // 
            this.rbtnExportPdf_A.Name = "rbtnExportPdf_A";
            this.rbtnExportPdf_A.Tag = "_PDF_A";
            this.rbtnExportPdf_A.Text = "PDF/A";
            this.rbtnExportPdf_A.ToolTip = "PDF/A (embedded fonts)";
            // 
            // rbtnExportPdf_linkedFonts
            // 
            this.rbtnExportPdf_linkedFonts.Name = "rbtnExportPdf_linkedFonts";
            this.rbtnExportPdf_linkedFonts.Tag = "_PDF";
            this.rbtnExportPdf_linkedFonts.Text = "PDF (linked fonts)";
            this.rbtnExportPdf_linkedFonts.ToolTip = "PDF with linked (non-embedded) fonts";
            // 
            // rbtnExportHtml
            // 
            this.rbtnExportHtml.Items.Add(this.rbtnExportHtml2);
            this.rbtnExportHtml.Items.Add(this.rbtnExportHtmlPaged);
            this.rbtnExportHtml.KeyTip = "EH";
            this.rbtnExportHtml.LargeImage = global::FlexReportDesignerApp.Img_Preview.ExportHTM_32;
            this.rbtnExportHtml.Name = "rbtnExportHtml";
            this.rbtnExportHtml.SmallImage = global::FlexReportDesignerApp.Img_Preview.ExportHTM_16;
            this.rbtnExportHtml.Tag = "_HTML";
            this.rbtnExportHtml.Text = "HTML";
            this.rbtnExportHtml.ToolTip = resources.GetString("rbtnExportHtml.ToolTip");
            // 
            // rbtnExportHtml2
            // 
            this.rbtnExportHtml2.Name = "rbtnExportHtml2";
            this.rbtnExportHtml2.Tag = "_HTML";
            this.rbtnExportHtml2.Text = "Plain HTML";
            this.rbtnExportHtml2.ToolTip = "Export to plain HTML";
            // 
            // rbtnExportHtmlPaged
            // 
            this.rbtnExportHtmlPaged.Name = "rbtnExportHtmlPaged";
            this.rbtnExportHtmlPaged.Tag = "_PagedHTML";
            this.rbtnExportHtmlPaged.Text = "Paged HTML";
            this.rbtnExportHtmlPaged.ToolTip = "Export to paged HTML";
            // 
            // rbtnExportXls
            // 
            this.rbtnExportXls.Items.Add(this.rbtnExportXls2);
            this.rbtnExportXls.Items.Add(this.rbtnExportXlsx);
            this.rbtnExportXls.KeyTip = "EE";
            this.rbtnExportXls.LargeImage = global::FlexReportDesignerApp.Img_Preview.ExportXLS_32;
            this.rbtnExportXls.Name = "rbtnExportXls";
            this.rbtnExportXls.SmallImage = global::FlexReportDesignerApp.Img_Preview.ExportXLS_16;
            this.rbtnExportXls.Tag = "_XLS";
            this.rbtnExportXls.Text = "Excel";
            this.rbtnExportXls.ToolTip = resources.GetString("rbtnExportXls.ToolTip");
            // 
            // rbtnExportXls2
            // 
            this.rbtnExportXls2.Name = "rbtnExportXls2";
            this.rbtnExportXls2.Tag = "_XLS";
            this.rbtnExportXls2.Text = "Microsoft Excel";
            this.rbtnExportXls2.ToolTip = "Export to Microsoft Excel";
            // 
            // rbtnExportXlsx
            // 
            this.rbtnExportXlsx.Name = "rbtnExportXlsx";
            this.rbtnExportXlsx.Tag = "_XLSX";
            this.rbtnExportXlsx.Text = "Open XML Excel";
            this.rbtnExportXlsx.ToolTip = "Export to Open XML Excel";
            // 
            // ribbonSeparator20
            // 
            this.ribbonSeparator20.HiddenMode = true;
            this.ribbonSeparator20.Name = "ribbonSeparator20";
            // 
            // rbtnExportRtf
            // 
            this.rbtnExportRtf.KeyTip = "ER";
            this.rbtnExportRtf.Name = "rbtnExportRtf";
            this.rbtnExportRtf.SmallImage = global::FlexReportDesignerApp.Img_Preview.ExportRTF_16;
            this.rbtnExportRtf.Tag = "_RTF";
            this.rbtnExportRtf.Text = "RTF";
            this.rbtnExportRtf.ToolTip = resources.GetString("rbtnExportRtf.ToolTip");
            // 
            // rbtnExportDocx
            // 
            this.rbtnExportDocx.KeyTip = "EW";
            this.rbtnExportDocx.Name = "rbtnExportDocx";
            this.rbtnExportDocx.SmallImage = global::FlexReportDesignerApp.Img_Preview.ExportDOC_16;
            this.rbtnExportDocx.Tag = "_DOCX";
            this.rbtnExportDocx.Text = "Word";
            this.rbtnExportDocx.ToolTip = resources.GetString("rbtnExportDocx.ToolTip");
            // 
            // rmExportMore
            // 
            this.rmExportMore.Items.Add(this.rbtnExportMetafiles);
            this.rmExportMore.Items.Add(this.rbtnExportTIFF);
            this.rmExportMore.Items.Add(this.rbtnExportBMP);
            this.rmExportMore.Items.Add(this.rbtnExportPNG);
            this.rmExportMore.Items.Add(this.rbtnExportJPEG);
            this.rmExportMore.Items.Add(this.rbtnExportGIF);
            this.rmExportMore.KeyTip = "EM";
            this.rmExportMore.Name = "rmExportMore";
            this.rmExportMore.SmallImage = global::FlexReportDesignerApp.Img_Preview.ExportMore_16;
            this.rmExportMore.Text = "More";
            this.rmExportMore.ToolTip = resources.GetString("rmExportMore.ToolTip");
            // 
            // rbtnExportMetafiles
            // 
            this.rbtnExportMetafiles.Name = "rbtnExportMetafiles";
            this.rbtnExportMetafiles.Tag = "_ZIP";
            this.rbtnExportMetafiles.Text = "Compressed metafiles";
            this.rbtnExportMetafiles.ToolTip = "Export to metafiles in a zip archive";
            // 
            // rbtnExportTIFF
            // 
            this.rbtnExportTIFF.Name = "rbtnExportTIFF";
            this.rbtnExportTIFF.Tag = "_TIFF";
            this.rbtnExportTIFF.Text = "TIFF images";
            this.rbtnExportTIFF.ToolTip = "Export to Tagged Image File Format";
            // 
            // rbtnExportBMP
            // 
            this.rbtnExportBMP.Name = "rbtnExportBMP";
            this.rbtnExportBMP.Tag = "_BMP";
            this.rbtnExportBMP.Text = "Bitmap images";
            this.rbtnExportBMP.ToolTip = "Export to bitmap images";
            // 
            // rbtnExportPNG
            // 
            this.rbtnExportPNG.Name = "rbtnExportPNG";
            this.rbtnExportPNG.Tag = "_PNG";
            this.rbtnExportPNG.Text = "PNG images";
            this.rbtnExportPNG.ToolTip = "Export to Portable Network Graphic images";
            // 
            // rbtnExportJPEG
            // 
            this.rbtnExportJPEG.Name = "rbtnExportJPEG";
            this.rbtnExportJPEG.Tag = "_JPEG";
            this.rbtnExportJPEG.Text = "JPEG images";
            this.rbtnExportJPEG.ToolTip = "Export to JPEG images";
            // 
            // rbtnExportGIF
            // 
            this.rbtnExportGIF.Name = "rbtnExportGIF";
            this.rbtnExportGIF.Tag = "_GIF";
            this.rbtnExportGIF.Text = "GIF images";
            this.rbtnExportGIF.ToolTip = "Export to GIF images";
            // 
            // rgStopRefresh
            // 
            this.rgStopRefresh.GroupKeyTip = "G";
            this.rgStopRefresh.Items.Add(this.rbtnPreviewStop);
            this.rgStopRefresh.Items.Add(this.rbtnPreviewRefresh);
            this.rgStopRefresh.Name = "rgStopRefresh";
            this.rgStopRefresh.Text = "Generate";
            // 
            // rbtnPreviewStop
            // 
            this.chMain.SetC1Command(this.rbtnPreviewStop, this.cPreviewStop);
            this.rbtnPreviewStop.KeyTip = "O";
            this.rbtnPreviewStop.LargeImage = global::FlexReportDesignerApp.Img_Preview.Stop_32;
            this.rbtnPreviewStop.Name = "rbtnPreviewStop";
            this.rbtnPreviewStop.SmallImage = global::FlexReportDesignerApp.Img_Preview.Stop_16;
            this.rbtnPreviewStop.Tag = "PreviewStop";
            this.rbtnPreviewStop.Text = "Stop ";
            this.rbtnPreviewStop.ToolTip = resources.GetString("rbtnPreviewStop.ToolTip");
            // 
            // rbtnPreviewRefresh
            // 
            this.rbtnPreviewRefresh.KeyTip = "R";
            this.rbtnPreviewRefresh.LargeImage = global::FlexReportDesignerApp.Img_Preview.Refresh_32;
            this.rbtnPreviewRefresh.Name = "rbtnPreviewRefresh";
            this.rbtnPreviewRefresh.SmallImage = global::FlexReportDesignerApp.Img_Preview.Refresh_16;
            this.rbtnPreviewRefresh.Tag = "PreviewRefresh";
            this.rbtnPreviewRefresh.Text = "Refresh";
            this.rbtnPreviewRefresh.ToolTip = resources.GetString("rbtnPreviewRefresh.ToolTip");
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // c1CommandDock1
            // 
            this.c1CommandDock1.Controls.Add(this.c1DockingTab2);
            this.c1CommandDock1.Controls.Add(this.c1DockingTab1);
            this.c1CommandDock1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1CommandDock1.Id = 1;
            this.c1CommandDock1.Location = new System.Drawing.Point(0, 143);
            this.c1CommandDock1.Name = "c1CommandDock1";
            this.c1CommandDock1.Size = new System.Drawing.Size(274, 658);
            // 
            // c1DockingTab2
            // 
            this.c1DockingTab2.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.c1DockingTab2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1DockingTab2.CanAutoHide = true;
            this.c1DockingTab2.CanMoveTabs = true;
            this.c1DockingTab2.Controls.Add(this.dtpProperties);
            this.c1DockingTab2.Location = new System.Drawing.Point(0, 501);
            this.c1DockingTab2.Name = "c1DockingTab2";
            this.c1DockingTab2.ShowCaption = true;
            this.c1DockingTab2.Size = new System.Drawing.Size(274, 157);
            this.c1DockingTab2.TabIndex = 5;
            this.c1DockingTab2.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            //this.c1DockingTab2.TabStyle = C1.Win.Command.TabStyleEnum.Office2007;
            //this.c1DockingTab2.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue;
            // 
            // dtpProperties
            // 
            this.dtpProperties.CaptionVisible = true;
            this.dtpProperties.Controls.Add(this._propGrid);
            this.dtpProperties.Controls.Add(this.c1ToolBar2);
            this.dtpProperties.Controls.Add(this._fieldPicker);
            this.dtpProperties.Location = new System.Drawing.Point(0, 3);
            this.dtpProperties.Name = "dtpProperties";
            this.dtpProperties.Size = new System.Drawing.Size(271, 130);
            this.dtpProperties.TabIndex = 1;
            this.dtpProperties.Text = "Properties";
            // 
            // _propGrid
            // 
            this._propGrid.BackColor = System.Drawing.SystemColors.Control;
            this._propGrid.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this._propGrid.CommandsBackColor = System.Drawing.SystemColors.Window;
            this._propGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this._propGrid.LineColor = System.Drawing.SystemColors.Control;
            this._propGrid.Location = new System.Drawing.Point(0, 71);
            this._propGrid.Name = "_propGrid";
            this._propGrid.Size = new System.Drawing.Size(271, 59);
            this._propGrid.TabIndex = 2;
            this._propGrid.ToolbarVisible = false;
            // 
            // c1ToolBar2
            // 
            this.c1ToolBar2.AccessibleName = "Tool Bar";
            this.c1ToolBar2.AutoSize = false;
            this.c1ToolBar2.CommandHolder = this.chMain;
            this.c1ToolBar2.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink3,
            this.c1CommandLink4});
            this.c1ToolBar2.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1ToolBar2.Location = new System.Drawing.Point(0, 45);
            this.c1ToolBar2.Movable = false;
            this.c1ToolBar2.Name = "c1ToolBar2";
            this.c1ToolBar2.Size = new System.Drawing.Size(271, 26);
            this.c1ToolBar2.Text = "c1ToolBar2";
            //this.c1ToolBar2.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue;
            // 
            // chMain
            // 
            this.chMain.Commands.Add(this.cmNewReport);
            this.chMain.Commands.Add(this.cNewReportEmpty);
            this.chMain.Commands.Add(this.cNewReportWizard);
            this.chMain.Commands.Add(this.cPasteReport);
            this.chMain.Commands.Add(this.cCutReport);
            this.chMain.Commands.Add(this.cCopyReport);
            this.chMain.Commands.Add(this.cDeleteReport);
            this.chMain.Commands.Add(this.cMoveReportUp);
            this.chMain.Commands.Add(this.cMoveReportDown);
            this.chMain.Commands.Add(this.cPropertiesCategorized);
            this.chMain.Commands.Add(this.cPropertiesAlphabetical);
            this.chMain.Commands.Add(this.cmSelectAll);
            this.chMain.Commands.Add(this.cmCutField);
            this.chMain.Commands.Add(this.cmCopyField);
            this.chMain.Commands.Add(this.cmPasteField);
            this.chMain.Commands.Add(this.cmDeleteField);
            this.chMain.Commands.Add(this.cmBringToFront);
            this.chMain.Commands.Add(this.cmSendToBack);
            this.chMain.Commands.Add(this.cmReport);
            this.chMain.Commands.Add(this._cmDesigner);
            this.chMain.Commands.Add(this.cLockFields);
            this.chMain.Commands.Add(this.cPreviewStop);
            this.chMain.Commands.Add(this.cPreviewRefresh);
            this.chMain.Commands.Add(this.cScriptEditor);
            this.chMain.Commands.Add(this._cContextPlaceholderTop);
            this.chMain.Commands.Add(this._cContextPlaceholderBot);
            this.chMain.Commands.Add(this.cmDataTree);
            this.chMain.Commands.Add(this.cAddDataSource);
            this.chMain.Commands.Add(this.cAddParameter);
            this.chMain.Commands.Add(this.cAddCalculatedField);
            this.chMain.Commands.Add(this.cAddSort);
            this.chMain.Commands.Add(this.cDataTreeDelete);
            this.chMain.Commands.Add(this.cDataTreeInsert);
            this.chMain.Commands.Add(this.cDataTreeInplaceEdit);
            this.chMain.Commands.Add(this.cDataTreeChangeSortOrder);
            this.chMain.Commands.Add(this.cDataTreeEdit);
            this.chMain.Commands.Add(this.cDataTreeMoveUp);
            this.chMain.Commands.Add(this.cDataTreeMoveDown);
            this.chMain.Commands.Add(this.cmDataTreeAdd);
            this.chMain.Commands.Add(this.cmProperties);
            this.chMain.Commands.Add(this.cmPreview);
            this.chMain.Commands.Add(this.cPreviewCopy);
            this.chMain.Commands.Add(this.cDataSourceRefresh);
            this.chMain.Commands.Add(this.cmErrorList);
            this.chMain.Commands.Add(this.cErrorListHide);
            this.chMain.Commands.Add(this.cErrorListClear);
            this.chMain.Commands.Add(this.cErrorListShow);
            this.chMain.Commands.Add(this.cErrorListCopy);
            this.chMain.ImageList = this.ilReportList;
            this.chMain.Owner = this;
            this.chMain.StateUpdateOnIdle = false;
            this.chMain.CommandClick += new C1.Win.Command.CommandClickEventHandler(this.chMain_CommandClick);
            // 
            // cAddDataSource
            // 
            this.cAddDataSource.Image = ((System.Drawing.Image)(resources.GetObject("cAddDataSource.Image")));
            this.cAddDataSource.Name = "cAddDataSource";
            this.cAddDataSource.ShortcutText = "";
            this.cAddDataSource.Text = "Add Data Source";
            this.cAddDataSource.ToolTipText = "Add a new data source to the current report\'s DataSources collection.";
            // 
            // cPreviewStop
            // 
            this.cPreviewStop.Name = "cPreviewStop";
            this.cPreviewStop.ShortcutText = "";
            this.cPreviewStop.Text = "Stop";
            // 
            // cmNewReport
            // 
            this.cmNewReport.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink11,
            this.c1CommandLink12});
            this.cmNewReport.HideNonRecentLinks = false;
            this.cmNewReport.Image = ((System.Drawing.Image)(resources.GetObject("cmNewReport.Image")));
            this.cmNewReport.Name = "cmNewReport";
            this.cmNewReport.ShortcutText = "";
            this.cmNewReport.ShowToolTips = true;
            this.cmNewReport.Text = "New Report";
            // 
            // c1CommandLink11
            // 
            this.c1CommandLink11.Command = this.cNewReportWizard;
            // 
            // cNewReportWizard
            // 
            this.cNewReportWizard.Image = ((System.Drawing.Image)(resources.GetObject("cNewReportWizard.Image")));
            this.cNewReportWizard.Name = "cNewReportWizard";
            this.cNewReportWizard.ShortcutText = "";
            this.cNewReportWizard.Text = "Report Wizard...";
            this.cNewReportWizard.ToolTipText = "Run report wizard to create a new report";
            this.cNewReportWizard.UserData = "NewReportWizard";
            // 
            // c1CommandLink12
            // 
            this.c1CommandLink12.Command = this.cNewReportEmpty;
            this.c1CommandLink12.SortOrder = 1;
            // 
            // cNewReportEmpty
            // 
            this.cNewReportEmpty.Image = ((System.Drawing.Image)(resources.GetObject("cNewReportEmpty.Image")));
            this.cNewReportEmpty.Name = "cNewReportEmpty";
            this.cNewReportEmpty.ShortcutText = "";
            this.cNewReportEmpty.Text = "Empty Report";
            this.cNewReportEmpty.ToolTipText = "Create empty new report";
            this.cNewReportEmpty.UserData = "NewReportEmpty";
            // 
            // cPasteReport
            // 
            this.cPasteReport.Image = ((System.Drawing.Image)(resources.GetObject("cPasteReport.Image")));
            this.cPasteReport.Name = "cPasteReport";
            this.cPasteReport.ShortcutText = "";
            this.cPasteReport.Text = "Paste";
            this.cPasteReport.ToolTipText = "Paste (Ctrl+V)";
            this.cPasteReport.UserData = "PasteReport";
            // 
            // cCutReport
            // 
            this.cCutReport.Image = ((System.Drawing.Image)(resources.GetObject("cCutReport.Image")));
            this.cCutReport.Name = "cCutReport";
            this.cCutReport.ShortcutText = "";
            this.cCutReport.Text = "Cut";
            this.cCutReport.ToolTipText = "Cut (Ctrl+X)";
            this.cCutReport.UserData = "CutReport";
            // 
            // cCopyReport
            // 
            this.cCopyReport.Image = ((System.Drawing.Image)(resources.GetObject("cCopyReport.Image")));
            this.cCopyReport.Name = "cCopyReport";
            this.cCopyReport.ShortcutText = "";
            this.cCopyReport.Text = "Copy";
            this.cCopyReport.ToolTipText = "Copy (Ctrl+C)";
            this.cCopyReport.UserData = "CopyReport";
            // 
            // cDeleteReport
            // 
            this.cDeleteReport.Image = ((System.Drawing.Image)(resources.GetObject("cDeleteReport.Image")));
            this.cDeleteReport.Name = "cDeleteReport";
            this.cDeleteReport.ShortcutText = "";
            this.cDeleteReport.Text = "Delete Report";
            this.cDeleteReport.ToolTipText = "Delete selected report (Del)";
            this.cDeleteReport.UserData = "DeleteReport";
            // 
            // cMoveReportUp
            // 
            this.cMoveReportUp.Image = ((System.Drawing.Image)(resources.GetObject("cMoveReportUp.Image")));
            this.cMoveReportUp.Name = "cMoveReportUp";
            this.cMoveReportUp.ShortcutText = "";
            this.cMoveReportUp.Text = "Move Report Up";
            this.cMoveReportUp.ToolTipText = "Move report up";
            this.cMoveReportUp.UserData = "MoveReportUp";
            // 
            // cMoveReportDown
            // 
            this.cMoveReportDown.Image = ((System.Drawing.Image)(resources.GetObject("cMoveReportDown.Image")));
            this.cMoveReportDown.Name = "cMoveReportDown";
            this.cMoveReportDown.ShortcutText = "";
            this.cMoveReportDown.Text = "Move Report Down";
            this.cMoveReportDown.ToolTipText = "Move report down";
            this.cMoveReportDown.UserData = "MoveReportDown";
            // 
            // cPropertiesCategorized
            // 
            this.cPropertiesCategorized.Image = ((System.Drawing.Image)(resources.GetObject("cPropertiesCategorized.Image")));
            this.cPropertiesCategorized.Name = "cPropertiesCategorized";
            this.cPropertiesCategorized.ShortcutText = "";
            this.cPropertiesCategorized.Text = "Categorized";
            this.cPropertiesCategorized.ToolTipText = "Group properties into categories";
            this.cPropertiesCategorized.UserData = "PropertiesCategorized";
            // 
            // cPropertiesAlphabetical
            // 
            this.cPropertiesAlphabetical.Image = ((System.Drawing.Image)(resources.GetObject("cPropertiesAlphabetical.Image")));
            this.cPropertiesAlphabetical.Name = "cPropertiesAlphabetical";
            this.cPropertiesAlphabetical.ShortcutText = "";
            this.cPropertiesAlphabetical.Text = "Alphabetical";
            this.cPropertiesAlphabetical.ToolTipText = "Show properties in alphabetical order";
            this.cPropertiesAlphabetical.UserData = "PropertiesAlphabetical";
            // 
            // cmSelectAll
            // 
            this.cmSelectAll.Name = "cmSelectAll";
            this.cmSelectAll.ShortcutText = "";
            this.cmSelectAll.Text = "Select All (Ctrl+A)";
            this.cmSelectAll.UserData = "SelectAll";
            // 
            // cmCutField
            // 
            this.cmCutField.Name = "cmCutField";
            this.cmCutField.ShortcutText = "";
            this.cmCutField.Text = "Cut (Ctrl+X)";
            this.cmCutField.UserData = "Cut";
            // 
            // cmCopyField
            // 
            this.cmCopyField.Image = ((System.Drawing.Image)(resources.GetObject("cmCopyField.Image")));
            this.cmCopyField.Name = "cmCopyField";
            this.cmCopyField.ShortcutText = "";
            this.cmCopyField.Text = "Copy (Ctrl+C)";
            this.cmCopyField.UserData = "Copy";
            // 
            // cmPasteField
            // 
            this.cmPasteField.Image = ((System.Drawing.Image)(resources.GetObject("cmPasteField.Image")));
            this.cmPasteField.Name = "cmPasteField";
            this.cmPasteField.ShortcutText = "";
            this.cmPasteField.Text = "Paste (Ctrl+V)";
            this.cmPasteField.UserData = "Paste";
            // 
            // cmDeleteField
            // 
            this.cmDeleteField.Image = ((System.Drawing.Image)(resources.GetObject("cmDeleteField.Image")));
            this.cmDeleteField.Name = "cmDeleteField";
            this.cmDeleteField.ShortcutText = "";
            this.cmDeleteField.Text = "Delete (Del)";
            this.cmDeleteField.UserData = "Delete";
            // 
            // cmBringToFront
            // 
            this.cmBringToFront.Image = ((System.Drawing.Image)(resources.GetObject("cmBringToFront.Image")));
            this.cmBringToFront.Name = "cmBringToFront";
            this.cmBringToFront.ShortcutText = "";
            this.cmBringToFront.Text = "Bring to Front";
            this.cmBringToFront.UserData = "BringToFront";
            // 
            // cmSendToBack
            // 
            this.cmSendToBack.Image = ((System.Drawing.Image)(resources.GetObject("cmSendToBack.Image")));
            this.cmSendToBack.Name = "cmSendToBack";
            this.cmSendToBack.ShortcutText = "";
            this.cmSendToBack.Text = "Send to Back";
            this.cmSendToBack.UserData = "SendToBack";
            // 
            // cmReport
            // 
            this.cmReport.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink6,
            this.c1CommandLink25,
            this.c1CommandLink26,
            this.c1CommandLink27,
            this.c1CommandLink7,
            this.c1CommandLink8,
            this.c1CommandLink9});
            this.cmReport.Name = "cmReport";
            this.cmReport.ShortcutText = "";
            //this.cmReport.VisualStyle = C1.Win.Command.VisualStyle.Custom;
            //this.cmReport.VisualStyleBase = C1.Win.Command.VisualStyle.Custom;
            // 
            // c1CommandLink6
            // 
            this.c1CommandLink6.Command = this.cNewReportEmpty;
            // 
            // c1CommandLink25
            // 
            this.c1CommandLink25.Command = this.cCutReport;
            this.c1CommandLink25.Delimiter = true;
            this.c1CommandLink25.SortOrder = 1;
            // 
            // c1CommandLink26
            // 
            this.c1CommandLink26.Command = this.cCopyReport;
            this.c1CommandLink26.SortOrder = 2;
            // 
            // c1CommandLink27
            // 
            this.c1CommandLink27.Command = this.cPasteReport;
            this.c1CommandLink27.SortOrder = 3;
            // 
            // c1CommandLink7
            // 
            this.c1CommandLink7.Command = this.cDeleteReport;
            this.c1CommandLink7.SortOrder = 4;
            // 
            // c1CommandLink8
            // 
            this.c1CommandLink8.Command = this.cMoveReportUp;
            this.c1CommandLink8.Delimiter = true;
            this.c1CommandLink8.SortOrder = 5;
            // 
            // c1CommandLink9
            // 
            this.c1CommandLink9.Command = this.cMoveReportDown;
            this.c1CommandLink9.SortOrder = 6;
            // 
            // _cmDesigner
            // 
            this._cmDesigner.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink14,
            this.c1CommandLink15,
            this.c1CommandLink16,
            this.c1CommandLink17,
            this.c1CommandLink13,
            this.c1CommandLink18,
            this.c1CommandLink19,
            this.c1CommandLink28,
            this._clContextPlaceholderTop,
            this._clContextPlaceholderBot,
            this.c1CommandLink10});
            this._cmDesigner.Name = "_cmDesigner";
            this._cmDesigner.ShortcutText = "";
            //this._cmDesigner.VisualStyleBase = C1.Win.Command.VisualStyle.Custom;
            // 
            // c1CommandLink14
            // 
            this.c1CommandLink14.Command = this.cmCutField;
            // 
            // c1CommandLink15
            // 
            this.c1CommandLink15.Command = this.cmCopyField;
            this.c1CommandLink15.SortOrder = 1;
            // 
            // c1CommandLink16
            // 
            this.c1CommandLink16.Command = this.cmPasteField;
            this.c1CommandLink16.SortOrder = 2;
            // 
            // c1CommandLink17
            // 
            this.c1CommandLink17.Command = this.cmDeleteField;
            this.c1CommandLink17.SortOrder = 3;
            // 
            // c1CommandLink13
            // 
            this.c1CommandLink13.Command = this.cmSelectAll;
            this.c1CommandLink13.SortOrder = 4;
            // 
            // c1CommandLink18
            // 
            this.c1CommandLink18.Command = this.cmBringToFront;
            this.c1CommandLink18.Delimiter = true;
            this.c1CommandLink18.SortOrder = 5;
            // 
            // c1CommandLink19
            // 
            this.c1CommandLink19.Command = this.cmSendToBack;
            this.c1CommandLink19.SortOrder = 6;
            // 
            // c1CommandLink28
            // 
            this.c1CommandLink28.Command = this.cLockFields;
            this.c1CommandLink28.SortOrder = 7;
            // 
            // cLockFields
            // 
            this.cLockFields.Image = ((System.Drawing.Image)(resources.GetObject("cLockFields.Image")));
            this.cLockFields.Name = "cLockFields";
            this.cLockFields.ShortcutText = "";
            this.cLockFields.Text = "Lock All Fields";
            this.cLockFields.UserData = "LockFields";
            // 
            // _clContextPlaceholderTop
            // 
            this._clContextPlaceholderTop.Command = this._cContextPlaceholderTop;
            this._clContextPlaceholderTop.Delimiter = true;
            this._clContextPlaceholderTop.SortOrder = 8;
            // 
            // _cContextPlaceholderTop
            // 
            this._cContextPlaceholderTop.Name = "_cContextPlaceholderTop";
            this._cContextPlaceholderTop.ShortcutText = "";
            this._cContextPlaceholderTop.Visible = false;
            // 
            // _clContextPlaceholderBot
            // 
            this._clContextPlaceholderBot.Command = this._cContextPlaceholderBot;
            this._clContextPlaceholderBot.Delimiter = true;
            this._clContextPlaceholderBot.SortOrder = 9;
            // 
            // _cContextPlaceholderBot
            // 
            this._cContextPlaceholderBot.Name = "_cContextPlaceholderBot";
            this._cContextPlaceholderBot.ShortcutText = "";
            this._cContextPlaceholderBot.Visible = false;
            // 
            // c1CommandLink10
            // 
            this.c1CommandLink10.Command = this.cmProperties;
            this.c1CommandLink10.Delimiter = true;
            this.c1CommandLink10.SortOrder = 10;
            // 
            // cmProperties
            // 
            this.cmProperties.Name = "cmProperties";
            this.cmProperties.ShortcutText = "";
            this.cmProperties.Text = "Properties (Alt+Enter)";
            // 
            // cPreviewRefresh
            // 
            this.cPreviewRefresh.Name = "cPreviewRefresh";
            this.cPreviewRefresh.ShortcutText = "";
            this.cPreviewRefresh.Text = "Refresh";
            // 
            // cScriptEditor
            // 
            this.cScriptEditor.Name = "cScriptEditor";
            this.cScriptEditor.Shortcut = System.Windows.Forms.Shortcut.F7;
            this.cScriptEditor.ShortcutText = "";
            // 
            // cmDataTree
            // 
            this.cmDataTree.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.clAddParameter,
            this.clAddDataSource,
            this.clAddCalculatedField,
            this.clAddSort,
            this.clDataTreeEdit,
            this.clDataTreeChangeSortOrder,
            this.clDataTreeInplaceEdit,
            this.clDataTreeMoveUp,
            this.clDataTreeMoveDown,
            this.clDataTreeDelete});
            this.cmDataTree.Name = "cmDataTree";
            this.cmDataTree.ShortcutText = "";
            //this.cmDataTree.VisualStyle = C1.Win.Command.VisualStyle.Custom;
            //this.cmDataTree.VisualStyleBase = C1.Win.Command.VisualStyle.Custom;
            // 
            // clAddParameter
            // 
            this.clAddParameter.Command = this.cAddParameter;
            this.clAddParameter.Text = "Add Parameter";
            this.clAddParameter.ToolTipText = "Add Parameter (Ctrl+X)";
            // 
            // cAddParameter
            // 
            this.cAddParameter.Image = ((System.Drawing.Image)(resources.GetObject("cAddParameter.Image")));
            this.cAddParameter.Name = "cAddParameter";
            this.cAddParameter.ShortcutText = "";
            this.cAddParameter.Text = "Add Parameter";
            // 
            // clAddDataSource
            // 
            this.clAddDataSource.Command = this.cAddDataSource;
            this.clAddDataSource.SortOrder = 1;
            this.clAddDataSource.Text = "Add Data Source";
            this.clAddDataSource.ToolTipText = "Add Data Source (Ctrl+N)";
            // 
            // clAddCalculatedField
            // 
            this.clAddCalculatedField.Command = this.cAddCalculatedField;
            this.clAddCalculatedField.SortOrder = 2;
            // 
            // cAddCalculatedField
            // 
            this.cAddCalculatedField.Image = ((System.Drawing.Image)(resources.GetObject("cAddCalculatedField.Image")));
            this.cAddCalculatedField.Name = "cAddCalculatedField";
            this.cAddCalculatedField.ShortcutText = "";
            this.cAddCalculatedField.Text = "Add Calculated Field";
            // 
            // clAddSort
            // 
            this.clAddSort.Command = this.cAddSort;
            this.clAddSort.SortOrder = 3;
            // 
            // cAddSort
            // 
            this.cAddSort.Image = ((System.Drawing.Image)(resources.GetObject("cAddSort.Image")));
            this.cAddSort.Name = "cAddSort";
            this.cAddSort.ShortcutText = "";
            this.cAddSort.Text = "Add Sort Definition";
            // 
            // clDataTreeEdit
            // 
            this.clDataTreeEdit.Command = this.cDataTreeEdit;
            this.clDataTreeEdit.Delimiter = true;
            this.clDataTreeEdit.SortOrder = 4;
            // 
            // cDataTreeEdit
            // 
            this.cDataTreeEdit.Image = ((System.Drawing.Image)(resources.GetObject("cDataTreeEdit.Image")));
            this.cDataTreeEdit.Name = "cDataTreeEdit";
            this.cDataTreeEdit.ShortcutText = "";
            this.cDataTreeEdit.Text = "Edit";
            // 
            // clDataTreeChangeSortOrder
            // 
            this.clDataTreeChangeSortOrder.Command = this.cDataTreeChangeSortOrder;
            this.clDataTreeChangeSortOrder.SortOrder = 5;
            // 
            // cDataTreeChangeSortOrder
            // 
            this.cDataTreeChangeSortOrder.Image = ((System.Drawing.Image)(resources.GetObject("cDataTreeChangeSortOrder.Image")));
            this.cDataTreeChangeSortOrder.Name = "cDataTreeChangeSortOrder";
            this.cDataTreeChangeSortOrder.ShortcutText = "";
            this.cDataTreeChangeSortOrder.Text = "Change Sort Order";
            // 
            // clDataTreeInplaceEdit
            // 
            this.clDataTreeInplaceEdit.Command = this.cDataTreeInplaceEdit;
            this.clDataTreeInplaceEdit.SortOrder = 6;
            // 
            // cDataTreeInplaceEdit
            // 
            this.cDataTreeInplaceEdit.Name = "cDataTreeInplaceEdit";
            this.cDataTreeInplaceEdit.ShortcutText = "";
            this.cDataTreeInplaceEdit.Text = "Rename";
            // 
            // clDataTreeMoveUp
            // 
            this.clDataTreeMoveUp.Command = this.cDataTreeMoveUp;
            this.clDataTreeMoveUp.Delimiter = true;
            this.clDataTreeMoveUp.SortOrder = 7;
            // 
            // cDataTreeMoveUp
            // 
            this.cDataTreeMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("cDataTreeMoveUp.Image")));
            this.cDataTreeMoveUp.Name = "cDataTreeMoveUp";
            this.cDataTreeMoveUp.ShortcutText = "";
            this.cDataTreeMoveUp.Text = "Move Up";
            // 
            // clDataTreeMoveDown
            // 
            this.clDataTreeMoveDown.Command = this.cDataTreeMoveDown;
            this.clDataTreeMoveDown.SortOrder = 8;
            // 
            // cDataTreeMoveDown
            // 
            this.cDataTreeMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("cDataTreeMoveDown.Image")));
            this.cDataTreeMoveDown.Name = "cDataTreeMoveDown";
            this.cDataTreeMoveDown.ShortcutText = "";
            this.cDataTreeMoveDown.Text = "Move Down";
            // 
            // clDataTreeDelete
            // 
            this.clDataTreeDelete.Command = this.cDataTreeDelete;
            this.clDataTreeDelete.Delimiter = true;
            this.clDataTreeDelete.SortOrder = 9;
            // 
            // cDataTreeDelete
            // 
            this.cDataTreeDelete.Image = ((System.Drawing.Image)(resources.GetObject("cDataTreeDelete.Image")));
            this.cDataTreeDelete.Name = "cDataTreeDelete";
            this.cDataTreeDelete.ShortcutText = "";
            this.cDataTreeDelete.Text = "Delete";
            // 
            // cDataTreeInsert
            // 
            this.cDataTreeInsert.Image = ((System.Drawing.Image)(resources.GetObject("cDataTreeInsert.Image")));
            this.cDataTreeInsert.Name = "cDataTreeInsert";
            this.cDataTreeInsert.ShortcutText = "";
            this.cDataTreeInsert.Text = "Add";
            this.cDataTreeInsert.ToolTipText = "Add Parameter, Data Source, Calculated Field or Sort Definition.";
            // 
            // cmDataTreeAdd
            // 
            this.cmDataTreeAdd.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink37,
            this.c1CommandLink38,
            this.c1CommandLink39,
            this.c1CommandLink40});
            this.cmDataTreeAdd.HideNonRecentLinks = false;
            this.cmDataTreeAdd.Image = ((System.Drawing.Image)(resources.GetObject("cmDataTreeAdd.Image")));
            this.cmDataTreeAdd.Name = "cmDataTreeAdd";
            this.cmDataTreeAdd.ShortcutText = "";
            this.cmDataTreeAdd.ShowToolTips = true;
            this.cmDataTreeAdd.Text = "Add...";
            // 
            // c1CommandLink37
            // 
            this.c1CommandLink37.Command = this.cAddParameter;
            // 
            // c1CommandLink38
            // 
            this.c1CommandLink38.Command = this.cAddDataSource;
            this.c1CommandLink38.SortOrder = 1;
            // 
            // c1CommandLink39
            // 
            this.c1CommandLink39.Command = this.cAddCalculatedField;
            this.c1CommandLink39.SortOrder = 2;
            // 
            // c1CommandLink40
            // 
            this.c1CommandLink40.Command = this.cAddSort;
            this.c1CommandLink40.SortOrder = 3;
            // 
            // cmPreview
            // 
            this.cmPreview.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink5});
            this.cmPreview.Name = "cmPreview";
            this.cmPreview.ShortcutText = "";
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Command = this.cPreviewCopy;
            // 
            // cPreviewCopy
            // 
            this.cPreviewCopy.Image = ((System.Drawing.Image)(resources.GetObject("cPreviewCopy.Image")));
            this.cPreviewCopy.Name = "cPreviewCopy";
            this.cPreviewCopy.ShortcutText = "";
            this.cPreviewCopy.Text = "Copy (Ctrl+C)";
            // 
            // cDataSourceRefresh
            // 
            this.cDataSourceRefresh.Image = ((System.Drawing.Image)(resources.GetObject("cDataSourceRefresh.Image")));
            this.cDataSourceRefresh.Name = "cDataSourceRefresh";
            this.cDataSourceRefresh.ShortcutText = "";
            this.cDataSourceRefresh.Text = "Refresh";
            this.cDataSourceRefresh.ToolTipText = "Refresh Data Source Info";
            // 
            // cmErrorList
            // 
            this.cmErrorList.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink30,
            this.c1CommandLink31,
            this.c1CommandLink32});
            this.cmErrorList.Name = "cmErrorList";
            this.cmErrorList.ShortcutText = "";
            // 
            // c1CommandLink30
            // 
            this.c1CommandLink30.Command = this.cErrorListHide;
            // 
            // cErrorListHide
            // 
            this.cErrorListHide.Name = "cErrorListHide";
            this.cErrorListHide.ShortcutText = "";
            this.cErrorListHide.Text = "Hide";
            // 
            // c1CommandLink31
            // 
            this.c1CommandLink31.Command = this.cErrorListClear;
            this.c1CommandLink31.SortOrder = 1;
            // 
            // cErrorListClear
            // 
            this.cErrorListClear.Name = "cErrorListClear";
            this.cErrorListClear.ShortcutText = "";
            this.cErrorListClear.Text = "Clear";
            // 
            // c1CommandLink32
            // 
            this.c1CommandLink32.Command = this.cErrorListCopy;
            this.c1CommandLink32.Delimiter = true;
            this.c1CommandLink32.SortOrder = 2;
            // 
            // cErrorListCopy
            // 
            this.cErrorListCopy.Image = ((System.Drawing.Image)(resources.GetObject("cErrorListCopy.Image")));
            this.cErrorListCopy.Name = "cErrorListCopy";
            this.cErrorListCopy.ShortcutText = "";
            this.cErrorListCopy.Text = "Copy";
            this.cErrorListCopy.UserData = "ErrorListCopy";
            // 
            // cErrorListShow
            // 
            this.cErrorListShow.Name = "cErrorListShow";
            this.cErrorListShow.ShortcutText = "";
            this.cErrorListShow.Text = "Show Error List";
            // 
            // ilReportList
            // 
            this.ilReportList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilReportList.ImageStream")));
            this.ilReportList.TransparentColor = System.Drawing.Color.Transparent;
            this.ilReportList.Images.SetKeyName(0, "ReportListItem_16x16.png");
            this.ilReportList.Images.SetKeyName(1, "ReportContainerListItem_16x16.png");
            this.ilReportList.Images.SetKeyName(2, "Databases_SmallImage.png");
            this.ilReportList.Images.SetKeyName(3, "Database_SmallImage.PNG");
            this.ilReportList.Images.SetKeyName(4, "DatabaseField_SmallImage.PNG");
            this.ilReportList.Images.SetKeyName(5, "FieldBoundImage_SmallImage.PNG");
            this.ilReportList.Images.SetKeyName(6, "FieldCalculated_SmallImage.PNG");
            this.ilReportList.Images.SetKeyName(7, "Parameters_SmallImage.PNG");
            this.ilReportList.Images.SetKeyName(8, "Parameter_SmallImage.png");
            this.ilReportList.Images.SetKeyName(9, "Delete_SmallImage.PNG");
            // 
            // _flexDesigner
            // 
            this._flexDesigner.AllowDrop = true;
            this.chMain.SetC1ContextMenu(this._flexDesigner, this._cmDesigner);
            this._flexDesigner.CreateFieldInfo = null;
            this._flexDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexDesigner.Location = new System.Drawing.Point(274, 143);
            this._flexDesigner.Name = "_flexDesigner";
            this._flexDesigner.Report = null;
            this._flexDesigner.Size = new System.Drawing.Size(1036, 658);
            this._flexDesigner.TabIndex = 4;
            this._flexDesigner.Text = "c1FlexReportDesigner1";
            this._flexDesigner.ZoomFactor = 1F;
            // 
            // _reportList
            // 
            this._reportList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chMain.SetC1ContextMenu(this._reportList, this.cmReport);
            this._reportList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._reportList.FullRowSelect = true;
            this._reportList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this._reportList.HideSelection = false;
            this._reportList.LabelEdit = true;
            this._reportList.Location = new System.Drawing.Point(0, 50);
            this._reportList.MultiSelect = false;
            this._reportList.Name = "_reportList";
            this._reportList.Size = new System.Drawing.Size(271, 424);
            this._reportList.SmallImageList = this.ilReportList;
            this._reportList.TabIndex = 1;
            this._reportList.UseCompatibleStateImageBehavior = false;
            this._reportList.View = System.Windows.Forms.View.Details;
            this._reportList.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this._reportList_AfterLabelEdit);
            this._reportList.SelectedIndexChanged += new System.EventHandler(this._reportList_SelectedIndexChanged);
            this._reportList.DragDrop += new System.Windows.Forms.DragEventHandler(this._reportList_DragDrop);
            this._reportList.DragOver += new System.Windows.Forms.DragEventHandler(this._reportList_DragOver);
            this._reportList.DoubleClick += new System.EventHandler(this._reportList_DoubleClick);
            this._reportList.MouseDown += new System.Windows.Forms.MouseEventHandler(this._reportList_MouseDown);
            this._reportList.MouseMove += new System.Windows.Forms.MouseEventHandler(this._reportList_MouseMove);
            // 
            // _dataTree
            // 
            this._dataTree.BackColor = System.Drawing.Color.Cyan;
            this.chMain.SetC1ContextMenu(this._dataTree, this.cmDataTree);
            this._dataTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataTree.FlexDesigner = null;
            this._dataTree.Location = new System.Drawing.Point(0, 50);
            this._dataTree.Name = "_dataTree";
            this._dataTree.Size = new System.Drawing.Size(271, 424);
            this._dataTree.TabIndex = 4;
            // 
            // _errorList
            // 
            this._errorList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.chMain.SetC1ContextMenu(this._errorList, this.cmErrorList);
            this._errorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this._errorList.Location = new System.Drawing.Point(0, 24);
            this._errorList.Name = "_errorList";
            this._errorList.Settings = "64, 256, 64";
            this._errorList.Size = new System.Drawing.Size(271, 450);
            this._errorList.TabIndex = 0;
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.Command = this.cPropertiesCategorized;
            this.c1CommandLink3.Text = "New Command";
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.cPropertiesAlphabetical;
            this.c1CommandLink4.SortOrder = 1;
            this.c1CommandLink4.Text = "New Command";
            // 
            // _fieldPicker
            // 
            this._fieldPicker.Designer = this._flexDesigner;
            this._fieldPicker.Dock = System.Windows.Forms.DockStyle.Top;
            this._fieldPicker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this._fieldPicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._fieldPicker.FormattingEnabled = true;
            this._fieldPicker.Location = new System.Drawing.Point(0, 24);
            this._fieldPicker.Name = "_fieldPicker";
            this._fieldPicker.Size = new System.Drawing.Size(271, 21);
            this._fieldPicker.TabIndex = 4;
            // 
            // c1DockingTab1
            // 
            this.c1DockingTab1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.c1DockingTab1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1DockingTab1.CanAutoHide = true;
            this.c1DockingTab1.CanMoveTabs = true;
            this.c1DockingTab1.Controls.Add(this.dtpReports);
            this.c1DockingTab1.Controls.Add(this.dtpData);
            this.c1DockingTab1.Controls.Add(this.dtpErrors);
            this.c1DockingTab1.Location = new System.Drawing.Point(0, 0);
            this.c1DockingTab1.Name = "c1DockingTab1";
            this.c1DockingTab1.SelectedIndex = 5;
            this.c1DockingTab1.ShowCaption = true;
            this.c1DockingTab1.Size = new System.Drawing.Size(274, 501);
            this.c1DockingTab1.TabIndex = 0;
            this.c1DockingTab1.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            //this.c1DockingTab1.TabStyle = C1.Win.Command.TabStyle.Office2007;
            //this.c1DockingTab1.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue;
            // 
            // dtpReports
            // 
            this.dtpReports.CaptionVisible = true;
            this.dtpReports.Controls.Add(this._reportList);
            this.dtpReports.Controls.Add(this.c1ToolBar1);
            this.dtpReports.Location = new System.Drawing.Point(0, 0);
            this.dtpReports.Name = "dtpReports";
            this.dtpReports.Size = new System.Drawing.Size(271, 474);
            this.dtpReports.TabIndex = 0;
            this.dtpReports.Text = "Reports";
            // 
            // c1ToolBar1
            // 
            this.c1ToolBar1.AccessibleName = "Tool Bar";
            this.c1ToolBar1.AutoSize = false;
            this.c1ToolBar1.CommandHolder = this.chMain;
            this.c1ToolBar1.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink23,
            this.c1CommandLink24,
            this.c1CommandLink22,
            this.c1CommandLink2,
            this.c1CommandLink20,
            this.c1CommandLink21});
            this.c1ToolBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.c1ToolBar1.Location = new System.Drawing.Point(0, 24);
            this.c1ToolBar1.Movable = false;
            this.c1ToolBar1.Name = "c1ToolBar1";
            this.c1ToolBar1.Size = new System.Drawing.Size(271, 26);
            this.c1ToolBar1.Text = "c1ToolBar1";
            //this.c1ToolBar1.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue;
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.ButtonLook = ((C1.Win.Command.ButtonLookFlags)((C1.Win.Command.ButtonLookFlags.Text | C1.Win.Command.ButtonLookFlags.Image)));
            this.c1CommandLink1.Command = this.cmNewReport;
            // 
            // c1CommandLink23
            // 
            this.c1CommandLink23.ButtonLook = C1.Win.Command.ButtonLookFlags.Image;
            this.c1CommandLink23.Command = this.cCutReport;
            this.c1CommandLink23.Delimiter = true;
            this.c1CommandLink23.SortOrder = 1;
            // 
            // c1CommandLink24
            // 
            this.c1CommandLink24.ButtonLook = C1.Win.Command.ButtonLookFlags.Image;
            this.c1CommandLink24.Command = this.cCopyReport;
            this.c1CommandLink24.SortOrder = 2;
            // 
            // c1CommandLink22
            // 
            this.c1CommandLink22.ButtonLook = C1.Win.Command.ButtonLookFlags.Image;
            this.c1CommandLink22.Command = this.cPasteReport;
            this.c1CommandLink22.SortOrder = 3;
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.ButtonLook = C1.Win.Command.ButtonLookFlags.Image;
            this.c1CommandLink2.Command = this.cDeleteReport;
            this.c1CommandLink2.SortOrder = 4;
            // 
            // c1CommandLink20
            // 
            this.c1CommandLink20.ButtonLook = C1.Win.Command.ButtonLookFlags.Image;
            this.c1CommandLink20.Command = this.cMoveReportUp;
            this.c1CommandLink20.Delimiter = true;
            this.c1CommandLink20.SortOrder = 5;
            // 
            // c1CommandLink21
            // 
            this.c1CommandLink21.ButtonLook = C1.Win.Command.ButtonLookFlags.Image;
            this.c1CommandLink21.Command = this.cMoveReportDown;
            this.c1CommandLink21.SortOrder = 6;
            this.c1CommandLink21.Text = "`";
            // 
            // dtpData
            // 
            this.dtpData.CaptionVisible = true;
            this.dtpData.Controls.Add(this._dataTree);
            this.dtpData.Controls.Add(this.toolbarData);
            this.dtpData.Location = new System.Drawing.Point(0, 0);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(271, 474);
            this.dtpData.TabIndex = 4;
            this.dtpData.Text = "Data";
            // 
            // toolbarData
            // 
            this.toolbarData.AccessibleName = "Tool Bar";
            this.toolbarData.AutoSize = false;
            this.toolbarData.CommandHolder = this.chMain;
            this.toolbarData.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink36,
            this.c1CommandLink41,
            this.c1CommandLink35,
            this.c1CommandLink34,
            this.c1CommandLink42,
            this.c1CommandLink43,
            this.c1CommandLink29});
            this.toolbarData.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolbarData.Location = new System.Drawing.Point(0, 24);
            this.toolbarData.Movable = false;
            this.toolbarData.Name = "toolbarData";
            this.toolbarData.Size = new System.Drawing.Size(271, 26);
            this.toolbarData.Text = "c1ToolBar3";
            //this.toolbarData.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue;
            // 
            // c1CommandLink36
            // 
            this.c1CommandLink36.Command = this.cmDataTreeAdd;
            // 
            // c1CommandLink41
            // 
            this.c1CommandLink41.Command = this.cDataTreeEdit;
            this.c1CommandLink41.Delimiter = true;
            this.c1CommandLink41.SortOrder = 1;
            // 
            // c1CommandLink35
            // 
            this.c1CommandLink35.Command = this.cDataTreeChangeSortOrder;
            this.c1CommandLink35.SortOrder = 2;
            // 
            // c1CommandLink34
            // 
            this.c1CommandLink34.Command = this.cDataTreeDelete;
            this.c1CommandLink34.SortOrder = 3;
            // 
            // c1CommandLink42
            // 
            this.c1CommandLink42.Command = this.cDataTreeMoveUp;
            this.c1CommandLink42.Delimiter = true;
            this.c1CommandLink42.SortOrder = 4;
            // 
            // c1CommandLink43
            // 
            this.c1CommandLink43.Command = this.cDataTreeMoveDown;
            this.c1CommandLink43.SortOrder = 5;
            // 
            // c1CommandLink29
            // 
            this.c1CommandLink29.Command = this.cDataSourceRefresh;
            this.c1CommandLink29.Delimiter = true;
            this.c1CommandLink29.SortOrder = 6;
            // 
            // dtpErrors
            // 
            this.dtpErrors.CaptionVisible = true;
            this.dtpErrors.Controls.Add(this._errorList);
            this.dtpErrors.Location = new System.Drawing.Point(0, 0);
            this.dtpErrors.Name = "dtpErrors";
            this.dtpErrors.Size = new System.Drawing.Size(271, 474);
            this.dtpErrors.TabIndex = 5;
            this.dtpErrors.Text = "Errors";
            // 
            // _flexViewer
            // 
            this._flexViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flexViewer.Location = new System.Drawing.Point(274, 143);
            this._flexViewer.Name = "_flexViewer";
            this._flexViewer.Size = new System.Drawing.Size(1036, 658);
            this._flexViewer.TabIndex = 10;
            // 
            // _reportRender
            // 
            this._reportRender.ReportDefinition = resources.GetString("_reportRender.ReportDefinition");
            this._reportRender.ReportName = "";
            // 
            // rbtnFieldFlexChart
            // 
            this.rbtnFieldFlexChart.KeyTip = "Z";
            this.rbtnFieldFlexChart.LargeImage = global::FlexReportDesignerApp.Img_Insert.FldFlexChart_32;
            this.rbtnFieldFlexChart.Name = "rbtnFieldFlexChart";
            this.rbtnFieldFlexChart.SmallImage = global::FlexReportDesignerApp.Img_Insert.FldFlexChart_16;
            this.rbtnFieldFlexChart.Text = "FlexChart";
            this.rbtnFieldFlexChart.ToolTip = resources.GetString("rbtnFieldFlexChart.ToolTip");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 823);
            this.Controls.Add(this._flexViewer);
            this.Controls.Add(this._flexDesigner);
            this.Controls.Add(this.c1CommandDock1);
            this.Controls.Add(this.rbnMain);
            this.Controls.Add(this.sbMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FlexReportDesigner";
            //this.VisualStyleHolder = C1.Win.Ribbon.VisualStyle.Custom;
            ((System.ComponentModel.ISupportInitialize)(this.sbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbnMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandDock1)).EndInit();
            this.c1CommandDock1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab2)).EndInit();
            this.c1DockingTab2.ResumeLayout(false);
            this.dtpProperties.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DockingTab1)).EndInit();
            this.c1DockingTab1.ResumeLayout(false);
            this.dtpReports.ResumeLayout(false);
            this.dtpData.ResumeLayout(false);
            this.dtpErrors.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._flexViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void RbtnStatusZoom_DrawItem(object sender, C1.Win.Ribbon.DrawItemEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private C1.Win.Ribbon.C1StatusBar sbMain;
        private C1.Win.Ribbon.C1Ribbon rbnMain;
        private C1.Win.Ribbon.RibbonApplicationMenu ramMain;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab rtDesign;
        private C1.Win.Ribbon.RibbonGroup rgData;
        private C1.Win.Ribbon.RibbonButton rbtnNew;
        private C1.Win.Ribbon.RibbonButton rbtnOpen;
        private C1.Win.Ribbon.RibbonButton rbtnClose;
        private C1.Win.Ribbon.RibbonButton rbtnSave;
        private C1.Win.Ribbon.RibbonButton rbtnSaveAs;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator1;
        private C1.Win.Ribbon.RibbonButton rbtnImport;
        private C1.Win.Ribbon.RibbonButton rbtnExport;
        private C1.Win.Ribbon.RibbonButton rbtnExit;
        private C1.Win.Ribbon.RibbonButton rbtnOptions;
        private C1.Win.Ribbon.RibbonListItem ribbonListItem1;
        private C1.Win.Ribbon.RibbonLabel ribbonLabel1;
        private C1.Win.Ribbon.RibbonListItem ribbonListItem2;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator2;
        private C1.Win.Ribbon.RibbonButton rbtnGroupSort;
        private C1.Win.Ribbon.RibbonTab rtArrange;
        private C1.Win.Ribbon.RibbonGroup rgEdit;
        private C1.Win.Ribbon.RibbonButton rbtnPaste;
        private C1.Win.Ribbon.RibbonButton rbtnCut;
        private C1.Win.Ribbon.RibbonButton rbtnCopy;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator3;
        private C1.Win.Ribbon.RibbonGroup rgFont;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar1;
        private C1.Win.Ribbon.RibbonFontComboBox rcbFontName;
        private C1.Win.Ribbon.RibbonComboBox rcbFontSize;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator5;
        private C1.Win.Ribbon.RibbonButton rbtnFontSizeUp;
        private C1.Win.Ribbon.RibbonButton rbtnFontSizeDown;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar2;
        private C1.Win.Ribbon.RibbonToggleButton rbtnFontBold;
        private C1.Win.Ribbon.RibbonToggleButton rbtnFontItalic;
        private C1.Win.Ribbon.RibbonToggleButton rbtnFontUnderline;
        private C1.Win.Ribbon.RibbonColorPicker rbtnTextColor;
        private C1.Win.Ribbon.RibbonColorPicker rbtnFillColor;
        private C1.Win.Ribbon.RibbonGroup rgPosition;
        private C1.Win.Ribbon.RibbonTab rtPreview;
        private C1.Win.Ribbon.RibbonGroup rgZoom;
        private C1.Win.Ribbon.RibbonGroup rgNavigation;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar3;
        private C1.Win.Ribbon.RibbonTextBox rebPageNo;
        private C1.Win.Ribbon.RibbonLabel rlblPageCount;
        private C1.Win.Ribbon.RibbonGroup rgPreviewTools;
        private C1.Win.Ribbon.RibbonToggleButton rbtnHandTool;
        private C1.Win.Ribbon.RibbonToggleButton rbtnTextSelectTool;
        private C1.Win.Ribbon.RibbonTrackBar rtbZoom;
        private C1.Win.Ribbon.RibbonLabel rlblZoom;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator9;
        private C1.Win.Ribbon.RibbonToggleGroup ribbonToggleGroup1;
        private C1.Win.Ribbon.RibbonToggleButton rbtnViewSinglePage;
        private C1.Win.Ribbon.RibbonToggleButton rbtnViewContinuous;
        private C1.Win.Ribbon.RibbonToggleButton rbtnViewPagesFacing;
        private C1.Win.Ribbon.RibbonToggleButton rbtnViewPagesFacingContinuous;
        private C1.Win.Ribbon.RibbonButton rbtnBringToFront;
        private C1.Win.Ribbon.RibbonButton rbtnSendToBack;
        private C1.Win.Ribbon.RibbonButton rbtnAlignLeft;
        private C1.Win.Ribbon.RibbonButton rbtnEqualHorizontalSpacing;
        private C1.Win.Ribbon.RibbonButton rbtnIncreaseHorizontalSpacing;
        private C1.Win.Ribbon.RibbonButton rbtnDecreaseHorizontalSpacing;
        private C1.Win.Ribbon.RibbonButton rbtnEqualVerticalSpacing;
        private C1.Win.Ribbon.RibbonButton rbtnIncreaseVerticalSpacing;
        private C1.Win.Ribbon.RibbonButton rbtnDecreaseVerticalSpacing;
        private C1.Win.Ribbon.RibbonGroup rgSize;
        private C1.Win.Ribbon.RibbonButton rbtnReportInfo;
        private C1.Win.Command.C1CommandDock c1CommandDock1;
        private C1.Win.Command.C1DockingTab c1DockingTab1;
        private C1.Win.Command.C1DockingTabPage dtpReports;
        private C1.Win.Command.C1DockingTabPage dtpProperties;
        private C1.Win.Command.C1CommandHolder chMain;
        private C1.Win.Command.C1Command cNewReportEmpty;
        private C1.Win.Command.C1Command cDeleteReport;
        private C1.Win.Command.C1ToolBar c1ToolBar1;
        private C1.Win.Command.C1CommandLink c1CommandLink1;
        private C1.Win.Command.C1CommandLink c1CommandLink2;
        private C1.Win.Command.C1ToolBar c1ToolBar2;
        private C1.Win.Command.C1CommandLink c1CommandLink3;
        private C1.Win.Command.C1Command cPropertiesCategorized;
        private C1.Win.Command.C1Command cPropertiesAlphabetical;
        private C1.Win.Command.C1CommandLink c1CommandLink4;
        private C1.Win.Command.C1Command cMoveReportUp;
        private C1.Win.Command.C1Command cMoveReportDown;
        private C1.Win.Command.C1Command cmSelectAll;
        private C1.Win.Command.C1Command cmCutField;
        private C1.Win.Command.C1Command cmCopyField;
        private C1.Win.Command.C1Command cmPasteField;
        private C1.Win.Command.C1Command cmDeleteField;
        private C1.Win.Command.C1Command cmBringToFront;
        private C1.Win.Command.C1Command cmSendToBack;
        private C1.Win.Ribbon.RibbonGroup rgFields;
        private C1.Win.Ribbon.RibbonToggleButton rbtnFieldArrow;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator12;
        private C1.Win.Ribbon.RibbonSplitButton rbtnFieldDataField;
        private C1.Win.Ribbon.RibbonSplitButton rbtnFieldCheckBox;
        private C1.Win.Ribbon.RibbonSplitButton rbtnFieldBarCode;
        private C1.Win.Ribbon.RibbonSplitButton rbtnFieldRtf;
        private C1.Win.Ribbon.RibbonSplitButton rbtnFieldCalculated;
        private C1.Win.Ribbon.RibbonSplitButton rbtnFieldPicture;
        private C1.Win.Ribbon.RibbonToggleButton rbtnFieldShape;
        private C1.Win.Ribbon.RibbonMenu rbtnFieldSubReport;
        private C1.Win.Ribbon.RibbonToggleButton rbtnFieldLegacy;
        private FlexReportDesignerApp.Util.ReportList _reportList;
        private FlexReportDesignerApp.Util.FieldPicker _fieldPicker;
        private C1.Win.FlexReport.C1FlexReport _reportRender;
        private C1.Win.Ribbon.RibbonLabel rlblStatusBarText;
        private C1.Win.Ribbon.RibbonButton rbtnRenderError;
        private C1.Win.Ribbon.RibbonSeparator rsepRenderError;
        private C1.Win.Ribbon.RibbonButton rbtnDelete;
        private C1.Win.Command.C1CommandLink c1CommandLink20;
        private C1.Win.Command.C1CommandLink c1CommandLink21;
        private C1.Win.Command.C1Command cPasteReport;
        private C1.Win.Command.C1Command cCutReport;
        private C1.Win.Command.C1Command cCopyReport;
        private C1.Win.Command.C1CommandLink c1CommandLink22;
        private C1.Win.Command.C1CommandLink c1CommandLink23;
        private C1.Win.Command.C1CommandLink c1CommandLink24;
        private C1.Win.Ribbon.RibbonButton rbtnUndo;
        private C1.Win.Ribbon.RibbonButton rbtnRedo;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator8;
        private C1.Win.Ribbon.RibbonToggleButton rbtnTextAlignGeneral;
        private C1.Win.Ribbon.RibbonToggleButton rbtnTextAlignLeft;
        private C1.Win.Ribbon.RibbonToggleButton rbtnTextAlignCenter;
        private C1.Win.Ribbon.RibbonToggleButton rbtnTextAlignRight;
        private C1.Win.Ribbon.RibbonToggleButton rbtnTextAlignJustify;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator4;
        private C1.Win.Ribbon.RibbonGroup rgTools;
        private C1.Win.Ribbon.RibbonButton rbtnShowPropertyGrid;
        private C1.Win.Ribbon.RibbonGroup rgGrid;
        private C1.Win.Ribbon.RibbonToggleButton rbtnSnapToGrid;
        private C1.Win.Ribbon.RibbonToggleButton rbtnShowGrid;
        private C1.Win.Ribbon.RibbonButton rbtnGridProperties;
        private C1.Win.Ribbon.RibbonGroup rgControlAlignment;
        private C1.Win.Ribbon.RibbonButton rbtnAlignRight;
        private C1.Win.Ribbon.RibbonButton rbtnAlignTop;
        private C1.Win.Ribbon.RibbonButton rbtnAlignBottom;
        private C1.Win.Ribbon.RibbonButton rbtnSizeToGrid;
        private C1.Win.Ribbon.RibbonButton rbtnHeightToTallest;
        private C1.Win.Ribbon.RibbonButton rbtnHeightToShortest;
        private C1.Win.Ribbon.RibbonButton rbtnWidthToWidest;
        private C1.Win.Ribbon.RibbonButton rbtnWidthToNarrowest;
        private C1.Win.Ribbon.RibbonTab rtPageSetup;
        private C1.Win.Ribbon.RibbonGroup rgPageLayout1;
        private C1.Win.Ribbon.RibbonSplitButton rbtnPageSize1;
        private C1.Win.Ribbon.RibbonToggleButton rbtnPagePortrait1;
        private C1.Win.Ribbon.RibbonToggleButton rbtnPageLandscape1;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator14;
        private C1.Win.Ribbon.RibbonButton rbtnPageSetup1;
        private C1.Win.Ribbon.RibbonGroup rgPageLayout2;
        private C1.Win.Ribbon.RibbonSplitButton rbtnPageSize2;
        private C1.Win.Ribbon.RibbonToggleButton rbtnPagePortrait2;
        private C1.Win.Ribbon.RibbonToggleButton rbtnPageLandscape2;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator141;
        private C1.Win.Ribbon.RibbonButton rbtnPageSetup2;
        private C1.Win.Ribbon.RibbonMenu rbtnZoom;
        private C1.Win.Ribbon.RibbonToggleButton rbtnZoomOnePage;
        private C1.Win.Ribbon.RibbonToggleButton rbtnZoomTwoPages;
        private C1.Win.Ribbon.RibbonGroup rgExport;
        private C1.Win.Ribbon.RibbonSplitButton rbtnExportXls;
        private C1.Win.Ribbon.RibbonSplitButton rbtnExportHtml;
        private C1.Win.Ribbon.RibbonButton rbtnExportRtf;
        private C1.Win.Ribbon.RibbonButton rbtnExportDocx;
        private C1.Win.Ribbon.RibbonMenu rmExportMore;
        private C1.Win.Ribbon.RibbonToggleButton rbtnZoomFitToWindow;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator10;
        private C1.Win.Ribbon.RibbonToggleButton rbtnZoom10;
        private C1.Win.Ribbon.RibbonToggleButton rbtnZoom25;
        private C1.Win.Ribbon.RibbonToggleButton rbtnZoom50;
        private C1.Win.Ribbon.RibbonToggleButton rbtnZoom75;
        private C1.Win.Ribbon.RibbonToggleButton rbtnZoom100;
        private C1.Win.Ribbon.RibbonToggleButton rbtnZoom125;
        private C1.Win.Ribbon.RibbonToggleButton rbtnZoom150;
        private C1.Win.Ribbon.RibbonToggleButton rbtnZoom200;
        private C1.Win.Ribbon.RibbonToggleButton rbtnZoom500;
        private C1.Win.Ribbon.RibbonButton rbtnExportHtml2;
        private C1.Win.Ribbon.RibbonButton rbtnExportHtmlPaged;
        private C1.Win.Ribbon.RibbonButton rbtnExportXls2;
        private C1.Win.Ribbon.RibbonButton rbtnExportXlsx;
        private C1.Win.Ribbon.RibbonButton rbtnExportTIFF;
        private C1.Win.Ribbon.RibbonButton rbtnExportMetafiles;
        private C1.Win.Ribbon.RibbonButton rbtnExportBMP;
        private C1.Win.Ribbon.RibbonButton rbtnExportPNG;
        private C1.Win.Command.C1DockingTabPage dtpData;
        private C1.Win.Ribbon.RibbonButton rbtnShowDataTree;
        private C1.Win.Ribbon.RibbonSplitButton rbtnAbout;
        private C1.Win.Ribbon.RibbonButton rbtnAlignCenter;
        private C1.Win.Ribbon.RibbonButton rbtnAlignMiddle;
        private C1.Win.Command.C1ContextMenu cmReport;
        private C1.Win.Command.C1CommandLink c1CommandLink6;
        private C1.Win.Command.C1CommandLink c1CommandLink25;
        private C1.Win.Command.C1CommandLink c1CommandLink26;
        private C1.Win.Command.C1CommandLink c1CommandLink27;
        private C1.Win.Command.C1CommandLink c1CommandLink7;
        private C1.Win.Command.C1CommandLink c1CommandLink8;
        private C1.Win.Command.C1CommandLink c1CommandLink9;
        private C1.Win.Command.C1ContextMenu _cmDesigner;
        private C1.Win.Command.C1CommandLink c1CommandLink13;
        private C1.Win.Command.C1CommandLink c1CommandLink14;
        private C1.Win.Command.C1CommandLink c1CommandLink15;
        private C1.Win.Command.C1CommandLink c1CommandLink16;
        private C1.Win.Command.C1CommandLink c1CommandLink17;
        private C1.Win.Command.C1CommandLink c1CommandLink18;
        private C1.Win.Command.C1CommandLink c1CommandLink19;
        private C1.Win.Ribbon.RibbonButton rbtnFirstPage;
        private C1.Win.Ribbon.RibbonButton rbtnPreviousPage;
        private C1.Win.Ribbon.RibbonButton rbtnNextPage;
        private C1.Win.Ribbon.RibbonButton rbtnLastPage;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar4;
        private C1.Win.Ribbon.RibbonButton rbtnPreviousView;
        private C1.Win.Ribbon.RibbonButton rbtnNextView;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator7;
        private C1.Win.Ribbon.RibbonToggleButton rbtnPreviewFind;
        private C1.Win.Ribbon.RibbonButton rbtnHelpContents;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator15;
        private C1.Win.Ribbon.RibbonButton rbtnAbout2;
        private C1.Win.Ribbon.RibbonButton rbtnCheckForUpdates;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator16;
        private C1.Win.Ribbon.RibbonToggleButton rbtnLockFields;
        private C1.Win.Ribbon.RibbonLabel rlblSelectedReport;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator17;
        private C1.Win.Command.C1Command cLockFields;
        private C1.Win.Command.C1CommandLink c1CommandLink28;
        private C1.Win.Ribbon.RibbonTab rtInsert;
        private C1.Win.Ribbon.RibbonGroup rgBorder;
        private C1.Win.Ribbon.RibbonColorPicker rclrBorderColor;
        private C1.Win.Ribbon.RibbonGallery rgalBorderStyle;
        private C1.Win.Ribbon.RibbonGalleryItem rgiBorderStyleSolid;
        private C1.Win.Ribbon.RibbonGalleryItem rgiBorderStyleDash;
        private C1.Win.Ribbon.RibbonGalleryItem rgiBorderStyleDot;
        private C1.Win.Ribbon.RibbonGalleryItem rgiBorderStyleDashDot;
        private C1.Win.Ribbon.RibbonGalleryItem rgiBorderStyleDashDotDot;
        private C1.Win.Ribbon.RibbonGalleryItem rgiBorderStyleNone;
        private C1.Win.Ribbon.RibbonComboBox rcmbBorderWidth;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar5;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar6;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator18;
        private C1.Win.Ribbon.RibbonGroup rgMode;
        private C1.Win.Ribbon.RibbonGroup rgAutoFormat;
        private C1.Win.Ribbon.RibbonButton rbtnStyles;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator6;
        private C1.Win.Ribbon.RibbonButton rbtnApplyStyleToSelection;
        private C1.Win.Ribbon.RibbonButton rbtnFormatAsTableRow;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator11;
        private C1.Win.Ribbon.RibbonButton rbtnAlignToGrid;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator19;
        private C1.Win.Ribbon.RibbonToggleButton rbtnModePreview;
        private C1.Win.Ribbon.RibbonToggleButton rbtnModeDesign;
        private C1.Win.Ribbon.RibbonToggleButton rbtnScriptEditor;
        private C1.Win.Ribbon.RibbonGroup rgStopRefresh;
        private C1.Win.Ribbon.RibbonButton rbtnPreviewStop;
        private C1.Win.Command.C1Command cPreviewStop;
        private C1.Win.Command.C1Command cPreviewRefresh;
        private C1.Win.Ribbon.RibbonButton rbtnPreviewRefresh;
        private C1.Win.Ribbon.RibbonButton rbtnPreviewPrint;
        private System.Windows.Forms.ImageList ilReportList;
        private C1.Win.Ribbon.RibbonGroup rgCustomFields;
        private C1.Win.Ribbon.RibbonButton rbtnSaveAndExit;
        private C1.Win.Ribbon.RibbonButton rbtnCancelAndExit;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator13;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator20;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator21;
        private C1.Win.Command.C1Command cScriptEditor;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.FlexReport.C1FlexReportDesigner _flexDesigner;
        private C1.Win.Command.C1ToolBar toolbarData;
        private C1.Win.Command.C1ContextMenu cmDataTree;
        private C1.Win.Command.C1CommandLink clAddDataSource;
        private C1.Win.Command.C1CommandLink clAddParameter;
        private C1.Win.Command.C1Command cAddDataSource;
        private C1.Win.Command.C1Command cAddParameter;
        private C1.Win.Ribbon.RibbonGroup rgSubSection;
        private C1.Win.Ribbon.RibbonButton rbtnSubSectionAdd;
        private C1.Win.Ribbon.RibbonButton rbtnSubSectionRemove;
        private C1.Win.Ribbon.RibbonButton rbtnSubSectionMoveUp;
        private C1.Win.Ribbon.RibbonButton rbtnSubSectionMoveDown;
        private C1.Win.Ribbon.RibbonToggleButton rbtnFieldChart;
        private C1.Win.Ribbon.RibbonMenu rbmCaptionsVisibility;
        private C1.Win.Ribbon.RibbonToggleButton rbtnCaptionsVisibilityAll;
        private C1.Win.Ribbon.RibbonToggleButton rbtnCaptionsVisibilitySection;
        private C1.Win.Ribbon.RibbonToggleButton rbtnCaptionsVisibilityHairline;
        private C1.Win.Ribbon.RibbonToggleButton rbtnCaptionsVisibilityHidden;
        private C1.Win.Command.C1CommandLink _clContextPlaceholderTop;
        private C1.Win.Command.C1Command _cContextPlaceholderTop;
        private C1.Win.Command.C1CommandLink _clContextPlaceholderBot;
        private C1.Win.Command.C1Command _cContextPlaceholderBot;
        private C1.Win.FlexViewer.C1FlexViewerPane _flexViewer;
        private C1.Win.Command.C1Command cAddCalculatedField;
        private C1.Win.Command.C1CommandLink clAddCalculatedField;
        private C1.Win.Ribbon.RibbonButton rbtnStatusZoom;
        private C1.Win.Ribbon.RibbonSplitButton rbtnDataSources;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator22;
        private C1.Win.Ribbon.RibbonButton rbtnDataSourcesAdd;
        private Controls.DataTree _dataTree;
        private C1.Win.Command.C1Command cAddSort;
        private C1.Win.Command.C1Command cDataTreeDelete;
        private C1.Win.Command.C1CommandLink c1CommandLink34;
        private C1.Win.Command.C1Command cDataTreeInsert;
        private C1.Win.Command.C1CommandLink clAddSort;
        private C1.Win.Command.C1CommandLink clDataTreeDelete;
        private C1.Win.Command.C1Command cDataTreeInplaceEdit;
        private C1.Win.Command.C1CommandLink clDataTreeInplaceEdit;
        private C1.Win.Command.C1CommandLink clDataTreeChangeSortOrder;
        private C1.Win.Command.C1Command cDataTreeChangeSortOrder;
        private C1.Win.Command.C1CommandLink c1CommandLink35;
        private C1.Win.Command.C1Command cDataTreeEdit;
        private C1.Win.Command.C1Command cDataTreeMoveUp;
        private C1.Win.Command.C1Command cDataTreeMoveDown;
        private C1.Win.Command.C1CommandMenu cmDataTreeAdd;
        private C1.Win.Command.C1CommandLink c1CommandLink37;
        private C1.Win.Command.C1CommandLink c1CommandLink38;
        private C1.Win.Command.C1CommandLink c1CommandLink39;
        private C1.Win.Command.C1CommandLink c1CommandLink40;
        private C1.Win.Command.C1CommandLink c1CommandLink36;
        private C1.Win.Command.C1CommandLink c1CommandLink41;
        private C1.Win.Command.C1CommandLink c1CommandLink42;
        private C1.Win.Command.C1CommandLink c1CommandLink43;
        private C1.Win.Command.C1CommandLink clDataTreeEdit;
        private C1.Win.Command.C1CommandLink clDataTreeMoveUp;
        private C1.Win.Command.C1CommandLink clDataTreeMoveDown;
        private C1.Win.Ribbon.RibbonButton rbtnFieldParagraph;
        private C1.Win.Command.C1CommandLink c1CommandLink10;
        private C1.Win.Command.C1Command cmProperties;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator23;
        private C1.Win.Ribbon.RibbonButton rbtnCaptionsExpandAll;
        private C1.Win.Ribbon.RibbonButton rbtnCaptionsCollapseAll;
        private C1.Win.Ribbon.RibbonToggleButton rbtnPreviewThumbnails;
        private C1.Win.Ribbon.RibbonToggleButton rbtnPreviewOutlines;
        private C1.Win.Ribbon.RibbonToggleButton rbtnPreviewPaginated;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator24;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator25;
        private C1.Win.Command.C1ContextMenu cmPreview;
        private C1.Win.Command.C1CommandLink c1CommandLink5;
        private C1.Win.Command.C1Command cPreviewCopy;
        private C1.Win.Command.C1CommandMenu cmNewReport;
        private C1.Win.Command.C1CommandLink c1CommandLink11;
        private C1.Win.Command.C1Command cNewReportWizard;
        private C1.Win.Command.C1CommandLink c1CommandLink12;
        private C1.Win.Command.C1DockingTab c1DockingTab2;
        private System.Windows.Forms.PropertyGrid _propGrid;
        private C1.Win.Ribbon.RibbonToggleButton rbtnPreviewParams;
        private C1.Win.Ribbon.RibbonSplitButton rbtnExportPdf;
        private C1.Win.Ribbon.RibbonButton rbtnExportPdf_A;
        private C1.Win.Ribbon.RibbonButton rbtnExportPdf_linkedFonts;
        private C1.Win.Ribbon.RibbonButton rbtnCloseSearch;
        private C1.Win.Ribbon.RibbonTextBox rebSearchText;
        private C1.Win.Ribbon.RibbonButton rbtnSearchNext;
        private C1.Win.Ribbon.RibbonButton rbtnSearchPrev;
        private C1.Win.Ribbon.RibbonToggleButton rbtnMatchCase;
        private C1.Win.Ribbon.RibbonToggleButton rbtnMatchWholeWord;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator26;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator27;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator28;
        private C1.Win.Command.C1Command cDataSourceRefresh;
        private C1.Win.Command.C1CommandLink c1CommandLink29;
        private C1.Win.Ribbon.RibbonButton rbtnExportJPEG;
        private C1.Win.Ribbon.RibbonButton rbtnExportGIF;
        private C1.Win.Command.C1DockingTabPage dtpErrors;
        private Controls.ErrorList _errorList;
        private C1.Win.Command.C1ContextMenu cmErrorList;
        private C1.Win.Command.C1CommandLink c1CommandLink30;
        private C1.Win.Command.C1Command cErrorListHide;
        private C1.Win.Command.C1Command cErrorListClear;
        private C1.Win.Command.C1CommandLink c1CommandLink31;
        private C1.Win.Ribbon.RibbonButton rbtnShowErrorList;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator29;
        private C1.Win.Command.C1Command cErrorListShow;
        private C1.Win.Command.C1Command cErrorListCopy;
        private C1.Win.Command.C1CommandLink c1CommandLink32;
        private C1.Win.Ribbon.RibbonButton rbtnRotateViewCCW;
        private C1.Win.Ribbon.RibbonButton rbtnRotateViewCW;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator30;
        private C1.Win.Ribbon.RibbonButton rbtnFieldFlexChart;
    }
}
