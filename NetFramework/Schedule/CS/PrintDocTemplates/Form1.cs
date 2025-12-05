using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PrintDocTemplates
{
	using C1.Win.Schedule;
	using C1.Schedule;
	using C1.C1Preview;
    using C1.Win.RibbonPreview;

    public partial class Form1 : Form
	{
		// C1PrintDocument controls
		C1PrintDocument _printDoc = new C1PrintDocument();
		// preview window
		C1RibbonPreviewDialog _preview = new C1RibbonPreviewDialog();

		public Form1()
		{
			InitializeComponent();
			_preview.Text = "Print Preview";
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		// On loading the form, load previously saved data.
		private void Form1_Load(object sender, EventArgs e)
		{
			// If file with data exists,
			if (File.Exists("C1Schedule.xml"))
			{
	            // load data from the file.
				this.c1Schedule1.DataStorage.Import("C1Schedule.xml", FileFormatEnum.XML);
			}
			// subscribe to the DocumentStarting event
			_printDoc.DocumentStarting += new EventHandler(_printDoc_DocumentStarting);
		}

		// On closing the form, save all data to the file.
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
	        // Save all data to the file.
			this.c1Schedule1.DataStorage.Export("C1Schedule.xml", FileFormatEnum.XML);
		}

		private void _DayView_Click(object sender, EventArgs e)
		{
			// Switch to the DayView.
			this.c1Schedule1.ViewType = ScheduleViewEnum.DayView;
		}

		private void _workWeek_Click(object sender, EventArgs e)
		{
			// Switch to the WorkWeekView.
			this.c1Schedule1.ViewType = ScheduleViewEnum.WorkWeekView;
		}

		private void _week_Click(object sender, EventArgs e)
		{
			// Switch to the WeekView.
			this.c1Schedule1.ViewType = ScheduleViewEnum.WeekView;
		}

		private void _month_Click(object sender, EventArgs e)
		{
			// Switch to the MonthView.
			this.c1Schedule1.ViewType = ScheduleViewEnum.MonthView;
		}

		private void _today_Click(object sender, EventArgs e)
		{
			// Go to today date.
			this.c1Schedule1.GoToDate(DateTime.Today);

		}

		// Export data to the file.
		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.c1Schedule1.Export(null, "Export Data to File");
		}

		// Import data from the file.
		private void importToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.c1Schedule1.Import("Import Data");
		}

		// adds assembly references and initializes document tags
		private void _printDoc_DocumentStarting(object sender, EventArgs e)
		{
			// add references needed for document scripts execution 
            _printDoc.ScriptingOptions.ExternalAssemblies.Add(System.Reflection.Assembly.GetAssembly(typeof(C1Schedule)).Location);
            _printDoc.ScriptingOptions.ExternalAssemblies.Add(System.Reflection.Assembly.GetAssembly(typeof(Appointment)).Location);
            _printDoc.ScriptingOptions.ExternalAssemblies.Add(System.Reflection.Assembly.GetAssembly(typeof(C1.Win.Schedule.C1ScheduleStorage)).Location);
            _printDoc.ScriptingOptions.ExternalAssemblies.Add("netstandard.dll");

            // initialize document tags
            DateTime start = c1Schedule1.SelectedDates[0].Date;
			DateTime end = c1Schedule1.SelectedDates[c1Schedule1.SelectedDates.Length - 1].Date;

			Tag tag = _printDoc.Tags["StartDate"];
			if (tag != null && tag.Type == typeof(DateTime))
			{
				tag.Value = start;
			}
			tag = _printDoc.Tags["EndDate"];
			if (tag != null && tag.Type == typeof(DateTime))
			{
				tag.Value = end;
			}

			// show tag input form to user
			_printDoc.EditTags();

			tag = _printDoc.Tags["StartDate"];
			if (tag != null && tag.Type == typeof(DateTime))
			{
				start = (DateTime)tag.Value;
			}
			tag = _printDoc.Tags["EndDate"];
			if (tag != null && tag.Type == typeof(DateTime))
			{
				end = (DateTime)tag.Value;
			}

			tag = _printDoc.Tags["Appointment"];
			if (tag != null && tag.Type == typeof(Appointment) && c1Schedule1.SelectedAppointments != null && c1Schedule1.SelectedAppointments.Count > 0)
			{
				tag.Value = c1Schedule1.SelectedAppointments[0];
			}

			tag = _printDoc.Tags["CalendarInfo"];
			if (tag != null && tag.Type == typeof(CalendarInfo))
			{
				tag.Value = c1Schedule1.CalendarInfo;
			}

			tag = _printDoc.Tags["Appointments"];
			if (tag != null)
			{
				if (tag.Type == typeof(AppointmentCollection))
				{
					tag.Value = c1Schedule1.DataStorage.AppointmentStorage.Appointments;
				}
				else if (tag.Type == typeof(IList<Appointment>))
				{
					bool isAppointmentContext = _printDoc.DocumentFileName.Contains("Memo") || _printDoc.DocumentFileName.Contains("Details");
					if (isAppointmentContext && c1Schedule1.SelectedAppointments != null && c1Schedule1.SelectedAppointments.Count > 0)
					{
						tag.Value = c1Schedule1.SelectedAppointments;
					}
					else
					{
                        // get appointments for the currently selected SchedulerGroupItem if any, 
                        // or all appointments otherwise.
                        AppointmentList list = c1Schedule1.DataStorage.AppointmentStorage.Appointments.GetOccurrences(
                            c1Schedule1.SelectedGroupItem == null ? null : c1Schedule1.SelectedGroupItem.Owner,
                            c1Schedule1.GroupBy, start, end.AddDays(1), true);
                        list.Sort();
                        tag.Value = list;
					}
				}
			}
		}

		private void dailyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Utils.MakeDay(_printDoc);
			_printDoc.Save("day.c1d");
			// clear and re-load to be sure that all works when document is loaded from file
			_printDoc.Clear();
			_printDoc.Load("day.c1d");
			Preview();
		}

		private void weeklyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Utils.MakeWeek(_printDoc);
			_printDoc.Save("week.c1d");
			// clear and re-load to be sure that all works when document is loaded from file
			_printDoc.Clear();
			_printDoc.Load("week.c1d");
			Preview();
		}

		private void monthlyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Utils.MakeMonth(_printDoc);
			_printDoc.Save("month.c1d");
			// clear and re-load to be sure that all works when document is loaded from file
			_printDoc.Clear();
			_printDoc.Load("month.c1d");
			Preview();
		}

		private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Utils.MakeDetails(_printDoc);
			_printDoc.Save("details.c1d");
			// clear and re-load to be sure that all works when document is loaded from file
			_printDoc.Clear();
			_printDoc.Load("details.c1d");
			Preview();
		}

		private void memoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Utils.MakeMemo(_printDoc);
			_printDoc.Save("memo.c1d");
			// clear and re-load to be sure that all works when document is loaded from file
			_printDoc.Clear();
			_printDoc.Load("memo.c1d");
			Preview();
		}

		/// <summary>
		/// Shows C1PrintDocument content in a C1PrintPreviewDialog.
		/// </summary>
		private void Preview()
		{
			_preview.Document = null;
			_preview.Document = _printDoc;
			_preview.ShowDialog();
		}
	}
}