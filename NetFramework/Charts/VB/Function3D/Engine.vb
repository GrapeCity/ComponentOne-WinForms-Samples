
Imports System
Imports System.Collections
Imports System.Xml.Serialization

Imports C1.Win.C1Chart3D



'/ <summary>
'/ Summary description for Engine.
'/ </summary>
Public Class Range
   Implements ICloneable 'ToDo: Add Implements Clauses for implementation methods of these interface(s)
   Private xmin As Single = - 10
   Private ymin As Single = - 10
   Private xmax As Single = 10
   Private ymax As Single = 10
   Private nx As Integer = 11
   Private ny As Integer = 11
   
   
   Public Function Clone() As Object Implements ICloneable.Clone
      Return Me.MemberwiseClone()
   End Function 'Clone
   <XmlAttribute()>  _
   Public Property MinX() As Single
      Get
         Return xmin
      End Get
      Set
         xmin = value
      End Set
   End Property
   <XmlAttribute()>  _
   Public Property MinY() As Single
      Get
         Return ymin
      End Get
      Set
         ymin = value
      End Set
   End Property
   <XmlAttribute()>  _
   Public Property MaxX() As Single
      Get
         Return xmax
      End Get
      Set
         xmax = value
      End Set
   End Property
   <XmlAttribute()>  _
   Public Property MaxY() As Single
      Get
         Return ymax
      End Get
      Set
         ymax = value
      End Set
   End Property
   <XmlAttribute()>  _
   Public Property NumX() As Integer
      Get
         Return nx
      End Get
      Set
         nx = value
      End Set
   End Property
   <XmlAttribute()>  _
   Public Property NumY() As Integer
      Get
         Return ny
      End Get
      Set
         ny = value
      End Set
   End Property 
   
   Friend ReadOnly Property DeltaX() As Single
      Get
         Return(xmax - xmin) /(nx - 1)
      End Get
   End Property
   
   Friend ReadOnly Property DeltaY() As Single
      Get
         Return(ymax - ymin) /(ny - 1)
      End Get
   End Property
End Class 'Range

Public Class FunctionInfo
   Private m_code As String() = Nothing
   Private m_name As String = [String].Empty
   Private m_range As New Range()
   
   
   Public Sub New()
   End Sub 'New
    
   Public Sub New(name As String, code() As String, range As Range)
      m_name = name
      m_code = code
      Range = range
   End Sub 'New
   
   '[XmlAttribute]
   
   Public Property Code() As String()
      Get
         Return m_code
      End Get
      Set
         m_code = value
      End Set
   End Property
   <XmlAttribute()>  _
   Public Property Name() As String
      Get
         Return m_name
      End Get
      Set
         m_name = value
      End Set
   End Property
   
   
   Public Property Range() As Range
      Get
         Return CType(m_range.Clone(), Range)
      End Get
      Set
         m_range = CType(value.Clone(), Range)
      End Set
   End Property
End Class 'FunctionInfo


Public Class FunctionInfoCollection
   Inherits CollectionBase
   
   Default Public Property Item(i As Integer) As FunctionInfo
      Get
         Return CType(List(i), FunctionInfo)
      End Get
      Set
         List(i) = value
      End Set
   End Property
   
   
   Public Function Add(fi As FunctionInfo) As Integer
      Return List.Add(fi)
   End Function 'Add
   
   
   Public Function FindName(s As String) As Integer
      Dim i As Integer
      For i = 0 To Count - 1
         If s.Equals(Me(i).Name) Then
            Return i
         End If
      Next i
      Return - 1
   End Function 'FindName
End Class 'FunctionInfoCollection


Public Class Engine
   Private func As New FunctionEvaluator()
   
   Public Sub New()
   End Sub 'New
   
   
   Public Function Run([text] As String, range As Range) As Chart3DDataSetGrid
      func.Text = [text]
      
      If Not func.Compile() Then
         Return Nothing
      End If 
      Dim dx As Single = range.DeltaX
      Dim dy As Single = range.DeltaY
      Dim data As Single(,) = CType(Array.CreateInstance(GetType(Single), range.NumX, range.NumY), Single(,))
      Dim i As Integer
      For i = 0 To range.NumX - 1
         Dim j As Integer
         For j = 0 To range.NumY - 1
            data(i, j) = CSng(func.Invoke(range.MinX + i * dx, range.MinY + j * dy))
         Next j
      Next i
      
      Return New Chart3DDataSetGrid(range.MinX, range.MinY, dx, dy, data)
   End Function 'Run
   
   
   Public ReadOnly Property Errors() As String()
      Get
         Return func.Errors
      End Get
   End Property
End Class 'Engine
