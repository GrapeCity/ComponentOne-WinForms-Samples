namespace TXTextSpellCheckerDemo
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
            this._spell = new C1.Win.C1SpellChecker.C1SpellChecker(this.components);
            this.statusBar1 = new TXTextControl.StatusBar();
            this.buttonBar1 = new TXTextControl.ButtonBar();
            this.rulerBar1 = new TXTextControl.RulerBar();
            this._txText = new TXTextSpellCheckerDemo.TXTextSpellChecker();
            ((System.ComponentModel.ISupportInitialize)(this._spell)).BeginInit();
            this.SuspendLayout();
            // 
            // statusBar1
            // 
            this.statusBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusBar1.Location = new System.Drawing.Point(0, 339);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Size = new System.Drawing.Size(724, 22);
            this.statusBar1.TabIndex = 1;
            // 
            // buttonBar1
            // 
            this.buttonBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBar1.Location = new System.Drawing.Point(0, 0);
            this.buttonBar1.Name = "buttonBar1";
            this.buttonBar1.Size = new System.Drawing.Size(724, 28);
            this.buttonBar1.TabIndex = 2;
            this.buttonBar1.Text = "buttonBar1";
            // 
            // rulerBar1
            // 
            this.rulerBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rulerBar1.Location = new System.Drawing.Point(0, 28);
            this.rulerBar1.Name = "rulerBar1";
            this.rulerBar1.Size = new System.Drawing.Size(724, 25);
            this.rulerBar1.TabIndex = 3;
            this.rulerBar1.Text = "rulerBar1";
            // 
            // _txText
            // 
            this._txText.BorderStyle = TXTextControl.BorderStyle.None;
            this._txText.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txText.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._txText.IgnoreChanges = false;
            this._txText.Location = new System.Drawing.Point(0, 53);
            this._txText.Margin = new System.Windows.Forms.Padding(4);
            this._txText.Name = "_txText";
            this._txText.PageMargins.Bottom = 79;
            this._txText.PageMargins.Left = 79;
            this._txText.PageMargins.Right = 79;
            this._txText.PageMargins.Top = 79;
            this._txText.Size = new System.Drawing.Size(724, 286);
            this._txText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 361);
            this.Controls.Add(this._txText);
            this.Controls.Add(this.rulerBar1);
            this.Controls.Add(this.buttonBar1);
            this.Controls.Add(this.statusBar1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1SpellChecker working with a TXTextEditor";
            ((System.ComponentModel.ISupportInitialize)(this._spell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1SpellChecker.C1SpellChecker _spell;
        private TXTextSpellChecker _txText;
        private TXTextControl.StatusBar statusBar1;
        private TXTextControl.ButtonBar buttonBar1;
        private TXTextControl.RulerBar rulerBar1;
    }
}

