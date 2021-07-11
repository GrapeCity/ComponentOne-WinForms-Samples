using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Xml.Serialization;
using System.Text;
using C1.C1Preview;

namespace C1ReportsScheduler
{
    [XmlInclude(typeof(TaskServer))]
    public abstract class TaskBase : INotifyPropertyChanged
    {
        // public only because of XmlSerializer:
        [EditorBrowsable(EditorBrowsableState.Never)]
        public class TaskProxy
        {
            public long Id;
            public ReportKind ReportKind;
            public string FileName;
            public string ReportName;
            public string Message;
            public string[] ReportNames;
            public CheckedStatus CheckedStatus;
            public TaskState State;
        }

        #region data fields
        private readonly object _syncRoot = new object();
        private long _id = -1;
        internal const string c_reportNameNa = "n/a";
        protected TaskList _owner = null;
        protected ActionList _actions = null;
        protected ScheduleBase _schedule = null;
        protected CheckedStatus _checkedStatus = CheckedStatus.Unknown;
        protected CheckedStatus _checkedStatusBeforeLongOp = CheckedStatus.Unknown;
        protected TaskState _state = TaskState.Busy;
        protected string _message = string.Empty;
        #endregion data fields

        #region construction
        public TaskBase()
        {
            lock (SyncRoot)
            {
                _id = Util.NewId();
                InitDerived();
                State = TaskState.Ready;
            }
        }

        public TaskBase(TaskList owner)
        {
            lock (SyncRoot)
            {
                _id = Util.NewId();
                _owner = owner;
                InitDerived();
                State = TaskState.Ready;
            }
        }

        /// <summary>
        /// Called by the base ctor to initialize derived types, prior to setting ready state.
        /// </summary>
        protected abstract void InitDerived();

        protected void AssertIsReady()
        {
            if (State != TaskState.Ready)
            {
                AltUtil.ShowError("Task is not ready when it should have been.");
                throw new Util.ShouldNotHappenException();
            }
        }
        #endregion construction

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler;
            lock (SyncRoot)
                handler = PropertyChanged;

            if (handler != null)
            {
                ISynchronizeInvoke invoker = Invoker;
                if (invoker != null && invoker.InvokeRequired)
                    invoker.BeginInvoke(handler, new object[] { this, new PropertyChangedEventArgs(propertyName) });
                else
                    handler(this, new PropertyChangedEventArgs(propertyName));

                if (propertyName != "CheckedStatus" && propertyName != "State")
                {
                    CheckedStatus = CheckedStatus.Unknown;
                    lock (_actions.SyncRoot)
                        foreach (ActionBase action in _actions)
                            action.CheckedStatus = CheckedStatus.Unknown;
                }
            }
        }
        #endregion

        #region event handlers
        protected void _actions_AddingNew(object sender, AddingNewEventArgs e)
        {
            AssertIsReady();
        }
        #endregion event handlers

        #region public stored properties
        public abstract ReportKind ReportKind
        {
            get;
            set;
        }

        public abstract string FileName
        {
            get;
            set;
        }

        public abstract string ReportName
        {
            get;
            set;
        }

        [XmlArray(ElementName = "Actions")]
        [XmlArrayItem(ElementName = "Action")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual ActionBase[] ActionsCore
        {
            get { throw new Util.MustOverrideException(); }
            set { throw new Util.MustOverrideException(); }
        }

        // this is for XML serialization only
        [XmlElement("Schedule")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual ScheduleBase ScheduleCore
        {
            get { throw new Util.MustOverrideException(); }
            set { throw new Util.MustOverrideException(); }
        }
        #endregion public stored properties

        #region non-persisted public properties
        [XmlIgnore]
        protected object SyncRoot
        {
            get { return _syncRoot; }
        }

        [XmlIgnore]
        public TaskList Owner
        {
            get { return _owner; }
            internal set
            {
                System.Diagnostics.Debug.Assert(_owner == null);
                lock (SyncRoot)
                    _owner = value;
            }
        }

        [XmlIgnore]
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        [XmlIgnore]
        public int Index
        {
            get
            {
                TaskList owner = Owner;
                if (owner == null)
                    return -1;
                return owner.IndexOf(this);
            }
        }

        [XmlIgnore]
        public ISynchronizeInvoke Invoker
        {
            get
            {
                TaskList tasks = _owner;
                if (tasks == null)
                    return null;
                return tasks.Invoker;
            }
        }

        [XmlIgnore]
        public ScheduleBase Schedule
        {
            get { return _schedule; }
        }

        [XmlIgnore]
        public ActionList Actions
        {
            get { return _actions; }
        }

        [XmlIgnore]
        public string Message
        {
            get { return _message; }
            set
            {
                if (value != _message)
                {
                    lock (SyncRoot)
                        _message = value;
                    OnPropertyChanged("Message");
                }
            }
        }

        [XmlIgnore]
        public abstract string[] ReportNames
        {
            get;
        }

        [XmlIgnore]
        public abstract object Document
        {
            get;
        }

        [XmlIgnore]
        public TaskState State
        {
            get { return _state; }
            internal set
            {
                if (value != _state)
                {
                    lock (SyncRoot)
                        _state = value;
                    OnPropertyChanged("State");
                }
            }
        }

        [XmlIgnore]
        public bool IsReady
        {
            get { return State == TaskState.Ready; }
        }

        [XmlIgnore]
        public CheckedStatus CheckedStatus
        {
            get { return _checkedStatus; }
            internal set
            {
                if (value != _checkedStatus)
                {
                    lock (SyncRoot)
                        _checkedStatus = value;
                    OnPropertyChanged("CheckedStatus");
                }
            }
        }
        #endregion non-persisted public properties

        #region methods
        public abstract bool Check(bool checkActions);

        public abstract void Load();

        public abstract void UnLoad();

        public abstract void ScheduledRun(ScheduleBase runner);
        #endregion
    }

    public abstract class TaskList : AsyncBindingList<TaskBase>
    {
        private TaskListHolder _owner = null;

        [XmlIgnore]
        public TaskListHolder Owner
        {
            get { return _owner; }
            set
            {
                lock (SyncRoot)
                    _owner = value;
            }
        }

        public TaskBase TaskById(long id)
        {
            int index;
            return TaskById(id, out index);
        }

        // todo: optimize (hash table etc):
        public TaskBase TaskById(long id, out int index)
        {
            lock (SyncRoot)
            {
                for (int i = 0; i < Count; ++i)
                    if (this[i].Id == id)
                    {
                        index = i;
                        return this[i];
                    }
            }
            index = -1;
            return null;
        }

        public long TaskId(int taskIdx)
        {
            try
            {
                return this[taskIdx].Id;
            }
            catch
            {
                return Util.NullId;
            }
        }

        protected void OnTaskRemoved(TaskBase task)
        {
            lock (SyncRoot)
            {
                if (task.Owner == this)
                    task.Owner = null;
            }
        }

        public abstract void MoveTask(long taskId, bool down);

        public abstract void RemoveTask(long taskId);

        // public abstract void MoveAction(long taskId, int actionIndex, bool down);
    }

    [XmlRoot("C1ReportsSchedulerTasks")]
    [XmlInclude(typeof(TaskListHolderServer))]
    public abstract class TaskListHolder
    {
        private TaskList _tasks;
        private ISynchronizeInvoke _invoker = null;
        private readonly object _syncRoot = new object();

        public event ListChangedEventHandler ListChanged;

        public TaskListHolder()
        {
        }

        public object SyncRoot
        {
            get { return _syncRoot; }
        }

        public abstract bool Ping();

        [XmlIgnore]
        public ISynchronizeInvoke Invoker
        {
            get { return _invoker; }
            set
            {
                lock (SyncRoot)
                {
                    _invoker = value;
                    if (_tasks != null)
                        _tasks.Invoker = value;
                }
            }
        }

        [XmlIgnore]
        public TaskList Tasks
        {
            get { return _tasks; }
            protected set
            {
                lock (SyncRoot)
                {
                    if (_tasks != null)
                    {
                        lock (_tasks.SyncRoot)
                            _tasks.ListChanged -= new ListChangedEventHandler(_tasks_ListChanged);
                    }

                    _tasks = value;

                    if (_tasks != null)
                    {
                        lock (_tasks.SyncRoot)
                        {
                            _tasks.Invoker = _invoker;
                            _tasks.ListChanged += new ListChangedEventHandler(_tasks_ListChanged);
                        }
                    }
                }
            }
        }

        private void _tasks_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (ListChanged != null)
                ListChanged(this, e);
        }

        [XmlArray(ElementName = "Tasks")]
        [XmlArrayItem(ElementName = "Task")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public virtual TaskBase[] TasksCore
        {
            get;
            set;
        }

        protected abstract void TaskListLoaded();

        public void StopSchedules()
        {
            if (_tasks != null)
            {
                foreach (TaskBase t in _tasks)
                    t.Schedule.Exit();
            }
        }

        public abstract void Save(Stream s);

        public abstract void Save(string fileName);

        public static TaskListHolder Load(Stream s)
        {
            XmlSerializer xs = new XmlSerializer(typeof(TaskListHolderServer));
            TaskListHolder tasks = (TaskListHolder)xs.Deserialize(s);
            return tasks;
        }

        public static TaskListHolder Load(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
                return Load(fs);
        }
    }
}
