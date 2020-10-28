using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InputPanelExplorer.Samples
{
    public partial class Customization : UserControl
    {
        private BindingSource employeesBindingSource;
        public Customization()
        {
            InitializeComponent();
        }

        private void DataBinding_Load(object sender, EventArgs e)
        {
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

        private void cbReportsTo_Format(object sender, ListControlConvertEventArgs e)
        {
            PropertyDescriptor pd = TypeDescriptor.GetProperties(e.ListItem)["FirstName"];
            if (pd != null)
            {
                object firstName = pd.GetValue(e.ListItem);
                if (firstName is string && e.Value is string)
                {
                    e.Value = (string)firstName + " " + (string)e.Value;
                }
            }
        }
    }
}
