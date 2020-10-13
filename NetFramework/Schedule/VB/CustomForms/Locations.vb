Imports System
Imports System.Collections.Generic
Imports System.Text

Namespace TestSchedule
	''' <summary>
    ''' This class represents an Exercise location (for example, Studio or Pool).
	''' </summary>
	Class Location
		Private _id As Integer
		Private _name As String

		''' <summary>
		''' Creates new instance of Location object whith the specified parameters.
		''' </summary>
		''' <param name="id"></param>
		''' <param name="name"></param>
		Public Sub New(ByVal id As Integer, ByVal name As String)
			_id = id
			_name = name
		End Sub

		''' <summary>
		''' Gets or sets Location name.
		''' </summary>
		Public Property Name() As String
			Get
				Return _name
			End Get
			Set
				If _name <> value Then
					_name = value
				End If
			End Set
		End Property

		''' <summary>
		''' Unique Id of Location.
		''' </summary>
		Public Property Id() As Integer
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
		''' Returns LocationName.
		''' </summary>
		''' <returns></returns>
		Public Overloads Overrides Function ToString() As String
			Return Name
		End Function
	End Class
End Namespace
