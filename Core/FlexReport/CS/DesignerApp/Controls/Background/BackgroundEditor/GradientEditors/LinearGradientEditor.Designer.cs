//----------------------------------------------------------------------------
// LinearGradientEditor.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors
{
    partial class LinearGradientEditor
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
            this.gbeBounds = new FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientBoundsEditor();
            this.SuspendLayout();
            // 
            // gbeBounds
            // 
            this.gbeBounds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbeBounds.BackColor = System.Drawing.Color.AliceBlue;
            this.gbeBounds.Location = new System.Drawing.Point(3, 3);
            this.gbeBounds.Name = "gbeBounds";
            this.gbeBounds.Size = new System.Drawing.Size(247, 161);
            this.gbeBounds.TabIndex = 0;
            this.gbeBounds.Changed += new System.EventHandler(this.gbeBounds_Changed);
            // 
            // LinearGradientEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.gbeBounds);
            this.Name = "LinearGradientEditor";
            this.Size = new System.Drawing.Size(250, 164);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientBoundsEditor gbeBounds;

    }
}
