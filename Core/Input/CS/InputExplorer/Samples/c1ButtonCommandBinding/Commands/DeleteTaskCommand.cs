#nullable enable
using InputExplorer.Samples.C1ButtonCommandBinding.ViewModels;
using System.Windows.Input;
using System;

namespace InputExplorer.Samples.C1ButtonCommandBinding.Commands
{
    /// <summary>
    /// Command for deleting the currently selected task
    /// Can only execute when a task is selected
    /// </summary>
    public class DeleteTaskCommand : ICommand
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
        public DeleteTaskCommand(TaskController controller)
        {
            _controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }

        /// <summary>
        /// Determines if a task can be deleted
        /// Returns true only when a task is currently selected
        /// </summary>
        public bool CanExecute(object? parameter)
        {
            return _controller.CurrentTask != null;
        }

        /// <summary>
        /// Executes the delete task operation
        /// Removes the currently selected task from the collection
        /// </summary>
        public void Execute(object? parameter)
        {
            if (!CanExecute(parameter))
                return;

            // Remove the selected task
            _controller.Tasks.Remove(_controller.CurrentTask!);

            // Clear selection
            _controller.CurrentTask = null;
        }

        /// <summary>
        /// Raises the CanExecuteChanged event
        /// Call this when CurrentTask changes
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
#nullable restore