using C1.Win.FlexGrid;
using C1.Win.Themes;
using C1.Win.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColumnPicker
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1NWindDataSet.Orders' table. You can move, or remove it, as needed.
            var conn = $@"provider=microsoft.jet.oledb.4.0;data source={Environment.GetFolderPath(Environment.SpecialFolder.Personal)}\ComponentOne Samples\Common\c1nwind.mdb;";
            ordersTableAdapter.Connection.ConnectionString = conn;
            this.ordersTableAdapter.Fill(this.c1NWindDataSet.Orders);
            InitThemes();
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

        private void rbCreateBands_Click(object sender, EventArgs e)
        {
            if (c1FlexGridBandedView1.FlexGrid != null) return;
            c1FlexGrid1.BeginUpdate();
            c1FlexGridBandedView1.FlexGrid = c1FlexGrid1;
            c1FlexGridBandedView1.BandsColumnsRelation = BandsColumnsRelation.BandsBeforeColumns;
            c1FlexGridBandedView1.BeginUpdate();
            c1FlexGridBandedView1.Bands.Clear();
            var bands = c1FlexGridBandedView1.Bands;
            var b1 = bands.Add(c1FlexGrid1.Cols["OrderID"]);
            b1.Caption = "Order";
            var b2 = b1.Children.Add(c1FlexGrid1.Cols["OrderDate"]);
            b2.Caption = "Date";
            var b3 = b1.Children.Add(c1FlexGrid1.Cols["CustomerID"]);
            b3.Caption = "Customer";
            c1FlexGridBandedView1.EndUpdate();
            c1FlexGrid1.EndUpdate();
        }

        private void rbRemoveBands_Click(object sender, EventArgs e)
        {
            if (c1FlexGridBandedView1.FlexGrid == null) return;
            c1FlexGrid1.BeginUpdate();
            c1FlexGridBandedView1.FlexGrid = null;
            c1FlexGridBandedView1.BeginUpdate();
            c1FlexGridBandedView1.Bands.Clear();
            c1FlexGridBandedView1.EndUpdate();
            c1FlexGrid1.EndUpdate();
        }
    }
}
