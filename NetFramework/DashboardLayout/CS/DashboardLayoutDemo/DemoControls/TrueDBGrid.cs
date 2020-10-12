using C1.Win.C1TrueDBGrid;

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
