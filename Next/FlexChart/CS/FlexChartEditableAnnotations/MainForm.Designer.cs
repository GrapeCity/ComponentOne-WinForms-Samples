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
            this.pTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pDescription = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.pCollapse = new System.Windows.Forms.Panel();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.pControls = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAbsolute = new System.Windows.Forms.ToolStripButton();
            this.tsDataCoordinate = new System.Windows.Forms.ToolStripButton();
            this.tsRelative = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsText = new System.Windows.Forms.ToolStripButton();
            this.tsCircle = new System.Windows.Forms.ToolStripButton();
            this.tsEllipse = new System.Windows.Forms.ToolStripButton();
            this.tsRectangle = new System.Windows.Forms.ToolStripButton();
            this.tsSquare = new System.Windows.Forms.ToolStripButton();
            this.tsLine = new System.Windows.Forms.ToolStripButton();
            this.tsPolygon = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsAllowMove = new System.Windows.Forms.ToolStripButton();
            this.pChart = new System.Windows.Forms.Panel();
            this.flexChart1 = new C1.Win.Chart.FlexChart();
            this.pTitle.SuspendLayout();
            this.pDescription.SuspendLayout();
            this.pCollapse.SuspendLayout();
            this.pControls.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.White;
            this.pTitle.Controls.Add(this.lblTitle);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(884, 80);
            this.pTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.lblTitle.Location = new System.Drawing.Point(35, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // pDescription
            // 
            this.pDescription.AutoSize = true;
            this.pDescription.BackColor = System.Drawing.Color.White;
            this.pDescription.Controls.Add(this.tbDescription);
            this.pDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDescription.Location = new System.Drawing.Point(0, 80);
            this.pDescription.Name = "pDescription";
            this.pDescription.Padding = new System.Windows.Forms.Padding(40, 30, 40, 3);
            this.pDescription.Size = new System.Drawing.Size(884, 170);
            this.pDescription.TabIndex = 7;
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
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbDescription.Size = new System.Drawing.Size(804, 137);
            this.tbDescription.TabIndex = 3;
            this.tbDescription.TabStop = false;
            this.tbDescription.Text = "";
            // 
            // pCollapse
            // 
            this.pCollapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pCollapse.Controls.Add(this.btnCollapse);
            this.pCollapse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCollapse.Location = new System.Drawing.Point(0, 250);
            this.pCollapse.Name = "pCollapse";
            this.pCollapse.Size = new System.Drawing.Size(884, 26);
            this.pCollapse.TabIndex = 8;
            this.pCollapse.Paint += new System.Windows.Forms.PaintEventHandler(this.pCollapse_Paint);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCollapse.BackColor = System.Drawing.Color.Transparent;
            this.btnCollapse.BackgroundImage = global::FlexChartEditableAnnotations.Properties.Resources.cb_up26;
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Location = new System.Drawing.Point(415, 0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(26, 26);
            this.btnCollapse.TabIndex = 0;
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // pControls
            // 
            this.pControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pControls.Controls.Add(this.toolStrip1);
            this.pControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControls.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pControls.Location = new System.Drawing.Point(0, 276);
            this.pControls.Name = "pControls";
            this.pControls.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.pControls.Size = new System.Drawing.Size(884, 44);
            this.pControls.TabIndex = 9;
            this.pControls.WrapContents = false;
            this.pControls.Paint += new System.Windows.Forms.PaintEventHandler(this.pControls_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAbsolute,
            this.tsDataCoordinate,
            this.tsRelative,
            this.toolStripSeparator1,
            this.tsText,
            this.tsCircle,
            this.tsEllipse,
            this.tsRectangle,
            this.tsSquare,
            this.tsLine,
            this.tsPolygon,
            this.toolStripSeparator2,
            this.tsAllowMove});
            this.toolStrip1.Location = new System.Drawing.Point(40, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(308, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.OnToolstripItemClicked);
            // 
            // tsAbsolute
            // 
            this.tsAbsolute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAbsolute.Image = ((System.Drawing.Image)(resources.GetObject("tsAbsolute.Image")));
            this.tsAbsolute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAbsolute.Name = "tsAbsolute";
            this.tsAbsolute.Size = new System.Drawing.Size(23, 22);
            this.tsAbsolute.Text = "Absoute Attachment";
            // 
            // tsDataCoordinate
            // 
            this.tsDataCoordinate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsDataCoordinate.Image = ((System.Drawing.Image)(resources.GetObject("tsDataCoordinate.Image")));
            this.tsDataCoordinate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDataCoordinate.Name = "tsDataCoordinate";
            this.tsDataCoordinate.Size = new System.Drawing.Size(23, 22);
            this.tsDataCoordinate.Text = "DataCoordinate Attachment";
            // 
            // tsRelative
            // 
            this.tsRelative.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRelative.Image = ((System.Drawing.Image)(resources.GetObject("tsRelative.Image")));
            this.tsRelative.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRelative.Name = "tsRelative";
            this.tsRelative.Size = new System.Drawing.Size(23, 22);
            this.tsRelative.Text = "Relative Attachment";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsText
            // 
            this.tsText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsText.Image = ((System.Drawing.Image)(resources.GetObject("tsText.Image")));
            this.tsText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsText.Name = "tsText";
            this.tsText.Size = new System.Drawing.Size(23, 22);
            this.tsText.Text = "Add Text Annotation";
            // 
            // tsCircle
            // 
            this.tsCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsCircle.Image = ((System.Drawing.Image)(resources.GetObject("tsCircle.Image")));
            this.tsCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCircle.Name = "tsCircle";
            this.tsCircle.Size = new System.Drawing.Size(23, 22);
            this.tsCircle.Text = "Add Circle Annotation";
            // 
            // tsEllipse
            // 
            this.tsEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsEllipse.Image = ((System.Drawing.Image)(resources.GetObject("tsEllipse.Image")));
            this.tsEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEllipse.Name = "tsEllipse";
            this.tsEllipse.Size = new System.Drawing.Size(23, 22);
            this.tsEllipse.Text = "Add Ellipse Annotation";
            // 
            // tsRectangle
            // 
            this.tsRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsRectangle.Image = ((System.Drawing.Image)(resources.GetObject("tsRectangle.Image")));
            this.tsRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRectangle.Name = "tsRectangle";
            this.tsRectangle.Size = new System.Drawing.Size(23, 22);
            this.tsRectangle.Text = "Add Rectangle Annotation";
            // 
            // tsSquare
            // 
            this.tsSquare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsSquare.Image = ((System.Drawing.Image)(resources.GetObject("tsSquare.Image")));
            this.tsSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSquare.Name = "tsSquare";
            this.tsSquare.Size = new System.Drawing.Size(23, 22);
            this.tsSquare.Text = "Add Square Annotation";
            // 
            // tsLine
            // 
            this.tsLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsLine.Image = ((System.Drawing.Image)(resources.GetObject("tsLine.Image")));
            this.tsLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLine.Name = "tsLine";
            this.tsLine.Size = new System.Drawing.Size(23, 22);
            this.tsLine.Text = "Add Line Annotation";
            // 
            // tsPolygon
            // 
            this.tsPolygon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsPolygon.Image = ((System.Drawing.Image)(resources.GetObject("tsPolygon.Image")));
            this.tsPolygon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPolygon.Name = "tsPolygon";
            this.tsPolygon.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.tsPolygon.Size = new System.Drawing.Size(25, 22);
            this.tsPolygon.Text = "Add Polygon Annotation";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.Beige;
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsAllowMove
            // 
            this.tsAllowMove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsAllowMove.Image = ((System.Drawing.Image)(resources.GetObject("tsAllowMove.Image")));
            this.tsAllowMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAllowMove.Name = "tsAllowMove";
            this.tsAllowMove.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.tsAllowMove.Size = new System.Drawing.Size(30, 22);
            this.tsAllowMove.Text = "Allow moving Annotations";
            // 
            // pChart
            // 
            this.pChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pChart.Controls.Add(this.flexChart1);
            this.pChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChart.Location = new System.Drawing.Point(0, 320);
            this.pChart.Name = "pChart";
            this.pChart.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.pChart.Size = new System.Drawing.Size(884, 441);
            this.pChart.TabIndex = 13;
            // 
            // flexChart1
            // 
            this.flexChart1.AxisX.Chart = this.flexChart1;
            this.flexChart1.AxisX.DataSource = null;
            this.flexChart1.AxisX.PlotAreaName = null;
            this.flexChart1.AxisY.Chart = this.flexChart1;
            this.flexChart1.AxisY.DataSource = null;
            this.flexChart1.AxisY.PlotAreaName = null;
            this.flexChart1.BackColor = System.Drawing.Color.White;
            this.flexChart1.Binding = null;
            this.flexChart1.BindingX = null;
            this.flexChart1.DataMember = null;
            this.flexChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexChart1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flexChart1.Footer.Content = null;
            this.flexChart1.Header.Content = null;
            this.flexChart1.Legend.ItemMaxWidth = 0;
            this.flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexChart1.Legend.Position = C1.Chart.Position.Right;
            this.flexChart1.Legend.Reversed = false;
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
            this.flexChart1.Size = new System.Drawing.Size(804, 401);
            this.flexChart1.TabIndex = 0;
            // 
            // 
            // 
            this.flexChart1.ToolTip.Content = "{value}";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 761);
            this.Controls.Add(this.pChart);
            this.Controls.Add(this.pControls);
            this.Controls.Add(this.pCollapse);
            this.Controls.Add(this.pDescription);
            this.Controls.Add(this.pTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 800);
            this.Name = "MainForm";
            this.Text = "FlexChart Editable Annotations";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.BaseSample_SizeChanged);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.pDescription.ResumeLayout(false);
            this.pCollapse.ResumeLayout(false);
            this.pControls.ResumeLayout(false);
            this.pControls.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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