Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Drawing
Imports System.ComponentModel

Namespace TestSchedule
	''' <summary>
    ''' This class represents Exercise level (for example, beginning or intermediate).
    ''' It is used for coloring Exercises on the time table.
	''' </summary>
	Public Class Level
		Private _id As Guid
		Private _color As Color
		Private _levelName As String
		Private _description As String

		''' <summary>
		''' Creates a new instance of the Level object with the specified properties.
		''' </summary>
		''' <param name="id"></param>
		''' <param name="color"></param>
		''' <param name="name"></param>
		''' <param name="description"></param>
		Public Sub New(ByVal id As Guid, ByVal color As Color, ByVal name As String, ByVal description As String)
			_id = id
			_color = color
			_levelName = name
			_description = description
		End Sub

		''' <summary>
		''' Gets or sets level name. 
		''' </summary>
		Public Property LevelName() As String
			Get
				Return _levelName
			End Get
			Set
				If _levelName <> value Then
					_levelName = value
				End If
			End Set
		End Property

		''' <summary>
		''' Gets or sets level description. 
		''' </summary>
		Public Property Description() As String
			Get
				Return _description
			End Get
			Set
				If _description <> value Then
					_description = value
				End If
			End Set
		End Property

		''' <summary>
		''' Gets or sets level color. 
		''' </summary>
		Public Property Color() As Color
			Get
				Return _color
			End Get
			Set
				If Not _color.Equals(value) Then
					_color = value
				End If
			End Set
		End Property

		''' <summary>
		''' Gets or sets argb string, specifying the color of level.
		''' This property necessary for mapping color to the LabelStorage.
		''' </summary>
		Public Property ColorString() As String
			Get
				Return _color.A.ToString() + ", " + _color.R.ToString() + ", " + _color.G.ToString() + ", " + _color.B.ToString()
			End Get
			Set
				Dim tc As TypeConverter = TypeDescriptor.GetConverter(GetType(Color))
				_color = DirectCast(tc.ConvertFromInvariantString(value), Color)
			End Set
		End Property

		''' <summary>
		''' Unique Id of the Level.
		''' </summary>
		Public Property Id() As Guid
			Get
				Return _id
			End Get
			Set
				If _id <> value Then
					_id = value
				End If
			End Set
		End Property

		''' <summary>
		''' Returns LevelName.
		''' </summary>
		''' <returns></returns>
		Public Overloads Overrides Function ToString() As String
			Return LevelName
		End Function
	End Class

	''' <summary>
	''' Dictionary of Level objects.
	''' </summary>
	Public Class LevelCollection
		Inherits Dictionary(Of Guid, Level)
		''' <summary>
		''' Creates new LevelCollection object and fills it with the set
		''' of predefines Level objects.
		''' </summary>
		Public Sub New()
			LoadDefaults()
		End Sub

		''' <summary>
		''' Fills LevelCollection with the set of predefines Level objects.
		''' </summary>
		Public Sub LoadDefaults()
			Clear()
			Dim level As New Level(New Guid("{9EFA1881-A29D-461d-BC50-E8027B12DD4C}"), Color.White, "All", "All levels")
			Add(level.Id, level)
			level = New Level(New Guid("{DA09A26C-5AB3-460a-BD2C-E992B9E86E2B}"), Color.LightGoldenrodYellow, "Beginner", "Beginner")
			Add(level.Id, level)
			level = New Level(New Guid("{7669CE0F-888C-4c50-BB4C-52E592310DDB}"), Color.Orange, "Advanced", "Advanced")
			Add(level.Id, level)
			level = New Level(New Guid("{BF0B75A3-031C-457a-9A21-6B0C095AF673}"), Color.YellowGreen, "Intermediate", "Intermediate")
			Add(level.Id, level)
			level = New Level(New Guid("{002DFB0D-46D8-4b87-9B98-9B1D909B0249}"), Color.SkyBlue, "Course", "Course")
			Add(level.Id, level)
		End Sub
	End Class
End Namespace
