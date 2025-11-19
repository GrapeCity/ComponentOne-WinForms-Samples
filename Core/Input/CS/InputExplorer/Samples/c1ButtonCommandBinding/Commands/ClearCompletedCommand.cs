#nullable enable
using InputExplorer.Samples.C1ButtonCommandBinding.ViewModels;
using System.Windows.Input;
using System;
using System.Linq;

namespace InputExplorer.Samples.C1ButtonCommandBinding.Commands
{
    /// <summary>
    /// Command for removing all completed tasks from the collection
    /// Can only execute when there is at least one completed task
    /// </summary>
    public class ClearCompletedCommand : ICommand
    {
        private readonly TaskController _controller;

        /// <summary>
        /// Event raised when CanExecute status changes
        /// </summary>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="controller">Controller instance to work with</param>
        public ClearCompletedCommand(TaskController controller)
        {
            _controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }

        /// <summary>
        /// Determines if completed tasks can be cleared
        /// Returns true when at least one task is marked as completed
        /// </summary>
        public bool CanExecute(object? parameter)
        {
            // Check if any task is completed
            return _controller.Tasks.Any(t => t.IsCompleted);
        }

        /// <summary>
        /// Executes the clear completed operation
        /// Removes all tasks where IsCompleted is true
        /// </summary>
        public void Execute(object? parameter)
        {
            if (!CanExecute(parameter))
                return;

            // Remove all completed tasks
            // Iterate backwards to avoid index issues when removing
            for (int i = _controller.Tasks.Count - 1; i >= 0; i--)
            {
                if (_controller.Tasks[i].IsCompleted)
                {
                    _controller.Tasks.RemoveAt(i);
                }
            }
        }

        /// <summary>
        /// Raises the CanExecuteChanged event
        /// Call this when tasks are added/removed or completion status changes
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
#nullable restore