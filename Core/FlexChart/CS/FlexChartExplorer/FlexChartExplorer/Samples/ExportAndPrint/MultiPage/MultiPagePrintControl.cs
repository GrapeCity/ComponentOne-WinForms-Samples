using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BaseExplorer;
using C1.Win.Chart;
using C1.Chart.Printing;

namespace FlexChartExplorer.Samples
{
    public partial class MultiPagePrintControl : UserControl
    {
        private ButtonEx btnMultiChart, btnMultiPage, btnSubCharts, btnStripChart;

        [DefaultValue(null)]
        public FlexChart FlexChart { get; set; }

        [DefaultValue(null)]
        public PageSettings PageSets { get; set; }

        [DefaultValue(null)]
        public PrinterSettings PrinterSets { get; set; }

        public MultiPagePrintControl()
        {
            InitializeComponent();

            btnMultiChart = new ButtonEx("Print Multiple Charts Per Page") { Bounds = new Rectangle(15,19, 236, 28)};
            btnMultiPage = new ButtonEx("Print Multiple Charts on Multiple Pages") { Bounds = new Rectangle(275, 19, 236, 28) };
            btnSubCharts = new ButtonEx("Print Sub Charts With Axis") { Bounds = new Rectangle(15, 66, 236, 28) };
            btnStripChart = new ButtonEx("Print as Strip Chart") { Bounds = new Rectangle(275, 66, 236, 28) };

            btnMultiChart.Click += btnMultiChart_Click;
            btnMultiPage.Click += btnMultiPage_Click;
            btnSubCharts.Click += btnSubCharts_Click;
            btnStripChart.Click += btnStripChart_Click;

            this.Controls.Add(btnMultiChart);
            this.Controls.Add(btnMultiPage);
            this.Controls.Add(btnSubCharts);
            this.Controls.Add(btnStripChart);
        }

        private void InitializePageSettings()
        {
            if (PageSets == null)
                PageSets = new PageSettings { Landscape = true };
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

            pd.DefaultPageSettings = PageSets;

            if (PrinterSets != null)
                pd.PrinterSettings = PrinterSets;

            int pageNumber = 0;

            pd.PrintPage += (pageSender, printPageEventArgs) =>
            {
                // Each chart or page could use a different FlexChart instance, but for simplicity
                // of the sample, a single FlexChart instance is used with minor changes to differentiate them.
                ChartPrinter chartPrinter = new ChartPrinter(FlexChart, true);

                // Save changes to the FlexChart instance so they can be restored later.
                Color originalBackgroundColor = FlexChart.BackColor;
                string title = FlexChart.Header.Content;

                pageNumber++;

                // the chart is drawn within the rectangle assuming coordinates relative
                // to the Top-Left page margin as specifiec in the prinPageEventArgs.
                Rectangle rect = singlePage ? new Rectangle(0, 100, 400, 200) : Rectangle.Empty;

                printPageEventArgs.HasMorePages = pageNumber < 4;       // sanity check to avoid endless loop.

                // Print the chart 4 times with different modified charts.
                if (singlePage || (!singlePage && pageNumber == 1))
                {
                    FlexChart.BackColor = Color.Yellow;
                    FlexChart.Header.Content = "Fit With Yellow Background";
                    chartPrinter.PrinterCtrlToPage(pd, printPageEventArgs, ChartPrinter.PrintScale.Fit, rect, false);
                    drawMarginedRectangle(printPageEventArgs.Graphics, rect, printPageEventArgs.MarginBounds);
                }

                // same chart with GrayScale next to it.
                if (singlePage || (!singlePage && pageNumber == 2))
                {
                    if (singlePage) rect.X += rect.Width + 50;
                    FlexChart.Header.Content = "Fit With Yellow Background in GrayScale";
                    chartPrinter.PrinterCtrlToPage(pd, printPageEventArgs, ChartPrinter.PrintScale.Fit, rect, true);
                    drawMarginedRectangle(printPageEventArgs.Graphics, rect, printPageEventArgs.MarginBounds);
                }

                if (singlePage || (!singlePage && pageNumber == 3))
                {
                    if (singlePage) { rect.X -= rect.Width + 50; rect.Y += rect.Height + 50; }
                    FlexChart.BackColor = Color.Green;
                    FlexChart.Header.Content = "Zoomed With Green Background";
                    chartPrinter.PrinterCtrlToPage(pd, printPageEventArgs, ChartPrinter.PrintScale.Zoom, rect, false);
                    drawMarginedRectangle(printPageEventArgs.Graphics, rect, printPageEventArgs.MarginBounds);
                }


                if (singlePage || (!singlePage && pageNumber == 4))
                {
                    if (singlePage) rect.X += rect.Width + 50;
                    FlexChart.BackColor = Color.MistyRose;
                    FlexChart.Header.Content = "Stretched With Rose Background";
                    chartPrinter.PrinterCtrlToPage(pd, printPageEventArgs, ChartPrinter.PrintScale.Stretch, rect, false);
                    drawMarginedRectangle(printPageEventArgs.Graphics, rect, printPageEventArgs.MarginBounds);
                    printPageEventArgs.HasMorePages = false;
                    pageNumber = 0;     // zero for the next print from preview dialog.
                }

                // restore modified chart setting to original values.
                FlexChart.Header.Content = title;
                FlexChart.BackColor = originalBackgroundColor;
            };

            ChartPrinter.ChartPreviewDialogEx(pd, PrinterSets == null);

            pd.Dispose();
        }

        private void btnSubCharts_Click(object sender, EventArgs e)
        {
            InitializePageSettings();

            PrintDocument pd = new PrintDocument();
            pd.DefaultPageSettings = PageSets;
            pd.PrinterSettings = PrinterSets;

            int pageNumber = 0;

            // determine the limits over which the chart should be printed.
            int pageCount = 8;
            double minXValue = 0;
            double maxXValue = FlexChart.AxisX.ActualMax;

            double increment = (maxXValue - minXValue) / pageCount;

            double minFlex = double.NaN, maxFlex = double.NaN;
            double minFlexY = double.NaN, maxFlexY = double.NaN;

            pd.BeginPrint += (pageSender, beginPrintEventArgs) =>
            {
                // save the current axis limits
                minFlex = FlexChart.AxisX.Min;
                maxFlex = FlexChart.AxisX.Max;
                minFlexY = FlexChart.AxisY.Min;
                maxFlexY = FlexChart.AxisY.Max;

                FlexChart.AxisX.Min = minXValue;
                FlexChart.AxisX.Max = increment;
                FlexChart.AxisY.Min = FlexChart.AxisY.ActualMin;
                FlexChart.AxisY.Max = FlexChart.AxisY.ActualMax;

                pageNumber = 0;
            };


            pd.PrintPage += (pageSender, printPageEventArgs) =>
            {
                // Each chart or page could use a different FlexChart instance, but in this case
                // subsets of a single FlexChart instance is used.
                ChartPrinter chartPrinter = new ChartPrinter(FlexChart, true);
                pageNumber++;

                // The chart is drawn within the rectangle assuming coordinates relative
                // to the Top-Left page margin as specified in the prinPageEventArgs.
                // An empty rectangle indicates a full page rather than a limited
                // rectangle on the page.
                Rectangle rect = new Rectangle(0, 0, 0, 0);

                printPageEventArgs.HasMorePages = pageNumber < 30;       // sanity check to avoid endless loop.
                chartPrinter.PrinterCtrlToPage(pd, printPageEventArgs, ChartPrinter.PrintScale.Fit, rect, false);

                bool morePages = FlexChart.AxisX.Max < maxXValue;
                printPageEventArgs.HasMorePages = morePages;

                if (morePages)
                {
                    // set up for the next page.
                    FlexChart.AxisX.Min += increment;
                    FlexChart.AxisX.Max += increment;
                }
            };

            pd.EndPrint += (pageSender, endPrintEventArgs) =>
            {
                // restore the axis limits
                FlexChart.AxisX.Max = maxFlex;
                FlexChart.AxisX.Min = minFlex;
                FlexChart.AxisY.Max = maxFlexY;
                FlexChart.AxisY.Min = minFlexY;

                // reset for next print from preview dialog.
                pageNumber = 0;
            };

            ChartPrinter.ChartPreviewDialogEx(pd, true);
            pd.Dispose();
        }

        private void btnStripChart_Click(object sender, EventArgs e)
        {
            InitializePageSettings();

            PageSettings pageSets = PageSets;
            PrinterSettings prnSets = PrinterSets;

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
            double minFlex = FlexChart.AxisX.Min;
            double maxFlex = FlexChart.AxisX.Max;
            double minFlexY = FlexChart.AxisY.Min;
            double maxFlexY = FlexChart.AxisY.Max;
            double xunit = FlexChart.AxisX.MajorUnit;

            // set the axis limits and units for bitmap creation
            FlexChart.AxisX.Min = 0;
            FlexChart.AxisX.Max = FlexChart.AxisX.ActualMax;
            FlexChart.AxisY.Min = FlexChart.AxisY.ActualMin;
            FlexChart.AxisY.Max = FlexChart.AxisY.ActualMax;
            FlexChart.AxisX.MajorUnit = 1;
            FlexChart.AxisX.MinorTickMarks = C1.Chart.TickMark.Outside;

            // draw the print version of the chart to a bitmap.
            Bitmap bitmap = new Bitmap(bitMapWidth, bitMapHeight);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                FlexChart.DrawChart(g, new Size(bitMapWidth, bitMapHeight));
            }

            // restore the axis limits and units
            FlexChart.AxisX.Max = maxFlex;
            FlexChart.AxisX.Min = minFlex;
            FlexChart.AxisY.Max = maxFlexY;
            FlexChart.AxisY.Min = minFlexY;
            FlexChart.AxisX.MajorUnit = xunit;
            FlexChart.AxisX.MinorTickMarks = C1.Chart.TickMark.None;
            FlexChart.Refresh();

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
