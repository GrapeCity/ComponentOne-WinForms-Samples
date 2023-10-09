//----------------------------------------------------------------------------
// ReportWizard.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------

namespace FlexReportDesignerApp
{
    partial class ReportWizard : System.Windows.Forms.Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportWizard));
            this._tab = new System.Windows.Forms.TabControl();
            this._pgData = new System.Windows.Forms.TabPage();
            this._dsPicker = new FlexReportDesignerApp.Util.DataSourcePicker();
            this._pgLayout = new System.Windows.Forms.TabPage();
            this._checkAdjust = new System.Windows.Forms.CheckBox();
            this._gbLayout = new System.Windows.Forms.GroupBox();
            this._btnColumnar = new System.Windows.Forms.RadioButton();
            this._btnTabular = new System.Windows.Forms.RadioButton();
            this._btnJustified = new System.Windows.Forms.RadioButton();
            this._btnLabels = new System.Windows.Forms.RadioButton();
            this._btnOutline = new System.Windows.Forms.RadioButton();
            this._btnStepped = new System.Windows.Forms.RadioButton();
            this._btnAligned = new System.Windows.Forms.RadioButton();
            this._picLayout = new System.Windows.Forms.PictureBox();
            this._gbOrientation = new System.Windows.Forms.GroupBox();
            this._btnPortrait = new System.Windows.Forms.RadioButton();
            this._btnLandscape = new System.Windows.Forms.RadioButton();
            this._pgFields = new System.Windows.Forms.TabPage();
            this._btnAddFields = new System.Windows.Forms.Button();
            this._lstAvailable = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this._btnRemoveFields = new System.Windows.Forms.Button();
            this._lstGroups = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._lstDetail = new System.Windows.Forms.ListBox();
            this._pgLabels = new System.Windows.Forms.TabPage();
            this._lvLabels = new System.Windows.Forms.ListView();
            this._ch1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._ch2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._ch3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._gbUnits = new System.Windows.Forms.GroupBox();
            this._btnMetric = new System.Windows.Forms.RadioButton();
            this._btnEnglish = new System.Windows.Forms.RadioButton();
            this._picLabels = new System.Windows.Forms.PictureBox();
            this._gbPaperType = new System.Windows.Forms.GroupBox();
            this._btnSheetFeed = new System.Windows.Forms.RadioButton();
            this._btnContinuous = new System.Windows.Forms.RadioButton();
            this._pgStyle = new System.Windows.Forms.TabPage();
            this._lbStyles = new System.Windows.Forms.ListBox();
            this._picStyle = new System.Windows.Forms.PictureBox();
            this._pgTitle = new System.Windows.Forms.TabPage();
            this._btnPreview = new System.Windows.Forms.RadioButton();
            this._txtReportName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._picFinish = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._btnModify = new System.Windows.Forms.RadioButton();
            this._lblTitle = new System.Windows.Forms.Label();
            this._gb1 = new System.Windows.Forms.GroupBox();
            this._gb2 = new System.Windows.Forms.GroupBox();
            this._btnPanel = new System.Windows.Forms.Panel();
            this._btnBack = new System.Windows.Forms.Button();
            this._btnNext = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._tabPanel = new System.Windows.Forms.Panel();
            this._tab.SuspendLayout();
            this._pgData.SuspendLayout();
            this._pgLayout.SuspendLayout();
            this._gbLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picLayout)).BeginInit();
            this._gbOrientation.SuspendLayout();
            this._pgFields.SuspendLayout();
            this._pgLabels.SuspendLayout();
            this._gbUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picLabels)).BeginInit();
            this._gbPaperType.SuspendLayout();
            this._pgStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picStyle)).BeginInit();
            this._pgTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picFinish)).BeginInit();
            this._btnPanel.SuspendLayout();
            this._tabPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tab
            // 
            this._tab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this._tab.Controls.Add(this._pgData);
            this._tab.Controls.Add(this._pgLayout);
            this._tab.Controls.Add(this._pgFields);
            this._tab.Controls.Add(this._pgLabels);
            this._tab.Controls.Add(this._pgStyle);
            this._tab.Controls.Add(this._pgTitle);
            this._tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tab.Location = new System.Drawing.Point(0, 0);
            this._tab.Name = "_tab";
            this._tab.SelectedIndex = 0;
            this._tab.Size = new System.Drawing.Size(580, 378);
            this._tab.TabIndex = 0;
            this._tab.SelectedIndexChanged += new System.EventHandler(this._tab_SelectedIndexChanged);
            // 
            // _pgData
            // 
            this._pgData.Controls.Add(this._dsPicker);
            this._pgData.Location = new System.Drawing.Point(4, 25);
            this._pgData.Name = "_pgData";
            this._pgData.Size = new System.Drawing.Size(572, 349);
            this._pgData.TabIndex = 0;
            this._pgData.Tag = "Step 1: Select the Data Source for the new report.";
            this._pgData.Text = "DataSource";
            // 
            // _dsPicker
            // 
            this._dsPicker.DataSource = null;
            this._dsPicker.DesignerHostServices = null;
            this._dsPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dsPicker.Location = new System.Drawing.Point(0, 0);
            this._dsPicker.Name = "_dsPicker";
            this._dsPicker.Size = new System.Drawing.Size(572, 349);
            this._dsPicker.TabIndex = 0;
            // 
            // _pgLayout
            // 
            this._pgLayout.Controls.Add(this._checkAdjust);
            this._pgLayout.Controls.Add(this._gbLayout);
            this._pgLayout.Controls.Add(this._picLayout);
            this._pgLayout.Controls.Add(this._gbOrientation);
            this._pgLayout.Location = new System.Drawing.Point(4, 25);
            this._pgLayout.Name = "_pgLayout";
            this._pgLayout.Size = new System.Drawing.Size(572, 349);
            this._pgLayout.TabIndex = 2;
            this._pgLayout.Tag = "Step 3: Select the layout for the new report.";
            this._pgLayout.Text = "Layout";
            // 
            // _checkAdjust
            // 
            this._checkAdjust.AutoSize = true;
            this._checkAdjust.Checked = true;
            this._checkAdjust.CheckState = System.Windows.Forms.CheckState.Checked;
            this._checkAdjust.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._checkAdjust.Location = new System.Drawing.Point(276, 234);
            this._checkAdjust.Name = "_checkAdjust";
            this._checkAdjust.Size = new System.Drawing.Size(138, 18);
            this._checkAdjust.TabIndex = 3;
            this._checkAdjust.Text = "Adjust fields to fit page";
            // 
            // _gbLayout
            // 
            this._gbLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gbLayout.Controls.Add(this._btnColumnar);
            this._gbLayout.Controls.Add(this._btnTabular);
            this._gbLayout.Controls.Add(this._btnJustified);
            this._gbLayout.Controls.Add(this._btnLabels);
            this._gbLayout.Controls.Add(this._btnOutline);
            this._gbLayout.Controls.Add(this._btnStepped);
            this._gbLayout.Controls.Add(this._btnAligned);
            this._gbLayout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._gbLayout.Location = new System.Drawing.Point(271, 11);
            this._gbLayout.Name = "_gbLayout";
            this._gbLayout.Size = new System.Drawing.Size(291, 139);
            this._gbLayout.TabIndex = 1;
            this._gbLayout.TabStop = false;
            this._gbLayout.Text = "Layout";
            // 
            // _btnColumnar
            // 
            this._btnColumnar.AutoSize = true;
            this._btnColumnar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnColumnar.Location = new System.Drawing.Point(16, 22);
            this._btnColumnar.Name = "_btnColumnar";
            this._btnColumnar.Size = new System.Drawing.Size(75, 18);
            this._btnColumnar.TabIndex = 0;
            this._btnColumnar.Tag = "loColumnar";
            this._btnColumnar.Text = "&Columnar";
            this._btnColumnar.CheckedChanged += new System.EventHandler(this._btnLayout_CheckedChanged);
            // 
            // _btnTabular
            // 
            this._btnTabular.AutoSize = true;
            this._btnTabular.Checked = true;
            this._btnTabular.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnTabular.Location = new System.Drawing.Point(16, 49);
            this._btnTabular.Name = "_btnTabular";
            this._btnTabular.Size = new System.Drawing.Size(67, 18);
            this._btnTabular.TabIndex = 0;
            this._btnTabular.TabStop = true;
            this._btnTabular.Tag = "loTabular";
            this._btnTabular.Text = "&Tabular";
            this._btnTabular.CheckedChanged += new System.EventHandler(this._btnLayout_CheckedChanged);
            // 
            // _btnJustified
            // 
            this._btnJustified.AutoSize = true;
            this._btnJustified.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnJustified.Location = new System.Drawing.Point(16, 76);
            this._btnJustified.Name = "_btnJustified";
            this._btnJustified.Size = new System.Drawing.Size(69, 18);
            this._btnJustified.TabIndex = 0;
            this._btnJustified.Tag = "loJustified";
            this._btnJustified.Text = "&Justified";
            this._btnJustified.CheckedChanged += new System.EventHandler(this._btnLayout_CheckedChanged);
            // 
            // _btnLabels
            // 
            this._btnLabels.AutoSize = true;
            this._btnLabels.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnLabels.Location = new System.Drawing.Point(16, 103);
            this._btnLabels.Name = "_btnLabels";
            this._btnLabels.Size = new System.Drawing.Size(62, 18);
            this._btnLabels.TabIndex = 0;
            this._btnLabels.Tag = "loLabels";
            this._btnLabels.Text = "&Labels";
            this._btnLabels.CheckedChanged += new System.EventHandler(this._btnLayout_CheckedChanged);
            // 
            // _btnOutline
            // 
            this._btnOutline.AutoSize = true;
            this._btnOutline.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnOutline.Location = new System.Drawing.Point(131, 49);
            this._btnOutline.Name = "_btnOutline";
            this._btnOutline.Size = new System.Drawing.Size(64, 18);
            this._btnOutline.TabIndex = 0;
            this._btnOutline.Tag = "loOutline";
            this._btnOutline.Text = "&Outline";
            this._btnOutline.CheckedChanged += new System.EventHandler(this._btnLayout_CheckedChanged);
            // 
            // _btnStepped
            // 
            this._btnStepped.AutoSize = true;
            this._btnStepped.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnStepped.Location = new System.Drawing.Point(131, 22);
            this._btnStepped.Name = "_btnStepped";
            this._btnStepped.Size = new System.Drawing.Size(71, 18);
            this._btnStepped.TabIndex = 0;
            this._btnStepped.Tag = "loStepped";
            this._btnStepped.Text = "&Stepped";
            this._btnStepped.CheckedChanged += new System.EventHandler(this._btnLayout_CheckedChanged);
            // 
            // _btnAligned
            // 
            this._btnAligned.AutoSize = true;
            this._btnAligned.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnAligned.Location = new System.Drawing.Point(131, 76);
            this._btnAligned.Name = "_btnAligned";
            this._btnAligned.Size = new System.Drawing.Size(66, 18);
            this._btnAligned.TabIndex = 0;
            this._btnAligned.Tag = "loAligned";
            this._btnAligned.Text = "&Aligned";
            this._btnAligned.CheckedChanged += new System.EventHandler(this._btnLayout_CheckedChanged);
            // 
            // _picLayout
            // 
            this._picLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this._picLayout.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this._picLayout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picLayout.Location = new System.Drawing.Point(9, 9);
            this._picLayout.Name = "_picLayout";
            this._picLayout.Size = new System.Drawing.Size(253, 319);
            this._picLayout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._picLayout.TabIndex = 0;
            this._picLayout.TabStop = false;
            // 
            // _gbOrientation
            // 
            this._gbOrientation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gbOrientation.Controls.Add(this._btnPortrait);
            this._gbOrientation.Controls.Add(this._btnLandscape);
            this._gbOrientation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._gbOrientation.Location = new System.Drawing.Point(271, 159);
            this._gbOrientation.Name = "_gbOrientation";
            this._gbOrientation.Size = new System.Drawing.Size(291, 56);
            this._gbOrientation.TabIndex = 1;
            this._gbOrientation.TabStop = false;
            this._gbOrientation.Text = "Orientation";
            // 
            // _btnPortrait
            // 
            this._btnPortrait.AutoSize = true;
            this._btnPortrait.Checked = true;
            this._btnPortrait.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnPortrait.Location = new System.Drawing.Point(16, 22);
            this._btnPortrait.Name = "_btnPortrait";
            this._btnPortrait.Size = new System.Drawing.Size(64, 18);
            this._btnPortrait.TabIndex = 1;
            this._btnPortrait.TabStop = true;
            this._btnPortrait.Text = "&Portrait";
            // 
            // _btnLandscape
            // 
            this._btnLandscape.AutoSize = true;
            this._btnLandscape.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnLandscape.Location = new System.Drawing.Point(131, 22);
            this._btnLandscape.Name = "_btnLandscape";
            this._btnLandscape.Size = new System.Drawing.Size(84, 18);
            this._btnLandscape.TabIndex = 1;
            this._btnLandscape.Text = "Lan&dscape";
            // 
            // _pgFields
            // 
            this._pgFields.Controls.Add(this._btnAddFields);
            this._pgFields.Controls.Add(this._lstAvailable);
            this._pgFields.Controls.Add(this.label1);
            this._pgFields.Controls.Add(this._btnRemoveFields);
            this._pgFields.Controls.Add(this._lstGroups);
            this._pgFields.Controls.Add(this.label2);
            this._pgFields.Controls.Add(this.label3);
            this._pgFields.Controls.Add(this._lstDetail);
            this._pgFields.Location = new System.Drawing.Point(4, 25);
            this._pgFields.Name = "_pgFields";
            this._pgFields.Size = new System.Drawing.Size(572, 349);
            this._pgFields.TabIndex = 1;
            this._pgFields.Tag = "Step 2: Select the Fields that will be included in the new report.";
            this._pgFields.Text = "Fields";
            // 
            // _btnAddFields
            // 
            this._btnAddFields.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnAddFields.Location = new System.Drawing.Point(243, 140);
            this._btnAddFields.Name = "_btnAddFields";
            this._btnAddFields.Size = new System.Drawing.Size(47, 66);
            this._btnAddFields.TabIndex = 2;
            this._btnAddFields.Text = ">>";
            this._btnAddFields.Click += new System.EventHandler(this._btnAddFields_Click);
            // 
            // _lstAvailable
            // 
            this._lstAvailable.AllowDrop = true;
            this._lstAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this._lstAvailable.IntegralHeight = false;
            this._lstAvailable.Location = new System.Drawing.Point(13, 28);
            this._lstAvailable.Name = "_lstAvailable";
            this._lstAvailable.Size = new System.Drawing.Size(221, 292);
            this._lstAvailable.Sorted = true;
            this._lstAvailable.TabIndex = 1;
            this._lstAvailable.DragDrop += new System.Windows.Forms.DragEventHandler(this._lstDrag_DragDrop);
            this._lstAvailable.DragEnter += new System.Windows.Forms.DragEventHandler(this._lstDrag_DragEnter);
            this._lstAvailable.DoubleClick += new System.EventHandler(this._lstAvailable_DoubleClick);
            this._lstAvailable.MouseDown += new System.Windows.Forms.MouseEventHandler(this._lstDrag_MouseDown);
            this._lstAvailable.MouseMove += new System.Windows.Forms.MouseEventHandler(this._lstDrag_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available";
            // 
            // _btnRemoveFields
            // 
            this._btnRemoveFields.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnRemoveFields.Location = new System.Drawing.Point(243, 215);
            this._btnRemoveFields.Name = "_btnRemoveFields";
            this._btnRemoveFields.Size = new System.Drawing.Size(47, 66);
            this._btnRemoveFields.TabIndex = 2;
            this._btnRemoveFields.Text = "<<";
            this._btnRemoveFields.Click += new System.EventHandler(this._btnRemoveFields_Click);
            // 
            // _lstGroups
            // 
            this._lstGroups.AllowDrop = true;
            this._lstGroups.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lstGroups.IntegralHeight = false;
            this._lstGroups.Location = new System.Drawing.Point(300, 28);
            this._lstGroups.Name = "_lstGroups";
            this._lstGroups.Size = new System.Drawing.Size(242, 75);
            this._lstGroups.TabIndex = 1;
            this._lstGroups.DragDrop += new System.Windows.Forms.DragEventHandler(this._lstDrag_DragDrop);
            this._lstGroups.DragEnter += new System.Windows.Forms.DragEventHandler(this._lstDrag_DragEnter);
            this._lstGroups.MouseDown += new System.Windows.Forms.MouseEventHandler(this._lstDrag_MouseDown);
            this._lstGroups.MouseMove += new System.Windows.Forms.MouseEventHandler(this._lstDrag_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(300, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Groups";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(300, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Detail";
            // 
            // _lstDetail
            // 
            this._lstDetail.AllowDrop = true;
            this._lstDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lstDetail.IntegralHeight = false;
            this._lstDetail.Location = new System.Drawing.Point(300, 140);
            this._lstDetail.Name = "_lstDetail";
            this._lstDetail.Size = new System.Drawing.Size(242, 182);
            this._lstDetail.TabIndex = 1;
            this._lstDetail.DragDrop += new System.Windows.Forms.DragEventHandler(this._lstDrag_DragDrop);
            this._lstDetail.DragEnter += new System.Windows.Forms.DragEventHandler(this._lstDrag_DragEnter);
            this._lstDetail.MouseDown += new System.Windows.Forms.MouseEventHandler(this._lstDrag_MouseDown);
            this._lstDetail.MouseMove += new System.Windows.Forms.MouseEventHandler(this._lstDrag_MouseMove);
            // 
            // _pgLabels
            // 
            this._pgLabels.Controls.Add(this._lvLabels);
            this._pgLabels.Controls.Add(this._gbUnits);
            this._pgLabels.Controls.Add(this._picLabels);
            this._pgLabels.Controls.Add(this._gbPaperType);
            this._pgLabels.Location = new System.Drawing.Point(4, 25);
            this._pgLabels.Name = "_pgLabels";
            this._pgLabels.Size = new System.Drawing.Size(572, 349);
            this._pgLabels.TabIndex = 4;
            this._pgLabels.Tag = "Step 4: Select the type of label you want to use for the new report.";
            this._pgLabels.Text = "Labels";
            // 
            // _lvLabels
            // 
            this._lvLabels.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lvLabels.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._ch1,
            this._ch2,
            this._ch3});
            this._lvLabels.FullRowSelect = true;
            this._lvLabels.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this._lvLabels.HideSelection = false;
            this._lvLabels.LabelWrap = false;
            this._lvLabels.Location = new System.Drawing.Point(271, 9);
            this._lvLabels.MultiSelect = false;
            this._lvLabels.Name = "_lvLabels";
            this._lvLabels.Size = new System.Drawing.Size(271, 172);
            this._lvLabels.TabIndex = 5;
            this._lvLabels.UseCompatibleStateImageBehavior = false;
            this._lvLabels.View = System.Windows.Forms.View.Details;
            // 
            // _ch1
            // 
            this._ch1.Text = "Label Name";
            this._ch1.Width = 80;
            // 
            // _ch2
            // 
            this._ch2.Text = "Dimensions";
            this._ch2.Width = 100;
            // 
            // _ch3
            // 
            this._ch3.Text = "Across";
            this._ch3.Width = 30000;
            // 
            // _gbUnits
            // 
            this._gbUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._gbUnits.Controls.Add(this._btnMetric);
            this._gbUnits.Controls.Add(this._btnEnglish);
            this._gbUnits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._gbUnits.Location = new System.Drawing.Point(271, 190);
            this._gbUnits.Name = "_gbUnits";
            this._gbUnits.Size = new System.Drawing.Size(103, 84);
            this._gbUnits.TabIndex = 4;
            this._gbUnits.TabStop = false;
            this._gbUnits.Text = "Units";
            // 
            // _btnMetric
            // 
            this._btnMetric.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnMetric.Location = new System.Drawing.Point(9, 19);
            this._btnMetric.Name = "_btnMetric";
            this._btnMetric.Size = new System.Drawing.Size(84, 27);
            this._btnMetric.TabIndex = 0;
            this._btnMetric.Text = "Metric";
            this._btnMetric.CheckedChanged += new System.EventHandler(this._btnLabel_CheckedChanged);
            // 
            // _btnEnglish
            // 
            this._btnEnglish.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnEnglish.Location = new System.Drawing.Point(9, 46);
            this._btnEnglish.Name = "_btnEnglish";
            this._btnEnglish.Size = new System.Drawing.Size(84, 29);
            this._btnEnglish.TabIndex = 0;
            this._btnEnglish.Text = "English";
            this._btnEnglish.CheckedChanged += new System.EventHandler(this._btnLabel_CheckedChanged);
            // 
            // _picLabels
            // 
            this._picLabels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this._picLabels.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this._picLabels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picLabels.Location = new System.Drawing.Point(9, 9);
            this._picLabels.Name = "_picLabels";
            this._picLabels.Size = new System.Drawing.Size(253, 311);
            this._picLabels.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._picLabels.TabIndex = 2;
            this._picLabels.TabStop = false;
            // 
            // _gbPaperType
            // 
            this._gbPaperType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._gbPaperType.Controls.Add(this._btnSheetFeed);
            this._gbPaperType.Controls.Add(this._btnContinuous);
            this._gbPaperType.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._gbPaperType.Location = new System.Drawing.Point(384, 190);
            this._gbPaperType.Name = "_gbPaperType";
            this._gbPaperType.Size = new System.Drawing.Size(158, 84);
            this._gbPaperType.TabIndex = 4;
            this._gbPaperType.TabStop = false;
            this._gbPaperType.Text = "Paper Type";
            // 
            // _btnSheetFeed
            // 
            this._btnSheetFeed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSheetFeed.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnSheetFeed.Location = new System.Drawing.Point(9, 19);
            this._btnSheetFeed.Name = "_btnSheetFeed";
            this._btnSheetFeed.Size = new System.Drawing.Size(140, 27);
            this._btnSheetFeed.TabIndex = 0;
            this._btnSheetFeed.Text = "Sheet Feed";
            this._btnSheetFeed.CheckedChanged += new System.EventHandler(this._btnLabel_CheckedChanged);
            // 
            // _btnContinuous
            // 
            this._btnContinuous.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._btnContinuous.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnContinuous.Location = new System.Drawing.Point(9, 46);
            this._btnContinuous.Name = "_btnContinuous";
            this._btnContinuous.Size = new System.Drawing.Size(140, 29);
            this._btnContinuous.TabIndex = 0;
            this._btnContinuous.Text = "Continuous";
            this._btnContinuous.CheckedChanged += new System.EventHandler(this._btnLabel_CheckedChanged);
            // 
            // _pgStyle
            // 
            this._pgStyle.Controls.Add(this._lbStyles);
            this._pgStyle.Controls.Add(this._picStyle);
            this._pgStyle.Location = new System.Drawing.Point(4, 25);
            this._pgStyle.Name = "_pgStyle";
            this._pgStyle.Size = new System.Drawing.Size(572, 349);
            this._pgStyle.TabIndex = 3;
            this._pgStyle.Tag = "Step 4: Select the style for the new report.";
            this._pgStyle.Text = "Style";
            // 
            // _lbStyles
            // 
            this._lbStyles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lbStyles.IntegralHeight = false;
            this._lbStyles.Location = new System.Drawing.Point(271, 9);
            this._lbStyles.Name = "_lbStyles";
            this._lbStyles.Size = new System.Drawing.Size(271, 311);
            this._lbStyles.TabIndex = 2;
            this._lbStyles.SelectedIndexChanged += new System.EventHandler(this._lbStyles_SelectedIndexChanged);
            this._lbStyles.DoubleClick += new System.EventHandler(this._lbStyles_DoubleClick);
            // 
            // _picStyle
            // 
            this._picStyle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this._picStyle.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this._picStyle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picStyle.Location = new System.Drawing.Point(9, 9);
            this._picStyle.Name = "_picStyle";
            this._picStyle.Size = new System.Drawing.Size(253, 311);
            this._picStyle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._picStyle.TabIndex = 1;
            this._picStyle.TabStop = false;
            // 
            // _pgTitle
            // 
            this._pgTitle.Controls.Add(this._btnPreview);
            this._pgTitle.Controls.Add(this._txtReportName);
            this._pgTitle.Controls.Add(this.label4);
            this._pgTitle.Controls.Add(this._picFinish);
            this._pgTitle.Controls.Add(this.label5);
            this._pgTitle.Controls.Add(this.label6);
            this._pgTitle.Controls.Add(this._btnModify);
            this._pgTitle.Location = new System.Drawing.Point(4, 25);
            this._pgTitle.Name = "_pgTitle";
            this._pgTitle.Size = new System.Drawing.Size(572, 349);
            this._pgTitle.TabIndex = 5;
            this._pgTitle.Tag = "Step 5: Enter the Title for the new report.";
            this._pgTitle.Text = "Title";
            // 
            // _btnPreview
            // 
            this._btnPreview.Checked = true;
            this._btnPreview.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnPreview.Location = new System.Drawing.Point(271, 215);
            this._btnPreview.Name = "_btnPreview";
            this._btnPreview.Size = new System.Drawing.Size(215, 26);
            this._btnPreview.TabIndex = 5;
            this._btnPreview.TabStop = true;
            this._btnPreview.Text = "&Preview the report";
            // 
            // _txtReportName
            // 
            this._txtReportName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtReportName.Location = new System.Drawing.Point(280, 46);
            this._txtReportName.Name = "_txtReportName";
            this._txtReportName.Size = new System.Drawing.Size(262, 20);
            this._txtReportName.TabIndex = 4;
            this._txtReportName.Text = "New Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Location = new System.Drawing.Point(271, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "What title do you want for the new report?";
            // 
            // _picFinish
            // 
            this._picFinish.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this._picFinish.BackColor = System.Drawing.SystemColors.Control;
            this._picFinish.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._picFinish.Location = new System.Drawing.Point(9, 9);
            this._picFinish.Name = "_picFinish";
            this._picFinish.Size = new System.Drawing.Size(253, 311);
            this._picFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._picFinish.TabIndex = 2;
            this._picFinish.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Location = new System.Drawing.Point(271, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 57);
            this.label5.TabIndex = 3;
            this.label5.Text = "That\'s all the information the Wizard needs to create your report.";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Location = new System.Drawing.Point(271, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 51);
            this.label6.TabIndex = 3;
            this.label6.Text = "Do you want to preview the report or modify the report\'s design?";
            // 
            // _btnModify
            // 
            this._btnModify.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnModify.Location = new System.Drawing.Point(271, 243);
            this._btnModify.Name = "_btnModify";
            this._btnModify.Size = new System.Drawing.Size(215, 29);
            this._btnModify.TabIndex = 5;
            this._btnModify.Text = "&Modify the report\'s design";
            // 
            // _lblTitle
            // 
            this._lblTitle.BackColor = System.Drawing.SystemColors.Window;
            this._lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this._lblTitle.Location = new System.Drawing.Point(0, 0);
            this._lblTitle.Name = "_lblTitle";
            this._lblTitle.Size = new System.Drawing.Size(580, 56);
            this._lblTitle.TabIndex = 1;
            this._lblTitle.Text = "  Step 1: Start";
            this._lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _gb1
            // 
            this._gb1.Dock = System.Windows.Forms.DockStyle.Top;
            this._gb1.Location = new System.Drawing.Point(0, 56);
            this._gb1.Name = "_gb1";
            this._gb1.Size = new System.Drawing.Size(580, 6);
            this._gb1.TabIndex = 2;
            this._gb1.TabStop = false;
            // 
            // _gb2
            // 
            this._gb2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._gb2.Location = new System.Drawing.Point(0, 438);
            this._gb2.Name = "_gb2";
            this._gb2.Size = new System.Drawing.Size(580, 2);
            this._gb2.TabIndex = 3;
            this._gb2.TabStop = false;
            // 
            // _btnPanel
            // 
            this._btnPanel.Controls.Add(this._btnBack);
            this._btnPanel.Controls.Add(this._btnNext);
            this._btnPanel.Controls.Add(this._btnCancel);
            this._btnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._btnPanel.Location = new System.Drawing.Point(0, 440);
            this._btnPanel.Name = "_btnPanel";
            this._btnPanel.Size = new System.Drawing.Size(580, 40);
            this._btnPanel.TabIndex = 4;
            // 
            // _btnBack
            // 
            this._btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnBack.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnBack.Location = new System.Drawing.Point(315, 9);
            this._btnBack.Name = "_btnBack";
            this._btnBack.Size = new System.Drawing.Size(75, 23);
            this._btnBack.TabIndex = 0;
            this._btnBack.Text = "< &Back";
            this._btnBack.Click += new System.EventHandler(this._btnBack_Click);
            // 
            // _btnNext
            // 
            this._btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnNext.Location = new System.Drawing.Point(396, 9);
            this._btnNext.Name = "_btnNext";
            this._btnNext.Size = new System.Drawing.Size(75, 23);
            this._btnNext.TabIndex = 0;
            this._btnNext.Text = "&Next >";
            this._btnNext.Click += new System.EventHandler(this._btnNext_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnCancel.Location = new System.Drawing.Point(493, 9);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 0;
            this._btnCancel.Text = "&Cancel";
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // _tabPanel
            // 
            this._tabPanel.Controls.Add(this._tab);
            this._tabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabPanel.Location = new System.Drawing.Point(0, 62);
            this._tabPanel.Name = "_tabPanel";
            this._tabPanel.Size = new System.Drawing.Size(580, 378);
            this._tabPanel.TabIndex = 5;
            this._tabPanel.SizeChanged += new System.EventHandler(this._tabPanel_SizeChanged);
            // 
            // ReportWizard
            // 
            this.AcceptButton = this._btnNext;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(580, 480);
            this.Controls.Add(this._gb2);
            this.Controls.Add(this._tabPanel);
            this.Controls.Add(this._gb1);
            this.Controls.Add(this._lblTitle);
            this.Controls.Add(this._btnPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(540, 450);
            this.Name = "ReportWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FlexReport Wizard";
            this.Load += new System.EventHandler(this.ReportWizard_Load);
            this._tab.ResumeLayout(false);
            this._pgData.ResumeLayout(false);
            this._pgLayout.ResumeLayout(false);
            this._pgLayout.PerformLayout();
            this._gbLayout.ResumeLayout(false);
            this._gbLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picLayout)).EndInit();
            this._gbOrientation.ResumeLayout(false);
            this._gbOrientation.PerformLayout();
            this._pgFields.ResumeLayout(false);
            this._pgFields.PerformLayout();
            this._pgLabels.ResumeLayout(false);
            this._gbUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picLabels)).EndInit();
            this._gbPaperType.ResumeLayout(false);
            this._pgStyle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._picStyle)).EndInit();
            this._pgTitle.ResumeLayout(false);
            this._pgTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._picFinish)).EndInit();
            this._btnPanel.ResumeLayout(false);
            this._tabPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl _tab;
        private System.Windows.Forms.TabPage _pgData;
        private System.Windows.Forms.TabPage _pgFields;
        private System.Windows.Forms.TabPage _pgLayout;
        private System.Windows.Forms.TabPage _pgStyle;
        private System.Windows.Forms.TabPage _pgLabels;
        private System.Windows.Forms.TabPage _pgTitle;
        private System.Windows.Forms.Label _lblTitle;
        private System.Windows.Forms.GroupBox _gb1;
        private System.Windows.Forms.GroupBox _gb2;
        private System.Windows.Forms.Panel _btnPanel;
        private System.Windows.Forms.Button _btnBack;
        private System.Windows.Forms.Button _btnNext;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Panel _tabPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox _lstAvailable;
        private System.Windows.Forms.Button _btnAddFields;
        private System.Windows.Forms.Button _btnRemoveFields;
        private System.Windows.Forms.ListBox _lstGroups;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox _lstDetail;
        private System.Windows.Forms.PictureBox _picLayout;
        private System.Windows.Forms.RadioButton _btnColumnar;
        private System.Windows.Forms.RadioButton _btnTabular;
        private System.Windows.Forms.RadioButton _btnJustified;
        private System.Windows.Forms.RadioButton _btnLabels;
        private System.Windows.Forms.RadioButton _btnOutline;
        private System.Windows.Forms.RadioButton _btnStepped;
        private System.Windows.Forms.RadioButton _btnAligned;
        private System.Windows.Forms.RadioButton _btnPortrait;
        private System.Windows.Forms.RadioButton _btnLandscape;
        private System.Windows.Forms.GroupBox _gbLayout;
        private System.Windows.Forms.GroupBox _gbOrientation;
        private System.Windows.Forms.PictureBox _picStyle;
        private System.Windows.Forms.ListBox _lbStyles;
        private System.Windows.Forms.PictureBox _picFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtReportName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton _btnPreview;
        private System.Windows.Forms.RadioButton _btnModify;
        private System.Windows.Forms.PictureBox _picLabels;
        private System.Windows.Forms.GroupBox _gbUnits;
        private System.Windows.Forms.GroupBox _gbPaperType;
        private System.Windows.Forms.RadioButton _btnMetric;
        private System.Windows.Forms.RadioButton _btnEnglish;
        private System.Windows.Forms.RadioButton _btnSheetFeed;
        private System.Windows.Forms.RadioButton _btnContinuous;
        private System.Windows.Forms.ListView _lvLabels;
        private System.Windows.Forms.ColumnHeader _ch1;
        private System.Windows.Forms.ColumnHeader _ch2;
        private System.Windows.Forms.ColumnHeader _ch3;
        private System.Windows.Forms.CheckBox _checkAdjust;
    }
}
