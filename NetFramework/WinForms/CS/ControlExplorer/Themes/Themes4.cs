using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControlExplorer.Themes
{
    public partial class Themes4 : C1DemoForm
    {
        public Themes4()
        {
            InitializeComponent();
        }

        private void Themes4_Load(object sender, EventArgs e)
        {
            c1ThemePicker1.SelectedIndex = 0; // initially selected theme is "BeigeOne"
            c1ComboBox1.SelectedIndex = 0;    // c1ThemePicker1 property: ShowDefault = false
        }

        private void c1TextBox1_TextChanged(object sender, EventArgs e)
        {
            // apply regular expression as theme name filter
            c1ThemePicker1.Filter = c1TextBox1.Text.Trim();
        }

        private void c1ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c1ComboBox1.SelectedIndex == -1)
            {
                return;
            }

            // when "ShowDefault" selected
            var selectedItem = c1ComboBox1.SelectedItem.ToString();

            if (selectedItem == "true")
            {
                c1ThemePicker1.ShowDefault = true;
            }
            else
            {
                c1ThemePicker1.ShowDefault = false;
            }
        }
    }
}