namespace CustomDialogs
{
    partial class FormattingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Disposes of the resources (other than memory) used by the System.Windows.Forms.Form.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._cbInvisible = new System.Windows.Forms.CheckBox();
            this._cbBold = new System.Windows.Forms.CheckBox();
            this._cbItalic = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._rbNone = new System.Windows.Forms.RadioButton();
            this._rbUnderline = new System.Windows.Forms.RadioButton();
            this._rbStrikeout = new System.Windows.Forms.RadioButton();
            this._rbOverline = new System.Windows.Forms.RadioButton();
            this._tbSize = new System.Windows.Forms.TextBox();
            this._tbTextColor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._cbFontFamily = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(160, 220);
            this.btnOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 26);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(247, 220);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 26);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this._tbSize);
            this.groupBox1.Controls.Add(this._tbTextColor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._cbFontFamily);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(323, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font properties";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "&Size:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this._cbInvisible);
            this.groupBox3.Controls.Add(this._cbBold);
            this.groupBox3.Controls.Add(this._cbItalic);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Location = new System.Drawing.Point(7, 80);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(146, 113);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Effects ";
            // 
            // _cbInvisible
            // 
            this._cbInvisible.AutoSize = true;
            this._cbInvisible.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._cbInvisible.Location = new System.Drawing.Point(23, 67);
            this._cbInvisible.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._cbInvisible.Name = "_cbInvisible";
            this._cbInvisible.Size = new System.Drawing.Size(70, 18);
            this._cbInvisible.TabIndex = 2;
            this._cbInvisible.Text = "&In&visible";
            this._cbInvisible.UseVisualStyleBackColor = true;
            // 
            // _cbBold
            // 
            this._cbBold.AutoSize = true;
            this._cbBold.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._cbBold.Location = new System.Drawing.Point(23, 22);
            this._cbBold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._cbBold.Name = "_cbBold";
            this._cbBold.Size = new System.Drawing.Size(53, 18);
            this._cbBold.TabIndex = 0;
            this._cbBold.Text = "&Bold";
            this._cbBold.UseVisualStyleBackColor = true;
            // 
            // _cbItalic
            // 
            this._cbItalic.AutoSize = true;
            this._cbItalic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._cbItalic.Location = new System.Drawing.Point(23, 44);
            this._cbItalic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._cbItalic.Name = "_cbItalic";
            this._cbItalic.Size = new System.Drawing.Size(54, 18);
            this._cbItalic.TabIndex = 1;
            this._cbItalic.Text = "&Italic";
            this._cbItalic.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._rbNone);
            this.groupBox2.Controls.Add(this._rbUnderline);
            this.groupBox2.Controls.Add(this._rbStrikeout);
            this.groupBox2.Controls.Add(this._rbOverline);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox2.Location = new System.Drawing.Point(167, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(146, 113);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " Text decoration ";
            // 
            // _rbNone
            // 
            this._rbNone.AutoSize = true;
            this._rbNone.Checked = true;
            this._rbNone.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._rbNone.Location = new System.Drawing.Point(21, 88);
            this._rbNone.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._rbNone.Name = "_rbNone";
            this._rbNone.Size = new System.Drawing.Size(57, 18);
            this._rbNone.TabIndex = 3;
            this._rbNone.TabStop = true;
            this._rbNone.Text = "&None";
            this._rbNone.UseVisualStyleBackColor = true;
            // 
            // _rbUnderline
            // 
            this._rbUnderline.AutoSize = true;
            this._rbUnderline.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._rbUnderline.Location = new System.Drawing.Point(20, 66);
            this._rbUnderline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._rbUnderline.Name = "_rbUnderline";
            this._rbUnderline.Size = new System.Drawing.Size(76, 18);
            this._rbUnderline.TabIndex = 2;
            this._rbUnderline.Text = "&Underline";
            this._rbUnderline.UseVisualStyleBackColor = true;
            // 
            // _rbStrikeout
            // 
            this._rbStrikeout.AutoSize = true;
            this._rbStrikeout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._rbStrikeout.Location = new System.Drawing.Point(21, 44);
            this._rbStrikeout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._rbStrikeout.Name = "_rbStrikeout";
            this._rbStrikeout.Size = new System.Drawing.Size(73, 18);
            this._rbStrikeout.TabIndex = 1;
            this._rbStrikeout.Text = "Stri&kethrough";
            this._rbStrikeout.UseVisualStyleBackColor = true;
            // 
            // _rbOverline
            // 
            this._rbOverline.AutoSize = true;
            this._rbOverline.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._rbOverline.Location = new System.Drawing.Point(21, 22);
            this._rbOverline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._rbOverline.Name = "_rbOverline";
            this._rbOverline.Size = new System.Drawing.Size(70, 18);
            this._rbOverline.TabIndex = 0;
            this._rbOverline.Text = "&Overline";
            this._rbOverline.UseVisualStyleBackColor = true;
            // 
            // _tbSize
            // 
            this._tbSize.Location = new System.Drawing.Point(77, 50);
            this._tbSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._tbSize.Name = "_tbSize";
            this._tbSize.Size = new System.Drawing.Size(76, 20);
            this._tbSize.TabIndex = 3;
            // 
            // _cpTextColor
            // 
            this._tbTextColor.Location = new System.Drawing.Point(223, 50);
            this._tbTextColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._tbTextColor.Name = "_tbTextColor";
            this._tbTextColor.Size = new System.Drawing.Size(92, 21);
            this._tbTextColor.TabIndex = 5;
            this._tbTextColor.Validated += new System.EventHandler(_tbTextColor_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Location = new System.Drawing.Point(165, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Text &color:";
            // 
            // _cbFontFamily
            // 
            this._cbFontFamily.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._cbFontFamily.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._cbFontFamily.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._cbFontFamily.FormattingEnabled = true;
            this._cbFontFamily.Location = new System.Drawing.Point(77, 20);
            this._cbFontFamily.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this._cbFontFamily.Name = "_cbFontFamily";
            this._cbFontFamily.Size = new System.Drawing.Size(237, 21);
            this._cbFontFamily.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Font &family:";
            // 
            // FormattingForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(343, 255);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormattingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formatting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox _cbItalic;
        private System.Windows.Forms.CheckBox _cbBold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbTextColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _cbFontFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _tbSize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton _rbOverline;
        private System.Windows.Forms.RadioButton _rbNone;
        private System.Windows.Forms.RadioButton _rbUnderline;
        private System.Windows.Forms.RadioButton _rbStrikeout;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox _cbInvisible;
    }
}