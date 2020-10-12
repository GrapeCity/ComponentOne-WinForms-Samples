namespace ControlExplorer.Barcode
{
    partial class BarCodeTypesSample
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
            this.c1BarCode1 = new C1.Win.BarCode.C1BarCode();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1BarCode1
            // 
            this.c1BarCode1.AdditionalNumber = null;
            this.c1BarCode1.BackColor = System.Drawing.SystemColors.Control;
            this.c1BarCode1.CodeType = C1.BarCode.CodeType.QRCode;
            this.c1BarCode1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1BarCode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.c1BarCode1.ForeColor = System.Drawing.Color.Black;
            this.c1BarCode1.Location = new System.Drawing.Point(0, 52);
            this.c1BarCode1.MicroQRCodeOptions.EncodingCodePage = 65001;
            this.c1BarCode1.Name = "c1BarCode1";
            this.c1BarCode1.QuietZone.Bottom = 10D;
            this.c1BarCode1.QuietZone.Left = 10D;
            this.c1BarCode1.QuietZone.Right = 10D;
            this.c1BarCode1.QuietZone.Top = 10D;
            this.c1BarCode1.Size = new System.Drawing.Size(963, 544);
            this.c1BarCode1.TabIndex = 1;
            this.c1BarCode1.Text = "C1BarCode: explore barcode types";
            this.c1BarCode1.TextFixedLength = 0;
            this.c1BarCode1.WideToNarrowRatio = 2F;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(46, 16);
            this.textBox1.MaxLength = 4296;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1212, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "C1BarCode: explore barcode types";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(3, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Value:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(963, 52);
            this.panel1.TabIndex = 6;
            // 
            // BarCodeTypesSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 596);
            this.Controls.Add(this.c1BarCode1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BarCodeTypesSample";
            this.Text = "BarCodeTypesSample";
            this.Load += new System.EventHandler(this.BarCodeTypesSample_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.BarCode.C1BarCode c1BarCode1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}