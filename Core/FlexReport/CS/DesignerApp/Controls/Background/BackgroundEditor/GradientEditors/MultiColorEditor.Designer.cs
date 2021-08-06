//----------------------------------------------------------------------------
// MultiColorEditor.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors
{
    partial class MultiColorEditor
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
            this.tcbeColors = new FlexReportDesignerApp.Controls.Background.BackgroundEditor.ColorBlendEditor();
            this.SuspendLayout();
            // 
            // tcbeColors
            // 
            this.tcbeColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcbeColors.BackColor = System.Drawing.Color.AliceBlue;
            this.tcbeColors.Location = new System.Drawing.Point(3, 3);
            this.tcbeColors.Name = "tcbeColors";
            this.tcbeColors.Size = new System.Drawing.Size(244, 92);
            this.tcbeColors.TabIndex = 0;
            this.tcbeColors.Changed += new System.EventHandler(this.tcbeColors_Changed);
            // 
            // MultiColorEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.tcbeColors);
            this.Name = "MultiColorEditor";
            this.Size = new System.Drawing.Size(250, 98);
            this.ResumeLayout(false);

        }

        #endregion

        private ColorBlendEditor tcbeColors;
    }
}
