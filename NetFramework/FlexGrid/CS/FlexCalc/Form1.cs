using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace FlexCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            // populate the grid with some formulas (multiplication table)
            for (int r = 1; r < _flex.Rows.Count - 2; r++)
            {
                for (int c = 1; c < _flex.Cols.Count; c++)
                {
                    _flex[r, c] = string.Format("={0}*{1}", r, c);
                }
            }

            // add a bold total row
            var row = _flex.Rows.Count - 1;
            for (int c = 1; c < _flex.Cols.Count; c++)
            {
                _flex[row, c] = string.Format("=sum({0}1:{0}{1})",
                    (char)(c - 1 + 'A'),
                    row - 1);
            }
            _flex.Rows[row].StyleNew.Font = new Font(_flex.Font, FontStyle.Bold);

            // monitor text formula and synchronize the grid
            _txtFormula.Validating += _txtFormula_Validating;
            _txtFormula.KeyPress += _txtFormula_KeyPress;
            _txtFormula.GotFocus += _txtFormula_GotFocus;

            // show content for top cell
            _flex_SelChange(_flex, EventArgs.Empty);

            // show list of available functions
            _lblFx.MouseDown += _lblFx_MouseDown;
        }

        // show menu with available functions
        void _lblFx_MouseDown(object sender, MouseEventArgs e)
        {
            var menu = new FunctionMenu();
            menu.ItemClicked += (ss, ee) =>
            {
                var fn = ee.ClickedItem.Text;
                _txtFormula.SelectedText = fn;
            };
            menu.Show(Control.MousePosition);
        }

        // show current address and cell content when selection changes
        void _flex_SelChange(object sender, EventArgs e)
        {
            // show cell content above grid
            string address = null;
            string text = null;
            string status = "Ready";
            int row = _flex.Row;
            int col = _flex.Col;
            if (row > -1 && col > -1)
            {
                text = _flex[row, col] as string;
                address = _flex.GetAddress(row, col);
                if (!_flex.Selection.IsSingleCell)
                {
                    try
                    {
                        var sel = _flex.GetAddress(_flex.Selection);
                        var avg = _flex.Evaluate(string.Format("Average({0})", sel));
                        var count = _flex.Evaluate(string.Format("Count({0})", sel));
                        var sum = _flex.Evaluate(string.Format("Sum({0})", sel));
                        if ((double)count > 0)
                        {
                            status = string.Format("Average: {0:#,##0.##} Count: {1:n0} Sum: {2:#,##0.##}",
                                avg, count, sum);
                        }
                    }
                    catch
                    {
                        // the selection must contain errors...
                    }
                }
            }
            _lblAddress.Text = address;
            _txtFormula.Text = text;
            _lblStatus.Text = status;
        }

        // update grid when user types into content textbox
        void _txtFormula_Validating(object sender, CancelEventArgs e)
        {
            if (_flex.Row > -1 && _flex.Col > -1)
            {
                _flex[_flex.Row, _flex.Col] = _txtFormula.Text;
            }
        }
        void _txtFormula_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch ((int)e.KeyChar)
            {
                case 13: // enter
                    e.Handled = true;
                    _flex.Focus();
                    break;
                case 27: // escape
                    e.Handled = true;
                    _flex_SelChange(sender, e);
                    break;
            }
        }
        void _txtFormula_GotFocus(object sender, EventArgs e)
        {
            _txtFormula.SelectAll();
        }
    }
}
