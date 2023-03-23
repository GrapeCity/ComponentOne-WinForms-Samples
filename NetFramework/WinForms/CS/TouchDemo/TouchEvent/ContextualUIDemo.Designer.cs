namespace TouchDemo.TouchEvent
{
    partial class ContextualUIDemo
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
            this.colorButtonForTouch = new System.Windows.Forms.Button();
            this.C1TouchEventProvider1 = new C1.Win.TouchToolKit.C1TouchEventProvider();
            this.fontFamilyButtonForTouch = new System.Windows.Forms.Button();
            this.fontSizeButtonForTouch = new System.Windows.Forms.Button();
            this.fontFamilyTextBoxForTouch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.preViewLabel = new System.Windows.Forms.Label();
            this.colorButtonNormal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fontSizeButtonNormal = new System.Windows.Forms.Button();
            this.fontFamilyTextBoxNormal = new System.Windows.Forms.TextBox();
            this.fontFamilyButtonNormal = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fontSizeButtonNormal);
            this.panel1.Controls.Add(this.fontSizeButtonForTouch);
            this.panel1.Controls.Add(this.fontFamilyButtonNormal);
            this.panel1.Controls.Add(this.fontFamilyButtonForTouch);
            this.panel1.Controls.Add(this.fontFamilyTextBoxNormal);
            this.panel1.Controls.Add(this.fontFamilyTextBoxForTouch);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.colorButtonNormal);
            this.panel1.Controls.Add(this.colorButtonForTouch);
            // 
            // colorButtonForTouch
            // 
            this.colorButtonForTouch.BackColor = System.Drawing.Color.Black;
            this.C1TouchEventProvider1.SetEnableTouchEvents(this.colorButtonForTouch, true);
            this.colorButtonForTouch.ForeColor = System.Drawing.Color.White;
            this.colorButtonForTouch.Location = new System.Drawing.Point(387, 142);
            this.colorButtonForTouch.Name = "colorButtonForTouch";
            this.colorButtonForTouch.Size = new System.Drawing.Size(146, 30);
            this.colorButtonForTouch.TabIndex = 0;
            this.colorButtonForTouch.Text = "...";
            this.colorButtonForTouch.UseVisualStyleBackColor = false;
            // 
            // C1TouchEventProvider1
            // 
            this.C1TouchEventProvider1.Tapped += new System.EventHandler<C1.Win.TouchToolKit.TappedEventArgs>(this.C1TouchEventProvider1_Tapped);
            // 
            // fontFamilyButtonForTouch
            // 
            this.C1TouchEventProvider1.SetEnableTouchEvents(this.fontFamilyButtonForTouch, true);
            this.fontFamilyButtonForTouch.Location = new System.Drawing.Point(508, 314);
            this.fontFamilyButtonForTouch.Name = "fontFamilyButtonForTouch";
            this.fontFamilyButtonForTouch.Size = new System.Drawing.Size(25, 25);
            this.fontFamilyButtonForTouch.TabIndex = 4;
            this.fontFamilyButtonForTouch.UseVisualStyleBackColor = true;
            // 
            // fontSizeButtonForTouch
            // 
            this.C1TouchEventProvider1.SetEnableTouchEvents(this.fontSizeButtonForTouch, true);
            this.fontSizeButtonForTouch.Location = new System.Drawing.Point(387, 228);
            this.fontSizeButtonForTouch.Name = "fontSizeButtonForTouch";
            this.fontSizeButtonForTouch.Size = new System.Drawing.Size(146, 25);
            this.fontSizeButtonForTouch.TabIndex = 11;
            this.fontSizeButtonForTouch.Text = "9";
            this.fontSizeButtonForTouch.UseVisualStyleBackColor = true;
            // 
            // fontFamilyTextBoxForTouch
            // 
            this.fontFamilyTextBoxForTouch.Location = new System.Drawing.Point(387, 314);
            this.fontFamilyTextBoxForTouch.Name = "fontFamilyTextBoxForTouch";
            this.fontFamilyTextBoxForTouch.Size = new System.Drawing.Size(121, 25);
            this.fontFamilyTextBoxForTouch.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "ForeColor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "FontSize:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "FontFamily:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.preViewLabel);
            this.panel2.Location = new System.Drawing.Point(45, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 72);
            this.panel2.TabIndex = 7;
            // 
            // preViewLabel
            // 
            this.preViewLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preViewLabel.ForeColor = System.Drawing.Color.Black;
            this.preViewLabel.Location = new System.Drawing.Point(0, 0);
            this.preViewLabel.Name = "preViewLabel";
            this.preViewLabel.Size = new System.Drawing.Size(554, 70);
            this.preViewLabel.TabIndex = 3;
            this.preViewLabel.Text = "Provide touch-optimized contextual UI if it is opened by touch.";
            this.preViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorButtonNormal
            // 
            this.colorButtonNormal.BackColor = System.Drawing.Color.Black;
            this.colorButtonNormal.ForeColor = System.Drawing.Color.White;
            this.colorButtonNormal.Location = new System.Drawing.Point(63, 142);
            this.colorButtonNormal.Name = "colorButtonNormal";
            this.colorButtonNormal.Size = new System.Drawing.Size(146, 30);
            this.colorButtonNormal.TabIndex = 0;
            this.colorButtonNormal.Text = "...";
            this.colorButtonNormal.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "ForeColor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "FontSize:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "FontFamily:";
            // 
            // fontSizeButtonNormal
            // 
            this.fontSizeButtonNormal.Location = new System.Drawing.Point(63, 228);
            this.fontSizeButtonNormal.Name = "fontSizeButtonNormal";
            this.fontSizeButtonNormal.Size = new System.Drawing.Size(146, 25);
            this.fontSizeButtonNormal.TabIndex = 11;
            this.fontSizeButtonNormal.Text = "9";
            this.fontSizeButtonNormal.UseVisualStyleBackColor = true;
            // 
            // fontFamilyTextBoxNormal
            // 
            this.fontFamilyTextBoxNormal.Location = new System.Drawing.Point(63, 314);
            this.fontFamilyTextBoxNormal.Name = "fontFamilyTextBoxNormal";
            this.fontFamilyTextBoxNormal.Size = new System.Drawing.Size(121, 25);
            this.fontFamilyTextBoxNormal.TabIndex = 6;
            // 
            // fontFamilyButtonNormal
            // 
            this.fontFamilyButtonNormal.Location = new System.Drawing.Point(184, 314);
            this.fontFamilyButtonNormal.Name = "fontFamilyButtonNormal";
            this.fontFamilyButtonNormal.Size = new System.Drawing.Size(25, 25);
            this.fontFamilyButtonNormal.TabIndex = 4;
            this.fontFamilyButtonNormal.UseVisualStyleBackColor = true;
            // 
            // ContextualUIDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ContextualUIDemo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button colorButtonForTouch;
        private C1.Win.TouchToolKit.C1TouchEventProvider C1TouchEventProvider1;
        private System.Windows.Forms.Button fontSizeButtonForTouch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button fontSizeButtonNormal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label preViewLabel;
        private System.Windows.Forms.Button colorButtonNormal;
        private System.Windows.Forms.Button fontFamilyButtonForTouch;
        private System.Windows.Forms.TextBox fontFamilyTextBoxForTouch;
        private System.Windows.Forms.Button fontFamilyButtonNormal;
        private System.Windows.Forms.TextBox fontFamilyTextBoxNormal;
    }
}
