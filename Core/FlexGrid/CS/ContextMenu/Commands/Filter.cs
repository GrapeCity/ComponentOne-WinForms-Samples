using C1.Win.FlexGrid;
using System.Text.RegularExpressions;

namespace ContextMenu
{
    public class GridContextMenuItemFilterByValue : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;
        public GridContextMenuItemFilterByValue(C1FlexGrid grid)
            : base("Search By Value", null)
        {
            _grid = grid;
        }
        public override void Execute()
        {
            // Get selected range
            var sel = _grid.Selection;

            // Validate selection
            if (sel == null || sel.TopRow < _grid.Rows.Fixed || sel.LeftCol < _grid.Cols.Fixed)
                return;

            // Get the first selected cell's coordinates
            int row = sel.TopRow;
            int colIndex = sel.LeftCol;

            // Get the column and the selected cell value
            var col = _grid.Cols[colIndex];
            object cellValue = _grid[row, colIndex];

            // Enable filtering on the grid and the column
            _grid.AllowFiltering = true;
            col.AllowFiltering = AllowFiltering.ByCondition;

            // Create a new ConditionFilter
            var filter = new ConditionFilter();
            filter.Conditions[0].Operator = ConditionOperator.Equals;
            filter.Conditions[0].Parameter = cellValue;

            // Assign the filter to the column
            col.Filter = filter;

            // Apply the filter
            _grid.ApplyFilters();

        }
        public override bool Enabled
        {
            get
            {
                // Check that exactly one cell is selected (not a range)
                var sel = _grid.Selection;
                bool isSingleCell = sel.TopRow == sel.BottomRow && sel.LeftCol == sel.RightCol;
                if (!isSingleCell)
                    return false;

                return true;
            }
        }
    }

    public class GridContextMenuItemClearFilter : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;
        public GridContextMenuItemClearFilter(C1FlexGrid grid)
            : base("Clear Filter", null)
        {
            _grid = grid;
        }
        public override void Execute()
        {
            _grid.FilterDefinition = string.Empty;
            _grid.AllowFiltering = false;
        }
        public override bool Enabled => Regex.IsMatch(_grid.FilterDefinition, @"=\s*\S+");
    }
}
