namespace ControlExplorer.Input
{
    partial class RangeSlider
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
            this.c1RangeSlider1 = new C1.Win.C1Input.C1RangeSlider();
            this.c1RangeSlider2 = new C1.Win.C1Input.C1RangeSlider();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // c1RangeSlider1
            // 
            this.c1RangeSlider1.Location = new System.Drawing.Point(24, 12);
            this.c1RangeSlider1.LowerValue = 0D;
            this.c1RangeSlider1.Maximum = 100D;
            this.c1RangeSlider1.Minimum = 0D;
            this.c1RangeSlider1.Name = "c1RangeSlider1";
            this.c1RangeSlider1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.c1RangeSlider1.Size = new System.Drawing.Size(36, 254);
            this.c1RangeSlider1.TabIndex = 1;
            this.c1RangeSlider1.Text = "c1RangeSlider1";
            this.c1RangeSlider1.UpperValue = 100D;
            this.c1RangeSlider1.LowerValueChanged += new System.EventHandler(this.c1RangeSlider1_LowerValueChanged);
            this.c1RangeSlider1.UpperValueChanged += new System.EventHandler(this.c1RangeSlider1_UpperValueChanged);
            // 
            // c1RangeSlider2
            // 
            this.c1RangeSlider2.Location = new System.Drawing.Point(24, 297);
            this.c1RangeSlider2.LowerValue = 10D;
            this.c1RangeSlider2.Maximum = 100D;
            this.c1RangeSlider2.Minimum = 0D;
            this.c1RangeSlider2.Name = "c1RangeSlider2";
            this.c1RangeSlider2.Size = new System.Drawing.Size(298, 37);
            this.c1RangeSlider2.TabIndex = 2;
            this.c1RangeSlider2.Text = "c1RangeSlider2";
            this.c1RangeSlider2.UpperValue = 90D;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lower value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Upper value";
            // 
            // RangeSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 367);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c1RangeSlider2);
            this.Controls.Add(this.c1RangeSlider1);
            this.Name = "RangeSlider";
            this.Text = "RangeSlider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Input.C1RangeSlider c1RangeSlider1;
        private C1.Win.C1Input.C1RangeSlider c1RangeSlider2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}