using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShowTooltips
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.SetToolTip(openToolStripButton, "this is the <b>openToolStripButton</b>");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.UseFading = checkBox1.Checked;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.IsBalloon = checkBox2.Checked;
        }

        #region ** show for 1 second

        private void button2_Click(object sender, EventArgs e)
        {
            this.toolTip1.Show("standard Tooltip on button1\r\nfor 1 second.", this.button1, 1000);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.Show("<b>super</b> Tooltip on button1<br>for 1 second.", this.button1, 1000);
        }
        private void button10_Click(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.Show("<b>super</b> Tooltip on <b>openToolStripItem</b><br>for 1 second.", openToolStripButton, 1000);
        }
        #endregion

        #region ** show for 1 second with offset

        private void button8_Click(object sender, EventArgs e)
        {
            this.toolTip1.Show("standard Tooltip on button1\r\nfor 1 second, offset.", this.button1, 50, 50, 1000);
        }
        private void button9_Click(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.Show("<b>super</b> Tooltip on button1<br>for 1 second, offset.", this.button1, 50, 50, 1000);
        }
        private void button11_Click(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.Show("<b>super</b> Tooltip on <b>openToolStripItem</b><br>for 1 second, offset.", this.openToolStripButton, 50, 50, 1000);
        }

        #endregion

        #region ** show (no timer)

        private void button4_Click(object sender, EventArgs e)
        {
            this.toolTip1.Show("standard Tooltip on button1, no time.", this.button1);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.Show("<b>super</b> Tooltip on button1, no time.", this.button1);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.Show("<b>super</b> Tooltip on <b>openToolStripItem</b>,<br>no time.", this.openToolStripButton);
        }

        #endregion

        #region ** hide

        private void button6_Click(object sender, EventArgs e)
        {
            this.toolTip1.Hide(button1);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.Hide(button1);
        }
        private void button13_Click(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.Hide(openToolStripButton);
        }

        #endregion
    }
}