using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ControlExplorer.Chart
{
    [ToolboxItem(true)]
    public class StockData : XmlBindingSource
    {
        protected override void LoadXml()
        {
            base.LoadXml();
            AddDataMember(ControlExplorer.Properties.Resources.StockData);
        }
    }
}
