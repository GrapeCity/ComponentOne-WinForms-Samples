using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using C1.Win.C1Ribbon;
using C1.Win.C1RibbonPreview;
using C1.Win.C1Win7Pack;
using C1.C1Preview;

namespace RibbonPreviewControlDemo
{
    public partial class PreviewForm : C1RibbonForm
    {
        #region static members

        static string _exePath, _startupFilePath;
        static bool _isWindows10;

        static PreviewForm()
        {
            RibbonStyle.UpdateInstance(ThemeColor.Teal, ThemeLightness.LightGray);

            _isWindows10 = CheckWindows10();
            _exePath = Application.ExecutablePath;
        }

        internal static void SetStartupFilePath(string filePath)
        {
            _startupFilePath = filePath;
        }

        #endregion

        #region fields

        bool _shortcutInstalled;

        RibbonLabel _registerLabel;
        bool _registered;

        #endregion

        #region ctor/Dispose

        public PreviewForm()
        {
            InitializeComponent();
            BuildAppMenu();

            // A workaround for the bug with pinned items in Windows 10.
            if (_startupFilePath == null && _isWindows10)
            {
                atb.AddShortcutToStartMenu();
                _shortcutInstalled = true;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (_shortcutInstalled)
            {
                atb.RemoveShortcutFromStartMenu();
                _shortcutInstalled = false;
            }

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

            var rli = new C1.Win.C1Ribbon.RibbonListItem();
            rli.AllowSelection = false;
            rli.Items.Add(new RibbonLabel("Recent Documents"));
            appMenu.RightPaneItems.Add(rli);

            _registerLabel = new RibbonLabel();
            rli = new C1.Win.C1Ribbon.RibbonListItem();
            rli.Items.Add(_registerLabel);
            rli.Click += RegisterButton_Click;
            appMenu.RightPaneItems.Add(rli);

            rli = new C1.Win.C1Ribbon.RibbonListItem();
            rli.AllowSelection = false;
            rli.Items.Add(new RibbonSeparator());
            appMenu.RightPaneItems.Add(rli);
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
                if (addToJumpList && CheckFileRegistration())
                {
                    atb.JumpList.AddToRecentCategory(filePath);
                }
                return true;
            }
            return false;
        }

        bool CheckFileRegistration()
        {
            if (CheckAssociations())
            {
                return true;
            }
            if (extRegDlg.CheckBoxChecked)
            {
                return false;
            }
            extRegDlg.Show();
            if (extRegDlg.DialogResult == TaskDialogResult.Custom &&
                extRegDlg.ClickedCustomButton.Name == "registerButton")
            {
                RegisterAssociations();
                return true;
            }
            return false;
        }

        bool CheckAssociations()
        {
            return atb.CheckFileAssociations(".c1dx", ".c1d", ".c1mdx");
        }

        void RegisterAssociations()
        {
            string defaultIcon = @"%systemroot%\system32\shell32.dll,284";
            string openWithCommand = string.Format("\"{0}\" \"%1\"", _exePath);
            atb.RegisterFileAssociations(true, "C1PrintDocViewer", defaultIcon, openWithCommand, ".c1dx", ".c1d", ".c1mdx");
        }

        void UnregisterAssociations()
        {
            atb.UnregisterFileAssociations(true, ".c1dx", ".c1d", ".c1mdx");
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
            var items = atb.JumpList.GetKnownCategoryItems(JumpListKnownCategory.Recent);
            if (items.Count > 0)
            {
                rpc.Ribbon.ApplicationMenu.DroppedDown = true;
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

        void RegisterButton_Click(object sender, EventArgs e)
        {
            if (_registered)
                UnregisterAssociations();
            else
                RegisterAssociations();
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

            if (CheckAssociations())
            {
                _registerLabel.Text = "< unregister the file associations for .c1dx, .c1d, and .c1mdx >";
                _registered = true;
            }
            else
            {
                _registerLabel.Text = "< register.c1dx, .c1d, and.c1mdx files with this application >";
                _registered = false;
            }

            var items = atb.JumpList.GetKnownCategoryItems(JumpListKnownCategory.Recent);
            for (int i = 1; i <= items.Count; i++)
            {
                C1JumpPath jumpPath = items[i - 1] as C1JumpPath;
                if (jumpPath != null)
                {
                    var rli = new C1.Win.C1Ribbon.RibbonListItem();

                    var sb = new StringBuilder();
                    if (i < 10)
                        sb.Append('&').Append(i).Append("  ");
                    else
                        sb.Append(i).Append(' ');
                    sb.Append(Path.GetFileNameWithoutExtension(jumpPath.Path));
                    rli.Items.Add(new RibbonLabel(sb.ToString()));

                    var delButton = new C1.Win.C1Ribbon.RibbonButton();
                    if (i < 10)
                        delButton.KeyTip = "Y" + i.ToString();
                    delButton.SelectableInListItem = true;
                    delButton.SmallImage = Properties.Resources.Delete16x16;
                    delButton.ToolTip = "Remove from list";
                    delButton.Click += new System.EventHandler(this.DelButton_Click);
                    rli.Items.Add(delButton);

                    ribbonItems.Add(rli);

                    rli.Tag = jumpPath;
                    rli.ToolTip = jumpPath.Path;
                    rli.Click += RibbonListItem_Click;
                }
            }
        }

        void RibbonListItem_Click(object sender, EventArgs e)
        {
            RibbonListItem rli = (RibbonListItem)sender;
            C1JumpPath jumpPath = (C1JumpPath)rli.Tag;
            OpenFile(jumpPath.Path);
        }

        void DelButton_Click(object sender, EventArgs e)
        {
            RibbonListItem rli = ((RibbonButton)sender).Parent as RibbonListItem;
            if (rli != null)
            {
                atb.JumpList.RemoveFromKnownCategories((C1JumpPath)rli.Tag);
                rpc.Ribbon.ApplicationMenu.RightPaneItems.Remove(rli);
                rli.Dispose();
            }
        }

        #endregion

        #region interop code

        static bool CheckWindows10()
        {
            var ov = new OSVERSIONINFO();
            ov.dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFO));
            RtlGetVersion(ref ov);
            return ov.dwMajorVersion >= 10;
        }

        [System.Security.SuppressUnmanagedCodeSecurity()]
        [DllImport("ntdll.dll", CharSet = CharSet.Unicode)]
        static extern int RtlGetVersion(ref OSVERSIONINFO osVersion);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        struct OSVERSIONINFO
        {
            public int dwOSVersionInfoSize;
            public int dwMajorVersion;
            public int dwMinorVersion;
            public int dwBuildNumber;
            public int dwPlatformId;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string szCSDVersion;
        }

        #endregion
    }
}
