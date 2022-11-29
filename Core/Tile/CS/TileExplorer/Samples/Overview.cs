using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileExplorer.Samples
{
    public partial class Overview : UserControl
    {
        public Overview()
        {
            InitializeComponent();

            var message = "Connect succesfull";
            var table = TileExplorer.Data.DataSource.GetRows("SELECT name FROM sqlite_master WHERE type='table'");
            if (table is null)
                message = "Connect don't succesfull";

            var label = new Label();
            label.Dock = DockStyle.Fill;
            label.Text = message;
            label.TextAlign = ContentAlignment.MiddleCenter;

            this.Controls.Add(label);
        }
    }
}
