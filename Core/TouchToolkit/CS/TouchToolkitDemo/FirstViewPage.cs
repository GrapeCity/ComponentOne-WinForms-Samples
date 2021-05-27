using System;
using System.Windows.Forms;

namespace TouchToolkitDemo
{
    public partial class FirstViewPage : UserControl
    {
        public FirstViewPage()
        {
            InitializeComponent();
            Load += FirstViewPage_Load;
        }

        private void FirstViewPage_Load(object sender, EventArgs e)
        {
            mainvisual.Controls.Add(product2);
            mainvisual.Controls.Add(product3);
        }
    }
}
