using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Globalization;

namespace DataUpdateSample
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        int updatingItemIndex;
        DateTime updateTime = DateTime.MinValue;
        string dataPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data");
        string initialView;

        string tableName = "Sales";
        IList<Sale> dataFromDB;

        public Form1()
        {
            // designer support
            InitializeComponent();

            // connect to sample data
            conn = new SqlConnection(GetConnectionString());
            conn.Open();

            // show update log
            _c1FlexPivotPage.PivotEngine.StartUpdating += FlexPivotEngine_StartUpdating;
            _c1FlexPivotPage.PivotEngine.CancelUpdating += FlexPivotEngine_CancelUpdating; 
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

        void Form1_Load(object sender, EventArgs e)
        {
            // where DataEngine data is stored
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Init(dataPath);

            // peek at the data, does it already exist on disk?
            ICollection data = _c1FlexPivotPage.FlexPivotPanel.Workspace.GetTableData("Sales");
            if (data != null && data.Count != 0)
                // if there is data already on disk, show default view in the control
                ConnectDataEngine();
        }

        // initial data fill
        void btnFill_Click(object sender, EventArgs e)
        {
            AddToEngineTable(3000000, true);
        }

        // adding more data
        void btnAdd_Click(object sender, EventArgs e)
        {
            AddToEngineTable(1000, false);
        }

        // wipe out all data, including on disk
        void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(string.Format("Clear rows"));
            listBox1.TopIndex = listBox1.Items.Count - 1;

            _c1FlexPivotPage.FlexPivotPanel.ConnectDataEngine(null);
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Clear();
        }

        // select a predefined FlexPivot view
        void MenuView_DropDownItemClicked(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            var nd = e.CallerLink.Command.UserData as XmlNode;
            if (nd != null && _c1FlexPivotPage.PivotEngine.Fields.Count > 0)
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
        
        // add data to DataEngine table
        void AddToEngineTable(int count, bool firstTime)
        {
            // read initial data from database
            var command = new SqlCommand(Properties.Resources.SqlStatement, conn);
            if (firstTime || dataFromDB == null)
                using (var reader = command.ExecuteReader())
                {
                    dataFromDB = Sale.GetSales(reader).ToList();
                }

            // add more rows, just for testing performance  
            var connector = new C1.DataEngine.ObjectConnector<Sale>(_c1FlexPivotPage.FlexPivotPanel.Workspace, ChangeDataSize(dataFromDB, count));
            DateTime dt = DateTime.Now;
            int idx = StartAddingRows(count);
            if (firstTime)
                connector.GetData(tableName);
            else
                connector.AppendData(tableName);
            EndAddingRows(count, dt, idx);

            // connect C1FlexPivot to DataEngine filled with data
            if (firstTime)
                ConnectDataEngine();
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

        // connect C1FlexPivot to DataEngine filled with data
        void ConnectDataEngine()
        {
            var fPanel = _c1FlexPivotPage.FlexPivotPanel;
            fPanel.PivotEngine.BeginUpdate();
            fPanel.ConnectDataEngine(tableName);

            // set initial view
            fPanel.ViewDefinition = initialView;

            // fill lookups
            FillLookup("Country", Properties.Resources.SqlLookupCountry);
            FillLookup("Product", Properties.Resources.SqlLookupProduct);
            FillLookup("Customer", Properties.Resources.SqlLookupCustomer);
            FillLookup("Employee", Properties.Resources.SqlLookupEmployee);
            FillLookup("Category", Properties.Resources.SqlLookupCategory);

            fPanel.PivotEngine.EndUpdate();
        }

        // fill lookup dictionary for the field from the database
        void FillLookup(string fieldName, string lookupSql)
        {
            var field = _c1FlexPivotPage.FlexPivotPanel.PivotEngine.Fields[fieldName];
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
        int StartAddingRows(int count)
        {
            int index = listBox1.Items.Add(string.Format("Adding {0} rows...", count.ToString("n0")));
            listBox1.TopIndex = listBox1.Items.Count - 1;
            Application.DoEvents();
            return index;
        }

        // end logging adding rows
        void EndAddingRows(int count, DateTime startTime, int startItem)
        {
            string time = DateTime.Now.Subtract(startTime).TotalSeconds.ToString("n2");
            listBox1.Items[startItem] = string.Format("Added {0} rows: {1} sec.", count.ToString("n0"), time);
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        // start log item
        void FlexPivotEngine_StartUpdating(object sender, EventArgs e)
        {
            updateTime = DateTime.Now;
            updatingItemIndex = listBox1.Items.Add(string.Format("Updating..."));
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        // complete log item with cancelation information
        // Update can be cancelled if the user changes fields during update
        void FlexPivotEngine_CancelUpdating(object sender, EventArgs e)
        {
            string time = DateTime.Now.Subtract(updateTime).TotalSeconds.ToString("n2");
            listBox1.Items[updatingItemIndex] = string.Format("Updating canceled: {0} sec.", time);
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        // complete log item with calculated operation time 
        void _c1FlexPivotPage_Updated(object sender, EventArgs e)
        {
            string time = DateTime.Now.Subtract(updateTime).TotalSeconds.ToString("n2");

            // update log
            listBox1.Items[updatingItemIndex] = string.Format("Updated: {0} sec.", time);
            listBox1.TopIndex = listBox1.Items.Count - 1;

            // allow adding more data if there is data already; otherwise, allow only initial fill
            bool filled = _c1FlexPivotPage.PivotEngine.Fields.Count > 0;
            btnFill.Enabled = !filled;
            btnClear.Enabled = filled;
            btnAdd.Enabled = filled;
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
