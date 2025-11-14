#nullable enable
using InputExplorer.Samples.C1ButtonCommandBinding.Commands;
using InputExplorer.Samples.C1ButtonCommandBinding.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace InputExplorer.Samples.C1ButtonCommandBinding.ViewModels
{
    /// <summary>
    /// Controller/ViewModel for task management
    /// Contains all business logic, data, and commands
    /// Implements MVVM pattern separating logic from UI
    /// </summary>
    public class TaskController : INotifyPropertyChanged
    {
        private BindingList<TaskItem> _tasks;
        private TaskItem? _currentTask;
        private string _newTaskDescription = string.Empty;

        /// <summary>
        /// Event raised when a property value changes
        /// </summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Collection of all tasks
        /// BindingList provides automatic UI notifications when items change
        /// </summary>
        public BindingList<TaskItem> Tasks
        {
            get => _tasks;
            set
            {
                _tasks = value;
                OnPropertyChanged(nameof(Tasks));
            }
        }

        /// <summary>
        /// Currently selected task in the UI
        /// Used by commands to determine what task to operate on
        /// </summary>
        public TaskItem? CurrentTask
        {
            get => _currentTask;
            set
            {
                if (_currentTask != value)
                {
                    // Unsubscribe from old task's property changes
                    if (_currentTask != null)
                    {
                        _currentTask.PropertyChanged -= OnCurrentTaskPropertyChanged;
                    }

                    _currentTask = value;

                    // Subscribe to new task's property changes
                    if (_currentTask != null)
                    {
                        _currentTask.PropertyChanged += OnCurrentTaskPropertyChanged;
                    }

                    OnPropertyChanged(nameof(CurrentTask));

                    // Update command states when selection changes
                    (DeleteTaskCommand as DeleteTaskCommand)?.RaiseCanExecuteChanged();
                    (MarkCompleteCommand as MarkCompleteCommand)?.RaiseCanExecuteChanged();
                }
            }
        }

        /// <summary>
        /// Text for creating a new task
        /// Bound to the input textbox
        /// </summary>
        public string NewTaskDescription
        {
            get => _newTaskDescription;
            set
            {
                if (_newTaskDescription != value)
                {
                    _newTaskDescription = value;
                    OnPropertyChanged(nameof(NewTaskDescription));

                    // Update AddTask command when description changes
                    (AddTaskCommand as AddTaskCommand)?.RaiseCanExecuteChanged();
                }
            }
        }

        /// <summary>
        /// Command to add a new task
        /// Enabled only when NewTaskDescription is not empty
        /// </summary>
        public ICommand AddTaskCommand { get; }

        /// <summary>
        /// Command to mark selected task as complete
        /// Enabled only when a task is selected and not already completed
        /// </summary>
        public ICommand MarkCompleteCommand { get; }

        /// <summary>
        /// Command to delete the selected task
        /// Enabled only when a task is selected
        /// </summary>
        public ICommand DeleteTaskCommand { get; }

        /// <summary>
        /// Command to clear all completed tasks
        /// Enabled only when there are completed tasks
        /// </summary>
        public ICommand ClearCompletedCommand { get; }

        /// <summary>
        /// Constructor - initializes data and commands
        /// </summary>
        public TaskController()
        {
            // Initialize the tasks collection with automatic change notification
            _tasks = new BindingList<TaskItem>();

            // Subscribe to collection changes to update ClearCompleted command
            _tasks.ListChanged += OnTasksListChanged;

            // Initialize all commands with specific command classes
            AddTaskCommand = new AddTaskCommand(this);
            MarkCompleteCommand = new MarkCompleteCommand(this);
            DeleteTaskCommand = new DeleteTaskCommand(this);
            ClearCompletedCommand = new ClearCompletedCommand(this);

            // Add some sample data for demonstration
            AddSampleData();
        }

        /// <summary>
        /// Adds sample tasks for demonstration purposes
        /// </summary>
        private void AddSampleData()
        {
            Tasks = new BindingList<TaskItem>
            {
                new() { Description = "Learn C1Command", IsCompleted = false },
                new() { Description = "Implement MVVM pattern", IsCompleted = true },
                new() { Description = "Test command binding", IsCompleted = false }
            };
        }

        /// <summary>
        /// Handles changes to the Tasks collection
        /// Updates ClearCompleted command availability
        /// </summary>
        private void OnTasksListChanged(object? sender, ListChangedEventArgs e)
        {
            // When tasks are added or removed, update ClearCompleted command
            (ClearCompletedCommand as ClearCompletedCommand)?.RaiseCanExecuteChanged();
        }

        /// <summary>
        /// Handles property changes on the currently selected task
        /// Updates command states when task properties change
        /// </summary>
        private void OnCurrentTaskPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            // If completion status changed, update relevant commands
            if (e.PropertyName == nameof(TaskItem.IsCompleted))
            {
                (MarkCompleteCommand as MarkCompleteCommand)?.RaiseCanExecuteChanged();
                (ClearCompletedCommand as ClearCompletedCommand)?.RaiseCanExecuteChanged();
            }
        }

        /// <summary>
        /// Raises the PropertyChanged event
        /// </summary>
        /// <param name="propertyName">Name of the property that changed</param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
#nullable restore