using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;
using Microsoft.Data.Sqlite;
using System.IO;

namespace BarCodeExplorer.Samples
{
    public partial class DataBinding : UserControl
    {
        private BindingSource customersBindingSource;

        public DataBinding()
        {
            InitializeComponent();
        }

        private static DataTable GetTable(string queryString)
        {
            var table = new DataTable("Result");
            var pathDB = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common\NORTHWND.db";
            if (!File.Exists(pathDB))
            {
                MessageBox.Show($"File {pathDB}\n not found!","Error");
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

        private void DataBound_Load(object sender, EventArgs e)
        {
            var dataTable = GetTable("SELECT * FROM Customers");
            if (dataTable != null)
            {
                customersBindingSource = new BindingSource();
                customersBindingSource.DataSource = dataTable;

                labelCustomerName.DataBindings.Add("Text", customersBindingSource, "CompanyName");
                labelAddress.DataBindings.Add("Text", customersBindingSource, "Address");
                labelCity.DataBindings.Add("Text", customersBindingSource, "City");
                labelContactName.DataBindings.Add("Text", customersBindingSource, "ContactName");
                labelPhone.DataBindings.Add("Text", customersBindingSource, "Phone");
                c1BarCode1.DataBindings.Add("Text", customersBindingSource, "PostalCode");

                UpdateButtons();
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }

        private void UpdateButtons()
        {
            button1.Enabled = customersBindingSource.Position != 0;
            button2.Enabled = customersBindingSource.Position < customersBindingSource.Count - 1;

            label3.Text = $"{customersBindingSource.Position + 1} of {customersBindingSource.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (customersBindingSource.Position > 0)
                customersBindingSource.Position--;

            UpdateButtons();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (customersBindingSource.Position < customersBindingSource.Count - 1)
                customersBindingSource.Position++;

            UpdateButtons();
        }
    }
}
