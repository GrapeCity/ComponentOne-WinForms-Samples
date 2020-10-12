namespace ControlExplorer.Win7Pack
{
    partial class ThumbnailButtonDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThumbnailButtonDemo));
            C1.Win.C1Win7Pack.C1ThumbButton c1ThumbButton1 = new C1.Win.C1Win7Pack.C1ThumbButton();
            C1.Win.C1Win7Pack.C1ThumbButton c1ThumbButton2 = new C1.Win.C1Win7Pack.C1ThumbButton();
            C1.Win.C1Win7Pack.C1ThumbButton c1ThumbButton3 = new C1.Win.C1Win7Pack.C1ThumbButton();
            C1.Win.C1Win7Pack.C1ThumbButton c1ThumbButton4 = new C1.Win.C1Win7Pack.C1ThumbButton();
            this.imLarge = new System.Windows.Forms.ImageList(this.components);
            this.btnLastImage = new System.Windows.Forms.Button();
            this.btnFirstImage = new System.Windows.Forms.Button();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labImageCaption = new System.Windows.Forms.Label();
            this.taskbarButton = new C1.Win.C1Win7Pack.C1TaskbarButton(this.components);
            this.imSmall = new System.Windows.Forms.ImageList(this.components);
            this.c1SuperLabel1 = new C1.Win.C1SuperTooltip.C1SuperLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imLarge
            // 
            this.imLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imLarge.ImageStream")));
            this.imLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imLarge.Images.SetKeyName(0, "PrintView.png");
            this.imLarge.Images.SetKeyName(1, "Monitor.png");
            this.imLarge.Images.SetKeyName(2, "GreenBook.png");
            this.imLarge.Images.SetKeyName(3, "Wall.png");
            this.imLarge.Images.SetKeyName(4, "Tip.png");
            this.imLarge.Images.SetKeyName(5, "Reminder.png");
            this.imLarge.Images.SetKeyName(6, "JournalBook.png");
            this.imLarge.Images.SetKeyName(7, "Lightbulb.png");
            this.imLarge.Images.SetKeyName(8, "PaintPalette.png");
            this.imLarge.Images.SetKeyName(9, "PaperClip.png");
            // 
            // btnLastImage
            // 
            this.btnLastImage.Image = global::ControlExplorer.Properties.Resources.LastRecord;
            this.btnLastImage.Location = new System.Drawing.Point(218, 74);
            this.btnLastImage.Name = "btnLastImage";
            this.btnLastImage.Size = new System.Drawing.Size(46, 27);
            this.btnLastImage.TabIndex = 8;
            this.btnLastImage.UseVisualStyleBackColor = true;
            this.btnLastImage.Click += new System.EventHandler(this.btnLastImage_Click);
            // 
            // btnFirstImage
            // 
            this.btnFirstImage.Image = global::ControlExplorer.Properties.Resources.FirstRecord;
            this.btnFirstImage.Location = new System.Drawing.Point(12, 74);
            this.btnFirstImage.Name = "btnFirstImage";
            this.btnFirstImage.Size = new System.Drawing.Size(46, 27);
            this.btnFirstImage.TabIndex = 6;
            this.btnFirstImage.UseVisualStyleBackColor = true;
            this.btnFirstImage.Click += new System.EventHandler(this.btnFirstImage_Click);
            // 
            // btnNextImage
            // 
            this.btnNextImage.Image = global::ControlExplorer.Properties.Resources.NextRecord;
            this.btnNextImage.Location = new System.Drawing.Point(218, 107);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(46, 27);
            this.btnNextImage.TabIndex = 10;
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // btnPrevImage
            // 
            this.btnPrevImage.Image = global::ControlExplorer.Properties.Resources.PreviousRecord;
            this.btnPrevImage.Location = new System.Drawing.Point(12, 107);
            this.btnPrevImage.Name = "btnPrevImage";
            this.btnPrevImage.Size = new System.Drawing.Size(46, 27);
            this.btnPrevImage.TabIndex = 9;
            this.btnPrevImage.UseVisualStyleBackColor = true;
            this.btnPrevImage.Click += new System.EventHandler(this.btnPrevImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(64, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // labImageCaption
            // 
            this.labImageCaption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labImageCaption.Location = new System.Drawing.Point(218, 170);
            this.labImageCaption.Name = "labImageCaption";
            this.labImageCaption.Size = new System.Drawing.Size(164, 30);
            this.labImageCaption.TabIndex = 11;
            this.labImageCaption.Text = "Image Caption";
            this.labImageCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // taskbarButton
            // 
            this.taskbarButton.ContainerForm = this;
            c1ThumbButton1.ImageIndex = 0;
            c1ThumbButton1.Name = "FirstImage";
            c1ThumbButton1.Tooltip = "First Image";
            c1ThumbButton2.ImageIndex = 1;
            c1ThumbButton2.Name = "PrevImage";
            c1ThumbButton2.Tooltip = "Previous Image";
            c1ThumbButton3.ImageIndex = 2;
            c1ThumbButton3.Name = "NextImage";
            c1ThumbButton3.Tooltip = "Next Image";
            c1ThumbButton4.ImageIndex = 3;
            c1ThumbButton4.Name = "LastImage";
            c1ThumbButton4.Tooltip = "Last Image";
            this.taskbarButton.Thumbnail.Buttons.AddRange(new C1.Win.C1Win7Pack.C1ThumbButton[] {
            c1ThumbButton1,
            c1ThumbButton2,
            c1ThumbButton3,
            c1ThumbButton4});
            this.taskbarButton.Thumbnail.ImageList = this.imSmall;
            this.taskbarButton.WindowAppID = "ThumbnailButtonDemo";
            this.taskbarButton.ThumbButtonClick += new C1.Win.C1Win7Pack.ThumbButtonEventHandler(this.tm_ThumbButtonClick);
            // 
            // imSmall
            // 
            this.imSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imSmall.ImageStream")));
            this.imSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imSmall.Images.SetKeyName(0, "MoveFirst.png");
            this.imSmall.Images.SetKeyName(1, "MovePrevious_16x16.png");
            this.imSmall.Images.SetKeyName(2, "MoveNext_16x16.png");
            this.imSmall.Images.SetKeyName(3, "MoveLast.png");
            // 
            // c1SuperLabel1
            // 
            this.c1SuperLabel1.Location = new System.Drawing.Point(12, 12);
            this.c1SuperLabel1.Name = "c1SuperLabel1";
            this.c1SuperLabel1.Size = new System.Drawing.Size(370, 34);
            this.c1SuperLabel1.TabIndex = 12;
            this.c1SuperLabel1.Text = "With <b>C1TaskbarButton</b> you can add buttons to the taskbar thumbnail pop-up. " +
                "Hover over this window\'s button in your taskbar to see the buttons.";
            this.c1SuperLabel1.UseMnemonic = true;
            // 
            // ThumbnailButtonDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 212);
            this.Controls.Add(this.c1SuperLabel1);
            this.Controls.Add(this.labImageCaption);
            this.Controls.Add(this.btnLastImage);
            this.Controls.Add(this.btnFirstImage);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.btnPrevImage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ThumbnailButtonDemo";
            this.Text = "Thumbnail Buttons Demo";
            this.Load += new System.EventHandler(this.ThumbnailButtonDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imLarge;
        private System.Windows.Forms.Button btnLastImage;
        private System.Windows.Forms.Button btnFirstImage;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnPrevImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labImageCaption;
        private C1.Win.C1Win7Pack.C1TaskbarButton taskbarButton;
        private System.Windows.Forms.ImageList imSmall;
        private C1.Win.C1SuperTooltip.C1SuperLabel c1SuperLabel1;
    }
}