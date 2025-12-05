namespace FlexGridExplorer.Utility
{
    /// <summary>
    /// Provides centralized theme definitions for application-wide colors and visual styling.
    /// </summary>
    public static class SkinManager
    {
        public readonly static Color PrimaryColor = ColorTranslator.FromHtml("#132c55");
        public readonly static Color PrimaryLightColor = ColorTranslator.FromHtml("#435482");
        public readonly static Color BackColor = Color.FromArgb(243, 242, 242);
        public readonly static Color HoverBackColor = Color.FromArgb(233, 232, 232);
        public readonly static Color HomeBackColor = Color.FromArgb(249, 249, 249);
        public readonly static Color HighLightBackColor = Color.FromArgb(233, 232, 232);
        public readonly static Color DarkGray = ColorTranslator.FromHtml("#cdcdcc");
        public readonly static Color HighlighterColor = Color.FromArgb(1, 94, 184);
        public readonly static Color LightBackColor = Color.FromArgb(249, 248, 248);
        public readonly static Color Office365Black = Color.FromArgb(10, 10, 10);
        public readonly static Color LightGray = ColorTranslator.FromHtml("#e4e5e4");
    }

    public class FontManager
    {
        public readonly static Font SideBarStatusFont = new Font("Segoe UI", 8);
    }
}
