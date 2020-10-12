using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace CellNotes
{
	/// <summary>
	/// CellNote is a form that displays notes attached to grid elements.
	/// 
	/// It was designed for use with the C1FlexGrid, but can be used with
	/// any other controls as well.
	/// </summary>
	public class CellNote : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox _txtNote;
		private System.Windows.Forms.Label _lblShadow;
		private System.Windows.Forms.Label _lblGrip;
		private System.ComponentModel.Container components = null;

		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="notText">Initial text for the CellNote.</param>
		public CellNote(string noteText)
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// Initialize form
			//
			ShowInTaskbar   = false;
			StartPosition   = FormStartPosition.Manual;
			FormBorderStyle = FormBorderStyle.None;
			TransparencyKey = BackColor;
			NoteText		= noteText;
		}
		public CellNote() : this(string.Empty) {}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		//------------------------------------------------------------------------------------------------------
		#region ** Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._txtNote = new System.Windows.Forms.TextBox();
			this._lblShadow = new System.Windows.Forms.Label();
			this._lblGrip = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// _txtNote
			// 
			this._txtNote.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._txtNote.BackColor = System.Drawing.SystemColors.Info;
			this._txtNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this._txtNote.Location = new System.Drawing.Point(36, 8);
			this._txtNote.Multiline = true;
			this._txtNote.Name = "_txtNote";
			this._txtNote.Size = new System.Drawing.Size(248, 116);
			this._txtNote.TabIndex = 0;
			this._txtNote.Text = "** Enter your notes here...";
			// 
			// _lblShadow
			// 
			this._lblShadow.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._lblShadow.BackColor = System.Drawing.Color.DimGray;
			this._lblShadow.Location = new System.Drawing.Point(40, 12);
			this._lblShadow.Name = "_lblShadow";
			this._lblShadow.Size = new System.Drawing.Size(248, 116);
			this._lblShadow.TabIndex = 1;
			// 
			// _lblGrip
			// 
			this._lblGrip.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this._lblGrip.BackColor = System.Drawing.Color.Black;
			this._lblGrip.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
			this._lblGrip.Location = new System.Drawing.Point(276, 116);
			this._lblGrip.Name = "_lblGrip";
			this._lblGrip.Size = new System.Drawing.Size(12, 12);
			this._lblGrip.TabIndex = 1;
			this._lblGrip.MouseMove += new System.Windows.Forms.MouseEventHandler(this._lblGrip_MouseMove);
			this._lblGrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this._lblGrip_MouseDown);
			// 
			// CellNote
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(292, 133);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this._txtNote,
																		  this._lblGrip,
																		  this._lblShadow});
			this.Name = "CellNote";
			this.Text = "CellNoteForm";
			this.ResumeLayout(false);

		}
		#endregion

		//------------------------------------------------------------------------------------------------------
		#region ** fields

		private Point _ptCell;
		private bool  _editing;

		#endregion

		//------------------------------------------------------------------------------------------------------
		#region ** object model

		/// <summary>
		/// Gets or sets the contents of the note.
		/// </summary>
		public string NoteText
		{
			get { return _txtNote.Text; }
			set { _txtNote.Text = value; }
		}
		/// <summary>
		/// Show the note with a connector to the cell.
		/// </summary>
		/// <param name="r">Position of the cell in screen coordinates.</param>
		public void ShowNote(Rectangle r)
		{
			ShowNote(r, false);
		}
		/// <summary>
		/// Hide the note if it is visible.
		/// </summary>
		public void HideNote()
		{
			if (!_editing)
				Visible = false;
		}
		/// <summary>
		/// Show the note with a connector to the cell and allow the user to edit the note.
		/// </summary>
		/// <param name="r">Position of the cell in screen coordinates.</param>
		public void EditNote(Rectangle r)
		{
			ShowNote(r, true);
		}

		#endregion

		//------------------------------------------------------------------------------------------------------
		#region ** private stuff

		private void ShowNote(Rectangle r, bool editMode)
		{
			if (!Visible)
			{
				// position form
				Left = r.Right + 1;
				Top  = r.Y - 30;

				// store cell position
				r = RectangleToClient(r);
				_ptCell = new Point(r.Right, r.Top);

				// start showing/editing the note
				_editing = editMode;
				if (editMode)
				{
					// show the form
					Show();

					// move the cursor over the editor
					Point pt = new Point(_txtNote.Width/2, _txtNote.Height/2);
					Cursor.Position = _txtNote.PointToScreen(pt);

					// place selection at the end
					_txtNote.SelectionStart = 32000;
				}
				else
				{
					// disable editor so it won't get the focus
					_txtNote.Enabled = false;

					// show the form
					Show();

					// re-enable editor so it doesn't look disabled
					_txtNote.Enabled = true;
				}
			}
		}

		#endregion

		//------------------------------------------------------------------------------------------------------
		#region ** overrides/event handlers

		override protected void OnPaint(PaintEventArgs e)
		{
			// draw connector from cell to editor
			Point p = _txtNote.Location;
			e.Graphics.DrawLine(Pens.Black, _ptCell, p);
			base.OnPaint(e);
		}

		// hide form when the editor loses focus
        protected override void OnDeactivate(EventArgs e)
        {
            base.OnDeactivate(e);
            Visible = false;
        }

		// handle resizing the editor
		private Point _ptDown;
		private Size  _szDown;
		private void _lblGrip_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			_ptDown = Control.MousePosition;
			_szDown = Size;
		}
		private void _lblGrip_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if ((e.Button & MouseButtons.Left) != 0)
			{
				Point p = Control.MousePosition;
				Size = new Size(
					_szDown.Width  + (p.X - _ptDown.X),
					_szDown.Height + (p.Y - _ptDown.Y));
			}
		}

		#endregion
	}
}
