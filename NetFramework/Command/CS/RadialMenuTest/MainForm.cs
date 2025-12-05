using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.Command;

namespace RadialMenuTest
{
    public partial class MainForm : Form
    {
        private C1RadialMenu _activeRadialMenu;
		private int _menuClosedCounter = 1;

		public MainForm()
        {
            InitializeComponent();
            _activeRadialMenu = this.c1RmC1;

            chkShowOnMouseDown.Checked = true;
            chkShowExpanded.Checked = true;
            chkAutoHide.Checked = _activeRadialMenu.AutoHide;
            chkAnimateMenu.Checked = _activeRadialMenu.UseAnimation;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
			//this.Invoke(new Action(ShowMenu));
			ShowMenu();
		}

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
			// show radial menu when mouse clicked inside panel
			if (chkShowOnMouseDown.Checked && panel1.ClientRectangle.Contains(new Point(e.X, e.Y)))
			{
				_activeRadialMenu.ShowMenu(this, this.PointToScreen(new Point(e.X, e.Y)), chkShowExpanded.Checked);
			}
		}

        private void ShowMenu()
        {
            _activeRadialMenu.ShowMenu(this, CalcCenter(), chkShowExpanded.Checked);
        }

        private Point CalcCenter()
        {
            int w = tableLayoutPanel1.GetColumnWidths()[0];
            int h = tableLayoutPanel1.Height;
            return tableLayoutPanel1.PointToScreen(new Point(w / 2, h / 2));
        }

        private void RadialMenu_ItemClick(object sender, RadialMenuItemClickEventArgs e)
        {
            switch (e.RadialMenuItem.UserData as string)
            {
                case "check":
                    e.RadialMenuItem.Checked = !e.RadialMenuItem.Checked;
                    e.RadialMenuItem.Text = e.RadialMenuItem.Checked ? "ON" : "OFF";
                    e.RadialMenuItem.ToolTip = e.RadialMenuItem.Checked ? "Checked item" : "Unchecked item";
                    e.RadialMenuItem.Image = e.RadialMenuItem.Checked ?
                        global::RadialMenuTest.Properties.Resources.bullet_ball_glass_red :
                        global::RadialMenuTest.Properties.Resources.bullet_ball_glass_grey;
                    break;
                case "locale":
                    RadialMenuItem parent = e.RadialMenuItem.Parent as RadialMenuItem;
                    if (parent != null)
                    {
                        foreach (RadialMenuItem it in parent.Items)
                            if ((string)it.UserData == "locale")
                                it.Checked = false;
                    }
                    e.RadialMenuItem.Checked = true;
                    break;
            }
        }

		private void UpdateMenuPositionEventHandler(object sender, EventArgs e)
        {
            if (_activeRadialMenu.Visible)
                _activeRadialMenu.CenterOnScreen = CalcCenter();
        }

        private void rmiHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help clicked");
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
			ShowMenu();
		}

        private void btnHideMenu_Click(object sender, EventArgs e)
        {
            _activeRadialMenu.HideMenu();
        }

        private void chkAnimateMenu_CheckedChanged(object sender, EventArgs e)
        {
            _activeRadialMenu.UseAnimation = chkAnimateMenu.Checked;
        }

        private void chkAutoHide_CheckedChanged(object sender, EventArgs e)
        {
            _activeRadialMenu.AutoHide = chkAutoHide.Checked;
        }

		private void RadialMenu_MenuClosed(object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine($"Menu closed {_menuClosedCounter}");
			_menuClosedCounter++;
		}
	}
}
