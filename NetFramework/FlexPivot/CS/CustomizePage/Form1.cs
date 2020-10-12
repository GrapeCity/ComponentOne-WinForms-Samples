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
        C1.Win.C1Command.C1Command collapseAllView;
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
                c1FlexPivotPage1.ViewDefinition = view;
            }
            else
            {
                // build default view now
                var fp = c1FlexPivotPage1.FlexPivotEngine;
                fp.BeginUpdate();
                fp.RowFields.Add("ProductName");
                fp.ColumnFields.Add("Country");
                fp.ValueFields.Add("ExtendedPrice");
                fp.EndUpdate();
            }

            // build menu with predefined views:
            var doc = new System.Xml.XmlDocument();
            doc.LoadXml(Properties.Resources.FlexPivotViews);
            var menuView = new C1.Win.C1Command.C1CommandMenu();
            menuView.Text = "&View";
            menuView.Image = Properties.Resources.Views_small;
            foreach (System.Xml.XmlNode nd in doc.SelectNodes("FlexPivotViews/C1FlexPivotPage"))
            {
                var cmd = new C1.Win.C1Command.C1Command();
                cmd.Text = nd.Attributes["id"].Value;
                cmd.UserData = nd;
                cmd.Click += menuView_DropDownItemClicked;
                var link = new C1.Win.C1Command.C1CommandLink(cmd);
                menuView.CommandLinks.Add(link);
            }
            c1FlexPivotPage1.Updated += c1FlexPivotPage1_Updated;

            // add new view menu to C1FlexPivotPage toolstrip
            var menuLink = new C1.Win.C1Command.C1CommandLink(menuView);
            c1FlexPivotPage1.ToolBar.CommandLinks.Insert(3, menuLink);

            // add collapse all menu to C1FlexPivotPage toolstrip
            collapseAllView = new C1.Win.C1Command.C1Command();
            collapseAllView.Text = "&CollapseAll";
            collapseAllView.Image = Properties.Resources.CollapseAll;
            collapseAllView.Click += collapseAllView_Click;
            C1.Win.C1Command.C1CommandLink collapseAllViewLink = new C1.Win.C1Command.C1CommandLink(collapseAllView); 
            c1FlexPivotPage1.ToolBar.CommandLinks.Add(collapseAllViewLink);
        }

        void collapseAllView_Click(object sender, EventArgs e)
        {
            c1FlexPivotPage1.FlexPivotGrid.CollapseAllCols();
            c1FlexPivotPage1.FlexPivotGrid.CollapseAllRows();
        }

        // closing form, save current view as default for next time
        protected override void OnClosing(CancelEventArgs e)
        {
            // save current view as new default
            Properties.Settings.Default.DefaultView = c1FlexPivotPage1.ViewDefinition;
            Properties.Settings.Default.Save();

            // fire event as usual
            base.OnClosing(e);
        }

        // select a predefined view
        void menuView_DropDownItemClicked(object sender, C1.Win.C1Command.ClickEventArgs e)
        {
            var nd = e.CallerLink.Command.UserData as System.Xml.XmlNode;
            if (nd != null)
            {
                // load view definition from XML
                c1FlexPivotPage1.ViewDefinition = nd.OuterXml;

                // show current view name in status bar
                c1FlexPivotPage1.LabelStatus.Text = nd.Attributes["id"].Value;
            }
        }
        void c1FlexPivotPage1_Updated(object sender, EventArgs e)
        {
            // clear report name after user made any changes
            c1FlexPivotPage1.LabelStatus.Text = string.Empty;

            // update button status of collapseAllView.
            if (c1FlexPivotPage1.ShowTotalsColumns == C1.FlexPivot.ShowTotals.Subtotals || c1FlexPivotPage1.ShowTotalsRows == C1.FlexPivot.ShowTotals.Subtotals)
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
