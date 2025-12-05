namespace SeparateControls
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.c1TextBox5 = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox4 = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox3 = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox2 = new C1.Win.C1Input.C1TextBox();
            this.c1TextBox1 = new C1.Win.C1Input.C1TextBox();
            this.dropDownExpression1 = new SeparateControls.DropDownExpression();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Variable 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Variable 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Variable 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Variable 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Variable 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Expression";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Result:";
            // 
            // textResult
            // 
            this.textResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResult.Location = new System.Drawing.Point(72, 149);
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(546, 20);
            this.textResult.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.c1TextBox5);
            this.groupBox1.Controls.Add(this.c1TextBox4);
            this.groupBox1.Controls.Add(this.c1TextBox3);
            this.groupBox1.Controls.Add(this.c1TextBox2);
            this.groupBox1.Controls.Add(this.c1TextBox1);
            this.groupBox1.Controls.Add(this.textResult);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 181);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Enabled = false;
            this.splitter1.Location = new System.Drawing.Point(0, 71);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(630, 3);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dropDownExpression1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(630, 71);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // c1TextBox5
            // 
            this.c1TextBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1TextBox5.Location = new System.Drawing.Point(72, 123);
            this.c1TextBox5.Name = "c1TextBox5";
            this.c1TextBox5.Size = new System.Drawing.Size(546, 18);
            this.c1TextBox5.TabIndex = 17;
            this.c1TextBox5.Tag = null;
            // 
            // c1TextBox4
            // 
            this.c1TextBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1TextBox4.Location = new System.Drawing.Point(72, 97);
            this.c1TextBox4.Name = "c1TextBox4";
            this.c1TextBox4.Size = new System.Drawing.Size(546, 18);
            this.c1TextBox4.TabIndex = 16;
            this.c1TextBox4.Tag = null;
            // 
            // c1TextBox3
            // 
            this.c1TextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1TextBox3.Location = new System.Drawing.Point(72, 71);
            this.c1TextBox3.Name = "c1TextBox3";
            this.c1TextBox3.Size = new System.Drawing.Size(546, 18);
            this.c1TextBox3.TabIndex = 15;
            this.c1TextBox3.Tag = null;
            // 
            // c1TextBox2
            // 
            this.c1TextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1TextBox2.Location = new System.Drawing.Point(72, 45);
            this.c1TextBox2.Name = "c1TextBox2";
            this.c1TextBox2.Size = new System.Drawing.Size(546, 18);
            this.c1TextBox2.TabIndex = 14;
            this.c1TextBox2.Tag = null;
            // 
            // c1TextBox1
            // 
            this.c1TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1TextBox1.Location = new System.Drawing.Point(72, 17);
            this.c1TextBox1.Name = "c1TextBox1";
            this.c1TextBox1.Size = new System.Drawing.Size(546, 18);
            this.c1TextBox1.TabIndex = 12;
            this.c1TextBox1.Tag = null;
            // 
            // dropDownExpression1
            // 
            this.dropDownExpression1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownExpression1.DataSource = null;
            this.dropDownExpression1.Location = new System.Drawing.Point(6, 32);
            this.dropDownExpression1.Name = "dropDownExpression1";
            this.dropDownExpression1.Size = new System.Drawing.Size(612, 33);
            this.dropDownExpression1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 255);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SeparateControls sample";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TextBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DropDownExpression dropDownExpression1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBox2;
        private C1.Win.C1Input.C1TextBox c1TextBox1;
        private C1.Win.C1Input.C1TextBox c1TextBox5;
        private C1.Win.C1Input.C1TextBox c1TextBox4;
        private C1.Win.C1Input.C1TextBox c1TextBox3;
        private C1.Win.C1Input.C1TextBox c1TextBox2;
    }
}

