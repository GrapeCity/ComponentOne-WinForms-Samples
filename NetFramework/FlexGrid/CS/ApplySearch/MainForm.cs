using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Themes;
using C1.Win.Ribbon;

namespace ApplySearch
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitThemes();

            c1FlexGridSearchPanel1.SetC1FlexGridSearchPanel(c1FlexGrid1, c1FlexGridSearchPanel1);
            foreach (var searchHighlightMode in (SearchHighlightMode[])Enum.GetValues(typeof(SearchHighlightMode)))
            {
                rcbHighlightMode.Items.Add(searchHighlightMode.ToString());
            }
            rcbHighlightMode.SelectedIndex = 1;
            rcbSearchFilter.SelectedIndex = 0;
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            var conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            var dataAdapter = new OleDbDataAdapter("select * from orders", string.Format(conn, path));
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            c1FlexGrid1.DataSource = dataTable;
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office365"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
            cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365Green");
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
        }

        #endregion

        private void rcbHighlightMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGridSearchPanel1.HighlightSearchResultsMode = (SearchHighlightMode)rcbHighlightMode.SelectedIndex;
        }

        private void rcbSearchTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGridSearchPanel1.Text = rcbSearchTemplates.Text;
        }

        private void rcbSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGridSearchPanel1.FilterSearchResults = rcbSearchFilter.SelectedIndex == 0 ? true : false;
        }
    }
}
