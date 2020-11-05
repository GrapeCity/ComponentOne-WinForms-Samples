namespace FlexChartPrint.Samples
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
            this.splitBase = new System.Windows.Forms.SplitContainer();
            this.labTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPageSetup = new System.Windows.Forms.Button();
            this.chkScrollbar = new System.Windows.Forms.CheckBox();
            this.btnPrinterSetup = new System.Windows.Forms.Button();
            this.flexChart1 = new C1.Win.Chart.FlexChart();
            ((System.ComponentModel.ISupportInitialize)(this.splitBase)).BeginInit();
            this.splitBase.Panel1.SuspendLayout();
            this.splitBase.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitBase
            // 
            this.splitBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitBase.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitBase.IsSplitterFixed = true;
            this.splitBase.Location = new System.Drawing.Point(0, 0);
            this.splitBase.Name = "splitBase";
            this.splitBase.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitBase.Panel1
            // 
            this.splitBase.Panel1.Controls.Add(this.labTitle);
            this.splitBase.Panel1.Controls.Add(this.panel1);
            this.splitBase.Panel1.Controls.Add(this.flexChart1);
            this.splitBase.Panel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitBase.Size = new System.Drawing.Size(540, 700);
            this.splitBase.SplitterDistance = 467;
            this.splitBase.SplitterWidth = 1;
            this.splitBase.TabIndex = 0;
            // 
            // labTitle
            // 
            this.labTitle.AutoSize = true;
            this.labTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(152)))), ((int)(((byte)(232)))));
            this.labTitle.Location = new System.Drawing.Point(15, 24);
            this.labTitle.Name = "labTitle";
            this.labTitle.Size = new System.Drawing.Size(52, 30);
            this.labTitle.TabIndex = 5;
            this.labTitle.Text = "Title";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.panel1.Controls.Add(this.btnPageSetup);
            this.panel1.Controls.Add(this.chkScrollbar);
            this.panel1.Controls.Add(this.btnPrinterSetup);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 51);
            this.panel1.TabIndex = 4;
            // 
            // btnPageSetup
            // 
            this.btnPageSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPageSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(152)))), ((int)(((byte)(232)))));
            this.btnPageSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPageSetup.Location = new System.Drawing.Point(15, 12);
            this.btnPageSetup.Name = "btnPageSetup";
            this.btnPageSetup.Size = new System.Drawing.Size(124, 28);
            this.btnPageSetup.TabIndex = 1;
            this.btnPageSetup.Text = "Page Setup";
            this.btnPageSetup.UseVisualStyleBackColor = true;
            this.btnPageSetup.Click += new System.EventHandler(this.btnPageSetup_Click);
            // 
            // chkScrollbar
            // 
            this.chkScrollbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkScrollbar.AutoSize = true;
            this.chkScrollbar.Location = new System.Drawing.Point(358, 19);
            this.chkScrollbar.Name = "chkScrollbar";
            this.chkScrollbar.Size = new System.Drawing.Size(116, 17);
            this.chkScrollbar.TabIndex = 3;
            this.chkScrollbar.Text = "Use Axis Scrollbar";
            this.chkScrollbar.UseVisualStyleBackColor = true;
            this.chkScrollbar.CheckedChanged += new System.EventHandler(this.chkScrollbar_CheckedChanged);
            // 
            // btnPrinterSetup
            // 
            this.btnPrinterSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrinterSetup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(152)))), ((int)(((byte)(232)))));
            this.btnPrinterSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrinterSetup.Location = new System.Drawing.Point(145, 12);
            this.btnPrinterSetup.Name = "btnPrinterSetup";
            this.btnPrinterSetup.Size = new System.Drawing.Size(112, 28);
            this.btnPrinterSetup.TabIndex = 2;
            this.btnPrinterSetup.Text = "Printer Setup";
            this.btnPrinterSetup.UseVisualStyleBackColor = true;
            this.btnPrinterSetup.Click += new System.EventHandler(this.btnPrinterSetup_Click);
            // 
            // flexChart1
            // 
            this.flexChart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flexChart1.AxisX.Chart = this.flexChart1;
            this.flexChart1.AxisX.DataSource = null;
            this.flexChart1.AxisX.PlotAreaName = null;
            this.flexChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.flexChart1.AxisY.AxisLine = false;
            this.flexChart1.AxisY.Chart = this.flexChart1;
            this.flexChart1.AxisY.DataSource = null;
            this.flexChart1.AxisY.MajorGrid = true;
            this.flexChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.flexChart1.AxisY.PlotAreaName = null;
            this.flexChart1.AxisY.Position = C1.Chart.Position.Left;
            this.flexChart1.Legend.ItemMaxWidth = 0;
            this.flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexChart1.Legend.Position = C1.Chart.Position.Right;
            this.flexChart1.Legend.Reversed = false;
            this.flexChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.flexChart1.Legend.Title = null;
            this.flexChart1.Location = new System.Drawing.Point(15, 65);
            this.flexChart1.Margin = new System.Windows.Forms.Padding(10);
            this.flexChart1.Name = "flexChart1";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.flexChart1.Options.ClusterSize = elementSize1;
            this.flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexChart1.SelectedSeries = null;
            this.flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.flexChart1.Size = new System.Drawing.Size(490, 340);
            this.flexChart1.TabIndex = 0;
            // 
            // 
            // 
            this.flexChart1.ToolTip.Content = "{value}";
            // 
            // BaseSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.splitBase);
            this.Name = "BaseSample";
            this.Size = new System.Drawing.Size(540, 700);
            this.splitBase.Panel1.ResumeLayout(false);
            this.splitBase.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitBase)).EndInit();
            this.splitBase.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitBase;
        private System.Windows.Forms.CheckBox chkScrollbar;
        private System.Windows.Forms.Button btnPrinterSetup;
        private System.Windows.Forms.Button btnPageSetup;
        private C1.Win.Chart.FlexChart flexChart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labTitle;
    }
}
