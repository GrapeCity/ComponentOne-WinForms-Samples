using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VirtualMode
{
    public partial class Form1 : Form
    {
        VirtualDataSource _dataSource;
        string table = "Orders";

        public Form1()
        {
            InitializeComponent();

            // Create a DataRetriever and use it to create a Cache object
            // and to initialize the DataGridView columns and rows.
            try
            {

                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                string connectionString = GetConnectionString();

                // create the virtual data source
                _dataSource = new VirtualDataSource(connectionString, table, 16);

                // use virtual data source to create unbound columns 
                _flex.AutoGenerateColumns = false;
                _flex.Cols.Count = _dataSource.Columns.Count + _flex.Cols.Fixed;
                for (int c = 0; c < _dataSource.Columns.Count; c++)
                {
                    _flex.Cols[c + _flex.Cols.Fixed].Caption = _dataSource.Columns[c].ColumnName;
                }

                // create a dummy data source with the right number of rows
                var list = new List<object>();
                for (int r = 0; r < _dataSource.TotalRowCount; r++)
                {
                    list.Add(0);
                }
                _flex.DataSource = list;
            }
            catch (SqlException)
            {
                MessageBox.Show("Connection could not be established.\r\n" +
                    "Verify that the connection string is valid.");
                Application.Exit();
            }
        }

        // get cell value from the virtual data source
        void _flex_GetUnboundValue(object sender, C1.Win.C1FlexGrid.UnboundValueEventArgs e)
        {
            var row = e.Row - _flex.Rows.Fixed;
            var col = e.Col - _flex.Cols.Fixed;
            if (row > -1 && col > -1)
            {
                e.Value = _dataSource.GetValue(row, col);
            }
        }

        // set cell value in the virtual data source
        void _flex_SetUnboundValue(object sender, C1.Win.C1FlexGrid.UnboundValueEventArgs e)
        {
            var row = e.Row - _flex.Rows.Fixed;
            var col = e.Col - _flex.Cols.Fixed;
            if (row > -1 && col > -1)
            {
                _dataSource.SetValue(row, col, e.Value);
            }
        }

        // get sample DB connection string
        static string GetConnectionString()
        {
            var version = "v11.0";
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions");
            foreach (var subKeyName in key.GetSubKeyNames())
            {
                double localDBVersion = 0;
                if (double.TryParse(subKeyName, NumberStyles.Number, CultureInfo.InvariantCulture, out localDBVersion) && localDBVersion >= 12)
                {
                    version = "MSSQLLocalDB";
                    break;
                }
            }

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            return string.Format(@"Data Source=(LocalDB)\{0};AttachDbFilename={1}\NORTHWND.MDF;Integrated Security=True;Connect Timeout=30", version, path);
        }
    }
}
