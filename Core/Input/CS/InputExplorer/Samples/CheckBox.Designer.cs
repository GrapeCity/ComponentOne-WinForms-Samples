namespace InputExplorer.Samples
{
    partial class CheckBox
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
            this.c1CheckBox1 = new C1.Win.Input.C1CheckBox();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.c1CheckBox2 = new C1.Win.Input.C1CheckBox();
            this.c1CheckBox4 = new C1.Win.Input.C1CheckBox();
            this.c1CheckBox3 = new C1.Win.Input.C1CheckBox();
            this.SuspendLayout();
            // 
            // c1CheckBox1
            // 
            this.c1CheckBox1.Location = new System.Drawing.Point(41, 36);
            this.c1CheckBox1.Name = "c1CheckBox1";
            this.c1CheckBox1.Size = new System.Drawing.Size(145, 24);
            this.c1CheckBox1.TabIndex = 0;
            this.c1CheckBox1.Text = "Normal Appearance";
            this.c1CheckBox1.UseMnemonic = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(271, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1CheckBox1;
            this.propertyGrid1.Size = new System.Drawing.Size(366, 449);
            this.propertyGrid1.TabIndex = 4;
            // 
            // c1CheckBox2
            // 
            this.c1CheckBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.c1CheckBox2.Icon = new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, null, -1);
            this.c1CheckBox2.Location = new System.Drawing.Point(41, 122);
            this.c1CheckBox2.Name = "c1CheckBox2";
            this.c1CheckBox2.Size = new System.Drawing.Size(145, 24);
            this.c1CheckBox2.TabIndex = 1;
            this.c1CheckBox2.Text = "Button Appearance";
            this.c1CheckBox2.UseMnemonic = true;
            // 
            // c1CheckBox4
            // 
            this.c1CheckBox4.ForeColor = System.Drawing.Color.SeaGreen;
            this.c1CheckBox4.Location = new System.Drawing.Point(41, 294);
            this.c1CheckBox4.Name = "c1CheckBox4";
            this.c1CheckBox4.Size = new System.Drawing.Size(145, 24);
            this.c1CheckBox4.TabIndex = 3;
            this.c1CheckBox4.Text = "Vector Icon";
            this.c1CheckBox4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.c1CheckBox4.UseMnemonic = true;
            // 
            // c1CheckBox3
            // 
            this.c1CheckBox3.Location = new System.Drawing.Point(41, 208);
            this.c1CheckBox3.Name = "c1CheckBox3";
            this.c1CheckBox3.Size = new System.Drawing.Size(145, 24);
            this.c1CheckBox3.TabIndex = 2;
            this.c1CheckBox3.Text = "Three State";
            this.c1CheckBox3.ThreeState = true;
            this.c1CheckBox3.UseMnemonic = true;
            // 
            // CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1CheckBox3);
            this.Controls.Add(this.c1CheckBox4);
            this.Controls.Add(this.c1CheckBox2);
            this.Controls.Add(this.propertyGrid1);
            this.Controls.Add(this.c1CheckBox1);
            this.Name = "CheckBox";
            this.Size = new System.Drawing.Size(637, 449);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Input.C1CheckBox c1CheckBox1;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private C1.Win.Input.C1CheckBox c1CheckBox2;
        private C1.Win.Input.C1CheckBox c1CheckBox4;
        private C1.Win.Input.C1CheckBox c1CheckBox3;
    }
}
