using C1.Win.Chart;

namespace DashboardLayoutDemo.Controls
{
    public class DemoFlexChart : FlexChart, IDemo
    {
        public void Init()
        {
            DataSource = SampleHelper.Instance.GetSourceTable("Sales By Country", Properties.Resources.SalesByCountry);

            Series.Clear();

            var series1 = new Series();
            series1.Name = "Sales";
            series1.Binding = "Sales";

            Series.Add(series1);
            BindingX = "Country";
        }
    }
}
