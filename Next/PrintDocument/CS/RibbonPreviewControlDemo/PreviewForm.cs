using C1.C1Preview;
using C1.Win.Ribbon;
using C1.Win.RibbonPreview;
using System;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace RibbonPreviewControlDemo
{
    public partial class PreviewForm : C1RibbonForm
    {
        #region static members

        private static string _exePath, _startupFilePath;

        static PreviewForm()
        {
            _exePath = Application.ExecutablePath;
        }

        internal static void SetStartupFilePath(string filePath)
        {
            _startupFilePath = filePath;
        }

        #endregion

        #region fields

        //private RibbonLabel _registerLabel;

        #endregion

        #region ctor/Dispose

        public PreviewForm()
        {
            InitializeComponent();
            BuildAppMenu();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion

        #region build the app menu

        void BuildAppMenu()
        {
            var appMenu = rpc.Ribbon.ApplicationMenu;
            appMenu.Visible = true;
            appMenu.KeyTip = "S";
            appMenu.SmallImage = Properties.Resources.Menu;
            appMenu.DropDownWidth = 480;
            appMenu.DropDown += AppMenu_DropDown;

            var btn = new RibbonButton();
            btn.SmallImage = Properties.Resources.Open16x16;
            btn.LargeImage = Properties.Resources.Open32x32;
            btn.Text = "Open";
            new ButtonPreviewElement(rpc, btn, RibbonPreviewAction.FileOpen);
            appMenu.LeftPaneItems.Add(btn);

            btn = new RibbonButton();
            btn.SmallImage = Properties.Resources.Export16x16;
            btn.LargeImage = Properties.Resources.Export32x32;
            btn.Text = "Export";
            new ButtonPreviewElement(rpc, btn, RibbonPreviewAction.Export);
            appMenu.LeftPaneItems.Add(btn);

            appMenu.LeftPaneItems.Add(new RibbonSeparator());

            btn = new RibbonButton();
            btn.SmallImage = Properties.Resources.Print16x16;
            btn.LargeImage = Properties.Resources.Print32x32;
            btn.Text = "Print";
            new ButtonPreviewElement(rpc, btn, RibbonPreviewAction.Print);
            appMenu.LeftPaneItems.Add(btn);

            btn = new RibbonButton();
            btn.SmallImage = Properties.Resources.PageSetup16x16;
            btn.LargeImage = Properties.Resources.PageSetup32x32;
            btn.Text = "Page Setup";
            new ButtonPreviewElement(rpc, btn, RibbonPreviewAction.PageSetup);
            appMenu.LeftPaneItems.Add(btn);

            appMenu.LeftPaneItems.Add(new RibbonSeparator());

            btn = new RibbonButton();
            btn.SmallImage = Properties.Resources.Close16x16;
            btn.LargeImage = Properties.Resources.Close32x32;
            btn.Text = "Close";
            new ButtonPreviewElement(rpc, btn, RibbonPreviewAction.FileClose);
            appMenu.LeftPaneItems.Add(btn);

            appMenu.LeftPaneItems.Add(new RibbonSeparator());

            btn = new RibbonButton();
            btn.SmallImage = Properties.Resources.Exit16x16;
            btn.LargeImage = Properties.Resources.Exit32x32;
            btn.Text = "Exit";
            btn.Click += ExitButton_Click;
            appMenu.LeftPaneItems.Add(btn);
        }

        #endregion

        #region open file

        public bool OpenFile(string filePath, bool addToJumpList = true)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (!string.IsNullOrEmpty(filePath))
                {
                    if (!Directory.Exists(filePath))
                        filePath = Path.GetDirectoryName(filePath);
                    if (Directory.Exists(filePath))
                        ofd.InitialDirectory = filePath;
                }
                ofd.Filter = "All C1 Documents (*.c1dx;*.c1d;*.c1mdx)|*.c1dx;*.c1d;*.c1mdx|C1 Open XML Documents (*.c1dx)|*.c1dx|C1 Documents (*.c1d)|*.c1d|C1 Open XML Multi Documents (*.c1mdx)|*.c1mdx|All Files (*.*)|*.*";
                bool res = ofd.ShowDialog() == DialogResult.OK;
                filePath = ofd.FileName;
                ofd.Dispose();
                if (!res)
                {
                    return false;
                }
            }

            object doc = null;
            string ext = Path.GetExtension(filePath).ToLowerInvariant();
            try
            {
                if (ext == ".c1dx")
                {
                    var dx = new C1PrintDocument();
                    dx.Load(filePath, C1DocumentFormatEnum.C1dx);
                    doc = dx;
                }
                else if (ext == ".c1d")
                {
                    var dx = new C1PrintDocument();
                    dx.Load(filePath, C1DocumentFormatEnum.C1d);
                    doc = dx;
                }
                else if (ext == ".c1mdx")
                {
                    var mdx = new C1MultiDocument();
                    mdx.Load(filePath);
                    doc = mdx;
                }
                else
                {
                    MessageBox.Show("Can't open file with \"" + ext + "\" extension.", "C1PrintDocument Viewer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (doc != null)
            {
                Text = Path.GetFileNameWithoutExtension(filePath);
                rpc.Document = doc;
                return true;
            }
            return false;
        }

        #endregion

        #region event handlers

        void PreviewForm_Shown(object sender, EventArgs e)
        {
            rpc.Ribbon.Minimized = true;

            if (_startupFilePath != null)
            {
                OpenFile(_startupFilePath, false);
                _startupFilePath = null;
                return;
            }

            var exeDir = Path.GetDirectoryName(_exePath);
            var dirPath = exeDir + @"\Documents";
            
            if (!Directory.Exists(dirPath))
            {
                DirectoryInfo di = new DirectoryInfo(exeDir);
                if (di.Parent != null && di.Parent.Parent != null)
                {
                    dirPath = di.Parent.Parent.FullName + @"\Documents";
                }
            }
            OpenFile(Directory.Exists(dirPath) ? dirPath : null);
        }

        void rpc_UserAction(object sender, UserRibbonPreviewActionEventArgs e)
        {
            switch (e.Action)
            {
                case RibbonPreviewAction.FileOpen:
                    OpenFile(null);
                    e.Cancel = true;
                    break;

                case RibbonPreviewAction.FileClose:
                    Text = "C1PrintDocument Viewer";
                    break;
            }
        }

        void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        void AppMenu_DropDown(object sender, EventArgs e)
        {
            var ribbonItems = rpc.Ribbon.ApplicationMenu.RightPaneItems;
            while (ribbonItems.Count > 3)
            {
                int index = ribbonItems.Count - 1;
                var ri = ribbonItems[index];
                ribbonItems.RemoveAt(index);
                ri.Dispose();
            }
        }

        #endregion
    }
}
