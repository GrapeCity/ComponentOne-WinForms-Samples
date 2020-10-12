namespace CustomDialogs
{
    partial class CellEditorForm
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
            this._nudColSpan = new System.Windows.Forms.NumericUpDown();
            this._nudRowSpan = new System.Windows.Forms.NumericUpDown();
            this._lblRowSpan = new System.Windows.Forms.Label();
            this._lblColSpan = new System.Windows.Forms.Label();
            this._chbHeader = new System.Windows.Forms.CheckBox();
            this._gbxAlignment = new System.Windows.Forms.GroupBox();
            this._cbxHorizontalAlignment = new System.Windows.Forms.ComboBox();
            this._cbxVerticalAlignment = new System.Windows.Forms.ComboBox();
            this._lblHorizontalAlignment = new System.Windows.Forms.Label();
            this._lblVerticalAlignment = new System.Windows.Forms.Label();
            this._containerMain.SuspendLayout();
            this._gbxSpan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudColSpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudRowSpan)).BeginInit();
            this._gbxAlignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(216, 242);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(313, 242);
            // 
            // _btnAplly
            // 
            this._btnAplly.Location = new System.Drawing.Point(410, 242);
            // 
            // _containerMain
            // 
            this._containerMain.Controls.Add(this._gbxSpan);
            this._containerMain.Controls.Add(this._chbHeader);
            this._containerMain.Controls.Add(this._gbxAlignment);
            this._containerMain.Size = new System.Drawing.Size(489, 224);
            // 
            // _gbxSpan
            // 
            this._gbxSpan.Controls.Add(this._nudColSpan);
            this._gbxSpan.Controls.Add(this._nudRowSpan);
            this._gbxSpan.Controls.Add(this._lblRowSpan);
            this._gbxSpan.Controls.Add(this._lblColSpan);
            this._gbxSpan.Dock = System.Windows.Forms.DockStyle.Top;
            this._gbxSpan.Location = new System.Drawing.Point(3, 92);
            this._gbxSpan.Name = "_gbxSpan";
            this._gbxSpan.Size = new System.Drawing.Size(483, 75);
            this._gbxSpan.TabIndex = 1;
            this._gbxSpan.TabStop = false;
            this._gbxSpan.Text = "Span";
            // 
            // _nudColSpan
            // 
            this._nudColSpan.Location = new System.Drawing.Point(118, 20);
            this._nudColSpan.Name = "_nudColSpan";
            this._nudColSpan.Size = new System.Drawing.Size(95, 21);
            this._nudColSpan.TabIndex = 1;
            // 
            // _nudRowSpan
            // 
            this._nudRowSpan.Location = new System.Drawing.Point(118, 47);
            this._nudRowSpan.Name = "_nudRowSpan";
            this._nudRowSpan.Size = new System.Drawing.Size(95, 21);
            this._nudRowSpan.TabIndex = 3;
            // 
            // _lblRowSpan
            // 
            this._lblRowSpan.AutoSize = true;
            this._lblRowSpan.Location = new System.Drawing.Point(17, 49);
            this._lblRowSpan.Name = "_lblRowSpan";
            this._lblRowSpan.Size = new System.Drawing.Size(32, 13);
            this._lblRowSpan.TabIndex = 2;
            this._lblRowSpan.Text = "&Row:";
            // 
            // _lblColSpan
            // 
            this._lblColSpan.AutoSize = true;
            this._lblColSpan.Location = new System.Drawing.Point(17, 22);
            this._lblColSpan.Name = "_lblColSpan";
            this._lblColSpan.Size = new System.Drawing.Size(46, 13);
            this._lblColSpan.TabIndex = 0;
            this._lblColSpan.Text = "&Column:";
            // 
            // _chbHeader
            // 
            this._chbHeader.AutoSize = true;
            this._chbHeader.Location = new System.Drawing.Point(20, 176);
            this._chbHeader.Name = "_chbHeader";
            this._chbHeader.Size = new System.Drawing.Size(61, 17);
            this._chbHeader.TabIndex = 2;
            this._chbHeader.Text = "Hea&der";
            this._chbHeader.UseVisualStyleBackColor = true;
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
            this._gbxAlignment.Size = new System.Drawing.Size(483, 75);
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
            this._cbxHorizontalAlignment.Size = new System.Drawing.Size(359, 21);
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
            this._cbxVerticalAlignment.Size = new System.Drawing.Size(359, 21);
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
            // CellEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(513, 279);
            this.MinimumSize = new System.Drawing.Size(521, 174);
            this.Name = "CellEditorForm";
            this.Text = "Cell Properties";
            this._containerMain.ResumeLayout(false);
            this._containerMain.PerformLayout();
            this._gbxSpan.ResumeLayout(false);
            this._gbxSpan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._nudColSpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._nudRowSpan)).EndInit();
            this._gbxAlignment.ResumeLayout(false);
            this._gbxAlignment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _gbxSpan;
        private System.Windows.Forms.NumericUpDown _nudColSpan;
        private System.Windows.Forms.NumericUpDown _nudRowSpan;
        private System.Windows.Forms.Label _lblRowSpan;
        private System.Windows.Forms.Label _lblColSpan;
        private System.Windows.Forms.CheckBox _chbHeader;
        private System.Windows.Forms.GroupBox _gbxAlignment;
        private System.Windows.Forms.ComboBox _cbxHorizontalAlignment;
        private System.Windows.Forms.ComboBox _cbxVerticalAlignment;
        private System.Windows.Forms.Label _lblHorizontalAlignment;
        private System.Windows.Forms.Label _lblVerticalAlignment;

    }
}
