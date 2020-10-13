using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestSchedule
{
	/// <summary>
	/// The <see cref="SeriesDialog"/> represents the dialog form for selecting 
	/// the object for editing (occurrence or all pattern).
	/// </summary>
	public partial class SeriesDialog : Form
	{
		/// <summary>
		/// Initializes a new instance of <see cref="SeriesDialog"/> form.
		/// </summary>
		/// <param name="appSubject">The <see cref="String"/> value holding appointment subject.</param>
		public SeriesDialog(string appSubject)
		{
			Font = SystemInformation.MenuFont;
			InitializeComponent();
			_lblMessage.Text = string.Format(_lblMessage.Text,
				(appSubject.Length > 20) ? appSubject.Substring(0, 17) + "..." : appSubject);
			_pBox.Image = SystemIcons.Exclamation.ToBitmap();
		}

		/// <summary>
		/// Gets the <see cref="Boolean"/> value determining whether end-user selected 
		/// the series or individual occurrence.
		/// </summary>
		public bool Series
		{
			get
			{
				return _rbSeries.Checked;
			}
		}
	}
}
