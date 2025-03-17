using BaseExplorer.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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

        public static Color BackColor = Color.FromArgb(243, 242, 242);
        public static Color HighLightBackColor = Color.FromArgb(233, 232, 232);
        public static Color Office365Grey = Color.FromArgb(241, 240, 241);
        public static Color Office365Black = Color.FromArgb(10, 10, 10);
        public static Color Office365LightBlack = Color.FromArgb(39, 38, 38);
        public static Color LightGray = ColorTranslator.FromHtml("#e4e5e4");
        public static Color DarkGray = ColorTranslator.FromHtml("#cdcdcc");
        public static Color LightBackColor = Color.FromArgb(249, 248, 248);
        public static Color Indicator = Color.FromArgb(1, 94, 184);
        public static Color BlackBackColor = Color.FromArgb(33,32,33);
        public static Color BlackHighLightColor = Color.FromArgb(45, 44, 44);
    }

    public class FontManager
    {
        public static Font SideBarStatusFont = new System.Drawing.Font("Segoe UI",8);
    }
}
