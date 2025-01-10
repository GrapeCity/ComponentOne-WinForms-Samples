using C1.Zip;
using ControlExplorer.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    // todo:
    // - zip samples
    // - make sure that we unpack correctly
    // - add code viewer
    // - buttons to switch between code/demo, see button appearance in mockup
    // - sliding panel for properties
    // - proper cleanup from previous sample
    // - what to show if sample is not found? Maybe not MessageBox, just Label with message instead of sample right here
    public partial class DemoViewer : UserControl
    {
        ItemInfo _sample;
        Dictionary<string, string> _code = new Dictionary<string, string>();
        Assembly _exAsm = null;
        const string SOURCE_NAME = "ControlExplorer.SourceCode.zip";
        Control _demo = null;
        int _lastDpi = 0;

        public DemoViewer()
        {
            _exAsm = Assembly.GetExecutingAssembly();
            InitializeComponent();
            LayoutControls();
        }

        protected override void RescaleConstantsForDpi(int deviceDpiOld, int deviceDpiNew)
        {
            base.RescaleConstantsForDpi(deviceDpiOld, deviceDpiNew);
            LayoutControls();
        }

        private void LayoutControls()
        {
            int dpi = base.DeviceDpi;
            if (dpi != _lastDpi)
            {
                double scale = (double)dpi / 96;
            }
            _lastDpi = dpi;
        }

        public void Show(ItemInfo sample, Boolean isSidebarEvent)
        {
            _sample = sample;
            _code.Clear();
            string error = "";
            try
            {
                Assembly asm = Assembly.Load(sample.AssemblyName);
                Type type = asm?.GetType(sample.TypeName);
                if (type != null)
                {
                    ShowDemo(type);
                    if (isSidebarEvent)
                    {
                        AdjustHeaderHeight(sample);
                    }
                }
                else
                {
                    error = "Sample " + sample.AssemblyName + "." + sample.TypeName + " not found.";
                }
            }
            catch (Exception ex)
            {
                error = ex.Message + "\r\n" +
                    "Stack Trace: " + ex.StackTrace + "\r\n" +
                    "Inner Exception: " + ex.InnerException?.Message + "\r\n" +
                    "Stack Trace: " + ex.InnerException?.StackTrace;
            }
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error);
                Trace.WriteLine(error);
            }
        }

        private void AdjustHeaderHeight(ItemInfo sample)
        {
            if (!sample.Menus.IsNullOrEmpty())
            {
                ShowTopNavigation(sample);
                pnlHeader.Height = 95;
            }
            else if (!sample.Parent.Menus.IsNullOrEmpty())
            {
                ShowTopNavigation(sample.Parent);
                if (sample.Parent.Menus.Count > 1)
                {
                    pnlHeader.Height = 160;
                }
                else
                {
                    pnlHeader.Height = 95;
                }
            }
            else
            {
                ShowTopNavigation(sample);
                pnlHeader.Height = 95;
            }
        }

        private void ShowDemo(Type type)
        {
            InitializeCodeViewer();
            if (_demo != null)
            {
                this.pnlDemo.Controls.Remove(_demo);
                _demo.Dispose();
            }
            _demo = Activator.CreateInstance(type) as Control;
            var form = _demo as Form;
            if (form != null)
            {
                form.TopLevel = false;
                form.TopMost = false;
                form.ControlBox = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.SizeGripStyle = SizeGripStyle.Hide;
                form.Show();
            }
            _demo.Dock = DockStyle.Fill;
            this.pnlDemo.Controls.Add(_demo);
            _demo.Focus();
        }

        // Show demo and description 
        private void ShowTopNavigation(ItemInfo item)
        {
            pnlHeader.Controls.Clear();
            var menu = new MenuControl(item);
            menu.Dock = DockStyle.Fill;
            pnlHeader.Controls.Add(menu);
        }

        private void InitializeCodeViewer()
        {
            // todo: correct below code to properly find samples inside zip
            string filename1 = _sample.TypeName.Replace('.', '/') + ".cs";
            string filename2 = _sample.TypeName.Replace('.', '/') + ".Designer.cs";

            // Code from WPF version:
            // var sourceArray = Source.Split('\\');
            // string xaml = String.Format("{0}/{1}", sourceArray.First(), sourceArray.Last());
            // string cs = String.Format("{0}/{1}.cs", sourceArray.First(), sourceArray.Last());

            Stream s = _exAsm.GetManifestResourceStream(SOURCE_NAME);
            if (s != null)
            {
                C1ZipFile z = new C1ZipFile();
                z.Open(s);
                if (z.Entries[filename1] != null)
                {
                    _code.Add(filename1, string.Empty);
                }
                if (z.Entries[filename2] != null)
                {
                    _code.Add(filename2, string.Empty);
                }
                z.Close();
            }
        }

        private string GetCode(string filename)
        {
            Stream s = _exAsm.GetManifestResourceStream(SOURCE_NAME);
            string code = string.Empty;
            C1ZipFile z = new C1ZipFile();
            z.Open(s);
            if (z.Entries[filename] != null)
            {
                StreamReader reader = new StreamReader(z.Entries[filename].OpenReader());
                code = reader.ReadToEnd();
                reader.Close();
            }
            z.Close();
            return code;
        }
    }
}
