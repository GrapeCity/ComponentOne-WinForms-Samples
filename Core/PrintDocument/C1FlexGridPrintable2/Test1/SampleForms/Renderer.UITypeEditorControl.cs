//----------------------------------------------------------------------------
// UITypeEditorControl.cs
//----------------------------------------------------------------------------
// 
// Control wrapper for UITypeEditors so they can be used as grid editors.
// 
// UITypeEditors are used extensively in .NET. They are directly supported by
// the PropertyGrid control and allow esiting specific types using custom popup
// or dropdown controls. Many UITypeEditors are available for editing types
// such as Color, Font, Images, etc.
// 
// However, UITypeEditors are not based no the Control class and therefore
// cannot be used directly as grid editors. This class does inherit from 
// Control and wraps a UITypeEditor so it can be used as a grid editor.
// 
// UITypeEditorControl can be used directly or it can be used as a base class
// for specialized UITypeEditors.
//
// The constructor specifies the UITypeEditor to use and whether the user 
// should be allowed to edit the string representation of the value (if 
// allowTyping is set to false, then the user can only edit usign the drop 
// down).
//
// ** IN ORDER TO BUILD, YOU NEED TO ADD A REFERENCE TO "System.Drawing.Design.dll"
//
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Reflection;

namespace Renderer
{
	//-------------------------------------------------------------------------------
	#region ** UITypeEditorControl (base class for all of the controls below)

	/// <summary>
	/// UITypeEditorControl
	/// </summary>
	public class UITypeEditorControl : 
		ComboBox,
		IServiceProvider,
		IWindowsFormsEditorService
	{
		//---------------------------------------------------------------------------
		#region ** fields
		private UITypeEditor _editor;	    // UITypeEditor responsible for editing the values
		private Form		_form;		    // form used to show the drop down
		private Rectangle	_bounds;	    // cell bounds (used to position control and form)
		private object		_value;		    // current editor value 
		private bool		_dropped;	    // whether the drop down was displayed
		private bool		_allowTyping;	// whether to allow user to edit the string representation of the value
		#endregion

        //---------------------------------------------------------------------------
        #region ** ctor

		public UITypeEditorControl(UITypeEditor editor, bool allowTyping)
		{
			// save ctor parameters
			_editor = editor;
			_allowTyping = allowTyping;

			// initialize combo
			DropDownStyle = ComboBoxStyle.DropDown;
			DrawMode = DrawMode.OwnerDrawFixed;

			// initialize drop down editor
			_form = new Form();
			_form.StartPosition   = FormStartPosition.Manual;
			_form.FormBorderStyle = FormBorderStyle.None;
			_form.ShowInTaskbar   = false;
			_form.TopLevel        = true;
			_form.Deactivate     += _form_Deactivate;
		}
		#endregion

        //---------------------------------------------------------------------------
        #region ** IC1EmbeddedEditor

		public void C1EditorInitialize(object value, IDictionary attributes)
		{
			// initialize editor value
			_value = value;
			if (value != null)
			{
				TypeConverter tc = TypeDescriptor.GetConverter(value.GetType());
				try
				{
					Text = (string)tc.ConvertToString(value);
				}
				catch
				{
					Text = string.Empty;
				}
			}

			// initialize editor style
			Font      = (Font) attributes["Font"];
			BackColor = (Color)attributes["BackColor"];
			ForeColor = (Color)attributes["ForeColor"];

			// we haven't dropped the editor yet
			_dropped = false;
		}
		public object C1EditorGetValue()
		{
			// return value from drop down or from edit area
			return (_dropped)? _value: Text;
		}
		public UITypeEditorEditStyle C1EditorGetStyle()
		{
			return _editor.GetEditStyle();
		}
		public void C1EditorUpdateBounds(Rectangle rc)
		{
			// store bounds, will apply when showing the form
			_bounds = new Rectangle(Bounds.X, Bounds.Y, Bounds.Width, Bounds.Height);

			// if the user can type, position the combo
			if (_allowTyping)
			{
				rc.Inflate(2, 2);
				ItemHeight = Math.Max(3, rc.Height - 6);
				Bounds = rc;
			}
			else // can't type, so hide the control
			{
				Bounds = Rectangle.Empty;
			}
		}

		#endregion

        //---------------------------------------------------------------------------
        #region ** overrides

		// if the user can't type, show drop down right away
		override protected void OnEnter(EventArgs e)
		{
			if (!_allowTyping)
				DoDropDown();
		}

		// if the user can type, show drop down when requested
		override protected void OnDropDown(EventArgs e)
		{
			if (_allowTyping)
				DoDropDown();
		}

		// suppress OnLeave event until we're done editing
		override protected void OnLeave(EventArgs e)
		{
			// if we dropped down, wait until we're done editing
			if (_dropped)
				return;

			// we didn't drop down, allow default processing
			base.OnLeave(e);
		}

		// this is done only to avoid annoying beeps from the ComboBox
		override public bool PreProcessMessage(ref Message msg)
		{
			switch (msg.Msg)
			{
				case 0x100: // WM_KEYDOWN:

					// digest key that was pressed
					KeyEventArgs e = new KeyEventArgs((Keys)(int)msg.WParam);

					// if it was a tab or enter, handle internally but don't pass
					// to stupid base class to avoid annoying beeps.
				switch (e.KeyCode)
				{
					case Keys.Tab:
					case Keys.Enter:
					case Keys.Escape:
						OnKeyDown(e);
						return true;
				}
					break;
			}

			// allow regular processing
			return false;
		}
		#endregion

        //---------------------------------------------------------------------------
        #region ** private members

		private void DoDropDown()
		{
			// fire event as usual
			base.OnDropDown(EventArgs.Empty);

			// if this is a popup, hide editing area
			if (_editor.GetEditStyle() == UITypeEditorEditStyle.Modal)
				Bounds = Rectangle.Empty;

			// show editor and get the new value
			_dropped = true;
			_value = _editor.EditValue((IServiceProvider)this, _value);

			// force the drop down to close
			DrawMode = DrawMode.Normal;
			DrawMode = DrawMode.OwnerDrawFixed;
			DroppedDown = false;
			Capture = false;

			// fire OnLeave so grid knows we're done
			base.OnLeave(EventArgs.Empty);
		}

		#endregion

        //---------------------------------------------------------------------------
        #region ** event handlers

		// close drop down when form deactivated
		private void _form_Deactivate(object sender, EventArgs e)
		{
			((IWindowsFormsEditorService)this).CloseDropDown();
		}

		#endregion

        //---------------------------------------------------------------------------
        #region ** IServiceProvider interface

		object IServiceProvider.GetService(Type serviceType)
		{
			if (serviceType == typeof(IWindowsFormsEditorService))
				return (IWindowsFormsEditorService)this;
			return null;
		}
		
		#endregion

        //---------------------------------------------------------------------------
        #region ** IWindowsFormsEditorService interface

		void IWindowsFormsEditorService.DropDownControl(Control control)
		{
			// size form
			_form.ClientSize = control.Size;

			// calculate form location to avoid being off the screen
			Point pt = new Point(_bounds.Right - control.Width, _bounds.Bottom);
			Rectangle rc = Screen.GetWorkingArea(this);
			if (_bounds.Bottom + control.Height > rc.Bottom)    // check bottom
            {
				pt.Y = _bounds.Top - _form.Height;
            }
			if (pt.Y < 0) pt.Y = 0;					            // check top
			if (_bounds.X + control.Width > rc.Right)		    // check right
            {
				pt.X = rc.Right - _form.Width;
            }
			if (pt.X < 0) pt.X = 0;					            // check left

			// position form
			_form.Location = pt;

			// add control to form and show it
			_form.Controls.Add(control);
			_form.Show();

			// readjust form size (seems redundant, but isn't...)
			_form.ClientSize = control.Size;

			// wait until user makes a selection
			while (control.Visible)
			{
				Application.DoEvents();
				MsgWaitForMultipleObjects(1, IntPtr.Zero, 0, 5, 255);
			}

			// done
			_form.Hide();
			_form.Controls.Clear();
		}
		void IWindowsFormsEditorService.CloseDropDown()
		{
			_form.Hide();
		}
		DialogResult IWindowsFormsEditorService.ShowDialog(Form dialog)
		{
			// support modal editors
			return dialog.ShowDialog();
		}

		#endregion

        //---------------------------------------------------------------------------
        #region ** dll imports

		[System.Runtime.InteropServices.DllImport("User32")]
		private static extern int MsgWaitForMultipleObjects(
			int nCount, IntPtr pHandles, short bWaitAll, int dwMilliseconds, int dwWakeMask);

		#endregion
	}
	#endregion

    //-------------------------------------------------------------------------------
    #region ** ColorPicker

	/// <summary>
	/// ColorPicker
	/// Uses the Color UITypeEditor to show a form where users can pick colors
	/// </summary>
	public class ColorPicker : UITypeEditorControl
	{
		public ColorPicker() : base(new ColorEditor(), true) {}
	}
	#endregion

    //-------------------------------------------------------------------------------
    #region ** FileNamePicker
	
	/// <summary>
	/// FileNamePicker
	/// Uses the FileName UITypeEditor to show a form where users can pick filenames
	/// </summary>
	public class FileNamePicker : UITypeEditorControl
	{
		public FileNamePicker() : base(new FileNameEditor(), true) {}
	}
	#endregion

    //-------------------------------------------------------------------------------
    #region ** ImagePicker
	
	/// <summary>
	/// ImagePicker
	/// Uses the Image UITypeEditor to show a form where users can pick images
	/// </summary>
	public class ImagePicker : UITypeEditorControl
	{
		public ImagePicker() : base(new ImageEditor(), false) {}
	}
	#endregion

    //-------------------------------------------------------------------------------
    #region ** FontPicker
	
	/// <summary>
	/// FontPicker
	/// Uses the Font UITypeEditor to show a form where users can pick fonts
	/// </summary>
	public class FontPicker : UITypeEditorControl
	{
		public FontPicker() : base(new FontEditor(), true) {}
	}
	#endregion

    //-------------------------------------------------------------------------------
    #region ** DockPicker
	
	/// <summary>
	/// DockPicker
	/// Uses the Dock UITypeEditor to show a form where users can pick Dock settings
	/// </summary>
	public class DockPicker : UITypeEditorControl
	{
		public DockPicker() : base(new DockEditor(), true) {}
	}
	#endregion

    //-------------------------------------------------------------------------------
    #region ** AnchorPicker
	
	/// <summary>
	/// AnchorPicker
	/// Uses the Anchor UITypeEditor to show a form where users can Anchor settings
	/// </summary>
	public class AnchorPicker : UITypeEditorControl
	{
		public AnchorPicker() : base(new AnchorEditor(), true) {}
	}
	#endregion
}
