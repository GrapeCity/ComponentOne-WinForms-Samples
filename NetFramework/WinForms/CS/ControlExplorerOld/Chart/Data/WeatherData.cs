using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ControlExplorer.Chart
{
    [ToolboxItem(true)]
    public class WeatherData : XmlBindingSource
    {
        protected override void LoadXml()
        {
            base.LoadXml();
            AddDataMember(ControlExplorer.Properties.Resources.WeatherData);
        }
    }
}
