using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Xml.Serialization;
using System.Text;
using C1.C1Preview;
using C1ReportsSchedulerService;

namespace C1ReportsScheduler
{
    public class TaskServer : TaskBase
    {
        protected ReportItemBase _item = new ReportItemXmlReport();

        public TaskServer()
            : base()
        {
        }

        public TaskServer(TaskListServer owner)
            : base(owner)
        {
        }

        protected override void InitDerived()
        {
            lock (SyncRoot)
            {
                _actions = new ActionListServer();
                _actions.SetOwner(this);
                _actions.AddingNew += new AddingNewEventHandler(_actions_AddingNew);
                _schedule = new ScheduleServer(this);
                _item.LongOperation += new LongOperationEventHandler(_item_LongOperation);
            }
        }

        internal string ToProxyXml()
        {
            lock (SyncRoot)
                return Util.ToXml(ToProxy(), typeof(TaskProxy));
        }

        private TaskProxy ToProxy()
        {
            TaskProxy proxy = new TaskProxy();
            proxy.Id = this.Id;
            proxy.ReportKind = this.ReportKind;
            proxy.FileName = this.FileName;
            proxy.ReportName = this.ReportName;
            proxy.Message = this.Message;
            proxy.ReportNames = this.ReportNames;
            proxy.CheckedStatus = this.CheckedStatus;
            proxy.State = this.State;
            return proxy;
        }

        #region event handlers
        private void _item_LongOperation(object sender, LongOperationEventArgs e)
        {
            if (CheckedStatus != CheckedStatus.Working)
                _checkedStatusBeforeLongOp = CheckedStatus;
            if (e.Complete < 1)
            {
                CheckedStatus = CheckedStatus.Working;
            }
            else
            {
                CheckedStatus = _checkedStatusBeforeLongOp;
                _checkedStatusBeforeLongOp = CheckedStatus.Unknown;
            }
        }
        #endregion event handlers

        #region public overridden public props
        public override ReportKind ReportKind
        {
            get { return _item.ReportKind; }
            set
            {
                if (value != _item.ReportKind)
                {
                    bool reportNameChanged = false;
                    lock (SyncRoot)
                    {
                        AssertIsReady();
                        // save file/report names:
                        string fileName = _item.FileName;
                        string reportName = _item.ReportName;
                        // change type
                        switch (value)
                        {
                            case ReportKind.XmlReport:
                                _item = new ReportItemXmlReport();
                                break;
                            case ReportKind.C1dDocument:
                                _item = new ReportItemC1dDocument();
                                break;
                            case ReportKind.ImportedReport:
                                _item = new ReportItemImportedReport();
                                break;
                            case ReportKind.Program:
                                _item = new ReportItemProgram();
                                break;
                            default:
                                Debug.Assert(false);
                                break;
                        }
                        // restore file/report names:
                        _item.FileName = fileName;
                        _item.ReportName = reportName;
                        // can happen if item changes from a report to a document/program:
                        reportNameChanged = _item.ReportName != reportName;
                    }
                    OnPropertyChanged("ReportKind");
                    if (reportNameChanged)
                        OnPropertyChanged("ReportName");
                }
            }
        }

        public override string FileName
        {
            get { return _item.FileName; }
            set
            {
                AssertIsReady();
                lock (SyncRoot)
                {
                    _item.UnLoad();
                    _item.FileName = value;
                }
                OnPropertyChanged("FileName");
            }
        }

        public override string ReportName
        {
            get
            {
                switch (this.ReportKind)
                {
                    case ReportKind.XmlReport:
                    case ReportKind.ImportedReport:
                        return _item.ReportName;
                    default:
                        return c_reportNameNa;
                }
            }
            set
            {
                AssertIsReady();
                lock (SyncRoot)
                {
                    _item.UnLoad();
                    _item.ReportName = value;
                }
                OnPropertyChanged("ReportName");
            }
        }

        // this is for XML serialization only
        [XmlArray(ElementName = "Actions")]
        [XmlArrayItem(ElementName = "Action")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ActionBase[] ActionsCore
        {
            get
            {
                ActionList tActions = _actions; // to avoid races
                lock (tActions.SyncRoot)
                {
                    ActionBase[] actions = new ActionBase[tActions.Count];
                    for (int i = 0; i < tActions.Count; ++i)
                        actions[i] = ActionServer.ToBase(tActions[i]);
                    return actions;
                }
            }
            set
            {
                lock (SyncRoot)
                {
                    ActionListServer actions = new ActionListServer();
                    lock (actions.SyncRoot)
                    {
                        _actions = actions;
                        for (int i = 0; i < value.Length; ++i)
                            _actions.Add(new ActionServer(value[i]));
                        _actions.SetOwner(this);
                    }
                }
            }
        }

        // this is for XML serialization only
        [XmlElement("Schedule")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override ScheduleBase ScheduleCore
        {
            get
            {
                return ScheduleServer.ToBase(_schedule);
            }
            set
            {
                lock (SyncRoot)
                {
                    if (_schedule != null)
                    {
                        if (_schedule.Enabled)
                            throw new InvalidOperationException();
                        _schedule.Exit();
                    }
                    _schedule = ScheduleServer.FromBase(value);
                    _schedule.SetOwner(this);
                }
            }
        }
        #endregion public overridden public props

        #region non-persisted public properties
        [XmlIgnore]
        public override string[] ReportNames
        {
            get { return _item.ReportNames; }
        }

        [XmlIgnore]
        public override object Document
        {
            get
            {
                if (!Check(false))
                    return null;
                try
                {
                    return _item.Document;
                }
                catch
                {
                    return null;
                }
            }
        }
        #endregion non-persisted public properties

        #region public methods
        public override void Load()
        {
            try
            {
                lock (SyncRoot)
                    _item.Load();
            }
            catch
            {
                // eat exceptions
            }
        }

        public override void UnLoad()
        {
            try
            {
                lock (SyncRoot)
                    _item.UnLoad();
            }
            catch
            {
                // eat exceptions
            }
        }

        public override bool Check(bool checkActions)
        {
            if (CheckedStatus != CheckedStatus.Unknown)
                return CheckedStatus != CheckedStatus.Invalid;

            bool ok = false;
            lock (SyncRoot)
            {
                ok = _item.Check(out _message);
                if (ok && checkActions)
                {
                    lock (_actions.SyncRoot)
                    {
                        if (_actions.Count == 0)
                        {
                            ok = false;
                            Message = "No actions defined.";
                        }
                        else
                        {
                            foreach (ActionServer a in _actions)
                                ok = a.Check() && ok; // for UI, it is better to check all actions
                        }
                    }
                }
            }
            if (checkActions)
                CheckedStatus = ok ? CheckedStatus.CheckedOk : CheckedStatus.Invalid;

            return ok;
        }

        /// <summary>
        /// Runs all actions synchronously, in the current thread.
        /// </summary>
        public override void ScheduledRun(ScheduleBase runner)
        {
            System.Diagnostics.Debug.Assert(runner == _schedule);
            if (State != TaskState.Scheduled)
                return; // this could happen if we were caught in a transitional state
            try
            {
                State = TaskState.Busy;
                CheckedStatus = CheckedStatus.Working;
                if (AltUtil.LogTasks)
                {
                    string taskLog = string.Format("Running task Id {0}: Type '{1}', File '{2}' (Report name '{3}').", Id, ReportKind, FileName, ReportName);
                    AltUtil.LogMessage(taskLog);
                }
                lock (_actions.SyncRoot)
                    foreach (ActionBase action in _actions)
                        action.Run();
                // unloading task ensures that reports are regenerated on each run:
                UnLoad();
            }
            catch
            {
                // Note: errors if any should've been logged by action.Run, hence we just throw them on here.
                // AltUtil.ShowError(string.Format("Error running task Id {0}: {1}.", Id, ex.Message));
                throw;
            }
            finally
            {
                CheckedStatus = CheckedStatus.CheckedOk;
                State = _schedule.Enabled ? TaskState.Scheduled : TaskState.Ready;
                if (AltUtil.LogTasks)
                    AltUtil.LogMessage(string.Format("Finished running task Id {0}.", Id));
            }
        }
        #endregion public methods
    }

    public class TaskListServer : TaskList
    {
        private IC1ReportsSchedulerWcf _wcfService = null;
        private IC1ReportsSchedulerWcfCallback _wcfCallback = null;
        private bool _movingTask = false;

        public TaskListServer()
            : base()
        {
        }

        internal IC1ReportsSchedulerWcf WcfService
        {
            get { return _wcfService; }
            set
            {
                lock (SyncRoot)
                    _wcfService = value;
            }
        }

        internal IC1ReportsSchedulerWcfCallback WcfCallback
        {
            get
            {
                return _wcfCallback;
            }
            set
            {
                lock (SyncRoot)
                    _wcfCallback = value;
            }
        }

        protected override void OnAddingNew(AddingNewEventArgs e)
        {
            e.NewObject = new TaskServer(this);
            base.OnAddingNew(e);
        }

        protected override void RemoveItem(int index)
        {
            lock (SyncRoot)
            {
                TaskBase task = this[index];
                if (!_movingTask)
                    task.Schedule.Exit();
                long id = task.Id;
                base.RemoveItem(index);
                if (_wcfCallback != null)
                    _wcfCallback.TaskRemoved(id);
            }
        }

        protected override void OnListChanged(ListChangedEventArgs e)
        {
            base.OnListChanged(e);

            if (_wcfCallback == null)
                return;

            switch (e.ListChangedType)
            {
                case ListChangedType.ItemAdded:
                    lock (SyncRoot)
                    {
                        if (e.NewIndex >= 0 && e.NewIndex < this.Count)
                            _wcfCallback.TaskAdded(e.NewIndex, TaskId(e.NewIndex), ((TaskServer)this[e.NewIndex]).ToProxyXml());
                    }
                    break;
                case ListChangedType.ItemChanged:
                    lock (SyncRoot)
                    {
                        if (e.NewIndex >= 0 && e.NewIndex < this.Count)
                        {
                            TaskServer task = (TaskServer)this[e.NewIndex];
                            _wcfCallback.TaskPropertyChanged(task.Id, task.ToProxyXml(), e.PropertyDescriptor.Name);
                            if (e.PropertyDescriptor.Name == "ReportKind")
                            {
                                foreach (ActionServer action in task.Actions)
                                {
                                    _wcfCallback.ActionPropertyChanged(task.Id, action.Id, action.ToProxyXml(), "ExportFormatNames");
                                    _wcfCallback.ActionPropertyChanged(task.Id, action.Id, action.ToProxyXml(), "ActionKinds");
                                }
                            }
                        }
                    }
                    break;
                case ListChangedType.ItemDeleted:
                    // we need removed task's id, hence TaskRemoved must be called from RemoveItem override:
                    // _wcfCallback.TaskRemoved(TaskId(e.NewIndex));
                    break;
                case ListChangedType.ItemMoved:
                    break;
                case ListChangedType.Reset:
                    break;
            }
        }

        public override void MoveTask(long taskId, bool down)
        {
            lock (SyncRoot)
            {
                int index;
                TaskBase task = this.TaskById(taskId, out index);
                if (task == null)
                    return;
                if (down && index >= this.Count - 1)
                    return;
                if (!down && index <= 0)
                    return;
                try
                {
                    _movingTask = true;
                    this.RemoveAt(index);
                    int newIdx = down ? index + 1 : index - 1;
                    this.Insert(newIdx, task);
                }
                finally
                {
                    _movingTask = false;
                }
            }
        }

        public override void RemoveTask(long taskId)
        {
            lock (SyncRoot)
            {
                int index;
                TaskBase task = this.TaskById(taskId, out index);
                if (task != null)
                    this.RemoveAt(index);
            }
        }
    }

    [XmlRoot("C1ReportsSchedulerTasks")]
    public class TaskListHolderServer : TaskListHolder
    {
        public TaskListHolderServer()
        {
            lock (SyncRoot)
                Tasks = new TaskListServer();
        }

        protected override void TaskListLoaded()
        {
        }

        public override bool Ping()
        {
            return true;
        }

        public override void Save(Stream s)
        {
            lock (SyncRoot)
            {
                XmlSerializer xs = new XmlSerializer(typeof(TaskListHolderServer));
                xs.Serialize(s, this);
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

        [XmlArray(ElementName = "Tasks")]
        [XmlArrayItem(ElementName = "Task")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override TaskBase[] TasksCore
        {
            get
            {
                lock (SyncRoot)
                {
                    lock (Tasks.SyncRoot)
                    {
                        TaskBase[] tasks = new TaskBase[Tasks.Count];
                        for (int i = 0; i < Tasks.Count; ++i)
                            tasks[i] = Tasks[i];
                        return tasks;
                    }
                }
            }
            set
            {
                lock (SyncRoot)
                {
                    Tasks = new TaskListServer();
                    lock (Tasks.SyncRoot)
                    {
                        for (int i = 0; i < value.Length; ++i)
                        {
                            value[i].Id = Util.NewId();
                            Tasks.Add(value[i]);
                            Tasks[i].Owner = Tasks;
                        }
                    }
                }
            }
        }
    }
}
