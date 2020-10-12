using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using System.IO;
using C1.Win.FlexPivot;
using C1.FlexPivot;
using C1.DataEngine;
using System.Globalization;

namespace QuickStart
{
    public partial class Form1 : Form
    {
        bool updating;
        RadioButton sel;
        SqlConnection conn;
        DateTime addTime = DateTime.MinValue;
        DateTime updateTime = DateTime.MinValue;
        string dataPath = Path.Combine(System.Windows.Forms.Application.StartupPath, "Data");
        MemoryStream stream;
        string initialView;

        public Form1()
        {
            // designer support
            InitializeComponent();

            // handle standard data table controls
            foreach (Control ctl in groupBox1.Controls)
                if (ctl is RadioButton)
                    ctl.Click += DataTable_Click;

            // handle DataEngine table controls
            foreach (Control ctl in groupBox2.Controls)
                if (ctl is RadioButton)
                    ctl.Click += EngineTable_Click;

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

        // create and connect to DataTable
        void DataTable_Click(object sender, EventArgs e)
        {
            if (updating)
                return;

            // add data
            int count = StartAddingRows(sender);
            var dt = GetDataTable();
            AddToDataTable(dt, count);
            EndAddingRows(count);

            // set data
            _c1FlexPivotPage.FlexPivotPanel.FlexPivotEngine.BeginUpdate();
            _c1FlexPivotPage.DataSource = dt;
            OnSetData();
            _c1FlexPivotPage.FlexPivotPanel.FlexPivotEngine.EndUpdate();
        }

        // create and connect to a C1 DataEngine table
        void EngineTable_Click(object sender, EventArgs e)
        {
            if (updating)
                return;

            // add data to DataEngine
            int count = StartAddingRows(sender);
            DataTable dt = GetDataTable();
            AddToEngineTable(dt, count);
            EndAddingRows(count);

            // connect to DataEngine filled with data
            var fPanel = _c1FlexPivotPage.FlexPivotPanel;
            fPanel.FlexPivotEngine.BeginUpdate();
            fPanel.ConnectDataEngine(dt.TableName);
            OnSetData();
            fPanel.FlexPivotEngine.EndUpdate();
        }

        // select a predefined FlexPivot view
        void MenuView_DropDownItemClicked(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            if (updating || sel == null)
                return;

            var nd = e.CallerLink.Command.UserData as XmlNode;
            if (nd != null)
            {
                _c1FlexPivotPage.FlexPivotPanel.ViewDefinition = nd.OuterXml;
            }
        }

        // create DataTable
        DataTable GetDataTable()
        {
            var da = new SqlDataAdapter(Properties.Resources.SqlStatement, conn);
            var dt = new DataTable("NorthWind Sales Data");
            da.Fill(dt);
            return dt;
        }

        // generate new rows in DataTable
        void AddToDataTable(DataTable table, int count)
        {
            // remove column protection
            foreach (DataColumn col in table.Columns)
                col.ReadOnly = false;

            // read data from first rows
            int c = table.Rows.Count;
            int max = Math.Min(c, 5000);
            object[] rd = new object[max];
            for (int i = 0; i < max; i++)
                rd[i] = table.Rows[i].ItemArray;

            // add data to the end of the table
            for (int i = 0; i < count; i += max)
            {
                for (int k = 0; k < max && (k + i) < count; k++)
                {
                    DataRow r = table.NewRow();
                    r.ItemArray = (object[])rd[k];
                    table.Rows.Add(r);
                }
            }
        }

        // generate new rows in the C1 DataEngine table
        void AddToEngineTable(DataTable table, int count)
        {
            // clean previously generated data
            _c1FlexPivotPage.FlexPivotPanel.Workspace.Clear();

            AddToDataTable(table, count);
            C1.DataEngine.DbConnector.GetData(_c1FlexPivotPage.FlexPivotPanel.Workspace, table, table.TableName);
        }

        // initialize or restore pivot view
        void OnSetData()
        {
            if (initialView != null)
                // set initial view
                _c1FlexPivotPage.FlexPivotPanel.ViewDefinition = initialView;
            else
            {
                // restore the view
                using (System.Xml.XmlReader xr = System.Xml.XmlReader.Create(stream))
                {
                    _c1FlexPivotPage.ReadXml(xr);
                }
                stream.Dispose();
                stream = null;
            }
            initialView = null;

            // fill lookups
            FillLookup("Country", Properties.Resources.SqlLookupCountry);
            FillLookup("Product", Properties.Resources.SqlLookupProduct);
            FillLookup("Customer", Properties.Resources.SqlLookupCustomer);
            FillLookup("Employee", Properties.Resources.SqlLookupEmployee);
            FillLookup("Category", Properties.Resources.SqlLookupCategory);
        }

        // fill lookup dictionary for the field from the database
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
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess);
            while (reader.Read())
                dict.Add(reader.GetValue(0), reader.GetString(1));
            reader.Close();
            return dict;
        }

        // start logging adding rows
        int StartAddingRows(object sender)
        {
            updating = true;
            // uncheck other radio buttons
            foreach (Control ctl in groupBox1.Controls)
                if (ctl is RadioButton && !ctl.Equals(sender))
                    ((RadioButton)ctl).Checked = false;
            foreach (Control ctl in groupBox2.Controls)
                if (ctl is RadioButton && !ctl.Equals(sender))
                    ((RadioButton)ctl).Checked = false;

            // save current view
            stream = new MemoryStream();
            using (System.Xml.XmlWriter xw = System.Xml.XmlWriter.Create(stream))
            {
                _c1FlexPivotPage.FlexPivotEngine.WriteXml(xw);
                xw.Flush();
                stream.Position = 0;
            }

            // check selected button
            sel = ((RadioButton)sender);
            sel.Checked = true;

            // disconnect from data
            var fPanel = _c1FlexPivotPage.FlexPivotPanel;
            fPanel.DataSource = null;
            fPanel.ConnectDataEngine(null);

            // start log
            int count = int.Parse(sel.Tag.ToString());
            addTime = DateTime.Now;
            listBox1.Items.Add(string.Format("Creating {0} rows...", count.ToString("n0")));
            listBox1.TopIndex = listBox1.Items.Count - 1;
            Application.DoEvents();
            return count;
        }

        // end logging adding rows
        void EndAddingRows(int count)
        {
            string time = DateTime.Now.Subtract(addTime).TotalSeconds.ToString("n2");
            int idx = listBox1.Items.Count - 1;
            listBox1.Items[idx] = string.Format("Created {0} rows: {1} sec.", count.ToString("n0"), time);
            listBox1.TopIndex = idx;
        }

        // start log item
        void FlexPivotEngine_StartUpdating(object sender, EventArgs e)
        {
            string type = GetDataType();
            if (type == null)
                return;

            updateTime = DateTime.Now;
            listBox1.Items.Add(string.Format("Updating {0}...", type));
            listBox1.TopIndex = listBox1.Items.Count - 1;
        }

        // complete log item with cancelation information
        // Update can be cancelled if the user changes fields during update
        void FlexPivotEngine_CancelUpdating(object sender, EventArgs e)
        {
            string time = DateTime.Now.Subtract(updateTime).TotalSeconds.ToString("n2");
            int idx = listBox1.Items.Count - 1;
            listBox1.Items[idx] = string.Format("Updating {0} canceled: {1} sec.", GetDataType(), time);
            listBox1.TopIndex = idx;
        }

        // complete log item with calculated operation time 
        void _c1FlexPivotPage_Updated(object sender, EventArgs e)
        {
            string type = GetDataType();
            if (type == null)
                return;

            string time = DateTime.Now.Subtract(updateTime).TotalSeconds.ToString("n2");

            // update label
            Control label = sel.Parent.GetNextControl(sel, true);
            label.Text = string.Format("{0} sec.", time);

            // update log
            int idx = listBox1.Items.Count - 1;
            listBox1.Items[idx] = string.Format("Updated {0}: {1} sec.", type, time);
            listBox1.TopIndex = idx;
            updating = false;
        }

        // get current connected table type
        string GetDataType()
        {
            if (_c1FlexPivotPage.DataSource != null)
                return _c1FlexPivotPage.DataSource.GetType().FullName;
            else if (_c1FlexPivotPage.FlexPivotEngine.Fields.Count != 0)
                return "C1.DataEngine.Table";
            else
                return null;
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
