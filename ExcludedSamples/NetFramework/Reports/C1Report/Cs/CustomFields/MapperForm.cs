using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace C1.C1Report.MapCustomField
{
    public partial class MapperForm : Form
    {
        public MapperForm()
        {
            InitializeComponent();
        }

        // public Mapper Mapper { get { return _mapper; } }

        public System.Drawing.Image GetImage()
        {
            return null;
            /*
            Mapper m = new Mapper();
            return m.GetImage(96, 96);//qqq

            // render InkCanvas' visual tree to the RenderTargetBitmap
            RenderTargetBitmap targetBitmap = new RenderTargetBitmap(
                (int)this._mapper.ActualWidth,
                (int)this._mapper.ActualHeight,
                96d, 96d,
                PixelFormats.Default);
            targetBitmap.Render(this._mapper); //.Map);

            // add the RenderTargetBitmap to a Bitmapencoder
            BmpBitmapEncoder encoder = new BmpBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(targetBitmap));

            // produce a WinForms Image:
            MemoryStream ms = new MemoryStream();
            encoder.Save(ms);
            var winformImage = System.Drawing.Image.FromStream(ms);
            return winformImage;
             */
        }
    }
}
