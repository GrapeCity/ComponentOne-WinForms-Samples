namespace Tooltips.Forms
{
    partial class ChartTooltipForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartTooltipForm));
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            C1.Win.Chart.Series series2 = new C1.Win.Chart.Series();
            C1.Win.Chart.Series series3 = new C1.Win.Chart.Series();
            this.flexChart = new C1.Win.Chart.FlexChart();
            this.c1SuperTooltip1 = new C1.Win.SuperTooltip.C1SuperTooltip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.flexChart)).BeginInit();
            this.SuspendLayout();
            // 
            // flexChart
            // 
            this.flexChart.AxisX.Chart = this.flexChart;
            this.flexChart.AxisX.Position = C1.Chart.Position.Bottom;
            this.flexChart.AxisY.AxisLine = false;
            this.flexChart.AxisY.Chart = this.flexChart;
            this.flexChart.AxisY.MajorGrid = true;
            this.flexChart.AxisY.Position = C1.Chart.Position.Left;
            resources.ApplyResources(this.flexChart, "flexChart");
            this.flexChart.Legend.Position = C1.Chart.Position.Right;
            this.flexChart.Name = "flexChart";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.flexChart.Options.ClusterSize = elementSize1;
            this.flexChart.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexChart.SelectedSeries = null;
            this.flexChart.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series1.Binding = "Y";
            series1.BindingX = "X";
            series1.DataSource = new System.Drawing.Point[] {
        new System.Drawing.Point(1, 8),
        new System.Drawing.Point(2, 12),
        new System.Drawing.Point(3, 10),
        new System.Drawing.Point(4, 12),
        new System.Drawing.Point(5, 15)};
            series1.Name = "Series 1";
            series1.Style.StrokeWidth = 2F;
            series2.Binding = "Y";
            series2.BindingX = "X";
            series2.DataSource = new System.Drawing.Point[] {
        new System.Drawing.Point(1, 10),
        new System.Drawing.Point(2, 16),
        new System.Drawing.Point(3, 17),
        new System.Drawing.Point(4, 15),
        new System.Drawing.Point(5, 23)};
            series2.Name = "Series 2";
            series2.Style.StrokeWidth = 2F;
            series3.Binding = "Y";
            series3.BindingX = "X";
            series3.DataSource = new System.Drawing.Point[] {
        new System.Drawing.Point(1, 16),
        new System.Drawing.Point(2, 19),
        new System.Drawing.Point(3, 15),
        new System.Drawing.Point(4, 22),
        new System.Drawing.Point(5, 18)};
            series3.Name = "Series 3";
            series3.Style.StrokeWidth = 2F;
            this.flexChart.Series.Add(series1);
            this.flexChart.Series.Add(series2);
            this.flexChart.Series.Add(series3);
            // 
            // 
            // 
            this.flexChart.ToolTip.Content = "{value}";
            // 
            // c1SuperTooltip1
            // 
            this.c1SuperTooltip1.Font = new System.Drawing.Font("Tahoma", 8F);
            // 
            // ChartTooltipForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flexChart);
            this.Name = "ChartTooltipForm";
            ((System.ComponentModel.ISupportInitialize)(this.flexChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Chart.FlexChart flexChart;
        private C1.Win.SuperTooltip.C1SuperTooltip c1SuperTooltip1;
    }
}