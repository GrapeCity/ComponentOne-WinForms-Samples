using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using C1.Win.FlexGrid;

namespace ControlExplorer.FlexGrid
{
    public partial class TreeView : C1DemoForm
    {
       
        public TreeView()
        {
            InitializeComponent();
            AddProperty("Style", flex.Tree);
            AddProperty("LineStyle", flex.Tree);
            AddProperty("FocusRect", flex);
            //Custom demo properties
            AddProperty("AllowDragging", this);
            AddProperty("UseCheckBoxes", this);
        }

        private void NewTreeView_Load(object sender, EventArgs e)
        {
            // initialize grid

            // layout
            flex.Rows.Count = 1;
            flex.Cols.Count = 2;
            flex.Cols.Fixed = 0;
            flex[0, 0] = "File";
            flex[0, 1] = "Modified Date";
            flex.Cols[1].Format = "c";

            // styles
            CellStyle cs = flex.Styles.Normal;
            cs.Border.Direction = BorderDirEnum.Vertical;
            cs.TextAlign = TextAlignEnum.LeftCenter;
            cs.WordWrap = false;
            cs = flex.Styles.Add("Data");
            //cs.BackColor = Color.FromArgb(234, 236, 245);
            cs.Border.Direction = BorderDirEnum.Horizontal;
            //cs.ForeColor = SystemColors.InfoText;
            cs = flex.Styles.Add("SourceNode");
            //cs.BackColor = Color.FromArgb(255, 213, 141);
            cs.Font = new Font(flex.Font, FontStyle.Bold);

            // outline tree
            flex.Tree.Column = 0;
            flex.Tree.Style = TreeStyleFlags.Simple;
            flex.Tree.LineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            flex.AllowMerging = AllowMergingEnum.Nodes;

            // other
            flex.AllowResizing = AllowResizingEnum.Columns;
            flex.SelectionMode = SelectionModeEnum.Cell;
            flex.HighLight = HighLightEnum.Always;
            flex.FocusRect = FocusRectEnum.Solid;
            flex.AllowSorting = AllowSortingEnum.None;
            _allowDragging = true;

            // read XML document into the grid
            PopulateGrid();
            UpdateIcons();
            flex.AutoSizeCols();
        }

        private void PopulateGrid()
        {

            // load xml document
            XmlDocument xdoc = new XmlDocument();
            xdoc.LoadXml(ControlExplorer.Properties.Resources.TreeGroups);

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
            if (node.Name.Equals("Property"))
                flex[row, 0] = node.Attributes["Name"].Value;
            else
                flex[row, 0] = node.Name;
            if (node.ChildNodes.Count == 1)
            {
                flex[row, 1] = node.InnerText;
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
                    GetXMLData(child, level + 1);
            }
        }

        private void c1CommandHolder1_CommandClick(object sender, C1.Win.Command.CommandClickEventArgs e)
        {
            if (e.Command == c1CommandMoveUp)
            {
                MoveNode("up");
            }
            else if (e.Command == c1CommandMoveLeft)
            {
                MoveNode("out");
            }
            else if (e.Command == c1CommandMoveRight)
            {
                MoveNode("in");
            }
            else if (e.Command == c1CommandMoveDown)
            {
                MoveNode("down");
            }
            else if (e.Command == c1CommandAppendItem)
            {
                AddNode("append");
            }
            else if (e.Command == c1CommandInsertItem)
            {
                AddNode("insert");
            }
            else if (e.Command == c1CommandInsertBelow)
            {
                AddNode("insertbelow");
            }
            else if (e.Command == c1CommandAddChild)
            {
                AddNode("child");
            }
            else if (e.Command == c1CommandSortAsc)
            {
                SortNodes(false);
            }
            else if (e.Command == c1CommandSortDesc)
            {
                SortNodes(true);
            }
            else if (e.Command == c1CommandExpand)
            {
                ExpandNodes(true);
            }
            else if (e.Command == c1CommandCollapse)
            {
                ExpandNodes(false);
            }
            else if (e.Command == c1CommandDelete)
            {
                DeleteNode();
            }
            else if (e.Command == c1CommandPrint)
            {
                PrintTreeView();
            }
            UpdateIcons();
        }

        private void MoveNode(string dir)
        {
            if (flex.Row < 0)
                return;

            // get current row//s node
            Node nd = flex.Rows[flex.Row].Node;

            // apply movement selected by the user
            // (this will move the selected node)
            if (dir.Equals("out")) nd.Move(NodeMoveEnum.Out);
            else if (dir.Equals("in")) nd.Move(NodeMoveEnum.In);
            else if (dir.Equals("up")) nd.Move(NodeMoveEnum.Up);
            else if (dir.Equals("down")) nd.Move(NodeMoveEnum.Down);
            //else if (dir.Equals("first")) nd.Move(NodeMoveEnum.First);
            //else if (dir.Equals("last")) nd.Move(NodeMoveEnum.Last);

            // make sure the node is still visible
            nd.EnsureVisible();
            flex.Focus();
        }

        private void AddNode(string type)
        {
            //check if no node selected
            if (flex.Row < 0)
                return;


            // get current row//s node
            Node nd = flex.Rows[flex.Row].Node;
            Node newNode;
            // add relative as requested by user
            // (could be a child or a sibling)
            if (type.Equals("insert")) newNode = nd.AddNode(NodeTypeEnum.PreviousSibling, "New Item");
            else if (type.Equals("insertbelow")) newNode = nd.AddNode(NodeTypeEnum.NextSibling, "New Item");
            else if (type.Equals("append")) newNode = nd.AddNode(NodeTypeEnum.LastSibling, "New Item");
            else if (type.Equals("child")) newNode = nd.AddNode(NodeTypeEnum.LastChild, "New Item");
            else newNode = nd.AddNode(NodeTypeEnum.Root, "New Item");
            newNode.Select();
            flex.StartEditing();
        }

        private void DeleteNode()
        {
            if (flex.Row < 2)
                return;

            // get current node
            Node nd = flex.Rows[flex.Row].Node;

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

        private void SortNodes(bool desc)
        {
            if (flex.Row < 0)
                return;

            // get current node
            Node nd = flex.Rows[flex.Row].Node;

            // apply sorting selected by the user
            // (this will sort the selected node's children)
            if(desc)
                nd.Sort(SortFlags.Descending);
            else
                nd.Sort(SortFlags.Ascending);

            // done
            flex.Focus();
        }

        private void ExpandNodes(bool expand)
        {
            //cycle through all rows collapsing or expanding nodes
            for (int i = 1; i < flex.Rows.Count; i++)
            {
                if (flex.Rows[i].IsNode)
                    flex.Rows[i].Node.Collapsed = !expand;
            }

            // done
            flex.Focus();
        }

        private void PrintTreeView()
        {
            flex.PrintGrid("FlexTree", PrintGridFlags.ShowPreviewDialog);
        }

        //Dragging code
        private DRAGINFO m_DragInfo;
        private bool _allowDragging; //form property
        private const int DRAGTOL = 5;	// mouse movement before dragging starts

        public bool AllowDragging
        {
            get
            {
                return this._allowDragging;
            }
            set
            {
                this._allowDragging = value;
            }
        }

        private void flex_MouseDown(object sender, MouseEventArgs e)
        {
            m_DragInfo.checkDrag = false;

            // left button, no shift: start tracking mouse to drag
            if (e.Button != MouseButtons.Left) return;
            if (!this._allowDragging || m_DragInfo.dragging) return;
            if (flex.MouseRow < flex.Rows.Fixed || flex.MouseCol != 0) return;

            // save current row and mouse position
            m_DragInfo.row = flex.Row;
            m_DragInfo.mouseDown = new Point(e.X, e.Y);

            // start checking
            m_DragInfo.checkDrag = true;
        }

        private void flex_MouseMove(object sender, MouseEventArgs e)
        {
            // if checking and the user moved past our tolerance, start dragging
            if (!m_DragInfo.checkDrag || e.Button != MouseButtons.Left) return;
            if (Math.Abs(e.X - m_DragInfo.mouseDown.X) +
                Math.Abs(e.Y - m_DragInfo.mouseDown.Y) <= DRAGTOL) return;

            // update flags
            m_DragInfo.dragging = true;

            // set cursor and highlight node
            CellStyle cs = flex.Styles["SourceNode"];
            flex.Cursor = Cursors.PanSouth;
            flex.SetCellStyle(m_DragInfo.row, 0, cs);

            // check whether we can drop here
            Cursor c = (NoDropHere()) ? Cursors.No : Cursors.PanSouth;
            if (c != flex.Cursor) flex.Cursor = c;
        }

        private bool NoDropHere()
        {
            if (flex.MouseRow < flex.Rows.Fixed) return true;
            if (flex.MouseCol < flex.Cols.Fixed) return true;
            if (flex.GetDataDisplay(flex.Row, 0) == "SKU") return true;
            if (flex.Rows[flex.MouseRow].Node.Children == 0) return true;
            return false;
        }

        private void flex_MouseUp(object sender, MouseEventArgs e)
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
            UpdateIcons();
        }

        private void flex_DoubleClick(object sender, EventArgs e)
        {
            if (flex.Row < 1 || flex.MouseCol < 0)
                return;

            //flex.StartEditing(flex.Row, flex.MouseCol);
        }

        private void UpdateIcons()
        {
            for (int i = 1; i < flex.Rows.Count; i++)
            {
                if (flex.Rows[i].Node.Children < 1)
                {
                    if (_checkBoxes)
                    {
                        // set the check box
                        flex.SetCellCheck(i, 0, CheckEnum.Checked);
                    }
                    else
                    {
                        flex.SetCellCheck(i, 0, CheckEnum.None);
                        flex.SetCellImage(i, 0, imageList1.Images["Notepad1.png"]);
                    }
                }
                else
                    flex.SetCellImage(i, 0, imageList1.Images["Folder_closed.gif"]);
            }
        }

        private bool _checkBoxes = false;
        public bool UseCheckBoxes
        {
            get { return _checkBoxes; }
            set 
            { 
                _checkBoxes = value;
                UpdateIcons();
            }
        }

    }

    // to handle node dragging
    internal struct DRAGINFO
    {
        public bool dragging;	// currently dragging
        public bool checkDrag;	// currently checking mouse to start dragging
        public int row;		// index of row being dragged
        public Point mouseDown;	// mouse down position
    }
}
