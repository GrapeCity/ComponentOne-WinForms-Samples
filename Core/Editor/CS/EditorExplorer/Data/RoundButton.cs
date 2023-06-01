using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EditorExplorer
{
    using Data;

    [ToolboxItem(true)]
    public class RoundButton : Button
    {
        private int _corners = 0;

        [DefaultValue(0)]
        public int Corners
        {
            get => _corners;
            set
            {
                if (_corners != value)
                {
                    _corners = value;
                    RoundedRectangle.SetRoundedCorners(this, _corners);
                }
            }
        }

        public override void NotifyDefault(bool value) => base.NotifyDefault(false);

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            RoundedRectangle.SetRoundedCorners(this, Corners);
        }
    }
}