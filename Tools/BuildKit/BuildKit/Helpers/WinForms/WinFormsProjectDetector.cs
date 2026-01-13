using System.Xml.Linq;

namespace BuildKit.Helpers.WinForms;

/// <summary>
/// Detects if a project is a Windows Forms project.
/// </summary>
public class WinFormsProjectDetector(string csprojPath)
{
    /// <summary>
    /// Detects if a project is a Windows Forms project.
    /// </summary>
    /// <returns>True if the project is a Windows Forms project, false otherwise.</returns>
    public bool IsWinFormsProject()
    {
        if (!File.Exists(csprojPath))
            return false;

        var doc = XDocument.Load(csprojPath);
        var root = doc.Root!;
        var ns = root.Name.Namespace;

        if (HasProperty(root, ns, "UseWindowsForms", "true"))
            return true;

        return false;
    }

    private static bool HasProperty(
        XElement root,
        XNamespace ns,
        string propertyName,
        string expectedValue)
    {
        return root
            .Descendants(ns + propertyName)
            .Any(e =>
                string.Equals(
                    e.Value.Trim(),
                    expectedValue,
                    StringComparison.OrdinalIgnoreCase));
    }
}