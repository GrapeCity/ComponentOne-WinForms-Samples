using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramExplorer.Controls
{
    // Custom color table for dark theme
    public class DarkColorTable : ProfessionalColorTable
    {
        // Define your dark theme colors
        private readonly Color menuBackColor = Color.FromArgb(45, 45, 48);
        private readonly Color menuBorderColor = Color.FromArgb(63, 63, 70);
        private readonly Color selectionColor = Color.FromArgb(62, 62, 66);
        private readonly Color separatorColor = Color.FromArgb(63, 63, 70);
        private readonly Color checkPressedColor = Color.FromArgb(82, 82, 86);
        private readonly Color hoverColor = Color.FromArgb(52, 52, 55);

        // Menu item selection colors
        public override Color MenuItemSelected => selectionColor;
        public override Color MenuItemSelectedGradientBegin => selectionColor;
        public override Color MenuItemSelectedGradientEnd => selectionColor;

        // Menu item pressed (when clicked) colors
        public override Color MenuItemPressedGradientBegin => checkPressedColor;
        public override Color MenuItemPressedGradientEnd => checkPressedColor;
        public override Color MenuItemPressedGradientMiddle => checkPressedColor;

        // Dropdown background
        public override Color ToolStripDropDownBackground => menuBackColor;

        // Menu borders
        public override Color MenuBorder => menuBorderColor;
        public override Color MenuItemBorder => selectionColor;

        // Image margin (left side of menu items)
        public override Color ImageMarginGradientBegin => menuBackColor;
        public override Color ImageMarginGradientMiddle => menuBackColor;
        public override Color ImageMarginGradientEnd => menuBackColor;

        // For revealed image margin
        public override Color ImageMarginRevealedGradientBegin => menuBackColor;
        public override Color ImageMarginRevealedGradientMiddle => menuBackColor;
        public override Color ImageMarginRevealedGradientEnd => menuBackColor;

        // Separator colors
        public override Color SeparatorDark => separatorColor;
        public override Color SeparatorLight => menuBackColor;

        // Checkbox colors
        public override Color CheckBackground => checkPressedColor;
        public override Color CheckPressedBackground => selectionColor;
        public override Color CheckSelectedBackground => menuBackColor;

        // ToolStrip background gradient
        public override Color ToolStripGradientBegin => menuBackColor;
        public override Color ToolStripGradientMiddle => menuBackColor;
        public override Color ToolStripGradientEnd => menuBackColor;

        // ToolStrip border
        public override Color ToolStripBorder => menuBorderColor;

        // Button colors (for ToolStrip buttons)
        public override Color ButtonSelectedGradientBegin => selectionColor;
        public override Color ButtonSelectedGradientMiddle => selectionColor;
        public override Color ButtonSelectedGradientEnd => selectionColor;
        public override Color ButtonSelectedBorder => menuBorderColor;

        public override Color ButtonPressedGradientBegin => checkPressedColor;
        public override Color ButtonPressedGradientMiddle => checkPressedColor;
        public override Color ButtonPressedGradientEnd => checkPressedColor;
        public override Color ButtonPressedBorder => menuBorderColor;

        public override Color ButtonCheckedGradientBegin => checkPressedColor;
        public override Color ButtonCheckedGradientMiddle => checkPressedColor;
        public override Color ButtonCheckedGradientEnd => checkPressedColor;
    }

    // Custom renderer for complete control over appearance
    public class DarkToolStripRenderer : ToolStripProfessionalRenderer
    {
        private readonly Color textColor = Color.FromArgb(241, 241, 241);

        public DarkToolStripRenderer() : base(new DarkColorTable())
        {
        }

        // Override text rendering to set text color
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            // Set text color for all items
            e.TextColor = e.Item.Enabled ? textColor : Color.FromArgb(128, 128, 128);
            base.OnRenderItemText(e);
        }

        protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
        {
            //base.OnRenderToolStripBorder(e);
        }
    }
}
