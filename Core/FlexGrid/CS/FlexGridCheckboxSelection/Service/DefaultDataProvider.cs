using System.IO;

namespace FlexGridCheckboxSelection.Service
{
    /// <summary>
    /// Provides a safe mechanism for executing SQL queries and retrieving data 
    /// into <see cref="DataTable"/> objects while handling exceptions and schema validation.
    /// </summary> 
    internal sealed class DefaultDataProvider : IDataProvider
    {
        #region Public Methods
        /// <summary>
        /// Executes the given SQL query and returns a valid <see cref="DataTable"/>. 
        /// Returns false if any error occurs or required columns are missing.
        /// </summary>
        public bool GetRowsSafe(string sql, out DataTable dt, out string? error)
        {
            try
            {
                var raw = DataSource.GetRows(sql);
                if (!DataSchemaUtils.HasRequiredColumns(raw))
                {
                    dt = DataSchemaUtils.CreateEmptyTableWithRequiredColumns();
                    error = Strings.MissingColumnError;
                    return false;
                }

                dt = raw!;
                error = null;
                return true;
            }
            catch (Exception ex)
            {
                dt = DataSchemaUtils.CreateEmptyTableWithRequiredColumns();
                error = MapError(ex);
                return false;
            }
        }

        #endregion
        /// <summary>
        /// Converts an exception into a readable, user-friendly message.
        /// </summary>

        #region Private Methods
        private static string MapError(Exception ex) =>
         ex switch
         {
             SqliteException e => string.Format(Strings.SqliteExceptionMsg, e.Message),
             IOException e => string.Format(Strings.IOExceptionMsg, e.Message),
             InvalidOperationException e => string.Format(Strings.InvalidOperationExceptionMsg, e.Message),
             ArgumentException e => string.Format(Strings.ArgumentExceptionMsg, e.Message),
             _ => string.Format(Strings.UnexpectedErrorMsg, ex.Message),
         };

        #endregion
    }
}
