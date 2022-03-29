using C1.Win.TrueDBGrid;

namespace DashboardDemo.Controls
{
    public class DemoTrueDBGrid : C1TrueDBGrid, IDemo
    {
        public void Init()
        {
            DataSource = SampleHelper.Instance.GetSourceTable("Customers", Properties.Resources.Customers);
        }
    }
}
