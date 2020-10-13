Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace TestSchedule
	''' <summary>
    ''' The ExerciseCategory class describes category of Exercises.
    ''' </summary>
    Public Class ExerciseCategory
        Private _id As Integer
        Private _name As String

        ''' <summary>
        ''' Creates new instance of ExerciseCategory object with specified parameters.
        ''' </summary>
        ''' <param name="id"></param>
        ''' <param name="name"></param>
        Public Sub New(ByVal id As Integer, ByVal name As String)
            _id = id
            _name = name
        End Sub

        ''' <summary>
        ''' Gets or sets the name of ExerciseCategory.
        ''' </summary>
        Public Property Name() As String
            Get
                Return _name
            End Get
            Set(ByVal value As String)
                If _name <> Value Then
                    _name = Value
                End If
            End Set
        End Property

        ''' <summary>
        ''' Gets or sets an integer key for ExerciseCategory, which can be used
        ''' for identifying ExerciseCategory objects.
        ''' </summary>
        Public Property Id() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                If _id <> Value Then
                    _id = Value
                End If
            End Set
        End Property

        ''' <summary>
        ''' Overrides the default behaviour.
        ''' </summary>
        ''' <returns></returns>
        Public Overloads Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    ''' <summary>
    ''' ExerciseCategories list keeps the list of all available ExerciseCategory.
    ''' </summary>
    Public Class ExerciseCategories
        Inherits List(Of ExerciseCategory)
        ''' <summary>
        ''' Creates new instance of ExerciseCategories class and fills it with
        ''' the predefined set of ExerciseCategory objects.
        ''' </summary>
        Public Sub New()
            LoadDefaults()
        End Sub

        ''' <summary>
        ''' Fills ExerciseCategories list with the predefined set of 
        ''' ExerciseCategory objects.		
        ''' </summary>
        Public Sub LoadDefaults()
            Clear()
            Add(New ExerciseCategory(0, "Calorie burning"))
            Add(New ExerciseCategory(1, "Mind and Body"))
            Add(New ExerciseCategory(2, "Body conditioning"))
            Add(New ExerciseCategory(3, "Combination"))
        End Sub
    End Class
End Namespace
