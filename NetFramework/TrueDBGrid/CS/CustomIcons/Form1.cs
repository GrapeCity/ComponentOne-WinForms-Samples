using C1.Win.C1Themes;
using C1.Win.C1TrueDBGrid;
using C1.Win.Ribbon;
using System;
using System.Data;
using System.Linq;

namespace CustomIcons
{
    public partial class Form1 : C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitThemes();

            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Flag", typeof(bool));
            for (int i = 0; i < 100; i++)
                dt.Rows.Add(new object[] { i, i % 2 == 0 });
            c1TrueDBGrid1.DataSource = dt;

            cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365White");
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office365"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
            if (c1Ribbon1.RibbonStyle.IsDarkTheme)
            {
                c1TrueDBGrid1.Glyphs[GlyphType.CheckBoxChecked] = Properties.Resources.CheckedIconDark;
                c1TrueDBGrid1.Glyphs[GlyphType.CheckBoxUnchecked] = Properties.Resources.UncheckedIconDark;
                c1TrueDBGrid1.Glyphs[GlyphType.CheckBoxIndeterminate] = Properties.Resources.IndeterminateIconDark;
            }
            else
            {
                c1TrueDBGrid1.Glyphs[GlyphType.CheckBoxChecked] = Properties.Resources.CheckedIcon;
                c1TrueDBGrid1.Glyphs[GlyphType.CheckBoxUnchecked] = Properties.Resources.UncheckedIcon;
                c1TrueDBGrid1.Glyphs[GlyphType.CheckBoxIndeterminate] = Properties.Resources.IndeterminateIcon;
            }

            c1TrueDBGrid1.Splits[0].DisplayColumns[1].Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center;
            c1TrueDBGrid1.Splits[0].DisplayColumns[1].Style.VerticalAlignment = C1.Win.C1TrueDBGrid.AlignVertEnum.Center;
        }

        #endregion
    }
}
