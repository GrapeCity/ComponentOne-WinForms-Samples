using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMode
{
    public class DataConnector
    {
        //--------------------------------------------------------------------------------
        #region ** fields

        string _tableName;
        SqlCommand _command;
        DataColumnCollection _columnsValue;
        string _commaSeparatedListOfColumnNamesValue;
        int _rowCountValue = -1;
        string _columnToSortBy;
        SqlDataAdapter _adapter = new SqlDataAdapter();

        #endregion

        //--------------------------------------------------------------------------------
        #region ** ctors

        public DataConnector(string connectionString, string tableName)
        {
            var connection = new SqlConnection(connectionString);
            connection.Open();
            _command = connection.CreateCommand();
            _tableName = tableName;
        }

        #endregion

        //--------------------------------------------------------------------------------
        #region ** object model

        public int TotalRowCount
        {
            get
            {
                // Return the existing value if it has already been determined.
                if (_rowCountValue != -1)
                {
                    return _rowCountValue;
                }

                // Retrieve the row count from the database.
                _command.CommandText = "SELECT COUNT(*) FROM " + _tableName;
                _rowCountValue = (int)_command.ExecuteScalar();
                return _rowCountValue;
            }
        }

        public DataColumnCollection Columns
        {
            get
            {
                // Return the existing value if it has already been determined.
                if (_columnsValue != null)
                {
                    return _columnsValue;
                }

                // Retrieve the column information from the database.
                _command.CommandText = "SELECT * FROM " + _tableName;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = _command;
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                adapter.FillSchema(table, SchemaType.Source);
                _columnsValue = table.Columns;
                return _columnsValue;
            }
        }

        string CommaSeparatedListOfColumnNames
        {
            get
            {
                // Return the existing value if it has already been determined.
                if (_commaSeparatedListOfColumnNamesValue != null)
                {
                    return _commaSeparatedListOfColumnNamesValue;
                }

                // Store a list of column names for use in the
                // SupplyPageOfData method.
                var commaSeparatedColumnNames = new System.Text.StringBuilder();
                bool firstColumn = true;
                foreach (DataColumn column in Columns)
                {
                    if (!firstColumn)
                    {
                        commaSeparatedColumnNames.Append(", ");
                    }
                    commaSeparatedColumnNames.Append(column.ColumnName);
                    firstColumn = false;
                }

                _commaSeparatedListOfColumnNamesValue = commaSeparatedColumnNames.ToString();
                return _commaSeparatedListOfColumnNamesValue;
            }
        }

        public DataTable GetData(int lowerPageBoundary, int rowsPerPage)
        {
            // Store the name of the ID column. This column must contain unique 
            // values so the SQL below will work properly.
            if (_columnToSortBy == null)
            {
                _columnToSortBy = this.Columns[0].ColumnName;
            }

            if (!this.Columns[_columnToSortBy].Unique)
            {
                throw new InvalidOperationException(String.Format(
                    "Column {0} must contain unique values.", _columnToSortBy));
            }

            // Retrieve the specified number of rows from the database, starting
            // with the row specified by the lowerPageBoundary parameter.
            _command.CommandText = "Select Top " + rowsPerPage + " " +
                CommaSeparatedListOfColumnNames + " From " + _tableName +
                " WHERE " + _columnToSortBy + " NOT IN (SELECT TOP " +
                lowerPageBoundary + " " + _columnToSortBy + " From " +
                _tableName + " Order By " + _columnToSortBy +
                ") Order By " + _columnToSortBy;
            _adapter.SelectCommand = _command;

            // Create the Update command needed to update the database with our changes
            var cmdBuilder = new SqlCommandBuilder(_adapter);
            _adapter.UpdateCommand = cmdBuilder.GetUpdateCommand();

            // populate the page
            var table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            _adapter.Fill(table);
            Console.WriteLine("DataRetriever loaded {0} rows from the data source at {1}", table.Rows.Count, DateTime.Now.ToShortTimeString());
            return table;
        }

        // saves the changes in the table back to the database
        public int SaveChanges(DataTable table)
        {
            var count = _adapter.Update(table);
            table.AcceptChanges();
            return count;
        }

        #endregion
    }
}
