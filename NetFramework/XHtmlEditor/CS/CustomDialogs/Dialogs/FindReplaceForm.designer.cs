namespace CustomDialogs
{
    partial class FindReplaceForm
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
            this._tbcFindReplace = new System.Windows.Forms.TabControl();
            this._tpgFind = new System.Windows.Forms.TabPage();
            this._findOption = new CustomDialogs.FindOptions();
            this._tpgReplace = new System.Windows.Forms.TabPage();
            this._replaceOption = new CustomDialogs.ReplaceOptions();
            this._tbcFindReplace.SuspendLayout();
            this._tpgFind.SuspendLayout();
            this._tpgReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // _tbcFindReplace
            // 
            this._tbcFindReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tbcFindReplace.Location = new System.Drawing.Point(0, 0);
            this._tbcFindReplace.Name = "_tbcFindReplace";
            this._tbcFindReplace.SelectedIndex = 0;
            this._tbcFindReplace.Size = new System.Drawing.Size(499, 281);
            this._tbcFindReplace.TabIndex = 5;
            this._tbcFindReplace.TabPages.Add(this._tpgFind);
            this._tbcFindReplace.TabPages.Add(this._tpgReplace);
            this._tbcFindReplace.SelectedIndexChanged += new System.EventHandler(this.ChangeMode);
            // 
            // _tpgFind
            // 
            this._tpgFind.BackColor = System.Drawing.SystemColors.Window;
            this._tpgFind.Controls.Add(this._findOption);
            this._tpgFind.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tpgFind.Location = new System.Drawing.Point(1, 19);
            this._tpgFind.Name = "_tpgFind";
            this._tpgFind.Padding = new System.Windows.Forms.Padding(3);
            this._tpgFind.Size = new System.Drawing.Size(497, 261);
            this._tpgFind.TabIndex = 0;
            this._tpgFind.Text = "Find";
            this._tpgFind.Visible = false;
            // 
            // _findOption
            // 
            this._findOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this._findOption.Location = new System.Drawing.Point(3, 3);
            this._findOption.MatchCase = false;
            this._findOption.MatchWholeWord = false;
            this._findOption.MinimumSize = new System.Drawing.Size(409, 247);
            this._findOption.Name = "_findOption";
            this._findOption.SearchPattern = "";
            this._findOption.SearchUp = false;
            this._findOption.Size = new System.Drawing.Size(491, 255);
            this._findOption.TabIndex = 0;
            // 
            // _tpgReplace
            // 
            this._tpgReplace.BackColor = System.Drawing.SystemColors.Window;
            this._tpgReplace.Controls.Add(this._replaceOption);
            this._tpgReplace.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tpgReplace.Location = new System.Drawing.Point(1, 19);
            this._tpgReplace.Name = "_tpgReplace";
            this._tpgReplace.Padding = new System.Windows.Forms.Padding(3);
            this._tpgReplace.Size = new System.Drawing.Size(497, 261);
            this._tpgReplace.TabIndex = 1;
            this._tpgReplace.Text = "Replace";
            this._tpgReplace.Visible = false;
            // 
            // _replaceOption
            // 
            this._replaceOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this._replaceOption.Location = new System.Drawing.Point(3, 3);
            this._replaceOption.MatchCase = false;
            this._replaceOption.MatchWholeWord = false;
            this._replaceOption.MinimumSize = new System.Drawing.Size(409, 247);
            this._replaceOption.Name = "_replaceOption";
            this._replaceOption.SearchPattern = "";
            this._replaceOption.SearchUp = false;
            this._replaceOption.Size = new System.Drawing.Size(491, 255);
            this._replaceOption.TabIndex = 0;
            // 
            // FindReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 281);
            this.Controls.Add(this._tbcFindReplace);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(432, 317);
            this.Name = "FindReplaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find and Replace";
            this._tbcFindReplace.ResumeLayout(false);
            this._tpgFind.ResumeLayout(false);
            this._tpgReplace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl _tbcFindReplace;
        private System.Windows.Forms.TabPage _tpgFind;
        private System.Windows.Forms.TabPage _tpgReplace;
        private CustomDialogs.FindOptions _findOption;
        private CustomDialogs.ReplaceOptions _replaceOption;
    }
}