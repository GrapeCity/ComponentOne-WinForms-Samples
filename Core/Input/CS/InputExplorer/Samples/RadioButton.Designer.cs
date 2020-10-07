namespace InputExplorer.Samples
{
    partial class RadioButton
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
            this.c1RadioButton1 = new C1.Win.Input.C1RadioButton();
            this.c1RadioButton2 = new C1.Win.Input.C1RadioButton();
            this.c1RadioButton3 = new C1.Win.Input.C1RadioButton();
            this.c1RadioButton4 = new C1.Win.Input.C1RadioButton();
            this.SuspendLayout();
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Right;
            this.propertyGrid1.Location = new System.Drawing.Point(263, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.SelectedObject = this.c1RadioButton1;
            this.propertyGrid1.Size = new System.Drawing.Size(366, 391);
            this.propertyGrid1.TabIndex = 4;
            // 
            // c1RadioButton1
            // 
            this.c1RadioButton1.Location = new System.Drawing.Point(28, 37);
            this.c1RadioButton1.Name = "c1RadioButton1";
            this.c1RadioButton1.Size = new System.Drawing.Size(158, 24);
            this.c1RadioButton1.TabIndex = 0;
            this.c1RadioButton1.Text = "Normal Appearance";
            this.c1RadioButton1.UseMnemonic = true;
            // 
            // c1RadioButton2
            // 
            this.c1RadioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.c1RadioButton2.Location = new System.Drawing.Point(28, 116);
            this.c1RadioButton2.Name = "c1RadioButton2";
            this.c1RadioButton2.Size = new System.Drawing.Size(158, 24);
            this.c1RadioButton2.TabIndex = 1;
            this.c1RadioButton2.Text = "Button Appearance";
            this.c1RadioButton2.UseMnemonic = true;
            // 
            // c1RadioButton3
            // 
            this.c1RadioButton3.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.c1RadioButton3.Location = new System.Drawing.Point(28, 186);
            this.c1RadioButton3.Name = "c1RadioButton3";
            this.c1RadioButton3.Size = new System.Drawing.Size(158, 46);
            this.c1RadioButton3.TabIndex = 1;
            this.c1RadioButton3.Text = "Layout Options";
            this.c1RadioButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.c1RadioButton3.UseMnemonic = true;
            // 
            // c1RadioButton4
            // 
            this.c1RadioButton4.Location = new System.Drawing.Point(28, 274);
            this.c1RadioButton4.Name = "c1RadioButton4";
            this.c1RadioButton4.Size = new System.Drawing.Size(158, 24);
            this.c1RadioButton4.TabIndex = 3;
            this.c1RadioButton4.Text = "Vector Icon";
            this.c1RadioButton4.Styles.Normal.Text.ForeColor = System.Drawing.Color.SeaGreen;
            this.c1RadioButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.c1RadioButton4.UseMnemonic = true;
            // 
            // RadioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1RadioButton4);
            this.Controls.Add(this.c1RadioButton3);
            this.Controls.Add(this.c1RadioButton2);
            this.Controls.Add(this.c1RadioButton1);
            this.Controls.Add(this.propertyGrid1);
            this.Name = "RadioButton";
            this.Size = new System.Drawing.Size(629, 391);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private C1.Win.Input.C1RadioButton c1RadioButton1;
        private C1.Win.Input.C1RadioButton c1RadioButton2;
        private C1.Win.Input.C1RadioButton c1RadioButton3;
        private C1.Win.Input.C1RadioButton c1RadioButton4;
    }
}
