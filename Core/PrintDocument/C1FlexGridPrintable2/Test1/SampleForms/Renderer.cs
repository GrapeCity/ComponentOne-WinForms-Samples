using C1.Win.FlexGrid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Renderer
{
    public partial class Form1 : Form
    {
        #region ** fields

        private readonly string[] _rendererSet = new string[] { "Blue", "Silver", "Black", "Custom" };

        private readonly string[] _cellTypeNames = new string[]
        {
            "Normal",                  // 0,  normal scrollable cell.
            "TopLeft",                 // 1,  top left fixed cell.
            "ColumnHeader",            // 2,  column header cell.
            "ColumnHeaderSelected",    // 3,  selected column header cell.
            "ColumnHeaderHot",         // 4,  column header cell currently under the mouse.
            "ColumnHeaderSelectedHot", // 5,  selected column header cell currently under the mouse.
            "RowHeader",               // 6,  row header cell.
            "RowHeaderSelected",       // 7,  selected row header cell.
            "RowHeaderHot",            // 8,  row header cell currently under the mouse.
            "RowHeaderSelectedHot",    // 9,  selected row header cell currently under the mouse.
            "Highlight",               // 10, selected normal cell.
            "Cursor",                  // 11, cell that contains the cursor.
            "Footer"                   // 12, footer cell.
        };

        private CustomGridRenderer _renderer = new CustomGridRenderer();

        #endregion ** fields

        public Form1()
        {
            InitializeComponent();

            // set dimensions
            _flex.Rows.Count = _cellTypeNames.Length * 2 + 1;
            _flex.Cols.Count = 5;

            // set data types and custom editor
            var cp = new ColorPicker();
            for (int i = 1; i < 5; i++)
            {
                _flex.Cols[i].DataType = typeof(Color);
                _flex.Cols[i].Editor = cp;
            }

            // set column titles
            for (int i = 0; i < _rendererSet.Length; i++)
            {
                _flex[0, i + 1] = _rendererSet[i];
            }

            // set row titles and cell data
            for (int i = 0; i < _cellTypeNames.Length; i++)
            {
                _flex[i + 1, 0] = "Background: " + _cellTypeNames[i];
                _flex[i + 1, 1] = _renderer.BackgroundColorsBlue[i];
                _flex[i + 1, 2] = _renderer.BackgroundColorsSilver[i];
                _flex[i + 1, 3] = _renderer.BackgroundColorsBlack[i];
                _flex[i + 1, 4] = _renderer.BackgroundColorsCustom[i];
            }

            for (int i = _cellTypeNames.Length; i < _cellTypeNames.Length * 2; i++)
            {
                _flex[i + 1, 0] = "Border: " + _cellTypeNames[i - _cellTypeNames.Length];
                _flex[i + 1, 1] = _renderer.BorderColorsBlue[i - _cellTypeNames.Length];
                _flex[i + 1, 2] = _renderer.BorderColorsSilver[i - _cellTypeNames.Length];
                _flex[i + 1, 3] = _renderer.BorderColorsBlack[i - _cellTypeNames.Length];
                _flex[i + 1, 4] = _renderer.BorderColorsCustom[i - _cellTypeNames.Length];
            }

            // autosize fixed column
            _flex.AutoSizeCol(0);

            cbxRendererSet.Items.AddRange(_rendererSet);

            // "Custom" selected by default
            cbxRendererSet.SelectedItem = "Custom";

            // add footer
            var footerDescription = new FooterDescription();
            footerDescription.Caption = "FOOTER";
            _flex.Footers.Descriptions.Add(footerDescription);
            _flex.Footers.Fixed = true;

            // apply color when cell value changes
            _flex.CellChanged += new RowColEventHandler(_flex_CellChanged);

            // apply custom renderer
            _flex.Renderer = _renderer;
        }

        private void ApplyRenderer(string rendererSet, int row, Color color)
        {
            if (row > -1 && row < _cellTypeNames.Length)
            {
                _renderer._backgroundColors[row] = color;
            }
            else if (row >= _cellTypeNames.Length && row < _cellTypeNames.Length * 2)
            {
                row -= _cellTypeNames.Length;
                _renderer._borderColors[row] = color;
            }

            _renderer.ApplyRenderer(rendererSet);
            _flex.Invalidate();
        }

        private void cbxRendererSet_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbxRendererSet.SelectedIndex < 0)
            {
                return;
            }

            _renderer.ApplyRenderer(cbxRendererSet.SelectedItem.ToString());
            _flex.Invalidate();
        }

        private void _flex_CellChanged(object sender, RowColEventArgs e)
        {
            var value = _flex[e.Row, e.Col];

            if (value is Color)
            {
                var range = _flex.GetCellRange(e.Row, e.Col);
                var selectedColor = (Color)value;
                range.StyleNew.BackColor = selectedColor;

                cbxRendererSet.SelectedItem = _flex[0, e.Col];

                ApplyRenderer(_flex[0, e.Col].ToString(), e.Row - 1, selectedColor);
            }
        }
    }
}
