using System;
using System.ComponentModel;
using C1.Win.C1Ribbon;
using C1.Win.C1Themes;
using C1.Win.Layout;

namespace DashboardDemo.Controls
{
    public partial class BaseForm : C1RibbonForm, IDemo
    {
        #region Fields
        private LayoutType _layoutType;
        #endregion Fields

        #region Ctor
        public BaseForm()
        {
            InitializeComponent();
        }
        #endregion Ctor

        #region Properties
        public VisualStyle RibbonVisualStyle
        {
            get { return c1Ribbon1.VisualStyle; }
            set { c1Ribbon1.VisualStyle = value; }
        }

        public ToolIconAppearance ToolIconAppearance { get; set; }

        public LayoutType LayoutType
        {
            get { return _layoutType; }
            set
            {
                if (_layoutType != value)
                {
                    _layoutType = value;
                    switch (_layoutType)
                    {
                        case LayoutType.Flow:
                            btnFlow.Pressed = true;
                            break;
                        case LayoutType.Grid:
                            btnGrid.Pressed = true;
                            break;
                        case LayoutType.Split:
                            btnSplit.Pressed = true;
                            break;
                    }
                }
            }
        }
        #endregion Properties               

        #region Events
        /// <summary>
        /// Occurs when ItemIndex of Theme ComboBox is changed.
        /// </summary>
        [Category("Sample")]
        [Description("Occurs when ItemIndex of Theme ComboBox is changed.")]
        public event EventHandler<ThemeEventArgs> DemoThemeChanged;
        protected void OnDemoThemeChanged(object sender, string themeName)
        {
            DemoThemeChanged?.Invoke(sender, new ThemeEventArgs(themeName));
        }
        /// <summary>
        /// Occurs when ItemIndex of ToolIcon ComboBox is changed.
        /// </summary>
        [Category("Sample")]
        [Description("Occurs when ItemIndex of ToolIcon ComboBox is changed.")]
        public event EventHandler<ToolIconAppearanceEventArgs> ToolIconAppearanceChanged;
        protected void OnToolIconAppearanceChanged(object sender, ToolIconAppearance tia)
        {
            ToolIconAppearanceChanged?.Invoke(sender, new ToolIconAppearanceEventArgs(tia));
        }
        /// <summary>
        /// Occurs when one of the apply layout menu button is clicked.
        /// </summary>
        [Category("Sample")]
        [Description("Occurs when one of the apply layout menu button is clicked.")]
        public event EventHandler<FilePathEventArgs> ApplyLayoutClicked;
        protected void OnApplyLayoutClicked(object sender, EventArgs e)
        {
            RibbonItem btn = sender as RibbonItem;
            if (btn != null)
                ApplyLayoutClicked?.Invoke(sender, new FilePathEventArgs(SampleHelper.Instance.GetLayoutPath(btn.Tag as string)));
        }
        /// <summary>
        /// Occurs when save layout menu button is clicked.
        /// </summary>
        [Category("Sample")]
        [Description("Occurs when save layout menu button is clicked.")]
        public event EventHandler<FilePathEventArgs> SaveLayoutClicked;
        protected void OnSaveLayoutClicked(object sender, string path)
        {
            SaveLayoutClicked?.Invoke(sender, new FilePathEventArgs(path));
        }
        /// <summary>
        /// Occurs when reset layout menu button is clicked.
        /// </summary
        [Category("Sample")]
        [Description("Occurs when reset layout menu button is clicked.")]
        public event EventHandler<FilePathEventArgs> ResetLayoutClicked;
        protected void OnResetLayoutClicked(object sender, string path)
        {
            ResetLayoutClicked?.Invoke(sender, new FilePathEventArgs(path));
        }
        /// <summary>
        /// Occurs when one of the LyoutType toggle button is pressed.
        /// </summary
        [Category("Sample")]
        [Description("Occurs when one of the LyoutType toggle button is pressed.")]
        public event EventHandler<LayoutTypeEventArgs> LayoutTypeChanged;
        protected void OnLayoutTypeChanged(object sender, LayoutType type)
        {
            LayoutTypeChanged?.Invoke(sender, new LayoutTypeEventArgs(type));
        }
        #endregion        

        #region Private
        private void LoadThemes()
        {
            cmbThemes.Items.Clear();

            var themes = C1ThemeController.GetThemes();
            cmbThemes.Items.Add("None");
            foreach (var theme in themes)
                if(!theme.Contains("Office2010") && !theme.Contains("Office2007"))
                    cmbThemes.Items.Add(theme);
            cmbThemes.SelectedIndex = cmbThemes.Items.IndexOf("Office2016Colorful");
        }

        private void LoadIconAppearance()
        {
            cmbToolicon.Items.Clear();

            var positions = Enum.GetValues(typeof(ToolIconAppearance));
            for (var i = 0; i < positions.Length; i++)
            {
                var value = positions.GetValue(i).ToString();
                cmbToolicon.Items.Add(value);
                if (value.Equals(ToolIconAppearance.ToString()))
                    cmbToolicon.SelectedIndex = i;
            }
        }

        private void UpdateLayouts()
        {
            foreach (RibbonButton item in menuApply.Items)
                item.Click -= OnApplyLayoutClicked;
            menuApply.Items.Clear();

            string[] layouts = SampleHelper.Instance.GetLayouts();
            if (layouts != null)
            {
                if (layouts.Length == 0)
                {
                    menuApply.Enabled = false;
                }
                else
                {
                    menuApply.Enabled = true;
                    foreach (var item in layouts)
                    {
                        var btn = new RibbonButton();
                        btn.Text = item.Substring(0, item.LastIndexOf('.'));
                        btn.Tag = item;
                        btn.Click += OnApplyLayoutClicked;
                        menuApply.Items.Add(btn);
                    }
                }
            }
            else
                menuApply.Enabled = false;
        }
        #endregion Private

        #region EventHandlers
        private void menuSave_Click(object sender, EventArgs e)
        {
            string filePath;
            if (SampleHelper.Instance.SaveLayoutDialog(out filePath))
            {
                OnSaveLayoutClicked(sender, filePath);
                UpdateLayouts();
            }
        }

        private void menuReset_Click(object sender, EventArgs e)
        {
            OnResetLayoutClicked(sender, SampleHelper.Instance.DefaultLayoutPath);            
        }

        private void menuManage_Click(object sender, EventArgs e)
        {
            SampleHelper.Instance.ManageLayoutDialog();
            UpdateLayouts();
        }

        private void btnFlow_PressedChanged(object sender, EventArgs e)
        {
            if (btnFlow.Pressed)
                OnLayoutTypeChanged(sender, LayoutType.Flow);
        }

        private void btnGrid_PressedChanged(object sender, EventArgs e)
        {
            if (btnGrid.Pressed)
                OnLayoutTypeChanged(sender, LayoutType.Grid);
        }

        private void btnSplit_PressedChanged(object sender, EventArgs e)
        {
            if (btnSplit.Pressed)
                OnLayoutTypeChanged(sender, LayoutType.Split);
        }

        private void cmbToolicon_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnToolIconAppearanceChanged(sender, (ToolIconAppearance)Enum.Parse(typeof(ToolIconAppearance), cmbToolicon.SelectedItem.Text));
        }

        private void cmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            OnDemoThemeChanged(sender, cmbThemes.SelectedItem.Text);
        }
        #endregion EventHandlers

        #region IDemo
        public void Init()
        {
            LoadThemes();
            LoadIconAppearance();
            UpdateLayouts();
        }
        #endregion IDemo
    }
}
