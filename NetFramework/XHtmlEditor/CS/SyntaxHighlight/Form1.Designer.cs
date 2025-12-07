namespace SyntaxHighlight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.c1Editor1 = new C1.Win.C1Editor.C1Editor();
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Editor1
            // 
            this.c1Editor1.BackColor = System.Drawing.SystemColors.Window;
            this.c1Editor1.XmlExtensions = null;
            this.c1Editor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Editor1.Location = new System.Drawing.Point(0, 0);
            this.c1Editor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.c1Editor1.Name = "c1Editor1";
            this.c1Editor1.WordWrap = true;
            this.c1Editor1.Size = new System.Drawing.Size(617, 446);
            this.c1Editor1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 446);
            this.Controls.Add(this.c1Editor1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Editor: Syntax highlighting";
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Editor.C1Editor c1Editor1;
    }
}

