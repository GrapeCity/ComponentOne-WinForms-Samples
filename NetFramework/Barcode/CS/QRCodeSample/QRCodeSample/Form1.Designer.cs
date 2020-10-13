namespace QRCodeSample
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.c1QRCode1 = new C1.Win.C1BarCode.C1QRCode();
            this.c1BarCode1 = new C1.Win.C1BarCode.C1BarCode();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(546, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Welcome to C1BarCode (now with QR support).";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // c1QRCode1
            // 
            this.c1QRCode1.BackColor = System.Drawing.Color.Lavender;
            this.c1QRCode1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.c1QRCode1.Location = new System.Drawing.Point(391, 12);
            this.c1QRCode1.Name = "c1QRCode1";
            this.c1QRCode1.Size = new System.Drawing.Size(167, 164);
            this.c1QRCode1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.c1QRCode1.TabIndex = 1;
            this.c1QRCode1.Text = "Welcome! To ComponentOne QR Code!";
            // 
            // c1BarCode1
            // 
            this.c1BarCode1.BackColor = System.Drawing.Color.Lavender;
            this.c1BarCode1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.c1BarCode1.Location = new System.Drawing.Point(12, 12);
            this.c1BarCode1.Name = "c1BarCode1";
            this.c1BarCode1.Size = new System.Drawing.Size(373, 164);
            this.c1BarCode1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.c1BarCode1.TabIndex = 0;
            this.c1BarCode1.Text = "c1BarCode1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Scan this with a scanner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Scan this with your phone";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.c1QRCode1);
            this.Controls.Add(this.c1BarCode1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1QRCode: Compact 2D barcode symbology";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1BarCode.C1BarCode c1BarCode1;
        private C1.Win.C1BarCode.C1QRCode c1QRCode1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

    }
}

