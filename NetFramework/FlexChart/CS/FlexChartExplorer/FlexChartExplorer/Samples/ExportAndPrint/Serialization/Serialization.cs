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
using FlexChartExplorer.Data;
using BaseExplorer;
using System.IO;
using C1.Chart.Serialization;

namespace FlexChartExplorer.Samples
{
    public partial class Serialization : FlexChartBaseSample
    {
        private ButtonEx _bExportToFile, _bImportFromFile;
        private ComboBoxEx _cbChartType;
        private FlexChart _flexChart;
        private FlexPie _flexPie;
        public Serialization()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            //Setup FlexChart
            _flexChart.Header.Content = "Product Sales in Holidays";
            _flexChart.Header.Style.Font = StyleInfo.ChartHeaderFont;

            _flexChart.DataSource = SalesDataSource.GetSeasonSales(5);            
            _flexChart.BindingX = "Name";

            var ser1 = new Series { Name = "Winter Sales", Binding = "WinterTotal" };            
            var ser2 = new Series { Name = "Summer Sales", Binding = "SummerTotal" };            
            _flexChart.Series.Add(ser1);
            _flexChart.Series.Add(ser2);
            _flexChart.AxisX.AxisLine = false;

            //Setup FlexPie
            _flexPie.Header.Content = "Products Sales in Holidays";
            _flexPie.Header.Style.Font = StyleInfo.ChartHeaderFont;

            _flexPie.DataSource = SalesDataSource.GetSeasonSales(5);
            _flexPie.BindingName = "Name";
            _flexPie.Binding = "TotalSales";
            _flexPie.DataLabel.Content = "{value}";
            _flexPie.DataLabel.Position = PieLabelPosition.Inside;
            _flexPie.DataLabel.Border = true;            
        }
        protected override void InitializeControls()
        {
            _flexChart = new FlexChart() { Dock = DockStyle.Fill };
            _flexPie = new FlexPie() { Dock = DockStyle.Fill };
            //Set the Chart to be displayed by default
            this.Chart = _flexChart;

            _cbChartType = new ComboBoxEx("Chart Type") { DataSource = new string[] { "FlexChart", "FlexPie" } };
            _cbChartType.SelectedIndexChanged += _cbChartType_SelectedIndexChanged;

            _bExportToFile = new ButtonEx("Serialize To File");
            _bExportToFile.Click += _bExportToFile_Click;

            _bImportFromFile = new ButtonEx("Deserialize From File");
            _bImportFromFile.Click += _bImportFromFile_Click;

            this.pnlControls.Controls.Add(_cbChartType);
            this.pnlControls.Controls.Add(_bExportToFile);
            this.pnlControls.Controls.Add(_bImportFromFile);
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

        private void _bImportFromFile_Click(object sender, EventArgs e)
        {
            var filter = "XML File (*.xml)|*.xml";
            OpenFileDialog ofd = new OpenFileDialog() { Filter = filter };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DeserializeChartFromFile(ofd.FileName, this.Chart);
            }
        }

        private void _bExportToFile_Click(object sender, EventArgs e)
        {
            var filter = "XML File (*.xml)|*.xml";
            SaveFileDialog sfd = new SaveFileDialog() { OverwritePrompt = true, Filter = filter };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, Chart.SerializeToXml());
            }
        }

        private void DeserializeChartFromFile(string filename, FlexChartBase chart)
        {
            string data = File.ReadAllText(filename);
            if (data != null)
            {
                try
                {
                    chart.DeserializeFromXml(data);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }
    }
}
