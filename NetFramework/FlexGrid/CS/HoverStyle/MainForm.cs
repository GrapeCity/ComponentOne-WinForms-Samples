using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.FlexGrid;
using C1.Win.Themes;
using C1.Win.Ribbon;

namespace HoverStyle
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

            Enum.GetValues(typeof(HoverMode)).Cast<HoverMode>().ToList().ForEach(x => rbHoverMode.Items.Add(x.ToString()));
            Enum.GetValues(typeof(SelectionModeEnum)).Cast<SelectionModeEnum>().ToList().ForEach(x => rbSelectMode.Items.Add(x.ToString()));
            rbHoverMode.SelectedIndex = 3;
            rbSelectMode.SelectedIndex = 0;

            c1FlexGrid1.Styles.Hover.BackColor = rbHoverColor.Color;

            InitData();
        }

        private void InitData()
        {
            var dataAdapter = new OleDbDataAdapter("select * from orders", GetConnectionString());
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            c1FlexGrid1.DataSource = dataTable;
        }

        private string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
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
            c1FlexGrid1.Styles.Hover.BackColor = rbHoverColor.Color;
        }

        #endregion

        private void rbHoverMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.HoverMode = (HoverMode)Enum.Parse(typeof(HoverMode), rbHoverMode.Text);
        }

        private void rbSelectMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.SelectionMode = (SelectionModeEnum)Enum.Parse(typeof(SelectionModeEnum), rbSelectMode.Text);
        }

        private void rbHoverColor_SelectedColorChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.Styles.Hover.BackColor = rbHoverColor.Color;
        }
    }
}
