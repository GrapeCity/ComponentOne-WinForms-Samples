using System;
using System.ComponentModel;
using System.Collections.Generic;
using C1.Chart;
using C1.Win.Chart;
using C1.Win.CoditionalFormatting;

namespace ChartConditionalFormatting
{
    public class FormattablePieChart : FlexPie, IFormattableView
    {
        private IItemStyle style;
        public event ListChangedEventHandler DataChanged;
        public event EventHandler<ItemFormattingEventArgs> ItemFormatting;

        public FormattablePieChart()
        {
            SliceRendering += FormattablePieChart_SliceRendering;
            SliceRendered += FormattablePieChart_SliceRendered;
        }

        public IEnumerable<string> GetFieldNames() => new string[] { Binding };

        public int GetItemCount()
        {
            var names = ((IPieChart)this).GetNames();
            if (names == null)
            {
                return 0;
            }

            return names.Length;
        }

        public object GetValue(int item, string field)
        {
            return ((IPieChart)this).GetValues()[item];
        }

        public void UpdateView() => Invalidate();

        private void FormattablePieChart_SliceRendering(object sender, RenderSliceEventArgs e)
        {
            var pie = (IPieChart)this;
            var args = new ItemFormattingEventArgs(e.Index, Binding);
            ItemFormatting?.Invoke(this, args);

            style = args.Style;
            if (style != null)
            {
                var backColor = style.BackColor;
                if (!backColor.IsEmpty)
                {
                    e.Engine.SetFill(backColor.ToArgb());
                }

                var borderColor = args.Style.BorderColor;
                if (!borderColor.IsEmpty)
                {
                    e.Engine.SetStroke(borderColor.ToArgb());
                }
            }
        }

        private void FormattablePieChart_SliceRendered(object sender, RenderSliceEventArgs e)
        {
            if (style != null)
            {
                var icon = style.Icon;
                if (icon != null)
                {
                    var a2 = e.Angle + e.Sweep / 2f;
                    var x = e.CenterX + (Math.Cos(a2) * (e.InnerRadius + e.Radius) - icon.Width) * 0.5;
                    var y = e.CenterY + (Math.Sin(a2) * (e.InnerRadius + e.Radius) - icon.Height) * 0.5;
                    e.Engine.DrawImage(icon, x, y, icon.Width, icon.Height);
                }
            }
        }

        public void DataSourceChanged(ListChangedEventArgs e) => DataChanged?.Invoke(this, e);
    }
}
