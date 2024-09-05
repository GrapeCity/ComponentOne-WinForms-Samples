namespace TouchToolkitExplorer.C1ZoomPages
{
    partial class ShowControlDemo
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
            formButton = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            label17 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(formButton);
            // 
            // formButton
            // 
            formButton.AutoSize = true;
            formButton.Location = new System.Drawing.Point(16, 5);
            formButton.Name = "formButton";
            formButton.Size = new System.Drawing.Size(414, 35);
            formButton.TabIndex = 0;
            formButton.Text = "Click Me To Show The Test Form For ShowControl";
            formButton.UseVisualStyleBackColor = true;
            formButton.Click += formButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new System.Drawing.Point(16, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(663, 328);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new System.Drawing.Point(6, 14);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(325, 25);
            label17.TabIndex = 22;
            label17.Text = "InputBox may hide by screen keyboard.";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(6, 168);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(676, 25);
            label16.TabIndex = 23;
            label16.Text = "The input box will scroll out when screen keyboard open if AutoShowControl is true.";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.with;
            pictureBox2.Location = new System.Drawing.Point(38, 198);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(558, 124);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.without;
            pictureBox1.Location = new System.Drawing.Point(38, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(558, 121);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // ShowControlDemo
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Name = "ShowControlDemo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button formButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
