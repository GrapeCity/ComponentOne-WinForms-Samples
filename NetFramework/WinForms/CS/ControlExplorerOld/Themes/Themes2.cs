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
    public partial class Themes2 : C1DemoForm
    {
        public Themes2()
        {
            InitializeComponent();
            // populate combobox with all available themes
            this.comboBox1.Items.AddRange(C1.Win.C1Themes.C1ThemeController.GetThemes());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                // Set theme on the theme controller:
                this.c1ThemeController1.Theme = this.comboBox1.SelectedItem.ToString();
                // ...and apply it to all themable controls (this will override any control-specific theme settings):
                Action<Control> setTheme = null;
                setTheme = (c) =>
                {
                    if (C1.Win.C1Themes.C1ThemeController.IsObjectThemeable(c))
                        this.c1ThemeController1.SetTheme(c, this.c1ThemeController1.Theme);
                    foreach (Control cc in c.Controls)
                        setTheme(cc);
                };
                setTheme(this);
            }
        }
    }
}
