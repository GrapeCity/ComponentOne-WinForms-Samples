using C1.Zip;
using ControlExplorer.Utilities;
using System;
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
        //Dictionary<string, string> _code = new Dictionary<string, string>();
        Assembly _exAsm = null;
        const string SOURCE_NAME = "ControlExplorer.SourceCode.zip";
        Control _demo = null;
        CodeViewer _codeViewer;
        int _lastDpi = 0;
        string _code;

        public DemoViewer()
        {
            _exAsm = Assembly.GetExecutingAssembly();
            InitializeComponent();
            InitializeCodeViewer();
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
                pnlHeader.Height = 80;
            }
            else if (!sample.Parent.Menus.IsNullOrEmpty())
            {
                ShowTopNavigation(sample.Parent);
                if (sample.Parent.Menus.Count > 1)
                {
                    pnlHeader.Height = 130;
                }
                else
                {
                    pnlHeader.Height = 80;
                }
            }
            else
            {
                ShowTopNavigation(sample);
                pnlHeader.Height = 80;
            }
        }
        private void ShowDemo(Type type)
        {
            if (_demo != null)
            {
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
            _demo.Visible = true;
            _demo.Focus();
            _codeViewer.Visible = false;
            UpdateButtonText();
        }
        private void ShowTopNavigation(ItemInfo item)
        {
            pnlHeader.Controls.Clear();
            var menu = new MenuControl(item);
            menu.Dock = DockStyle.Fill;
            pnlHeader.Controls.Add(menu);
            menu.CodeButtonClick += ViewCodeButtonClicked;
        }

        private void ViewCodeButtonClicked(object sender, EventArgs e)
        {
            if (!_codeViewer.Visible)
            {
                _codeViewer.Visible = true;
                _demo.Visible = false;
                _codeViewer.SetCode(GetCode);
            }
            else
            {
                _codeViewer.Visible = false;
                _demo.Visible = true;
            }
            UpdateButtonText();
        }

        private void InitializeCodeViewer()
        {
            if (_codeViewer != null)
            {
                _codeViewer.Dispose();
            }
            _codeViewer = new CodeViewer();
            _codeViewer.Visible = false;
            _codeViewer.Dock = DockStyle.Fill;
            this.pnlDemo.Controls.Add(_codeViewer);
        }

        private void UpdateButtonText()
        {
            // Find the MenuControl and update the button text
            foreach (Control control in pnlHeader.Controls)
            {
                if (control is MenuControl menuControl)
                {
                    menuControl.UpdateCodeButtonText(_codeViewer.Visible ? "View Demo" : "View Code");
                }
            }
        }

        public string GetCode
        {
            get
            {
                string filename = "ControlExplorer/" + _sample.TypeName.Replace('.', '/') + ".cs";
                Stream s = _exAsm.GetManifestResourceStream(SOURCE_NAME);
                C1ZipFile z = new C1ZipFile();
                z.Open(s);
                if (z.Entries[filename] != null)
                {
                    StreamReader reader = new StreamReader(z.Entries[filename].OpenReader());
                    _code = reader.ReadToEnd();
                    reader.Close();
                }
                else
                {
                    _code = "No code available.";
                }
                z.Close();
                return _code;
            }
        }
    }
}
