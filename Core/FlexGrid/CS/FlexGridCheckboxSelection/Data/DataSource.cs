namespace FlexGridCheckboxSelection.Data
{
    /// <summary>
    /// Provides access to SQLite data, including schema validation and dynamic column creation.
    /// </summary
    static class DataSource
    {
        #region Private Methods

        static string _databaseFileName = @"\NORTHWND.db";
        static List<KeyValuePair<int, string>> _paths = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(1, Environment.CurrentDirectory),
                new KeyValuePair<int, string>(2, Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common")
            };

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets or sets the message box service used to display error messages.
        /// </summary
        public static IMessageBoxService MessageBoxService { get; set; } = new MessageBoxService();

        /// <summary>
        /// Attempts to locate the NORTHWND database file in known directories.
        /// </summary>
        public static string GetPathDb()
        {
            var existsDb = _paths.Select(x => new
            {
                Priority = x.Key,
                Path = x.Value + _databaseFileName,
                Exists = File.Exists(x.Value + _databaseFileName)
            }).Where(x => x.Exists)
              .OrderBy(x => x.Priority)
              .FirstOrDefault()?.Path ?? "";

            return existsDb;
        }

        /// <summary>
        /// Validates that the database exists; displays an error if not found.
        /// </summary>
        private static bool CheckDatabase()
        {
            var existsPathDb = GetPathDb();
            if (string.IsNullOrEmpty(existsPathDb))
            {
                var message = $"File {_databaseFileName} not found! {Environment.NewLine}" +
                    $"{string.Join(Environment.NewLine, _paths.Select(x => x.Value).ToArray())}";
                MessageBoxService.ShowError(message);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Dynamically creates <see cref="DataColumn"/> objects from an SQLite reader.
        /// </summary>
        private static IEnumerable<DataColumn> CreateColumns(SqliteDataReader reader, IEnumerable<string> imageColumns = null)
        {
            var columns = new List<DataColumn>();
            var dateColumnNames = new List<string>()
            { "datetime", "date"};

            if (reader.HasRows)
            {
                // Create base columns 
                var schemaTable = reader.GetSchemaTable();
                columns = (from s in schemaTable.Rows.Cast<DataRow>() select s)
                    .Select(x => new
                    {
                        // Name field
                        ColumnName = x["ColumnName"].ToString(),
                        // Database type
                        DataTypeName = x["DataTypeName"].ToString().ToLower(),
                        // System type
                        SystemType = Type.GetType(x["DataType"].ToString())
                    })
                    .Select(x => new DataColumn()
                    {
                        ColumnName = x.ColumnName,
                        DataType =
                                    // Check type as date
                                    dateColumnNames.Any(y => y == x.DataTypeName) ? typeof(DateTime) :
                                    imageColumns != null ?
                                        // Check type as image
                                        imageColumns.Any(y => y == x.ColumnName) ? typeof(Image) : x.SystemType
                                    : x.SystemType
                    }).ToList();
            }
            return columns;
        }

        /// <summary>
        /// Executes a SQL query and returns the results as a <see cref="DataTable"/>.
        /// </summary>
        /// <param name="queryString">SQL query text to execute.</param>
        /// <param name="tableName">Optional table name for the result set.</param>
        /// <param name="imageColumns">Optional image column names to decode from Base64.</param>
        public static DataTable GetRows(string queryString,
            string tableName = "Result", IEnumerable<string> imageColumns = null)
        {
            var table = new DataTable(tableName);
            var existsPathDb = GetPathDb();
            if (!CheckDatabase())
                return null;

            var connectionString = String.Format("Data Source={0}", existsPathDb);
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                using (SqliteCommand command = new SqliteCommand(queryString, connection))
                {
                    // Open SQLite database
                    connection.Open();
                    var reader = command.ExecuteReader();
                    var columns = CreateColumns(reader, imageColumns);
                    table.Columns.AddRange(columns.ToArray());

                    if (columns.Any())
                    {
                        while (reader.Read())
                        {
                            // Fill table
                            var row = table.NewRow();
                            var arrayColumns = columns.ToArray();
                            Enumerable.Range(0, reader.FieldCount)
                                .ToList()
                                .ForEach(x =>
                                {
                                    var currentColumns = arrayColumns[x];
                                    bool IsImageColumn = imageColumns == null ? false :
                                            imageColumns.Any(y => y == currentColumns.ColumnName) ? true : false;

                                    if (IsImageColumn)
                                        row[x] = ImageConverterUtils.Base64ToImage(reader[x].ToString());
                                    else
                                        row[x] = reader[x];
                                });

                            table.Rows.Add(row);
                        }

                        return table;
                    }
                }
            }
            return null;
        } 

        #endregion
    }
}
