//----------------------------------------------------------------------------
// ScriptEditorControl.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Forms
{
    partial class ScriptEditorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptEditorControl));
            this.inpPanel = new C1.Win.InputPanel.C1InputPanel();
            this.ilDirty = new C1.Win.InputPanel.InputLabel();
            this.lblField = new C1.Win.InputPanel.InputLabel();
            this.imScriptExprs = new C1.Win.InputPanel.InputComboBox();
            this.chkIsTextMode = new C1.Win.InputPanel.InputCheckBox();
            this.lblScript = new C1.Win.InputPanel.InputLabel();
            this.imScriptSubs = new C1.Win.InputPanel.InputComboBox();
            this.inputButton1 = new C1.Win.InputPanel.InputButton();
            this.inputButton2 = new C1.Win.InputPanel.InputButton();
            this.inputButton3 = new C1.Win.InputPanel.InputButton();
            this.pbGlyph = new System.Windows.Forms.PictureBox();
            this._txtScript = new FlexReportDesignerApp.Util.RegexTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.inpPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlyph)).BeginInit();
            this.SuspendLayout();
            // 
            // inpPanel
            // 
            this.inpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.inpPanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.inpPanel.Items.Add(this.ilDirty);
            this.inpPanel.Items.Add(this.lblField);
            this.inpPanel.Items.Add(this.imScriptExprs);
            this.inpPanel.Items.Add(this.chkIsTextMode);
            this.inpPanel.Items.Add(this.lblScript);
            this.inpPanel.Items.Add(this.imScriptSubs);
            this.inpPanel.Location = new System.Drawing.Point(0, 0);
            this.inpPanel.Name = "inpPanel";
            this.inpPanel.Size = new System.Drawing.Size(764, 28);
            this.inpPanel.TabIndex = 0;
            this.inpPanel.TabStop = false;
            this.inpPanel.ToolTipSettings.MaximumWidth = 300;
            // 
            // ilDirty
            // 
            this.ilDirty.AutoEllipsis = false;
            this.ilDirty.HorizontalAlign = C1.Win.InputPanel.InputContentAlignment.Center;
            this.ilDirty.Name = "ilDirty";
            this.ilDirty.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.ilDirty.Text = "*";
            this.ilDirty.VerticalAlign = C1.Win.InputPanel.InputContentAlignment.Center;
            this.ilDirty.Width = 16;
            // 
            // lblField
            // 
            this.lblField.Name = "lblField";
            this.lblField.Text = "Expression:";
            this.lblField.ToolTipText = resources.GetString("lblField.ToolTipText");
            this.lblField.VerticalAlign = C1.Win.InputPanel.InputContentAlignment.Center;
            // 
            // imScriptExprs
            // 
            this.imScriptExprs.Break = C1.Win.InputPanel.BreakType.None;
            this.imScriptExprs.DropDownStyle = C1.Win.InputPanel.InputComboBoxStyle.DropDownList;
            this.imScriptExprs.MaxDropDownItems = 16;
            this.imScriptExprs.Name = "imScriptExprs";
            this.imScriptExprs.TabStop = false;
            this.imScriptExprs.Text = "Menu";
            this.imScriptExprs.Width = 200;
            // 
            // chkIsTextMode
            // 
            this.chkIsTextMode.Break = C1.Win.InputPanel.BreakType.None;
            this.chkIsTextMode.Name = "chkIsTextMode";
            this.chkIsTextMode.TabStop = false;
            this.chkIsTextMode.Text = "Text Mode";
            this.chkIsTextMode.ToolTipText = resources.GetString("chkIsTextMode.ToolTipText");
            this.chkIsTextMode.VerticalAlign = C1.Win.InputPanel.InputContentAlignment.Center;
            // 
            // lblScript
            // 
            this.lblScript.Name = "lblScript";
            this.lblScript.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblScript.Text = "Script:";
            this.lblScript.ToolTipText = resources.GetString("lblScript.ToolTipText");
            this.lblScript.VerticalAlign = C1.Win.InputPanel.InputContentAlignment.Center;
            // 
            // imScriptSubs
            // 
            this.imScriptSubs.Break = C1.Win.InputPanel.BreakType.None;
            this.imScriptSubs.DropDownStyle = C1.Win.InputPanel.InputComboBoxStyle.DropDownList;
            this.imScriptSubs.Items.Add(this.inputButton1);
            this.imScriptSubs.Items.Add(this.inputButton2);
            this.imScriptSubs.Items.Add(this.inputButton3);
            this.imScriptSubs.MaxDropDownItems = 16;
            this.imScriptSubs.Name = "imScriptSubs";
            this.imScriptSubs.TabStop = false;
            this.imScriptSubs.Text = "Menu";
            this.imScriptSubs.Width = 160;
            // 
            // inputButton1
            // 
            this.inputButton1.Image = ((System.Drawing.Image)(resources.GetObject("inputButton1.Image")));
            this.inputButton1.Name = "inputButton1";
            this.inputButton1.Text = "Report.GlobalScripts";
            // 
            // inputButton2
            // 
            this.inputButton2.Image = ((System.Drawing.Image)(resources.GetObject("inputButton2.Image")));
            this.inputButton2.Name = "inputButton2";
            this.inputButton2.Text = "Report.OnOpen";
            // 
            // inputButton3
            // 
            this.inputButton3.Image = ((System.Drawing.Image)(resources.GetObject("inputButton3.Image")));
            this.inputButton3.Name = "inputButton3";
            this.inputButton3.Text = "Report.OnClose";
            // 
            // pbGlyph
            // 
            this.pbGlyph.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGlyph.BackColor = System.Drawing.Color.Transparent;
            this.pbGlyph.Image = global::FlexReportDesignerApp.Properties.Resources.SplitWindowHorz_16x16;
            this.pbGlyph.Location = new System.Drawing.Point(651, 54);
            this.pbGlyph.Name = "pbGlyph";
            this.pbGlyph.Size = new System.Drawing.Size(48, 52);
            this.pbGlyph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbGlyph.TabIndex = 2;
            this.pbGlyph.TabStop = false;
            // 
            // _txtScript
            // 
            this._txtScript.AcceptsTab = true;
            this._txtScript.AutoWordSelection = true;
            this._txtScript.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._txtScript.DetectUrls = false;
            this._txtScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtScript.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txtScript.Location = new System.Drawing.Point(0, 28);
            this._txtScript.MaxUndoRedoSteps = 50;
            this._txtScript.Name = "_txtScript";
            this._txtScript.ShowSelectionMargin = true;
            this._txtScript.Size = new System.Drawing.Size(764, 393);
            this._txtScript.TabIndex = 1;
            this._txtScript.Text = "";
            this._txtScript.WordWrap = false;
            // 
            // ScriptEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbGlyph);
            this.Controls.Add(this._txtScript);
            this.Controls.Add(this.inpPanel);
            this.Name = "ScriptEditorControl";
            this.Size = new System.Drawing.Size(764, 421);
            ((System.ComponentModel.ISupportInitialize)(this.inpPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGlyph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.InputPanel.C1InputPanel inpPanel;
        private C1.Win.InputPanel.InputLabel lblScript;
        private Util.RegexTextBox _txtScript;
        private C1.Win.InputPanel.InputLabel lblField;
        private C1.Win.InputPanel.InputComboBox imScriptSubs;
        private C1.Win.InputPanel.InputButton inputButton1;
        private C1.Win.InputPanel.InputButton inputButton2;
        private C1.Win.InputPanel.InputButton inputButton3;
        private C1.Win.InputPanel.InputComboBox imScriptExprs;
        private C1.Win.InputPanel.InputLabel ilDirty;
        private System.Windows.Forms.PictureBox pbGlyph;
        private C1.Win.InputPanel.InputCheckBox chkIsTextMode;
    }
}
