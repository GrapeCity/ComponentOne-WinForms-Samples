using System;
using System.Data;
using System.Data.OleDb;
using C1.Win.Ribbon;
using System.ComponentModel;
using C1.Win.C1Themes;
using C1.Win.RulesManager;
using System.Linq;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using C1.Win.Chart;
using C1.Win.CoditionalFormatting;
using System.Collections.Generic;
using C1.Chart;
using System.Collections.Specialized;
using System.Collections;
using C1.Win.Chart.Interaction;

namespace ControlExplorer.RulesManager
{
    public partial class ChartConditionalFormatting : C1DemoForm
    {
        private const string xmlFileName = "ChartConditionalFormattingRules.xml";
        private string pathToXmlFile = null;

        #region Initialization

        public ChartConditionalFormatting()
        {
            InitializeComponent();
        }

        private void ChartConditionalFormatting_Load(object sender, EventArgs e)
        {
            rulesManager.Options.AllowedRules = RuleTypes.Gradient;
            rulesManager.Options.IsFontStyleVisible = false;
            rulesManager.Options.IsHistogramVisible = false;
            rulesManager.Options.IsTextAlignVisible = false;
            rulesManager.Options.IsTextColorVisible = false;

            var dataSource = DemoDataSource("select top 9 * from Products where UnitsInStock > 0 and UnitsOnOrder > 0 ", true);

            formattablePieChart.ToolTip.Content = "{name} : {value}";
            formattablePieChart.DataSource = dataSource;
            formattablePieChart.DataSourceChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));            

            formattableFlexChart.DataSource = dataSource;
            formattableFlexChart.DataSourceChanged(new ListChangedEventArgs(ListChangedType.Reset, 0));

            var horizontalScrollbar = new AxisScrollbar(formattableFlexChart.AxisX);
            horizontalScrollbar.ScrollButtonsVisible = false;

            ApplyRules();

            // uncomment line below to allow saving of changed rules in xml file and loading of it on startup of application
            // rulesManager.RulesChanged += RulesManager_RulesChanged;
        }

        private void ApplyRules()
        {
            pathToXmlFile = Path.Combine(Directory.GetCurrentDirectory(), xmlFileName);

            if (!File.Exists(pathToXmlFile))
            {
                ApplyPredefinedRules();
            }
            else
            {
                rulesManager.LoadRules(pathToXmlFile);
            }
        }

        private void ApplyPredefinedRules()
        {
            var rule1 = new C1.Win.RulesManager.Rule()
            {
                Name = "Product rating",
                Expression = "= true",
                Style = new ItemStyle()
                {
                    Gradient = new GradientSettings()
                    {
                        IconList = IconListKey.Star,
                        IconPoints = new GradientPoint[]
                        {
                            new GradientPoint(GradientPointType.MinValue),
                            new GradientPoint(GradientPointType.MaxValue)
                        }
                    }
                }
            };
            rule1.AppliesTo.Add(new FieldRange(new string[] { "UnitsOnOrder" }));
            rulesManager.Rules.Add(rule1);

            var rule2 = new C1.Win.RulesManager.Rule()
            {
                Name = "Stock availability",
                Expression = "= true",
                Style = new ItemStyle()
                {
                    Gradient = new GradientSettings()
                    {
                        IconList = IconListKey.TrafficLight,
                        IconPoints = new GradientPoint[]
                        {
                            new GradientPoint(GradientPointType.MinValue),
                            new GradientPoint(GradientPointType.MaxValue)
                        }
                    }
                }
            };
            rule2.AppliesTo.Add(new FieldRange(new string[] { "UnitsInStock" }));
            rulesManager.Rules.Add(rule2);
        }

        private void RulesManager_RulesChanged(object sender, ListChangedEventArgs e)
        {
            rulesManager.SaveRules(pathToXmlFile);
        }

        #endregion

    }

    #region FormattablePieChart

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

    #endregion

    #region FormattableFlexChart

    public class FormattableFlexChart : C1.Win.Chart.FlexChart, IFormattableView
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
            if (series != null)
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

    #endregion

}
