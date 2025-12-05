using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class CellStyles : C1DemoForm
    {
        public CellStyles()
        {
            IsThemeable = false;
            InitializeComponent();
            // add some text to the grid
            _flex.Select(1, 1, _flex.Rows.Count - 1, _flex.Cols.Count - 1);
            var sel = _flex.Selection;
            sel.Data = "hello";
            _flex.Select(1, 1);
        }

        // update toolbar button state when user selects a new cell range
        void _flex_AfterRowColChange(object sender, C1.Win.FlexGrid.RangeEventArgs e)
        {
            UpdateButtonState();
        }

        // handle toolstrip buttons
        void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // scan each cell in the selection
            var sel = _flex.Selection;
            for (int r = sel.TopRow; r <= sel.BottomRow; r++)
            {
                for (int c = sel.LeftCol; c <= sel.RightCol; c++)
                {
                    // get the single-cell range
                    var rng = _flex.GetCellRange(r, c);

                    // create a brand new style for this cell,
                    // initialize it from the original style
                    var newStyle = _flex.Styles.Add(null);
                    newStyle.MergeWith(rng.StyleDisplay);

                    // assign the new style to the cell
                    rng.Style = newStyle;

                    if (e.ClickedItem == _btnBold)
                    {
                        newStyle.Font = CreateFont(newStyle.Font, FontStyle.Bold, !_btnBold.Checked);
                    }
                    else if (e.ClickedItem == _btnItalic)
                    {
                        newStyle.Font = CreateFont(newStyle.Font, FontStyle.Italic, !_btnItalic.Checked);
                    }
                    else if (e.ClickedItem == _btnUnderline)
                    {
                        newStyle.Font = CreateFont(newStyle.Font, FontStyle.Underline, !_btnUnderline.Checked);
                    }
                    else if (e.ClickedItem == _btnLeft)
                    {
                        newStyle.TextAlign = C1.Win.FlexGrid.TextAlignEnum.LeftCenter;
                    }
                    else if (e.ClickedItem == _btnRight)
                    {
                        newStyle.TextAlign = C1.Win.FlexGrid.TextAlignEnum.RightCenter;
                    }
                    else if (e.ClickedItem == _btnCenter)
                    {
                        newStyle.TextAlign = C1.Win.FlexGrid.TextAlignEnum.CenterCenter;
                    }
                }
            }

            // update state after changing the style
            UpdateButtonState();
        }

        // create a new font changing one font style flag
        Font CreateFont(Font f, FontStyle flag, bool value)
        {
            var fs = value ? (f.Style | flag) : (f.Style & ~flag);
            return new Font(f, fs);
        }

        // update toolbar button state
        void UpdateButtonState()
        {
            // show button state based on first cell of the selection
            var s = _flex.Selection.StyleDisplay;

            // update font buttons
            _btnBold.Checked = s.Font.Bold;
            _btnItalic.Checked = s.Font.Italic;
            _btnUnderline.Checked = s.Font.Underline;

            // update alignment buttons
            _btnLeft.Checked = s.TextAlign == C1.Win.FlexGrid.TextAlignEnum.LeftCenter;
            _btnCenter.Checked = s.TextAlign == C1.Win.FlexGrid.TextAlignEnum.CenterCenter;
            _btnRight.Checked = s.TextAlign == C1.Win.FlexGrid.TextAlignEnum.RightCenter;
        }
    }
}
