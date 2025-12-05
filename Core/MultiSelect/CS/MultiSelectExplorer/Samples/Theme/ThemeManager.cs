// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using C1.Win.Themes;
using System.Windows.Forms;

namespace MultiSelectExplorer.Samples.Theme
{
    /// <summary>
    /// Provides functionality for managing and applying ComponentOne themes
    /// to WinForms controls.
    /// </summary>
    public static class ThemeManager
    {
        public static void ApplyTheme(Control target, string themeName)
        {
            if (string.IsNullOrWhiteSpace(themeName))
                return;

            var theme = C1ThemeController.GetThemeByName(themeName, false);

            C1ThemeController.ApplyThemeToControlTree(target, theme);
        }

        public static string[] GetAvailableThemes()
        {
            return C1ThemeController.GetThemes();
        }
    }
}
