namespace FinancialChartExplorer.Samples
{
    partial class RangeSelector
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
            this.financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.financialChart2 = new C1.Win.Chart.Finance.FinancialChart();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(557, 272);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.financialChart1.Legend.Position = C1.Chart.Position.Right;
            this.financialChart1.Location = new System.Drawing.Point(3, 3);
            this.financialChart1.Name = "financialChart1";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.financialChart1.Options.ClusterSize = elementSize1;
            this.financialChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart1.SelectedSeries = null;
            this.financialChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart1.Size = new System.Drawing.Size(551, 200);
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
            this.financialChart2.Legend.Position = C1.Chart.Position.Right;
            this.financialChart2.Location = new System.Drawing.Point(3, 209);
            this.financialChart2.Name = "financialChart2";
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.financialChart2.Options.ClusterSize = elementSize2;
            this.financialChart2.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart2.SelectedSeries = null;
            this.financialChart2.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart2.Size = new System.Drawing.Size(551, 60);
            this.financialChart2.TabIndex = 1;
            this.financialChart2.Text = "financialChart2";
            // 
            // 
            // 
            this.financialChart2.ToolTip.Content = "{value}";
            // 
            // RangeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RangeSelector";
            this.Size = new System.Drawing.Size(557, 272);
            this.Load += new System.EventHandler(this.RangeSelector_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private C1.Win.Chart.Finance.FinancialChart financialChart2;
    }
}
