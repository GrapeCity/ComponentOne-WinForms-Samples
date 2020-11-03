namespace FinancialChartExplorer.Samples
{
    partial class Indicators
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
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.indicatorType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.period = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudFastPeriod = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudSlowPeriod = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudMacdSignalSmoothingPeriod = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nudKPeriod = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nudDPeriod = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nudStochasticSmoothingPeriod = new System.Windows.Forms.NumericUpDown();
            this.financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.financialChart2 = new C1.Win.Chart.Finance.FinancialChart();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.period)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFastPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlowPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMacdSignalSmoothingPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStochasticSmoothingPeriod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.financialChart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.financialChart2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.indicatorType);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.period);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.nudFastPeriod);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.nudSlowPeriod);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.nudMacdSignalSmoothingPeriod);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.nudKPeriod);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.nudDPeriod);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Controls.Add(this.nudStochasticSmoothingPeriod);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 213);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 56);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indicator Type";
            // 
            // indicatorType
            // 
            this.indicatorType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.indicatorType.FormattingEnabled = true;
            this.indicatorType.Location = new System.Drawing.Point(87, 3);
            this.indicatorType.Name = "indicatorType";
            this.indicatorType.Size = new System.Drawing.Size(196, 21);
            this.indicatorType.TabIndex = 1;
            this.indicatorType.SelectedIndexChanged += new System.EventHandler(this.indicatorType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(299, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Period";
            // 
            // period
            // 
            this.period.Location = new System.Drawing.Point(345, 3);
            this.period.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(52, 22);
            this.period.TabIndex = 3;
            this.period.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.period.ValueChanged += new System.EventHandler(this.period_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fast period";
            // 
            // nudFastPeriod
            // 
            this.nudFastPeriod.Location = new System.Drawing.Point(487, 3);
            this.nudFastPeriod.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFastPeriod.Name = "nudFastPeriod";
            this.nudFastPeriod.Size = new System.Drawing.Size(52, 22);
            this.nudFastPeriod.TabIndex = 5;
            this.nudFastPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudFastPeriod.ValueChanged += new System.EventHandler(this.nudFastPeriod_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Slow period";
            // 
            // nudSlowPeriod
            // 
            this.nudSlowPeriod.Location = new System.Drawing.Point(633, 3);
            this.nudSlowPeriod.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSlowPeriod.Name = "nudSlowPeriod";
            this.nudSlowPeriod.Size = new System.Drawing.Size(52, 22);
            this.nudSlowPeriod.TabIndex = 7;
            this.nudSlowPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudSlowPeriod.ValueChanged += new System.EventHandler(this.nudSlowPeriod_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Signal smoothing period";
            // 
            // nudMacdSignalSmoothingPeriod
            // 
            this.nudMacdSignalSmoothingPeriod.Location = new System.Drawing.Point(157, 31);
            this.nudMacdSignalSmoothingPeriod.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMacdSignalSmoothingPeriod.Name = "nudMacdSignalSmoothingPeriod";
            this.nudMacdSignalSmoothingPeriod.Size = new System.Drawing.Size(52, 22);
            this.nudMacdSignalSmoothingPeriod.TabIndex = 9;
            this.nudMacdSignalSmoothingPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMacdSignalSmoothingPeriod.ValueChanged += new System.EventHandler(this.nudMacdSignalSmoothingPeriod_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "K period";
            // 
            // nudKPeriod
            // 
            this.nudKPeriod.Location = new System.Drawing.Point(284, 31);
            this.nudKPeriod.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKPeriod.Name = "nudKPeriod";
            this.nudKPeriod.Size = new System.Drawing.Size(52, 22);
            this.nudKPeriod.TabIndex = 11;
            this.nudKPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudKPeriod.ValueChanged += new System.EventHandler(this.nudKPeriod_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "D period";
            // 
            // nudDPeriod
            // 
            this.nudDPeriod.Location = new System.Drawing.Point(413, 31);
            this.nudDPeriod.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDPeriod.Name = "nudDPeriod";
            this.nudDPeriod.Size = new System.Drawing.Size(52, 22);
            this.nudDPeriod.TabIndex = 13;
            this.nudDPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDPeriod.ValueChanged += new System.EventHandler(this.nudDPeriod_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Signal smoothing period";
            // 
            // nudSignalSmoothingPeriod
            // 
            this.nudStochasticSmoothingPeriod.Location = new System.Drawing.Point(625, 31);
            this.nudStochasticSmoothingPeriod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStochasticSmoothingPeriod.Name = "nudSignalSmoothingPeriod";
            this.nudStochasticSmoothingPeriod.Size = new System.Drawing.Size(52, 22);
            this.nudStochasticSmoothingPeriod.TabIndex = 15;
            this.nudStochasticSmoothingPeriod.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudStochasticSmoothingPeriod.ValueChanged += new System.EventHandler(this.nudSignalSmoothingPeriod_ValueChanged);
            // 
            // financialChart1
            // 
            this.financialChart1.AxisX.Chart = this.financialChart1;
            this.financialChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.financialChart1.AxisY.AxisLine = false;
            this.financialChart1.AxisY.Chart = this.financialChart1;
            this.financialChart1.AxisY.MajorGrid = true;
            this.financialChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.financialChart1.AxisY.Position = C1.Chart.Position.Left;
            this.financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            this.financialChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.financialChart1.Legend.Position = C1.Chart.Position.Right;
            this.financialChart1.Legend.Reversed = false;
            this.financialChart1.Legend.Title = null;
            this.financialChart1.Location = new System.Drawing.Point(10, 10);
            this.financialChart1.Margin = new System.Windows.Forms.Padding(10);
            this.financialChart1.Name = "financialChart1";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.financialChart1.Options.ClusterSize = elementSize1;
            this.financialChart1.Options.ReversalAmount = 1D;
            this.financialChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart1.SelectedSeries = null;
            this.financialChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart1.Size = new System.Drawing.Size(780, 10);
            this.financialChart1.TabIndex = 0;
            this.financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            this.financialChart1.ToolTip.Content = "{value}";
            // 
            // financialChart2
            // 
            this.financialChart2.AxisX.Chart = this.financialChart2;
            this.financialChart2.AxisX.Position = C1.Chart.Position.Bottom;
            this.financialChart2.AxisY.AxisLine = false;
            this.financialChart2.AxisY.Chart = this.financialChart2;
            this.financialChart2.AxisY.MajorGrid = true;
            this.financialChart2.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.financialChart2.AxisY.Position = C1.Chart.Position.Left;
            this.financialChart2.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            this.financialChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialChart2.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.financialChart2.Legend.Position = C1.Chart.Position.Right;
            this.financialChart2.Legend.Reversed = false;
            this.financialChart2.Legend.Title = null;
            this.financialChart2.Location = new System.Drawing.Point(10, 40);
            this.financialChart2.Margin = new System.Windows.Forms.Padding(10);
            this.financialChart2.Name = "financialChart2";
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.financialChart2.Options.ClusterSize = elementSize2;
            this.financialChart2.Options.ReversalAmount = 1D;
            this.financialChart2.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart2.SelectedSeries = null;
            this.financialChart2.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart2.Size = new System.Drawing.Size(780, 160);
            this.financialChart2.TabIndex = 1;
            this.financialChart2.Text = "financialChart2";
            // 
            // 
            // 
            this.financialChart2.ToolTip.Content = "{value}";
            // 
            // Indicators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Indicators";
            this.Size = new System.Drawing.Size(800, 272);
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.period)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFastPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSlowPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMacdSignalSmoothingPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStochasticSmoothingPeriod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private C1.Win.Chart.Finance.FinancialChart financialChart2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox indicatorType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown period;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudFastPeriod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudSlowPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudMacdSignalSmoothingPeriod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudKPeriod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudDPeriod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudStochasticSmoothingPeriod;
    }
}
