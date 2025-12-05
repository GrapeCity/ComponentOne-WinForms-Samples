using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using C1.Win.FlexGrid;

namespace AnimatedGif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // list of AnimatedGifs in the application
        // (used to update the current frames on a timer)
        List<AnimatedGif> _gifs = new List<AnimatedGif>();

        // list of cells that contain animated gifs
        // (used to invalidate the cells when animating)
        List<CellRange> _gifRanges = new List<CellRange>();

        private void Form1_Load(object sender, EventArgs e)
        {
            // load all animated gifs from resources
            int row = 1;
            int col = 1;
            Assembly a = Assembly.GetExecutingAssembly();
            foreach (string s in a.GetManifestResourceNames())
            {
                if (s.EndsWith(".gif"))
                {
                    try
                    {
                        // load gif, add to list
                        Image img = Image.FromStream(a.GetManifestResourceStream(s));
                        AnimatedGif gif = new AnimatedGif(img);
                        _gifs.Add(gif);

                        // show gif in grid cell
                        c1FlexGrid1[row, col] = s;
                        c1FlexGrid1.SetCellImage(row, col + 1, gif.Image);

                        // update row/col indices
                        if (col == 1)
                        {
                            col = 3;
                        }
                        else
                        {
                            col = 1;
                            row++;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("failed to load {0}", s);
                    }
                }
            }

            // initialize grid
            c1FlexGrid1.AutoSizeCols();
            c1FlexGrid1.AutoSizeRows();
            c1FlexGrid1.Styles.Normal.ImageAlign = ImageAlignEnum.CenterCenter;

            // build list of cells that contain gifs, enable timer
            BuildRangeList();
            timer1.Interval = 100;
            timer1.Enabled = true;
        }

        private void c1FlexGrid1_AfterDragColumn(object sender, DragRowColEventArgs e)
        {
            BuildRangeList();
        }

        // build a list of all ranges that contain animated gifs
        private void BuildRangeList()
        {
            _gifRanges.Clear();
            for (int r = 0; r < this.c1FlexGrid1.Rows.Count; r++)
            {
                for (int c = 0; c < this.c1FlexGrid1.Cols.Count; c++)
                {
                    Image img = this.c1FlexGrid1.GetCellImage(r, c);
                    if (img != null)
                    {
                        AnimatedGif gif = new AnimatedGif(img);
                        if (gif.IsAnimated)
                        {
                            _gifRanges.Add(this.c1FlexGrid1.GetCellRange(r, c));
                        }
                    }
                }
            }
        }

        // animate when the timer ticks
        private void timer1_Tick(object sender, EventArgs e)
        {
            // increment current frame on all gifs
            foreach (AnimatedGif gif in _gifs)
            {
                gif.NextFrame();
            }

            // invalidate grid cells to show changes
            foreach (CellRange rg in _gifRanges)
            {
                c1FlexGrid1.Invalidate(rg);
            }
        }

        // change animation speed by adjusting timer interval
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = Math.Max(timer1.Interval - 10, 1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Interval = Math.Min(timer1.Interval + 10, 500);
        }
    }

    /// <summary>
    /// Class that contains an animated gif image.
    /// </summary>
    public class AnimatedGif
    {
        // fields
        Image _img;
        FrameDimension _dim;
        int _frameCount;
        int _frameIndex;

        // ctor
        public AnimatedGif(Image img)
        {
            _img = img;
            if (img != null)
            {
                _dim = new FrameDimension(img.FrameDimensionsList[0]);
                _frameCount = img.GetFrameCount(_dim);
            }
        }

        // expose contained image
        public Image Image
        {
            get { return _img; }
        }

        // determines whether image is animated
        public bool IsAnimated
        {
            get { return _frameCount > 1; }
        }

        // move to next frame
        public void NextFrame()
        {
            if (_frameCount > 1)
            {
                _frameIndex = (_frameIndex + 1) % _frameCount;
                _img.SelectActiveFrame(_dim, _frameIndex);
            }
        }
    }
}