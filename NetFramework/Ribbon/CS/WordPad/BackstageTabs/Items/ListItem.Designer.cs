namespace WordPad.BackstageTabs.Items
{
    partial class ListItem
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
            this.pbPin = new System.Windows.Forms.PictureBox();
            this.lblSubText = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPin
            // 
            this.pbPin.Location = new System.Drawing.Point(356, 12);
            this.pbPin.Name = "pbPin";
            this.pbPin.Size = new System.Drawing.Size(16, 16);
            this.pbPin.TabIndex = 7;
            this.pbPin.TabStop = false;
            this.pbPin.Click += new System.EventHandler(this.pbPin_Click);
            this.pbPin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseDown);
            this.pbPin.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.pbPin.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.pbPin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseUp);
            // 
            // lblSubText
            // 
            this.lblSubText.AutoEllipsis = true;
            this.lblSubText.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubText.Location = new System.Drawing.Point(43, 22);
            this.lblSubText.Name = "lblSubText";
            this.lblSubText.Size = new System.Drawing.Size(288, 18);
            this.lblSubText.TabIndex = 6;
            this.lblSubText.Text = "label2";
            this.lblSubText.Click += new System.EventHandler(this.MenuItem_Click);
            this.lblSubText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseDown);
            this.lblSubText.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.lblSubText.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.lblSubText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseUp);
            // 
            // lblText
            // 
            this.lblText.AutoEllipsis = true;
            this.lblText.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblText.Location = new System.Drawing.Point(42, 1);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(289, 21);
            this.lblText.TabIndex = 5;
            this.lblText.Text = "label1";
            this.lblText.Click += new System.EventHandler(this.MenuItem_Click);
            this.lblText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseDown);
            this.lblText.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.lblText.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.lblText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseUp);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(4, 4);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(32, 32);
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.MenuItem_Click);
            this.pbImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseDown);
            this.pbImage.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.pbImage.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.pbImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseUp);
            // 
            // AppMenuTabItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbPin);
            this.Controls.Add(this.lblSubText);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pbImage);
            this.Name = "AppMenuTabItem";
            this.Size = new System.Drawing.Size(380, 40);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseDown);
            this.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MenuItem_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbPin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPin;
        private System.Windows.Forms.Label lblSubText;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.PictureBox pbImage;
    }
}
