
Imports System
Imports System.Drawing



Public Class Engine
   Private func As New FunctionEvaluator()
   
   Public Sub New()
   End Sub 'New
   
   
   Public Function Run([text] As String, xmin As Single, xmax As Single, npts As Integer) As PointF()
      func.Text = [text]
      
      If Not func.Compile() Then
         Return Nothing
      End If 
      Dim data As PointF() = CType(Array.CreateInstance(GetType(PointF), npts), PointF())
      Dim dx As Single = (xmax - xmin) /(npts - 1)
      Dim i As Integer
      For i = 0 To npts - 1
         data(i).X = xmin + dx * i
         data(i).Y = CSng(func.Invoke(data(i).X))
      Next i
      
      Return data
   End Function 'Run
   
   
   Public ReadOnly Property Errors() As String()
      Get
         Return func.Errors
      End Get
   End Property
   
   
   Public Function Compile([text] As String) As Boolean
      func.Text = [text]
      
      Return func.Compile()
   End Function 'Compile
End Class 'Engine
