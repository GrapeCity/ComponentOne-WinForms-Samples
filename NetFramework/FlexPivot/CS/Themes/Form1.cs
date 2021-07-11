using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using C1.Win.C1Themes;

namespace Themes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // designer support
            InitializeComponent();

            // fill c1 predefined themes
            foreach (string theme in C1ThemeController.GetThemes())
                cbTheme.Items.Add(theme);
            cbTheme.SelectedIndexChanged += cbTheme_SelectedIndexChanged;

            // connect to sample data
            var da = new OleDbDataAdapter(Properties.Resources.sql, GetConnectionString());
            var dt = new DataTable("NorthWind Sales Data");
            da.Fill(dt);

            // assign data to C1FlexPivotPage control
            _c1FlexPivotPage.DataSource = dt;

            // set default view
            var fp = _c1FlexPivotPage.PivotEngine;
            fp.ValueFields.MaxItems = 3;
            fp.BeginUpdate();
            fp.RowFields.Add("Country");
            fp.ColumnFields.Add("Product");
            fp.ValueFields.Add("Sales");
            fp.EndUpdate();
        }

        // apply theme to the FlexPivot page
        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            C1Theme theme = C1ThemeController.GetThemeByName(cbTheme.Text, false);
            if (theme != null)
                C1ThemeController.ApplyThemeToObject(_c1FlexPivotPage, theme);
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
