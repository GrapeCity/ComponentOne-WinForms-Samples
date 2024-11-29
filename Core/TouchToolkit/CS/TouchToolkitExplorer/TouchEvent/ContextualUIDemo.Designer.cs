namespace TouchToolkitExplorer.TouchEvent
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
            colorButtonForTouch = new System.Windows.Forms.Button();
            C1TouchEventProvider1 = new C1.Win.TouchToolKit.C1TouchEventProvider();
            fontFamilyButtonForTouch = new System.Windows.Forms.Button();
            fontSizeButtonForTouch = new System.Windows.Forms.Button();
            fontFamilyTextBoxForTouch = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            preViewLabel = new System.Windows.Forms.Label();
            colorButtonNormal = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            fontSizeButtonNormal = new System.Windows.Forms.Button();
            fontFamilyTextBoxNormal = new System.Windows.Forms.TextBox();
            fontFamilyButtonNormal = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(fontSizeButtonNormal);
            panel1.Controls.Add(fontSizeButtonForTouch);
            panel1.Controls.Add(fontFamilyButtonNormal);
            panel1.Controls.Add(fontFamilyButtonForTouch);
            panel1.Controls.Add(fontFamilyTextBoxNormal);
            panel1.Controls.Add(fontFamilyTextBoxForTouch);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(colorButtonNormal);
            panel1.Controls.Add(colorButtonForTouch);
            // 
            // colorButtonForTouch
            // 
            colorButtonForTouch.AutoSize = true;
            colorButtonForTouch.BackColor = System.Drawing.Color.Black;
            C1TouchEventProvider1.SetEnableTouchEvents(colorButtonForTouch, true);
            colorButtonForTouch.ForeColor = System.Drawing.Color.White;
            colorButtonForTouch.Location = new System.Drawing.Point(387, 142);
            colorButtonForTouch.Name = "colorButtonForTouch";
            colorButtonForTouch.Size = new System.Drawing.Size(146, 35);
            colorButtonForTouch.TabIndex = 0;
            colorButtonForTouch.Text = "...";
            colorButtonForTouch.UseVisualStyleBackColor = false;
            // 
            // C1TouchEventProvider1
            // 
            C1TouchEventProvider1.Tapped += C1TouchEventProvider1_Tapped;
            // 
            // fontFamilyButtonForTouch
            // 
            C1TouchEventProvider1.SetEnableTouchEvents(fontFamilyButtonForTouch, true);
            fontFamilyButtonForTouch.Location = new System.Drawing.Point(508, 320);
            fontFamilyButtonForTouch.Name = "fontFamilyButtonForTouch";
            fontFamilyButtonForTouch.Size = new System.Drawing.Size(25, 25);
            fontFamilyButtonForTouch.TabIndex = 4;
            fontFamilyButtonForTouch.UseVisualStyleBackColor = true;
            // 
            // fontSizeButtonForTouch
            // 
            fontSizeButtonForTouch.AutoSize = true;
            C1TouchEventProvider1.SetEnableTouchEvents(fontSizeButtonForTouch, true);
            fontSizeButtonForTouch.Location = new System.Drawing.Point(387, 228);
            fontSizeButtonForTouch.Name = "fontSizeButtonForTouch";
            fontSizeButtonForTouch.Size = new System.Drawing.Size(146, 35);
            fontSizeButtonForTouch.TabIndex = 11;
            fontSizeButtonForTouch.Text = "9";
            fontSizeButtonForTouch.UseVisualStyleBackColor = true;
            // 
            // fontFamilyTextBoxForTouch
            // 
            fontFamilyTextBoxForTouch.Location = new System.Drawing.Point(387, 314);
            fontFamilyTextBoxForTouch.Name = "fontFamilyTextBoxForTouch";
            fontFamilyTextBoxForTouch.Size = new System.Drawing.Size(121, 31);
            fontFamilyTextBoxForTouch.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(384, 111);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(94, 25);
            label2.TabIndex = 8;
            label2.Text = "ForeColor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(384, 193);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 25);
            label3.TabIndex = 9;
            label3.Text = "FontSize:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(384, 273);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(102, 25);
            label4.TabIndex = 10;
            label4.Text = "FontFamily:";
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel2.Controls.Add(preViewLabel);
            panel2.Location = new System.Drawing.Point(45, 12);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(556, 72);
            panel2.TabIndex = 7;
            // 
            // preViewLabel
            // 
            preViewLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            preViewLabel.ForeColor = System.Drawing.Color.Black;
            preViewLabel.Location = new System.Drawing.Point(0, 0);
            preViewLabel.Name = "preViewLabel";
            preViewLabel.Size = new System.Drawing.Size(554, 70);
            preViewLabel.TabIndex = 3;
            preViewLabel.Text = "Provide touch-optimized contextual UI if it is opened by touch.";
            preViewLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colorButtonNormal
            // 
            colorButtonNormal.AutoSize = true;
            colorButtonNormal.BackColor = System.Drawing.Color.Black;
            colorButtonNormal.ForeColor = System.Drawing.Color.White;
            colorButtonNormal.Location = new System.Drawing.Point(63, 142);
            colorButtonNormal.Name = "colorButtonNormal";
            colorButtonNormal.Size = new System.Drawing.Size(146, 35);
            colorButtonNormal.TabIndex = 0;
            colorButtonNormal.Text = "...";
            colorButtonNormal.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(60, 111);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(94, 25);
            label5.TabIndex = 8;
            label5.Text = "ForeColor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(60, 193);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(83, 25);
            label6.TabIndex = 9;
            label6.Text = "FontSize:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(60, 273);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(102, 25);
            label7.TabIndex = 10;
            label7.Text = "FontFamily:";
            // 
            // fontSizeButtonNormal
            // 
            fontSizeButtonNormal.AutoSize = true;
            fontSizeButtonNormal.Location = new System.Drawing.Point(63, 228);
            fontSizeButtonNormal.Name = "fontSizeButtonNormal";
            fontSizeButtonNormal.Size = new System.Drawing.Size(146, 35);
            fontSizeButtonNormal.TabIndex = 11;
            fontSizeButtonNormal.Text = "9";
            fontSizeButtonNormal.UseVisualStyleBackColor = true;
            // 
            // fontFamilyTextBoxNormal
            // 
            fontFamilyTextBoxNormal.Location = new System.Drawing.Point(63, 314);
            fontFamilyTextBoxNormal.Name = "fontFamilyTextBoxNormal";
            fontFamilyTextBoxNormal.Size = new System.Drawing.Size(121, 31);
            fontFamilyTextBoxNormal.TabIndex = 6;
            // 
            // fontFamilyButtonNormal
            // 
            fontFamilyButtonNormal.Location = new System.Drawing.Point(184, 317);
            fontFamilyButtonNormal.Name = "fontFamilyButtonNormal";
            fontFamilyButtonNormal.Size = new System.Drawing.Size(25, 25);
            fontFamilyButtonNormal.TabIndex = 4;
            fontFamilyButtonNormal.UseVisualStyleBackColor = true;
            // 
            // ContextualUIDemo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Name = "ContextualUIDemo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
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
