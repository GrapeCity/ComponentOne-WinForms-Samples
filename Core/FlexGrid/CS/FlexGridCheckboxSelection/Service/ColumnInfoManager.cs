namespace FlexGridCheckboxSelection.Service
{
    /// <summary>
    /// Manages the grid’s column layout by applying predefined ColumnInfo presets while preserving selection and grouping states.
    /// </summary>
    internal sealed class ColumnInfoManager
    {
        #region Private Variables

        readonly C1FlexGrid _grid;
        readonly SelectionStateService _selectionService;
        readonly IGridGrouper _grouper;

        #endregion

        #region Public Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="ColumnInfoManager"/> class
        /// </summary>
        /// <param name="grid">The <see cref="C1FlexGrid"/> instance.</param>
        /// <param name="selectionService">Service responsible for preserving selected rows.</param>
        /// <param name="grouper">Component used to reapply grouping after layout changes.</param>
        public ColumnInfoManager(C1FlexGrid grid, SelectionStateService selectionService, IGridGrouper grouper)
        {
            _grid = grid ?? throw new ArgumentNullException(nameof(grid));
            _selectionService = selectionService ?? throw new ArgumentNullException(nameof(selectionService));
            _grouper = grouper ?? throw new ArgumentNullException(nameof(grouper));
        }

        /// <summary>
        /// Applies or removes the grid header layout and optionally reapplies grouping.
        /// </summary>
        /// <param name="showHeader">True to show header columns; false to hide them.</param>
        /// <param name="reGroupAfter">True to reapply grouping after layout change.</param>
        public void ApplyHeader(bool showHeader, bool reGroupAfter)
        {
            var selectedKeys = _selectionService.CaptureSelectedKeys();
            var dataSource = _grid.DataSource;

            using (new GridUpdateScope(_grid))
            {
                _grid.DataSource = null;
                _grid.ColumnInfo = showHeader ? ColumnInfoPresetsUtils.WithHeader : ColumnInfoPresetsUtils.NoHeader;
                _grid.DataSource = dataSource;

                if (reGroupAfter)
                {
                    _grouper.ApplyGrouping();
                }

                _grid.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter;
                _grid.AutoSizeCols();
            }

            _selectionService.RestoreSelectedKeys(selectedKeys);
        } 

        #endregion
    }
}
