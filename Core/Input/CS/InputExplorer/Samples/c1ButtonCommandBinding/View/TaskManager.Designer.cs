using System.Drawing;
using System.Windows.Forms;

namespace InputExplorer.Samples.C1ButtonCommandBinding.View
{
    partial class TaskManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            c1CommandHolder1 = new C1.Win.Command.C1CommandHolder();
            c1CommandAdd = new C1.Win.Command.C1Command();
            c1CommandMarkComplete = new C1.Win.Command.C1Command();
            c1CommandDelete = new C1.Win.Command.C1Command();
            c1CommandClearCompleted = new C1.Win.Command.C1Command();
            panelTop = new Panel();
            textBoxNewTask = new C1.Win.Input.C1TextBox();
            buttonAdd = new C1.Win.Input.C1Button();
            labelNewTask = new Label();
            labelTasks = new Label();
            panelBottom = new Panel();
            buttonClearCompleted = new C1.Win.Input.C1Button();
            buttonMarkComplete = new C1.Win.Input.C1Button();
            buttonDelete = new C1.Win.Input.C1Button();
            c1FlexGridTasks = new C1.Win.FlexGrid.C1FlexGrid();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)c1CommandHolder1).BeginInit();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxNewTask).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonAdd).BeginInit();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonClearCompleted).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonMarkComplete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexGridTasks).BeginInit();
            SuspendLayout();
            // 
            // c1CommandHolder1
            // 
            c1CommandHolder1.Commands.Add(c1CommandAdd);
            c1CommandHolder1.Commands.Add(c1CommandMarkComplete);
            c1CommandHolder1.Commands.Add(c1CommandDelete);
            c1CommandHolder1.Commands.Add(c1CommandClearCompleted);
            c1CommandHolder1.Owner = this;
            // 
            // c1CommandAdd
            // 
            c1CommandAdd.Name = "c1CommandAdd";
            c1CommandAdd.ShortcutText = "";
            c1CommandAdd.Text = "&Add Task";
            c1CommandAdd.ToolTipText = "Add a new task to the list";
            c1CommandAdd.Virgin = false;
            // 
            // c1CommandMarkComplete
            // 
            c1CommandMarkComplete.Name = "c1CommandMarkComplete";
            c1CommandMarkComplete.ShortcutText = "";
            c1CommandMarkComplete.Text = "&Mark Complete";
            c1CommandMarkComplete.ToolTipText = "Mark the selected task as complete";
            c1CommandMarkComplete.Virgin = false;
            // 
            // c1CommandDelete
            // 
            c1CommandDelete.Name = "c1CommandDelete";
            c1CommandDelete.ShortcutText = "";
            c1CommandDelete.Text = "&Delete";
            c1CommandDelete.ToolTipText = "Delete the selected task";
            c1CommandDelete.Virgin = false;
            // 
            // c1CommandClearCompleted
            // 
            c1CommandClearCompleted.Name = "c1CommandClearCompleted";
            c1CommandClearCompleted.ShortcutText = "";
            c1CommandClearCompleted.ShowTextAsToolTip = false;
            c1CommandClearCompleted.Text = "&Clear Completed";
            c1CommandClearCompleted.ToolTipText = "Remove all completed tasks";
            c1CommandClearCompleted.Virgin = false;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(textBoxNewTask);
            panelTop.Controls.Add(buttonAdd);
            panelTop.Controls.Add(labelNewTask);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(10);
            panelTop.Size = new Size(1048, 69);
            panelTop.TabIndex = 0;
            // 
            // textBoxNewTask
            // 
            textBoxNewTask.Location = new Point(131, 20);
            textBoxNewTask.Name = "textBoxNewTask";
            textBoxNewTask.Size = new Size(462, 28);
            textBoxNewTask.TabIndex = 4;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(599, 19);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(120, 28);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add Task";
            // 
            // labelNewTask
            // 
            labelNewTask.AutoSize = true;
            labelNewTask.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNewTask.Location = new Point(10, 23);
            labelNewTask.Name = "labelNewTask";
            labelNewTask.Size = new Size(114, 20);
            labelNewTask.TabIndex = 1;
            labelNewTask.Text = "Add New Task:";
            // 
            // labelTasks
            // 
            labelTasks.Dock = DockStyle.Top;
            labelTasks.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTasks.Location = new Point(0, 69);
            labelTasks.Name = "labelTasks";
            labelTasks.Padding = new Padding(10, 5, 0, 0);
            labelTasks.Size = new Size(1048, 31);
            labelTasks.TabIndex = 4;
            labelTasks.Text = "Tasks:";
            // 
            // panelBottom
            // 
            panelBottom.Controls.Add(buttonClearCompleted);
            panelBottom.Controls.Add(buttonMarkComplete);
            panelBottom.Controls.Add(buttonDelete);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 532);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(1048, 68);
            panelBottom.TabIndex = 6;
            // 
            // buttonClearCompleted
            // 
            buttonClearCompleted.Location = new Point(300, 12);
            buttonClearCompleted.Name = "buttonClearCompleted";
            buttonClearCompleted.Size = new Size(150, 30);
            buttonClearCompleted.TabIndex = 9;
            buttonClearCompleted.Text = "Clear Completed";
            // 
            // buttonMarkComplete
            // 
            buttonMarkComplete.Location = new Point(10, 12);
            buttonMarkComplete.Name = "buttonMarkComplete";
            buttonMarkComplete.Size = new Size(150, 30);
            buttonMarkComplete.TabIndex = 7;
            buttonMarkComplete.Text = "Mark Complete";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(170, 12);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(120, 30);
            buttonDelete.TabIndex = 8;
            buttonDelete.Text = "Delete";
            // 
            // c1FlexGridTasks
            // 
            c1FlexGridTasks.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None;
            c1FlexGridTasks.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            c1FlexGridTasks.Dock = DockStyle.Fill;
            c1FlexGridTasks.Location = new Point(0, 100);
            c1FlexGridTasks.Name = "c1FlexGridTasks";
            c1FlexGridTasks.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.Row;
            c1FlexGridTasks.Size = new Size(1048, 432);
            c1FlexGridTasks.TabIndex = 7;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 100;
            toolTip1.ReshowDelay = 500;
            // 
            // TaskManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(c1FlexGridTasks);
            Controls.Add(panelBottom);
            Controls.Add(labelTasks);
            Controls.Add(panelTop);
            Name = "TaskManager";
            Size = new Size(1048, 600);
            ((System.ComponentModel.ISupportInitialize)c1CommandHolder1).EndInit();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textBoxNewTask).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonAdd).EndInit();
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)buttonClearCompleted).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonMarkComplete).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexGridTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private C1.Win.Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.Command.C1Command c1CommandAdd;
        private C1.Win.Command.C1Command c1CommandMarkComplete;
        private C1.Win.Command.C1Command c1CommandDelete;
        private C1.Win.Command.C1Command c1CommandClearCompleted;
        private C1.Win.Input.C1Button buttonDelete;
        private C1.Win.Input.C1Button buttonMarkComplete;
        private Panel panelBottom;
        private Label labelTasks;
        private C1.Win.Input.C1Button buttonAdd;
        private Label labelNewTask;
        private Panel panelTop;
        private C1.Win.Input.C1Button buttonClearCompleted;
        private C1.Win.FlexGrid.C1FlexGrid c1FlexGridTasks;
        private C1.Win.Input.C1TextBox textBoxNewTask;
        private ToolTip toolTip1;
    }
}