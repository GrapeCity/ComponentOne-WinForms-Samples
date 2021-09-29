namespace WordPad.BackstageTabs.Items
{
    partial class ItemButton
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
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(4, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(32, 32);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.MenuItem_Click);
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseDown);
            this.pbImage.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.pbImage.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseUp);
            // 
            // lblText
            // 
            this.lblText.AutoEllipsis = true;
            this.lblText.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(42, 9);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(318, 21);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "label1";
            this.lblText.Click += new System.EventHandler(this.MenuItem_Click);
            this.lblText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseDown);
            this.lblText.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.lblText.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.lblText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseUp);
            // 
            // AppMenuTabButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pbImage);
            this.Name = "AppMenuTabButton";
            this.Size = new System.Drawing.Size(380, 40);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseDown);
            this.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lblText;
    }
}
