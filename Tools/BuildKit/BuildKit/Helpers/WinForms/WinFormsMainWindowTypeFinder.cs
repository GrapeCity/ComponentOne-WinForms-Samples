// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;

namespace BuildKit.Helpers.WinForms;

/// <summary>
/// Finds the main window type of a WinForms application.
/// </summary>
public class WinFormsMainWindowTypeFinder : IDisposable
{
    #region Private Fields
    private readonly IServiceScope _serviceScope;
    private readonly SyntaxRootManager _syntaxRootManager;
    private SyntaxNode? _syntaxRoot;
    #endregion

    /// <summary>
    /// Initializes a new instance of the <see cref="WinFormsMainWindowTypeFinder"/> class.
    /// </summary>
    /// <param name="scopeFactory">The service scope factory.</param>
    public WinFormsMainWindowTypeFinder(IServiceScopeFactory scopeFactory)
    {
        _serviceScope = scopeFactory.CreateScope();
        _syntaxRootManager = _serviceScope.ServiceProvider.GetRequiredService<SyntaxRootManager>();
    }

    /// <summary>
    /// Finds the main window type of a WinForms application.
    /// </summary>
    /// <param name="filePath">The path to the source file.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The main window type of the application.</returns>
    public string? Find(string filePath, CancellationToken cancellationToken)
    {
        _syntaxRoot = GetSyntaxRoot(filePath, cancellationToken);

        if (AppRunArgsSyntax == null) return null;

        var tracker = new CSharpObjectTypeSyntaticTracer();

        return tracker.TraceExpression(_syntaxRoot, AppRunArgsSyntax, cancellationToken);
    }

    #region Private Properties
    private InvocationExpressionSyntax? _appRunInvokeSyntax;
    private InvocationExpressionSyntax? AppRunInvokeSyntax
    {
        get
        {
            _appRunInvokeSyntax ??= _syntaxRoot!.DescendantNodes()
                .OfType<InvocationExpressionSyntax>()
                .FirstOrDefault(inv => inv.Expression.ToString().Contains("Application.Run"));
            return _appRunInvokeSyntax;
        }
    }

    private ExpressionSyntax? _appRunArgsSyntax;
    private ExpressionSyntax? AppRunArgsSyntax
    {
        get
        {
            if (_appRunArgsSyntax is not null) return _appRunArgsSyntax;

            if (AppRunInvokeSyntax is not null && AppRunInvokeSyntax.ArgumentList.Arguments.Count > 0)
            {
                _appRunArgsSyntax = AppRunInvokeSyntax.ArgumentList.Arguments.First().Expression;
            }

            return _appRunArgsSyntax;
        }
    }
    #endregion

    #region Private Methods
    private SyntaxNode GetSyntaxRoot(string filePath, CancellationToken cancellationToken)
    {
        return _syntaxRootManager.GetSyntaxRoot(filePath, cancellationToken);
    }
    #endregion

    public void Dispose()
    {
        _serviceScope.Dispose();
        GC.SuppressFinalize(this);
    }
}