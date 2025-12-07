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
    public partial class Themes1 : C1DemoForm
    {
        public Themes1()
        {
            IsThemeable = false;
            InitializeComponent();
            // populate combobox with all available themes
            this.c1ComboBox2.Items.AddRange(C1.Win.Themes.C1ThemeController.GetThemes());
            this.c1ComboBox2.SelectedItem = "Material";
        }

        private void Themes1_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'c1DemoDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.c1DemoDataSet.Orders);
            // This line of code loads data into the 'c1DemoDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.c1DemoDataSet.Employees);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
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
    }
}
