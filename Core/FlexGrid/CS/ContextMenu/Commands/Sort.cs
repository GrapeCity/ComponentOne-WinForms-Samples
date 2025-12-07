using C1.Win.FlexGrid;
using System.Data;

namespace ContextMenu
{
    public class GridContextMenuItemSortAscending : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;

        public GridContextMenuItemSortAscending(C1FlexGrid grid)
            : base("Ascending", Properties.Resources.sort_ascending)
        {
            _grid = grid;
        }

        public override void Execute()
        {
            int col = _grid.Col;

            // Clear previous sort settings
            foreach (Column column in _grid.Cols)
                column.Sort = SortFlags.None;

            // Set current column to ascending
            _grid.Cols[col].Sort = SortFlags.Ascending;

            // Apply sorting
            _grid.Sort(SortFlags.UseColSort, col);


            // Manually trigger the after-sort logic
            if (_grid.DataSource is DataTable table)
            {
                var newTable = table.Clone(); // Copy schema only

                for (int i = _grid.Rows.Fixed; i < _grid.Rows.Count; i++)
                {
                    var gridRow = _grid.Rows[i];
                    if (gridRow.DataSource is DataRowView drv)
                    {
                        newTable.ImportRow(drv.Row);
                    }
                }

                _grid.DataSource = newTable;
            }

            // Select the first data row in the current column
            _grid.Select(_grid.Rows.Fixed, col);

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

    public class GridContextMenuItemSortDescending : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;

        public GridContextMenuItemSortDescending(C1FlexGrid grid)
            : base("Descending", Properties.Resources.sort_descending)
        {
            _grid = grid;
        }

        public override void Execute()
        {
            int col = _grid.Col;

            // Set current column to ascending
            _grid.Cols[col].Sort = SortFlags.Descending;

            // Apply sorting
            _grid.Sort(SortFlags.UseColSort, _grid.Col);

            // Manually trigger the after-sort logic
            if (_grid.DataSource is DataTable table)
            {
                var newTable = table.Clone(); // Copy schema only

                for (int i = _grid.Rows.Fixed; i < _grid.Rows.Count; i++)
                {
                    var gridRow = _grid.Rows[i];
                    if (gridRow.DataSource is DataRowView drv)
                    {
                        newTable.ImportRow(drv.Row);
                    }
                }

                _grid.DataSource = newTable;
            }

            // Select the last data row in the current column
            _grid.Select(_grid.Rows.Count - 1, col);

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
}
