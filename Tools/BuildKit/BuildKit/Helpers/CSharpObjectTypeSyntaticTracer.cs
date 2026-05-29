using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;

namespace BuildKit.Helpers;

/// <summary>
/// Traces the type of an object in a C# code.
/// </summary>
internal class CSharpObjectTypeSyntaticTracer
{
    private SyntaxNode? _root;

    /// <summary>
    /// The Core Logic: Takes an expression (variable, property, method call) and finds what "new X()" it resolves to.
    /// </summary>
    internal string? TraceExpression(SyntaxNode root, ExpressionSyntax expr, CancellationToken cancellationToken)
    {
        _root ??= root;

        if (expr == null) return null;

        // 1. BASE CASE: Direct Object Creation (new Form1())
        string? result = FindObjTypeByObjectCreation(expr);
        if (result is not null) return result;

        // 2. CASE: Method Call (e.g. GetAppForm())
        result = FindObjTypeByMethodCall(expr, cancellationToken);
        if (result is not null) return result;

        // 3. CASE: Identifier (Variables, Parameters, Fields, Properties)
        result = FindObjTypeByIdentifier(expr, cancellationToken);
        if (result is not null) return result;

        return null;

    }

    #region Private Methods
    private static string? FindObjTypeByObjectCreation(ExpressionSyntax expr)
    {
        if (expr is not ObjectCreationExpressionSyntax creation)
            return null;

        return creation.Type.ToString();
    }

    private string? FindObjTypeByMethodCall(ExpressionSyntax expr, CancellationToken cancellationToken)
    {
        if (expr is not InvocationExpressionSyntax invocation)
            return null;

        string methodName = GetNameFromExpression(invocation.Expression);
        // Find the method declaration in the tree
        var methodDecl = _root!.DescendantNodes().OfType<MethodDeclarationSyntax>()
            .FirstOrDefault(m => m.Identifier.Text == methodName);

        if (methodDecl != null)
        {
            // Check Expression Body (=> new Form1())
            if (methodDecl.ExpressionBody != null)
                return TraceExpression(_root, methodDecl.ExpressionBody.Expression, cancellationToken);

            // Check Return Statements
            var returnStmt = methodDecl.DescendantNodes().OfType<ReturnStatementSyntax>().FirstOrDefault();
            if (returnStmt is not null)
                return TraceExpression(_root, returnStmt.Expression!, cancellationToken);
        }

        return null;
    }

    private string? FindObjTypeByIdentifier(ExpressionSyntax expr, CancellationToken cancellationToken)
    {
        // --- CASE: Identifier (Variables, Parameters, Fields, Properties) ---
        if (expr is not IdentifierNameSyntax identifier)
            return null;

        string name = identifier.Identifier.Text;
        var currentMethod = expr.Ancestors().OfType<BaseMethodDeclarationSyntax>().FirstOrDefault();

        // A. Is it a Local Variable? (var f = ...)
        string? result = ResolveLocalVariable(name, currentMethod, cancellationToken);
        if (result is not null) return result;

        // B. Is it a Parameter? (void Run(Form f))
        result = ResolveParameter(name, currentMethod, cancellationToken);
        if (result is not null) return result;

        // C. Is it a Field? (private Form _f)
        // We assume if we see a field usage, it was assigned in the Constructor.
        result = ResolveField(name, expr, cancellationToken);
        if (result is not null) return result;

        // D. Is it a Property? (static Form AppForm => new Form1(); OR public Form AppForm { get; set; } = new Form1();)
        result = ResolveProperty(name, cancellationToken);
        if (result is not null) return result;

        return null;
    }

    private string? ResolveLocalVariable(string name, BaseMethodDeclarationSyntax? currentMethod, CancellationToken cancellationToken)
    {
        if (currentMethod is null) return null;

        var localDecl = currentMethod.DescendantNodes()
                .OfType<VariableDeclaratorSyntax>()
                .FirstOrDefault(v => v.Identifier.Text == name);

        if (localDecl != null && localDecl.Initializer != null)
        {
            return TraceExpression(_root!, localDecl.Initializer.Value, cancellationToken);
        }

        return null;
    }

    private string? ResolveParameter(string name, BaseMethodDeclarationSyntax? currentMethod, CancellationToken cancellationToken)
    {
        if (currentMethod is null) return null;

        var param = currentMethod.ParameterList.Parameters
                .FirstOrDefault(p => p.Identifier.Text == name);

        if (param != null)
        {
            int paramIndex = currentMethod.ParameterList.Parameters.IndexOf(param);

            // IF Constructor: Find "new ClassName(arg)"
            if (currentMethod is ConstructorDeclarationSyntax ctor)
            {
                var classDecl = ctor.Parent as ClassDeclarationSyntax;
                return FindCallerAndTraceArg(classDecl!.Identifier.Text, paramIndex, isConstructor: true, cancellationToken);
            }
            // IF Method: Find "MethodName(arg)"
            else if (currentMethod is MethodDeclarationSyntax method)
            {
                return FindCallerAndTraceArg(method.Identifier.Text, paramIndex, isConstructor: false, cancellationToken);
            }
        }
        return null;
    }

    private string? ResolveField(string name, ExpressionSyntax expr, CancellationToken cancellationToken)
    {
        var classNode = expr.Ancestors().OfType<ClassDeclarationSyntax>().FirstOrDefault();
        if (classNode is null) return null;

        var fieldDecl = classNode.DescendantNodes().OfType<FieldDeclarationSyntax>()
                .FirstOrDefault(f => f.Declaration.Variables.Any(v => v.Identifier.Text == name));

        if (fieldDecl != null)
        {
            // Find assignment in Constructor: "_f = x"
            var ctor = classNode.DescendantNodes().OfType<ConstructorDeclarationSyntax>().FirstOrDefault();
            if (ctor != null)
            {
                var assignment = ctor.DescendantNodes().OfType<AssignmentExpressionSyntax>()
                    .FirstOrDefault(a => GetNameFromExpression(a.Left) == name); // Matches "this._f" or "_f"

                if (assignment != null)
                {
                    // Recurse on the Right Hand Side of the assignment (which is likely a Parameter)
                    return TraceExpression(_root!, assignment.Right, cancellationToken);
                }
            }
        }

        return null;
    }

    private string? ResolveProperty(string name, CancellationToken cancellationToken)
    {
        var propDecl = _root!.DescendantNodes().OfType<PropertyDeclarationSyntax>()
                .FirstOrDefault(p => p.Identifier.Text == name);

        if (propDecl != null)
        {
            // **FIX ADDED HERE: Check for an initializer directly on the property**
            if (propDecl.Initializer != null)
            {
                // If initializer is present (e.g., = new Form1()), trace its value
                return TraceExpression(_root, propDecl.Initializer.Value, cancellationToken);
            }

            // Original logic for Expression Body: "Form AppForm => new Form1();"
            if (propDecl.ExpressionBody != null)
            {
                return TraceExpression(_root, propDecl.ExpressionBody.Expression, cancellationToken);
            }
            // Original logic for Getter: "get { return new Form1(); }"
            var getter = propDecl.AccessorList?.Accessors.FirstOrDefault(a => a.Keyword.Text == "get");
            if (getter != null)
            {
                var ret = getter.DescendantNodes().OfType<ReturnStatementSyntax>().FirstOrDefault();
                if (ret != null) return TraceExpression(_root!, ret.Expression!, cancellationToken);
            }
        }

        return null;
    }

    /// <summary>
    /// Finds who called a specific method/constructor and recurses on the argument passed.
    /// </summary>
    private string? FindCallerAndTraceArg(string targetName, int argIndex, bool isConstructor, CancellationToken cancellationToken)
    {
        if (isConstructor)
        {
            // Find "new TargetName(...)"
            var creation = _root!.DescendantNodes().OfType<ObjectCreationExpressionSyntax>()
                .FirstOrDefault(obj => obj.Type.ToString() == targetName && obj.ArgumentList!.Arguments.Count > argIndex);

            if (creation != null)
            {
                return TraceExpression(_root, creation.ArgumentList!.Arguments[argIndex].Expression, cancellationToken);
            }
        }
        else
        {
            // Find "TargetName(...)" or "Class.TargetName(...)"
            var invocation = _root!.DescendantNodes().OfType<InvocationExpressionSyntax>()
                .FirstOrDefault(inv => GetNameFromExpression(inv.Expression) == targetName && inv.ArgumentList.Arguments.Count > argIndex);

            if (invocation != null)
            {
                return TraceExpression(_root, invocation.ArgumentList.Arguments[argIndex].Expression, cancellationToken);
            }
        }
        return null;
    }

    /// <summary>
    /// Helper to get the simple name from complex expressions like "this.field", "Class.Method", etc.
    /// </summary>
    private static string GetNameFromExpression(ExpressionSyntax expr)
    {
        if (expr is IdentifierNameSyntax id) return id.Identifier.Text;
        if (expr is MemberAccessExpressionSyntax member) return member.Name.Identifier.Text;
        return expr.ToString();
    }
    #endregion
}
