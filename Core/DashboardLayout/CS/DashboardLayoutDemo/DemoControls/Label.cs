using C1.Win.Input;
using System.Data;

namespace DashboardLayoutDemo.Controls
{
    public class DemoLabel : C1Label, IDemo
    {
        public void Init()
        {
            DataTable dt = SampleHelper.Instance.GetSourceTable("Total Sales", Properties.Resources.TotalSales);
            Text = dt.Rows[0]["Sales"].ToString();
            //DataField = "Sales";
        }
    }
}
