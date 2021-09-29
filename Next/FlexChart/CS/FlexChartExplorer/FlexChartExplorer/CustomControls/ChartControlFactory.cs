using BaseExplorer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexChartExplorer
{
    public class ChartControlFactory 
    {
        public static ComboBoxEx BasicChartTypesCombo()
        {
            var cbChartType = new ComboBoxEx("Chart Type");
            var chartTypes = "Column|Bar|Line|Scatter|LineSymbols|Area|Spline|SplineSymbols|SplineArea|Step|StepSymbols|StepArea".Split('|');
            cbChartType.DataSource = chartTypes;
            return cbChartType;
        }

        public static ComboBoxEx FinancialChartTypesCombo()
        {
            var cbChartType = new ComboBoxEx("Chart Type");
            var finChartTypes = "Candlestick|HighLowOpenClose".Split('|');
            cbChartType.DataSource = finChartTypes;
            return cbChartType;
        }
    }
}
