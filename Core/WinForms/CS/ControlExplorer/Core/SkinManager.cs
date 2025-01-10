using System.Drawing;

namespace ControlExplorer.Core
{
    public static class SkinManager
    {
        public static Color PrimaryLightColor = ColorTranslator.FromHtml("#435482");
        public static Color BackColor = Color.FromArgb(243, 242, 242);
        public static Color HighLightBackColor = Color.FromArgb(233, 232, 232);
        public static Color DarkGray = ColorTranslator.FromHtml("#cdcdcc");
    }

    public class FontManager
    {
        public static Font SideBarStatusFont = new System.Drawing.Font("Segoe UI", 8);
    }
}
