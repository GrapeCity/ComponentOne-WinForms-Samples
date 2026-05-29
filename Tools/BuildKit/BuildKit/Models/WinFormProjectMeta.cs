namespace BuildKit.Models;

/// <summary>
/// Represents metadata for a Windows Forms project.
/// </summary>
public class WinFormsProjectMeta
{
    /// <summary>
    /// The directory of the project.
    /// </summary>
    public required string ProjectDir { get; init; }

    /// <summary>
    /// The path to the .csproj file of the project.
    /// </summary>
    public required string CsProjPath { get; init; }

    /// <summary>
    /// The path to the entry point of the project.
    /// </summary>
    public required string EntryFilePath { get; init; }

    /// <summary>
    /// The name of the main form class.
    /// </summary>
    public required string MainFormClassName { get; init; }

    /// <summary>
    /// The paths to the main form files.
    /// </summary>
    public required List<string> MainFormFilePaths { get; init; }

    /// <summary>
    /// The path to the main form designer file.
    /// </summary>
    public required string MainFormDesignerFilePath { get; init; }

    /// <summary>
    /// The path to the main form resource file.
    /// </summary>
    public required string MainFormResxFilePath { get; init; }
}
