using C1.Win.Input;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExplorer.Controls
{
    public class ControlTile : C1Button
    {
        const int width = 215;
        const int height = 36;
        int _lastDpi = 0;

        public ControlTile(ControlInfo info, Color backColor, Color hotColor, int paddingLeft)
        {
            ControlInfo = info;
            Text = info.Name;
            Icon = info.Icon;
            this.Trimming = StringTrimming.Character;
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.ImageAlign = ContentAlignment.MiddleLeft;
            if (Icon != null)
            {
                Icon.Color = Color.FromArgb(31, 31, 32);
                this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            }
            Styles.Border = new C1.Framework.Thickness(0);
            Styles.Hot.ForeColor = Styles.HotPressed.ForeColor =
                Styles.Pressed.ForeColor = 
                Styles.Default.ForeColor = Color.FromArgb(31, 31, 32);
            Styles.Font = new Font("Trebuchet MS", 9.75f);
            Styles.Padding = new C1.Framework.Thickness(paddingLeft, 0,0,0);
            Styles.Margins = new C1.Framework.Thickness(0);
            Styles.Default.BackColor = backColor;
            Styles.Hot.BackColor = Styles.HotPressed.BackColor =
                Styles.Pressed.BackColor = hotColor;
            SetSize();
        }

        private void SetSize()
        {
            int dpi = base.DeviceDpi;
            if (dpi != _lastDpi)
            {
                double scale = (double)dpi / 96;
                Size = new Size((int)(width * scale), (int)(height * scale));
            }
            _lastDpi = dpi;
        }
        public ControlInfo ControlInfo
        {
            get; private set;
        }

        protected override void RescaleConstantsForDpi(int deviceDpiOld, int deviceDpiNew)
        {
            base.RescaleConstantsForDpi(deviceDpiOld, deviceDpiNew);            
            SetSize();
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Explorer.TheExplorer.ShowControl(ControlInfo);
        }
    }
}
