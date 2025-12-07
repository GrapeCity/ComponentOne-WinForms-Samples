using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using C1.Win.GanttView;
using C1.GanttView;
using C1.Win.Schedule;
using C1.Schedule;

namespace GanttViewScheduler
{
    public partial class Form1 : Form
    {
        private string _resourcePath;
        private string _dataPath;
        private BindingList<CommonData> _data = new BindingList<CommonData>();
        private BindingList<CommonResource> _resources = new BindingList<CommonResource>();

        public Form1()
        {
            InitializeComponent();
            string dataDir = Path.GetDirectoryName(Application.ExecutablePath);
            _resourcePath = Path.Combine(dataDir, "_resources.xml");
            _dataPath = Path.Combine(dataDir, "_data.xml");

            CommonAppointmentMapping myAppointmentMapping = new CommonAppointmentMapping(_resources, c1Schedule1);
            c1Schedule1.DataStorage.AppointmentStorage.Mappings = myAppointmentMapping;
            c1Schedule1.DataStorage.ResourceStorage.Mappings.IdMapping.MappingName = "SchedID";
            c1Schedule1.DataStorage.ResourceStorage.Mappings.TextMapping.MappingName = "Name";
            c1Schedule1.DataStorage.ResourceStorage.DataSource = _resources;
            c1Schedule1.DataStorage.AppointmentStorage.DataSource = _data;
            c1Schedule1.CalendarInfo.FirstDate = new DateTime(2015, 5, 1);
            c1Schedule1.GoToDate(new DateTime(2015, 6, 1));

            CommonTaskMapping myTaskMapping = new CommonTaskMapping(_resources);
            c1GanttView1.DataStorage.TasksStorage.Mappings = myTaskMapping;
            c1GanttView1.DataStorage.TasksStorage.DataSource = _data;
            c1GanttView1.DataStorage.ResourceStorage.Mappings.ResourceID.MappingName = "GanttID";
            c1GanttView1.DataStorage.ResourceStorage.Mappings.Name.MappingName = "Name";
            c1GanttView1.DataStorage.ResourceStorage.DataSource = _resources;

            c1GanttView1.AfterEditTask += c1GanttView1_AfterEditTask;

            btnLoad_Click(this, EventArgs.Empty);
        }

        void c1GanttView1_AfterEditTask(object sender, CancelTaskArgs e)
        {
            if (e.Task != null)
                e.Cancel = e.Task.OutlineLevel > 1 || e.Task.Mode == TaskMode.Automatic;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new FileStream(_resourcePath, FileMode.Create))
                {
                    XmlSerializer s = new XmlSerializer(typeof(BindingList<CommonResource>));
                    s.Serialize(f, _resources);
                }
                using (var f = new FileStream(_dataPath, FileMode.Create))
                {
                    XmlSerializer s = new XmlSerializer(typeof(BindingList<CommonData>));
                    s.Serialize(f, _data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                using (var f = new FileStream(_resourcePath, FileMode.Open))
                {
                    XmlSerializer s = new XmlSerializer(typeof(BindingList<CommonResource>));
                    _resources = (BindingList<CommonResource>)s.Deserialize(f);
                }
                c1Schedule1.DataStorage.ResourceStorage.DataSource = _resources;
                c1GanttView1.DataStorage.ResourceStorage.DataSource = _resources;
                ((CommonAppointmentMapping)c1Schedule1.DataStorage.AppointmentStorage.Mappings).CommonResources = _resources;
                ((CommonTaskMapping)c1GanttView1.DataStorage.TasksStorage.Mappings).CommonResources = _resources;
                using (var f = new FileStream(_dataPath, FileMode.Open))
                {
                    XmlSerializer s = new XmlSerializer(typeof(BindingList<CommonData>));
                    _data = (BindingList<CommonData>)s.Deserialize(f);
                }
                c1Schedule1.DataStorage.AppointmentStorage.DataSource = c1GanttView1.DataStorage.TasksStorage.DataSource = _data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
