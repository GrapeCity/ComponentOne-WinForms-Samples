using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BuildKit.Helpers;

/// <summary>
/// Finds files containing a specific class.
/// </summary>
public class FilesWithClassFinder
{
    #region Fields
    private string? _className;
    #endregion

    #region Public Methods
    /// <summary>
    /// Searches the specified directory (and optionally subdirectories) for all .cs files
    /// that contain the class with the given name.
    /// </summary>
    /// <returns>A list of file paths that contain the class definition.</returns>
    public List<string> FindFiles(List<string> csFiles, string className, CancellationToken cancellationToken)
    {
        _className = className;
        var matchingFiles = new List<string>();

        matchingFiles.AddRange(csFiles.Where(f => FileContainsClass(f, cancellationToken)));

        return matchingFiles;
    }
    #endregion

    #region Private Methods
    /// <summary>
    /// Core Roslyn logic: Checks if a given file contains a class with the specified name.
    /// </summary>
    /// <param name="filePath">The full path to the .cs file to analyze.</param>
    /// <returns>True if the class is found in the file, otherwise false.</returns>
    private bool FileContainsClass(string filePath, CancellationToken cancellationToken)
    {
        try
        {
            cancellationToken.ThrowIfCancellationRequested();
            // 1. Read the file content
            string code = File.ReadAllText(filePath);

            cancellationToken.ThrowIfCancellationRequested();
            // 2. Parse the code into a Syntax Tree
            SyntaxTree tree = CSharpSyntaxTree.ParseText(code);

            cancellationToken.ThrowIfCancellationRequested();
            // 3. Get the root of the tree (CompilationUnitSyntax)
            var root = tree.GetCompilationUnitRoot();

            cancellationToken.ThrowIfCancellationRequested();
            // 4. Find all ClassDeclarationSyntax nodes in the file
            // This traverses the entire syntax tree efficiently.
            var classDeclarations = root.DescendantNodes()
                                        .OfType<ClassDeclarationSyntax>();

            cancellationToken.ThrowIfCancellationRequested();
            // 5. Check if any class identifier matches the desired name
            bool found = classDeclarations.Any(classDeclaration =>
                classDeclaration.Identifier.Text.Equals(_className!, System.StringComparison.Ordinal)
            );

            return found;
        }
        catch (IOException)
        {
            return false;
        }
    }
    #endregion
}