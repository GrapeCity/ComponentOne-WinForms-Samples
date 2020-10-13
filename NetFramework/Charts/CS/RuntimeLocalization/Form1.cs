using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using C1.Win.C1Chart;
using C1.Win.C1Chart3D;

namespace RuntimeLocalization
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		#region Main Events
		private void c1Chart1_Click(object sender, EventArgs e)
		{
			// Show the ChartProperties dialog
			c1Chart1.ShowProperties();
		}

		private void c1Chart3D1_Click(object sender, EventArgs e)
		{
			// Show the ChartProperties dialog
			c1Chart3D1.ShowProperties();
		}

		private void btnAddPrefix_Click(object sender, EventArgs e)
		{
			// Call runOperations to execute "localizeChart" for each checked chart
			runOperations(localizeChart);
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			// Call runOperations to execute "resetLocalizations" for each checked chart
			runOperations(resetLocalizations);
		}

		private void btnShowLocalizations_Click(object sender, EventArgs e)
		{
			// Call runOperations to execute "showLocalizations" for each checked chart
			runOperations(showLocalizations);
		}

		private void btnShowPropGrids_Click(object sender, EventArgs e)
		{
			// Call runOperations to execute "showPropertyGrids" for each checked chart
			runOperations(showPropertyGrids);
		}
		#endregion

		#region Operations routines

		/// <summary>
		/// Defines routine operation function construct.
		/// </summary>
		/// <param name="objChart"></param>
		private delegate void runOperation(object objChart);

		/// <summary>
		/// Framework to run the runOperation delegates for each
		/// checked chart in groupBox1.
		/// </summary>
		/// <param name="runop"></param>
		private void runOperations(runOperation runop)
		{
			foreach (CheckBox cb in groupBox1.Controls)
			{
				if (cb.Checked)
				{
					switch (cb.Text)
					{
						case "Chart 2D":
							runop(c1Chart1);
							break;

						case "Chart 3D":
							runop(c1Chart3D1);
							break;
					}
				}
			}
		}

		/// <summary>
		/// Localizes the specified chart object by adding the specified
		/// prefix in groupBox2 to the beginning of each localizable string.
		/// 
		/// Of course, no one would really want to do this, but it
		/// demonstrates how to modify and localize the strings used in the
		/// dialogs and property descriptions.
		/// </summary>
		/// <param name="objChart"></param>
		private void localizeChart(object objChart)
		{
			// a MemoryStream is used for demo purposes.
			MemoryStream ChartLocalizationStream = new MemoryStream();

			if (objChart is C1Chart)
			{
				C1Chart chart = objChart as C1Chart;
				if (chart.SaveLocalizations(ChartLocalizationStream))
				{
					addPrefixToLocalizations(ChartLocalizationStream);
					chart.LoadLocalizations(ChartLocalizationStream);
				}
			}
			else if (objChart is C1Chart3D)
			{
				C1Chart3D chart = objChart as C1Chart3D;
				if (chart.SaveLocalizations(ChartLocalizationStream))
				{
					addPrefixToLocalizations(ChartLocalizationStream);
					chart.LoadLocalizations(ChartLocalizationStream);
				}
			}

			ChartLocalizationStream.Close();
			ChartLocalizationStream.Dispose();
		}

		/// <summary>
		/// Resets the chart localizations to the default state for the
		/// specified chart.  This removes previous localizations and
		/// frees all memory associated with the localizations.
		/// </summary>
		/// <param name="objChart"></param>
		private void resetLocalizations(object objChart)
		{
			// passing null to any of the LoadLocalization overload
			// clears any existing localizations previously loaded.
			if (objChart is C1Chart)
			{
				C1Chart chart = objChart as C1Chart;
				chart.LoadLocalizations((Stream)null);
			}
			else if (objChart is C1Chart3D)
			{
				C1Chart3D chart = objChart as C1Chart3D;
				chart.LoadLocalizations((Stream)null);
			}
		}

		/// <summary>
		/// Creates a form and show the localization XML for the specified chart.
		/// 
		/// The localization XML is saved to a byte array for easy conversion to
		/// text.  Note that the first bytes of the array may be byte encodings.
		/// 
		/// The form is sizeable.
		/// </summary>
		/// <param name="objChart"></param>
		private void showLocalizations(object objChart)
		{
			string title = " string localizations.";
			byte[] ChartLocalizationBytes = null;

			if (objChart is C1Chart)
			{
				C1Chart chart = objChart as C1Chart;
				chart.SaveLocalizations(out ChartLocalizationBytes);
				title = chart.Name + title;
			}
			else if (objChart is C1Chart3D)
			{
				C1Chart3D chart = objChart as C1Chart3D;
				chart.SaveLocalizations(out ChartLocalizationBytes);
				title = chart.Name + title;
			}
			else 
			{
				MessageBox.Show("Object specified is not supported.");
				return;
			}

			string ChartLocalizationString = Encoding.UTF8.GetString(ChartLocalizationBytes);

			Form frm = new Form();
			TextBox tb = new TextBox();
			frm.Text = title;
			frm.Size = this.Size;
			frm.WindowState = FormWindowState.Normal;
			frm.FormBorderStyle = FormBorderStyle.Sizable;

			frm.Controls.Add(tb);
			tb.Dock = DockStyle.Fill;
			tb.Multiline = true;
			tb.ReadOnly = true;
			tb.ScrollBars = ScrollBars.Both;
			tb.Text = ChartLocalizationString;
			tb.SelectionStart = 0;
			tb.SelectionLength = 0;
			tb.Visible = true;

			frm.Show();
		}

		/// <summary>
		/// Creates a form and adds a PropertyGrid connected to the specified chart.
		/// The localizations of the Property Descriptions can be seen.
		///
		/// Special Note: Once a control property description has been
		/// retrieved, it does not change for the application.	This is a
		/// behavior of the .NET PropertyDescriptor.
		///
		/// The form is sizeable.
		/// </summary>
		/// <param name="objChart"></param>
		private void showPropertyGrids(object objChart)
		{
			string title = " Property Grid.";

			Form frm = new Form();
			PropertyGrid pg = new PropertyGrid();

			if (objChart is C1Chart)
			{
				C1Chart chart = objChart as C1Chart;
				pg.SelectedObject = chart;
				title = chart.Name + title;
			}
			else if (objChart is C1Chart3D)
			{
				C1Chart3D chart = objChart as C1Chart3D;
				pg.SelectedObject = chart;
				title = chart.Name + title;
			}
			else 
			{
				MessageBox.Show("Object specified is not supported.");
				return;
			}

			frm.Text = title;
			frm.Size = new Size(300, 400);
			frm.WindowState = FormWindowState.Normal;
			frm.FormBorderStyle = FormBorderStyle.Sizable;

			frm.Controls.Add(pg);
			pg.Dock = DockStyle.Fill;
			pg.HelpVisible = true;

			frm.Show();
		}

		#endregion	// Operations routines

		#region Miscellaneous Routines

		/// <summary>
		/// This method adds the prefix that is checked in groupBox2
		/// to the existing translations in the specified
		/// ChartLocalizationsStream.
		/// </summary>
		/// <param name="ChartLocalizationStream"></param>
		private void addPrefixToLocalizations(Stream ChartLocalizationStream)
		{
			string prefix = null;

			// remove the quotes from the text field values
			foreach (RadioButton rb in groupBox2.Controls)
			{
				if (rb.Checked)
				{
					prefix = rb.Text.Replace("\"", "");
					break;
				}
			}
			if (prefix == null) return;		// nothing to do.

			XmlDocument xdoc = new XmlDocument();

			// When saving the localizations to a stream, the chart
			// only writes forward and does not take control of the
			// stream from the caller.	Therefore, it will be necessary
			// to position the stream to the beginning in order to load
			// and Xml document directly.
			ChartLocalizationStream.Seek(0, SeekOrigin.Begin);
			xdoc.Load(ChartLocalizationStream);

			// The Chart basic element of the chart localization XML is
			// the C1ChartTranslation element.	It has two child nodes,
			// KeyStr and Trans.  KeyStr specifies the string that is
			// used by the default localization, and Trans specifies the
			// string to be used in place of the KeyStr.  If Trans is empty,
			// the KeyStr is used.
			//
			// To change the displayed value of the string, add or modify the
			// Trans inner text.

			// Get all the C1ChartTranslation element nodes, and insert the
			// prefix string before the existing Trans inner text.	If Trans
			// is empty, then it is set to prefix + KeyStr inner text.
			XmlNodeList xnl = xdoc.GetElementsByTagName("C1ChartTranslation");
			foreach (XmlNode xn in xnl)
			{
				if (xn.HasChildNodes)
				{
					XmlNode transNode = xn.LastChild;

					string trans = transNode.InnerText;
					if (trans == string.Empty)
					{
						XmlNode keystrNode = xn.FirstChild;
						trans = keystrNode.InnerText;
					}
					trans = prefix + ":" + trans;
					transNode.InnerText = trans;
				}
			}

			// empty the existing memory stream.
			ChartLocalizationStream.SetLength(0);

			// save the new translations to the existing stream
			xdoc.Save(ChartLocalizationStream);

			// position to the beginning of the stream in preparation
			// of the chart.LoadLocalizations().
			ChartLocalizationStream.Seek(0, SeekOrigin.Begin);
		}

		#endregion
	}
}