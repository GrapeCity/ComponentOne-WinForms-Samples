using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1Themes;

namespace ThemesEvents
{
    public partial class Form1 : Form
    {
        private static readonly Font ApplicationThemeFont = new Font("Tahoma", 14);

        public Form1()
        {
            InitializeComponent();
            ApplyDefaultTheme();
        }

        private void ApplyDefaultTheme()
        {
            SetApplicationTheme("Office365White");
        }

        private void SetApplicationTheme(string themeName)
        {
            lblApplicationTheme.Value = themeName;
            C1ThemeController.ApplicationTheme = themeName;
        }

        private void ctdbgThemes_Resize(object sender, EventArgs e)
        {
            ctdbgThemes.Splits[0].DisplayColumns[0].Width = ctdbgThemes.ClientSize.Width - ctdbgThemes.Splits[0].RecordSelectorWidth - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //
            ctdbgThemes_Resize(null, EventArgs.Empty);

            //
            ctdbgThemes.SetDataBinding();
            string[] themes = C1ThemeController.GetThemes();

            foreach (string s in themes)
                ctdbgThemes.AddRow(s);

            //
            lblApplicationTheme.Value = C1ThemeController.ApplicationTheme;
        }

        private void ctdbgThemes_DoubleClick(object sender, EventArgs e)
        {
            if (ctdbgThemes.Row >= 0 && ctdbgThemes.Row < ctdbgThemes.Rows.Count)
            {
                var dr = ctdbgThemes.GetDataBoundItem(ctdbgThemes.Row) as DataRowView;
                if(dr != null)
                {
                    SetApplicationTheme((string)dr.Row.ItemArray[0]);
                }
            }                
        }

        private void c1ThemeController1_ObjectThemeApplied(C1.Win.C1Themes.C1ThemeController sender, C1.Win.C1Themes.ObjectThemeEventArgs e)
        {
            if (e.Object == lblApplicationTheme)
            {
                lblApplicationTheme.Font = ApplicationThemeFont;
            }

            if (e.Object == ctdbgThemes)
            {
                ctdbgThemes.EvenRowStyle.BackColor = Color.Red;
                ctdbgThemes.EvenRowStyle.BackColor2 = Color.White;
                ctdbgThemes.EvenRowStyle.GradientMode = C1.Win.C1TrueDBGrid.GradientModeEnum.ForwardDiagonal;
            }
        }
    }
}
