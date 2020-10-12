using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Xml;
using System.IO;

using C1.Win.C1FlexGrid;

namespace TreeNode
{
	// to handle node dragging
	internal struct DRAGINFO
	{
		public bool		dragging;	// currently dragging
		public bool		checkDrag;	// currently checking mouse to start dragging
		public int		row;		// index of row being dragged
		public Point	mouseDown;	// mouse down position
	}

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox cmbSelect;
		private System.Windows.Forms.ComboBox cmbAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnMoveIn;
		private System.Windows.Forms.Button btnMoveDown;
		private System.Windows.Forms.Button btnMoveUp;
		private System.Windows.Forms.Button btnSortDescending;
		private System.Windows.Forms.Button btnSortAscending;
		private C1.Win.C1FlexGrid.C1FlexGrid flex;
		private System.Windows.Forms.Button btnMoveOut;
		private System.Windows.Forms.Button btnMoveFirst;
		private System.Windows.Forms.Button btnMoveLast;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private DRAGINFO m_DragInfo;
		private System.Windows.Forms.CheckBox chkDrag;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label5;	// info about current drag operation
		private const int DRAGTOL = 5;	// mouse movement before dragging starts

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMoveOut = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.cmbSelect = new System.Windows.Forms.ComboBox();
			this.chkDrag = new System.Windows.Forms.CheckBox();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.cmbAdd = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnMoveIn = new System.Windows.Forms.Button();
			this.btnMoveDown = new System.Windows.Forms.Button();
			this.btnMoveUp = new System.Windows.Forms.Button();
			this.btnMoveFirst = new System.Windows.Forms.Button();
			this.btnMoveLast = new System.Windows.Forms.Button();
			this.btnSortDescending = new System.Windows.Forms.Button();
			this.btnSortAscending = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.flex = new C1.Win.C1FlexGrid.C1FlexGrid();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.flex)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.AddRange(new System.Windows.Forms.Control[] {
																				 this.btnMoveOut,
																				 this.label1,
																				 this.cmbSelect,
																				 this.chkDrag,
																				 this.btnRefresh,
																				 this.cmbAdd,
																				 this.label2,
																				 this.label3,
																				 this.label4,
																				 this.btnMoveIn,
																				 this.btnMoveDown,
																				 this.btnMoveUp,
																				 this.btnMoveFirst,
																				 this.btnMoveLast,
																				 this.btnSortDescending,
																				 this.btnSortAscending,
																				 this.btnPrint,
																				 this.btnDelete,
																				 this.label5});
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(672, 56);
			this.panel1.TabIndex = 0;
			// 
			// btnMoveOut
			// 
			this.btnMoveOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMoveOut.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnMoveOut.Location = new System.Drawing.Point(156, 32);
			this.btnMoveOut.Name = "btnMoveOut";
			this.btnMoveOut.Size = new System.Drawing.Size(24, 20);
			this.btnMoveOut.TabIndex = 4;
			this.btnMoveOut.Text = "<";
			this.btnMoveOut.Click += new System.EventHandler(this.btnMove_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(460, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Add:";
			// 
			// cmbSelect
			// 
			this.cmbSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSelect.Items.AddRange(new object[] {
														   "Root",
														   "Parent",
														   "FirstChild",
														   "LastChild",
														   "FirstSibling",
														   "LastSibling",
														   "NextSibling",
														   "PreviousSibling"});
			this.cmbSelect.Location = new System.Drawing.Point(152, 10);
			this.cmbSelect.Name = "cmbSelect";
			this.cmbSelect.Size = new System.Drawing.Size(164, 21);
			this.cmbSelect.TabIndex = 2;
			this.cmbSelect.SelectionChangeCommitted += new System.EventHandler(this.cmbSelect_SelectionChangeCommitted);
			// 
			// chkDrag
			// 
			this.chkDrag.Checked = true;
			this.chkDrag.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkDrag.Location = new System.Drawing.Point(8, 36);
			this.chkDrag.Name = "chkDrag";
			this.chkDrag.Size = new System.Drawing.Size(80, 16);
			this.chkDrag.TabIndex = 1;
			this.chkDrag.Text = "&Dragging";
			// 
			// btnRefresh
			// 
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRefresh.Location = new System.Drawing.Point(8, 8);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(80, 20);
			this.btnRefresh.TabIndex = 0;
			this.btnRefresh.Text = "&Refresh";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// cmbAdd
			// 
			this.cmbAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAdd.Items.AddRange(new object[] {
														"FirstChild",
														"LastChild",
														"FirstSibling",
														"LastSibling",
														"NextSibling",
														"PreviousSibling"});
			this.cmbAdd.Location = new System.Drawing.Point(508, 10);
			this.cmbAdd.Name = "cmbAdd";
			this.cmbAdd.Size = new System.Drawing.Size(140, 21);
			this.cmbAdd.TabIndex = 2;
			this.cmbAdd.SelectionChangeCommitted += new System.EventHandler(this.cmbAdd_SelectionChangeCommitted);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(104, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "Select:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(104, 36);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 16);
			this.label3.TabIndex = 3;
			this.label3.Text = "Move";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(460, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 16);
			this.label4.TabIndex = 3;
			this.label4.Text = "Sort";
			// 
			// btnMoveIn
			// 
			this.btnMoveIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMoveIn.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnMoveIn.Location = new System.Drawing.Point(180, 32);
			this.btnMoveIn.Name = "btnMoveIn";
			this.btnMoveIn.Size = new System.Drawing.Size(24, 20);
			this.btnMoveIn.TabIndex = 4;
			this.btnMoveIn.Text = ">";
			this.btnMoveIn.Click += new System.EventHandler(this.btnMove_Click);
			// 
			// btnMoveDown
			// 
			this.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMoveDown.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnMoveDown.Location = new System.Drawing.Point(236, 32);
			this.btnMoveDown.Name = "btnMoveDown";
			this.btnMoveDown.Size = new System.Drawing.Size(24, 20);
			this.btnMoveDown.TabIndex = 4;
			this.btnMoveDown.Text = "v";
			this.btnMoveDown.Click += new System.EventHandler(this.btnMove_Click);
			// 
			// btnMoveUp
			// 
			this.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMoveUp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnMoveUp.Location = new System.Drawing.Point(212, 32);
			this.btnMoveUp.Name = "btnMoveUp";
			this.btnMoveUp.Size = new System.Drawing.Size(24, 20);
			this.btnMoveUp.TabIndex = 4;
			this.btnMoveUp.Text = "^";
			this.btnMoveUp.Click += new System.EventHandler(this.btnMove_Click);
			// 
			// btnMoveFirst
			// 
			this.btnMoveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMoveFirst.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnMoveFirst.Location = new System.Drawing.Point(264, 32);
			this.btnMoveFirst.Name = "btnMoveFirst";
			this.btnMoveFirst.Size = new System.Drawing.Size(24, 20);
			this.btnMoveFirst.TabIndex = 4;
			this.btnMoveFirst.Text = "^^";
			this.btnMoveFirst.Click += new System.EventHandler(this.btnMove_Click);
			// 
			// btnMoveLast
			// 
			this.btnMoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnMoveLast.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnMoveLast.Location = new System.Drawing.Point(288, 32);
			this.btnMoveLast.Name = "btnMoveLast";
			this.btnMoveLast.Size = new System.Drawing.Size(28, 20);
			this.btnMoveLast.TabIndex = 4;
			this.btnMoveLast.Text = "vv";
			this.btnMoveLast.Click += new System.EventHandler(this.btnMove_Click);
			// 
			// btnSortDescending
			// 
			this.btnSortDescending.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSortDescending.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnSortDescending.Location = new System.Drawing.Point(536, 32);
			this.btnSortDescending.Name = "btnSortDescending";
			this.btnSortDescending.Size = new System.Drawing.Size(24, 20);
			this.btnSortDescending.TabIndex = 4;
			this.btnSortDescending.Text = "v";
			this.btnSortDescending.Click += new System.EventHandler(this.btnSort_Click);
			// 
			// btnSortAscending
			// 
			this.btnSortAscending.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSortAscending.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnSortAscending.Location = new System.Drawing.Point(512, 32);
			this.btnSortAscending.Name = "btnSortAscending";
			this.btnSortAscending.Size = new System.Drawing.Size(24, 20);
			this.btnSortAscending.TabIndex = 4;
			this.btnSortAscending.Text = "^";
			this.btnSortAscending.Click += new System.EventHandler(this.btnSort_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnPrint.Location = new System.Drawing.Point(568, 32);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(80, 20);
			this.btnPrint.TabIndex = 0;
			this.btnPrint.Text = "&Print";
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// flex
			// 
			this.flex.ColumnInfo = "10,1,0,0,0,75,Columns:";
			this.flex.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flex.Location = new System.Drawing.Point(0, 56);
			this.flex.Name = "flex";
			this.flex.Rows.DefaultSize = 17;
			this.flex.Size = new System.Drawing.Size(672, 301);
			this.flex.StyleInfo = @"Normal{Font:Microsoft Sans Serif, 8.25pt;}	Alternate{}	Fixed{BackColor:Control;ForeColor:ControlText;Border:Flat,1,ControlDark,Both;}	Highlight{BackColor:Highlight;ForeColor:HighlightText;}	Focus{}	Editor{}	Search{BackColor:Highlight;ForeColor:HighlightText;}	Frozen{BackColor:LightBlue;}	NewRow{}	EmptyArea{BackColor:AppWorkspace;Border:Flat,1,ControlDarkDark,Both;}	GrandTotal{BackColor:Black;ForeColor:White;}	Subtotal0{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal1{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal2{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal3{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal4{BackColor:ControlDarkDark;ForeColor:White;}	Subtotal5{BackColor:ControlDarkDark;ForeColor:White;}	";
			this.flex.TabIndex = 1;
			this.flex.Tree.LineColor = System.Drawing.Color.FromArgb(((System.Byte)(128)), ((System.Byte)(128)), ((System.Byte)(128)));
			this.flex.Tree.NodeImageCollapsed = ((System.Drawing.Bitmap)(resources.GetObject("flex.Tree.NodeImageCollapsed")));
			this.flex.Tree.NodeImageExpanded = ((System.Drawing.Bitmap)(resources.GetObject("flex.Tree.NodeImageExpanded")));
			this.flex.MouseDown += new System.Windows.Forms.MouseEventHandler(this.flex_MouseDown);
			this.flex.MouseMove += new System.Windows.Forms.MouseEventHandler(this.flex_MouseMove);
			this.flex.MouseUp += new System.Windows.Forms.MouseEventHandler(this.flex_MouseUp);
			// 
			// btnDelete
			// 
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnDelete.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.btnDelete.Location = new System.Drawing.Point(420, 8);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(24, 20);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "x";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(368, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 16);
			this.label5.TabIndex = 3;
			this.label5.Text = "Delete:";
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(672, 357);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.flex,
																		  this.panel1});
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "C1FlexGrid: Tree Handling with the Node Object";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.flex)).EndInit();
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

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// initialize grid

			// layout
			flex.Rows.Count = 1;
			flex.Cols.Count = 2;
			flex.Cols.Fixed = 0;
			flex.ExtendLastCol = true;
			flex[0,0] = "Tag";
			flex[0,1] = "Value";
                
			// styles
			CellStyle cs = flex.Styles.Normal;
			cs.Border.Direction = BorderDirEnum.Vertical;
			cs.TextAlign = TextAlignEnum.LeftCenter;
			cs.WordWrap = false;
			cs = flex.Styles.Add("Data");
			cs.BackColor = SystemColors.Info;
			cs.ForeColor = SystemColors.InfoText;
			cs = flex.Styles.Add("SourceNode");
			cs.BackColor = Color.Yellow;
			cs.Font = new Font(flex.Font, FontStyle.Bold);

			// outline tree
			flex.Tree.Column = 0;
			flex.Tree.Style = TreeStyleFlags.Simple;
			flex.AllowMerging = AllowMergingEnum.Nodes;
        
			// other
			flex.AllowResizing = AllowResizingEnum.Columns;
			flex.SelectionMode = SelectionModeEnum.Cell;
    
			// read XML document into the grid
			PopulateGrid();
			flex.AutoSizeCols();
		}

		private void PopulateGrid()
		{
			// build filename
			string path = Path.GetDirectoryName(Application.ExecutablePath);
			int i = path.LastIndexOf(@"\bin\");
			if (i > -1) path = path.Substring(0, i);
			string fileName = path + @"\test.xml";

			// load xml document
			XmlDocument xdoc = new XmlDocument();
			xdoc.Load(fileName);

			// copy document to grid
	        flex.Rows.Count = 1;
	        GetXMLData(xdoc.ChildNodes[1], 0);
		}
		private void GetXMLData(XmlNode node, int level)
		{
			// skip comment nodes
			if (node.NodeType == XmlNodeType.Comment)
				return;

			// add new row for this node
			int row = flex.Rows.Count;
			flex.Rows.Add();
			flex[row,0] = node.Name;
			if (node.ChildNodes.Count == 1)
			{
				flex[row,1] = node.InnerText;
				flex.SetCellStyle(row, 1, flex.Styles["Data"]);
			}

			// make new row a node
			flex.Rows[row].IsNode = true;
			flex.Rows[row].Node.Level = level;

			// if this node has children, get them as well
			if (node.ChildNodes.Count > 1)
			{
				// recurse to get children
				foreach (XmlNode child in node.ChildNodes)
					GetXMLData(child, level+1);
			}
		}

		// refresh the grid with info from XML file
		private void btnRefresh_Click(object sender, System.EventArgs e)
		{
			PopulateGrid();
		}

		// handle select combo
		private void cmbSelect_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			if (flex.Rows.Count <= 1)
				return;
			// get current row//s node
			Node nd = flex.Rows[flex.Row].Node;

			// get relative node selected by the user
			nd = nd.GetNode((NodeTypeEnum)cmbSelect.SelectedIndex);
    
			// if failed, show message
			if (nd == null)
			{
				MessageBox.Show("Can//t find " + cmbSelect.Text + " for this node.");
				return;
			}
    
			// select node and make sure it//s visible
			nd.Select();
			nd.EnsureVisible();
			flex.Focus();
		}

		// handle add combo
		private void cmbAdd_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			if (flex.Rows.Count > 1)
			{
				// get current row//s node
				Node nd = flex.Rows[flex.Row].Node;

				// add relative as requested by user
				// (could be a child or a sibling)
				nd.AddNode((NodeTypeEnum)(cmbAdd.SelectedIndex + 2), cmbAdd.Text);
			}

			flex.Focus();
		}

		// move selected node to a new position
		private void btnMove_Click(object sender, System.EventArgs e)
		{
			if (flex.Rows.Count <= 1)
				return;
			// get current row//s node
			Node nd = flex.Rows[flex.Row].Node;
    
			// apply movement selected by the user
			// (this will move the selected node)
			if      (sender == btnMoveOut)   nd.Move(NodeMoveEnum.Out);
			else if (sender == btnMoveIn)    nd.Move(NodeMoveEnum.In);
			else if (sender == btnMoveUp)    nd.Move(NodeMoveEnum.Up);
			else if (sender == btnMoveDown)  nd.Move(NodeMoveEnum.Down);
			else if (sender == btnMoveFirst) nd.Move(NodeMoveEnum.First);
			else if (sender == btnMoveLast)  nd.Move(NodeMoveEnum.Last);
    
			// make sure the node is still visible
			nd.EnsureVisible();
			flex.Focus();
		}

		// sort selected node
		private void btnSort_Click(object sender, System.EventArgs e)
		{
			if (flex.Rows.Count <= 1)
				return;
			// get current node
			Node nd = flex.Rows[flex.Row].Node;
    
			// apply sorting selected by the user
			// (this will sort the selected node's children)
			if (sender == btnSortAscending)
				nd.Sort(SortFlags.Ascending);
			else
				nd.Sort(SortFlags.Descending);

			// done
			flex.Focus();
		}

		// delete selected node (and it's children)
		private void btnDelete_Click(object sender, System.EventArgs e)
		{
            // get current node
            Node nd = null;
            if (0 < flex.Rows.Count && 0 <= flex.Row && flex.Row < flex.Rows.Count)
            {
                nd = flex.Rows[flex.Row].Node;
            }

            if (nd != null)
            {
#if EASYWAY
			// easy way:
			nd.RemoveNode();
#else
                // slightly harder way:
                CellRange rg = nd.GetCellRange();
                flex.Rows.RemoveRange(rg.TopRow, rg.BottomRow - rg.TopRow + 1);
#endif
                // done
                flex.Focus();
            }
		}

		// start dragging node
		private void flex_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			m_DragInfo.checkDrag = false;

			// left button, no shift: start tracking mouse to drag
			if (e.Button != MouseButtons.Left) return;
			if (!chkDrag.Checked || m_DragInfo.dragging) return;
			if (flex.MouseRow < flex.Rows.Fixed || flex.MouseCol != 0) return;

			// save current row and mouse position
			m_DragInfo.row = flex.Row;
			m_DragInfo.mouseDown = new Point(e.X, e.Y);
            
			// start checking
			m_DragInfo.checkDrag = true;
		}

		// drag node
		private void flex_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// if checking and the user moved past our tolerance, start dragging
			if (!m_DragInfo.checkDrag || e.Button != MouseButtons.Left) return;
			if (Math.Abs(e.X - m_DragInfo.mouseDown.X) +
				Math.Abs(e.Y - m_DragInfo.mouseDown.Y) <= DRAGTOL) return;

			// update flags
			m_DragInfo.dragging = true;
            
			// set cursor and highlight node
			CellStyle cs = flex.Styles["SourceNode"];
			flex.Cursor = Cursors.NoMove2D;
			flex.SetCellStyle(m_DragInfo.row, 0, cs);

			// check whether we can drop here
			Cursor c = (NoDropHere())? Cursors.No: Cursors.NoMove2D;
			if (c != flex.Cursor) flex.Cursor = c;
		}
		private bool NoDropHere()
		{
			if (flex.MouseRow < flex.Rows.Fixed) return true;
			if (flex.MouseCol < flex.Cols.Fixed) return true;
			if (flex.GetDataDisplay(flex.Row,0) == "SKU") return true;
			return false;
		}

		// finish dragging node
		private void flex_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			// we're not checking until the mouse goes down again
			m_DragInfo.checkDrag = false;

			// not dragging? we're done
			if (!m_DragInfo.dragging) return;

			// stop dragging
			m_DragInfo.dragging = false;
			flex.SetCellStyle(m_DragInfo.row, 0, (CellStyle)null);
			flex.Cursor = Cursors.Default;
		        
			// test whether the drop is allowed
			if (NoDropHere()) return;

			// move node into new parent node
			Node ndSrc = flex.Rows[m_DragInfo.row].Node;
			Node ndDst = flex.Rows[flex.Row].Node;
			ndSrc.Move(NodeMoveEnum.ChildOf, ndDst);
			ndSrc.Select();
		}
		
		// print the tree
		private void btnPrint_Click(object sender, System.EventArgs e)
		{
			flex.PrintGrid("FlexTree", PrintGridFlags.ShowPreviewDialog);
		}
	}
}
