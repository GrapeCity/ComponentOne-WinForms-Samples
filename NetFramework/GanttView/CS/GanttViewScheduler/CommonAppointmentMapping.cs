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
    public class CommonAppointmentMapping : AppointmentMappingCollection
    {
        private BindingList<CommonResource> _resources = new BindingList<CommonResource>();
        private C1Schedule _owner;

        public CommonAppointmentMapping(BindingList<CommonResource> resources, C1Schedule owner)
            : base()
        {
            TaskResources = Add(typeof(Appointment), typeof(string), null, false, "");
            TaskResources.MappingName = "Resources";
            Subject.MappingName = "Name";
            Body.MappingName = "Notes";
            End.MappingName = "End";
            Location.MappingName = "Location";
            AppointmentProperties.MappingName = "Properties";
            Start.MappingName = "Begin";
            _resources = resources;
            _owner = owner;
            Collection = owner.DataStorage.AppointmentStorage.Appointments;
        }

        public MappingInfo TaskResources
        {
            get;
            set;
        }

        public BindingList<CommonResource> CommonResources
        {
            get { return _resources; }
            set { _resources = value; }
        }

        protected override bool ReadObject(Appointment app, object boundObject, bool raiseChanged)
        {
            bool res = base.ReadObject(app, boundObject, raiseChanged);
            string xml = (string)TaskResources.GetPropertyValue(boundObject);
            if (!string.IsNullOrEmpty(xml))
            {
                // Synchronize C1GanttView and C1Schedule resources
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                XmlNodeList list = doc.DocumentElement.SelectNodes("resourceRef/@resourceID");
                app.Resources.Clear();
                foreach (XmlNode node in list)
                {
                    int id = int.Parse(node.Value);
                    foreach (CommonResource resource in _resources)
                        if (resource.GanttID.Equals(id))
                            app.Resources.Add(_owner.DataStorage.ResourceStorage.Resources[resource.SchedID]);
                }
            }
            return res;
        }
    }
}
