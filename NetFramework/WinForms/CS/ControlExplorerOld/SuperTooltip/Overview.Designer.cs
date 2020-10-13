namespace ControlExplorer.SuperTooltip
{
    partial class Overview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Overview));
            System.Drawing.Drawing2D.Blend blend1 = new System.Drawing.Drawing2D.Blend();
            System.Drawing.Drawing2D.Blend blend2 = new System.Drawing.Drawing2D.Blend();
            System.Drawing.Drawing2D.Blend blend3 = new System.Drawing.Drawing2D.Blend();
            System.Drawing.Drawing2D.Blend blend4 = new System.Drawing.Drawing2D.Blend();
            this.c1SuperTooltip1 = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.c1Sizer1 = new C1.Win.C1Sizer.C1Sizer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.c1Sizer2 = new C1.Win.C1Sizer.C1Sizer();
            this.c1Sizer3 = new C1.Win.C1Sizer.C1Sizer();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.c1Sizer4 = new C1.Win.C1Sizer.C1Sizer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.c1Sizer5 = new C1.Win.C1Sizer.C1Sizer();
            this.label7 = new System.Windows.Forms.Label();
            this.c1superCorners = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            this.c1superFade = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.c1superGradients = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            this.c1superBalloon = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.c1Sizer7 = new C1.Win.C1Sizer.C1Sizer();
            this.c1Sizer6 = new C1.Win.C1Sizer.C1Sizer();
            this.c1superDelay = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            this.c1superShadow = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).BeginInit();
            this.c1Sizer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer2)).BeginInit();
            this.c1Sizer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer3)).BeginInit();
            this.c1Sizer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer4)).BeginInit();
            this.c1Sizer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer5)).BeginInit();
            this.c1Sizer5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer7)).BeginInit();
            this.c1Sizer7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer6)).BeginInit();
            this.c1Sizer6.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1SuperTooltip1
            // 
            this.c1SuperTooltip1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1SuperTooltip1.Images.Add(new C1.Win.C1SuperTooltip.ImageEntry("supertooltip.png", ((System.Drawing.Image)(resources.GetObject("c1SuperTooltip1.Images")))));
            this.c1SuperTooltip1.MaximumWidth = 200;
            this.c1SuperTooltip1.Opacity = 1;
            this.c1SuperTooltip1.ShowAlways = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(244, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 11;
            this.button1.Text = "Custom";
            this.c1SuperTooltip1.SetToolTip(this.button1, resources.GetString("button1.ToolTip"));
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // c1Sizer1
            // 
            this.c1Sizer1.Border.Corners = new C1.Win.C1Sizer.Corners(10, 10, 10, 10);
            this.c1Sizer1.Border.Thickness = new System.Windows.Forms.Padding(2);
            this.c1Sizer1.Controls.Add(this.label1);
            this.c1Sizer1.Gradient.BackColor2 = System.Drawing.Color.RoyalBlue;
            blend1.Factors = new float[] {
        0F,
        1F};
            blend1.Positions = new float[] {
        0F,
        1F};
            this.c1Sizer1.Gradient.Blend = blend1;
            this.c1Sizer1.Gradient.Mode = C1.Win.C1Sizer.GradientMode.Vertical;
            this.c1Sizer1.GridDefinition = "76:False:False;\t91.304347826087:False:False;";
            this.c1Sizer1.Location = new System.Drawing.Point(47, 24);
            this.c1Sizer1.Name = "c1Sizer1";
            this.c1Sizer1.Size = new System.Drawing.Size(138, 50);
            this.c1Sizer1.TabIndex = 0;
            this.c1Sizer1.Text = "c1Sizer1";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Opacity";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c1superCorners.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 39);
            this.label3.TabIndex = 2;
            this.label3.Text = "Shadow";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c1superShadow.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // c1Sizer2
            // 
            this.c1Sizer2.Controls.Add(this.label3);
            this.c1Sizer2.Controls.Add(this.label2);
            this.c1Sizer2.GridDefinition = "1.88679245283019:False:False;64.1509433962264:False:False;3.77358490566038:False:" +
                "False;\t2.04081632653061:False:False;83.6734693877551:False:False;3.4013605442176" +
                "9:False:False;";
            this.c1Sizer2.Location = new System.Drawing.Point(136, 117);
            this.c1Sizer2.Name = "c1Sizer2";
            this.c1Sizer2.Size = new System.Drawing.Size(147, 53);
            this.c1Sizer2.TabIndex = 3;
            this.c1Sizer2.Text = "c1Sizer2";
            // 
            // c1Sizer3
            // 
            this.c1Sizer3.BackColor = System.Drawing.Color.LemonChiffon;
            this.c1Sizer3.Controls.Add(this.label4);
            this.c1Sizer3.Gradient.BackColor2 = System.Drawing.Color.Gold;
            blend2.Factors = new float[] {
        0F,
        0.75F,
        1F,
        0F,
        0.75F,
        1F};
            blend2.Positions = new float[] {
        0F,
        0.25F,
        0.49F,
        0.51F,
        0.75F,
        1F};
            this.c1Sizer3.Gradient.Blend = blend2;
            this.c1Sizer3.Gradient.Mode = C1.Win.C1Sizer.GradientMode.Vertical;
            this.c1Sizer3.GridDefinition = "85.9649122807018:False:False;\t93.8461538461538:False:False;";
            this.c1Sizer3.Location = new System.Drawing.Point(234, 38);
            this.c1Sizer3.Name = "c1Sizer3";
            this.c1Sizer3.Size = new System.Drawing.Size(130, 57);
            this.c1Sizer3.TabIndex = 4;
            this.c1Sizer3.Text = "c1Sizer3";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 51);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gradients";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c1superGradients.SetToolTip(this.label4, resources.GetString("label4.ToolTip"));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Balloon";
            // 
            // c1Sizer4
            // 
            this.c1Sizer4.Controls.Add(this.label6);
            this.c1Sizer4.GridDefinition = "36.5671641791045:False:True;23.134328358209:False:True;28.3582089552239:False:Fal" +
                "se;\t21.5827338129496:False:True;40.2877697841727:False:True;26.6187050359712:Fal" +
                "se:False;";
            this.c1Sizer4.Image = ((System.Drawing.Image)(resources.GetObject("c1Sizer4.Image")));
            this.c1Sizer4.ImageAlignment = C1.Win.C1Sizer.ImageAlignment.LeftTop;
            this.c1Sizer4.Location = new System.Drawing.Point(393, 24);
            this.c1Sizer4.Name = "c1Sizer4";
            this.c1Sizer4.Size = new System.Drawing.Size(139, 134);
            this.c1Sizer4.TabIndex = 8;
            this.c1Sizer4.Text = "c1Sizer4";
            this.c1superBalloon.SetToolTip(this.c1Sizer4, resources.GetString("c1Sizer4.ToolTip"));
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 55);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.c1superDelay.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            // 
            // c1Sizer5
            // 
            this.c1Sizer5.BackColor = System.Drawing.Color.OliveDrab;
            this.c1Sizer5.Controls.Add(this.label7);
            this.c1Sizer5.Controls.Add(this.pictureBox1);
            blend3.Factors = new float[] {
        0.68F,
        0.98F};
            blend3.Positions = new float[] {
        0F,
        1F};
            this.c1Sizer5.Gradient.Blend = blend3;
            this.c1Sizer5.Gradient.Mode = C1.Win.C1Sizer.GradientMode.Vertical;
            this.c1Sizer5.GridDefinition = "87.3015873015873:False:False;\t59.0361445783133:False:False;33.7349397590361:False" +
                ":False;";
            this.c1Sizer5.Location = new System.Drawing.Point(287, 189);
            this.c1Sizer5.Name = "c1Sizer5";
            this.c1Sizer5.Size = new System.Drawing.Size(166, 63);
            this.c1Sizer5.TabIndex = 10;
            this.c1Sizer5.Text = "c1Sizer5";
            this.c1superDelay.SetToolTip(this.c1Sizer5, resources.GetString("c1Sizer5.ToolTip"));
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 55);
            this.label7.TabIndex = 10;
            this.label7.Text = "Timed Delay";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c1superDelay.SetToolTip(this.label7, resources.GetString("label7.ToolTip"));
            // 
            // c1superCorners
            // 
            this.c1superCorners.BackgroundGradient = C1.Win.C1SuperTooltip.BackgroundGradient.None;
            this.c1superCorners.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1superCorners.Opacity = 0.5;
            this.c1superCorners.RoundedCorners = true;
            this.c1superCorners.UseFading = false;
            // 
            // c1superFade
            // 
            this.c1superFade.BackColor = System.Drawing.Color.Black;
            this.c1superFade.BackgroundGradient = C1.Win.C1SuperTooltip.BackgroundGradient.Silver;
            this.c1superFade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("c1superFade.BackgroundImage")));
            this.c1superFade.BackgroundImageLayout = C1.Win.C1SuperTooltip.BackgroundImageLayout.Zoom;
            this.c1superFade.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1superFade.Opacity = 1;
            this.c1superFade.Shadow = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Background Image";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.c1superFade.SetToolTip(this.label5, "<div style=\"height:100;width:100\"><center><br>\n<br>\n<br>\n<b>Pow!</b></center></di" +
                    "v>");
            // 
            // c1superGradients
            // 
            this.c1superGradients.BackgroundGradient = C1.Win.C1SuperTooltip.BackgroundGradient.Gold;
            this.c1superGradients.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1superGradients.Opacity = 1;
            // 
            // c1superBalloon
            // 
            this.c1superBalloon.BackgroundGradient = C1.Win.C1SuperTooltip.BackgroundGradient.Blue;
            this.c1superBalloon.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1superBalloon.IsBalloon = true;
            this.c1superBalloon.Opacity = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.c1Sizer7);
            this.panel1.Controls.Add(this.c1Sizer1);
            this.panel1.Controls.Add(this.c1Sizer2);
            this.panel1.Controls.Add(this.c1Sizer5);
            this.panel1.Controls.Add(this.c1Sizer3);
            this.panel1.Controls.Add(this.c1Sizer4);
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 356);
            this.panel1.TabIndex = 12;
            // 
            // c1Sizer7
            // 
            this.c1Sizer7.BackColor = System.Drawing.SystemColors.Control;
            this.c1Sizer7.Controls.Add(this.label5);
            this.c1Sizer7.Gradient.BackColor2 = System.Drawing.Color.DimGray;
            blend4.Factors = new float[] {
        0F,
        1F};
            blend4.Positions = new float[] {
        0F,
        1F};
            this.c1Sizer7.Gradient.Blend = blend4;
            this.c1Sizer7.Gradient.Mode = C1.Win.C1Sizer.GradientMode.Horizontal;
            this.c1Sizer7.GridDefinition = "79.4871794871795:False:False;\t94.5945945945946:False:False;";
            this.c1Sizer7.Location = new System.Drawing.Point(47, 209);
            this.c1Sizer7.Name = "c1Sizer7";
            this.c1Sizer7.Size = new System.Drawing.Size(148, 39);
            this.c1Sizer7.TabIndex = 11;
            this.c1Sizer7.Text = "c1Sizer7";
            // 
            // c1Sizer6
            // 
            this.c1Sizer6.Controls.Add(this.panel1);
            this.c1Sizer6.Controls.Add(this.button1);
            this.c1Sizer6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Sizer6.GridDefinition = "79.8206278026906:False:False;9.41704035874439:False:False;7.17488789237668:False:" +
                "False;\t39.8648648648649:False:False;16.2162162162162:False:False;41.216216216216" +
                "2:False:False;";
            this.c1Sizer6.Location = new System.Drawing.Point(0, 0);
            this.c1Sizer6.Name = "c1Sizer6";
            this.c1Sizer6.Size = new System.Drawing.Size(592, 446);
            this.c1Sizer6.TabIndex = 13;
            this.c1Sizer6.Text = "c1Sizer6";
            // 
            // c1superDelay
            // 
            this.c1superDelay.BackgroundGradient = C1.Win.C1SuperTooltip.BackgroundGradient.Olive;
            this.c1superDelay.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1superDelay.InitialDelay = 2000;
            this.c1superDelay.Opacity = 1;
            this.c1superDelay.ReshowDelay = 0;
            // 
            // c1superShadow
            // 
            this.c1superShadow.BackgroundGradient = C1.Win.C1SuperTooltip.BackgroundGradient.Vista;
            this.c1superShadow.Font = new System.Drawing.Font("Tahoma", 8F);
            this.c1superShadow.Opacity = 1;
            this.c1superShadow.RoundedCorners = true;
            this.c1superShadow.UseFading = false;
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1Sizer6);
            this.Name = "Overview";
            this.Text = "Overview";
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer1)).EndInit();
            this.c1Sizer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer2)).EndInit();
            this.c1Sizer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer3)).EndInit();
            this.c1Sizer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer4)).EndInit();
            this.c1Sizer4.ResumeLayout(false);
            this.c1Sizer4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer5)).EndInit();
            this.c1Sizer5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer7)).EndInit();
            this.c1Sizer7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Sizer6)).EndInit();
            this.c1Sizer6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1SuperTooltip.C1SuperTooltip c1SuperTooltip1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private C1.Win.C1Sizer.C1Sizer c1Sizer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private C1.Win.C1Sizer.C1Sizer c1Sizer2;
        private C1.Win.C1Sizer.C1Sizer c1Sizer3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private C1.Win.C1Sizer.C1Sizer c1Sizer4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private C1.Win.C1Sizer.C1Sizer c1Sizer5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private C1.Win.C1SuperTooltip.C1SuperTooltip c1superCorners;
        private C1.Win.C1SuperTooltip.C1SuperTooltip c1superFade;
        private C1.Win.C1SuperTooltip.C1SuperTooltip c1superGradients;
        private C1.Win.C1SuperTooltip.C1SuperTooltip c1superBalloon;
        private System.Windows.Forms.Panel panel1;
        private C1.Win.C1Sizer.C1Sizer c1Sizer6;
        private C1.Win.C1SuperTooltip.C1SuperTooltip c1superDelay;
        private C1.Win.C1SuperTooltip.C1SuperTooltip c1superShadow;
        private C1.Win.C1Sizer.C1Sizer c1Sizer7;
        private System.Windows.Forms.Label label5;
    }
}