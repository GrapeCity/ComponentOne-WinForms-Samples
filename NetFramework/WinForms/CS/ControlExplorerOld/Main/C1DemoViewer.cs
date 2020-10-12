using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer
{
    public partial class C1DemoViewer : UserControl
    {
        private bool loadedCode = false;
        private C1DemoForm demoForm;

        public C1DemoViewer()
        {
            InitializeComponent();
        }

        public bool ShowTitle
        {
            set { this.c1DockingTab_Description.Visible = value; }
        }

        //public bool ShowProperties
        //{
        //    set { this.c1DockingTab_Properties.Visible = value; }
        //}


        public C1DemoForm Run(string typeName, string title, string description)
        {
            //C1DemoForm d = null;
            Control.ControlCollection items = panelDemo.Controls;
            Type t = Type.GetType(typeName);
            loadedCode = false;
            try
            {
                demoForm = t.Assembly.CreateInstance(t.FullName) as C1DemoForm;
                //c1Expander1.HeaderText = title;
                c1DockingTabPage_Demo.Text = title;
                demoForm.DisplayIn(items);
                AddProperties(demoForm);
                if (!string.IsNullOrEmpty(demoForm.Description))
                {
                    AddDescription(demoForm);
                    c1DockingTabPage_Description.Visible = true;
                    c1CommandDock1.Visible = true;
                }
                else if (!string.IsNullOrEmpty(description))
                {
                    lblDescription.Text = description.Replace("\\r\\n", "\r\n");
                    c1DockingTabPage_Description.Visible = true;
                    c1CommandDock1.Visible = true;
                }
                else
                {
                    c1DockingTabPage_Description.Visible = false;
                    c1CommandDock1.Visible = false;
                }
                if (!string.IsNullOrEmpty(typeName))
                {
                    c1DockingTabPage_Code.TabVisible = LoadCodeViewer();
                    c1DockingTab_Demo.ShowTabs = c1DockingTabPage_Code.TabVisible;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return demoForm;
        }

        private bool LoadCodeViewer()
        {
            if (!loadedCode && c1DockingTab_Demo.SelectedIndex == 1)
            {
                this.Cursor = Cursors.AppStarting;
                c1CodeViewer1.Code = demoForm.DemoCode;
                this.Cursor = Cursors.Default;
                loadedCode = true;
            }

            //return false if no code
            if (demoForm.DemoCode.Equals("No code available."))
                return false;
            else
                return true;
        }

        public void Close()
        {
            Control.ControlCollection items = panelDemo.Controls;
            //c1Expander1.HeaderText = "";
            //c1Expander1.ContentText = "";
            C1DemoForm.ClearContainer(items);
        }

        private void AddProperties(C1DemoForm d)
        {
            panelProperties.Controls.Clear();
            if (d.Properties.Count > 0)
            {
                PropertyList pl = new PropertyList(d.Properties);
                panelProperties.Controls.Add(pl);
                //int heightCount = d.Properties.Count > 4 ? 4 : d.Properties.Count;
                //panelProperties.Height = pl.CalculateHeight(pl);
                //btnProperties.Enabled = true;
                c1DockingTab_Properties.Visible = true;
            }
            else
            {
                c1DockingTab_Properties.Visible = false;
            }
        }

        private void AddDescription(C1DemoForm d)
        {
            lblDescription.Text = d.Description;
        }

        public void UpdateDescription(string desc)
        {
            lblDescription.Text = desc;
        }

        private void c1DockingTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCodeViewer();
        }

    }
}
