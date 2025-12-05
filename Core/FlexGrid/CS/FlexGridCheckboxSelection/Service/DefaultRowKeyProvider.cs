namespace FlexGridCheckboxSelection.Service
{
    /// <summary>
    /// Provides a default implementation of <see cref="IRowKeyProvider"/> that generates 
    /// a unique, concatenated key string for a given <see cref="Row"/> in the grid.
    /// </summary> 
    internal sealed class DefaultRowKeyProvider : IRowKeyProvider
    {
        #region Public Methods

        /// <summary>
        /// Generates a unique key string for the specified grid row.
        /// </summary>
        /// <param name="row">The grid row to extract key data from.</param>
        /// <returns>
        /// A concatenated key string made up of essential column values, or an empty string if the row is null or represents a group node.
        /// </returns>
        public string GetKey(Row row)
        {
            if (row == null || row.IsNode) return string.Empty;

            string country = row[GridColumnsUtils.Country]?.ToString() ?? "";
            string city = row[GridColumnsUtils.City]?.ToString() ?? "";
            string phone = row[GridColumnsUtils.Phone]?.ToString() ?? "";
            string id = row[GridColumnsUtils.Id]?.ToString() ?? "";
            string fax = row[GridColumnsUtils.Fax]?.ToString() ?? "";
            string address = row[GridColumnsUtils.Address]?.ToString() ?? "";
            string contactName = row[GridColumnsUtils.ContactName]?.ToString() ?? "";
            string contactTitle = row[GridColumnsUtils.ContactTitle]?.ToString() ?? "";
            string companyName = row[GridColumnsUtils.CompanyName]?.ToString() ?? "";

            return $"{country}|{city}|{phone}|{id}|{fax}|{address}|{contactName}|{contactTitle}|{companyName}";
        }

        #endregion
    }

}
