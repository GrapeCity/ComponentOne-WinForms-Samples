namespace TouchToolKitDemo.TouchEvent
{
    partial class AutoRepeatDemo
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
            this.C1TouchEventProvider1 = new C1.Win.TouchToolKit.C1TouchEventProvider();
            this.upButton1 = new System.Windows.Forms.Button();
            this.downButton1 = new System.Windows.Forms.Button();
            this.upButton2 = new System.Windows.Forms.Button();
            this.downButton2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.downButton2);
            this.panel1.Controls.Add(this.upButton2);
            this.panel1.Controls.Add(this.downButton1);
            this.panel1.Controls.Add(this.upButton1);
            this.panel1.Controls.Add(this.textBox1);
            // 
            // C1TouchEventProvider1
            // 
            this.C1TouchEventProvider1.EnablePressAndHold = false;
            this.C1TouchEventProvider1.PointerPressed += new System.EventHandler<C1.Win.TouchToolKit.PointerEventArgs>(this.C1TouchEventProvider1_PointerPressed);
            this.C1TouchEventProvider1.PointerReleased += new System.EventHandler<C1.Win.TouchToolKit.PointerEventArgs>(this.C1TouchEventProvider1_PointerReleased);
            this.C1TouchEventProvider1.Tapped += new System.EventHandler<C1.Win.TouchToolKit.TappedEventArgs>(this.C1TouchEventProvider1_Tapped);
            // 
            // upButton1
            // 
            this.C1TouchEventProvider1.SetEnableTouchEvents(this.upButton1, true);
            this.upButton1.Location = new System.Drawing.Point(170, 242);
            this.upButton1.Name = "upButton1";
            this.upButton1.Size = new System.Drawing.Size(65, 31);
            this.upButton1.TabIndex = 1;
            this.upButton1.Text = "+";
            this.upButton1.UseVisualStyleBackColor = true;
            // 
            // downButton1
            // 
            this.C1TouchEventProvider1.SetEnableTouchEvents(this.downButton1, true);
            this.downButton1.Location = new System.Drawing.Point(241, 242);
            this.downButton1.Name = "downButton1";
            this.downButton1.Size = new System.Drawing.Size(65, 31);
            this.downButton1.TabIndex = 2;
            this.downButton1.Text = "-";
            this.downButton1.UseVisualStyleBackColor = true;
            // 
            // upButton2
            // 
            this.upButton2.Location = new System.Drawing.Point(170, 122);
            this.upButton2.Name = "upButton2";
            this.upButton2.Size = new System.Drawing.Size(65, 30);
            this.upButton2.TabIndex = 3;
            this.upButton2.Text = "+";
            this.upButton2.UseVisualStyleBackColor = true;
            this.upButton2.Click += new System.EventHandler(this.upButton2_Click);
            // 
            // downButton2
            // 
            this.downButton2.Location = new System.Drawing.Point(241, 122);
            this.downButton2.Name = "downButton2";
            this.downButton2.Size = new System.Drawing.Size(65, 30);
            this.downButton2.TabIndex = 4;
            this.downButton2.Text = "-";
            this.downButton2.UseVisualStyleBackColor = true;
            this.downButton2.Click += new System.EventHandler(this.downButton2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Validated += new System.EventHandler(this.InputTextBox_Validated);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 30);
            this.textBox2.TabIndex = 5;
            this.textBox2.Validated += new System.EventHandler(this.InputTextBox_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "TextBox with Repeatable Buttons:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "TextBox with Buttons:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(77, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(501, 72);
            this.label4.TabIndex = 11;
            this.label4.Text = "When pressing and holding a control, the default logic of Windows8 is to show a black rectangle. After releasing your finger by touch, it generates a right-click message for this control.";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(77, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(501, 56);
            this.label5.TabIndex = 12;
            this.label5.Text = "To disable this default behavior user can set \"EnablePressAndHold\" property to fa" +
    "lse.";
            // 
            // AutoRepeatDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AutoRepeatDemo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.TouchToolKit.C1TouchEventProvider C1TouchEventProvider1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button downButton2;
        private System.Windows.Forms.Button upButton2;
        private System.Windows.Forms.Button downButton1;
        private System.Windows.Forms.Button upButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}
