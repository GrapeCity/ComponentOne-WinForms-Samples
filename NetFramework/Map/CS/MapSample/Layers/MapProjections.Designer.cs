namespace MapSample.Layers
{
    partial class MapProjections
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
            this.cmbProjection = new C1.Win.C1Input.C1ComboBox();
            this.lblProjection = new C1.Win.C1Input.C1Label();
            this.c1Map1 = new C1.Win.Map.C1Map();
            this.flowLayoutPanelMap = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelMap = new System.Windows.Forms.TableLayoutPanel();
            this.panelMap = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProjection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Map1)).BeginInit();
            this.flowLayoutPanelMap.SuspendLayout();
            this.tableLayoutPanelMap.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbProjection
            // 
            this.cmbProjection.AllowSpinLoop = false;
            this.cmbProjection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProjection.GapHeight = 0;
            this.cmbProjection.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbProjection.Items.Add("Mercator");
            this.cmbProjection.Items.Add("Gall Peters");
            this.cmbProjection.Items.Add("Sinusoidal");
            this.cmbProjection.Items.Add("Bonne");
            this.cmbProjection.Location = new System.Drawing.Point(58, 4);
            this.cmbProjection.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.cmbProjection.Name = "cmbProjection";
            this.cmbProjection.Size = new System.Drawing.Size(65, 29);
            this.cmbProjection.TabIndex = 1;
            this.cmbProjection.Tag = null;
            this.cmbProjection.SelectedIndexChanged += new System.EventHandler(this.cmbProjection_SelectedIndexChanged);
            // 
            // lblProjection
            // 
            this.lblProjection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblProjection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjection.Location = new System.Drawing.Point(1, 2);
            this.lblProjection.Margin = new System.Windows.Forms.Padding(1);
            this.lblProjection.Name = "lblProjection";
            this.lblProjection.Size = new System.Drawing.Size(55, 21);
            this.lblProjection.TabIndex = 0;
            this.lblProjection.Tag = null;
            this.lblProjection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProjection.Value = "Projection:";
            // 
            // c1Map1
            // 
            this.c1Map1.DistanceScale.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.c1Map1.DistanceScale.BarStyle.BackColor = System.Drawing.Color.Black;
            this.c1Map1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Map1.Location = new System.Drawing.Point(0, 0);
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
            this.c1Map1.Size = new System.Drawing.Size(395, 418);
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
            // flowLayoutPanelMap
            // 
            this.flowLayoutPanelMap.Controls.Add(this.lblProjection);
            this.flowLayoutPanelMap.Controls.Add(this.cmbProjection);
            this.flowLayoutPanelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMap.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMap.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelMap.Name = "flowLayoutPanelMap";
            this.flowLayoutPanelMap.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.flowLayoutPanelMap.Size = new System.Drawing.Size(395, 20);
            this.flowLayoutPanelMap.TabIndex = 3;
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
            this.tableLayoutPanelMap.Size = new System.Drawing.Size(395, 438);
            this.tableLayoutPanelMap.TabIndex = 4;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.c1Map1);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 20);
            this.panelMap.Margin = new System.Windows.Forms.Padding(0);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(395, 418);
            this.panelMap.TabIndex = 4;
            // 
            // MapProjections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMap);
            this.Name = "MapProjections";
            this.Size = new System.Drawing.Size(395, 438);
            ((System.ComponentModel.ISupportInitialize)(this.cmbProjection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProjection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Map1)).EndInit();
            this.flowLayoutPanelMap.ResumeLayout(false);
            this.tableLayoutPanelMap.ResumeLayout(false);
            this.panelMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1ComboBox cmbProjection;
        private C1.Win.C1Input.C1Label lblProjection;
        private C1.Win.Map.C1Map c1Map1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMap;
        private System.Windows.Forms.Panel panelMap;
    }
}
