using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.ServiceProcess;

namespace C1ReportsScheduler
{
    public partial class MainForm : Form
    {
        #region private data
        private TaskListHolder _tasksHolder = null;
        private TaskListStore _taskListStore = TaskListStore.AppConfigFile;
        private string _c1rsconfFileName = null;
        private TaskBase _currentTask = null;
        private HelpForm _helpForm = null;
        private LogForm _logForm = null;

        private Dictionary<object, Command> _commandMap;
        private TaskGridInfo _taskGridInfo = new TaskGridInfo();
        private ActionGridInfo _actionGridInfo = new ActionGridInfo();

        private static readonly Size c_btnImageSize = global::C1ReportsScheduler.Properties.Resources.Add.Size;
        private const int c_btnWidth = 22;
        private const int c_gridRowHeadersWidth = 32;
        private const int c_gridFileNameWidth = 170;
        private const int c_gridReportNameWidth = 150;
        private static readonly Dictionary<ReportKind, TaskKindName> c_taskKindNames;
        private static List<string> c_taskKinds;
        private readonly TimeSpan c_timeout = new TimeSpan(0, 0, 96);
        private Timer _timer = new Timer();
        private bool _inTimerTick = false;
        private long _desiredTaskId = Util.NullId;
        private long _desiredActionId = Util.NullId;
        private Label _lblPleaseAddTask = null;
        #endregion private data

        static MainForm()
        {
            c_taskKindNames = new Dictionary<ReportKind, TaskKindName>();
            c_taskKindNames.Add(ReportKind.XmlReport,
                new TaskKindName("C1Report", "C1Report component loaded from an XML report definition"));
            c_taskKindNames.Add(ReportKind.ImportedReport,
                new TaskKindName("Imported C1Report", "XML report definition imported into a C1PrintDocument component"));
            c_taskKindNames.Add(ReportKind.C1dDocument,
                new TaskKindName("C1PrintDocument", "C1D or C1DX document (possibly data-bound) loaded into a C1PrintDocument"));
            c_taskKindNames.Add(ReportKind.Program,
                new TaskKindName("External executable", "A user program generating and exporting a report or document"));
            c_taskKinds = new List<string>(c_taskKindNames.Count);
            foreach (TaskKindName tk in c_taskKindNames.Values)
                c_taskKinds.Add(tk.Name);
        }

        public MainForm()
        {
            InitializeComponent();

            // VS designer gets confused with the order of those, hence we have to do it manually:
            this.splitContainer1.Panel2MinSize = 300;

            // we need handle for invokers to work:
            base.CreateHandle();

            // set parent for modal dialogs:
            WinUtil.MainForm = this;

            this.FormClosing += new FormClosingEventHandler(MainForm_FormClosing);
            this.FormClosed += new FormClosedEventHandler(MainForm_FormClosed);

            InitTaskGrid();
            InitActionGrid();

            rbtScheduleOnce.CheckedChanged += new EventHandler(rbtScheduleFreq_CheckedChanged);
            rbtScheduleDaily.CheckedChanged += new EventHandler(rbtScheduleFreq_CheckedChanged);
            rbtScheduleWeekly.CheckedChanged += new EventHandler(rbtScheduleFreq_CheckedChanged);
            rbtScheduleMonthly.CheckedChanged += new EventHandler(rbtScheduleFreq_CheckedChanged);
            chkScheduleRepeat.CheckedChanged += new EventHandler(chkScheduleRepeat_CheckedChanged);

            InitCommandMap();

            // get into a consistent state:
            NewTasks();

            // if non client mode, offer to install or connect to service:
            TestClientModeOnStart();

            // load saved settings:
            C1Settings.Load(this);

            // start time for service ping
            _timer.Interval = 1001; // 1 sec
            _timer.Tick += new EventHandler(_timer_Tick);
            _timer.Start();
        }

        private void ShowAboutForm()
        {
            using (AboutForm af = new AboutForm(this))
                af.ShowDialog(this);
        }

        private void ShowHelpForm()
        {
            if (_helpForm != null)
                _helpForm.Visible = true;
            else
            {
                _helpForm = new HelpForm();
                _helpForm.Owner = this;
                _helpForm.FormClosing += new FormClosingEventHandler(_helpForm_FormClosing);
                UiSettings uiSettings = Properties.Settings.Default.UiSettings;
                if (uiSettings != null && !uiSettings.HelpFormBounds.IsEmpty)
                    _helpForm.Bounds = uiSettings.HelpFormBounds;
                _helpForm.Show(this);
            }
        }

        private void _helpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                ((HelpForm)sender).Visible = false;
            }
        }

        private void ShowLogForm()
        {
            if (_logForm != null)
                _logForm.Visible = true;
            else
            {
                _logForm = new LogForm();
                // _logForm.Owner = this;
                _logForm.FormClosing += new FormClosingEventHandler(_logForm_FormClosing);
                UiSettings uiSettings = Properties.Settings.Default.UiSettings;
                if (uiSettings != null && !uiSettings.LogFormBounds.IsEmpty)
                    _logForm.Bounds = uiSettings.LogFormBounds;
                _logForm.Show();
            }
        }

        public bool LogFormVisible
        {
            get
            {
                return _logForm != null && _logForm.Visible;
            }
            set
            {
                if (LogFormVisible)
                    _logForm.Visible = false;
                else
                    ShowLogForm();
            }
        }

        private void _logForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                ((LogForm)sender).Visible = false;
            }
        }

        private void TestClientModeOnStart()
        {
            if (Properties.Settings.Default.ClientMode)
                return;

            bool serviceInstalled;
            if (CanConnectToService(false, out serviceInstalled))
            {
                // connect to a running service:
                string text =
                    "You're about to start C1ReportsScheduler app in standalone mode.\r\n" +
                    "But, it appears that C1Reports scheduling service is installed and running.\r\n" +
                    "For full functionality it is highly recommended that you connect to the C1Reports scheduling service, " +
                    "and use the C1ReportsScheduler (this application) in client mode to communicate with the service.\r\n\r\n" +
                    "Do you want to connect to the service now?\r\n"
                    ;
                if (WinUtil.AskQuestion(text, false))
                {
                    Properties.Settings.Default.ClientMode = true;
                }
            }
            else if (serviceInstalled)
            {
                // warn about a stopped service:
                string text =
                    "You're about to start C1ReportsScheduler app in standalone mode.\r\n" +
                    "But, it appears that C1Reports scheduling service is installed but is not running.\r\n" +
                    "For full functionality it is highly recommended that you start the C1Reports scheduling service, " +
                    "and use the C1ReportsScheduler (this application) in client mode to communicate with the service.\r\n\r\n" +
                    "Use menu Service | Start to start the service and connect to it.\r\n"
                    ;
                WinUtil.ShowWarning(text);
            }
            else
            {
                // offer to install and start service:
                string text =
                    "You're about to start C1ReportsScheduler app in standalone mode.\r\n" +
                    "Standalone mode provides limited scheduling functionality, as scheduled reports will not run when the application is closed.\r\n" +
                    "For full functionality it is highly recommended that you install the C1Reports scheduling service, " +
                    "and use the C1ReportsScheduler (this application) in client mode to communicate with the service.\r\n\r\n" +
                    "Do you want to install the service now?\r\n\r\n" +
                    "(You can install or uninstall the service at any time via the \"Service\" menu.)"
                    ;
                if (WinUtil.AskQuestion(text, false))
                {
                    try
                    {
                        ServiceSetup();
                        Properties.Settings.Default.ClientMode = true;
                    }
                    catch (Exception ex)
                    {
                        WinUtil.ShowError(ex.Message);
                    }
                }
            }
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_inTimerTick || !ClientMode)
                return;

            _inTimerTick = true;
            try
            {
                using (ServiceController sc = new ServiceController(C1ReportsSchedulerService.Constants.Name))
                {
                    try
                    {
                        if (sc.Status == ServiceControllerStatus.Stopped || sc.Status == ServiceControllerStatus.StopPending ||
                            !_tasksHolder.Ping())
                        {
                            WinUtil.SuppressErrorDialog = true;
                            DisconnectFromService();
                        }
                    }
                    catch
                    {
                        DisconnectFromService();
                    }
                    finally
                    {
                        sc.Close();
                        WinUtil.SuppressErrorDialog = false;
                    }
                }
            }
            finally
            {
                _inTimerTick = false;
            }
        }

        public bool ClientMode
        {
            get { return _tasksHolder is TaskListHolderClient; }
        }

        public TaskListStore TaskListStore
        {
            get { return _taskListStore; }
            set
            {
                _taskListStore = value;
            }
        }

        public string C1rsconfFileName
        {
            get { return _c1rsconfFileName; }
            private set
            {
                _c1rsconfFileName = value;
                const string appname = "C1ReportsScheduler";
                string caption;
                if (ClientMode)
                    caption = string.Format("{0} - Client mode (connected to {1} service)", appname, C1ReportsSchedulerService.Constants.Name);
                else if (!string.IsNullOrEmpty(_c1rsconfFileName))
                    caption = string.Format("{0} - Standalone mode [{1}]", appname, _c1rsconfFileName);
                else
                    caption = string.Format("{0} - Standalone mode", appname);
                this.Text = caption;
            }
        }

        private void SetStatus(bool connected)
        {
            statusClientMode.Text = string.Format("[ {0} ]", connected ? "Client" : "Standalone");
            statusClientMode.Image = connected ?
                global::C1ReportsScheduler.Properties.Resources.ServiceConnected :
                global::C1ReportsScheduler.Properties.Resources.ServiceOffline;
            statusClientMode.ToolTipText = connected ?
                string.Format("Running in client mode, connected to {0}", C1ReportsSchedulerService.Constants.Name) :
                "Running in standalone mode.";
        }

        void _tasksHolder_ListChanged(object sender, ListChangedEventArgs e)
        {
            System.Diagnostics.Debug.Assert(!this.InvokeRequired, "Invokes should be handled by AsyncList");
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.ApplicationExitCall)
                && !ClientMode && _tasksHolder.Tasks.Count > 0)
            {
                string question = "C1ReportsScheduler is currently running in standalone mode.\r\n" +
                    "If you close it now, scheduled tasks will stop running. To keep them running, either keep the C1ReportsScheduler application open, " +
                    "or (recommended) install the C1ReportsScheduler service and transfer scheduled tasks to it via the \"Service\" menu.\r\n\r\n" +
                    "Continue closing C1ReportsScheduler application?";
                if (!WinUtil.AskQuestion(question, true))
                {
                    e.Cancel = true;
                    return;
                }
            }

            _tasksHolder.StopSchedules();
            if (_tasksHolder.Tasks is TaskListClient)
                ((TaskListClient)_tasksHolder.Tasks).Close();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            C1Settings.Save(this);
        }

        internal void ConnectToServiceOnLoad()
        {
            ConnectToService();
        }

        internal void SaveToFile(string fileName)
        {
            _tasksHolder.Save(fileName);
        }

        internal void FileOpen(string fileName)
        {
            try
            {
                LoadTasks(TaskListHolder.Load(fileName));
                C1rsconfFileName = fileName;
            }
            catch (Exception ex)
            {
                WinUtil.ShowError(ex.Message);
                C1rsconfFileName = null;
            }
        }

        /// <summary>
        /// The main (only) method for changing the task holder.
        /// (Can be called with new empty TaskListHolderServer to clear tasks.)
        /// </summary>
        /// <param name="tasks"></param>
        internal void LoadTasks(TaskListHolder tasks)
        {
            if (_currentTask != null)
                _currentTask.Schedule.Exit();
            // the only other place where _currentTask can be set is in _taskGrid_CurrentCellChanged:
            _currentTask = null;
            OnCurrentTaskChanged(true);
            C1rsconfFileName = null;
            if (_tasksHolder != null)
            {
                lock (_tasksHolder.SyncRoot)
                {
                    Clear();
                    _tasksHolder.ListChanged -= new ListChangedEventHandler(_tasksHolder_ListChanged);
                }
            }
            lock (tasks.SyncRoot)
            {
                _tasksHolder = tasks;
                _tasksHolder.Invoker = this;
                _tasksHolder.ListChanged += new ListChangedEventHandler(_tasksHolder_ListChanged);
                _taskGrid.DataSource = Tasks;
                CurrentTaskIndex = 0;
            }
            bool clientMode = this._tasksHolder is TaskListHolderClient;
            SetStatus(clientMode);
            C1rsconfFileName = null;
        }

        internal void NewTasks()
        {
            LoadTasks(new TaskListHolderServer());
        }

        private bool ConfirmNewOrLoadTasks()
        {
            if (ClientMode)
            {
                if (!WinUtil.AskQuestion(string.Format(
                    "Loading a new task list will disconnect from the {0} service and switch the application to standalone mode. Do you want to continue?",
                    C1ReportsSchedulerService.Constants.Name), true))
                    return false;
            }
            else if (Tasks.Count > 0)
            {
                if (!WinUtil.AskQuestion("Overwrite current task list?", true))
                    return false;
            }
            return true;
        }

        private void Command_Click(object sender, EventArgs e)
        {
            // avoid recursive command calls:
            if (!_timer.Enabled)
                return;

            // we turn service pinging off for the duration of the command.
            _timer.Stop();
            try
            {
                Command cmd = _commandMap[sender];
                cmd();
            }
            catch (Exception ex)
            {
                WinUtil.ShowError(ex.Message);
            }
            finally
            {
                _timer.Start();
            }
        }

        public TaskList Tasks
        {
            get { return _tasksHolder.Tasks; }
        }

        internal TaskListHolder TasksHolder
        {
            get { return _tasksHolder; }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {
            // fixes an MS bug:
            // this.taskTabControl.Invalidate();
        }

        private void fileToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {

        }

        private void taskToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            TaskBase task = CurrentTask;
            int taskIdx = CurrentTaskIndex;
            int taskCount = _taskGrid.Rows.Count;

            taskAddToolStripMenuItem.Enabled = true;
            taskDeleteToolStripMenuItem.Enabled = task != null && task.IsReady;
            taskMoveUpToolStripMenuItem.Enabled = taskIdx > 0;
            taskMoveDownToolStripMenuItem.Enabled = taskIdx >= 0 && taskIdx < taskCount - 1;
            taskPreviewToolStripMenuItem.Enabled = task != null && task.IsReady && task.ReportKind != ReportKind.Program;
            taskCheckToolStripMenuItem.Enabled = task != null && task.IsReady;
            taskCheckAllToolStripMenuItem.Enabled = taskCount > 0;
        }

        private void actionToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            TaskBase task = CurrentTask;
            ActionBase action = CurrentAction;
            ActionList actions = action == null ? null : action.Task.Actions;

            actionAddToolStripMenuItem.Enabled = task != null && task.IsReady;
            actionDeleteToolStripMenuItem.Enabled = actions != null && task.IsReady;
            actionMoveDownToolStripMenuItem.Enabled = actions != null && task.IsReady && actions.IndexOf(action) < actions.Count - 1;
            actionMoveUpToolStripMenuItem.Enabled = actions != null && task.IsReady && actions.IndexOf(action) > 0;
        }

        private void scheduleToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            // if service is not running, disable all schedule commands:
            bool serviceRunning;
            if (ClientMode)
            {
                using (ServiceController sc = new ServiceController(C1ReportsSchedulerService.Constants.Name))
                {
                    try
                    {
                        serviceRunning = sc.Status == ServiceControllerStatus.Running;
                    }
                    catch
                    {
                        serviceRunning = false;
                    }
                    finally
                    {
                        sc.Close();
                    }
                }
                if (!serviceRunning)
                {
                    btnScheduleStart.Enabled = false;
                    btnSchedulePause.Enabled = false;
                }
            }
            else
                serviceRunning = true;
            TaskBase task = CurrentTask;
            bool running = task != null && task.Schedule.Enabled;
            bool paused = task != null && task.Schedule.Paused;
            scheduleStartToolStripMenuItem.Enabled = serviceRunning && task != null && !running;
            scheduleStopToolStripMenuItem.Enabled = serviceRunning && running && !paused;
            schedulePauseToolStripMenuItem.Enabled = serviceRunning && running && !paused;
            scheduleResumeToolStripMenuItem.Enabled = serviceRunning && running && paused;
        }

        private void serviceToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            using (ServiceController sc = new ServiceController(C1ReportsSchedulerService.Constants.Name))
            {
                try
                {
                    ServiceControllerStatus status = sc.Status;
                    bool canConnect = status == ServiceControllerStatus.Paused || status == ServiceControllerStatus.Running;
                    this.serviceConnectToolStripMenuItem.Enabled = canConnect && !ClientMode;
                    this.serviceDisconnectToolStripMenuItem.Enabled = canConnect && ClientMode;
                    this.serviceTransferTasksToolStripMenuItem.Enabled = !ClientMode;
                    this.serviceStartToolStripMenuItem.Enabled = status == ServiceControllerStatus.Stopped;
                    this.serviceStopToolStripMenuItem.Enabled = status == ServiceControllerStatus.Running;
                    this.servicePauseToolStripMenuItem.Enabled = status == ServiceControllerStatus.Running;
                    this.serviceResumeToolStripMenuItem.Enabled = status == ServiceControllerStatus.Paused;
                    this.serviceSetupToolStripMenuItem.Enabled = true;
                    this.serviceInstallToolStripMenuItem.Enabled = false;
                    this.serviceUninstallToolStripMenuItem.Enabled = true;
                    this.serviceLogToolStripMenuItem.Checked = LogFormVisible;
                }
                catch
                {
                    this.serviceConnectToolStripMenuItem.Enabled = false;
                    this.serviceDisconnectToolStripMenuItem.Enabled = false;
                    this.serviceTransferTasksToolStripMenuItem.Enabled = false;
                    this.serviceStartToolStripMenuItem.Enabled = false;
                    this.serviceStopToolStripMenuItem.Enabled = false;
                    this.servicePauseToolStripMenuItem.Enabled = false;
                    this.serviceResumeToolStripMenuItem.Enabled = false;
                    this.serviceSetupToolStripMenuItem.Enabled = false;
                    this.serviceInstallToolStripMenuItem.Enabled = true;
                    this.serviceUninstallToolStripMenuItem.Enabled = false;
                    this.serviceLogToolStripMenuItem.Checked = false;
                }
                finally
                {
                    sc.Close();
                }
            }
        }
    }
}
