using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.CodeDom;
using System.IO;
using C1.Zip;
using System.Diagnostics;
using System.Reflection;
using DataFilterExplorer;

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
        SampleInfo _sample;
        Dictionary<string, string> _code = new Dictionary<string, string>();
        Assembly _exAsm = null;
        const string SOURCE_NAME = "ControlExplorer.SourceCode.zip";
        Control _demo = null;
        const int titleHeight = 36;
        const int descriptionHeight = 72;
        int _lastDpi = 0;
        private MainForm _mainForm;

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
                this.pnlTitle.Size = new Size(pnlTitle.Width, (int)(titleHeight * scale));
                this.pnlDescription.Size = new Size(pnlDescription.Width, (int)(descriptionHeight * scale));
            }
            _lastDpi = dpi;
        }

        public void Show(SampleInfo sample)
        {
            _sample = sample;
            _code.Clear();
            lblTitle.Text = sample.Name;
            if ( sample.Category != null)
            {
                lblTitle.Text = sample.Category + " - " + lblTitle.Text;
            }
            lblDescription.Size = new Size(0, 0);
            lblDescription.Text = sample.LongDescription;
            string error = "";
            try
            {
                Assembly asm = Assembly.Load(sample.AssemblyName);
                Type type = asm?.GetType(sample.TypeName);
                if (type != null)
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
                    this.pnlDescription.Height = (int)(descriptionHeight * (double)base.DeviceDpi / 96);
                    var prefSize = lblDescription.GetPreferredSize(new Size(pnlDescription.Width - 15, 2000));
                    pnlDescription.AutoScrollPosition = new Point(0, 0);
                    lblDescription.Size = new Size(pnlDescription.Width - 25, Math.Max(prefSize.Height, 72));
                    lblDescription.Location = new Point(0, 0);
                    lblDescription.Invalidate();
                    _demo.Focus();
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
