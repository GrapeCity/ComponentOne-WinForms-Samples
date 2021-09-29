namespace FlexChartPrint.Samples
{
    partial class SingleChartPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingleChartPrint));
            this.btnClear = new System.Windows.Forms.Button();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.labHeight = new System.Windows.Forms.Label();
            this.labWidth = new System.Windows.Forms.Label();
            this.labY = new System.Windows.Forms.Label();
            this.labX = new System.Windows.Forms.Label();
            this.chkPreview = new System.Windows.Forms.CheckBox();
            this.comboPrintScale = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkGrayScale = new System.Windows.Forms.CheckBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(152)))), ((int)(((byte)(232)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(211, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtHeight
            // 
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHeight.Location = new System.Drawing.Point(330, 104);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(50, 20);
            this.txtHeight.TabIndex = 11;
            this.txtHeight.Validating += new System.ComponentModel.CancelEventHandler(this.NumerTextValidate);
            // 
            // txtWidth
            // 
            this.txtWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWidth.Location = new System.Drawing.Point(330, 76);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(50, 20);
            this.txtWidth.TabIndex = 9;
            this.txtWidth.Validating += new System.ComponentModel.CancelEventHandler(this.NumerTextValidate);
            // 
            // txtY
            // 
            this.txtY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtY.Location = new System.Drawing.Point(211, 104);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(50, 20);
            this.txtY.TabIndex = 7;
            this.txtY.Validating += new System.ComponentModel.CancelEventHandler(this.NumerTextValidate);
            // 
            // txtX
            // 
            this.txtX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtX.Location = new System.Drawing.Point(211, 76);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(50, 20);
            this.txtX.TabIndex = 5;
            this.txtX.Validating += new System.ComponentModel.CancelEventHandler(this.NumerTextValidate);
            // 
            // labHeight
            // 
            this.labHeight.Location = new System.Drawing.Point(277, 106);
            this.labHeight.Name = "labHeight";
            this.labHeight.Size = new System.Drawing.Size(47, 12);
            this.labHeight.TabIndex = 10;
            this.labHeight.Text = "Height:";
            this.labHeight.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labWidth
            // 
            this.labWidth.Location = new System.Drawing.Point(280, 78);
            this.labWidth.Name = "labWidth";
            this.labWidth.Size = new System.Drawing.Size(44, 12);
            this.labWidth.TabIndex = 8;
            this.labWidth.Text = "Width:";
            this.labWidth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labY
            // 
            this.labY.Location = new System.Drawing.Point(188, 106);
            this.labY.Name = "labY";
            this.labY.Size = new System.Drawing.Size(17, 12);
            this.labY.TabIndex = 6;
            this.labY.Text = "Y:";
            // 
            // labX
            // 
            this.labX.Location = new System.Drawing.Point(188, 78);
            this.labX.Name = "labX";
            this.labX.Size = new System.Drawing.Size(17, 12);
            this.labX.TabIndex = 4;
            this.labX.Text = "X:";
            // 
            // chkPreview
            // 
            this.chkPreview.AutoSize = true;
            this.chkPreview.Checked = true;
            this.chkPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPreview.Location = new System.Drawing.Point(15, 130);
            this.chkPreview.Name = "chkPreview";
            this.chkPreview.Size = new System.Drawing.Size(88, 17);
            this.chkPreview.TabIndex = 3;
            this.chkPreview.Text = "Print Preview";
            this.chkPreview.UseVisualStyleBackColor = true;
            // 
            // comboPrintScale
            // 
            this.comboPrintScale.FormattingEnabled = true;
            this.comboPrintScale.Location = new System.Drawing.Point(15, 75);
            this.comboPrintScale.Name = "comboPrintScale";
            this.comboPrintScale.Size = new System.Drawing.Size(120, 21);
            this.comboPrintScale.TabIndex = 1;
            this.comboPrintScale.SelectedIndexChanged += new System.EventHandler(this.comboPrintScale_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(15, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 52);
            this.label1.TabIndex = 13;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // chkGrayScale
            // 
            this.chkGrayScale.AutoSize = true;
            this.chkGrayScale.Location = new System.Drawing.Point(15, 105);
            this.chkGrayScale.Name = "chkGrayScale";
            this.chkGrayScale.Size = new System.Drawing.Size(95, 17);
            this.chkGrayScale.TabIndex = 2;
            this.chkGrayScale.Text = "Use Grayscale";
            this.chkGrayScale.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(152)))), ((int)(((byte)(232)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(15, 153);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(93, 27);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // SingleChartPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.labHeight);
            this.Controls.Add(this.labWidth);
            this.Controls.Add(this.labY);
            this.Controls.Add(this.labX);
            this.Controls.Add(this.chkPreview);
            this.Controls.Add(this.comboPrintScale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkGrayScale);
            this.Controls.Add(this.btnPrint);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SingleChartPrint";
            this.Size = new System.Drawing.Size(541, 212);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkGrayScale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPrintScale;
        private System.Windows.Forms.CheckBox chkPreview;
        private System.Windows.Forms.Label labX;
        private System.Windows.Forms.Label labY;
        private System.Windows.Forms.Label labWidth;
        private System.Windows.Forms.Label labHeight;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
    }
}
