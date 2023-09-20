//----------------------------------------------------------------------------
// GradientCenterEditor.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor
{
    partial class GradientCenterEditor
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
            this.components = new System.ComponentModel.Container();
            this.neVertical = new FlexReportDesignerApp.Controls.Background.Editors.NumericEditor();
            this.lblVertical = new C1.Win.C1Input.C1Label();
            this.neHorizontal = new FlexReportDesignerApp.Controls.Background.Editors.NumericEditor();
            this.lblHorizontal = new C1.Win.C1Input.C1Label();
            this.gccMain = new FlexReportDesignerApp.Controls.Background.GradientCenterControl();
            ((System.ComponentModel.ISupportInitialize)(this.neVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHorizontal)).BeginInit();
            this.SuspendLayout();
            // 
            // neVertical
            // 
            this.neVertical.AcceptsTab = true;
            this.neVertical.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.neVertical.ImagePadding = new System.Windows.Forms.Padding(0);
            this.neVertical.Location = new System.Drawing.Point(107, 110);
            this.neVertical.Name = "neVertical";
            this.neVertical.Size = new System.Drawing.Size(103, 19);
            this.neVertical.TabIndex = 4;
            this.neVertical.Tag = null;
            this.neVertical.EditorValueChanged += new System.EventHandler(this.peVertical_EditorValueChanged);
            // 
            // lblVertical
            // 
            this.lblVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVertical.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblVertical.Location = new System.Drawing.Point(3, 110);
            this.lblVertical.Name = "lblVertical";
            this.lblVertical.Size = new System.Drawing.Size(98, 19);
            this.lblVertical.TabIndex = 3;
            this.lblVertical.Tag = null;
            this.lblVertical.Text = "Vertical:";
            this.lblVertical.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVertical.TextDetached = true;
            // 
            // neHorizontal
            // 
            this.neHorizontal.AcceptsTab = true;
            this.neHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.neHorizontal.ImagePadding = new System.Windows.Forms.Padding(0);
            this.neHorizontal.Location = new System.Drawing.Point(107, 85);
            this.neHorizontal.Name = "neHorizontal";
            this.neHorizontal.Size = new System.Drawing.Size(103, 19);
            this.neHorizontal.TabIndex = 2;
            this.neHorizontal.Tag = null;
            this.neHorizontal.EditorValueChanged += new System.EventHandler(this.peHorizontal_EditorValueChanged);
            // 
            // lblHorizontal
            // 
            this.lblHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblHorizontal.Location = new System.Drawing.Point(3, 85);
            this.lblHorizontal.Name = "lblHorizontal";
            this.lblHorizontal.Size = new System.Drawing.Size(98, 19);
            this.lblHorizontal.TabIndex = 1;
            this.lblHorizontal.Tag = null;
            this.lblHorizontal.Text = "Horizontal:";
            this.lblHorizontal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHorizontal.TextDetached = true;
            // 
            // gccMain
            // 
            this.gccMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gccMain.Location = new System.Drawing.Point(3, 3);
            this.gccMain.Name = "gccMain";
            this.gccMain.Size = new System.Drawing.Size(207, 73);
            this.gccMain.TabIndex = 0;
            this.gccMain.TabStop = false;
            this.gccMain.Text = "gradientCenterControl1";
            this.gccMain.GradientCenterChanged += new System.EventHandler(this.gccMain_GradientCenterChanged);
            // 
            // GradientCenterEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.neVertical);
            this.Controls.Add(this.lblVertical);
            this.Controls.Add(this.neHorizontal);
            this.Controls.Add(this.lblHorizontal);
            this.Controls.Add(this.gccMain);
            this.Name = "GradientCenterEditor";
            this.Size = new System.Drawing.Size(247, 135);
            ((System.ComponentModel.ISupportInitialize)(this.neVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblHorizontal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientCenterControl gccMain;
        private C1.Win.C1Input.C1Label lblHorizontal;
        private Editors.NumericEditor neHorizontal;
        private Editors.NumericEditor neVertical;
        private C1.Win.C1Input.C1Label lblVertical;
    }
}
