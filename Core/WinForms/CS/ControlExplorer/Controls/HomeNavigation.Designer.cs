using C1.Framework;

namespace ControlExplorer.Controls
{
    partial class HomeNavigation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeNavigation));
            this.companyLogoBox = new System.Windows.Forms.PictureBox();
            this.pnlLogoFooter = new System.Windows.Forms.Panel();
            this.pnlFeaturedTiles = new System.Windows.Forms.Panel();
            this.lblPromo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoBox)).BeginInit();
            this.pnlLogoFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // mesciusLogoBox
            // 
            this.companyLogoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.companyLogoBox.Image = ResourceLoader.GetImage("companyLogoPictureBox.png");
            this.companyLogoBox.Location = new System.Drawing.Point(42, 0);
            this.companyLogoBox.Name = "companyLogoBox";
            this.companyLogoBox.Size = new System.Drawing.Size(130, 30);
            this.companyLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.companyLogoBox.TabIndex = 0;
            this.companyLogoBox.TabStop = false;
            // 
            // pnlLogoFooter
            // 
            this.pnlLogoFooter.Controls.Add(this.companyLogoBox);
            this.pnlLogoFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLogoFooter.Location = new System.Drawing.Point(0, 358);
            this.pnlLogoFooter.Name = "pnlLogoFooter";
            this.pnlLogoFooter.Size = new System.Drawing.Size(215, 44);
            this.pnlLogoFooter.TabIndex = 1;
            // 
            // pnlFeaturedTiles
            // 
            this.pnlFeaturedTiles.AutoScroll = true;
            this.pnlFeaturedTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFeaturedTiles.Location = new System.Drawing.Point(0, 260);
            this.pnlFeaturedTiles.Name = "pnlFeaturedTiles";
            this.pnlFeaturedTiles.Size = new System.Drawing.Size(215, 98);
            this.pnlFeaturedTiles.TabIndex = 2;
            // 
            // lblPromo
            // 
            this.lblPromo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPromo.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPromo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.lblPromo.Location = new System.Drawing.Point(0, 0);
            this.lblPromo.Name = "lblPromo";
            this.lblPromo.Padding = new System.Windows.Forms.Padding(26, 14, 20, 0);
            this.lblPromo.Size = new System.Drawing.Size(215, 260);
            this.lblPromo.TabIndex = 3;
            this.lblPromo.Text = "label1";
            // 
            // HomeNavigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.Controls.Add(this.pnlFeaturedTiles);
            this.Controls.Add(this.lblPromo);
            this.Controls.Add(this.pnlLogoFooter);
            this.Name = "HomeNavigation";
            this.Size = new System.Drawing.Size(215, 402);
            ((System.ComponentModel.ISupportInitialize)(this.companyLogoBox)).EndInit();
            this.pnlLogoFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox companyLogoBox;
        private System.Windows.Forms.Panel pnlLogoFooter;
        private System.Windows.Forms.Panel pnlFeaturedTiles;
        private System.Windows.Forms.Label lblPromo;
    }
}
