using DataDynamics.ActiveReports.Document;
using DataDynamics.ActiveReports.Viewer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ClickOnceDemo.GcZoomPages
{
    public static class ActiveReportsCreater
    {
        public static Control CreateControl(string zoomPolicy, Font font, Size layoutSize)
        {
            if (zoomPolicy == "ActiveReportsZoomPolicy")
            {
                Viewer viever = new Viewer();
                viever.Dock = DockStyle.Fill;
                Document doc = new Document();
                MemoryStream stream = new MemoryStream(Properties.Resources.Seikyu2);
                stream.Position = 0;
                doc.Load(stream);
                stream.Close();
                viever.Document = doc;
                return viever;
            }
            return null;
        }


        internal static string[] ActiveReportsPolicies = new string[] 
        {
            "ActiveReportsZoomPolicy",
        };


        internal static string GetDescription(string zoomPolicy)
        {
            return Properties.Resources.ZoomPolicy_AR_ActiveReports;
        }
    }
}
