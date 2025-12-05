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
        public static Control CreateLiteratureDiagram(Color foreColor, Color backColor)
        {
            var diagram = LoadDiagramFromResource("literature.mermaid");
            diagram.ForeColor = foreColor;
            diagram.BackColor = backColor;
            diagram.Direction = C1.Diagram.DiagramDirection.LeftRight;
            diagram.Font = new Font("Lucida Calligraphy", diagram.Font.Size);
            diagram.Header.Content = "Literature Genres Tree";
            foreach (var node in diagram.Nodes)
                node.Shape = Shape.Ellipse;
            diagram.ScaleMode = ScaleMode.ScaleToFit;
            SetHeaderStyle(diagram);
            return diagram;
        }
    }
}
