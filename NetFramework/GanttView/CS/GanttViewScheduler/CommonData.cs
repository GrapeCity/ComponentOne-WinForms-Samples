using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace GanttViewScheduler
{
    /// <summary>
    /// Class impersonates one element of data for C1GanttView Task and C1Schedule Appointment data source
    /// </summary>
    public class CommonData : INotifyPropertyChanged, IRaiseItemChangedEvents
    {
        private string _name, _notes, _resources, _properties;
        private DateTime? _begin, _end;
        private int _id;

        public CommonData()
        {
            Initialized = true;
            ID = IdGenerator.NewId;
        }
        public bool Initialized { get; set; }
        public int ID
        {
            get { return _id; }
            set { IdGenerator.NewId = _id = value; }
        }
        public int NextID { get; set; }
        public int OutlineParentID { get; set; }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                RaisePropertyChanged("Name");
            }
        }
        public DateTime? Begin
        {
            get { return _begin; }
            set { _begin = value; RaisePropertyChanged("Begin"); }
        }
        public DateTime? End
        {
            get { return _end; }
            set { _end = value; RaisePropertyChanged("End"); }
        }
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; RaisePropertyChanged("Notes"); }
        }
        public string Resources
        {
            get { return _resources; }
            set { _resources = value; RaisePropertyChanged("Resources"); }
        }
        public string Properties
        {
            get { return _properties; }
            set { _properties = value; RaisePropertyChanged("Properties"); }
        }
        public string Location { get; set; }
        public bool RaisesItemChangedEvents
        {
            get { return true; }
        }
        public string Predecessors { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
