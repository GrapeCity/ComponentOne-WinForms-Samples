using C1.Win.C1Themes;
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

namespace DividingQrCode
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitThemes();
            foreach(var control in sample1.ThemeableControls)
                c1ThemeController1.SetTheme(control, "(default)");
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office2016"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;            
        }

        #endregion
    }
}
