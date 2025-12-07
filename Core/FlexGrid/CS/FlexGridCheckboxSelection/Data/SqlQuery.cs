namespace FlexGridCheckboxSelection.Data
{
    /// <summary>
    /// Centralized store for all SQL queries used in the application. 
    /// </summary>
    internal class SqlQuery
    {
        #region Public Variables

        /// <summary>
        /// Query for retrieving extended customer data.
        /// </summary>
        public const string CustomerSqlQuery =
            @"SELECT PostalCode AS ID,
                         Country,
                         City,
                         Phone,
                         Fax,
                         Address,
                         ContactName,
                         ContactTitle,
                         CompanyName
                  FROM Customers
                  ORDER BY Country, City ASC"; 

        #endregion
    }
}
