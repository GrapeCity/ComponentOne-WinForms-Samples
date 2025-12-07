using C1.Win.Chart;
using C1.Win.Themes;

namespace MaterialDesign.Controls
{
    public class DemoFlexChart : FlexChart, IDemo, IThemeable
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

            AxisX.AxisLine = false;
            AxisX.Labels = false;
        }

        void IThemeable.ThemeChanged()
        {
            C1MaterialThemeSettings settings = SampleHelper.Instance.C1Theme.GetSettings() as C1MaterialThemeSettings;
            if (settings != null)
                Series[0].Style.FillColor = settings.SecondaryColor;
        }
    }
}
