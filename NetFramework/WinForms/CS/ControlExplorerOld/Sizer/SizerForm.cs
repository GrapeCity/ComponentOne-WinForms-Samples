using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Sizer
{
    public partial class SizerForm : C1DemoForm
    {
        Size minSizeBlock1;
        Size minSizeBlock2;
        Size minSizeBlock3;
        Size minSizeBlock4;

        public SizerForm()
        {
            InitializeComponent();
        }

        private void SizerForm_Load(object sender, EventArgs e)
        {
            minSizeBlock1 = new Size(125, 200);
            minSizeBlock2 = new Size(300, 200);
            minSizeBlock3 = new Size(300, 160);
            minSizeBlock4 = new Size(150, 160);
        }

        private void c1Sizer2_SplitterMoved(object sender, C1.Win.C1Sizer.C1SizerEventArgs e)
        {
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            c1SuperTooltip1.Show("Drag the splitters to see C1Sizer in action!", c1Sizer2, new Point(c1Sizer2.Grid.Columns[1].Bounds.Left - 2, c1Sizer2.Grid.Rows[0].Size / 2), 6000);
            timer1.Enabled = false;
        }
        
    }
}
