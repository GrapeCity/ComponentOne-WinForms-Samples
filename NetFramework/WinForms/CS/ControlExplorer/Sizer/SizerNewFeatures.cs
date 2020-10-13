using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Sizer;

namespace ControlExplorer.Sizer
{
    public partial class SizerNewFeatures : C1DemoForm
    {
        Size minSizeBlock1;
        Size minSizeBlock2;
        Size minSizeBlock3;
        Size minSizeBlock4;

        public SizerNewFeatures()
        {
            InitializeComponent();
        }

        private void c1Sizer_MouseEnter(object sender, EventArgs e)
        {
            C1Sizer sizer = sender as C1Sizer;
            sizer.BackColor = Color.Gold;  
        }

        private void c1Sizer_MouseLeave(object sender, EventArgs e)
        {
            C1Sizer sizer = sender as C1Sizer;
            sizer.BackColor = Color.Silver;
        }

        double _angle = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            _angle += 0.08;
            this.c1Sizer4.Gradient.Center = new Point(
                (int)(50 + 80 * Math.Cos(_angle)),
                (int)(50 + 80 * Math.Sin(_angle)));
      
        }

        private void SizerNewFeatures_Load(object sender, EventArgs e)
        {
            minSizeBlock1 = new Size(125, 200);
            minSizeBlock2 = new Size(300, 200);
            minSizeBlock3 = new Size(300, 160);
            minSizeBlock4 = new Size(150, 160);
        }

        private void c1Sizer2_SplitterMoved(object sender, C1.Win.C1Sizer.C1SizerEventArgs e)
        {
            //c1SuperTooltip1.Show("Notice components in this Sizer panel got resized", button2);
            if (c1Sizer2.Grid.Columns[0].Size <= minSizeBlock1.Width)
            {
                c1Sizer2.Grid.Columns[0].Size = minSizeBlock1.Width;
            }

            if (c1Sizer2.Grid.Columns[1].Size <= minSizeBlock2.Width)
            {
                c1Sizer2.Grid.Columns[1].Size = minSizeBlock2.Width;
            }

        }

        private void c1Sizer9_SplitterMoved(object sender, C1.Win.C1Sizer.C1SizerEventArgs e)
        {
            if (c1Sizer9.Grid.Columns[0].Size <= minSizeBlock3.Width)
            {
                c1Sizer9.Grid.Columns[0].Size = minSizeBlock3.Width;
            }

            if (c1Sizer9.Grid.Columns[1].Size <= minSizeBlock4.Width)
            {
                c1Sizer9.Grid.Columns[1].Size = minSizeBlock4.Width;
            }

        }

        private void c1Sizer1_SplitterMoved(object sender, C1.Win.C1Sizer.C1SizerEventArgs e)
        {
            if (c1Sizer1.Grid.Rows[0].Size <= minSizeBlock1.Height)
            {
                c1Sizer1.Grid.Rows[0].Size = minSizeBlock1.Height;
            }

            if (c1Sizer1.Grid.Rows[1].Size <= minSizeBlock4.Height)
            {
                c1Sizer1.Grid.Rows[1].Size = minSizeBlock4.Height;
            }
        }



    }
}

