using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    // todo: 
    // - scrolling with themeable scrollbars
    public partial class AllControls : UserControl
    {
        readonly Dictionary<CategoryControl, int> _categoriesWidth = new();
        const int catWidth = 125;
        const int spacing = 10;
        const int titleHeight = 36;
        const int lblAllWidth = 110;
        int _lastDpi = 0;

        public AllControls()
        {
            InitializeComponent();
            InitializeCategories();
            LayoutControls();
        }

        private void InitializeCategories()
        {
            var cat1 = new CategoryControl("DATA\r\nMANAGEMENT", "Grids and data management", Color.White, Color.FromArgb(242, 242, 243), 8);
            cat1.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.pnlCategories.Controls.Add(cat1);
            _categoriesWidth.Add(cat1, catWidth);

            var cat2 = new CategoryControl("DATA\r\nVISUALIZATION", "Data visualization", Color.White, Color.FromArgb(242, 242, 243), 8);
            cat2.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.pnlCategories.Controls.Add(cat2);
            _categoriesWidth.Add(cat2, catWidth);

            var cat3 = new CategoryControl("INPUT AND\r\nEDITING", "Input and editing", Color.White, Color.FromArgb(242, 242, 243), 8);
            cat3.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.pnlCategories.Controls.Add(cat3);
            _categoriesWidth.Add(cat3, 160); // MultiColumnCombo > catWidth

            var cat4 = new CategoryControl("REPORTING AND\r\nDOCUMENTS", "Reporting and documents", Color.White, Color.FromArgb(242, 242, 243), 8);
            cat4.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.pnlCategories.Controls.Add(cat4);
            _categoriesWidth.Add(cat4, catWidth);

            var cat5 = new CategoryControl("UTILITIES", "Utilities", Color.White, Color.FromArgb(242, 242, 243), 8);
            cat5.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.pnlCategories.Controls.Add(cat5);
            _categoriesWidth.Add(cat5, catWidth);

            var cat6 = new CategoryControl("SCHEDULING", "Scheduling", Color.White, Color.FromArgb(242, 242, 243), 8);
            cat6.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.pnlCategories.Controls.Add(cat6);
            _categoriesWidth.Add(cat6, catWidth);

            var cat7 = new CategoryControl("NAVIGATION\r\nAND LAYOUT", "Navigation and layout", Color.White, Color.FromArgb(242, 242, 243), 8);
            cat7.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom;
            this.pnlCategories.Controls.Add(cat7);
            _categoriesWidth.Add(cat7, catWidth);
        }

        private void LayoutControls()
        {
            int dpi = DeviceDpi;
            if (dpi != _lastDpi)
            {
                double scale = (double)dpi / 96;
                double scaledSpacing = spacing * scale;
                var x = scaledSpacing;
                foreach (CategoryControl cat in pnlCategories.Controls)
                {
                    var width = _categoriesWidth[cat] * scale;
                    var size = new Size((int)width, ClientSize.Height);
                    var step = scaledSpacing + width;
                    cat.Size = size;
                    cat.Location = new Point((int)x, 0);
                    x += step;
                }
                this.pnlTitle.Size = new Size(pnlTitle.Width, (int)(titleHeight * scale));
                this.lblAllControls.Size = new Size((int)(lblAllWidth * scale), lblAllControls.Height);
            }
            _lastDpi = dpi;
        }

        protected override void RescaleConstantsForDpi(int deviceDpiOld, int deviceDpiNew)
        {
            base.RescaleConstantsForDpi(deviceDpiOld, deviceDpiNew);
            LayoutControls();
        }

        protected override void OnDpiChangedAfterParent(EventArgs e)
        {
            base.OnDpiChangedAfterParent(e);
            LayoutControls();
        }
    }
}
