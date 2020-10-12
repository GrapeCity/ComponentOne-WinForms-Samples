using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using C1.Win.Olap;

namespace QuickStart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // designer support
            InitializeComponent();

            // get data
            var da = new OleDbDataAdapter(Properties.Resources.SqlStatement, GetConnectionString());
            var dt = new DataTable("NorthWind Sales Data");
            da.Fill(dt);

            // assign data to C1OlapPage control
            _c1OlapPage.DataSource = dt;

            // show default view
            var olap = _c1OlapPage.OlapPanel.OlapEngine;
            olap.BeginUpdate();
            olap.RowFields.Add("Country");
            olap.ColumnFields.Add("Category");
            olap.ValueFields.Add("Sales");
            olap.EndUpdate();

            // load predefined olap views
            var doc = new XmlDocument();
            doc.LoadXml(Properties.Resources.OlapViews);

            // build menu with default olap views
            var menuView = new ToolStripDropDownButton("&View", Properties.Resources.Views_small);
            foreach (XmlNode nd in doc.SelectNodes("OlapViews/C1Olap"))
            {
                var tsi = menuView.DropDownItems.Add(nd.Attributes["id"].Value);
                tsi.Tag = nd;
            }
            menuView.DropDownItemClicked += MenuView_DropDownItemClicked;

            // add the new view menu to the toolstrip
            _c1OlapPage.ToolStrip.Items.Insert(3, menuView);
        }

        // select a predefined Olap view
        void MenuView_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var nd = e.ClickedItem.Tag as XmlNode;
            if (nd != null)
            {
                _c1OlapPage.OlapPanel.ViewDefinition = nd.OuterXml;
            }
        }

        // get standard nwind mdb connection string
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
