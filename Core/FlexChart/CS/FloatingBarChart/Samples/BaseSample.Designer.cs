namespace FloatingBarChart.Samples
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
            lblTitle = new System.Windows.Forms.Label();
            pTitle = new System.Windows.Forms.Panel();
            pScroll = new System.Windows.Forms.Panel();
            pChart = new System.Windows.Forms.Panel();
            flexChart1 = new C1.Win.Chart.FlexChart();
            pControls = new System.Windows.Forms.FlowLayoutPanel();
            pCollapse = new System.Windows.Forms.Panel();
            btnCollapse = new System.Windows.Forms.Button();
            pDescription = new System.Windows.Forms.Panel();
            tbDescription = new System.Windows.Forms.RichTextBox();
            pTitle.SuspendLayout();
            pScroll.SuspendLayout();
            pChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flexChart1).BeginInit();
            pCollapse.SuspendLayout();
            pDescription.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(21, 164, 250);
            lblTitle.Location = new System.Drawing.Point(35, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(62, 33);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Title";
            // 
            // pTitle
            // 
            pTitle.BackColor = System.Drawing.Color.White;
            pTitle.Controls.Add(lblTitle);
            pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            pTitle.Location = new System.Drawing.Point(0, 0);
            pTitle.Name = "pTitle";
            pTitle.Size = new System.Drawing.Size(815, 80);
            pTitle.TabIndex = 4;
            // 
            // pScroll
            // 
            pScroll.AutoScroll = true;
            pScroll.AutoScrollMargin = new System.Drawing.Size(0, 400);
            pScroll.Controls.Add(pChart);
            pScroll.Controls.Add(pControls);
            pScroll.Controls.Add(pCollapse);
            pScroll.Controls.Add(pDescription);
            pScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            pScroll.ForeColor = System.Drawing.Color.DimGray;
            pScroll.Location = new System.Drawing.Point(0, 80);
            pScroll.Name = "pScroll";
            pScroll.Size = new System.Drawing.Size(815, 471);
            pScroll.TabIndex = 5;
            // 
            // pChart
            // 
            pChart.BackColor = System.Drawing.Color.FromArgb(234, 242, 246);
            pChart.Controls.Add(flexChart1);
            pChart.Dock = System.Windows.Forms.DockStyle.Fill;
            pChart.Location = new System.Drawing.Point(0, 240);
            pChart.Name = "pChart";
            pChart.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            pChart.Size = new System.Drawing.Size(798, 400);
            pChart.TabIndex = 12;
            // 
            // flexChart1
            // 
            flexChart1.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            flexChart1.AnimationLoad.Duration = 400;
            flexChart1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexChart1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexChart1.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexChart1.AnimationUpdate.Duration = 400;
            flexChart1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexChart1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexChart1.AxisX.AxisLine = true;
            flexChart1.AxisX.Chart = flexChart1;
            flexChart1.AxisX.DataSource = null;
            flexChart1.AxisX.Formatter = null;
            flexChart1.AxisX.GroupProvider = null;
            flexChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart1.AxisX.GroupVisibilityLevel = 0;
            flexChart1.AxisX.PlotAreaName = null;
            flexChart1.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart1.AxisY.AxisLine = false;
            flexChart1.AxisY.Chart = flexChart1;
            flexChart1.AxisY.DataSource = null;
            flexChart1.AxisY.Formatter = null;
            flexChart1.AxisY.GroupProvider = null;
            flexChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart1.AxisY.GroupVisibilityLevel = 0;
            flexChart1.AxisY.PlotAreaName = null;
            flexChart1.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart1.BackColor = System.Drawing.Color.White;
            flexChart1.Binding = null;
            flexChart1.BindingX = null;
            flexChart1.DataLabel.Angle = 0;
            flexChart1.DataLabel.Border = false;
            flexChart1.DataLabel.ConnectingLine = false;
            flexChart1.DataLabel.Content = null;
            flexChart1.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            flexChart1.DataLabel.MaxAutoLabels = 100;
            flexChart1.DataLabel.MaxLines = 0;
            flexChart1.DataLabel.MaxWidth = 0;
            flexChart1.DataLabel.Offset = 0;
            flexChart1.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            flexChart1.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            flexChart1.DataLabel.Position = C1.Chart.LabelPosition.None;
            flexChart1.DataMember = null;
            flexChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            flexChart1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            flexChart1.Footer.Content = null;
            flexChart1.Header.Content = null;
            flexChart1.Legend.ItemMaxWidth = 0;
            flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexChart1.Legend.Position = C1.Chart.Position.Right;
            flexChart1.Legend.Reversed = false;
            flexChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexChart1.Legend.Title = null;
            flexChart1.Location = new System.Drawing.Point(40, 20);
            flexChart1.Margin = new System.Windows.Forms.Padding(10);
            flexChart1.Name = "flexChart1";
            flexChart1.Options.Chart = flexChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            flexChart1.Options.ClusterSize = elementSize1;
            flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            flexChart1.SelectedSeries = null;
            flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            flexChart1.Size = new System.Drawing.Size(718, 360);
            flexChart1.TabIndex = 1;
            flexChart1.Text = "flexPie1";
            // 
            // 
            // 
            flexChart1.ToolTip.Content = "{value}";
            // 
            // pControls
            // 
            pControls.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            pControls.Dock = System.Windows.Forms.DockStyle.Top;
            pControls.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            pControls.Location = new System.Drawing.Point(0, 196);
            pControls.Name = "pControls";
            pControls.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            pControls.Size = new System.Drawing.Size(798, 44);
            pControls.TabIndex = 7;
            pControls.WrapContents = false;
            // 
            // pCollapse
            // 
            pCollapse.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            pCollapse.Controls.Add(btnCollapse);
            pCollapse.Dock = System.Windows.Forms.DockStyle.Top;
            pCollapse.Location = new System.Drawing.Point(0, 170);
            pCollapse.Name = "pCollapse";
            pCollapse.Size = new System.Drawing.Size(798, 26);
            pCollapse.TabIndex = 5;
            pCollapse.Paint += pCollapse_Paint;
            // 
            // btnCollapse
            // 
            btnCollapse.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            btnCollapse.BackColor = System.Drawing.Color.Transparent;
            btnCollapse.BackgroundImage = Properties.Resources.cb_up26;
            btnCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnCollapse.FlatAppearance.BorderSize = 0;
            btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCollapse.Location = new System.Drawing.Point(372, 0);
            btnCollapse.Margin = new System.Windows.Forms.Padding(0);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new System.Drawing.Size(26, 26);
            btnCollapse.TabIndex = 0;
            btnCollapse.UseVisualStyleBackColor = false;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // pDescription
            // 
            pDescription.AutoSize = true;
            pDescription.BackColor = System.Drawing.Color.White;
            pDescription.Controls.Add(tbDescription);
            pDescription.Dock = System.Windows.Forms.DockStyle.Top;
            pDescription.Location = new System.Drawing.Point(0, 0);
            pDescription.Name = "pDescription";
            pDescription.Padding = new System.Windows.Forms.Padding(40, 30, 40, 3);
            pDescription.Size = new System.Drawing.Size(798, 170);
            pDescription.TabIndex = 6;
            pDescription.SizeChanged += BaseSample_SizeChanged;
            pDescription.Paint += pDescription_Paint;
            // 
            // tbDescription
            // 
            tbDescription.BackColor = System.Drawing.Color.White;
            tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbDescription.Dock = System.Windows.Forms.DockStyle.Top;
            tbDescription.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            tbDescription.ForeColor = System.Drawing.Color.DimGray;
            tbDescription.Location = new System.Drawing.Point(40, 30);
            tbDescription.Name = "tbDescription";
            tbDescription.ReadOnly = true;
            tbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            tbDescription.Size = new System.Drawing.Size(718, 137);
            tbDescription.TabIndex = 0;
            tbDescription.Text = "";
            // 
            // BaseSample
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pScroll);
            Controls.Add(pTitle);
            Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            Name = "BaseSample";
            Size = new System.Drawing.Size(815, 551);
            SizeChanged += BaseSample_SizeChanged;
            pTitle.ResumeLayout(false);
            pTitle.PerformLayout();
            pScroll.ResumeLayout(false);
            pScroll.PerformLayout();
            pChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flexChart1).EndInit();
            pCollapse.ResumeLayout(false);
            pDescription.ResumeLayout(false);
            ResumeLayout(false);
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
