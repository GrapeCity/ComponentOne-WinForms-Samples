namespace EditorDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.c1EditorRibbon1 = new C1.Win.Editor.C1EditorRibbon();
            this.c1Editor1 = new C1.Win.Editor.C1Editor();
            ((System.ComponentModel.ISupportInitialize)(this.c1EditorRibbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1EditorRibbon1
            // 
            this.c1EditorRibbon1.Editor = this.c1Editor1;
            this.c1EditorRibbon1.Location = new System.Drawing.Point(0, 0);
            this.c1EditorRibbon1.Name = "c1EditorRibbon1";
            this.c1EditorRibbon1.Size = new System.Drawing.Size(1226, 115);
            // 
            // c1Editor1
            // 
            this.c1Editor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1Editor1.DesignEdit = false;
            this.c1Editor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Editor1.Location = new System.Drawing.Point(0, 115);
            this.c1Editor1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1Editor1.Name = "c1Editor1";
            this.c1Editor1.Size = new System.Drawing.Size(1226, 538);
            this.c1Editor1.TabIndex = 2;
            this.c1Editor1.C1EditorReady += new System.EventHandler(this.c1Editor1_C1EditorReady);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1226, 653);
            this.Controls.Add(this.c1Editor1);
            this.Controls.Add(this.c1EditorRibbon1);
            this.Name = "Form1";
            this.Text = "Editor Demo";
            ((System.ComponentModel.ISupportInitialize)(this.c1EditorRibbon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Editor.C1EditorRibbon c1EditorRibbon1;
        private C1.Win.Editor.C1Editor c1Editor1;
    }
}