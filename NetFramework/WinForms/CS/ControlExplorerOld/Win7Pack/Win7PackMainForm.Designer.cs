namespace ControlExplorer.Win7Pack
{
    partial class Win7PackMainForm
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
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton1 = new C1.Win.C1Win7Pack.C1CustomButton();
            C1.Win.C1Win7Pack.C1CustomButton c1CustomButton2 = new C1.Win.C1Win7Pack.C1CustomButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win7PackMainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThumbnailButtons = new System.Windows.Forms.Button();
            this.btnProgressDemo = new System.Windows.Forms.Button();
            this.btnJumpTaskDemo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDialogDemo = new System.Windows.Forms.Button();
            this.dialogError = new C1.Win.C1Win7Pack.C1TaskDialog(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnThumbnailButtons);
            this.groupBox1.Controls.Add(this.btnProgressDemo);
            this.groupBox1.Controls.Add(this.btnJumpTaskDemo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "C1TaskbarButton Demos";
            // 
            // btnThumbnailButtons
            // 
            this.btnThumbnailButtons.Location = new System.Drawing.Point(222, 110);
            this.btnThumbnailButtons.Name = "btnThumbnailButtons";
            this.btnThumbnailButtons.Size = new System.Drawing.Size(175, 23);
            this.btnThumbnailButtons.TabIndex = 3;
            this.btnThumbnailButtons.Text = "Launch Thumbnail Button Demo";
            this.btnThumbnailButtons.UseVisualStyleBackColor = true;
            this.btnThumbnailButtons.Click += new System.EventHandler(this.btnThumbnailButtons_Click);
            // 
            // btnProgressDemo
            // 
            this.btnProgressDemo.Location = new System.Drawing.Point(222, 68);
            this.btnProgressDemo.Name = "btnProgressDemo";
            this.btnProgressDemo.Size = new System.Drawing.Size(175, 23);
            this.btnProgressDemo.TabIndex = 2;
            this.btnProgressDemo.Text = "Launch Progress Indicator Demo";
            this.btnProgressDemo.UseVisualStyleBackColor = true;
            this.btnProgressDemo.Click += new System.EventHandler(this.btnProgressDemo_Click);
            // 
            // btnJumpTaskDemo
            // 
            this.btnJumpTaskDemo.Location = new System.Drawing.Point(222, 26);
            this.btnJumpTaskDemo.Name = "btnJumpTaskDemo";
            this.btnJumpTaskDemo.Size = new System.Drawing.Size(175, 23);
            this.btnJumpTaskDemo.TabIndex = 0;
            this.btnJumpTaskDemo.Text = "Launch Jump List Demo";
            this.btnJumpTaskDemo.UseVisualStyleBackColor = true;
            this.btnJumpTaskDemo.Click += new System.EventHandler(this.btnJumpTaskDemo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.btnDialogDemo);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "C1TaskDialog Demos";
            // 
            // btnDialogDemo
            // 
            this.btnDialogDemo.Location = new System.Drawing.Point(222, 37);
            this.btnDialogDemo.Name = "btnDialogDemo";
            this.btnDialogDemo.Size = new System.Drawing.Size(175, 23);
            this.btnDialogDemo.TabIndex = 0;
            this.btnDialogDemo.Text = "Launch Windows Dialog Demo";
            this.btnDialogDemo.UseVisualStyleBackColor = true;
            this.btnDialogDemo.Click += new System.EventHandler(this.btnDialogDemo_Click);
            // 
            // dialogError
            // 
            this.dialogError.CheckBoxText = "Don\'t ask me again";
            this.dialogError.CheckedByDefault = true;
            this.dialogError.CollapsedControlText = "Show details";
            this.dialogError.Content = "With C1TaskDialog you can create custom Windows styled message boxes " +
                "with rich features like this one.";
            c1CustomButton1.ID = 9;
            c1CustomButton1.Name = "sendButton";
            c1CustomButton1.Note = "Shows progress dialog";
            c1CustomButton1.Text = "Send Feedback";
            c1CustomButton2.ID = 10;
            c1CustomButton2.Name = "dontSendButton";
            c1CustomButton2.Note = "Closes the dialog";
            c1CustomButton2.Text = "No Thanks";
            this.dialogError.CustomButtons.AddRange(new C1.Win.C1Win7Pack.C1CustomButton[] {
            c1CustomButton1,
            c1CustomButton2});
            this.dialogError.ExpandedControlText = "Hide details";
            this.dialogError.ExpandedInformation = "There is no real error! This is only a demo.";
            this.dialogError.ExpandFooterArea = true;
            this.dialogError.MainCommonIcon = C1.Win.C1Win7Pack.TaskDialogCommonIcon.Error;
            this.dialogError.MainInstruction = "An unexpected error occured. Please send feedback now!";
            this.dialogError.NextID = 13;
            this.dialogError.WindowTitle = "Custom Dialog Demo";
            this.dialogError.ButtonClick += new C1.Win.C1Win7Pack.TaskDialogButtonClickEventHandler(this.dialogError_ButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(19, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 145);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(19, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 129);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Win7PackMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 379);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Win7PackMainForm";
            this.Text = "Win7PackMainForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnJumpTaskDemo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProgressDemo;
        private System.Windows.Forms.Button btnDialogDemo;
        private C1.Win.C1Win7Pack.C1TaskDialog dialogError;
        private System.Windows.Forms.Button btnThumbnailButtons;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;


    }
}