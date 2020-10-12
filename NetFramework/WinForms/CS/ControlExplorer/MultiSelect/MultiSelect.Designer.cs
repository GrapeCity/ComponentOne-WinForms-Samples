namespace ControlExplorer.MultiSelect
{
    partial class MultiSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiSelect));
            this.c1MultiSelect1 = new C1.Win.Input.C1MultiSelect();
            this.SuspendLayout();
            // 
            // c1MultiSelect1
            // 
            this.c1MultiSelect1.Location = new System.Drawing.Point(12, 29);
            this.c1MultiSelect1.Name = "c1MultiSelect1";
            this.c1MultiSelect1.Placeholder = "Country";
            this.c1MultiSelect1.Size = new System.Drawing.Size(346, 30);
            this.c1MultiSelect1.Styles.DropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.c1MultiSelect1.TabIndex = 0;
            // 
            // MultiSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 652);
            this.Controls.Add(this.c1MultiSelect1);
            this.Name = "MultiSelect";
            this.Text = "MultiSelect";
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Input.C1MultiSelect c1MultiSelect1;
    }
}