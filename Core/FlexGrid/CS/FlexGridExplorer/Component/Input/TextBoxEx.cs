using System.ComponentModel;

namespace FlexGridExplorer.Component.Input
{
    /// <summary>
    /// Extends the standard <see cref="TextBox"/> control by adding placeholder text support.
    /// </summary>
    public class TextBoxEx : TextBox
    {
        #region Variables Private
        const int WmPaint = 15;
        string _placeHolder = "";
        #endregion

        #region Public Methods
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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
                    var graphics = Graphics.FromHwnd(Handle);

                    if (string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(Placeholder))
                    {
                        graphics.DrawString(Placeholder, Font, Brushes.DimGray, new PointF(0, 0));
                    }
                    break;
            }
        }
        #endregion
    }
}
