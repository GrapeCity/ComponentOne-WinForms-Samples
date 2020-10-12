using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GridSuperToolTip
{
    public partial class Form1 : Form
    {
        // html template for super tooltip
        private string _tip =
            @"<table><tr>
              <td><parm><img src='res://LITENING.ICO'></parm>
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

        // place to stash row and column info
        private Point _rowcol = Point.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.c1SuperTooltip1.IsBalloon = this.checkBox1.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // we'll use the grid's celltip eventing to control supertooltip visibility
            this.c1TrueDBGrid1.CellTips = C1.Win.C1TrueDBGrid.CellTipEnum.Anchored;

            // no delay for showing, very long time to hide
            c1SuperTooltip1.AutomaticDelay = 0;
            c1SuperTooltip1.AutoPopDelay = int.MaxValue;
            // make an empty grid
            FillGrid(this.c1TrueDBGrid1);
        }
        #region populate grid
        private void FillGrid(C1.Win.C1TrueDBGrid.C1TrueDBGrid grid)
        {
            for(int i=0; i < 10; i++)
            {
                grid.Columns.Add(new C1.Win.C1TrueDBGrid.C1DataColumn("",typeof(string)));
            }

            grid.SetDataBinding();
            grid.AddRows(30);
        }
        #endregion

        #region mouse handlers

       #endregion

        private void c1TrueDBGrid1_MouseMove(object sender, MouseEventArgs e)
        {
            C1.Win.C1TrueDBGrid.C1TrueDBGrid tdbgrid = sender as C1.Win.C1TrueDBGrid.C1TrueDBGrid;

            // get the row and column index where the mouse is positioned
            Point p = tdbgrid.PointToClient(Control.MousePosition);
            Point curRowCol = new Point(tdbgrid.ColContaining(p.X), tdbgrid.RowContaining(p.Y));

            // if we've moved to another row/column then hide the supertooltip
            if (!this._rowcol.Equals(curRowCol)) this.c1SuperTooltip1.Hide(tdbgrid);
        }

        private void c1TrueDBGrid1_FetchCellTips(object sender, C1.Win.C1TrueDBGrid.FetchCellTipsEventArgs e)
        {
            // setting e.CellTip to an empty string disables the built-in celltip
            e.CellTip = string.Empty;

            // now use supertooltip
            C1.Win.C1TrueDBGrid.C1TrueDBGrid tdbgrid = sender as C1.Win.C1TrueDBGrid.C1TrueDBGrid;

            // save the current row and column index, we'll use this in MouseMove
            this._rowcol = new Point(e.ColIndex, e.Row);
            string tip = _tip.Replace("(row,col)", string.Format("<b>({0},{1})</b>",e.Row, e.ColIndex));
            this.c1SuperTooltip1.SetToolTip(tdbgrid, tip);
        }
    }
}