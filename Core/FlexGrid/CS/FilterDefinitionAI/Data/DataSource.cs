using FlexGridGeminiAI.Helpers;
using FlexGridGeminiAI.Interface;
using FlexGridGeminiAI.Models;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.Common;
using System.Text;

namespace FlexGridGeminiAI.Data
{

    /// <summary>
    /// class to provide a datasource either locallyor from the componenton control panel
    /// </summary>
    public class DataSource: IDataSource
    {
        private string _databaseFileName = @"\NORTHWND.db";
        private static Dictionary<int, string?> paths = new Dictionary<int, string?>
        {
            { 1, Environment.CurrentDirectory },
            { 2, Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common" }
        };


        public void SetDataSource(string fileName)
        {
            _databaseFileName = fileName;
        }

        #region "private methods"
        /// <summary>
        /// Search for the availibility of the database
        /// </summary>
        /// <returns>string path to the database</returns>
        public string GetPathDb()
        {
            var existDb = (
                from x in paths
                let fullPath = x.Value + _databaseFileName
                where File.Exists(fullPath)
                orderby x.Key
                select fullPath
            ).FirstOrDefault();

            if (existDb == null)
                throw new FileNotFoundException("Database file not found in any of the configured paths.");
            return existDb;
        }
        /// <summary>
        /// Opens the connection
        /// </summary>
        /// <returns></returns>
        private DbConnection GetOpenConnection()
        {
            string dbPath = GetPathDb();
            bool checkDb = CheckDatabase();
            
            if (!checkDb)
            {
                return default;
            }

            var connectionString = String.Format("Data Source={0}", dbPath);
            SqliteConnection connection = new SqliteConnection(connectionString);
            
            connection.Open();

            return connection;
        }

        private bool CheckDatabase()
        {
            var existsPathDb = GetPathDb();

            if (string.IsNullOrEmpty(existsPathDb))
            {
                var message = $"File {_databaseFileName} not found! {Environment.NewLine}" +
                    $"{string.Join(Environment.NewLine, paths.Select(x => x.Value).ToArray())}";
                MessageBox.Show(message, "Error");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Gets all the Tables inside of the database
        /// </summary>
        public List<string> GetDataTables(string query)
        {
            List<string> titles = new List<string> { };
            
            var connection = GetOpenConnection();
            using var command = connection.CreateCommand();
            command.CommandText = query;
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                titles.Add(reader.GetString(0));
            }
            return titles;
        }

        private IEnumerable<DataColumn> CreateColumns(SqliteDataReader reader, IEnumerable<string> imageColumns = null)
        {
            if (!reader.HasRows)
                return Enumerable.Empty<DataColumn>();

            var dateTypes = new[] { "datetime", "date" };
            var imageSet = imageColumns?.ToHashSet(StringComparer.OrdinalIgnoreCase);
            var schemaTable = reader.GetSchemaTable();

            var columns = schemaTable.Rows.Cast<DataRow>()
                .Select(row => CreateColumn(row, dateTypes, imageSet))
                .ToList();

            return columns;
        }

        private DataColumn CreateColumn(DataRow row, IEnumerable<string> dateTypes, HashSet<string> imageSet)
        {
            var name = row["ColumnName"]?.ToString();
            var typeName = row["DataTypeName"]?.ToString()?.ToLower();
            var systemType = Type.GetType(row["DataType"]?.ToString()) ?? typeof(string);

            Type resolvedType = systemType;

            if (dateTypes.Contains(typeName))
                resolvedType = typeof(DateTime);
            else if (imageSet?.Contains(name) == true)
                resolvedType = typeof(Image);

            return new DataColumn
            {
                ColumnName = name,
                DataType = resolvedType
            };
        }
        #endregion

        /// <summary>
        /// Generates a detailed string representation of a DataTable's schema.
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public List<DataColumnSchema> GetDataTableSchema(DataTable dataTable)
        {
            var schemaList = new List<DataColumnSchema>();

            if (dataTable == null || dataTable.Columns.Count == 0)
                return schemaList;

            foreach (DataColumn col in dataTable.Columns)
            {
                schemaList.Add(new DataColumnSchema
                {
                    Name = col.ColumnName,
                    ColumnIndex = col.Ordinal,
                    DataType = col.DataType.FullName
                });
            }

            return schemaList;
        }

        private SqliteConnection EstablishSqliteConnection()
        {
            var existsPathDb = GetPathDb();
            if (!CheckDatabase()) return null;

            var connectionString = $"Data Source={existsPathDb}";
            var connection = new SqliteConnection(connectionString);
            connection.Open();
            return connection;
        }

        /// <summary>
        ///  Generated the DataTable for the Grid
        /// </summary>
        /// <param name="queryString">Sql query for selection of data from the col</param>
        /// <param name="tableName">Name of the table from which the data is selected</param>
        /// <param name="imageColumns">if there is image in the column</param>
        /// <returns>DataTable</returns>
        public DataTable GetRows(string queryString,
            string tableName = "Result",
            IEnumerable<string> imageColumns = null)
        {
            var table = new DataTable(tableName);
            using var connection = EstablishSqliteConnection();
            if (connection == null) return null;

            using var command = new SqliteCommand(queryString, connection);
            using var reader = command.ExecuteReader();

            var columns = CreateColumns(reader, imageColumns);
            table.Columns.AddRange(columns.ToArray());

            if (columns.Any())
            {
                while (reader.Read())
                {
                    var row = table.NewRow();
                    var arrayColumns = columns.ToArray();

                    Enumerable.Range(0, reader.FieldCount).ToList().ForEach(x =>
                    {
                        var currentColumn = arrayColumns[x];
                        bool isImageColumn = imageColumns?.Any(y => y == currentColumn.ColumnName) ?? false;

                        row[x] = isImageColumn
                            ? ImageConverterUtils.Base64ToImage(reader[x].ToString())
                            : reader[x];
                    });

                    table.Rows.Add(row);
                }

                return table;
            }

            return null;
        }
    }
}
