// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.DependencyInjection;

namespace BuildKit.Helpers.WinForms;

/// <summary>
/// Injects the icon of a form into the designer file.
/// </summary>
public sealed class WinFormsDesignerIconInjector(IServiceProvider serviceProvider)
{
    readonly SyntaxRootManager _syntaxRootManager = serviceProvider.GetRequiredService<SyntaxRootManager>();

    /// <summary>
    /// Injects the icon of a form into the designer file.
    /// </summary>
    /// <param name="filePath">The path to the designer file.</param>
    /// <param name="formTypeName">The name of the form type.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    public void Inject(string filePath, string formTypeName, CancellationToken cancellationToken)
    {
        SyntaxNode oldRoot = _syntaxRootManager.GetSyntaxRoot(filePath, cancellationToken);
        SyntaxNode? newRoot = new WinFormsDesignerIconSyntaxWriter(formTypeName).Visit(oldRoot) ?? throw new Exception("Could not edit Designer file");
        cancellationToken.ThrowIfCancellationRequested();

        var updatedCode = newRoot.NormalizeWhitespace().ToFullString();
        cancellationToken.ThrowIfCancellationRequested();

        File.WriteAllText(filePath, updatedCode);
        cancellationToken.ThrowIfCancellationRequested();
    }
}