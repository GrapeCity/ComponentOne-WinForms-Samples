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
            Explorer.ThemeApplied += Explorer_ThemeApplied;
        }

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
                if (!string.IsNullOrEmpty(typeName))
                {
                    c1DockingTabPage_Code.TabVisible = LoadCodeViewer();
                    c1DockingTab_Demo.ShowTabs = c1DockingTabPage_Code.TabVisible;
                }
                demoForm.DisplayIn(items);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (demoForm != null && demoForm.IsHandleCreated)
            {
                // use BeginInvoke to be sure that it is called after form loading and all props are already initialized
                demoForm.BeginInvoke((Action)delegate ()
                {
                    AddProperties(demoForm);
                });
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
            c1DockingTab_Properties.AutoHiding = true;
            panelProperties.Controls.Clear();
            if (d.Properties.Count > 0)
            {
                PropertyList pl = new PropertyList(d.Properties);
                panelProperties.Controls.Add(pl);
                Explorer.ApplyTheme(pl);
                Explorer.ApplyTheme(c1DockingTab_Properties);
                c1DockingTab_Properties.Visible = true;
                if ( d.PinProperties)
                {
                    c1DockingTab_Properties.SlideShowPage(c1DockingTabPage_Properties);
                    c1DockingTab_Properties.AutoHiding = false;
                }
            }
            else
            {
                c1DockingTab_Properties.SlideHidePage();
                c1DockingTab_Properties.Visible = false;
            }
        }

        internal void HideProps()
        {
            c1DockingTab_Properties.AutoHiding = true;
            c1DockingTab_Properties.SlideHidePage();
        }

        private void Explorer_ThemeApplied(object sender, EventArgs e)
        {
            if (panelProperties.Controls.Count > 0)
            {
                ((PropertyList)panelProperties.Controls[0]).UpdatePropertiesFromTheme();
            }
        }

        private void c1DockingTab1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCodeViewer();
        }
    }
}
