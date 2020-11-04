namespace WeatherChart
{
    partial class Form1
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
            C1.Win.Chart.Series series2 = new C1.Win.Chart.Series();
            C1.Chart.ElementSize elementSize3 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series3 = new C1.Win.Chart.Series();
            C1.Chart.ElementSize elementSize4 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series4 = new C1.Win.Chart.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartRangeSelector = new C1.Win.Chart.FlexChart();
            this.chartPrecipitation = new C1.Win.Chart.FlexChart();
            this.chartPressure = new C1.Win.Chart.FlexChart();
            this.chartTemperature = new C1.Win.Chart.FlexChart();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRangeSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrecipitation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.chartRangeSelector, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chartPrecipitation, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.chartPressure, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartTemperature, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(755, 503);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // chartRangeSelector
            // 
            this.chartRangeSelector.AxisX.Chart = this.chartRangeSelector;
            this.chartRangeSelector.AxisX.LabelAngle = 45D;
            this.chartRangeSelector.AxisX.Position = C1.Chart.Position.Bottom;
            this.chartRangeSelector.AxisY.AxisLine = false;
            this.chartRangeSelector.AxisY.Chart = this.chartRangeSelector;
            this.chartRangeSelector.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.chartRangeSelector.AxisY.Position = C1.Chart.Position.Left;
            this.chartRangeSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartRangeSelector.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartRangeSelector.Legend.Position = C1.Chart.Position.None;
            this.chartRangeSelector.Legend.Title = null;
            this.chartRangeSelector.Location = new System.Drawing.Point(0, 392);
            this.chartRangeSelector.Margin = new System.Windows.Forms.Padding(0);
            this.chartRangeSelector.Name = "chartRangeSelector";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.chartRangeSelector.Options.ClusterSize = elementSize1;
            this.chartRangeSelector.PlotMargin = new System.Windows.Forms.Padding(150, 0, 30, 0);
            this.chartRangeSelector.SelectedSeries = null;
            this.chartRangeSelector.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series1.Name = "Series 1";
            series1.Style.StrokeWidth = 2F;
            this.chartRangeSelector.Series.Add(series1);
            this.chartRangeSelector.Size = new System.Drawing.Size(755, 111);
            this.chartRangeSelector.TabIndex = 3;
            this.chartRangeSelector.Text = "flexChart1";
            // 
            // 
            // 
            this.chartRangeSelector.ToolTip.Content = "{value}";
            this.chartRangeSelector.Rendered += new System.EventHandler<C1.Win.Chart.RenderEventArgs>(this.chartRangeSelector_Rendered);
            // 
            // chartPrecipitation
            // 
            this.chartPrecipitation.AxisX.Chart = this.chartPrecipitation;
            this.chartPrecipitation.AxisX.Position = C1.Chart.Position.None;
            this.chartPrecipitation.AxisY.AxisLine = false;
            this.chartPrecipitation.AxisY.Chart = this.chartPrecipitation;
            this.chartPrecipitation.AxisY.MajorGrid = true;
            this.chartPrecipitation.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.chartPrecipitation.AxisY.Position = C1.Chart.Position.Left;
            this.chartPrecipitation.AxisY.Title = "Preсipitation";
            this.chartPrecipitation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPrecipitation.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartPrecipitation.Legend.Position = C1.Chart.Position.None;
            this.chartPrecipitation.Legend.Title = null;
            this.chartPrecipitation.Location = new System.Drawing.Point(0, 261);
            this.chartPrecipitation.Margin = new System.Windows.Forms.Padding(0);
            this.chartPrecipitation.Name = "chartPrecipitation";
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.chartPrecipitation.Options.ClusterSize = elementSize2;
            this.chartPrecipitation.PlotMargin = new System.Windows.Forms.Padding(150, 5, 30, 5);
            this.chartPrecipitation.SelectedSeries = null;
            this.chartPrecipitation.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series2.Name = "Series 1";
            series2.Style.StrokeWidth = 2F;
            this.chartPrecipitation.Series.Add(series2);
            this.chartPrecipitation.Size = new System.Drawing.Size(755, 131);
            this.chartPrecipitation.TabIndex = 2;
            this.chartPrecipitation.Text = "flexChart1";
            // 
            // 
            // 
            this.chartPrecipitation.ToolTip.Content = "{value}";
            this.chartPrecipitation.Rendered += new System.EventHandler<C1.Win.Chart.RenderEventArgs>(this.chartTemperature_Rendered);
            // 
            // chartPressure
            // 
            this.chartPressure.AxisX.Chart = this.chartPressure;
            this.chartPressure.AxisX.Position = C1.Chart.Position.None;
            this.chartPressure.AxisY.AxisLine = false;
            this.chartPressure.AxisY.Chart = this.chartPressure;
            this.chartPressure.AxisY.MajorGrid = true;
            this.chartPressure.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.chartPressure.AxisY.Position = C1.Chart.Position.Left;
            this.chartPressure.AxisY.Title = "MeanPressure";
            this.chartPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPressure.Header.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.chartPressure.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartPressure.Legend.Position = C1.Chart.Position.None;
            this.chartPressure.Legend.Title = null;
            this.chartPressure.Location = new System.Drawing.Point(0, 130);
            this.chartPressure.Margin = new System.Windows.Forms.Padding(0);
            this.chartPressure.Name = "chartPressure";
            elementSize3.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize3.Value = 70D;
            this.chartPressure.Options.ClusterSize = elementSize3;
            this.chartPressure.PlotMargin = new System.Windows.Forms.Padding(150, 5, 30, 5);
            this.chartPressure.SelectedSeries = null;
            this.chartPressure.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series3.Name = "Series 1";
            series3.Style.StrokeWidth = 2F;
            this.chartPressure.Series.Add(series3);
            this.chartPressure.Size = new System.Drawing.Size(755, 131);
            this.chartPressure.TabIndex = 1;
            this.chartPressure.Text = "flexChart1";
            // 
            // 
            // 
            this.chartPressure.ToolTip.Content = "{value}";
            this.chartPressure.Rendered += new System.EventHandler<C1.Win.Chart.RenderEventArgs>(this.chartTemperature_Rendered);
            // 
            // chartTemperature
            // 
            this.chartTemperature.AxisX.Chart = this.chartTemperature;
            this.chartTemperature.AxisX.LabelAngle = 45D;
            this.chartTemperature.AxisX.Position = C1.Chart.Position.Top;
            this.chartTemperature.AxisY.AxisLine = false;
            this.chartTemperature.AxisY.Chart = this.chartTemperature;
            this.chartTemperature.AxisY.MajorGrid = true;
            this.chartTemperature.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.chartTemperature.AxisY.Position = C1.Chart.Position.Left;
            this.chartTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartTemperature.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartTemperature.Legend.Position = C1.Chart.Position.Left;
            this.chartTemperature.Legend.Title = null;
            this.chartTemperature.Location = new System.Drawing.Point(0, 0);
            this.chartTemperature.Margin = new System.Windows.Forms.Padding(0);
            this.chartTemperature.Name = "chartTemperature";
            elementSize4.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize4.Value = 70D;
            this.chartTemperature.Options.ClusterSize = elementSize4;
            this.chartTemperature.PlotMargin = new System.Windows.Forms.Padding(150, 0, 30, 5);
            this.chartTemperature.SelectedSeries = null;
            this.chartTemperature.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series4.Name = "Series 1";
            series4.Style.StrokeWidth = 2F;
            this.chartTemperature.Series.Add(series4);
            this.chartTemperature.Size = new System.Drawing.Size(755, 130);
            this.chartTemperature.TabIndex = 0;
            this.chartTemperature.Text = "flexChart1";
            // 
            // 
            // 
            this.chartTemperature.ToolTip.Content = "{value}";
            this.chartTemperature.Rendered += new System.EventHandler<C1.Win.Chart.RenderEventArgs>(this.chartTemperature_Rendered);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(755, 503);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "WeatherChart";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRangeSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPrecipitation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemperature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.FlexChart chartTemperature;
        private C1.Win.Chart.FlexChart chartRangeSelector;
        private C1.Win.Chart.FlexChart chartPressure;
        private C1.Win.Chart.FlexChart chartPrecipitation;
    }
}

