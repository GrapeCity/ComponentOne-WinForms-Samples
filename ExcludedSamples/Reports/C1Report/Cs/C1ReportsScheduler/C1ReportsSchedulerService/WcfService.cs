using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Xml.Serialization;
using System.Text;
using System.Reflection;
using C1ReportsScheduler;

namespace C1ReportsSchedulerService
{
    // Define a service contract.
    // [ServiceContract(Namespace = "http://ComponentOne.Reports.Service")]
    [ServiceContract(CallbackContract = typeof(IC1ReportsSchedulerWcfCallback))]
    // [ServiceContract]
    public interface IC1ReportsSchedulerWcf
    {
        [OperationContract]
        void Connect();

        [OperationContract(IsOneWay = true)]
        void Disconnect(string reason);

        [OperationContract]
        bool Ping();

        [OperationContract]
        string GetAboutString();

        [OperationContract]
        int GetTaskCount();

        [OperationContract]
        long GetTaskId(int taskIndex);

        [OperationContract]
        string GetTaskXml(long taskId);

        [OperationContract]
        int GetActionCount(long taskId);

        [OperationContract]
        long GetActionId(long taskId, int actionIndex);

        [OperationContract]
        string GetActionXml(long taskId, long actionId);

        [OperationContract]
        string GetScheduleXml(long taskId);

        [OperationContract(IsOneWay = true)]
        void AddTask();

        [OperationContract(IsOneWay = true)]
        void RemoveTask(long taskId);

        [OperationContract(IsOneWay = true)]
        void MoveTask(long taskId, bool down);

        [OperationContract]
        bool CheckTask(long taskId, bool checkActions);

        [OperationContract]
        string SerializeTaskListHolder();

        [OperationContract]
        string SerializeDocument(long taskId);

        [OperationContract(IsOneWay = true)]
        void AddAction(long taskId);

        [OperationContract(IsOneWay = true)]
        void MoveAction(long taskId, long actionId, bool down);

        [OperationContract(IsOneWay = true)]
        void RemoveAction(long taskId, long actionId);

        [OperationContract(IsOneWay = true)]
        void SetTaskProperty(long taskId, string propertyName, string propertyValue);

        [OperationContract(IsOneWay = true)]
        void SetActionProperty(long taskId, long actionId, string propertyName, string propertyValue);

        [OperationContract(IsOneWay = true)]
        void SetScheduleProperty(long taskId, string propertyName, string propertyValue);
    }

    public interface IC1ReportsSchedulerWcfCallback
    {
        [OperationContract(IsOneWay = true)]
        void TaskPropertyChanged(long taskId, string taskXml, string propertyName);

        [OperationContract(IsOneWay = true)]
        void ActionPropertyChanged(long taskId, long actionId, string actionXml, string propertyName);

        [OperationContract(IsOneWay = true)]
        void SchedulePropertyChanged(long taskId, string scheduleXml, string propertyName);

        [OperationContract(IsOneWay = true)]
        void TaskAdded(int index, long taskId, string taskXml);

        [OperationContract(IsOneWay = true)]
        void TaskRemoved(long taskId);

        [OperationContract(IsOneWay = true)]
        void ActionAdded(long taskId, int actionIndex, long actionId, string actionXml);

        [OperationContract(IsOneWay = true)]
        void ActionRemoved(long taskId, long actionId);
    }


    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single,
        IncludeExceptionDetailInFaults = true,
        UseSynchronizationContext = false,
        ConcurrencyMode = ConcurrencyMode.Reentrant
        )]
    public class ReportsSchedulerWcf : IC1ReportsSchedulerWcf
    {
        static private ReportsSchedulerWcf s_singleton = null;
        private TaskListHolderServer _tasks = null;
        // set by Connect, reset by Disconnect:
        private IC1ReportsSchedulerWcfCallback _callback = null;
        // indicates that service is paused:
        private bool _paused = false;

        public ReportsSchedulerWcf()
        {
            System.Diagnostics.Debug.Assert(s_singleton == null);
            s_singleton = this;
        }

        static public ReportsSchedulerWcf Singleton
        {
            get { return s_singleton; }
        }

        public TaskListHolderServer Tasks
        {
            get { return _tasks; }
            set
            {
                _tasks = value;
                ((TaskListServer)_tasks.Tasks).WcfService = this; // ReportsSchedulerWcf.Singleton;
            }
        }

        public bool Paused
        {
            get { return _paused; }
            set
            {
                _paused = value;
            }
        }

        private void Log(string message)
        {
            Logger.Log("ReportsSchedulerWcf", message);
        }

        #region IC1ReportsSchedulerWcf Members
        public void Connect()
        {
            Log("Connecting...");

            Debug.Assert(_callback == null);

            OperationContext.Current.Channel.Closed += new EventHandler(Channel_Closed);
            OperationContext.Current.Channel.Faulted += new EventHandler(Channel_Faulted);

            _callback = OperationContext.Current.GetCallbackChannel<IC1ReportsSchedulerWcfCallback>();
            ((TaskListServer)_tasks.Tasks).WcfCallback = _callback;

            Log("Connected.");
        }

        /// <summary>
        /// Disconnects.
        /// </summary>
        /// <param name="reason">Reason for disconnecting.</param>
        public void Disconnect(string reason)
        {
            Log("Disconnecting...");

            ((TaskListServer)_tasks.Tasks).WcfCallback = null;
            _callback = null;

            if (OperationContext.Current != null && OperationContext.Current.Channel != null)
            {
                try
                {
                    if (OperationContext.Current.Channel.State == CommunicationState.Opened)
                        OperationContext.Current.Channel.Close();
                }
                catch (Exception ex)
                {
                    Log(string.Format("Exception while disconnecting: {0}", ex.Message));
                }
            }
            Log(string.Format("Disconnected, reason: {0}", reason ?? "None given."));
        }

        private void DetachChannel(IContextChannel channel)
        {
            channel.Closed -= new EventHandler(Channel_Closed);
            channel.Faulted -= new EventHandler(Channel_Faulted);
        }

        private void Channel_Faulted(object sender, EventArgs e)
        {
            DetachChannel(sender as IContextChannel);
            Disconnect("Channel_Faulted");
        }

        private void Channel_Closed(object sender, EventArgs e)
        {
            DetachChannel(sender as IContextChannel);
            Disconnect("Channel_Closed");
        }

        public bool Ping()
        {
            return true;
        }

        public string GetAboutString()
        {
            try
            {
                Assembly entryAssembly = Assembly.GetEntryAssembly();

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(Util.GetAssemblyAboutName(entryAssembly));
                foreach (AssemblyName name in entryAssembly.GetReferencedAssemblies())
                    if (name.Name.ToLower().StartsWith("c1"))
                        sb.AppendLine(Util.GetAssemblyAboutName(name));
                return sb.ToString();
            }
            catch (Exception ex)
            {
                return string.Format("Error: {0}", ex.Message);
            }
        }

        public int GetTaskCount()
        {
            Debug.Assert(_callback != null);
            return _tasks.Tasks.Count;
        }

        public long GetTaskId(int taskIndex)
        {
            try
            {
                TaskBase task = _tasks.Tasks[taskIndex];
                return task.Id;
            }
            catch
            {
                return Util.NullId;
            }
        }

        public string GetTaskXml(long taskId)
        {
            Debug.Assert(_callback != null);
            TaskServer task = (TaskServer)_tasks.Tasks.TaskById(taskId);
            if (task != null)
                return task.ToProxyXml();
            return null;
        }

        public int GetActionCount(long taskId)
        {
            Debug.Assert(_callback != null);
            TaskBase task = _tasks.Tasks.TaskById(taskId);
            if (task != null)
                return task.Actions.Count;
            return 0;
        }

        public long GetActionId(long taskId, int actionIndex)
        {
            TaskBase task = _tasks.Tasks.TaskById(taskId);
            if (task == null)
                return Util.NullId;
            try
            {
                return task.Actions[actionIndex].Id;
            }
            catch
            {
                return Util.NullId;
            }
        }

        public string GetActionXml(long taskId, long actionId)
        {
            Debug.Assert(_callback != null);
            TaskBase task = _tasks.Tasks.TaskById(taskId);
            if (task == null)
                return null;
            ActionBase action = task.Actions.ActionById(actionId);
            if (action == null)
                return null;
            return ((ActionServer)action).ToProxyXml();
        }

        public string GetScheduleXml(long taskId)
        {
            Debug.Assert(_callback != null);
            TaskBase task = _tasks.Tasks.TaskById(taskId);
            if (task != null)
                return ((ScheduleServer)task.Schedule).ToProxyXml();
            return null;
        }

        public void AddTask()
        {
            _tasks.Tasks.AddNew();
        }

        public void RemoveTask(long taskId)
        {
            int index;
            TaskBase task = _tasks.Tasks.TaskById(taskId, out index);
            if (task != null)
                _tasks.Tasks.RemoveAt(index);
        }

        public void MoveTask(long taskId, bool down)
        {
            _tasks.Tasks.MoveTask(taskId, down);
        }

        public bool CheckTask(long taskId, bool checkActions)
        {
            TaskBase task = _tasks.Tasks.TaskById(taskId);
            if (task != null)
                return task.Check(checkActions);
            return false;
        }

        public string SerializeTaskListHolder()
        {
            using (MemoryStream ms = new MemoryStream())
            {
                _tasks.Save(ms);
                ms.Seek(0, SeekOrigin.Begin);
                return UTF8Encoding.Default.GetString(ms.GetBuffer());
            }
        }

        public string SerializeDocument(long taskId)
        {
            TaskBase task = _tasks.Tasks.TaskById(taskId);
            if (task == null)
                return null;
            try
            {
                object doc = task.Document;
                C1.C1Preview.C1PrintDocument c1doc = doc as C1.C1Preview.C1PrintDocument;
                if (c1doc == null)
                {
                    C1.C1Report.C1Report c1rep = doc as C1.C1Report.C1Report;
                    if (c1rep == null)
                        return null;
                    c1doc = c1rep.C1Document;
                    if (c1doc == null)
                        return null;
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    c1doc.Save(ms, C1.C1Preview.C1DocumentFormatEnum.C1dx);
                    ms.Seek(0, SeekOrigin.Begin);
                    return UTF8Encoding.Default.GetString(ms.GetBuffer());
                }
            }
            catch (Exception ex)
            {
                AltUtil.ShowError(ex.Message);
                return null;
            }
        }

        public void AddAction(long taskId)
        {
            TaskBase task = _tasks.Tasks.TaskById(taskId);
            if (task != null)
                task.Actions.AddNew();
        }

        public void MoveAction(long taskId, long actionId, bool down)
        {
            TaskBase task = _tasks.Tasks.TaskById(taskId);
            if (task != null)
                task.Actions.MoveAction(actionId, down);
        }

        public void RemoveAction(long taskId, long actionId)
        {
            TaskBase task = _tasks.Tasks.TaskById(taskId);
            if (task != null)
                task.Actions.RemoveAction(actionId);
        }

        public void SetTaskProperty(long taskId, string propertyName, string propertyValue)
        {
            TaskBase task = _tasks.Tasks.TaskById(taskId);
            Util.SetProperty(task, propertyName, propertyValue);
        }

        public void SetActionProperty(long taskId, long actionId, string propertyName, string propertyValue)
        {
            TaskBase task = _tasks.Tasks.TaskById(taskId);
            ActionBase action = task.Actions.ActionById(actionId);
            Util.SetProperty(action, propertyName, propertyValue);
        }

        public void SetScheduleProperty(long taskId, string propertyName, string propertyValue)
        {
            if (Paused && propertyName == "Paused")
                return; // ignore attempts to pause/resume schedules when service is paused.
            TaskBase task = _tasks.Tasks.TaskById(taskId);
            Util.SetProperty(task.Schedule, propertyName, propertyValue);
        }
        #endregion
    }
}
