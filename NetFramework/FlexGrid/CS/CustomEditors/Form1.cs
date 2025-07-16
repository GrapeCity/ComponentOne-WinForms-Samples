using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using C1.Win.FlexGrid;

namespace CustomEditors
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private C1.Win.FlexGrid.C1FlexGrid _flex;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button _btnBorders;
		private System.Windows.Forms.DomainUpDown domainUpDown1;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.CheckBox _chkSetHandled;
		private System.Windows.Forms.RichTextBox _rtfHelp;
		private System.Windows.Forms.CheckBox _chkShowButtons;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this._flex = new C1.Win.FlexGrid.C1FlexGrid();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._btnBorders = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this._chkSetHandled = new System.Windows.Forms.CheckBox();
            this._rtfHelp = new System.Windows.Forms.RichTextBox();
            this._chkShowButtons = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this._flex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // _flex
            // 
            this._flex.AllowFreezing = C1.Win.FlexGrid.AllowFreezingEnum.Both;
            this._flex.ColumnInfo = "10,1,0,0,0,105,Columns:";
            this._flex.Dock = System.Windows.Forms.DockStyle.Fill;
            this._flex.Location = new System.Drawing.Point(0, 85);
            this._flex.Name = "_flex";
            this._flex.Rows.DefaultSize = 21;
            this._flex.Size = new System.Drawing.Size(656, 320);
            this._flex.StyleInfo = resources.GetString("_flex.StyleInfo");
            this._flex.TabIndex = 11;
            this._flex.VisualStyle = C1.Win.FlexGrid.VisualStyle.Office2007Black;
            this._flex.ComboCloseUp += new C1.Win.FlexGrid.RowColEventHandler(this._flex_ComboCloseUp);
            this._flex.ChangeEdit += new System.EventHandler(this._flex_ChangeEdit);
            this._flex.KeyPressEdit += new C1.Win.FlexGrid.KeyPressEditEventHandler(this._flex_KeyPressEdit);
            this._flex.ComboDropDown += new C1.Win.FlexGrid.RowColEventHandler(this._flex_ComboDropDown);
            this._flex.StartEdit += new C1.Win.FlexGrid.RowColEventHandler(this._flex_StartEdit);
            this._flex.AfterEdit += new C1.Win.FlexGrid.RowColEventHandler(this._flex_AfterEdit);
            this._flex.KeyDown += new System.Windows.Forms.KeyEventHandler(this._flex_KeyDown);
            this._flex.CellButtonClick += new C1.Win.FlexGrid.RowColEventHandler(this._flex_CellButtonClick);
            this._flex.OwnerDrawCell += new C1.Win.FlexGrid.OwnerDrawCellEventHandler(this._flex_OwnerDrawCell);
            this._flex.SelChange += new System.EventHandler(this._flex_SelChange);
            this._flex.KeyDownEdit += new C1.Win.FlexGrid.KeyEditEventHandler(this._flex_KeyDownEdit);
            this._flex.SetupEditor += new C1.Win.FlexGrid.RowColEventHandler(this._flex_SetupEditor);
            this._flex.KeyUpEdit += new C1.Win.FlexGrid.KeyEditEventHandler(this._flex_KeyUpEdit);
            this._flex.BeforeEdit += new C1.Win.FlexGrid.RowColEventHandler(this._flex_BeforeEdit);
            this._flex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._flex_KeyPress);
            this._flex.KeyUp += new System.Windows.Forms.KeyEventHandler(this._flex_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.Color.MistyRose;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(11, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 17);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "textBox1";
            this.textBox1.Visible = false;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Red;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            this.imageList1.Images.SetKeyName(8, "");
            this.imageList1.Images.SetKeyName(9, "");
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.MistyRose;
            this.comboBox1.DropDownWidth = 160;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 17;
            this.comboBox1.Items.AddRange(new object[] {
            "Hello",
            "There",
            "How",
            "Are",
            "You",
            "This",
            "Is",
            "A",
            "Regular ComboBox"});
            this.comboBox1.Location = new System.Drawing.Point(11, 117);
            this.comboBox1.MaxDropDownItems = 55;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 25);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "comboBox1";
            this.comboBox1.Visible = false;
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            this.comboBox1.Validated += new System.EventHandler(this.comboBox1_Validated);
            // 
            // _btnBorders
            // 
            this._btnBorders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnBorders.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._btnBorders.Location = new System.Drawing.Point(496, 8);
            this._btnBorders.Name = "_btnBorders";
            this._btnBorders.Size = new System.Drawing.Size(145, 29);
            this._btnBorders.TabIndex = 4;
            this._btnBorders.Text = "Borders";
            this._btnBorders.Click += new System.EventHandler(this._btnBorders_Click);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.BackColor = System.Drawing.Color.MistyRose;
            this.domainUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.domainUpDown1.Items.Add("Please");
            this.domainUpDown1.Items.Add("Select");
            this.domainUpDown1.Items.Add("An");
            this.domainUpDown1.Items.Add("Item");
            this.domainUpDown1.Items.Add("From");
            this.domainUpDown1.Items.Add("This");
            this.domainUpDown1.Items.Add("DomainUpDown");
            this.domainUpDown1.Items.Add("Control.");
            this.domainUpDown1.Location = new System.Drawing.Point(11, 175);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(101, 20);
            this.domainUpDown1.TabIndex = 6;
            this.domainUpDown1.Text = "domainUpDown1";
            this.domainUpDown1.Visible = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.MistyRose;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.Location = new System.Drawing.Point(11, 204);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(101, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Visible = false;
            // 
            // _chkSetHandled
            // 
            this._chkSetHandled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chkSetHandled.Location = new System.Drawing.Point(496, 37);
            this._chkSetHandled.Name = "_chkSetHandled";
            this._chkSetHandled.Size = new System.Drawing.Size(145, 23);
            this._chkSetHandled.TabIndex = 8;
            this._chkSetHandled.Text = "e.Handled";
            // 
            // _rtfHelp
            // 
            this._rtfHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this._rtfHelp.Location = new System.Drawing.Point(7, 8);
            this._rtfHelp.Name = "_rtfHelp";
            this._rtfHelp.ReadOnly = true;
            this._rtfHelp.Size = new System.Drawing.Size(477, 71);
            this._rtfHelp.TabIndex = 9;
            this._rtfHelp.Text = "richTextBox1";
            // 
            // _chkShowButtons
            // 
            this._chkShowButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._chkShowButtons.Location = new System.Drawing.Point(496, 57);
            this._chkShowButtons.Name = "_chkShowButtons";
            this._chkShowButtons.Size = new System.Drawing.Size(145, 24);
            this._chkShowButtons.TabIndex = 10;
            this._chkShowButtons.Text = "ShowButtons";
            this._chkShowButtons.CheckedChanged += new System.EventHandler(this._chkShowButtons_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 17);
            this.ClientSize = new System.Drawing.Size(656, 405);
            this.Controls.Add(this._chkShowButtons);
            this.Controls.Add(this._rtfHelp);
            this.Controls.Add(this._chkSetHandled);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this._btnBorders);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._flex);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 85, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1FlexGrid: Custom Editors";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._flex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
            Application.EnableVisualStyles();
			Application.Run(new Form1());
		}

		void Form1_Load(object sender, System.EventArgs e)
		{
			// initialize variables
			Hashtable imgMap  = new Hashtable();
			Hashtable dataMap = new Hashtable();
			for (int i = 0; i < imageList1.Images.Count; i++)
			{
				imgMap.Add(i, imageList1.Images[i]);
				dataMap.Add(i, new string('*', i));
			}
			string comboList = "Banana|Apple|Orange|Grape";//|Tangerine|Melon|Pear|Pineapple|Mango";//Some long text\r\nthat will probably have to be\r\nwrapped in order to fit in this\r\nlist.";

			DataTable dt = new DataTable();
			string conn = GetConnectionString();
			string sql  = "select FirstName, LastName, Address, City, Region, Country from employees";
			System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter(sql, conn);
			da.Fill(dt);

			C1FlexGrid flexEditor = new C1FlexGrid();
            flexEditor.Visible = false;
			flexEditor.Font = Font;
			flexEditor.Parent = this;
			flexEditor.DataSource = dt;

			//---------------------------------------------------------------------------------
			// ** show built-in editors

			CellStyle cs = _flex.Styles.Add("Built-In Editors");
			cs.UserData = 
				@"\b ** Built-In Editors\b0\par " +
				@"These cells use the C1FlexGrid built-in editors, controlled by " +
				@"the setting of the DataType, DataMap, ComboList, and EditMask properties.";

			// add boolean row (with checkbox)
			_flex.Rows.Count = 1;
			Row r = _flex.Rows.Add();
			r.Caption  = "CheckBox";
			r.DataType = typeof(bool);
			r.Style.MergeWith(cs);

			// add boolean row (text mapped)
			r = _flex.Rows.Add();
			r.Caption  = "ToggleText";
			r.DataType = typeof(bool);
			r.Format   = "Yes;No";
			r.TextAlign= TextAlignEnum.CenterCenter;
			r.Style.MergeWith(cs);

			// add popup row
			r = _flex.Rows.Add();
			r.Caption  = "Popup";
			r.ComboList= "...";
			r.Style.MergeWith(cs);

			// add editable popup row
			r = _flex.Rows.Add();
			r.Caption  = "PopEdit";
			r.ComboList= "|...";
			r.Style.MergeWith(cs);

			// add row with masked textbox
			r = _flex.Rows.Add();
			r.Caption  = "TextBox";
			r.EditMask = "(999) 999-9999";
			r.Style.MergeWith(cs);

			// add row with simple list
			r = _flex.Rows.Add();
			r.Caption  = "List";
			r.ComboList= comboList;
			r.Style.WordWrap = true;
			r.Style.MergeWith(cs);

			// add row with combo list
			r = _flex.Rows.Add();
			r.Caption  = "Combo";
			r.ComboList= "|" + comboList;
			r.TextAlign= TextAlignEnum.CenterCenter;
			r.Style.MergeWith(cs);

			// add row with date time picker
			r = _flex.Rows.Add();
			r.Caption  = "DateTime";
			r.DataType = typeof(DateTime);
			r.Style.MergeWith(cs);

			// add row with time picker
			r = _flex.Rows.Add();
			r.Caption  = "Time";
			r.DataType = typeof(DateTime);
			r.Format   = "HH:mm";
			r.Style.MergeWith(cs);

			// add row with data/image maps
			r = _flex.Rows.Add();
			r.Caption  = "Data/ImageMaps";
			r.DataType = typeof(int);
			r.ImageMap = imgMap;
			r.DataMap  = dataMap;
			r.TextAlign= TextAlignEnum.LeftCenter;
			r.Style.MergeWith(cs);

			//---------------------------------------------------------------------------------
			// ** show regular controls used as editors

			cs = _flex.Styles.Add("Regular Controls");
			cs.BackColor = Color.Linen;
			cs.UserData = 
				@"\b ** Regular Controls\b0\par " +
				@"These cells use regular .NET controls as grid editors. The controls were added " +
				@"to the form at design time and assigned to grid rows. Their functionality is somewhat " +
				@"limited because they don't implement the IC1EmbeddedEditor interface.";

			// add row with custom editor (TextBox)
			r = _flex.Rows.Add();
			r.Caption  = "TextBox";
			r.Editor   = textBox1;
			r.Style.MergeWith(cs);

			// add row with custom editor (Combo)
			r = _flex.Rows.Add();
			r.Caption  = "ComboBox";
			r.DataType = typeof(string);
			r.Editor   = comboBox1;
			r.Style.MergeWith(cs);

			// add row with custom editor (DomainUpDown)
			r = _flex.Rows.Add();
			r.Caption  = "DomainUpDown";
			r.DataType = typeof(string);
			r.Editor   = domainUpDown1;
			r.Style.MergeWith(cs);

			// add row with custom editor (NumericUpDown)
			r = _flex.Rows.Add();
			r.Caption  = "NumericUpDown";
			r.DataType = typeof(double);
			r.Editor   = numericUpDown1;
			r.Style.MergeWith(cs);

			//---------------------------------------------------------------------------------
			// ** show custom editors based on regular controls

			cs = _flex.Styles.Add("Custom Controls");
			cs.BackColor = Color.LightGoldenrodYellow;
			cs.UserData = 
				@"\b ** Custom Controls\b0\par " +
				@"These cells use custom controls that inherit from the base .NET controls " +
				@"and implement methods in the IC1EmbeddedEditor interface. Because the grid " +
				@"binds using reflection, you don't have to implement the entire interface, only " +
				@"the methods that are relevant to your specific control.";

			// add row with custom editor (Numeric, integer, positive, no calculator)
			r = _flex.Rows.Add();
			r.Caption  = "Positive Integer";
			r.DataType = typeof(int);
			r.Format   = "#,###";
			r.Editor   = new NumericTextBox(r.Format, false);
			((NumericTextBox)r.Editor).Minimum = 0;
			r.Style.MergeWith(cs);

			// add row with custom editor (Numeric, three decimals, no calculator)
			r = _flex.Rows.Add();
			r.Caption  = "Double";
			r.DataType = typeof(double);
			r.Format   = "#,###.000";
			r.Editor   = new NumericTextBox(r.Format, false);
			r.Style.MergeWith(cs);

			// add row with custom editor (Numeric, two decimals, calculator)
			r = _flex.Rows.Add();
			r.Caption  = "Calculator";
			r.DataType = typeof(double);
			r.Format   = "#,###.000";
			r.Editor   = new NumericTextBox(r.Format, true);
			r.Style.MergeWith(cs);

			//---------------------------------------------------------------------------------
			// ** show custom editors based on UITypeEditors

			cs = _flex.Styles.Add("UITypeEditors");
			cs.BackColor = Color.Lavender;
			cs.UserData = 
				@"\b ** UITypeEditors\b0\par " +
				@"These cells use a custom control that wraps UITypeEditor objects. .NET exposes " +
				@"UITypeEditors for many classes such as Color, Font, etc. You can leverage these " +
				@"and other custom UITypeEditors for editing values on the C1FlexGrid.";

			// add row with custom editor (Color)
			r = _flex.Rows.Add();
			r.Caption  = "Color";
			r.DataType = typeof(Color);
			r.Editor   = new ColorPicker();
			r.Style.MergeWith(cs);

			// add row with custom editor (Font)
			r = _flex.Rows.Add();
			r.Caption  = "Font";
			r.DataType = typeof(Font);
			r.Editor   = new FontPicker();
			r.Style.MergeWith(cs);

			// add row with custom editor (FileName)
			r = _flex.Rows.Add();
			r.Caption  = "FileName";
			r.DataType = typeof(string);
			r.Editor   = new FileNamePicker();
			r.Style.MergeWith(cs);

			// add row with custom editor (Image)
			r = _flex.Rows.Add();
			r.Caption  = "Image";
			r.DataType = typeof(Image);
			r.Editor   = new ImagePicker();
			r.Style.MergeWith(cs);

			// add row with custom editor (Dock)
			r = _flex.Rows.Add();
			r.Caption  = "Dock";
			r.DataType = typeof(DockStyle);
			r.Editor   = new DockPicker();
			r.Style.MergeWith(cs);

			// add row with custom editor (Anchor)
			r = _flex.Rows.Add();
			r.Caption  = "Anchor";
			r.DataType = typeof(AnchorStyles);
			r.Editor   = new AnchorPicker();
			r.Style.MergeWith(cs);

			// add row with custom editor (Flags)
			FlagsEditor flagsEditor = new FlagsEditor(typeof(AnchorStyles));
			r = _flex.Rows.Add();
			r.Caption  = "Flags";
			r.DataType = typeof(AnchorStyles);
			r.Editor   = new UITypeEditorControl(flagsEditor, false);
			r.Style.MergeWith(cs);

			// add row with custom editor (Multi-Column drop-down based on another FlexGrid)
			MultiColumnEditor mcEditor = new MultiColumnEditor(flexEditor, "FirstName");
			flexEditor.BackColor = cs.BackColor;
			r = _flex.Rows.Add();
			r.Caption  = "MultiColumn";
			r.Editor   = new UITypeEditorControl(mcEditor, false);
			r.Style.MergeWith(cs);

			mcEditor = new MultiColumnEditor(flexEditor, "FirstName");
			flexEditor.BackColor = cs.BackColor;
			r = _flex.Rows.Add();
			r.Caption  = "MultiColumn";
			r.Editor   = new UITypeEditorControl(mcEditor, true);
			r.Style.MergeWith(cs);

			// show help
			_flex_SelChange(this, EventArgs.Empty);
		}

		// show some help
		string _help = null;
		void _flex_SelChange(object sender, System.EventArgs e)
		{
			if (_flex.Row > -1)
			{
				CellStyle cs = _flex.Rows[_flex.Row].Style;
				if (cs != null && cs.UserData.ToString() != _help)
				{
					_help = cs.UserData.ToString();
					_rtfHelp.BackColor = cs.BackColor;
					_rtfHelp.Text = "?";
					_rtfHelp.SelectAll();
					_rtfHelp.SelectedRtf = _rtfHelp.SelectedRtf.Replace("?", _help);
				}
			}
		}

		// trace events
		void _flex_BeforeEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			//Console.WriteLine("_flex_BeforeEdit {0} {1}", e.Row, e.Col);
		}
		void _flex_StartEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			//_flex.Editor = _flex.Cols[e.Col].UserData as Control;
			Console.WriteLine("_flex_StartEdit {0} {1}", e.Row, e.Col);
		}
		void _flex_SetupEditor(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			Console.WriteLine("_flex_SetupEditor {0} {1}", e.Row, e.Col);
		}
		void _flex_AfterEdit(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			Console.WriteLine("_flex_AfterEdit {0} {1}", e.Row, e.Col);
		}
		void _flex_CellButtonClick(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			MessageBox.Show(string.Format("_flex_CellButtonClick {0} {1}", e.Row, e.Col));
			Console.WriteLine("_flex_CellButtonClick {0} {1}", e.Row, e.Col);
		}
		void _flex_ComboCloseUp(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			Console.WriteLine("_flex_ComboCloseUp {0} {1}", e.Row, e.Col);
		}
		void _flex_ComboDropDown(object sender, C1.Win.FlexGrid.RowColEventArgs e)
		{
			Console.WriteLine("_flex_ComboDropDown {0} {1}", e.Row, e.Col);
		}
		void _flex_KeyDownEdit(object sender, C1.Win.FlexGrid.KeyEditEventArgs e)
		{
			//e.Handled = true;
			Console.WriteLine("_flex_KeyDownEdit {0} {1} {2}", e.Row, e.Col, e.KeyCode);
		}
		void _flex_KeyPressEdit(object sender, C1.Win.FlexGrid.KeyPressEditEventArgs e)
		{
			if (_chkSetHandled.Checked)
				e.Handled = true;
			Console.WriteLine("_flex_KeyPressEdit {0} {1} {2}", e.Row, e.Col, (int)e.KeyChar);
		}
		void _flex_KeyUpEdit(object sender, C1.Win.FlexGrid.KeyEditEventArgs e)
		{
			Console.WriteLine("_flex_KeyUpEdit {0} {1} {2}", e.Row, e.Col, e.KeyCode);
		}
		void _flex_ValidateEdit(object sender, C1.Win.FlexGrid.ValidateEditEventArgs e)
		{
			//e.Cancel = true;
			Console.WriteLine("_flex_ValidateEdit {0} {1}", e.Row, e.Col, e.Cancel);
		}
		void _flex_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			Console.WriteLine("_flex_KeyDown {0}", e.KeyCode);
		}
		void _flex_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			Console.WriteLine("_flex_KeyUp {0}", e.KeyCode);
		}
		void _flex_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			Console.WriteLine("_flex_KeyUp {0}", (int)e.KeyChar);
		}
		void _flex_ChangeEdit(object sender, System.EventArgs e)
		{
			Console.WriteLine("_flex_ChangeEdit {0}", _flex.Editor.Text);
		}

		// handle ComboBox custom grid editor
		void comboBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			// avoid beeps when user hits enter
			if (e.KeyChar == 13)
				e.Handled = true;
		}
		void comboBox1_Validated(object sender, System.EventArgs e)
		{
			// add new items to the list
			if (!comboBox1.Items.Contains(comboBox1.Text))
				comboBox1.Items.Add(comboBox1.Text);
		}
		void comboBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// required value
			if (comboBox1.Text.Length == 0)
			{
				e.Cancel = true;
				MessageBox.Show("Please select a non-empty string.");
			}
		}
		void textBox1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{  
			// avoid beeps when user hits enter
			if (e.KeyChar == 13)
				e.Handled = true;
		}
		void _flex_OwnerDrawCell(object sender, C1.Win.FlexGrid.OwnerDrawCellEventArgs e)
		{
			if (_flex[e.Row, e.Col] is Image)
				e.Image = _flex[e.Row, e.Col] as Image;
		}

		void _btnBorders_Click(object sender, System.EventArgs e)
		{
			int w = _flex.Styles.Normal.Border.Width;
			_flex.Styles.Normal.Border.Width = 6-w;
			_flex.Styles.Fixed.Border.Width  = 6-w;
		}
		void _chkShowButtons_CheckedChanged(object sender, System.EventArgs e)
		{
			_flex.ShowButtons = _chkShowButtons.Checked
				? ShowButtonsEnum.Always
				: ShowButtonsEnum.WithFocus;
		}

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
