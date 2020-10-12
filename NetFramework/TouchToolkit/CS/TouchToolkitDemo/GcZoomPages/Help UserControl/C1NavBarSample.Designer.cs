namespace ClickOnceDemo.GcZoomPages
{
    partial class C1NavBarSample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(C1NavBarSample));
            this.c1NavBar1 = new C1.Win.C1Command.C1NavBar();
            this.c1NavBarPanel2 = new C1.Win.C1Command.C1NavBarPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.c1NavBarPanel7 = new C1.Win.C1Command.C1NavBarPanel();
            this.c1Calendar1 = new C1.Win.C1Schedule.C1Calendar();
            this.c1NavBarPanel1 = new C1.Win.C1Command.C1NavBarPanel();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.c1NavBarPanel4 = new C1.Win.C1Command.C1NavBarPanel();
            this.c1NavBarPanel5 = new C1.Win.C1Command.C1NavBarPanel();
            this.c1NavBarPanel6 = new C1.Win.C1Command.C1NavBarPanel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.c1NavBar1)).BeginInit();
            this.c1NavBar1.SuspendLayout();
            this.c1NavBarPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.c1NavBarPanel7.SuspendLayout();
            this.c1NavBarPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1NavBar1
            // 
            this.c1NavBar1.AllowCollapse = true;
            this.c1NavBar1.Collapsed = false;
            this.c1NavBar1.CollapseDirection = C1.Win.C1Command.CollapseDirectionEnum.ToLeft;
            this.c1NavBar1.Controls.Add(this.c1NavBarPanel2);
            this.c1NavBar1.Controls.Add(this.c1NavBarPanel7);
            this.c1NavBar1.Controls.Add(this.c1NavBarPanel1);
            this.c1NavBar1.Controls.Add(this.c1NavBarPanel4);
            this.c1NavBar1.Controls.Add(this.c1NavBarPanel5);
            this.c1NavBar1.Controls.Add(this.c1NavBarPanel6);
            this.c1NavBar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.c1NavBar1.Location = new System.Drawing.Point(0, 0);
            this.c1NavBar1.Name = "c1NavBar1";
            this.c1NavBar1.ShowVerticalTextOnCollapse = true;
            this.c1NavBar1.Size = new System.Drawing.Size(250, 446);
            this.c1NavBar1.StackButtonCount = 3;
            this.c1NavBar1.UIStrings.Content = new string[] {
        "NavBarCollapsedBarText:Navigation Pane"};
            this.c1NavBar1.VisualStyle = C1.Win.C1Command.VisualStyle.Office2010Blue;
            this.c1NavBar1.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2010Blue;
            this.c1NavBar1.DockChanged += new System.EventHandler(this.c1NavBar1_DockChanged);
            // 
            // c1NavBarPanel2
            // 
            this.c1NavBarPanel2.Button.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.c1NavBarPanel2.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.c1NavBarPanel2.Button.PanelHeader = "Mail";
            this.c1NavBarPanel2.Button.SmallImage = ((System.Drawing.Image)(resources.GetObject("resource.SmallImage")));
            this.c1NavBarPanel2.Button.Text = "Mail";
            this.c1NavBarPanel2.Controls.Add(this.pictureBox1);
            this.c1NavBarPanel2.ID = 2;
            this.c1NavBarPanel2.Name = "c1NavBarPanel2";
            this.c1NavBarPanel2.Size = new System.Drawing.Size(248, 284);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 284);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // c1NavBarPanel7
            // 
            this.c1NavBarPanel7.Button.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.c1NavBarPanel7.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.c1NavBarPanel7.Button.SmallImage = ((System.Drawing.Image)(resources.GetObject("resource.SmallImage1")));
            this.c1NavBarPanel7.Button.Text = "Calendar";
            this.c1NavBarPanel7.Controls.Add(this.c1Calendar1);
            this.c1NavBarPanel7.ID = 7;
            this.c1NavBarPanel7.Name = "c1NavBarPanel7";
            this.c1NavBarPanel7.Size = new System.Drawing.Size(248, 284);
            // 
            // c1Calendar1
            // 
            this.c1Calendar1.BoldedDates = new System.DateTime[0];
            this.c1Calendar1.CalendarDimensions = 5;
            // 
            // 
            // 
            this.c1Calendar1.CalendarInfo.CultureInfo = new System.Globalization.CultureInfo("en-US");
            this.c1Calendar1.CalendarInfo.DateFormatString = "M/d/yyyy";
            this.c1Calendar1.CalendarInfo.EndDayTime = System.TimeSpan.Parse("19:00:00");
            this.c1Calendar1.CalendarInfo.StartDayTime = System.TimeSpan.Parse("07:00:00");
            this.c1Calendar1.CalendarInfo.TimeScale = System.TimeSpan.Parse("00:30:00");
            this.c1Calendar1.CalendarInfo.WeekStart = System.DayOfWeek.Sunday;
            this.c1Calendar1.CalendarInfo.WorkDays.AddRange(new System.DayOfWeek[] {
            System.DayOfWeek.Monday,
            System.DayOfWeek.Tuesday,
            System.DayOfWeek.Wednesday,
            System.DayOfWeek.Thursday,
            System.DayOfWeek.Friday});
            this.c1Calendar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Calendar1.Location = new System.Drawing.Point(0, 0);
            this.c1Calendar1.Name = "c1Calendar1";
            this.c1Calendar1.Size = new System.Drawing.Size(248, 284);
            this.c1Calendar1.TabIndex = 0;
            // 
            // c1NavBarPanel1
            // 
            this.c1NavBarPanel1.Button.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.c1NavBarPanel1.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.c1NavBarPanel1.Button.SmallImage = ((System.Drawing.Image)(resources.GetObject("resource.SmallImage2")));
            this.c1NavBarPanel1.Button.Text = "Notes";
            this.c1NavBarPanel1.Controls.Add(this.radioButton3);
            this.c1NavBarPanel1.Controls.Add(this.radioButton2);
            this.c1NavBarPanel1.Controls.Add(this.radioButton1);
            this.c1NavBarPanel1.ID = 1;
            this.c1NavBarPanel1.Name = "c1NavBarPanel1";
            this.c1NavBarPanel1.Size = new System.Drawing.Size(248, 284);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Location = new System.Drawing.Point(11, 70);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.Text = "By Color";
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Transparent;
            this.radioButton2.Location = new System.Drawing.Point(11, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(82, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "By Category";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(11, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Icons";
            this.radioButton1.UseVisualStyleBackColor = false;
            // 
            // c1NavBarPanel4
            // 
            this.c1NavBarPanel4.Button.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.c1NavBarPanel4.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.c1NavBarPanel4.Button.SmallImage = ((System.Drawing.Image)(resources.GetObject("resource.SmallImage3")));
            this.c1NavBarPanel4.Button.Text = "Tasks";
            this.c1NavBarPanel4.ID = 4;
            this.c1NavBarPanel4.Name = "c1NavBarPanel4";
            this.c1NavBarPanel4.Size = new System.Drawing.Size(248, 284);
            // 
            // c1NavBarPanel5
            // 
            this.c1NavBarPanel5.Button.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.c1NavBarPanel5.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.c1NavBarPanel5.Button.SmallImage = ((System.Drawing.Image)(resources.GetObject("resource.SmallImage4")));
            this.c1NavBarPanel5.Button.Text = "Journal";
            this.c1NavBarPanel5.ID = 5;
            this.c1NavBarPanel5.Name = "c1NavBarPanel5";
            this.c1NavBarPanel5.Size = new System.Drawing.Size(248, 284);
            // 
            // c1NavBarPanel6
            // 
            this.c1NavBarPanel6.Button.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.c1NavBarPanel6.Button.ImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.c1NavBarPanel6.Button.SmallImage = ((System.Drawing.Image)(resources.GetObject("resource.SmallImage5")));
            this.c1NavBarPanel6.Button.Text = "Contacts";
            this.c1NavBarPanel6.ID = 6;
            this.c1NavBarPanel6.Name = "c1NavBarPanel6";
            this.c1NavBarPanel6.Size = new System.Drawing.Size(248, 284);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(250, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 446);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // C1NavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(610, 446);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.c1NavBar1);
            this.Name = "C1NavBar";
            this.Text = "NavBar";
            ((System.ComponentModel.ISupportInitialize)(this.c1NavBar1)).EndInit();
            this.c1NavBar1.ResumeLayout(false);
            this.c1NavBarPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.c1NavBarPanel7.ResumeLayout(false);
            this.c1NavBarPanel1.ResumeLayout(false);
            this.c1NavBarPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Command.C1NavBar c1NavBar1;
        private C1.Win.C1Command.C1NavBarPanel c1NavBarPanel1;
        private C1.Win.C1Command.C1NavBarPanel c1NavBarPanel2;
        private C1.Win.C1Command.C1NavBarPanel c1NavBarPanel4;
        private C1.Win.C1Command.C1NavBarPanel c1NavBarPanel5;
        private C1.Win.C1Command.C1NavBarPanel c1NavBarPanel6;
        private C1.Win.C1Schedule.C1Calendar c1Calendar1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Splitter splitter1;
        private C1.Win.C1Command.C1NavBarPanel c1NavBarPanel7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}