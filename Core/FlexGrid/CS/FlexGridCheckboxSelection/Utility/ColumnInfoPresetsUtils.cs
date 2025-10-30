namespace FlexGridCheckboxSelection.Utility
{
    /// <summary>
    /// Provides predefined column layout configurations for C1FlexGrid controls.
    /// This utility centralizes common ColumnInfo presets used to toggle grid headers on or off.
    /// </summary>
    internal static class ColumnInfoPresetsUtils
    {
        #region Public Methods

        /// <summary>
        /// Represents the ColumnInfo string used when headers are visible.
        /// </summary>
        public const string WithHeader = "10,1,0,0,0,-1,Columns:";

        /// <summary>
        /// Represents the ColumnInfo string used when headers are hidden.
        /// </summary>
        public const string NoHeader = "0,0,0,0,0,-1,Columns:"; 

        #endregion
    }

}
