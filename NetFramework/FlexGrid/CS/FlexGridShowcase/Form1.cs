using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexGridShowcase
{

    // todo:
    // * use Ribbon & RibbonForm
    // * follow mock up https://xd.adobe.com/view/39af2b73-85cd-41ce-4b18-82821e0eb4f4-4f9e/
    // * add licensing
    // * add code comments and readme
    // * data taken from here: $/Rhino/Main/Wijmo5Mvc/Samples/CS/ASPNETCore/MvcExplorer/src/MvcExplorer/Models, see whether we need something more
    // ** - should we use CustomerSale instead?
    // * if we don't have something from mock up for the first version, write some todo doc for the future
    // * ask someone to check it on HDPI machine

    public partial class Form1 : C1.Win.Ribbon.C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            cbDataSize.SelectedIndex = 0;
            InitThemes();
        }

        #region ** Data
        private void cbDataSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            // todo: 
            // * add more options
            // * do something with different column count?
            int rows = cbDataSize.SelectedIndex == 0 ? 10 : 100;
            if (c1FlexGrid1.DataSource == null || ((IList<Sale>)c1FlexGrid1.DataSource).Count != rows)
            {
                var list = Sale.GetData(rows);

                // bind the grid 
                c1FlexGrid1.DataSource = list;
            }
        }
        #endregion

        #region ** Themes

        private void InitThemes()
        {
            var themes = C1.Win.C1Themes.C1ThemeController.GetThemes();
            foreach (var s in themes)
            {
                if (s.Contains("Office365") || s.Contains("Material"))
                    cbTheme.Items.Add(s);
            }
            cbTheme.SelectedIndex = cbTheme.Items.IndexOf("Office365Green");
        }

        private void cbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            C1.Win.C1Themes.C1ThemeController.ApplicationTheme = cbTheme.SelectedItem.Text;
        }

        #endregion
    }
}
