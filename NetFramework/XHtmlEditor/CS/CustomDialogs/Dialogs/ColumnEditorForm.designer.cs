namespace CustomDialogs
{
    partial class ColumnEditorForm
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
            this._gbxSpan = new System.Windows.Forms.GroupBox();
            this._nudSpan = new System.Windows.Forms.NumericUpDown();
            this._lblSpan = new System.Windows.Forms.Label();
            this._gbxWidth = new System.Windows.Forms.GroupBox();
            this._tbWidthValue = new System.Windows.Forms.NumericUpDown();
            this._chkWidth = new System.Windows.Forms.CheckBox();
            this._cbxWidthType = new System.Windows.Forms.ComboBox();
            this._gbxAlignment = new System.Windows.Forms.GroupBox();
            this._cbxHorizontalAlignment = new System.Windows.Forms.ComboBox();
            this._cbxVerticalAlignment = new System.Windows.Forms.ComboBox();
            this._lblHorizontalAlignment = new System.Windows.Forms.Label();
            this._lblVerticalAlignment = new System.Windows.Forms.Label();
            this._containerMain.SuspendLayout();
            this._gbxSpan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSpan)).BeginInit();
            this._gbxWidth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbWidthValue)).BeginInit();
            this._gbxAlignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(255, 286);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(352, 286);
            // 
            // _btnAplly
            // 
            this._btnAplly.Location = new System.Drawing.Point(449, 286);
            // 
            // _containerMain
            // 
            this._containerMain.Controls.Add(this._gbxSpan);
            this._containerMain.Controls.Add(this._gbxWidth);
            this._containerMain.Controls.Add(this._gbxAlignment);
            this._containerMain.Size = new System.Drawing.Size(529, 268);
            // 
            // _gbxSpan
            // 
            this._gbxSpan.Controls.Add(this._nudSpan);
            this._gbxSpan.Controls.Add(this._lblSpan);
            this._gbxSpan.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbxSpan.Location = new System.Drawing.Point(3, 143);
            this._gbxSpan.Name = "_gbxSpan";
            this._gbxSpan.Size = new System.Drawing.Size(523, 52);
            this._gbxSpan.TabIndex = 2;
            this._gbxSpan.TabStop = false;
            this._gbxSpan.Text = "Span";
            // 
            // _nudSpan
            // 
            this._nudSpan.Location = new System.Drawing.Point(118, 20);
            this._nudSpan.Name = "_nudSpan";
            this._nudSpan.Size = new System.Drawing.Size(95, 21);
            this._nudSpan.TabIndex = 1;
            // 
            // _lblSpan
            // 
            this._lblSpan.AutoSize = true;
            this._lblSpan.Location = new System.Drawing.Point(17, 22);
            this._lblSpan.Name = "_lblSpan";
            this._lblSpan.Size = new System.Drawing.Size(46, 13);
            this._lblSpan.TabIndex = 0;
            this._lblSpan.Text = "&Column:";
            // 
            // _gbxWidth
            // 
            this._gbxWidth.Controls.Add(this._tbWidthValue);
            this._gbxWidth.Controls.Add(this._chkWidth);
            this._gbxWidth.Controls.Add(this._cbxWidthType);
            this._gbxWidth.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbxWidth.Location = new System.Drawing.Point(3, 92);
            this._gbxWidth.Name = "_gbxWidth";
            this._gbxWidth.Size = new System.Drawing.Size(523, 51);
            this._gbxWidth.TabIndex = 1;
            this._gbxWidth.TabStop = false;
            this._gbxWidth.Text = "Size";
            // 
            // _tbWidthValue
            // 
            this._tbWidthValue.Location = new System.Drawing.Point(118, 19);
            this._tbWidthValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._tbWidthValue.Name = "_tbWidthValue";
            this._tbWidthValue.Size = new System.Drawing.Size(95, 21);
            this._tbWidthValue.TabIndex = 1;
            this._tbWidthValue.ThousandsSeparator = true;
            // 
            // _chkWidth
            // 
            this._chkWidth.AutoSize = true;
            this._chkWidth.Checked = true;
            this._chkWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkWidth.Location = new System.Drawing.Point(20, 20);
            this._chkWidth.Name = "_chkWidth";
            this._chkWidth.Size = new System.Drawing.Size(94, 17);
            this._chkWidth.TabIndex = 0;
            this._chkWidth.Text = "Specify &width:";
            this._chkWidth.UseVisualStyleBackColor = true;
            // 
            // _cbxWidthType
            // 
            this._cbxWidthType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._cbxWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxWidthType.FormattingEnabled = true;
            this._cbxWidthType.Location = new System.Drawing.Point(219, 18);
            this._cbxWidthType.Name = "_cbxWidthType";
            this._cbxWidthType.Size = new System.Drawing.Size(291, 21);
            this._cbxWidthType.TabIndex = 2;
            // 
            // _gbxAlignment
            // 
            this._gbxAlignment.Controls.Add(this._cbxHorizontalAlignment);
            this._gbxAlignment.Controls.Add(this._cbxVerticalAlignment);
            this._gbxAlignment.Controls.Add(this._lblHorizontalAlignment);
            this._gbxAlignment.Controls.Add(this._lblVerticalAlignment);
            this._gbxAlignment.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbxAlignment.Location = new System.Drawing.Point(3, 17);
            this._gbxAlignment.Name = "_gbxAlignment";
            this._gbxAlignment.Size = new System.Drawing.Size(523, 75);
            this._gbxAlignment.TabIndex = 0;
            this._gbxAlignment.TabStop = false;
            this._gbxAlignment.Text = "Alignment";
            // 
            // _cbxHorizontalAlignment
            // 
            this._cbxHorizontalAlignment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._cbxHorizontalAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxHorizontalAlignment.FormattingEnabled = true;
            this._cbxHorizontalAlignment.Location = new System.Drawing.Point(118, 46);
            this._cbxHorizontalAlignment.Name = "_cbxHorizontalAlignment";
            this._cbxHorizontalAlignment.Size = new System.Drawing.Size(399, 21);
            this._cbxHorizontalAlignment.TabIndex = 3;
            // 
            // _cbxVerticalAlignment
            // 
            this._cbxVerticalAlignment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._cbxVerticalAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxVerticalAlignment.FormattingEnabled = true;
            this._cbxVerticalAlignment.Location = new System.Drawing.Point(118, 19);
            this._cbxVerticalAlignment.Name = "_cbxVerticalAlignment";
            this._cbxVerticalAlignment.Size = new System.Drawing.Size(399, 21);
            this._cbxVerticalAlignment.TabIndex = 1;
            // 
            // _lblHorizontalAlignment
            // 
            this._lblHorizontalAlignment.AutoSize = true;
            this._lblHorizontalAlignment.Location = new System.Drawing.Point(17, 49);
            this._lblHorizontalAlignment.Name = "_lblHorizontalAlignment";
            this._lblHorizontalAlignment.Size = new System.Drawing.Size(59, 13);
            this._lblHorizontalAlignment.TabIndex = 2;
            this._lblHorizontalAlignment.Text = "&Horizontal:";
            // 
            // _lblVerticalAlignment
            // 
            this._lblVerticalAlignment.AutoSize = true;
            this._lblVerticalAlignment.Location = new System.Drawing.Point(17, 22);
            this._lblVerticalAlignment.Name = "_lblVerticalAlignment";
            this._lblVerticalAlignment.Size = new System.Drawing.Size(46, 13);
            this._lblVerticalAlignment.TabIndex = 0;
            this._lblVerticalAlignment.Text = "&Vertical:";
            // 
            // ColumnEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(553, 323);
            this.MinimumSize = new System.Drawing.Size(561, 174);
            this.Name = "ColumnEditorForm";
            this.Text = "Column Properties";
            this._containerMain.ResumeLayout(false);
            this._gbxSpan.ResumeLayout(false);
            this._gbxSpan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudSpan)).EndInit();
            this._gbxWidth.ResumeLayout(false);
            this._gbxWidth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbWidthValue)).EndInit();
            this._gbxAlignment.ResumeLayout(false);
            this._gbxAlignment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _gbxSpan;
        private System.Windows.Forms.NumericUpDown _nudSpan;
        private System.Windows.Forms.Label _lblSpan;
        private System.Windows.Forms.GroupBox _gbxWidth;
        private System.Windows.Forms.ComboBox _cbxWidthType;
        private System.Windows.Forms.GroupBox _gbxAlignment;
        private System.Windows.Forms.ComboBox _cbxHorizontalAlignment;
        private System.Windows.Forms.ComboBox _cbxVerticalAlignment;
        private System.Windows.Forms.Label _lblHorizontalAlignment;
        private System.Windows.Forms.Label _lblVerticalAlignment;
        private System.Windows.Forms.CheckBox _chkWidth;
        private System.Windows.Forms.NumericUpDown _tbWidthValue;

    }
}
