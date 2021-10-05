using Leadtools;
using Leadtools.Codecs;
using Leadtools.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceDemo.GcZoomPages
{
    public static class LeadToolsCreater
    {
        public static Control CreateControl(string zoomPolicy, Font font, Size layoutSize)
        {
            switch (zoomPolicy)
            {
                case "RasterImageListZoomPolicy":
                    RasterImageList imageList1 = new RasterImageList();
                    imageList1.Dock = DockStyle.Fill;
                    using (RasterCodecs codecs = new RasterCodecs())
                    {
                        MemoryStream stream1 = new MemoryStream();
                        Properties.Resources.Accnt.Save(stream1, ImageFormat.Png);
                        stream1.Position = 0;
                        RasterImage image1 = codecs.Load(stream1);
                        stream1.Close();

                        stream1 = new MemoryStream();
                        Properties.Resources.Bill.Save(stream1, ImageFormat.Png);
                        stream1.Position = 0;
                        RasterImage image2 = codecs.Load(stream1);
                        stream1.Close();

                        stream1 = new MemoryStream();
                        Properties.Resources.Check.Save(stream1, ImageFormat.Png);
                        stream1.Position = 0;
                        RasterImage image3 = codecs.Load(stream1);
                        stream1.Close();

                        stream1 = new MemoryStream();
                        Properties.Resources.Cust.Save(stream1, ImageFormat.Png);
                        stream1.Position = 0;
                        RasterImage image4 = codecs.Load(stream1);
                        stream1.Close();
                        imageList1.Items.Add(new RasterImageListItem(image1, 1, "aaa"));
                        imageList1.Items.Add(new RasterImageListItem(image2, 1, "bbb"));
                        imageList1.Items.Add(new RasterImageListItem(image3, 1, "ccc"));
                        imageList1.Items.Add(new RasterImageListItem(image4, 1, "ddd"));
                    }
                    return imageList1;
                case "RasterImageViewerZoomPolicy":
                    RasterImageViewer imageViewer1 = new RasterImageViewer();
                    imageViewer1.Dock = DockStyle.Fill;
                    using (RasterCodecs codecs = new RasterCodecs())
                    {
                        MemoryStream stream1 = new MemoryStream();
                        Properties.Resources.Forest.Save(stream1, ImageFormat.Png);
                        stream1.Position = 0;
                        RasterImage image1 = codecs.Load(stream1);
                        stream1.Close();
                        imageViewer1.Image = image1;
                    }
                    return imageViewer1;
                default:
                    break;
            }
            return null;
        }


        internal static string[] LeadToolsPolicies = new string[] 
        {
            "RasterImageListZoomPolicy",
            "RasterImageViewerZoomPolicy"
        };


        internal static string GetDescription(string zoomPolicy)
        {
            if (zoomPolicy == "RasterImageListZoomPolicy")
            {
                return Properties.Resources.ZoomPolicy_LT_RasterImageList;
            }
            else if (zoomPolicy == "RasterImageViewerZoomPolicy")
            {
                return Properties.Resources.ZoomPolicy_LT_RasterImageViewer;
            }
            return "";
        }
    }
}
