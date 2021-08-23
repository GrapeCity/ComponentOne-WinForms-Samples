using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Xml.Serialization;
using System.Text;
using System.ServiceModel;
using C1.C1Preview;

namespace C1ReportsScheduler
{
    public class TaskClient : TaskBase
    {
        private ReportKind _reportKind;
        private string _fileName;
        private string _reportName;
        private string[] _reportNames;

        public TaskClient()
            : base()
        {
        }

        public TaskClient(TaskListClient owner)
            : base(owner)
        {
        }

        protected override void InitDerived()
        {
            lock (SyncRoot)
            {
                ActionListClient actions = new ActionListClient();
                lock (actions.SyncRoot)
                {
                    _actions = actions;
                    _actions.SetOwner(this);
                    _actions.AddingNew += new AddingNewEventHandler(_actions_AddingNew);
                    _schedule = new ScheduleClient(this);
                }
            }
        }

        internal void FromProxyXml(string xml)
        {
            lock (SyncRoot)
                FromProxy((TaskProxy)Util.FromXml(xml, typeof(TaskProxy)));
        }

        private void FromProxy(TaskProxy proxy)
        {
            this.Id = proxy.Id;
            this._reportKind = proxy.ReportKind;
            this._fileName = proxy.FileName;
            this._reportName = proxy.ReportName;
            this._message = proxy.Message;
            this._reportNames = proxy.ReportNames;
            this._checkedStatus = proxy.CheckedStatus;
            this._state = proxy.State;
        }

        internal void CallPropertyChanged(string propertyName)
        {
            OnPropertyChanged(propertyName);
        }

        #region public overridden public props
        public override ReportKind ReportKind
        {
            get { return _reportKind; }
            set
            {
                ((TaskListClient)_owner).SetTaskProperty(this, "ReportKind", value.ToString());
            }
        }

        public override string FileName
        {
            get { return _fileName; }
            set
            {
                ((TaskListClient)_owner).SetTaskProperty(this, "FileName", value);
            }
        }

        public override string ReportName
        {
            get { return _reportName; }
            set
            {
                ((TaskListClient)_owner).SetTaskProperty(this, "ReportName", value);
            }
        }
        #endregion public overridden public props

        #region non-persisted public properties
        [XmlIgnore]
        public override string[] ReportNames
        {
            get { return _reportNames; }
        }

        [XmlIgnore]
        public override object Document
        {
            get
            {
                TaskListClient taskList = (TaskListClient)_owner;
                if (taskList.WcfClient == null)
                {
                    WinUtil.ShowErrorClientDisconnected();
                    return null;
                }
                string xml = taskList.WcfClient.SerializeDocument(Id);
                if (string.IsNullOrEmpty(xml))
                    return null;
                using (MemoryStream ms = new MemoryStream(UTF8Encoding.Default.GetBytes(xml)))
                    return C1PrintDocument.FromStream(ms, C1DocumentFormatEnum.C1dx);
            }
        }
        #endregion non-persisted public properties

        #region public methods
        public override void Load()
        {
            throw new Util.ShouldNotHappenException();
        }

        public override void UnLoad()
        {
            throw new Util.ShouldNotHappenException();
        }

        public override bool Check(bool checkActions)
        {
            TaskListClient taskList = (TaskListClient)_owner;
            if (taskList.WcfClient == null)
            {
                WinUtil.ShowErrorClientDisconnected();
                return false;
            }
            return taskList.WcfClient.CheckTask(Id, checkActions);
        }

        private void StartThread(object param)
        {
            throw new Util.ShouldNotHappenException();
        }

        public void StartAction(int actionIdx)
        {
            throw new Util.ShouldNotHappenException();
        }

        /// <summary>
        /// Runs all actions asynchronously, in a separate thread.
        /// </summary>
        public void StartAllActions()
        {
            StartAction(-1);
        }

        /// <summary>
        /// Runs all actions synchronously, in the current thread.
        /// </summary>
        public override void ScheduledRun(ScheduleBase runner)
        {
            throw new Util.ShouldNotHappenException();
        }
        #endregion public methods
    }

    public class TaskListClient : TaskList
    {
        #region WCF callback class (supports events fired on server)
        /// <summary>
        /// Used by the service to invoke property changed type events on the client.
        /// </summary>
        [CallbackBehaviorAttribute(
            IncludeExceptionDetailInFaults = true,
            UseSynchronizationContext = false,
            ConcurrencyMode = ConcurrencyMode.Multiple
        )]
        public class WcfCallback : IC1ReportsSchedulerWcfCallback
        {
            private TaskListClient _owner = null;

            public WcfCallback()
            {
            }

            public TaskListClient Owner
            {
                get { return _owner; }
                set { _owner = value; }
            }

            public void TaskPropertyChanged(long taskId, string taskXml, string propertyName)
            {
                if (_owner != null)
                    _owner.CallTaskPropertyChanged(taskId, taskXml, propertyName);
            }

            public void ActionPropertyChanged(long taskId, long actionId, string actionXml, string propertyName)
            {
                if (_owner != null)
                    _owner.CallActionPropertyChanged(taskId, actionId, actionXml, propertyName);
            }

            public void SchedulePropertyChanged(long taskId, string scheduleXml, string propertyName)
            {
                if (_owner != null)
                    _owner.CallSchedulePropertyChanged(taskId, scheduleXml, propertyName);
            }

            public void TaskAdded(int index, long taskId, string taskXml)
            {
                if (_owner != null)
                    _owner.TaskAdded(index, taskId, taskXml);
            }

            public void TaskRemoved(long taskId)
            {
                if (_owner != null)
                    _owner.TaskRemoved(taskId);
            }

            public void ActionAdded(long taskId, int actionIndex, long actionId, string actionXml)
            {
                if (_owner != null)
                    _owner.ActionAdded(taskId, actionIndex, actionId, actionXml);
            }

            public void ActionRemoved(long taskId, long actionId)
            {
                if (_owner != null)
                    _owner.ActionRemoved(taskId, actionId);
            }
        }
        #endregion

        private C1ReportsSchedulerWcfClient _wcfClient = null;
        private WcfCallback _wcfCallback = null;

        public TaskListClient(C1ReportsSchedulerWcfClient wcfClient, TaskListClient.WcfCallback wcfCallback, ProgressCallback progressCbk)
        {
            if (wcfClient == null || wcfCallback == null)
            {
                WinUtil.ShowErrorClientDisconnected();
                return;
            }

            lock (SyncRoot)
            {
                _wcfClient = wcfClient;
                _wcfCallback = wcfCallback;
                _wcfCallback.Owner = this;

                _wcfClient.Connect();

                int count = _wcfClient.GetTaskCount();
                for (int i = 0; i < count; ++i)
                {
                    if (progressCbk != null)
                        progressCbk(0, count, i);
                    long id = _wcfClient.GetTaskId(i);
                    TaskClient task = new TaskClient(this);
                    UpdateTaskFromServer(task, id, _wcfClient.GetTaskXml(id));
                    Add(task);
                }
            }
        }

        public void Disconnect()
        {
            if (_wcfClient == null)
            {
                WinUtil.ShowErrorClientDisconnected();
                _wcfCallback = null;
                return;
            }

            try
            {
                lock (SyncRoot)
                {
                    _wcfClient.Disconnect("Client disconnect.");
                    _wcfCallback.Owner = null;
                    _wcfClient = null;
                    _wcfCallback = null;
                }
            }
            catch (Exception ex)
            {
                WinUtil.ShowError(ex.Message);
            }
            finally
            {
                _wcfClient = null;
                _wcfCallback = null;
            }
        }

        internal C1ReportsSchedulerWcfClient WcfClient
        {
            get { return _wcfClient; }
        }

        private void UpdateTaskFromServer(TaskClient task, long taskId, string taskXml)
        {
            if (_wcfClient == null)
                WinUtil.ShowErrorClientDisconnected();

            lock (SyncRoot)
            {
                task.FromProxyXml(taskXml);
                int actionCount = _wcfClient.GetActionCount(taskId);
                lock (task.Actions.SyncRoot)
                {
                    for (int j = 0; j < actionCount; ++j)
                    {
                        ActionClient action = new ActionClient(task);
                        action.FromProxyXml(_wcfClient.GetActionXml(taskId, _wcfClient.GetActionId(taskId, j)));
                        task.Actions.Add(action);
                    }
                }
                ((ScheduleClient)task.Schedule).FromProxyXml(_wcfClient.GetScheduleXml(taskId));
            }
        }

        public void Close()
        {
            Disconnect();
        }

        private void CallTaskPropertyChanged(long taskId, string taskXml, string propertyName)
        {
            TaskClient task;
            lock (SyncRoot)
            {
                task = TaskById(taskId) as TaskClient;
                if (task == null)
                    return;
                task.FromProxyXml(taskXml);
            }
            task.CallPropertyChanged(propertyName);
        }

        private void CallActionPropertyChanged(long taskId, long actionId, string actionXml, string propertyName)
        {
            try
            {
                ActionClient action;
                lock (SyncRoot)
                {
                    TaskBase task = TaskById(taskId);
                    if (task == null)
                        return;
                    action = task.Actions.ActionById(actionId) as ActionClient;
                    if (action == null)
                        return; // can happen if the action has just been added on the server
                    action.FromProxyXml(actionXml);
                }
                action.CallPropertyChanged(propertyName);
            }
            catch (Exception ex)
            {
                AltUtil.ShowError(ex.Message);
            }
        }

        private void CallSchedulePropertyChanged(long taskId, string scheduleXml, string propertyName)
        {
            ScheduleClient schedule;
            lock (SyncRoot)
            {
                TaskBase task = TaskById(taskId);
                if (task == null)
                    return;
                schedule = (ScheduleClient)task.Schedule;
                schedule.FromProxyXml(scheduleXml);
            }
            schedule.CallPropertyChanged(propertyName);
        }

        private void TaskAdded(int index, long taskId, string taskXml)
        {
            lock (SyncRoot)
            {
                TaskClient task = new TaskClient(this);
                UpdateTaskFromServer(task, taskId, taskXml);
                this.Insert(index, task);
            }
        }

        private void TaskRemoved(long taskId)
        {
            lock (SyncRoot)
            {
                int index;
                TaskBase task = TaskById(taskId, out index);
                if (task != null)
                    this.RemoveAt(index);
            }
        }

        private void ActionAdded(long taskId, int actionIndex, long actionId, string actionXml)
        {
            lock (SyncRoot)
            {
                TaskBase task = TaskById(taskId);
                if (task != null)
                {
                    ActionClient action = new ActionClient(task);
                    action.FromProxyXml(actionXml);
                    System.Diagnostics.Debug.Assert(actionId == action.Id);
                    lock (task.Actions.SyncRoot)
                        task.Actions.Insert(actionIndex, action);
                }
            }
        }

        private void ActionRemoved(long taskId, long actionId)
        {
            lock (SyncRoot)
            {
                TaskBase task = TaskById(taskId);
                if (task != null)
                {
                    int index;
                    if (task.Actions.ActionById(actionId, out index) != null)
                        lock (task.Actions.SyncRoot)
                            task.Actions.RemoveAt(index);
                }
            }
        }

        public void SetTaskProperty(TaskBase task, string propertyName, string propertyValue)
        {
            if (_wcfClient == null)
                WinUtil.ShowErrorClientDisconnected();
            else
                _wcfClient.SetTaskProperty(task.Id, propertyName, propertyValue);
        }

        public void SetActionProperty(TaskBase task, ActionBase action, string propertyName, string propertyValue)
        {
            if (_wcfClient == null)
                WinUtil.ShowErrorClientDisconnected();
            else
                _wcfClient.SetActionProperty(task.Id, action.Id, propertyName, propertyValue);
        }

        public void SetScheduleProperty(TaskBase task, string propertyName, string propertyValue)
        {
            if (_wcfClient == null)
                WinUtil.ShowErrorClientDisconnected();
            else
                _wcfClient.SetScheduleProperty(task.Id, propertyName, propertyValue);
        }

        public override void MoveTask(long taskId, bool down)
        {
            if (_wcfClient == null)
                WinUtil.ShowErrorClientDisconnected();
            else
                _wcfClient.MoveTask(taskId, down);
        }

        public override void RemoveTask(long taskId)
        {
            if (_wcfClient == null)
                WinUtil.ShowErrorClientDisconnected();
            else
                _wcfClient.RemoveTask(taskId);
        }

        protected override object AddNewCore()
        {
            if (_wcfClient == null)
            {
                WinUtil.ShowErrorClientDisconnected();
                CancelNew(this.Count);
                return null;
            }

            lock (SyncRoot)
            {
                // We do not want to really add a new task.
                // Instead, we tell the server to do that, and cancel our own adding.
                // The server will tell us that it has added a task, and we will update then.
                _wcfClient.AddTask();
                CancelNew(this.Count);
                return null;
            }
        }

        protected override void OnAddingNew(AddingNewEventArgs e)
        {
            throw new Util.ShouldNotHappenException();
        }
    }

    public class TaskListHolderClient : TaskListHolder
    {
        public TaskListHolderClient(ISynchronizeInvoke invoker, string wcfEndpointAddress, ProgressCallback progressCbk)
        {
            this.Invoker = invoker;

            TaskListClient.WcfCallback callback = new TaskListClient.WcfCallback();

#if wcf_http
            C1ReportsSchedulerWcfClient wcfClient = new C1ReportsSchedulerWcfClient(
                new InstanceContext(callback),
                new WSDualHttpBinding(),
                new EndpointAddress(wcfEndpointAddress));
#else
            // NOTE: without increasing quotas, preview e.g. does not work for even
            // small documents.
            var ntb = new NetTcpBinding();
            ntb.ReaderQuotas.MaxArrayLength *= 16;
            ntb.ReaderQuotas.MaxBytesPerRead *= 16;
            ntb.ReaderQuotas.MaxDepth *= 16;
            ntb.ReaderQuotas.MaxNameTableCharCount *= 16;
            ntb.ReaderQuotas.MaxStringContentLength = int.MaxValue;
            ntb.MaxReceivedMessageSize = int.MaxValue;
            C1ReportsSchedulerWcfClient wcfClient = new C1ReportsSchedulerWcfClient(
                new InstanceContext(callback),
                ntb,
                new EndpointAddress(wcfEndpointAddress));
#endif

            wcfClient.InnerChannel.Closed += new EventHandler(InnerChannel_Closed);
            wcfClient.InnerChannel.Faulted += new EventHandler(InnerChannel_Faulted);

            Tasks = new TaskListClient(wcfClient, callback, progressCbk);
        }

        public override bool Ping()
        {
            TaskListClient taskList = (TaskListClient)Tasks;
            if (taskList.WcfClient == null)
            {
                WinUtil.ShowErrorClientDisconnected();
                return false;
            }
            try
            {
                return taskList.WcfClient.Ping();
            }
            catch (Exception ex)
            {
                WinUtil.ShowError(ex.Message);
                return false;
            }
        }

        public string GetServiceAboutString()
        {
            string err = "Error: could not get about info from service.";

            TaskListClient taskList = (TaskListClient)Tasks;
            if (taskList.WcfClient == null)
            {
                WinUtil.ShowErrorClientDisconnected();
                return err;
            }
            try
            {
                return taskList.WcfClient.GetAboutString();
            }
            catch
            {
                return err;
            }
        }

        public void WcfDisconnect()
        {
            ((TaskListClient)Tasks).Disconnect();
        }

        void InnerChannel_Faulted(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            IClientChannel channel = (IClientChannel)sender;
            /*
            channel.Dispose();
            _wcfClient.Close();
            _wcfClient = null;
             */
        }

        void InnerChannel_Closed(object sender, EventArgs e)
        {
            // throw new NotImplementedException();
            IClientChannel channel = (IClientChannel)sender;
            /*
            channel.Dispose();
            _wcfClient.Close();
            _wcfClient = null;
             */
        }

        protected override void TaskListLoaded()
        {
        }

        public override void Save(Stream s)
        {
            TaskListClient taskList = (TaskListClient)Tasks;
            if (taskList.WcfClient == null)
            {
                WinUtil.ShowErrorClientDisconnected();
                return;
            }
            lock (SyncRoot)
            {
                string xml = taskList.WcfClient.SerializeTaskListHolder();
                TaskListHolderServer tholder = Util.FromXml(xml, typeof(TaskListHolderServer)) as TaskListHolderServer;
                tholder.Save(s);
            }
        }

        public override void Save(string fileName)
        {
            lock (SyncRoot)
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create))
                    Save(fs);
            }
        }
    }
}
