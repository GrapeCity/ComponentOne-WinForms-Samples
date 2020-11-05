namespace StockAnalysis
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
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxTitle = new System.Windows.Forms.PictureBox();
            this.financialChart = new C1.Win.Chart.Finance.FinancialChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxSecurityIcon = new System.Windows.Forms.PictureBox();
            this.btnOptions = new System.Windows.Forms.Button();
            this.btnIndicators = new System.Windows.Forms.Button();
            this.btnOverlays = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labAnnotationType = new System.Windows.Forms.Label();
            this.cboAnnoType = new System.Windows.Forms.ComboBox();
            this.rangeChart = new C1.Win.Chart.Finance.FinancialChart();
            this.btnAnnoStroke = new System.Windows.Forms.Button();
            this.btnAnnoFill = new System.Windows.Forms.Button();
            this.btnAnnoFont = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecurityIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rangeChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.financialChart, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rangeChart, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1124, 706);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBoxTitle
            // 
            this.pictureBoxTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBoxTitle, 2);
            this.pictureBoxTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTitle.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxTitle.Name = "pictureBoxTitle";
            this.pictureBoxTitle.Size = new System.Drawing.Size(1124, 50);
            this.pictureBoxTitle.TabIndex = 0;
            this.pictureBoxTitle.TabStop = false;
            // 
            // financialChart
            // 
            this.financialChart.AxisX.Chart = this.financialChart;
            this.financialChart.AxisX.DataSource = null;
            this.financialChart.AxisX.GroupProvider = null;
            this.financialChart.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.financialChart.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.financialChart.AxisX.PlotAreaName = null;
            this.financialChart.AxisX.Position = C1.Chart.Position.Bottom;
            this.financialChart.AxisY.Chart = this.financialChart;
            this.financialChart.AxisY.DataSource = null;
            this.financialChart.AxisY.GroupProvider = null;
            this.financialChart.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.financialChart.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.financialChart.AxisY.MajorGrid = true;
            this.financialChart.AxisY.PlotAreaName = null;
            this.financialChart.AxisY.Position = C1.Chart.Position.Right;
            this.financialChart.ChartType = C1.Chart.Finance.FinancialChartType.Candlestick;
            this.financialChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialChart.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.financialChart.Legend.ItemMaxWidth = 0;
            this.financialChart.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.financialChart.Legend.Position = C1.Chart.Position.None;
            this.financialChart.Legend.Reversed = false;
            this.financialChart.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.financialChart.Legend.Title = null;
            this.financialChart.Location = new System.Drawing.Point(260, 126);
            this.financialChart.Margin = new System.Windows.Forms.Padding(10);
            this.financialChart.Name = "financialChart";
            this.financialChart.Options.BoxSize = 2D;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.financialChart.Options.ClusterSize = elementSize1;
            this.financialChart.Options.ReversalAmount = 2D;
            this.financialChart.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart.SelectedSeries = null;
            this.financialChart.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series1.DataLabel = null;
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            this.financialChart.Series.Add(series1);
            this.financialChart.Size = new System.Drawing.Size(854, 510);
            this.financialChart.TabIndex = 1;
            this.financialChart.Text = "chart1";
            // 
            // 
            // 
            this.financialChart.ToolTip.Content = "{value}";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 119);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(244, 584);
            this.panel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBoxSecurityIcon, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOptions, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnIndicators, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnOverlays, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(250, 50);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(874, 66);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // pictureBoxSecurityIcon
            // 
            this.pictureBoxSecurityIcon.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxSecurityIcon.Name = "pictureBoxSecurityIcon";
            this.pictureBoxSecurityIcon.Size = new System.Drawing.Size(350, 30);
            this.pictureBoxSecurityIcon.TabIndex = 0;
            this.pictureBoxSecurityIcon.TabStop = false;
            // 
            // btnOptions
            // 
            this.btnOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOptions.FlatAppearance.BorderSize = 0;
            this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptions.Location = new System.Drawing.Point(557, 3);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(94, 30);
            this.btnOptions.TabIndex = 1;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            // 
            // btnIndicators
            // 
            this.btnIndicators.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIndicators.FlatAppearance.BorderSize = 0;
            this.btnIndicators.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndicators.Location = new System.Drawing.Point(657, 3);
            this.btnIndicators.Name = "btnIndicators";
            this.btnIndicators.Size = new System.Drawing.Size(94, 30);
            this.btnIndicators.TabIndex = 2;
            this.btnIndicators.Text = "Indicators";
            this.btnIndicators.UseVisualStyleBackColor = true;
            // 
            // btnOverlays
            // 
            this.btnOverlays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOverlays.FlatAppearance.BorderSize = 0;
            this.btnOverlays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOverlays.Location = new System.Drawing.Point(757, 3);
            this.btnOverlays.Name = "btnOverlays";
            this.btnOverlays.Size = new System.Drawing.Size(94, 30);
            this.btnOverlays.TabIndex = 3;
            this.btnOverlays.Text = "Overlays";
            this.btnOverlays.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAnnoFont);
            this.panel2.Controls.Add(this.btnAnnoFill);
            this.panel2.Controls.Add(this.btnAnnoStroke);
            this.panel2.Controls.Add(this.labAnnotationType);
            this.panel2.Controls.Add(this.cboAnnoType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 24);
            this.panel2.TabIndex = 4;
            // 
            // labAnnotationType
            // 
            this.labAnnotationType.Location = new System.Drawing.Point(6, 4);
            this.labAnnotationType.Name = "labAnnotationType";
            this.labAnnotationType.Size = new System.Drawing.Size(94, 20);
            this.labAnnotationType.TabIndex = 1;
            this.labAnnotationType.Text = "Annotation Type:";
            this.labAnnotationType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboAnnoType
            // 
            this.cboAnnoType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAnnoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnnoType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAnnoType.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnnoType.FormattingEnabled = true;
            this.cboAnnoType.ItemHeight = 20;
            this.cboAnnoType.Location = new System.Drawing.Point(106, 1);
            this.cboAnnoType.Name = "cboAnnoType";
            this.cboAnnoType.Size = new System.Drawing.Size(130, 26);
            this.cboAnnoType.TabIndex = 0;
            // 
            // rangeChart
            // 
            this.rangeChart.AxisX.Chart = this.rangeChart;
            this.rangeChart.AxisX.DataSource = null;
            this.rangeChart.AxisX.GroupProvider = null;
            this.rangeChart.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.rangeChart.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.rangeChart.AxisX.PlotAreaName = null;
            this.rangeChart.AxisX.Position = C1.Chart.Position.None;
            this.rangeChart.AxisY.AxisLine = false;
            this.rangeChart.AxisY.Chart = this.rangeChart;
            this.rangeChart.AxisY.DataSource = null;
            this.rangeChart.AxisY.GroupProvider = null;
            this.rangeChart.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.rangeChart.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.rangeChart.AxisY.PlotAreaName = null;
            this.rangeChart.AxisY.Position = C1.Chart.Position.None;
            this.rangeChart.ChartType = C1.Chart.Finance.FinancialChartType.Line;
            this.rangeChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rangeChart.Legend.ItemMaxWidth = 0;
            this.rangeChart.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.rangeChart.Legend.Position = C1.Chart.Position.None;
            this.rangeChart.Legend.Reversed = false;
            this.rangeChart.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.rangeChart.Legend.Title = null;
            this.rangeChart.Location = new System.Drawing.Point(260, 656);
            this.rangeChart.Margin = new System.Windows.Forms.Padding(10);
            this.rangeChart.Name = "rangeChart";
            this.rangeChart.Options.BoxSize = 2D;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.rangeChart.Options.ClusterSize = elementSize2;
            this.rangeChart.Options.ReversalAmount = 2D;
            this.rangeChart.PlotMargin = new System.Windows.Forms.Padding(0);
            this.rangeChart.SelectedSeries = null;
            this.rangeChart.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.rangeChart.Size = new System.Drawing.Size(854, 40);
            this.rangeChart.TabIndex = 0;
            // 
            // 
            // 
            this.rangeChart.ToolTip.Content = "{value}";
            // 
            // btnAnnoStroke
            // 
            this.btnAnnoStroke.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnAnnoStroke.FlatAppearance.BorderSize = 2;
            this.btnAnnoStroke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnoStroke.Location = new System.Drawing.Point(251, 5);
            this.btnAnnoStroke.Name = "btnAnnoStroke";
            this.btnAnnoStroke.Size = new System.Drawing.Size(15, 15);
            this.btnAnnoStroke.TabIndex = 2;
            this.btnAnnoStroke.UseVisualStyleBackColor = true;
            // 
            // btnAnnoFill
            // 
            this.btnAnnoFill.BackColor = System.Drawing.Color.LightGreen;
            this.btnAnnoFill.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btnAnnoFill.FlatAppearance.BorderSize = 2;
            this.btnAnnoFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnoFill.Location = new System.Drawing.Point(286, 5);
            this.btnAnnoFill.Name = "btnAnnoFill";
            this.btnAnnoFill.Size = new System.Drawing.Size(15, 15);
            this.btnAnnoFill.TabIndex = 3;
            this.btnAnnoFill.UseVisualStyleBackColor = false;
            // 
            // btnAnnoFont
            // 
            this.btnAnnoFont.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnAnnoFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnoFont.Location = new System.Drawing.Point(316, 2);
            this.btnAnnoFont.Name = "btnAnnoFont";
            this.btnAnnoFont.Size = new System.Drawing.Size(50, 21);
            this.btnAnnoFont.TabIndex = 4;
            this.btnAnnoFont.Text = "Font";
            this.btnAnnoFont.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1124, 706);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F);
            this.Name = "MainForm";
            this.Text = "Stock Analysis";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSecurityIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rangeChart)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBoxTitle;
        private C1.Win.Chart.Finance.FinancialChart financialChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBoxSecurityIcon;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.Button btnIndicators;
        private System.Windows.Forms.Button btnOverlays;
        private C1.Win.Chart.Finance.FinancialChart rangeChart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labAnnotationType;
        private System.Windows.Forms.ComboBox cboAnnoType;
        private System.Windows.Forms.Button btnAnnoFill;
        private System.Windows.Forms.Button btnAnnoStroke;
        private System.Windows.Forms.Button btnAnnoFont;

    }
}

