using C1.Win.FlexGrid;
using System.Drawing;

namespace Renderer
{
    public class CustomGridRenderer : C1FlexGridRenderer
    {
        public Color[] _backgroundColors;
        public Color[] _borderColors;
        private string _rendererSet;

        #region ** renderer data set

        public readonly Color[] BackgroundColorsBlue = new Color[]
        {
            Color.FromArgb(218,237,255), // 0.  Normal, normal scrollable cell.
            Color.FromArgb(191,219,255), // 1.  TopLeft, top left fixed cell.
            Color.FromArgb(21,173,255),  // 2.  ColumnHeader, column header cell.
            Color.FromArgb(140,176,248), // 3.  ColumnHeaderSelected, selected column header cell.
            Color.FromArgb(140,176,248), // 4.  ColumnHeaderHot, column header cell currently under the mouse.
            Color.FromArgb(140,176,248), // 5.  ColumnHeaderSelectedHot, selected column header cell currently under the mouse.
            Color.FromArgb(191,219,255), // 6.  RowHeader, row header cell.
            Color.FromArgb(140,176,248), // 7.  RowHeaderSelected, selected row header cell.
            Color.FromArgb(140,176,248), // 8.  RowHeaderHot, row header cell currently under the mouse.
            Color.FromArgb(140,176,248), // 9.  RowHeaderSelectedHot, selected row header cell currently under the mouse.
            Color.FromArgb(140,176,248), // 10. Highlight, selected normal cell.
            Color.FromArgb(176,213,246), // 11. Cursor, cell that contains the cursor.
            Color.FromArgb(191,219,255)  // 12. Footer, footer cell.
        };

        public readonly Color[] BorderColorsBlue = new Color[]
        {
            Color.FromArgb(10,63,108), // 0.  Normal, normal scrollable cell.
            Color.FromArgb(10,63,108), // 1.  TopLeft, top left fixed cell.
            Color.FromArgb(10,63,108), // 2.  ColumnHeader, column header cell.
            Color.FromArgb(10,63,108), // 3.  ColumnHeaderSelected, selected column header cell.
            Color.FromArgb(10,63,108), // 4.  ColumnHeaderHot, column header cell currently under the mouse.
            Color.FromArgb(10,63,108), // 5.  ColumnHeaderSelectedHot, selected column header cell currently under the mouse.
            Color.FromArgb(10,63,108), // 6.  RowHeader, row header cell.
            Color.FromArgb(10,63,108), // 7.  RowHeaderSelected, selected row header cell.
            Color.FromArgb(10,63,108), // 8.  RowHeaderHot, row header cell currently under the mouse.
            Color.FromArgb(10,63,108), // 9.  RowHeaderSelectedHot, selected row header cell currently under the mouse.
            Color.FromArgb(10,63,108), // 10. Highlight, selected normal cell.
            Color.FromArgb(10,63,108), // 11. Cursor, cell that contains the cursor.
            Color.FromArgb(10,63,108)  // 12. Footer, footer cell.
        };

        public readonly Color[] BackgroundColorsSilver = new Color[]
        {
            Color.FromArgb(255,255,255), // 0.  Normal, normal scrollable cell.
            Color.FromArgb(240,240,240), // 1.  TopLeft, top left fixed cell.
            Color.FromArgb(235,235,241), // 2.  ColumnHeader, column header cell.
            Color.FromArgb(255,255,255), // 3.  ColumnHeaderSelected, selected column header cell.
            Color.FromArgb(255,255,255), // 4.  ColumnHeaderHot, column header cell currently under the mouse.
            Color.FromArgb(255,255,255), // 5.  ColumnHeaderSelectedHot, selected column header cell currently under the mouse.
            Color.FromArgb(240,240,240), // 6.  RowHeader, row header cell.
            Color.FromArgb(255,255,255), // 7.  RowHeaderSelected, selected row header cell.
            Color.FromArgb(255,255,255), // 8.  RowHeaderHot, row header cell currently under the mouse.
            Color.FromArgb(255,255,255), // 9.  RowHeaderSelectedHot, selected row header cell currently under the mouse.
            Color.FromArgb(235,235,241), // 10. Highlight, selected normal cell.
            Color.FromArgb(255,255,255), // 11. Cursor, cell that contains the cursor.
            Color.FromArgb(235,235,241)  // 12. Footer, footer cell.
        };

        public readonly Color[] BorderColorsSilver = new Color[]
        {
            Color.FromArgb(160,160,160), // 0.  Normal, normal scrollable cell.
            Color.FromArgb(160,160,160), // 1.  TopLeft, top left fixed cell.
            Color.FromArgb(160,160,160), // 2.  ColumnHeader, column header cell.
            Color.FromArgb(160,160,160), // 3.  ColumnHeaderSelected, selected column header cell.
            Color.FromArgb(160,160,160), // 4.  ColumnHeaderHot, column header cell currently under the mouse.
            Color.FromArgb(160,160,160), // 5.  ColumnHeaderSelectedHot, selected column header cell currently under the mouse.
            Color.FromArgb(160,160,160), // 6.  RowHeader, row header cell.
            Color.FromArgb(160,160,160), // 7.  RowHeaderSelected, selected row header cell.
            Color.FromArgb(160,160,160), // 8.  RowHeaderHot, row header cell currently under the mouse.
            Color.FromArgb(160,160,160), // 9.  RowHeaderSelectedHot, selected row header cell currently under the mouse.
            Color.FromArgb(160,160,160), // 10. Highlight, selected normal cell.
            Color.FromArgb(160,160,160), // 11. Cursor, cell that contains the cursor.
            Color.FromArgb(160,160,160)  // 12. Footer, footer cell.
        };

        public readonly Color[] BackgroundColorsBlack = new Color[]
        {
            Color.FromArgb(56,56,56),  // 0.  Normal, normal scrollable cell.
            Color.FromArgb(38,38,38),  // 1.  TopLeft, top left fixed cell.
            Color.FromArgb(38,38,38),  // 2.  ColumnHeader, column header cell.
            Color.FromArgb(0,114,198), // 3.  ColumnHeaderSelected, selected column header cell.
            Color.FromArgb(0,114,198), // 4.  ColumnHeaderHot, column header cell currently under the mouse.
            Color.FromArgb(0,114,198), // 5.  ColumnHeaderSelectedHot, selected column header cell currently under the mouse.
            Color.FromArgb(38,38,38),  // 6.  RowHeader, row header cell.
            Color.FromArgb(0,114,198), // 7.  RowHeaderSelected, selected row header cell.
            Color.FromArgb(0,114,198), // 8.  RowHeaderHot, row header cell currently under the mouse.
            Color.FromArgb(0,114,198), // 9.  RowHeaderSelectedHot, selected row header cell currently under the mouse.
            Color.FromArgb(0,114,198), // 10. Highlight, selected normal cell.
            Color.FromArgb(0,114,198), // 11. Cursor, cell that contains the cursor.
            Color.FromArgb(38,38,38)   // 12. Footer, footer cell.
        };

        public readonly Color[] BorderColorsBlack = new Color[]
        {
            Color.FromArgb(104,104,104), // 0.  Normal, normal scrollable cell.
            Color.FromArgb(104,104,104), // 1.  TopLeft, top left fixed cell.
            Color.FromArgb(104,104,104), // 2.  ColumnHeader, column header cell.
            Color.FromArgb(104,104,104), // 3.  ColumnHeaderSelected, selected column header cell.
            Color.FromArgb(104,104,104), // 4.  ColumnHeaderHot, column header cell currently under the mouse.
            Color.FromArgb(104,104,104), // 5.  ColumnHeaderSelectedHot, selected column header cell currently under the mouse.
            Color.FromArgb(104,104,104), // 6.  RowHeader, row header cell.
            Color.FromArgb(104,104,104), // 7.  RowHeaderSelected, selected row header cell.
            Color.FromArgb(104,104,104), // 8.  RowHeaderHot, row header cell currently under the mouse.
            Color.FromArgb(104,104,104), // 9.  RowHeaderSelectedHot, selected row header cell currently under the mouse.
            Color.FromArgb(104,104,104), // 10. Highlight, selected normal cell.
            Color.FromArgb(104,104,104), // 11. Cursor, cell that contains the cursor.
            Color.FromArgb(104,104,104)  // 12. Footer, footer cell.
        };

        public readonly Color[] BackgroundColorsCustom = new Color[]
        {
            Color.FromArgb(244,252,232), // 0.  Normal, normal scrollable cell.
            Color.FromArgb(192,192,255), // 1.  TopLeft, top left fixed cell.
            Color.FromArgb(214,232,190), // 2.  ColumnHeader, column header cell.
            Color.FromArgb(255,219,101), // 3.  ColumnHeaderSelected, selected column header cell.
            Color.FromArgb(214,232,190), // 4.  ColumnHeaderHot, column header cell currently under the mouse.
            Color.FromArgb(214,232,190), // 5.  ColumnHeaderSelectedHot, selected column header cell currently under the mouse.
            Color.FromArgb(214,232,190), // 6.  RowHeader, row header cell.
            Color.FromArgb(255,219,101), // 7.  RowHeaderSelected, selected row header cell.
            Color.FromArgb(214,232,190), // 8.  RowHeaderHot, row header cell currently under the mouse.
            Color.FromArgb(214,232,190), // 9.  RowHeaderSelectedHot, selected row header cell currently under the mouse.
            Color.FromArgb(255,219,101), // 10. Highlight, selected normal cell.
            Color.FromArgb(255,219,101), // 11. Cursor, cell that contains the cursor.
            Color.FromArgb(214,232,190)  // 12. Footer, footer cell.
        };

        public readonly Color[] BorderColorsCustom = new Color[]
        {
            Color.FromArgb(112,169,207), // 0.  Normal, normal scrollable cell.
            Color.FromArgb(112,169,207), // 1.  TopLeft, top left fixed cell.
            Color.FromArgb(112,169,207), // 2.  ColumnHeader, column header cell.
            Color.FromArgb(112,169,207), // 3.  ColumnHeaderSelected, selected column header cell.
            Color.FromArgb(112,169,207), // 4.  ColumnHeaderHot, column header cell currently under the mouse.
            Color.FromArgb(112,169,207), // 5.  ColumnHeaderSelectedHot, selected column header cell currently under the mouse.
            Color.FromArgb(112,169,207), // 6.  RowHeader, row header cell.
            Color.FromArgb(112,169,207), // 7.  RowHeaderSelected, selected row header cell.
            Color.FromArgb(112,169,207), // 8.  RowHeaderHot, row header cell currently under the mouse.
            Color.FromArgb(112,169,207), // 9.  RowHeaderSelectedHot, selected row header cell currently under the mouse.
            Color.FromArgb(112,169,207), // 10. Highlight, selected normal cell.
            Color.FromArgb(112,169,207), // 11. Cursor, cell that contains the cursor.
            Color.FromArgb(112,169,207)  // 12. Footer, footer cell.
        };

        #endregion ** renderer data set

        #region ** constructor

        public CustomGridRenderer()
        {
            _backgroundColors = new Color[BackgroundColorsCustom.Length];
            _borderColors = new Color[BorderColorsCustom.Length];
        }

        #endregion ** constructor

        public override bool TracksSelection => true;

        public override bool TracksMouse => true;

        public override void OnDrawCell(C1FlexGridBase flex, OwnerDrawCellEventArgs e, CellType cellType)
        {
            e.Style.Border.Color = _borderColors[(int)cellType];
            e.Style.BackColor = _backgroundColors[(int)cellType];

            // set text color
            switch (_rendererSet)
            {
                case "Blue":
                case "Silver":
                case "Custom":
                default:
                    e.Style.ForeColor = Color.Black;
                    break;

                case "Black":
                    e.Style.ForeColor = Color.White;
                    break;
            }

            base.OnDrawCell(flex, e, cellType);
        }

        public void ApplyRenderer(string rendererSet)
        {
            _rendererSet = rendererSet;

            switch (_rendererSet)
            {
                case "Blue":
                    _backgroundColors = BackgroundColorsBlue;
                    _borderColors = BorderColorsBlue;
                    break;

                case "Silver":
                    _backgroundColors = BackgroundColorsSilver;
                    _borderColors = BorderColorsSilver;
                    break;

                case "Black":
                    _backgroundColors = BackgroundColorsBlack;
                    _borderColors = BorderColorsBlack;
                    break;

                case "Custom":
                default:
                    _backgroundColors = BackgroundColorsCustom;
                    _borderColors = BorderColorsCustom;
                    break;
            }
        }
    }
}
