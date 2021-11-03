using System;
using System.Drawing;
using System.Windows.Forms;

namespace DrillDown.Samples
{
    public partial class BaseSample : UserControl
    {
        public BaseSample()
        {
            InitializeComponent();
        }

        private void pControls_Paint(object sender, PaintEventArgs e)
        {
            pControls.CreateGraphics().DrawLine(new Pen(Color.LightGray), 0, pControls.Height - 1, pControls.Width, pControls.Height - 1);
        }

        private void pCollapse_Paint(object sender, PaintEventArgs e)
        {
            using (var gr = pCollapse.CreateGraphics())
            {
                gr.FillRectangle(new SolidBrush(Color.White), 0, 0, pCollapse.Width, pCollapse.Height / 2);
                gr.DrawLine(new Pen(Color.LightGray), 0, pCollapse.Height / 2, pCollapse.Width, pCollapse.Height / 2);
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            pDescription.Visible = !pDescription.Visible;
            btnCollapse.BackgroundImage = pDescription.Visible ?
                DrillDown.Properties.Resources.cb_up26 :
                DrillDown.Properties.Resources.cb_down26;
        }

        private void pDescription_Paint(object sender, PaintEventArgs e)
        {
            pDescription.CreateGraphics().DrawLine(new Pen(Color.LightGray), 0, 13, pDescription.Width, 13);
        }

        private void BaseSample_SizeChanged(object sender, EventArgs e)
        {
            tbDescription.Height = (int)tbDescription.CreateGraphics().MeasureString(tbDescription.Text,
                tbDescription.Font, tbDescription.Width).Height;
        }
    }
}
