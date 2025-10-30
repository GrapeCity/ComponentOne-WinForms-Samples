namespace FlexGridCheckboxSelection.Utility
{
    /// <summary>
    /// Provides schema validation and helper methods for ensuring that all required data columns exist in the application's DataTables.
    /// This utility centralizes schema consistency checks and creates empty tables with the required structure when needed.
    /// </summary>
    internal static class DataSchemaUtils
    {
        #region Private Variables

        static readonly string[] RequiredColumns =
          { GridColumnsUtils.Id, GridColumnsUtils.Country, GridColumnsUtils.City, GridColumnsUtils.Phone,GridColumnsUtils.Fax,
            GridColumnsUtils.Address, GridColumnsUtils.ContactName, GridColumnsUtils.ContactTitle, GridColumnsUtils.CompanyName };

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates an empty  DataTable containing all required columns defined for the application schema.
        /// </summary>
        public static DataTable CreateEmptyTableWithRequiredColumns()
        {
            var dt = new DataTable();
            foreach (var col in RequiredColumns)
                dt.Columns.Add(col, typeof(string));
            return dt;
        }

        /// <summary>
        /// Determines whether the specified DataTable contains all required columns defined by the schema.
        /// </summary>
        public static bool HasRequiredColumns(DataTable? dt)
        {
            if (dt == null) return false;
            foreach (var col in RequiredColumns)
                if (!dt.Columns.Contains(col)) return false;
            return true;
        } 
        #endregion
    }
}
