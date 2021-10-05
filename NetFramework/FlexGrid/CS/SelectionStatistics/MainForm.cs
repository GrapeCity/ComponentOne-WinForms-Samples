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

namespace SelectionStatistics
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
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office2016"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
            cmbTheme.SelectedIndex = 3;
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
            c1ThemeController1.SetTheme(selectionStatisticsControl1.c1FlexGrid1, c1ThemeController1.Theme);
            selectionStatisticsControl1.tslSelectionStatistics.Font = selectionStatisticsControl1.c1FlexGrid1.Font;
            selectionStatisticsControl1.tsSelectionStatistics.BackColor = selectionStatisticsControl1.c1FlexGrid1.BackColor;
        }

        #endregion
    }
}
