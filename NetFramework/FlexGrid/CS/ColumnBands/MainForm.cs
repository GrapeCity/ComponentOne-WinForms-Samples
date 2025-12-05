using C1.Win.FlexGrid;
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

namespace ColumnBands
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

            columnBandsUserControl1.Init();

            Enum.GetValues(typeof(BandsColumnsRelation))
                    .Cast<BandsColumnsRelation>().ToList().ForEach(x =>
                    {
                        rbBandsColumnsRelation.Items.Add(x.ToString());
                    });
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office365"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
            cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365Green");
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;

            c1ThemeController1.SetTheme(columnBandsUserControl1.c1FlexGrid1, c1ThemeController1.Theme);
        }

        #endregion

        private void rbCreateBands_Click(object sender, EventArgs e)
        {
            columnBandsUserControl1.CreateBands();
        }

        private void rbClearBands_Click(object sender, EventArgs e)
        {
            columnBandsUserControl1.ClearColumnBands();
        }

        private void rbBandsColumnsRelation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var value = (BandsColumnsRelation)Enum.Parse(typeof(BandsColumnsRelation), rbBandsColumnsRelation.Text);
                columnBandsUserControl1.SetBandsColumnsRelation(value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
