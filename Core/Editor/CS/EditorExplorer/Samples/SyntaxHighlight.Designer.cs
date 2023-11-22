namespace EditorExplorer.Samples
{
    partial class SyntaxHighlight
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
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.c1Editor1 = new C1.Win.Editor.C1Editor();
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Editor1
            // 
            this.c1Editor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.c1Editor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Editor1.Location = new System.Drawing.Point(0, 96);
            this.c1Editor1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c1Editor1.Name = "c1Editor1";
            this.c1Editor1.Size = new System.Drawing.Size(1048, 725);
            this.c1Editor1.TabIndex = 0;
            this.c1Editor1.UserDataFolder = Util.UserDataFolder;
            this.c1Editor1.C1EditorReady += c1Editor1_C1EditorReady;
            // 
            // SyntaxHighlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Editor1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SyntaxHighlight";
            this.Size = new System.Drawing.Size(1048, 821);
            ((System.ComponentModel.ISupportInitialize)(this.c1Editor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Editor.C1Editor c1Editor1;
    }
}