using C1.Win.Ribbon;
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

namespace FilterSummary
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            cmbTheme.SelectedIndex = 2;            
        }

        private void CmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
        }

        private void CbAutoApply_CheckedChanged(object sender, EventArgs e)
        {
            c1DataFilter1.AutoApply = cbAutoApply.Checked;
        }

        private static DataTable GetDataTableCars()
        {
            string rs = "select * from Cars;";
            string cn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(rs, cn);
            DataTable dt = new DataTable("Cars");
            da.Fill(dt);
            return dt;
        }

        private static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {            
            var ds = new DataSet();
            ds.Tables.Add(GetDataTableCars());
            var bs = new BindingSource(ds, "Cars");
            c1FlexGrid1.DataSource = bs;
            c1DataFilter1.DataSource = bs;

            bs = new BindingSource(ds, "Cars");
            var cf = c1DataFilter1.Filters[0] as C1.Win.DataFilter.ChecklistFilter;
            cf.ItemsSource = bs;
            cf.SelectAll();

            bs = new BindingSource(ds, "Cars");
            cf = c1DataFilter1.Filters[1] as C1.Win.DataFilter.ChecklistFilter;
            cf.ItemsSource = bs;
            cf.SelectAll();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            c1DataFilter1.ApplyFilter();
        }
    }
}
