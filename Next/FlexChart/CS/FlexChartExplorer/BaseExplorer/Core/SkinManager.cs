using BaseExplorer.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseExplorer.Core
{
    public static class SkinManager
    {
        public static Color PrimaryColor = ColorTranslator.FromHtml("#132c55");
        public static Color PrimaryDarkColor = ColorTranslator.FromHtml("#00002c");
        public static Color PrimaryLightColor = ColorTranslator.FromHtml("#435482");
        public static Color SecondaryColor = ColorTranslator.FromHtml("#ffffff");
        public static Color SecondaryDarkColor = ColorTranslator.FromHtml("#ffffff");
        public static Color SecondaryLightColor = ColorTranslator.FromHtml("#ffffff");
        public static Color PrimaryTextColor = ColorTranslator.FromHtml("#ffffff");
        public static Color SecondaryTextColor = ColorTranslator.FromHtml("#000000");
        public static Color SurfaceColor = ColorTranslator.FromHtml("#EEF7F6");
        public static Color PrimaryBackColor = ColorTranslator.FromHtml("#ffffff");
        public static Color SecondaryBackColor = ColorTranslator.FromHtml("#ffffff");
    }

    public class FontManager
    {
        public static Font SideBarStatusFont = new System.Drawing.Font("Segoe UI",8);
    }
}
