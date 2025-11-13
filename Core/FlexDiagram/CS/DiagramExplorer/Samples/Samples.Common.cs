using C1.Diagram;
using C1.Diagram.Parser;
using C1.Win.Diagram;
using DiagramExplorer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiagramExplorer.Samples
{
    internal partial class Samples
    {
        static Random rnd = new Random(1);

        static void SetHeaderStyle(FlexDiagram diagram)
        {
            diagram.Header.Style.Font = new Font(diagram.Font.Name, 20);
            diagram.Header.HorizontalAlignment = HorizontalAlignment.Left;
        }

        static Stream? GetResourceStream(string name)
        {
            var asm = Assembly.GetExecutingAssembly();
            return asm.GetManifestResourceStream($"{asm.GetName().Name}.Resources.{name}");
        }

        static FlexDiagram LoadDiagramFromResource(string name)
        {
            var stream = GetResourceStream(name);

            var text = "";
            if (stream != null)
            {
                using (var sr = new StreamReader(stream))
                    text = sr.ReadToEnd();
            }

            var diagram = new FlexDiagram();
            diagram.LoadMermaidGraph(text);

            return diagram;
        }
    }
}
