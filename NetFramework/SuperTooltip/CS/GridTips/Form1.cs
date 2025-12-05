using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GridTips
{
    public partial class Form1 : Form
    {
        // html template for super tooltip
        private string _tip =
            @"<table><tr>
              <td><parm><img src='res://Target.png'></parm>
              <td><b><parm>This is a SuperTooltip</parm></b>
            </table>
            <parm><hr noshade size=1 style='margin:2' color=Darker></parm>
            <div style='margin:1 12'><parm>
              This tooltip is associated with cell (row,col).<br>
            You can show it as a balloon or as a regular<br>
            tooltip.
            </parm></div>
            <parm><hr noshade size=1 style='margin:2' color=Darker></parm>
            <table><tr>
              <td><parm></parm>
              <td><b><parm>enjoy your SuperTooltip today!</parm></b>
            </table>";

        public Form1()
        {
            InitializeComponent();
        }

        // initialize tip properties
        private void Form1_Load(object sender, EventArgs e)
        {
            // no delay for showing, very long time to hide
            c1SuperTooltip1.AutomaticDelay = 0;
            c1SuperTooltip1.AutoPopDelay = int.MaxValue;

            // no delay for showing, very long time to hide
            toolTip1.AutomaticDelay = 0;
            toolTip1.AutoPopDelay = int.MaxValue;
        }

        // change IsBalloon for all tips
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.IsBalloon = this.checkBox1.Checked;
            this.toolTip1.IsBalloon = this.checkBox1.Checked;
        }

        private void _flex_MouseHoverCell(object sender, EventArgs e)
        {
            // update super tooltip
            C1.Win.FlexGrid.C1FlexGrid flex = sender as C1.Win.FlexGrid.C1FlexGrid;
            string tip = _tip.Replace("(row,col)", string.Format("<b>({0},{1})</b>", flex.MouseRow, flex.MouseCol));
            this.c1SuperTooltip1.SetToolTip(flex, tip);
        }

        // update regular tooltip
        private void _flex2_MouseHoverCell(object sender, EventArgs e)
        {
            C1.Win.FlexGrid.C1FlexGrid flex = sender as C1.Win.FlexGrid.C1FlexGrid;
            string tip = string.Format("This is a regular tip on cell ({0},{1})", flex.MouseRow, flex.MouseCol);
            this.toolTip1.SetToolTip(flex, tip);
        }

        // update super tooltip using Show/Hide methods
        private void _flex3_MouseHoverCell(object sender, EventArgs e)
        {
            C1.Win.FlexGrid.C1FlexGrid flex = sender as C1.Win.FlexGrid.C1FlexGrid;
            string tip = _tip.Replace("(row,col)", string.Format("<b>({0},{1})</b>", flex.MouseRow, flex.MouseCol));
            Point pt = flex.PointToClient(Control.MousePosition);
            this.c1SuperTooltip1.Show(tip, flex, pt);
        }
        private void _flex3_MouseLeave(object sender, EventArgs e)
        {
            C1.Win.FlexGrid.C1FlexGrid flex = sender as C1.Win.FlexGrid.C1FlexGrid;
            this.c1SuperTooltip1.Hide(flex);
        }

        // update regular tooltip using Show/Hide methods
        private void _flex4_MouseHoverCell(object sender, EventArgs e)
        {
            C1.Win.FlexGrid.C1FlexGrid flex = sender as C1.Win.FlexGrid.C1FlexGrid;
            string tip = string.Format("This is a regular tip on cell ({0},{1})", flex.MouseRow, flex.MouseCol);
            Point pt = flex.PointToClient(Control.MousePosition);
            this.toolTip1.Show(tip, flex, pt);
        }
        private void _flex4_MouseLeave(object sender, EventArgs e)
        {
            C1.Win.FlexGrid.C1FlexGrid flex = sender as C1.Win.FlexGrid.C1FlexGrid;
            this.toolTip1.Hide(flex);
        }
    }
}