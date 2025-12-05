namespace FlexGridCheckboxSelection.Service
{
    /// <summary>
    /// Provides functionality to capture and restore the selection state of rows in a C1FlexGrid.
    /// </summary>
    /// <remarks>
    /// This service preserves selected rows when the grid is refreshed, rebound, or regrouped.
    /// It uses an <see cref="IRowKeyProvider"/> to uniquely identify each row by key values.
    /// </remarks>
    internal sealed class SelectionStateService
    {
        #region Private Methods

        readonly C1FlexGrid _grid;
        readonly IRowKeyProvider _keyProvider;

        #endregion

        #region Public Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionStateService"/> class.
        /// </summary>
        /// <param name="grid">The C1FlexGrid whose row selections are to be managed.</param>
        /// <param name="keyProvider">Provides a way to generate unique keys for grid rows.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown if <paramref name="grid"/> or <paramref name="keyProvider"/> is null.
        /// </exception>
        public SelectionStateService(C1FlexGrid grid, IRowKeyProvider keyProvider)
        {
            _grid = grid ?? throw new ArgumentNullException(nameof(grid));
            _keyProvider = keyProvider ?? throw new ArgumentNullException(nameof(keyProvider));
        }

        /// <summary>
        /// Captures a list of unique row keys for all currently selected rows.
        /// </summary>
        /// <returns>A list of keys identifying the selected rows.</returns>
        public List<string> CaptureSelectedKeys()
        {
            var keys = new List<string>();
            foreach (Row row in _grid.Rows)
            {
                if (row.IsNode || !row.Selected) continue;
                var key = _keyProvider.GetKey(row);
                if (!string.IsNullOrEmpty(key)) keys.Add(key);
            }
            return keys;
        }

        /// <summary>
        /// Restores the selection state of rows based on the previously captured keys.
        /// This re-selects rows that match the provided key set.
        /// </summary>
        /// <param name="keys">A collection of keys representing rows that should be re-selected.</param>
        public void RestoreSelectedKeys(IReadOnlyCollection<string> keys)
        {
            if (keys == null || keys.Count == 0) return;

            foreach (Row row in _grid.Rows)
            {
                if (row.IsNode) continue;
                var key = _keyProvider.GetKey(row);
                if (keys.Contains(key)) row.Selected = true;
            }
        }

        #endregion
    }

}
