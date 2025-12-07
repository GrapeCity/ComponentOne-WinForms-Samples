using C1.Diagram.Parser;
using C1.Diagram;
using C1.Win.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiagramExplorer.Samples
{
    internal partial class Samples
    {
        public static Control CreateFamilyTreeDiagram(Color foreColor, Color backColor)
        {
            var diagram = LoadDiagramFromResource("family-tree.mermaid");
            diagram.ForeColor = foreColor;
            diagram.BackColor = backColor;
            diagram.Header.Content = "Games of Thrones, Main Characters";
            diagram.Header.HorizontalAlignment = HorizontalAlignment.Left;
            diagram.ScaleMode = ScaleMode.ScaleToFit;
            diagram.Font = new Font("Segoe UI Emoji", 10);

            SetHeaderStyle(diagram);
            return diagram;
        }

    }
}
