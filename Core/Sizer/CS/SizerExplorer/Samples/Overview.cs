using System;
using System.Drawing;
using System.Windows.Forms;

namespace SizerExplorer.Samples
{
    public partial class Overview : UserControl
    {
        private Size _minSizeBlock1;
        private Size _minSizeBlock2;
        private Size _minSizeBlock3;
        private Size _minSizeBlock4;

        public Overview()
        {
            InitializeComponent();
        }

        private void Overview_VisibleChanged(object sender, EventArgs e) => tooltip1.Hide(c1Sizer2);

        private void SizerForm_Load(object sender, EventArgs e)
        {
            _minSizeBlock1 = new Size(125, 200);
            _minSizeBlock2 = new Size(300, 200);
            _minSizeBlock3 = new Size(300, 160);
            _minSizeBlock4 = new Size(150, 160);
        }

        private void c1Sizer2_SplitterMoved(object sender, C1.Win.Sizer.C1SizerEventArgs e)
        {
            if (c1Sizer2.Grid.Columns[0].Size <= _minSizeBlock1.Width)
                c1Sizer2.Grid.Columns[0].Size = _minSizeBlock1.Width;

            if (c1Sizer2.Grid.Columns[1].Size <= _minSizeBlock2.Width)
                c1Sizer2.Grid.Columns[1].Size = _minSizeBlock2.Width;
        }

        private void c1Sizer9_SplitterMoved(object sender, C1.Win.Sizer.C1SizerEventArgs e)
        {
            if (c1Sizer9.Grid.Columns[0].Size <= _minSizeBlock3.Width)
                c1Sizer9.Grid.Columns[0].Size = _minSizeBlock3.Width;

            if (c1Sizer9.Grid.Columns[1].Size <= _minSizeBlock4.Width)
                c1Sizer9.Grid.Columns[1].Size = _minSizeBlock4.Width;            
        }

        private void c1Sizer1_SplitterMoved(object sender, C1.Win.Sizer.C1SizerEventArgs e)
        {
            if (c1Sizer1.Grid.Rows[0].Size <= _minSizeBlock1.Height)
                c1Sizer1.Grid.Rows[0].Size = _minSizeBlock1.Height;

            if (c1Sizer1.Grid.Rows[1].Size <= _minSizeBlock4.Height)
                c1Sizer1.Grid.Rows[1].Size = _minSizeBlock4.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tooltip1.Show("Drag the splitters to see C1Sizer in action!", c1Sizer2, new Point(c1Sizer2.Grid.Columns[1].Bounds.Left - 2, c1Sizer2.Grid.Rows[0].Size / 2), 6000);
            timer1.Enabled = false;
        }
    }
}