using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Chart;
using C1.Win.Chart;
using BaseExplorer;
using FlexChartExplorer.Data;
using System.IO;

namespace FlexChartExplorer.Samples
{
    public partial class SaveImage : FlexChartBaseSample
    {
        private ButtonEx _bSaveImage;
        private ComboBoxEx _cbChartType;
        private FlexChart _flexChart;
        private FlexPie _flexPie;
        public SaveImage()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            //Setup FlexChart
            _flexChart.Header.Content = "World GDP Ranking";
            _flexChart.Header.Style.Font = StyleInfo.ChartHeaderFont;

            _flexChart.DataSource = HierarchicalDataSource.GetFlatOrHierarchicalGDPData(true);
            _flexChart.BindingX = "Country";

            var ser1 = new Series() { Binding = "CurrentPrices", Name = "Current Prices" };
            var ser2 = new Series() { Binding = "PPPValuation", Name = "PPP Valuation", ChartType = ChartType.LineSymbols };
            _flexChart.Series.Add(ser1);
            _flexChart.Series.Add(ser2);
            _flexChart.AxisX.AxisLine = false;


            //Setup FlexPie
            _flexPie.Header.Content = "Category-wise Total Sales";
            _flexPie.Header.Style.Font = StyleInfo.ChartHeaderFont;

            _flexPie.DataSource = SalesDataSource.GetSeasonSales(5);
            _flexPie.BindingName = "Name";
            _flexPie.Binding = "TotalSales";
            _flexPie.DataLabel.Content = "{y} : {p:0.0} % of Total";
            _flexPie.DataLabel.Position = PieLabelPosition.Center;
            _flexPie.DataLabel.Border = true;            
        }
        protected override void InitializeControls()
        {            
            _flexChart = new FlexChart() { Dock = DockStyle.Fill };
            _flexPie = new FlexPie() { Dock = DockStyle.Fill };
            //Set default chart to be shown
            this.Chart = _flexChart;

            _cbChartType = new ComboBoxEx("Chart Type") { DataSource = new string[] { "FlexChart", "FlexPie" } };
            _cbChartType.SelectedIndexChanged += _cbChartType_SelectedIndexChanged;

            _bSaveImage = new ButtonEx("Save As Image");
            _bSaveImage.Click += _bSaveImage_Click;

            this.pnlControls.Controls.Add(_cbChartType);
            this.pnlControls.Controls.Add(_bSaveImage);
        }

        private void _cbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            switch (_cbChartType.SelectedItem.ToString())
            {
                case "FlexChart":
                    this.Chart = _flexChart;
                    break;
                case "FlexPie":
                    this.Chart = _flexPie;
                    break;
            }
            this.pnlMain.Controls.Add(this.Chart);
        }

        private void _bSaveImage_Click(object sender, EventArgs e)
        {
            var filter = "JPEG Image(*.jpg)|*.jpeg|PNG Image(*.png)|*.png|SVG Image(*.svg)|*.svg";
            SaveFileDialog sfd = new SaveFileDialog() { OverwritePrompt = true, Filter = filter };
            var format = ImageFormat.Jpg;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var fileStream = sfd.OpenFile())
                {
                    var fmt = Path.GetExtension(sfd.FileName);
                    switch (fmt)
                    {
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        case ".svg":
                            format = ImageFormat.Svg;
                            break;
                    }
                    if(this.Chart is FlexChart)
                        (this.Chart as FlexChart).SaveImage(fileStream, format, Chart.Width, Chart.Height);
                    else
                        (this.Chart as FlexPie).SaveImage(fileStream, format, Chart.Width, Chart.Height);
                }
            }
        }
    }
}
