//----------------------------------------------------------------------------
// GradientBoundsEditor.Designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp.Controls.Background.BackgroundEditor
{
    partial class GradientBoundsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradientBoundsEditor));
            this.ilMain = new System.Windows.Forms.ImageList(this.components);
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lblGradientMode = new C1.Win.Input.C1Label();
            this.lgmeMode = new FlexReportDesignerApp.Controls.Background.Editors.LinearGradientModeEditor();
            this.lblStart = new C1.Win.Input.C1Label();
            this.neEndY = new FlexReportDesignerApp.Controls.Background.Editors.NumericEditor();
            this.neEndX = new FlexReportDesignerApp.Controls.Background.Editors.NumericEditor();
            this.neStartY = new FlexReportDesignerApp.Controls.Background.Editors.NumericEditor();
            this.neStartX = new FlexReportDesignerApp.Controls.Background.Editors.NumericEditor();
            this.lblEnd = new C1.Win.Input.C1Label();
            this.cbEndPoint = new C1.Win.Input.C1CheckBox();
            this.cbStartPoint = new C1.Win.Input.C1CheckBox();
            this.gbcMain = new FlexReportDesignerApp.Controls.Background.GradientBoundsControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblGradientMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgmeMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neEndY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neEndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.neStartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEndPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStartPoint)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ilMain
            // 
            this.ilMain.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilMain.ImageStream")));
            this.ilMain.TransparentColor = System.Drawing.Color.Transparent;
            this.ilMain.Images.SetKeyName(0, "GradientStartPoint.png");
            this.ilMain.Images.SetKeyName(1, "GradientEndPoint.png");
            // 
            // tlpMain
            // 
            this.tlpMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.Controls.Add(this.lblGradientMode, 0, 0);
            this.tlpMain.Controls.Add(this.lgmeMode, 1, 0);
            this.tlpMain.Controls.Add(this.lblStart, 0, 1);
            this.tlpMain.Controls.Add(this.neEndY, 2, 2);
            this.tlpMain.Controls.Add(this.neEndX, 1, 2);
            this.tlpMain.Controls.Add(this.neStartY, 2, 1);
            this.tlpMain.Controls.Add(this.neStartX, 1, 1);
            this.tlpMain.Controls.Add(this.lblEnd, 0, 2);
            this.tlpMain.Location = new System.Drawing.Point(3, 82);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 4;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(210, 75);
            this.tlpMain.TabIndex = 3;
            // 
            // lblGradientMode
            // 
            //this.lblGradientMode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblGradientMode.Location = new System.Drawing.Point(3, 0);
            this.lblGradientMode.Name = "lblGradientMode";
            this.lblGradientMode.Size = new System.Drawing.Size(74, 19);
            this.lblGradientMode.TabIndex = 0;
            this.lblGradientMode.Tag = null;
            this.lblGradientMode.Text = "Mode:";
            this.lblGradientMode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.lblGradientMode.TextDetached = true;
            // 
            // lgmeMode
            // 
            //this.lgmeMode.AcceptsTab = true;
            this.lgmeMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.lgmeMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpMain.SetColumnSpan(this.lgmeMode, 2);
            this.lgmeMode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lgmeMode.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            this.lgmeMode.Padding = new System.Windows.Forms.Padding(0);
            this.lgmeMode.Location = new System.Drawing.Point(83, 3);
            this.lgmeMode.Name = "lgmeMode";
            //this.lgmeMode.ShowFocusRectangle = true;
            this.lgmeMode.Size = new System.Drawing.Size(124, 19);
            this.lgmeMode.TabIndex = 1;
            this.lgmeMode.Tag = null;
            this.lgmeMode.EditorValueChanged += new System.EventHandler(this.lgmeMode_EditorValueChanged);
            // 
            // lblStart
            // 
            //this.lblStart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblStart.Location = new System.Drawing.Point(3, 25);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(74, 19);
            this.lblStart.TabIndex = 2;
            this.lblStart.Tag = null;
            this.lblStart.Text = "Start:";
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.lblStart.TextDetached = true;
            // 
            // neEndY
            // 
            //this.neEndY.AcceptsTab = true;
            this.neEndY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.neEndY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.neEndY.DecimalPlaces = 0;
            this.neEndY.Format = "{0}%";
            this.neEndY.Padding = new System.Windows.Forms.Padding(0);
            this.neEndY.Location = new System.Drawing.Point(148, 53);
            this.neEndY.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.neEndY.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.neEndY.Name = "neEndY";
            this.neEndY.NumericType = FlexReportDesignerApp.Controls.Background.Editors.NumericType.Integer;
            this.neEndY.Size = new System.Drawing.Size(59, 19);
            this.neEndY.TabIndex = 7;
            this.neEndY.Tag = null;
            this.neEndY.EditorValueChanged += new System.EventHandler(this.neEndY_EditorValueChanged);
            // 
            // neEndX
            // 
            //this.neEndX.AcceptsTab = true;
            this.neEndX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.neEndX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.neEndX.DecimalPlaces = 0;
            this.neEndX.Format = "{0}%";
            this.neEndX.Padding = new System.Windows.Forms.Padding(0);
            this.neEndX.Location = new System.Drawing.Point(83, 53);
            this.neEndX.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.neEndX.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.neEndX.Name = "neEndX";
            this.neEndX.NumericType = FlexReportDesignerApp.Controls.Background.Editors.NumericType.Integer;
            this.neEndX.Size = new System.Drawing.Size(59, 19);
            this.neEndX.TabIndex = 6;
            this.neEndX.Tag = null;
            this.neEndX.EditorValueChanged += new System.EventHandler(this.neEndX_EditorValueChanged);
            // 
            // neStartY
            // 
            //this.neStartY.AcceptsTab = true;
            this.neStartY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.neStartY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.neStartY.DecimalPlaces = 0;
            this.neStartY.Format = "{0}%";
            this.neStartY.Padding = new System.Windows.Forms.Padding(0);
            this.neStartY.Location = new System.Drawing.Point(148, 28);
            this.neStartY.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.neStartY.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.neStartY.Name = "neStartY";
            this.neStartY.NumericType = FlexReportDesignerApp.Controls.Background.Editors.NumericType.Integer;
            this.neStartY.Size = new System.Drawing.Size(59, 19);
            this.neStartY.TabIndex = 4;
            this.neStartY.Tag = null;
            this.neStartY.EditorValueChanged += new System.EventHandler(this.neStartY_EditorValueChanged);
            // 
            // neStartX
            // 
            //this.neStartX.AcceptsTab = true;
            this.neStartX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            //this.neStartX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.neStartX.DecimalPlaces = 0;
            this.neStartX.Format = "{0}%";
            this.neStartX.Padding = new System.Windows.Forms.Padding(0);
            this.neStartX.Location = new System.Drawing.Point(83, 28);
            this.neStartX.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.neStartX.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.neStartX.Name = "neStartX";
            this.neStartX.NumericType = FlexReportDesignerApp.Controls.Background.Editors.NumericType.Integer;
            this.neStartX.Size = new System.Drawing.Size(59, 19);
            this.neStartX.TabIndex = 3;
            this.neStartX.Tag = null;
            this.neStartX.EditorValueChanged += new System.EventHandler(this.neStartX_EditorValueChanged);
            // 
            // lblEnd
            // 
            //this.lblEnd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblEnd.Location = new System.Drawing.Point(3, 50);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(74, 19);
            this.lblEnd.TabIndex = 5;
            this.lblEnd.Tag = null;
            this.lblEnd.Text = "End:";
            this.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //this.lblEnd.TextDetached = true;
            // 
            // cbEndPoint
            // 
            this.cbEndPoint.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbEndPoint.AutoCheck = false;
            this.cbEndPoint.BackColor = System.Drawing.Color.Transparent;
            this.cbEndPoint.ForeColor = System.Drawing.Color.Black;
            this.cbEndPoint.ImageKey = "GradientEndPoint.png";
            this.cbEndPoint.ImageList = this.ilMain;
            this.cbEndPoint.Location = new System.Drawing.Point(3, 2);
            this.cbEndPoint.Name = "cbEndPoint";
            this.cbEndPoint.Padding = new System.Windows.Forms.Padding(1);
            this.cbEndPoint.Size = new System.Drawing.Size(26, 23);
            this.cbEndPoint.TabIndex = 0;
            //this.cbEndPoint.UseVisualStyleBackColor = true;
            this.cbEndPoint.Value = false;
            this.cbEndPoint.Click += new System.EventHandler(this.cbEndPoint_Click);
            // 
            // cbStartPoint
            // 
            this.cbStartPoint.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbStartPoint.AutoCheck = false;
            this.cbStartPoint.BackColor = System.Drawing.Color.Transparent;
            this.cbStartPoint.Checked = true;
            this.cbStartPoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStartPoint.ForeColor = System.Drawing.Color.Black;
            this.cbStartPoint.ImageKey = "GradientStartPoint.png";
            this.cbStartPoint.ImageList = this.ilMain;
            this.cbStartPoint.Location = new System.Drawing.Point(3, 3);
            this.cbStartPoint.Name = "cbStartPoint";
            this.cbStartPoint.Padding = new System.Windows.Forms.Padding(1);
            this.cbStartPoint.Size = new System.Drawing.Size(26, 23);
            this.cbStartPoint.TabIndex = 0;
            this.cbStartPoint.TabStop = false;
            //this.cbStartPoint.UseVisualStyleBackColor = true;
            this.cbStartPoint.Value = true;
            this.cbStartPoint.Click += new System.EventHandler(this.cbStartPoint_Click);
            // 
            // gbcMain
            // 
            this.gbcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbcMain.Location = new System.Drawing.Point(3, 3);
            this.gbcMain.Name = "gbcMain";
            this.gbcMain.Size = new System.Drawing.Size(207, 73);
            this.gbcMain.TabIndex = 0;
            this.gbcMain.TabStop = false;
            this.gbcMain.Text = "gradientBoundsControl1";
            this.gbcMain.GradientStartChanged += new System.EventHandler(this.gbcMain_GradientStartChanged);
            this.gbcMain.GradientEndChanged += new System.EventHandler(this.gbcMain_GradientEndChanged);
            this.gbcMain.ActiveCornerChanged += new System.EventHandler(this.gbcMain_ActiveCornerChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbStartPoint);
            this.panel1.Location = new System.Drawing.Point(211, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 31);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.cbEndPoint);
            this.panel2.Location = new System.Drawing.Point(211, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(36, 30);
            this.panel2.TabIndex = 2;
            // 
            // GradientBoundsEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.gbcMain);
            this.Name = "GradientBoundsEditor";
            this.Size = new System.Drawing.Size(247, 161);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lblGradientMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgmeMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neEndY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neEndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.neStartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEndPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbStartPoint)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GradientBoundsControl gbcMain;
        private Editors.NumericEditor neStartX;
        private C1.Win.Input.C1Label lblStart;
        private Editors.NumericEditor neStartY;
        private C1.Win.Input.C1Label lblEnd;
        private Editors.NumericEditor neEndX;
        private Editors.NumericEditor neEndY;
        private C1.Win.Input.C1CheckBox cbStartPoint;
        private C1.Win.Input.C1CheckBox cbEndPoint;
        private Editors.LinearGradientModeEditor lgmeMode;
        private C1.Win.Input.C1Label lblGradientMode;
        private System.Windows.Forms.ImageList ilMain;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
