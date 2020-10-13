namespace ControlExplorer.FlexChart
{
    partial class FunnelChartIntro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.NumericUpDown nudNeckWidth;
        private System.Windows.Forms.NumericUpDown nudNeckHeight;
        private System.Windows.Forms.ComboBox cbFunnelType;
        private C1.Win.Chart.FlexChart flexChart1;

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
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            this.flexChart1 = new C1.Win.Chart.FlexChart();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // flexChart1
            // 
            this.flexChart1.AxisX.Chart = this.flexChart1;
            this.flexChart1.AxisY.Chart = this.flexChart1;
            this.flexChart1.ChartType = C1.Chart.ChartType.Funnel;
            this.flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexChart1.Legend.Position = C1.Chart.Position.Right;
            this.flexChart1.Legend.Title = null;
            this.flexChart1.Location = new System.Drawing.Point(2, 76);
            this.flexChart1.Margin = new System.Windows.Forms.Padding(10);
            this.flexChart1.Name = "flexChart1";
            this.flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexChart1.SelectedSeries = null;
            this.flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series1.Name = "Series 1";
            series1.Style.StrokeWidth = 2F;
            this.flexChart1.Series.Add(series1);
            this.flexChart1.Size = new System.Drawing.Size(600, 400);
            this.flexChart1.TabIndex = 0;
            this.flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            this.flexChart1.ToolTip.Content = "{value}";
            // 
            // FunnelChartIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 537);
            this.Controls.Add(this.flexChart1);
            this.Name = "FunnelChartIntro";
            this.Text = "FunnelChart";
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.TouchToolKit.C1Zoom c1Zoom1;
    }
}

