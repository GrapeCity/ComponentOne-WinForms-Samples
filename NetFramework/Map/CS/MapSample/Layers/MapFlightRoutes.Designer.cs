namespace MapSample.Layers
{
    partial class MapFlightRoutes
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
            C1.Win.Map.VirtualEarthRoadSource virtualEarthRoadSource5 = new C1.Win.Map.VirtualEarthRoadSource();
            this.radRoutesKiev = new System.Windows.Forms.RadioButton();
            this.radRoutesBern = new System.Windows.Forms.RadioButton();
            this.c1Map1 = new C1.Win.Map.C1Map();
            this.tableLayoutMap = new System.Windows.Forms.TableLayoutPanel();
            this.panelMap = new System.Windows.Forms.Panel();
            this.flowLayoutRb = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.c1Map1)).BeginInit();
            this.tableLayoutMap.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.flowLayoutRb.SuspendLayout();
            this.SuspendLayout();
            // 
            // radRoutesKiev
            // 
            this.radRoutesKiev.AutoSize = true;
            this.radRoutesKiev.Checked = true;
            this.radRoutesKiev.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radRoutesKiev.Location = new System.Drawing.Point(7, 2);
            this.radRoutesKiev.Margin = new System.Windows.Forms.Padding(10, 3, 1, 1);
            this.radRoutesKiev.Name = "radRoutesKiev";
            this.radRoutesKiev.Size = new System.Drawing.Size(147, 25);
            this.radRoutesKiev.TabIndex = 0;
            this.radRoutesKiev.TabStop = true;
            this.radRoutesKiev.Text = "Routes from Kiev";
            this.radRoutesKiev.UseVisualStyleBackColor = true;
            this.radRoutesKiev.CheckedChanged += new System.EventHandler(this.radRoutes_CheckedChanged);
            // 
            // radRoutesBern
            // 
            this.radRoutesBern.AutoSize = true;
            this.radRoutesBern.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.radRoutesBern.Location = new System.Drawing.Point(106, 2);
            this.radRoutesBern.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.radRoutesBern.Name = "radRoutesBern";
            this.radRoutesBern.Size = new System.Drawing.Size(150, 25);
            this.radRoutesBern.TabIndex = 1;
            this.radRoutesBern.Text = "Routes from Bern";
            this.radRoutesBern.UseVisualStyleBackColor = true;
            this.radRoutesBern.CheckedChanged += new System.EventHandler(this.radRoutes_CheckedChanged);
            // 
            // c1Map1
            // 
            this.c1Map1.DistanceScale.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.c1Map1.DistanceScale.BarStyle.BackColor = System.Drawing.Color.Black;
            this.c1Map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Map1.Location = new System.Drawing.Point(0, 0);
            this.c1Map1.Margin = new System.Windows.Forms.Padding(0);
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
            this.c1Map1.Size = new System.Drawing.Size(513, 512);
            this.c1Map1.TabIndex = 2;
            this.c1Map1.Text = "c1Map1";
            virtualEarthRoadSource5.ApplicationId = null;
            this.c1Map1.TileLayer.TileSource = virtualEarthRoadSource5;
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
            // tableLayoutMap
            // 
            this.tableLayoutMap.ColumnCount = 1;
            this.tableLayoutMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMap.Controls.Add(this.panelMap, 0, 1);
            this.tableLayoutMap.Controls.Add(this.flowLayoutRb, 0, 0);
            this.tableLayoutMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMap.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMap.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutMap.Name = "tableLayoutMap";
            this.tableLayoutMap.RowCount = 2;
            this.tableLayoutMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutMap.Size = new System.Drawing.Size(513, 532);
            this.tableLayoutMap.TabIndex = 3;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.c1Map1);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 20);
            this.panelMap.Margin = new System.Windows.Forms.Padding(0);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(513, 512);
            this.panelMap.TabIndex = 4;
            // 
            // flowLayoutRb
            // 
            this.flowLayoutRb.Controls.Add(this.radRoutesKiev);
            this.flowLayoutRb.Controls.Add(this.radRoutesBern);
            this.flowLayoutRb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutRb.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutRb.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutRb.Name = "flowLayoutRb";
            this.flowLayoutRb.Size = new System.Drawing.Size(511, 18);
            this.flowLayoutRb.TabIndex = 4;
            // 
            // MapFlightRoutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutMap);
            this.Name = "MapFlightRoutes";
            this.Size = new System.Drawing.Size(513, 532);
            ((System.ComponentModel.ISupportInitialize)(this.c1Map1)).EndInit();
            this.tableLayoutMap.ResumeLayout(false);
            this.panelMap.ResumeLayout(false);
            this.flowLayoutRb.ResumeLayout(false);
            this.flowLayoutRb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radRoutesKiev;
        private System.Windows.Forms.RadioButton radRoutesBern;
        private C1.Win.Map.C1Map c1Map1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMap;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutRb;
    }
}
