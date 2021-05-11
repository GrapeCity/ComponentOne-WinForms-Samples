using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Drawing;
using C1.C1Preview;
using C1.C1Report;

namespace WpfChartInReport
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            C1PrintDocument c1doc = new C1PrintDocument();
            c1doc.Body.Children.Add(new RenderText("Here is a C1.WPF.C1Chart.C1Chart:"));

            // get image from chart using method described here:
            // http://blogs.msdn.com/jaimer/archive/2009/07/03/rendertargetbitmap-tips.aspx
            Rect bounds = VisualTreeHelper.GetDescendantBounds(c1Chart1);
            // desired resolution:
            double dpiX = 300, dpiY = 300;
            RenderTargetBitmap rtb = new RenderTargetBitmap(
                (int)(bounds.Width * dpiX / 96.0), (int)(bounds.Height * dpiY / 96.0), dpiX, dpiY, PixelFormats.Pbgra32);
            DrawingVisual dv = new DrawingVisual();
            using (DrawingContext ctx = dv.RenderOpen())
            {
                VisualBrush vb = new VisualBrush(c1Chart1);
                ctx.DrawRectangle(vb, null, new Rect(new System.Windows.Point(), bounds.Size));
            }
            rtb.Render(dv);

            // make PNG with chart:
            PngBitmapEncoder enc = new PngBitmapEncoder();
            enc.Frames.Add(BitmapFrame.Create(rtb));

            // create RenderImage with System.Drawing.Image from the PNG
            // (must keep the stream for the image lifetime):
            MemoryStream ms = new MemoryStream();
            enc.Save(ms);
            ms.Seek(0, SeekOrigin.Begin);
            RenderImage riChart = new RenderImage(System.Drawing.Image.FromStream(ms));
            c1doc.Body.Children.Add(riChart);

            // show window with C1PrintDocument in document viewer:
            DocumentViewer w2 = new DocumentViewer();
            w2.c1DocumentViewer1.Document = c1doc.FixedDocumentSequence;
            w2.Show();
        }
    }
}
