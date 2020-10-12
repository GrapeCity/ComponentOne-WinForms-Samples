using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ControlExplorer.Chart
{
    [ToolboxItem(true)]
    public class CategorySales : XmlBindingSource
    {
        protected override void LoadXml()
        {
            base.LoadXml();
            AddDataMember(ControlExplorer.Properties.Resources.CategorySalesByMonth);
            AddDataMember(ControlExplorer.Properties.Resources.CategorySalesByQuarter);
            AddDataMember(ControlExplorer.Properties.Resources.CategorySalesByYear);
            AddDataMember(ControlExplorer.Properties.Resources.MonthlySalesByCategory);
            AddDataMember(ControlExplorer.Properties.Resources.QuarterlySalesByCategory);
            AddDataMember(ControlExplorer.Properties.Resources.YearlySalesByCategory);
            AddDataMember(ControlExplorer.Properties.Resources.TotalSalesByCategory);
        }
    }
}
