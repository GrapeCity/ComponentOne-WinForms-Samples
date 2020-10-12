using C1.Win.C1Chart;
using C1.Win.TouchToolKit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ControlExplorer.ZoomPolicies
{
    public class C1ChartZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1Chart); }
        }

        public override void Terminate(System.Windows.Forms.Control control)
        {
            _zoomedLineStyles.Clear();
            _zoomedSymbolStyle.Clear();
            base.Terminate(control);
        }

        public override void ZoomBounds(System.Windows.Forms.Control control, ZoomBoundsInfo infos)
        {
            C1Chart chart = control as C1Chart;
            ZoomChartGroups(infos, chart.ChartGroups);
            ZoomChartArea(infos, chart.ChartArea);
            ZoomTitle(infos, chart.Header);
            ZoomTitle(infos, chart.Footer);
            ZoomLegend(infos, chart.Legend);
            ZoomChartLabels(infos, chart.ChartLabels);
            base.ZoomBounds(control, infos);
        }

        public override void ZoomFont(System.Windows.Forms.Control control, ZoomFontInfo infos)
        {
            base.ZoomFont(control, infos);
            C1Chart chart = control as C1Chart;
            ZoomChartGroups(infos, chart.ChartGroups);
            ZoomChartArea(infos, chart.ChartArea);
            ZoomTitle(infos, chart.Header);
            ZoomTitle(infos, chart.Footer);
            ZoomLegend(infos, chart.Legend);
            ZoomChartLabels(infos, chart.ChartLabels);
            ZoomStyle(infos, chart.Style);
        }

        private void ZoomChartGroups(ZoomBoundsInfo infos, ChartGroups groups)
        {
            if (groups == null)
            {
                return;
            }
            foreach (ChartGroup group in groups.ChartGroupsCollection)
            {
                foreach (FunctionBase functionBase in group.ChartData.FunctionsList)
                {
                    ZoomLineStyle(infos, functionBase.LineStyle);
                }
                foreach (ChartDataSeries series in group.ChartData.SeriesList)
                {
                    ZoomDataSeries(infos, series);
                }
            }
        }

        private void ZoomChartGroups(ZoomFontInfo infos, ChartGroups groups)
        {
            if (groups == null)
            {
                return;
            }
            foreach (ChartGroup group in groups.ChartGroupsCollection)
            {
                foreach (ChartDataSeries series in group.ChartData.SeriesList)
                {
                    ZoomDataSeries(infos, series);
                }
            }
        }


        private void ZoomChartLabels(ZoomBoundsInfo infos, ChartLabels labels)
        {
            if (labels == null)
            {
                return;
            }
            foreach (Label label in labels.LabelsCollection)
            {
                ZoomChartLabel(infos, label);
            }
        }

        private void ZoomChartLabels(ZoomFontInfo infos, ChartLabels labels)
        {
            if (labels == null)
            {
                return;
            }
            ZoomStyle(infos, labels.DefaultLabelStyle);
            foreach (Label label in labels.LabelsCollection)
            {
                ZoomChartLabel(infos, label);
            }
        }

        private void ZoomChartLabel(ZoomBoundsInfo infos, Label label)
        {
            if (label == null)
            {
                return;
            }
            if (label.AttachMethodData.X > 0 || label.AttachMethodData.Y > 0)
            {
                double x = label.AttachMethodData.X;
                double y = label.AttachMethodData.Y;
                x = x > 0 ? infos.Zoom(x) : x;
                y = y > 0 ? infos.Zoom(y) : y;
                label.AttachMethodData.X = x;
                label.AttachMethodData.Y = y;
            }
            if (label.SizeDefault.Width > 0 || label.SizeDefault.Height > 0)
            {
                label.SizeDefault = ZoomSize(infos, label.SizeDefault);
            }
        }

        private void ZoomChartLabel(ZoomFontInfo infos, Label label)
        {
            if (label == null)
            {
                return;
            }
            ZoomStyle(infos, label.Style);
        }

        private void ZoomChartArea(ZoomBoundsInfo infos, Area area)
        {
            if (area == null)
            {
                return;
            }
            foreach (Axis axis in area.Axes)
            {
                ZoomAxis(infos, axis);
            }
            ZoomPlotArea(infos, area.PlotArea);
            if (area.LocationDefault.X > 0 || area.LocationDefault.Y > 0)
            {
                area.LocationDefault = ZoomPoint(infos, area.LocationDefault);
            }
            if (area.SizeDefault.Width > 0 || area.SizeDefault.Height > 0)
            {
                area.SizeDefault = ZoomSize(infos, area.SizeDefault);
            }
        }

        private void ZoomChartArea(ZoomFontInfo infos, Area area)
        {
            if (area == null)
            {
                return;
            }
            ZoomStyle(infos, area.Style);
            foreach (Axis axis in area.Axes)
            {
                ZoomAxis(infos, axis);
            }
            ZoomPlotArea(infos, area.PlotArea);
        }

        private void ZoomAxis(ZoomBoundsInfo infos, Axis axis)
        {
            if (axis == null)
            {
                return;
            }
            axis.Thickness = infos.Zoom(axis.Thickness);
            foreach (ValueLabel valueLabel in axis.ValueLabels)
            {
                if (valueLabel.MarkerSize > 0)
                {
                    valueLabel.MarkerSize = infos.Zoom(valueLabel.MarkerSize);
                }
            }
        }

        private void ZoomAxis(ZoomFontInfo infos, Axis axis)
        {
            if (axis == null)
            {
                return;
            }

            if (axis.ShouldSerializeFont())
            {
                axis.Font = infos.Zoom(axis.Font);
            }
        }

        private void ZoomPlotArea(ZoomBoundsInfo infos, PlotArea plotArea)
        {
            if (plotArea == null)
            {
                return;
            }
            if (plotArea.LocationDefault.X > 0 || plotArea.LocationDefault.Y > 0)
            {
                plotArea.LocationDefault = ZoomPoint(infos, plotArea.LocationDefault);
            }
            if (plotArea.SizeDefault.Width > 0 || plotArea.SizeDefault.Height > 0)
            {
                plotArea.SizeDefault = ZoomSize(infos, plotArea.SizeDefault);
            }
            foreach (AlarmZone alarmZone in plotArea.AlarmZones)
            {
                if (alarmZone.MinHeight > 0)
                {
                    alarmZone.MinHeight = infos.Zoom(alarmZone.MinHeight);
                }
                if (alarmZone.MinWidth > 0)
                {
                    alarmZone.MinWidth = infos.Zoom(alarmZone.MinWidth);
                }
            }
        }

        private void ZoomPlotArea(ZoomFontInfo infos, PlotArea plotArea)
        {
        }

        private void ZoomDataSeries(ZoomBoundsInfo infos, ChartDataSeries dataSeries)
        {
            if (dataSeries == null)
            {
                return;
            }
            ZoomSymbolStyle(infos, dataSeries.SymbolStyle);
            ZoomLineStyle(infos, dataSeries.LineStyle);
        }

        private void ZoomDataSeries(ZoomFontInfo infos, ChartDataSeries dataSeries)
        {
            if (dataSeries == null)
            {
                return;
            }
            if (dataSeries.DataLabel != null)
            {
                ZoomStyle(infos, dataSeries.DataLabel.Style);
            }
        }


        private void ZoomTitle(ZoomBoundsInfo infos, Title title)
        {
            if (title == null)
            {
                return;
            }
            if (title.LocationDefault.X > 0 || title.LocationDefault.Y > 0)
            {
                title.LocationDefault = ZoomPoint(infos, title.LocationDefault);
            }
            if (title.SizeDefault.Width > 0 || title.SizeDefault.Height > 0)
            {
                title.SizeDefault = ZoomSize(infos, title.SizeDefault);
            }
        }

        private void ZoomTitle(ZoomFontInfo infos, Title title)
        {
            if (title == null)
            {
                return;
            }
            ZoomStyle(infos, title.Style);
        }

        private void ZoomLegend(ZoomBoundsInfo infos, Legend legend)
        {
            if (legend == null)
            {
                return;
            }
            if (legend.LocationDefault.X > 0 || legend.LocationDefault.Y > 0)
            {
                legend.LocationDefault = ZoomPoint(infos, legend.LocationDefault);
            }
            if (legend.SizeDefault.Width > 0 || legend.SizeDefault.Height > 0)
            {
                legend.SizeDefault = ZoomSize(infos, legend.SizeDefault);
            }
        }

        private void ZoomLegend(ZoomFontInfo infos, Legend legend)
        {
            if (legend == null)
            {
                return;
            }
            ZoomStyle(infos, legend.Style);
        }

        private Point ZoomPoint(ZoomBoundsInfo infos, Point point)
        {
            int x = point.X;
            int y = point.Y;
            x = x > 0 ? infos.Zoom(x) : x;
            y = y > 0 ? infos.Zoom(y) : y;
            return new Point(x, y);
        }

        private static Size ZoomSize(ZoomBoundsInfo infos, Size size)
        {
            int width = size.Width;
            int height = size.Height;
            width = width > 0 ? infos.Zoom(width) : width;
            height = height > 0 ? infos.Zoom(height) : height;
            return new Size(width, height);
        }

        private List<ChartLineStyle> _zoomedLineStyles = new List<ChartLineStyle>();
        private void ZoomLineStyle(ZoomBoundsInfo infos, ChartLineStyle lineStyle)
        {
            if (lineStyle.Thickness > 0
                && !_zoomedLineStyles.Contains(lineStyle))
            {
                lineStyle.Thickness = infos.Zoom(lineStyle.Thickness);
                _zoomedLineStyles.Add(lineStyle);
            }
        }


        private List<ChartSymbolStyle> _zoomedSymbolStyle = new List<ChartSymbolStyle>();
        private void ZoomSymbolStyle(ZoomBoundsInfo infos, ChartSymbolStyle symbolStyle)
        {
            if (symbolStyle.Size > 0
                && !_zoomedSymbolStyle.Contains(symbolStyle))
            {
                symbolStyle.Size = infos.Zoom(symbolStyle.Size);
                _zoomedSymbolStyle.Add(symbolStyle);
            }
        }

        private void ZoomStyle(ZoomFontInfo infos, Style style)
        {
            if (style == null || style.Font == null)
            {
                return;
            }
            style.Font = infos.Zoom(style.Font);
        }


    }
}

