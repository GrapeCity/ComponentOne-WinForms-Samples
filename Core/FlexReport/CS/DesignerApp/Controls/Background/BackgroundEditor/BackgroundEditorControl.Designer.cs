//----------------------------------------------------------------------------
// BackgroundEditorControl.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using C1.Win.Command;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor
{
    partial class BackgroundEditorControl
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
            this.dtMain = new C1.Win.Command.C1DockingTab();
            this.dtpWebColors = new C1.Win.Command.C1DockingTabPage();
            this.dtpSystemColors = new C1.Win.Command.C1DockingTabPage();
            this.dtpCustom = new C1.Win.Command.C1DockingTabPage();
            this.dtpGradient = new C1.Win.Command.C1DockingTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dtMain)).BeginInit();
            this.dtMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtMain
            // 
            this.dtMain.Controls.Add(this.dtpWebColors);
            this.dtMain.Controls.Add(this.dtpSystemColors);
            this.dtMain.Controls.Add(this.dtpCustom);
            this.dtMain.Controls.Add(this.dtpGradient);
            this.dtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtMain.Location = new System.Drawing.Point(0, 0);
            this.dtMain.Name = "dtMain";
            this.dtMain.Size = new System.Drawing.Size(306, 378);
            this.dtMain.TabIndex = 2;
            this.dtMain.TabsCanFocus = false;
            // 
            // dtpWebColors
            // 
            this.dtpWebColors.Location = new System.Drawing.Point(1, 23);
            this.dtpWebColors.Name = "dtpWebColors";
            this.dtpWebColors.Size = new System.Drawing.Size(304, 354);
            this.dtpWebColors.TabIndex = 0;
            this.dtpWebColors.Text = "Web";
            // 
            // dtpSystemColors
            // 
            this.dtpSystemColors.Location = new System.Drawing.Point(1, 23);
            this.dtpSystemColors.Name = "dtpSystemColors";
            this.dtpSystemColors.Size = new System.Drawing.Size(304, 354);
            this.dtpSystemColors.TabIndex = 1;
            this.dtpSystemColors.Text = "System";
            // 
            // dtpCustom
            // 
            this.dtpCustom.Location = new System.Drawing.Point(1, 23);
            this.dtpCustom.Name = "dtpCustom";
            this.dtpCustom.Size = new System.Drawing.Size(304, 354);
            this.dtpCustom.TabIndex = 2;
            this.dtpCustom.Text = "Custom";
            // 
            // dtpGradient
            // 
            this.dtpGradient.Location = new System.Drawing.Point(1, 23);
            this.dtpGradient.Name = "dtpGradient";
            this.dtpGradient.Size = new System.Drawing.Size(304, 354);
            this.dtpGradient.TabIndex = 3;
            this.dtpGradient.Text = "Gradient";
            // 
            // BackgroundEditorControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.dtMain);
            this.Name = "BackgroundEditorControl";
            this.Size = new System.Drawing.Size(306, 378);
            ((System.ComponentModel.ISupportInitialize)(this.dtMain)).EndInit();
            this.dtMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Command.C1DockingTab dtMain;
        private C1.Win.Command.C1DockingTabPage dtpWebColors;
        private C1.Win.Command.C1DockingTabPage dtpSystemColors;
        private C1.Win.Command.C1DockingTabPage dtpCustom;
        private C1.Win.Command.C1DockingTabPage dtpGradient;
    }
}
