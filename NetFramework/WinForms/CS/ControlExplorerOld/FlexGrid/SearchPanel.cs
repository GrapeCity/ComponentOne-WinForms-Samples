using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class SearchPanel : C1DemoForm
    {
        public SearchPanel()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindDataSource();
            // add demo properties
            AddProperty("SearchMode", c1FlexGridSearchPanel1);
            AddProperty("HighlightSearchResults", c1FlexGridSearchPanel1);
            AddProperty("FilterSearchResults", c1FlexGridSearchPanel1);
        }

        private void BindDataSource()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("First Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Last Name", typeof(string)));
            dt.Columns.Add(new DataColumn("Birthdate", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("City", typeof(string)));
            dt.Columns.Add(new DataColumn("Country", typeof(string)));

            DataRow dr = dt.NewRow();
            dr.ItemArray = new object[] { "Dietrich", "Dittmar", new DateTime(1964, 04, 19), "Hamburg", "Germany" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "Florentin", "Monette", new DateTime(1973, 12, 23), "Paris", "France" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "John Jr", "Anderson", new DateTime(1995, 10, 11), "New York", "USA" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "Lazare", "Tremble", new DateTime(1951, 3, 27), "Marseille", "France" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "Ezio", "Barsetti", new DateTime(2000, 1, 1), "Turin", "Italy" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "Enrica", "D'onofrio", new DateTime(1961, 9, 2), "Rome", "Italy" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "Freja", "Otto", new DateTime(1986, 12, 1), "Berlin", "Germany" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "Yves", "Roux", new DateTime(1957, 1, 31), "Marseille", "France" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "John", "Smith", new DateTime(1925, 5, 24), "Boston", "USA" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "Edu", "Mendes", new DateTime(1996, 2, 29), "Porto", "Portugal" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "Filipe", "Souza", new DateTime(1988, 5, 27), "Porto", "Portugal" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "Jane", "Smith", new DateTime(1964, 7, 26), "Los Angeles", "USA" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "Henrique", "Gomes", new DateTime(1969, 4, 11), "Lisbon", "Portugal" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "Gabriela", "Jager", new DateTime(1992, 6, 13), "Bremen", "Germany" };

            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr.ItemArray = new object[] { "Dante", "Silvestri", new DateTime(1993, 10, 21), "Parma", "Italy" };

            dt.Rows.Add(dr);

            c1FlexGrid1.DataSource = dt;
        }
    }
}
