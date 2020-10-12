using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var form = new LayoutDemo.Form1())
                form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var form = new JpnEraDateEdit._2013.Form1())
                form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var form = new RangeSliders.Form1())
                form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (var form = new GaugeDemo.Form1())
                form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var form = new SeparateControls.Form1())
                form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (var form = new DragAndDrop.Form1())
                form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using (var form = new CVForm.CVForm())
                form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            using (var form = new TestBarCode.Form1())
                form.ShowDialog();
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            using (var form = new Subtotals.Form1())
                form.ShowDialog();
        }
    }
}
