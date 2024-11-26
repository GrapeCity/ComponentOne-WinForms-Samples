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
            this.cmbCountry = new C1.Win.C1Input.C1ComboBox();
            this.lblCountry = new C1.Win.C1Input.C1Label();
            this.c1Map1 = new C1.Win.Map.C1Map();
            this.flowLayoutPanelComboBox = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelMap = new System.Windows.Forms.TableLayoutPanel();
            this.panelMap = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCountry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Map1)).BeginInit();
            this.flowLayoutPanelComboBox.SuspendLayout();
            this.tableLayoutPanelMap.SuspendLayout();
            this.panelMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCountry
            // 
            this.cmbCountry.AllowSpinLoop = false;
            this.cmbCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCountry.GapHeight = 0;
            this.cmbCountry.ImagePadding = new System.Windows.Forms.Padding(0);
            this.cmbCountry.Items.Add("USA");
            this.cmbCountry.Items.Add("Japan");
            this.cmbCountry.Location = new System.Drawing.Point(53, 3);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(48, 19);
            this.cmbCountry.TabIndex = 1;
            this.cmbCountry.Tag = null;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // lblCountry
            // 
            this.lblCountry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(3, 1);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(44, 18);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Tag = null;
            this.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblCountry.Value = "Country:";
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
            this.c1Map1.Size = new System.Drawing.Size(410, 474);
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
            // flowLayoutPanelComboBox
            // 
            this.flowLayoutPanelComboBox.Controls.Add(this.lblCountry);
            this.flowLayoutPanelComboBox.Controls.Add(this.cmbCountry);
            this.flowLayoutPanelComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelComboBox.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanelComboBox.Margin = new System.Windows.Forms.Padding(1);
            this.flowLayoutPanelComboBox.Name = "flowLayoutPanelComboBox";
            this.flowLayoutPanelComboBox.Size = new System.Drawing.Size(408, 18);
            this.flowLayoutPanelComboBox.TabIndex = 3;
            // 
            // tableLayoutPanelMap
            // 
            this.tableLayoutPanelMap.ColumnCount = 1;
            this.tableLayoutPanelMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMap.Controls.Add(this.flowLayoutPanelComboBox, 0, 0);
            this.tableLayoutPanelMap.Controls.Add(this.panelMap, 0, 1);
            this.tableLayoutPanelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMap.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMap.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMap.Name = "tableLayoutPanelMap";
            this.tableLayoutPanelMap.RowCount = 2;
            this.tableLayoutPanelMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMap.Size = new System.Drawing.Size(410, 494);
            this.tableLayoutPanelMap.TabIndex = 4;
            // 
            // panelMap
            // 
            this.panelMap.Controls.Add(this.c1Map1);
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 20);
            this.panelMap.Margin = new System.Windows.Forms.Padding(0);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(410, 474);
            this.panelMap.TabIndex = 4;
            // 
            // MapShape
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMap);
            this.Name = "MapShape";
            this.Size = new System.Drawing.Size(410, 494);
            ((System.ComponentModel.ISupportInitialize)(this.cmbCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblCountry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Map1)).EndInit();
            this.flowLayoutPanelComboBox.ResumeLayout(false);
            this.tableLayoutPanelMap.ResumeLayout(false);
            this.panelMap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1ComboBox cmbCountry;
        private C1.Win.C1Input.C1Label lblCountry;
        private C1.Win.Map.C1Map c1Map1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMap;
        private System.Windows.Forms.Panel panelMap;
    }
}
