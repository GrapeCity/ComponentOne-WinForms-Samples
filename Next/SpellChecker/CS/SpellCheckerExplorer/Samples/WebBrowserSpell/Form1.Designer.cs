namespace SpellCheckerExplorer.Samples.WebBrowserSpell
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
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._chkActiveSpelling = new System.Windows.Forms.ToolStripButton();
            this._chkModalSpellCheck = new System.Windows.Forms.ToolStripButton();
            this._webBrowser = new System.Windows.Forms.WebBrowser();
            this._spellChecker = new C1.Win.SpellChecker.C1SpellChecker(this.components);
            this._toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._spellChecker)).BeginInit();
            this.SuspendLayout();
            // 
            // _toolStrip
            // 
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._chkActiveSpelling,
            this._chkModalSpellCheck});
            this._toolStrip.Location = new System.Drawing.Point(0, 0);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(943, 25);
            this._toolStrip.TabIndex = 1;
            this._toolStrip.Text = "toolStrip1";
            // 
            // _chkActiveSpelling
            // 
            this._chkActiveSpelling.Checked = true;
            this._chkActiveSpelling.CheckState = System.Windows.Forms.CheckState.Checked;
            this._chkActiveSpelling.Image = global::SpellCheckerExplorer.Samples.WebBrowserSpell.Properties.Resources.ShowErrors_small;
            this._chkActiveSpelling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._chkActiveSpelling.Name = "_chkActiveSpelling";
            this._chkActiveSpelling.Size = new System.Drawing.Size(156, 22);
            this._chkActiveSpelling.Text = "Show Spelling Errors";
            this._chkActiveSpelling.ToolTipText = "Show spelling errors as you type.";
            this._chkActiveSpelling.Click += new System.EventHandler(this._chkActiveSpelling_Click);
            // 
            // _chkModalSpellCheck
            // 
            this._chkModalSpellCheck.Image = global::SpellCheckerExplorer.Samples.WebBrowserSpell.Properties.Resources.Spelling_small;
            this._chkModalSpellCheck.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._chkModalSpellCheck.Name = "_chkModalSpellCheck";
            this._chkModalSpellCheck.Size = new System.Drawing.Size(100, 22);
            this._chkModalSpellCheck.Text = "Spell-Check";
            this._chkModalSpellCheck.ToolTipText = "Perform a modal spell-check.";
            this._chkModalSpellCheck.Click += new System.EventHandler(this._chkModalSpellCheck_Click);
            // 
            // _webBrowser
            // 
            this._webBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this._webBrowser.Location = new System.Drawing.Point(0, 25);
            this._webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this._webBrowser.Name = "_webBrowser";
            this._webBrowser.Size = new System.Drawing.Size(943, 500);
            this._webBrowser.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(943, 525);
            this.Controls.Add(this._webBrowser);
            this.Controls.Add(this._toolStrip);
            this.Name = "Form1";
            this.Text = "C1SpellChecker works with WebBrowser controls";
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._spellChecker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser _webBrowser;
        private System.Windows.Forms.ToolStrip _toolStrip;
        private C1.Win.SpellChecker.C1SpellChecker _spellChecker;
        private System.Windows.Forms.ToolStripButton _chkActiveSpelling;
        private System.Windows.Forms.ToolStripButton _chkModalSpellCheck;
    }
}

