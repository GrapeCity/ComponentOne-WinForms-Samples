using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Tooltips.Data
{
    public class CategoricalPoint
    {
        public string Name
        { get; set; }

        public long Sales
        { get; set; }

        public long Downloads
        { get; set; }

        public long Expenses
        { get; set; }

        public static ObservableCollection<CategoricalPoint> GetCategoricalData()
        {
            ObservableCollection<CategoricalPoint> categoricalData = new ObservableCollection<CategoricalPoint>();
            var MonthNames = Tooltips.Resources.AppResources.MonthNames.Split(',');
            var salesData = new[] { 5000, 8500, 7000, 6500, 12000, 7580, 9587, 12456, 21591, 8500, 6500, 8500 };
            var downloadsData = new[] { 6000, 7500, 12000, 5800, 11000, 9000, 13580, 7560, 9000, 1800, 6500, 5000, 7560 };
            var expensesData = new[] { 15000, 18000, 15500, 18500, 9500, 8750, 4000, 10000, 7500, 12000, 10000, 4000, 4500 };
            for (int i = 0; i < MonthNames.Length; i++)
            {
                CategoricalPoint temp = new CategoricalPoint();
                temp.Name = MonthNames[i];
                temp.Sales = salesData[i];
                temp.Downloads = downloadsData[i];
                temp.Expenses = expensesData[i];
                categoricalData.Add(temp);
            }
            return categoricalData;
        }
    }
}
