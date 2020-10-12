namespace CheckSelectedText
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._spellChecker = new C1.Win.C1SpellChecker.C1SpellChecker(this.components);
            this._textBox = new System.Windows.Forms.TextBox();
            this._btnCheckSelection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._spellChecker)).BeginInit();
            this.SuspendLayout();
            // 
            // _textBox
            // 
            this._textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._textBox.HideSelection = false;
            this._textBox.Location = new System.Drawing.Point(14, 49);
            this._textBox.Multiline = true;
            this._textBox.Name = "_textBox";
            this._textBox.Size = new System.Drawing.Size(461, 239);
            this._textBox.TabIndex = 0;
            this._textBox.Text = resources.GetString("_textBox.Text");
            // 
            // _btnCheckSelection
            // 
            this._btnCheckSelection.Location = new System.Drawing.Point(14, 14);
            this._btnCheckSelection.Name = "_btnCheckSelection";
            this._btnCheckSelection.Size = new System.Drawing.Size(189, 29);
            this._btnCheckSelection.TabIndex = 1;
            this._btnCheckSelection.Text = "Check Selected Text";
            this._btnCheckSelection.UseVisualStyleBackColor = true;
            this._btnCheckSelection.Click += new System.EventHandler(this._btnCheckSelection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 302);
            this.Controls.Add(this._btnCheckSelection);
            this.Controls.Add(this._textBox);
            this.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1SpellChecker: Check selected text";
            ((System.ComponentModel.ISupportInitialize)(this._spellChecker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1SpellChecker.C1SpellChecker _spellChecker;
        private System.Windows.Forms.TextBox _textBox;
        private System.Windows.Forms.Button _btnCheckSelection;
    }
}

