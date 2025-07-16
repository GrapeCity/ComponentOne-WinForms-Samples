namespace C1SpellCheckerSpeed
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
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this._lblNotFound = new System.Windows.Forms.Label();
            this._lblSpeed = new System.Windows.Forms.Label();
            this._lblWords = new System.Windows.Forms.Label();
            this._lblTime = new System.Windows.Forms.Label();
            this.c1SpellChecker1 = new C1.Win.SpellChecker.C1SpellChecker(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1SpellChecker1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Spell-check the King James Bible";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(369, 82);
            this.listBox1.TabIndex = 4;
            // 
            // _lblNotFound
            // 
            this._lblNotFound.AutoSize = true;
            this._lblNotFound.Location = new System.Drawing.Point(9, 115);
            this._lblNotFound.Name = "_lblNotFound";
            this._lblNotFound.Size = new System.Drawing.Size(89, 13);
            this._lblNotFound.TabIndex = 3;
            this._lblNotFound.Text = "Words not found:";
            // 
            // _lblSpeed
            // 
            this._lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblSpeed.AutoSize = true;
            this._lblSpeed.Location = new System.Drawing.Point(9, 268);
            this._lblSpeed.Name = "_lblSpeed";
            this._lblSpeed.Size = new System.Drawing.Size(142, 13);
            this._lblSpeed.TabIndex = 7;
            this._lblSpeed.Text = "Words checked per second:";
            // 
            // _lblWords
            // 
            this._lblWords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblWords.AutoSize = true;
            this._lblWords.Location = new System.Drawing.Point(9, 230);
            this._lblWords.Name = "_lblWords";
            this._lblWords.Size = new System.Drawing.Size(86, 13);
            this._lblWords.TabIndex = 5;
            this._lblWords.Text = "Words checked:";
            // 
            // _lblTime
            // 
            this._lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblTime.AutoSize = true;
            this._lblTime.Location = new System.Drawing.Point(9, 249);
            this._lblTime.Name = "_lblTime";
            this._lblTime.Size = new System.Drawing.Size(73, 13);
            this._lblTime.TabIndex = 6;
            this._lblTime.Text = "Time elapsed:";
            // 
            // c1SpellChecker1
            // 
            this.c1SpellChecker1.Options.Ignore = ((C1.Win.SpellChecker.IgnoreOptions)(((C1.Win.SpellChecker.IgnoreOptions.Numbers | C1.Win.SpellChecker.IgnoreOptions.MixedCase)
                        | C1.Win.SpellChecker.IgnoreOptions.Urls)));
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(369, 27);
            this.button2.TabIndex = 0;
            this.button2.Text = "Spell-check Moby Dick";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(12, 45);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(369, 27);
            this.button3.TabIndex = 1;
            this.button3.Text = "Spell-check the Declaration of Independence";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 290);
            this.Controls.Add(this._lblTime);
            this.Controls.Add(this._lblWords);
            this.Controls.Add(this._lblSpeed);
            this.Controls.Add(this._lblNotFound);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1SpellChecker: the fastest on earth!";
            ((System.ComponentModel.ISupportInitialize)(this.c1SpellChecker1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.SpellChecker.C1SpellChecker c1SpellChecker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label _lblNotFound;
        private System.Windows.Forms.Label _lblSpeed;
        private System.Windows.Forms.Label _lblWords;
        private System.Windows.Forms.Label _lblTime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

