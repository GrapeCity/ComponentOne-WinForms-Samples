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
using System.Diagnostics;

namespace BarCodeExplorer.Samples
{
    public partial class DataBinding : UserControl
    {
        private BindingSource customersBindingSource;

        public DataBinding()
        {
            InitializeComponent();
        }

        #region **internals
        private DataTable GetRows(string queryString)
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

        private void CreateHtml(string fileName)
        {
            string content = @"";
            var pathTemplate = Environment.CurrentDirectory + @"\Samples\DataBinding.Template.html";
            if (!File.Exists(pathTemplate))
            {
                MessageBox.Show($"File {pathTemplate}\n not found!", "Error");
                return;
            }

            // Read template
            content = File.ReadAllText(pathTemplate);

            // Create dictionary
            var patterns = (from s in splitContainer1.Panel2.Controls.Cast<Control>() select s)
                .Select(x => x as C1.Win.Input.C1Label)
                .Where(x => x != null)
                .Where(x => x.Name.IndexOf("label") >= 0)
                .Select(x => new
                {
                    Key = x.Name,
                    Value = x.Text
                }).ToDictionary(x => x.Key, x => x.Value);

            // Replace values
            patterns.Keys.ToList()
                .ForEach(x =>
                {
                    content = content.Replace(x, patterns[x]);
                });

            // Get image of barcode
            var base64String = "";
            using (var stream = new System.IO.MemoryStream())
            {
                c1BarCode1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);

                byte[] imageBytes = stream.ToArray();
                base64String = Convert.ToBase64String(imageBytes);
            }

            content = content.Replace("%Base64Image", base64String);

            // Save to file
            File.WriteAllText(fileName, content);
        }
       
        private void UpdateButtons()
        {
            button1.Enabled = customersBindingSource.Position != 0;
            button2.Enabled = customersBindingSource.Position < customersBindingSource.Count - 1;

            label3.Text = $"{customersBindingSource.Position + 1} of {customersBindingSource.Count}";
        }

        #endregion

        private void DataBound_Load(object sender, EventArgs e)
        {
            var dataTable = GetRows("SELECT * FROM Customers");
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

        private void linkExportTo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var saveDialog = new SaveFileDialog() { DefaultExt =  "HTML", Filter = "Html files(*.html) | *.html | All files(*.*) | *.*" };
            if (saveDialog.ShowDialog(this) == DialogResult.OK)
                CreateHtml(saveDialog.FileName);
        }
    }
}
