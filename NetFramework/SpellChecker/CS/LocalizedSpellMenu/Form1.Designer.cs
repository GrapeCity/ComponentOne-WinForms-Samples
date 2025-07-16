namespace LocalizedSpellMenu
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
            this.c1SpellChecker1 = new C1.Win.SpellChecker.C1SpellChecker(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1SpellChecker1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1SpellChecker1
            // 
            this.c1SpellChecker1.Options.DialogLanguage = C1.Win.SpellChecker.DialogLanguage.Portuguese;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 20);
            this.c1SpellChecker1.SetSpellChecking(this.textBox1, true);
            this.textBox1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(416, 104);
            this.c1SpellChecker1.SetSpellChecking(this.richTextBox1, true);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(441, 172);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1SpellChecker: Custom context menu";
            ((System.ComponentModel.ISupportInitialize)(this.c1SpellChecker1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.SpellChecker.C1SpellChecker c1SpellChecker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

