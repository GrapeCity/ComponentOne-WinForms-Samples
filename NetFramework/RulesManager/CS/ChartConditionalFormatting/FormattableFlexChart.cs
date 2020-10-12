using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using C1.Chart;
using C1.Win.Chart;
using C1.Win.CoditionalFormatting;

namespace ChartConditionalFormatting
{
    public class FormattableFlexChart : FlexChart, IFormattableView
    {
        private IItemStyle style;
        public event ListChangedEventHandler DataChanged;
        public event EventHandler<ItemFormattingEventArgs> ItemFormatting;

        public IEnumerable<string> GetFieldNames() => Series.Select(s => s.Name);

        public int GetItemCount()
        {
            int count = 0;
            foreach (var serie in Series)
            {
                var values = serie.GetValues(0);
                if (values != null)
                {
                    count = Math.Max(count, values.Count());
                }
            }
            return count;
        }

        public object GetValue(int item, string field)
        {
            var matchedSeries = Series.Where(s => s.Name == field);
            if (matchedSeries != null && matchedSeries.Count() > 0)
            {
                var values = ((ISeries)matchedSeries.First()).GetValues(0);
                if (values != null && values.Length > item && item >= 0)
                {
                    return values[item];
                }
            }
            return null;
        }

        public void UpdateView() => Invalidate();

        protected override void Series_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Attach(e.NewItems);
                    break;
                case NotifyCollectionChangedAction.Move:
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Detach(e.OldItems);
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Detach(e.OldItems);
                    Attach(e.NewItems);
                    break;
                case NotifyCollectionChangedAction.Reset:
                    Detach(e.OldItems);
                    break;
            }
            base.Series_CollectionChanged(sender, e);
        }

        public void DataSourceChanged(ListChangedEventArgs e) => DataChanged?.Invoke(this, e);

        private void Attach(IEnumerable objs)
        {
            if (objs != null)
            {
                foreach (var item in objs)
                {
                    Attach(item);
                }
            }
        }

        private void Detach(IEnumerable objs)
        {
            if (objs != null)
            {
                foreach (var item in objs)
                {
                    Detach(item);
                }
            }
        }

        private void Attach(object obj)
        {
            var series = obj as Series;
            if(series != null)
            {
                series.SymbolRendering += OnSeriesSymbolRendering;
                series.SymbolRendered += OnSeriesSymbolRendered;
            }
        }

        private void Detach(object obj)
        {
            var series = obj as Series;
            if (series != null)
            {
                series.SymbolRendering -= OnSeriesSymbolRendering;
                series.SymbolRendered -= OnSeriesSymbolRendered;
            }
        }

        private void OnSeriesSymbolRendering(object sender, RenderSymbolEventArgs e)
        {
            if (e.Series == null && e.Series.Name == null)
            {
                return;
            }

            var args = new ItemFormattingEventArgs(e.Index, e.Series.Name);
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

        private void OnSeriesSymbolRendered(object sender, RenderSymbolEventArgs e)
        {
            if (style != null)
            {
                var icon = style.Icon;
                if (icon != null)
                {
                    e.Engine.DrawImage(icon, e.Point.X - icon.Width * 0.5, e.Point.Y, icon.Width, icon.Height);
                }
            }
        }
    }
}