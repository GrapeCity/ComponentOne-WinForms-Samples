//----------------------------------------------------------------------------
// OptionsForm.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp
{
    /// <summary>
    /// Summary description for OptionsForm.
    /// </summary>
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
    	
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._chkReload = new System.Windows.Forms.CheckBox();
            this._cmbGridUnits = new System.Windows.Forms.ComboBox();
            this._chkEmbed = new System.Windows.Forms.CheckBox();
            this._chkAutoSave = new System.Windows.Forms.CheckBox();
            this._chkCategorize = new System.Windows.Forms.CheckBox();
            this._chkSortReportList = new System.Windows.Forms.CheckBox();
            this._numSpacing = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this._chkShowGrid = new System.Windows.Forms.CheckBox();
            this._chkSnapToGrid = new System.Windows.Forms.CheckBox();
            this._btnFont = new System.Windows.Forms.Button();
            this._chkSyntaxColoring = new System.Windows.Forms.CheckBox();
            this._chkSyntaxCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this._cmbIsolationLevel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.General = new System.Windows.Forms.TabPage();
            this._chkFileAssociateFLXR = new System.Windows.Forms.CheckBox();
            this._chkInsertLegacyField = new System.Windows.Forms.CheckBox();
            this._chkOpenExportedFile = new System.Windows.Forms.CheckBox();
            this._gbTheme = new System.Windows.Forms.GroupBox();
            this._btnThemeApply = new System.Windows.Forms.Button();
            this._rbtThemeCustom = new System.Windows.Forms.RadioButton();
            this._rbtThemeBuiltIn = new System.Windows.Forms.RadioButton();
            this._cmbThemeCustom = new System.Windows.Forms.ComboBox();
            this._cmbThemeBuiltIn = new System.Windows.Forms.ComboBox();
            this.DesignPane = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._cbUseInPlaceFixedFont = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._chkSnapToSides = new System.Windows.Forms.CheckBox();
            this._chkSnapToPadding = new System.Windows.Forms.CheckBox();
            this._numSnapPaddingY = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this._numSnapPaddingX = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnDesignerPaneColorsReset = new System.Windows.Forms.Button();
            this._cbIndicatorShow = new System.Windows.Forms.CheckBox();
            this._cpSelectionBase = new C1.Win.C1Input.C1ColorPicker();
            this._cpHighlightBase = new C1.Win.C1Input.C1ColorPicker();
            this._cpIndicatorBase = new C1.Win.C1Input.C1ColorPicker();
            this._cpCaptionBase = new C1.Win.C1Input.C1ColorPicker();
            this._cpControlBase = new C1.Win.C1Input.C1ColorPicker();
            this._cpRulerBase = new C1.Win.C1Input.C1ColorPicker();
            this._cpGridBase = new C1.Win.C1Input.C1ColorPicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this._cpBrickBoundsBase = new C1.Win.C1Input.C1ColorPicker();
            this.label12 = new System.Windows.Forms.Label();
            this._cpRubberBandBase = new C1.Win.C1Input.C1ColorPicker();
            this.label11 = new System.Windows.Forms.Label();
            this._cpMouseGuidesBase = new C1.Win.C1Input.C1ColorPicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SaveLoad = new System.Windows.Forms.TabPage();
            this._btnResetLayout = new System.Windows.Forms.Button();
            this._chkRestoreEditorSettings = new System.Windows.Forms.CheckBox();
            this.Connection = new System.Windows.Forms.TabPage();
            this.ScriptEditor = new System.Windows.Forms.TabPage();
            this.Warnings = new System.Windows.Forms.TabPage();
            this._chkWarn_AppIn64bitMode = new System.Windows.Forms.CheckBox();
            this._chkCheckUpdates = new System.Windows.Forms.CheckBox();
            this._chkWarn_ImportCrystalRASNotAvailable = new System.Windows.Forms.CheckBox();
            this._chkInsertLegacyChart = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._numSpacing)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.General.SuspendLayout();
            this._gbTheme.SuspendLayout();
            this.DesignPane.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numSnapPaddingY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numSnapPaddingX)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cpSelectionBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpHighlightBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpIndicatorBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpCaptionBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpControlBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpRulerBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpGridBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpBrickBoundsBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpRubberBandBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpMouseGuidesBase)).BeginInit();
            this.SaveLoad.SuspendLayout();
            this.Connection.SuspendLayout();
            this.ScriptEditor.SuspendLayout();
            this.Warnings.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnOK.Location = new System.Drawing.Point(495, 398);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(88, 24);
            this._btnOK.TabIndex = 0;
            this._btnOK.Text = "&OK";
            this._btnOK.Click += new System.EventHandler(this._btnOK_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnCancel.Location = new System.Drawing.Point(591, 398);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(88, 24);
            this._btnCancel.TabIndex = 1;
            this._btnCancel.Text = "&Cancel";
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grid uni&ts:";
            // 
            // _chkReload
            // 
            this._chkReload.AutoSize = true;
            this._chkReload.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkReload.Location = new System.Drawing.Point(11, 11);
            this._chkReload.Name = "_chkReload";
            this._chkReload.Size = new System.Drawing.Size(151, 18);
            this._chkReload.TabIndex = 0;
            this._chkReload.Text = "&Reload last file on startup";
            this._chkReload.CheckedChanged += new System.EventHandler(this._chkReload_CheckedChanged);
            // 
            // _cmbGridUnits
            // 
            this._cmbGridUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbGridUnits.Location = new System.Drawing.Point(111, 67);
            this._cmbGridUnits.Name = "_cmbGridUnits";
            this._cmbGridUnits.Size = new System.Drawing.Size(135, 21);
            this._cmbGridUnits.TabIndex = 3;
            this._cmbGridUnits.SelectedIndexChanged += new System.EventHandler(this._cmbUnits_SelectedIndexChanged);
            // 
            // _chkEmbed
            // 
            this._chkEmbed.AutoSize = true;
            this._chkEmbed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkEmbed.Location = new System.Drawing.Point(11, 83);
            this._chkEmbed.Name = "_chkEmbed";
            this._chkEmbed.Size = new System.Drawing.Size(204, 18);
            this._chkEmbed.TabIndex = 3;
            this._chkEmbed.Text = "&Embed images into Xml when saving";
            // 
            // _chkAutoSave
            // 
            this._chkAutoSave.AutoSize = true;
            this._chkAutoSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkAutoSave.Location = new System.Drawing.Point(11, 59);
            this._chkAutoSave.Name = "_chkAutoSave";
            this._chkAutoSave.Size = new System.Drawing.Size(181, 18);
            this._chkAutoSave.TabIndex = 2;
            this._chkAutoSave.Text = "&Save changes before rendering";
            // 
            // _chkCategorize
            // 
            this._chkCategorize.AutoSize = true;
            this._chkCategorize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkCategorize.Location = new System.Drawing.Point(11, 11);
            this._chkCategorize.Name = "_chkCategorize";
            this._chkCategorize.Size = new System.Drawing.Size(143, 18);
            this._chkCategorize.TabIndex = 0;
            this._chkCategorize.Text = "&Categorize property grid";
            // 
            // _chkSortReportList
            // 
            this._chkSortReportList.AutoSize = true;
            this._chkSortReportList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkSortReportList.Location = new System.Drawing.Point(11, 35);
            this._chkSortReportList.Name = "_chkSortReportList";
            this._chkSortReportList.Size = new System.Drawing.Size(96, 18);
            this._chkSortReportList.TabIndex = 1;
            this._chkSortReportList.Text = "Sor&t report list";
            // 
            // _numSpacing
            // 
            this._numSpacing.Enabled = false;
            this._numSpacing.Location = new System.Drawing.Point(111, 94);
            this._numSpacing.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this._numSpacing.Name = "_numSpacing";
            this._numSpacing.Size = new System.Drawing.Size(135, 20);
            this._numSpacing.TabIndex = 5;
            this._numSpacing.Value = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Grid s&pacing:";
            // 
            // _chkShowGrid
            // 
            this._chkShowGrid.AutoSize = true;
            this._chkShowGrid.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkShowGrid.Location = new System.Drawing.Point(9, 20);
            this._chkShowGrid.Name = "_chkShowGrid";
            this._chkShowGrid.Size = new System.Drawing.Size(79, 18);
            this._chkShowGrid.TabIndex = 0;
            this._chkShowGrid.Text = "Show &grid";
            // 
            // _chkSnapToGrid
            // 
            this._chkSnapToGrid.AutoSize = true;
            this._chkSnapToGrid.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkSnapToGrid.Location = new System.Drawing.Point(9, 41);
            this._chkSnapToGrid.Name = "_chkSnapToGrid";
            this._chkSnapToGrid.Size = new System.Drawing.Size(89, 18);
            this._chkSnapToGrid.TabIndex = 1;
            this._chkSnapToGrid.Text = "S&nap to grid";
            // 
            // _btnFont
            // 
            this._btnFont.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnFont.Location = new System.Drawing.Point(101, 59);
            this._btnFont.Name = "_btnFont";
            this._btnFont.Size = new System.Drawing.Size(285, 24);
            this._btnFont.TabIndex = 3;
            this._btnFont.Text = "Courier New, 9pt";
            this._btnFont.Click += new System.EventHandler(this._btnFont_Click);
            // 
            // _chkSyntaxColoring
            // 
            this._chkSyntaxColoring.AutoSize = true;
            this._chkSyntaxColoring.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkSyntaxColoring.Location = new System.Drawing.Point(11, 35);
            this._chkSyntaxColoring.Name = "_chkSyntaxColoring";
            this._chkSyntaxColoring.Size = new System.Drawing.Size(104, 18);
            this._chkSyntaxColoring.TabIndex = 1;
            this._chkSyntaxColoring.Text = "S&yntax coloring";
            // 
            // _chkSyntaxCheck
            // 
            this._chkSyntaxCheck.AutoSize = true;
            this._chkSyntaxCheck.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkSyntaxCheck.Location = new System.Drawing.Point(11, 11);
            this._chkSyntaxCheck.Name = "_chkSyntaxCheck";
            this._chkSyntaxCheck.Size = new System.Drawing.Size(134, 18);
            this._chkSyntaxCheck.TabIndex = 0;
            this._chkSyntaxCheck.Text = "&Auto syntax checking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "F&ont:";
            // 
            // _cmbIsolationLevel
            // 
            this._cmbIsolationLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbIsolationLevel.FormattingEnabled = true;
            this._cmbIsolationLevel.Location = new System.Drawing.Point(14, 42);
            this._cmbIsolationLevel.Name = "_cmbIsolationLevel";
            this._cmbIsolationLevel.Size = new System.Drawing.Size(200, 21);
            this._cmbIsolationLevel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(398, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Transaction isolation level for newly created reports (the default is ReadCommitt" +
    "ed):";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.General);
            this.tabControl1.Controls.Add(this.DesignPane);
            this.tabControl1.Controls.Add(this.SaveLoad);
            this.tabControl1.Controls.Add(this.Connection);
            this.tabControl1.Controls.Add(this.ScriptEditor);
            this.tabControl1.Controls.Add(this.Warnings);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(667, 377);
            this.tabControl1.TabIndex = 0;
            // 
            // General
            // 
            this.General.Controls.Add(this._chkFileAssociateFLXR);
            this.General.Controls.Add(this._chkInsertLegacyChart);
            this.General.Controls.Add(this._chkInsertLegacyField);
            this.General.Controls.Add(this._chkOpenExportedFile);
            this.General.Controls.Add(this._gbTheme);
            this.General.Controls.Add(this._chkSortReportList);
            this.General.Controls.Add(this._chkCategorize);
            this.General.Location = new System.Drawing.Point(4, 22);
            this.General.Name = "General";
            this.General.Padding = new System.Windows.Forms.Padding(8);
            this.General.Size = new System.Drawing.Size(659, 351);
            this.General.TabIndex = 0;
            this.General.Text = "General";
            this.General.UseVisualStyleBackColor = true;
            // 
            // _chkFileAssociateFLXR
            // 
            this._chkFileAssociateFLXR.AutoSize = true;
            this._chkFileAssociateFLXR.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkFileAssociateFLXR.Location = new System.Drawing.Point(11, 131);
            this._chkFileAssociateFLXR.Name = "_chkFileAssociateFLXR";
            this._chkFileAssociateFLXR.Size = new System.Drawing.Size(268, 18);
            this._chkFileAssociateFLXR.TabIndex = 5;
            this._chkFileAssociateFLXR.Text = "Associate .FLXR file type with FlexReportDesigner";
            // 
            // _chkInsertLegacyField
            // 
            this._chkInsertLegacyField.AutoSize = true;
            this._chkInsertLegacyField.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkInsertLegacyField.Location = new System.Drawing.Point(11, 83);
            this._chkInsertLegacyField.Name = "_chkInsertLegacyField";
            this._chkInsertLegacyField.Size = new System.Drawing.Size(259, 18);
            this._chkInsertLegacyField.TabIndex = 3;
            this._chkInsertLegacyField.Text = "Show \"Legacy Field\" button on the INSERT tab";
            // 
            // _chkOpenExportedFile
            // 
            this._chkOpenExportedFile.AutoSize = true;
            this._chkOpenExportedFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkOpenExportedFile.Location = new System.Drawing.Point(11, 59);
            this._chkOpenExportedFile.Name = "_chkOpenExportedFile";
            this._chkOpenExportedFile.Size = new System.Drawing.Size(144, 18);
            this._chkOpenExportedFile.TabIndex = 2;
            this._chkOpenExportedFile.Text = "Open file after exporting";
            // 
            // _gbTheme
            // 
            this._gbTheme.Controls.Add(this._btnThemeApply);
            this._gbTheme.Controls.Add(this._rbtThemeCustom);
            this._gbTheme.Controls.Add(this._rbtThemeBuiltIn);
            this._gbTheme.Controls.Add(this._cmbThemeCustom);
            this._gbTheme.Controls.Add(this._cmbThemeBuiltIn);
            this._gbTheme.Location = new System.Drawing.Point(11, 236);
            this._gbTheme.Name = "_gbTheme";
            this._gbTheme.Size = new System.Drawing.Size(393, 104);
            this._gbTheme.TabIndex = 6;
            this._gbTheme.TabStop = false;
            this._gbTheme.Text = "Designer Theme";
            // 
            // _btnThemeApply
            // 
            this._btnThemeApply.Location = new System.Drawing.Point(205, 73);
            this._btnThemeApply.Name = "_btnThemeApply";
            this._btnThemeApply.Size = new System.Drawing.Size(182, 23);
            this._btnThemeApply.TabIndex = 4;
            this._btnThemeApply.Text = "Apply (cannot be canceled)";
            this._btnThemeApply.UseVisualStyleBackColor = true;
            this._btnThemeApply.Click += new System.EventHandler(this._btnThemeApply_Click);
            // 
            // _rbtThemeCustom
            // 
            this._rbtThemeCustom.AutoSize = true;
            this._rbtThemeCustom.Location = new System.Drawing.Point(6, 46);
            this._rbtThemeCustom.Name = "_rbtThemeCustom";
            this._rbtThemeCustom.Size = new System.Drawing.Size(95, 17);
            this._rbtThemeCustom.TabIndex = 2;
            this._rbtThemeCustom.TabStop = true;
            this._rbtThemeCustom.Text = "Themes folder:";
            this._rbtThemeCustom.UseVisualStyleBackColor = true;
            // 
            // _rbtThemeBuiltIn
            // 
            this._rbtThemeBuiltIn.AutoSize = true;
            this._rbtThemeBuiltIn.Location = new System.Drawing.Point(6, 19);
            this._rbtThemeBuiltIn.Name = "_rbtThemeBuiltIn";
            this._rbtThemeBuiltIn.Size = new System.Drawing.Size(59, 17);
            this._rbtThemeBuiltIn.TabIndex = 0;
            this._rbtThemeBuiltIn.TabStop = true;
            this._rbtThemeBuiltIn.Text = "Built in:";
            this._rbtThemeBuiltIn.UseVisualStyleBackColor = true;
            // 
            // _cmbThemeCustom
            // 
            this._cmbThemeCustom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbThemeCustom.FormattingEnabled = true;
            this._cmbThemeCustom.Location = new System.Drawing.Point(129, 46);
            this._cmbThemeCustom.Name = "_cmbThemeCustom";
            this._cmbThemeCustom.Size = new System.Drawing.Size(258, 21);
            this._cmbThemeCustom.TabIndex = 3;
            this._cmbThemeCustom.SelectedIndexChanged += new System.EventHandler(this._cmbThemeCustom_SelectedIndexChanged);
            // 
            // _cmbThemeBuiltIn
            // 
            this._cmbThemeBuiltIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbThemeBuiltIn.FormattingEnabled = true;
            this._cmbThemeBuiltIn.Location = new System.Drawing.Point(129, 19);
            this._cmbThemeBuiltIn.Name = "_cmbThemeBuiltIn";
            this._cmbThemeBuiltIn.Size = new System.Drawing.Size(258, 21);
            this._cmbThemeBuiltIn.TabIndex = 1;
            this._cmbThemeBuiltIn.SelectedIndexChanged += new System.EventHandler(this._cmbThemeBuiltIn_SelectedIndexChanged);
            // 
            // DesignPane
            // 
            this.DesignPane.Controls.Add(this.groupBox3);
            this.DesignPane.Controls.Add(this._cbUseInPlaceFixedFont);
            this.DesignPane.Controls.Add(this.groupBox2);
            this.DesignPane.Controls.Add(this.groupBox1);
            this.DesignPane.Location = new System.Drawing.Point(4, 22);
            this.DesignPane.Name = "DesignPane";
            this.DesignPane.Padding = new System.Windows.Forms.Padding(8);
            this.DesignPane.Size = new System.Drawing.Size(659, 351);
            this.DesignPane.TabIndex = 1;
            this.DesignPane.Text = "Design Pane";
            this.DesignPane.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._chkShowGrid);
            this.groupBox3.Controls.Add(this._chkSnapToGrid);
            this.groupBox3.Controls.Add(this._cmbGridUnits);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this._numSpacing);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(379, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 126);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Grid";
            // 
            // _cbUseInPlaceFixedFont
            // 
            this._cbUseInPlaceFixedFont.AutoSize = true;
            this._cbUseInPlaceFixedFont.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._cbUseInPlaceFixedFont.Location = new System.Drawing.Point(388, 270);
            this._cbUseInPlaceFixedFont.Name = "_cbUseInPlaceFixedFont";
            this._cbUseInPlaceFixedFont.Size = new System.Drawing.Size(208, 18);
            this._cbUseInPlaceFixedFont.TabIndex = 3;
            this._cbUseInPlaceFixedFont.Text = "Use fixed font for in-place field editing";
            this._cbUseInPlaceFixedFont.CheckedChanged += new System.EventHandler(this._chkSnapToPadding_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._chkSnapToSides);
            this.groupBox2.Controls.Add(this._chkSnapToPadding);
            this.groupBox2.Controls.Add(this._numSnapPaddingY);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this._numSnapPaddingX);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(379, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Snap";
            // 
            // _chkSnapToSides
            // 
            this._chkSnapToSides.AutoSize = true;
            this._chkSnapToSides.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkSnapToSides.Location = new System.Drawing.Point(9, 19);
            this._chkSnapToSides.Name = "_chkSnapToSides";
            this._chkSnapToSides.Size = new System.Drawing.Size(157, 18);
            this._chkSnapToSides.TabIndex = 0;
            this._chkSnapToSides.Text = "Snap to field/section sides";
            this._chkSnapToSides.CheckedChanged += new System.EventHandler(this._chkSnapToPadding_CheckedChanged);
            // 
            // _chkSnapToPadding
            // 
            this._chkSnapToPadding.AutoSize = true;
            this._chkSnapToPadding.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkSnapToPadding.Location = new System.Drawing.Point(9, 43);
            this._chkSnapToPadding.Name = "_chkSnapToPadding";
            this._chkSnapToPadding.Size = new System.Drawing.Size(110, 18);
            this._chkSnapToPadding.TabIndex = 1;
            this._chkSnapToPadding.Text = "Snap to padding";
            this._chkSnapToPadding.CheckedChanged += new System.EventHandler(this._chkSnapToPadding_CheckedChanged);
            // 
            // _numSnapPaddingY
            // 
            this._numSnapPaddingY.Enabled = false;
            this._numSnapPaddingY.Location = new System.Drawing.Point(150, 92);
            this._numSnapPaddingY.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this._numSnapPaddingY.Name = "_numSnapPaddingY";
            this._numSnapPaddingY.Size = new System.Drawing.Size(96, 20);
            this._numSnapPaddingY.TabIndex = 5;
            this._numSnapPaddingY.Value = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Vertical padding:";
            // 
            // _numSnapPaddingX
            // 
            this._numSnapPaddingX.Enabled = false;
            this._numSnapPaddingX.Location = new System.Drawing.Point(150, 67);
            this._numSnapPaddingX.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this._numSnapPaddingX.Name = "_numSnapPaddingX";
            this._numSnapPaddingX.Size = new System.Drawing.Size(96, 20);
            this._numSnapPaddingX.TabIndex = 3;
            this._numSnapPaddingX.Value = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Horizontal padding:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnDesignerPaneColorsReset);
            this.groupBox1.Controls.Add(this._cbIndicatorShow);
            this.groupBox1.Controls.Add(this._cpSelectionBase);
            this.groupBox1.Controls.Add(this._cpHighlightBase);
            this.groupBox1.Controls.Add(this._cpIndicatorBase);
            this.groupBox1.Controls.Add(this._cpCaptionBase);
            this.groupBox1.Controls.Add(this._cpControlBase);
            this.groupBox1.Controls.Add(this._cpRulerBase);
            this.groupBox1.Controls.Add(this._cpGridBase);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this._cpBrickBoundsBase);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this._cpRubberBandBase);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this._cpMouseGuidesBase);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Colors";
            // 
            // _btnDesignerPaneColorsReset
            // 
            this._btnDesignerPaneColorsReset.Location = new System.Drawing.Point(260, 270);
            this._btnDesignerPaneColorsReset.Name = "_btnDesignerPaneColorsReset";
            this._btnDesignerPaneColorsReset.Size = new System.Drawing.Size(88, 24);
            this._btnDesignerPaneColorsReset.TabIndex = 21;
            this._btnDesignerPaneColorsReset.Text = "Reset";
            this._btnDesignerPaneColorsReset.UseVisualStyleBackColor = true;
            this._btnDesignerPaneColorsReset.Click += new System.EventHandler(this._btnDesignerPaneColorsReset_Click);
            // 
            // _cbIndicatorShow
            // 
            this._cbIndicatorShow.AutoSize = true;
            this._cbIndicatorShow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._cbIndicatorShow.Location = new System.Drawing.Point(9, 259);
            this._cbIndicatorShow.Name = "_cbIndicatorShow";
            this._cbIndicatorShow.Size = new System.Drawing.Size(154, 18);
            this._cbIndicatorShow.TabIndex = 20;
            this._cbIndicatorShow.Text = "Show group indicator strip";
            this._cbIndicatorShow.ThreeState = true;
            this._cbIndicatorShow.CheckedChanged += new System.EventHandler(this._chkSnapToPadding_CheckedChanged);
            // 
            // _cpSelectionBase
            // 
            this._cpSelectionBase.AllowEmpty = false;
            this._cpSelectionBase.Color = System.Drawing.Color.Transparent;
            this._cpSelectionBase.EmptyColorCaption = null;
            this._cpSelectionBase.ImagePadding = new System.Windows.Forms.Padding(0);
            this._cpSelectionBase.Location = new System.Drawing.Point(175, 19);
            this._cpSelectionBase.Name = "_cpSelectionBase";
            this._cpSelectionBase.Size = new System.Drawing.Size(173, 18);
            this._cpSelectionBase.TabIndex = 1;
            this._cpSelectionBase.Tag = null;
            // 
            // _cpHighlightBase
            // 
            this._cpHighlightBase.AllowEmpty = false;
            this._cpHighlightBase.Color = System.Drawing.Color.Transparent;
            this._cpHighlightBase.EmptyColorCaption = null;
            this._cpHighlightBase.ImagePadding = new System.Windows.Forms.Padding(0);
            this._cpHighlightBase.Location = new System.Drawing.Point(175, 211);
            this._cpHighlightBase.Name = "_cpHighlightBase";
            this._cpHighlightBase.Size = new System.Drawing.Size(173, 18);
            this._cpHighlightBase.TabIndex = 17;
            this._cpHighlightBase.Tag = null;
            // 
            // _cpIndicatorBase
            // 
            this._cpIndicatorBase.AllowEmpty = false;
            this._cpIndicatorBase.Color = System.Drawing.Color.Transparent;
            this._cpIndicatorBase.EmptyColorCaption = null;
            this._cpIndicatorBase.ImagePadding = new System.Windows.Forms.Padding(0);
            this._cpIndicatorBase.Location = new System.Drawing.Point(175, 235);
            this._cpIndicatorBase.Name = "_cpIndicatorBase";
            this._cpIndicatorBase.Size = new System.Drawing.Size(173, 18);
            this._cpIndicatorBase.TabIndex = 19;
            this._cpIndicatorBase.Tag = null;
            // 
            // _cpCaptionBase
            // 
            this._cpCaptionBase.AllowEmpty = false;
            this._cpCaptionBase.Color = System.Drawing.Color.Transparent;
            this._cpCaptionBase.EmptyColorCaption = null;
            this._cpCaptionBase.ImagePadding = new System.Windows.Forms.Padding(0);
            this._cpCaptionBase.Location = new System.Drawing.Point(175, 187);
            this._cpCaptionBase.Name = "_cpCaptionBase";
            this._cpCaptionBase.Size = new System.Drawing.Size(173, 18);
            this._cpCaptionBase.TabIndex = 15;
            this._cpCaptionBase.Tag = null;
            // 
            // _cpControlBase
            // 
            this._cpControlBase.AllowEmpty = false;
            this._cpControlBase.Color = System.Drawing.Color.Transparent;
            this._cpControlBase.EmptyColorCaption = null;
            this._cpControlBase.ImagePadding = new System.Windows.Forms.Padding(0);
            this._cpControlBase.Location = new System.Drawing.Point(175, 163);
            this._cpControlBase.Name = "_cpControlBase";
            this._cpControlBase.Size = new System.Drawing.Size(173, 18);
            this._cpControlBase.TabIndex = 13;
            this._cpControlBase.Tag = null;
            // 
            // _cpRulerBase
            // 
            this._cpRulerBase.AllowEmpty = false;
            this._cpRulerBase.Color = System.Drawing.Color.Transparent;
            this._cpRulerBase.EmptyColorCaption = null;
            this._cpRulerBase.ImagePadding = new System.Windows.Forms.Padding(0);
            this._cpRulerBase.Location = new System.Drawing.Point(175, 139);
            this._cpRulerBase.Name = "_cpRulerBase";
            this._cpRulerBase.Size = new System.Drawing.Size(173, 18);
            this._cpRulerBase.TabIndex = 11;
            this._cpRulerBase.Tag = null;
            // 
            // _cpGridBase
            // 
            this._cpGridBase.AllowEmpty = false;
            this._cpGridBase.Color = System.Drawing.Color.Transparent;
            this._cpGridBase.EmptyColorCaption = null;
            this._cpGridBase.ImagePadding = new System.Windows.Forms.Padding(0);
            this._cpGridBase.Location = new System.Drawing.Point(175, 115);
            this._cpGridBase.Name = "_cpGridBase";
            this._cpGridBase.Size = new System.Drawing.Size(173, 18);
            this._cpGridBase.TabIndex = 9;
            this._cpGridBase.Tag = null;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 214);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Highlight:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Selected items:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Detail group indicator:";
            // 
            // _cpBrickBoundsBase
            // 
            this._cpBrickBoundsBase.AllowEmpty = false;
            this._cpBrickBoundsBase.Color = System.Drawing.Color.Transparent;
            this._cpBrickBoundsBase.EmptyColorCaption = null;
            this._cpBrickBoundsBase.ImagePadding = new System.Windows.Forms.Padding(0);
            this._cpBrickBoundsBase.Location = new System.Drawing.Point(175, 91);
            this._cpBrickBoundsBase.Name = "_cpBrickBoundsBase";
            this._cpBrickBoundsBase.Size = new System.Drawing.Size(173, 18);
            this._cpBrickBoundsBase.TabIndex = 7;
            this._cpBrickBoundsBase.Tag = null;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Caption background:";
            // 
            // _cpRubberBandBase
            // 
            this._cpRubberBandBase.AllowEmpty = false;
            this._cpRubberBandBase.Color = System.Drawing.Color.Transparent;
            this._cpRubberBandBase.EmptyColorCaption = null;
            this._cpRubberBandBase.ImagePadding = new System.Windows.Forms.Padding(0);
            this._cpRubberBandBase.Location = new System.Drawing.Point(175, 43);
            this._cpRubberBandBase.Name = "_cpRubberBandBase";
            this._cpRubberBandBase.Size = new System.Drawing.Size(173, 18);
            this._cpRubberBandBase.TabIndex = 3;
            this._cpRubberBandBase.Tag = null;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Design background:";
            // 
            // _cpMouseGuidesBase
            // 
            this._cpMouseGuidesBase.AllowEmpty = false;
            this._cpMouseGuidesBase.Color = System.Drawing.Color.Transparent;
            this._cpMouseGuidesBase.EmptyColorCaption = null;
            this._cpMouseGuidesBase.ImagePadding = new System.Windows.Forms.Padding(0);
            this._cpMouseGuidesBase.Location = new System.Drawing.Point(175, 67);
            this._cpMouseGuidesBase.Name = "_cpMouseGuidesBase";
            this._cpMouseGuidesBase.Size = new System.Drawing.Size(173, 18);
            this._cpMouseGuidesBase.TabIndex = 5;
            this._cpMouseGuidesBase.Tag = null;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Rulers:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Grid:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Field bounds:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sizing/snap guides:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rubber band:";
            // 
            // SaveLoad
            // 
            this.SaveLoad.Controls.Add(this._btnResetLayout);
            this.SaveLoad.Controls.Add(this._chkEmbed);
            this.SaveLoad.Controls.Add(this._chkAutoSave);
            this.SaveLoad.Controls.Add(this._chkRestoreEditorSettings);
            this.SaveLoad.Controls.Add(this._chkReload);
            this.SaveLoad.Location = new System.Drawing.Point(4, 22);
            this.SaveLoad.Name = "SaveLoad";
            this.SaveLoad.Padding = new System.Windows.Forms.Padding(8);
            this.SaveLoad.Size = new System.Drawing.Size(659, 351);
            this.SaveLoad.TabIndex = 2;
            this.SaveLoad.Text = "Save/Load";
            this.SaveLoad.UseVisualStyleBackColor = true;
            // 
            // _btnResetLayout
            // 
            this._btnResetLayout.Location = new System.Drawing.Point(11, 316);
            this._btnResetLayout.Name = "_btnResetLayout";
            this._btnResetLayout.Size = new System.Drawing.Size(201, 24);
            this._btnResetLayout.TabIndex = 4;
            this._btnResetLayout.Text = "Reset designer layout";
            this._btnResetLayout.UseVisualStyleBackColor = true;
            this._btnResetLayout.Click += new System.EventHandler(this._btnResetLayout_Click);
            // 
            // _chkRestoreEditorSettings
            // 
            this._chkRestoreEditorSettings.AutoSize = true;
            this._chkRestoreEditorSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkRestoreEditorSettings.Location = new System.Drawing.Point(23, 35);
            this._chkRestoreEditorSettings.Name = "_chkRestoreEditorSettings";
            this._chkRestoreEditorSettings.Size = new System.Drawing.Size(143, 18);
            this._chkRestoreEditorSettings.TabIndex = 1;
            this._chkRestoreEditorSettings.Text = "Restore last editor state";
            // 
            // Connection
            // 
            this.Connection.Controls.Add(this.label8);
            this.Connection.Controls.Add(this._cmbIsolationLevel);
            this.Connection.Location = new System.Drawing.Point(4, 22);
            this.Connection.Name = "Connection";
            this.Connection.Padding = new System.Windows.Forms.Padding(8);
            this.Connection.Size = new System.Drawing.Size(659, 351);
            this.Connection.TabIndex = 3;
            this.Connection.Text = "Data";
            this.Connection.UseVisualStyleBackColor = true;
            // 
            // ScriptEditor
            // 
            this.ScriptEditor.Controls.Add(this.label3);
            this.ScriptEditor.Controls.Add(this._btnFont);
            this.ScriptEditor.Controls.Add(this._chkSyntaxColoring);
            this.ScriptEditor.Controls.Add(this._chkSyntaxCheck);
            this.ScriptEditor.Location = new System.Drawing.Point(4, 22);
            this.ScriptEditor.Name = "ScriptEditor";
            this.ScriptEditor.Padding = new System.Windows.Forms.Padding(8);
            this.ScriptEditor.Size = new System.Drawing.Size(659, 351);
            this.ScriptEditor.TabIndex = 4;
            this.ScriptEditor.Text = "Script Editor";
            this.ScriptEditor.UseVisualStyleBackColor = true;
            // 
            // Warnings
            // 
            this.Warnings.Controls.Add(this._chkWarn_AppIn64bitMode);
            this.Warnings.Controls.Add(this._chkCheckUpdates);
            this.Warnings.Controls.Add(this._chkWarn_ImportCrystalRASNotAvailable);
            this.Warnings.Location = new System.Drawing.Point(4, 22);
            this.Warnings.Name = "Warnings";
            this.Warnings.Padding = new System.Windows.Forms.Padding(3);
            this.Warnings.Size = new System.Drawing.Size(659, 351);
            this.Warnings.TabIndex = 5;
            this.Warnings.Text = "Warnings";
            this.Warnings.UseVisualStyleBackColor = true;
            // 
            // _chkWarn_AppIn64bitMode
            // 
            this._chkWarn_AppIn64bitMode.AutoSize = true;
            this._chkWarn_AppIn64bitMode.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkWarn_AppIn64bitMode.Location = new System.Drawing.Point(11, 58);
            this._chkWarn_AppIn64bitMode.Name = "_chkWarn_AppIn64bitMode";
            this._chkWarn_AppIn64bitMode.Size = new System.Drawing.Size(201, 18);
            this._chkWarn_AppIn64bitMode.TabIndex = 0;
            this._chkWarn_AppIn64bitMode.Text = "Application is running in &64 bit mode";
            // 
            // _chkCheckUpdates
            // 
            this._chkCheckUpdates.AutoSize = true;
            this._chkCheckUpdates.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkCheckUpdates.Location = new System.Drawing.Point(11, 11);
            this._chkCheckUpdates.Name = "_chkCheckUpdates";
            this._chkCheckUpdates.Size = new System.Drawing.Size(169, 18);
            this._chkCheckUpdates.TabIndex = 0;
            this._chkCheckUpdates.Text = "C&heck for updates on startup";
            // 
            // _chkWarn_ImportCrystalRASNotAvailable
            // 
            this._chkWarn_ImportCrystalRASNotAvailable.AutoSize = true;
            this._chkWarn_ImportCrystalRASNotAvailable.Location = new System.Drawing.Point(11, 35);
            this._chkWarn_ImportCrystalRASNotAvailable.Name = "_chkWarn_ImportCrystalRASNotAvailable";
            this._chkWarn_ImportCrystalRASNotAvailable.Size = new System.Drawing.Size(301, 17);
            this._chkWarn_ImportCrystalRASNotAvailable.TabIndex = 1;
            this._chkWarn_ImportCrystalRASNotAvailable.Text = "Import from Crystal Reports: warn if &RAS API is unavailable";
            this._chkWarn_ImportCrystalRASNotAvailable.UseVisualStyleBackColor = true;
            // 
            // _chkInsertLegacyChart
            // 
            this._chkInsertLegacyChart.AutoSize = true;
            this._chkInsertLegacyChart.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._chkInsertLegacyChart.Location = new System.Drawing.Point(11, 107);
            this._chkInsertLegacyChart.Name = "_chkInsertLegacyChart";
            this._chkInsertLegacyChart.Size = new System.Drawing.Size(262, 18);
            this._chkInsertLegacyChart.TabIndex = 4;
            this._chkInsertLegacyChart.Text = "Show \"Legacy Chart\" button on the INSERT tab";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(689, 429);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FlexReportDesigner Options";
            ((System.ComponentModel.ISupportInitialize)(this._numSpacing)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this._gbTheme.ResumeLayout(false);
            this._gbTheme.PerformLayout();
            this.DesignPane.ResumeLayout(false);
            this.DesignPane.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numSnapPaddingY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numSnapPaddingX)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._cpSelectionBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpHighlightBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpIndicatorBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpCaptionBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpControlBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpRulerBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpGridBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpBrickBoundsBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpRubberBandBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._cpMouseGuidesBase)).EndInit();
            this.SaveLoad.ResumeLayout(false);
            this.SaveLoad.PerformLayout();
            this.Connection.ResumeLayout(false);
            this.Connection.PerformLayout();
            this.ScriptEditor.ResumeLayout(false);
            this.ScriptEditor.PerformLayout();
            this.Warnings.ResumeLayout(false);
            this.Warnings.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion

    	
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox _chkReload;
        private System.Windows.Forms.ComboBox _cmbGridUnits;
        private System.Windows.Forms.CheckBox _chkEmbed;
        private System.Windows.Forms.CheckBox _chkAutoSave;
        private System.Windows.Forms.CheckBox _chkCategorize;
        private System.Windows.Forms.CheckBox _chkShowGrid;
        private System.Windows.Forms.CheckBox _chkSnapToGrid;
        private System.Windows.Forms.CheckBox _chkSyntaxColoring;
        private System.Windows.Forms.CheckBox _chkSyntaxCheck;
        private System.Windows.Forms.Button _btnFont;
        private System.Windows.Forms.Label label3;
        private System.Drawing.Font _scriptEditorFont = new System.Drawing.Font("Courier New", 9);
        private System.Windows.Forms.CheckBox _chkSortReportList;
        private System.Windows.Forms.NumericUpDown _numSpacing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _cmbIsolationLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage General;
        private System.Windows.Forms.TabPage DesignPane;
        private System.Windows.Forms.TabPage SaveLoad;
        private System.Windows.Forms.TabPage Connection;
        private System.Windows.Forms.TabPage ScriptEditor;
        private System.Windows.Forms.ComboBox _cmbThemeBuiltIn;
        private System.Windows.Forms.GroupBox _gbTheme;
        private System.Windows.Forms.RadioButton _rbtThemeCustom;
        private System.Windows.Forms.RadioButton _rbtThemeBuiltIn;
        private System.Windows.Forms.ComboBox _cmbThemeCustom;
        private System.Windows.Forms.Button _btnThemeApply;
        private System.Windows.Forms.TabPage Warnings;
        private System.Windows.Forms.CheckBox _chkWarn_ImportCrystalRASNotAvailable;
        private System.Windows.Forms.CheckBox _chkCheckUpdates;
        private C1.Win.C1Input.C1ColorPicker _cpRubberBandBase;
        private C1.Win.C1Input.C1ColorPicker _cpSelectionBase;
        private C1.Win.C1Input.C1ColorPicker _cpMouseGuidesBase;
        private C1.Win.C1Input.C1ColorPicker _cpGridBase;
        private C1.Win.C1Input.C1ColorPicker _cpBrickBoundsBase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button _btnDesignerPaneColorsReset;
        private C1.Win.C1Input.C1ColorPicker _cpRulerBase;
        private System.Windows.Forms.Label label10;
        private C1.Win.C1Input.C1ColorPicker _cpControlBase;
        private System.Windows.Forms.Label label11;
        private C1.Win.C1Input.C1ColorPicker _cpCaptionBase;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown _numSnapPaddingX;
        private System.Windows.Forms.CheckBox _chkSnapToPadding;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox _chkSnapToSides;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown _numSnapPaddingY;
        private System.Windows.Forms.Label label15;
        private C1.Win.C1Input.C1ColorPicker _cpHighlightBase;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox _chkOpenExportedFile;
        private C1.Win.C1Input.C1ColorPicker _cpIndicatorBase;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox _chkInsertLegacyField;
        private System.Windows.Forms.CheckBox _cbUseInPlaceFixedFont;
        private System.Windows.Forms.CheckBox _chkRestoreEditorSettings;
        private System.Windows.Forms.CheckBox _cbIndicatorShow;
        private System.Windows.Forms.CheckBox _chkFileAssociateFLXR;
        private System.Windows.Forms.Button _btnResetLayout;
        private System.Windows.Forms.CheckBox _chkWarn_AppIn64bitMode;
        private System.Windows.Forms.CheckBox _chkInsertLegacyChart;
    }
}
