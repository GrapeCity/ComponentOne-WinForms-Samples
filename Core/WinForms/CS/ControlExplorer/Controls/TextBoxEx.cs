using System.Drawing;
using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    public class TextBoxEx : TextBox
    {
        #region Variables
        const int WmPaint = 15;
        string _placeHolder = "";
        #endregion

        #region Public Methods
        public string Placeholder
        {
            get
            {
                return _placeHolder;
            }
            set
            {
                _placeHolder = value;
                Refresh();
            }
        }
        public TextBoxEx()
        {
            Margin = new Padding(5);
        }
        #endregion

        #region Protected Methods 
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WmPaint:
                    using (var graphics = Graphics.FromHwnd(Handle))
                    {
                        if (string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(Placeholder))
                        {
                            graphics.DrawString(Placeholder, Font, Brushes.DimGray, new PointF(0, 0));
                        }
                    }
                    break;
            }
        }
        #endregion
    }
}
