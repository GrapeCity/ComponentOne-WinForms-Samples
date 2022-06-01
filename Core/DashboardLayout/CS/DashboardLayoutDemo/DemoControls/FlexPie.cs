using C1.Win.Chart;

namespace DashboardDemo.Controls
{
    public partial class DemoFlexPie : FlexPie, IDemo
    {
        public void Init()
        {
            DataSource = SampleHelper.Instance.GetSourceTable("Sales By Employee", Properties.Resources.SalesByEmployee);
            Binding = "Sales";
            BindingName = "Employee";
        }
    }
}
