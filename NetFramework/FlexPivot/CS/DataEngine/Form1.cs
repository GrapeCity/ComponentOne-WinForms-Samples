using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using C1.FlexPivot;
using C1.DataEngine;
using System.Globalization;

namespace DataEngineSample
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        DateTime updateTime = DateTime.MinValue;
        string dataPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data");
        string initialView;

        public Form1()
        {
            // designer support
            InitializeComponent();

            // connect to sample data
            conn = new SqlConnection(GetConnectionString());
            conn.Open();

            // where DataEngine data is stored
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Init(dataPath);

            // show update log
            _c1FlexPivotPage.FlexPivotEngine.StartUpdating += FlexPivotEngine_StartUpdating;
            _c1FlexPivotPage.FlexPivotEngine.CancelUpdating += FlexPivotEngine_CancelUpdating;
            _c1FlexPivotPage.Updated += _c1FlexPivotPage_Updated;

            // load predefined FlexPivot views
            var doc = new XmlDocument();
            doc.LoadXml(Properties.Resources.FlexPivotViews);

            // build menu with FlexPivot views
            var menuView = new C1.Win.C1Command.C1CommandMenu();
            menuView.Text = "&View";
            menuView.Image = Properties.Resources.Views_small;
            foreach (XmlNode nd in doc.SelectNodes("FlexPivotViews/C1FlexPivot"))
            {
                if (initialView == null)
                    initialView = nd.OuterXml;
                var cmd = new C1.Win.C1Command.C1Command();
                cmd.Text = nd.Attributes["id"].Value;
                cmd.UserData = nd;
                cmd.Click += MenuView_DropDownItemClicked;
                var link = new C1.Win.C1Command.C1CommandLink(cmd);
                menuView.CommandLinks.Add(link);
            }

            // add the new view menu to the toolstrip
            var menuLink = new C1.Win.C1Command.C1CommandLink(menuView);
            menuLink.ButtonLook = C1.Win.C1Command.ButtonLookFlags.TextAndImage;
            _c1FlexPivotPage.ToolBar.CommandLinks.Insert(3, menuLink);
        }

        // Fill C1 DataEngine with data and connect C1FlexPivot to it
        void btnFill_Click(object sender, EventArgs e)
        {
            btnFill.Enabled = false;
            SetData(3000000);
        }

        // select a predefined FlexPivot view
        void MenuView_DropDownItemClicked(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            var nd = e.CallerLink.Command.UserData as XmlNode;
            if (nd != null && _c1FlexPivotPage.FlexPivotEngine.Fields.Count > 0)
            {
                _c1FlexPivotPage.FlexPivotPanel.ViewDefinition = nd.OuterXml;
            }
        }

        // data row item
        public class Sale
        {
            public float Sales { get; set; }
            public DateTime OrderDate { get; set; }
            public int Product { get; set; }
            public int Customer { get; set; }
            public int Country { get; set; }
            public int Employee { get; set; }
            public int Category { get; set; }

            public Sale(IDataReader reader)
            {
                Sales = (float)reader["Sales"];
                OrderDate = (DateTime)reader["OrderDate"];
                Product = (int)reader["Product"];
                Customer = (int)reader["Customer"];
                Country = (int)reader["Country"];
                Employee = (int)reader["Employee"];
                Category = (int)reader["Category"];
            }

            public static IEnumerable<Sale> GetSales(IDataReader reader)
            {
                while (reader.Read())
                    yield return new Sale(reader);
            }
        }

        // Connect C1FlexPivot to data 
        void SetData(int count)
        {
            // read initial data from database
            IList<Sale> dataFromDB;
            var command = new SqlCommand(Properties.Resources.SqlStatement, conn);
            using (var reader = command.ExecuteReader())
                dataFromDB = Sale.GetSales(reader).ToList();

            // add more rows, just for testing performance 
            string tableName = "Sales";
            DateTime dt = DateTime.Now;
            StartAddingRows(count);
            var connector = new C1.DataEngine.ObjectConnector<Sale>(_c1FlexPivotPage.FlexPivotPanel.Workspace, ChangeDataSize(dataFromDB, count));
            connector.GetData(tableName);
            EndAddingRows(count, dt);

            var fPanel = _c1FlexPivotPage.FlexPivotPanel;
            fPanel.FlexPivotEngine.BeginUpdate();

            // connect C1FlexPivot to DataEngine filled with data
            fPanel.ConnectDataEngine(tableName);

            // set initial view
            fPanel.ViewDefinition = initialView;

            // fill lookups 
            FillLookup("Country", Properties.Resources.SqlLookupCountry);
            FillLookup("Product", Properties.Resources.SqlLookupProduct);
            FillLookup("Customer", Properties.Resources.SqlLookupCustomer);
            FillLookup("Employee", Properties.Resources.SqlLookupEmployee);
            FillLookup("Category", Properties.Resources.SqlLookupCategory);

            fPanel.FlexPivotEngine.EndUpdate();
        }

        // increasing row count by cloning existing rows multiple times, just for testing performance
        IEnumerable<Sale> ChangeDataSize(IEnumerable<Sale> data, int size)
        {
            IEnumerator<Sale> enumerator = data.GetEnumerator();
            for (int i = 0; i < size; i++)
            {
                if (!enumerator.MoveNext())
                {
                    if (i == 0)
                        break;
                    enumerator = data.GetEnumerator();
                    enumerator.MoveNext();
                }
                yield return enumerator.Current;
            }
        }

        // fill lookup dictionary for a field from the database
        void FillLookup(string fieldName, string lookupSql)
        {
            C1FlexPivotField field = _c1FlexPivotPage.FlexPivotPanel.FlexPivotEngine.Fields[fieldName];
            if (field.Lookup == null)
                field.Lookup = GetLookup(conn, lookupSql);
        }

        // create a dictionary from two data columns
        Dictionary<object, string> GetLookup(SqlConnection conn, string command)
        {
            var dict = new Dictionary<object, string>();
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                dict.Add(reader.GetValue(0), reader.GetString(1));
            reader.Close();
            return dict;
        }

        // start logging adding rows
        void StartAddingRows(int count)
        {
            listBox1.Items.Add(string.Format("Adding {0} rows...", count.ToString("n0")));
            listBox1.TopIndex = listBox1.Items.Count - 1;
            Application.DoEvents();
        }

        // end logging adding rows
        void EndAddingRows(int count, DateTime startTime)
        {
            string time = DateTime.Now.Subtract(startTime).TotalSeconds.ToString("n2");
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            listBox1.Items.Add(string.Format("Added {0} rows: {1} sec.", count.ToString("n0"), time));
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        // start log item
        void FlexPivotEngine_StartUpdating(object sender, EventArgs e)
        {
            updateTime = DateTime.Now;
            listBox1.Items.Add(string.Format("Updating..."));
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        // complete log item with cancelation information
        // Update can be cancelled if the user changes fields during update
        void FlexPivotEngine_CancelUpdating(object sender, EventArgs e)
        {
            string time = DateTime.Now.Subtract(updateTime).TotalSeconds.ToString("n2");
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            listBox1.Items.Add(string.Format("Updating canceled: {0} sec.", time));
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        // complete log item with calculated operation time 
        void _c1FlexPivotPage_Updated(object sender, EventArgs e)
        {
            string time = DateTime.Now.Subtract(updateTime).TotalSeconds.ToString("n2");

            // update log
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            listBox1.Items.Add(string.Format("Updated: {0} sec.", time));
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        // remove data generated by C1 DataEngine
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
