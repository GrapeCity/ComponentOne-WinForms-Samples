
namespace InputExplorer.Samples
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.c1RangeSlider1 = new C1.Win.Input.C1RangeSlider();
            this.c1RangeSlider2 = new C1.Win.Input.C1RangeSlider();
            this.c1RangeSlider3 = new C1.Win.Input.C1RangeSlider();
            this.c1RangeSlider4 = new C1.Win.Input.C1RangeSlider();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(201, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1RangeSlider1;
            this.propertyGrid1.Size = new System.Drawing.Size(366, 436);
            this.propertyGrid1.TabIndex = 2;
            // 
            // c1RangeSlider1
            // 
            this.c1RangeSlider1.LargeChange = 5D;
            this.c1RangeSlider1.Location = new System.Drawing.Point(14, 32);
            this.c1RangeSlider1.LowerValue = 0D;
            this.c1RangeSlider1.Maximum = 100D;
            this.c1RangeSlider1.Minimum = 0D;
            this.c1RangeSlider1.Name = "c1RangeSlider1";
            this.c1RangeSlider1.Size = new System.Drawing.Size(138, 28);
            this.c1RangeSlider1.TabIndex = 3;
            this.c1RangeSlider1.Text = "c1RangeSlider1";
            this.c1RangeSlider1.UpperValue = 100D;
            // 
            // c1RangeSlider2
            // 
            this.c1RangeSlider2.LargeChange = 5D;
            this.c1RangeSlider2.Location = new System.Drawing.Point(14, 108);
            this.c1RangeSlider2.LowerValue = 0D;
            this.c1RangeSlider2.Maximum = 100D;
            this.c1RangeSlider2.Minimum = 0D;
            this.c1RangeSlider2.Name = "c1RangeSlider2";
            this.c1RangeSlider2.Size = new System.Drawing.Size(138, 28);
            this.c1RangeSlider2.Styles.Thumb.Width = 15;
            this.c1RangeSlider2.TabIndex = 4;
            this.c1RangeSlider2.Text = "c1RangeSlider2";
            this.c1RangeSlider2.UpperValue = 100D;
            // 
            // c1RangeSlider3
            // 
            this.c1RangeSlider3.LargeChange = 5D;
            this.c1RangeSlider3.Location = new System.Drawing.Point(14, 184);
            this.c1RangeSlider3.LowerValue = 25D;
            this.c1RangeSlider3.Maximum = 100D;
            this.c1RangeSlider3.Minimum = 0D;
            this.c1RangeSlider3.Name = "c1RangeSlider3";
            this.c1RangeSlider3.ScrollBehavior = C1.Win.Input.RangeSliderScrollBehavior.RangeStep;
            this.c1RangeSlider3.Size = new System.Drawing.Size(138, 28);
            this.c1RangeSlider3.Styles.Bar.Default.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.c1RangeSlider3.Styles.Bar.Selected.BackColor = System.Drawing.SystemColors.Highlight;
            this.c1RangeSlider3.Styles.Bar.Thickness = 1D;
            this.c1RangeSlider3.Styles.Thumb.Width = 10;
            this.c1RangeSlider3.TabIndex = 5;
            this.c1RangeSlider3.Text = "c1RangeSlider3";
            this.c1RangeSlider3.UpperValue = 75D;
            // 
            // c1RangeSlider4
            // 
            this.c1RangeSlider4.LargeChange = 5D;
            this.c1RangeSlider4.Location = new System.Drawing.Point(167, 32);
            this.c1RangeSlider4.LowerValue = 0D;
            this.c1RangeSlider4.Maximum = 100D;
            this.c1RangeSlider4.Minimum = 0D;
            this.c1RangeSlider4.Name = "c1RangeSlider4";
            this.c1RangeSlider4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.c1RangeSlider4.ScrollBehavior = C1.Win.Input.RangeSliderScrollBehavior.ThumbStep;
            this.c1RangeSlider4.Size = new System.Drawing.Size(30, 180);
            this.c1RangeSlider4.TabIndex = 6;
            this.c1RangeSlider4.Text = "c1RangeSlider4";
            this.c1RangeSlider4.UpperValue = 100D;
            // 
            // RangeSlider
            // 
            this.Controls.Add(this.c1RangeSlider4);
            this.Controls.Add(this.c1RangeSlider3);
            this.Controls.Add(this.c1RangeSlider2);
            this.Controls.Add(this.c1RangeSlider1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "RangeSlider";
            this.Size = new System.Drawing.Size(567, 436);
            this.ResumeLayout(false);
            this.AutoScaleDimensions = new System.Drawing.SizeF(96, 96);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private C1.Win.Input.C1RangeSlider c1RangeSlider1;
        private C1.Win.Input.C1RangeSlider c1RangeSlider2;
        private C1.Win.Input.C1RangeSlider c1RangeSlider3;
        private C1.Win.Input.C1RangeSlider c1RangeSlider4;
    }
}
