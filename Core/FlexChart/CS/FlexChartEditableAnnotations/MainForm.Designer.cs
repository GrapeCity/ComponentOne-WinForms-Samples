namespace FlexChartEditableAnnotations
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            pTitle = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            pDescription = new System.Windows.Forms.Panel();
            tbDescription = new System.Windows.Forms.RichTextBox();
            pCollapse = new System.Windows.Forms.Panel();
            btnCollapse = new System.Windows.Forms.Button();
            pControls = new System.Windows.Forms.FlowLayoutPanel();
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            tsAbsolute = new System.Windows.Forms.ToolStripButton();
            tsDataCoordinate = new System.Windows.Forms.ToolStripButton();
            tsRelative = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            tsText = new System.Windows.Forms.ToolStripButton();
            tsCircle = new System.Windows.Forms.ToolStripButton();
            tsEllipse = new System.Windows.Forms.ToolStripButton();
            tsRectangle = new System.Windows.Forms.ToolStripButton();
            tsSquare = new System.Windows.Forms.ToolStripButton();
            tsLine = new System.Windows.Forms.ToolStripButton();
            tsPolygon = new System.Windows.Forms.ToolStripButton();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            tsAllowMove = new System.Windows.Forms.ToolStripButton();
            pChart = new System.Windows.Forms.Panel();
            flexChart1 = new C1.Win.Chart.FlexChart();
            pTitle.SuspendLayout();
            pDescription.SuspendLayout();
            pCollapse.SuspendLayout();
            pControls.SuspendLayout();
            toolStrip1.SuspendLayout();
            pChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flexChart1).BeginInit();
            SuspendLayout();
            // 
            // pTitle
            // 
            pTitle.BackColor = System.Drawing.Color.White;
            pTitle.Controls.Add(lblTitle);
            pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            pTitle.Location = new System.Drawing.Point(0, 0);
            pTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pTitle.Name = "pTitle";
            pTitle.Size = new System.Drawing.Size(1031, 92);
            pTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Calibri", 20F);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(21, 164, 250);
            lblTitle.Location = new System.Drawing.Point(41, 39);
            lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(62, 33);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title";
            // 
            // pDescription
            // 
            pDescription.AutoSize = true;
            pDescription.BackColor = System.Drawing.Color.White;
            pDescription.Controls.Add(tbDescription);
            pDescription.Dock = System.Windows.Forms.DockStyle.Top;
            pDescription.Location = new System.Drawing.Point(0, 92);
            pDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pDescription.Name = "pDescription";
            pDescription.Padding = new System.Windows.Forms.Padding(47, 35, 47, 3);
            pDescription.Size = new System.Drawing.Size(1031, 196);
            pDescription.TabIndex = 7;
            pDescription.Paint += pDescription_Paint;
            // 
            // tbDescription
            // 
            tbDescription.BackColor = System.Drawing.Color.White;
            tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tbDescription.Dock = System.Windows.Forms.DockStyle.Top;
            tbDescription.Font = new System.Drawing.Font("Calibri", 10F);
            tbDescription.ForeColor = System.Drawing.Color.DimGray;
            tbDescription.Location = new System.Drawing.Point(47, 35);
            tbDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbDescription.Name = "tbDescription";
            tbDescription.ReadOnly = true;
            tbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            tbDescription.Size = new System.Drawing.Size(937, 158);
            tbDescription.TabIndex = 3;
            tbDescription.TabStop = false;
            tbDescription.Text = "";
            // 
            // pCollapse
            // 
            pCollapse.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            pCollapse.Controls.Add(btnCollapse);
            pCollapse.Dock = System.Windows.Forms.DockStyle.Top;
            pCollapse.Location = new System.Drawing.Point(0, 288);
            pCollapse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pCollapse.Name = "pCollapse";
            pCollapse.Size = new System.Drawing.Size(1031, 30);
            pCollapse.TabIndex = 8;
            pCollapse.Paint += pCollapse_Paint;
            // 
            // btnCollapse
            // 
            btnCollapse.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom;
            btnCollapse.BackColor = System.Drawing.Color.Transparent;
            btnCollapse.BackgroundImage = Properties.Resources.cb_up26;
            btnCollapse.FlatAppearance.BorderSize = 0;
            btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCollapse.Location = new System.Drawing.Point(484, 0);
            btnCollapse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCollapse.Name = "btnCollapse";
            btnCollapse.Size = new System.Drawing.Size(30, 30);
            btnCollapse.TabIndex = 0;
            btnCollapse.UseVisualStyleBackColor = false;
            btnCollapse.Click += btnCollapse_Click;
            // 
            // pControls
            // 
            pControls.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            pControls.Controls.Add(toolStrip1);
            pControls.Dock = System.Windows.Forms.DockStyle.Top;
            pControls.Font = new System.Drawing.Font("Calibri", 9F);
            pControls.Location = new System.Drawing.Point(0, 318);
            pControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pControls.Name = "pControls";
            pControls.Padding = new System.Windows.Forms.Padding(47, 0, 0, 0);
            pControls.Size = new System.Drawing.Size(1031, 51);
            pControls.TabIndex = 9;
            pControls.WrapContents = false;
            pControls.Paint += pControls_Paint;
            // 
            // toolStrip1
            // 
            toolStrip1.CanOverflow = false;
            toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsAbsolute, tsDataCoordinate, tsRelative, toolStripSeparator1, tsText, tsCircle, tsEllipse, tsRectangle, tsSquare, tsLine, tsPolygon, toolStripSeparator2, tsAllowMove });
            toolStrip1.Location = new System.Drawing.Point(47, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(277, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += OnToolstripItemClicked;
            // 
            // tsAbsolute
            // 
            tsAbsolute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsAbsolute.Image = (System.Drawing.Image)resources.GetObject("tsAbsolute.Image");
            tsAbsolute.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsAbsolute.Name = "tsAbsolute";
            tsAbsolute.Size = new System.Drawing.Size(23, 22);
            tsAbsolute.Text = "Absoute Attachment";
            // 
            // tsDataCoordinate
            // 
            tsDataCoordinate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsDataCoordinate.Image = (System.Drawing.Image)resources.GetObject("tsDataCoordinate.Image");
            tsDataCoordinate.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsDataCoordinate.Name = "tsDataCoordinate";
            tsDataCoordinate.Size = new System.Drawing.Size(23, 22);
            tsDataCoordinate.Text = "DataCoordinate Attachment";
            // 
            // tsRelative
            // 
            tsRelative.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsRelative.Image = (System.Drawing.Image)resources.GetObject("tsRelative.Image");
            tsRelative.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsRelative.Name = "tsRelative";
            tsRelative.Size = new System.Drawing.Size(23, 22);
            tsRelative.Text = "Relative Attachment";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsText
            // 
            tsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsText.Image = (System.Drawing.Image)resources.GetObject("tsText.Image");
            tsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsText.Name = "tsText";
            tsText.Size = new System.Drawing.Size(23, 22);
            tsText.Text = "Add Text Annotation";
            // 
            // tsCircle
            // 
            tsCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsCircle.Image = (System.Drawing.Image)resources.GetObject("tsCircle.Image");
            tsCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsCircle.Name = "tsCircle";
            tsCircle.Size = new System.Drawing.Size(23, 22);
            tsCircle.Text = "Add Circle Annotation";
            // 
            // tsEllipse
            // 
            tsEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsEllipse.Image = (System.Drawing.Image)resources.GetObject("tsEllipse.Image");
            tsEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsEllipse.Name = "tsEllipse";
            tsEllipse.Size = new System.Drawing.Size(23, 22);
            tsEllipse.Text = "Add Ellipse Annotation";
            // 
            // tsRectangle
            // 
            tsRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsRectangle.Image = (System.Drawing.Image)resources.GetObject("tsRectangle.Image");
            tsRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsRectangle.Name = "tsRectangle";
            tsRectangle.Size = new System.Drawing.Size(23, 22);
            tsRectangle.Text = "Add Rectangle Annotation";
            // 
            // tsSquare
            // 
            tsSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsSquare.Image = (System.Drawing.Image)resources.GetObject("tsSquare.Image");
            tsSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsSquare.Name = "tsSquare";
            tsSquare.Size = new System.Drawing.Size(23, 22);
            tsSquare.Text = "Add Square Annotation";
            // 
            // tsLine
            // 
            tsLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsLine.Image = (System.Drawing.Image)resources.GetObject("tsLine.Image");
            tsLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsLine.Name = "tsLine";
            tsLine.Size = new System.Drawing.Size(23, 22);
            tsLine.Text = "Add Line Annotation";
            // 
            // tsPolygon
            // 
            tsPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsPolygon.Image = (System.Drawing.Image)resources.GetObject("tsPolygon.Image");
            tsPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsPolygon.Name = "tsPolygon";
            tsPolygon.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            tsPolygon.Size = new System.Drawing.Size(25, 22);
            tsPolygon.Text = "Add Polygon Annotation";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.BackColor = System.Drawing.Color.Beige;
            toolStripSeparator2.ForeColor = System.Drawing.Color.DarkTurquoise;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsAllowMove
            // 
            tsAllowMove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            tsAllowMove.Image = (System.Drawing.Image)resources.GetObject("tsAllowMove.Image");
            tsAllowMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            tsAllowMove.Name = "tsAllowMove";
            tsAllowMove.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            tsAllowMove.Size = new System.Drawing.Size(30, 22);
            tsAllowMove.Text = "Allow moving Annotations";
            // 
            // pChart
            // 
            pChart.BackColor = System.Drawing.Color.FromArgb(234, 242, 246);
            pChart.Controls.Add(flexChart1);
            pChart.Dock = System.Windows.Forms.DockStyle.Fill;
            pChart.Location = new System.Drawing.Point(0, 369);
            pChart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pChart.Name = "pChart";
            pChart.Padding = new System.Windows.Forms.Padding(47, 23, 47, 23);
            pChart.Size = new System.Drawing.Size(1031, 509);
            pChart.TabIndex = 13;
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
            flexChart1.Font = new System.Drawing.Font("Calibri", 10F);
            flexChart1.Footer.Content = null;
            flexChart1.Header.Content = null;
            flexChart1.Legend.ItemMaxWidth = 0;
            flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexChart1.Legend.Position = C1.Chart.Position.Right;
            flexChart1.Legend.Reversed = false;
            flexChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexChart1.Legend.Title = null;
            flexChart1.Location = new System.Drawing.Point(47, 23);
            flexChart1.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            flexChart1.Name = "flexChart1";
            flexChart1.Options.Chart = flexChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            flexChart1.Options.ClusterSize = elementSize1;
            flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            flexChart1.SelectedSeries = null;
            flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            flexChart1.Size = new System.Drawing.Size(937, 463);
            flexChart1.TabIndex = 0;
            // 
            // 
            // 
            flexChart1.ToolTip.Content = "{value}";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1031, 878);
            Controls.Add(pChart);
            Controls.Add(pControls);
            Controls.Add(pCollapse);
            Controls.Add(pDescription);
            Controls.Add(pTitle);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(1047, 917);
            Name = "MainForm";
            Text = "FlexChart Editable Annotations";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            SizeChanged += BaseSample_SizeChanged;
            pTitle.ResumeLayout(false);
            pTitle.PerformLayout();
            pDescription.ResumeLayout(false);
            pCollapse.ResumeLayout(false);
            pControls.ResumeLayout(false);
            pControls.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            pChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flexChart1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel pChart;
        public System.Windows.Forms.FlowLayoutPanel pControls;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Panel pCollapse;
        public System.Windows.Forms.RichTextBox tbDescription;
        public System.Windows.Forms.Panel pDescription;
        public System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.ToolStripButton tsAllowMove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsPolygon;
        private System.Windows.Forms.ToolStripButton tsLine;
        private System.Windows.Forms.ToolStripButton tsSquare;
        private System.Windows.Forms.ToolStripButton tsRectangle;
        private System.Windows.Forms.ToolStripButton tsEllipse;
        private System.Windows.Forms.ToolStripButton tsCircle;
        private System.Windows.Forms.ToolStripButton tsText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsRelative;
        private System.Windows.Forms.ToolStripButton tsDataCoordinate;
        private System.Windows.Forms.ToolStripButton tsAbsolute;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private C1.Win.Chart.FlexChart flexChart1;
    }
}