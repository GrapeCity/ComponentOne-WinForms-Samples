using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Drawing.Printing;
using C1.C1Preview;
using C1.C1Preview.Export;
using C1.C1Report;

namespace C1ReportsScheduler
{
    /// <summary>
    /// Represents an action that may be performed on a <see cref="Task"/>,
    /// such as export or print.
    /// </summary>
    public class ActionBase : INotifyPropertyChanged
    {
        // public only because of XmlSerializer:
        [EditorBrowsable(EditorBrowsableState.Never)]
        public class ActionProxy
        {
            public long Id;
            public ActionKind Kind;
            public string ExportFormatKey;
            public string OutputFileName;
            public string ExportFormatName;
            public string ExportDefaultExtension;
            public string Message;
            public CheckedStatus CheckedStatus;
            public string[] ExportFormatNames;
            public ActionKind[] ActionKinds;
        }

        public enum ActionState
        {
            Ready,
            Running,
        }

        #region private and protected fields
        private readonly object _syncRoot = new object();
        private long _id = -1;
        private ActionState _state = ActionState.Ready;

        protected const string c_exportNa = "n/a";
        protected TaskBase _owner = null;
        protected ActionKind _kind = ActionKind.Export;
        protected string _exportFormatKey = string.Empty;
        protected string _message = string.Empty;
        protected string _outputFileName = string.Empty;
        protected CheckedStatus _checkedStatus = CheckedStatus.Unknown;
        #endregion

        #region construction
        /// <summary>
        /// This ctor is for XML serialization only.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal ActionBase()
        {
            lock (SyncRoot)
            {
                _id = Util.NewId();
                _owner = null;
                ResetExportFormatKey();
            }
        }

        public ActionBase(TaskBase owner)
        {
            lock (SyncRoot)
            {
                _id = Util.NewId();
                _owner = owner;
                ResetExportFormatKey();
            }
        }

        public object SyncRoot
        {
            get { return _syncRoot; }
        }

        internal void SetOwner(TaskBase owner)
        {
            System.Diagnostics.Debug.Assert(_owner == null);
            lock (SyncRoot)
            {
                _owner = owner;
                SetExportFormatKey(_exportFormatKey);
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
                ISynchronizeInvoke invoker = null;
                lock (SyncRoot)
                {
                    if (_owner != null)
                        invoker = _owner.Invoker;
                }
                if (invoker != null && invoker.InvokeRequired)
                    invoker.BeginInvoke(handler, new object[] { this, new PropertyChangedEventArgs(propertyName) });
                else
                    handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        #region public stored properties
        public virtual ActionKind Kind
        {
            get { return _kind; }
            set { _kind = value; } // this is for xml serialization only
        }

        protected virtual void SetExportFormatKey(string value)
        {
            lock (SyncRoot)
            {
                if (_owner != null)
                    throw new Util.MustOverrideException();
                _exportFormatKey = value;
            }
        }

        protected virtual void ResetExportFormatKey()
        {
            _exportFormatKey = string.Empty;
        }

        [DefaultValue("")]
        public string ExportFormatKey
        {
            get { return _exportFormatKey; }
            set
            {
                if (value != _exportFormatKey)
                {
                    SetExportFormatKey(value);
                    OnPropertyChanged("ExportFormatKey");
                }
            }
        }

        [DefaultValue("")]
        public virtual string OutputFileName
        {
            get { return _outputFileName; }
            set { _outputFileName = value; }
        }

        protected virtual void ResetOutputFileName()
        {
            _outputFileName = string.Empty;
        }
        #endregion public stored properties

        #region public non-stored properties
        [XmlIgnore]
        public TaskBase Task
        {
            get { return _owner; }
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
                if (_owner == null)
                    return -1;
                return _owner.Actions.IndexOf(this);
            }
        }

        // NOTE: IF THIS IS NOT PUBLIC - IBINDINGLIST DOES NOT provide a PropertyDescriptor in ListChanged!!!
        [XmlIgnore]
        public ActionState State
        {
            get { return _state; }
            set
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
        public virtual string ExportFormatName
        {
            get { return c_exportNa; }
            set
            {
                throw new Util.MustOverrideException();
            }
        }

        [XmlIgnore]
        public virtual string ExportDefaultExtension
        {
            get
            {
                return string.Empty;
            }
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

        [XmlIgnore]
        public virtual string[] ExportFormatNames
        {
            get { return null; }
        }

        [XmlIgnore]
        public virtual ActionKind[] ActionKinds
        {
            get { return null; }
        }
        #endregion public non-stored properties

        #region public methods
        public virtual bool Run()
        {
            return false;
        }

        public virtual bool Check()
        {
            return false;
        }
        #endregion public methods
    }

    [XmlInclude(typeof(ActionListServer))]
    public class ActionList : AsyncBindingList<ActionBase>
    {
        protected TaskBase _owner = null;

        /// <summary>
        /// MUST be called after de-serializing (i.e. after parameterless ctor was used).
        /// </summary>
        /// <param name="owner"></param>
        internal void SetOwner(TaskBase owner)
        {
            System.Diagnostics.Debug.Assert(owner != null && _owner == null);
            lock (SyncRoot)
            {
                _owner = owner;
                foreach (ActionBase action in this)
                    action.SetOwner(_owner);
            }
        }

        public ActionBase ActionById(long id)
        {
            int index;
            return ActionById(id, out index);
        }

        // todo: optimize
        public ActionBase ActionById(long id, out int index)
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

        public long ActionId(int index)
        {
            try
            {
                return this[index].Id;
            }
            catch
            {
                return Util.NullId;
            }
        }

        public virtual void MoveAction(long actionId, bool down)
        {
            throw new Util.MustOverrideException();
        }

        public virtual void RemoveAction(long actionId)
        {
            throw new Util.MustOverrideException();
        }
    }
}
