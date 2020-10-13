using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomizePage
{
    public partial class Form1 : Form
    {
        ToolStripButton collapseAllView;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // modify the connection string to make it work for the current user on this machine
            this.invoicesTableAdapter.Connection.ConnectionString = GetConnectionString();

            // auto-generated:
            // This line of code loads data into the 'nWINDDataSet.Invoices' table.
            this.invoicesTableAdapter.Fill(this.nWINDDataSet.Invoices);

            // show default view:
            // this assumes an application setting of type string called "DefaultView"
            var view = Properties.Settings.Default.DefaultView;
            if (!string.IsNullOrEmpty(view))
            {
                c1OlapPage1.ViewDefinition = view;
            }
            else
            {
                // build default view now
                var olap = c1OlapPage1.OlapEngine;
                olap.BeginUpdate();
                olap.RowFields.Add("ProductName");
                olap.ColumnFields.Add("Country");
                olap.ValueFields.Add("ExtendedPrice");
                olap.EndUpdate();
            }

            // build menu with predefined views:
            var doc = new System.Xml.XmlDocument();
            doc.LoadXml(Properties.Resources.OlapViews);
            var menuView = new ToolStripDropDownButton("&View", Properties.Resources.Views_small);
            foreach (System.Xml.XmlNode nd in doc.SelectNodes("OlapViews/C1OlapPage"))
            {
                var tsi = menuView.DropDownItems.Add(nd.Attributes["id"].Value);
                tsi.Tag = nd;
            }
            menuView.DropDownItemClicked += menuView_DropDownItemClicked;
            c1OlapPage1.Updated += c1OlapPage1_Updated;

            // add new view menu to C1OlapPage toolstrip
            c1OlapPage1.ToolStrip.Items.Insert(3, menuView);

            // add collapseall menu to C1OlapPage toolstrip
            collapseAllView = new ToolStripButton("&CollapseAll", Properties.Resources.CollapseAll);
            collapseAllView.Click += collapseAllView_Click;
            c1OlapPage1.ToolStrip.Items.Insert(11, collapseAllView);
        }

        void collapseAllView_Click(object sender, EventArgs e)
        {
            c1OlapPage1.OlapGrid.CollapseAllCols();
            c1OlapPage1.OlapGrid.CollapseAllRows();
        }

        // closing form, save current view as default for next time
        protected override void OnClosing(CancelEventArgs e)
        {
            // save current view as new default
            Properties.Settings.Default.DefaultView = c1OlapPage1.ViewDefinition;
            Properties.Settings.Default.Save();

            // fire event as usual
            base.OnClosing(e);
        }

        // select a predefined view
        void menuView_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var nd = e.ClickedItem.Tag as System.Xml.XmlNode;
            if (nd != null)
            {
                // load view definition from XML
                c1OlapPage1.ViewDefinition = nd.OuterXml;

                // show current view name in status bar
                c1OlapPage1.LabelStatus.Text = nd.Attributes["id"].Value;
            }
        }
        void c1OlapPage1_Updated(object sender, EventArgs e)
        {
            // clear report name after user made any changes
            c1OlapPage1.LabelStatus.Text = string.Empty;

            // update button status of collapseAllView.
            if (c1OlapPage1.ShowTotalsColumns == C1.Olap.ShowTotals.Subtotals || c1OlapPage1.ShowTotalsRows == C1.Olap.ShowTotals.Subtotals)
                collapseAllView.Enabled = true;
            else
                collapseAllView.Enabled = false;
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
