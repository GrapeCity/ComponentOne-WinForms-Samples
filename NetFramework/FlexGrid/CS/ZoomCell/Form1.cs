using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

namespace ZoomCell
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private C1.Win.FlexGrid.C1FlexGrid _flex;
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
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._flex.BackColor = System.Drawing.SystemColors.Window;
			this._flex.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:22;}\t";
			this._flex.Location = new System.Drawing.Point(8, 8);
			this._flex.Name = "_flex";
			this._flex.Size = new System.Drawing.Size(320, 160);
			this._flex.Styles = new C1.Win.FlexGrid.CellStyleCollection(@"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	");
			this._flex.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.button1.Location = new System.Drawing.Point(8, 176);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(96, 24);
			this.button1.TabIndex = 1;
			this.button1.Text = "First, Last";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.button2.Location = new System.Drawing.Point(120, 176);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(96, 24);
			this.button2.TabIndex = 1;
			this.button2.Text = "ID, Last, Title";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this.button3.Location = new System.Drawing.Point(232, 176);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(96, 24);
			this.button3.TabIndex = 1;
			this.button3.Text = "Default";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(336, 205);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.button1,
																		  this._flex,
																		  this.button2,
																		  this.button3});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "C1FlexGrid: Click a cell to zoom in";
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

		ArrayList _al;
		private void Form1_Load(object sender, System.EventArgs e)
		{
			// create data source
			_al = new ArrayList();
			_al.Add(new Employee(1, "Jimmy", "Page", "Guitarist"));
			_al.Add(new Employee(2, "Robert", "Plant", "Singer"));
			_al.Add(new Employee(3, "John", "Bonham", "Drummer"));
			_al.Add(new Employee(4, "John", "Jones", "Bassist"));

			// bind to grid
			_flex.DataSource = _al;

			// set grid style
			_flex.Styles.Alternate.BackColor = Color.LightGreen;

			// create ZoomCell, attach it to grid
			ZoomCell z = new ZoomCell(_flex);
		}

		// bind to FirstName, LastName
		private void button1_Click(object sender, System.EventArgs e)
		{
			_flex.DataSource = _al;
			_flex.Cols.Count = 1; // clear existing columns
			AddColumn("FirstName", typeof(string));
			AddColumn("LastName",  typeof(string));
		}

		// bind to ID, LastName, Title
		private void button2_Click(object sender, System.EventArgs e)
		{
			_flex.DataSource = _al;
			_flex.Cols.Count = 1; // clear existing columns
			AddColumn("ID", typeof(int));
			AddColumn("LastName", typeof(string));
			AddColumn("Title", typeof(string));
		}

		// default binding
		private void button3_Click(object sender, System.EventArgs e)
		{
			_flex.DataSource = null;
			_flex.DataSource = _al;
		}

		// helper
		private void AddColumn(string name, Type type)
		{
			C1.Win.FlexGrid.Column col = _flex.Cols.Add();
			col.Name = name;
			col.Caption = name;
			col.DataType = type;
		}
	}

	/// <summary>
	/// Employee
	/// simple class used to show data binding
	/// </summary>
	public class Employee
	{
		int _id;
		string _first;
		string _last;
		string _title;
		public Employee(int id, string first, string last, string title)
		{
			_id = id;
			_first = first;
			_last = last;
			_title = title;
		}
		public int ID
		{
			get { return _id; }
		}
		public string FirstName
		{
			get { return _first; }
			set { _first = value; }
		}
		public string LastName
		{
			get { return _last; }
			set { _last = value; }
		}
		public string Title
		{
			get { return _title; }
			set { _title = value; }
		}
	}

	/// <summary>
	/// ZoomCell
	/// show zoomed view of the selected cell:
	/// - activates on click
	/// - follows cursor
	/// - deactivates on lostfocus or Escape key
	/// </summary>
	public class ZoomCell : PictureBox
	{
		// ** fields
		private C1FlexGrid  _owner;
		private float		_zoom;

		// ** ctor
		public ZoomCell(C1FlexGrid owner)
		{
			// initialize base class (PictureBox)
			BorderStyle = BorderStyle.FixedSingle;
			SizeMode    = PictureBoxSizeMode.StretchImage;
			Visible     = false;
			Parent      = owner;

			// initialize zoom factor: 25%
			_zoom = 1.25f;

			// hook up event handlers
			_owner = owner;
			owner.MouseDown += new MouseEventHandler(Flex_MouseDown);
			owner.EnterCell += new EventHandler(Flex_EnterCell);
			owner.LostFocus += new EventHandler(Flex_LostFocus);
			owner.KeyPress  += new KeyPressEventHandler(Flex_KeyPress);
		}

		// ** event handlers
		private void Flex_MouseDown(object sender, MouseEventArgs e)
		{
			// show zoom when user clicks the cell
			ShowZoomedCell(_owner.MouseRow, _owner.MouseCol);
		}
		private void Flex_EnterCell(object sender, EventArgs e)
		{
			// follow cursor
			if (Visible)
				ShowZoomedCell(_owner.Row, _owner.Col);
		}
		private void Flex_KeyPress(object sender, KeyPressEventArgs e)
		{
			// hide zoom when user hits escape
			if (Visible && e.KeyChar == 27)
				Visible = false;
		}
		private void Flex_LostFocus(object sender, EventArgs e)
		{
			Visible = false;
		}

		// ** private
		private void ShowZoomedCell(int row, int col)
		{
			// ignore empty area
			if (row < _owner.Rows.Fixed || col < _owner.Cols.Fixed)
			{
				Visible = false;
				return;
			}

			// get cell rectangle
			Rectangle rc = _owner.GetCellRect(row, col);

			// create bitmap
			CellStyle style = _owner.GetCellStyleDisplay(row, col);
			Image = new Bitmap(rc.Width, rc.Height);
			using (Graphics g = Graphics.FromImage(Image))
			{
				Point pt = rc.Location;
				rc.Location = Point.Empty;
				style.Render(g, rc, _owner.GetDataDisplay(row, col));
				rc.Location = pt;
			}

			// apply zoom factor
			rc.Inflate((int)(rc.Width * (_zoom-1)), (int)(rc.Height * (_zoom-1)));
			Bounds = rc;
			Visible = true;
			Invalidate();
		}
	}
}
