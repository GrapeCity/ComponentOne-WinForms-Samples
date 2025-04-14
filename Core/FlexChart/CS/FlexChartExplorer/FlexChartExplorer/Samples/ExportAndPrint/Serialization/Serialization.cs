using System;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using FlexChartExplorer.Data;
using BaseExplorer;
using System.IO;
using C1.Chart.Serialization;
using FlexChartExplorer.Samples.ExportAndPrint.Serialization;
using MessagePack;

namespace FlexChartExplorer.Samples
{
    public partial class Serialization : FlexChartBaseSample
    {
        private ButtonEx _bExportToFile, _bImportFromFile;
        private ComboBoxEx _cbChartType;
        private FlexChart _flexChart;
        private FlexPie _flexPie;
        private LabelEx _lblChartType;

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

            _cbChartType = new ComboBoxEx("Chart Type") { ItemsDataSource = new string[] { "FlexChart", "FlexPie" } };
            _cbChartType.SelectedIndex = 0;
            _cbChartType.SelectedIndexChanged += _cbChartType_SelectedIndexChanged;

            _bExportToFile = new ButtonEx("Serialize To File");
            _bExportToFile.Click += _bExportToFile_Click;

            _bImportFromFile = new ButtonEx("Deserialize From File");
            _bImportFromFile.Click += _bImportFromFile_Click;

            _lblChartType = new LabelEx("Chart Type:");

            this.pnlControls.Controls.Add(_lblChartType);
            this.pnlControls.Controls.Add(_cbChartType);
            this.pnlControls.Controls.Add(_bExportToFile);
            this.pnlControls.Controls.Add(_bImportFromFile);
        }

        private void _cbChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            switch (_cbChartType.SelectedValue.ToString())
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
            var filter = "XML File (*.xml)|*.xml|JSON File (*.json)|*.json|Binary File(*.bin)|*.bin";
            OpenFileDialog ofd = new OpenFileDialog() {Filter = filter };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                DeserializeChartFromFile(ofd.FileName, Chart);
            }
        }

        private void _bExportToFile_Click(object sender, EventArgs e)
        {
            var filter = "XML File (*.xml)|*.xml|JSON File (*.json)|*.json|Binary File(*.bin)|*.bin";
            SaveFileDialog sfd = new SaveFileDialog() { OverwritePrompt = true, Filter = filter };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var fmt = Path.GetExtension(sfd.FileName);
                string data = null;
                switch (fmt)
                {
                    case ".json":
                        data = Chart.SerializeToJson();
                        File.WriteAllText(sfd.FileName, data);
                        break;
                    case ".bin":
                        byte[] result = Chart.SerializeToBinary();
                        File.WriteAllBytes(sfd.FileName, result);
                        break;
                    default:
                        data = Chart.SerializeToXml();
                        File.WriteAllText(sfd.FileName, data);
                        break;
                }
            }
        }

        private void DeserializeChartFromFile(string filename, FlexChartBase chart)
        {
            var fmt = Path.GetExtension(filename);
            try
            {
                switch (fmt)
                {
                    case ".json":
                        var data = File.ReadAllText(filename);
                        chart.DeserializeFromJson(data);
                        break;
                    case ".bin":
                        var bytes = File.ReadAllBytes(filename);
                        chart.DeserializeFromBinary(bytes);
                        break;
                    default:
                        data = File.ReadAllText(filename);
                        chart.DeserializeFromXml(data);
                        break;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
