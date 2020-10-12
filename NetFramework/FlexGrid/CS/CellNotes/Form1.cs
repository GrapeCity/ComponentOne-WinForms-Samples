using System;
using System.Text;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.Win.C1FlexGrid;

namespace CellNotes
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._flex = new C1.Win.C1FlexGrid.C1FlexGrid();
            this._btnShowNotes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:23;}\t";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 45);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 17;
            this._flex.Size = new System.Drawing.Size(528, 224);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 2;
            // 
            // _btnShowNotes
            // 
            this._btnShowNotes.Location = new System.Drawing.Point(10, 9);
            this._btnShowNotes.Name = "_btnShowNotes";
            this._btnShowNotes.Size = new System.Drawing.Size(124, 28);
            this._btnShowNotes.TabIndex = 3;
            this._btnShowNotes.Text = "Show all notes";
            this._btnShowNotes.Click += new System.EventHandler(this._btnShowNotes_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(140, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Move the mouse over cells to see notes. Use the context menu to edit notes.";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(6, 15);
            this.ClientSize = new System.Drawing.Size(528, 269);
            this.Controls.Add(this._flex);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._btnShowNotes);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 45, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: CellNotes";
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

		C1.Win.C1FlexGrid.C1FlexGrid _flex;
		System.Windows.Forms.Label label1;
		System.Windows.Forms.Button _btnShowNotes;

		void Form1_Load(object sender, System.EventArgs e)
		{
			// load some data
			string conn = GetConnectionString();
			string sql  = "select * from employees";
			OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
			DataTable dt = new DataTable();
			da.Fill(dt);

			// bind to grid
			_flex.DataSource = dt;

			// hide Notes column (we'll use CellNotes instead)
			_flex.Cols["Notes"].Visible = false;

			// create cell notes for every employee
			int noteColumn = _flex.Cols["FirstName"].Index;
			for (int r = _flex.Rows.Fixed; r < _flex.Rows.Count; r++)
			{
				// create note
				CellNote note = new CellNote(_flex[r, "Notes"] as string);

				// attach note to "FirstName" column
				CellRange rg = _flex.GetCellRange(r, noteColumn);
				rg.UserData = note;
			}

			// create manager to display/edit the cell notes
			CellNoteManager mgr = new CellNoteManager(_flex);
		}

		// show all notes on the grid
		// (this could be used to persist the notes in a file for example)
		void _btnShowNotes_Click(object sender, System.EventArgs e)
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("** Cell Notes:");

			int count = 0;
			for (int r = 0; r < _flex.Rows.Count; r++)
			{
				for (int c = 0; c < _flex.Cols.Count; c++)
				{
					CellRange rg = _flex.GetCellRange(r, c);
					CellNote note = rg.UserData as CellNote;
					if (note != null)
					{
						count++;
						sb.Append("\r\n-----------------------------\r\n");
						sb.AppendFormat("Notes for cell {0}, {1}: (form size is {2} by {3})\r\n",
							r, c, note.Width, note.Height);
						sb.Append(note.NoteText);
					}
				}
			}

			if (count == 0)
			{
				sb.Append("\r\nThis form contains no notes.");
			}

			MessageBox.Show(sb.ToString());
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
	}
}
