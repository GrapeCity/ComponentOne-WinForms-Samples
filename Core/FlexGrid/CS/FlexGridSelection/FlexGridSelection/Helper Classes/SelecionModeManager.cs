using C1.Win.FlexGrid;
using C1.Win.Ribbon;
using FlexGridSelection.Interfaces;

namespace FlexGridSelection.Helper_Classes
{
    public class SelectionModeManager : ISelectionModeManager
    {
        private readonly C1FlexGrid _sourceFlexGrid;
        private readonly RibbonButton _selectAllButton;


        public SelectionModeManager(C1FlexGrid sourceFlexGrid, RibbonButton selectAllButton)
        {
            _sourceFlexGrid = sourceFlexGrid;
            _selectAllButton = selectAllButton;
        }
        /// <summary>
        /// Populates the provided RibbonComboBox with items by parsing the SelectionModeEnum values.
        /// Each item’s Tag property is set to the corresponding SelectionModeEnum value.
        /// </summary>
        public void PopulateSelectionModeCombo(RibbonComboBox combo)
        {
            combo.Items.Clear();
            foreach (SelectionModeEnum mode in Enum.GetValues(typeof(SelectionModeEnum)))
            {
                var item = new RibbonButton
                {
                    Text = mode.ToString(),
                    Tag = mode
                };
                combo.Items.Add(item);
            }
        }
        /// <summary>
        /// Updates the grid’s selection mode and executes corresponding selection logic.
        /// </summary>
        public void HandleSelectionModeChanged(SelectionModeEnum selectionMode)
        {
            _sourceFlexGrid.SelectionMode = selectionMode;

            // Execute selection logic based on the chosen mode.
            switch (selectionMode)
            {
                case SelectionModeEnum.Cell:
                    _sourceFlexGrid.Select(_sourceFlexGrid.GetCellRange(4, 2));
                    break;
                case SelectionModeEnum.CellRange:
                    _sourceFlexGrid.Select(_sourceFlexGrid.GetCellRange(4, 2, 7, 4));
                    break;
                case SelectionModeEnum.Row:
                    _sourceFlexGrid.Select(_sourceFlexGrid.GetCellRange(4, 1));
                    break;
                case SelectionModeEnum.RowRange:
                    _sourceFlexGrid.Select(_sourceFlexGrid.GetCellRange(4, 2, 7, 4));
                    break;
                case SelectionModeEnum.Column:
                    _sourceFlexGrid.Select(_sourceFlexGrid.GetCellRange(1, 3));
                    break;
                case SelectionModeEnum.ColumnRange:
                    _sourceFlexGrid.Select(_sourceFlexGrid.GetCellRange(4, 2, 7, 4));
                    break;
                case SelectionModeEnum.ListBox:
                    var rowsToSelect = new List<int> { 1, 2, 3, 4, 9, 10, 11 };
                    foreach (int rowIndex in rowsToSelect)
                    {
                        _sourceFlexGrid.Rows[rowIndex].Selected = true;
                    }
                    break;
                case SelectionModeEnum.MultiRange:
                    var rangesForMultiRange = new List<CellRange>
                    {
                        _sourceFlexGrid.GetCellRange(1, 1, 4, 2),
                        _sourceFlexGrid.GetCellRange(4, 3, 7, 5),
                        _sourceFlexGrid.GetCellRange(10, 2, 12, 3)
                    };
                    _sourceFlexGrid.Select(rangesForMultiRange);
                    break;
                default:
                    break;
            }

            var restrictedModes = new HashSet<SelectionModeEnum>
            {
                SelectionModeEnum.Cell,
                SelectionModeEnum.Row,
                SelectionModeEnum.Column
            };
            _selectAllButton.Enabled = !restrictedModes.Contains(_sourceFlexGrid.SelectionMode);
        }
    }
}
