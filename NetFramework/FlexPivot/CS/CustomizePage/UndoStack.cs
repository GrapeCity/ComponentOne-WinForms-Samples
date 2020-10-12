using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace CustomizePage
{
	public abstract class UndoStack
	{
		// ** fields

		List<object> _stack = new List<object>();
        int _current;
        bool _updating;

		// ** constants

		private const int MAX_STACK_SIZE = 12;

		// ** ctor

		public UndoStack()
		{
		}

        // ** abstracts

        public abstract object GetCurrentState();
        public abstract void ApplySavedState(object state);

		// ** object model

		public void Clear()
		{
			_stack.Clear();
			_current = 0;
		}
		public bool CanUndo
		{
			get { return _current > 0; }
		}
		public bool Undo()
		{
			if (!CanUndo) return false;
            if (_current == _stack.Count)
			{
				int ptr = _current;
				SaveState();
				_current = ptr;
			}
			_current--;
            _updating = true;
            RestoreState(_current);
            _updating = false;
			return true;
		}
		public bool CanRedo
		{
			get { return _current < _stack.Count - 1; }
		}
		public bool Redo()
		{
			if (!CanRedo) return false;
            _updating = true;
            _current++;
			RestoreState(_current);
            _updating = false;
            return true;
		}
        public bool SaveState()
        {
            if (_updating)
            {
                return false;
            }

            while (_stack.Count > _current)
            {
                _stack.RemoveAt(_stack.Count - 1);
            }
            while (_stack.Count >= MAX_STACK_SIZE)
            {
                _stack.RemoveAt(0);
            }
            object state = GetCurrentState();
            _stack.Add(state);
            _current = _stack.Count;
            return true;
        }
        bool RestoreState(int index)
        {
            if (index < 0 || index >= _stack.Count) return false;
            object state = _stack[index];
            ApplySavedState(state);
            return true;
        }
    }
}
