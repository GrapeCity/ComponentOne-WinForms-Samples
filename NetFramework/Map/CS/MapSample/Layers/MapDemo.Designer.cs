namespace MapSample.Layers
{
    partial class MapDemo
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
            C1.Win.Map.VirtualEarthRoadSource virtualEarthRoadSource1 = new C1.Win.Map.VirtualEarthRoadSource();
            this.c1Map1 = new C1.Win.Map.C1Map();
            this.cmbSource = new C1.Win.C1Input.C1ComboBox();
            this.lblDemoSource = new C1.Win.C1Input.C1Label();
            this.chkShowTools = new C1.Win.C1Input.C1CheckBox();
            this.tableLayoutPanelMap = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelMap = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMap = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.c1Map1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDemoSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowTools)).BeginInit();
            this.tableLayoutPanelMap.SuspendLayout();
            this.flowLayoutPanelMap.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1Map1
            // 
            this.c1Map1.DistanceScale.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.c1Map1.DistanceScale.BarStyle.BackColor = System.Drawing.Color.Black;
            this.c1Map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Map1.Location = new System.Drawing.Point(0, 0);
            this.c1Map1.Margin = new System.Windows.Forms.Padding(0);
            this.c1Map1.Name = "c1Map1";
            this.c1Map1.Padding = new System.Windows.Forms.Padding(1);
            this.c1Map1.PanTool.MarkerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(176)))), ((int)(((byte)(202)))));
            this.c1Map1.PanTool.MarkerStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.c1Map1.PanTool.MarkerStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;
            this.c1Map1.PanTool.PanStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.c1Map1.PanTool.PanStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.c1Map1.PanTool.PanStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;
            this.c1Map1.PanTool.PanStyle.Stroke.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.c1Map1.PanTool.PanStyle.Stroke.Width = 1F;
            this.c1Map1.Proxy = null;
            this.c1Map1.Size = new System.Drawing.Size(516, 511);
            this.c1Map1.TabIndex = 3;
            this.c1Map1.Text = "c1Map1";
            this.c1Map1.TileLayer.Name = null;
            virtualEarthRoadSource1.ApplicationId = null;
            this.c1Map1.TileLayer.TileSource = virtualEarthRoadSource1;
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
            // cmbSource
            // 
            this.cmbSource.AllowSpinLoop = false;
            this.cmbSource.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSource.GapHeight = 0;
            this.cmbSource.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbSource.Items.Add("VirtualEarthRoadSource");
            this.cmbSource.Items.Add("VirtualEarthAerialSource");
            this.cmbSource.Items.Add("VirtualEarthHybridSource");
            this.cmbSource.Items.Add("OpenStreet (custom)");
            this.cmbSource.Location = new System.Drawing.Point(43, 4);
            this.cmbSource.Margin = new System.Windows.Forms.Padding(1);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(133, 29);
            this.cmbSource.TabIndex = 1;
            this.cmbSource.Tag = null;
            this.cmbSource.SelectedIndexChanged += new System.EventHandler(this.cmbSource_SelectedIndexChanged);
            // 
            // lblDemoSource
            // 
            this.lblDemoSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDemoSource.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDemoSource.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDemoSource.Location = new System.Drawing.Point(1, 4);
            this.lblDemoSource.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.lblDemoSource.Name = "lblDemoSource";
            this.lblDemoSource.Size = new System.Drawing.Size(40, 25);
            this.lblDemoSource.TabIndex = 0;
            this.lblDemoSource.Tag = null;
            this.lblDemoSource.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDemoSource.Value = "Source:";
            // 
            // chkShowTools
            // 
            this.chkShowTools.AutoSize = true;
            this.chkShowTools.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkShowTools.Checked = true;
            this.chkShowTools.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.chkShowTools.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowTools.Location = new System.Drawing.Point(178, 5);
            this.chkShowTools.Margin = new System.Windows.Forms.Padding(1, 2, 1, 1);
            this.chkShowTools.Name = "chkShowTools";
            this.chkShowTools.Size = new System.Drawing.Size(107, 25);
            this.chkShowTools.TabIndex = 2;
            this.chkShowTools.Text = "Show Tools";
            this.chkShowTools.UseVisualStyleBackColor = true;
            this.chkShowTools.Value = true;
            this.chkShowTools.CheckedChanged += new System.EventHandler(this.chkShowTools_CheckedChanged);
            // 
            // tableLayoutPanelMap
            // 
            this.tableLayoutPanelMap.ColumnCount = 1;
            this.tableLayoutPanelMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMap.Controls.Add(this.flowLayoutPanelMap, 0, 0);
            this.tableLayoutPanelMap.Controls.Add(this.panelMap, 0, 1);
            this.tableLayoutPanelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMap.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMap.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMap.Name = "tableLayoutPanelMap";
            this.tableLayoutPanelMap.RowCount = 2;
            this.tableLayoutPanelMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMap.Size = new System.Drawing.Size(516, 531);
            this.tableLayoutPanelMap.TabIndex = 5;
            // 
            // flowLayoutPanelMap
            // 
            this.flowLayoutPanelMap.AutoSize = true;
            this.flowLayoutPanelMap.Controls.Add(this.lblDemoSource);
            this.flowLayoutPanelMap.Controls.Add(this.cmbSource);
            this.flowLayoutPanelMap.Controls.Add(this.chkShowTools);
            this.flowLayoutPanelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMap.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMap.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelMap.Name = "flowLayoutPanelMap";
            this.flowLayoutPanelMap.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flowLayoutPanelMap.Size = new System.Drawing.Size(516, 20);
            this.flowLayoutPanelMap.TabIndex = 6;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.c1Map1);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 20);
            this.panelMap.Margin = new System.Windows.Forms.Padding(0);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(516, 511);
            this.panelMap.TabIndex = 7;
            // 
            // MapDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMap);
            this.Name = "MapDemo";
            this.Size = new System.Drawing.Size(516, 531);
            ((System.ComponentModel.ISupportInitialize)(this.c1Map1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDemoSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkShowTools)).EndInit();
            this.tableLayoutPanelMap.ResumeLayout(false);
            this.tableLayoutPanelMap.PerformLayout();
            this.flowLayoutPanelMap.ResumeLayout(false);
            this.flowLayoutPanelMap.PerformLayout();
            this.panelMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.Map.C1Map c1Map1;
        private C1.Win.C1Input.C1ComboBox cmbSource;
        private C1.Win.C1Input.C1Label lblDemoSource;
        private C1.Win.C1Input.C1CheckBox chkShowTools;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMap;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMap;
        private System.Windows.Forms.Panel panelMap;
    }
}
