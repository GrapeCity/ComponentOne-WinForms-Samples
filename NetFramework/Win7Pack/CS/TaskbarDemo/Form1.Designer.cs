namespace TaskbarDemo
{
    partial class Form1
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
            C1.Win.C1Win7Pack.C1ThumbButton c1ThumbButton1 = new C1.Win.C1Win7Pack.C1ThumbButton();
            C1.Win.C1Win7Pack.C1ThumbButton c1ThumbButton2 = new C1.Win.C1Win7Pack.C1ThumbButton();
            C1.Win.C1Win7Pack.C1ThumbButton c1ThumbButton3 = new C1.Win.C1Win7Pack.C1ThumbButton();
            C1.Win.C1Win7Pack.C1ThumbButton c1ThumbButton4 = new C1.Win.C1Win7Pack.C1ThumbButton();
            C1.Win.C1Win7Pack.C1ThumbButton c1ThumbButton5 = new C1.Win.C1Win7Pack.C1ThumbButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.taskbarButton = new C1.Win.C1Win7Pack.C1TaskbarButton(this.components);
            this.imSmall = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.progressCheckBox = new System.Windows.Forms.CheckBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clipCheckBox = new System.Windows.Forms.CheckBox();
            this.btnPrevImage = new System.Windows.Forms.Button();
            this.btnNextImage = new System.Windows.Forms.Button();
            this.imLarge = new System.Windows.Forms.ImageList(this.components);
            this.btnFirstImage = new System.Windows.Forms.Button();
            this.btnLastImage = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labImageCaption = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            c1ThumbButton5.DismissOnClick = true;
            c1ThumbButton5.ImageIndex = 4;
            c1ThumbButton5.Name = "ToggleView";
            c1ThumbButton5.Tooltip = "Toggle View";
            this.taskbarButton.Thumbnail.Buttons.AddRange(new C1.Win.C1Win7Pack.C1ThumbButton[] {
            c1ThumbButton1,
            c1ThumbButton2,
            c1ThumbButton3,
            c1ThumbButton4,
            c1ThumbButton5});
            this.taskbarButton.Thumbnail.ImageList = this.imSmall;
            this.taskbarButton.WindowAppID = "TaskbarDemo";
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
            this.imSmall.Images.SetKeyName(4, "Flag.png");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(97, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overlay Icon";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(15, 90);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(70, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "Warning";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.overlayRadioButton_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 67);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "Info";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.overlayRadioButton_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(50, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Error";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.overlayRadioButton_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "None";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.overlayRadioButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.trackBar1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.progressCheckBox);
            this.groupBox2.Controls.Add(this.radioButton8);
            this.groupBox2.Controls.Add(this.radioButton7);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Location = new System.Drawing.Point(133, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 121);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Progress Indicator";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(20, 84);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(246, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(103, 34);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(163, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Value:";
            // 
            // progressCheckBox
            // 
            this.progressCheckBox.AutoSize = true;
            this.progressCheckBox.Location = new System.Drawing.Point(20, 22);
            this.progressCheckBox.Name = "progressCheckBox";
            this.progressCheckBox.Size = new System.Drawing.Size(60, 17);
            this.progressCheckBox.TabIndex = 0;
            this.progressCheckBox.Text = "Visible";
            this.progressCheckBox.UseVisualStyleBackColor = true;
            this.progressCheckBox.CheckedChanged += new System.EventHandler(this.progressCheckBox_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(285, 90);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(71, 17);
            this.radioButton8.TabIndex = 6;
            this.radioButton8.Text = "Marquee";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Click += new System.EventHandler(this.progressRadioButton_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(285, 67);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(62, 17);
            this.radioButton7.TabIndex = 5;
            this.radioButton7.Text = "Paused";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Click += new System.EventHandler(this.progressRadioButton_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(285, 44);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(50, 17);
            this.radioButton6.TabIndex = 4;
            this.radioButton6.Text = "Error";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.progressRadioButton_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(285, 21);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(62, 17);
            this.radioButton5.TabIndex = 3;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Normal";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.progressRadioButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(69, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // clipCheckBox
            // 
            this.clipCheckBox.AutoSize = true;
            this.clipCheckBox.Location = new System.Drawing.Point(236, 281);
            this.clipCheckBox.Name = "clipCheckBox";
            this.clipCheckBox.Size = new System.Drawing.Size(172, 17);
            this.clipCheckBox.TabIndex = 7;
            this.clipCheckBox.Text = "Clip Thumbnail by the Image";
            this.clipCheckBox.UseVisualStyleBackColor = true;
            this.clipCheckBox.CheckedChanged += new System.EventHandler(this.clipCheckBox_CheckedChanged);
            // 
            // btnPrevImage
            // 
            this.btnPrevImage.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevImage.Image")));
            this.btnPrevImage.Location = new System.Drawing.Point(17, 205);
            this.btnPrevImage.Name = "btnPrevImage";
            this.btnPrevImage.Size = new System.Drawing.Size(46, 27);
            this.btnPrevImage.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btnPrevImage, "Previous Image");
            this.btnPrevImage.UseVisualStyleBackColor = true;
            this.btnPrevImage.Click += new System.EventHandler(this.btnPrevImage_Click);
            // 
            // btnNextImage
            // 
            this.btnNextImage.Image = ((System.Drawing.Image)(resources.GetObject("btnNextImage.Image")));
            this.btnNextImage.Location = new System.Drawing.Point(223, 205);
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(46, 27);
            this.btnNextImage.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnNextImage, "Next Image");
            this.btnNextImage.UseVisualStyleBackColor = true;
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
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
            // btnFirstImage
            // 
            this.btnFirstImage.Image = ((System.Drawing.Image)(resources.GetObject("btnFirstImage.Image")));
            this.btnFirstImage.Location = new System.Drawing.Point(17, 172);
            this.btnFirstImage.Name = "btnFirstImage";
            this.btnFirstImage.Size = new System.Drawing.Size(46, 27);
            this.btnFirstImage.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnFirstImage, "First Image");
            this.btnFirstImage.UseVisualStyleBackColor = true;
            this.btnFirstImage.Click += new System.EventHandler(this.btnFirstImage_Click);
            // 
            // btnLastImage
            // 
            this.btnLastImage.Image = ((System.Drawing.Image)(resources.GetObject("btnLastImage.Image")));
            this.btnLastImage.Location = new System.Drawing.Point(223, 172);
            this.btnLastImage.Name = "btnLastImage";
            this.btnLastImage.Size = new System.Drawing.Size(46, 27);
            this.btnLastImage.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnLastImage, "Last Image");
            this.btnLastImage.UseVisualStyleBackColor = true;
            this.btnLastImage.Click += new System.EventHandler(this.btnLastImage_Click);
            // 
            // labImageCaption
            // 
            this.labImageCaption.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labImageCaption.Location = new System.Drawing.Point(286, 169);
            this.labImageCaption.Name = "labImageCaption";
            this.labImageCaption.Size = new System.Drawing.Size(214, 30);
            this.labImageCaption.TabIndex = 6;
            this.labImageCaption.Text = "Image Caption";
            this.labImageCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 317);
            this.Controls.Add(this.labImageCaption);
            this.Controls.Add(this.btnLastImage);
            this.Controls.Add(this.btnFirstImage);
            this.Controls.Add(this.btnNextImage);
            this.Controls.Add(this.btnPrevImage);
            this.Controls.Add(this.clipCheckBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "C1TaskbarButton Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1Win7Pack.C1TaskbarButton taskbarButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.CheckBox progressCheckBox;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox clipCheckBox;
        private System.Windows.Forms.Button btnNextImage;
        private System.Windows.Forms.Button btnPrevImage;
        private System.Windows.Forms.ImageList imLarge;
        private System.Windows.Forms.ImageList imSmall;
        private System.Windows.Forms.Button btnLastImage;
        private System.Windows.Forms.Button btnFirstImage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labImageCaption;
    }
}

