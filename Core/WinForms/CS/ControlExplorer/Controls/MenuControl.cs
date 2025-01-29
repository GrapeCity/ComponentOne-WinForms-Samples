using System;
using System.Drawing;
using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    public partial class MenuControl : UserControl
    {
        #region Private Variables 
        private CustomTooltip _customTooltip;
        private ItemInfo _control;
        private MenuItemControl _selectedMenuItem;
        private string _selectedItem;

        #endregion

        #region Public Methods 

        public event EventHandler CodeButtonClick;

        public void UpdateCodeButtonText(string text)
        {
            btnViewCode.Text = text;
            btnViewCode.Icon = text == "View Demo" ? ControlIcons.Demo : ControlIcons.Code;
        }

        public string SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                _selectedItem = value;
                lblSelectedMenu.Text = value;
            }
        }

        public MenuControl(ItemInfo info)
        {
            _control = info;
            InitializeComponent();
            AddMenuItems();

            btnViewCode.Icon = ControlIcons.Code;

            btnViewCode.Click += (s, e) => CodeButtonClick?.Invoke(this, e);
        }

        #endregion

        #region Private Methods 
        private void AddMenuItems()
        {
            if (_control.Menus != null && _control.Menus.Count > 1)
            {
                foreach (ItemInfo menu in _control.Menus)
                {
                    string menuText = menu.Name;
                    MenuItemControl menuControl = new MenuItemControl(menuText)
                    {
                        Height = 50
                    };
                    menuControl.SetWidth(menuText);
                    menuControl.Tag = menu;
                    menuControl.Click += MenuItemControl_Click;
                    menuPanel.Controls.Add(menuControl);

                    if (menu.Name == _control.DefaultSampleName)
                    {
                        menuControl.Selected = true;
                        _selectedMenuItem = menuControl;
                        SelectedItem = menuControl.MenuName;
                        InitTooltip(menu.LongDescription);
                    }
                }
                Panel linePanel = new Panel
                {
                    BackColor = Color.LightGray,
                    Height = 1,
                    Width = this.ClientSize.Width,
                    Location = new Point(0, topPnl.Height + 50),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };
                this.Controls.Add(linePanel);
                linePanel.BringToFront();
            }
            else if (_control.Menus != null && _control.Menus.Count == 1)
            {
                foreach (ItemInfo menu in _control.Menus)
                {
                    SelectedItem = menu.Name;
                    InitTooltip(menu.LongDescription);
                }
            }
            else
            {
                SelectedItem = _control.Name;
                InitTooltip(_control.LongDescription);
            }
        }

        private void MenuItemControl_Click(object sender, EventArgs e)
        {
            if (_selectedMenuItem != null)
            {
                _selectedMenuItem.Selected = false;
            }
            MenuItemControl menuItemClicked = sender as MenuItemControl;
            menuItemClicked.Selected = true;
            _selectedMenuItem = menuItemClicked;
            SelectedItem = menuItemClicked.MenuName;
            ItemInfo selectedItemInfo = menuItemClicked.Tag as ItemInfo;
            if (selectedItemInfo != null)
            {
                Explorer.TheExplorer?.ShowSample(selectedItemInfo, false);
                InitTooltip(selectedItemInfo.LongDescription);
            }
        }
        private void InitTooltip(string description)
        {
            if (!string.IsNullOrEmpty(description))
            {
                pictureBox1.Visible = true;
                pictureBox1.Location = new Point(lblSelectedMenu.Right + 3, lblSelectedMenu.Top + (lblSelectedMenu.Height - pictureBox1.Height) / 2);
                int desiredWidth = 600;

                if (_customTooltip != null)
                {
                    _customTooltip.Dispose();
                    _customTooltip = null;
                }

                _customTooltip = new CustomTooltip
                {
                    Text = description,
                    Visible = false,
                    Width = desiredWidth,
                    MinimumSize = new Size(desiredWidth, 40),
                };
                Size textSize = TextRenderer.MeasureText(description, _customTooltip.Font,
                    new Size(desiredWidth - _customTooltip.Padding.Horizontal, int.MaxValue), TextFormatFlags.WordBreak);
                _customTooltip.Height = textSize.Height + _customTooltip.Padding.Vertical;
                AttachMouseEvents();
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private Form GetParentForm()
        {
            Control parent = this.Parent;
            while (parent != null && !(parent is Form))
            {
                parent = parent.Parent;
            }
            return parent as Form;
        }

        private void AttachMouseEvents()
        {
            pictureBox1.MouseEnter += PictureBox1_MouseEnter;
            pictureBox1.MouseLeave += PictureBox1_MouseLeave;
        }

        private void PictureBox1_MouseEnter(object sender, EventArgs e)
        {
            // Find the parent form
            Form mainForm = GetParentForm();
            if (mainForm != null)
            {
                mainForm.Controls.Add(_customTooltip);
                Point locationOnScreen = this.PointToScreen(new Point(pictureBox1.Right, pictureBox1.Top - 5));
                Point locationInForm = mainForm.PointToClient(locationOnScreen);
                if (locationInForm.X + _customTooltip.Width > mainForm.ClientSize.Width)
                {
                    locationInForm.X = mainForm.ClientSize.Width - _customTooltip.Width;
                }
                if (locationInForm.Y + _customTooltip.Height > mainForm.ClientSize.Height)
                {
                    locationInForm.Y = mainForm.ClientSize.Height - _customTooltip.Height;
                }

                _customTooltip.Location = locationInForm;
            }
            _customTooltip.Visible = true;
            _customTooltip.BringToFront();
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            _customTooltip.Visible = false;
        }

        #endregion

        #region Protected Methods
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion
    }
}
