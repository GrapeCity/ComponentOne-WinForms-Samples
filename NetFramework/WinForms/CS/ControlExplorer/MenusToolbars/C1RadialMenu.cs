using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.MenusToolbars
{
    public partial class C1RadialMenu : C1DemoForm
    {
        public C1RadialMenu()
        {
            InitializeComponent();
        }

        private void C1RadialMenu_Load(object sender, EventArgs e)
        {
            c1RadialMenu1.ThemeChanged(Explorer.Theme);
            c1RadialMenu1.ShowMenu(this, new Point(600,500), true);
        }

        private void C1RadialMenu_Leave(object sender, EventArgs e)
        {
            
        }

        private void c1RadialMenu1_ItemClick(object sender, C1.Win.C1Command.RadialMenuItemClickEventArgs e)
        {
            
        }

        private void C1RadialMenu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                c1RadialMenu1.ThemeChanged(Explorer.Theme);
                // c1RadialMenu1.ShowMenu(this, new Point(600, 500), true);
                c1RadialMenu1.ShowMenu(this, this.PointToScreen(e.Location), true);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                c1RadialMenu1.HideMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
