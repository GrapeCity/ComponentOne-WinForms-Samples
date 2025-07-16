namespace CustomSpellDialog
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSpellCheck = new System.Windows.Forms.Button();
            this.c1SpellChecker1 = new C1.Win.SpellChecker.C1SpellChecker(this.components);
            this.btnSpellCheckCustom = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1SpellChecker1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(347, 349);
            this.c1SpellChecker1.SetSpellChecking(this.textBox1, true);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(733, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status
            // 
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(38, 17);
            this.status.Text = "Ready";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(366, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(347, 348);
            this.c1SpellChecker1.SetSpellChecking(this.richTextBox1, true);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            this.richTextBox1.Enter += new System.EventHandler(this.richTextBox1_Enter);
            // 
            // btnSpellCheck
            // 
            this.btnSpellCheck.Location = new System.Drawing.Point(12, 367);
            this.btnSpellCheck.Name = "btnSpellCheck";
            this.btnSpellCheck.Size = new System.Drawing.Size(213, 27);
            this.btnSpellCheck.TabIndex = 2;
            this.btnSpellCheck.Text = "Spell-Check with Word Dialog";
            this.btnSpellCheck.UseVisualStyleBackColor = true;
            this.btnSpellCheck.Click += new System.EventHandler(this.btnSpellCheck_Click);
            // 
            // c1SpellChecker1
            // 
            this.c1SpellChecker1.BadWordFound += new C1.Win.SpellChecker.BadWordEventHandler(this.c1SpellChecker1_BadWordFound);
            // 
            // btnSpellCheckCustom
            // 
            this.btnSpellCheckCustom.Location = new System.Drawing.Point(231, 367);
            this.btnSpellCheckCustom.Name = "btnSpellCheckCustom";
            this.btnSpellCheckCustom.Size = new System.Drawing.Size(213, 27);
            this.btnSpellCheckCustom.TabIndex = 2;
            this.btnSpellCheckCustom.Text = "Spell-Check with Sentence Dialog";
            this.btnSpellCheckCustom.UseVisualStyleBackColor = true;
            this.btnSpellCheckCustom.Click += new System.EventHandler(this.btnSpellCheckCustom_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 422);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSpellCheckCustom);
            this.Controls.Add(this.btnSpellCheck);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Spell: Custom Spell Dialogs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1SpellChecker1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel status;
        private C1.Win.SpellChecker.C1SpellChecker c1SpellChecker1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSpellCheck;
        private System.Windows.Forms.Button btnSpellCheckCustom;
    }
}

