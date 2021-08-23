namespace TestBarCode {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbText = new System.Windows.Forms.TextBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.cbCodeType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComposite = new System.Windows.Forms.Button();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.btnCode39 = new System.Windows.Forms.Button();
            this.btnDataMatrix = new System.Windows.Forms.Button();
            this.btnQRcode = new System.Windows.Forms.Button();
            this.btnPdf417 = new System.Windows.Forms.Button();
            this.c1BarCode1 = new C1.Win.BarCode.C1BarCode();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbText
            // 
            this.tbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbText.Location = new System.Drawing.Point(19, 97);
            this.tbText.Margin = new System.Windows.Forms.Padding(4);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(500, 30);
            this.tbText.TabIndex = 2;
            this.tbText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(561, 0);
            this.propertyGrid1.Margin = new System.Windows.Forms.Padding(4);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(504, 885);
            this.propertyGrid1.TabIndex = 4;
            // 
            // cbCodeType
            // 
            this.cbCodeType.DropDownHeight = 500;
            this.cbCodeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCodeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCodeType.FormattingEnabled = true;
            this.cbCodeType.IntegralHeight = false;
            this.cbCodeType.Location = new System.Drawing.Point(17, 37);
            this.cbCodeType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCodeType.Name = "cbCodeType";
            this.cbCodeType.Size = new System.Drawing.Size(501, 33);
            this.cbCodeType.TabIndex = 0;
            this.cbCodeType.SelectedIndexChanged += new System.EventHandler(this.cbCodeType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CodeType:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Templates:";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.c1BarCode1);
            this.panel1.Controls.Add(this.btnComposite);
            this.panel1.Controls.Add(this.cbCodeType);
            this.panel1.Controls.Add(this.btnRotateRight);
            this.panel1.Controls.Add(this.btnRotateLeft);
            this.panel1.Controls.Add(this.tbText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnCode39);
            this.panel1.Controls.Add(this.btnDataMatrix);
            this.panel1.Controls.Add(this.btnQRcode);
            this.panel1.Controls.Add(this.btnPdf417);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 885);
            this.panel1.TabIndex = 17;
            // 
            // btnComposite
            // 
            this.btnComposite.FlatAppearance.BorderSize = 0;
            this.btnComposite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComposite.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnComposite.ForeColor = System.Drawing.Color.Black;
            this.btnComposite.Image = global::TestBarCode.Properties.Resources.composite;
            this.btnComposite.Location = new System.Drawing.Point(425, 159);
            this.btnComposite.Margin = new System.Windows.Forms.Padding(0);
            this.btnComposite.Name = "btnComposite";
            this.btnComposite.Size = new System.Drawing.Size(109, 133);
            this.btnComposite.TabIndex = 17;
            this.btnComposite.Text = "Composite";
            this.btnComposite.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnComposite.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnComposite.UseVisualStyleBackColor = true;
            this.btnComposite.Click += new System.EventHandler(this.TemplateButton_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.BackgroundImage = global::TestBarCode.Properties.Resources.Rotate_right_arrow1;
            this.btnRotateRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRotateRight.Location = new System.Drawing.Point(259, 817);
            this.btnRotateRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(40, 39);
            this.btnRotateRight.TabIndex = 15;
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.BackgroundImage = global::TestBarCode.Properties.Resources.Rotate_left_arrow;
            this.btnRotateLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRotateLeft.Location = new System.Drawing.Point(213, 817);
            this.btnRotateLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(40, 39);
            this.btnRotateLeft.TabIndex = 14;
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // btnCode39
            // 
            this.btnCode39.FlatAppearance.BorderSize = 0;
            this.btnCode39.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCode39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCode39.ForeColor = System.Drawing.Color.Black;
            this.btnCode39.Image = global::TestBarCode.Properties.Resources.code39;
            this.btnCode39.Location = new System.Drawing.Point(9, 158);
            this.btnCode39.Margin = new System.Windows.Forms.Padding(0);
            this.btnCode39.Name = "btnCode39";
            this.btnCode39.Size = new System.Drawing.Size(109, 133);
            this.btnCode39.TabIndex = 9;
            this.btnCode39.Text = "Code39";
            this.btnCode39.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCode39.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCode39.UseVisualStyleBackColor = true;
            this.btnCode39.Click += new System.EventHandler(this.TemplateButton_Click);
            // 
            // btnDataMatrix
            // 
            this.btnDataMatrix.FlatAppearance.BorderSize = 0;
            this.btnDataMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDataMatrix.ForeColor = System.Drawing.Color.Black;
            this.btnDataMatrix.Image = global::TestBarCode.Properties.Resources.datematrix;
            this.btnDataMatrix.Location = new System.Drawing.Point(321, 159);
            this.btnDataMatrix.Margin = new System.Windows.Forms.Padding(0);
            this.btnDataMatrix.Name = "btnDataMatrix";
            this.btnDataMatrix.Size = new System.Drawing.Size(109, 133);
            this.btnDataMatrix.TabIndex = 12;
            this.btnDataMatrix.Text = "DataMatrix";
            this.btnDataMatrix.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDataMatrix.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDataMatrix.UseVisualStyleBackColor = true;
            this.btnDataMatrix.Click += new System.EventHandler(this.TemplateButton_Click);
            // 
            // btnQRcode
            // 
            this.btnQRcode.FlatAppearance.BorderSize = 0;
            this.btnQRcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQRcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnQRcode.ForeColor = System.Drawing.Color.Black;
            this.btnQRcode.Image = global::TestBarCode.Properties.Resources.qrcode;
            this.btnQRcode.Location = new System.Drawing.Point(113, 159);
            this.btnQRcode.Margin = new System.Windows.Forms.Padding(0);
            this.btnQRcode.Name = "btnQRcode";
            this.btnQRcode.Size = new System.Drawing.Size(109, 133);
            this.btnQRcode.TabIndex = 10;
            this.btnQRcode.Text = "QRcode";
            this.btnQRcode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQRcode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnQRcode.UseVisualStyleBackColor = true;
            this.btnQRcode.Click += new System.EventHandler(this.TemplateButton_Click);
            // 
            // btnPdf417
            // 
            this.btnPdf417.FlatAppearance.BorderSize = 0;
            this.btnPdf417.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPdf417.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPdf417.ForeColor = System.Drawing.Color.Black;
            this.btnPdf417.Image = global::TestBarCode.Properties.Resources.pdf417;
            this.btnPdf417.Location = new System.Drawing.Point(217, 159);
            this.btnPdf417.Margin = new System.Windows.Forms.Padding(0);
            this.btnPdf417.Name = "btnPdf417";
            this.btnPdf417.Size = new System.Drawing.Size(109, 133);
            this.btnPdf417.TabIndex = 11;
            this.btnPdf417.Text = "Pdf417";
            this.btnPdf417.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPdf417.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPdf417.UseVisualStyleBackColor = true;
            this.btnPdf417.Click += new System.EventHandler(this.TemplateButton_Click);
            // 
            // c1BarCode1
            // 
            this.c1BarCode1.AdditionalNumber = null;
            this.c1BarCode1.BackColor = System.Drawing.Color.White;
            this.c1BarCode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.c1BarCode1.ForeColor = System.Drawing.Color.Black;
            this.c1BarCode1.Location = new System.Drawing.Point(34, 294);
            this.c1BarCode1.Name = "c1BarCode1";
            this.c1BarCode1.QuietZone.Bottom = 10D;
            this.c1BarCode1.QuietZone.Left = 10D;
            this.c1BarCode1.QuietZone.Right = 10D;
            this.c1BarCode1.QuietZone.Top = 10D;
            this.c1BarCode1.Size = new System.Drawing.Size(500, 500);
            this.c1BarCode1.TabIndex = 18;
            this.c1BarCode1.Text = "c1BarCode1";
            this.c1BarCode1.TextFixedLength = 0;
            this.c1BarCode1.CaptionPosition = C1.BarCode.BarCodeCaptionPosition.Below;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1065, 885);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.propertyGrid1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestBarCode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.ComboBox cbCodeType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCode39;
        private System.Windows.Forms.Button btnQRcode;
        private System.Windows.Forms.Button btnPdf417;
        private System.Windows.Forms.Button btnDataMatrix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRotateLeft;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnComposite;
        private C1.Win.BarCode.C1BarCode c1BarCode1;


    }
}

