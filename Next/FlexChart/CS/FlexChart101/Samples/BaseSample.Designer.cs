namespace FlexChart101.Samples
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
            this.components = new System.ComponentModel.Container();
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseSample));
            this.pMain = new System.Windows.Forms.Panel();
            this.pChart = new System.Windows.Forms.Panel();
            this.flexChart1 = new C1.Win.Chart.FlexChart();
            this.pControls = new System.Windows.Forms.FlowLayoutPanel();
            this.pCollapse = new System.Windows.Forms.Panel();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.pCode = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.pDescription = new System.Windows.Forms.Panel();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.pTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ttCopy = new System.Windows.Forms.ToolTip(this.components);
            this.pMain.SuspendLayout();
            this.pChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).BeginInit();
            this.pCollapse.SuspendLayout();
            this.pCode.SuspendLayout();
            this.pDescription.SuspendLayout();
            this.pTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.AutoScroll = true;
            this.pMain.AutoScrollMargin = new System.Drawing.Size(500, 500);
            this.pMain.Controls.Add(this.pChart);
            this.pMain.Controls.Add(this.pControls);
            this.pMain.Controls.Add(this.pCollapse);
            this.pMain.Controls.Add(this.pCode);
            this.pMain.Controls.Add(this.pDescription);
            this.pMain.Controls.Add(this.pTitle);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.ForeColor = System.Drawing.Color.DimGray;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(815, 551);
            this.pMain.TabIndex = 5;
            // 
            // pChart
            // 
            this.pChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            this.pChart.Controls.Add(this.flexChart1);
            this.pChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pChart.Location = new System.Drawing.Point(0, 425);
            this.pChart.MinimumSize = new System.Drawing.Size(500, 200);
            this.pChart.Name = "pChart";
            this.pChart.Padding = new System.Windows.Forms.Padding(40, 20, 40, 20);
            this.pChart.Size = new System.Drawing.Size(798, 500);
            this.pChart.TabIndex = 24;
            // 
            // flexChart1
            // 
            this.flexChart1.AxisX.Chart = this.flexChart1;
            this.flexChart1.AxisY.Chart = this.flexChart1;
            this.flexChart1.BackColor = System.Drawing.Color.White;
            this.flexChart1.Binding = null;
            this.flexChart1.BindingX = null;
            this.flexChart1.DataMember = null;
            this.flexChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexChart1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flexChart1.Footer.Border = false;
            this.flexChart1.Footer.Content = null;
            this.flexChart1.Footer.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.flexChart1.Header.Border = false;
            this.flexChart1.Header.Content = null;
            this.flexChart1.Header.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.flexChart1.Legend.Position = C1.Chart.Position.Right;
            this.flexChart1.Location = new System.Drawing.Point(40, 20);
            this.flexChart1.Name = "flexChart1";
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.flexChart1.Options.ClusterSize = elementSize2;
            this.flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexChart1.PlotStyle.Fill = null;
            this.flexChart1.PlotStyle.Font = null;
            this.flexChart1.PlotStyle.Stroke = null;
            this.flexChart1.PlotStyle.StrokeDashPattern = null;
            this.flexChart1.PlotStyle.StrokeWidth = 1F;
            this.flexChart1.SelectionStyle.Fill = null;
            this.flexChart1.SelectionStyle.Font = null;
            this.flexChart1.SelectionStyle.StrokeDashPattern = null;
            this.flexChart1.SelectionStyle.StrokeWidth = 1F;
            this.flexChart1.Size = new System.Drawing.Size(718, 460);
            this.flexChart1.TabIndex = 1;
            this.flexChart1.Text = "flexPie1";
            // 
            // 
            // 
            this.flexChart1.ToolTip.Content = "{value}";
            // 
            // pControls
            // 
            this.pControls.AutoSize = true;
            this.pControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pControls.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pControls.Location = new System.Drawing.Point(0, 381);
            this.pControls.MinimumSize = new System.Drawing.Size(0, 44);
            this.pControls.Name = "pControls";
            this.pControls.Padding = new System.Windows.Forms.Padding(40, 3, 40, 17);
            this.pControls.Size = new System.Drawing.Size(798, 44);
            this.pControls.TabIndex = 23;
            this.pControls.WrapContents = false;
            this.pControls.Paint += new System.Windows.Forms.PaintEventHandler(this.pControls_Paint);
            // 
            // pCollapse
            // 
            this.pCollapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pCollapse.Controls.Add(this.btnCollapse);
            this.pCollapse.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCollapse.Location = new System.Drawing.Point(0, 355);
            this.pCollapse.Name = "pCollapse";
            this.pCollapse.Size = new System.Drawing.Size(798, 26);
            this.pCollapse.TabIndex = 22;
            this.pCollapse.Paint += new System.Windows.Forms.PaintEventHandler(this.pCollapse_Paint);
            // 
            // btnCollapse
            // 
            this.btnCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCollapse.BackColor = System.Drawing.Color.Transparent;
            this.btnCollapse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCollapse.BackgroundImage")));
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.Location = new System.Drawing.Point(372, 0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(26, 26);
            this.btnCollapse.TabIndex = 0;
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // pCode
            // 
            this.pCode.BackColor = System.Drawing.Color.White;
            this.pCode.Controls.Add(this.btnCopy);
            this.pCode.Controls.Add(this.tbCode);
            this.pCode.Dock = System.Windows.Forms.DockStyle.Top;
            this.pCode.Location = new System.Drawing.Point(0, 235);
            this.pCode.Name = "pCode";
            this.pCode.Padding = new System.Windows.Forms.Padding(40, 0, 40, 15);
            this.pCode.Size = new System.Drawing.Size(798, 120);
            this.pCode.TabIndex = 21;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.Transparent;
            this.btnCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopy.BackgroundImage")));
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(225)))));
            this.btnCopy.Location = new System.Drawing.Point(660, 15);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(0);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(65, 24);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            this.btnCopy.MouseEnter += new System.EventHandler(this.btnCopy_MouseEnter);
            this.btnCopy.MouseLeave += new System.EventHandler(this.btnCopy_MouseLeave);
            // 
            // tbCode
            // 
            this.tbCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(252)))), ((int)(((byte)(225)))));
            this.tbCode.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCode.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCode.ForeColor = System.Drawing.Color.DimGray;
            this.tbCode.Location = new System.Drawing.Point(40, 0);
            this.tbCode.Multiline = true;
            this.tbCode.Name = "tbCode";
            this.tbCode.ReadOnly = true;
            this.tbCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbCode.Size = new System.Drawing.Size(718, 105);
            this.tbCode.TabIndex = 0;
            this.tbCode.TabStop = false;
            this.tbCode.Text = "Code";
            this.tbCode.SizeChanged += new System.EventHandler(this.tbCode_SizeChanged);
            // 
            // pDescription
            // 
            this.pDescription.BackColor = System.Drawing.Color.White;
            this.pDescription.Controls.Add(this.tbDescription);
            this.pDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.pDescription.Location = new System.Drawing.Point(0, 65);
            this.pDescription.Name = "pDescription";
            this.pDescription.Padding = new System.Windows.Forms.Padding(40, 30, 40, 15);
            this.pDescription.Size = new System.Drawing.Size(798, 170);
            this.pDescription.TabIndex = 13;
            this.pDescription.Paint += new System.Windows.Forms.PaintEventHandler(this.pDescription_Paint);
            // 
            // tbDescription
            // 
            this.tbDescription.BackColor = System.Drawing.Color.White;
            this.tbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDescription.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbDescription.ForeColor = System.Drawing.Color.DimGray;
            this.tbDescription.Location = new System.Drawing.Point(40, 30);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.ReadOnly = true;
            this.tbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tbDescription.Size = new System.Drawing.Size(718, 125);
            this.tbDescription.TabIndex = 0;
            this.tbDescription.TabStop = false;
            this.tbDescription.Text = "";
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.White;
            this.pTitle.Controls.Add(this.lblTitle);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(798, 65);
            this.pTitle.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(164)))), ((int)(((byte)(250)))));
            this.lblTitle.Location = new System.Drawing.Point(35, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(62, 33);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Title";
            // 
            // ttCopy
            // 
            this.ttCopy.OwnerDraw = true;
            this.ttCopy.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.ttCopy_Draw);
            this.ttCopy.Popup += new System.Windows.Forms.PopupEventHandler(this.ttCopy_Popup);
            // 
            // BaseSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pMain);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "BaseSample";
            this.Size = new System.Drawing.Size(815, 551);
            this.pMain.ResumeLayout(false);
            this.pMain.PerformLayout();
            this.pChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).EndInit();
            this.pCollapse.ResumeLayout(false);
            this.pCode.ResumeLayout(false);
            this.pCode.PerformLayout();
            this.pDescription.ResumeLayout(false);
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pMain;
        public System.Windows.Forms.Panel pDescription;
        private System.Windows.Forms.Panel pTitle;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Panel pChart;
        public C1.Win.Chart.FlexChart flexChart1;
        private System.Windows.Forms.Panel pCollapse;
        private System.Windows.Forms.Button btnCollapse;
        public System.Windows.Forms.Panel pCode;
        private System.Windows.Forms.Button btnCopy;
        public System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.ToolTip ttCopy;
        public System.Windows.Forms.RichTextBox tbDescription;
        public System.Windows.Forms.FlowLayoutPanel pControls;
    }
}
