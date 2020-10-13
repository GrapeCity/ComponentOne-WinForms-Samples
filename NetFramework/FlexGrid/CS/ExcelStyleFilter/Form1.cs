using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ExcelStyleFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ContextMenuStrip _menu;

        private void Form1_Load(object sender, EventArgs e)
        {
            // create menu strip
            _menu = new ContextMenuStrip();
            foreach (string s in "Sort Ascending|Sort Descending|-|(All)|(Top 10)|(Non Blanks)|(Custom...)".Split('|'))
            {
                _menu.Items.Add(s, null, new EventHandler(_menuItemClick));
            }

            // create style with button and hook up event handler
            CellStyle cs = _flex.Styles.Add("filter");
            cs.ComboList = "...";
            cs.Font = new Font(_flex.Font, FontStyle.Bold);
            _flex.CellButtonClick += new RowColEventHandler(_flex_CellButtonClick);
            _flex.ShowButtons = ShowButtonsEnum.Always;

            // initalize cell that contains menu
            _flex.Cols[1].Name = "Revenue"; // (to find the column)
            _flex.SetCellStyle(1, 1, cs);   // (to show the button)
            _flex[1, 1] = "Revenue";        // (just some text)

            // add some data to filter on
            Random rnd = new Random();
            for (int r = 2; r < _flex.Rows.Count - 5; r++)
            {
                _flex[r, 1] = rnd.Next(0, 1000);
            }
        }

        // show menu when user clicks the button
        void _flex_CellButtonClick(object sender, RowColEventArgs e)
        {
            Rectangle rc = _flex.GetCellRect(e.Row, e.Col);
            rc.Offset(0, rc.Height);
            _menu.Show(_flex, rc.Location);
        }

        // handle menu clicks
        void _menuItemClick(object sender, EventArgs e)
        {
            // no repainting while we work
            _flex.Redraw = false;

            ToolStripItem item = sender as ToolStripItem;
            int col = _flex.Cols.IndexOf("Revenue");
            CellRange rg = _flex.GetCellRange(2, col, _flex.Rows.Count-1, col);

            switch (item.Text)
            {
                case "Sort Ascending":
                    _flex.Sort(SortFlags.Ascending, rg);
                    break;
                case "Sort Descending":
                    _flex.Sort(SortFlags.Descending, rg);
                    break;
                case "(All)":
                    for (int r = 2; r < _flex.Rows.Count; r++)
                        _flex.Rows[r].Visible = true;
                    break;
                case "(Top 10)":
                    _flex.Sort(SortFlags.Descending, rg);
                    for (int r = 2; r < _flex.Rows.Count; r++)
                        _flex.Rows[r].Visible = r <= 12;
                    break;
                case "(Non Blanks)":
                    for (int r = 2; r < _flex.Rows.Count; r++)
                        _flex.Rows[r].Visible = _flex[r, col] != null;
                    break;
                case "(Custom...)":
                    MessageBox.Show("Your custom filter dialog goes here");
                    break;
            }

            // ready to paint again
            _flex.Redraw = true;
        }
    }
}