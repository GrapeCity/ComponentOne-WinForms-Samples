using System;
using System.Windows.Forms;

namespace DataFilterAndDataEngine.UI
{
    public partial class LoadingView : UserControl
    {
        public LoadingView()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            c1RadialGauge1.Value = (c1RadialGauge1.Value + 4) % 104;
        }

        private void LoadingView_Load(object sender, EventArgs e)
        {
            timer1.Enabled = Visible;
            c1RadialGauge1.Value = 0;
        }
    }
}
