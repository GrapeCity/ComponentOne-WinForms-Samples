using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace C1.C1Report.CustomFields.Maps
{
    /// <summary>
    /// A WPF control used to draw a map legend.
    /// </summary>
    internal class MapperLegend : Border
    {
        /// <summary>
        /// Defaults.
        /// </summary>
        private static class Constants
        {
            public const double BorderThickness = 1;
            public static readonly Brush BorderBrush = Brushes.LightSlateGray;
            public const double Margin = 12;
        }

        private StackPanel ItemsContainer
        {
            get;
            set;
        }

        public MapperLegend()
        {
            this.VerticalAlignment = System.Windows.VerticalAlignment.Top;
            this.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            this.Margin = new Thickness(Constants.Margin);
            //
            this.BorderBrush = Constants.BorderBrush;
            this.BorderThickness = new Thickness(Constants.BorderThickness);
            //
            ItemsContainer = new StackPanel();
            this.Child = ItemsContainer;
        }

        public void UpdateFromOwner(IMapperOwner owner, Legend mapLegend)
        {
            ItemsContainer.Children.Clear();
            if (owner == null || mapLegend == null)
                return;

            // Orientation:
            ItemsContainer.Orientation = mapLegend.Orientation == System.Windows.Forms.Orientation.Vertical ?
                Orientation.Vertical : Orientation.Horizontal;

            // alignment:
            HorizontalAlignment horz;
            VerticalAlignment vert;
            Util.ContentToHorzVertAlign(mapLegend.LegendAlignment, out horz, out vert);
            this.HorizontalAlignment = horz;
            this.VerticalAlignment = vert;

            // margins
            this.Margin = new Thickness(
                mapLegend.Margin.Left, mapLegend.Margin.Top, mapLegend.Margin.Right, mapLegend.Margin.Bottom);
            this.BorderThickness = new Thickness(
                mapLegend.BorderThickness.Left, mapLegend.BorderThickness.Top, mapLegend.BorderThickness.Right, mapLegend.BorderThickness.Bottom);
            this.Padding = new Thickness(
                mapLegend.Padding.Left, mapLegend.Padding.Top, mapLegend.Padding.Right, mapLegend.Padding.Bottom);

            //
            this.Background = Util.BrushFromGdiColor(mapLegend.BackColor);

            double padding = 0;
            if (!string.IsNullOrEmpty(mapLegend.Caption))
            {
                ItemsContainer.Children.Add(MakeLegendCaption(mapLegend, owner, out padding));
            }

            Action<IEnumerable> addItems = (items) =>
                {
                    foreach (ILegendItem li in items)
                    {
                        if (li.LegendItemVisible)
                        {
                            var item = MakeItem(li, mapLegend, owner);
                            if (item != null)
                                ItemsContainer.Children.Add(item);
                        }
                    }
                };

            if (mapLegend.Automatic)
                addItems(mapLegend.Owner.Layers);
            else
                addItems(mapLegend.Items);
        }

        private UIElement MakeItem(ILegendItem legendItem, Legend legend, IMapperOwner owner)
        {
            switch (legendItem.LegendItemKind)
            {
                case LegendItemKind.Point:
                    return MakePointItem(legendItem, legend, owner);
                case LegendItemKind.Line:
                    return MakeLineItem(legendItem, legend, owner);
                case LegendItemKind.KML:
                case LegendItemKind.None:
                    return null;
                case LegendItemKind.ColorSwatch:
                    return MakeColorSwatchItem(legendItem, legend, owner);
                case LegendItemKind.Text:
                    return MakeTextItem(legendItem, legend, owner);
                default:
                    System.Diagnostics.Debug.Assert(false, "unknown legend item type");
                    return null;
            }
        }

        private TextBlock MakeLegendCaption(Legend legend, IMapperOwner owner, out double padding)
        {
            return MakeItemText(null, legend, owner, out padding);
        }

        private TextBlock MakeTextItem(ILegendItem legendItem, Legend legend, IMapperOwner owner)
        {
            double padding;
            return MakeItemText(legendItem, legend, owner, out padding);
        }

        #region Style handlers
        private System.Drawing.Color GetTextColor(Legend legend, ILegendItem legendItem)
        {
            if (legendItem != null && !Util.IsColorEmpty(legendItem.LegendItemTextColor))
                return legendItem.LegendItemTextColor;
            else
                return legend.TextColor;
        }

        private System.Drawing.Font GetFont(Legend legend, ILegendItem legendItem)
        {
            if (legendItem != null)
                return legendItem.LegendItemFont;
            else
                return legend.Font;
        }

        private System.Drawing.Color GetStrokeColor(Legend legend, ILegendItem legendItem)
        {
            if (legendItem != null)
                return legendItem.LegendItemStrokeColor;
            else
                return System.Drawing.Color.Black;
        }
        #endregion

        private TextBlock MakeItemText(ILegendItem mapperItem, Legend mapLegend, IMapperOwner owner, out double padding)
        {
            // text:
            TextBlock tb = new TextBlock();
            tb.Foreground = Util.BrushFromGdiColor(GetTextColor(mapLegend, mapperItem));
            tb.Text = mapperItem == null ? mapLegend.Caption : mapperItem.LegendItemCaption;
            tb.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            if (mapperItem == null)
                tb.HorizontalAlignment = System.Windows.HorizontalAlignment.Center; // todo: give control to user?
            Util.ApplyFontToTextBlock(GetFont(mapLegend, mapperItem), tb);
            padding = tb.FontSize / 4;
            tb.Margin = new Thickness(padding, 0, padding, 0);
            return tb;
        }

        private UIElement MakePointItem(ILegendItem mapperItem, Legend mapLegend, IMapperOwner owner)
        {
            System.Diagnostics.Debug.Assert(mapperItem.LegendItemKind == LegendItemKind.Point);
            double padding;
            var tb = MakeItemText(mapperItem, mapLegend, owner, out padding);

            // graphics:
            Path p = new Path();
            var stroke = GetStrokeColor(mapLegend, mapperItem);
            p.Stroke = Util.BrushFromGdiColor(stroke);
            var fill = mapperItem.LegendItemFillColor;
            p.Fill = Util.BrushFromGdiColor(fill);

            double size;
            if (mapperItem.LegendItemMarkerSize >= 0)
                size = mapperItem.LegendItemMarkerSize;
            else
                size = tb.FontSize / 3; // a "heuristic" ...
            Geometry eg = Util.MarkerShapeToGeometry(mapperItem.LegendItemMarkerShape, size);
            p.Data = eg;
            p.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            p.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            p.Margin = new Thickness(size + padding, size + padding, padding, padding);

            // combine:
            StackPanel sp = new StackPanel();
            sp.Orientation = Orientation.Horizontal;
            sp.Children.Add(p);
            sp.Children.Add(tb);

            return sp;
        }

        private UIElement MakeLineItem(ILegendItem mapperItem, Legend mapLegend, IMapperOwner owner)
        {
            System.Diagnostics.Debug.Assert(mapperItem.LegendItemKind == LegendItemKind.Line);
            double padding;
            var tb = MakeItemText(mapperItem, mapLegend, owner, out padding);

            // graphics:
            Path p = new Path();
            var stroke = GetStrokeColor(mapLegend, mapperItem);
            p.Stroke = Util.BrushFromGdiColor(stroke);
            var fill = mapperItem.LegendItemFillColor;
            p.Fill = Util.BrushFromGdiColor(fill);
            p.StrokeDashArray = Util.DashStyleToCollection(mapperItem.LegendItemDashStyle);
            if (mapperItem.LegendItemLineThickness >= 0)
                p.StrokeThickness = mapperItem.LegendItemLineThickness;

            LineGeometry lg = new LineGeometry();
            lg.StartPoint = new Point(0, tb.FontSize / 3); // "heuristic" ...
            lg.EndPoint = new Point(tb.FontSize * 3, tb.FontSize / 3); // another one :)
            p.Data = lg;
            p.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            p.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            p.Margin = new Thickness(lg.StartPoint.X + padding, lg.StartPoint.Y + padding, padding, padding);

            // combine:
            StackPanel sp = new StackPanel();
            sp.Orientation = Orientation.Horizontal;
            sp.Children.Add(p);
            sp.Children.Add(tb);

            return sp;
        }

        private UIElement MakeColorSwatchItem(ILegendItem mapperItem, Legend mapLegend, IMapperOwner owner)
        {
            System.Diagnostics.Debug.Assert(mapperItem.LegendItemKind == LegendItemKind.ColorSwatch);
            double padding;
            var tb = MakeItemText(mapperItem, mapLegend, owner, out padding);

            padding = 0; // todo: allow override

            // graphics:
            Path p = new Path();
            var stroke = GetStrokeColor(mapLegend, mapperItem);
            p.Stroke = Util.BrushFromGdiColor(stroke);
            var fill = mapperItem.LegendItemFillColor;
            p.Fill = Util.BrushFromGdiColor(fill);

            double size = tb.FontSize; // / 3; // a "heuristic" ...
            Geometry eg = Util.MarkerShapeToGeometry(MarkerShape.Square, size);
            p.Data = eg;
            p.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            p.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            p.Margin = new Thickness(size + padding, size + padding, padding, padding);

            // combine:
            StackPanel sp = new StackPanel();
            sp.Orientation = Orientation.Horizontal;
            sp.Children.Add(p);
            sp.Children.Add(tb);

            return sp;
        }
    }
}
