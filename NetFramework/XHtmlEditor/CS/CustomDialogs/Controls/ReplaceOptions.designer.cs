namespace CustomDialogs
{
    partial class ReplaceOptions
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
            this._lblReplaceWith = new System.Windows.Forms.Label();
            this._tbReplacePattern = new System.Windows.Forms.TextBox();
            this._btnReplaceAll = new System.Windows.Forms.Button();
            this._btnReplace = new System.Windows.Forms.Button();
            this._gbxFindOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tbFindPattern
            // 
            this._tbFindPattern.TextChanged += new System.EventHandler(this._tbFindPattern_TextChanged);
            // 
            // _gbxFindOptions
            // 
            this._gbxFindOptions.TabIndex = 4;
            // 
            // _btnClose
            // 
            this._btnClose.TabIndex = 8;
            // 
            // _btnFindNext
            // 
            this._btnFindNext.TabIndex = 7;
            // 
            // _lblReplaceWith
            // 
            this._lblReplaceWith.AutoSize = true;
            this._lblReplaceWith.Location = new System.Drawing.Point(12, 66);
            this._lblReplaceWith.Name = "_lblReplaceWith";
            this._lblReplaceWith.Size = new System.Drawing.Size(72, 13);
            this._lblReplaceWith.TabIndex = 2;
            this._lblReplaceWith.Text = "Replace w&ith:";
            // 
            // _tbReplacePattern
            // 
            this._tbReplacePattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbReplacePattern.Location = new System.Drawing.Point(90, 63);
            this._tbReplacePattern.Name = "_tbReplacePattern";
            this._tbReplacePattern.Size = new System.Drawing.Size(307, 20);
            this._tbReplacePattern.TabIndex = 3;
            // 
            // _btnReplaceAll
            // 
            this._btnReplaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnReplaceAll.Location = new System.Drawing.Point(112, 210);
            this._btnReplaceAll.Name = "_btnReplaceAll";
            this._btnReplaceAll.Size = new System.Drawing.Size(91, 25);
            this._btnReplaceAll.TabIndex = 6;
            this._btnReplaceAll.Text = "Replace &All";
            this._btnReplaceAll.UseVisualStyleBackColor = true;
            // 
            // _btnReplace
            // 
            this._btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnReplace.Location = new System.Drawing.Point(15, 210);
            this._btnReplace.Name = "_btnReplace";
            this._btnReplace.Size = new System.Drawing.Size(91, 25);
            this._btnReplace.TabIndex = 5;
            this._btnReplace.Text = "&Replace";
            this._btnReplace.UseVisualStyleBackColor = true;
            // 
            // ReplaceOptions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this._tbReplacePattern);
            this.Controls.Add(this._lblReplaceWith);
            this.Controls.Add(this._btnReplaceAll);
            this.Controls.Add(this._btnReplace);
            this.Name = "ReplaceOptions";
            this.Controls.SetChildIndex(this._btnReplace, 0);
            this.Controls.SetChildIndex(this._gbxFindOptions, 0);
            this.Controls.SetChildIndex(this._btnReplaceAll, 0);
            this.Controls.SetChildIndex(this._lblReplaceWith, 0);
            this.Controls.SetChildIndex(this._btnFindNext, 0);
            this.Controls.SetChildIndex(this._btnClose, 0);
            this.Controls.SetChildIndex(this._tbReplacePattern, 0);
            this.Controls.SetChildIndex(this._tbFindPattern, 0);
            this.Controls.SetChildIndex(this._lblFindWhat, 0);
            this._gbxFindOptions.ResumeLayout(false);
            this._gbxFindOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblReplaceWith;
        private System.Windows.Forms.TextBox _tbReplacePattern;
        private System.Windows.Forms.Button _btnReplaceAll;
        private System.Windows.Forms.Button _btnReplace;
    }
}
