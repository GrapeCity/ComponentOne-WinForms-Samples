using C1.Win.Themes;
using C1.Win.TrueDBGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueDBGridExplorer.Samples
{
    public partial class CustomIcons : UserControl
    {
        public CustomIcons()
        {
            InitializeComponent();
        }

        private void CustomIcons_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Flag", typeof(bool));
            for (int i = 0; i < 100; i++)
                dt.Rows.Add(new object[] { i, i % 2 == 0 });
            c1TrueDBGrid1.DataSource = dt;

            InitThemes();
            cmbTheme.SelectedIndex = 0;
        }

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office2016"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.DisplayText;
            if (c1ThemeController1.Theme.Contains("Black"))
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
            c1TrueDBGrid1.Splits[0].DisplayColumns[1].Style.HorizontalAlignment = C1.Win.TrueDBGrid.AlignHorzEnum.Center;
            c1TrueDBGrid1.Splits[0].DisplayColumns[1].Style.VerticalAlignment = C1.Win.TrueDBGrid.AlignVertEnum.Center;
        }
    }
}
