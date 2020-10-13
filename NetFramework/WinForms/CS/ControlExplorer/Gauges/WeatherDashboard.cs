using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

namespace ControlExplorer.Gauges
{
    public partial class WeatherDashboard : C1DemoForm
    {
        public WeatherDashboard()
        {
            InitializeComponent();
        }

        private void weatherData1_CurrentChanged(object sender, EventArgs e)
        {
            //handle custom binding for Events gauge (sun, rain, thunderstorm, snow)
            string events = (weatherData1.Current as DataRowView)["events"].ToString();
            string[] eventsArray = events.Split('-');
            if (eventsArray.Length == 0)
            {
                eventsGauge.Value = 3;
                eventsGauge.MorePointersValue_0 = 3;
                eventsGauge.MorePointersValue_1 = 3;
            }
            else if (eventsArray.Length == 1)
            {
                eventsGauge.Value = WeatherEventConverter(eventsArray[0]);
                eventsGauge.MorePointersValue_0 = WeatherEventConverter(eventsArray[0]);
                eventsGauge.MorePointersValue_1 = WeatherEventConverter(eventsArray[0]);
            }
            else if (eventsArray.Length == 2)
            {
                eventsGauge.Value = WeatherEventConverter(eventsArray[0]);
                eventsGauge.MorePointersValue_0 = WeatherEventConverter(eventsArray[1]);
                eventsGauge.MorePointersValue_1 = WeatherEventConverter(eventsArray[0]);
            }
            else if (eventsArray.Length == 3)
            {
                eventsGauge.Value = WeatherEventConverter(eventsArray[0]);
                eventsGauge.MorePointersValue_0 = WeatherEventConverter(eventsArray[1]);
                eventsGauge.MorePointersValue_1 = WeatherEventConverter(eventsArray[2]);
            }
        }

        private int WeatherEventConverter(string precip)
        {
            if (precip.ToLower().Equals("snow"))
            {
                return 1;
            }
            else if (precip.ToLower().Equals("fog"))
            {
                return 2;
            }
            else if (precip.ToLower().Equals("rain"))
            {
                return 4;
            }
            else if (precip.ToLower().Equals("thunderstorm"))
            {
                return 5;
            }
            else //sunny!
                return 3;
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            //print preview gauge
            C1PrintPreviewDialog dlg = new C1PrintPreviewDialog();
            dlg.Text = "C1PrintPreview";
            C1PrintDocument doc = new C1PrintDocument();
            doc.StartDoc();
            doc.AllowNonReflowableDocs = true;
            doc.PageLayout.PageSettings.Landscape = true;
            string date = (weatherData1.Current as DataRowView)["year"].ToString();
            doc.RenderBlockText("Weather Statistics on " + date);
            doc.RenderBlockImage(c1Gauge1.GetImage());
            doc.EndDoc();
            dlg.Document = doc;
            dlg.Show(this.ParentForm);
        }
    }
}
