using System;
using System.IO;
using C1.Win.Chart;
using System.Windows.Forms;

namespace ControlExplorer.DashboardLayout
{
    public partial class SaveLoadLayout : C1DemoForm
    {
        private MemoryStream _defaultLayout; // default layout

        public SaveLoadLayout()
        {
            InitializeComponent();
            _defaultLayout = new MemoryStream();
        }

        private void SaveLoadLayout_Load(object sender, EventArgs e)
        {
            InitContent();
            // save default layout too memory stream
            c1DashboardLayout1.SaveLayout(_defaultLayout);
        }

        private void InitContent()
        {
            // init chart1
            flexChart1.DataSource = DemoDataSource("SalesByCountry");
            flexChart1.Series.Clear();
            flexChart1.Series.Add(new Series() { Name = "Sales", Binding = "Sales" });
            flexChart1.BindingX = "Country";
            // init grid
            c1FlexGrid1.DataSource = DemoDataSource("Sales");
            // init pie
            flexPie1.DataSource = DemoDataSource("SalesByEmployee");
            flexPie1.Binding = "Sales";
            flexPie1.BindingName = "Employee";
            // init Gauge
            timer1.Start();
            // init dialogs
            DirectoryInfo dir = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\Layouts");
            if (!dir.Exists)
                dir.Create();
            saveFileDialog1.InitialDirectory = dir.FullName;
            openFileDialog1.InitialDirectory = dir.FullName;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // set current time
            TimeSpan time = DateTime.Now.TimeOfDay;
            c1RadialGauge1.MorePointers["hours"].Value = time.Hours % 12;
            c1RadialGauge1.MorePointers["minutes"].Value = time.Minutes;
            c1RadialGauge1.MorePointers["seconds"].Value = time.Seconds;
        }

        private void commandSave_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            // save layout to file
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                c1DashboardLayout1.SaveLayout(saveFileDialog1.FileName);
        }

        private void commandLoad_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            // load layout from file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                c1DashboardLayout1.LoadLayout(openFileDialog1.FileName);
        }

        private void commandReset_Click(object sender, C1.Win.Command.ClickEventArgs e)
        {
            // load layout from stream
            _defaultLayout.Seek(0, SeekOrigin.Begin);
            c1DashboardLayout1.LoadLayout(_defaultLayout);
        }
    }
}
