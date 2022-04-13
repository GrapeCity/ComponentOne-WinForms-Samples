using System;
using System.Data;
using System.Windows.Forms;
using C1.Win.Chart;

namespace SampleExplorer
{
    public partial class Overview : UserControl
    {
        DataTable _salesByCountry;
        DataTable _salesTop10;
        DataTable _customers;
        DataTable _salesByEmployee;
        DataTable _totalSales;

        public Overview()
        {
            InitializeComponent();            
        }        

        private void Overview_Load(object sender, EventArgs e)
        {
            InitContent();
        }

        private void InitContent()
        {
            // init chart1
            flexChart1.DataSource = _salesByCountry = DataSource.DemoDataSource("SalesByCountry");
            flexChart1.Series.Clear();
            flexChart1.Series.Add(new Series() { Name = "Sales", Binding = "Sales" });
            flexChart1.BindingX = "Country";
            // init flex grid
            c1FlexGrid1.DataSource = _salesTop10 = DataSource.DemoDataSource("SalesTop10");
            c1FlexGrid1.Cols["Sales"].Format = "#.##";
            // init true db grid
            c1TrueDBGrid1.DataSource = _customers = DataSource.DemoDataSource("Customers");
            // init pie
            flexPie1.DataSource = _salesByEmployee = DataSource.DemoDataSource("SalesByEmployee");
            flexPie1.Binding = "Sales";
            flexPie1.BindingName = "Employee";
            // init Gauge
            _totalSales = DataSource.DemoDataSource("TotalSales");
            c1LinearGauge1.Pointer.Value = Convert.ToDouble(_totalSales.Rows[0][0]) / 1000.00;
        }
    }
}
