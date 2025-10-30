namespace FlexGridCheckboxSelection.Helper
{

    /// <summary>
    /// Provides a scoped way to safely pair <see cref="C1FlexGrid.BeginUpdate"/> 
    /// and <see cref="C1FlexGrid.EndUpdate"/> calls, preventing unnecessary UI redraws.
    /// </summary>
    internal sealed class GridUpdateScope : IDisposable
    {
        #region Private Variables

        readonly C1FlexGrid _grid;

        #endregion

        #region Public Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="GridUpdateScope"/> class.
        /// </summary>
        /// <param name="grid">The <see cref="C1FlexGrid"/> to suspend updates for.</param>
        public GridUpdateScope(C1FlexGrid grid)
        {
            _grid = grid ?? throw new ArgumentNullException(nameof(grid));
            _grid.BeginUpdate();
        }

        /// <summary>
        /// Ends the update operation and resumes grid rendering.
        /// </summary>
        public void Dispose() => _grid.EndUpdate(); 
        #endregion
    }

}
