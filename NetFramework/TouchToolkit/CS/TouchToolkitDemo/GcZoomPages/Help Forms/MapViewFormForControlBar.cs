using C1.Win.TouchToolKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClickOnceDemo.C1ZoomPages.Help_Forms
{
    public partial class MapViewFormForControlBar : Form
    {
        int sliceCount = 4; 

        public MapViewFormForControlBar()
        {
            InitializeComponent();

            System.Threading.Thread thread = new System.Threading.Thread(ShowSplashForm);
            
            thread.Start();

            Bitmap b = Properties.Resources.world;

            int width = this.Width;
            int height = this.Height;

            int sourceWidth = b.Width / sliceCount;
            int sourceHeight = b.Height / sliceCount;

            for (int column = 0; column < sliceCount; column++)
            {
                for (int row = 0; row < sliceCount; row++)
                {
                    C1MultiScaleImage image = new C1MultiScaleImage();

                    int targetWidth = width / sliceCount + 1;
                    int targetHeight = height / sliceCount + 1;

                    image.Size = new Size(targetWidth, targetHeight);

                    image.Location = new Point(row * width / sliceCount, column * height / sliceCount);

                    Rectangle sourceRect = new Rectangle(row * sourceWidth, column * sourceHeight, sourceWidth, sourceHeight);

                    var image4 = GetImagePart(image.Size, b, sourceRect, 4);
                    image.Images.Add(new ImageItem(image4, 4f));
                    var image2 = GetImagePart(image.Size, image4, new Rectangle(0,0,image4.Width,image4.Height), 2);
                    image.Images.Add(new ImageItem(image2, 2f));
                    image.Image = GetImagePart(image.Size, image2, new Rectangle(0, 0, image2.Width, image2.Height), 1);

                    this.Controls.Add(image);
                }
            }

            b.Dispose();

            CloseSplashForm();
            thread.Abort();
        }

        SplashForm form;

        void CloseSplashForm()
        {
            if (form.InvokeRequired)
            {
                form.Invoke(new Action(CloseSplashForm));
            }
            else
            {
                form.Close();
            }
        }

        void ShowSplashForm()
        {
            form = new SplashForm();
            form.ShowDialog();
        }

        private Image GetImagePart(Size targetSize , Image imageFrom, Rectangle boundsFrom, int currentFactor)
        {
            Bitmap bitmap = new Bitmap(targetSize.Width * currentFactor, targetSize.Height * currentFactor);

            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.DrawImage(imageFrom, new Rectangle(Point.Empty, bitmap.Size), boundsFrom, GraphicsUnit.Pixel);
            }

            return bitmap;
        }
    }
}
