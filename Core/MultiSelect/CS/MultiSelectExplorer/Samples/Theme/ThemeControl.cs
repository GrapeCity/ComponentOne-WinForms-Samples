// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using C1.Win.Input;
using MultiSelectExplorer.Properties;
using MultiSelectExplorer.Samples.Theme;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MultiSelectExplorer.Samples
{
    public partial class ThemeControl : UserControl
    {
        private C1Button _selectedButton;

        public ThemeControl()
        {
            InitializeComponent();
            InitializeLocalizedText();
            InitializeMultiSelect();
            LoadThemeButtons();
        }

        private void InitializeLocalizedText()
        {
            lblMultiSelectTitle.Text = Resources.ThemeMultiSelectTitle;
            lblThemeSelectionTitle.Text = Resources.ThemeSelectionTitle;
        }

        private void InitializeMultiSelect()
        {
            _multiSelect.Items.AddRange(Resources.ProgrammingLanguages.Split(','));
            _multiSelect.AutoOpen = true;
        }

        private void LoadThemeButtons()
        {
            var themes = ThemeManager.GetAvailableThemes().ToList();
            themes.Insert(0, "Default");

            foreach (var themeName in themes)
            {
                var btn = ButtonFactory.CreateThemeButton(themeName, ThemeButton_Click);
                flowLayoutPanel1.Controls.Add(btn);

                if (themeName == "Default")
                    HighlightSelectedButton(btn);
            }
        }

        private void ThemeButton_Click(object sender, EventArgs e)
        {
            if (sender is not C1Button btn) return;

            string themeName = btn.Tag?.ToString();
            if (string.IsNullOrEmpty(themeName)) return;

            ThemeManager.ApplyTheme(_multiSelect, themeName);

            _multiSelect.Focus();

            HighlightSelectedButton(btn);
        }

        private void HighlightSelectedButton(C1Button btn)
        {
            ResetButtonAppearance(_selectedButton);

            btn.BackColor = Color.FromArgb(30, 144, 235);
            btn.ForeColor = Color.White;

            _selectedButton = btn;
        }

        private static void ResetButtonAppearance(C1Button btn)
        {
            if (btn == null) return;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

    }
}