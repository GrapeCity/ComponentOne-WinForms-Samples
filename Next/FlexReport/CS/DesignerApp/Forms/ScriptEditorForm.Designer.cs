//----------------------------------------------------------------------------
// ScriptEditorForm.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace ReportDesignerApp
{
    partial class ScriptEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptEditorForm));
            this.chMain = new C1.Win.C1Command.C1CommandHolder();
            this.cCut = new C1.Win.C1Command.C1Command();
            this.cCopy = new C1.Win.C1Command.C1Command();
            this.cPaste = new C1.Win.C1Command.C1Command();
            this.cDelete = new C1.Win.C1Command.C1Command();
            this.cUndo = new C1.Win.C1Command.C1Command();
            this.cRedo = new C1.Win.C1Command.C1Command();
            this.cSelectAll = new C1.Win.C1Command.C1Command();
            this.cReportFields = new C1.Win.C1Command.C1CommandMenu();
            this.cDatabaseFields = new C1.Win.C1Command.C1CommandMenu();
            this.contextMenu = new C1.Win.C1Command.C1ContextMenu();
            this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink3 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink4 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink5 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink6 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink7 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink8 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink9 = new C1.Win.C1Command.C1CommandLink();
            this.c1CommandLink10 = new C1.Win.C1Command.C1CommandLink();
            this.cScriptFunctions = new C1.Win.C1Command.C1CommandMenu();
            this.c1CommandLink11 = new C1.Win.C1Command.C1CommandLink();
            this.cAggregates = new C1.Win.C1Command.C1CommandMenu();
            this.c1CommandLink12 = new C1.Win.C1Command.C1CommandLink();
            this.cString = new C1.Win.C1Command.C1CommandMenu();
            this.c1CommandLink13 = new C1.Win.C1Command.C1CommandLink();
            this.cDateTime = new C1.Win.C1Command.C1CommandMenu();
            this.c1CommandLink14 = new C1.Win.C1Command.C1CommandLink();
            this.cLogical = new C1.Win.C1Command.C1CommandMenu();
            this.c1CommandLink15 = new C1.Win.C1Command.C1CommandLink();
            this.cReportVariables = new C1.Win.C1Command.C1CommandMenu();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.txtScript = new ReportDesignerApp.Util.RegexTextBox();
            this._statusBar = new C1.Win.C1Ribbon.C1StatusBar();
            this.rblText = new C1.Win.C1Ribbon.RibbonLabel();
            this.rbtnError = new C1.Win.C1Ribbon.RibbonButton();
            this.ribbonSeparator1 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.rlblRow = new C1.Win.C1Ribbon.RibbonLabel();
            this.ribbonSeparator2 = new C1.Win.C1Ribbon.RibbonSeparator();
            this.rlblCol = new C1.Win.C1Ribbon.RibbonLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnCancel = new System.Windows.Forms.Button();
            this._btnFields = new System.Windows.Forms.Button();
            this._btnOK = new System.Windows.Forms.Button();
            this.c1CommandLink16 = new C1.Win.C1Command.C1CommandLink();
            this.cMath = new C1.Win.C1Command.C1CommandMenu();
            this.c1CommandLink17 = new C1.Win.C1Command.C1CommandLink();
            this.cDataConversion = new C1.Win.C1Command.C1CommandMenu();
            this.c1CommandLink18 = new C1.Win.C1Command.C1CommandLink();
            this.cMiscellaneous = new C1.Win.C1Command.C1CommandMenu();
            ((System.ComponentModel.ISupportInitialize)(this.chMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._statusBar)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.chMain.Commands.Add(this.cReportFields);
            this.chMain.Commands.Add(this.cDatabaseFields);
            this.chMain.Commands.Add(this.contextMenu);
            this.chMain.Commands.Add(this.cAggregates);
            this.chMain.Commands.Add(this.cString);
            this.chMain.Commands.Add(this.cDateTime);
            this.chMain.Commands.Add(this.cLogical);
            this.chMain.Commands.Add(this.cReportVariables);
            this.chMain.Commands.Add(this.cScriptFunctions);
            this.chMain.Commands.Add(this.cMath);
            this.chMain.Commands.Add(this.cDataConversion);
            this.chMain.Commands.Add(this.cMiscellaneous);
            this.chMain.ImageList = this.imageList;
            this.chMain.Owner = this;
            this.chMain.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue;
            this.chMain.CommandClick += new C1.Win.C1Command.CommandClickEventHandler(this.chMain_CommandClick);
            // 
            // cCut
            // 
            this.cCut.ImageIndex = 0;
            this.cCut.Name = "cCut";
            this.cCut.Text = "Cut";
            // 
            // cCopy
            // 
            this.cCopy.ImageIndex = 1;
            this.cCopy.Name = "cCopy";
            this.cCopy.Text = "Copy";
            // 
            // cPaste
            // 
            this.cPaste.ImageIndex = 2;
            this.cPaste.Name = "cPaste";
            this.cPaste.Text = "Paste";
            // 
            // cDelete
            // 
            this.cDelete.ImageIndex = 5;
            this.cDelete.Name = "cDelete";
            this.cDelete.Text = "Delete";
            // 
            // cUndo
            // 
            this.cUndo.ImageIndex = 3;
            this.cUndo.Name = "cUndo";
            this.cUndo.Text = "Undo";
            // 
            // cRedo
            // 
            this.cRedo.ImageIndex = 4;
            this.cRedo.Name = "cRedo";
            this.cRedo.Text = "Redo";
            // 
            // cSelectAll
            // 
            this.cSelectAll.Name = "cSelectAll";
            this.cSelectAll.Text = "Select All";
            // 
            // cReportFields
            // 
            this.cReportFields.ImageIndex = 6;
            this.cReportFields.Name = "cReportFields";
            this.cReportFields.Text = "Report Fields";
            this.cReportFields.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // cDatabaseFields
            // 
            this.cDatabaseFields.ImageIndex = 8;
            this.cDatabaseFields.Name = "cDatabaseFields";
            this.cDatabaseFields.Text = "Database Fields";
            this.cDatabaseFields.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // contextMenu
            // 
            this.contextMenu.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink1,
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4,
            this.c1CommandLink5,
            this.c1CommandLink6,
            this.c1CommandLink7,
            this.c1CommandLink8,
            this.c1CommandLink9,
            this.c1CommandLink10});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue;
            this.contextMenu.Popup += new System.EventHandler(this.contextMenu_Popup);
            this.contextMenu.Closed += new System.EventHandler(this.contextMenu_Closed);
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
            // c1CommandLink8
            // 
            this.c1CommandLink8.Command = this.cReportFields;
            this.c1CommandLink8.Delimiter = true;
            this.c1CommandLink8.SortOrder = 7;
            // 
            // c1CommandLink9
            // 
            this.c1CommandLink9.Command = this.cDatabaseFields;
            this.c1CommandLink9.SortOrder = 8;
            // 
            // c1CommandLink10
            // 
            this.c1CommandLink10.Command = this.cScriptFunctions;
            this.c1CommandLink10.Delimiter = true;
            this.c1CommandLink10.SortOrder = 9;
            // 
            // cScriptFunctions
            // 
            this.cScriptFunctions.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink11,
            this.c1CommandLink16,
            this.c1CommandLink12,
            this.c1CommandLink13,
            this.c1CommandLink14,
            this.c1CommandLink17,
            this.c1CommandLink18,
            this.c1CommandLink15});
            this.cScriptFunctions.ImageIndex = 7;
            this.cScriptFunctions.Name = "cScriptFunctions";
            this.cScriptFunctions.Text = "Script Functions";
            this.cScriptFunctions.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue;
            // 
            // c1CommandLink11
            // 
            this.c1CommandLink11.Command = this.cAggregates;
            // 
            // cAggregates
            // 
            this.cAggregates.Name = "cAggregates";
            this.cAggregates.Text = "Aggregates";
            this.cAggregates.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1CommandLink12
            // 
            this.c1CommandLink12.Command = this.cString;
            this.c1CommandLink12.SortOrder = 2;
            // 
            // cString
            // 
            this.cString.Name = "cString";
            this.cString.Text = "String";
            this.cString.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1CommandLink13
            // 
            this.c1CommandLink13.Command = this.cDateTime;
            this.c1CommandLink13.SortOrder = 3;
            // 
            // cDateTime
            // 
            this.cDateTime.Name = "cDateTime";
            this.cDateTime.Text = "Date/Time";
            this.cDateTime.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1CommandLink14
            // 
            this.c1CommandLink14.Command = this.cLogical;
            this.c1CommandLink14.SortOrder = 4;
            // 
            // cLogical
            // 
            this.cLogical.Name = "cLogical";
            this.cLogical.Text = "Logical";
            this.cLogical.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // c1CommandLink15
            // 
            this.c1CommandLink15.Command = this.cReportVariables;
            this.c1CommandLink15.SortOrder = 7;
            // 
            // cReportVariables
            // 
            this.cReportVariables.Name = "cReportVariables";
            this.cReportVariables.Text = "Report Variables";
            this.cReportVariables.VisualStyleBase = C1.Win.C1Command.VisualStyle.OfficeXP;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Cut_SmallImage.png");
            this.imageList.Images.SetKeyName(1, "Copy_SmallImage.png");
            this.imageList.Images.SetKeyName(2, "Paste_SmallImage.png");
            this.imageList.Images.SetKeyName(3, "Undo_SmallImage.png");
            this.imageList.Images.SetKeyName(4, "Redo_SmallImage.png");
            this.imageList.Images.SetKeyName(5, "Delete_SmallImage.PNG");
            this.imageList.Images.SetKeyName(6, "FieldLabel_SmallImage.PNG");
            this.imageList.Images.SetKeyName(7, "FieldCalculated_SmallImage.PNG");
            this.imageList.Images.SetKeyName(8, "FieldDataField_SmallImage.PNG");
            // 
            // txtScript
            // 
            this.txtScript.AcceptsTab = true;
            this.txtScript.AutoWordSelection = true;
            this.chMain.SetC1ContextMenu(this.txtScript, this.contextMenu);
            this.txtScript.DetectUrls = false;
            this.txtScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtScript.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScript.Location = new System.Drawing.Point(0, 0);
            this.txtScript.MaxUndoRedoSteps = 50;
            this.txtScript.Name = "txtScript";
            this.txtScript.ShowSelectionMargin = true;
            this.txtScript.Size = new System.Drawing.Size(573, 244);
            this.txtScript.TabIndex = 25;
            this.txtScript.Text = "";
            this.txtScript.WordWrap = false;
            this.txtScript.SelectionChanged += new System.EventHandler(this.txtScript_SelectionChanged);
            this.txtScript.TextChanged += new System.EventHandler(this.txtScript_TextChanged);
            // 
            // _statusBar
            // 
            this._statusBar.LeftPaneItems.Add(this.rblText);
            this._statusBar.Name = "_statusBar";
            this._statusBar.RightPaneItems.Add(this.rbtnError);
            this._statusBar.RightPaneItems.Add(this.ribbonSeparator1);
            this._statusBar.RightPaneItems.Add(this.rlblRow);
            this._statusBar.RightPaneItems.Add(this.ribbonSeparator2);
            this._statusBar.RightPaneItems.Add(this.rlblCol);
            // 
            // rblText
            // 
            this.rblText.Name = "rblText";
            // 
            // rbtnError
            // 
            this.rbtnError.Name = "rbtnError";
            this.rbtnError.SmallImage = ((System.Drawing.Image)(resources.GetObject("rbtnError.SmallImage")));
            this.rbtnError.Visible = false;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this._btnCancel);
            this.panel1.Controls.Add(this._btnFields);
            this.panel1.Controls.Add(this._btnOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 40);
            this.panel1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 2);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._btnCancel.Location = new System.Drawing.Point(486, 8);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "&Cancel";
            // 
            // _btnFields
            // 
            this._btnFields.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnFields.Location = new System.Drawing.Point(12, 8);
            this._btnFields.Name = "_btnFields";
            this._btnFields.Size = new System.Drawing.Size(75, 23);
            this._btnFields.TabIndex = 1;
            this._btnFields.TabStop = false;
            this._btnFields.Text = "Fields >>";
            this._btnFields.Click += new System.EventHandler(this._btnFields_Click);
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this._btnOK.Location = new System.Drawing.Point(405, 8);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(75, 23);
            this._btnOK.TabIndex = 2;
            this._btnOK.Text = "&OK";
            // 
            // c1CommandLink16
            // 
            this.c1CommandLink16.Command = this.cMath;
            this.c1CommandLink16.SortOrder = 1;
            // 
            // cMath
            // 
            this.cMath.Name = "cMath";
            this.cMath.Text = "Math";
            // 
            // c1CommandLink17
            // 
            this.c1CommandLink17.Command = this.cDataConversion;
            this.c1CommandLink17.SortOrder = 5;
            // 
            // cDataConversion
            // 
            this.cDataConversion.Name = "cDataConversion";
            this.cDataConversion.Text = "Data conversion";
            // 
            // c1CommandLink18
            // 
            this.c1CommandLink18.Command = this.cMiscellaneous;
            this.c1CommandLink18.SortOrder = 6;
            // 
            // cMiscellaneous
            // 
            this.cMiscellaneous.Name = "cMiscellaneous";
            this.cMiscellaneous.Text = "Miscellaneous";
            // 
            // ScriptEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 306);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._statusBar);
            this.Name = "ScriptEditorForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VBScript Editor";
            this.Load += new System.EventHandler(this.ScriptEditorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._statusBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Command.C1CommandHolder chMain;
        private C1.Win.C1Command.C1Command cCut;
        private C1.Win.C1Command.C1Command cCopy;
        private C1.Win.C1Command.C1Command cPaste;
        private C1.Win.C1Command.C1Command cUndo;
        private C1.Win.C1Command.C1Command cRedo;
        private C1.Win.C1Command.C1CommandMenu cReportFields;
        private C1.Win.C1Command.C1CommandMenu cDatabaseFields;
        private System.Windows.Forms.ImageList imageList;
        private C1.Win.C1Ribbon.C1StatusBar _statusBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Button _btnFields;
        private System.Windows.Forms.Button _btnOK;
        private ReportDesignerApp.Util.RegexTextBox txtScript;
        private C1.Win.C1Command.C1ContextMenu contextMenu;
        private C1.Win.C1Command.C1CommandLink c1CommandLink1;
        private C1.Win.C1Command.C1CommandMenu cAggregates;
        private C1.Win.C1Command.C1CommandMenu cString;
        private C1.Win.C1Command.C1CommandMenu cDateTime;
        private C1.Win.C1Command.C1CommandMenu cLogical;
        private C1.Win.C1Command.C1CommandMenu cReportVariables;
        private C1.Win.C1Command.C1CommandLink c1CommandLink2;
        private C1.Win.C1Command.C1CommandLink c1CommandLink3;
        private C1.Win.C1Command.C1CommandLink c1CommandLink4;
        private C1.Win.C1Command.C1CommandLink c1CommandLink5;
        private C1.Win.C1Command.C1Command cDelete;
        private C1.Win.C1Command.C1CommandLink c1CommandLink6;
        private C1.Win.C1Command.C1CommandLink c1CommandLink7;
        private C1.Win.C1Command.C1Command cSelectAll;
        private C1.Win.C1Command.C1CommandLink c1CommandLink8;
        private C1.Win.C1Command.C1CommandLink c1CommandLink9;
        private C1.Win.C1Command.C1CommandLink c1CommandLink10;
        private C1.Win.C1Command.C1CommandMenu cScriptFunctions;
        private C1.Win.C1Command.C1CommandLink c1CommandLink11;
        private C1.Win.C1Command.C1CommandLink c1CommandLink12;
        private C1.Win.C1Command.C1CommandLink c1CommandLink13;
        private C1.Win.C1Command.C1CommandLink c1CommandLink14;
        private C1.Win.C1Command.C1CommandLink c1CommandLink15;
        private C1.Win.C1Ribbon.RibbonLabel rlblRow;
        private C1.Win.C1Ribbon.RibbonLabel rlblCol;
        private C1.Win.C1Ribbon.RibbonButton rbtnError;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator1;
        private C1.Win.C1Ribbon.RibbonSeparator ribbonSeparator2;
        private C1.Win.C1Ribbon.RibbonLabel rblText;
        private C1.Win.C1Command.C1CommandLink c1CommandLink16;
        private C1.Win.C1Command.C1CommandMenu cMath;
        private C1.Win.C1Command.C1CommandLink c1CommandLink17;
        private C1.Win.C1Command.C1CommandMenu cDataConversion;
        private C1.Win.C1Command.C1CommandLink c1CommandLink18;
        private C1.Win.C1Command.C1CommandMenu cMiscellaneous;
    }
}
