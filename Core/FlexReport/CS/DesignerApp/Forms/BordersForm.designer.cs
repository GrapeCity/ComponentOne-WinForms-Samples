//----------------------------------------------------------------------------
// BordersForm.designer.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
namespace FlexReportDesignerApp
{
    partial class BordersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
    	
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ListBox lbWidth;
        private System.Windows.Forms.ListBox lbStyle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox previewPanel;

        private C1.Win.Input.Pickers.C1ColorPicker c1ColorPicker1;
        private C1.Win.Input.C1CheckBox cbBorderTop;
        private C1.Win.Input.C1CheckBox cbBorderRight;
        private C1.Win.Input.C1CheckBox cbBorderLeft;
        private C1.Win.Input.C1CheckBox cbBorderBottom;

        private C1.Win.Input.C1CheckBox cbBorderAll;
        private C1.Win.Input.C1CheckBox cbBorderNone;
        private C1.Win.Input.C1NumericEdit numRadiusX;
        private C1.Win.Input.C1NumericEdit numRadiusY;

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BordersForm));
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numRadiusY = new C1.Win.Input.C1NumericEdit();
            this.numRadiusX = new C1.Win.Input.C1NumericEdit();
            this.c1ColorPicker1 = new C1.Win.Input.Pickers.C1ColorPicker();
            this.lbWidth = new System.Windows.Forms.ListBox();
            this.lbStyle = new System.Windows.Forms.ListBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbBorderNone = new C1.Win.Input.C1CheckBox();
            this.cbBorderAll = new C1.Win.Input.C1CheckBox();
            this.cbBorderLeft = new C1.Win.Input.C1CheckBox();
            this.cbBorderBottom = new C1.Win.Input.C1CheckBox();
            this.cbBorderRight = new C1.Win.Input.C1CheckBox();
            this.cbBorderTop = new C1.Win.Input.C1CheckBox();
            this.previewPanel = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ColorPicker1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbBorderNone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBorderAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBorderLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBorderBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBorderRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBorderTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._btnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnOK.Location = new System.Drawing.Point(357, 327);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(88, 24);
            this._btnOK.TabIndex = 2;
            this._btnOK.Text = "&OK";
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnCancel.Location = new System.Drawing.Point(451, 327);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(88, 24);
            this._btnCancel.TabIndex = 3;
            this._btnCancel.Text = "&Cancel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "&Width:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numRadiusY);
            this.groupBox1.Controls.Add(this.numRadiusX);
            this.groupBox1.Controls.Add(this.c1ColorPicker1);
            this.groupBox1.Controls.Add(this.lbWidth);
            this.groupBox1.Controls.Add(this.lbStyle);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Line";
            // 
            // numRadiusY
            // 
            this.numRadiusY.Location = new System.Drawing.Point(97, 255);
            this.numRadiusY.Name = "numRadiusY";
            this.numRadiusY.PostValidation.Intervals.AddRange(new C1.Win.Input.Validation.ValueInterval[] {
            new C1.Win.Input.Validation.ValueInterval(new decimal(new int[] {
                            0,
                            0,
                            0,
                            0}), null, true, true)});
            this.numRadiusY.Size = new System.Drawing.Size(99, 18);
            this.numRadiusY.TabIndex = 8;
            this.numRadiusY.Tag = null;
            //this.numRadiusY.VisibleButtons = C1.Win.Input.DropDownControlButtonFlags.UpDown;
            this.numRadiusY.ValueChanged += new System.EventHandler(this.numRadiusY_ValueChanged);
            // 
            // numRadiusX
            // 
            //this.numRadiusX.ImagePadding = new System.Windows.Forms.Padding(0);
            this.numRadiusX.Location = new System.Drawing.Point(97, 231);
            this.numRadiusX.Name = "numRadiusX";
            this.numRadiusX.PostValidation.Intervals.AddRange(new C1.Win.Input.Validation.ValueInterval[] {
            new C1.Win.Input.Validation.ValueInterval(new decimal(new int[] {
                            0,
                            0,
                            0,
                            0}), null, true, true)});
            this.numRadiusX.Size = new System.Drawing.Size(99, 18);
            this.numRadiusX.TabIndex = 6;
            this.numRadiusX.Tag = null;
            //this.numRadiusX.VisibleButtons = C1.Win.Input.DropDownControlButtonFlags.UpDown;
            this.numRadiusX.ValueChanged += new System.EventHandler(this.numRadiusX_ValueChanged);
            // 
            // c1ColorPicker1
            // 
            this.c1ColorPicker1.AllowEmpty = false;
            this.c1ColorPicker1.EmptyColorCaption = null;
            this.c1ColorPicker1.Padding = new System.Windows.Forms.Padding(0);
            this.c1ColorPicker1.Location = new System.Drawing.Point(21, 207);
            this.c1ColorPicker1.Name = "c1ColorPicker1";
            this.c1ColorPicker1.Size = new System.Drawing.Size(175, 18);
            this.c1ColorPicker1.TabIndex = 4;
            this.c1ColorPicker1.Tag = null;
            this.c1ColorPicker1.Color = System.Drawing.Color.Transparent;
            // 
            // lbWidth
            // 
            this.lbWidth.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbWidth.FormattingEnabled = true;
            this.lbWidth.Location = new System.Drawing.Point(148, 36);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.Size = new System.Drawing.Size(123, 147);
            this.lbWidth.TabIndex = 3;
            this.lbWidth.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbWidth_DrawItem);
            this.lbWidth.SelectedIndexChanged += new System.EventHandler(this.lbWidth_SelectedIndexChanged);
            // 
            // lbStyle
            // 
            this.lbStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbStyle.FormattingEnabled = true;
            this.lbStyle.Location = new System.Drawing.Point(10, 36);
            this.lbStyle.Name = "lbStyle";
            this.lbStyle.Size = new System.Drawing.Size(123, 147);
            this.lbStyle.TabIndex = 2;
            this.lbStyle.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbStyle_DrawItem);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(24, 258);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 13);
            this.label24.TabIndex = 7;
            this.label24.Text = "Radius &Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Radius &X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "&Style:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbBorderNone);
            this.groupBox2.Controls.Add(this.cbBorderAll);
            this.groupBox2.Controls.Add(this.cbBorderLeft);
            this.groupBox2.Controls.Add(this.cbBorderBottom);
            this.groupBox2.Controls.Add(this.cbBorderRight);
            this.groupBox2.Controls.Add(this.cbBorderTop);
            this.groupBox2.Controls.Add(this.previewPanel);
            this.groupBox2.Location = new System.Drawing.Point(313, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "&Borders";
            // 
            // cbBorderNone
            // 
            this.cbBorderNone.Appearance = System.Windows.Forms.Appearance.Button;
            //this.cbBorderNone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbBorderNone.Image = ((System.Drawing.Image)(resources.GetObject("cbBorderNone.Image")));
            this.cbBorderNone.Location = new System.Drawing.Point(128, 30);
            this.cbBorderNone.Name = "cbBorderNone";
            this.cbBorderNone.Size = new System.Drawing.Size(58, 42);
            this.cbBorderNone.TabIndex = 1;
            this.cbBorderNone.Text = "&None";
            this.cbBorderNone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbBorderNone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            //this.cbBorderNone.UseVisualStyleBackColor = true;
            this.cbBorderNone.Value = null;
            this.cbBorderNone.Click += new System.EventHandler(this.cbBorderNone_Click);
            // 
            // cbBorderAll
            // 
            this.cbBorderAll.Appearance = System.Windows.Forms.Appearance.Button;
            //this.cbBorderAll.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbBorderAll.Image = ((System.Drawing.Image)(resources.GetObject("cbBorderAll.Image")));
            this.cbBorderAll.Location = new System.Drawing.Point(40, 30);
            this.cbBorderAll.Name = "cbBorderAll";
            this.cbBorderAll.Size = new System.Drawing.Size(58, 42);
            this.cbBorderAll.TabIndex = 0;
            this.cbBorderAll.Text = "&All";
            this.cbBorderAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cbBorderAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            //this.cbBorderAll.UseVisualStyleBackColor = true;
            this.cbBorderAll.Value = null;
            this.cbBorderAll.Click += new System.EventHandler(this.cbBorderAll_Click);
            // 
            // cbBorderLeft
            // 
            this.cbBorderLeft.Appearance = System.Windows.Forms.Appearance.Button;
            //this.cbBorderLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbBorderLeft.Image = ((System.Drawing.Image)(resources.GetObject("cbBorderLeft.Image")));
            this.cbBorderLeft.Location = new System.Drawing.Point(9, 160);
            this.cbBorderLeft.Name = "cbBorderLeft";
            this.cbBorderLeft.Size = new System.Drawing.Size(26, 26);
            this.cbBorderLeft.TabIndex = 5;
            //this.cbBorderLeft.UseVisualStyleBackColor = true;
            this.cbBorderLeft.Value = null;
            this.cbBorderLeft.Click += new System.EventHandler(this.cbBorder_Click);
            // 
            // cbBorderBottom
            // 
            this.cbBorderBottom.Appearance = System.Windows.Forms.Appearance.Button;
            //this.cbBorderBottom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbBorderBottom.Image = ((System.Drawing.Image)(resources.GetObject("cbBorderBottom.Image")));
            this.cbBorderBottom.Location = new System.Drawing.Point(100, 230);
            this.cbBorderBottom.Name = "cbBorderBottom";
            this.cbBorderBottom.Size = new System.Drawing.Size(26, 26);
            this.cbBorderBottom.TabIndex = 4;
            //this.cbBorderBottom.UseVisualStyleBackColor = true;
            this.cbBorderBottom.Value = null;
            this.cbBorderBottom.Click += new System.EventHandler(this.cbBorder_Click);
            // 
            // cbBorderRight
            // 
            this.cbBorderRight.Appearance = System.Windows.Forms.Appearance.Button;
            //this.cbBorderRight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbBorderRight.Image = ((System.Drawing.Image)(resources.GetObject("cbBorderRight.Image")));
            this.cbBorderRight.Location = new System.Drawing.Point(191, 160);
            this.cbBorderRight.Name = "cbBorderRight";
            this.cbBorderRight.Size = new System.Drawing.Size(26, 26);
            this.cbBorderRight.TabIndex = 3;
            //this.cbBorderRight.UseVisualStyleBackColor = true;
            this.cbBorderRight.Value = null;
            this.cbBorderRight.Click += new System.EventHandler(this.cbBorder_Click);
            // 
            // cbBorderTop
            // 
            this.cbBorderTop.Appearance = System.Windows.Forms.Appearance.Button;
            //this.cbBorderTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cbBorderTop.Image = ((System.Drawing.Image)(resources.GetObject("cbBorderTop.Image")));
            this.cbBorderTop.Location = new System.Drawing.Point(100, 92);
            this.cbBorderTop.Name = "cbBorderTop";
            this.cbBorderTop.Size = new System.Drawing.Size(26, 26);
            this.cbBorderTop.TabIndex = 2;
            //this.cbBorderTop.UseVisualStyleBackColor = true;
            this.cbBorderTop.Value = null;
            this.cbBorderTop.Click += new System.EventHandler(this.cbBorder_Click);
            // 
            // previewPanel
            // 
            this.previewPanel.BackColor = System.Drawing.SystemColors.Window;
            this.previewPanel.Location = new System.Drawing.Point(40, 123);
            this.previewPanel.Name = "previewPanel";
            this.previewPanel.Size = new System.Drawing.Size(146, 102);
            this.previewPanel.TabIndex = 0;
            this.previewPanel.TabStop = false;
            this.previewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.previewPanel_Paint);
            this.previewPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.previewPanel_MouseClick);
            // 
            // BordersForm
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(551, 363);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BordersForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Border Properties";
            this.Load += new System.EventHandler(this.BordersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRadiusX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ColorPicker1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbBorderNone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBorderAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBorderLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBorderBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBorderRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBorderTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewPanel)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
