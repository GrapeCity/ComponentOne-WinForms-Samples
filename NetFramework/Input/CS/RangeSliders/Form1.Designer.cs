namespace RangeSliders
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
            this.c1RangeSlider1 = new C1.Win.C1Input.C1RangeSlider();
            this.c1NumericEdit1 = new C1.Win.C1Input.C1NumericEdit();
            this.c1NumericEdit2 = new C1.Win.C1Input.C1NumericEdit();
            this.c1ComboBox1 = new C1.Win.C1Input.C1ComboBox();
            this.c1Label1 = new C1.Win.C1Input.C1Label();
            this.c1Label2 = new C1.Win.C1Input.C1Label();
            this.c1Label3 = new C1.Win.C1Input.C1Label();
            this.c1RangeSlider2 = new C1.Win.C1Input.C1RangeSlider();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).BeginInit();
            this.SuspendLayout();
            // 
            // c1RangeSlider1
            // 
            this.c1RangeSlider1.Location = new System.Drawing.Point(12, 12);
            this.c1RangeSlider1.LowerValue = 0D;
            this.c1RangeSlider1.Maximum = 100D;
            this.c1RangeSlider1.Minimum = 0D;
            this.c1RangeSlider1.Name = "c1RangeSlider1";
            this.c1RangeSlider1.Size = new System.Drawing.Size(250, 66);
            this.c1RangeSlider1.TabIndex = 0;
            this.c1RangeSlider1.Text = "c1RangeSlider1";
            this.c1RangeSlider1.UpperValue = 100D;
            this.c1RangeSlider1.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            this.c1RangeSlider1.LowerValueChanged += new System.EventHandler(this.c1RangeSlider1_LowerValueChanged);
            this.c1RangeSlider1.UpperValueChanged += new System.EventHandler(this.c1RangeSlider1_UpperValueChanged);
            // 
            // c1NumericEdit1
            // 
            this.c1NumericEdit1.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.c1NumericEdit1.Location = new System.Drawing.Point(372, 12);
            this.c1NumericEdit1.Name = "c1NumericEdit1";
            this.c1NumericEdit1.Size = new System.Drawing.Size(100, 18);
            this.c1NumericEdit1.TabIndex = 1;
            this.c1NumericEdit1.Tag = null;
            this.c1NumericEdit1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.c1NumericEdit1.ValueChanged += new System.EventHandler(this.c1NumericEdit1_ValueChanged);
            // 
            // c1NumericEdit2
            // 
            this.c1NumericEdit2.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.c1NumericEdit2.Location = new System.Drawing.Point(372, 36);
            this.c1NumericEdit2.Name = "c1NumericEdit2";
            this.c1NumericEdit2.Size = new System.Drawing.Size(100, 18);
            this.c1NumericEdit2.TabIndex = 2;
            this.c1NumericEdit2.Tag = null;
            this.c1NumericEdit2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.c1NumericEdit2.ValueChanged += new System.EventHandler(this.c1NumericEdit2_ValueChanged);
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AllowSpinLoop = false;
            this.c1ComboBox1.GapHeight = 0;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.c1ComboBox1.InitialSelectedIndex = 4;
            this.c1ComboBox1.Items.Add("System");
            this.c1ComboBox1.Items.Add("Office2007Blue");
            this.c1ComboBox1.Items.Add("Office2007Black");
            this.c1ComboBox1.Items.Add("Office2007Silver");
            this.c1ComboBox1.Items.Add("Office2010Blue");
            this.c1ComboBox1.Items.Add("Office2010Black");
            this.c1ComboBox1.Items.Add("Office2010Silver");
            this.c1ComboBox1.ItemsDisplayMember = "";
            this.c1ComboBox1.ItemsValueMember = "";
            this.c1ComboBox1.Location = new System.Drawing.Point(372, 60);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(100, 18);
            this.c1ComboBox1.TabIndex = 3;
            this.c1ComboBox1.Tag = null;
            this.c1ComboBox1.ValueChanged += new System.EventHandler(this.c1ComboBox1_ValueChanged);
            // 
            // c1Label1
            // 
            this.c1Label1.AutoSize = true;
            this.c1Label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label1.Location = new System.Drawing.Point(300, 15);
            this.c1Label1.Name = "c1Label1";
            this.c1Label1.Size = new System.Drawing.Size(66, 13);
            this.c1Label1.TabIndex = 4;
            this.c1Label1.Tag = null;
            this.c1Label1.Value = "Lower Value";
            this.c1Label1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue;
            // 
            // c1Label2
            // 
            this.c1Label2.AutoSize = true;
            this.c1Label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label2.Location = new System.Drawing.Point(300, 39);
            this.c1Label2.Name = "c1Label2";
            this.c1Label2.Size = new System.Drawing.Size(66, 13);
            this.c1Label2.TabIndex = 5;
            this.c1Label2.Tag = null;
            this.c1Label2.Value = "Upper Value";
            // 
            // c1Label3
            // 
            this.c1Label3.AutoSize = true;
            this.c1Label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1Label3.Location = new System.Drawing.Point(305, 63);
            this.c1Label3.Name = "c1Label3";
            this.c1Label3.Size = new System.Drawing.Size(61, 13);
            this.c1Label3.TabIndex = 6;
            this.c1Label3.Tag = null;
            this.c1Label3.Value = "Visual Style";
            // 
            // c1RangeSlider2
            // 
            this.c1RangeSlider2.Location = new System.Drawing.Point(12, 84);
            this.c1RangeSlider2.LowerValue = 0D;
            this.c1RangeSlider2.Maximum = 100D;
            this.c1RangeSlider2.Minimum = 0D;
            this.c1RangeSlider2.Name = "c1RangeSlider2";
            this.c1RangeSlider2.Size = new System.Drawing.Size(250, 66);
            this.c1RangeSlider2.TabIndex = 7;
            this.c1RangeSlider2.Text = "c1RangeSlider2";
            this.c1RangeSlider2.UpperValue = 100D;
            this.c1RangeSlider2.VisualStyle = C1.Win.C1Input.VisualStyle.System;
            this.c1RangeSlider2.LowerValueChanged += new System.EventHandler(this.c1RangeSlider2_LowerValueChanged);
            this.c1RangeSlider2.UpperValueChanged += new System.EventHandler(this.c1RangeSlider2_UpperValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.c1RangeSlider2);
            this.Controls.Add(this.c1Label3);
            this.Controls.Add(this.c1Label2);
            this.Controls.Add(this.c1Label1);
            this.Controls.Add(this.c1ComboBox1);
            this.Controls.Add(this.c1NumericEdit2);
            this.Controls.Add(this.c1NumericEdit1);
            this.Controls.Add(this.c1RangeSlider1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Label3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1RangeSlider c1RangeSlider1;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit1;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit2;
        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
        private C1.Win.C1Input.C1Label c1Label1;
        private C1.Win.C1Input.C1Label c1Label2;
        private C1.Win.C1Input.C1Label c1Label3;
        private C1.Win.C1Input.C1RangeSlider c1RangeSlider2;
    }
}