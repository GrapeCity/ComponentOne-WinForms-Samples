using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputPanelExplorer.Samples
{
    public partial class DataBinding : UserControl
    {
        private BindingSource employeesBindingSource;

        public DataBinding()
        {
            InitializeComponent();

            employeesBindingSource = new BindingSource();
            employeesBindingSource.DataSource = GetRows("Select * from Employees");

          
        }

        private DataTable GetRows(string queryString)
        {
            var table = new DataTable("Result");
            var pathDB = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common\NORTHWND.db";
            if (!File.Exists(pathDB))
            {
                MessageBox.Show($"File {pathDB}\n not found!", "Error");
                return null;
            }

            var connectionString = String.Format("Data Source={0}", pathDB);

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
                                DataType = typeof(object)
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
