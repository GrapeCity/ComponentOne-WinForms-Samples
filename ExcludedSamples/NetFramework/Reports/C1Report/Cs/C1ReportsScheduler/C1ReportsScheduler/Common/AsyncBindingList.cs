using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using System.Text;
using C1.C1Preview;

namespace C1ReportsScheduler
{
    // http://social.msdn.microsoft.com/Forums/en-US/netfxbcl/thread/186338b6-2fe1-4d41-bab5-c35bf64a6b8d
    public class AsyncBindingList<T> : BindingList<T>
    {
        private ISynchronizeInvoke _invoker = null;
        private readonly object _syncRoot = new object();

        public AsyncBindingList()
        {
        }

        [XmlIgnore]
        public object SyncRoot
        {
            get { return _syncRoot; }
        }

        [XmlIgnore]
        public ISynchronizeInvoke Invoker
        {
            get { return _invoker; }
            set
            {
                lock (SyncRoot)
                {
                    _invoker = value;
                }
            }
        }

        delegate void ListChangedDelegate(ListChangedEventArgs e);

        protected override void OnListChanged(ListChangedEventArgs e)
        {
            if (_invoker != null && _invoker.InvokeRequired)
            {
                IAsyncResult ar = _invoker.BeginInvoke(new ListChangedDelegate(base.OnListChanged), new object[] { e });
            }
            else
            {
                base.OnListChanged(e);
            }
        }
    }
}
