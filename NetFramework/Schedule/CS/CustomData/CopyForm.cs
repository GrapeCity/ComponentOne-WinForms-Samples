using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomData
{
	/// <summary>
	/// This form allows to select DateTime from the MonthCalendar control.
	/// </summary>
	public partial class CopyForm : Form
	{
		DateTime _date = DateTime.Today;

		public CopyForm()
		{
			InitializeComponent();
		}

		public DateTime Date
		{
			get
			{
				return _date;
			}
		}

		private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
		{
			_date = e.Start;
			this.DialogResult = DialogResult.OK;
			Close();
		}
	}
}