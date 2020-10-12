namespace MultipleForms
{
    partial class DHBaseForm
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
            this.c1DynamicHelp1 = new C1.Win.C1DynamicHelp.C1DynamicHelp();
            this.SuspendLayout();
            // 
            // c1DynamicHelp1
            // 
            this.c1DynamicHelp1.Location = new System.Drawing.Point(128, 0);
            this.c1DynamicHelp1.Name = "c1DynamicHelp1";
            this.c1DynamicHelp1.Size = new System.Drawing.Size(164, 266);
            this.c1DynamicHelp1.TabIndex = 0;
            // 
            // DHBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.c1DynamicHelp1);
            this.KeyPreview = true;
            this.Name = "DHBaseForm";
            this.Text = "DHBaseForm";
            this.Load += new System.EventHandler(this.DHBaseForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        protected C1.Win.C1DynamicHelp.C1DynamicHelp c1DynamicHelp1;

    }
}