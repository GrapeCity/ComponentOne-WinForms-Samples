using C1.Win.Chart;
using C1.Win.C1Themes;

namespace MaterialDesign.Controls
{
    public class DemoFlexChart2 : FlexChart, IDemo, IThemeable
    {
        public void Init()
        {
            DataSource = SampleHelper.Instance.GetSourceTable("Sales By Date", Properties.Resources.SalesByDate);

            Series.Clear();

            var series1 = new Series();
            series1.Name = "Sales";
            series1.Binding = "Sales";

            Series.Add(series1);
            BindingX = "OrderDate";

            AxisX.AxisLine = false;
        }

        void IThemeable.ThemeChanged()
        {
            C1MaterialThemeSettings settings = SampleHelper.Instance.C1Theme.GetSettings() as C1MaterialThemeSettings;
            if (settings != null)
                Series[0].Style.StrokeColor = settings.SecondaryColor;
        }
    }
}
