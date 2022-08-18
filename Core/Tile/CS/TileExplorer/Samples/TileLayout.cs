using System;
using System.Windows.Forms;

namespace TileExplorer.Samples
{
    public partial class TileLayout : UserControl
    {
        bool _tile4Flipped;

        public TileLayout()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool a = _tile4Flipped;
            tile4.Template = a ? template41 : template42;
            _tile4Flipped = !a;
        }
    }
}
