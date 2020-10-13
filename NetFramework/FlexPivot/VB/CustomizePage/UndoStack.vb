Namespace CustomizePage
	Public MustInherit Class UndoStack
		' ** fields

		Private _stack As New List(Of Object)()
		Private _current As Integer
		Private _updating As Boolean

		' ** constants

		Private Const MAX_STACK_SIZE As Integer = 12

		' ** ctor

		Public Sub New()
		End Sub

		' ** abstracts

		Public MustOverride Function GetCurrentState() As Object
		Public MustOverride Sub ApplySavedState(ByVal state As Object)

		' ** object model

		Public Sub Clear()
			_stack.Clear()
			_current = 0
		End Sub
		Public ReadOnly Property CanUndo() As Boolean
			Get
				Return _current > 0
			End Get
		End Property
		Public Function Undo() As Boolean
			If Not CanUndo Then
				Return False
			End If
			If _current = _stack.Count Then
				Dim ptr As Integer = _current
				SaveState()
				_current = ptr
			End If
			_current -= 1
			_updating = True
			RestoreState(_current)
			_updating = False
			Return True
		End Function
		Public ReadOnly Property CanRedo() As Boolean
			Get
				Return _current < _stack.Count - 1
			End Get
		End Property
		Public Function Redo() As Boolean
			If Not CanRedo Then
				Return False
			End If
			_updating = True
			_current += 1
			RestoreState(_current)
			_updating = False
			Return True
		End Function
		Public Function SaveState() As Boolean
			If _updating Then
				Return False
			End If

			Do While _stack.Count > _current
				_stack.RemoveAt(_stack.Count - 1)
			Loop
			Do While _stack.Count >= MAX_STACK_SIZE
				_stack.RemoveAt(0)
			Loop
			Dim state As Object = GetCurrentState()
			_stack.Add(state)
			_current = _stack.Count
			Return True
		End Function
		Private Function RestoreState(ByVal index As Integer) As Boolean
			If index < 0 OrElse index >= _stack.Count Then
				Return False
			End If
			Dim state As Object = _stack(index)
			ApplySavedState(state)
			Return True
		End Function
	End Class
End Namespace
