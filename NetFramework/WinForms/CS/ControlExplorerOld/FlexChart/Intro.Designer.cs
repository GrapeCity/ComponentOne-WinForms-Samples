namespace ControlExplorer.FlexChart
{
    partial class Intro
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
            C1.Win.Chart.Series series2 = new C1.Win.Chart.Series();
            C1.Win.Chart.Series series3 = new C1.Win.Chart.Series();
            C1.Win.Chart.FlexPieSlice flexPieSlice1 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice2 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice3 = new C1.Win.Chart.FlexPieSlice();
            C1.Win.Chart.FlexPieSlice flexPieSlice4 = new C1.Win.Chart.FlexPieSlice();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Intro));
            this.flexChart1 = new C1.Win.Chart.FlexChart();
            this.flexPie1 = new C1.Win.Chart.FlexPie();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // flexChart1
            // 
            this.flexChart1.AxisX.Chart = this.flexChart1;
            this.flexChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.flexChart1.AxisY.AxisLine = false;
            this.flexChart1.AxisY.Chart = this.flexChart1;
            this.flexChart1.AxisY.MajorGrid = true;
            this.flexChart1.AxisY.Position = C1.Chart.Position.Left;
            this.flexChart1.Legend.Position = C1.Chart.Position.Right;
            this.flexChart1.Location = new System.Drawing.Point(7, 106);
            this.flexChart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flexChart1.Name = "flexChart1";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.flexChart1.Options.ClusterSize = elementSize1;
            this.flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexChart1.SelectedSeries = null;
            this.flexChart1.SelectionMode = C1.Chart.ChartSelectionMode.Series;
            this.flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.DodgerBlue;
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
            this.flexChart1.Series.Add(series1);
            this.flexChart1.Series.Add(series2);
            this.flexChart1.Series.Add(series3);
            this.flexChart1.Size = new System.Drawing.Size(430, 341);
            this.flexChart1.TabIndex = 2;
            this.flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            this.flexChart1.ToolTip.Content = "{value}";
            // 
            // flexPie1
            // 
            flexPieSlice1.Name = "Slice1";
            flexPieSlice1.Value = 1D;
            flexPieSlice2.Name = "Slice2";
            flexPieSlice2.Value = 2D;
            flexPieSlice3.Name = "Slice3";
            flexPieSlice3.Value = 3D;
            flexPieSlice4.Name = "Slice4";
            flexPieSlice4.Value = 4D;
            this.flexPie1.DataSource = new C1.Win.Chart.FlexPieSlice[] {
        flexPieSlice1,
        flexPieSlice2,
        flexPieSlice3,
        flexPieSlice4};
            this.flexPie1.Legend.Position = C1.Chart.Position.Right;
            this.flexPie1.Location = new System.Drawing.Point(443, 106);
            this.flexPie1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flexPie1.Name = "flexPie1";
            this.flexPie1.SelectedItemPosition = C1.Chart.Position.Top;
            this.flexPie1.SelectionMode = C1.Chart.ChartSelectionMode.Point;
            this.flexPie1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.flexPie1.Size = new System.Drawing.Size(299, 341);
            this.flexPie1.TabIndex = 3;
            this.flexPie1.Text = "flexPie1";
            // 
            // 
            // 
            this.flexPie1.ToolTip.Content = "{value}";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "FlexChart control:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "FlexPie control:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(705, 60);
            this.label3.TabIndex = 6;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // Intro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 448);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flexPie1);
            this.Controls.Add(this.flexChart1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Intro";
            this.Text = "Intro";
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private C1.Win.Chart.FlexChart flexChart1;
        private C1.Win.Chart.FlexPie flexPie1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}