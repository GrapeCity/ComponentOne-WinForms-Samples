namespace MapSample.Layers
{
    partial class MapShape
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
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.c1Map1 = new C1.Win.Map.C1Map();
            ((System.ComponentModel.ISupportInitialize)(this.c1Map1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Items.AddRange(new object[] {
            "USA",
            "Japan"});
            this.cmbCountry.Location = new System.Drawing.Point(74, 3);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(182, 21);
            this.cmbCountry.TabIndex = 1;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.Location = new System.Drawing.Point(3, 7);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(65, 18);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Country:";
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // c1Map1
            // 
            this.c1Map1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Map1.DistanceScale.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.c1Map1.DistanceScale.BarStyle.BackColor = System.Drawing.Color.Black;
            this.c1Map1.Location = new System.Drawing.Point(0, 31);
            this.c1Map1.Name = "c1Map1";
            this.c1Map1.PanTool.MarkerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(176)))), ((int)(((byte)(202)))));
            this.c1Map1.PanTool.MarkerStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.c1Map1.PanTool.MarkerStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;
            this.c1Map1.PanTool.PanStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.c1Map1.PanTool.PanStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.c1Map1.PanTool.PanStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;
            this.c1Map1.PanTool.PanStyle.Stroke.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.c1Map1.PanTool.PanStyle.Stroke.Width = 1F;
            this.c1Map1.Proxy = null;
            this.c1Map1.Size = new System.Drawing.Size(506, 462);
            this.c1Map1.TabIndex = 2;
            this.c1Map1.Text = "c1Map1";
            this.c1Map1.ZoomTool.ButtonStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.c1Map1.ZoomTool.ButtonStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.c1Map1.ZoomTool.ButtonStyle.Border.Bottom.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.c1Map1.ZoomTool.ButtonStyle.Border.Bottom.Width = 1F;
            this.c1Map1.ZoomTool.ButtonStyle.Border.Left.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.c1Map1.ZoomTool.ButtonStyle.Border.Left.Width = 1F;
            this.c1Map1.ZoomTool.ButtonStyle.Border.Right.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.c1Map1.ZoomTool.ButtonStyle.Border.Right.Width = 1F;
            this.c1Map1.ZoomTool.ButtonStyle.Border.RoundRadius.BottomLeft = 3;
            this.c1Map1.ZoomTool.ButtonStyle.Border.RoundRadius.BottomRight = 3;
            this.c1Map1.ZoomTool.ButtonStyle.Border.RoundRadius.TopLeft = 3;
            this.c1Map1.ZoomTool.ButtonStyle.Border.RoundRadius.TopRight = 3;
            this.c1Map1.ZoomTool.ButtonStyle.Border.Top.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.c1Map1.ZoomTool.ButtonStyle.Border.Top.Width = 1F;
            this.c1Map1.ZoomTool.ButtonStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;
            this.c1Map1.ZoomTool.Margin = new System.Windows.Forms.Padding(20, 70, 0, 0);
            this.c1Map1.ZoomTool.ThumbStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.c1Map1.ZoomTool.ThumbStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(176)))), ((int)(((byte)(202)))));
            this.c1Map1.ZoomTool.ThumbStyle.Border.Bottom.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(198)))));
            this.c1Map1.ZoomTool.ThumbStyle.Border.Bottom.Width = 1F;
            this.c1Map1.ZoomTool.ThumbStyle.Border.Left.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(198)))));
            this.c1Map1.ZoomTool.ThumbStyle.Border.Left.Width = 1F;
            this.c1Map1.ZoomTool.ThumbStyle.Border.Right.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(198)))));
            this.c1Map1.ZoomTool.ThumbStyle.Border.Right.Width = 1F;
            this.c1Map1.ZoomTool.ThumbStyle.Border.RoundRadius.BottomLeft = 3;
            this.c1Map1.ZoomTool.ThumbStyle.Border.RoundRadius.BottomRight = 3;
            this.c1Map1.ZoomTool.ThumbStyle.Border.RoundRadius.TopLeft = 3;
            this.c1Map1.ZoomTool.ThumbStyle.Border.RoundRadius.TopRight = 3;
            this.c1Map1.ZoomTool.ThumbStyle.Border.Top.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(198)))));
            this.c1Map1.ZoomTool.ThumbStyle.Border.Top.Width = 1F;
            this.c1Map1.ZoomTool.ThumbStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;
            this.c1Map1.ZoomTool.TrackStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.c1Map1.ZoomTool.TrackStyle.Border.Bottom.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.c1Map1.ZoomTool.TrackStyle.Border.Bottom.Width = 1F;
            this.c1Map1.ZoomTool.TrackStyle.Border.Left.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.c1Map1.ZoomTool.TrackStyle.Border.Left.Width = 1F;
            this.c1Map1.ZoomTool.TrackStyle.Border.Right.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.c1Map1.ZoomTool.TrackStyle.Border.Right.Width = 1F;
            this.c1Map1.ZoomTool.TrackStyle.Border.RoundRadius.BottomLeft = 3;
            this.c1Map1.ZoomTool.TrackStyle.Border.RoundRadius.BottomRight = 3;
            this.c1Map1.ZoomTool.TrackStyle.Border.RoundRadius.TopLeft = 3;
            this.c1Map1.ZoomTool.TrackStyle.Border.RoundRadius.TopRight = 3;
            this.c1Map1.ZoomTool.TrackStyle.Border.Top.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.c1Map1.ZoomTool.TrackStyle.Border.Top.Width = 1F;
            // 
            // MapShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.c1Map1);
            this.Name = "MapShape";
            this.Size = new System.Drawing.Size(506, 493);
            ((System.ComponentModel.ISupportInitialize)(this.c1Map1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.Label lblCountry;
        private C1.Win.Map.C1Map c1Map1;
    }
}
