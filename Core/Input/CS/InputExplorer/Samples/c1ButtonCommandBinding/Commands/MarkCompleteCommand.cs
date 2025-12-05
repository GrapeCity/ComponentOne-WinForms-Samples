#nullable enable
using InputExplorer.Samples.C1ButtonCommandBinding.ViewModels;
using System.Windows.Input;
using System;

namespace InputExplorer.Samples.C1ButtonCommandBinding.Commands
{
    // <summary>
    /// Command for marking the selected task as complete
    /// Can only execute when a task is selected and not already completed
    /// </summary>
    public class MarkCompleteCommand : ICommand
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
        public MarkCompleteCommand(TaskController controller)
        {
            _controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }

        /// <summary>
        /// Determines if a task can be marked complete
        /// Returns true when a task is selected and not already complete
        /// </summary>
        public bool CanExecute(object? parameter)
        {
            return _controller.CurrentTask != null &&
                   !_controller.CurrentTask.IsCompleted;
        }

        /// <summary>
        /// Executes the mark complete operation
        /// Sets the IsCompleted flag to true for the selected task
        /// </summary>
        public void Execute(object? parameter)
        {
            if (!CanExecute(parameter))
                return;

            // Mark the task as completed
            _controller.CurrentTask!.IsCompleted = true;
        }

        /// <summary>
        /// Raises the CanExecuteChanged event
        /// Call this when CurrentTask changes or its IsCompleted status changes
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
#nullable restore