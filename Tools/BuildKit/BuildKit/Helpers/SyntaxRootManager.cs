// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuildKit.Helpers;

/// <summary>
/// Manages the syntax roots of the source files.
/// </summary>
/// <remarks>
/// This class is for performance.
/// <remarks>
public class SyntaxRootManager : IDisposable
{
    private readonly Dictionary<string, SyntaxNode> SyntaxRoots = [];

    /// <summary>
    /// Removes the syntax root of the specified file.
    /// </summary>
    /// <param name="filePath">The path to the file.</param>
    public void RemoveSyntaxRoot(string filePath)
    {
        SyntaxRoots.Remove(filePath);
    }

    /// <summary>
    /// Removes the specified syntax root from the manager.
    /// </summary>
    /// <param name="root">The syntax root to remove.</param>
    public void RemoveSyntaxRoot(SyntaxNode root)
    {
        SyntaxRoots.Where((pair) => pair.Value == root).ToList().ForEach((pair) => SyntaxRoots.Remove(pair.Key));
    }

    /// <summary>
    /// Gets the syntax root of the specified file.
    /// </summary>
    /// <param name="filePath">The path to the file.</param>
    /// <param name="cancellationToken">The cancellation token.</param>
    public SyntaxNode GetSyntaxRoot(string filePath, CancellationToken cancellationToken)
    {
        if (SyntaxRoots.TryGetValue(filePath, out var root)) return root;

        cancellationToken.ThrowIfCancellationRequested();
        string sourceCode = File.ReadAllTextAsync(filePath, cancellationToken).GetAwaiter().GetResult();
        cancellationToken.ThrowIfCancellationRequested();

        return CSharpSyntaxTree.ParseText(sourceCode, cancellationToken: cancellationToken).GetRoot(cancellationToken);
    }

    /// <summary>
    /// Disposes the manager.
    /// </summary>
    public void Dispose()
    {
        SyntaxRoots.Clear();
        GC.SuppressFinalize(this);
    }
}