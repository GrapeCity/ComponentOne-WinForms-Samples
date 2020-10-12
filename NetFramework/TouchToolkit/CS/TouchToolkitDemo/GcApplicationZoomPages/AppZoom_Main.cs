using C1.Win.TouchToolKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickOnceDemo.C1ApplicationZoomPages
{
    public partial class AppZoom_Main : Form
    {
        public AppZoom_Main()
        {
            InitializeComponent();
            PopulateDateGridView();
            dataGridView1.RowCount = 10;
        }
        
        private void PopulateDateGridView()
        {
            string[] row0 = { "2012/12/12", "1128", "ABC商事", "支払勘定", "23.27", "", "36,020.30" };
            string[] row1 = { "2012/12/13", "1129", "グレープ株式会社", "支払勘定", "182.30", "", "35,837.30" };
            string[] row2 = { "2012/12/14", "1123", "グレープシードオフィス", "支払勘定", "240.00", "", "32,433.30" };
            string[] row3 = { "2012/12/15", "1130", "DD株式会社", "支払勘定", "240.00", "", "39,426.30" };
            string[] row4 = { "2012/12/22", "1131", "ブドウ貿易", "支払勘定", "1,275.00", "", "39,222.30" };
            string[] row5 = { "2012/12/25", "1209", "パワーツール", "支払勘定", "1,275.00", "", "38,134.30" };
            string[] row6 = { "2012/12/25", "1212", "オレンジ商事", "支払勘定", "1,275.00", "", "36,433.30" };
            string[] row7 = { "2012/12/26", "1204", "レイザーコンサルタント", "支払勘定", "375.00", "", "36,020.30" };
            string[] row8 = { "2012/12/26", "1215", "グレープ株式会社", "支払勘定", "2,835.00", "", "36,433.30" };
            string[] row9 = { "2012/12/27", "1218", "ITC株式会社", "支払勘定", "2,835.00", "", "33,479.30" };
            string[] row10 = { "2012/12/29", "1221", "ワイン事務所", "支払勘定", "23.27", "", "32,011.30" };


            {
                DataGridViewRowCollection rows = this.dataGridView1.Rows;
                rows.Add(row0);
                rows.Add(row1);
                rows.Add(row2);
                rows.Add(row3);
                rows.Add(row4);
                rows.Add(row5);
                rows.Add(row6);
                rows.Add(row7);
                rows.Add(row8);
                rows.Add(row9);
                rows.Add(row0);
            }
        }

        private void myImageButton_Click(object sender, EventArgs e)
        {
            Form form = null;
            if (sender == this.myImageButton1)
            {
                form = new AppZoom_Child1();
            }
            else if (sender == this.myImageButton2)
            {
                form = new AppZoom_Child2();
            }
            else if (sender == this.myImageButton6)
            {
                form = new AppZoom_Child3();
            }
            else
            {
                MessageBox.Show("Show other forms.");
            }
            if (form != null)
            {
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
        }

    }

    public class MyImageButtonZoomPolicy : ZoomPolicy
    {
        public override Type TargetType
        {
            get { return typeof(MyImageButton); }
        }

        public override void ZoomBounds(Control control, ZoomBoundsInfo infos)
        {
            MyImageButton imageBUtton = control as MyImageButton;
            imageBUtton.ImageFactor = infos.TargetFactor;
            base.ZoomBounds(control, infos);
        }
    }

                    

    public class MyImageButton : Button
    {
        public MyImageButton()
        {
            this.TextAlign = ContentAlignment.BottomCenter;
            this.ImageFactor = 1;
        }

        private const int ImagePadding = 4;

        public Bitmap RenderImage { get; set; }

        public float ImageFactor { get; set; }
        
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            if (RenderImage != null)
            {
                int width = (int)Math.Round(RenderImage.Width * ImageFactor);
                int height = (int)Math.Round(RenderImage.Height * ImageFactor);
                int x = (this.ClientSize.Width - width) / 2;
                int y = (int)Math.Round(ImagePadding * ImageFactor);
                pevent.Graphics.DrawImage(RenderImage, new Rectangle(x, y, width, height));
            }
        }
    }
}
