namespace ControlExplorer.Controls
{
    partial class CategoryControl
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
            this.lblCategoryTitle = new System.Windows.Forms.Label();
            this.pnlTiles = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblCategoryTitle
            // 
            this.lblCategoryTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCategoryTitle.Font = new System.Drawing.Font("Trebuchet MS", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCategoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.lblCategoryTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCategoryTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblCategoryTitle.Name = "lblCategoryTitle";
            this.lblCategoryTitle.Padding = new System.Windows.Forms.Padding(8, 20, 0, 0);
            this.lblCategoryTitle.Size = new System.Drawing.Size(115, 52);
            this.lblCategoryTitle.TabIndex = 0;
            this.lblCategoryTitle.Text = "label1";
            // 
            // pnlTiles
            // 
            this.pnlTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTiles.Location = new System.Drawing.Point(0, 52);
            this.pnlTiles.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTiles.Name = "pnlTiles";
            this.pnlTiles.Size = new System.Drawing.Size(115, 316);
            this.pnlTiles.TabIndex = 1;
            // 
            // CategoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlTiles);
            this.Controls.Add(this.lblCategoryTitle);
            this.Margin = new System.Windows.Forms.Padding(8, 20, 3, 3);
            this.Name = "CategoryControl";
            this.Size = new System.Drawing.Size(115, 368);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryTitle;
        private System.Windows.Forms.Panel pnlTiles;
    }
}
