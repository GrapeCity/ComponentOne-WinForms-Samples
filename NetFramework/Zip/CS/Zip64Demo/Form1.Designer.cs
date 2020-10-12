namespace Zip64Demo
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
            this._btnOneBigFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._BtnManySmallFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnOneBigFile
            // 
            this._btnOneBigFile.Location = new System.Drawing.Point(12, 12);
            this._btnOneBigFile.Name = "_btnOneBigFile";
            this._btnOneBigFile.Size = new System.Drawing.Size(107, 38);
            this._btnOneBigFile.TabIndex = 0;
            this._btnOneBigFile.Text = "One Big File";
            this._btnOneBigFile.UseVisualStyleBackColor = true;
            this._btnOneBigFile.Click += new System.EventHandler(this._btnOneBigFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ready";
            // 
            // _BtnManySmallFiles
            // 
            this._BtnManySmallFiles.Location = new System.Drawing.Point(125, 12);
            this._BtnManySmallFiles.Name = "_BtnManySmallFiles";
            this._BtnManySmallFiles.Size = new System.Drawing.Size(107, 38);
            this._BtnManySmallFiles.TabIndex = 0;
            this._BtnManySmallFiles.Text = "Many Small Files";
            this._BtnManySmallFiles.UseVisualStyleBackColor = true;
            this._BtnManySmallFiles.Click += new System.EventHandler(this._btnManyFiles_Click_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 128);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._BtnManySmallFiles);
            this.Controls.Add(this._btnOneBigFile);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1Zip: Zip64 Support for Huge files (>4 gig)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnOneBigFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _BtnManySmallFiles;
    }
}

