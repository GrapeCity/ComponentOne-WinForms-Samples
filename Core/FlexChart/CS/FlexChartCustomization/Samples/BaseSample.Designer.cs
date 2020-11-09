namespace FlexChartCustomization.Samples
{
    partial class BaseSample
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
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseSample));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pTitle = new System.Windows.Forms.Panel();
            this.pScroll = new System.Windows.Forms.Panel();
            this.pChart = new System.Windows.Forms.Panel();
            this.flexChart1 = new C1.Win.Chart.FlexChart();
            this.pControls = new System.Windows.Forms.FlowLayoutPanel();
            this.pCollapse = new System.Windows.Forms.Panel();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.pDescription = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.pTitle.SuspendLayout();
            this.pScroll.SuspendLayout();
            this.pChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).BeginInit();
            this.pCollapse.SuspendLayout();
            this.pDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.lblTitle.Location = new System.Drawing.Point(35, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 49);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Title";
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.White;
            this.pTitle.Controls.Add(this.lblTitle);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(815, 80);
            this.pTitle.TabIndex = 4;
            // 
            // pScroll
            // 
            this.pScroll.AutoScroll = true;
            this.pScroll.AutoScrollMargin = new System.Drawing.Size(0, 400);
            this.pScroll.Controls.Add(this.pChart);
            this.pScroll.Controls.Add(this.pControls);
            this.pScroll.Controls.Add(this.pCollapse);
            this.pScroll.Controls.Add(this.pDescription);
            this.pScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pScroll.ForeColor = System.Drawing.Color.DimGray;
            this.pScroll.Location = new System.Drawing.Point(0, 80);
            this.pScroll.Name = "pScroll";
            this.pScroll.Size = new System.Drawing.Size(815, 471);
            this.pScroll.TabIndex = 5;
            // 
            // pChart
            // 
            this.pChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pChart.Controls.Add(this.flexChart1);
            this.pChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChart.Location = new System.Drawing.Point(0, 240);
            this.pChart.Name = "pChart";
            this.pChart.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.pChart.Size = new System.Drawing.Size(789, 400);
            this.pChart.TabIndex = 12;
            // 
            // flexChart1
            // 
            this.flexChart1.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.flexChart1.AnimationLoad.Duration = 400;
            this.flexChart1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.flexChart1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.flexChart1.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.flexChart1.AnimationUpdate.Duration = 400;
            this.flexChart1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.flexChart1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.flexChart1.AxisX.Chart = this.flexChart1;
            this.flexChart1.AxisX.DataSource = null;
            this.flexChart1.AxisX.GroupProvider = null;
            this.flexChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.flexChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.flexChart1.AxisX.GroupVisibilityLevel = 0;
            this.flexChart1.AxisX.LabelMax = false;
            this.flexChart1.AxisX.LabelMin = false;
            this.flexChart1.AxisX.PlotAreaName = null;
            this.flexChart1.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.flexChart1.AxisY.Chart = this.flexChart1;
            this.flexChart1.AxisY.DataSource = null;
            this.flexChart1.AxisY.GroupProvider = null;
            this.flexChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.flexChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.flexChart1.AxisY.GroupVisibilityLevel = 0;
            this.flexChart1.AxisY.LabelMax = false;
            this.flexChart1.AxisY.LabelMin = false;
            this.flexChart1.AxisY.PlotAreaName = null;
            this.flexChart1.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.flexChart1.BackColor = System.Drawing.Color.White;
            this.flexChart1.Binding = null;
            this.flexChart1.BindingX = null;
            this.flexChart1.DataLabel.Angle = 0;
            this.flexChart1.DataLabel.Border = false;
            this.flexChart1.DataLabel.ConnectingLine = false;
            this.flexChart1.DataLabel.Content = null;
            this.flexChart1.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.flexChart1.DataLabel.MaxAutoLabels = 100;
            this.flexChart1.DataLabel.MaxLines = 0;
            this.flexChart1.DataLabel.MaxWidth = 0;
            this.flexChart1.DataLabel.Offset = 0;
            this.flexChart1.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.flexChart1.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.flexChart1.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.flexChart1.DataMember = null;
            this.flexChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexChart1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flexChart1.Footer.Content = null;
            this.flexChart1.Header.Content = null;
            this.flexChart1.Legend.ItemMaxWidth = 0;
            this.flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexChart1.Legend.Position = C1.Chart.Position.Right;
            this.flexChart1.Legend.Reversed = false;
            this.flexChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.flexChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.flexChart1.Legend.Title = null;
            this.flexChart1.Location = new System.Drawing.Point(40, 20);
            this.flexChart1.Margin = new System.Windows.Forms.Padding(10);
            this.flexChart1.Name = "flexChart1";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.flexChart1.Options.ClusterSize = elementSize1;
            this.flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexChart1.SelectedSeries = null;
            this.flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.flexChart1.Size = new System.Drawing.Size(709, 360);
            this.flexChart1.TabIndex = 1;
            this.flexChart1.Text = "flexPie1";
            // 
            // 
            // 
            this.flexChart1.ToolTip.Content = "{value}";
            // 
            // pControls
            // 
            this.pControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControls.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pControls.Location = new System.Drawing.Point(0, 196);
            this.pControls.Name = "pControls";
            this.pControls.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.pControls.Size = new System.Drawing.Size(789, 44);
            this.pControls.TabIndex = 7;
            this.pControls.WrapContents = false;
            // 
            // pCollapse
            // 
            this.pCollapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pCollapse.Controls.Add(this.btnCollapse);
            this.pCollapse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCollapse.Location = new System.Drawing.Point(0, 170);
            this.pCollapse.Name = "pCollapse";
            this.pCollapse.Size = new System.Drawing.Size(789, 26);
            this.pCollapse.TabIndex = 5;
            this.pCollapse.Paint += new System.Windows.Forms.PaintEventHandler(this.pCollapse_Paint);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCollapse.BackColor = System.Drawing.Color.Transparent;
            this.btnCollapse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCollapse.BackgroundImage")));
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Location = new System.Drawing.Point(367, 0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(26, 26);
            this.btnCollapse.TabIndex = 0;
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // pDescription
            // 
            this.pDescription.AutoSize = true;
            this.pDescription.BackColor = System.Drawing.Color.White;
            this.pDescription.Controls.Add(this.tbDescription);
            this.pDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDescription.Location = new System.Drawing.Point(0, 0);
            this.pDescription.Name = "pDescription";
            this.pDescription.Padding = new System.Windows.Forms.Padding(40, 30, 40, 3);
            this.pDescription.Size = new System.Drawing.Size(789, 170);
            this.pDescription.TabIndex = 6;
            this.pDescription.SizeChanged += new System.EventHandler(this.BaseSample_SizeChanged);
            this.pDescription.Paint += new System.Windows.Forms.PaintEventHandler(this.pDescription_Paint);
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.White;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbDescription.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescription.ForeColor = System.Drawing.Color.DimGray;
            this.tbDescription.Location = new System.Drawing.Point(40, 30);
            this.tbDescription.MinimumSize = new System.Drawing.Size(0, 60);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbDescription.Size = new System.Drawing.Size(709, 137);
            this.tbDescription.TabIndex = 0;
            this.tbDescription.Text = "";
            // 
            // BaseSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pScroll);
            this.Controls.Add(this.pTitle);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "BaseSample";
            this.Size = new System.Drawing.Size(815, 551);
            this.SizeChanged += new System.EventHandler(this.BaseSample_SizeChanged);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.pScroll.ResumeLayout(false);
            this.pScroll.PerformLayout();
            this.pChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).EndInit();
            this.pCollapse.ResumeLayout(false);
            this.pDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pTitle;
        public System.Windows.Forms.Panel pScroll;
        public System.Windows.Forms.Panel pDescription;
        private System.Windows.Forms.Panel pCollapse;
        private System.Windows.Forms.Button btnCollapse;
        public System.Windows.Forms.Panel pChart;
        public C1.Win.Chart.FlexChart flexChart1;
        public System.Windows.Forms.FlowLayoutPanel pControls;
        public System.Windows.Forms.RichTextBox tbDescription;
    }
}
