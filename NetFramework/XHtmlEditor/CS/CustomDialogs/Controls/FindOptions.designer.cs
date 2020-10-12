namespace CustomDialogs
{
    partial class FindOptions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._lblFindWhat = new System.Windows.Forms.Label();
            this._tbFindPattern = new System.Windows.Forms.TextBox();
            this._btnClose = new System.Windows.Forms.Button();
            this._btnFindNext = new System.Windows.Forms.Button();
            this._gbxFindOptions = new System.Windows.Forms.GroupBox();
            this._chbSearchUp = new System.Windows.Forms.CheckBox();
            this._chbMatchWholeWord = new System.Windows.Forms.CheckBox();
            this._chbMatchCase = new System.Windows.Forms.CheckBox();
            this._gbxFindOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblFindWhat
            // 
            this._lblFindWhat.AutoSize = true;
            this._lblFindWhat.Location = new System.Drawing.Point(12, 27);
            this._lblFindWhat.Name = "_lblFindWhat";
            this._lblFindWhat.Size = new System.Drawing.Size(56, 13);
            this._lblFindWhat.TabIndex = 0;
            this._lblFindWhat.Text = "Fi&nd what:";
            // 
            // _tbFindPattern
            // 
            this._tbFindPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._tbFindPattern.Location = new System.Drawing.Point(90, 24);
            this._tbFindPattern.Name = "_tbFindPattern";
            this._tbFindPattern.Size = new System.Drawing.Size(307, 20);
            this._tbFindPattern.TabIndex = 1;
            this._tbFindPattern.TextChanged += new System.EventHandler(this._tbFindPattern_TextChanged);
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnClose.Location = new System.Drawing.Point(306, 210);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(91, 25);
            this._btnClose.TabIndex = 4;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            // 
            // _btnFindNext
            // 
            this._btnFindNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnFindNext.Location = new System.Drawing.Point(209, 210);
            this._btnFindNext.Name = "_btnFindNext";
            this._btnFindNext.Size = new System.Drawing.Size(91, 25);
            this._btnFindNext.TabIndex = 3;
            this._btnFindNext.Text = "Find &Next";
            this._btnFindNext.UseVisualStyleBackColor = true;
            // 
            // _gbxFindOptions
            // 
            this._gbxFindOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._gbxFindOptions.Controls.Add(this._chbSearchUp);
            this._gbxFindOptions.Controls.Add(this._chbMatchWholeWord);
            this._gbxFindOptions.Controls.Add(this._chbMatchCase);
            this._gbxFindOptions.Location = new System.Drawing.Point(15, 107);
            this._gbxFindOptions.Name = "_gbxFindOptions";
            this._gbxFindOptions.Size = new System.Drawing.Size(382, 97);
            this._gbxFindOptions.TabIndex = 2;
            this._gbxFindOptions.TabStop = false;
            this._gbxFindOptions.Text = "Find options";
            // 
            // _chbSearchUp
            // 
            this._chbSearchUp.AutoSize = true;
            this._chbSearchUp.Location = new System.Drawing.Point(6, 65);
            this._chbSearchUp.Name = "_chbSearchUp";
            this._chbSearchUp.Size = new System.Drawing.Size(75, 17);
            this._chbSearchUp.TabIndex = 2;
            this._chbSearchUp.Text = "Search &up";
            this._chbSearchUp.UseVisualStyleBackColor = true;
            // 
            // _chbMatchWholeWord
            // 
            this._chbMatchWholeWord.AutoSize = true;
            this._chbMatchWholeWord.Location = new System.Drawing.Point(6, 42);
            this._chbMatchWholeWord.Name = "_chbMatchWholeWord";
            this._chbMatchWholeWord.Size = new System.Drawing.Size(137, 17);
            this._chbMatchWholeWord.TabIndex = 1;
            this._chbMatchWholeWord.Text = "Match whole word onl&y";
            this._chbMatchWholeWord.UseVisualStyleBackColor = true;
            // 
            // _chbMatchCase
            // 
            this._chbMatchCase.AutoSize = true;
            this._chbMatchCase.Location = new System.Drawing.Point(6, 19);
            this._chbMatchCase.Name = "_chbMatchCase";
            this._chbMatchCase.Size = new System.Drawing.Size(82, 17);
            this._chbMatchCase.TabIndex = 0;
            this._chbMatchCase.Text = "Matc&h case";
            this._chbMatchCase.UseVisualStyleBackColor = true;
            // 
            // FindOptions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this._lblFindWhat);
            this.Controls.Add(this._tbFindPattern);
            this.Controls.Add(this._btnClose);
            this.Controls.Add(this._btnFindNext);
            this.Controls.Add(this._gbxFindOptions);
            this.MinimumSize = new System.Drawing.Size(409, 247);
            this.Name = "FindOptions";
            this.Size = new System.Drawing.Size(409, 247);
            this._gbxFindOptions.ResumeLayout(false);
            this._gbxFindOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label _lblFindWhat;
        protected System.Windows.Forms.TextBox _tbFindPattern;
        protected System.Windows.Forms.GroupBox _gbxFindOptions;
        protected System.Windows.Forms.CheckBox _chbSearchUp;
        protected System.Windows.Forms.CheckBox _chbMatchWholeWord;
        protected System.Windows.Forms.CheckBox _chbMatchCase;
        protected System.Windows.Forms.Button _btnClose;
        protected System.Windows.Forms.Button _btnFindNext;

    }
}
