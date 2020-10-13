using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;

namespace SparklineSamples
{
    public class SparklineTypeItem
    {
        public string Name
        {
            get;
            set;
        }

        public C1.Win.Sparkline.SparklineType Type
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class ColorItem
    {
        public string Name
        {
            get;
            set;
        }

        public Color Value
        {
            get;
            set;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    class SampleData
    {
        ColorItem[] _defaultColors;
        SparklineTypeItem[] _types;

        public List<double> DefaultData
        {
            get
            {
                List<double> data = new List<double>() { 1.0, -2.0, -1.0, 6.0, 4.0, -4.0, 3.0, 8.0 };
                return data;
            }
        }

        public List<DateTime> DefaultDateAxisData
        {
            get
            {
                List<DateTime> dates = new List<DateTime>();

                dates.Add(new DateTime(2011, 1, 5));
                dates.Add(new DateTime(2011, 1, 1));
                dates.Add(new DateTime(2011, 2, 11));
                dates.Add(new DateTime(2011, 3, 1));
                dates.Add(new DateTime(2011, 2, 1));
                dates.Add(new DateTime(2011, 2, 3));
                dates.Add(new DateTime(2011, 3, 6));
                dates.Add(new DateTime(2011, 2, 19));

                return dates;
            }
        }

        public ColorItem[] DefaultColors
        {
            get
            {
                if (_defaultColors == null)
                {
                    _defaultColors = new ColorItem[]
                    {
                        new ColorItem() { Name = "Sky Blue", Value = Color.FromArgb(0xFF, 0x88, 0xBD, 0xE6) },
                        new ColorItem() { Name = "Sandy Brown", Value = Color.FromArgb(0xFF, 0xFB, 0xB2, 0x58) },
                        new ColorItem() { Name = "Light Green", Value = Color.FromArgb(0xFF, 0x90, 0xCD, 0x97) },
                        new ColorItem() { Name = "Light Pink", Value = Color.FromArgb(0xFF, 0xF6, 0xAA, 0xC9) },
                        new ColorItem() { Name = "Dark Khaki", Value = Color.FromArgb(0xFF, 0xBF, 0xA5, 0x54) },
                        new ColorItem() { Name = "Medium Orchid", Value = Color.FromArgb(0xFF, 0xBC, 0x99, 0xC7) },
                        new ColorItem() { Name = "Gold", Value = Color.FromArgb(0xFF, 0xED, 0xDD, 0x46) },
                        new ColorItem() { Name = "Light Coral", Value = Color.FromArgb(0xFF, 0xF0, 0x7E, 0x6E) },
                        new ColorItem() { Name = "Gray", Value = Color.FromArgb(0xFF, 0x8C, 0x8C, 0x8C) }
                    };
                }

                return _defaultColors;
            }
        }

        public SparklineTypeItem[] SparklineTypes
        {
            get
            {
                if (_types == null)
                {
                    _types = new SparklineTypeItem[]
                    {
                        new SparklineTypeItem(){ Name = "Line", Type = C1.Win.Sparkline.SparklineType.Line },
                        new SparklineTypeItem(){ Name = "Column", Type = C1.Win.Sparkline.SparklineType.Column },
                        new SparklineTypeItem(){ Name = "WinLoss", Type = C1.Win.Sparkline.SparklineType.WinLoss }
                    };
                }

                return _types;
            }
        }
    }

    public class RegionSalesData
    {
        public ObservableCollection<double> SalesTrend { get; set; }
        public ObservableCollection<double> WinLoss { get; set; }
        public ObservableCollection<double> ProfitTrend { get; set; }
        public string State { get; set; }
        public double TotalSales { get; set; }
        public double NetSales { get; set; }
    }
}
