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
    public class ActionClient : ActionBase
    {
        private string _exportFormatName;
        private string _exportDefaultExtension;
        private string[] _exportFormatNames;
        private ActionKind[] _actionKinds;

        #region construction
        /// <summary>
        /// This ctor is for XML serialization only.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        private ActionClient()
            : base()
        {
        }

        public ActionClient(TaskBase owner)
            : base(owner)
        {
        }

        internal void FromProxyXml(string xml)
        {
            FromProxy((ActionProxy)Util.FromXml(xml, typeof(ActionProxy)));
        }

        private void FromProxy(ActionProxy proxy)
        {
            this.Id = proxy.Id;
            this._kind = proxy.Kind;
            this._exportFormatKey = proxy.ExportFormatKey;
            this._outputFileName = proxy.OutputFileName;
            this._exportFormatName = proxy.ExportFormatName;
            this._exportDefaultExtension = proxy.ExportDefaultExtension;
            this._message = proxy.Message;
            this._checkedStatus = proxy.CheckedStatus;
            this._exportFormatNames = proxy.ExportFormatNames;
            this._actionKinds = proxy.ActionKinds;

        }

        internal void CallPropertyChanged(string propertyName)
        {
            OnPropertyChanged(propertyName);
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
        }
        #endregion construction

        #region public stored properties
        public override ActionKind Kind
        {
            set
            {
                ((TaskListClient)_owner.Owner).SetActionProperty(_owner, this, "Kind", value.ToString());
            }
        }

        public override string OutputFileName
        {
            set
            {
                ((TaskListClient)_owner.Owner).SetActionProperty(_owner, this, "OutputFileName", value);
            }
        }
        #endregion public stored properties

        #region public non-stored properties
        [XmlIgnore]
        public override string ExportFormatName
        {
            get
            {
                return _exportFormatName;
            }
            set
            {
                ((TaskListClient)_owner.Owner).SetActionProperty(_owner, this, "ExportFormatName", value);
            }
        }

        [XmlIgnore]
        public override string ExportDefaultExtension
        {
            get
            {
                return _exportDefaultExtension;
            }
        }

        [XmlIgnore]
        public override string[] ExportFormatNames
        {
            get
            {
                return _exportFormatNames;
            }
        }

        [XmlIgnore]
        public override ActionKind[] ActionKinds
        {
            get
            {
                return _actionKinds;
            }
        }
        #endregion public non-stored properties

        #region public methods
        public override bool Run()
        {
            throw new NotImplementedException();
        }

        public override bool Check()
        {
            throw new NotImplementedException();
        }
        #endregion public methods
    }

    public class ActionListClient : ActionList
    {
        protected override object AddNewCore()
        {
            TaskListClient taskList = (TaskListClient)_owner.Owner;
            if (taskList.WcfClient == null)
            {
                WinUtil.ShowErrorClientDisconnected();
                CancelNew(this.Count);
                return null;
            }
            lock (SyncRoot)
            {
                // We do not want to really add a new item.
                // Instead, we tell the server to do that, and cancel our own adding.
                // The server will tell us that it has added a task, and we will update then.
                taskList.WcfClient.AddAction(_owner.Id);
                CancelNew(this.Count);
                return null;
            }
        }

        protected override void OnAddingNew(AddingNewEventArgs e)
        {
            throw new Util.ShouldNotHappenException();
        }

        public override void MoveAction(long actionId, bool down)
        {
            TaskListClient taskList = (TaskListClient)_owner.Owner;
            if (taskList.WcfClient == null)
                WinUtil.ShowErrorClientDisconnected();
            else
                taskList.WcfClient.MoveAction(_owner.Id, actionId, down);
        }

        public override void RemoveAction(long actionId)
        {
            TaskListClient taskList = (TaskListClient)_owner.Owner;
            if (taskList.WcfClient == null)
                WinUtil.ShowErrorClientDisconnected();
            else
                taskList.WcfClient.RemoveAction(_owner.Id, actionId);
        }
    }
}
