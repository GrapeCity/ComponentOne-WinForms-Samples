namespace Tooltips.Forms
{
    partial class HTMLTooltipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HTMLTooltipForm));
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            C1.Win.Chart.Series series2 = new C1.Win.Chart.Series();
            C1.Win.Chart.Series series3 = new C1.Win.Chart.Series();
            C1.Win.Chart.FlexPieSlice flexPieSlice1 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice2 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice3 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice4 = new C1.Win.Chart.FlexPieSlice();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flexChart = new C1.Win.Chart.FlexChart();
            this.flexPie = new C1.Win.Chart.FlexPie();
            this.c1SuperTooltip1 = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.flexChart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flexPie, 1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
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
            this.flexChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flexChart_MouseMove);
            // 
            // flexPie
            // 
            flexPieSlice1.Name = "Slice1";
            flexPieSlice1.Value = 1D;
            flexPieSlice2.Name = "Slice2";
            flexPieSlice2.Value = 2D;
            flexPieSlice3.Name = "Slice3";
            flexPieSlice3.Value = 3D;
            flexPieSlice4.Name = "Slice4";
            flexPieSlice4.Value = 4D;
            this.flexPie.DataSource = new C1.Win.Chart.FlexPieSlice[] {
        flexPieSlice1,
        flexPieSlice2,
        flexPieSlice3,
        flexPieSlice4};
            resources.ApplyResources(this.flexPie, "flexPie");
            this.flexPie.Legend.Position = C1.Chart.Position.Right;
            this.flexPie.Name = "flexPie";
            this.flexPie.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            // 
            // 
            // 
            this.flexPie.ToolTip.Content = "{value}";
            this.flexPie.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flexPie_MouseMove);
            // 
            // c1SuperTooltip1
            // 
            this.c1SuperTooltip1.Font = new System.Drawing.Font("Tahoma", 8F);
            // 
            // HTMLTooltipForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "HTMLTooltipForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flexChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.FlexChart flexChart;
        private C1.Win.Chart.FlexPie flexPie;
        private C1.Win.C1SuperTooltip.C1SuperTooltip c1SuperTooltip1;
    }
}