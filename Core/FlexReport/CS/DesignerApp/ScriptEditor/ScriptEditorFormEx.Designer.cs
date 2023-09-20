//----------------------------------------------------------------------------
// ScriptEditorFormEx.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Forms
{
    partial class ScriptEditorFormEx
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptEditorFormEx));
            this.chMain = new C1.Win.Command.C1CommandHolder();
            this.cSelectAll = new C1.Win.Command.C1Command();
            this.contextMenu = new C1.Win.Command.C1ContextMenu();
            this.c1CommandLink1 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink2 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink3 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink4 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink5 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink6 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink7 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink19 = new C1.Win.Command.C1CommandLink();
            this.cInsertC1Report = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink11 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink27 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink12 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink20 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink28 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink29 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink22 = new C1.Win.Command.C1CommandLink();
            this.cInsertVBSCript = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink21 = new C1.Win.Command.C1CommandLink();
            this.c1CommandLink32 = new C1.Win.Command.C1CommandLink();
            this.cOK = new C1.Win.Command.C1Command();
            this.cCancel = new C1.Win.Command.C1Command();
            this.cHistBack = new C1.Win.Command.C1Command();
            this.cHistForward = new C1.Win.Command.C1Command();
            this.cSwitchWindow = new C1.Win.Command.C1Command();
            this.cPasteAlt = new C1.Win.Command.C1Command();
            this._scriptEditor1 = new FlexReportDesignerApp.Forms.ScriptEditorControl();
            this._scriptEditor0 = new FlexReportDesignerApp.Forms.ScriptEditorControl();
            this._statusBar = new C1.Win.Ribbon.C1StatusBar();
            this.rblText = new C1.Win.Ribbon.RibbonLabel();
            this.ribbonSeparator1 = new C1.Win.Ribbon.RibbonSeparator();
            this.rlblRow = new C1.Win.Ribbon.RibbonLabel();
            this.ribbonSeparator2 = new C1.Win.Ribbon.RibbonSeparator();
            this.rlblCol = new C1.Win.Ribbon.RibbonLabel();
            this.rbnMain = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.rtHome = new C1.Win.Ribbon.RibbonTab();
            this.rgMain = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonSeparator5 = new C1.Win.Ribbon.RibbonSeparator();
            this.rgInsert = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonSeparator4 = new C1.Win.Ribbon.RibbonSeparator();
            this.rgVBScript = new C1.Win.Ribbon.RibbonGroup();
            this.rtView = new C1.Win.Ribbon.RibbonTab();
            this.rgDisplay = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonToolBar1 = new C1.Win.Ribbon.RibbonToolBar();
            this.rbEditorFontName = new C1.Win.Ribbon.RibbonFontComboBox();
            this.ribbonToolBar2 = new C1.Win.Ribbon.RibbonToolBar();
            this.rbFontSize = new C1.Win.Ribbon.RibbonComboBox();
            this.ribbonSeparator6 = new C1.Win.Ribbon.RibbonSeparator();
            this.rlblEditorBackColor = new C1.Win.Ribbon.RibbonLabel();
            this.rgOptions = new C1.Win.Ribbon.RibbonGroup();
            this.rbSyntaxHighlight = new C1.Win.Ribbon.RibbonCheckBox();
            this.rbSyntaxAutoCheck = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonSeparator8 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbDataSourceFilterWarning = new C1.Win.Ribbon.RibbonCheckBox();
            this.rbAutoSave = new C1.Win.Ribbon.RibbonCheckBox();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this._slNote = new C1.Win.SuperTooltip.C1SuperLabel();
            this._splitter = new System.Windows.Forms.SplitContainer();
            this.rbtnOK = new C1.Win.Ribbon.RibbonButton();
            this.rbtnCancel = new C1.Win.Ribbon.RibbonButton();
            this.rbtnGoBack = new C1.Win.Ribbon.RibbonButton();
            this.rbtnGoForward = new C1.Win.Ribbon.RibbonButton();
            this.rgEdit = new C1.Win.Ribbon.RibbonGroup();
            this.rbtnPaste = new C1.Win.Ribbon.RibbonButton();
            this.rbtnCut = new C1.Win.Ribbon.RibbonButton();
            this.rbtnCopy = new C1.Win.Ribbon.RibbonButton();
            this.rbtnDelete = new C1.Win.Ribbon.RibbonButton();
            this.ribbonSeparator3 = new C1.Win.Ribbon.RibbonSeparator();
            this.rbtnUndo = new C1.Win.Ribbon.RibbonButton();
            this.rbtnRedo = new C1.Win.Ribbon.RibbonButton();
            this.rmnuReportParams = new C1.Win.Ribbon.RibbonMenu();
            this.rmnuDataFields = new C1.Win.Ribbon.RibbonMenu();
            this.rmnuCalculatedFields = new C1.Win.Ribbon.RibbonMenu();
            this.rmnuReportFields = new C1.Win.Ribbon.RibbonMenu();
            this.rmnuReportGlobals = new C1.Win.Ribbon.RibbonMenu();
            this.rmnuReportMore = new C1.Win.Ribbon.RibbonMenu();
            this.rmnuVBScriptFunctions = new C1.Win.Ribbon.RibbonMenu();
            this.rmnuVBScriptProgram = new C1.Win.Ribbon.RibbonMenu();
            this.rbtnFontSizeUp = new C1.Win.Ribbon.RibbonButton();
            this.rbtnFontSizeDown = new C1.Win.Ribbon.RibbonButton();
            this.rbTextColor = new C1.Win.Ribbon.RibbonColorPicker();
            this.rbBackgroundColor = new C1.Win.Ribbon.RibbonColorPicker();
            this.rbtnError = new C1.Win.Ribbon.RibbonButton();
            this.cCut = new C1.Win.Command.C1Command();
            this.cCopy = new C1.Win.Command.C1Command();
            this.cPaste = new C1.Win.Command.C1Command();
            this.cDelete = new C1.Win.Command.C1Command();
            this.cUndo = new C1.Win.Command.C1Command();
            this.cRedo = new C1.Win.Command.C1Command();
            this.cmnuReportParams = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink8 = new C1.Win.Command.C1CommandLink();
            this.cmnuDataFields = new C1.Win.Command.C1CommandMenu();
            this.cmnuCalculatedFields = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink9 = new C1.Win.Command.C1CommandLink();
            this.cmnuReportFields = new C1.Win.Command.C1CommandMenu();
            this.cmnuReportGlobals = new C1.Win.Command.C1CommandMenu();
            this.cmnuReportMore = new C1.Win.Command.C1CommandMenu();
            this.cmnuVBScriptFunc = new C1.Win.Command.C1CommandMenu();
            this.cmnuVBScriptProg = new C1.Win.Command.C1CommandMenu();
            this.cmnuReportGroups = new C1.Win.Command.C1CommandMenu();
            this.c1CommandLink10 = new C1.Win.Command.C1CommandLink();
            ((System.ComponentModel.ISupportInitialize)(this.chMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._statusBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbnMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._splitter)).BeginInit();
            this._splitter.Panel1.SuspendLayout();
            this._splitter.Panel2.SuspendLayout();
            this._splitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // chMain
            // 
            this.chMain.Commands.Add(this.cCut);
            this.chMain.Commands.Add(this.cCopy);
            this.chMain.Commands.Add(this.cPaste);
            this.chMain.Commands.Add(this.cDelete);
            this.chMain.Commands.Add(this.cUndo);
            this.chMain.Commands.Add(this.cRedo);
            this.chMain.Commands.Add(this.cSelectAll);
            this.chMain.Commands.Add(this.cmnuReportParams);
            this.chMain.Commands.Add(this.cmnuDataFields);
            this.chMain.Commands.Add(this.cmnuCalculatedFields);
            this.chMain.Commands.Add(this.cmnuReportFields);
            this.chMain.Commands.Add(this.cmnuReportGlobals);
            this.chMain.Commands.Add(this.cmnuReportMore);
            this.chMain.Commands.Add(this.cmnuVBScriptFunc);
            this.chMain.Commands.Add(this.cmnuVBScriptProg);
            this.chMain.Commands.Add(this.contextMenu);
            this.chMain.Commands.Add(this.cOK);
            this.chMain.Commands.Add(this.cCancel);
            this.chMain.Commands.Add(this.cInsertC1Report);
            this.chMain.Commands.Add(this.cInsertVBSCript);
            this.chMain.Commands.Add(this.cHistBack);
            this.chMain.Commands.Add(this.cHistForward);
            this.chMain.Commands.Add(this.cSwitchWindow);
            this.chMain.Commands.Add(this.cPasteAlt);
            this.chMain.Commands.Add(this.cmnuReportGroups);
            this.chMain.Owner = this;
            //this.chMain.VisualStyle =  C1.Win.Command.VisualStyle.Office2007Blue;
            this.chMain.CommandClick += new C1.Win.Command.CommandClickEventHandler(this.chMain_CommandClick);
            // 
            // cSelectAll
            // 
            this.cSelectAll.Name = "cSelectAll";
            this.cSelectAll.Shortcut = System.Windows.Forms.Shortcut.CtrlA;
            this.cSelectAll.ShortcutText = "";
            this.cSelectAll.Text = "Select All";
            // 
            // contextMenu
            // 
            this.contextMenu.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink7,
            this.c1CommandLink19,
            this.c1CommandLink22});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.ShortcutText = "";
            //this.contextMenu.VisualStyleBase = C1.Win.Command.VisualStyle.Office2007Blue;
            // 
            // c1CommandLink1
            // 
            this.c1CommandLink1.Command = this.cUndo;
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.cRedo;
            this.c1CommandLink2.SortOrder = 1;
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.Command = this.cCut;
            this.c1CommandLink3.Delimiter = true;
            this.c1CommandLink3.SortOrder = 2;
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.cCopy;
            this.c1CommandLink4.SortOrder = 3;
            // 
            // c1CommandLink5
            // 
            this.c1CommandLink5.Command = this.cPaste;
            this.c1CommandLink5.SortOrder = 4;
            // 
            // c1CommandLink6
            // 
            this.c1CommandLink6.Command = this.cDelete;
            this.c1CommandLink6.SortOrder = 5;
            // 
            // c1CommandLink7
            // 
            this.c1CommandLink7.Command = this.cSelectAll;
            this.c1CommandLink7.Delimiter = true;
            this.c1CommandLink7.SortOrder = 6;
            // 
            // c1CommandLink19
            // 
            this.c1CommandLink19.Command = this.cInsertC1Report;
            this.c1CommandLink19.SortOrder = 7;
            // 
            // cInsertC1Report
            // 
            this.cInsertC1Report.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink11,
            this.c1CommandLink27,
            this.c1CommandLink12,
            this.c1CommandLink20,
            this.c1CommandLink28,
            this.c1CommandLink29});
            this.cInsertC1Report.Name = "cInsertC1Report";
            this.cInsertC1Report.ShortcutText = "";
            this.cInsertC1Report.Text = "C1Report...";
            this.cInsertC1Report.ToolTipText = "Insert a C1Report field, variable or function.";
            // 
            // c1CommandLink11
            // 
            this.c1CommandLink11.Command = this.cmnuReportParams;
            // 
            // c1CommandLink27
            // 
            this.c1CommandLink27.Command = this.cmnuDataFields;
            this.c1CommandLink27.SortOrder = 1;
            // 
            // c1CommandLink12
            // 
            this.c1CommandLink12.Command = this.cmnuCalculatedFields;
            this.c1CommandLink12.SortOrder = 2;
            // 
            // c1CommandLink20
            // 
            this.c1CommandLink20.Command = this.cmnuReportFields;
            this.c1CommandLink20.SortOrder = 3;
            // 
            // c1CommandLink28
            // 
            this.c1CommandLink28.Command = this.cmnuReportGlobals;
            this.c1CommandLink28.SortOrder = 4;
            // 
            // c1CommandLink29
            // 
            this.c1CommandLink29.Command = this.cmnuReportMore;
            this.c1CommandLink29.SortOrder = 5;
            // 
            // c1CommandLink22
            // 
            this.c1CommandLink22.Command = this.cInsertVBSCript;
            this.c1CommandLink22.SortOrder = 8;
            // 
            // cInsertVBSCript
            // 
            this.cInsertVBSCript.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink21,
            this.c1CommandLink32});
            this.cInsertVBSCript.Name = "cInsertVBSCript";
            this.cInsertVBSCript.ShortcutText = "";
            this.cInsertVBSCript.Text = "VBScript...";
            this.cInsertVBSCript.ToolTipText = "Insert a standard VBScript function or construct.";
            // 
            // c1CommandLink21
            // 
            this.c1CommandLink21.Command = this.cmnuVBScriptFunc;
            // 
            // c1CommandLink32
            // 
            this.c1CommandLink32.Command = this.cmnuVBScriptProg;
            this.c1CommandLink32.SortOrder = 1;
            // 
            // cOK
            // 
            this.cOK.Name = "cOK";
            this.cOK.Shortcut = System.Windows.Forms.Shortcut.CtrlW;
            this.cOK.ShortcutText = "";
            // 
            // cCancel
            // 
            this.cCancel.Name = "cCancel";
            this.cCancel.ShortcutText = "";
            // 
            // cHistBack
            // 
            this.cHistBack.Name = "cHistBack";
            this.cHistBack.Shortcut = System.Windows.Forms.Shortcut.AltLeftArrow;
            this.cHistBack.ShortcutText = "";
            this.cHistBack.Text = "Back";
            // 
            // cHistForward
            // 
            this.cHistForward.Name = "cHistForward";
            this.cHistForward.Shortcut = System.Windows.Forms.Shortcut.AltRightArrow;
            this.cHistForward.ShortcutText = "";
            this.cHistForward.Text = "Forward";
            // 
            // cSwitchWindow
            // 
            this.cSwitchWindow.Name = "cSwitchWindow";
            this.cSwitchWindow.Shortcut = System.Windows.Forms.Shortcut.F6;
            this.cSwitchWindow.ShortcutText = "";
            this.cSwitchWindow.Text = "Window";
            // 
            // cPasteAlt
            // 
            this.cPasteAlt.Name = "cPasteAlt";
            this.cPasteAlt.Shortcut = System.Windows.Forms.Shortcut.ShiftIns;
            this.cPasteAlt.ShortcutText = "";
            // 
            // _scriptEditor1
            // 
            this._scriptEditor1.AutoSaveCurrentScript = false;
            this.chMain.SetC1ContextMenu(this._scriptEditor1, this.contextMenu);
            this._scriptEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scriptEditor1.EditorBackgroundColor = System.Drawing.SystemColors.Window;
            this._scriptEditor1.EditorFont = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scriptEditor1.EditorTextColor = System.Drawing.SystemColors.WindowText;
            this._scriptEditor1.IsSelectedEditor = false;
            this._scriptEditor1.Location = new System.Drawing.Point(0, 0);
            this._scriptEditor1.Name = "_scriptEditor1";
            this._scriptEditor1.Size = new System.Drawing.Size(887, 195);
            this._scriptEditor1.SyntaxAutoCheck = false;
            this._scriptEditor1.TabIndex = 0;
            // 
            // _scriptEditor0
            // 
            this._scriptEditor0.AutoSaveCurrentScript = false;
            this.chMain.SetC1ContextMenu(this._scriptEditor0, this.contextMenu);
            this._scriptEditor0.Dock = System.Windows.Forms.DockStyle.Fill;
            this._scriptEditor0.EditorBackgroundColor = System.Drawing.SystemColors.Window;
            this._scriptEditor0.EditorFont = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._scriptEditor0.EditorTextColor = System.Drawing.SystemColors.WindowText;
            this._scriptEditor0.IsSelectedEditor = false;
            this._scriptEditor0.Location = new System.Drawing.Point(0, 0);
            this._scriptEditor0.Name = "_scriptEditor0";
            this._scriptEditor0.Size = new System.Drawing.Size(887, 216);
            this._scriptEditor0.SyntaxAutoCheck = false;
            this._scriptEditor0.TabIndex = 2;
            // 
            // _statusBar
            // 
            this._statusBar.LeftPaneItems.Add(this.rblText);
            this._statusBar.Location = new System.Drawing.Point(0, 662);
            this._statusBar.Name = "_statusBar";
            this._statusBar.RightPaneItems.Add(this.rbtnError);
            this._statusBar.RightPaneItems.Add(this.ribbonSeparator1);
            this._statusBar.RightPaneItems.Add(this.rlblRow);
            this._statusBar.RightPaneItems.Add(this.ribbonSeparator2);
            this._statusBar.RightPaneItems.Add(this.rlblCol);
            this._statusBar.Size = new System.Drawing.Size(887, 23);
            // 
            // rblText
            // 
            this.rblText.Name = "rblText";
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            this.ribbonSeparator1.Visible = false;
            // 
            // rlblRow
            // 
            this.rlblRow.Name = "rlblRow";
            this.rlblRow.Text = "row";
            // 
            // ribbonSeparator2
            // 
            this.ribbonSeparator2.Name = "ribbonSeparator2";
            // 
            // rlblCol
            // 
            this.rlblCol.Name = "rlblCol";
            this.rlblCol.Text = "col";
            // 
            // rbnMain
            // 
            this.rbnMain.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.rbnMain.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.rbnMain.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.rbnMain.Location = new System.Drawing.Point(0, 0);
            this.rbnMain.Name = "rbnMain";
            this.rbnMain.QatHolder = this.ribbonQat1;
            this.rbnMain.Size = new System.Drawing.Size(887, 155);
            this.rbnMain.Tabs.Add(this.rtHome);
            this.rbnMain.Tabs.Add(this.rtView);
            this.rbnMain.ToolTipSettings.MaximumWidth = 300;
            this.rbnMain.TopToolBarHolder = this.ribbonTopToolBar1;
            this.rbnMain.RibbonEvent += this.rbnMain_RibbonEvent;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            this.ribbonApplicationMenu1.Visible = false;
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // rtHome
            // 
            this.rtHome.Groups.Add(this.rgMain);
            this.rtHome.Groups.Add(this.rgEdit);
            this.rtHome.Groups.Add(this.rgInsert);
            this.rtHome.Groups.Add(this.rgVBScript);
            this.rtHome.KeyTip = "H";
            this.rtHome.Name = "rtHome";
            this.rtHome.Text = "HOME";
            // 
            // rgMain
            // 
            this.rgMain.Items.Add(this.rbtnOK);
            this.rgMain.Items.Add(this.rbtnCancel);
            this.rgMain.Items.Add(this.ribbonSeparator5);
            this.rgMain.Items.Add(this.rbtnGoBack);
            this.rgMain.Items.Add(this.rbtnGoForward);
            this.rgMain.Name = "rgMain";
            this.rgMain.Text = "Navigation";
            // 
            // ribbonSeparator5
            // 
            this.ribbonSeparator5.Name = "ribbonSeparator5";
            // 
            // rgInsert
            // 
            this.rgInsert.Items.Add(this.rmnuReportParams);
            this.rgInsert.Items.Add(this.rmnuDataFields);
            this.rgInsert.Items.Add(this.rmnuCalculatedFields);
            this.rgInsert.Items.Add(this.ribbonSeparator4);
            this.rgInsert.Items.Add(this.rmnuReportFields);
            this.rgInsert.Items.Add(this.rmnuReportGlobals);
            this.rgInsert.Items.Add(this.rmnuReportMore);
            this.rgInsert.Name = "rgInsert";
            this.rgInsert.Text = "FlexReport";
            // 
            // ribbonSeparator4
            // 
            this.ribbonSeparator4.Name = "ribbonSeparator4";
            // 
            // rgVBScript
            // 
            this.rgVBScript.Items.Add(this.rmnuVBScriptFunctions);
            this.rgVBScript.Items.Add(this.rmnuVBScriptProgram);
            this.rgVBScript.Name = "rgVBScript";
            this.rgVBScript.Text = "VBScript";
            // 
            // rtView
            // 
            this.rtView.Groups.Add(this.rgDisplay);
            this.rtView.Groups.Add(this.rgOptions);
            this.rtView.KeyTip = "V";
            this.rtView.Name = "rtView";
            this.rtView.Text = "VIEW";
            // 
            // rgDisplay
            // 
            this.rgDisplay.Items.Add(this.ribbonToolBar1);
            this.rgDisplay.Items.Add(this.ribbonToolBar2);
            this.rgDisplay.Name = "rgDisplay";
            this.rgDisplay.Text = "Display";
            // 
            // ribbonToolBar1
            // 
            this.ribbonToolBar1.Items.Add(this.rbEditorFontName);
            this.ribbonToolBar1.Name = "ribbonToolBar1";
            // 
            // rbEditorFontName
            // 
            this.rbEditorFontName.KeyTip = "FF";
            this.rbEditorFontName.Label = "Font:";
            this.rbEditorFontName.Name = "rbEditorFontName";
            this.rbEditorFontName.TextAreaWidth = 180;
            this.rbEditorFontName.ToolTip = resources.GetString("rbEditorFontName.ToolTip");
            this.rbEditorFontName.ShouldDrawFont += this.rbEditorFontName_ShouldDrawFont;
            // 
            // ribbonToolBar2
            // 
            this.ribbonToolBar2.Items.Add(this.rbFontSize);
            this.ribbonToolBar2.Items.Add(this.rbtnFontSizeUp);
            this.ribbonToolBar2.Items.Add(this.rbtnFontSizeDown);
            this.ribbonToolBar2.Items.Add(this.ribbonSeparator6);
            this.ribbonToolBar2.Items.Add(this.rlblEditorBackColor);
            this.ribbonToolBar2.Items.Add(this.rbTextColor);
            this.ribbonToolBar2.Items.Add(this.rbBackgroundColor);
            this.ribbonToolBar2.Name = "ribbonToolBar2";
            // 
            // rbFontSize
            // 
            this.rbFontSize.KeyTip = "FS";
            this.rbFontSize.Label = "Size:";
            this.rbFontSize.Name = "rbFontSize";
            this.rbFontSize.TextAreaWidth = 30;
            this.rbFontSize.ToolTip = resources.GetString("rbFontSize.ToolTip");
            // 
            // ribbonSeparator6
            // 
            this.ribbonSeparator6.Name = "ribbonSeparator6";
            // 
            // rlblEditorBackColor
            // 
            this.rlblEditorBackColor.Name = "rlblEditorBackColor";
            this.rlblEditorBackColor.Text = "Colors:";
            // 
            // rgOptions
            // 
            this.rgOptions.Items.Add(this.rbSyntaxHighlight);
            this.rgOptions.Items.Add(this.rbSyntaxAutoCheck);
            this.rgOptions.Items.Add(this.ribbonSeparator8);
            this.rgOptions.Items.Add(this.rbDataSourceFilterWarning);
            this.rgOptions.Items.Add(this.rbAutoSave);
            this.rgOptions.Name = "rgOptions";
            this.rgOptions.Text = "Options";
            // 
            // rbSyntaxHighlight
            // 
            this.rbSyntaxHighlight.KeyTip = "H";
            this.rbSyntaxHighlight.Name = "rbSyntaxHighlight";
            this.rbSyntaxHighlight.Text = "Syntax Highlighting";
            this.rbSyntaxHighlight.ToolTip = resources.GetString("rbSyntaxHighlight.ToolTip");
            // 
            // rbSyntaxAutoCheck
            // 
            this.rbSyntaxAutoCheck.KeyTip = "A";
            this.rbSyntaxAutoCheck.Name = "rbSyntaxAutoCheck";
            this.rbSyntaxAutoCheck.Text = "Auto Syntax Check";
            this.rbSyntaxAutoCheck.ToolTip = resources.GetString("rbSyntaxAutoCheck.ToolTip");
            // 
            // ribbonSeparator8
            // 
            this.ribbonSeparator8.Name = "ribbonSeparator8";
            // 
            // rbDataSourceFilterWarning
            // 
            this.rbDataSourceFilterWarning.KeyTip = "D";
            this.rbDataSourceFilterWarning.Name = "rbDataSourceFilterWarning";
            this.rbDataSourceFilterWarning.Text = "DataSource.Filter Warning";
            this.rbDataSourceFilterWarning.ToolTip = resources.GetString("rbDataSourceFilterWarning.ToolTip");
            // 
            // rbAutoSave
            // 
            this.rbAutoSave.KeyTip = "S";
            this.rbAutoSave.Name = "rbAutoSave";
            this.rbAutoSave.Text = "Autosave Current Script";
            this.rbAutoSave.ToolTip = resources.GetString("rbAutoSave.ToolTip");
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // _slNote
            // 
            this._slNote.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._slNote.Location = new System.Drawing.Point(0, 570);
            this._slNote.Name = "_slNote";
            this._slNote.Size = new System.Drawing.Size(887, 92);
            this._slNote.TabIndex = 3;
            this._slNote.Text = resources.GetString("_slNote.Text");
            this._slNote.UseMnemonic = true;
            this._slNote.LinkClicked += this._slNote_LinkClicked;
            // 
            // _splitter
            // 
            this._splitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitter.Location = new System.Drawing.Point(0, 155);
            this._splitter.Name = "_splitter";
            this._splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitter.Panel1
            // 
            this._splitter.Panel1.Controls.Add(this._scriptEditor1);
            this._splitter.Panel1MinSize = 2;
            // 
            // _splitter.Panel2
            // 
            this._splitter.Panel2.Controls.Add(this._scriptEditor0);
            this._splitter.Size = new System.Drawing.Size(887, 415);
            this._splitter.SplitterDistance = 195;
            this._splitter.TabIndex = 6;
            // 
            // rbtnOK
            // 
            this.chMain.SetC1Command(this.rbtnOK, this.cOK);
            this.rbtnOK.KeyTip = "O";
            this.rbtnOK.LargeImage = global::FlexReportDesignerApp.Img_ScriptEditor.Done_32;
            this.rbtnOK.Name = "rbtnOK";
            this.rbtnOK.SmallImage = global::FlexReportDesignerApp.Img_ScriptEditor.Done_16;
            this.rbtnOK.Text = "Done";
            this.rbtnOK.ToolTip = resources.GetString("rbtnOK.ToolTip");
            // 
            // rbtnCancel
            // 
            this.chMain.SetC1Command(this.rbtnCancel, this.cCancel);
            this.rbtnCancel.LargeImage = ((System.Drawing.Image)(resources.GetObject("rbtnCancel.LargeImage")));
            this.rbtnCancel.Name = "rbtnCancel";
            this.rbtnCancel.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnCancel.SmallImage")));
            this.rbtnCancel.Text = "Cancel";
            this.rbtnCancel.Visible = false;
            // 
            // rbtnGoBack
            // 
            this.chMain.SetC1Command(this.rbtnGoBack, this.cHistBack);
            this.rbtnGoBack.KeyTip = "B";
            this.rbtnGoBack.Name = "rbtnGoBack";
            this.rbtnGoBack.SmallImage = global::FlexReportDesignerApp.Img_Preview.PreviousView_16;
            this.rbtnGoBack.Text = "Back";
            this.rbtnGoBack.ToolTip = resources.GetString("rbtnGoBack.ToolTip");
            // 
            // rbtnGoForward
            // 
            this.chMain.SetC1Command(this.rbtnGoForward, this.cHistForward);
            this.rbtnGoForward.KeyTip = "F";
            this.rbtnGoForward.Name = "rbtnGoForward";
            this.rbtnGoForward.SmallImage = global::FlexReportDesignerApp.Img_Preview.NextView_16;
            this.rbtnGoForward.Text = "Forward";
            this.rbtnGoForward.ToolTip = resources.GetString("rbtnGoForward.ToolTip");
            // 
            // rgEdit
            // 
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
            // rbtnPaste
            // 
            this.chMain.SetC1Command(this.rbtnPaste, this.cPaste);
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
            this.chMain.SetC1Command(this.rbtnCut, this.cCut);
            this.rbtnCut.KeyTip = "X";
            this.rbtnCut.Name = "rbtnCut";
            this.rbtnCut.SmallImage = global::FlexReportDesignerApp.Img_Home.Cut_16;
            this.rbtnCut.Tag = "Cut";
            this.rbtnCut.Text = "Cut";
            this.rbtnCut.ToolTip = resources.GetString("rbtnCut.ToolTip");
            // 
            // rbtnCopy
            // 
            this.chMain.SetC1Command(this.rbtnCopy, this.cCopy);
            this.rbtnCopy.KeyTip = "C";
            this.rbtnCopy.Name = "rbtnCopy";
            this.rbtnCopy.SmallImage = global::FlexReportDesignerApp.Img_Home.Copy_16;
            this.rbtnCopy.Tag = "Copy";
            this.rbtnCopy.Text = "Copy";
            this.rbtnCopy.ToolTip = resources.GetString("rbtnCopy.ToolTip");
            // 
            // rbtnDelete
            // 
            this.chMain.SetC1Command(this.rbtnDelete, this.cDelete);
            this.rbtnDelete.KeyTip = "D";
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
            // rbtnUndo
            // 
            this.chMain.SetC1Command(this.rbtnUndo, this.cUndo);
            this.rbtnUndo.KeyTip = "Z";
            this.rbtnUndo.Name = "rbtnUndo";
            this.rbtnUndo.SmallImage = global::FlexReportDesignerApp.Img_Home.Undo_16;
            this.rbtnUndo.Tag = "Undo";
            this.rbtnUndo.Text = "Undo";
            this.rbtnUndo.ToolTip = resources.GetString("rbtnUndo.ToolTip");
            // 
            // rbtnRedo
            // 
            this.chMain.SetC1Command(this.rbtnRedo, this.cRedo);
            this.rbtnRedo.KeyTip = "Y";
            this.rbtnRedo.Name = "rbtnRedo";
            this.rbtnRedo.SmallImage = global::FlexReportDesignerApp.Img_Home.Redo_16;
            this.rbtnRedo.Tag = "Redo";
            this.rbtnRedo.Text = "Redo";
            this.rbtnRedo.ToolTip = resources.GetString("rbtnRedo.ToolTip");
            // 
            // rmnuReportParams
            // 
            this.rmnuReportParams.Name = "rmnuReportParams";
            this.rmnuReportParams.SmallImage = global::FlexReportDesignerApp.Img_ScriptEditor.ReportParameter_16;
            this.rmnuReportParams.Text = "Report Parameters";
            // 
            // rmnuDataFields
            // 
            this.rmnuDataFields.KeyTip = "2";
            this.rmnuDataFields.Name = "rmnuDataFields";
            this.rmnuDataFields.SmallImage = global::FlexReportDesignerApp.Img_ScriptEditor.DatabaseFields_16;
            this.rmnuDataFields.Text = "Database Fields";
            this.rmnuDataFields.ToolTip = resources.GetString("rmnuDataFields.ToolTip");
            // 
            // rmnuCalculatedFields
            // 
            this.rmnuCalculatedFields.Name = "rmnuCalculatedFields";
            this.rmnuCalculatedFields.SmallImage = global::FlexReportDesignerApp.Img_ScriptEditor.CalculatedFields_16;
            this.rmnuCalculatedFields.Text = "Calculated Fields";
            // 
            // rmnuReportFields
            // 
            this.rmnuReportFields.KeyTip = "1";
            this.rmnuReportFields.Name = "rmnuReportFields";
            this.rmnuReportFields.SmallImage = global::FlexReportDesignerApp.Img_ScriptEditor.ReportFields_16;
            this.rmnuReportFields.Text = "Report Fields";
            this.rmnuReportFields.ToolTip = resources.GetString("rmnuReportFields.ToolTip");
            // 
            // rmnuReportGlobals
            // 
            this.rmnuReportGlobals.KeyTip = "3";
            this.rmnuReportGlobals.Name = "rmnuReportGlobals";
            this.rmnuReportGlobals.SmallImage = global::FlexReportDesignerApp.Img_ScriptEditor.GlobalScripts_16;
            this.rmnuReportGlobals.Text = "Global Scripts";
            this.rmnuReportGlobals.ToolTip = resources.GetString("rmnuReportGlobals.ToolTip");
            // 
            // rmnuReportMore
            // 
            this.rmnuReportMore.KeyTip = "4";
            this.rmnuReportMore.Name = "rmnuReportMore";
            this.rmnuReportMore.SmallImage = global::FlexReportDesignerApp.Img_ScriptEditor.More_16;
            this.rmnuReportMore.Text = "More";
            this.rmnuReportMore.ToolTip = resources.GetString("rmnuReportMore.ToolTip");
            // 
            // rmnuVBScriptFunctions
            // 
            this.rmnuVBScriptFunctions.KeyTip = "5";
            this.rmnuVBScriptFunctions.Name = "rmnuVBScriptFunctions";
            this.rmnuVBScriptFunctions.SmallImage = global::FlexReportDesignerApp.Img_ScriptEditor.Functions_16;
            this.rmnuVBScriptFunctions.Text = "Functions";
            this.rmnuVBScriptFunctions.ToolTip = resources.GetString("rmnuVBScriptFunctions.ToolTip");
            // 
            // rmnuVBScriptProgram
            // 
            this.rmnuVBScriptProgram.KeyTip = "6";
            this.rmnuVBScriptProgram.Name = "rmnuVBScriptProgram";
            this.rmnuVBScriptProgram.SmallImage = global::FlexReportDesignerApp.Img_ScriptEditor.Program_16;
            this.rmnuVBScriptProgram.Text = "Program";
            this.rmnuVBScriptProgram.ToolTip = resources.GetString("rmnuVBScriptProgram.ToolTip");
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
            // rbTextColor
            // 
            this.rbTextColor.DefaultColor = System.Drawing.Color.Black;
            this.rbTextColor.KeyTip = "FC";
            this.rbTextColor.Name = "rbTextColor";
            this.rbTextColor.SmallImage = global::FlexReportDesignerApp.Img_Home.FontColor_16;
            this.rbTextColor.ToolTip = resources.GetString("rbTextColor.ToolTip");
            // 
            // rbBackgroundColor
            // 
            this.rbBackgroundColor.DefaultColor = System.Drawing.Color.White;
            this.rbBackgroundColor.KeyTip = "FL";
            this.rbBackgroundColor.Name = "rbBackgroundColor";
            this.rbBackgroundColor.SmallImage = global::FlexReportDesignerApp.Img_Home.BackgroundColor_16;
            this.rbBackgroundColor.ToolTip = resources.GetString("rbBackgroundColor.ToolTip");
            // 
            // rbtnError
            // 
            this.rbtnError.Name = "rbtnError";
            this.rbtnError.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnError.SmallImage")));
            this.rbtnError.Visible = false;
            // 
            // cCut
            // 
            this.cCut.Image = global::FlexReportDesignerApp.Img_Home.Cut_16;
            this.cCut.Name = "cCut";
            this.cCut.Shortcut = System.Windows.Forms.Shortcut.CtrlX;
            this.cCut.ShortcutText = "";
            this.cCut.Text = "Cut";
            // 
            // cCopy
            // 
            this.cCopy.Image = global::FlexReportDesignerApp.Img_Home.Copy_16;
            this.cCopy.Name = "cCopy";
            this.cCopy.Shortcut = System.Windows.Forms.Shortcut.CtrlC;
            this.cCopy.ShortcutText = "";
            this.cCopy.Text = "Copy";
            // 
            // cPaste
            // 
            this.cPaste.Image = global::FlexReportDesignerApp.Img_Home.Paste_32;
            this.cPaste.Name = "cPaste";
            this.cPaste.Shortcut = System.Windows.Forms.Shortcut.CtrlV;
            this.cPaste.ShortcutText = "";
            this.cPaste.Text = "Paste";
            // 
            // cDelete
            // 
            this.cDelete.Image = global::FlexReportDesignerApp.Img_Home.Delete_16;
            this.cDelete.Name = "cDelete";
            this.cDelete.Shortcut = System.Windows.Forms.Shortcut.Del;
            this.cDelete.ShortcutText = "";
            this.cDelete.Text = "Delete";
            // 
            // cUndo
            // 
            this.cUndo.Image = global::FlexReportDesignerApp.Img_Home.Undo_16;
            this.cUndo.Name = "cUndo";
            this.cUndo.Shortcut = System.Windows.Forms.Shortcut.CtrlZ;
            this.cUndo.ShortcutText = "";
            this.cUndo.Text = "Undo";
            // 
            // cRedo
            // 
            this.cRedo.Image = global::FlexReportDesignerApp.Img_Home.Redo_16;
            this.cRedo.Name = "cRedo";
            this.cRedo.Shortcut = System.Windows.Forms.Shortcut.CtrlY;
            this.cRedo.ShortcutText = "";
            this.cRedo.Text = "Redo";
            // 
            // cmnuReportParams
            // 
            this.cmnuReportParams.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink8});
            this.cmnuReportParams.Image = global::FlexReportDesignerApp.Img_ScriptEditor.ReportParameter_16;
            this.cmnuReportParams.Name = "cmnuReportParams";
            this.cmnuReportParams.ShortcutText = "";
            this.cmnuReportParams.Text = "Report Parameters";
            // 
            // c1CommandLink8
            // 
            this.c1CommandLink8.Text = "New Command";
            // 
            // cmnuDataFields
            // 
            this.cmnuDataFields.Image = global::FlexReportDesignerApp.Img_ScriptEditor.DatabaseFields_16;
            this.cmnuDataFields.Name = "cmnuDataFields";
            this.cmnuDataFields.ShortcutText = "";
            this.cmnuDataFields.Text = "Database Fields";
            // 
            // cmnuCalculatedFields
            // 
            this.cmnuCalculatedFields.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink9});
            this.cmnuCalculatedFields.Image = global::FlexReportDesignerApp.Img_ScriptEditor.CalculatedFields_16;
            this.cmnuCalculatedFields.Name = "cmnuCalculatedFields";
            this.cmnuCalculatedFields.ShortcutText = "";
            this.cmnuCalculatedFields.Text = "Calculated Fields";
            // 
            // c1CommandLink9
            // 
            this.c1CommandLink9.Text = "New Command";
            // 
            // cmnuReportFields
            // 
            this.cmnuReportFields.Image = global::FlexReportDesignerApp.Img_ScriptEditor.ReportFields_16;
            this.cmnuReportFields.Name = "cmnuReportFields";
            this.cmnuReportFields.ShortcutText = "";
            this.cmnuReportFields.Text = "Report Fields";
            // 
            // cmnuReportGlobals
            // 
            this.cmnuReportGlobals.Image = global::FlexReportDesignerApp.Img_ScriptEditor.GlobalScripts_16;
            this.cmnuReportGlobals.Name = "cmnuReportGlobals";
            this.cmnuReportGlobals.ShortcutText = "";
            this.cmnuReportGlobals.Text = "Global Scripts";
            // 
            // cmnuReportMore
            // 
            this.cmnuReportMore.Image = global::FlexReportDesignerApp.Img_ScriptEditor.More_16;
            this.cmnuReportMore.Name = "cmnuReportMore";
            this.cmnuReportMore.ShortcutText = "";
            this.cmnuReportMore.Text = "More";
            // 
            // cmnuVBScriptFunc
            // 
            this.cmnuVBScriptFunc.Image = global::FlexReportDesignerApp.Img_ScriptEditor.Functions_16;
            this.cmnuVBScriptFunc.Name = "cmnuVBScriptFunc";
            this.cmnuVBScriptFunc.ShortcutText = "";
            this.cmnuVBScriptFunc.Text = "Functions";
            // 
            // cmnuVBScriptProg
            // 
            this.cmnuVBScriptProg.Image = global::FlexReportDesignerApp.Img_ScriptEditor.Program_16;
            this.cmnuVBScriptProg.Name = "cmnuVBScriptProg";
            this.cmnuVBScriptProg.ShortcutText = "";
            this.cmnuVBScriptProg.Text = "Program";
            // 
            // cmnuReportGroups
            // 
            this.cmnuReportGroups.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLink10});
            this.cmnuReportGroups.Image = global::FlexReportDesignerApp.Img_Home.Groups_16;
            this.cmnuReportGroups.Name = "cmnuReportGroups";
            this.cmnuReportGroups.ShortcutText = "";
            this.cmnuReportGroups.Text = "Report Groups";
            // 
            // c1CommandLink10
            // 
            this.c1CommandLink10.Text = "New Command";
            // 
            // ScriptEditorFormEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 685);
            this.Controls.Add(this._splitter);
            this.Controls.Add(this._slNote);
            this.Controls.Add(this.rbnMain);
            this.Controls.Add(this._statusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "ScriptEditorFormEx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VBScript Editor";
            ((System.ComponentModel.ISupportInitialize)(this.chMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._statusBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbnMain)).EndInit();
            this._splitter.Panel1.ResumeLayout(false);
            this._splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitter)).EndInit();
            this._splitter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Command.C1CommandHolder chMain;
        private C1.Win.Command.C1Command cCut;
        private C1.Win.Command.C1Command cCopy;
        private C1.Win.Command.C1Command cPaste;
        private C1.Win.Command.C1Command cUndo;
        private C1.Win.Command.C1Command cRedo;
        private C1.Win.Ribbon.C1StatusBar _statusBar;
        private C1.Win.Command.C1ContextMenu contextMenu;
        private C1.Win.Command.C1CommandLink c1CommandLink1;
        private C1.Win.Command.C1CommandLink c1CommandLink2;
        private C1.Win.Command.C1CommandLink c1CommandLink3;
        private C1.Win.Command.C1CommandLink c1CommandLink4;
        private C1.Win.Command.C1CommandLink c1CommandLink5;
        private C1.Win.Command.C1Command cDelete;
        private C1.Win.Command.C1CommandLink c1CommandLink6;
        private C1.Win.Command.C1CommandLink c1CommandLink7;
        private C1.Win.Command.C1Command cSelectAll;
        private C1.Win.Ribbon.RibbonLabel rlblRow;
        private C1.Win.Ribbon.RibbonLabel rlblCol;
        private C1.Win.Ribbon.RibbonButton rbtnError;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator1;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator2;
        private C1.Win.Ribbon.RibbonLabel rblText;
        private Forms.ScriptEditorControl _scriptEditor1;
        private C1.Win.Ribbon.C1Ribbon rbnMain;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab rtHome;
        private C1.Win.Ribbon.RibbonGroup rgMain;
        private C1.Win.Ribbon.RibbonGroup rgEdit;
        private C1.Win.Ribbon.RibbonButton rbtnPaste;
        private C1.Win.Ribbon.RibbonButton rbtnCut;
        private C1.Win.Ribbon.RibbonButton rbtnCopy;
        private C1.Win.Ribbon.RibbonButton rbtnDelete;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator3;
        private C1.Win.Ribbon.RibbonButton rbtnUndo;
        private C1.Win.Ribbon.RibbonButton rbtnRedo;
        private C1.Win.Ribbon.RibbonButton rbtnOK;
        private C1.Win.Ribbon.RibbonButton rbtnCancel;
        private C1.Win.Command.C1Command cOK;
        private C1.Win.Command.C1Command cCancel;
        private C1.Win.Ribbon.RibbonGroup rgInsert;
        private C1.Win.Ribbon.RibbonMenu rmnuReportFields;
        private C1.Win.Ribbon.RibbonMenu rmnuDataFields;
        private C1.Win.Ribbon.RibbonMenu rmnuReportMore;
        private C1.Win.Ribbon.RibbonGroup rgVBScript;
        private C1.Win.Ribbon.RibbonMenu rmnuVBScriptFunctions;
        private C1.Win.Ribbon.RibbonMenu rmnuVBScriptProgram;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator4;
        private C1.Win.Ribbon.RibbonMenu rmnuReportGlobals;
        private C1.Win.Command.C1CommandLink c1CommandLink19;
        private C1.Win.Command.C1CommandMenu cInsertC1Report;
        private C1.Win.Command.C1CommandLink c1CommandLink20;
        private C1.Win.Command.C1CommandLink c1CommandLink22;
        private C1.Win.Command.C1CommandMenu cInsertVBSCript;
        private C1.Win.Command.C1CommandLink c1CommandLink21;
        private C1.Win.Command.C1CommandMenu cmnuReportFields;
        private C1.Win.Command.C1CommandLink c1CommandLink27;
        private C1.Win.Command.C1CommandMenu cmnuDataFields;
        private C1.Win.Command.C1CommandLink c1CommandLink28;
        private C1.Win.Command.C1CommandMenu cmnuReportGlobals;
        private C1.Win.Command.C1CommandLink c1CommandLink29;
        private C1.Win.Command.C1CommandMenu cmnuReportMore;
        private C1.Win.Command.C1CommandMenu cmnuVBScriptFunc;
        private C1.Win.Command.C1CommandLink c1CommandLink32;
        private C1.Win.Command.C1CommandMenu cmnuVBScriptProg;
        private C1.Win.Ribbon.RibbonTab rtView;
        private C1.Win.Ribbon.RibbonGroup rgDisplay;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar1;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar2;
        private C1.Win.Ribbon.RibbonFontComboBox rbEditorFontName;
        private C1.Win.Ribbon.RibbonLabel rlblEditorBackColor;
        private C1.Win.Ribbon.RibbonColorPicker rbBackgroundColor;
        private C1.Win.Ribbon.RibbonComboBox rbFontSize;
        private C1.Win.Ribbon.RibbonButton rbtnFontSizeUp;
        private C1.Win.Ribbon.RibbonButton rbtnFontSizeDown;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator6;
        private C1.Win.SuperTooltip.C1SuperLabel _slNote;
        private C1.Win.Ribbon.RibbonGroup rgOptions;
        private C1.Win.Ribbon.RibbonCheckBox rbSyntaxHighlight;
        private C1.Win.Ribbon.RibbonCheckBox rbSyntaxAutoCheck;
        private C1.Win.Ribbon.RibbonCheckBox rbDataSourceFilterWarning;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator8;
        private C1.Win.Ribbon.RibbonCheckBox rbAutoSave;
        private C1.Win.Ribbon.RibbonColorPicker rbTextColor;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator5;
        private C1.Win.Ribbon.RibbonButton rbtnGoBack;
        private C1.Win.Ribbon.RibbonButton rbtnGoForward;
        private C1.Win.Command.C1Command cHistBack;
        private C1.Win.Command.C1Command cHistForward;
        private ScriptEditorControl _scriptEditor0;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Command.C1Command cSwitchWindow;
        private System.Windows.Forms.SplitContainer _splitter;
        private C1.Win.Command.C1Command cPasteAlt;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Command.C1CommandMenu cmnuReportParams;
        private C1.Win.Command.C1CommandLink c1CommandLink8;
        private C1.Win.Command.C1CommandMenu cmnuCalculatedFields;
        private C1.Win.Command.C1CommandLink c1CommandLink9;
        private C1.Win.Command.C1CommandMenu cmnuReportGroups;
        private C1.Win.Command.C1CommandLink c1CommandLink10;
        private C1.Win.Command.C1CommandLink c1CommandLink11;
        private C1.Win.Command.C1CommandLink c1CommandLink12;
        private C1.Win.Ribbon.RibbonMenu rmnuReportParams;
        private C1.Win.Ribbon.RibbonMenu rmnuCalculatedFields;
    }
}
