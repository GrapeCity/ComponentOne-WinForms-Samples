using System;
using System.Xml;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.C1Report;

namespace ReportDesignerDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public partial class Form1 : System.Windows.Forms.Form
	{
		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		// ** fields

		private string	_fileName;
		private bool	_dirty;
		private const string _appName = "C1ReportDesigner Demo";

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		// ** event handlers

		// update UI on startup to show form title and disable clipboard and
		// undo/redo buttons
		private void Form1_Load(object sender, System.EventArgs e)
		{
			UpdateUI();
		}

		// handle clicks on toolbar buttons
		private void _tb_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
		{
			// design/preview mode
			if (e.Button == _btnDesign)		SetDesignMode(true);
			if (e.Button == _btnPreview)	SetDesignMode(false);

			// file commands
			if (e.Button == _btnNew)		NewFile();
			if (e.Button == _btnOpen)		OpenFile();
			if (e.Button == _btnSave)		SaveFile();

			// allow user to undo clipboard operations			
			if (e.Button == _btnCut || e.Button == _btnPaste)
				_c1rd.UndoStack.SaveState();
			
			// clipboard
			if (e.Button == _btnCut)		_c1rd.ClipboardHandler.Cut();
			if (e.Button == _btnCopy)		_c1rd.ClipboardHandler.Copy();
			if (e.Button == _btnPaste)		_c1rd.ClipboardHandler.Paste();

			// undo/redo
			if (e.Button == _btnUndo)		_c1rd.UndoStack.Undo();
			if (e.Button == _btnRedo)		_c1rd.UndoStack.Redo();

			// add/remove reports
			if (e.Button == _btnAddReport)	NewReport();
			if (e.Button == _btnDelReport)  DeleteReport();

			// add fields
			// (just set create info and wait for CreateField event from designer)
			if (e.Button == _btnAddField)	_c1rd.CreateFieldInfo = e.Button;
			if (e.Button == _btnAddLabel)	_c1rd.CreateFieldInfo = e.Button;
		}

		// a new report was selected: switch to design mode and show it
		private void _list_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			// switch to design mode
			SetDesignMode(true);

			// attach selected report to designer and preview controls
			_c1rd.Report = null;
			_c1ppv.Document = null;
			if (_list.SelectedItem != null)
				_c1rd.Report = ((ReportHolder)_list.SelectedItem).Report;
		}

		// when a value changes in the property window, refresh the designer
		// to show the changes
		private void _ppg_PropertyValueChanged(object s, System.Windows.Forms.PropertyValueChangedEventArgs e)
		{
			_c1rd.Refresh();
			_dirty = true;
			UpdateUI();
		}

		// when properties of the selected objects change in the designer,
		// update the property window to show the changes
		private void _c1rd_ValuesChanged(object sender, System.EventArgs e)
		{
			_ppg.Refresh();
			_dirty = true;
			UpdateUI();
		}

		// the selection changed, need to update property grid and show the
		// properties of the selected object 
		private void _c1rd_SelectionChanged(object sender, System.EventArgs e)
		{
			object[] sel = _c1rd.SelectedFields;
			if (sel.Length > 0)
			{
				_lblPropGrid.Text = "Field Properties";
				_ppg.SelectedObjects = sel;
			}
			else if (_c1rd.SelectedSection != null) 
			{
				_lblPropGrid.Text = "Section Properties";
				_ppg.SelectedObject = _c1rd.SelectedSection;
			}
			else if (_c1rd.Report != null)
			{
				_lblPropGrid.Text = "Report Properties";
				_ppg.SelectedObject = _c1rd.Report;
			}
			else // nothing selected
			{
				_lblPropGrid.Text = "Properties";
				_ppg.SelectedObject = null;
			}

			// done
			UpdateUI();		
		}

		// ** update UI to reflect current state

		private void UpdateUI()
		{
			// update caption
			Text = (_fileName != null && _fileName.Length > 0)
				? string.Format("{0} - [{1}] {2}", _appName, _fileName, _dirty? "*": "")
				: _appName;

			// push/release design/preview mode buttons
			bool design = _c1rd.Visible && _c1rd.Report != null;
			_btnDesign.Pushed  = design;
			_btnPreview.Pushed = !design;

			// enable/disable buttons
			_btnCut.Enabled   = design && _c1rd.ClipboardHandler.CanCut;
			_btnCopy.Enabled  = design && _c1rd.ClipboardHandler.CanCut;
			_btnPaste.Enabled = design && _c1rd.ClipboardHandler.CanPaste;
			_btnUndo.Enabled  = design && _c1rd.UndoStack.CanUndo;
			_btnRedo.Enabled  = design && _c1rd.UndoStack.CanRedo;

			bool reportSelected = design && _list.SelectedItem != null;
			_btnAddReport.Enabled = _c1rd.Visible;
			_btnDelReport.Enabled = reportSelected;
			_btnAddField.Enabled  = reportSelected; 
			_btnAddLabel.Enabled  = reportSelected;
		}

		// ** switch between design/preview mode

		private void SetDesignMode(bool design)
		{
			// show/hide preview/design panes
			_c1rd.Visible  = design;
			_c1ppv.Visible = !design;

			// no properties in preview mode
			if (!design)
			{
				_lblPropGrid.Text = "Properties";
				_ppg.SelectedObject = null;
			}

			// attach copy of the report to preview control
			// (so changes caused by script aren't saved)
			if (!design)
			{
				_c1ppv.Document = null;
				_c1r.CopyFrom(_c1rd.Report);
				Cursor = Cursors.WaitCursor;
				_c1r.Render();
				if (_c1r.PageImages.Count > 0)
					_c1ppv.Document = _c1r;
				Cursor = Cursors.Default;
			}

			// done, update UI
			UpdateUI();
		}

		// ** file commands

		private void NewFile()
		{
			_fileName = "";
			_dirty = false;
			_list.Items.Clear();
			_c1ppv.Document = null;
			_c1rd.Report = null;
			UpdateUI();
		}
		public void OpenFile()
		{
			// get name of file to open
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.FileName = "*.xml";
			dlg.Title = "Open Report Definition File";
			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			// check selected file
			string[] reports = null;
			try
			{
				reports = _c1r.GetReportInfo(dlg.FileName);
			}
			catch {}
			if (reports == null || reports.Length == 0)
			{
				MessageBox.Show("Invalid (or empty) report defintion file");
				return;
			}

			// clear list
			NewFile();

			// load new file
			Cursor = Cursors.WaitCursor;
			_fileName = dlg.FileName;
			foreach (string reportName in reports)
			{
                try
                {
                    C1Report rpt = new C1Report();
                    rpt.Load(_fileName, reportName);
                    _list.Items.Add(new ReportHolder(rpt));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error loading report {0}: {1}", reportName, ex.Message));
                }
			}
			Cursor = Cursors.Default;

			// select first report
			_list.SelectedIndex = 0;
		}
		public void SaveFile()
		{
			// get name of file to save
			SaveFileDialog dlg = new SaveFileDialog();
			dlg.FileName = _fileName;
			dlg.Title = "Save Report Definition File";
			if (dlg.ShowDialog() != DialogResult.OK)
				return;

			// save file
			XmlTextWriter w = new XmlTextWriter(dlg.FileName, System.Text.Encoding.Default);
			w.Formatting = Formatting.Indented;
			w.Indentation = 2;
			w.WriteStartDocument();

			// write all reports to it
			Cursor = Cursors.WaitCursor;
			w.WriteStartElement("Reports");
			foreach (ReportHolder rh in _list.Items)
				rh.Report.Save(w); //rh.Report.ReportName);
			w.WriteEndElement();
			Cursor = Cursors.Default;

			// close the file
			w.Close();

			// and be done
			_fileName = dlg.FileName;
			_dirty = false;
			UpdateUI();
		}

		// create a new report and add it to the list
		private void NewReport()
		{
			// select a data source (just mdb files in this sample)
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.FileName = "*.mdb";
			dlg.Title = "Select report data source";
			if (dlg.ShowDialog() != DialogResult.OK) return;

			// select first table from data source
			string connString = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};", dlg.FileName);
			string tableName  = GetFirstTable(connString);
			if (tableName == null || tableName.Length == 0)
			{
				MessageBox.Show("Failed to retrieve data from the selected source.");
				return;
			}

			// create new report
			C1Report rpt = new C1Report();
			rpt.ReportName = tableName;

			// set data source
			rpt.DataSource.ConnectionString = connString;
			rpt.DataSource.RecordSource = tableName;

			// add a title field
			Section s = rpt.Sections[SectionTypeEnum.Header];
			s.Visible = true;
			s.Height = 600;
			Field f = s.Fields.Add("TitleField", tableName, 0, 0, 4000, 600);
			f.Font.Bold = true;
			f.Font.Size = 24;
			f.ForeColor = Color.Navy;

			// add up to 5 calculated fields
			string[] fieldNames = rpt.DataSource.GetDBFieldList(true);
			int cnt = Math.Min(5, fieldNames.Length);

			// add a page header
			s = rpt.Sections[SectionTypeEnum.PageHeader];
			s.Visible = true;
			s.Height = 400;
			Rectangle rc = new Rectangle(0, 0, 1000, (int)s.Height);
			for (int i = 0; i < cnt; i++)
			{
				f = s.Fields.Add("TitleField", fieldNames[i], rc);
				f.Font.Bold = true;
				rc.Offset(rc.Width, 0);
			}

			// add detail section
			s = rpt.Sections[SectionTypeEnum.Detail];
			s.Visible = true;
			s.Height = 300;
			rc = new Rectangle(0, 0, 1000, (int)s.Height);
			for (int i = 0; i < cnt; i++)
			{
				f = s.Fields.Add("TitleField", fieldNames[i], rc);
				f.Calculated = true;
				rc.Offset(rc.Width, 0);
			}

			// add new report to the list and select it
			_list.Items.Add(new ReportHolder(rpt));
			_list.SelectedIndex = _list.Items.Count-1;

			// done
			_dirty = true;
			UpdateUI();
		}

		// get the name of the first table in the given connection
		private string GetFirstTable(string connString)
		{
			string tableName = null;
			OleDbConnection conn = new OleDbConnection(connString);
			try
			{
				// get schema
				conn.Open();
				DataTable dt = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
				foreach (DataRow dr in dt.Rows)
				{
					// check the table type
					string type = dr["TABLE_TYPE"].ToString().ToUpper();
					if (type != "TABLE" && type != "VIEW" && type != "LINK")
						continue;

					// get the table name
					tableName = dr["TABLE_NAME"].ToString();
					break;
				}

				// done
				conn.Close();
			}
			catch {}

			// return the first table we found
			return tableName;
		}
			
		// remove current report from the list
		private void DeleteReport()
		{
			// a report must be selected
			int index = _list.SelectedIndex;
			if (index < 0) return;

			// remove report from the designer and from the list
			_c1rd.Report = null;
			_list.Items.RemoveAt(index);

			// select another report if we can
			if (index > _list.Items.Count-1)
				index = _list.Items.Count-1;
			if (index > -1)
				_list.SelectedIndex = index;

			// done
			_dirty = true;
			UpdateUI();
		}

		int _ctr = 0;
		private void _c1rd_CreateField(object sender, C1.Win.C1ReportDesigner.CreateFieldEventArgs e)
		{
			// save undo info
			_c1rd.UndoStack.SaveState();

			// add label field
			string fieldName = string.Format("NewField{0}", ++_ctr);
			string fieldText = fieldName;
			Field f = e.Section.Fields.Add(fieldName, fieldText, e.FieldBounds);

			// if this is a calculated field, 
			// change the Text and Calculated properties
			if (e.CreateFieldInfo == _btnAddField)
			{
				string[] fieldNames = _c1rd.Report.DataSource.GetDBFieldList(true);
				if (fieldNames.Length > 0)
				{
					f.Text = fieldNames[0];
					f.Calculated = true;
				}
			}
		}
	}

	/// <summary>
	/// ReportHolder
	/// Helper class used to store reports in listboxes. The main thing
	/// it does is override the ToString() method to render the report name.
	/// </summary>
	public class ReportHolder
	{
		public readonly C1Report Report;
		public ReportHolder(C1Report report)
		{
			Report = report;
		}
		override public string ToString()
		{
			string s = Report.ReportName;
			return (s != null && s.Length > 0)? s: "Unnamed Report";
		}
	}
}
