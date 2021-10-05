using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Chart;
using C1.Chart.Printing;

namespace FlexChartPrint.Samples
{
    public partial class MultiChartPrint : BaseChartPrint
    {
        public MultiChartPrint()
        {
            InitializeComponent();
        }

        protected override string Title
        {
            get { return "Multiple Page Printing"; }
        }

        private void btnMultiChart_Click(object sender, EventArgs e)
        {
            MultiChartPageClick(true);
        }

        private void btnMultiPage_Click(object sender, EventArgs e)
        {
            MultiChartPageClick(false);
        }

        private void drawMarginedRectangle(Graphics g, Rectangle rect, Rectangle origin)
        {
            // Draw the Rectangle rect offset by the location of the origin Rectangle
            if (rect.Width == 0) rect.Width = origin.Width;
            if (rect.Height == 0) rect.Height = origin.Height;

            rect = new Rectangle(rect.Left + origin.Left - 1, rect.Top + origin.Top - 1, rect.Width + 2, rect.Height + 2);
            g.DrawRectangle(Pens.Black, rect);
        }

        private void MultiChartPageClick(bool singlePage)
        {
            InitializePageSettings();

            PrintDocument pd = new PrintDocument();

            pd.DefaultPageSettings = BaseSample.pageSets;

            if (BaseSample.prnSets != null)
                pd.PrinterSettings = BaseSample.prnSets;

            int pageNumber = 0;

            pd.PrintPage += (pageSender, printPageEventArgs) =>
            {
                FlexChart flexChart = BaseSample.FlexChart;

                // Each chart or page could use a different FlexChart instance, but for simplicity
                // of the sample, a single FlexChart instance is used with minor changes to differentiate them.
                ChartPrinter chartPrinter = new ChartPrinter(flexChart, true);

                // Save changes to the FlexChart instance so they can be restored later.
                Color originalBackgroundColor = flexChart.BackColor;
                string title = flexChart.Header.Content;

                pageNumber++;

                // the chart is drawn within the rectangle assuming coordinates relative
                // to the Top-Left page margin as specifiec in the prinPageEventArgs.
                Rectangle rect = singlePage ? new Rectangle(0, 100, 400, 200) : Rectangle.Empty;

                printPageEventArgs.HasMorePages = pageNumber < 4;       // sanity check to avoid endless loop.

                // Print the chart 4 times with different modified charts.
                if (singlePage || (!singlePage && pageNumber == 1))
                {
                    flexChart.BackColor = Color.Yellow;
                    flexChart.Header.Content = "Fit With Yellow Background";
                    chartPrinter.PrinterCtrlToPage(pd, printPageEventArgs, ChartPrinter.PrintScale.Fit, rect, false);
                    drawMarginedRectangle(printPageEventArgs.Graphics, rect, printPageEventArgs.MarginBounds);
                }

                // same chart with GrayScale next to it.
                if (singlePage || (!singlePage && pageNumber == 2))
                {
                    if (singlePage) rect.X += rect.Width + 50;
                    flexChart.Header.Content = "Fit With Yellow Background in GrayScale";
                    chartPrinter.PrinterCtrlToPage(pd, printPageEventArgs, ChartPrinter.PrintScale.Fit, rect, true);
                    drawMarginedRectangle(printPageEventArgs.Graphics, rect, printPageEventArgs.MarginBounds);
                }

                if (singlePage || (!singlePage && pageNumber == 3))
                {
                    if (singlePage) { rect.X -= rect.Width + 50; rect.Y += rect.Height + 50; }
                    flexChart.BackColor = Color.Green;
                    flexChart.Header.Content = "Zoomed With Green Background";
                    chartPrinter.PrinterCtrlToPage(pd, printPageEventArgs, ChartPrinter.PrintScale.Zoom, rect, false);
                    drawMarginedRectangle(printPageEventArgs.Graphics, rect, printPageEventArgs.MarginBounds);
                }


                if (singlePage || (!singlePage && pageNumber == 4))
                {
                    if (singlePage) rect.X += rect.Width + 50;
                    flexChart.BackColor = Color.MistyRose;
                    flexChart.Header.Content = "Stretched With Rose Background";
                    chartPrinter.PrinterCtrlToPage(pd, printPageEventArgs, ChartPrinter.PrintScale.Stretch, rect, false);
                    drawMarginedRectangle(printPageEventArgs.Graphics, rect, printPageEventArgs.MarginBounds);
                    printPageEventArgs.HasMorePages = false;
                    pageNumber = 0;     // zero for the next print from preview dialog.
                }

                // restore modified chart setting to original values.
                flexChart.Header.Content = title;
                flexChart.BackColor = originalBackgroundColor;
            };

            ChartPrinter.ChartPreviewDialogEx(pd, BaseSample.prnSets == null);

            pd.Dispose();
        }

        private void btnSubCharts_Click(object sender, EventArgs e)
        {
            FlexChart flexChart = BaseSample.FlexChart;

            InitializePageSettings();

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings = BaseSample.pageSets;
            pd.PrinterSettings = BaseSample.prnSets;

            int pageNumber = 0;

            // determine the limits over which the chart should be printed.
            int pageCount = 8;
            double minXValue = 0;
            double maxXValue = BaseSample.maximumXValue;

            double increment = (maxXValue - minXValue) / pageCount;

            double minFlex = double.NaN, maxFlex = double.NaN;
            double minFlexY = double.NaN, maxFlexY = double.NaN;

            pd.BeginPrint += (pageSender, beginPrintEventArgs) =>
            {
                // save the current axis limits
                minFlex = flexChart.AxisX.Min;
                maxFlex = flexChart.AxisX.Max;
                minFlexY = flexChart.AxisY.Min;
                maxFlexY = flexChart.AxisY.Max;

                flexChart.AxisX.Min = minXValue;
                flexChart.AxisX.Max = increment;
                flexChart.AxisY.Min = flexChart.AxisY.ActualMin;
                flexChart.AxisY.Max = flexChart.AxisY.ActualMax;

                pageNumber = 0;
            };


            pd.PrintPage += (pageSender, printPageEventArgs) =>
            {
                // Each chart or page could use a different FlexChart instance, but in this case
                // subsets of a single FlexChart instance is used.
                ChartPrinter chartPrinter = new ChartPrinter(flexChart, true);
                pageNumber++;

                // The chart is drawn within the rectangle assuming coordinates relative
                // to the Top-Left page margin as specifiec in the prinPageEventArgs.
                // An empty rectangle indicates a full page rather than a limited
                // rectangle on the page.
                Rectangle rect = new Rectangle(0, 0, 0, 0);

                printPageEventArgs.HasMorePages = pageNumber < 30;       // sanity check to avoid endless loop.
                chartPrinter.PrinterCtrlToPage(pd, printPageEventArgs, ChartPrinter.PrintScale.Fit, rect, false);

                bool morePages = flexChart.AxisX.Max < maxXValue;
                printPageEventArgs.HasMorePages = morePages;

                if (morePages)
                {
                    // set up for the next page.
                    flexChart.AxisX.Min += increment;
                    flexChart.AxisX.Max += increment;
                }
            };

            pd.EndPrint += (pageSender, endPrintEventArgs) =>
            {
                // restore the axis limits
                flexChart.AxisX.Max = maxFlex;
                flexChart.AxisX.Min = minFlex;
                flexChart.AxisY.Max = maxFlexY;
                flexChart.AxisY.Min = minFlexY;

                // reset for next print from preview dialog.
                pageNumber = 0;
            };

            ChartPrinter.ChartPreviewDialogEx(pd, true);
            pd.Dispose();
        }

        private void btnStripChart_Click(object sender, EventArgs e)
        {
            InitializePageSettings();

            FlexChart flexChart = BaseSample.FlexChart;
            PageSettings pageSets = BaseSample.pageSets;
            PrinterSettings prnSets = BaseSample.prnSets;

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings = pageSets;
            pd.PrinterSettings = prnSets;

            int pageNumber = 0;

            // determine the limits over which the chart should be printed.
            int pageCount = 8;

            int pageWidth = pageSets.Bounds.Width - pageSets.Margins.Left - pageSets.Margins.Right;
            int pageHeight = pageSets.Bounds.Height - pageSets.Margins.Top - pageSets.Margins.Bottom;

            int bitMapWidth = pageCount * pageWidth;
            int bitMapHeight = pageHeight;

            // save the current axis limits and units
            double minFlex = flexChart.AxisX.Min;
            double maxFlex = flexChart.AxisX.Max;
            double minFlexY = flexChart.AxisY.Min;
            double maxFlexY = flexChart.AxisY.Max;
            double xunit = flexChart.AxisX.MajorUnit;

            // set the axis limits and units for bitmap creation
            flexChart.AxisX.Min = 0;
            flexChart.AxisX.Max = BaseSample.maximumXValue;
            flexChart.AxisY.Min = flexChart.AxisY.ActualMin;
            flexChart.AxisY.Max = flexChart.AxisY.ActualMax;
            flexChart.AxisX.MajorUnit = 1;
            flexChart.AxisX.MinorTickMarks = C1.Chart.TickMark.Outside;

            // draw the print version of the chart to a bitmap.
            Bitmap bitmap = new Bitmap(bitMapWidth, bitMapHeight);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                flexChart.DrawChart(g, new Size(bitMapWidth, bitMapHeight));
            }

            // restore the axis limits and units
            flexChart.AxisX.Max = maxFlex;
            flexChart.AxisX.Min = minFlex;
            flexChart.AxisY.Max = maxFlexY;
            flexChart.AxisY.Min = minFlexY;
            flexChart.AxisX.MajorUnit = xunit;
            flexChart.AxisX.MinorTickMarks = C1.Chart.TickMark.None;
            flexChart.Refresh();

            int increment = bitMapWidth / pageCount;
            int bitmapLeft = 0;

            // print initialization
            pd.BeginPrint += (pageSender, beginPrintEventArgs) =>
            {
                pageNumber = 0;
                bitmapLeft = 0;
            };

            pd.PrintPage += (pageSender, printPageEventArgs) =>
            {
                pageNumber++;

                Graphics g = printPageEventArgs.Graphics;
                g.DrawImage(bitmap,
                    new Rectangle(pageSets.Margins.Left, pageSets.Margins.Top, increment, bitMapHeight),
                    new Rectangle(bitmapLeft, 0, increment, bitMapHeight),
                    GraphicsUnit.Pixel);

                bitmapLeft += increment;

                bool morepages = pageNumber < 8;
                printPageEventArgs.HasMorePages = morepages;
            };

            pd.EndPrint += (pageSender, endPrintEventArgs) =>
            {
                pageNumber = 0;
                bitmapLeft = 0;
            };

            ChartPrinter.ChartPreviewDialogEx(pd, true);
            pd.Dispose();
        }
    }
}
