using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using C1.Win.FlexGrid;

namespace CustomEditor
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
    public class Form1 : System.Windows.Forms.Form
    {
        private C1.Win.FlexGrid.C1FlexGrid _flex;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        // custom editor
        private MyEditor _myEditor;

        public Form1()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                if (components != null) 
                {
                    components.Dispose();
                }
            }
            base.Dispose( disposing );
        }

		#region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.BackColor = System.Drawing.SystemColors.Window;
            this._flex.ColumnInfo = "10,1,0,0,0,75,Columns:0{Width:26;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Name = "_flex";
            this._flex.Size = new System.Drawing.Size(512, 430);
            this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
            this._flex.TabIndex = 0;
            this._flex.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
            this._flex.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("_flex.Tree.NodeImageCollapsed")));
            this._flex.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("_flex.Tree.NodeImageExpanded")));
            this._flex.StartEdit += new C1.Win.FlexGrid.RowColEventHandler(this._flex_StartEdit);
            this._flex.AfterScroll += new C1.Win.FlexGrid.RangeEventHandler(this._flex_AfterScroll);
            this._flex.AfterEdit += new C1.Win.FlexGrid.RowColEventHandler(this._flex_AfterEdit);
            this._flex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._flex_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(512, 430);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                                                          this._flex});
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Custom Editors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() 
        {
            Application.Run(new Form1());
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            // create custom editor
            _myEditor = new MyEditor(_flex);
            _myEditor.Leave += new EventHandler(_editor_Leave);

            // make first column a DateTime (just for testing)
            //_flex.Cols[1].DataType = typeof(DateTime);

            // assign first column a mask so the control won't display the
            // drop-down button for the calendar
            //_flex.Cols[1].EditMask = "99/99/99";
        }
		
        // use custom editor to edit column 1
        private void _flex_StartEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
        {
            if (e.Col == 1)
            {
                // start editing the cell with the custom editor
                _myEditor.StartEditing(e.Row, e.Col);

                // cancel built-in editor
                e.Cancel = true;
            }
        }

        // if the custom editor is visible, make it follow the cell being edited
        private void _flex_AfterScroll(object sender, C1.Win.FlexGrid.RangeEventArgs e)
        {
            if (_myEditor.Visible)
                _myEditor.UpdatePosition();
        }

        // save last key pressed for the custom editor
        private void _flex_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            _myEditor.SetPendingKey(e.KeyChar);
        }

        // after edit handler (built-in editors)
        private void _flex_AfterEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
        {
            Console.WriteLine("** After Edit handler");
        }

        // after edit handler (custom editor)
        private void _editor_Leave(object sender, EventArgs e)
        {
            if (!_myEditor.Cancel)
                Console.WriteLine("** After Edit Custom handler");
        }
    }

	/// <summary>
	/// MyEditor inherits from a TextBox and can be used as a custom editor
	/// for a C1FlexGrid control.
	/// </summary>
    public class MyEditor : System.Windows.Forms.TextBox // System.Windows.Forms.ComboBox 
    {
        private C1FlexGrid _owner;
        private int  _row, _col;
        private char _pendingKey;
        private bool _cancel;

        // constructor: attach to owner grid
        public MyEditor(C1FlexGrid owner)
        {
            Visible     = false;
            AutoSize    = false;
            BackColor   = Color.Beige;
            BorderStyle = BorderStyle.None;

            _pendingKey = (char)0;
            _cancel     = false;
            _owner      = owner;
            _owner.Controls.Add(this);
        }

        // start editing: move to cell and activate
        public void StartEditing(int row, int col)
        {
            // save coordinates of cell being edited
            _row = row;
            _col = col;

            // assume we'll save the edits
            _cancel = false;

            // move editor over the current cell
            Rectangle rc = _owner.GetCellRect(row, col, true);
            rc.Width--;
            rc.Height--;
            Bounds = rc;

            // initialize control content
            Text = "";
            if (_pendingKey > ' ')
                Text = _pendingKey.ToString();
            else if (_owner[row, col] != null)
                Text = _owner[row, col].ToString();
            Select(Text.Length, 0);

            // make editor visible
            Visible = true;

            // and get the focus
            Select();
        }

        // save key that started the editing mode
        public void SetPendingKey(char chr)
        {
            _pendingKey = chr;
        }

        // expose internal variables
        public bool Cancel      { get { return _cancel; }}
        public int Row          { get { return _row; }}
        public int Col          { get { return _col; }}

        // move editor after the grid has scrolled
		public void UpdatePosition()
		{
			// get cell rect now
			Rectangle rcCell = _owner.GetCellRect(_row, _col, false);

			// intersect with scrollable part of the grid
			Rectangle rcScroll = _owner.ClientRectangle;
			rcScroll.X = _owner.Cols[_owner.Cols.Fixed].Left;
			rcScroll.Y = _owner.Rows[_owner.Rows.Fixed].Top;
			rcScroll.Width -= rcScroll.X;
			rcScroll.Height -= rcScroll.Y;
			rcCell = Rectangle.Intersect(rcCell, rcScroll);

			// and move the control
			if (rcCell.Width > 0) rcCell.Width--;
			if (rcCell.Height > 0) rcCell.Height--;
			Bounds = rcCell;
		}

		// lost focus: hide the editor
		override protected void OnLeave(System.EventArgs e)
		{
			// base processing
			base.OnLeave(e);

			// copy text to owner grid
			if (!_cancel)
				_owner[_row, _col] = Text;

			// no more pending keys
			_pendingKey = (char)0;

			// done for now, hide editor
			Visible = false;
		}

		// we will handle the Tab key ourselves
		override protected bool IsInputKey(Keys keyData)
		{
			if (keyData == Keys.Tab) return true;
			return base.IsInputKey(keyData);
		}

		// some keys end the editing
		override protected void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Escape: // cancel edits
					_cancel = true;
					_owner.Select();
					e.Handled = true;
					return;

				case Keys.Enter: // finish editing
				case Keys.Tab:
				case Keys.Up:
				case Keys.Down:
				case Keys.PageUp:
				case Keys.PageDown:
					_owner.Select();
					e.Handled = true;
					MoveCursor(e.KeyCode);
					return;

				default: // default processing
					base.OnKeyDown(e);
					return;
			}
		}

		// move cursor after done editing
		protected void MoveCursor(Keys key)
		{
			int row = _owner.Row;
			int col = _owner.Col;
			switch (key)
			{
				case Keys.Tab:          col++;      break;
				case Keys.Up:           row--;      break;
                case Keys.Return:       row++;      break;
                case Keys.Down:         row++;      break;
				case Keys.PageUp:       row -= 10;  break;
				case Keys.PageDown:     row += 10;  break;
			}

			// validate new selection
			if (row < _owner.Rows.Fixed)   row = _owner.Rows.Fixed;
			if (col < _owner.Cols.Fixed)   col = _owner.Cols.Fixed;
			if (row > _owner.Rows.Count-1) row = _owner.Rows.Count-1;
			if (col > _owner.Cols.Count-1) col = _owner.Cols.Count-1;

			// apply new selection
			_owner.Select(row, col);
		}

		// suppress some keys to avoid annoying beep
		override protected void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case (char)27: // Keys.Escape:
				case (char)13: // Keys.Enter:
				case (char) 9: // Keys.Tab:
					e.Handled = true;
					return;
			}
			base.OnKeyPress(e);
		}
	}
}
