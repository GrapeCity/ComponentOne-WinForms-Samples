using C1.Win.FlexGrid;

namespace ContextMenu
{
    public class GridContextMenuItemDeleteRow : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;
        public GridContextMenuItemDeleteRow(C1FlexGrid grid)
            : base("Delete Row", Properties.Resources.delete)
        {
            _grid = grid;
        }
        public override void Execute()
        {
            var selection = _grid.Selection;

            var rowsToDelete = new HashSet<int>();

            for (int row = selection.TopRow; row <= selection.BottomRow; row++)
            {
                if (row >= _grid.Rows.Fixed)
                    rowsToDelete.Add(row);
            }

            if (rowsToDelete.Count == 0)
            {
                MessageBox.Show("No valid rows selected for deletion.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (int row in rowsToDelete.OrderByDescending(r => r))
            {
                _grid.Rows.Remove(row);
            }
        }
    }
}
