using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Themes
{
    public partial class Themes3 : C1DemoForm
    {
        public Themes3()
        {
            InitializeComponent();
            this.ribbonComboBox1.DropDownStyle = C1.Win.C1Ribbon.RibbonComboBoxStyle.DropDownList;
            // populate combobox with all available themes
            var themes = C1.Win.C1Themes.C1ThemeController.GetThemes();
            foreach (string theme in themes)
                this.ribbonComboBox1.Items.Add(theme);
        }

        private void ribbonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.SetTheme(c1Ribbon1, ribbonComboBox1.SelectedItem.Text);
        }
    }
}
