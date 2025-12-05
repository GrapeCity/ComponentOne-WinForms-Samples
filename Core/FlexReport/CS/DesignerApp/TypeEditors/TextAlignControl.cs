//----------------------------------------------------------------------------
// TextAlignControl.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;

namespace FlexReportDesignerApp
{
	/// <summary>
	/// Summary description for TextAlignControl.
	/// </summary>
	internal partial class TextAlignControl : System.Windows.Forms.UserControl
	{

		public TextAlignControl()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitForm call

		}

		// ** object model
		private int _value;

		[DefaultValue(0)]
		public int Value
		{
			get { return _value; }
			set { _value = value; }
		}

		// ** select current setting on initial display
		override protected void OnGotFocus(System.EventArgs e)
		{
			if (this.Visible)
			{
				foreach (Button ctl in Controls)
				{
					if (int.Parse(ctl.Tag.ToString()) == _value)
					{
						ctl.FlatStyle = FlatStyle.Standard;
						ctl.Focus();
					}
					else
					{
						ctl.FlatStyle = FlatStyle.Popup;
					}
				}
			}
		}

		// ** hide control when a value is checked or when a special key is pressed
		private void button_Clicked(object sender, System.EventArgs e)
		{
			Button btn = sender as Button;
			_value = int.Parse(btn.Tag.ToString());
			Visible = false;		
		}
		private void button_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar == 27)
				Visible = false;
		}
	}
}
