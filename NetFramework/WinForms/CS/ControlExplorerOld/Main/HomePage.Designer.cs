namespace ControlExplorer.Main
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1SuperLabel1 = new C1.Win.C1SuperTooltip.C1SuperLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.c1SuperLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 441);
            this.panel1.TabIndex = 2;
            // 
            // c1SuperLabel1
            // 
            this.c1SuperLabel1.AutoSize = true;
            this.c1SuperLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SuperLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1SuperLabel1.Images.Add(new C1.Win.C1SuperTooltip.ImageEntry("Editor_RTF.png", ((System.Drawing.Image)(resources.GetObject("c1SuperLabel1.Images")))));
            this.c1SuperLabel1.Location = new System.Drawing.Point(0, 0);
            this.c1SuperLabel1.Name = "c1SuperLabel1";
            this.c1SuperLabel1.Size = new System.Drawing.Size(582, 441);
            this.c1SuperLabel1.TabIndex = 1;
            this.c1SuperLabel1.UseMnemonic = true;
            this.c1SuperLabel1.LinkClicked += new C1.Win.C1SuperTooltip.C1SuperLabelLinkClickedEventHandler(this.c1SuperLabel1_LinkClicked);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1SuperTooltip.C1SuperLabel c1SuperLabel1;
        private System.Windows.Forms.Panel panel1;

    }
}