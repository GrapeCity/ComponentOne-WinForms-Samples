using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Schedule;
using C1.C1Schedule;
using System.Drawing.Printing;
using System.IO;
using C1.Win.RibbonPreview;

namespace SchedulerPrinting
{
    public partial class Form1 : Form
    {
        // controls for printing and previewing
        private C1RibbonPreviewDialog printPreviewDialog1 = new C1RibbonPreviewDialog();
        private PrintRangeDialog printRangeDialog1 = new PrintRangeDialog();
        private PrintDocument printDocument1 = new PrintDocument();
        
        private C1Schedule sched = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDayView_Click(object sender, EventArgs e)
        {
            c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.DayView;
        }

        private void btnWeekView_Click(object sender, EventArgs e)
        {
            c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.WeekView;
        }

        private void btnMonthView_Click(object sender, EventArgs e)
        {
            c1Schedule1.ViewType = C1.Win.C1Schedule.ScheduleViewEnum.MonthView;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // create in-memory scheduler control for printing
            sched = new C1Schedule();
            sched.ShowReminderForm = false;
            // copy theme information
            sched.Theme.XmlDefinition = c1Schedule1.Theme.XmlDefinition;
            // copy time scale information
            sched.CalendarInfo.TimeScale = c1Schedule1.CalendarInfo.TimeScale;
            // copy week start
            sched.CalendarInfo.WeekStart = c1Schedule1.CalendarInfo.WeekStart;

            // copy view information
            sched.ViewType = c1Schedule1.ViewType;
            
            // customize theme for better print contrast
            // sched.Theme["DayViewDayName"].Format = "g";
            //sched.Theme["TimeRuler"].ForeColor = Color.Black;
            //sched.Theme["TimeRuler"].BorderColor = Color.Black;
            //sched.Theme["TimeRuler"].BackBrush = new SolidBrush(Color.White);

            // don't highlight day status for better contrast
            sched.Theme.HighlightDayStatus = false;

            // It's possible to change other appearance settings for printing version
            // To do so:
            // - create custom visual style in the smart designer;
            // - edit appearance of this visual style;
            // - save visual style to file;
            // - load saved xml definition into sched.Theme.XmlDefinition property.
            sched.Theme.ShowNavigationPanels = false;

            // hide title
            sched.ShowTitle = false;
            // hide free time

            using (MemoryStream stream = new MemoryStream())
            {
                // copy appointments from the displayed Scheduler
                c1Schedule1.DataStorage.Export(stream, FileFormatEnum.XML);
                stream.Position = 0;
                sched.DataStorage.Import(stream, FileFormatEnum.XML);
            }
            if (c1Schedule1.ViewType == ScheduleViewEnum.TimeLineView)
            {
                sched.Height = 800;
                sched.Width = 1200;
            }
            else
            {
                // set large enough height, so that all day is visible without scrolling
                sched.Height = 1200;
                // use the same width as in displayed scheduler
                sched.Width = c1Schedule1.Width;
            }

            // end C1Schedule initialization
            ((ISupportInitialize)sched).EndInit();

            // set initial date range
            printRangeDialog1.StartDate = c1Schedule1.SelectedDates[0];
            if (c1Schedule1.SelectedDates.Length > 1)
            {
                printRangeDialog1.EndDate = c1Schedule1.SelectedDates[c1Schedule1.SelectedDates.Length - 1];
            }
            else
            {
                printRangeDialog1.EndDate = c1Schedule1.SelectedDates[0];
            }

            // show date range dialog
            if (printRangeDialog1.ShowDialog() == DialogResult.OK)
            {
                // go to desired date

                DateTime[] dates = printRangeDialog1.GetDateRange();
                sched.ShowDates(dates);
                // adjust intervals to don't hurt performance and get correct view for Month view
                sched.CalendarInfo.FirstDate = dates[0];
                sched.CalendarInfo.LastDate = dates[dates.Length - 1];

                // initialize printing
                printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
                printPreviewDialog1.Document = printDocument1;
                printDocument1.DefaultPageSettings.Landscape = c1Schedule1.ViewType == ScheduleViewEnum.TimeLineView;
                // show print preview
                printPreviewDialog1.ShowDialog();
                printDocument1.PrintPage -= new PrintPageEventHandler(printDocument1_PrintPage);
            } 
        }

        // copy C1Schedule as bitmap to the currently printed page
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.PageSettings.Landscape = c1Schedule1.ViewType == ScheduleViewEnum.TimeLineView;
            // copy scheduler to the page
            Graphics graphics = e.Graphics;
            Rectangle bounds = e.MarginBounds;
            Bitmap bitmap = new Bitmap(sched.Width, sched.Height);
            sched.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            Rectangle target = new Rectangle(bounds.X, bounds.Y, bounds.Width, bounds.Height);
            double xScale = (double)bitmap.Width / bounds.Width;
            double yScale = (double)bitmap.Height / bounds.Height;
            if (xScale < yScale)
                target.Width = (int)(xScale * target.Width / yScale);
            else
                target.Height = (int)(yScale * target.Height / xScale);
            graphics.PageUnit = GraphicsUnit.Display;
            graphics.DrawImage(bitmap, target);

            switch (c1Schedule1.ViewType)
            {
                case ScheduleViewEnum.TimeLineView:
                    {
                        // check whether some content is out of visibility, scroll and force printing next page
                        int maxScrollOffset = sched.ScrollSize.Width - sched.ScrollableRectangle.Width;

                        if (sched.ScrollPosition.X > -maxScrollOffset)
                        {
                            e.HasMorePages = true;
                            sched.ScrollPosition = new Point(sched.ScrollPosition.X - sched.ScrollableRectangle.Width, sched.ScrollPosition.Y);
                        }
                    }
                    break;
                case ScheduleViewEnum.MonthView:
                    break;
                default:
                    if (c1Schedule1.ViewType == ScheduleViewEnum.WeekView && c1Schedule1.WeekViewStyle == WeekViewStyleEnum.Office2003)
                    {
                        break;
                    }
                    {
                        int maxScrollOffset = sched.ScrollSize.Height - sched.ScrollableRectangle.Height;

                        if (sched.ScrollPosition.Y > -maxScrollOffset)
                        {
                            e.HasMorePages = true;
                            sched.ScrollPosition = new Point(sched.ScrollPosition.X, sched.ScrollPosition.Y - sched.ScrollableRectangle.Height);
                        }
                    }
                    break;
            }
        }
    }
}
