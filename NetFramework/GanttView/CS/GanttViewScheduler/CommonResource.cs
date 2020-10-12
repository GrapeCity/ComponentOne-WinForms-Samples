using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GanttViewScheduler
{
    /// <summary>
    /// Class impersonates one element of resources for C1GanttView and C1Schedule data source
    /// </summary>

    public class CommonResource : INotifyPropertyChanged, IRaiseItemChangedEvents
    {
        string _name;
        Guid _schedID;
        int _ganttID;

        public CommonResource()
        {
            _schedID = Guid.NewGuid();
            _ganttID = IdGenerator.NewId;
        }
        public Guid SchedID
        {
            get { return _schedID; }
            set { _schedID = value; RaisePropertyChanged("SchedID"); }
        }
        public int GanttID
        {
            get { return _ganttID; }
            set { IdGenerator.NewId = _ganttID = value; RaisePropertyChanged("GanttID"); }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public bool RaisesItemChangedEvents
        {
            get { return true; }
        }

        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
