// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.
using C1.Win.Input;
using C1.Win.Themes;
namespace ScrollBarAnnotations.Manager
{
    internal static class ThemeManager
    {

        internal static void InitializeTheme(C1ComboBox themeComboBox)
        {
            // Load all available themes into the ComboBox
            var themes = C1ThemeController.GetThemes();
            themeComboBox.Items.Add("(none)");

            themeComboBox.Items.AddRange(themes);

            // Set default theme to "ExpressionLight"
            themeComboBox.SelectedIndex = themeComboBox.Items.Select(x => x.DisplayText).ToList().IndexOf("ExpressionLight");
            themeComboBox.Text = themeComboBox.SelectedItem.DisplayText;
        }

        /// <summary>
        /// Applies the selected theme (from the given ComboBox) 
        /// to the specified control and its child controls.
        /// </summary>
        /// <param name="flexSample">The parent control to which the theme will be applied.</param>
        /// <param name="themeComboBox">The ComboBox containing available themes.</param>
        internal static void ApplyTheme(Control flexSample, C1ComboBox themeComboBox)
        {
            C1ThemeController.ApplyThemeToControlTree(
                flexSample,
                C1ThemeController.GetThemeByName((string)themeComboBox.SelectedItem.Value, false),
                applyThemeToSubTree: null,
                true
            );
        }
    }
}
