//----------------------------------------------------------------------------
// GradientBackgroundEditor.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor
{
    partial class GradientBackgroundEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradientBackgroundEditor));
            this.ilMain = new System.Windows.Forms.ImageList(this.components);
            this.mceMultiColor = new FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors.MultiColorEditor();
            this.lgeLinear = new FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors.LinearGradientEditor();
            this.rgeRadial = new FlexReportDesignerApp.Controls.Background.BackgroundEditor.GradientEditors.RadialGradientEditor();
            this.cbRadial = new C1.Win.Input.C1CheckBox();
            this.cbLinear = new C1.Win.Input.C1CheckBox();
            this.btnOk = new C1.Win.Input.C1Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cbRadial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLinear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilMain
            // 
            this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
            this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMain.Images.SetKeyName(0, "MultiColorLinear.png");
            this.ilMain.Images.SetKeyName(1, "MultiColorRadial.png");
            // 
            // mceMultiColor
            // 
            this.mceMultiColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mceMultiColor.BackColor = System.Drawing.Color.AliceBlue;
            this.mceMultiColor.Location = new System.Drawing.Point(34, 0);
            this.mceMultiColor.Name = "mceMultiColor";
            this.mceMultiColor.Size = new System.Drawing.Size(266, 96);
            this.mceMultiColor.TabIndex = 0;
            this.mceMultiColor.Changed += new System.EventHandler(this.mceMultiColor_Changed);
            // 
            // lgeLinear
            // 
            this.lgeLinear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lgeLinear.BackColor = System.Drawing.Color.AliceBlue;
            this.lgeLinear.Location = new System.Drawing.Point(34, 102);
            this.lgeLinear.Name = "lgeLinear";
            this.lgeLinear.Size = new System.Drawing.Size(266, 162);
            this.lgeLinear.TabIndex = 3;
            this.lgeLinear.Changed += new System.EventHandler(this.lgeLinear_Changed);
            // 
            // rgeRadial
            // 
            this.rgeRadial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rgeRadial.BackColor = System.Drawing.Color.AliceBlue;
            this.rgeRadial.Location = new System.Drawing.Point(34, 102);
            this.rgeRadial.Name = "rgeRadial";
            this.rgeRadial.Size = new System.Drawing.Size(266, 162);
            this.rgeRadial.TabIndex = 3;
            this.rgeRadial.Changed += new System.EventHandler(this.lgeLinear_Changed);
            // 
            // cbRadial
            // 
            this.cbRadial.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbRadial.AutoCheck = false;
            this.cbRadial.BackColor = System.Drawing.Color.Transparent;
            //this.cbRadial.BorderColor = System.Drawing.Color.Transparent;
            //this.cbRadial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbRadial.ForeColor = System.Drawing.Color.Black;
            this.cbRadial.ImageKey = "MultiColorRadial.png";
            this.cbRadial.ImageList = this.ilMain;
            this.cbRadial.Location = new System.Drawing.Point(4, 3);
            this.cbRadial.Name = "cbRadial";
            this.cbRadial.Padding = new System.Windows.Forms.Padding(1);
            this.cbRadial.Size = new System.Drawing.Size(26, 23);
            this.cbRadial.TabIndex = 0;
            //this.cbRadial.UseVisualStyleBackColor = true;
            this.cbRadial.Value = false;
            this.cbRadial.Click += new System.EventHandler(this.cbRadial_Click);
            // 
            // cbLinear
            // 
            this.cbLinear.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbLinear.AutoCheck = false;
            this.cbLinear.BackColor = System.Drawing.Color.Transparent;
            //this.cbLinear.BorderColor = System.Drawing.Color.Transparent;
            //this.cbLinear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbLinear.Checked = true;
            this.cbLinear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLinear.ForeColor = System.Drawing.Color.Black;
            this.cbLinear.ImageKey = "MultiColorLinear.png";
            this.cbLinear.ImageList = this.ilMain;
            this.cbLinear.Location = new System.Drawing.Point(4, 3);
            this.cbLinear.Name = "cbLinear";
            this.cbLinear.Padding = new System.Windows.Forms.Padding(1);
            this.cbLinear.Size = new System.Drawing.Size(26, 23);
            this.cbLinear.TabIndex = 0;
            this.cbLinear.TabStop = false;
            //this.cbLinear.UseVisualStyleBackColor = true;
            this.cbLinear.Value = true;
            this.cbLinear.Click += new System.EventHandler(this.cbLinear_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(222, 278);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            //this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbLinear);
            this.panel1.Location = new System.Drawing.Point(0, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 30);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbRadial);
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(34, 30);
            this.panel2.TabIndex = 2;
            // 
            // GradientBackgroundEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.mceMultiColor);
            this.Controls.Add(this.lgeLinear);
            this.Controls.Add(this.rgeRadial);
            this.Name = "GradientBackgroundEditor";
            this.Size = new System.Drawing.Size(300, 304);
            ((System.ComponentModel.ISupportInitialize)(this.cbRadial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbLinear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ImageList ilMain;
        private MultiColorEditor mceMultiColor;
        private LinearGradientEditor lgeLinear;
        private RadialGradientEditor rgeRadial;
        private C1.Win.Input.C1CheckBox cbRadial;
        private C1.Win.Input.C1CheckBox cbLinear;
        private C1.Win.Input.C1Button btnOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
