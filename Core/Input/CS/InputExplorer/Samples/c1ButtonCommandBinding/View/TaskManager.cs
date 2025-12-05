#nullable enable
using InputExplorer.Properties;
using InputExplorer.Samples.C1ButtonCommandBinding.ViewModels;
using System.Windows.Forms;

namespace InputExplorer.Samples.C1ButtonCommandBinding.View
{
    public partial class TaskManager : UserControl
    {
        private TaskController _controller;

        public TaskManager()
        {
            InitializeComponent();
            InitializeController();
            SetText();
        }

        private void InitializeController()
        {
            // Create the controller instance
            _controller = new TaskController();

            // Bind C1FlexGrid to the Tasks collection
            c1FlexGridTasks.DataSource = _controller.Tasks;
            c1FlexGridTasks.AutoSizeCol(1);

            // Bind TextBox to NewTaskDescription property with two-way binding
            textBoxNewTask.DataBindings.Add(
                "Text",
                _controller,
                nameof(TaskController.NewTaskDescription),
                false,
                DataSourceUpdateMode.OnPropertyChanged
            );

            c1FlexGridTasks.AfterRowColChange += OnFlexGridSelectionChanged;

            BindCommands();
        }

        /// <summary>
        /// Binds ICommand implementations to C1Button.Command properties.
        /// This is the key feature being demonstrated: C1Button.Command automatically handles
        /// both Click events and Enabled state synchronization, replacing the traditional
        /// manual approach of subscribing to Click events and CanExecuteChanged events.
        /// </summary>
        private void BindCommands()
        {
            // Directly bind commands to C1Button.Command property
            // This automatically handles Click events and Enabled state!
            buttonAdd.Command = _controller.AddTaskCommand;
            buttonMarkComplete.Command = _controller.MarkCompleteCommand;
            buttonDelete.Command = _controller.DeleteTaskCommand;
            buttonClearCompleted.Command = _controller.ClearCompletedCommand;
        }

        private void SetText()
        {
            labelNewTask.Text = Resources.Label_NewTask;
            labelTasks.Text = Resources.Label_Tasks;

            buttonAdd.Text = Resources.Button_AddTask;
            buttonMarkComplete.Text = Resources.Button_MarkComplete;
            buttonDelete.Text = Resources.Button_Delete;
            buttonClearCompleted.Text = Resources.Button_ClearCompleted;

            toolTip1.SetToolTip(buttonAdd, Resources.Tooltip_AddTask);
            toolTip1.SetToolTip(buttonMarkComplete, Resources.Tooltip_MarkComplete);
            toolTip1.SetToolTip(buttonDelete, Resources.Tooltip_Delete);
            toolTip1.SetToolTip(buttonClearCompleted, Resources.Tooltip_ClearCompleted);
        }

        /// <summary>
        /// Handles selection changes in the C1FlexGrid
        /// C1FlexGrid SelectionChanged uses RangeEventHandler delegate
        /// </summary>
        private void OnFlexGridSelectionChanged(object? sender, C1.Win.FlexGrid.RangeEventArgs e)
        {
            // C1FlexGrid row 0 is the header row, data starts at row 1
            // Check if a valid data row is selected (row > 0)
            if (c1FlexGridTasks.Row > 0 && c1FlexGridTasks.Row < c1FlexGridTasks.Rows.Count)
            {
                int dataIndex = c1FlexGridTasks.Row - 1;  // Subtract 1 for header row

                if (dataIndex >= 0 && dataIndex < _controller.Tasks.Count)
                {
                    _controller.CurrentTask = _controller.Tasks[dataIndex];
                    return;
                }
            }

            // No valid row selected (header or out of range)
            _controller.CurrentTask = null;
        }
    }
}
#nullable restore