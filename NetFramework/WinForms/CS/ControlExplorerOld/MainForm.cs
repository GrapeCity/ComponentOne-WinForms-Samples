using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Linq;
using C1.Win.C1Command;
using C1.Win.C1Ribbon;
using C1.Win.C1Themes;
using ControlExplorer.Main;

namespace ControlExplorer
{
    public partial class MainForm : C1RibbonForm
    {
        private C1DemoViewer _viewer = null;
        private C1DemoForm _activeForm;
        // control icons:
        static private readonly List<Image> _controlIconsLight = new List<Image>()
        {
            ControlExplorer.Properties.Resources.ci_Barcode,
            ControlExplorer.Properties.Resources.ci_Chart,
            ControlExplorer.Properties.Resources.ci_FlexChart,
            ControlExplorer.Properties.Resources.ci_DockingTab,
            ControlExplorer.Properties.Resources.ci_DynamicHelp,
            ControlExplorer.Properties.Resources.ci_Editor,
            ControlExplorer.Properties.Resources.ci_Excel,
            ControlExplorer.Properties.Resources.ci_FlexGrid,
            ControlExplorer.Properties.Resources.ci_FlexPivot,
            ControlExplorer.Properties.Resources.ci_FlexReport,
            ControlExplorer.Properties.Resources.ci_GanttView,
            ControlExplorer.Properties.Resources.ci_Gauge,
            ControlExplorer.Properties.Resources.ci_Input,
            ControlExplorer.Properties.Resources.ci_InputPanel,
            ControlExplorer.Properties.Resources.ci_List,
            ControlExplorer.Properties.Resources.ci_Map,
            ControlExplorer.Properties.Resources.ci_PDF,
            // Relevant content moved to FlexReport node: ControlExplorer.Properties.Resources.ci_Report,
            ControlExplorer.Properties.Resources.ci_Ribbon,
            ControlExplorer.Properties.Resources.ci_Scheduler,
            ControlExplorer.Properties.Resources.ci_Sizer,
            ControlExplorer.Properties.Resources.ci_SpellChecker,
            ControlExplorer.Properties.Resources.ci_SplitContainer,
            // Relevant content moved to FlexReport node: ControlExplorer.Properties.Resources.ci_SSRS,
            ControlExplorer.Properties.Resources.ci_SuperTooltip,
            ControlExplorer.Properties.Resources.ci_Themes,
            ControlExplorer.Properties.Resources.ci_TileControl,
            ControlExplorer.Properties.Resources.ci_Toolbars,
            ControlExplorer.Properties.Resources.ci_TreeView,
            ControlExplorer.Properties.Resources.ci_TrueDBGrid,
            ControlExplorer.Properties.Resources.ci_Win7Pack,
            ControlExplorer.Properties.Resources.ci_Word,
        };

        private ControlExplorer.Main.FlatIconList _icons = new FlatIconList();
        private Image _controlNewOverlay = ControlExplorer.Properties.Resources.New;

        /// <summary>
        /// Gets the main form instance.
        /// </summary>
        public static MainForm TheMainForm { get; private set; }

        public MainForm()
        {
            // initialize icons
            foreach (Image icon in _controlIconsLight)
            {
                _icons.Add(icon);
            }
            _icons.Add(_controlNewOverlay);
            InitializeComponent();

            TheMainForm = this;

            ControlExplorer.Properties.Settings.Default.SettingsLoaded += Default_SettingsLoaded;

            _viewer = new C1DemoViewer();

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        void Default_SettingsLoaded(object sender, System.Configuration.SettingsLoadedEventArgs e)
        {
            MainForm.ThemeName = ControlExplorer.Properties.Settings.Default.ThemeName;
            // Show current theme in the theme combo:
            cmbTheme.Items.Clear();
            cmbTheme.Items.Add(new C1.Win.C1InputPanel.InputOption(MainForm.ThemeName));
            cmbTheme.SelectedIndex = 0;
            ApplyTheme(this);
            this.cmbTheme.ChangeCommitted += new System.EventHandler(this.cmbTheme_ChangeCommitted);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            #region ReadControlXML

            XmlReader xr = XmlReader.Create("C1Controls.xml");
            //int _tcount = 0;
            //int _trow = 1;
            //int _tleft = 1;
            int indexgp = 0;
            int pageIndex = 0;

            //set text for Main heading Tile
            c1TileControl2.Groups[0].Tiles[0].Text1 = "Over 80 .NET Windows Forms controls, including the ones you can't get anywhere else.\n\nComponentOne Studio® WinForms Edition controls come packed with smart, code-free designers, endless built-in features, superior flexibility, and the outstanding assurance that these controls will stand the test of time.";
            
            while (xr.Read())
            {
                if (xr.NodeType == XmlNodeType.Element)
                {
                    switch (xr.Name)
                    {
                        case "control":
                            string name = xr.GetAttribute("name");
                            string _gname = name;

                            //adding tile control for the home page    
                            C1.Win.C1Tile.Tile t1 = new C1.Win.C1Tile.Tile();
                            t1.Text = name;

                            //Highlight new controls and samples using a different tile image
                            if (xr.GetAttribute("status") == "new")
                            {
                                t1.Template = template2;
                                // See note below.
                                // t1.ImageIndex = _pageIndex;
                                t1.Image = _icons[pageIndex].Image;
                                t1.Image1 = _icons[_icons.Count - 1].Image;
                            }
                            else
                            {
                                // Due to a bug in ImageList, using ImageIndex does not preserve semi-transparent pixels,
                                // whereas using the actual image works fine:
                                // t1.ImageIndex = _pageIndex;
                                t1.Image = _icons[pageIndex].Image;
                            }
                            c1TileControl1.Groups[0].Tiles.Add(t1);
                            
                            //create group for second tile
                            C1.Win.C1Tile.Group controlGrp = new C1.Win.C1Tile.Group();
                            controlGrp.Visible = false;
                            controlGrp.Name = name;
                            c1TileControl2.Groups.Add(controlGrp);
                            indexgp = controlGrp.Index;

                            ////reconfiguring how the tiles are arranged
                            //foreach (C1.Win.C1Tile.Tile _tSub in c1TileControl1.Groups[0].Tiles)
                            //{
                            //    if (_tleft >= 8)
                            //    {
                            //        _tleft = 1;
                            //        _trow = _trow + 1;
                            //    }
                            //    if (c1TileControl1.Groups[0].Tiles[_tcount] == _tSub)
                            //    {
                            //        _tSub.TopCell = _trow;
                            //        _tSub.LeftCell = _tleft;
                            //        _tleft = _tleft + 1;
                            //        _tcount = _tcount + 1;
                            //    }

                            //}
                            pageIndex++;
                            break;
                        case "sample":

                            //all the groups for individual controls are created one time, and individual sample tiles are added on form load.
                            //On subsequent clicks the groups for controls are hidden and shown, inorder to better performance.
                            C1.Win.C1Tile.Tile tsample = new C1.Win.C1Tile.Tile();
                            if(xr.GetAttribute("status")=="new")
                            {
                                tsample.Template = template4;
                                tsample.Image = ControlExplorer.Properties.Resources.c1new2;
                            }
                            tsample.Name = xr.GetAttribute("name");
                            tsample.Text = xr.GetAttribute("name");
                            tsample.Text1 = xr.GetAttribute("short"); 
                            tsample.Tag = new DemoForm(xr.GetAttribute("form"), xr.GetAttribute("description"));
                            c1TileControl2.Groups[indexgp].Tiles.Add(tsample);
                            break;
                    }
                }
            }

            #endregion

            LoadWelcomePage();
            _backBtn.Enabled = false;
            c1TileControl1.Select();
        }

        #region Internal Methods
        private void AddOrRemove(Control.ControlCollection collection, Control control)
        {
            if (control == null)
            {
                collection.Clear();
                return;
            }

            if (!collection.Contains(control))
            {
                collection.Clear();
                collection.Add(control);
                control.Dock = DockStyle.Fill;
                control.Visible = true;
            }
        }

        public void Attach(Control viewer)
        {
            AddOrRemove(panel1.Controls, viewer);
        }

        public void Detach()
        {
            Attach(null);
        }

        void ResetViewer()
        {
            _viewer.Close();
        }

        private void LoadWelcomePage()
        {
            //for the tile version this is loaded blank - super label on homepage is populated with no text.
            _activeForm = _viewer.Run(typeof(Main.HomePage).ToString(), "ComponentOne Studio WinForms Edition", "");
            this.Attach(_viewer);
        }

        // This method is used to open platform home page.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.componentone.com/Studio/Platform/WinForms");
        }
        // download page
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.componentone.com/Download/");
        }

        public void LoadPage(string formName, string title, string desc)
        {
            this.Cursor = Cursors.AppStarting;
            _activeForm = _viewer.Run(formName, title, desc);
            this.Attach(_viewer);
            this.Cursor = Cursors.Default;
        }
        #endregion

        #region Theming

        /// <summary>
        /// Gets or sets the name of a C1Theme used by the control explorer.
        /// The theme name is persisted in the app's config file,
        /// setting this property updates the config.
        /// </summary>
        public static string ThemeName
        {
            get
            {
                return ControlExplorer.Properties.Settings.Default.ThemeName;
            }
            set
            {
                if (ControlExplorer.Properties.Settings.Default.ThemeName != value)
                {
                    ControlExplorer.Properties.Settings.Default.ThemeName = value;
                    ControlExplorer.Properties.Settings.Default.Save();
                }
            }
        }
        
        /// <summary>
        /// Gets the C1Theme used by the control explorer, or null if no theme is used
        /// or the theme specified in the app's config file cannot be found.
        /// </summary>
        public static C1Theme Theme
        {
            get
            {
                if (!string.IsNullOrEmpty(ThemeName))
                    return C1.Win.C1Themes.C1ThemeController.GetThemeByName(ThemeName, false);
                else
                    return null;
            }
        }

        /// <summary>
        /// Applies the theme used by the control explorer, to the specified controls and
        /// recursively to its children.
        /// </summary>
        /// <param name="control">The control to apply the theme to.</param>
        public static void ApplyTheme(Control control)
        {
            try
            {
                var theme = Theme;
                if (theme != null)
                {
                    if (control == TheMainForm)
                    {
                        // color all icons according to the new loaded theme
                        Color foreground = Theme.GetColor(@"BaseThemeProperties\ControlText");
                        bool needUpdateIcons = foreground != TheMainForm._icons.Foreground;
                        if (needUpdateIcons)
                        {
                            TheMainForm._icons.Foreground = foreground;
                            for (int i = 0; i < TheMainForm.c1TileControl1.Groups[0].Tiles.Count; ++i)
                            {
                                var tile = TheMainForm.c1TileControl1.Groups[0].Tiles[i];
                                if (tile.Image == TheMainForm.pictureBox2.Image)
                                    TheMainForm.pictureBox2.Image = TheMainForm._icons[i].Image;
                                if (tile.Image1 != null) //= _controlNewOverlay;
                                    tile.Image1 = TheMainForm._icons[TheMainForm._icons.Count - 1].Image;

                                tile.Image = TheMainForm._icons[i].Image;
                            }
                        }
                    }

                    if (control.FindForm() == TheMainForm)
                    {
                        // Controls that rely on specific colors to be visible/usable:
                        List<Control> noTheming = new List<Control>()
                    {
                        TheMainForm._backBtn,
                        TheMainForm.label1,
                        TheMainForm.label3,
                        TheMainForm.panel3
                    };
                        C1ThemeController.ApplyThemeToControlTree(control, theme, (c) => !noTheming.Contains(c));
                    }
                    else
                        C1ThemeController.ApplyThemeToControlTree(control, theme);
                }
            }
            catch
            {
                // eat theme-related exceptions
            }
        }

        private void cmbTheme_DropDown(object sender, EventArgs e)
        {
            cmbTheme.Items.Clear();
            string[] themes = C1ThemeController.GetThemes();
            var showThemes = themes.Where((tn) =>
            {
                var ltn = tn.ToLower();
                if (ltn.Contains("visualstyle")) // avoid old "visual style" themes
                    return false;
                else
                    return true;
            });

            foreach (string theme in showThemes)
                cmbTheme.Items.Add(new C1.Win.C1InputPanel.InputOption(theme));
        }

        private void cmbTheme_ChangeCommitted(object sender, EventArgs e)
        {
            this.SuspendPainting();
            C1Theme theme = C1ThemeController.GetThemeByName(cmbTheme.Text, false);
            if (theme != null)
                ThemeName = theme.Name;
            else
                ThemeName = string.Empty;
            ApplyTheme(this);
            this.ResumePainting();
        }

        #endregion

        #region Events and Methods
        //Click event when any home page tile is clicked
        private void c1TileControl1_TileClicked(object sender, C1.Win.C1Tile.TileEventArgs e)
        {
            //update view of homepage
            c1TileControl1.Visible = false;
            panel1.Visible = true;
            label1.Visible = false;
            label3.Text = e.Tile.Text/*.ToLower()*/;
            label3.Visible = true;
            pictureBox2.Image = e.Tile.Image;
            _backBtn.Visible = true;
            _backBtn.BringToFront(); // for some reason theme application before 1st opening a demo seems to move it back
            _backBtn.Enabled = true;

            //Load the first sample for control here
            loadFirstSample(e.Tile.Text);

            //Load tile group for samples list
            c1TileControl2.UncheckAllTiles();
            foreach (C1.Win.C1Tile.Group gp in c1TileControl2.Groups)
            {
                if (gp.Name == e.Tile.Text)
                    gp.Visible = true;
                else
                    gp.Visible = false;
            }
            if (cmbTheme.SelectedIndex == 6)
                c1TileControl2.BackColor = this.BackgroundColor;
        }

        //Load sample of the selected control
        private void loadFirstSample(string name)
        {
            foreach (C1.Win.C1Tile.Group gp in c1TileControl2.Groups)
            {
                if (gp.Name == name)
                    loadandshow(gp.Tiles[0]);
            }
        }
        //change visible properties of various container controls on the page
        private void refreshhomepage()
        {
            c1TileControl2.UncheckAllTiles();
            foreach (C1.Win.C1Tile.Group gp in c1TileControl2.Groups)
            {
                if (gp.Index != 0)
                    gp.Visible = false;
                else
                    gp.Visible = true;
            }
            c1TileControl1.Visible = true;
            panel1.Visible = false;
            label1.Visible = true;
            label3.Visible = false;
            label2.Text = "";
            pictureBox2.Image = null;
            _backBtn.Visible = false;
            _backBtn.Enabled = false;
            c1TileControl2.BackColor = c1TileControl1.BackColor;
            c1TileControl1.Select();
        }

        private void _backBtn_Click(object sender, EventArgs e)
        {
            LoadWelcomePage();
            refreshhomepage();
        }
        
        //Secod tile control click event, to launch the samples
        private void c1TileControl2_TileClicked(object sender, C1.Win.C1Tile.TileEventArgs e)
        {
            if (e.Tile.Group.Index != 0)
            {
                _backBtn.Enabled = false;
                
                loadandshow(e.Tile);
                
                //code changed for loading samples after each tile click
                //DemoForm d = (DemoForm)e.Tile.Tag;
                //this.Cursor = Cursors.AppStarting;
                //activeForm = viewer.Run(d.FormName, e.Tile.Text, d.Description);
                //this.Attach(viewer);
                //this.Cursor = Cursors.Default;
                //label2.Text = e.Tile.Text1;
                //System.Threading.Thread.Sleep(3000);
                _backBtn.Enabled = true;
            }
        }

        //method to load samples and launch them in demoviewer
        private void loadandshow(C1.Win.C1Tile.Tile launcherTile)
        {
            // mark launcher tile:
            launcherTile.TileControl.UncheckAllTiles();
            launcherTile.Checked = true;

            DemoForm d = (DemoForm)launcherTile.Tag;
            this.Cursor = Cursors.AppStarting;
            _activeForm = _viewer.Run(d.FormName, launcherTile.Text, d.Description);
            this.Attach(_viewer);
            this.Cursor = Cursors.Default;
            label2.Text = launcherTile.Text1;
        }

        #endregion
    }

    public class DemoForm
    {
        string _form;
        string _desc;
        string _name;

        public DemoForm(string form, string desc)
        {
            _form = form;
            _desc = desc;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string FormName
        {
            get { return _form; }
            set { _form = value; }
        }

        public string Description
        {
            get { return _desc; }
            set { _desc = value; }
        }

    }
}
