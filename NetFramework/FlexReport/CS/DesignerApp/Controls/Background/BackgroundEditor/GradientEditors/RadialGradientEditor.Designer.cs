//----------------------------------------------------------------------------
// RadialGradientEditor.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using FlexReportDesignerApp.Controls.Background.BackgroundEditor;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors
{
    partial class RadialGradientEditor
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
            this.gceCenter = new FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientCenterEditor();
            this.SuspendLayout();
            // 
            // gceCenter
            // 
            this.gceCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gceCenter.BackColor = System.Drawing.Color.AliceBlue;
            this.gceCenter.Location = new System.Drawing.Point(3, 3);
            this.gceCenter.Name = "gceCenter";
            this.gceCenter.Size = new System.Drawing.Size(247, 135);
            this.gceCenter.TabIndex = 0;
            this.gceCenter.Changed += new System.EventHandler(this.gceCenter_Changed);
            // 
            // RadialGradientEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.gceCenter);
            this.Name = "RadialGradientEditor";
            this.Size = new System.Drawing.Size(250, 141);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientCenterEditor gceCenter;

    }
}
