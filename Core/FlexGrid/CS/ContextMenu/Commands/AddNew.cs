using C1.Win.FlexGrid;
using System.Data;
using System.Text.RegularExpressions;

namespace ContextMenu
{
    public class GridContextMenuItemAddRowAbove : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;
        public GridContextMenuItemAddRowAbove(C1FlexGrid grid)
            : base("Above", Properties.Resources.add_row_above)
        {
            _grid = grid;
        }
        public override void Execute()
        {
            // Ensure the grid is data-bound to a DataTable
            if (_grid.DataSource is DataTable table)
            {
                int currentRow = _grid.Row;
                // Map the grid row index to the DataTable row index
                int dataRowIndex = currentRow - _grid.Rows.Fixed;
                if (dataRowIndex >= 0 && dataRowIndex <= table.Rows.Count)
                {
                    // Create a new row and insert it above the selected row
                    var newRow = table.NewRow();
                    table.Rows.InsertAt(newRow, dataRowIndex);
                    // Optionally, set focus to the new row in the grid
                    _grid.Row = currentRow;
                }
            }
            else
            {
                MessageBox.Show("Grid is not data-bound. Cannot insert row.", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override bool Enabled
        {
            get
            {
                // Check that a filter is applied
                bool isFilterApplied = Regex.IsMatch(_grid.FilterDefinition ?? "", @"=\s*\S+");
                if (isFilterApplied)
                    return false;

                var sel = _grid.Selection;

                // Check that selection covers exactly one row (any number of cells)
                bool isSingleRowSelected = sel.TopRow == sel.BottomRow;

                return isSingleRowSelected;
            }
        }

    }
    public class GridContextMenuItemAddRowBelow : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;
        public GridContextMenuItemAddRowBelow(C1FlexGrid grid)
            : base("Below", Properties.Resources.add_row_below)
        {
            _grid = grid;
        }
        public override void Execute()
        {
            // Ensure the grid is data-bound to a DataTable
            if (_grid.DataSource is DataTable table)
            {
                int currentRow = _grid.Row;
                // Map the grid row index to the DataTable row index
                int dataRowIndex = currentRow - _grid.Rows.Fixed;
                if (dataRowIndex >= 0 && dataRowIndex < table.Rows.Count)
                {
                    // Insert below: add 1 to the current data row index
                    var newRow = table.NewRow();
                    table.Rows.InsertAt(newRow, dataRowIndex + 1);
                    // Optionally, set focus to the new row in the grid
                    _grid.Row = currentRow + 1;
                }
            }
            else
            {
                MessageBox.Show("Grid is not data-bound. Cannot insert row.", "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public override bool Enabled
        {
            get
            {
                // 1. Check that a filter is applied
                bool isFilterApplied = Regex.IsMatch(_grid.FilterDefinition ?? "", @"=\s*\S+");
                if (isFilterApplied)
                    return false;

                var sel = _grid.Selection;

                // Check that selection covers exactly one row (any number of cells)
                bool isSingleRowSelected = sel.TopRow == sel.BottomRow;

                return isSingleRowSelected;
            }
        }
    }
}
