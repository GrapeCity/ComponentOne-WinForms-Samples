namespace CustomDialogs
{
    partial class RowEditorForm
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
            this._gbxAlignment = new System.Windows.Forms.GroupBox();
            this._cbxHorizontalAlignment = new System.Windows.Forms.ComboBox();
            this._cbxVerticalAlignment = new System.Windows.Forms.ComboBox();
            this._lblHorizontalAlignment = new System.Windows.Forms.Label();
            this._lblVerticalAlignment = new System.Windows.Forms.Label();
            this._containerMain.SuspendLayout();
            this._gbxAlignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(213, 286);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(310, 286);
            // 
            // _btnAplly
            // 
            this._btnAplly.Location = new System.Drawing.Point(407, 286);
            // 
            // _containerMain
            // 
            this._containerMain.Controls.Add(this._gbxAlignment);
            this._containerMain.Size = new System.Drawing.Size(486, 268);
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
            this._gbxAlignment.Size = new System.Drawing.Size(480, 75);
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
            this._cbxHorizontalAlignment.Size = new System.Drawing.Size(356, 21);
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
            this._cbxVerticalAlignment.Size = new System.Drawing.Size(356, 21);
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
            // RowEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(510, 323);
            this.MinimumSize = new System.Drawing.Size(518, 174);
            this.Name = "RowEditorForm";
            this.Text = "Row Properties";
            this._containerMain.ResumeLayout(false);
            this._gbxAlignment.ResumeLayout(false);
            this._gbxAlignment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox _gbxAlignment;
        private System.Windows.Forms.ComboBox _cbxHorizontalAlignment;
        private System.Windows.Forms.ComboBox _cbxVerticalAlignment;
        private System.Windows.Forms.Label _lblHorizontalAlignment;
        private System.Windows.Forms.Label _lblVerticalAlignment;


    }
}
