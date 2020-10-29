using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputPanelExplorer.Data
{
    public static class DataSource
    {
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
        public static DataTable GetRows(string queryString)
        {
            var table = new DataTable("Result");
            var existsPathDb = GetPathDb();
            if (string.IsNullOrEmpty(existsPathDb))
            {
                var message = $"File {databaseFileName} not found! {Environment.NewLine}" +
                    $"{string.Join(Environment.NewLine, paths.Select(x => x.Value).ToArray())}";
                MessageBox.Show(message, "Error");

                return null;
            }

            var connectionString = String.Format("Data Source={0}", existsPathDb);

            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                using (SqliteCommand command = new SqliteCommand(queryString, connection))
                {
                    // Open SQLite database
                    connection.Open();
                    var reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        // Get column structure
                        var schemaTable = reader.GetSchemaTable();
                        var columns = (from s in schemaTable.Rows.Cast<DataRow>() select s)
                            .Select(x => new DataColumn()
                            {
                                ColumnName = x["ColumnName"].ToString(),
                                DataType = Type.GetType(x["DataType"].ToString()) 
                            });
                        table.Columns.AddRange(columns.ToArray());

                        while (reader.Read())
                        {
                            // Fill table
                            var row = table.NewRow();
                            Enumerable.Range(0, reader.FieldCount)
                                .ToList()
                                .ForEach(x =>
                                {
                                    row[x] = reader[x];
                                });

                            table.Rows.Add(row);
                        }

                        return table;
                    }
                }

                return null;
            }
        }
    }
}
