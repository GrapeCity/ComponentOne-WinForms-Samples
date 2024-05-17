using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Themes;

namespace InputExplorer.Samples
{
    public partial class Themes : UserControl
    {
        public Themes()
        {
            InitializeComponent();
            cmbThemes.SelectedIndex = cmbThemes.Items.Select(x => 
                x.DisplayText).ToList().IndexOf("Office365White");
        }

        private void Themes_Load(object sender, EventArgs e)
        {
             cmbThemes.Items.AddRangeValues(C1ThemeController.GetThemes());
        }

        private void cmbThemes_SelectedItemChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbThemes.SelectedItem.Value.ToString();
        }
    }
}
