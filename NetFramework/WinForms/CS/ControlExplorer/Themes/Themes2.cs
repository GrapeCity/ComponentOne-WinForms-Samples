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
            IsThemeable = false;
            InitializeComponent();

            // populate combobox with all available themes
            this.c1ComboBox2.Items.AddRange(C1.Win.Themes.C1ThemeController.GetThemes());
            this.c1ComboBox2.SelectedItem = "Material";
        }

        private void c1ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Explorer.LockWindowUpdate(Handle);

                // Set theme on the theme controller:
                this.c1ThemeController1.Theme = this.c1ComboBox2.SelectedItem.ToString();
                // ...and apply it to all themable controls (this will override any control-specific theme settings):
                Action<Control> setTheme = null;
                setTheme = (c) =>
                {
                    if (C1.Win.Themes.C1ThemeController.IsObjectThemeable(c))
                        this.c1ThemeController1.SetTheme(c, this.c1ThemeController1.Theme);
                    foreach (Control cc in c.Controls)
                        setTheme(cc);
                };
                setTheme(this);
            }
            finally
            {
                Explorer.LockWindowUpdate(IntPtr.Zero);
            }
        }
    }
}
