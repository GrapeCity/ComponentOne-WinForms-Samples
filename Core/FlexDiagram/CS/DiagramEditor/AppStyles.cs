// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace DiagramEditor
{
    public class AppStyles
    {
        public static Color BackColor = Color.White;

        public static Color HoverColor = Color.FromArgb(0xE8, 0xF0, 0xFE);

        public static Color PanelBackColor = Color.FromArgb(0xFA, 0xFA, 0xFA);
        public static Color HeaderColor = Color.FromArgb(0x50, 0x50, 0x50);
        public static Color LabelColor = Color.FromArgb(0x60, 0x60, 0x60);

        public static Color LabelLightColor = Color.FromArgb(0x90, 0x90, 0x90);

        static string fontName = "Segoe UI";

        public static Font Font = new Font(fontName, 8f);

        public static Font ItalicFont = new Font(fontName, 8.5f, FontStyle.Italic);
        public static Font BoldFont = new Font(fontName, 8.5f, FontStyle.Bold);

        public static Color SelectionFill = Color.FromArgb(0xDA, 0xE8, 0xFC);
        public static Color SelectionStroke = Color.FromArgb(0x6C, 0x8E, 0xBF);
        public static Color SelectionStroke2 = Color.FromArgb(0x20, 0x1A, 0x73, 0xE8);
    }
}
