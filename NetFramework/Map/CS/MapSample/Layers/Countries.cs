using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace MapSample.Layers
{
    public interface IValueToColor
    {
        Color ValueToColor(double value);
    }

    public class Country
    {
        private Color? _fill = null;
        double _value;
        internal Countries Parent;

        public string Name { get; set; }

        public double Value
        {
            get { return _value; }
            set { _value = value; _fill = null; }
        }

        public Color Fill
        {
            get
            {
                if (_fill == null)
                {
                    if (Parent != null)
                        _fill = Parent.ValueToColor(Value);
                }
                return _fill.HasValue ? _fill.Value : Color.Empty;
            }
        }
    }

    public class Countries : Collection<Country>, IValueToColor
    {
        readonly Dictionary<string, Country> _dict = new Dictionary<string, Country>();

        public IValueToColor Converter { get; set; }

        public Color ValueToColor(double value)
        {
            if (Converter != null)
                return Converter.ValueToColor(value);

            return Color.Empty;
        }

        public Country this[string name]
        {
            get
            {
                if (_dict.ContainsKey(name))
                    return _dict[name];
                return null;
            }
        }

        public double GetMin()
        {
            double min = double.NaN;

            foreach (var country in this)
            {
                if (double.IsNaN(min) || country.Value < min)
                    min = country.Value;
            }

            return min;
        }

        public double GetMax()
        {
            double max = double.NaN;

            foreach (var country in this)
            {
                if (double.IsNaN(max) || country.Value > max)
                    max = country.Value;
            }

            return max;
        }

        protected override void InsertItem(int index, Country item)
        {
            base.InsertItem(index, item);
            item.Parent = this;
            _dict.Add(item.Name, item);
        }

        protected override void ClearItems()
        {
            foreach (var item in this)
                item.Parent = null;

            base.ClearItems();
            _dict.Clear();
        }

        protected override void RemoveItem(int index)
        {
            var item = this[index];
            base.RemoveItem(index);

            _dict.Remove(item.Name);
            item.Parent = null;
        }

        public static Countries CreateTestCollection()
        {
            var countries = new Countries();

            foreach (var s in File.ReadAllLines("Resources\\gdp-ppp.txt"))
            {
                string[] ss = s.Split(new[] {'\t'},
                    StringSplitOptions.RemoveEmptyEntries);

                countries.Add(new Country
                {
                    Name = ss[1].Trim(),
                    Value = double.Parse(ss[2], CultureInfo.InvariantCulture)
                });
            }

            var cvals = new ColorValues
            {
                new ColorValue {Color = Color.Red, Value = 0},
                new ColorValue {Color = Color.Green, Value = 2000000},
                new ColorValue {Color = Color.Blue, Value = 1.001*countries.GetMax()}
            };

            countries.Converter = cvals;

            return countries;
        }
    }

    public class ColorValue
    {
        public Color Color { get; set; }
        public double Value { get; set; }
    }

    public class ColorValues : Collection<ColorValue>, IValueToColor
    {
        public Color ValueToColor(double value)
        {
            Color color = Color.Empty;

            ColorValue greater = null;
            ColorValue less = null;

            foreach (ColorValue cval in this)
            {
                if (cval.Value < value)
                {
                    if (less == null || (value - cval.Value < value - less.Value))
                        less = cval;
                }
                if (cval.Value > value)
                {
                    if (greater == null || (value - cval.Value > value - greater.Value))
                        greater = cval;
                }
            }

            if (less != null && greater != null)
            {
                Color clr1 = less.Color;
                Color clr2 = greater.Color;

                double rval = (value - less.Value) / (greater.Value - less.Value);

                Color clr = Color.FromArgb(
                  (byte)(clr1.A + rval * (clr2.A - clr1.A)),
                  (byte)(clr1.R + rval * (clr2.R - clr1.R)),
                  (byte)(clr1.G + rval * (clr2.G - clr1.G)),
                  (byte)(clr1.B + rval * (clr2.B - clr1.B)));
                color = clr;
            }

            return color;
        }
    }

    public class ColorRange : IValueToColor
    {
        public double Min { get; set; }
        public double Max { get; set; }

        public Color ColorMin { get; set; }
        public Color ColorMax { get; set; }

        public Color ValueToColor(double value)
        {
            Color color = Color.Empty;

            value = (value - Min) / (Max - Min);
            value = Math.Log(value + 1, 2);

            if (value >= 0.0 && value <= 1.0)
            {
                Color clr = Color.FromArgb((byte)(ColorMin.A + value * (ColorMax.A - ColorMin.A)),
                  (byte)(ColorMin.R + value * (ColorMax.R - ColorMin.R)),
                  (byte)(ColorMin.G + value * (ColorMax.G - ColorMin.G)),
                  (byte)(ColorMin.B + value * (ColorMax.B - ColorMin.B)));

                color = clr;
            }

            return color;
        }
    }
}
