using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexGridExplorer.Data
{
    public static class DataSource
    {
        #region "private methods"

        private static string databaseFileName = @"\NORTHWND.db";
        private static List<KeyValuePair<int, string>> paths = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(1, Environment.CurrentDirectory),
                new KeyValuePair<int, string>(2, Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common")
            };
        public static string GetPathDb()
        {
            var existsDb = paths.Select(x => new
            {
                Priority = x.Key,
                Path = x.Value + databaseFileName,
                Exists = File.Exists(x.Value + databaseFileName)
            }).Where(x => x.Exists)
              .OrderBy(x => x.Priority)
              .FirstOrDefault()?.Path ?? "";

            return existsDb;
        }
        private static bool CheckDatabase()
        {
            var existsPathDb = GetPathDb();
            if (string.IsNullOrEmpty(existsPathDb))
            {
                var message = $"File {databaseFileName} not found! {Environment.NewLine}" +
                    $"{string.Join(Environment.NewLine, paths.Select(x => x.Value).ToArray())}";
                MessageBox.Show(message, "Error");

                return false;
            }

            return true;
        }
        private static IEnumerable<DataColumn> CreateColumns(SqliteDataReader reader, IEnumerable<string> imageColumns = null)
        {
            var columns = new List<DataColumn>();
            var dateColumnNames = new List<string>()
            { "datetime", "date"};

            if(reader.HasRows )
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
        private static Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        #endregion
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
                                        row[x] = Base64ToImage(reader[x].ToString());
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
    }
}
