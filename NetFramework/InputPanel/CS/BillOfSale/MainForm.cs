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

namespace BillOfSale
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

            BindingList<SaleInfo> datalist = new BindingList<SaleInfo>();

            Transactor t1 = new Transactor("Alice Smit", "Wonderland", "Tinytown", "S1", "89182", "222222", "987654321021", "ABC", new DateTime(2021,4,6));
            Transactor t2 = new Transactor("Bob Bill", "Oz", "Largetown", "S2", "98064", "333333", "123456789012", "Technology inc", new DateTime(2021,4,2));
            datalist.Add(new SaleInfo(new DateTime(2021,4,6), t1, t2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin vel tortor dolor. Fusce vulputate facilisis tortor commodo luctus. Praesent ligula ante, convallis eget lacus ut, ultrices semper enim. Morbi ac scelerisque metus. Integer finibus malesuada fermentum. Donec pulvinar nisl nec felis ornare, eu egestas augue molestie. Donec sed dui sit amet enim pulvinar blandit. In ac dui bibendum, maximus diam eu, tempus nulla. Aliquam pellentesque viverra felis hendrerit dictum. Sed pharetra nisl non leo tincidunt feugiat.",
                300, "cash"));
            billOfSaleBindingSource.DataSource = datalist[0];

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitThemes();
            
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office365"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
            cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365White");
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
            
        }

        #endregion

       
    }

    
}
