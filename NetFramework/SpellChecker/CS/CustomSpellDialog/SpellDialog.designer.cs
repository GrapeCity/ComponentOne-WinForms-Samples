namespace CustomSpellDialog
{
    partial class SpellDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._txtChangeTo = new System.Windows.Forms.TextBox();
            this._listSuggestions = new System.Windows.Forms.ListBox();
            this._lblNotInDictionary = new System.Windows.Forms.Label();
            this._lblChangeTo = new System.Windows.Forms.Label();
            this._lblSuggestions = new System.Windows.Forms.Label();
            this._btnIgnore = new System.Windows.Forms.Button();
            this._btnChange = new System.Windows.Forms.Button();
            this._btnAdd = new System.Windows.Forms.Button();
            this._btnIgnoreAll = new System.Windows.Forms.Button();
            this._btnChangeAll = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtError = new System.Windows.Forms.TextBox();
            this._lblRepeatedWord = new System.Windows.Forms.Label();
            this._lblNoSuggestions = new System.Windows.Forms.Label();
            this._lblChange = new System.Windows.Forms.Label();
            this._lblRemove = new System.Windows.Forms.Label();
            this._btnSuggest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtChangeTo
            // 
            this._txtChangeTo.Location = new System.Drawing.Point(113, 30);
            this._txtChangeTo.Name = "_txtChangeTo";
            this._txtChangeTo.Size = new System.Drawing.Size(159, 20);
            this._txtChangeTo.TabIndex = 1;
            this._txtChangeTo.TextChanged += new System.EventHandler(this._txtChangeTo_TextChanged);
            // 
            // _listSuggestions
            // 
            this._listSuggestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this._listSuggestions.FormattingEnabled = true;
            this._listSuggestions.IntegralHeight = false;
            this._listSuggestions.Location = new System.Drawing.Point(113, 56);
            this._listSuggestions.Name = "_listSuggestions";
            this._listSuggestions.Size = new System.Drawing.Size(159, 117);
            this._listSuggestions.TabIndex = 3;
            this._listSuggestions.DoubleClick += new System.EventHandler(this._listSuggestions_DoubleClick);
            this._listSuggestions.SelectedIndexChanged += new System.EventHandler(this._listSuggestions_SelectedIndexChanged);
            // 
            // _lblNotInDictionary
            // 
            this._lblNotInDictionary.AutoSize = true;
            this._lblNotInDictionary.Location = new System.Drawing.Point(4, 7);
            this._lblNotInDictionary.Name = "_lblNotInDictionary";
            this._lblNotInDictionary.Size = new System.Drawing.Size(88, 13);
            this._lblNotInDictionary.TabIndex = 16;
            this._lblNotInDictionary.Text = "Not in Dictionary:";
            // 
            // _lblChangeTo
            // 
            this._lblChangeTo.AutoSize = true;
            this._lblChangeTo.Location = new System.Drawing.Point(4, 33);
            this._lblChangeTo.Name = "_lblChangeTo";
            this._lblChangeTo.Size = new System.Drawing.Size(63, 13);
            this._lblChangeTo.TabIndex = 0;
            this._lblChangeTo.Text = "Change &To:";
            // 
            // _lblSuggestions
            // 
            this._lblSuggestions.AutoSize = true;
            this._lblSuggestions.Location = new System.Drawing.Point(4, 62);
            this._lblSuggestions.Name = "_lblSuggestions";
            this._lblSuggestions.Size = new System.Drawing.Size(68, 13);
            this._lblSuggestions.TabIndex = 2;
            this._lblSuggestions.Text = "Suggestio&ns:";
            // 
            // _btnIgnore
            // 
            this._btnIgnore.Location = new System.Drawing.Point(278, 56);
            this._btnIgnore.Name = "_btnIgnore";
            this._btnIgnore.Size = new System.Drawing.Size(95, 25);
            this._btnIgnore.TabIndex = 4;
            this._btnIgnore.Text = "&Ignore";
            this._btnIgnore.UseVisualStyleBackColor = true;
            this._btnIgnore.Click += new System.EventHandler(this._btnIgnore_Click);
            // 
            // _btnChange
            // 
            this._btnChange.Location = new System.Drawing.Point(278, 84);
            this._btnChange.Name = "_btnChange";
            this._btnChange.Size = new System.Drawing.Size(95, 25);
            this._btnChange.TabIndex = 6;
            this._btnChange.Text = "&Change";
            this._btnChange.UseVisualStyleBackColor = true;
            this._btnChange.Click += new System.EventHandler(this._btnChange_Click);
            // 
            // _btnAdd
            // 
            this._btnAdd.Location = new System.Drawing.Point(278, 112);
            this._btnAdd.Name = "_btnAdd";
            this._btnAdd.Size = new System.Drawing.Size(95, 25);
            this._btnAdd.TabIndex = 8;
            this._btnAdd.Text = "&Add";
            this._btnAdd.UseVisualStyleBackColor = true;
            this._btnAdd.Click += new System.EventHandler(this._btnAdd_Click);
            // 
            // _btnIgnoreAll
            // 
            this._btnIgnoreAll.Location = new System.Drawing.Point(382, 56);
            this._btnIgnoreAll.Name = "_btnIgnoreAll";
            this._btnIgnoreAll.Size = new System.Drawing.Size(95, 25);
            this._btnIgnoreAll.TabIndex = 5;
            this._btnIgnoreAll.Text = "I&gnore All";
            this._btnIgnoreAll.UseVisualStyleBackColor = true;
            this._btnIgnoreAll.Click += new System.EventHandler(this._btnIgnoreAll_Click);
            // 
            // _btnChangeAll
            // 
            this._btnChangeAll.Location = new System.Drawing.Point(382, 84);
            this._btnChangeAll.Name = "_btnChangeAll";
            this._btnChangeAll.Size = new System.Drawing.Size(95, 25);
            this._btnChangeAll.TabIndex = 7;
            this._btnChangeAll.Text = "Change A&ll";
            this._btnChangeAll.UseVisualStyleBackColor = true;
            this._btnChangeAll.Click += new System.EventHandler(this._btnChangeAll_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(382, 189);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(95, 25);
            this._btnCancel.TabIndex = 15;
            this._btnCancel.Text = "&Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this._btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(7, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 2);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // _txtError
            // 
            this._txtError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._txtError.Location = new System.Drawing.Point(113, 4);
            this._txtError.Name = "_txtError";
            this._txtError.ReadOnly = true;
            this._txtError.Size = new System.Drawing.Size(364, 20);
            this._txtError.TabIndex = 17;
            // 
            // _lblRepeatedWord
            // 
            this._lblRepeatedWord.AutoSize = true;
            this._lblRepeatedWord.Location = new System.Drawing.Point(4, 195);
            this._lblRepeatedWord.Name = "_lblRepeatedWord";
            this._lblRepeatedWord.Size = new System.Drawing.Size(83, 13);
            this._lblRepeatedWord.TabIndex = 11;
            this._lblRepeatedWord.Text = "Repeated word:";
            this._lblRepeatedWord.Visible = false;
            // 
            // _lblNoSuggestions
            // 
            this._lblNoSuggestions.AutoSize = true;
            this._lblNoSuggestions.Location = new System.Drawing.Point(93, 195);
            this._lblNoSuggestions.Name = "_lblNoSuggestions";
            this._lblNoSuggestions.Size = new System.Drawing.Size(84, 13);
            this._lblNoSuggestions.TabIndex = 12;
            this._lblNoSuggestions.Text = "(no suggestions)";
            this._lblNoSuggestions.Visible = false;
            // 
            // _lblChange
            // 
            this._lblChange.AutoSize = true;
            this._lblChange.Location = new System.Drawing.Point(183, 195);
            this._lblChange.Name = "_lblChange";
            this._lblChange.Size = new System.Drawing.Size(44, 13);
            this._lblChange.TabIndex = 13;
            this._lblChange.Text = "&Change";
            this._lblChange.Visible = false;
            // 
            // _lblRemove
            // 
            this._lblRemove.AutoSize = true;
            this._lblRemove.Location = new System.Drawing.Point(236, 195);
            this._lblRemove.Name = "_lblRemove";
            this._lblRemove.Size = new System.Drawing.Size(47, 13);
            this._lblRemove.TabIndex = 14;
            this._lblRemove.Text = "&Remove";
            this._lblRemove.Visible = false;
            // 
            // _btnSuggest
            // 
            this._btnSuggest.Location = new System.Drawing.Point(382, 112);
            this._btnSuggest.Name = "_btnSuggest";
            this._btnSuggest.Size = new System.Drawing.Size(95, 25);
            this._btnSuggest.TabIndex = 9;
            this._btnSuggest.Text = "&Suggest";
            this._btnSuggest.UseVisualStyleBackColor = true;
            this._btnSuggest.Click += new System.EventHandler(this._btnSuggest_Click);
            // 
            // SpellDialog
            // 
            this.AcceptButton = this._btnIgnore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(489, 222);
            this.Controls.Add(this._lblRemove);
            this.Controls.Add(this._lblChange);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._btnAdd);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSuggest);
            this.Controls.Add(this._btnChangeAll);
            this.Controls.Add(this._btnIgnoreAll);
            this.Controls.Add(this._btnChange);
            this.Controls.Add(this._btnIgnore);
            this.Controls.Add(this._lblSuggestions);
            this.Controls.Add(this._lblChangeTo);
            this.Controls.Add(this._lblNoSuggestions);
            this.Controls.Add(this._lblRepeatedWord);
            this.Controls.Add(this._lblNotInDictionary);
            this.Controls.Add(this._listSuggestions);
            this.Controls.Add(this._txtError);
            this.Controls.Add(this._txtChangeTo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SpellDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spelling";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox _listSuggestions;
        private System.Windows.Forms.Label _lblNotInDictionary;
        private System.Windows.Forms.Label _lblChangeTo;
        private System.Windows.Forms.Label _lblSuggestions;
        private System.Windows.Forms.Button _btnIgnore;
        private System.Windows.Forms.Button _btnChange;
        private System.Windows.Forms.Button _btnAdd;
        private System.Windows.Forms.Button _btnIgnoreAll;
        private System.Windows.Forms.Button _btnChangeAll;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox _txtError;
        private System.Windows.Forms.Label _lblRepeatedWord;
        private System.Windows.Forms.Label _lblNoSuggestions;
        private System.Windows.Forms.Label _lblChange;
        private System.Windows.Forms.Label _lblRemove;
        private System.Windows.Forms.Button _btnSuggest;
        private System.Windows.Forms.TextBox _txtChangeTo;

    }
}