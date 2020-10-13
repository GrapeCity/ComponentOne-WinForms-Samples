using System;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace CustomEditors
{
	/// <summary>
	/// NumericTextBox
	/// 
	/// Inherits from TextBox and provides filtering/formatting for numeric input.
	/// These are the main properties:
	/// 
	///		string	Format		Controls how the value is entered and formatted.
	///		
	///		bool	Calculated	Set to true to allow users to enter expressions
	///							(the value is calculated when the control loses
	///							focus or when the user presses the = key).
	///							
	///		decimal Minimum		Determine the range of acceptable values.
	///		decimal Maximum
	///		
	/// </summary>
	public class NumericTextBox : TextBox
	{
		//------------------------------------------------------------------------------
		#region ** fields
		private string		_rawFormat;			        // format specified by the user
		private bool		_calculated;		        // calculated text box
		private string		_format;			        // format used internally
		private char		_thoSymbol;			        // localized thousand separator
		private char		_decSymbol;			        // localized decimal symbol
		private int			_decDigits;			        // number of decimal digits
		private string		_unformattedText;           // raw text (before formatting)
		private bool		_decKeyPressed;		        // decimal key pressed (keypad)
		private bool		_updating;                  // updating text
		private decimal		_minValue, _maxValue;

		private static DataTable _dt = new DataTable(); // data table to evaluate expressions
		#endregion

		//------------------------------------------------------------------------------
		#region ** ctors
		public NumericTextBox(string format, bool calculated)
		{
			NumberFormatInfo nf = CultureInfo.CurrentCulture.NumberFormat;
			_thoSymbol	= nf.NumberGroupSeparator[0];
			_decSymbol	= nf.NumberDecimalSeparator[0];
			_calculated = calculated;
			TextAlign	= HorizontalAlignment.Right;
			Format		= format;
			_maxValue   = (decimal)+1e20;
			_minValue   = (decimal)-1e20;
		}
		public NumericTextBox() : this("#,###.00", false) {}
		#endregion

		//------------------------------------------------------------------------------
		#region ** object model
		[DefaultValue("#,###.00"), RefreshProperties(RefreshProperties.Repaint)]
		public string Format
		{
			get { return _rawFormat; }
			set
			{
				_rawFormat = value;
				UpdateFormat();
			}
		}
		[DefaultValue(false), RefreshProperties(RefreshProperties.Repaint)]
		public bool Calculated
		{
			get { return _calculated; }
			set
			{
				_calculated = value;
				TextAlign = (_calculated)
					? HorizontalAlignment.Left
					: HorizontalAlignment.Right;
			}
		}
		[DefaultValue(HorizontalAlignment.Right)]
		new public HorizontalAlignment TextAlign 
		{
			get { return base.TextAlign; }
			set { base.TextAlign = value; }
		}
		[DefaultValue(1e20)]
		public decimal Minimum
		{
			get { return _minValue; }
			set { _minValue = value; UpdateText(); }
		}
		[DefaultValue(-1e20)]
		public decimal Maximum
		{
			get { return _maxValue; }
			set { _maxValue = value; UpdateText(); }
		}
		#endregion

		//------------------------------------------------------------------------------
		#region ** editor interface
		public void C1EditorInitialize(object value, IDictionary attributes)
		{
			// initialize style
			BorderStyle	= BorderStyle.None;
			AutoSize	= false;
			Font		= (Font) attributes["Font"];
			BackColor	= (Color)attributes["BackColor"];
			ForeColor	= (Color)attributes["ForeColor"];

			// initialize content
			Text = string.Empty;
			if (value != null) Text = value.ToString();
		}
		public object C1EditorGetValue()
		{
			Calculate();
			return Text;
		}
		#endregion

		//------------------------------------------------------------------------------
		#region ** private stuff
		private void UpdateFormat()
		{
			// handle thousand separators
			if (_rawFormat.IndexOf(',') > -1)
			{
				_format = "#,###";
			}
			else
			{
				_format = "#";
			}

			// handle decimal points
			_decDigits = 0;
			int posDec = _rawFormat.IndexOf('.');
			if (posDec > -1)
			{
				_decDigits = _rawFormat.Length - posDec - 1;
				_format += "." + new string('0', _decDigits);
			}

			// update text using new format
			Text = _unformattedText;
			UpdateText();
		}
		private bool Calculate()
		{
			if (!_calculated)
				return UpdateText();

			// build expression
			bool ok = false;
			string expr = Text;
			expr = expr.Replace(_thoSymbol.ToString(), string.Empty);
			expr = expr.Replace(_decSymbol, '.');

			// evaluate
			try
			{
                object result = _dt.Compute(expr, string.Empty);
				Text = string.Format(CultureInfo.CurrentCulture, "{0}", result);
				ok = UpdateText();
				Select(32000,0);
			} 
			catch (Exception x)
			{
				Text = x.Message;;
				Select(0, 32000);
			}
			return ok;
		}
		private bool UpdateText()
		{
			// save selection
			int len = Text.Length;
			int pos = SelectionStart + SelectionLength;
				
			// parse value
			bool ok = false;
			string text = Text;
			decimal value = 0;
			try
			{
				if (text.Length > 0)
				{
					if (text[0] == _thoSymbol)
						text = text.Substring(1);
					value = decimal.Parse(text, NumberStyles.Any);
				}
				if (value < _minValue) value = _minValue;
				if (value > _maxValue) value = _maxValue;
				ok = true;
			}
			catch {}

			// format
			text = value.ToString(_format);
			if (Text.StartsWith("-"))
			{
				if (!text.StartsWith("-"))
					text = "-" + text;
			}

			// assign value to control
			_updating = true;
			Text = text;
			_updating = false;

			// restore selection
			int decPos = text.IndexOf(_decSymbol);
            if (decPos < 0 && pos == len) pos = text.Length;
            if (pos < decPos) pos += text.Length - len;
			if (pos < 0) pos = 0;
            Select(pos, 0);

			// return ok if value was updated correctly
			return ok;
		}

		#endregion

		//------------------------------------------------------------------------------
		#region ** overrides
		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!e.Handled && !_calculated)
			{
				_decKeyPressed = false;
				if (e.KeyCode == Keys.Delete)
				{
					int pos = SelectionStart;
					if (pos < Text.Length && Text[pos] == _decSymbol)
					{
						e.Handled = true;
						Select(pos+1, 0);
					}
				}
				if (e.KeyCode == Keys.Decimal)
				{			
					_decKeyPressed = true;
				}
			}
		}
		private static string _calculatorChars = "0123456789+-/*()., ";
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
			if (!e.Handled)
			{
				// calculate value when user presses '='
				if (_calculated)
				{
					if (e.KeyChar == '=')
					{
						Calculate();
						e.Handled = true;
					}
					if (_calculatorChars.IndexOf(e.KeyChar) < 0)
					{
						e.Handled = true;
					}
					return;
				}

				int pos = SelectionStart;
				int len = Text.Length;

				// handle backspace over decimal
				if (e.KeyChar == 8)
				{
					if (pos > 0 && Text[pos-1] == _decSymbol)
					{
						Select(pos-1, 0);
						e.Handled = true;
					}
					return;
				}

				// move to decimal point
				if (e.KeyChar == _decSymbol || _decKeyPressed)
				{
					int posDec = Text.IndexOf(_decSymbol);
					if (posDec > -1)
					{
						if (pos <= posDec) posDec++;
						Select(posDec, 0);
					}
					e.Handled = true;
					return;
				}

				// minus char only allowed at string start, and only when Minimum < 0
				if (e.KeyChar == '-' && pos == 0 && _minValue < 0)
					return;

				// ignore bad characters
				if (!char.IsDigit(e.KeyChar) || (pos == len && _decDigits > 0))
					e.Handled = true;
			}
		}
		protected override void OnTextChanged(EventArgs e)
		{
			if (!_updating)
			{
				_unformattedText = Text;
				base.OnTextChanged(e);
				if (!_calculated)
					UpdateText();
			}
		}
		protected override void OnValidating(CancelEventArgs e)
		{
			bool ok = Calculate();
			if (!ok) e.Cancel = true;
			base.OnValidating(e);
		}
		#endregion
	}
}
