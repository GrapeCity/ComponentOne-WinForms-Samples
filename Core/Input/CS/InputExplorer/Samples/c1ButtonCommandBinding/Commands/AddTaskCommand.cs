#nullable enable
using InputExplorer.Samples.C1ButtonCommandBinding.ViewModels;
using System;
using System.Windows.Input;

namespace InputExplorer.Samples.C1ButtonCommandBinding.Commands
{
    /// <summary>
    /// Command for adding a new task to the collection
    /// Can only execute when NewTaskDescription is not empty
    /// </summary>
    public class AddTaskCommand : ICommand
    {
        private readonly TaskController _controller;

        /// Event raised when CanExecute status changes
        public event EventHandler? CanExecuteChanged;

        public AddTaskCommand(TaskController controller)
        {
            _controller = controller ?? throw new ArgumentNullException(nameof(controller));
        }

        /// <summary>
        /// Determines if a new task can be added
        /// Returns true only when description is not empty or whitespace
        /// </summary>
        public bool CanExecute(object? parameter)
        {
            return !string.IsNullOrWhiteSpace(_controller.NewTaskDescription);
        }

        /// <summary>
        /// Executes the add task operation
        /// Creates a new TaskItem and adds it to the Tasks collection
        /// </summary>
        public void Execute(object? parameter)
        {
            if (!CanExecute(parameter))
                return;

            // Create new task from current description
            var newTask = new Models.TaskItem
            {
                Description = _controller.NewTaskDescription,
                IsCompleted = false
            };

            // Add to collection
            _controller.Tasks.Add(newTask);

            // Clear the input field
            _controller.NewTaskDescription = string.Empty;
        }

        /// <summary>
        /// Raises the CanExecuteChanged event
        /// Call this when NewTaskDescription changes
        /// </summary>
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
#nullable restore