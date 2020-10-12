using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class DHBaseForm : Form
    {
        private Form1 _mainForm;

        public Form1 MainForm
        {
            get { return _mainForm; }
            set
            {
                _mainForm = value;
                c1DynamicHelp1.TopicMap.TopicMapChanged -= new EventHandler(TopicMap_TopicMapChanged);
                c1DynamicHelp1.TopicMap.TopicMapSaved -= new EventHandler(TopicMap_TopicMapSaved);
                // set MainControl property to allow c1DynamicHelp1 on this form to use properties of the c1DynamicHelp1 on the _mainForm
                c1DynamicHelp1.MainControl = _mainForm.c1DynamicHelp1;
                c1DynamicHelp1.TopicMap.TopicMapChanged += new EventHandler(TopicMap_TopicMapChanged);
                c1DynamicHelp1.TopicMap.TopicMapSaved += new EventHandler(TopicMap_TopicMapSaved);
            }
        }

        public DHBaseForm()
        {
            InitializeComponent();
            // handle the following events to notify the user about changes in topic map
            c1DynamicHelp1.TopicMap.TopicMapChanged += new EventHandler(TopicMap_TopicMapChanged);
            c1DynamicHelp1.TopicMap.TopicMapSaved += new EventHandler(TopicMap_TopicMapSaved);
        }

        void TopicMap_TopicMapSaved(object sender, EventArgs e)
        {
            // don't display * when topic map is saved and has ho changes
            this.Text = this.Name;
        }

        void TopicMap_TopicMapChanged(object sender, EventArgs e)
        {
            // display * when topic map has changes
            this.Text = this.Name + " *";
        }

        // toggle authoring mode when the user hits ctrl+shift+a
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control && e.Shift)
                c1DynamicHelp1.AuthoringMode = !c1DynamicHelp1.AuthoringMode;
            base.OnKeyDown(e);
        }

        private void DHBaseForm_Load(object sender, EventArgs e)
        {
            // need to refresh the topic map, because Form has just been created, and C1DynamicHelp control was already initialized prior to that
            c1DynamicHelp1.TopicMap.Refresh();
        }
    }
}