namespace TouchToolkitExplorer.TouchEvent
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
            C1TouchEventProvider1 = new C1.Win.TouchToolKit.C1TouchEventProvider();
            upButton1 = new System.Windows.Forms.Button();
            downButton1 = new System.Windows.Forms.Button();
            upButton2 = new System.Windows.Forms.Button();
            downButton2 = new System.Windows.Forms.Button();
            textBox1 = new System.Windows.Forms.TextBox();
            textBox2 = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(downButton2);
            panel1.Controls.Add(upButton2);
            panel1.Controls.Add(downButton1);
            panel1.Controls.Add(upButton1);
            panel1.Controls.Add(textBox1);
            // 
            // C1TouchEventProvider1
            // 
            C1TouchEventProvider1.EnablePressAndHold = false;
            C1TouchEventProvider1.PointerPressed += C1TouchEventProvider1_PointerPressed;
            C1TouchEventProvider1.PointerReleased += C1TouchEventProvider1_PointerReleased;
            C1TouchEventProvider1.Tapped += C1TouchEventProvider1_Tapped;
            // 
            // upButton1
            // 
            upButton1.AutoSize = true;
            C1TouchEventProvider1.SetEnableTouchEvents(upButton1, true);
            upButton1.Location = new System.Drawing.Point(170, 245);
            upButton1.Name = "upButton1";
            upButton1.Size = new System.Drawing.Size(65, 35);
            upButton1.TabIndex = 1;
            upButton1.Text = "+";
            upButton1.UseVisualStyleBackColor = true;
            // 
            // downButton1
            // 
            downButton1.AutoSize = true;
            C1TouchEventProvider1.SetEnableTouchEvents(downButton1, true);
            downButton1.Location = new System.Drawing.Point(241, 245);
            downButton1.Name = "downButton1";
            downButton1.Size = new System.Drawing.Size(65, 35);
            downButton1.TabIndex = 2;
            downButton1.Text = "-";
            downButton1.UseVisualStyleBackColor = true;
            // 
            // upButton2
            // 
            upButton2.AutoSize = true;
            upButton2.Location = new System.Drawing.Point(170, 116);
            upButton2.Name = "upButton2";
            upButton2.Size = new System.Drawing.Size(65, 35);
            upButton2.TabIndex = 3;
            upButton2.Text = "+";
            upButton2.UseVisualStyleBackColor = true;
            upButton2.Click += upButton2_Click;
            // 
            // downButton2
            // 
            downButton2.AutoSize = true;
            downButton2.Location = new System.Drawing.Point(241, 116);
            downButton2.Name = "downButton2";
            downButton2.Size = new System.Drawing.Size(65, 35);
            downButton2.TabIndex = 4;
            downButton2.Text = "-";
            downButton2.UseVisualStyleBackColor = true;
            downButton2.Click += downButton2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(44, 250);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(120, 23);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBox1.Validated += InputTextBox_Validated;
            // 
            // textBox2
            // 
            textBox2.Location = new System.Drawing.Point(44, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(120, 23);
            textBox2.TabIndex = 5;
            textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBox2.Validated += InputTextBox_Validated;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(40, 181);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(182, 15);
            label2.TabIndex = 6;
            label2.Text = "TextBox with Repeatable Buttons:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(40, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(121, 15);
            label3.TabIndex = 7;
            label3.Text = "TextBox with Buttons:";
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(77, 56);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(501, 53);
            label4.TabIndex = 11;
            label4.Text = "When press and hold a control, the default logic of Win8 is show a black rectangle. After release finger, it generate a right click message for this control. ";
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(77, 204);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(501, 34);
            label5.TabIndex = 12;
            label5.Text = "To disable this default behavior user can set \"EnablePressAndHold\" property to false.";
            // 
            // AutoRepeatDemo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Name = "AutoRepeatDemo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
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
