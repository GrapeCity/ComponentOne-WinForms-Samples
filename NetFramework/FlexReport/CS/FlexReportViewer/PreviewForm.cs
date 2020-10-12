using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
using System.Xml;

using C1.Win.Ribbon;
using C1.Win.C1Win7Pack;
using C1.Win.FlexReport;
using C1.Win.FlexViewer;

namespace FlexReportViewer
{
    public partial class PreviewForm : C1RibbonForm
    {
        #region static members

        internal const string FormTitle = "FlexReport Viewer";
        const ThemeColor DefaultThemeColor = ThemeColor.Azure;

        const string OpenFileDlgTitle = "Open Report Definition File";
        const string FileOpenFilter = "FlexReport Definition Files (*.flxr)|*.flxr|Legacy C1Report Definition Files (*.xml)|*.xml|All Files|*.*";
        const string FriendlyName = "FlexReport Definition File";
        const string DefaultIcon = @"%systemroot%\system32\shell32.dll,284";
        const string OpenWithCommandFmt = "\"{0}\" \"%1\"";
        const string SampleReportsDir = @"\Reports";

        static string _exePath, _startupFilePath;

        static bool _isWindows10;
        static bool _isWindows10240;

        static PreviewForm()
        {
            RibbonStyle.UpdateInstance(DefaultThemeColor, ThemeLightness.DarkGray);
            var ipStyle = (C1.Win.C1InputPanel.ThemeColor)((int)DefaultThemeColor);
            C1.Win.C1InputPanel.InputStyle.UpdateInstance(ipStyle, C1.Win.C1InputPanel.ThemeLightness.LightGray);

            var ov = new OSVERSIONINFO();
            ov.dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFO));
            RtlGetVersion(ref ov);
            _isWindows10 = ov.dwMajorVersion >= 10;
            _isWindows10240 = ov.dwMajorVersion == 10 && ov.dwBuildNumber < 10586;

            _exePath = Application.ExecutablePath;
        }

        internal static void SetStartupFilePath(string filePath)
        {
            _startupFilePath = filePath;
        }

        #endregion

        #region fields

        ThemeColor _themeColor;
        bool _shortcutInstalled;

        StringCollection _recentItems;

        RibbonButton _exportButton;
        RibbonButton _printButton;
        RibbonButton _pageSetupButton;
        RibbonButton _closeButton;
        RibbonMenu _themeColorMenu;

        RibbonComboBox _reportsCombo;
        XmlDocument _doc;
        C1FlexReport _report;

        RibbonLabel _registerLabel;
        bool _registered;

        #endregion

        #region ctor/Dispose

        public PreviewForm()
        {
            InitializeComponent();

            Text = FormTitle;
            BuildAppMenu();

            // A workaround for the bug with pinned items in Windows 10 build 10240.
            if (_startupFilePath == null && _isWindows10240)
            {
                atb.AddShortcutToStartMenu();
                _shortcutInstalled = true;
            }

            // subscribe to color theme changes
            RibbonStyle.Instance.StyleChanged += RibbonStyle_StyleChanged;
            RibbonStyle_StyleChanged(this, EventArgs.Empty);

            var st = Properties.Settings.Default;

            // A workaround for the bug with Recent Items in Windows 10 builds 10240 and 10586
            if (_isWindows10)
            {
                _recentItems = st.RecentItems;
                if (_recentItems == null)
                {
                    _recentItems = new StringCollection();
                }
            }

            // load theme color from settings
            var s = st.ThemeColor;
            if (string.IsNullOrEmpty(s) || !Enum.TryParse<ThemeColor>(s, out _themeColor))
                _themeColor = DefaultThemeColor;
            else
            {
                var coll = _themeColorMenu.Items;
                for (int i = 0; i < coll.Count; i++)
                {
                    var tb = (RibbonToggleButton)coll[i];
                    if ((ThemeColor)tb.Tag == _themeColor)
                    {
                        tb.Pressed = true;
                        break;
                    }
                }
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
                CloseFile();
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #endregion

        #region build app menu

        void BuildAppMenu()
        {
            var appMenu = fv.Ribbon.ApplicationMenu;
            appMenu.Visible = true;
            appMenu.KeyTip = "Q";
            appMenu.SmallImage = Properties.Resources.Menu;
            appMenu.DropDownWidth = 420;
            appMenu.DropDown += AppMenu_DropDown;

            var btn = new RibbonButton();
            btn.SmallImage = Properties.Resources.Open16x16;
            btn.LargeImage = Properties.Resources.Open32x32;
            btn.Text = "Open";
            btn.Click += OpenButton_Click;
            appMenu.LeftPaneItems.Add(btn);

            _exportButton = new RibbonButton();
            _exportButton.Enabled = false;
            _exportButton.SmallImage = Properties.Resources.Export16x16;
            _exportButton.LargeImage = Properties.Resources.Export32x32;
            _exportButton.Text = "Export";
            new ButtonActionElement(fv, _exportButton, FlexViewerAction.Export);
            appMenu.LeftPaneItems.Add(_exportButton);

            appMenu.LeftPaneItems.Add(new RibbonSeparator());

            _printButton = new RibbonButton();
            _printButton.Enabled = false;
            _printButton.SmallImage = Properties.Resources.Print16x16;
            _printButton.LargeImage = Properties.Resources.Print32x32;
            _printButton.Text = "Print";
            new ButtonActionElement(fv, _printButton, FlexViewerAction.Print);
            appMenu.LeftPaneItems.Add(_printButton);

            _pageSetupButton = new RibbonButton();
            _pageSetupButton.Enabled = false;
            _pageSetupButton.SmallImage = Properties.Resources.PageSetup16x16;
            _pageSetupButton.LargeImage = Properties.Resources.PageSetup32x32;
            _pageSetupButton.Text = "Page Setup";
            new ButtonActionElement(fv, _pageSetupButton, FlexViewerAction.PageSetup);
            appMenu.LeftPaneItems.Add(_pageSetupButton);

            appMenu.LeftPaneItems.Add(new RibbonSeparator());

            _closeButton = new RibbonButton();
            _closeButton.Enabled = false;
            _closeButton.SmallImage = Properties.Resources.Close16x16;
            _closeButton.LargeImage = Properties.Resources.Close32x32;
            _closeButton.Text = "Close";
            _closeButton.Click += CloseButton_Click;
            appMenu.LeftPaneItems.Add(_closeButton);

            appMenu.LeftPaneItems.Add(new RibbonSeparator());

            btn = new RibbonButton();
            btn.SmallImage = Properties.Resources.Exit16x16;
            btn.LargeImage = Properties.Resources.Exit32x32;
            btn.Text = "Exit";
            btn.Click += ExitButton_Click;
            appMenu.LeftPaneItems.Add(btn);

            var rli = new C1.Win.Ribbon.RibbonListItem();
            rli.AllowSelection = false;
            rli.Items.Add(new RibbonLabel("Recent Documents"));
            appMenu.RightPaneItems.Add(rli);

            _registerLabel = new RibbonLabel();
            rli = new C1.Win.Ribbon.RibbonListItem();
            rli.Items.Add(_registerLabel);
            rli.Click += RegisterButton_Click;
            appMenu.RightPaneItems.Add(rli);

            rli = new C1.Win.Ribbon.RibbonListItem();
            rli.AllowSelection = false;
            rli.Items.Add(new RibbonSeparator());
            appMenu.RightPaneItems.Add(rli);

            _reportsCombo = new RibbonComboBox();
            _reportsCombo.Enabled = false;
            _reportsCombo.GripHandleVisible = true;
            _reportsCombo.KeyTip = "G";
            _reportsCombo.Label = " Select report: ";
            _reportsCombo.TextAreaWidth = 170;
            _reportsCombo.MaxDropDownItems = 12;
            _reportsCombo.DropDownStyle = RibbonComboBoxStyle.DropDownList;
            _reportsCombo.ChangeCommitted += ReportsCombo_SelectedIndexChanged;

            var ti = fv.Ribbon.TopToolBar.Items;
            ti.Insert(ti.Count - 2, _reportsCombo);
            fv.Ribbon.Qat.Visible = false;

            _themeColorMenu = new RibbonMenu();
            _themeColorMenu.Text = "&Colors";
            fv.StatusBar.RightPaneItems.Insert(0, new RibbonSeparator());
            fv.StatusBar.RightPaneItems.Insert(0, _themeColorMenu);

            var coll = _themeColorMenu.Items;
            AddThemeColor(coll, ThemeColor.Azure);
            AddThemeColor(coll, ThemeColor.Blue);
            AddThemeColor(coll, ThemeColor.Green);
            AddThemeColor(coll, ThemeColor.Orange);
            AddThemeColor(coll, ThemeColor.Orchid);
            AddThemeColor(coll, ThemeColor.Red);
            AddThemeColor(coll, ThemeColor.Teal);
            AddThemeColor(coll, ThemeColor.Violet);
            var tb = (RibbonToggleButton)coll[0];
            tb.Pressed = true;
            tb.PressedButtonChanged += PreviewForm_PressedButtonChanged;

            fv.ZoomMode = FlexViewerZoomMode.PageWidth;
            fv.ShowParameters = true;
        }

        void AddThemeColor(RibbonItemCollection items, ThemeColor themeColor)
        {
            RibbonToggleButton tb = new RibbonToggleButton();
            tb.Text = themeColor.ToString();
            tb.Tag = themeColor;
            tb.ToggleGroupName = "Theme";
            tb.CanDepress = false;
            items.Add(tb);
        }

        #endregion

        #region methods

        bool OpenFile(string filePath, bool addToJumpList = true)
        {
            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath))
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.DereferenceLinks = true;
                    dlg.Title = OpenFileDlgTitle;
                    if (!string.IsNullOrEmpty(filePath))
                    {
                        if (!Directory.Exists(filePath))
                            filePath = Path.GetDirectoryName(filePath);
                        if (Directory.Exists(filePath))
                            dlg.InitialDirectory = filePath;
                    }
                    dlg.Filter = FileOpenFilter;
                    dlg.FilterIndex = 0;
                    if (dlg.ShowDialog() != DialogResult.OK)
                    {
                        return false;
                    }
                    filePath = dlg.FileName;
                }
                addToJumpList = true;
            }
            XmlDocument doc = null;
            string ext = Path.GetExtension(filePath).ToLowerInvariant();
            try
            {
                if (ext == ".flxr" || ext == ".xml")
                {
                    doc = new XmlDocument();
                    doc.PreserveWhitespace = true;
                    doc.Load(filePath);
                }
                else
                {
                    MessageBox.Show("Can't open file with \"" + ext + "\" extension.", FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (doc != null)
            {
                Text = Path.GetFileNameWithoutExtension(filePath);
                if (addToJumpList)
                {
                    if (CheckFileRegistration())
                        atb.JumpList.AddToRecentCategory(filePath);
                    if (_isWindows10)
                    {
                        bool found = false;
                        for (int i = 0; i < _recentItems.Count; i++)
                        {
                            if (string.Compare(_recentItems[i], filePath, StringComparison.OrdinalIgnoreCase) == 0)
                            {
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            _recentItems.Add(filePath);
                        }
                    }
                }

                string[] reportList = C1FlexReport.GetReportList(doc);
                if (reportList == null || reportList.Length == 0)
                {
                    MessageBox.Show("The opened file does not contain any reports.", FormTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

                _doc = doc;

                var coll = _reportsCombo.Items;
                _reportsCombo.Items.ClearAndDisposeItems();
                for (int i = 0; i < reportList.Length; i++)
                {
                    coll.Add(new RibbonButton(reportList[i]));
                }
                UpdateEnabled();
                _reportsCombo.DroppedDown = true;
                return true;
            }
            return false;
        }

        void CloseFile()
        {
            _doc = null;
            if (_report != null)
            {
                this.Text = FormTitle;
                fv.DocumentSource = null;
                _report.Dispose();
                _report = null;
                _reportsCombo.Items.ClearAndDisposeItems();
                _reportsCombo.SelectedIndex = -1;
            }
            UpdateEnabled();
        }

        void UpdateEnabled()
        {
            bool hasDoc = _doc != null;
            bool hasReport = _report != null;
            _closeButton.Enabled = hasDoc;
            _reportsCombo.Enabled = hasDoc;
            _exportButton.Enabled = hasReport;
            _printButton.Enabled = hasReport;
            _pageSetupButton.Enabled = hasReport;
        }

        void LoadReport(string reportName)
        {
            var report = new C1FlexReport();
            report.Load(_doc, reportName);

            var oldReport = _report;
            _report = report;

            // assign report to the flex viewer control
            fv.DocumentSource = report;

            if (oldReport != null)
            {
                oldReport.Dispose();
            }
            UpdateEnabled();
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
            bool result = false;
            if (extRegDlg.DialogResult == TaskDialogResult.Custom &&
                extRegDlg.ClickedCustomButton.Name == "registerButton")
            {
                try
                {
                    RegisterAssociations();
                    result = true;
                }
                catch (Win32Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return result;
        }

        bool CheckAssociations()
        {
            return atb.CheckFileAssociations(".flxr");
        }

        void RegisterAssociations()
        {
            atb.RegisterFileAssociations(true, FriendlyName, DefaultIcon, string.Format(OpenWithCommandFmt, _exePath), ".flxr");
        }

        void UnregisterAssociations()
        {
            atb.UnregisterFileAssociations(true, ".flxr");
        }

        #endregion

        #region event handlers

        void PreviewForm_Shown(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            Application.Idle -= Application_Idle;
            if (_startupFilePath != null)
            {
                OpenFile(_startupFilePath, false);
                _startupFilePath = null;
                return;
            }

            bool hasRecentItems = false;
            if (_isWindows10)
                hasRecentItems = _recentItems.Count > 0;
            else
            {
                var items = atb.JumpList.GetKnownCategoryItems(JumpListKnownCategory.Recent);
                hasRecentItems = items.Count > 0;
            }
            if (hasRecentItems)
            {
                fv.Ribbon.ApplicationMenu.DroppedDown = true;
                return;
            }

            var exeDir = Path.GetDirectoryName(_exePath);
            var dirPath = exeDir + SampleReportsDir;
            if (!Directory.Exists(dirPath))
            {
                DirectoryInfo di = new DirectoryInfo(exeDir);
                if (di.Parent != null && di.Parent.Parent != null)
                {
                    dirPath = di.Parent.Parent.FullName + SampleReportsDir;
                }
            }
            OpenFile(Directory.Exists(dirPath) ? dirPath : null);
        }

        void ReportsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_doc != null)
            {
                RibbonButton item = _reportsCombo.SelectedItem;
                if (item != null)
                {
                    LoadReport(item.Text);
                }
            }
        }

        void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFile(null);
        }

        void CloseButton_Click(object sender, EventArgs e)
        {
            CloseFile();
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
            var ribbonItems = fv.Ribbon.ApplicationMenu.RightPaneItems;
            while (ribbonItems.Count > 3)
            {
                int index = ribbonItems.Count - 1;
                var ri = ribbonItems[index];
                ribbonItems.RemoveAt(index);
                ri.Dispose();
            }

            if (CheckAssociations())
            {
                _registerLabel.Text = "{ unregister .flxr files from this application }";
                _registered = true;
            }
            else
            {
                _registerLabel.Text = "{ register .flxr files with this application }";
                _registered = false;
            }

            if (_isWindows10)
            {
                for (int i = 1; i <= _recentItems.Count; i++)
                {
                    string path = _recentItems[i - 1];
                    if (path != null)
                    {
                        AppendListItem(ribbonItems, i, path).Tag = path;
                    }
                }
            }
            else
            {
                var items = atb.JumpList.GetKnownCategoryItems(JumpListKnownCategory.Recent);
                for (int i = 1; i <= items.Count; i++)
                {
                    C1JumpPath jumpPath = items[i - 1] as C1JumpPath;
                    if (jumpPath != null)
                    {
                        AppendListItem(ribbonItems, i, jumpPath.Path).Tag = jumpPath;
                    }
                }
            }
        }

        RibbonListItem AppendListItem(RibbonItemCollection ribbonItems, int num, string path)
        {
            var rli = new C1.Win.Ribbon.RibbonListItem();

            var sb = new StringBuilder();
            if (num < 10)
                sb.Append('&').Append(num).Append("  ");
            else
                sb.Append(num).Append(' ');
            sb.Append(Path.GetFileNameWithoutExtension(path));
            rli.Items.Add(new RibbonLabel(sb.ToString()));

            var delButton = new C1.Win.Ribbon.RibbonButton();
            if (num < 10)
                delButton.KeyTip = "Y" + num.ToString();
            delButton.SelectableInListItem = true;
            delButton.SmallImage = Properties.Resources.Delete16x16;
            delButton.ToolTip = "Remove from list";
            delButton.Click += new System.EventHandler(this.DelButton_Click);
            rli.Items.Add(delButton);

            ribbonItems.Add(rli);

            rli.ToolTip = path;
            rli.Click += RibbonListItem_Click;
            return rli;
        }

        void RibbonListItem_Click(object sender, EventArgs e)
        {
            RibbonListItem rli = (RibbonListItem)sender;
            if (_isWindows10)
                OpenFile((string)rli.Tag, false);
            else
            {
                C1JumpPath jumpPath = (C1JumpPath)rli.Tag;
                OpenFile(jumpPath.Path, false);
            }
        }

        void DelButton_Click(object sender, EventArgs e)
        {
            RibbonListItem rli = ((RibbonButton)sender).Parent as RibbonListItem;
            if (rli != null)
            {
                if (!_isWindows10)
                    atb.JumpList.RemoveFromKnownCategories((C1JumpPath)rli.Tag);
                else
                {
                    string s = (string)rli.Tag;
                    for (int i = 0; i < _recentItems.Count; i++)
                    {
                        if (_recentItems[i] == s)
                        {
                            _recentItems.RemoveAt(i);
                            break;
                        }
                    }
                }
                fv.Ribbon.ApplicationMenu.RightPaneItems.Remove(rli);
                rli.Dispose();
            }
        }

        void PreviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var st = Properties.Settings.Default;
            st.ThemeColor = _themeColor.ToString();
            if (_isWindows10)
            {
                st.RecentItems = _recentItems;
            }
            st.Save();
        }

        void RibbonStyle_StyleChanged(object sender, EventArgs e)
        {
            var s = RibbonStyle.Instance;
            var p = fv.Pane;

            p.SplitterColor = s.BrushSet.GetColor(StyleBrush.Toggled);

            p.OutlineForeColorNormal = s.ColorSet[StyleColor.TabText];
            p.OutlineBackColorHot = s.BrushSet.GetColor(StyleBrush.Hot);
            p.OutlineForeColorHot = s.ColorSet[StyleColor.HotText];
            p.OutlineBackColorSelected = s.BrushSet.GetColor(StyleBrush.Pressed);
            p.OutlineForeColorSelected = s.ColorSet[StyleColor.PressedText];
            p.OutlineBackColorHotSelected = s.BrushSet.GetColor(StyleBrush.Toggled);
            p.OutlineForeColorHotSelected = s.ColorSet[StyleColor.ToggledText];
            p.OutlineAreaBackColor = s.ColorSet[StyleColor.FormBackground];
            p.OutlineBackColorNormal = s.ColorSet[StyleColor.FormBackground];

            p.ThumbPageNumBackColor = s.BrushSet.GetColor(StyleBrush.AppButton);
            p.ThumbPageNumForeColor = s.ColorSet[StyleColor.AppButtonText];

            p.ThumbBackColorHot = s.BrushSet.GetColor(StyleBrush.Hot);
            p.ThumbBackColorPressed = s.BrushSet.GetColor(StyleBrush.Pressed);
            p.ThumbBackColorSelected = s.BrushSet.GetColor(StyleBrush.Toggled);

            p.ParamHeaderBackColor = s.BrushSet.GetColor(StyleBrush.Pressed);
            p.ParamHeaderForeColor = s.ColorSet[StyleColor.PressedText];
        }

        void PreviewForm_PressedButtonChanged(object sender, EventArgs e)
        {
            var tb = (RibbonToggleButton)sender;
            _themeColor = (ThemeColor)tb.PressedButton.Tag;
            RibbonStyle.UpdateInstance(_themeColor, ThemeLightness.DarkGray);

            var ipStyle = (C1.Win.C1InputPanel.ThemeColor)((int)_themeColor);
            C1.Win.C1InputPanel.InputStyle.UpdateInstance(ipStyle, C1.Win.C1InputPanel.ThemeLightness.LightGray);
        }

        #endregion

        #region interop code

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
