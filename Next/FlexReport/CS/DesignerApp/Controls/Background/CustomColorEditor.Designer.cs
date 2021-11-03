//----------------------------------------------------------------------------
// CustomColorEditor.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;

namespace FlexReportDesignerApp.Controls.Background
{
    partial class CustomColorEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomColorEditor));
            this.btnOk = new C1.Win.Input.C1Button();
            this.cbTransparentColor = new FlexReportDesignerApp.Controls.Background.ColorButton();
            this.neAlpha = new C1.Win.Input.C1NumericEdit();
            this.neBlue = new C1.Win.Input.C1NumericEdit();
            this.neGreen = new C1.Win.Input.C1NumericEdit();
            this.neRed = new C1.Win.Input.C1NumericEdit();
            this.pnlCustomColors = new FlexReportDesignerApp.Controls.Background.ColorSwatchPanel();
            this.c1Label4 = new C1.Win.Input.C1Label();
            this.c1Label3 = new C1.Win.Input.C1Label();
            this.c1Label2 = new C1.Win.Input.C1Label();
            this.c1Label1 = new C1.Win.Input.C1Label();
            this.pcPreview = new FlexReportDesignerApp.Controls.Background.PreviewControl();
            this.btnColorPicker = new FlexReportDesignerApp.Controls.Background.ColorPickerButton();
            this.cbEmptyColor = new FlexReportDesignerApp.Controls.Background.ColorButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neAlpha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(222, 323);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "OK";
            //this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cbTransparentColor
            // 
            this.cbTransparentColor.Color = System.Drawing.Color.Transparent;
            this.cbTransparentColor.Location = new System.Drawing.Point(3, 3);
            this.cbTransparentColor.Name = "cbTransparentColor";
            this.cbTransparentColor.Size = new System.Drawing.Size(96, 23);
            this.cbTransparentColor.TabIndex = 0;
            this.cbTransparentColor.UseVisualStyleBackColor = false;
            // 
            // neAlpha
            // 
            this.neAlpha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            //this.neAlpha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.neAlpha.DataType = typeof(int);
            this.neAlpha.Padding = new System.Windows.Forms.Padding(0);
            this.neAlpha.Location = new System.Drawing.Point(153, 326);
            this.neAlpha.Name = "neAlpha";
            this.neAlpha.Size = new System.Drawing.Size(60, 18);
            this.neAlpha.TabIndex = 11;
            this.neAlpha.Tag = null;
            //this.neAlpha.VisibleButtons = C1.Win.Input.DropDownControlButtonFlags.UpDown;
            this.neAlpha.ValueChanged += new System.EventHandler(this.neRed_ValueChanged);
            // 
            // neBlue
            // 
            this.neBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            //this.neBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.neBlue.DataType = typeof(int);
            this.neBlue.Padding = new System.Windows.Forms.Padding(0);
            this.neBlue.Location = new System.Drawing.Point(153, 300);
            this.neBlue.Name = "neBlue";
            this.neBlue.Size = new System.Drawing.Size(60, 18);
            this.neBlue.TabIndex = 9;
            this.neBlue.Tag = null;
            //this.neBlue.VisibleButtons = C1.Win.Input.DropDownControlButtonFlags.UpDown;
            this.neBlue.ValueChanged += new System.EventHandler(this.neRed_ValueChanged);
            // 
            // neGreen
            // 
            this.neGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            //this.neGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.neGreen.DataType = typeof(int);
            this.neGreen.Padding = new System.Windows.Forms.Padding(0);
            this.neGreen.Location = new System.Drawing.Point(153, 274);
            this.neGreen.Name = "neGreen";
            this.neGreen.Size = new System.Drawing.Size(60, 18);
            this.neGreen.TabIndex = 7;
            this.neGreen.Tag = null;
            //this.neGreen.VisibleButtons = C1.Win.Input.DropDownControlButtonFlags.UpDown;
            this.neGreen.ValueChanged += new System.EventHandler(this.neRed_ValueChanged);
            // 
            // neRed
            // 
            this.neRed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            //this.neRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.neRed.DataType = typeof(int);
            this.neRed.Padding = new System.Windows.Forms.Padding(0);
            this.neRed.Location = new System.Drawing.Point(153, 248);
            this.neRed.Name = "neRed";
            this.neRed.Size = new System.Drawing.Size(60, 18);
            this.neRed.TabIndex = 5;
            this.neRed.Tag = null;
            //this.neRed.VisibleButtons = C1.Win.Input.DropDownControlButtonFlags.UpDown;
            this.neRed.ValueChanged += new System.EventHandler(this.neRed_ValueChanged);
            // 
            // pnlCustomColors
            // 
            this.pnlCustomColors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCustomColors.BackColor = System.Drawing.Color.Transparent;
            this.pnlCustomColors.CurrentColor = System.Drawing.Color.Empty;
            this.pnlCustomColors.Location = new System.Drawing.Point(3, 32);
            this.pnlCustomColors.Name = "pnlCustomColors";
            this.pnlCustomColors.Size = new System.Drawing.Size(294, 185);
            this.pnlCustomColors.TabIndex = 2;
            this.pnlCustomColors.TabStop = false;
            // 
            // c1Label4
            // 
            this.c1Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Label4.BackColor = System.Drawing.Color.Transparent;
            //this.c1Label4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label4.ForeColor = System.Drawing.Color.Black;
            this.c1Label4.Location = new System.Drawing.Point(104, 329);
            this.c1Label4.Name = "c1Label4";
            this.c1Label4.Size = new System.Drawing.Size(43, 13);
            this.c1Label4.TabIndex = 10;
            this.c1Label4.Tag = null;
            this.c1Label4.Text = "Alpha:";
            this.c1Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.c1Label4.TextDetached = true;
            // 
            // c1Label3
            // 
            this.c1Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Label3.BackColor = System.Drawing.Color.Transparent;
            //this.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label3.ForeColor = System.Drawing.Color.Black;
            this.c1Label3.Location = new System.Drawing.Point(104, 303);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(43, 13);
            this.c1Label3.TabIndex = 8;
            this.c1Label3.Tag = null;
            this.c1Label3.Text = "Blue:";
            this.c1Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.c1Label3.TextDetached = true;
            // 
            // c1Label2
            // 
            this.c1Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Label2.BackColor = System.Drawing.Color.Transparent;
            //this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.ForeColor = System.Drawing.Color.Black;
            this.c1Label2.Location = new System.Drawing.Point(104, 277);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(43, 13);
            this.c1Label2.TabIndex = 6;
            this.c1Label2.Tag = null;
            this.c1Label2.Text = "Green:";
            this.c1Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.c1Label2.TextDetached = true;
            // 
            // c1Label1
            // 
            this.c1Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Label1.BackColor = System.Drawing.Color.Transparent;
            //this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.ForeColor = System.Drawing.Color.Black;
            this.c1Label1.Location = new System.Drawing.Point(104, 251);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(43, 13);
            this.c1Label1.TabIndex = 4;
            this.c1Label1.Tag = null;
            this.c1Label1.Text = "Red:";
            this.c1Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.c1Label1.TextDetached = true;
            // 
            // pcPreview
            // 
            this.pcPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcPreview.Location = new System.Drawing.Point(3, 252);
            this.pcPreview.Name = "pcPreview";
            this.pcPreview.Size = new System.Drawing.Size(96, 96);
            this.pcPreview.TabIndex = 3;
            this.pcPreview.TabStop = false;
            this.pcPreview.Text = "previewControl1";
            this.pcPreview.DrawInitial += new System.EventHandler<FlexReportDesignerApp.Controls.Background.DrawPreviewEventArgs>(this.pcPreview_DrawInitial);
            this.pcPreview.DrawCurrent += new System.EventHandler<FlexReportDesignerApp.Controls.Background.DrawPreviewEventArgs>(this.pcPreview_DrawCurrent);
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.BackColor = System.Drawing.Color.Transparent;
            this.btnColorPicker.Image = ((System.Drawing.Image)(resources.GetObject("btnColorPicker.Image")));
            this.btnColorPicker.Location = new System.Drawing.Point(255, 3);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(23, 23);
            this.btnColorPicker.TabIndex = 1;
            this.btnColorPicker.UseVisualStyleBackColor = false;
            this.btnColorPicker.Visible = false;
            // 
            // cbEmptyColor
            // 
            this.cbEmptyColor.Color = System.Drawing.Color.Empty;
            this.cbEmptyColor.Location = new System.Drawing.Point(105, 3);
            this.cbEmptyColor.Name = "cbEmptyColor";
            this.cbEmptyColor.Size = new System.Drawing.Size(65, 23);
            this.cbEmptyColor.TabIndex = 13;
            this.cbEmptyColor.UseVisualStyleBackColor = false;
            // 
            // CustomColorEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.cbEmptyColor);
            this.Controls.Add(this.btnColorPicker);
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1Label3);
            this.Controls.Add(this.c1Label4);
            this.Controls.Add(this.pcPreview);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbTransparentColor);
            this.Controls.Add(this.neAlpha);
            this.Controls.Add(this.neBlue);
            this.Controls.Add(this.neGreen);
            this.Controls.Add(this.neRed);
            this.Controls.Add(this.pnlCustomColors);
            this.Name = "CustomColorEditor";
            this.Size = new System.Drawing.Size(300, 349);
            ((System.ComponentModel.ISupportInitialize)(this.btnOk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neAlpha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Input.C1Button btnOk;
        private ColorButton cbTransparentColor;
        private C1.Win.Input.C1NumericEdit neAlpha;
        private C1.Win.Input.C1NumericEdit neBlue;
        private C1.Win.Input.C1NumericEdit neGreen;
        private C1.Win.Input.C1NumericEdit neRed;
        private C1.Win.Input.C1Label c1Label4;
        private C1.Win.Input.C1Label c1Label3;
        private C1.Win.Input.C1Label c1Label2;
        private C1.Win.Input.C1Label c1Label1;
        private ColorSwatchPanel pnlCustomColors;
        public PreviewControl pcPreview;
        private ColorPickerButton btnColorPicker;
        private ColorButton cbEmptyColor;
    }
}
