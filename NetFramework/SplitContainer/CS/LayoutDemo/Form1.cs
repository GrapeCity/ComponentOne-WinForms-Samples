using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace LayoutDemo
{
    using C1.Win.C1SplitContainer;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void c1SplitterPanel6_DrawHeader(object sender, DrawHeaderEventArgs e)
        {
            LinearGradientBrush lgb = new LinearGradientBrush(e.Bounds, Color.MistyRose, Color.SteelBlue, 90f);   
            e.Graphics.FillRectangle(lgb, e.Bounds);
            lgb.Dispose();
        }

        private void c1SplitterPanel6_DrawSplitter(object sender, DrawSplitterEventArgs e)
        {
            Point pt1 = e.Bounds.Location;
            pt1.Y += e.Bounds.Height / 2;
            Point pt2 = pt1;
            pt2.X += e.Bounds.Width;
            pt1.X += 10;
            pt2.X -= 5;
            Pen pen = new Pen(Color.White);
            pen.Width = 2f;
            pen.DashPattern = new float[] { 1.0f, 2.0f, 1.0f, 2.0f };
            e.Graphics.DrawLine(pen, pt1, pt2);
            pen.Dispose();
        }
    }
}
