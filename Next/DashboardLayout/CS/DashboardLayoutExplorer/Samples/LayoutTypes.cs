using System;
using System.Windows.Forms;
using C1.Win.Layout;

namespace SampleExplorer
{
    public partial class LayoutTypes : UserControl
    {
        public LayoutTypes()
        {
            InitializeComponent();
        }

        private void LayoutTypes_Load(object sender, EventArgs e)
        {
            // select split layout
            c1ComboBox1.SelectedIndex = 2;
        }

        private void c1ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // selected index
            int idx = c1ComboBox1.SelectedIndex;
            // selected value
            string value = c1ComboBox1.Items[idx].Value as string;
            // new layout type
            LayoutType type = (LayoutType)Enum.Parse(typeof(LayoutType), value);
            // change layout type
            c1DashboardLayout1.LayoutType = type;
        }
    }
}
