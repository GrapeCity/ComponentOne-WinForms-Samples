using C1.Win.FlexGrid;
using C1.Win.Ribbon;
using C1.Win.Themes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RowsSelected
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitThemes();
            c1FlexGridData.AutoResize = true;
            LoadData();
            foreach (SelectionModeEnum mode in Enum.GetValues(typeof(SelectionModeEnum)))
            {
                ribbonComboBoxSelMode.Items.Add(mode.ToString());
            }
            ribbonComboBoxSelMode.SelectedIndex = 0;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }

        #region Themes

        private void InitThemes()
        {
            IEnumerable<string> themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office365"));
            foreach (string theme in themes)
                ribbonComboBoxThemes.Items.Add(theme);
            ribbonComboBoxThemes.SelectedIndex = ribbonComboBoxThemes.Items.IndexOf("Office365Green");
        }

        private void ribbonComboBoxThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = ribbonComboBoxThemes.SelectedItem.Text;
        }

        #endregion

        private void LoadData()
        {
            string conn = GetConnectionString();
            var sql = "SELECT ( SELECT COUNT(*) FROM customers AS T2 WHERE T2.CustomerId <= T1.CustomerId ) AS RowNumber, T1.* FROM customers AS T1 ORDER BY T1.CustomerId;";
            var da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
            var dt = new DataTable();
            da.Fill(dt);
            c1FlexGridData.DataSource = dt;
        }

        private string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            var conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        private void c1FlexGridData_AfterSelChange(object sender, RangeEventArgs e)
        {
            c1FlexGridRowsSelected.BeginUpdate();
            c1FlexGridRowsSelected.Rows.Count = 1;
            foreach (Row row in c1FlexGridData.Rows.Selected)
            {
                c1FlexGridRowsSelected.AddItem($"row: {row.Index}");
            }
            c1FlexGridRowsSelected.EndUpdate();
        }

        private void ribbonComboBoxSelMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1FlexGridData.SelectionMode = (SelectionModeEnum)Enum.Parse(typeof(SelectionModeEnum), ribbonComboBoxSelMode.Text);
        }
    }
}
