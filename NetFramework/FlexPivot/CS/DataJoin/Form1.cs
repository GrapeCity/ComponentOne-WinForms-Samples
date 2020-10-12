using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using C1.Win.FlexPivot;
using C1.FlexPivot;
using C1.DataEngine;
using System.Globalization;

namespace DataJoin
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        List<dynamic> tables = new List<dynamic>();
        string dataPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data");

        // default result fields (not including referenced fields)
        string[] selectedFields = new string[] {
            "Orders\\Customer\\Customers\\Company",
            "Orders\\Customer\\Customers\\Country",
            "Orders\\Employee\\Employees\\Title"
        };

        public Form1()
        {
            // designer support
            InitializeComponent();

            // connect to sample data
            conn = new SqlConnection(GetConnectionString());
            conn.Open();

            // where DataEngine data is stored
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Init(dataPath);

            // create DataEngine tables
            tables.Add(GetData("Orders", Properties.Resources.SqlOrders));
            tables.Add(GetData("Customers", Properties.Resources.SqlCustomers));
            tables.Add(GetData("Employees", Properties.Resources.SqlEmployees));

            btnJoin.Click += btnJoin_Click;
        }

        // joins tables
        void btnJoin_Click(object sender, EventArgs e)
        {
            using (FormJoin frm = new FormJoin())
            {
                frm.Tables = tables.ToArray();
                // restore previously selected fileds
                frm.SelectedFields = selectedFields;
                if (frm.ShowDialog(this) == DialogResult.OK)
                {
                    selectedFields = frm.SelectedFields;
                    // clear previous join result
                    _c1FlexPivotPage.FlexPivotPanel.Workspace.Clear("join");
                    // join tables
                    _c1FlexPivotPage.FlexPivotPanel.Workspace.join("join", tables[0], frm.JoinSettings).Query.Execute();
                    // connect joined data to C1FlexPivot
                    _c1FlexPivotPage.FlexPivotPanel.ConnectDataEngine("join");
                    // update C1FlexPivot view
                    OnSetData();
                }
            }
        }

        // creates DataEngine table
        dynamic GetData(string name, string sql)
        {
            C1.DataEngine.DbConnector connector = new C1.DataEngine.DbConnector(_c1FlexPivotPage.FlexPivotPanel.Workspace, conn);
            connector.Command = new SqlCommand(sql);
            connector.GetData(name);
            return _c1FlexPivotPage.FlexPivotPanel.Workspace.table(name);
        }

        // initializes or restores pivot view
        void OnSetData()
        {
            // fill lookups
            FillLookup("Country", Properties.Resources.SqlLookupCountry);
            FillLookup("Company", Properties.Resources.SqlLookupCustomer);
            FillLookup("Employee", Properties.Resources.SqlLookupEmployee);
            // set default C1FlexPivot view
            _c1FlexPivotPage.FlexPivotEngine.ShowTotalsRows = ShowTotals.Subtotals;
            C1FlexPivotField field = GetField("OrderID");
            if (field != null)
            {
                field.Subtotal = Subtotal.Count;
                _c1FlexPivotPage.FlexPivotEngine.ValueFields.Add(field);
            }
            field = GetField("Country");
            if (field != null)
                _c1FlexPivotPage.FlexPivotEngine.RowFields.Add(field);
            field = GetField("Company");
            if (field != null)
                _c1FlexPivotPage.FlexPivotEngine.RowFields.Add(field);
        }

        // fills lookup dictionary for the field from the database
        void FillLookup(string fieldName, string lookupSql)
        {
            C1FlexPivotField field = GetField(fieldName);
            if (field != null && field.Lookup == null)
                field.Lookup = GetLookup(conn, lookupSql);
        }

        // gets a C1FlexPivotField by name
        C1FlexPivotField GetField(string name)
        {
            foreach (C1FlexPivotField field in _c1FlexPivotPage.FlexPivotEngine.Fields)
                if (field.Name == name)
                    return field;
            return null;
        }

        // create a dictionary from two data columns
        Dictionary<object, string> GetLookup(SqlConnection conn, string command)
        {
            var dict = new Dictionary<object, string>();
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
            while (reader.Read())
                dict.Add(reader.GetValue(0), reader.GetString(1));
            reader.Close();
            return dict;
        }

        // remove data generated by the C1 DataEngine
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Clear();
            try
            {
                conn.Close();
            }
            catch { }
            base.OnFormClosed(e);
        }

        // get sample DB connection string
        static string GetConnectionString()
        {
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions");
            if (key == null)
            {
                throw new Exception("Microsoft SQL Server LocalDB is not installed.");
            }
            var version = "v11.0";
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
