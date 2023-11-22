//----------------------------------------------------------------------------
// ColorBlendEditor.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;

namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor
{
    partial class ColorBlendEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorBlendEditor));
            this.lblPosition = new C1.Win.C1Input.C1Label();
            this.lblColor = new C1.Win.C1Input.C1Label();
            this.btnAdd = new C1.Win.C1Input.C1Button();
            this.btnRemove = new C1.Win.C1Input.C1Button();
            this.ceColor = new FlexReportDesignerApp.Controls.Background.Editors.ColorEditor();
            this.pePosition = new FlexReportDesignerApp.Controls.Background.Editors.PercentEditor();
            this.gpeMain = new FlexReportDesignerApp.Controls.Background.GradientPointsControl();
            ((System.ComponentModel.ISupportInitialize)(this.lblPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePosition)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblPosition.Location = new System.Drawing.Point(3, 41);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(81, 14);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Tag = null;
            this.lblPosition.Text = "Position:";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPosition.TextDetached = true;
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblColor.Location = new System.Drawing.Point(3, 65);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(81, 14);
            this.lblColor.TabIndex = 5;
            this.lblColor.Tag = null;
            this.lblColor.Text = "Color:";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblColor.TextDetached = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(260, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Image = ((System.Drawing.Image)(resources.GetObject("btnRemove.Image")));
            this.btnRemove.Location = new System.Drawing.Point(287, 4);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(25, 25);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // ceColor
            // 
            this.ceColor.AcceptsTab = true;
            this.ceColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ceColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ceColor.ImagePadding = new System.Windows.Forms.Padding(0);
            this.ceColor.Location = new System.Drawing.Point(90, 64);
            this.ceColor.Name = "ceColor";
            this.ceColor.Size = new System.Drawing.Size(222, 19);
            this.ceColor.TabIndex = 6;
            this.ceColor.Tag = null;
            this.ceColor.EditorValueChanged += new System.EventHandler(this.ceColor_EditorValueChanged);
            // 
            // pePosition
            // 
            this.pePosition.AcceptsTab = true;
            this.pePosition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pePosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pePosition.DecimalPlaces = 1;
            this.pePosition.ImagePadding = new System.Windows.Forms.Padding(0);
            this.pePosition.Location = new System.Drawing.Point(90, 40);
            this.pePosition.Name = "pePosition";
            this.pePosition.NumericType = FlexReportDesignerApp.Controls.Background.Editors.NumericType.Float;
            this.pePosition.Size = new System.Drawing.Size(222, 19);
            this.pePosition.TabIndex = 4;
            this.pePosition.Tag = null;
            this.pePosition.EditorValueChanged += new System.EventHandler(this.pePosition_EditorValueChanged);
            // 
            // gpeMain
            // 
            this.gpeMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpeMain.Location = new System.Drawing.Point(3, 3);
            this.gpeMain.Name = "gpeMain";
            this.gpeMain.Size = new System.Drawing.Size(255, 31);
            this.gpeMain.TabIndex = 0;
            this.gpeMain.Text = "gradientPointsEditor1";
            this.gpeMain.PointAdded += new System.EventHandler<FlexReportDesignerApp.Controls.Background.GradientPointEventArgs>(this.gpeMain_PointAdded);
            this.gpeMain.PointChanged += new System.EventHandler<FlexReportDesignerApp.Controls.Background.GradientPointEventArgs>(this.gpeMain_PointChanged);
            this.gpeMain.SelectedPointChanged += new System.EventHandler(this.gpeMain_SelectedPointChanged);
            // 
            // ColorBlendEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ceColor);
            this.Controls.Add(this.pePosition);
            this.Controls.Add(this.gpeMain);
            this.Name = "ColorBlendEditor";
            this.Size = new System.Drawing.Size(315, 92);
            ((System.ComponentModel.ISupportInitialize)(this.lblPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePosition)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GradientPointsControl gpeMain;
        private C1.Win.C1Input.C1Label lblPosition;
        private Editors.ColorEditor ceColor;
        private C1.Win.C1Input.C1Label lblColor;
        private Editors.PercentEditor pePosition;
        private C1.Win.C1Input.C1Button btnRemove;
        private C1.Win.C1Input.C1Button btnAdd;
    }
}
