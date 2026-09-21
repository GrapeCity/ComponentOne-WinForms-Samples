using C1.Chart;
using C1.Chart.Serialization;
using C1.Diagram;
using C1.Diagram.Parser;
using System.Diagnostics;
using System.Reflection;

namespace DiagramEditor.Helpers;

public static class DiagramExtensions
{
    public static List<IEdge> GetEdges(this INode node)
    {
        var list = new List<IEdge>();

        var diagram = node.Diagram;

        foreach (var edge in diagram.Edges)
        {
            if(edge.Source == node || edge.Target == node)
                list.Add(edge);
        }

        return list;
    }

    static Stream? GetResourceStream(string name)
    {
        var asm = Assembly.GetExecutingAssembly();
        return asm.GetManifestResourceStream($"{asm.GetName().Name}.Resources.{name}");
    }

    public static void LoadDiagramFromResource(this IDiagram diagram, string name)
    {
        var stream = GetResourceStream(name);

        var text = "";
        if (stream != null)
        {
            using (var sr = new StreamReader(stream))
                text = sr.ReadToEnd();
        }


        diagram.LoadMermaidGraph(text);
    }
}
