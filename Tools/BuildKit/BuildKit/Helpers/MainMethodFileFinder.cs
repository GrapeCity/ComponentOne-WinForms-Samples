using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;

namespace BuildKit.Helpers;

/// <summary>
/// Finds the file containing the Main method.
/// </summary>
public class MainMethodFileFinder
{
    #region Fields
    private SyntaxRootManager _rootManager;
    #endregion

    #region Constants
    private static readonly string[] ALLOWED_RETURN_TYPES = ["void", "int", "Task", "Task<int>"];
    #endregion

    #region Constructors
    /// <summary>
    /// Initializes a new instance of the <see cref="MainMethodFileFinder"/> class.
    /// </summary>
    /// <param name="serviceProvider">The service provider.</param>
    public MainMethodFileFinder(IServiceProvider serviceProvider)
    {
        _rootManager = serviceProvider.GetRequiredService<SyntaxRootManager>();
    }
    #endregion

    #region Public Methods
    /// <summary>
    /// Finds the file containing the Main method.
    /// </summary>
    /// <param name="sourceFiles">The source files.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    public string? Find(IEnumerable<string> sourceFiles, CancellationToken cancellationToken)
    {
        return sourceFiles.FirstOrDefault((f) => IsMainMethod(f, cancellationToken));
    }
    #endregion

    #region Private Methods
    private IEnumerable<MethodDeclarationSyntax> GetMainMethodsInSource(string file, CancellationToken cancellationToken)
    {
        SyntaxNode root = _rootManager.GetSyntaxRoot(file, cancellationToken);

        return root.DescendantNodes()
            .OfType<MethodDeclarationSyntax>()
            .Where(m => m.Identifier.Text == "Main");
    }

    private bool IsMainMethod(string file, CancellationToken cancellationToken)
    {
        // 1. Parse the code into a Syntax Tree
        IEnumerable<MethodDeclarationSyntax> mainMethods = GetMainMethodsInSource(file, cancellationToken);

        foreach (var mainMethod in mainMethods)
        {
            cancellationToken.ThrowIfCancellationRequested();
            bool isValid = IsMainMethodStatic(mainMethod) && IsMethodReturnTypeValidForMain(mainMethod) && IsMainMethodSignatureValid(mainMethod);
            if (isValid)
                return true;
        }

        return false;
    }

    private static bool IsMainMethodStatic(MethodDeclarationSyntax methodDeclaration)
    {
        return methodDeclaration.Modifiers.Any((s) => s.IsKind(SyntaxKind.StaticKeyword));
    }

    private static bool IsMethodReturnTypeValidForMain(MethodDeclarationSyntax methodDeclaration)
    {
        return ALLOWED_RETURN_TYPES.Contains(methodDeclaration.ReturnType.ToString());
    }

    private static bool IsMainMethodSignatureValid(MethodDeclarationSyntax methodDeclaration)
    {
        var parameterList = methodDeclaration.ParameterList.Parameters;

        if (parameterList.Count == 0)
        {
            // Signature: static void Main()
            return true;
        }
        else if (parameterList.Count == 1)
        {
            var param = parameterList.First();
            string paramType = param.Type?.ToString() ?? string.Empty;

            // Signature: static void Main(string[] args)
            if (paramType.Contains("string") && paramType.Contains("[]"))
            {
                return true;
            }
        }

        return false;
    }
    #endregion
}