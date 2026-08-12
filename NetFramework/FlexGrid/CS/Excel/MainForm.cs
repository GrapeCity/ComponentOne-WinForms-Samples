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

namespace Excel
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitThemes();
            c1FlexGrid1.AutoResize = true;
            LoadData();
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

        void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            string conn = GetConnectionString();
            var sql = "select * from customers";
            var da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
            var dt = new DataTable();
            da.Fill(dt);
            c1FlexGrid1.DataSource = dt;
            //add footer
            var footer = new FooterDescription();
            var agg = new AggregateDefinition()
            {
                Aggregate = AggregateEnum.Count,
                Column = 1
            };
            footer.Aggregates.Add(agg);
            c1FlexGrid1.Footers.Descriptions.Add(footer);
            c1FlexGrid1.Footers.Fixed = true;
        }

        void btnMultiSheet_Click(object sender, EventArgs e)
        {
            // choose file
            string fileName;
            using (var dlg = new SaveFileDialog())
            {
                dlg.DefaultExt = "xls";
                dlg.FileName = "*.xls";
                if (dlg.ShowDialog() != DialogResult.OK)
                    return;
                fileName = dlg.FileName;
            }
            // delete file if it's already there
            if (File.Exists(fileName))
                File.Delete(fileName);

            // prepare to load data from database
            string mdbfile = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common\c1nwind.mdb";
            var conn = @"provider=microsoft.jet.oledb.4.0;data source=" + mdbfile + ";";
            System.Data.OleDb.OleDbDataAdapter da;

            // save several sheets
            string[] tables = "Categories|Products|Employees|Customers|Orders".Split('|');
            foreach (string table in tables)
            {
                // load data into grid
                string sql = "select * from " + table;
                da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
                var dt = new DataTable();
                da.Fill(dt);
                c1FlexGrid1.DataSource = dt;
                c1FlexGrid1.Update();

                // save into a sheet
                c1FlexGrid1.SaveExcel(fileName, table, FileFlags.VisibleOnly | FileFlags.IncludeFixedCells);
            }
        }

        void btnImportSheet_Click(object sender, EventArgs e)
        {
            //Diplay custom ImportOptions dialog first to select FileFlags
            FileFlags flags;
            using (var options = new ImportOptions())
            {
                options.c1ThemeController1.Theme = c1ThemeController1.Theme;
                if (options.ShowDialog() != DialogResult.OK)
                    return;
                flags = options.Flags;
            }
            string fileName;
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel (*.xls, *.xlsx)|*.xls;*.xlsx";
                if (ofd.ShowDialog() != DialogResult.OK)
                    return;
                fileName = ofd.FileName;
            }
            try
            {
                //Load selected Excel File
                c1FlexGrid1.DataSource = null;
                c1FlexGrid1.LoadExcel(fileName, flags);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to import Excel file: " + ex.Message);
            }
        }

        void btnExportSheet_Click(object sender, EventArgs e)
        {
            //This function saves and launches Excel file from FlexGrid
            //Diplay custom ExportOptions dialog first to select FileFlags
            FileFlags flags;
            using (var options = new ExportOptions())
            {
                options.c1ThemeController1.Theme = c1ThemeController1.Theme;
                if (options.ShowDialog() != DialogResult.OK)
                    return;
                flags = options.Flags;
            }
            string fileName;
            using (var sfd = new SaveFileDialog())
            {
                if (flags.ToString().Contains("OpenXml"))
                    sfd.Filter = "Excel OpenXml (*.xlsx)|*.xlsx";
                else
                    sfd.Filter = "Excel (*.xls)|*.xls";

                if (sfd.ShowDialog() != DialogResult.OK)
                    return;
                fileName = sfd.FileName;
            }
            c1FlexGrid1.SaveExcel(fileName, flags);
            System.Diagnostics.Process.Start(fileName);
        }

        private string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            var conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
