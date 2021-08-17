using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Win.FlexPivot;

namespace FlexPivotExplorer.Samples
{
    public partial class HierarchicalAxes : UserControl
    {
        public HierarchicalAxes()
        {
            InitializeComponent();
        }

        FlexPivotChart chart;

        private void HierarchicalAxes_Load(object sender, EventArgs e)
        {
            var panel = new C1FlexPivotPanel() { Dock = DockStyle.Fill };
            chart = new FlexPivotChart() { Dock = DockStyle.Fill };
            panel.DataSource = SampleData.CreateDataTable(1000);

            panel.PivotEngine.RowFields.Add("Region", "Country", "Product");
            panel.PivotEngine.ValueFields.Add("Sales");

            chart.DataSource = panel;
            
            chart.ShowHierarchicalAxes = true;
            tableLayoutPanel1.Controls.Add(panel, 0, 1);
            tableLayoutPanel1.Controls.Add(chart, 1, 0);
            tableLayoutPanel1.SetRowSpan(chart, 2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            chart.ShowHierarchicalAxes = checkBox1.Checked;
        }
    }

    class SampleData
    {
        static Random rnd = new Random();

        public static DataTable CreateDataTable(int nrows)
        {
            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Region", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("Sales", typeof(int));
            dt.Columns.Add("Downloads", typeof(int));

            var countries = "US,Germany,UK,Japan,China,Italy,Spain".Split(',');
            var products = "Wijmo,Olap".Split(',');

            for (var i = 0; i < nrows; i++)
            {
                var country = countries[rnd.Next(countries.Length)];
                dt.Rows.Add(new object[] {
                        rnd.Next(),
                        products[rnd.Next(products.Length)],
                        CountryToRegion(country),
                        country,
                        rnd.Next(10000),
                        rnd.Next(10000)
                    }
                );
            }

            return dt;
        }

        static string CountryToRegion(string country)
        {
            if (country == "US")
                return "America";
            else if (country == "Japan" || country == "China")
                return "Asia";
            else
                return "Europe";
        }
    }
}
