using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WorkingWithTopicMap.Properties;
using System.Xml;

namespace WorkingWithTopicMap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // load default topic map
            // its name is c1DynamicHelp1.HelpSource + ".xml" name (in this sample: C1Sample.chm.xml)
            c1DynamicHelp1.TopicMap.Load();
        }

        private void btnLoadFrom_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                // set up and show OpenFileDialog
                dlg.InitialDirectory = Application.StartupPath;
                dlg.Filter = "Topic map files (*.xml)|*.xml|All files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // load topic map from the selected file
                    c1DynamicHelp1.TopicMap.Load(dlg.FileName);
                }
            }            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // save topic map to the default file name: c1DynamicHelp1.HelpSource + ".xml" (in this sample: C1Sample.chm.xml)
            c1DynamicHelp1.TopicMap.Save();
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                // set up and show SaveFileDialog
                dlg.InitialDirectory = Application.StartupPath;
                dlg.Filter = "Topic map files (*.xml)|*.xml|All files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // save topic map to the selected file
                    c1DynamicHelp1.TopicMap.Save(dlg.FileName);
                }
            }
        }

        private void btnLoadFromRes_Click(object sender, EventArgs e)
        {
            // create new XmlDocument
            XmlDocument topicMap = new XmlDocument();
            // load XmlDocument from application resources
            topicMap.LoadXml(Resources.ResTopicMap);
            // set XmlDocument as the source for the c1DynamicHelp1.TopicMap
            c1DynamicHelp1.TopicMap.XmlSource = topicMap;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // need to refresh the topic map, because Form1 has just been created, and C1DynamicHelp control was already initialized prior to that
            c1DynamicHelp1.TopicMap.Refresh();
        }

        // toggle authoring mode when the user hits ctrl+shift+a
        protected override void OnKeyDown(KeyEventArgs e)
        {
            // you can activate authoring mode, change topic map and try to save it to different locations and 
            // then load it back 
            if (e.KeyCode == Keys.A && e.Control && e.Shift)
                c1DynamicHelp1.AuthoringMode = !c1DynamicHelp1.AuthoringMode;
            base.OnKeyDown(e);
        }

    }
}