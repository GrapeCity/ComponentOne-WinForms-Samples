using C1.Win.C1Chart3D;
using C1.Win.TouchToolKit;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ControlExplorer.ZoomPolicies
{
    public class C1Chart3DZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(C1Chart3D); }
        }

        public override void Terminate(System.Windows.Forms.Control control)
        {
            _zoomedContourStyles.Clear();
            base.Terminate(control);
        }

        public override void ZoomBounds(System.Windows.Forms.Control control, ZoomBoundsInfo infos)
        {
            C1Chart3D chart = control as C1Chart3D;
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
            C1Chart3D chart = control as C1Chart3D;
            ZoomChartGroups(infos, chart.ChartGroups);
            ZoomChartArea(infos, chart.ChartArea);
            ZoomTitle(infos, chart.Header);
            ZoomTitle(infos, chart.Footer);
            ZoomLegend(infos, chart.Legend);
            ZoomChartLabels(infos, chart.ChartLabels);

            ZoomStyle(infos, chart.Style);
            ZoomStyle(infos, chart.AreaStyle);
            ZoomStyle(infos, chart.DefaultLabelStyle);
            ZoomStyle(infos, chart.FooterStyle);
            ZoomStyle(infos, chart.HeaderStyle);
            ZoomStyle(infos, chart.LegendStyle);
        }

        private void ZoomChartGroups(ZoomBoundsInfo infos, Chart3DGroups groups)
        {
            if (groups == null)
            {
                return;
            }
            foreach (Chart3DStyle style in groups.ChartStyles)
            {
                ZoomChart3DStyle(infos, style);
            }
            foreach (Chart3DContourStyle style in groups.ContourStyles.Styles)
            {
                ZoomContourStyles(infos, style);
            }
            foreach (Chart3DGroup group in groups.ChartGroupsCollection)
            {
                if (group.Contour != null)
                {
                    foreach (Chart3DContourLevel level in group.Contour.Levels)
                    {
                        ZoomContourStyles(infos, level.Style);
                    }
                }
                if (group.ChartData.SetPoint != null)
                {
                    foreach (Chart3DPointSeries series in group.ChartData.SetPoint.SeriesCollection)
                    {
                        ZoomDataSeries(infos, series);
                    }
                }
            }
        }

        private void ZoomChartGroups(ZoomFontInfo infos, Chart3DGroups groups)
        {
            if (groups == null)
            {
                return;
            }
            foreach (Chart3DGroup group in groups.ChartGroupsCollection)
            {
                if (group.ChartData.SetPoint != null)
                {
                    foreach (Chart3DPointSeries series in group.ChartData.SetPoint.SeriesCollection)
                    {
                        ZoomDataSeries(infos, series);
                    }
                }
            }
        }


        private void ZoomChartLabels(ZoomBoundsInfo infos, Chart3DLabels labels)
        {
            if (labels == null)
            {
                return;
            }
            foreach (Chart3DLabel label in labels.LabelsCollection)
            {
                ZoomChartLabel(infos, label);
            }
        }

        private void ZoomChartLabels(ZoomFontInfo infos, Chart3DLabels labels)
        {
            if (labels == null)
            {
                return;
            }
            ZoomStyle(infos, labels.DefaultStyle);
            foreach (Chart3DLabel label in labels.LabelsCollection)
            {
                ZoomChartLabel(infos, label);
            }
        }

        private void ZoomChartLabel(ZoomBoundsInfo infos, Chart3DLabel label)
        {
            if (label == null)
            {
                return;
            }
            if (label.AttachMethodData.X > 0 || label.AttachMethodData.Y > 0)
            {
                float x = label.AttachMethodData.X;
                float y = label.AttachMethodData.Y;
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

        private void ZoomChartLabel(ZoomFontInfo infos, Chart3DLabel label)
        {
            if (label == null)
            {
                return;
            }
            ZoomStyle(infos, label.Style);
        }

        private void ZoomChartArea(ZoomBoundsInfo infos, Chart3DArea area)
        {
            if (area == null)
            {
                return;
            }
            foreach (Chart3DAxis axis in area.Axes)
            {
                ZoomAxis(infos, axis);
            }
            ZoomChartView(infos, area.View);
            if (area.LocationDefault.X > 0 || area.LocationDefault.Y > 0)
            {
                area.LocationDefault = ZoomPoint(infos, area.LocationDefault);
            }
            if (area.SizeDefault.Width > 0 || area.SizeDefault.Height > 0)
            {
                area.SizeDefault = ZoomSize(infos, area.SizeDefault);
            }
        }

        private void ZoomChartArea(ZoomFontInfo infos, Chart3DArea area)
        {
            if (area == null)
            {
                return;
            }
            ZoomStyle(infos, area.Style);
            foreach (Chart3DAxis axis in area.Axes)
            {
                ZoomAxis(infos, axis);
            }
            ZoomChartView(infos, area.View);
        }

        private void ZoomAxis(ZoomBoundsInfo infos, Chart3DAxis axis)
        {
            if (axis == null)
            {
                return;
            }
            if (axis.MajorGrid.Style.Thickness > 0)
            {
                axis.MajorGrid.Style.Thickness = infos.Zoom(axis.MajorGrid.Style.Thickness);
            }
        }

        private void ZoomAxis(ZoomFontInfo infos, Chart3DAxis axis)
        {
            if (axis == null)
            {
                return;
            }
        }

        private void ZoomChartView(ZoomBoundsInfo infos, Chart3DView view)
        {
            if (view == null)
            {
                return;
            }
        }

        private void ZoomChartView(ZoomFontInfo infos, Chart3DView view)
        {
            if (view == null)
            {
                return;
            }
        }

        private void ZoomDataSeries(ZoomBoundsInfo infos, Chart3DPointSeries dataSeries)
        {
            if (dataSeries == null)
            {
                return;
            }
            ZoomChart3DStyle(infos, dataSeries.Style);
        }

        private void ZoomChart3DStyle(ZoomBoundsInfo infos, Chart3DStyle Style)
        {
            if (Style.SymbolStyle.Size > 0)
            {
                Style.SymbolStyle.Size = infos.Zoom(Style.SymbolStyle.Size);
            }
            Style.LineStyle.Thickness = infos.Zoom(Style.LineStyle.Thickness);
        }

        private void ZoomDataSeries(ZoomFontInfo infos, Chart3DPointSeries dataSeries)
        {
            if (dataSeries == null)
            {
                return;
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

        private void ZoomLegend(ZoomBoundsInfo infos, Chart3DLegend legend)
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

        private void ZoomLegend(ZoomFontInfo infos, Chart3DLegend legend)
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

        private List<Chart3DContourStyle> _zoomedContourStyles = new List<Chart3DContourStyle>();
        private void ZoomContourStyles(ZoomBoundsInfo infos, Chart3DContourStyle style)
        {
            if (style.LineStyle.Thickness > 0
                && !_zoomedContourStyles.Contains(style))
            {
                style.LineStyle.Thickness = infos.Zoom(style.LineStyle.Thickness);
                _zoomedContourStyles.Add(style);
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

