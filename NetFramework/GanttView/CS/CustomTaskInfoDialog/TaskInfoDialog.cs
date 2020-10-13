using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1GanttView;

namespace CustomTaskInfoDialog
{
    public partial class TaskInfoDialog : Form
    {
        #region field

        private C1GanttView _ganttView;
        private Task _selectedTask;

        #endregion

        #region ctors

        public TaskInfoDialog()
        {
            InitializeComponent();
        }

        public TaskInfoDialog(C1GanttView ganttView)
            : this()
        {
            _ganttView = ganttView;
        }

        #endregion

        #region event handlers

        private void TaskInfoDialog_Load(object sender, EventArgs e)
        {
            List<Task> tasks = new List<Task>();
            TaskCollection taskColl = _ganttView.Tasks;
            foreach (Task task in taskColl)
            {
                if (!string.IsNullOrEmpty(task.Name))
                {
                    tasks.Add(task);
                }
            }
            cbTask.DataSource = tasks;
            cbTask.DisplayMember = "Name";
            cbTask.SelectedItem = _ganttView.SelectedTask;
        }

        private void cbTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedTask = (Task)cbTask.SelectedValue;
            tbTaskName.Text = _selectedTask.Name;
            tbResource.Text = _selectedTask.ResourceNames;
            tbStart.Text = _selectedTask.Start.Value.ToShortDateString();
            tbDuration.Text = _selectedTask.GetDurationInDays() + " day(s)";
            tbPercentComplete.Text = (_selectedTask.PercentComplete * 100).ToString("0.00");
        }

        #endregion

    }
}
