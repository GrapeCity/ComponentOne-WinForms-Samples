namespace FlexGridCheckboxSelection.Helper
{
    /// <summary>
    /// A custom panel that draws a dashed border around itself.
    /// </summary>
    /// 
    internal class DashedBorderPanel : Panel
    {
        #region Property Setters and Getters

        [Category("Appearance")]
        [Description("Gets or sets the color of the dashed border.")]
        [DefaultValue(typeof(Color), "Gray")]
        public Color BorderColor { get; set; } = Color.Gray;

        [Category("Appearance")]
        [Description("Gets or sets the thickness (in pixels) of the dashed border.")]
        [DefaultValue(1.5f)]
        public float BorderThickness { get; set; } = 1.5f;

        [Category("Appearance")]
        [Description("Gets or sets the dash style of the border.")]
        [DefaultValue(DashStyle.Dash)]
        public DashStyle BorderDashStyle { get; set; } = DashStyle.Dash;

        #endregion
        
        #region Public Methods
        public DashedBorderPanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }
        #endregion

        #region Protected Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.Clear(BackColor);
            using (var pen = new Pen(BorderColor, BorderThickness))
            {
                pen.DashStyle = BorderDashStyle;
                var rect = ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawRectangle(pen, rect);
            }
        } 

        #endregion
    }
}
