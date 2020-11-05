using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Input;

namespace ControlExplorer.Controls
{
    public partial class CategoryControl : UserControl
    {
        const int height = 36;
        const int titleHeight = 54;
        const int titleWidth = 128;
        const int spacing = 12;
        int _lastDpi = 0;
        bool _isTop = false;
        bool _isNew = false;


        public CategoryControl(string name, string group, Color backColor, Color hotColor, int paddingLeft)
        {
            InitializeComponent();
            this.lblCategoryTitle.Text = name;
            this.lblCategoryTitle.Padding = new Padding(paddingLeft, 20, 0, 0);
            group = group.ToLower().Trim();

            if (group == "new")
            {
                _isNew = true;
                foreach (ControlInfo control in ControlInfo.Controls)
                {
                    if (control.IsNew)
                    {
                        ControlTile btn = new ControlTile(control, backColor, hotColor, paddingLeft);
                        this.pnlTiles.Controls.Add(btn);
                    }
                }
            }
            else if (group == "top")
            {
                _isTop = true;
                foreach (ControlInfo control in ControlInfo.Controls)
                {
                    if (control.IsPopular)
                    {
                        ControlTile btn = new ControlTile(control, backColor, hotColor, paddingLeft);
                        this.pnlTiles.Controls.Add(btn);
                    }
                }
            }
            else
            {
                foreach (ControlInfo control in ControlInfo.Controls)
                {
                    if (control.Group.ToLower().Trim() == group)
                    {
                        ControlTile btn = new ControlTile(control, backColor, hotColor, paddingLeft);
                        this.pnlTiles.Controls.Add(btn);
                    }
                }
            }
            LayoutControls();
        }

        private void LayoutControls()
        {
            int dpi = base.DeviceDpi;
            if (dpi != _lastDpi)
            {
                double scale = (double)dpi / 96;
                var actualSpacing = (int)(spacing * scale);
                var y = (int)actualSpacing;

                foreach (ControlTile btn in this.pnlTiles.Controls)
                {
                    btn.Location = new Point(0, y);
                    y += btn.Size.Height + actualSpacing;
                }
                this.lblCategoryTitle.Size =new Size((int)(titleWidth * scale), (int)((_isTop ? height : titleHeight) * scale));
                this.pnlTiles.Size = new Size(this.pnlTiles.Width, y);
                if (_isNew || _isTop)
                {
                    this.Size = new Size(this.Width, lblCategoryTitle.Size.Height + y);
                }
            }
            _lastDpi = dpi;
        }
        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);
            LayoutControls();
        }

    }
}
