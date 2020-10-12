using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace C1ReportsScheduler
{
    static internal class C1Settings
    {
        static public void Load(MainForm mainForm)
        {
            UiSettings uiSettings = Properties.Settings.Default.UiSettings;
            if (uiSettings != null)
                mainForm.UiSettings = uiSettings;

            mainForm.WcfEndpointAddress = Properties.Settings.Default.EndpointAddress;

            if (Properties.Settings.Default.ClientMode)
            {
                if (!mainForm.ClientMode)
                    mainForm.ConnectToServiceOnLoad();
            }
            else
            {
                TaskListStore store = Properties.Settings.Default.TaskListStore;
                switch (store)
                {
                    case TaskListStore.AppConfigFile:
                        string tasksXml = Properties.Settings.Default.C1ReportsSchedulerTasks;
                        if (!string.IsNullOrEmpty(tasksXml))
                        {
                            try
                            {
                                using (MemoryStream ms = new MemoryStream(UTF8Encoding.Default.GetBytes(tasksXml)))
                                    mainForm.LoadTasks(TaskListHolder.Load(ms));
                            }
                            catch (Exception ex)
                            {
                                WinUtil.ShowError(string.Format("Error loading tasks from config file: {0}", ex.Message));
                            }
                        }
                        break;
                    case TaskListStore.XmlFile:
                        mainForm.FileOpen(Properties.Settings.Default.C1rsconfFileName);
                        break;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        break;
                }
            }
        }

        static public void Save(MainForm mainForm)
        {
            Properties.Settings.Default.UiSettings = mainForm.UiSettings;

            Properties.Settings.Default.EndpointAddress = mainForm.WcfEndpointAddress;

            if (mainForm.ClientMode)
            {
                Properties.Settings.Default.ClientMode = true;
            }
            else
            {
                Properties.Settings.Default.ClientMode = false;

                TaskListStore store = mainForm.TaskListStore;
                switch (store)
                {
                    case TaskListStore.AppConfigFile:
                        using (MemoryStream ms = new MemoryStream())
                        {
                            mainForm.TasksHolder.Save(ms);
                            ms.Seek(0, SeekOrigin.Begin);
                            Properties.Settings.Default.C1ReportsSchedulerTasks = UTF8Encoding.Default.GetString(ms.GetBuffer());
                        }
                        break;
                    case TaskListStore.XmlFile:
                        Properties.Settings.Default.C1rsconfFileName = mainForm.C1rsconfFileName;
                        mainForm.TasksHolder.Save(mainForm.C1rsconfFileName);
                        break;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        break;
                }
            }
            Properties.Settings.Default.Save();
        }
    }
}
