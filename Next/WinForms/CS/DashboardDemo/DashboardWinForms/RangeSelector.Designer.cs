namespace DashboardWinForms
{
    partial class ValRangeSelector
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
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            this.flexChart1 = new C1.Win.Chart.FlexChart();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // flexChart1
            // 
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
            this.flexChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexChart1.Legend.ItemMaxWidth = 0;
            this.flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexChart1.Legend.Position = C1.Chart.Position.Right;
            this.flexChart1.Legend.Reversed = false;
            this.flexChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.flexChart1.Legend.Title = null;
            this.flexChart1.Location = new System.Drawing.Point(10, 10);
            this.flexChart1.Margin = new System.Windows.Forms.Padding(10);
            this.flexChart1.Name = "flexChart1";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.flexChart1.Options.ClusterSize = elementSize1;
            this.flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexChart1.SelectedSeries = null;
            this.flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            this.flexChart1.Series.Add(series1);
            this.flexChart1.Size = new System.Drawing.Size(706, 113);
            this.flexChart1.TabIndex = 0;
            this.flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            this.flexChart1.ToolTip.Content = "{value}";
            // 
            // RangeSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.flexChart1);
            this.Name = "RangeSelector";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(726, 100);
            this.Load += new System.EventHandler(this.RangeSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Chart.FlexChart flexChart1;
    }
}
