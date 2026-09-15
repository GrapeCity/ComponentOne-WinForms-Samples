// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Text;

namespace DiagramEditor
{
    public sealed class ModernColorTable : ProfessionalColorTable
    {
        public override Color ToolStripGradientBegin => Color.FromArgb(248, 249, 250);
        public override Color ToolStripGradientMiddle => Color.FromArgb(248, 249, 250);
        public override Color ToolStripGradientEnd => Color.FromArgb(248, 249, 250);

        public override Color MenuStripGradientBegin => Color.White;
        public override Color MenuStripGradientEnd => Color.White;

        public override Color ToolStripBorder => Color.FromArgb(220, 220, 220);

        public override Color ButtonSelectedGradientBegin => Color.FromArgb(235, 239, 244);
        public override Color ButtonSelectedGradientMiddle => Color.FromArgb(235, 239, 244);
        public override Color ButtonSelectedGradientEnd => Color.FromArgb(235, 239, 244);

        public override Color ButtonPressedGradientBegin => Color.FromArgb(220, 230, 240);
        public override Color ButtonPressedGradientMiddle => Color.FromArgb(220, 230, 240);
        public override Color ButtonPressedGradientEnd => Color.FromArgb(220, 230, 240);
    }
}
