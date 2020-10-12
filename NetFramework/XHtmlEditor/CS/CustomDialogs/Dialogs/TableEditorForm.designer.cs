namespace CustomDialogs
{
    partial class TableEditorForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._tbSummary = new System.Windows.Forms.TextBox();
            this._tbCaption = new System.Windows.Forms.TextBox();
            this._lblSummary = new System.Windows.Forms.Label();
            this._lblCaption = new System.Windows.Forms.Label();
            this._gbxSize = new System.Windows.Forms.GroupBox();
            this._tbWidthValue = new System.Windows.Forms.NumericUpDown();
            this._chkWidth = new System.Windows.Forms.CheckBox();
            this.lblColumnCount = new System.Windows.Forms.Label();
            this._cbxWidthType = new System.Windows.Forms.ComboBox();
            this._lblRowCount = new System.Windows.Forms.Label();
            this._nudColumnCount = new System.Windows.Forms.NumericUpDown();
            this._nudRowCount = new System.Windows.Forms.NumericUpDown();
            this._gbxAlignment = new System.Windows.Forms.GroupBox();
            this._lblCellPadding = new System.Windows.Forms.Label();
            this._lblCellSpacing = new System.Windows.Forms.Label();
            this._nudCellPadding = new System.Windows.Forms.NumericUpDown();
            this._nudCellSpacing = new System.Windows.Forms.NumericUpDown();
            this._gbxBorder = new System.Windows.Forms.GroupBox();
            this._nudBorder = new System.Windows.Forms.NumericUpDown();
            this._lblBorder = new System.Windows.Forms.Label();
            this._containerMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this._gbxSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbWidthValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudColumnCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudRowCount)).BeginInit();
            this._gbxAlignment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudCellPadding)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudCellSpacing)).BeginInit();
            this._gbxBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudBorder)).BeginInit();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(256, 340);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(353, 340);
            // 
            // _btnAplly
            // 
            this._btnAplly.Location = new System.Drawing.Point(450, 340);
            // 
            // _containerMain
            // 
            this._containerMain.Controls.Add(this._gbxBorder);
            this._containerMain.Controls.Add(this._gbxAlignment);
            this._containerMain.Controls.Add(this._gbxSize);
            this._containerMain.Controls.Add(this.panel1);
            this._containerMain.Size = new System.Drawing.Size(529, 322);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._tbSummary);
            this.panel1.Controls.Add(this._tbCaption);
            this.panel1.Controls.Add(this._lblSummary);
            this.panel1.Controls.Add(this._lblCaption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 67);
            this.panel1.TabIndex = 0;
            // 
            // _tbSummary
            // 
            this._tbSummary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbSummary.Location = new System.Drawing.Point(74, 36);
            this._tbSummary.Name = "_tbSummary";
            this._tbSummary.Size = new System.Drawing.Size(440, 21);
            this._tbSummary.TabIndex = 3;
            // 
            // _tbCaption
            // 
            this._tbCaption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbCaption.Location = new System.Drawing.Point(74, 9);
            this._tbCaption.Name = "_tbCaption";
            this._tbCaption.Size = new System.Drawing.Size(440, 21);
            this._tbCaption.TabIndex = 1;
            // 
            // _lblSummary
            // 
            this._lblSummary.AutoSize = true;
            this._lblSummary.Location = new System.Drawing.Point(17, 39);
            this._lblSummary.Name = "_lblSummary";
            this._lblSummary.Size = new System.Drawing.Size(55, 13);
            this._lblSummary.TabIndex = 2;
            this._lblSummary.Text = "S&ummary:";
            // 
            // _lblCaption
            // 
            this._lblCaption.AutoSize = true;
            this._lblCaption.Location = new System.Drawing.Point(24, 12);
            this._lblCaption.Name = "_lblCaption";
            this._lblCaption.Size = new System.Drawing.Size(48, 13);
            this._lblCaption.TabIndex = 0;
            this._lblCaption.Text = "C&aption:";
            // 
            // _gbxSize
            // 
            this._gbxSize.Controls.Add(this._tbWidthValue);
            this._gbxSize.Controls.Add(this._chkWidth);
            this._gbxSize.Controls.Add(this.lblColumnCount);
            this._gbxSize.Controls.Add(this._cbxWidthType);
            this._gbxSize.Controls.Add(this._lblRowCount);
            this._gbxSize.Controls.Add(this._nudColumnCount);
            this._gbxSize.Controls.Add(this._nudRowCount);
            this._gbxSize.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbxSize.Location = new System.Drawing.Point(3, 84);
            this._gbxSize.Name = "_gbxSize";
            this._gbxSize.Size = new System.Drawing.Size(523, 103);
            this._gbxSize.TabIndex = 1;
            this._gbxSize.TabStop = false;
            this._gbxSize.Text = "Size";
            // 
            // _tbWidthValue
            // 
            this._tbWidthValue.Location = new System.Drawing.Point(125, 74);
            this._tbWidthValue.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this._tbWidthValue.Name = "_tbWidthValue";
            this._tbWidthValue.Size = new System.Drawing.Size(95, 21);
            this._tbWidthValue.TabIndex = 5;
            // 
            // _chkWidth
            // 
            this._chkWidth.AutoSize = true;
            this._chkWidth.Checked = true;
            this._chkWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkWidth.Location = new System.Drawing.Point(20, 75);
            this._chkWidth.Name = "_chkWidth";
            this._chkWidth.Size = new System.Drawing.Size(94, 17);
            this._chkWidth.TabIndex = 4;
            this._chkWidth.Text = "Specify &width:";
            this._chkWidth.UseVisualStyleBackColor = true;
            // 
            // lblColumnCount
            // 
            this.lblColumnCount.AutoSize = true;
            this.lblColumnCount.Location = new System.Drawing.Point(17, 22);
            this.lblColumnCount.Name = "lblColumnCount";
            this.lblColumnCount.Size = new System.Drawing.Size(102, 13);
            this.lblColumnCount.TabIndex = 0;
            this.lblColumnCount.Text = "Number of &columns:";
            // 
            // _cbxWidthType
            // 
            this._cbxWidthType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._cbxWidthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbxWidthType.FormattingEnabled = true;
            this._cbxWidthType.Location = new System.Drawing.Point(224, 74);
            this._cbxWidthType.Name = "_cbxWidthType";
            this._cbxWidthType.Size = new System.Drawing.Size(290, 21);
            this._cbxWidthType.TabIndex = 6;
            // 
            // _lblRowCount
            // 
            this._lblRowCount.AutoSize = true;
            this._lblRowCount.Location = new System.Drawing.Point(17, 49);
            this._lblRowCount.Name = "_lblRowCount";
            this._lblRowCount.Size = new System.Drawing.Size(87, 13);
            this._lblRowCount.TabIndex = 2;
            this._lblRowCount.Text = "Number of &rows:";
            // 
            // _nudColumnCount
            // 
            this._nudColumnCount.Location = new System.Drawing.Point(125, 20);
            this._nudColumnCount.Name = "_nudColumnCount";
            this._nudColumnCount.Size = new System.Drawing.Size(95, 21);
            this._nudColumnCount.TabIndex = 1;
            // 
            // _nudRowCount
            // 
            this._nudRowCount.Location = new System.Drawing.Point(125, 47);
            this._nudRowCount.Name = "_nudRowCount";
            this._nudRowCount.Size = new System.Drawing.Size(95, 21);
            this._nudRowCount.TabIndex = 3;
            // 
            // _gbxAlignment
            // 
            this._gbxAlignment.Controls.Add(this._lblCellPadding);
            this._gbxAlignment.Controls.Add(this._lblCellSpacing);
            this._gbxAlignment.Controls.Add(this._nudCellPadding);
            this._gbxAlignment.Controls.Add(this._nudCellSpacing);
            this._gbxAlignment.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbxAlignment.Location = new System.Drawing.Point(3, 187);
            this._gbxAlignment.Name = "_gbxAlignment";
            this._gbxAlignment.Size = new System.Drawing.Size(523, 77);
            this._gbxAlignment.TabIndex = 2;
            this._gbxAlignment.TabStop = false;
            this._gbxAlignment.Text = "Alignment";
            // 
            // _lblCellPadding
            // 
            this._lblCellPadding.AutoSize = true;
            this._lblCellPadding.Location = new System.Drawing.Point(17, 49);
            this._lblCellPadding.Name = "_lblCellPadding";
            this._lblCellPadding.Size = new System.Drawing.Size(69, 13);
            this._lblCellPadding.TabIndex = 2;
            this._lblCellPadding.Text = "Cell &padding:";
            // 
            // _lblCellSpacing
            // 
            this._lblCellSpacing.AutoSize = true;
            this._lblCellSpacing.Location = new System.Drawing.Point(17, 22);
            this._lblCellSpacing.Name = "_lblCellSpacing";
            this._lblCellSpacing.Size = new System.Drawing.Size(67, 13);
            this._lblCellSpacing.TabIndex = 0;
            this._lblCellSpacing.Text = "Cell &spacing:";
            // 
            // _nudCellPadding
            // 
            this._nudCellPadding.Location = new System.Drawing.Point(125, 47);
            this._nudCellPadding.Name = "_nudCellPadding";
            this._nudCellPadding.Size = new System.Drawing.Size(95, 21);
            this._nudCellPadding.TabIndex = 3;
            // 
            // _nudCellSpacing
            // 
            this._nudCellSpacing.Location = new System.Drawing.Point(125, 20);
            this._nudCellSpacing.Name = "_nudCellSpacing";
            this._nudCellSpacing.Size = new System.Drawing.Size(95, 21);
            this._nudCellSpacing.TabIndex = 1;
            // 
            // _gbxBorder
            // 
            this._gbxBorder.Controls.Add(this._nudBorder);
            this._gbxBorder.Controls.Add(this._lblBorder);
            this._gbxBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbxBorder.Location = new System.Drawing.Point(3, 264);
            this._gbxBorder.Name = "_gbxBorder";
            this._gbxBorder.Size = new System.Drawing.Size(523, 49);
            this._gbxBorder.TabIndex = 3;
            this._gbxBorder.TabStop = false;
            this._gbxBorder.Text = "Border";
            // 
            // _nudBorder
            // 
            this._nudBorder.Location = new System.Drawing.Point(125, 20);
            this._nudBorder.Name = "_nudBorder";
            this._nudBorder.Size = new System.Drawing.Size(95, 21);
            this._nudBorder.TabIndex = 1;
            // 
            // _lblBorder
            // 
            this._lblBorder.AutoSize = true;
            this._lblBorder.Location = new System.Drawing.Point(17, 22);
            this._lblBorder.Name = "_lblBorder";
            this._lblBorder.Size = new System.Drawing.Size(39, 13);
            this._lblBorder.TabIndex = 0;
            this._lblBorder.Text = "Wi&dth:";
            // 
            // TableEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(553, 377);
            this.MinimumSize = new System.Drawing.Size(561, 174);
            this.Name = "TableEditorForm";
            this.Text = "Table Properties";
            this._containerMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._gbxSize.ResumeLayout(false);
            this._gbxSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._tbWidthValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudColumnCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudRowCount)).EndInit();
            this._gbxAlignment.ResumeLayout(false);
            this._gbxAlignment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudCellPadding)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudCellSpacing)).EndInit();
            this._gbxBorder.ResumeLayout(false);
            this._gbxBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudBorder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox _gbxBorder;
        private System.Windows.Forms.NumericUpDown _nudBorder;
        private System.Windows.Forms.Label _lblBorder;
        private System.Windows.Forms.GroupBox _gbxAlignment;
        private System.Windows.Forms.Label _lblCellPadding;
        private System.Windows.Forms.Label _lblCellSpacing;
        private System.Windows.Forms.NumericUpDown _nudCellPadding;
        private System.Windows.Forms.NumericUpDown _nudCellSpacing;
        private System.Windows.Forms.GroupBox _gbxSize;
        private System.Windows.Forms.NumericUpDown _tbWidthValue;
        private System.Windows.Forms.CheckBox _chkWidth;
        private System.Windows.Forms.Label lblColumnCount;
        private System.Windows.Forms.ComboBox _cbxWidthType;
        private System.Windows.Forms.Label _lblRowCount;
        private System.Windows.Forms.NumericUpDown _nudColumnCount;
        private System.Windows.Forms.NumericUpDown _nudRowCount;
        private System.Windows.Forms.TextBox _tbSummary;
        private System.Windows.Forms.TextBox _tbCaption;
        private System.Windows.Forms.Label _lblSummary;
        private System.Windows.Forms.Label _lblCaption;

    }
}
