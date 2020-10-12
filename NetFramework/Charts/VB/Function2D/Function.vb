
Imports System

Imports System.CodeDom
Imports System.CodeDom.Compiler
Imports System.Reflection



'/ <summary>
'/ Summary description for Function.
'/ </summary>
Public Class FunctionEvaluator
   Private m_text As String = String.Empty
   Private m_compiled As Boolean = False
   Private calc As Object = Nothing
   
   Private cu As New CodeCompileUnit()
   Private ns As New CodeNamespace("Function2D")
   Private method As New CodeMemberMethod()
   Private cl As New CodeTypeDeclaration("Calculator")
   
   Private compile_result As CompilerResults
   Private compiler As ICodeCompiler
   
   
   Sub init_compiler()
        Dim vb As New Microsoft.VisualBasic.VBCodeProvider()
       compiler = vb.CreateCompiler()
   End Sub 'init_compiler
   
   
   Sub init()
      cu.Namespaces.Add(ns)
      ns.Imports.Add(New CodeNamespaceImport("System"))
      ns.Types.Add(cl)
      method.Parameters.Add(New CodeParameterDeclarationExpression(GetType(Double), "x"))
      method.ReturnType = New CodeTypeReference(GetType(Double))
      
      cl.TypeAttributes = TypeAttributes.Public
      cl.Members.Add(method)
      method.Attributes = MemberAttributes.Public ' | MemberAttributes.Static;
      method.Name = "Run"
      
      init_compiler()
   End Sub 'init
   
   
   Public Sub New()
      init()
   End Sub 'New
   
   
   Public Property [Text]() As String
      Get
         Return m_text
      End Get
      Set
         If Not m_text.Equals(value) Then
            m_text = value
            m_compiled = False
         End If
      End Set
   End Property
   
   
   ReadOnly Property Compiled() As Boolean
      Get
         Return m_compiled
      End Get
   End Property
   
   
   Public Function Invoke(x As Double) As Double
      If Not Compile() Then
         Throw New Exception("Error during compile")
      End If 
      Dim test As Type = compile_result.CompiledAssembly.GetType("Function2D.Calculator")
      Dim m As MethodInfo = test.GetMethod("Run")
      Dim args As Object() = CType(Array.CreateInstance(GetType(Object), 1), Object())
      args(0) = x
      Return CDbl(m.Invoke(calc, args))
   End Function 'Invoke
   
   
   Public Function Compile() As Boolean
      If m_compiled Then
         Return True
      End If 
      method.Statements.Clear()
      Dim code As String
       code = "return " + m_text
      method.Statements.Add(New CodeExpressionStatement(New CodeSnippetExpression(code)))
      
      Dim compparams As New CompilerParameters(New String() {"mscorlib.dll"})
      compparams.GenerateInMemory = True
      
      If Not (compiler Is Nothing) Then
         compile_result = compiler.CompileAssemblyFromDom(compparams, cu)
      End If 
      If compile_result Is Nothing OrElse compile_result.Errors.Count > 0 Then
         Return False
      End If 
      m_compiled = True
      calc = compile_result.CompiledAssembly.CreateInstance("Function2D.Calculator")
      Return True
   End Function 'Compile
   
   
   Public ReadOnly Property Errors() As String()
      Get
         If m_compiled Then
            Return Nothing
         End If
         Dim cnt As Integer = compile_result.Errors.Count
         Dim err(cnt) As String
         Dim i As Integer
         For i = 0 To cnt - 1
            err(i) = compile_result.Errors(i).ErrorText
         Next i
         Return err
      End Get
   End Property
End Class 'FunctionEvaluator
