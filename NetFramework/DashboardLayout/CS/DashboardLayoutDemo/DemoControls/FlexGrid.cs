using C1.Win.C1FlexGrid;

namespace DashboardLayoutDemo.Controls
{
    public partial class DemoFlexGrid : C1FlexGrid, IDemo
    {
        public void Init() =>  DataSource = SampleHelper.Instance.GetSourceTable("Sales", Properties.Resources.Sales);
    }
}
