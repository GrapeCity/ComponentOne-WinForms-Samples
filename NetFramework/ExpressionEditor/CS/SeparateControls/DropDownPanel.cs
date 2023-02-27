using System;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.ExpressionEditor;

namespace SeparateControls
{
    public partial class DropDownPanel : Form
    {
        private Control _owner;

        public DropDownPanel(Control owner, C1ExpressionEditor editor) : base()
        {
            _owner = owner;
            InitializeComponent();
            UpdateLocation();

            MaximizeBox = false;
            MinimizeBox = false;     
            KeyPreview = true;
            StartPosition = FormStartPosition.Manual;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ShowInTaskbar = false;

            // set ExpresionEditor property for panel
            c1ExpressionEditorPanel1.ExpressionEditor = editor;
        }

        // updates dialog location - places under the parent control
        private void UpdateLocation()
        {
            Point ownerLocation = _owner.Parent.PointToScreen(_owner.Location);
            var x = ownerLocation.X + _owner.Width - Width;
            var y = ownerLocation.Y + _owner.Height;
            SetDesktopLocation(x, y);
        }
        
        #region Override
        protected override void OnShown(EventArgs e)
        {
            UpdateLocation();
        }       

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.KeyCode == Keys.Escape)
                Close();
        }
        #endregion
    }
}
