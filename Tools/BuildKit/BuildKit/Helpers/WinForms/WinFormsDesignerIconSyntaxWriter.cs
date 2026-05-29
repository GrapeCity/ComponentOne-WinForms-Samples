// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace BuildKit.Helpers.WinForms;

/// <summary>
/// Rewrites the InitializeComponent method to inject the icon of a form into the designer file.
/// </summary>
internal sealed class WinFormsDesignerIconSyntaxWriter(string formClassName) : CSharpSyntaxRewriter
{
    /// <summary>
    /// Rewrites the InitializeComponent method to inject the icon of a form into the designer file.
    /// </summary>
    /// <param name="node">The method declaration node.</param>
    /// <returns>The rewritten method declaration node.</returns>
    public override SyntaxNode? VisitMethodDeclaration(MethodDeclarationSyntax node)
    {
        if (node.Identifier.Text != "InitializeComponent" ||
            node.Body == null)
            return base.VisitMethodDeclaration(node);

        BlockSyntax body = node.Body;

        bool hasResourcesVar =
            body.Statements
                .OfType<LocalDeclarationStatementSyntax>()
                .Any(s =>
                    s.Declaration.Variables.Any(v => v.Identifier.Text == "resources"));

        bool hasIconAssignment =
            body.Statements
                .OfType<ExpressionStatementSyntax>()
                .Any(s =>
                    s.Expression is AssignmentExpressionSyntax assign &&
                    assign.Left.ToString().EndsWith("Icon") &&
                    assign.Right.ToString().Contains("resources.GetObject(\"$this.Icon\")"));

        if (hasResourcesVar && hasIconAssignment)
            return node;

        SyntaxList<StatementSyntax> newStatements = body.Statements;

        if (!hasResourcesVar)
            newStatements = newStatements.Insert(0, ResourceDeclarationLine);

        if (!hasIconAssignment)
            newStatements = newStatements.Insert(1, AssignIconLine);

        return node.WithBody(body.WithStatements(newStatements));
    }

    #region Private Properties
    /// <summary>
    /// Translates to `System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));`
    /// </summary>
    private LocalDeclarationStatementSyntax ResourceDeclarationLine => SyntaxFactory.LocalDeclarationStatement(
                SyntaxFactory.VariableDeclaration(
                    type: SyntaxFactory.ParseTypeName("System.ComponentModel.ComponentResourceManager")
                ).AddVariables(
                    SyntaxFactory.VariableDeclarator("resources")
                        .WithInitializer(
                            SyntaxFactory.EqualsValueClause(
                                SyntaxFactory.ObjectCreationExpression(
                                    SyntaxFactory.ParseTypeName("System.ComponentModel.ComponentResourceManager")
                                ).AddArgumentListArguments(
                                    SyntaxFactory.Argument(
                                        SyntaxFactory.TypeOfExpression(
                                            SyntaxFactory.IdentifierName(formClassName)
                                        )
                                    )
                                )
                            )
                        )
                )
            );

    /// <summary>
    /// Translates to `Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
    /// </summary>
    private static readonly ExpressionStatementSyntax AssignIconLine = SyntaxFactory.ExpressionStatement(
                SyntaxFactory.AssignmentExpression(
                    kind: SyntaxKind.SimpleAssignmentExpression,
                    left: SyntaxFactory.IdentifierName("Icon"),
                    right: SyntaxFactory.CastExpression(
                        type: SyntaxFactory.ParseTypeName("System.Drawing.Icon"),
                        expression: SyntaxFactory.InvocationExpression(
                            expression: SyntaxFactory.MemberAccessExpression(
                                kind: SyntaxKind.SimpleMemberAccessExpression,
                                expression: SyntaxFactory.IdentifierName("resources"),
                                name: SyntaxFactory.IdentifierName("GetObject")
                            )
                        ).AddArgumentListArguments(
                            SyntaxFactory.Argument(
                                expression: SyntaxFactory.LiteralExpression(
                                    kind: SyntaxKind.StringLiteralExpression,
                                    token: SyntaxFactory.Literal("$this.Icon")
                                )
                            )
                        )
                    )
                )
            );
    #endregion
}
