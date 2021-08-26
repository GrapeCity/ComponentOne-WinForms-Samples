using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ServiceProcess;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace C1ReportsScheduler
{
    public partial class MainForm
    {
        delegate void Command();

        private void InitCommandMap()
        {
            _commandMap = new Dictionary<object, Command>();
            // file commands:
            _commandMap.Add(fileNewToolStripMenuItem, new Command(FileNew));
            _commandMap.Add(fileSaveToolStripMenuItem, new Command(FileSave));
            _commandMap.Add(fileSaveAsToolStripMenuItem, new Command(FileSaveAs));
            _commandMap.Add(fileOpenToolStripMenuItem, new Command(FileOpen));
            _commandMap.Add(exitToolStripMenuItem, new Command(Exit));
            // task list commands:
            // _commandMap.Add(taskFocusToolStripMenuItem, new Command(TasksFocus));
            _commandMap.Add(tbtnTaskAdd, new Command(TasksAddNew));
            _commandMap.Add(taskAddToolStripMenuItem, new Command(TasksAddNew));
            _commandMap.Add(tbtnTaskRemove, new Command(TasksDeleteCurrent));
            _commandMap.Add(taskDeleteToolStripMenuItem, new Command(TasksDeleteCurrent));
            _commandMap.Add(tbtnTaskMoveUp, new Command(TasksMoveUp));
            _commandMap.Add(taskMoveUpToolStripMenuItem, new Command(TasksMoveUp));
            _commandMap.Add(tbtnTaskMoveDown, new Command(TasksMoveDown));
            _commandMap.Add(taskMoveDownToolStripMenuItem, new Command(TasksMoveDown));
            _commandMap.Add(taskCheckToolStripMenuItem, new Command(CheckCurrentTask));
            _commandMap.Add(taskPreviewToolStripMenuItem, new Command(PreviewCurrentTask));
            _commandMap.Add(tbtnTaskPreview, new Command(PreviewCurrentTask));
            _commandMap.Add(taskCheckAllToolStripMenuItem, new Command(CheckAllTasks));
            // action list commands:
            // _commandMap.Add(actionShowToolStripMenuItem, new Command(ActionFocus));
            _commandMap.Add(tbtnActionAdd, new Command(ActionsAddNew));
            _commandMap.Add(actionAddToolStripMenuItem, new Command(ActionsAddNew));
            _commandMap.Add(tbtnActionRemove, new Command(ActionsDeleteCurrent));
            _commandMap.Add(actionDeleteToolStripMenuItem, new Command(ActionsDeleteCurrent));
            _commandMap.Add(tbtnActionMoveUp, new Command(ActionsMoveUp));
            _commandMap.Add(actionMoveUpToolStripMenuItem, new Command(ActionsMoveUp));
            _commandMap.Add(tbtnActionMoveDown, new Command(ActionsMoveDown));
            _commandMap.Add(actionMoveDownToolStripMenuItem, new Command(ActionsMoveDown));
            _commandMap.Add(actionRunToolStripMenuItem, new Command(StartCurrentAction));
            _commandMap.Add(actionRunAllToolStripMenuItem, new Command(StartCurrentTask));
            // schedule:
            // _commandMap.Add(scheduleShowToolStripMenuItem, new Command(ScheduleFocus));
            _commandMap.Add(scheduleStartToolStripMenuItem, new Command(ScheduleStart));
            _commandMap.Add(scheduleStopToolStripMenuItem, new Command(ScheduleStop));
            _commandMap.Add(schedulePauseToolStripMenuItem, new Command(SchedulePause));
            _commandMap.Add(scheduleResumeToolStripMenuItem, new Command(SchedulePause));
            _commandMap.Add(btnScheduleStart, new Command(StartStopSchedule));
            _commandMap.Add(btnSchedulePause, new Command(PauseResumeSchedule));
            // service:
            _commandMap.Add(serviceConnectToolStripMenuItem, new Command(ConnectToService));
            _commandMap.Add(serviceDisconnectToolStripMenuItem, new Command(DisconnectFromService));
            _commandMap.Add(serviceTransferTasksToolStripMenuItem, new Command(TransferTasksToService));
            _commandMap.Add(serviceStartToolStripMenuItem, new Command(ServiceStart));
            _commandMap.Add(serviceStopToolStripMenuItem, new Command(ServiceStop));
            _commandMap.Add(servicePauseToolStripMenuItem, new Command(ServicePause));
            _commandMap.Add(serviceResumeToolStripMenuItem, new Command(ServiceResume));
            _commandMap.Add(serviceSetupToolStripMenuItem, new Command(ServiceSetup));
            _commandMap.Add(serviceInstallToolStripMenuItem, new Command(ServiceInstall));
            _commandMap.Add(serviceUninstallToolStripMenuItem, new Command(ServiceUninstall));
            _commandMap.Add(serviceLogToolStripMenuItem, new Command(ServiceLog));
            // help:
            _commandMap.Add(helpContentsToolStripMenuItem, new Command(ShowHelpContents));
            _commandMap.Add(helpAboutToolStripMenuItem, new Command(ShowAboutBox));
        }

        #region service commands
        private void ServiceInstall()
        {
            string question = string.Format("This will install {0} service on your system.\r\nDo you want to continue?", C1ReportsSchedulerService.Constants.Name);
            if (WinUtil.AskQuestion(question, false))
                ServiceSetup();
        }

        private void ServiceSetup()
        {
            // find out whether the service is installed or not:
            bool serviceInstalled = false;
            ServiceControllerStatus serviceStatus = ServiceControllerStatus.ContinuePending; // some assigned value
            using (ServiceController sc = new ServiceController(C1ReportsSchedulerService.Constants.Name))
            {
                try
                {
                    serviceStatus = sc.Status;
                    serviceInstalled = true;
                }
                catch
                {
                }
                finally
                {
                    sc.Close();
                }
            }

            // try getting values from registry, use defaults if unsuccessful:
            string sWcfEndpointBaseAddress = C1ReportsSchedulerService.Defaults.WcfEndpointBaseAddress;
            string sWcfEndpointRelAddress = C1ReportsSchedulerService.Defaults.WcfEndpointRelAddress;
            string sC1rsconfFilePath = string.Format(@"{0}\{1}{2}",
                Application.CommonAppDataPath, C1ReportsSchedulerService.Defaults.C1rsconfFileName, C1ReportsSchedulerService.Defaults.C1rsconfFileExt);
            bool sAutoStart = serviceInstalled ?
                ServiceInstaller.InstallService.GetAutoStartValue(C1ReportsSchedulerService.Constants.Name) : false;
            bool sLogTasks = C1ReportsSchedulerService.Defaults.LogTasks;
            bool sLogActions = C1ReportsSchedulerService.Defaults.LogActions;
            bool sLogProgramOutput = C1ReportsSchedulerService.Defaults.LogProgramOutput;
            bool sEnableMex = C1ReportsSchedulerService.Defaults.EnableMex;
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(C1ReportsSchedulerService.Constants.RegKey_Root))
                {
                    sWcfEndpointBaseAddress = key.GetValue(C1ReportsSchedulerService.Constants.RegKey_WcfEndpointBaseAddress) as string;
                    sWcfEndpointRelAddress = key.GetValue(C1ReportsSchedulerService.Constants.RegKey_WcfEndpointRelAddress) as string;
                    sC1rsconfFilePath = key.GetValue(C1ReportsSchedulerService.Constants.RegKey_C1rsconfFilePath) as string;
                    sLogTasks = (int)key.GetValue(C1ReportsSchedulerService.Constants.RegKey_LogTasks) != 0;
                    sLogActions = (int)key.GetValue(C1ReportsSchedulerService.Constants.RegKey_LogActions) != 0;
                    sLogProgramOutput = (int)key.GetValue(C1ReportsSchedulerService.Constants.RegKey_LogProgramOutput) != 0;
                    sEnableMex = (int)key.GetValue(C1ReportsSchedulerService.Constants.RegKey_EnableMex) != 0;
                }
            }
            catch
            {
                // eat errors here
            }

            // show dialog to set up service parameters (WCF comm address etc):
            using (ServiceInstallDialog sid = new ServiceInstallDialog())
            {
                sid.WcfEndpointBaseAddress = sWcfEndpointBaseAddress;
                sid.WcfEndpointRelAddress = sWcfEndpointRelAddress;
                sid.C1rsconfFilePath = sC1rsconfFilePath;
                sid.AutoStart = sAutoStart;
                sid.LogTasks = sLogTasks;
                sid.LogActions = sLogActions;
                sid.LogProgramOutput = sLogProgramOutput;
                sid.EnableMex = sEnableMex;
                if (sid.ShowDialog(this) != DialogResult.OK)
                    return;
                // copy back values from the dialog:
                sWcfEndpointBaseAddress = sid.WcfEndpointBaseAddress;
                sWcfEndpointRelAddress = sid.WcfEndpointRelAddress;
                sC1rsconfFilePath = sid.C1rsconfFilePath;
                sAutoStart = sid.AutoStart;
                sLogTasks = sid.LogTasks;
                sLogActions = sid.LogActions;
                sLogProgramOutput = sid.LogProgramOutput;
                sEnableMex = sid.EnableMex;
            }

            // install service if it is not installed, stop (so that the new settings will be applied) otherwise:
            using (ProgressDialog prg = new ProgressDialog())
            {
                if (!serviceInstalled)
                {
                    // install service:
                    prg.SetProgress(10, "Installing service...");
                    // find service executable (must be in same directory as current app):
                    string serviceExe = WinUtil.FindServiceExe();
                    if (string.IsNullOrEmpty(serviceExe))
                    {
                        WinUtil.ShowError(string.Format("Could not find the service executable {0}", WinUtil.ServiceExeName));
                        return;
                    }
                    // install service:
                    ServiceInstaller.InstallService.Install(serviceExe, C1ReportsSchedulerService.Constants.Name, C1ReportsSchedulerService.Constants.Name, sAutoStart);
                    ServiceInstaller.InstallService.SetDescription(C1ReportsSchedulerService.Constants.Name, C1ReportsSchedulerService.Constants.Description);
                }
                else
                {
                    DisconnectFromService();
                    // stop service (restart will pick up new settings):
                    ServiceCall(ServiceControllerStatus.Stopped, "Stopping", prg);
                    // update "autostart" parameter:
                    ServiceInstaller.InstallService.SetAutoStartValue(C1ReportsSchedulerService.Constants.Name, sAutoStart);
                }
                // set up service via additional registry keys:
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey(C1ReportsSchedulerService.Constants.RegKey_Root, true))
                {
                    key.SetValue(C1ReportsSchedulerService.Constants.RegKey_WcfEndpointBaseAddress, sWcfEndpointBaseAddress, RegistryValueKind.String);
                    key.SetValue(C1ReportsSchedulerService.Constants.RegKey_WcfEndpointRelAddress, sWcfEndpointRelAddress, RegistryValueKind.String);
                    key.SetValue(C1ReportsSchedulerService.Constants.RegKey_C1rsconfFilePath, sC1rsconfFilePath, RegistryValueKind.String);
                    key.SetValue(C1ReportsSchedulerService.Constants.RegKey_LogTasks, sLogTasks ? 1 : 0, RegistryValueKind.DWord);
                    key.SetValue(C1ReportsSchedulerService.Constants.RegKey_LogActions, sLogActions ? 1 : 0, RegistryValueKind.DWord);
                    key.SetValue(C1ReportsSchedulerService.Constants.RegKey_LogProgramOutput, sLogProgramOutput ? 1 : 0, RegistryValueKind.DWord);
                    key.SetValue(C1ReportsSchedulerService.Constants.RegKey_EnableMex, sEnableMex ? 1 : 0, RegistryValueKind.DWord);
                }
                // create event log:
                if (!EventLog.SourceExists(C1ReportsSchedulerService.Constants.EventLogSourceName))
                {
                    // optional but why not...
                    prg.SetProgress(prg.Complete + 5, "Creating service event log source...");
                    EventLog.CreateEventSource(C1ReportsSchedulerService.Constants.EventLogSourceName, C1ReportsSchedulerService.Constants.EventLogName);
                }
                // start service:
                ServiceStart(prg, false);
            }
        }

        private void ServiceUninstall()
        {
            string question = string.Format("This will remove {0} service from your system.\r\nDo you want to continue?", C1ReportsSchedulerService.Constants.Name);
            if (!WinUtil.AskQuestion(question, false))
                return;

            using (ProgressDialog prg = new ProgressDialog())
            {
                DisconnectFromService();
                ServiceCall(ServiceControllerStatus.Stopped, "Stopping", prg);
                prg.SetProgress(prg.Complete, "Uninstalling service...");
                ServiceInstaller.InstallService.Uninstall(C1ReportsSchedulerService.Constants.Name);
            }
        }

        private void ConnectToService()
        {
            if (CanConnectToService(true))
                using (ProgressDialog prg = new ProgressDialog())
                    ConnectToService(prg);
        }

        private void DisconnectFromService()
        {
            WcfDisconnect();
            NewTasks();
        }

        private void TransferTasksToService()
        {
            if (ClientMode)
                return;
            if (!WinUtil.AskQuestion("This will delete all tasks currently handled by the service, and restart it with the current task list.\r\nDo you want to continue?", true))
                return;
            using (ProgressDialog prg = new ProgressDialog())
            {
                ServiceCall(ServiceControllerStatus.Stopped, "Stopping", prg);
                ServiceStart(prg, true);
            }
        }

        private void ServiceStart()
        {
            using (ProgressDialog prg = new ProgressDialog())
                ServiceStart(prg, false);
        }

        private void ServiceStop()
        {
            DisconnectFromService();
            ServiceCall(ServiceControllerStatus.Stopped, "Stopping");
        }

        private void ServicePause()
        {
            ServiceCall(ServiceControllerStatus.Paused, "Pausing");
        }

        private void ServiceResume()
        {
            ServiceCall(ServiceControllerStatus.Running, "Resuming");
        }

        private void ServiceLog()
        {
            LogFormVisible = !LogFormVisible;
        }
        #endregion service commands

        #region file commands
        private void FileNew()
        {
            if (!ConfirmNewOrLoadTasks())
                return;
            NewTasks();
        }

        private void FileOpen()
        {
            try
            {
                if (!ConfirmNewOrLoadTasks())
                    return;
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = string.Format("{0} config files (*{1})|*{1}|All files (*.*)|*.*",
                        C1ReportsSchedulerService.Constants.Name, C1ReportsSchedulerService.Defaults.C1rsconfFileExt);
                    if (ofd.ShowDialog() == DialogResult.OK)
                        FileOpen(ofd.FileName);
                }
            }
            catch (Exception ex)
            {
                WinUtil.ShowError(string.Format("Could not load from the selected file: {0}", ex.Message));
                NewTasks();
            }
        }

        private void FileSave()
        {
            C1Settings.Save(this);
        }

        private void FileSaveAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = string.Format("{0} config files (*{1})|*{1}|All files (*.*)|*.*",
                C1ReportsSchedulerService.Constants.Name, C1ReportsSchedulerService.Defaults.C1rsconfFileExt);
            if (sfd.ShowDialog() == DialogResult.OK)
                SaveToFile(sfd.FileName);
        }

        private void Exit()
        {
            Application.Exit();
        }

        private void Clear()
        {
            if (_tasksHolder != null)
            {
                _tasksHolder.StopSchedules();
                Tasks.Clear();
            }
        }
        #endregion file commands

        #region task commands
        private void TasksFocus()
        {
            // this sequence moves input focus to the grid (unless it is readonly):
            _taskGrid.BeginEdit(false);
            _taskGrid.EndEdit();
        }

        private void PreviewCurrentTask()
        {
            TaskBase task = CurrentTask;
            if (!CurrentTaskIsReady || !task.Check(false))
                return;
            C1.Win.C1Preview.C1PrintPreviewDialog pview = new C1.Win.C1Preview.C1PrintPreviewDialog();
            pview.Show(this);
            pview.Document = task.Document;
        }

        /// <summary>
        /// Starts current task in a background thread
        /// Does not depend on schedule.
        /// </summary>
        private void StartCurrentTask()
        {
            if (!CurrentTaskIsReady)
                return;
            // todo: implement via schedule:
            throw new NotImplementedException();
        }

        private void CheckAllTasks()
        {
            foreach (TaskBase task in Tasks)
                task.Check(true);
        }

        private void CheckCurrentTask()
        {
            TaskBase task = CurrentTask;
            if (task != null)
            {
                task.Check(true);
                statusTextTask.Text = task.Message;
            }
        }

        private void TasksMoveUp()
        {
            long taskId = CurrentTaskId;
            if (taskId != Util.NullId)
            {
                _desiredTaskId = taskId;
                Tasks.MoveTask(taskId, false);
            }
        }

        private void TasksMoveDown()
        {
            long taskId = CurrentTaskId;
            if (taskId != Util.NullId)
            {
                _desiredTaskId = taskId;
                Tasks.MoveTask(taskId, true);
            }
        }

        private void TasksAddNew()
        {
            _desiredTaskId = Util.NewestId;
            Tasks.AddNew();
        }

        private void TasksDeleteCurrent()
        {
            int currRowIdx = CurrentTaskIndex;
            if (currRowIdx == -1)
                return;
            TaskBase task = Tasks[currRowIdx];
            if (!string.IsNullOrEmpty(task.FileName) &&
                !WinUtil.AskQuestion(string.Format("Remove report {0}/{1} from list?", task.FileName, task.ReportName), true))
                return;
            if (currRowIdx == _taskGrid.Rows.Count - 1)
                --currRowIdx;
            if (currRowIdx >= 0 && currRowIdx < _taskGrid.Rows.Count)
                _desiredTaskId = Tasks[currRowIdx].Id;
            Tasks.RemoveTask(task.Id);
        }
        #endregion task commands

        #region action commands
        private void ActionFocus()
        {
            // TODO.
        }

        private void StartCurrentAction()
        {
            if (!CurrentTaskIsReady || CurrentAction == null)
                return;
            // TODO.
            throw new NotImplementedException();
        }

        private void ActionsMoveUp()
        {
            if (!CurrentTaskIsReady)
                return;
            long actionId = CurrentActionId;
            if (actionId == Util.NullId)
                return;
            ActionList actions = CurrentActions;
            if (actions == null)
                return;
            _desiredActionId = actionId;
            actions.MoveAction(actionId, false);
        }

        private void ActionsMoveDown()
        {
            if (!CurrentTaskIsReady)
                return;
            long actionId = CurrentActionId;
            if (actionId == Util.NullId)
                return;
            ActionList actions = CurrentActions;
            if (actions == null)
                return;
            _desiredActionId = actionId;
            actions.MoveAction(actionId, true);
        }

        private void ActionsDeleteCurrent()
        {
            if (!CurrentTaskIsReady)
                return;
            int currRowIdx = CurrentActionIndex;
            if (currRowIdx == -1)
                return;
            ActionList actions = CurrentActions;
            if (actions == null)
                return;
            ActionBase action = actions[currRowIdx];
            if (!string.IsNullOrEmpty(action.OutputFileName) && !WinUtil.AskQuestion("Remove action from list?", true))
                return;
            if (currRowIdx == _actionGrid.Rows.Count - 1)
                --currRowIdx;
            if (currRowIdx >= 0 && currRowIdx < _actionGrid.Rows.Count)
                _desiredActionId = actions[currRowIdx].Id;
            actions.RemoveAction(action.Id);
        }

        private void ActionsAddNew()
        {
            if (!CurrentTaskIsReady)
                return;
            ActionList actions = CurrentActions;
            if (actions == null)
                return;
            _desiredActionId = Util.NewestId;
            actions.AddNew();
        }
        #endregion action commands

        #region schedule commands
        private void ScheduleFocus()
        {
            // TODO.
        }

        private void ScheduleStart()
        {
            StartStopSchedule();
        }

        private void ScheduleStop()
        {
            StartStopSchedule();
        }

        private void SchedulePause()
        {
            PauseResumeSchedule();
        }

        private void ScheduleResume()
        {
            PauseResumeSchedule();
        }

        private void StartStopSchedule()
        {
            TaskBase task = CurrentTask;
            if (task == null)
                return;
            bool start = !task.Schedule.Enabled;
            if (start)
            {
                System.Diagnostics.Debug.Assert(task.State == TaskState.Ready);
                if (task.Check(true))
                    task.Schedule.Enabled = true;
                else
                    WinUtil.ShowError(string.Format("Could not start schedule - task has errors: {0}", task.Message));
            }
            else
            {
                task.Schedule.Enabled = false;
            }
        }

        private void PauseResumeSchedule()
        {
            TaskBase task = CurrentTask;
            if (task == null || !task.Schedule.Enabled)
                return;
            task.Schedule.Paused = !task.Schedule.Paused;
        }
        #endregion file commands

        #region help
        private void ShowHelpContents()
        {
            ShowHelpForm();
        }

        private void ShowAboutBox()
        {
            ShowAboutForm();
        }
        #endregion help
    }
}
