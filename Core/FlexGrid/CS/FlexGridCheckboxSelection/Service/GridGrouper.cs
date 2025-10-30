namespace FlexGridCheckboxSelection.Service
{
    /// <summary>
    /// Applies hierarchical grouping to a <see cref="C1FlexGrid"/> by inserting group header nodes
    /// and styling them. Current implementation groups by Country (level 0) then City (level 1).
    /// </summary>
    internal sealed class GridGrouper : IGridGrouper
    {
        #region Private Methods

        readonly C1FlexGrid _grid;

        const string StyleGroup0 = "Group0";
        const string StyleGroup1 = "Group1";

        #endregion

        #region Public Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="GridGrouper"/> class.
        /// </summary>
        /// <param name="grid">The target grid to group.</param>
        /// <exception cref="ArgumentNullException">Thrown when <paramref name="grid"/> is null.</exception>
        public GridGrouper(C1FlexGrid grid)
        {
            _grid = grid ?? throw new ArgumentNullException(nameof(grid));
        }

        /// <summary>
        /// Applies grouping to the bound data: level 0 by Country, level 1 by City.
        /// </summary>
        public void ApplyGrouping()
        {
            if (_grid.Rows.Count <= _grid.Rows.Fixed) return;

            CreateTreeColumn(0);
            ApplyGroupStyles();

            InsertGroupNodes(GridColumnsUtils.Country, level: 0, styleName: StyleGroup0);
            InsertGroupNodes(GridColumnsUtils.City, level: 1, styleName: StyleGroup1);
        }

        /// <summary>
        /// Sets which column displays the tree expand/collapse glyphs.
        /// </summary>
        private void CreateTreeColumn(int columnIndex) => _grid.Tree.Column = columnIndex;

        /// <summary>
        /// Ensures styles for group rows exist.
        /// </summary>
        private void ApplyGroupStyles()
        {
            if (_grid.Styles[StyleGroup0] == null)
            {
                var s0 = _grid.Styles.Add(StyleGroup0);
                s0.BackColor = Color.Gray;
                s0.ForeColor = Color.White;
                s0.Font = new Font(_grid.Font, FontStyle.Bold);
            }

            if (_grid.Styles[StyleGroup1] == null)
            {
                var s1 = _grid.Styles.Add(StyleGroup1);
                s1.BackColor = Color.LightGray;
                s1.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Inserts group header nodes whenever the value in <paramref name="columnName"/> changes.
        /// </summary>
        /// <param name="columnName">The column used as a grouping key.</param>
        /// <param name="level">The tree level for the group header node.</param>
        /// <param name="styleName">The style name to apply on the inserted group row.</param>
        private void InsertGroupNodes(string columnName, int level, string styleName)
        {
            if (string.IsNullOrWhiteSpace(columnName)) return;

            object? current = null;
            var firstScrollableCol = _grid.Cols.Fixed;

            for (int r = _grid.Rows.Fixed; r < _grid.Rows.Count; r++)
            {
                var row = _grid.Rows[r];
                if (row.IsNode) continue;

                var value = _grid[r, columnName];
                if (Equals(value, current)) continue;

                // Value changed: insert a header node at this level and style it.
                _grid.Rows.InsertNode(r, level);
                if (_grid.Styles[styleName] is CellStyle style)
                {
                    _grid.Rows[r].Style = style;
                }

                // Show the group caption in the first scrollable column.
                _grid[r, firstScrollableCol] = value;
                current = value;
            }
        } 
        #endregion
    }
}
