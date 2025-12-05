using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.Win.Themes;

namespace ThemeManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ApplyDefaultTheme();
        }

        private void ApplyDefaultTheme()
        {
            SetApplicationTheme("Office365White");
        }

        /// <summary>
        /// Sets the specified theme as the application theme - i.e. the theme used by default
        /// by all C1ThemeControllers in the application.
        /// </summary>
        /// <param name="themeName">The name of the theme.</param>
        private void SetApplicationTheme(string themeName)
        {
            tbApplicationTheme.Value = themeName;
            C1ThemeController.ApplicationTheme = themeName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create another form to show that changing ApplicationTheme automatically
            // propagages to all form in an application on which there is a C1ThemeController:
            var f2 = new Form2();
            f2.SetDesktopLocation(this.DesktopBounds.Right + 10, this.DesktopBounds.Top);
            f2.Show();

            //
            ctdbgThemes_Resize(null, EventArgs.Empty);

            // Get the list of available themes and populate the grid with them:
            ctdbgThemes.SetDataBinding();
            string[] themes = C1ThemeController.GetThemes();
            foreach (string s in themes)
                ctdbgThemes.AddRow(s);

            //
            tbApplicationTheme.Value = C1ThemeController.ApplicationTheme;
        }

        private void ctdbgThemes_Resize(object sender, EventArgs e)
        {
            ctdbgThemes.Splits[0].DisplayColumns[0].Width = ctdbgThemes.ClientSize.Width - ctdbgThemes.Splits[0].RecordSelectorWidth - 1;
        }

        private void ctdbgThemes_DoubleClick(object sender, EventArgs e)
        {
            if (ctdbgThemes.Row >= 0 && ctdbgThemes.Row < ctdbgThemes.Rows.Count)
                SetApplicationTheme((string)ctdbgThemes.Rows[ctdbgThemes.Row][0]);
        }

        private void btnSetAsApplicationTheme_Click(object sender, EventArgs e)
        {
            if (ctdbgThemes.Row >= 0 && ctdbgThemes.Row < ctdbgThemes.Rows.Count)
                SetApplicationTheme((string)ctdbgThemes.Rows[ctdbgThemes.Row][0]);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    string theme = C1ThemeController.RegisterTheme(openFileDialog1.FileName);
                    ctdbgThemes.AddRow(theme);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Cannot add theme, error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (ctdbgThemes.Row >= 0 && ctdbgThemes.Row < ctdbgThemes.Rows.Count)
            {
                string theme = (string)ctdbgThemes.Rows[ctdbgThemes.Row][0];
                try
                {
                    C1ThemeController.UnregisterTheme(theme);
                    ctdbgThemes.Rows.RemoveAt(ctdbgThemes.Row);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Cannot remove theme, error:\r\n{0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
