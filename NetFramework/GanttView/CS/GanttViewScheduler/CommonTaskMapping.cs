using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml;
using C1.Win.C1GanttView;
using C1.GanttView;
using C1.Win.C1Schedule;
using C1.C1Schedule;

namespace GanttViewScheduler
{
    /// <summary>
    /// Mapping class for synchronizing C1GanttView Task and C1Schedule Appointment resources
    /// </summary>
    public class CommonTaskMapping : TasksMappingCollection
    {
        private BindingList<CommonResource> _resources = new BindingList<CommonResource>();

        public CommonTaskMapping(BindingList<CommonResource> resources)
            : base()
        {
            AppointmentProperties = Add(typeof(Task), typeof(string), null, false, "");
            AppointmentProperties.MappingName = "Properties";
            TaskID.MappingName = "ID";
            NextID.MappingName = "NextID";
            OutlineParentID.MappingName = "OutlineParentID";
            Initialized.MappingName = "Initialized";
            Name.MappingName = "Name";
            Start.MappingName = "Begin";
            Finish.MappingName = "End";
            Notes.MappingName = "Notes";
            Resources.MappingName = "Resources";
            Predecessors.MappingName = "Predecessors";
            _resources = resources;
        }

        public MappingInfo AppointmentProperties
        {
            get;
            set;
        }

        public BindingList<CommonResource> CommonResources
        {
            get { return _resources; }
            set { _resources = value; }
        }

        protected override bool ReadObject(Task task, object boundObject, bool raiseChanged)
        {
            bool res = base.ReadObject(task, boundObject, raiseChanged);
            string xml = (string)AppointmentProperties.GetPropertyValue(boundObject);
            if (!string.IsNullOrEmpty(xml))
            {
                // Synchronize C1GanttView and C1Schedule resources
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                XmlNodeList list = doc.DocumentElement.SelectNodes("Resources/Obj/@Id");
                task.ResourceRefs.Clear();
                foreach (XmlNode node in list)
                {
                    Guid id = new Guid(node.Value);
                    foreach (CommonResource resource in _resources)
                        if (resource.SchedID.Equals(id))
                            task.ResourceRefs.Add(new ResourceRef(resource.GanttID, 0));
                }
            }
            return res;
        }
    }
}
