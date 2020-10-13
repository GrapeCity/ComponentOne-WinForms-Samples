namespace XlsToJson
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
            this._btnConvert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._buttonCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnConvert
            // 
            this._btnConvert.Location = new System.Drawing.Point(12, 12);
            this._btnConvert.Name = "_btnConvert";
            this._btnConvert.Size = new System.Drawing.Size(164, 46);
            this._btnConvert.TabIndex = 0;
            this._btnConvert.Text = "Select Excel File...";
            this._btnConvert.UseVisualStyleBackColor = true;
            this._btnConvert.Click += new System.EventHandler(this._btnConvert_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(606, 318);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            // 
            // _buttonCopy
            // 
            this._buttonCopy.Enabled = false;
            this._buttonCopy.Location = new System.Drawing.Point(182, 12);
            this._buttonCopy.Name = "_buttonCopy";
            this._buttonCopy.Size = new System.Drawing.Size(210, 46);
            this._buttonCopy.TabIndex = 0;
            this._buttonCopy.Text = "Copy JSON to Clibpoard";
            this._buttonCopy.UseVisualStyleBackColor = true;
            this._buttonCopy.Click += new System.EventHandler(this._buttonCopy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 394);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._buttonCopy);
            this.Controls.Add(this._btnConvert);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XlsToJson";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnConvert;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button _buttonCopy;
    }
}

