using System.Drawing;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples.ColumnEditors
{
    /// <summary>
	/// FlexTextBox is a resizable multiline textbox written to display as an editor in C1FlexGrid.
	/// 
	/// It was modeled after the CellNote editor from the CellNotes demo
	/// </summary>
    class FlexTextBox : TextBox
    {
        private Label _lblGrip;
        private System.ComponentModel.Container components = null;

        /// <summary>
        /// Constructor.
        /// </summary>
        public FlexTextBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        //------------------------------------------------------------------------------------------------------
        #region ** Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlexTextBox));
            _lblGrip = new Label();
            SuspendLayout();
            // 
            // _lblGrip
            // 
            _lblGrip.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            _lblGrip.BackColor = Color.Transparent;
            _lblGrip.Cursor = Cursors.SizeNWSE;
            _lblGrip.Image = (Image)resources.GetObject("_lblGrip.Image");
            _lblGrip.Location = new Point(100, 0);
            _lblGrip.Name = "_lblGrip";
            _lblGrip.Size = new Size(16, 16);
            _lblGrip.TabIndex = 1;
            _lblGrip.MouseMove += _lblGrip_MouseMove;
            _lblGrip.MouseDown += _lblGrip_MouseDown;
            // 
            // TextBox
            // 
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BackColor = Color.White;
            Controls.Add(this._lblGrip);
            Size = new Size(120, 20);
            MinimumSize = new Size(120, 20);
            Multiline = true;
            ResumeLayout(false);

        }
        #endregion

        //------------------------------------------------------------------------------------------------------
        #region ** overrides/event handlers

        // handle resizing the textbox
        Point _ptDown;
        Size _szDown;

        private void _lblGrip_MouseDown(object sender, MouseEventArgs e)
        {
            _ptDown = Control.MousePosition;
            _szDown = Size;
        }

        private void _lblGrip_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) != 0)
            {
                Point p = Control.MousePosition;
                Size = new Size(
                    _szDown.Width + (p.X - _ptDown.X),
                    _szDown.Height + (p.Y - _ptDown.Y));
            }
        }

        #endregion

    }
}
