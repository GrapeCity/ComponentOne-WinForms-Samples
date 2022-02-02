using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prj_DashboardLayout_RightToLeft
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetNames(typeof(RightToLeft));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1DashboardLayout1.RightToLeft = (RightToLeft)Enum.Parse(typeof(RightToLeft), comboBox1.SelectedIndex.ToString());
        }
    }
}
