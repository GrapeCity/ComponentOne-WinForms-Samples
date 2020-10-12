namespace StockPortfolio
{
    partial class PageNameLabel
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
            this.lblPagelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPagelabel
            // 
            this.lblPagelabel.AutoSize = true;
            this.lblPagelabel.BackColor = System.Drawing.Color.Transparent;
            this.lblPagelabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagelabel.Location = new System.Drawing.Point(6, 0);
            this.lblPagelabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPagelabel.Name = "lblPagelabel";
            this.lblPagelabel.Size = new System.Drawing.Size(117, 25);
            this.lblPagelabel.TabIndex = 0;
            this.lblPagelabel.Text = "WATCHLIST";
            // 
            // PageNameLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblPagelabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PageNameLabel";
            this.Size = new System.Drawing.Size(741, 28);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPagelabel;


    }
}
