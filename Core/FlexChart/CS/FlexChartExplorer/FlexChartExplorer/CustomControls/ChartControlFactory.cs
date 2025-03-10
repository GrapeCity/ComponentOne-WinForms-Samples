using BaseExplorer;
using C1.Win.Input;
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
            var cbChartType = new ComboBoxEx();
            var chartTypes = "Column|Bar|Line|Scatter|LineSymbols|Area|Spline|SplineSymbols|SplineArea|Step|StepSymbols|StepArea".Split('|');
            cbChartType.ItemsDataSource = chartTypes;
            cbChartType.SelectedIndex = 0;
            return cbChartType;
        }

        public static C1ComboBox FinancialChartTypesCombo()
        {
            var cbChartType = new C1ComboBox();
            var finChartTypes = "Candlestick|HighLowOpenClose".Split('|');
            cbChartType.ItemsDataSource = finChartTypes;
            cbChartType.SelectedIndex = 0;
            return cbChartType;
        }
    }
}
