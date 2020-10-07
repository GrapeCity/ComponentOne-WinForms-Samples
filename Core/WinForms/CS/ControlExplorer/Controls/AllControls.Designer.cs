namespace ControlExplorer.Controls
{
    partial class AllControls
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblAllControls = new System.Windows.Forms.Label();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.pnlTitle.Controls.Add(this.lblAllControls);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(353, 36);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblAllControls
            // 
            this.lblAllControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAllControls.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAllControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.lblAllControls.Location = new System.Drawing.Point(0, 0);
            this.lblAllControls.Name = "lblAllControls";
            this.lblAllControls.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.lblAllControls.Size = new System.Drawing.Size(99, 36);
            this.lblAllControls.TabIndex = 0;
            this.lblAllControls.Text = "All Controls";
            this.lblAllControls.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlCategories
            // 
            this.pnlCategories.AutoScroll = true;
            this.pnlCategories.BackColor = System.Drawing.Color.White;
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCategories.Location = new System.Drawing.Point(0, 36);
            this.pnlCategories.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(353, 253);
            this.pnlCategories.TabIndex = 1;
            // 
            // AllControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.pnlCategories);
            this.Controls.Add(this.pnlTitle);
            this.Name = "AllControls";
            this.Size = new System.Drawing.Size(353, 289);
            this.pnlTitle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Label lblAllControls;
    }
}
