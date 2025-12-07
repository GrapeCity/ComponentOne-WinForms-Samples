using System.Windows.Forms;

namespace InputExplorer.Samples.DropDowns
{
    partial class CreditCards
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCards));
            radioButton1 = new System.Windows.Forms.RadioButton();
            radioButton2 = new System.Windows.Forms.RadioButton();
            radioButton3 = new System.Windows.Forms.RadioButton();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            radioButton4 = new System.Windows.Forms.RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.Checked = true;
            radioButton1.Location = new System.Drawing.Point(128, 16);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new System.Drawing.Size(192, 53);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Visa";
            // 
            // radioButton2
            // 
            radioButton2.Location = new System.Drawing.Point(128, 65);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new System.Drawing.Size(192, 53);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Master Card";
            // 
            // radioButton3
            // 
            radioButton3.Location = new System.Drawing.Point(128, 113);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new System.Drawing.Size(192, 53);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "American Express";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.Control;
            button1.DialogResult = DialogResult.OK;
            button1.Location = new System.Drawing.Point(65, 234);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 48);
            button1.TabIndex = 3;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += DropDown1_PostChanges;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.SystemColors.Control;
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new System.Drawing.Point(230, 234);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 48);
            button2.TabIndex = 4;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // radioButton4
            // 
            radioButton4.Location = new System.Drawing.Point(128, 161);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new System.Drawing.Size(192, 53);
            radioButton4.TabIndex = 5;
            radioButton4.Text = "Discover";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(68, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(26, 24);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(68, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(26, 24);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(68, 79);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(26, 24);
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(68, 31);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(26, 24);
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // CreditCards
            // 
            BackColor = System.Drawing.Color.LightGray;
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            MinimumSize = new System.Drawing.Size(336, 140);
            Name = "CreditCards";
            Size = new System.Drawing.Size(390, 315);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}