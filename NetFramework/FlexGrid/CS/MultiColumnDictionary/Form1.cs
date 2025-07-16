using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using C1.Win.FlexGrid;


namespace MultiColumnDictionarySample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.ImageList _imgList;
		private System.Windows.Forms.CheckBox _chkCombo;
		private C1.Win.FlexGrid.C1FlexGrid _flexList;
		private System.Windows.Forms.RadioButton _radioShippers;
		private System.Windows.Forms.RadioButton _radioProducts;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.ComponentModel.IContainer components;

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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this._flex = new C1.Win.FlexGrid.C1FlexGrid();
			this._imgList = new System.Windows.Forms.ImageList(this.components);
			this._chkCombo = new System.Windows.Forms.CheckBox();
			this._flexList = new C1.Win.FlexGrid.C1FlexGrid();
			this._radioShippers = new System.Windows.Forms.RadioButton();
			this._radioProducts = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this._flexList)).BeginInit();
			this.SuspendLayout();
			// 
			// _flex
			// 
			this._flex.Anchor = (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._flex.AutoClipboard = true;
			this._flex.ColumnInfo = "10,0,0,0,0,85,Columns:";
			this._flex.Location = new System.Drawing.Point(8, 8);
			this._flex.Name = "_flex";
			this._flex.Rows.DefaultSize = 17;
			this._flex.Size = new System.Drawing.Size(704, 240);
			this._flex.StyleInfo = @"Normal{}	Alternate{}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Focus{}	Editor{}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:Beige;}	NewRow{}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	";
			this._flex.TabIndex = 0;
			this._flex.SetupEditor += new C1.Win.FlexGrid.RowColEventHandler(this._flex_SetupEditor);
			this._flex.ValidateEdit += new C1.Win.FlexGrid.ValidateEditEventHandler(this._flex_ValidateEdit);
			// 
			// _imgList
			// 
			this._imgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this._imgList.ImageSize = new System.Drawing.Size(16, 16);
			this._imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgList.ImageStream")));
			this._imgList.TransparentColor = System.Drawing.Color.Red;
			// 
			// _chkCombo
			// 
			this._chkCombo.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this._chkCombo.Location = new System.Drawing.Point(8, 400);
			this._chkCombo.Name = "_chkCombo";
			this._chkCombo.Size = new System.Drawing.Size(104, 16);
			this._chkCombo.TabIndex = 3;
			this._chkCombo.Text = "Use Combos";
			// 
			// _flexList
			// 
			this._flexList.AllowAddNew = true;
			this._flexList.AllowDelete = true;
			this._flexList.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this._flexList.ColumnInfo = "10,1,0,0,0,85,Columns:0{Width:27;}\t";
			this._flexList.Location = new System.Drawing.Point(192, 280);
			this._flexList.Name = "_flexList";
			this._flexList.Rows.DefaultSize = 17;
			this._flexList.ShowCursor = true;
			this._flexList.Size = new System.Drawing.Size(520, 136);
			this._flexList.TabIndex = 4;
			// 
			// _radioShippers
			// 
			this._radioShippers.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this._radioShippers.Location = new System.Drawing.Point(8, 280);
			this._radioShippers.Name = "_radioShippers";
			this._radioShippers.Size = new System.Drawing.Size(128, 16);
			this._radioShippers.TabIndex = 5;
			this._radioShippers.Text = "Edit Shippers >>>";
			this._radioShippers.CheckedChanged += new System.EventHandler(this._radioShippers_CheckedChanged);
			// 
			// _radioProducts
			// 
			this._radioProducts.Anchor = (System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left);
			this._radioProducts.Location = new System.Drawing.Point(8, 304);
			this._radioProducts.Name = "_radioProducts";
			this._radioProducts.Size = new System.Drawing.Size(128, 16);
			this._radioProducts.TabIndex = 5;
			this._radioProducts.Text = "Edit Products >>>";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 328);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(168, 64);
			this.label1.TabIndex = 6;
			this.label1.Text = "Any changes to this data will automatically be reflected in the drop-down lists. " +
				"(Requires version 220 or later).";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right);
			this.groupBox1.Location = new System.Drawing.Point(8, 264);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(704, 2);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(720, 421);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox1,
																		  this._radioShippers,
																		  this._flexList,
																		  this._chkCombo,
																		  this._flex,
																		  this._radioProducts,
																		  this.label1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: MultiColumnDictionary Demo";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this._flexList)).EndInit();
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

		// tables used as list sources
		DataTable _dtShippers, _dtProducts, _dtEmployees;

		void Form1_Load(object sender, System.EventArgs e)
		{
			// load some data to use in multi-column combos
            string conn = GetConnectionString();
			_dtShippers = new DataTable();
			_dtProducts = new DataTable();
			_dtEmployees = new DataTable();
			new OleDbDataAdapter("select * from shippers", conn).Fill(_dtShippers);
			new OleDbDataAdapter("select * from products", conn).Fill(_dtProducts);
			new OleDbDataAdapter("select * from Employees", conn).Fill(_dtEmployees);

			// show data so user can change it and see the effects
			_radioShippers.Checked = true;

			// create an image map to use with multi-column combos
			Hashtable img = new Hashtable();
			for (int i = 0; i < _imgList.Images.Count; i++)
			{
				img[i] = _imgList.Images[i];
			}

			_flex.Cols.Count = 100;

			// regular combo list with duplicate items, no tabs
			int colIndex = _flex.Cols.Fixed;
			Column col = _flex.Cols[colIndex++];
			col.Caption = "Reg Dup";
			col.ComboList = "foo bar|bar foo|foo bar|foo bar";

			// regular combo list with with duplicate items and tabs
			col = _flex.Cols[colIndex++];
			col.Caption = "Reg Dup Tab";
			col.ComboList = "foo\tbar|bar\tfoo|foo\tbar|foo\tbar";

			// enumerated type
			col = _flex.Cols[colIndex++];
			col.Caption = "Enum";
			col.DataType  = typeof(DockStyle);

			// regular data map
			col = _flex.Cols[colIndex++];
			col.Caption = "Map Img";
			col.ImageMap = img;
			Hashtable ht = new Hashtable();
			ht[0] = "Zero";
			ht[1] = "One";
			ht[2] = "Two";
			ht[3] = "Three";
			col.DataMap = ht;

			// combo with images only
			col = _flex.Cols[colIndex++];
			col.Caption = "Img Only";
			col.ImageAndText = false;
			col.ImageMap = img;
			col.DataMap = ht;

			// MultiColumnDictionary 1: string-based, autoKeys (stores int, duplicates allowed)
			col = _flex.Cols[colIndex++];
			col.Caption = "MCD SA Img";
			col.ImageMap = img;
			col.DataMap = new MultiColumnDictionary("foo\tbar|bar\tfoo|foo\tbar|bar\tfoo", 0, true);

			// MultiColumnDictionary 2: string-based, explicit keys (stores string, duplicates not allowed)
			col = _flex.Cols[colIndex++];
			col.Caption = "MCD SK";
			col.DataMap = new MultiColumnDictionary("foo\tbar|bar\tfoo|foo\tbar|bar\tfoo", 0, false);

			// MultiColumnDictionary 3: bound to Shippers
			col = _flex.Cols[colIndex++];
			col.Caption = "MCD Shippers";
			col.ImageMap = img;
			col.DataMap = new C1.Win.FlexGrid.MultiColumnDictionary(_dtShippers, "ShipperID", new string[] { "CompanyName","Phone" }, 0);

			// MultiColumnDictionary 4: bound to Products
			col = _flex.Cols[colIndex++];
			col.Caption = "MCD Prods";
			col.ImageMap = img;
			col.DataMap = new C1.Win.FlexGrid.MultiColumnDictionary(_dtProducts, "ProductID", null, 1);

			// MultiColumnDictionary 5: bound to Employees
			col = _flex.Cols[colIndex++];
			col.Caption = "MCD Employees";
			col.ImageMap = img;
			col.DataMap = new C1.Win.FlexGrid.MultiColumnDictionary(_dtEmployees, "EmployeeID", new string[] { "FirstName", "LastName", "Country" }, 0);

			// MultiColumnDictionary 6: string-based, multicol
			col = _flex.Cols[colIndex++];
			col.Caption = "MCD Str MC";
			string text = "Row1, Col1\tRow1, Col2|Row2, Col1\tRow2, Col2";
			col.DataMap = new MultiColumnDictionary(text, 0, true);
		}

		// Use combo if checked.
		// By default, maps imply simple dropdowns.
		// Simple dropdowns also have autosearch, but the combo autosearch looks better.
		void _flex_SetupEditor(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			ComboBox cb = _flex.Editor as ComboBox;
			if (cb != null)
			{
				cb.DropDownStyle = _chkCombo.Checked
					? ComboBoxStyle.DropDown
					: ComboBoxStyle.DropDownList;
			}
		}

		// Allow users to type an ID in addition to the item itself.
		// To do this, retrieve the editor value, check if it's an integer, and look it up
		// in the dictionary. If an entry is found, replace the editor contents with it.
		void _flex_ValidateEdit(object sender, C1.Win.FlexGrid.ValidateEditEventArgs e)
		{
			// check that we have a combo and a multi-column dictionary
			ComboBox cb = _flex.Editor as ComboBox;
			IC1MultiColumnDictionary mcd = _flex.Cols[e.Col].DataMap as IC1MultiColumnDictionary;
			if (cb != null && mcd != null)
			{
				// check that the current value is an integer
				double d = 0;
				if (double.TryParse(cb.Text, NumberStyles.Integer, CultureInfo.CurrentCulture, out d))
				{
					// look up entry using current content as key
					string text = mcd.GetDisplayValue((int)d);
					if (text.Length > 0)
					{
						// found, fix editor
						cb.Text = text;
					}
					else
					{
						// not found, fail validation
						e.Cancel = true;
					}
				}
			}
		}

		// Show tables that are used as combo sources so the user can update them and see the 
		// how the changes are automatically reflected in the dropdowns.
		void _radioShippers_CheckedChanged(object sender, System.EventArgs e)
		{
			_flexList.DataSource = (_radioShippers.Checked)
				? _dtShippers
				: _dtProducts;
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
