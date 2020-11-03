namespace StockChart
{
    partial class frmMain
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
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.financialChart2 = new C1.Win.Chart.Finance.FinancialChart();
            this.ucToolbar = new StockChart.ucToolbar();
            this.ucTitlebar = new StockChart.Controls.ucTitlebar();
            this.ucDescription1 = new StockChart.Controls.ucDescription();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart2)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.financialChart1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.financialChart2, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ucToolbar, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ucTitlebar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ucDescription1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 561);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // financialChart1
            // 
            this.financialChart1.AxisX.Chart = this.financialChart1;
            this.financialChart1.AxisX.DataSource = null;
            this.financialChart1.AxisX.PlotAreaName = null;
            this.financialChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.financialChart1.AxisY.AxisLine = false;
            this.financialChart1.AxisY.Chart = this.financialChart1;
            this.financialChart1.AxisY.DataSource = null;
            this.financialChart1.AxisY.MajorGrid = true;
            this.financialChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.financialChart1.AxisY.PlotAreaName = null;
            this.financialChart1.AxisY.Position = C1.Chart.Position.Left;
            this.financialChart1.BackColor = System.Drawing.Color.Black;
            this.financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            this.financialChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialChart1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.financialChart1.Legend.ItemMaxWidth = 0;
            this.financialChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.financialChart1.Legend.Position = C1.Chart.Position.Right;
            this.financialChart1.Legend.Reversed = false;
            this.financialChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.financialChart1.Legend.Title = null;
            this.financialChart1.Location = new System.Drawing.Point(10, 388);
            this.financialChart1.Margin = new System.Windows.Forms.Padding(10);
            this.financialChart1.Name = "financialChart1";
            this.financialChart1.Options.BoxSize = 2D;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.financialChart1.Options.ClusterSize = elementSize1;
            this.financialChart1.Options.ReversalAmount = 1D;
            this.financialChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart1.SelectedSeries = null;
            this.financialChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart1.Size = new System.Drawing.Size(764, 43);
            this.financialChart1.TabIndex = 0;
            // 
            // 
            // 
            this.financialChart1.ToolTip.Content = "{value}";
            // 
            // financialChart2
            // 
            this.financialChart2.AxisX.Chart = this.financialChart2;
            this.financialChart2.AxisX.DataSource = null;
            this.financialChart2.AxisX.PlotAreaName = null;
            this.financialChart2.AxisX.Position = C1.Chart.Position.Bottom;
            this.financialChart2.AxisY.AxisLine = false;
            this.financialChart2.AxisY.Chart = this.financialChart2;
            this.financialChart2.AxisY.DataSource = null;
            this.financialChart2.AxisY.MajorGrid = true;
            this.financialChart2.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.financialChart2.AxisY.PlotAreaName = null;
            this.financialChart2.AxisY.Position = C1.Chart.Position.Left;
            this.financialChart2.BackColor = System.Drawing.Color.Black;
            this.financialChart2.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            this.financialChart2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialChart2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(184)))), ((int)(((byte)(184)))));
            this.financialChart2.Legend.ItemMaxWidth = 0;
            this.financialChart2.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.financialChart2.Legend.Position = C1.Chart.Position.Right;
            this.financialChart2.Legend.Reversed = false;
            this.financialChart2.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.financialChart2.Legend.Title = null;
            this.financialChart2.Location = new System.Drawing.Point(10, 451);
            this.financialChart2.Margin = new System.Windows.Forms.Padding(10);
            this.financialChart2.Name = "financialChart1";
            this.financialChart2.Options.BoxSize = 2D;
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.financialChart2.Options.ClusterSize = elementSize2;
            this.financialChart2.Options.ReversalAmount = 1D;
            this.financialChart2.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart2.SelectedSeries = null;
            this.financialChart2.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart2.Size = new System.Drawing.Size(764, 100);
            this.financialChart2.TabIndex = 0;
            // 
            // 
            // 
            this.financialChart2.ToolTip.Content = "{value}";
            // 
            // ucToolbar
            // 
            this.ucToolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucToolbar.Location = new System.Drawing.Point(3, 231);
            this.ucToolbar.Name = "ucToolbar";
            this.ucToolbar.Size = new System.Drawing.Size(778, 144);
            this.ucToolbar.TabIndex = 1;
            // 
            // ucTitlebar
            // 
            this.ucTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(2)))), ((int)(((byte)(2)))));
            this.ucTitlebar.Difference = 0D;
            this.ucTitlebar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucTitlebar.Location = new System.Drawing.Point(3, 163);
            this.ucTitlebar.Name = "ucTitlebar";
            this.ucTitlebar.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ucTitlebar.Price = 0D;
            this.ucTitlebar.Size = new System.Drawing.Size(778, 62);
            this.ucTitlebar.StockName = null;
            this.ucTitlebar.TabIndex = 2;
            // 
            // ucDescription1
            // 
            this.ucDescription1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(87)))), ((int)(((byte)(102)))));
            this.ucDescription1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucDescription1.Location = new System.Drawing.Point(3, 3);
            this.ucDescription1.Name = "ucDescription1";
            this.ucDescription1.Size = new System.Drawing.Size(778, 154);
            this.ucDescription1.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "Stock Chart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private C1.Win.Chart.Finance.FinancialChart financialChart2;
        private ucToolbar ucToolbar;
        private Controls.ucTitlebar ucTitlebar;
        private Controls.ucDescription ucDescription1;
    }
}

