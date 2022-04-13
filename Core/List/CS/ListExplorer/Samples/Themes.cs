using ListExplorer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListExplorer.Samples
{
    public partial class Themes : UserControl
    {
        public Themes()
        {
            InitializeComponent();
        }

        private void Themes_Load(object sender, EventArgs e)
        {            
            cmbThemePicker.ColumnHeaders = false;
            cmbThemePicker.ExtendRightColumn = true;
            cmbThemePicker.DataSource = C1.Win.Themes.C1ThemeController.GetThemes();

            string sql = @"
                SELECT Distinct 
                    *
	                FROM Products;";

            var bindingSource = new BindingSource()
            {
                DataSource = DataSource.GetRows(sql)
            };
            c1List1.DataSource = bindingSource;
            c1Combo1.DataSource = bindingSource;            
        }

        private void cmbThemePicker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbThemePicker.Text;
        }
    }
}
