using C1.Win.FlexGrid;
using System.Data;

namespace ContextMenu
{
    public class GridContextMenuItemSelectAll : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;

        public GridContextMenuItemSelectAll(C1FlexGrid grid)
            : base("Select All", Properties.Resources.select)
        {
            _grid = grid;
        }

        public override void Execute()
        {
            
            // Select all cells from (first row, first col) to (last row, last col)
            _grid.Select(1, 1, _grid.Rows.Count - 1, _grid.Cols.Count - 1);
        }
    }

    public class GridContextMenuItemClearContent : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;

        public GridContextMenuItemClearContent(C1FlexGrid grid)
            : base("Clear Content", null)
        {
            _grid = grid;
        }

        public override void Execute()
        {
            var selection = _grid.Selection;

            for (int row = selection.TopRow; row <= selection.BottomRow; row++)
            {
                for (int col = selection.LeftCol; col <= selection.RightCol; col++)
                {
                    // Optional: skip fixed cells
                    if (row < _grid.Rows.Fixed || col < _grid.Cols.Fixed)
                        continue;

                    _grid[row, col] = null; // or string.Empty
                }
            }
        }
    }

    public class GridContextMenuItemEditCellValue : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;

        public GridContextMenuItemEditCellValue(C1FlexGrid grid)
            : base("Edit Value", null)
        {
            _grid = grid;
        }

        public override void Execute()
        {
            var sel = _grid.Selection;

            // Ensure it's a valid single cell selection
            if (sel.TopRow != sel.BottomRow || sel.LeftCol != sel.RightCol)
                return;

            int row = sel.TopRow;
            int col = sel.LeftCol;

            // Skip headers
            if (row < _grid.Rows.Fixed || col < _grid.Cols.Fixed)
                return;

            // Start editing the selected cell
            _grid.StartEditing(row, col);
        }

        public override bool Enabled
        {
            get
            {
                var sel = _grid.Selection;

                // Check if it's a single cell selection (not multiple cells)
                bool isSingleCell = sel.TopRow == sel.BottomRow && sel.LeftCol == sel.RightCol;

                if (!isSingleCell)
                    return false;

                return true;
            }
        }
    }

    public class GridContextMenuItemRenameHeader : GridContextMenuItemBase
    {
        private readonly C1FlexGrid _grid;
        public GridContextMenuItemRenameHeader(C1FlexGrid grid)
            : base("Rename", null)
        {
            _grid = grid;
        }

        public override void Execute()
        {
            var sel = _grid.Selection;
            if (sel == null || sel.LeftCol != sel.RightCol)
            {
                MessageBox.Show("Please select exactly one column to rename.", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_grid.DataSource is not DataTable table)
            {
                MessageBox.Show("Grid is not data-bound to a DataTable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int colIndex = sel.LeftCol;
            var currentHeader = _grid.Cols[colIndex].Caption;

            string input = PromptInput($"Enter new name for column '{currentHeader}':", "Rename Column Header", currentHeader);

            if (string.IsNullOrWhiteSpace(input))
            {
                // User canceled or entered empty string, do nothing
                return;
            }

            input = input.Trim();

            if (table.Columns.Cast<DataColumn>().Any(c => c.ColumnName.Equals(input, StringComparison.OrdinalIgnoreCase) && table.Columns.IndexOf(c) != colIndex - _grid.Cols.Fixed))
            {
                MessageBox.Show("Column name must be unique.", "Rename Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _grid.Cols[colIndex].Caption = input;

                int tableColIndex = colIndex - _grid.Cols.Fixed;
                if (tableColIndex >= 0 && tableColIndex < table.Columns.Count)
                {
                    table.Columns[tableColIndex].ColumnName = input;
                    _grid.Select(_grid.Row, colIndex);
                }
            }
            catch (Exception ex) when (ex is DuplicateNameException || ex is ArgumentException)
            {
                MessageBox.Show("Invalid column name.", "Rename Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string PromptInput(string text, string caption, string defaultValue = "")
        {
            using Form prompt = new Form()
            {
                Width = 500,
                Height = 225,
                FormBorderStyle = FormBorderStyle.FixedToolWindow,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent,
                ShowInTaskbar = false,
            };

            Label textLabel = new Label() { Left = 20, Top = 20, Text = text, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 430, Text = defaultValue };
            Button confirmation = new Button() { Text = "OK", Left = 360, Width = 90, Height = 40, Top = 100, DialogResult = DialogResult.OK };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : null;
        }
    }
}
