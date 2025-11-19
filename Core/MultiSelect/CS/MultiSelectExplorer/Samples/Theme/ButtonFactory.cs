// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using C1.Win.Input;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MultiSelectExplorer.Samples.Theme
{
    /// <summary>
    /// Provides helper methods for creating standardized <see cref="C1Button"/> controls.
    /// </summary>
    public static class ButtonFactory
    {
        public static C1Button CreateThemeButton(string themeName, EventHandler clickHandler)
        {
            var btn = new C1Button
            {
                Text = themeName,
                Tag = themeName,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = Color.White,
                ForeColor = Color.Black,
                Font = new Font("Segoe UI", 9F),
                Margin = new Padding(5),
                Padding = new Padding(8, 4, 8, 4),
            };

            btn.Styles.Corners = new C1.Framework.Corners(1, 1, 1, 1);
            btn.Styles.Hot.BackColor = Color.FromArgb(30, 144, 235);
            btn.Styles.Hot.ForeColor = Color.White;
            btn.Styles.HotPressed.BackColor = Color.FromArgb(30, 144, 235);
            btn.Styles.HotPressed.BorderColor = Color.FromArgb(30, 144, 235);
            btn.Styles.HotPressed.ForeColor = Color.White;

            if (clickHandler != null)
            {
                btn.Click -= clickHandler;
                btn.Click += clickHandler;
            }
                
            return btn;
        }
    }
}
