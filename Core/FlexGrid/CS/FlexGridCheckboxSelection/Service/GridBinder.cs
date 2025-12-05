namespace FlexGridCheckboxSelection.Service
{
    /// <summary>
    /// Handles data binding between a <see cref="C1FlexGrid"/> control and a <see cref="DataTable"/>.
    /// </summary>
    internal sealed class GridBinder
    {
        #region Private Methods

        readonly C1FlexGrid _grid;
        readonly SelectionStateService _selectionService;
        readonly IGridGrouper _grouper;

        #endregion

        #region Public Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="GridBinder"/> class.
        /// </summary>
        /// <param name="grid">The grid control to bind data.</param>
        /// <param name="selectionService">The service managing selection state persistence.</param>
        /// <param name="grouper">The service responsible for applying data grouping.</param>
        /// <exception cref="ArgumentNullException">Thrown when any dependency is null.</exception>
        public GridBinder(C1FlexGrid grid, SelectionStateService selectionService, IGridGrouper grouper)
        {
            _grid = grid ?? throw new ArgumentNullException(nameof(grid));
            _selectionService = selectionService ?? throw new ArgumentNullException(nameof(selectionService));
            _grouper = grouper ?? throw new ArgumentNullException(nameof(grouper));
        }

        /// <summary>
        /// Rebinds the grid with the provided data source, applies grouping and restores the previous row selection state.
        /// </summary>
        /// <param name="source">The data source to bind to the grid.</param>
        /// <param name="grouped">Determines whether to apply grouping after binding.</param>
        public void Rebind(DataTable source, bool grouped)
        {
            if (source == null) source = DataSchemaUtils.CreateEmptyTableWithRequiredColumns();

            List<string> selectedKeys = _selectionService.CaptureSelectedKeys();

            using (new GridUpdateScope(_grid))
            {
                _grid.DataSource = null;
                _grid.DataSource = source.Copy();

                var canGroup = grouped && source.Rows.Count > 0 && DataSchemaUtils.HasRequiredColumns(source);
                if (canGroup) _grouper.ApplyGrouping();

                _grid.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
                _grid.AutoSizeCols();
            }

            _selectionService.RestoreSelectedKeys(selectedKeys);
        } 

        #endregion
    }
}
